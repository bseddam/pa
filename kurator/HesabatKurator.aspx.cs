using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class kurator_HesabatKurator : System.Web.UI.Page
{
    Class2 klas = new Class2(); string islem1; string islem; string BusinessTripID; string rownumber = ""; string RayonID;
    string RegionCode; string RegionID; string UserID;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            //aranacak = Request.QueryString["aranacak"];
            islem1 = Request.QueryString["islem1"];
            islem = Request.QueryString["islem"];
            BusinessTripID = Request.QueryString["BusinessTripID"];
            Session["BusinessTripID"] = BusinessTripID;
            rownumber = Request.QueryString["rownumber"];
            RayonID = Request.QueryString["RayonID"];
            Session["RayonID"] = RayonID;
            RegionCode = Request.QueryString["RegionCode"];
            UserID = Request.QueryString["UserID"];
            RegionID = Request.QueryString["RayonID"];
        }
        catch (Exception)
        { }
        Calendar1.SelectedDates.Clear();
        Calendar3.SelectedDates.Clear();
        if (Page.IsPostBack == false)
        {
            LinkButton lblvizual = (LinkButton)Master.FindControl("Hesabatlar");
            lblvizual.BackColor = Color.Peru;

            pnlhesabatabax.Visible = false;
            pnlyenideniwle.Visible = false;
            string useradsoyad;
            if (islem == "fayl")
            {
                DataRow user = klas.GetDataRow("select Name +' '+ Sname as Name from Users where UserID=" + UserID);
                if (user != null)
                {
                    useradsoyad = user["Name"].ToString();

                    DataRow dtcel = klas.GetDataRow("select FileName from business_trip where BusinessTripID=" + BusinessTripID);
                    if (dtcel["FileName"].ToString() != "" && dtcel != null)
                    {
                        System.IO.FileInfo Dfile = new System.IO.FileInfo(Server.MapPath("~/hesabatirad/" + useradsoyad + "/" + dtcel["FileName"].ToString()));
                        if (Dfile.Exists)
                        {
                            Response.Clear();
                            Response.AddHeader("Content-Disposition", "attachment; filename=" + dtcel["FileName"].ToString());
                            Response.AddHeader("Content-Length", Dfile.Length.ToString());
                            Response.ContentType = "application/octet-stream";
                            Response.WriteFile(Dfile.FullName);
                            Response.End();
                        }
                    }
                    datalistrayontarix();
                }
            }
            if (islem == "rayonsil")
            {
                klas.cmd("Delete from business_trip Where BusinessTripID=" + BusinessTripID);
                Response.Redirect("HesabatKurator.aspx");
            }
            if (islem == "faylsil")
            {
                DataRow user = klas.GetDataRow("select Name +' '+ Sname as Name from Users where UserID=" + UserID);
                if (user != null)
                {
                    useradsoyad = user["Name"].ToString();

                    DataRow dtsil = klas.GetDataRow("select FileName from business_trip where BusinessTripID=" + BusinessTripID);
                    if (dtsil["FileName"].ToString() != "" && dtsil != null)
                    {
                        System.IO.FileInfo file = new System.IO.FileInfo(Server.MapPath("~/hesabatirad/" + useradsoyad + "/" + dtsil["FileName"].ToString()));
                        if (file.Exists)//check file exsit or not
                        {
                            file.Delete();
                            SqlConnection baglanti = klas.baglan();
                            SqlCommand cmd2 = new SqlCommand("Update business_trip set FileName=null where BusinessTripID=" + BusinessTripID, baglanti);

                            cmd2.ExecuteNonQuery();
                        }
                    }
                    datalistrayontarix();
                }
            }

            if (islem1 == "adminislem1")
            {
                lbldey.Text = "1";
                Panel1.Visible = true;
                Calendar1.Visible = false;
                lblgelme.Visible = false;
                imgbsilgelme.Visible = false;
                Calendar3.Visible = false;
                lblgetme.Visible = false;
                imgbsilgetme0.Visible = false;
                lblgelme.Text = "";
                lblgetme.Text = "";
                lblgelme1.Text = "";
                lblgetme1.Text = "";


                btntesdiqolunmuw.BackColor = SystemColors.ButtonFace;
                btnbaxish.BackColor = Color.Aquamarine;
                btnyenidenile.BackColor = SystemColors.ButtonFace;
                pnlhesabatabax.Visible = true;
                pnlyenideniwle.Visible = false;

                if (lblgetme1.Text == "")
                {
                    lblgetme1.Text = "2020-01-01";
                }
                if (lblgelme1.Text == "")
                {
                    lblgelme1.Text = "2015-01-01";
                }
                datalistrayontarix();
                ryn1();

            }
            if (islem1 == "adminislem3")
            {
                lbldey.Text = "3";
                btntesdiqolunmuw.BackColor = SystemColors.ButtonFace;
                btnbaxish.BackColor = SystemColors.ButtonFace;
                btnyenidenile.BackColor = Color.Aquamarine;
                pnlhesabatabax.Visible = false;
                pnlyenideniwle.Visible = true;
                dlyenideniwle();
            }
            if (islem1 == "1")
            {
                Panel1.Visible = true;
                Calendar1.Visible = false;
                lblgelme.Visible = false;
                imgbsilgelme.Visible = false;
                Calendar3.Visible = false;
                lblgetme.Visible = false;
                imgbsilgetme0.Visible = false;
                lblgelme.Text = "";
                lblgetme.Text = "";
                lblgelme1.Text = "";
                lblgetme1.Text = "";


                btnbaxish.BackColor = Color.Aquamarine;
                btnyenidenile.BackColor = SystemColors.ButtonFace;
                pnlhesabatabax.Visible = true;
                pnlyenideniwle.Visible = false;
    
                if (lblgetme1.Text == "")
                {
                    lblgetme1.Text = "2020-01-01";
                }
                if (lblgelme1.Text == "")
                {
                    lblgelme1.Text = "2015-01-01";
                }
                datalistrayontarix();
                ryn1();
            }
            if (islem1 == "adminislem4")
            {
                lbldey.Text = "4";
                Panel1.Visible = true;
                Calendar1.Visible = false;
                lblgelme.Visible = false;
                imgbsilgelme.Visible = false;
                Calendar3.Visible = false;
                lblgetme.Visible = false;
                imgbsilgetme0.Visible = false;
                lblgelme.Text = "";
                lblgetme.Text = "";
                lblgelme1.Text = "";
                lblgetme1.Text = "";


                btnyenidenile.BackColor = SystemColors.ButtonFace;
                btnbaxish.BackColor = SystemColors.ButtonFace;
                btntesdiqolunmuw.BackColor = Color.Aquamarine;
                pnlhesabatabax.Visible = true;
                pnlyenideniwle.Visible = false;
       
                if (lblgetme1.Text == "")
                {
                    lblgetme1.Text = "2020-01-01";
                }
                if (lblgelme1.Text == "")
                {
                    lblgelme1.Text = "2015-01-01";
                }
                datalistrayontarix();
                ryn1();
            }


        }
    }


    void datalistrayontarix()
    {
        string asort = "";
        if (lbldey.Text == "1")
        {
            asort = "and (AssortinID=" + int.Parse(lbldey.Text) + " or AssortinID=2)";
        }
        else if (lbldey.Text == "4")
        {
            asort = "and AssortinID=" + int.Parse(lbldey.Text);
        }
        string s = @"SELECT     dbo.Users.Name + ' ' + dbo.Users.Sname AS username, dbo.Users.UserID, dbo.business_trip.RegionCome, dbo.business_trip.GoFromRegion, 
                     dbo.business_trip.FileName,dbo.business_trip.ComingToWork, dbo.business_trip.Regions, dbo.business_trip.RegionID, dbo.business_trip.BusinessTripID
FROM         dbo.Users INNER JOIN  dbo.business_trip ON dbo.Users.UserID = dbo.business_trip.UserID where 1=1 and (dbo.Users.UserID = '" + Session["UserID"].ToString() + "')"
            + asort + " ORDER BY   dbo.Users.Name, dbo.business_trip.RegionCome DESC";
        //and (dbo.FRegions.Approval <> 3)

        DataTable dtGruplar = klas.getdatatable(s);
        DataList1.DataSource = dtGruplar;
        DataList1.DataBind();
        if (dtGruplar.Rows.Count > 0)
        {
            lblmesage.Text = "";
            exele.Visible = true;
            Panel1.Visible = true;
        }
        else
        {
            lblmesage.Text = "Tapılmadı";
            lblmesage.ForeColor = Color.Red;
            exele.Visible = false;
            Panel1.Visible = false;
        }
    }
    void dlyenideniwle()
    {

        string s = @"SELECT     dbo.Users.Name + ' ' + dbo.Users.Sname AS username, dbo.Users.UserID, dbo.business_trip.RegionCome, dbo.business_trip.GoFromRegion,  
dbo.business_trip.FileName,dbo.business_trip.ComingToWork, dbo.business_trip.Regions, dbo.business_trip.RegionID, dbo.business_trip.BusinessTripID
FROM dbo.Users INNER JOIN dbo.business_trip ON dbo.Users.UserID = dbo.business_trip.UserID  where AssortinID=3 and (dbo.Users.UserID = '"
            + Session["UserID"].ToString() + "') ORDER BY "+
" dbo.Users.Name, dbo.business_trip.RegionCome DESC";

        DataTable dtGruplar = klas.getdatatable(s);
        rpyenideniwle.DataSource = dtGruplar;
        rpyenideniwle.DataBind();
        if (dtGruplar.Rows.Count > 0)
        {
            lbltapilmadi.Text = "";
            Panel4.Visible = true;

        }
        else
        {
            Panel4.Visible = false;
            lbltapilmadi.Text = "Tapılmadı";
            lbltapilmadi.ForeColor = Color.Red;
        }
    }




    protected void Button1_Click(object sender, EventArgs e)
    {
        string asort = "";
        if (lbldey.Text == "1")
        {
            asort = "and (AssortinID=" + int.Parse(lbldey.Text) + " or AssortinID=2)";
        }
        else if (lbldey.Text == "4")
        {
            asort = "and AssortinID=" + int.Parse(lbldey.Text);
        }

        if (lblgetme1.Text == "")
        {
            lblgetme1.Text = "2020-01-01";

        }
        if (lblgelme1.Text == "")
        {
            lblgelme1.Text = "2015-01-01";
        }
        string s = "";
        string ltext = "";
        if (ddlryn.SelectedValue != "-1" && ddlryn.SelectedValue != "0")
        {
            ltext = @" and  (dbo.Users.UserID = '" + Session["UserID"].ToString() + "')  and dbo.business_trip.RegionID= '" + ddlryn.SelectedValue + "' AND (dbo.business_trip.RegionCome >= '" + lblgelme1.Text + "' ) AND (dbo.business_trip.GoFromRegion <= '" + lblgetme1.Text + "') ";
            //Response.Write("1"); 
        }
        else if (ddlryn.SelectedValue == "-1")
        {

            ltext = @"  and (dbo.Users.UserID = '" + Session["UserID"].ToString() + "')  AND (dbo.business_trip.RegionCome >= '" + lblgelme1.Text + "' ) AND (dbo.business_trip.GoFromRegion <= '" + lblgetme1.Text + "') ";


            //  Response.Write("3");
            //  Response.Write("gelme=" + lblgetme1.Text);
        }
        else if ( ddlryn.SelectedValue != "-1"  && ddlryn.SelectedValue != "0")
        {
            ltext = @"and  (dbo.Users.UserID = '" + Session["UserID"].ToString() + "') and dbo.business_trip.RegionID= '" + ddlryn.SelectedValue + "' AND (dbo.business_trip.RegionCome >= '" + lblgelme1.Text + "' ) AND (dbo.business_trip.GoFromRegion <= '" + lblgetme1.Text + "')";

            // Response.Write("4");
        }

        else
        {
          
            ltext = @"and  (dbo.Users.UserID = '" + Session["UserID"].ToString() + "') and   (dbo.business_trip.RegionCome >= '" + lblgelme1.Text + "' ) AND (dbo.business_trip.GoFromRegion <= '" + lblgetme1.Text + "') ";
            
     
        }


        s = @"SELECT     dbo.Users.Name + ' ' + dbo.Users.Sname AS username, dbo.Users.UserID, dbo.business_trip.RegionCome, dbo.business_trip.GoFromRegion, dbo.business_trip.FileName,
                      dbo.business_trip.ComingToWork, dbo.business_trip.Regions, dbo.business_trip.RegionID, dbo.business_trip.BusinessTripID
FROM         dbo.Users INNER JOIN
                      dbo.business_trip ON dbo.Users.UserID = dbo.business_trip.UserID
                    
WHERE     1=1  " + asort + " " + ltext + " ORDER BY dbo.Users.Name, dbo.business_trip.RegionCome DESC";
        // Response.Write("5"); 



        DataTable dtGruplar = klas.getdatatable(s);
        DataList1.DataSource = dtGruplar;
        DataList1.DataBind();
        if (dtGruplar.Rows.Count > 0)
        {
            Panel1.Visible = true;
            lblmesage.Text = "";
            exele.Visible = true;
            Panel1.Visible = true;
        }
        else
        {
            Panel1.Visible = false;
            lblmesage.Text = "Tapılmadı";
            lblmesage.ForeColor = Color.Red;
            exele.Visible = false;
            Panel1.Visible = false;
        }
    }


    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        if (Calendar1.Visible)
        {
            Calendar1.Visible = false;
            lblgelme.Visible = true;
            imgbsilgelme.Visible = true;

        }
        else
        {
            imgbsilgelme.Visible = false;
            Calendar1.Visible = true;
            lblgelme.Visible = false;
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
            imgbsilgetme0.Visible = true;
        }
        else
        {
            Calendar3.Visible = true;
            lblgetme.Visible = false;
            imgbsilgetme0.Visible = false;
        }
        if (lblgetme.Text == "")
        {
            imgbsilgetme0.Visible = false;
        }
    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        lblgelme.Text = Calendar1.SelectedDate.ToString("d");
        lblgelme1.Text = Calendar1.SelectedDate.ToString("yyyy-MM-dd");
        Calendar1.Visible = false;
        lblgelme.Visible = true;
        imgbsilgelme.Visible = true;
    }
    protected void Calendar3_SelectionChanged(object sender, EventArgs e)
    {
        lblgetme.Text = Calendar3.SelectedDate.ToString("d");
        lblgetme1.Text = Calendar3.SelectedDate.ToString("yyyy-MM-dd");
        Calendar3.Visible = false;
        lblgetme.Visible = true;
        imgbsilgetme0.Visible = true;
    }


    protected void exele_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < DataList1.Items.Count; i++)
        {
            ((System.Web.UI.WebControls.Panel)(DataList1.Items[i].FindControl("Panel2"))).Visible = false;
        }
        Panel3.Visible = false;
        Response.ClearContent();
        Response.AppendHeader("content-disposition", "attachment; filename=Hesabatsiyahi.doc");
        Response.ContentType = "application/excel";
        Response.ContentEncoding = System.Text.Encoding.UTF8;
        Response.BinaryWrite(System.Text.Encoding.UTF8.GetPreamble());
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        StringWriter stringWritter = new StringWriter();
        HtmlTextWriter htmlTextWritter = new HtmlTextWriter(stringWritter);
        Panel1.RenderControl(htmlTextWritter);
        Response.Write(stringWritter.ToString());
        Response.End();
    }
    protected void imgbsilgelme_Click(object sender, ImageClickEventArgs e)
    {
        lblgelme.Text = "";
        lblgelme1.Text = "";
        imgbsilgelme.Visible = false;
    }
    protected void imgbsilgetme0_Click(object sender, ImageClickEventArgs e)
    {
        lblgetme.Text = "";
        lblgetme1.Text = "";
        imgbsilgetme0.Visible = false;
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
        DataTable dtiller = klas.getdatatable("Select * from List_classification_Regions where UserID='" + Session["UserID"].ToString() + "' and ForDelete=1 order by [Name]");
        ddlryn.DataTextField = "Name";
        ddlryn.DataValueField = "RegionsID";
        ddlryn.DataSource = dtiller;
        ddlryn.DataBind();
        ddlryn.Items.Insert(0, new ListItem("Seçin", "0"));
        ddlryn.Items.Insert(1, new ListItem("Ümumi", "-1"));
        ddlryn.SelectedValue = "-1";
    }
    public static string yuklegorun(string yukle)
    {
        string deger = "";
        if (yukle == "")
        {
            deger = "false";
        }
        else
        {
            deger = "true";
        }
        return deger;
    }

    protected void btnbaxish_Click(object sender, EventArgs e)
    {
        lbldey.Text = "1";
        Panel1.Visible = true;
        Calendar1.Visible = false;
        lblgelme.Visible = false;
        imgbsilgelme.Visible = false;
        Calendar3.Visible = false;
        lblgetme.Visible = false;
        imgbsilgetme0.Visible = false;
        lblgelme.Text = "";
        lblgetme.Text = "";
        lblgelme1.Text = "";
        lblgetme1.Text = "";


        btntesdiqolunmuw.BackColor = SystemColors.ButtonFace;
        btnbaxish.BackColor = Color.Aquamarine;
        btnyenidenile.BackColor = SystemColors.ButtonFace;
        pnlhesabatabax.Visible = true;
        pnlyenideniwle.Visible = false;

        if (lblgetme1.Text == "")
        {
            lblgetme1.Text = "2020-01-01";
        }
        if (lblgelme1.Text == "")
        {
            lblgelme1.Text = "2015-01-01";
        }
        datalistrayontarix();
        ryn1();
    }
    protected void btnyenidenile_Click(object sender, EventArgs e)
    {

        lbldey.Text = "3";

        btntesdiqolunmuw.BackColor = SystemColors.ButtonFace;
        btnbaxish.BackColor = SystemColors.ButtonFace;
        btnyenidenile.BackColor = Color.Aquamarine;
        pnlhesabatabax.Visible = false;
        pnlyenideniwle.Visible = true;
        dlyenideniwle();
    }

    protected void btntesdiqolunmuw_Click(object sender, EventArgs e)
    {
        lbldey.Text = "4";
        Panel1.Visible = true;
        Calendar1.Visible = false;
        lblgelme.Visible = false;
        imgbsilgelme.Visible = false;
        Calendar3.Visible = false;
        lblgetme.Visible = false;
        imgbsilgetme0.Visible = false;
        lblgelme.Text = "";
        lblgetme.Text = "";
        lblgelme1.Text = "";
        lblgetme1.Text = "";


        btnyenidenile.BackColor = SystemColors.ButtonFace;
        btnbaxish.BackColor = SystemColors.ButtonFace;
        btntesdiqolunmuw.BackColor = Color.Aquamarine;
        pnlhesabatabax.Visible = true;
        pnlyenideniwle.Visible = false;

        if (lblgetme1.Text == "")
        {
            lblgetme1.Text = "2020-01-01";
        }
        if (lblgelme1.Text == "")
        {
            lblgelme1.Text = "2015-01-01";
        }
        datalistrayontarix();
        ryn1();
    }
}