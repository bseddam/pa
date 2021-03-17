using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class adminpanel_Istetdiyitedbirtehlil : System.Web.UI.Page
{
    Class2 klas = new Class2(); string islem; string UserID; string RegionID; string BusinessTripID; string tarix1; string tarix2;
    string tarix3; string tarix4; string ParticipationID; string DiscussedID; 
    string siralama1; string userkod = ""; string rayonkod = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            islem = Request.QueryString["islem"];
            UserID = Request.QueryString["UserID"];
            RegionID = Request.QueryString["RegionID"];
            ParticipationID = Request.QueryString["ParticipationID"];
            DiscussedID = Request.QueryString["DiscussedID"];
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

                if (siralama1 == "1")
                {
                    rdrayon.Checked = true;
                    rdmeqsed.Checked = false;
                    rdmesele.Checked = false;
                }
                else if (siralama1 == "2")
                {
                    rdmeqsed.Checked = true;
                    rdrayon.Checked = false;
                    rdmesele.Checked = false;
                }
                else if (siralama1 == "3")
                {
                    rdmeqsed.Checked = false;
                    rdrayon.Checked = false;
                    rdmesele.Checked = true;
                }
                pnlbirinci.Visible = false;
                ryn();
                ddlryn.SelectedValue = RegionID;
                lblgelme1.Text = tarix1;
                lblgetme1.Text = tarix2;
                lblgelme.Text = tarix3;
                lblgetme.Text = tarix4;
                lblgelme2.Text = tarix3;
                lblgetme2.Text = tarix4;
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

        string siralama = "";
        if (rdrayon.Checked == true)
        {
            siralama = "mqs.UserID,mqs.RegionID,sort1,sort2";
            lblsira.Text = "1";
        }
        else if (rdmeqsed.Checked == true)
        {
            siralama = "sort1,sort2,mqs.UserID,mqs.RegionID";
            lblsira.Text = "2";
        }
        else
        {
            siralama = "sort2,sort1,mqs.UserID,mqs.RegionID";
            lblsira.Text = "3";
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

        lblfmetn.Text = klas.getdatacell(@"select COUNT(*) as fmeqsay from 
(SELECT distinct ParticipationID FROM 
Conn_participation_measure  as r  inner join business_trip as bis ON r.BusinessTripID = bis.BusinessTripID where  AssortinID=4 and BaxilibYesNo='true' and OlunubYesNo='true' and ParticipationID<>0 " +
 tarixs2 + " " + " " + tarixs1 + "  " + rayon + "  " + " " + userid + ")as cc");
        lblfmetn0.Text = klas.getdatacell(@"select COUNT(*) as fmeqsay from 
(SELECT distinct DiscussedID FROM 
Conn_participation_measure  as r  inner join business_trip as bis ON r.BusinessTripID = bis.BusinessTripID where  AssortinID=4 and BaxilibYesNo='true' and OlunubYesNo='true' and DiscussedID<>0 " +
tarixs2 + " " + " " + tarixs1 + "  " + rayon + "  " + " " + userid + ")as cc");

//        lbltedbir.Text = klas.getdatacell(@"select COUNT(*) as meqcem from (select  distinct  bis.BusinessTripID,RegionID,UserID,ParticipationID FROM 
// Conn_participation_measure as r inner join business_trip as bis ON r.BusinessTripID = bis.BusinessTripID where
// bis.AssortinID=4 and BaxilibYesNo='true' and OlunubYesNo='true' and ParticipationID<>0" + tarixs2 + " " + " " + tarixs1 + "  " + rayon + "  " + " " + userid + " )as cc");
//        lblmesele.Text = klas.getdatacell(@"select COUNT(*) as meqcem from (select  distinct  bis.BusinessTripID,RegionID,UserID,DiscussedID FROM 
// Conn_participation_measure as r inner join business_trip as bis ON r.BusinessTripID = bis.BusinessTripID where
// bis.AssortinID=4 and BaxilibYesNo='true'  and OlunubYesNo='true' and DiscussedID<>0 " + tarixs2 + " " + " " + tarixs1 + "  " + rayon + "  " + " " + userid + " )as cc");


        DataTable region2 = klas.getdatatable(@"select u.Name+' '+Sname  as Username,
mqs.RegionID,mqs.ClassifName ParticipationOther,muz.ClassifName DiscussedOther,u.UserID,mqs.ParticipationID,muz.DiscussedID,CONVERT(varchar(1000),tedbir) as tedbir,mesele,
CONVERT(varchar(1000), ryns.rynsay) as rynsay,r.Name,CONVERT(varchar(1000),umumimesele) as  umumimesele ,
case when b.sort Is null then 100000 else b.sort  end  as sort1,
case when k.sort Is null then 100000 else k.sort  end  as sort2,CONVERT(varchar(1000),meqsedumumi) as  meqsedumumi  from 
(select COUNT(*) tedbir,ted1.RegionID,UserID,ParticipationID,ClassifName from 
(select  distinct  bis.BusinessTripID,RegionID,bis.UserID,ParticipationID,lc.ClassifName FROM 
 Conn_participation_measure as r inner join business_trip as bis ON r.BusinessTripID = bis.BusinessTripID 
 inner join List_classifications as lc on lc.ClassifID=r.ParticipationID  where
 bis.AssortinID=4 and BaxilibYesNo='true' and OlunubYesNo='true'  " + tarixs2 + " " + " " + tarixs1 + "  " + rayon + "  " +
" " + userid + " ) as ted1 group by ted1.RegionID,ted1.UserID,ted1.ParticipationID,ClassifName ) as mqs  " +
"inner join (select COUNT(*) meqsedumumi,ParticipationID from ( SELECT distinct bis.BusinessTripID,  " +
"ParticipationID FROM   Conn_participation_measure  as r inner join business_trip as bis ON  "+
"r.BusinessTripID = bis.BusinessTripID where AssortinID=4  and BaxilibYesNo='true'  "+
"and OlunubYesNo='true' " + tarixs2 + " " + " " + tarixs1 + "  " + rayon + "  " +" " + userid +
") as ma group by ParticipationID) as mqsumumi on mqsumumi.ParticipationID=mqs.ParticipationID  " +
 " inner join (SELECT COUNT(*) mesele,RegionID,bis.UserID,ParticipationID,DiscussedID,lc1.ClassifName FROM  "+
"Conn_participation_measure as r inner join business_trip as bis ON r.BusinessTripID = bis.BusinessTripID inner join List_classifications as lc on lc.ClassifID=r.ParticipationID inner join List_classifications as lc1 on lc1.ClassifID=r.DiscussedID where " +
"bis.AssortinID=4 and BaxilibYesNo='true'  and OlunubYesNo='true'  " + tarixs2 + " " + " " + tarixs1 + "  " + rayon + "  " +" " + userid +
"group by RegionID,bis.UserID,ParticipationID,DiscussedID,lc1.ClassifName) as muz on  muz.ParticipationID=mqs.ParticipationID and muz.UserID=mqs.UserID and muz.RegionID=mqs.RegionID  " +

"inner join (SELECT COUNT(*) umumimesele,DiscussedID FROM   Conn_participation_measure  as r inner join " +
"business_trip as bis ON r.BusinessTripID = bis.BusinessTripID where AssortinID=4  and BaxilibYesNo='true' and OlunubYesNo='true'  " 
+ tarixs2 + " " + " " + tarixs1 + "  " + rayon + " " + userid + 
" group by DiscussedID ) as meseleumumi  on muz.DiscussedID=meseleumumi.DiscussedID  " +

"inner join (SELECT COUNT(*) as rynsay,UserID,RegionID FROM business_trip as bis where bis.AssortinID=4 " + tarixs2 + " " + " " + tarixs1 + "  " + rayon + "  " +
" " + userid + "  group by UserID,RegionID)as ryns on ryns.RegionID=mqs.RegionID and ryns.UserID=mqs.UserID inner join Users as u on u.UserID=mqs.UserID "+
" left join List_classification_Regions as r ON mqs.RegionID = r.RegionsID left join List_classifications as b on b.ClassifID=mqs.ParticipationID "+
" left join List_classifications as k on k.ClassifID=muz.DiscussedID order by " + siralama + "");

        if (rdrayon.Checked == true)
        {
            DataList1.DataSource = klas.tekrarlama2("Username", "rynsay", "Name", "UserID", "ParticipationOther", "tedbir", "meqsedumumi", "DiscussedOther", "umumimesele", "RegionID", "Sn", region2);
        }
        else if (rdmeqsed.Checked == true)
        {
            DataList1.DataSource = klas.tekrarlama20("Username", "rynsay", "Name", "UserID", "ParticipationOther", "tedbir", "meqsedumumi", "DiscussedOther", "umumimesele", "Sn", region2);
        }
        else {
            DataList1.DataSource = klas.tekrarlama21("Username", "rynsay", "Name", "UserID", "ParticipationOther", "tedbir", "meqsedumumi", "DiscussedOther", "umumimesele", "Sn", region2);
        }
     
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
        if (ParticipationID != null)
        {
            purp = "and ParticipationID=" + ParticipationID + " ";
        }
        else
        {
            purp = " ";
        }
        string discus = "";
        if (DiscussedID != null)
        {
            discus = "and DiscussedID=" + DiscussedID + " ";
        }
        else
        {
            discus = " ";
        }

        string sirala;
        if (siralama1 == "1")
        {
            sirala = "userID,RegionID,sort1,sort2";
        }
        else if (siralama1 == "2")
        {
            sirala = "sort1,sort2,userID,RegionID";
        }
        else {
            sirala = "sort2,sort1,userID,RegionID";
        }

        DataTable region2 = klas.getdatatable(@"SELECT    b.BusinessTripID, b.RegionID, b.RegionCome, b.GoFromRegion, r.Name,u.Name+' '+u.Sname as username,
  b.UserID, c.DiscussedOther, c.DiscussedID, c.ParticipationOther, c.ParticipationID,WorkView,ResultView,
  case when lc.sort Is null then 100000 else lc.sort  end  as sort1,
case when k.sort Is null then 100000 else k.sort  end  as sort2
  FROM  business_trip as b INNER JOIN Conn_participation_measure as c ON b.BusinessTripID = c.BusinessTripID
  inner join Users as u on u.UserID=b.UserID
   left join List_classification_Regions as r ON b.RegionID = r.RegionsID 
   left join List_classifications as lc on lc.ClassifID=c.ParticipationID 
 left join List_classifications as k on k.ClassifID=c.DiscussedID 
   where b.AssortinID=4 and  BaxilibYesNo='true' and OlunubYesNo='true' " + rayon + "   " + tarixs22 + " " + tarixs11 + " " + user1 + " " + purp + " " + discus + " " + user2 + " " + rayon2 +
    " order by " + sirala + " "); 
        //userID,RegionID,sort1,sort2");


//        DataTable region2 = klas.getdatatable(@"SELECT distinct   b.BusinessTripID, b.RegionID, b.RegionCome, b.GoFromRegion, b.Regions, 
//   b.UserID, c.ParticipationOther, c.ParticipationID FROM  business_trip as b INNER JOIN Conn_participation_measure as c ON b.BusinessTripID = c.BusinessTripID where  BaxilibYesNo='true' 
//" + rayon + "   " + tarixs22 + " " + tarixs11 + " " + user1 + " and ParticipationID=" + ParticipationID + " order by b.RegionCome desc,b.GoFromRegion desc");
        DataList3.DataSource = region2;
        DataList3.DataBind();
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
//    void ikinci()
//    {
//        pnlesasseh.Visible = false;
//        pnlikinci.Visible = true;
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


//        DataTable region2 = klas.getdatatable(@"SELECT    b.BusinessTripID, b.RegionID, b.RegionCome, b.GoFromRegion, b.Regions, 
//   b.UserID, c.DiscussedOther, c.DiscussedID, c.ParticipationOther, c.ParticipationID FROM  business_trip as b INNER JOIN Conn_participation_measure as c ON b.BusinessTripID = c.BusinessTripID where  BaxilibYesNo='true'
//" + rayon + "   " + tarixs22 + " " + tarixs11 + " " + user1 + " and ParticipationID=" + ParticipationID + " and DiscussedID=" + DiscussedID + " order by b.RegionCome desc,b.GoFromRegion desc");
//        rpmesele.DataSource = region2;
//        rpmesele.DataBind();
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
//            pnlbirinci.Visible = false;

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
        if (islem == "rayon5" || islem == "rayon2")
        {
            Response.Redirect("Istetdiyitedbirtehlil.aspx?islem=rayon0");
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
        pnlprint.RenderControl(htmlTextWritter);
        Response.Write(stringWritter.ToString());
        Response.End();
        pnlbaxiw0.Visible = true;
    }
}