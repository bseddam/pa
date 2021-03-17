using System;
using System.Collections.Generic;
using System.Data;
using System.Net;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class adminpanel_adminMasterPage : System.Web.UI.MasterPage
{
    Class2 klas = new Class2();
    protected void Page_Load(object sender, EventArgs e)
    {
        Page.Response.Cache.SetCacheability(HttpCacheability.NoCache);
        if (!Page.IsPostBack)
        {

            try
            {
                if (Session["UserID1"] == null || Session["passvord1"] == null)
                {
                    Response.Redirect("~/Default.aspx");
                }
                Session["UserID"] = null;
            }
            catch (Exception)
            {
              //  Response.Redirect("admingiris.aspx");
            }
            HttpRequest request = base.Request;
            string useraddress = request.UserHostAddress;
            if (useraddress == "192.168.150.17")
            {
                pnladm.Visible = false;
                LinkButton1.Visible = true;
            }
            else if (useraddress == "192.168.150.77")
            {

                pnladm.Visible = false;
                LinkButton1.Visible = true;
            }

        }
       
           
        
       
    }
    protected void btncixis_Click(object sender, EventArgs e)
    {
        FormsAuthentication.SignOut();
        Session.Abandon();
        Session.Clear();
        Session.RemoveAll();
        string localip = "?";
        IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
        foreach (IPAddress ip in host.AddressList)
        {
            if (ip.AddressFamily.ToString() == "InterNetwork")
            {
                localip = ip.ToString();
            }
        }
        if (localip == "192.168.150.17")
        {
            Response.Redirect("~/Default.aspx");
        }
        else if (localip == "192.168.150.77")
        {

            Response.Redirect("~/Default.aspx");
        }
        Response.Redirect("~/Default.aspx");
    }



    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Default.aspx");
       
    }
}
