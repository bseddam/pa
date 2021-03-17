using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Data.SqlClient;

/// <summary>
/// Summary description for UserManagement
/// </summary>
namespace User
{
    public class UserManagement
    {
        public static string folderPath;

        public static int id
        {
            get { return (int)HttpContext.Current.Session["ID"]; }
            set { HttpContext.Current.Session["ID"] = value; }
        }

        public static bool IsAuthenticated()
        {
            return (HttpContext.Current.Session["ID"] != null);
        }

        public static void logOut()
        {
            HttpContext.Current.Session.Abandon();
        }

        public static SqlConnection myConnection()
        {
            string conStr = ConfigurationManager.ConnectionStrings["Work_dbConnectionString"].ConnectionString;
            return new SqlConnection(conStr);
        }

        public static SqlCommand MyCommand(string userName, string password)
        {
            SqlConnection sqlcon = myConnection();
            string strcommand = "Select UserID from Users Where (UserName=@UserName and Pwd=@PasswordID ) ";
            SqlCommand command = new SqlCommand(strcommand, sqlcon);
            command.Parameters.Add("@UserName", SqlDbType.NVarChar);
            command.Parameters.Add(@"PasswordID", SqlDbType.NVarChar);
            command.Parameters[0].Value = userName;
            command.Parameters[1].Value = password;
            return command;
        }

        public static bool CanAuthenticate(string userName, string password)
        {
            SqlCommand cmd = MyCommand(userName, password);
            cmd.Connection.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            bool canAuthenticate = rdr.Read();
            cmd.Connection.Close();
            return canAuthenticate;
        }

        public static int AuthenticateUser(string userName, string password)
        {
            if (CanAuthenticate(userName, password))
            {
                SqlCommand cmd = MyCommand(userName, password);
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    id = Convert.ToInt32(reader[0].ToString());
                    cmd.Connection.Close();
                    return id;
                }
                else
                {
                    cmd.Connection.Close();
                    return -1;
                }
                
            }
            else
            {
                return -1;
            }
        }

        public static string GetCurrentUserName()
        {
            if (IsAuthenticated())
            {
                string commandText = "SELECT UserName From Users Where UserID = @UserID" ;
                SqlConnection con = myConnection();
                SqlCommand command = new SqlCommand(commandText, con);
                command.Parameters.Add("UserID", SqlDbType.BigInt);
                command.Parameters["UserID"].Value = id.ToString();
                con.Open();
                return command.ExecuteScalar().ToString();
                con.Close();
            }
            else
            {
                return string.Empty;
            }
        }

        public static bool PasswordChanged(string oldPassword, string newPassworrd)
        {
            string commandText = "Update Users Set Pwd = @NewPassword Where (UserID = @UserID) AND (Pwd = @OldPassword) ";
            SqlConnection con = myConnection();
            SqlCommand command = new SqlCommand(commandText, con);

            command.Parameters.Add("NewPassword", SqlDbType.NVarChar, 10);
            command.Parameters["NewPassword"].Value = newPassworrd;

            command.Parameters.Add("UserID", SqlDbType.BigInt);
            command.Parameters["UserID"].Value = id.ToString();

            command.Parameters.Add("OldPassword", SqlDbType.NVarChar, 10);
            command.Parameters["OldPassword"].Value = oldPassword;

            command.Connection.Open();
            int count = command.ExecuteNonQuery();
            command.Connection.Close();
            
            //newPassworrd.GetHashCode().ToString();
            return (count == 1);
        }

        public static bool IsAdmin()
        {
            string commandText = "Select ClassID from Users Where UserID=@UserID ";
            SqlConnection con = myConnection();
            SqlCommand command = new SqlCommand(commandText, con);

            command.Parameters.Add("UserID", SqlDbType.BigInt);
            command.Parameters["UserID"].Value = id.ToString();

            command.Connection.Open();
            int classID;
            try
            {
                classID = Convert.ToInt32(command.ExecuteScalar().ToString());
                return (classID == 100);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static string GetRespUserNames(int TaskID)
        {
            string commandText = @"Select U.UserName From TaskResponsibility TR INNER JOIN Users U ON U.UserID = TR.UserID
                                    Where TR.TaskID = @taskID order by Ordering";
            SqlConnection con = myConnection();
            SqlCommand command = new SqlCommand(commandText,con);

            command.Parameters.Add("taskID",SqlDbType.BigInt);
            command.Parameters["taskID"].Value = TaskID;

            command.Connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            string userNames = string.Empty;
            while (reader.Read())
            {
                userNames = userNames + reader[0].ToString() + ", ";
            }

            command.Connection.Close();

            if (userNames.Length > 0)
            {
                userNames = userNames.Remove(userNames.Length-2);
            }
            return userNames;
        }


        public UserManagement()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}