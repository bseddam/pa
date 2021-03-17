using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class adminpanel_sosialobyektler : System.Web.UI.Page
{
    Class2 klas = new Class2(); 
    protected void Page_Load(object sender, EventArgs e)
    {
    
        if (Page.IsPostBack == false)
        {


        

        LinkButton lblvizual1 = (LinkButton)Master.Master.FindControl("Tesnifatlar");
        lblvizual1.BackColor = Color.Peru;
        ContentPlaceHolder cp = this.Master.Master.FindControl("ContentPlaceHolder1") as ContentPlaceHolder;
        LinkButton tb = cp.FindControl("sosialobyektler") as LinkButton;
        tb.BackColor = Color.Brown;
        }


        string s = @"SELECT     dbo.List_classification_Regions.Name, dbo.SosTex_count.Count_n, dbo.SosTex_count.Name AS Texnika, dbo.SosTex_count.kod
FROM         dbo.List_classification_Regions INNER JOIN
                      dbo.SosTex_count ON dbo.List_classification_Regions.RegionsID = dbo.SosTex_count.RegionID";

        DataTable dtGruplar = klas.getdatatable(s);//and b.RegionCome >'" + Convert.ToDateTime(gelme) + "' order by [RegionCome]
        DataList1.DataSource = dtGruplar;
        DataList1.DataBind();
    }
}