using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Data.SqlClient;

public partial class adminpanel_admingiris : System.Web.UI.Page
{
    Class2 klas = new Class2();
    seo klass = new seo();
  
    protected void Page_Load(object sender, EventArgs e)
    {
        txtparol.Focus();
        HttpRequest request = base.Request;
        string useraddress = request.UserHostAddress;
        if (useraddress == "192.168.150.17")
        {
            Session["UserID1"] = "000";
            Session["passvord1"] = "000";
            Response.Redirect("Hesabattehlili.aspx", true);
        }
        else if (useraddress == "192.168.150.77")
        {
            Session["UserID1"] = "000";
            Session["passvord1"] = "000";
            Response.Redirect("Hesabattehlili.aspx", true);
        }



        Page.Response.Cache.SetCacheability(HttpCacheability.NoCache);
        if (Page.IsPostBack == false)
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            Session.Clear();
        }
    }
    protected void btnGiris_Click(object sender, EventArgs e)
    {
        //parametr ile
        //string sqlcumle = "Select * from Users Where passvord=@passvord and status_users=0";
        //SqlConnection baglan = klas.baglan();
        //SqlDataAdapter dap = new SqlDataAdapter(sqlcumle, baglan);
        //dap.SelectCommand.Parameters.AddWithValue("@passvord", txtparol.Text);
        //DataTable dt = new DataTable();
        //try
        //{
        //    dap.Fill(dt);
        //}
        //catch (SqlException ex)
        //{
        //    throw new Exception(ex.Message + "(" + sqlcumle + ")");
        //}
        //dap.Dispose();
        //baglan.Close();
        //baglan.Dispose();
        //if (dt.Rows.Count != 0)
        //{
        //    Response.Write("aaa="+dt.Rows[0]["UserID"].ToString());
        //}
        DataRow drGiris1 = klas.GetDataRow("Select * from Users Where passvord='" + seo.temizle(txtparol.Text) + "' and status_users=0");
        if (drGiris1 != null)
        {
            Session["UserID"] = drGiris1["UserID"].ToString();
            Session["passvord"] = drGiris1["passvord"].ToString();
            Response.Redirect("~/kurator/Ezamiyyenintesviri.aspx?islem=Default", true);
        }
        else
            lblBilgi.Text = "Şifrə yalnışdır!";


        DataRow drGiris = klas.GetDataRow("Select * from Users Where passvord='" + seo.temizle(txtparol.Text) + "' and status_users=1");
        if (drGiris != null)
        {
            Session["UserID1"] = drGiris["UserID"].ToString();
            Session["passvord1"] = drGiris["passvord"].ToString();
            Response.Redirect("Yeniezamiyye.aspx?islem1=g2r2i1&islem=geri", true);
        }
        else
            lblBilgi.Text = "Şifrə yalnışdır!";
    }
}