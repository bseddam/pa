using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data;

using System.Security.Cryptography;

public class MyDB
{
    //public SqlConnection sqlCon;
    public SqlConnection sqlCon;

    public MyDB(string DB_NAME)
    {
        ConnectToDB(DB_NAME);
    }




    public static string GetQuote(string str)
    {
        if (str == null) return null;
        return str.Replace("'", "''");
    }

    public SqlCommand GetCommand(string strSQL)
    {
        //SqlCommand sCmd = new SqlCommand(strSQL, sqlCon);
        SqlCommand sCmd = new SqlCommand(strSQL, sqlCon);
        return sCmd;
    }

    public DataTable GetTable(string strSQL)
    {
        SqlCommand sCmd = new SqlCommand(strSQL, sqlCon);

        SqlDataAdapter sda = new SqlDataAdapter(sCmd);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        return dt;
    }

    public SqlDataReader GetReader(string strSQL)
    {
        SqlDataReader odr;
        try
        {
            odr = GetCommand(strSQL).ExecuteReader();
        }
        catch
        {
            return null;
        }
        return odr;

    }

    public object GetScalarResult(string strSQL)
    {
        object odr;
        try
        {
            odr = GetCommand(strSQL).ExecuteScalar();
        }
        catch
        {
            return null;
        }
        return odr;

    }

    private void ConnectToDB(string DB_NAME)
    {
        try
        {
            if (sqlCon != null) return;
            string DBS_NAME = @"."; //STAT2
            string strConnection = "Data Source=" + DBS_NAME + ";Initial Catalog=" + DB_NAME + ";Integrated Security=True";
            sqlCon = new SqlConnection(strConnection);
            if (sqlCon.State != ConnectionState.Open) sqlCon.Open();
        }
        catch
        {

        }
    }

    public void CloseDB()
    {
        if (sqlCon == null) return;
        sqlCon.Close();
        sqlCon.Dispose();
    }

    public enum ValidationCode
    {
        LoginFailed = 1,
        LoginSucceeded = 2,
        ConnectionFailed = 3,
        UnspecifiedFailure = 4,
        LoginCreated = 5,
        PasswordChanged = 6
    }

    public static string EncodePassword(string originalPassword)
    {

        ////Encrypt the password
        //MD5CryptoServiceProvider md5Hasher = new MD5CryptoServiceProvider();
        //byte[] hashedBytes;
        //UTF8Encoding encoder = new UTF8Encoding();
        //hashedBytes = md5Hasher.ComputeHash(encoder.GetBytes(originalPassword));

        Byte[] originalBytes;
        Byte[] encodedBytes;
        MD5 md5;
        // Create MD5 Cryptography Service Provider.
        md5 = new MD5CryptoServiceProvider();
        originalBytes = ASCIIEncoding.Default.GetBytes(originalPassword);
        encodedBytes = md5.ComputeHash(originalBytes);
        return BitConverter.ToString(encodedBytes);
    }

    public static byte[] EncodePasswordByte(string originalPassword)
    {
        Byte[] originalBytes;
        Byte[] encodedBytes;
        MD5 md5;
        // Create MD5 Cryptography Service Provider.
        md5 = new MD5CryptoServiceProvider();
        originalBytes = ASCIIEncoding.Default.GetBytes(originalPassword);
        encodedBytes = md5.ComputeHash(originalBytes);
        return encodedBytes;
    }
}

