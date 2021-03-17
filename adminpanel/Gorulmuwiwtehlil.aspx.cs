using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class adminpanel_Gorulmuwiwtehlil : System.Web.UI.Page
{
    Class2 klas = new Class2();string islem; string UserID; string RegionID; string tarix1; string tarix2;
    string tarix3; string tarix4;
    protected void Page_Load(object sender, EventArgs e)
    { 
        try
        {
            islem = Request.QueryString["islem"];
            UserID = Request.QueryString["UserID"];
            RegionID = Request.QueryString["RegionID"];
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
           LinkButton lblprofil = (LinkButton)Master.FindControl("Hesabattehlili");
            lblprofil.BackColor = Color.Peru;
        if (Page.IsPostBack == false)
        {
            if (islem == "rayon0")
            {
                sifirinci();
            }
            else
                if (islem == "userler")
                {
                    ikinci();
                }

        }
    }
    void ikinci()
    {
        string trx1 = "";
        string trx2 = "";

        if (tarix1 == "")
        {
            trx1 = " ";

        }
        else
        {
            trx1 = " and bis.RegionCome >='" + tarix1 + "'";
        }
        if (tarix2 == "")
        {
            trx2 = " ";

        }
        else
        {
            trx2 = " and bis.GoFromRegion <='" + tarix2 + "'";
        }

        string reg;
        if (RegionID == null)
        {
            reg = " ";
        }
        else
        {
            reg = " and bis.RegionID=" + RegionID;
        }
        string user;
        if (UserID == null)
        {
            user = " ";
        }
        else
        {
            user = " and u.UserID=" + UserID;
        }

      
        Panel3.Visible = true;
        Panel1.Visible = false;
        DataTable region3 = klas.getdatatable(@"SELECT u.userid,bis.BusinessTripID,bis.RegionID,bis.RegionCome,bis.GoFromRegion,bis.ComingToWork,AssortinID,
u.Name+' '+u.Sname as Name,bis.Regions from
business_trip as bis inner join Users as u on u.UserID=bis.UserID
 where 1=1 " + reg + user  + trx2 + trx1 + " ");
        rp3.DataSource = region3;
        rp3.DataBind();
    }
      void sifirinci()
      {
          Panel1.Visible = true;
          // Panel2.Visible = false;
          string tarixs1 = "";
          string tarixs2 = "";

          if (lblgetme1.Text != "")
          {
              tarixs1 = "'" + lblgetme1.Text + "'";
          }
          else
          {
              tarixs1 = "'2030-12-01'";

          }
          if (lblgelme1.Text != "")
          {
              tarixs2 = "'" + lblgelme1.Text + "'";
          }
          else
          {
              tarixs2 = "'2000-01-01'";
          }

          DataTable region2 = klas.getdatatable(@"declare @p1 datetime
set @p1=" + tarixs2 + " declare @p2 datetime set @p2=" + tarixs1 +
" Select s.Name+' '+Sname Name,UserID, " +
   "(select COUNT(*) from ViewFregions_B where UserID=s.UserID and RegionCome>=@p1 and GoFromRegion<=@p2) Umumisay, " +
   "(select COUNT(*) from ViewFregions_B where UserID=s.UserID and BusinessTripIDSend is not null and RegionCome>=@p1 and GoFromRegion<=@p2) umumiGonderilme," +
   "cast(case when (select COUNT(*) from ViewFregions_B where UserID=s.UserID and RegionCome>=@p1 and GoFromRegion<=@p2) <>0 then " +
   "((select COUNT(*) from ViewFregions_B where UserID=s.UserID and BusinessTripIDSend is not null and RegionCome>=@p1 and GoFromRegion<=@p2)/ " +
   "convert(decimal(6,2),(select COUNT(*) from ViewFregions_B where UserID=s.UserID and RegionCome>=@p1 and GoFromRegion<=@p2)))*100 " +
  " else 0 end as decimal(5,1)) umumiFaizG, " +
  " (select COUNT(*) from ViewFregions_B where UserID=s.UserID and BusinessTripIDSend is not null and (datediff(DAY,ComingToWorkb,senddate))<=3 and RegionCome>=@p1 and GoFromRegion<=@p2) vaxtindagonderilme, " +
  " cast(case when (select COUNT(*) from ViewFregions_B where UserID=s.UserID and RegionCome>=@p1 and GoFromRegion<=@p2) <>0 then  " +
   "((select COUNT(*) from ViewFregions_B where UserID=s.UserID and BusinessTripIDSend is not null and (datediff(DAY,ComingToWorkb,senddate))<=3 and RegionCome>=@p1 and GoFromRegion<=@p2)/ " +
   "convert(decimal(6,2),(select COUNT(*) from ViewFregions_B where UserID=s.UserID and RegionCome>=@p1 and GoFromRegion<=@p2)))*100 " +
  " else 0 end as decimal(5,1)) vaxtindagonderilmefaiz, " +
   "(select COUNT(*) from ViewFregions_B where UserID=s.UserID and BusinessTripIDSend is not null and (datediff(DAY,ComingToWorkb,senddate))>3 and RegionCome>=@p1 and GoFromRegion<=@p2) gecikdirmeklegonderilme, " +
  " cast(case when (select COUNT(*) from ViewFregions_B where UserID=s.UserID and RegionCome>=@p1 and GoFromRegion<=@p2) <>0 then  " +
  " ((select COUNT(*) from ViewFregions_B where UserID=s.UserID and BusinessTripIDSend is not null and (datediff(DAY,ComingToWorkb,senddate))>3 and RegionCome>=@p1 and GoFromRegion<=@p2)/  " +
  " convert(decimal(6,2),(select COUNT(*) from ViewFregions_B where UserID=s.UserID and RegionCome>=@p1 and GoFromRegion<=@p2)))*100 " +
  " else 0 end as decimal(5,1)) gecikdirmeklegonderilmefaiz, " +
  " (select COUNT(*) from ViewFregions_B where UserID=s.UserID and BusinessTripIDSend is null and RegionCome>=@p1 and GoFromRegion<=@p2) umumigonderilmeyen, " +
  " cast(case when (select COUNT(*) from ViewFregions_B where UserID=s.UserID and RegionCome>=@p1 and GoFromRegion<=@p2) <>0 then " +
 "  ((select COUNT(*) from ViewFregions_B where UserID=s.UserID and BusinessTripIDSend is null and RegionCome>=@p1 and GoFromRegion<=@p2)/ " +
  " convert(decimal(6,2),(select COUNT(*) from ViewFregions_B where UserID=s.UserID and RegionCome>=@p1 and GoFromRegion<=@p2)))*100 " +
"  else 0 end as decimal(5,1)) umumigonderilmeyenfaiz, " +
 "  (select COUNT(*) from ViewFregions_B where UserID=s.UserID and BusinessTripIDSend is null and (datediff(DAY,ComingToWorkb,senddate))>3 and RegionCome>=@p1 and GoFromRegion<=@p2) VaxtindaGonderilmeyen, " +
"   cast(case when (select COUNT(*) from ViewFregions_B where UserID=s.UserID and RegionCome>=@p1 and GoFromRegion<=@p2) <>0 then  " +
 "  ((select COUNT(*) from ViewFregions_B where UserID=s.UserID and BusinessTripIDSend is null and (datediff(DAY,ComingToWorkb,senddate))>3 and RegionCome>=@p1 and GoFromRegion<=@p2)/ " +
"   convert(decimal(6,2),(select COUNT(*) from ViewFregions_B where UserID=s.UserID and RegionCome>=@p1 and GoFromRegion<=@p2)))*100 " +
 "  else 0 end as decimal(5,1)) VaxtindaFaizGonderilmeyen, " +
"   (select COUNT(*) from ViewFregions_B where UserID=s.UserID and BusinessTripIDSend is null and (datediff(DAY,ComingToWorkb,GETDATE()))>3 and RegionCome>=@p1 and GoFromRegion<=@p2) GecikdirmekleGonderilmeyen, " +
"   cast(case when (select COUNT(*) from ViewFregions_B where UserID=s.UserID and RegionCome>=@p1 and GoFromRegion<=@p2) <>0 then " +
"   ((select COUNT(*) from ViewFregions_B where UserID=s.UserID and BusinessTripIDSend is null and (datediff(DAY,ComingToWorkb,GETDATE()))>3 and RegionCome>=@p1 and GoFromRegion<=@p2)/ " +
 "  convert(decimal(6,2),(select COUNT(*) from ViewFregions_B where UserID=s.UserID and RegionCome>=@p1 and GoFromRegion<=@p2)))*100 " +
"   else 0 end as decimal(5,1)) GecikdirmekleFaizGonderilmeyen from Users s where s.status_users=0 order by s.sortID");
          DataList1.DataSource = region2;
          DataList1.DataBind();

          //DataTable region2 = klas.getdatatable(@"exec ParseDay " + tarixs2 + "," + tarixs1 + " " +
          //    "select users.UserID,users.Name+' '+users.Sname As Name,(case when sum(Yanvar) is null then 0 else sum(Yanvar) end+ case when sum(Fevral) is null then 0 else sum(Fevral) end+ "+
          //    "case when sum(Mart) is null then 0 else sum(Mart) end+case when sum(Aprel) is null then 0 else sum(Aprel) end+ "+
          //    "case when sum(May) is null then 0 else sum(May) end +case when sum(İyun) is null then 0 else sum(İyun) end+ "+
          //    "case when sum(İyul) is null then 0 else sum(İyul) end+case when sum(Avqust) is null then 0 else sum(Avqust) end+ "+
          //    "case when sum(Sentyabr) is null then 0 else sum(Sentyabr) end+case when sum(Oktyabr) is null then 0 else sum(Oktyabr) end+ "+
          //    "case when sum(Noyabr) is null then 0 else sum(Noyabr) end+case when sum(Dekabr) is null then 0 else sum(Dekabr) end) cemi, "+
          //    "sum(Yanvar) Yanvar,sum(Fevral) Fevral,sum(Mart) Mart,sum(Aprel) Aprel,sum(May) May,sum(İyun) "+
          //    "[İyun],sum(İyul) [İyul],sum(Avqust) Avqust,sum(Sentyabr) Sentyabr,sum(Oktyabr) Oktyabr,sum(Noyabr) Noyabr,sum(Dekabr) Dekabr from pivotTableDay "+
          //    "left join Users on users.UserID=pivotTableDay.userid group by users.UserID,users.Name,users.Sname");



          DataList1.DataSource = region2;
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
    protected void btngeri_Click(object sender, EventArgs e)
    {
        if (islem == "userler")
        {
            Response.Redirect("Gorulmuwiwtehlil.aspx?islem=rayon0");
        }
        else
        {
            Response.Redirect("Hesabattehlili.aspx");
        }
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
    protected void Button1_Click1(object sender, EventArgs e)
    {
        lblgelme4.Text = lblgelme.Text;
        lblgetme4.Text = lblgetme.Text;
        lblgelme3.Text = lblgelme1.Text;
        lblgetme3.Text = lblgetme1.Text;

        sifirinci();
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
        pnlprint.RenderControl(htmlTextWritter);
        Response.Write(stringWritter.ToString());
        Response.End();
    }
}