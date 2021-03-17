using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class adminpanel_Yasmentehlil : System.Web.UI.Page
{
    Class2 klas = new Class2(); string islem; string UserID; string RegionID; string BusinessTripID; string tarix1; string tarix2;
    string tarix3; string tarix4; string LivingID;
  
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            islem = Request.QueryString["islem"];
            UserID = Request.QueryString["UserID"];
            RegionID = Request.QueryString["RegionID"];
            LivingID = Request.QueryString["LivingID"];
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
                pnlbirinci.Visible = false;
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

            if (islem == "rayon5")
            {
                pnlesasseh.Visible = false;
                pnlbirinci.Visible = true;
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
                birinci();

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
        lblezamsay.Text = klas.getdatacell(@"select COUNT(*) as rynsay FROM business_trip as bis where AssortinID=4 "
              + tarixs2 + " " + " " + tarixs1 + "  " + rayon + "  " + " " + userid + "");
        lblfreg.Text = klas.getdatacell(@"select COUNT(*) as freg from (select distinct RegionsID,Name FROM 
List_classification_Regions  as r inner join business_trip as bis ON r.RegionsID = bis.RegionID where AssortinID=4 " +
       tarixs2 + " " + " " + tarixs1 + "  " + rayon + "  " + " " + userid + ") as cc");
        lblfmetn.Text = klas.getdatacell(@"select COUNT(*) yasmensayi from List_SubRegions where ForDelete=1");
        lblolyasmen.Text = klas.getdatacell(@"SELECT COUNT(*) as oldsay FROM   Conn_living  as cl  
inner join  business_trip as bis ON cl.BusinessTripID = bis.BusinessTripID 
left join List_SubRegions as sr on sr.CityID=cl.LivingID and bis.RegionID=sr.RegionID 
 where AssortinID=4 and IshtirakYesNo='true' and LivingID<>0 " + tarixs2 + " " + " " + tarixs1 + "  " + rayon + "  " + " " + userid + "");
        lblolferqli.Text = klas.getdatacell(@"select COUNT(*) from (SELECT distinct bis.RegionID,LivingID,UserID FROM   Conn_living  as cl  
inner join  business_trip as bis ON cl.BusinessTripID = bis.BusinessTripID 
left join List_SubRegions as sr on sr.CityID=cl.LivingID and bis.RegionID=sr.RegionID 
 where AssortinID=4 and IshtirakYesNo='true' and LivingID<>0 " + tarixs2 + " " + " " + tarixs1 + "  " + rayon + "  " + " " + userid + " ) as c ");

        float ehatelik = 0;
        ehatelik = (float.Parse(lblolferqli.Text) / float.Parse(lblfmetn.Text))*100;
        lblehatelik.Text = Math.Round(Convert.ToDecimal(ehatelik), 1).ToString()+"%";


        DataTable region2 = klas.getdatatable(@"select u.Name+' '+Sname  as Username,CONVERT(varchar(1000),cemimensayi) cemimensayi,mqs.LivingOther as LivingOther,CONVERT(varchar(1000), oldsayi) oldsayi,
CONVERT(varchar(1000),CONVERT(decimal(5,1),(Round((CONVERT(decimal,meqseds)/CONVERT(decimal,cemimensayi))*100,1)))) + '%' as ehatefaiz,
mqs.RegionID,u.UserID,mqs.LivingID,meqseds,CONVERT(varchar(1000), ryns.rynsay) as rynsay,r.Name from 
(SELECT COUNT(*) meqseds,LivingID,bis.RegionID,UserID,LivingOther FROM   Conn_living  as r inner join 
business_trip as bis ON r.BusinessTripID = bis.BusinessTripID inner join List_SubRegions as lc on lc.CityID=r.LivingID 
where AssortinID=4 and IshtirakYesNo='true' and lc.ForDelete=1 " + tarixs2 + " " + " " + tarixs1 + "  " + rayon + "  " +
        " " + userid + "  group by LivingID,bis.RegionID,UserID,LivingOther) as mqs " +
     "inner join (select COUNT(*) cemimensayi,RegionID from List_SubRegions as sr where ForDelete=1 " +
"group by RegionID) as mn on mn.RegionID=mqs.RegionID " +
"inner join (select COUNT(*) as oldsayi,UserID,RegionID from ( " +
"select distinct bis.RegionID,Name,UserID from Conn_living as r " +
"inner join List_SubRegions as lc on lc.CityID=r.LivingID inner join " +
"business_trip as bis ON r.BusinessTripID = bis.BusinessTripID  " +
"where AssortinID=4 and IshtirakYesNo='true'  and lc.ForDelete=1 " + tarixs2 + " " + " " + tarixs1 + "  " + rayon + "  " +
        " " + userid + " ) as kkk group by UserID,RegionID) as oldsayi  " +
"on oldsayi.RegionID=mqs.RegionID and oldsayi.UserID=mqs.UserID " +
        "inner join ( SELECT COUNT(*) as rynsay,UserID,RegionID FROM business_trip as btr  where AssortinID=4 " + tarixs22 + " " + " " + tarixs11 + "  " + rayon1 + "  " +" " + userid1 + " " +
        "group by UserID,RegionID )as ryns on ryns.RegionID=mqs.RegionID and ryns.UserID=mqs.UserID " +
"inner join Users as u on u.UserID=mqs.UserID    " +
"left join List_classification_Regions as r ON mqs.RegionID = r.RegionsID   " +
 "order by mqs.UserID,mqs.RegionID,LivingOther");


        DataList1.DataSource = klas.tekrarlamar1x("Username", "rynsay", "Name", "UserID", "cemimensayi", "oldsayi", "Sn", region2);
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


    void birinci()
    {

        string rayon;
        string rayon1;
        string userid;
        string userid1;
        if (UserID == "" || UserID == null)
        {
            userid = "  ";
            userid1 = "  ";
        }
        else
        {
            userid = " and bis.UserID='" + UserID + "' ";
            userid1 = " and btr.UserID='" + UserID + "' ";
        }
        if (RegionID == "" || RegionID == null)
        {
            rayon = "  ";
            rayon1 = "  ";
        }
        else
        {
            rayon = " and bis.RegionID='" + RegionID + "' ";
            rayon1 = " and btr.RegionID='" + RegionID + "' ";
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

        if (LivingID == "" || LivingID == null)
        {
            LivingID = " ";
        }
        else
        {
            LivingID = "and LivingID=" + LivingID;
        }
        pnlesasseh.Visible = false;
        pnlbirinci.Visible = true;



        DataTable region2 = klas.getdatatable(@"SELECT     u.Name+' '+u.Sname  as Username,bis.BusinessTripID, bis.RegionID, bis.RegionCome, bis.GoFromRegion, bis.Regions, 
   bis.UserID, c.LivingOther, c.LivingID FROM  business_trip as bis INNER JOIN Conn_living as c ON bis.BusinessTripID = c.BusinessTripID 
INNER JOIN Users as u ON bis.UserID = u.UserID where AssortinID=4 and IshtirakYesNo='true' 
" + tarixs2 + " " + " " + tarixs1 + "  " + rayon + "  " +
        " " + userid + " " + LivingID + " order by bis.RegionCome desc,bis.GoFromRegion desc");
        DataList3.DataSource = region2;
        DataList3.DataBind();

    

    }


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
            Response.Redirect("Yasmentehlil.aspx?islem=rayon0");
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
    protected void btnworde_Click(object sender, EventArgs e)
    {
        pnlbaxiw0.Visible = false;
        for (int i = 0; i < DataList3.Items.Count; i++)
        {
            ((System.Web.UI.WebControls.Panel)(DataList3.Items[i].FindControl("pnlbaxiw1"))).Visible = false;
        }
        Response.ClearContent();
        Response.AppendHeader("content-disposition", "attachment; filename=Hesabattehlil.doc");
        Response.ContentType = "application/excel";
        Response.ContentEncoding = System.Text.Encoding.UTF8;
        Response.BinaryWrite(System.Text.Encoding.UTF8.GetPreamble());
        StringWriter stringWritter = new StringWriter();
        HtmlTextWriter htmlTextWritter = new HtmlTextWriter(stringWritter);
        pnlprnt.RenderControl(htmlTextWritter);
        Response.Write(stringWritter.ToString());
        Response.End();
    }
}