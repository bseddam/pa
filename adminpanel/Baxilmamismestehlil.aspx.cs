using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class adminpanel_Baxilmamismestehlil : System.Web.UI.Page
{
    Class2 klas = new Class2(); string islem; string UserID; string RegionID; string BusinessTripID; string tarix1; string tarix2;
    string tarix3; string tarix4; string PurposeID;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            islem = Request.QueryString["islem"];
            UserID = Request.QueryString["UserID"];
            RegionID = Request.QueryString["RegionID"];
            PurposeID = Request.QueryString["PurposeID"];
            BusinessTripID = Request.QueryString["BusinessTripID"];
            tarix1 = Request.QueryString["tarix1"];
            tarix2 = Request.QueryString["tarix2"];
            tarix3 = Request.QueryString["tarix3"];
            tarix4 = Request.QueryString["tarix4"];
        }
        catch (Exception)
        {
            throw;
        }
        Calendar1.SelectedDates.Clear();
        Calendar3.SelectedDates.Clear();
        if (Page.IsPostBack == false)
        {


            LinkButton lblprofil = (LinkButton)Master.FindControl("Hesabattehlili");
            lblprofil.BackColor = Color.Peru;
            users();



            if (islem == "rayon0")
            {

                ryn();
                ddlryn.SelectedValue = RegionID;
                lblgelme1.Text = tarix1;
                lblgetme1.Text = tarix2;
                lblgelme.Text = tarix3;
                lblgetme.Text = tarix4;
                if (lblgelme.Text != "")
                {
                    imgbsilgelme.Visible = true;
                }
                else
                {
                    imgbsilgelme.Visible = false;
                }
                if (lblgetme.Text != "")
                {
                    imgbsilgetme0.Visible = true;
                }
                else
                {
                    imgbsilgetme0.Visible = false;
                }
                sifirinci();

            }
        }

    }


    protected void Button1_Click1(object sender, EventArgs e)
    {

        sifirinci();

    }
    void sifirinci()
    {
        string rayon;
        string rayon1;
        string userid;
        string userid1;
        if (ddlusers.SelectedValue == "0" || ddlusers.SelectedValue == "-1" || ddlusers.SelectedValue == "")
        {
            userid = "  ";
            userid1 = "  ";
        }
        else
        {
            userid = " and bis.UserID='" + ddlusers.SelectedValue + "' ";
            userid1 = " and btr.UserID='" + ddlusers.SelectedValue + "' ";
        }
        if (ddlryn.SelectedValue == "0" || ddlryn.SelectedValue == "-1" || ddlryn.SelectedValue == "")
        {
            rayon = "  ";
            rayon1 = "  ";
        }
        else
        {
            rayon = " and bis.RegionID='" + ddlryn.SelectedValue + "' ";
            rayon1 = " and btr.RegionID='" + ddlryn.SelectedValue + "' ";
        }
        string tarixs1 = "";
        string tarixs2 = "";
        string tarixs11 = "";
        string tarixs22 = "";
        if (lblgetme1.Text != "")
        {
            tarixs1 = " and bis.GoFromRegion <='" + lblgetme1.Text + "'";
            tarixs11 = "and btr.GoFromRegion <='" + lblgetme1.Text + "'";
        }
        if (lblgelme1.Text != "")
        {
            tarixs2 = "and bis.RegionCome >= '" + lblgelme1.Text + "'";
            tarixs22 = "and btr.RegionCome >='" + lblgelme1.Text + "'";
        }
        lblezamsay.Text = klas.getdatacell("select COUNT(*) as rynsay FROM business_trip as bis where AssortinID=4 "
            + tarixs2 + " " + " " + tarixs1 + "  " + rayon + "  " + " " + userid + "");



        DataTable region2 = klas.getdatatable(@"select lll.UserID,lll.ClassifID,lll.ClassifName,lll.RegionID,sort,CONVERT(varchar(1000), ryns.rynsay) as rynsay
,u.Name+' '+Sname as username ,r.Name
from (
select distinct btr.UserID,c.ClassifID,c.ClassifName,btr.RegionID,sort from List_classifications c,Business_trip btr 
where c.ListID=10 and c.ClassifID  not in (Select distinct p1.ReviewedID from business_trip bis inner join " +
"Conn_Reviewed p1 on p1.BusinessTripID=bis.BusinessTripID and bis.RegionID=btr.RegionID and bis.UserID=btr.UserID " +
" where baxilib='true' and AssortinID=4   " + tarixs2 + " " + " " + tarixs1 + "  " + rayon + "  " +
        " " + userid + " ) and AssortinID=4  " + tarixs22 + " " + " " + tarixs11 + "  " + rayon1 + "  " + " " + userid1 + " "
  + ") as lll inner join " + "(SELECT COUNT(*) as rynsay,UserID,RegionID FROM business_trip as btr  where AssortinID=4   "
        + tarixs22 + " " + " " + tarixs11 + "  " + rayon1 + "  " + " " + userid1 + " " +
        " group by UserID,RegionID )as ryns on ryns.RegionID=lll.RegionID and ryns.UserID=lll.UserID  " +
 "inner join Users as u on u.UserID=lll.UserID  " +
 "left join List_classification_Regions as r ON lll.RegionID = r.RegionsID order by lll.UserID,lll.RegionID,lll.sort");




        DataList1.DataSource = klas.tekrarlamax1("Username", "rynsay", "Name", "UserID", "Sn", region2);
        DataList1.DataBind();


        if (region2.Rows.Count > 0)
        {

            lblmesage.Text = "";
            exele.Visible = true;
        }
        else
        {

            lblmesage.Text = "Tapılmadı";
            lblmesage.ForeColor = Color.Red;
            //exele.Visible = false;
            //Panel1.Visible = false;
            //Panel2.Visible = false;
            //Panel3.Visible = false;
            //Panel4.Visible = false;
        }

    }


    //    void birinci()
    //    {
    //        string rayon;
    //        string user1;

    //        rayon = " and b.RegionID='" + RegionID + "'  ";
    //        user1 = " and b.UserID='" + UserID + "' ";


    //        string tarixs11 = "";
    //        string tarixs22 = "";
    //        if (lblgetme1.Text != "")
    //        {
    //            tarixs11 = " and b.GoFromRegion <='" + lblgetme1.Text + "'";
    //        }
    //        if (lblgelme1.Text != "")
    //        {
    //            tarixs22 = "and b.RegionCome >='" + lblgelme1.Text + "'";
    //        }


    //        DataTable region2 = klas.getdatatable(@"SELECT     b.BusinessTripID, b.RegionID, b.RegionCome, b.GoFromRegion, b.Regions, 
    //   b.UserID, c.Other, c.PurposeID FROM  business_trip as b INNER JOIN Conn_PurposeOfTrip as c ON b.BusinessTripID = c.BusinessTripID where 1=1
    //" + rayon + "   " + tarixs22 + " " + tarixs11 + " " + user1 + " and PurposeID=" + PurposeID + " order by b.RegionCome desc,b.GoFromRegion desc");
    //        DataList3.DataSource = region2;
    //        DataList3.DataBind();
    //        if (region2.Rows.Count > 0)
    //        {
    //            lblmesage.Text = "";
    //            exele.Visible = true;
    //        }
    //        else
    //        {
    //            lblmesage.Text = "Tapılmadı";
    //            lblmesage.ForeColor = Color.Red;
    //            exele.Visible = false;

    //        }

    //    }


    void ryn1()
    {
        DataTable dtiller = klas.getdatatable("Select * from List_classification_Regions where  ForDelete=1 order by [Name]");
        ddlryn.DataTextField = "Name";
        ddlryn.DataValueField = "RegionsID";
        ddlryn.DataSource = dtiller;
        ddlryn.DataBind();
        ddlryn.Items.Insert(0, new ListItem("Seçin", "0"));
        ddlryn.Items.Insert(1, new ListItem("Ümumi", "-1"));
        ddlryn.SelectedValue = "-1";
    }
    void ryn()
    {
        DataTable dtiller = klas.getdatatable("Select * from List_classification_Regions where UserID='" + ddlusers.SelectedValue + "' and ForDelete=1 order by [Name]");
        ddlryn.DataTextField = "Name";
        ddlryn.DataValueField = "RegionsID";
        ddlryn.DataSource = dtiller;
        ddlryn.DataBind();
        ddlryn.Items.Insert(0, new ListItem("Seçin", "0"));
        ddlryn.Items.Insert(1, new ListItem("Ümumi", "-1"));
        ddlryn.SelectedValue = "-1";
    }
    void users()
    {
        DataTable region2 = klas.getdatatable("select UserID,Name+' '+Sname as Name,Fname,status_users from Users where status_users=0 order by [Name]");
        ddlusers.DataTextField = "Name";
        ddlusers.DataValueField = "UserID";
        ddlusers.DataSource = region2;
        ddlusers.DataBind();
        ddlusers.Items.Insert(0, new ListItem("Seçin", "0"));
        ddlusers.Items.Insert(1, new ListItem("Ümumi", "-1"));
        ddlusers.SelectedValue = "0";
    }

    protected void exele_Click(object sender, EventArgs e)
    {

        sifirinci();
        Response.ClearContent();
        Response.AppendHeader("content-disposition", "attachment; filename=Hesabattehlil.doc");
        Response.ContentType = "application/excel";
        Response.ContentEncoding = System.Text.Encoding.UTF8;
        Response.BinaryWrite(System.Text.Encoding.UTF8.GetPreamble());
        StringWriter stringWritter = new StringWriter();
        HtmlTextWriter htmlTextWritter = new HtmlTextWriter(stringWritter);
        Panel1.RenderControl(htmlTextWritter);
        Response.Write(stringWritter.ToString());
        Response.End();

    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        if (Calendar1.Visible)
        {
            Calendar1.Visible = false;
            lblgelme.Visible = true;
            lblgelme2.Visible = true;
            imgbsilgelme.Visible = true;

        }
        else
        {
            imgbsilgelme.Visible = false;
            Calendar1.Visible = true;
            lblgelme.Visible = false;
            lblgelme2.Visible = false;
        }
        if (lblgelme.Text == "")
        {
            imgbsilgelme.Visible = false;
        }
    }
    protected void imgbsilgelme_Click(object sender, ImageClickEventArgs e)
    {
        lblgelme.Text = "";
        lblgelme2.Text = "";
        lblgelme1.Text = "";
        imgbsilgelme.Visible = false;
    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        lblgelme.Text = Calendar1.SelectedDate.ToString("d");
        lblgelme1.Text = Calendar1.SelectedDate.ToString("yyyy-MM-dd");
        lblgelme2.Text = Calendar1.SelectedDate.ToString("d");
        Calendar1.Visible = false;
        lblgelme.Visible = true;
        lblgelme2.Visible = true;
        imgbsilgelme.Visible = true;
    }
    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        if (Calendar3.Visible)
        {
            Calendar3.Visible = false;
            lblgetme.Visible = true;
            lblgetme2.Visible = true;
            imgbsilgetme0.Visible = true;
        }
        else
        {
            Calendar3.Visible = true;
            lblgetme.Visible = false;
            lblgetme2.Visible = false;
            imgbsilgetme0.Visible = false;
        }
        if (lblgetme.Text == "")
        {
            imgbsilgetme0.Visible = false;
        }
    }
    protected void imgbsilgetme0_Click(object sender, ImageClickEventArgs e)
    {
        lblgetme.Text = "";
        lblgetme1.Text = "";
        lblgetme2.Text = "";
        imgbsilgetme0.Visible = false;
    }
    protected void Calendar3_SelectionChanged(object sender, EventArgs e)
    {
        lblgetme.Text = Calendar3.SelectedDate.ToString("d");
        lblgetme1.Text = Calendar3.SelectedDate.ToString("yyyy-MM-dd");
        lblgetme2.Text = Calendar3.SelectedDate.ToString("d");
        Calendar3.Visible = false;
        lblgetme.Visible = true;
        lblgetme2.Visible = true;
        imgbsilgetme0.Visible = true;
    }
    protected void btngeri_Click(object sender, EventArgs e)
    {
        if (islem == "rayon0")
        {
            Response.Redirect("Hesabattehlili.aspx");
        }
        if (islem == "rayon5")
        {
            Response.Redirect("Ezmeqsedtehlil.aspx?islem=rayon0&tarix1=" + lblgelme1.Text + "&tarix2=" + lblgetme1.Text + "&tarix3=" + lblgelme.Text + "&tarix4=" + lblgetme.Text);
        }
    }
    protected void ddlusers_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlusers.SelectedValue == "-1")
        {
            ryn1();
        }
        else
        {
            ryn();
        }
    }
}