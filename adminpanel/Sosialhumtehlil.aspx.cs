using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class adminpanel_Sosialhumtehlil : System.Web.UI.Page
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
                // pnlbirinci.Visible = false;
                ryn();
                sahe();
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
    void sifirinci()
    {
        string rayon;
        string rayon1;
        string userid;
        string userid1;
        string sahe;
        string teyinat;
        string icrabarqeyd;
        if (ddlicrabarqeyd.SelectedValue == "0" || ddlicrabarqeyd.SelectedValue == "-1" || ddlicrabarqeyd.SelectedValue == "")
        {
            icrabarqeyd = "  ";
        }
        else
        {
            icrabarqeyd = " and IcraBaredeMelumat='" + ddlicrabarqeyd.SelectedValue + "' ";
        }


        if (ddlsahe.SelectedValue == "0" || ddlsahe.SelectedValue == "-1" || ddlsahe.SelectedValue == "")
        {
            sahe = "  ";
        }
        else
        {
            sahe = " and Shkod1='" + ddlsahe.SelectedValue + "' ";
        }
        if (ddlteyinat.SelectedValue == "0" || ddlteyinat.SelectedValue == "-1" || ddlteyinat.SelectedValue == "")
        {
            teyinat = "  ";
        }
        else
        {
            teyinat = " and Shkod2='" + ddlteyinat.SelectedValue + "' ";
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
        lblsaheler.Text = klas.getdatacell(@"select COUNT(*) as meqcem from (SELECT distinct Shkod1,sh1 FROM  
TS10_2  as r inner join business_trip as bis ON r.BusinessTripID = bis.BusinessTripID 
where AssortinID=4 and statussablon=0  " + tarixs2 + " " + " " + tarixs1 + "  " + rayon + "  " + " " + userid + sahe + teyinat +icrabarqeyd+ " )as cc");
        lblteyuzre.Text = klas.getdatacell(@"select COUNT(*) as meqcem from (SELECT distinct Shkod2,sh2 FROM  
TS10_2  as r inner join business_trip as bis ON r.BusinessTripID = bis.BusinessTripID 
where AssortinID=4 and statussablon=0  " + tarixs2 + " " + " " + tarixs1 + "  " + rayon + "  " + " " + userid + sahe + teyinat +icrabarqeyd+ " )as cc");




        DataTable region2 = klas.getdatatable(@"select  u.Name+' '+u.Sname  as Username,lll.RegionID
,u.UserID,lll.SerbestMetn1,Shkod1,Shkod2,sh1,sh2,icrabarmel,
case when b.SortA_Z Is null then 100000 else b.SortA_Z  end  as sort1,
case when k.sort Is null then 100000 else k.sort  end  as sort2 ,
CONVERT(varchar(1000),ryns.rynsay)rynsay,r.Name,lll.BusinessTripID  
from 
(
select case when IcraBaredeMelumat =1 then N'İcrasına başlanmamışdır. Səbəb: ' +lower(Sebeb) 
 when IcraBaredeMelumat =2 then SerbestMetn2 end as icrabarmel,
SerbestMetn1,bis.RegionID,bis.UserID,
Icra_tarix,IHBMektub,MektubNomre,MektubTarix,DPAdi,DPIL,IcrasiRazilashdirilib,Vezifesi,Adi,Soyadi,Telefonu,dp_diger,
sh1,Shkod1,sh2,Shkod2,bis.BusinessTripID
  from business_trip bis  inner join TS10_2 o on bis.BusinessTripID=o.BusinessTripID where  statussablon=0 and  bis.AssortinID=4  " + tarixs2 + " " + " " + tarixs1 + "  " + rayon + "  " +
 " " + userid + sahe + teyinat + icrabarqeyd+" " +
 ") as lll inner join ( SELECT COUNT(*) as rynsay,UserID,RegionID FROM business_trip btr where AssortinID=4  " 
 + tarixs22 + " " + " " + tarixs11 + "  " + rayon1 + "  " +" " + userid1 + " group by UserID,RegionID )as ryns " +
        "on ryns.RegionID=lll.RegionID and ryns.UserID=lll.UserID  "+
        "inner join Users as u on u.UserID=lll.UserID  "+
 "left join List_classification_Regions as r ON lll.RegionID = r.RegionsID  "+
 "left join List_classifications_SHablon as b on b.ClassifID=lll.Shkod1 " +
 "left join List_SubClassifictions_SHablon as k on k.ClassifID=lll.Shkod2 " +
 " order by "+siralama+" ");
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
    void sahe()
    {
        DataTable meqsed = klas.getdatatable("Select ClassifID,ClassifName,ListID from List_classifications_SHablon where ListID=10 order by SortA_Z");
        ddlsahe.DataTextField = "ClassifName";
        ddlsahe.DataValueField = "ClassifID";
        ddlsahe.DataSource = meqsed;
        ddlsahe.DataBind();
        ddlsahe.Items.Insert(0, new ListItem("Ümumi", "-1"));
    }
    void teyinat()
    {
        DataTable dtilceler = klas.getdatatable("Select * from List_SubClassifictions_SHablon Where MainClassifId=" + ddlsahe.SelectedValue + "");
        ddlteyinat.DataTextField = "ClassificationName";
        ddlteyinat.DataValueField = "ClassifID";
        ddlteyinat.DataSource = dtilceler;
        ddlteyinat.DataBind();
        ddlteyinat.Items.Insert(0, new ListItem("Ümumi", "-1"));
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
}