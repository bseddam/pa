using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class kurator_Default : System.Web.UI.Page
{
    string RegionCode; string BusinessTripID; string FRegionsId; Class2 klas = new Class2();
    protected void Page_Load(object sender, EventArgs e)
    {
        LinkButton lblprofil = (LinkButton)Master.FindControl("Yeniezamiyye");
        lblprofil.BackColor = Color.Peru;
       
        try
        {
            RegionCode = Request.QueryString["RegionCode"];
            BusinessTripID = Request.QueryString["BusinessTripID"];
            Session["BusinessTripID"] = BusinessTripID;
            Session["RegionID"] = RegionCode;
            FRegionsId = Request.QueryString["RayonID1"];
            Session["FRegionsId"] = FRegionsId;

            if (Session["UserID1"] == null)
            {
                DataRow dryoxla = klas.GetDataRow("SELECT     dbo.FRegions.BusinessTripID, dbo.Fbusiness_trip.UserID, dbo.FRegions.RegionCode, dbo.FRegions.RegionID " +
                    " FROM         dbo.FRegions INNER JOIN " +
                    " dbo.Fbusiness_trip ON dbo.FRegions.BusinessTripID = dbo.Fbusiness_trip.BusinessTripID " +
                    "WHERE     (dbo.FRegions.RegionID = " + FRegionsId + ") AND (dbo.FRegions.RegionCode = " + RegionCode + ") AND (dbo.Fbusiness_trip.UserID = " + Session["UserID"].ToString() + ") AND (dbo.FRegions.BusinessTripID = " + BusinessTripID + ")");
                DataRow dryoxla1 = klas.GetDataRow(" select * from FRegions where RegionID=" + FRegionsId + " and (Approval=0 or Approval=3)");
           
                if (dryoxla == null || dryoxla1 == null)
            {
                Response.Redirect("~/adminpanel/admingiris.aspx");
            }
            }
        }
        catch (Exception)
        { }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("et_baxilmish_arash_mesele.aspx");

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("et_tedbir_mesele.aspx");
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("et_ihb_numayendelik.aspx");
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        Response.Redirect("et_yashayishmenteqeleri.aspx");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
     
        Response.Redirect("et_vetendashlarla_gorush.aspx");
    }

    protected void btngeri_Click(object sender, EventArgs e)
    {

        Response.Redirect("Ezamiyyenintesviri.aspx?islem=rayontarix&BusinessTripID=" + BusinessTripID);
    }
}