using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class adminpanel_Muddetlertehlil : System.Web.UI.Page
{
    Class2 klas = new Class2(); string islem; string UserID; string RegionID; string tarix1; string tarix2;
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
        LinkButton lblprofil = (LinkButton)Master.FindControl("Hesabattehlili");
        lblprofil.BackColor = Color.Peru;
        Calendar1.SelectedDates.Clear();
        Calendar3.SelectedDates.Clear();
        if (Page.IsPostBack == false)
        {
            if (islem == "rayon0")
            {
                sifirinci();
            }
            else
                if (islem == "userler")
                {
                    birinci();
                }
                else { 
                ikinci();
                }
            
        }
    }
    void birinci() {
        Panel2.Visible = true;
        Panel1.Visible = false;
        Panel3.Visible = false;
        DataTable region3 = klas.getdatatable(@"select Users.UserID,r.Name region,users.Name+' '+users.Sname As Name,Sname,str(pivotTableDay.Yanvar, 10, 2) Yanvar,
                                               str(pivotTableDay.Fevral, 10, 2) Fevral,
                                               str(pivotTableDay.Mart, 10, 2) Mart,
str(pivotTableDay.Aprel, 10, 2) Aprel,
str(pivotTableDay.May, 10, 2) May,
str(pivotTableDay.İyun, 10, 2) İyun,
str(pivotTableDay.İyul, 10, 2) İyul,
str(pivotTableDay.Avqust, 10, 2) Avqust,
str(pivotTableDay.Sentyabr, 10, 2) Sentyabr,
str(pivotTableDay.Oktyabr, 10, 2) Oktyabr,
str(pivotTableDay.Noyabr, 10, 2) Noyabr,
str(pivotTableDay.Dekabr, 10, 2) Dekabr,
pivotTableDay.RegionID
from 
pivotTableDay left join Users on users.UserID=pivotTableDay.userid inner join List_classification_Regions r on r.RegionsID=pivotTableDay.RegionID where Users.UserID=" + UserID);
        DataList2.DataSource = region3;
        DataList2.DataBind();
    }
    void ikinci()
    {
        string trx1 = "";
        string trx2 = "";

        if (tarix1 == "")
        {
            trx1 = " ";
          
        }
        else {
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
        reg=" ";
        }
        else {
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
        string iw;
        if (islem == null)
        {
            iw = " ";
        }
        else
        {
            iw = " and MONTH(RegionCome) =" + islem;
        }
        Panel3.Visible = true;
        Panel2.Visible = false;
        Panel1.Visible = false;
        DataTable region3 = klas.getdatatable(@"SELECT u.userid,bis.BusinessTripID,bis.RegionID,bis.RegionCome,bis.GoFromRegion,bis.ComingToWork,AssortinID,
u.Name+' '+u.Sname as Name,bis.Regions from
business_trip as bis inner join Users as u on u.UserID=bis.UserID
 where 1=1 " + reg + user + iw + trx2 + trx1 + " order by  bis.RegionCome desc, bis.GoFromRegion desc");
        rp3.DataSource = region3;
        rp3.DataBind();
    }
    protected void btngeri_Click(object sender, EventArgs e)
    {
        if (islem == "userler")
        {
            Response.Redirect("Muddetlertehlil.aspx?islem=rayon0");
        }
        else if (islem == "rayon0")
        {
            Response.Redirect("Hesabattehlili.aspx");
        }
        else if (RegionID != null) {
            Response.Write(RegionID);
           
            Response.Redirect("Muddetlertehlil.aspx?UserID=" + UserID+"&islem=userler&tarix1="+lblgelme1.Text+"&tarix2="+lblgetme1.Text+"&tarix3="+lblgelme.Text+"&tarix4="+lblgetme.Text+"");
      }
        else
        {
            Response.Redirect("Muddetlertehlil.aspx?islem=rayon0");
        }

    }
    public static string kesiki(string muddet)
    {
        string subString = "";
        if (muddet.Length >= 2)
        {
            subString = muddet.Substring(0, 2);
        }
        else {
            subString = muddet;
        }
        return subString;
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
    protected void Button1_Click1(object sender, EventArgs e)
    {
         lblgelme4.Text = lblgelme.Text;
        lblgetme4.Text = lblgetme.Text;
        lblgelme3.Text = lblgelme1.Text;
        lblgetme3.Text = lblgetme1.Text;

        sifirinci();
    }
    void sifirinci()
    {
        Panel3.Visible = false;
        Panel1.Visible = true;
        Panel2.Visible = false;
        string tarixs1 = "";
        string tarixs2 = "";

        if (lblgetme1.Text != "")
        {
            tarixs1 = "'" + lblgetme1.Text + "'";
           }
        else {
            tarixs1 = "'2030-12-01'"; 
       
        }
        if (lblgelme1.Text != "")
        {
            tarixs2 = "'" + lblgelme1.Text + "'";
               }
        else {
            tarixs2 = "'2000-01-01'";
        }
        DataTable region2 = klas.getdatatable(@"exec ParseDay " + tarixs2 + "," + tarixs1 + " " +
            "select users.UserID,users.Name+' '+users.Sname As Name,(case when sum(Yanvar) is null then 0 else sum(Yanvar) end+ case when sum(Fevral) is null then 0 else sum(Fevral) end+ "+
            "case when sum(Mart) is null then 0 else sum(Mart) end+case when sum(Aprel) is null then 0 else sum(Aprel) end+ "+
            "case when sum(May) is null then 0 else sum(May) end +case when sum(İyun) is null then 0 else sum(İyun) end+ "+
            "case when sum(İyul) is null then 0 else sum(İyul) end+case when sum(Avqust) is null then 0 else sum(Avqust) end+ "+
            "case when sum(Sentyabr) is null then 0 else sum(Sentyabr) end+case when sum(Oktyabr) is null then 0 else sum(Oktyabr) end+ "+
            "case when sum(Noyabr) is null then 0 else sum(Noyabr) end+case when sum(Dekabr) is null then 0 else sum(Dekabr) end) cemi, "+
            "sum(Yanvar) Yanvar,sum(Fevral) Fevral,sum(Mart) Mart,sum(Aprel) Aprel,sum(May) May,sum(İyun) "+
            "[İyun],sum(İyul) [İyul],sum(Avqust) Avqust,sum(Sentyabr) Sentyabr,sum(Oktyabr) Oktyabr,sum(Noyabr) Noyabr,sum(Dekabr) Dekabr from pivotTableDay "+
            "left join Users on users.UserID=pivotTableDay.userid group by users.UserID,users.Name,users.Sname");



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
}