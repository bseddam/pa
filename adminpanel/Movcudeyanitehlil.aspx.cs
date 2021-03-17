using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class adminpanel_Movcudeyanitehlil : System.Web.UI.Page
{
    Class2 klas = new Class2(); string islem; string UserID; string RegionID; string BusinessTripID; string tarix1; string tarix2;
    string tarix3; string tarix4; string PurposeID; string siralama1; string userkod = ""; string rayonkod = "";
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
            siralama1 = Request.QueryString["siralama1"];
            userkod = Request.QueryString["userkod"];
            rayonkod = Request.QueryString["rayonkod"];
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
        lblgelme4.Text = lblgelme.Text;
        lblgetme4.Text = lblgetme.Text;
        lblgelme3.Text = lblgelme1.Text;
        lblgetme3.Text = lblgetme1.Text;
        lblkurator.Text = ddlusers.SelectedValue;
        lblrayon.Text = ddlryn.SelectedValue;
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
        lblcem.Text = klas.getdatacell(@"select sum(lll.Situation_SUM) from 
(select Situation_SUM,Situation_Excellent,Situation_fit,Situation_unfit,Offer,RegionID,UserID
  from business_trip bis inner join Conn_Existing_Campaign o on bis.BusinessTripID=o.BusinessTripID where  AssortinID=4 " +
 tarixs2 + " " + " " + tarixs1 + "  " + rayon + "  " + " " + userid + "  ) as lll ");
//        lblela.Text = klas.getdatacell(@"select sum(lll.Situation_Excellent) from 
//(select Situation_SUM,Situation_Excellent,Situation_fit,Situation_unfit,Offer,RegionID,UserID
//  from business_trip bis inner join Conn_Existing_Campaign o on bis.BusinessTripID=o.BusinessTripID where  AssortinID=4 " +
//tarixs2 + " " + " " + tarixs1 + "  " + rayon + "  " + " " + userid + "  ) as lll ");
        lblela.Text = klas.getdatacell(@"select CONVERT(varchar(1000),sum(lll.Situation_Excellent))+'/'+
CONVERT(varchar(1000),CONVERT(decimal(5,1),(Round((sum(lll.Situation_Excellent)/sum(lll.Situation_SUM))*100,1)))) + '%' as ela from 
(select Situation_SUM,Situation_Excellent,Situation_fit,Situation_unfit,Offer,RegionID,UserID
  from business_trip bis inner join Conn_Existing_Campaign o on bis.BusinessTripID=o.BusinessTripID where  AssortinID=4  " +
 tarixs2 + " " + " " + tarixs1 + "  " + rayon + "  " + " " + userid + "  ) as lll");
        lblyararli.Text = klas.getdatacell(@"select CONVERT(varchar(1000),sum(lll.Situation_fit))+'/'+
CONVERT(varchar(1000),CONVERT(decimal(5,1),(Round((sum(lll.Situation_fit)/sum(lll.Situation_SUM))*100,1)))) + '%' as yararli from 
(select Situation_SUM,Situation_Excellent,Situation_fit,Situation_unfit,Offer,RegionID,UserID
  from business_trip bis inner join Conn_Existing_Campaign o on bis.BusinessTripID=o.BusinessTripID where  AssortinID=4  " +
tarixs2 + " " + " " + tarixs1 + "  " + rayon + "  " + " " + userid + "  ) as lll");
        lblyararsiz.Text = klas.getdatacell(@"select CONVERT(varchar(1000),sum(lll.Situation_unfit))+'/'+
CONVERT(varchar(1000),CONVERT(decimal(5,1),(Round((sum(lll.Situation_unfit)/sum(lll.Situation_SUM))*100,1)))) + '%' as yararsiz from 
(select Situation_SUM,Situation_Excellent,Situation_fit,Situation_unfit,Offer,RegionID,UserID
  from business_trip bis inner join Conn_Existing_Campaign o on bis.BusinessTripID=o.BusinessTripID where  AssortinID=4  " +
tarixs2 + " " + " " + tarixs1 + "  " + rayon + "  " + " " + userid + "  ) as lll");





        DataTable region2 = klas.getdatatable(@"select   u.Name+' '+u.Sname  as Username,umumi.RegionID,Offer,u.UserID,CONVERT(varchar(1000),umumi.cemumumi) as cemumumi,
CONVERT(varchar(1000),ela1.cemela)+'/'+
CONVERT(varchar(1000),CONVERT(decimal(5,1),(Round(COALESCE((ela1.cemela/nullif(umumi.cemumumi,0)),0)*100,1)))) + '%' as ela,
CONVERT(varchar(1000),yararli.cemyararli)+'/'+
CONVERT(varchar(1000),CONVERT(decimal(5,1),(Round(COALESCE((yararli.cemyararli/nullif(umumi.cemumumi,0)),0)*100,1)))) + '%' as yararli,
CONVERT(varchar(1000),yararsiz.cemyararsiz)+'/'+
CONVERT(varchar(1000),CONVERT(decimal(5,1),(Round(COALESCE((yararsiz.cemyararsiz/nullif(umumi.cemumumi,0)),0)*100,1)))) + '%' as yararsiz,
CONVERT(varchar(1000),ryns.rynsay)rynsay,r.Name  from 
 (select sum(Situation_SUM) as cemumumi,RegionID,UserID
 from business_trip bis inner join Conn_Existing_Campaign o on bis.BusinessTripID=o.BusinessTripID where AssortinID=4  " + tarixs2 + " " + " " + tarixs1 + "  " + rayon + "  " +
" " + userid + " group by RegionID,UserID) as umumi inner join (select sum(Situation_Excellent) as cemela,RegionID,UserID "+
" from business_trip bis inner join Conn_Existing_Campaign o on bis.BusinessTripID=o.BusinessTripID where AssortinID=4  " + tarixs2 + " " + " " + tarixs1 + "  " + rayon + "  " +
" " + userid + " group by RegionID,UserID) as ela1 on umumi.RegionID=ela1.RegionID and umumi.UserID=ela1.UserID "+
"inner join (select sum(Situation_fit) as cemyararli,RegionID,UserID "+
"from business_trip bis inner join Conn_Existing_Campaign o on bis.BusinessTripID=o.BusinessTripID where AssortinID=4  " + tarixs2 + " " + " " + tarixs1 + "  " + rayon + "  " +
" " + userid + "group by RegionID,UserID) as yararli on yararli.RegionID=umumi.RegionID and yararli.UserID=umumi.UserID  "+
"inner join (select sum(Situation_unfit) as cemyararsiz,RegionID,UserID "+
"from business_trip bis inner join Conn_Existing_Campaign o on bis.BusinessTripID=o.BusinessTripID where AssortinID=4  " + tarixs2 + " " + " " + tarixs1 + "  " + rayon + "  " +
" " + userid + " group by RegionID,UserID) as yararsiz on yararsiz.RegionID=umumi.RegionID and yararsiz.UserID=umumi.UserID  "+
"inner join ( SELECT COUNT(*) as rynsay,UserID,RegionID FROM business_trip as bis   where  AssortinID=4  " + tarixs2 + " " + " " + tarixs1 + "  " + rayon + "  " +
" " + userid + " group by UserID,RegionID )as ryns on ryns.RegionID=umumi.RegionID and ryns.UserID=umumi.UserID   "+
" inner join Users as u on u.UserID=umumi.UserID   inner join (select Situation_SUM,Situation_Excellent,Situation_fit,Situation_unfit,Offer,RegionID,UserID "+
" from business_trip bis inner join Conn_Existing_Campaign o on bis.BusinessTripID=o.BusinessTripID where  AssortinID=4   " + tarixs2 + " " + " " + tarixs1 + "  " + rayon + "  " +
" " + userid + "  ) as lll on lll.RegionID=umumi.RegionID and lll.UserID=umumi.UserID left join List_classification_Regions as r ON umumi.RegionID = r.RegionsID   order by umumi.UserID,umumi.RegionID");

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


    void birinci()
    {
        string user2 = " "; string rayon2 = " ";
        if (userkod == null || userkod == "" || userkod == "-1" || userkod == "0")
        {
            user2 = " ";
        }
        else
        {
            user2 = " and b.UserID='" + userkod + "' ";
        }

        if (rayonkod == null || rayonkod == "" || rayonkod == "-1" || rayonkod == "0")
        {
            rayon2 = " ";
        }
        else
        {
            rayon2 = " and b.RegionID='" + rayonkod + "' ";
        }






        pnlesasseh.Visible = false;
        pnlbirinci.Visible = true;
        string rayon;
        string user1;
        string purp = "";

        if (UserID == null)
        {
            user1 = " ";
        }
        else
        {
            user1 = " and b.UserID='" + UserID + "' ";
        }
        if (RegionID == null)
        {
            rayon = " ";
        }
        else
        {
            rayon = " and b.RegionID='" + RegionID + "'  ";
        }


        string tarixs11 = "";
        string tarixs22 = "";
        if (lblgetme1.Text != "")
        {
            tarixs11 = " and b.GoFromRegion <='" + lblgetme1.Text + "'";
        }
        if (lblgelme1.Text != "")
        {
            tarixs22 = "and b.RegionCome >='" + lblgelme1.Text + "'";
        }


        DataTable region2 = klas.getdatatable(@"select  lll.BusinessTripID,u.Name+' '+u.Sname  as Username,lll.RegionID,lll.Offer,u.UserID,lll.Situation_SUM,Regioncome,GoFromRegion,
        CONVERT(varchar(1000),lll.Situation_Excellent)+'/'+
        CONVERT(varchar(1000),CONVERT(decimal(5,1),(Round((lll.Situation_Excellent/lll.Situation_SUM)*100,1)))) + '%' as ela,
        CONVERT(varchar(1000),lll.Situation_fit)+'/'+
        CONVERT(varchar(1000),CONVERT(decimal(5,1),(Round((lll.Situation_fit/lll.Situation_SUM)*100,1)))) + '%' as yararli,
        CONVERT(varchar(1000),lll.Situation_unfit)+'/'+
        CONVERT(varchar(1000),CONVERT(decimal(5,1),(Round((lll.Situation_unfit/lll.Situation_SUM)*100,1)))) + '%' as yararsiz,
        r.Name 
         from 
        (select b.BusinessTripID,Situation_SUM,Situation_Excellent,Situation_fit,Situation_unfit,Offer,RegionID,UserID,b.Regioncome,b.GoFromRegion 
          from business_trip b inner join Conn_Existing_Campaign o on b.BusinessTripID=o.BusinessTripID where  AssortinID=4  " + tarixs22 + " " + " " + tarixs11 + "  " + rayon + "  " +
     " " + user1 + " ) as lll  inner join Users as u on u.UserID=lll.UserID " +
     " left join List_classification_Regions as r ON lll.RegionID = r.RegionsID   order by lll.UserID,lll.RegionID");
        rp1.DataSource = region2;
        rp1.DataBind();
        if (region2.Rows.Count > 0)
        {
            lblmesage.Text = "";
            exele.Visible = true;
        }
        else
        {
            lblmesage.Text = "Tapılmadı";
            lblmesage.ForeColor = Color.Red;
            pnlbirinci.Visible = false;

        }

      

     


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
            Response.Redirect("Movcudeyanitehlil.aspx?islem=rayon0");
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
    protected void exele0_Click(object sender, EventArgs e)
    {
        pnlbaxiw0.Visible = false;
        for (int i = 0; i < rp1.Items.Count; i++)
        {
            ((System.Web.UI.WebControls.Panel)(rp1.Items[i].FindControl("pnlbaxiw1"))).Visible = false;
        }
        Response.ClearContent();
        Response.AppendHeader("content-disposition", "attachment; filename=Hesabattehlil.doc");
        Response.ContentType = "application/excel";
        Response.ContentEncoding = System.Text.Encoding.UTF8;
        Response.BinaryWrite(System.Text.Encoding.UTF8.GetPreamble());
        StringWriter stringWritter = new StringWriter();
        HtmlTextWriter htmlTextWritter = new HtmlTextWriter(stringWritter);
        pnlprint.RenderControl(htmlTextWritter);
        Response.Write(stringWritter.ToString());
        Response.End();
        pnlbaxiw0.Visible = true;
    }
}