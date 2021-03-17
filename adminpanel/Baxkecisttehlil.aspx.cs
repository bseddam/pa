using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class adminpanel_Baxkecisttehlil : System.Web.UI.Page
{
    Class2 klas = new Class2(); string islem; string UserID; string RegionID; string BusinessTripID; string tarix1; string tarix2;
    string tarix3; string tarix4; string Construction_works; string siralama1; string userkod = ""; string rayonkod = "";
    string ObjectID=""; string SubObjectID=""; string Living_PointID;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            islem = Request.QueryString["islem"];
            UserID = Request.QueryString["UserID"];
            RegionID = Request.QueryString["RegionID"];
            Construction_works = Request.QueryString["Construction_works"];
            ObjectID = Request.QueryString["ObjectID"];
            SubObjectID = Request.QueryString["SubObjectID"];
            Living_PointID = Request.QueryString["Living_PointID"];
            BusinessTripID = Request.QueryString["BusinessTripID"];
            tarix1 = Request.QueryString["tarix1"];
            tarix2 = Request.QueryString["tarix2"];
            tarix3 = Request.QueryString["tarix3"];
            tarix4 = Request.QueryString["tarix4"];
            siralama1 = Request.QueryString["siralama1"];
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
                sahe();
              
                pnlbirinci.Visible = false;
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
        lblsahe.Text = ddlsahe.SelectedValue;
        lblteyinat.Text = ddlteyinat.SelectedValue;
        sifirinci();

    }
    void sahe()
    {
        DataTable meqsed = klas.getdatatable("Select ClassifID,ClassifName,ListID from List_classifications where ListID=12 order by sort");
        ddlsahe.DataTextField = "ClassifName";
        ddlsahe.DataValueField = "ClassifID";
        ddlsahe.DataSource = meqsed;
        ddlsahe.DataBind();
        ddlsahe.Items.Insert(0, new ListItem("Ümumi", "-1"));
    }
    void teyinat()
    {
        DataTable dtilceler = klas.getdatatable("Select * from List_SubClassifictions Where ListID=" + ddlsahe.SelectedValue + " order by [sort]");
        ddlteyinat.DataTextField = "ClassificationName";
        ddlteyinat.DataValueField = "ClassifID";
        ddlteyinat.DataSource = dtilceler;
        ddlteyinat.DataBind();
        ddlteyinat.Items.Insert(0, new ListItem("Ümumi", "-1"));
    }
    void sifirinci()
    {
        string rayon;
        string rayon1;
        string userid;
        string userid1;
        string sahe;
        string teyinat;
        if (ddlsahe.SelectedValue == "0" || ddlsahe.SelectedValue == "-1" || ddlsahe.SelectedValue == "")
        {
            sahe = "  ";
        }
        else
        {
            sahe = " and r.ObjectID='" + ddlsahe.SelectedValue + "' ";
        }
        if (ddlteyinat.SelectedValue == "0" || ddlteyinat.SelectedValue == "-1" || ddlteyinat.SelectedValue == "")
        {
            teyinat = "  ";
        }
        else
        {
            teyinat = " and r.SubObjectID='" + ddlteyinat.SelectedValue + "' ";
        }
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
        if (ddlsiralama.SelectedValue == "1")
        {
            siralama = "lll.UserID,lll.RegionID,sort1,sort2";
            lblsira.Text = "1";
        }
        else if (ddlsiralama.SelectedValue == "2")
        {
            siralama = "sort1,sort2,lll.UserID,lll.RegionID";
            lblsira.Text = "2";
        }
        else
        {
            siralama = "sort2,sort1,lll.UserID,lll.RegionID";
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

        lblferqli.Text = klas.getdatacell(@"select COUNT(*) as meqcem from (SELECT distinct Living_PointID,Living_Point FROM  
Conn_Object_operation  as r inner join business_trip as bis ON r.BusinessTripID = bis.BusinessTripID 
where AssortinID=4 " + tarixs2 + " " + " " + tarixs1 + "  " + rayon + "  " + " " + userid + sahe + teyinat + " )as cc");
        lblsaheler.Text = klas.getdatacell(@"select COUNT(*) as meqcem from (SELECT distinct ObjectID,ObjectOther FROM  
Conn_Object_operation  as r inner join business_trip as bis ON r.BusinessTripID = bis.BusinessTripID 
where AssortinID=4 " + tarixs2 + " " + " " + tarixs1 + "  " + rayon + "  " + " " + userid + sahe + teyinat + " )as cc");
        lblteyuzre.Text = klas.getdatacell(@"select COUNT(*) as meqcem from (SELECT distinct SubObjectID,SubObjectOther FROM  
Conn_Object_operation  as r inner join business_trip as bis ON r.BusinessTripID = bis.BusinessTripID 
where AssortinID=4 " + tarixs2 + " " + " " + tarixs1 + "  " + rayon + "  " + " " + userid + sahe + teyinat + " )as cc");
        lblela.Text = klas.getdatacell(@"select COUNT(*) as meqcem from (SELECT  Construction_works FROM  
Conn_Object_operation  as r inner join business_trip as bis ON r.BusinessTripID = bis.BusinessTripID 
where AssortinID=4 and Construction_works=N'əla' " + tarixs2 + " " + " " + tarixs1 + "  " + rayon + "  " + " " + userid + sahe + teyinat + " )as cc");

        lblyararli.Text = klas.getdatacell(@"select COUNT(*) as meqcem from (SELECT  Construction_works FROM  
Conn_Object_operation  as r inner join business_trip as bis ON r.BusinessTripID = bis.BusinessTripID 
where AssortinID=4 and Construction_works=N'yararlı' " + tarixs2 + " " + " " + tarixs1 + "  " + rayon + "  " + " " + userid + sahe + teyinat + " )as cc");
        lblyararsiz.Text = klas.getdatacell(@"select COUNT(*) as meqcem from (SELECT  Construction_works FROM  
Conn_Object_operation  as r inner join business_trip as bis ON r.BusinessTripID = bis.BusinessTripID 
where AssortinID=4 and Construction_works=N'yararsız' " + tarixs2 + " " + " " + tarixs1 + "  " + rayon + "  " + " " + userid + sahe + teyinat + " )as cc");


        DataTable region2 = klas.getdatatable(@"select  u.Name+' '+Sname  as Username,lll.RegionID,lll.SubObjectOther,lll.Living_PointID,lll.Living_Point
,lll.ObjectOther,u.UserID,lll.SubObjectID,lll.ObjectID,
case when ela Is null then 0 else ela  end  as ela
,case when yararli Is null then 0 else yararli  end  as yararli
,case when yararsiz Is null then 0 else yararsiz  end  as yararsiz,
CONVERT(varchar(1000),ryns.rynsay)rynsay,r.Name,
case when b.sort Is null then 100000 else b.sort  end  as sort1,
case when k.sort Is null then 100000 else k.sort  end  as sort2 
 from 

(select bis.RegionID,bis.UserID,ObjectID,SubObjectID,SubObjectOther,Living_PointID,Living_Point,ObjectOther,
sum(case when r.Construction_works=N'yararlı' then 1 else 0 end) yararli,
sum(case when r.Construction_works=N'yararsız' then 1 else 0 end) yararsiz,
sum(case when r.Construction_works=N'əla' then 1 else 0 end) ela
 from business_trip bis inner join Conn_Object_operation r on bis.BusinessTripID=r.BusinessTripID  where AssortinID=4  " + tarixs2 + " " + " " + tarixs1 + "  " + rayon + "  " +
 " " + userid +sahe+teyinat+ " group by bis.RegionID,bis.UserID,ObjectID,SubObjectID,SubObjectOther,Living_PointID,Living_Point,ObjectOther) as lll inner join "+
 "( SELECT COUNT(*) as rynsay,UserID,RegionID FROM business_trip btr where AssortinID=4  " + tarixs22 + " " + " " + tarixs11 + "  " + rayon1 + "  " +
 " " + userid1 + " group by UserID,RegionID )as ryns " +
 "on ryns.RegionID=lll.RegionID and ryns.UserID=lll.UserID inner join Users as u on u.UserID=lll.UserID "+
 "left join List_classification_Regions as r ON lll.RegionID = r.RegionsID  left join List_classifications as b on b.ClassifID=lll.ObjectID "+
 " left join List_SubClassifictions as k on k.ClassifID=lll.SubObjectID    order by " + siralama + "");


        if (ddlsiralama.SelectedValue == "1")
        {
            DataList1.DataSource = klas.tekrarlamax1("Username", "rynsay", "Name", "UserID", "Sn", region2);
             }
        else if (ddlsiralama.SelectedValue == "2")
        {
            
            DataList1.DataSource = klas.tekrarlama011("Username", "rynsay", "Name", "UserID", "Sn", region2);
    
        }
        else
        {
            DataList1.DataSource = klas.tekrarlama011("Username", "rynsay", "Name", "UserID", "Sn", region2);
                //klas.tekrarlama("SubObjectOther", "Sn", region2);
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
        string obj = "";
        string subobj = "";
          if (UserID == null || UserID == "" || UserID == "-1" || UserID == "0")
        {
            user1 = " ";
        }
        else
        {
            user1 = " and b.UserID='" + UserID + "' ";
        }
          if (RegionID == null || RegionID == "" || RegionID == "-1" || RegionID == "0")
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
        if (Construction_works == null &&Construction_works =="")
        {
            purp = " ";
        }
        else
        {
            purp = "and Construction_works=N'" + Construction_works + "' "; 
        }
        if (ObjectID == null || ObjectID == "" || ObjectID == "-1" || ObjectID == "0")
        {
            obj = " ";
        }
        else
        {
            obj = " and ObjectID=" + ObjectID + " ";
        }
        if (SubObjectID == null || SubObjectID == "" || SubObjectID == "-1" || SubObjectID == "0")
        {
            subobj = " "; 
        }
        else
        {
           subobj = " and SubObjectID=" + SubObjectID + " ";
      
        }

        string living = "";
          if (Living_PointID == null || Living_PointID == "" || Living_PointID == "-1" || Living_PointID == "0")
        {
            living = " ";
        }
        else
        {
             living = " and Living_PointID=" + Living_PointID + " ";
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
        else
        {
            sirala = "sort2,sort1,userID,RegionID";
        }

        DataTable region2 = klas.getdatatable(@"SELECT    b.BusinessTripID, b.RegionID, b.RegionCome, b.GoFromRegion, r.Name,u.Name+' '+u.Sname as username,
  b.UserID,c.Construction_works,c.WorkView,c.ResultView,c.ObjectID,c.ObjectOther,SubObjectID,SubObjectOther,c.Living_Point,c.Living_PointID,
  case when lc.sort Is null then 100000 else lc.sort  end  as sort1,
case when k.sort Is null then 100000 else k.sort  end  as sort2
  FROM  business_trip as b INNER JOIN Conn_Object_operation as c ON b.BusinessTripID = c.BusinessTripID
  inner join Users as u on u.UserID=b.UserID
   left join List_classification_Regions as r ON b.RegionID = r.RegionsID 
   left join List_classifications as lc on lc.ClassifID=c.ObjectID 
 left join List_SubClassifictions as k on k.ClassifID=c.SubObjectID 
   where AssortinID=4 " + rayon + "   " + tarixs22 + " " + tarixs11 + " " + user1 + " " + purp + obj + subobj + living +
                        " " + user2 + " " + rayon2 +
    " order by " + sirala + " ");
     
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
        Response.AppendHeader("content-disposition", "attachment; filename=Hesabattehlil.doc;");
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
            Response.Redirect("Baxkecisttehlil.aspx?islem=rayon0");
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
    protected void ddlsahe_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlsahe.SelectedValue == "0")
        {
            ddlteyinat.Enabled = false;

        }
        else
        {
            ddlteyinat.Enabled = true;
        }

        teyinat();
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