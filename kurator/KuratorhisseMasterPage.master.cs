using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class adminpanel_Kuratorhisse : System.Web.UI.MasterPage
{
    Class2 klas = new Class2(); string BusinessTripID; string islem;
    protected void Page_Load(object sender, EventArgs e)
    {
        Page.Response.Cache.SetCacheability(HttpCacheability.NoCache);
        if (!Page.IsPostBack)
        {
            try
            {
                if (Session["UserID1"] == null)
                {
                    lbadmin.Visible = false;
                    if (Session["UserID"] == null || Session["passvord"] == null)
                    {
                        Response.Redirect("~/adminpanel/admingiris.aspx");
                    }
                    DataRow drGiris1 = klas.GetDataRow("Select * from Users Where UserID='" + Session["UserID"].ToString() + "'and passvord='" + Session["passvord"].ToString() + "' and status_users=0");
                    if (drGiris1 == null)
                    {
                        Response.Redirect("~/adminpanel/admingiris.aspx");
                    }
                }
                else
                {
                    Session["UserID2"] = Session["UserID1"].ToString();
                    Session["UserID1"] = "1";
                }

                string userid = Session["UserID"].ToString();
                DataRow drGiris = klas.GetDataRow("Select * from Users Where UserID=" + userid);
                if (drGiris != null)
                {
                    lbladsoy.Text = drGiris["Name"].ToString() + " " + drGiris["Sname"].ToString();
                    lblvezife.Text = drGiris["Duty"].ToString();
                }
                islem = Request.QueryString["islem"];
                BusinessTripID = Request.QueryString["BusinessTripID"];
                if (BusinessTripID != null && islem != "sil")
                {
                    DataRow dryoxla = klas.GetDataRow(@"SELECT     dbo.Users.UserID, dbo.Fbusiness_trip.BusinessTripID 
FROM         dbo.Fbusiness_trip INNER JOIN  dbo.Users ON dbo.Fbusiness_trip.UserID = dbo.Users.UserID 
WHERE     (dbo.Fbusiness_trip.UserID = " + userid + ") AND (dbo.Fbusiness_trip.BusinessTripID = " + BusinessTripID + ") ");
                    if (dryoxla == null)
                    {
                        Response.Redirect("~/adminpanel/admingiris.aspx");
                    }

                }
          
             
            }
            catch (Exception)
            {
                //Response.Redirect("~/adminpanel/admingiris.aspx");
            }
        }
    }
    protected void btncixis_Click(object sender, EventArgs e)
    {

        FormsAuthentication.SignOut();
        Session.Abandon();
        Session.Clear();
        Response.Redirect("~/adminpanel/admingiris.aspx");
    }
    //protected void lbadmin_Click(object sender, EventArgs e)
    //{
        
    //    Session["UserID1"] = Session["UserID2"].ToString();
    //    Session["UserID2"] = null;
    //    Response.Redirect("../adminpanel/Yeniezamiyye.aspx?islem1=g2r2i1&islem=geri");
    //}
}
