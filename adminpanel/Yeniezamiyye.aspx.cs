using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class adminpanel_Ezamteqvim : System.Web.UI.Page
{
    Class2 klas = new Class2(); int a = 0; string islem; string BusinessTripID; string userid; string regionid; string rownumber = "";
    string regiongelme; string regiongetme; string isecixma; string RayonID; string RegionCode; string UserID; string islem1;
    string RegionID; string Purpose;
    protected void Page_Load(object sender, EventArgs e)
    {
    
        Calendar1.SelectedDates.Clear();
        Calendar3.SelectedDates.Clear();
        Calendar2.SelectedDates.Clear();
        Calendar4.SelectedDates.Clear();
        cldraygetmetrx.SelectedDates.Clear();
        cldraygelmetrx.SelectedDates.Clear();
        try
        {
            islem1 = Request.QueryString["islem1"];
            islem = Request.QueryString["islem"];
            BusinessTripID = Request.QueryString["BusinessTripID"];
            rownumber = Request.QueryString["rownumber"];
            UserID = Request.QueryString["UserID"];
            RegionID = Request.QueryString["RayonID"];
            Purpose = Request.QueryString["Purpose"];
            Session["RegionID"] = RegionID;
        }
        catch (Exception)
        { }
        if (Page.IsPostBack == false)
        {

            ryn1();
            users3();
            ddlusers3.Items.Insert(0, new ListItem("Seçin", "0"));
            ddlusers3.Items.Insert(1, new ListItem("Ümumi", "-1"));
            ddlusers3.SelectedValue = "-1";

            users();
            ddlusers.Items.Insert(0, new ListItem("Seçin", "0"));
            ddlusers.Items.Insert(1, new ListItem("Ümumi", "-1"));
            ddlusers.SelectedValue = "0";
      
            LinkButton lblvizual = (LinkButton)Master.FindControl("Yeniezamiyye");
            lblvizual.BackColor = Color.Peru;
              
            string useradsoyad;
           
           
            if (islem == "fayl")
            {
                DataRow user = klas.GetDataRow("select Name +' '+ Sname as Name from Users where UserID=" + UserID);
                if (user != null)
                {
                    useradsoyad = user["Name"].ToString();
                btntesdiqolmuw0.BackColor = Color.GreenYellow;
                
                Session[rownumber] = null;
                dlgonderumumi.Visible = false;
                dlteqdimolunmuw.Visible = true;
                btngonray.BackColor = Color.Aquamarine;
                btngonumumi.BackColor = SystemColors.ButtonFace;
                pnlgonderilmeyen.Visible = true;
                DataRow dtcel = klas.GetDataRow("select FileName from FRegions where RegionID=" + RegionID);
                if (dtcel["FileName"].ToString() != "" && dtcel != null)
                {

                    System.IO.FileInfo Dfile = new System.IO.FileInfo(Server.MapPath("~/iradlar/" + useradsoyad + "/" + dtcel["FileName"].ToString()));
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
                    teqdimolunmuw();
            }
            }
            if (islem == "faylsil")
            {
                DataRow user = klas.GetDataRow("select Name +' '+ Sname as Name from Users where UserID=" + UserID);
                if (user != null)
                {
                    useradsoyad = user["Name"].ToString();
                    btntesdiqolmuw0.BackColor = Color.GreenYellow;

                    Session[rownumber] = null;
                    btnyenideniwle.BackColor = Color.Aquamarine;
                    btngonray.BackColor = SystemColors.ButtonFace;
                    btngonumumi.BackColor = SystemColors.ButtonFace;
                    dlgonderumumi.Visible = false;
                    dlteqdimolunmuw.Visible = false;
                    dlyenideniwle.Visible = true;
                   
                    pnlgonderilmeyen.Visible = true;
                    DataRow dtsil = klas.GetDataRow("select FileName from FRegions where RegionID=" + RegionID);
                    if (dtsil["FileName"].ToString() != "" && dtsil != null)
                    {
                        System.IO.FileInfo file = new System.IO.FileInfo(Server.MapPath("~/iradlar/" + useradsoyad + "/" + dtsil["FileName"].ToString()));


                        if (file.Exists)//check file exsit or not
                        {
                            file.Delete();
                            SqlConnection baglanti = klas.baglan();
                            SqlCommand cmd2 = new SqlCommand("Update FRegions set FileName=null where RegionID=" + RegionID, baglanti);
                            cmd2.ExecuteNonQuery();
                        }

                    }
                    yenideniwle();
                }
            }
            if (islem == "gonder")
            {

                string calendar11 = klas.getdatacell("Select Purpose from FRegions where (DateRealGoFromRegion is not null or DateRealRegionCome is not null) and RegionID=" + RegionID);
                if (calendar11 != "")
                {
                    SqlConnection baglanti = klas.baglan();
                    SqlCommand cmd = new SqlCommand("Update FRegions set Arxiv=1 where RegionID=" + RegionID, baglanti);
                    cmd.ExecuteNonQuery();
                }
                else {
                    lblsebeb1.Visible = true;
                    lblsebeb1.Text = "Səbəb qeyd olunmalıdır";
                }

                pnlrealtarixgelme.Visible = false;
                pnlrealtarixgetme.Visible = false;
                dleztarixnez.Visible = true;
                pnlsebeb.Visible = false;
                eztarixnezaret.BackColor = Color.GreenYellow;
                btneztarixnez.BackColor = Color.Aquamarine;
                btneztarixnezarxiv.BackColor = SystemColors.ButtonFace; 
                dlezamiyyetarixnezaret();
                pnleztarixnezaret.Visible = true;
                DataRow calendar1 = klas.GetDataRow("Select * from FRegions where RegionID=" + RegionID);
            }
            if (islem == "gerigonder")
            {
                SqlConnection baglanti = klas.baglan();
                SqlCommand cmd = new SqlCommand("Update FRegions set Arxiv=0 where RegionID=" + RegionID, baglanti);
                cmd.ExecuteNonQuery();

                pnlrealtarixgelme.Visible = false;
                pnlrealtarixgetme.Visible = false;
                dlnezaretarxiv.Visible = true;
                pnlsebeb.Visible = false;
                eztarixnezaret.BackColor = Color.GreenYellow;
                btneztarixnez.BackColor =SystemColors.ButtonFace;
                btneztarixnezarxiv.BackColor = Color.Aquamarine;

                ezamiyyetarixnezaretarxiv();
                pnleztarixnezaret.Visible = true;
                DataRow calendar1 = klas.GetDataRow("Select * from FRegions where RegionID=" + RegionID);
            }
            if (islem == "sebeb")
            {
                pnlrealtarixgelme.Visible = false;
                pnlrealtarixgetme.Visible = false;
                dleztarixnez.Visible = true;
                pnlsebeb.Visible = true;
                eztarixnezaret.BackColor = Color.GreenYellow;
                btneztarixnez.BackColor = Color.Aquamarine;
                btneztarixnezarxiv.BackColor = SystemColors.ButtonFace;
                Session[rownumber] = rownumber;
                dlezamiyyetarixnezaret();
                pnleztarixnezaret.Visible = true;
                if (Purpose != null && Purpose != "")
                {
                    txtsebeb.Text = Purpose;
                }

                DataRow calendar1 = klas.GetDataRow("Select * from FRegions where RegionID=" + RegionID);
            
            }
            if (islem == "sebeb1")
            {
                pnlsebeb.Visible = true;
                dlnezaretarxiv.Visible = true;
                eztarixnezaret.BackColor = Color.GreenYellow;
                btneztarixnez.BackColor = SystemColors.ButtonFace;
                btneztarixnezarxiv.BackColor = Color.Aquamarine;
                Session[rownumber] = rownumber;
                ezamiyyetarixnezaretarxiv();
                pnleztarixnezaret.Visible = true;
                pnlrealtarixgelme.Visible = false;
                pnlrealtarixgetme.Visible = false;
                if (Purpose != null && Purpose != "")
                {
                    txtsebeb.Text = Purpose;
                }

                DataRow calendar1 = klas.GetDataRow("Select * from FRegions where RegionID=" + RegionID);

            }
            if (islem == "realtimegofromregion")
            {
                dleztarixnez.Visible = true;
               eztarixnezaret.BackColor = Color.GreenYellow;
               btneztarixnez.BackColor = Color.Aquamarine;
               btneztarixnezarxiv.BackColor = SystemColors.ButtonFace;
                string regiongelme1;
                string regiongetme1;
                Session[rownumber] = rownumber;
                dlezamiyyetarixnezaret();
                pnleztarixnezaret.Visible = true;
                pnlrealtarixgelme.Visible = true;
                //pnlteqvimelave.Visible = false;
                pnlrealtarixgetme.Visible = false;

                DataRow calendar1 = klas.GetDataRow("Select * from FRegions where RegionID=" + RegionID);

                regiongelme1 = calendar1["DateRealRegionCome"].ToString();
                regiongetme1 = calendar1["DateRealGoFromRegion"].ToString();

                string gelmetarix1 = Class2.sozukes(regiongelme1);
                string getmetarix1 = Class2.sozukes(regiongetme1);
 
                lblraygetme.Text = gelmetarix1;
                lblraygelme.Text = getmetarix1;
                if (gelmetarix1 != "")
                    lblraygelme0.Text = Convert.ToDateTime(gelmetarix1).ToString("yyyy-MM-dd");
                if (getmetarix1 != "")
                    lblraygetme0.Text = Convert.ToDateTime(getmetarix1).ToString("yyyy-MM-dd"); 
            }
            if (islem == "realtimeregioncome") {
                dleztarixnez.Visible = true;
                eztarixnezaret.BackColor = Color.GreenYellow;
                btneztarixnez.BackColor = Color.Aquamarine;
                btneztarixnezarxiv.BackColor = SystemColors.ButtonFace;
                string regiongelme1;
                string regiongetme1;
                Session[rownumber] = rownumber;
                dlezamiyyetarixnezaret();
                pnleztarixnezaret.Visible = true;
                pnlrealtarixgelme.Visible = false;
                //pnlteqvimelave.Visible = false;
                pnlrealtarixgetme.Visible = true;

                DataRow calendar1 = klas.GetDataRow("Select * from FRegions where RegionID=" + RegionID);

                regiongelme1 = calendar1["DateRealRegionCome"].ToString();
                regiongetme1 = calendar1["DateRealGoFromRegion"].ToString();

                string gelmetarix1 = Class2.sozukes(regiongelme1);
                string getmetarix1 = Class2.sozukes(regiongetme1);
           

                lblraygetme.Text = gelmetarix1;
                lblraygelme.Text = getmetarix1;
                if (gelmetarix1 != "")
                    lblraygelme0.Text = Convert.ToDateTime(gelmetarix1).ToString("yyyy-MM-dd");
                if (getmetarix1 != "")
                    lblraygetme0.Text = Convert.ToDateTime(getmetarix1).ToString("yyyy-MM-dd"); 
            }








           
            if (islem == "realtimegofromregion1")
            {
                dlnezaretarxiv.Visible = true;
                eztarixnezaret.BackColor = Color.GreenYellow;
                btneztarixnez.BackColor = SystemColors.ButtonFace;
                btneztarixnezarxiv.BackColor = Color.Aquamarine;
                string regiongelme1;
                string regiongetme1;
                Session[rownumber] = rownumber;
                ezamiyyetarixnezaretarxiv();
                pnleztarixnezaret.Visible = true;
                pnlrealtarixgelme.Visible = true;
                //pnlteqvimelave.Visible = false;
                pnlrealtarixgetme.Visible = false;

                DataRow calendar1 = klas.GetDataRow("Select * from FRegions where RegionID=" + RegionID);

                regiongelme1 = calendar1["DateRealRegionCome"].ToString();
                regiongetme1 = calendar1["DateRealGoFromRegion"].ToString();

                string gelmetarix1 = Class2.sozukes(regiongelme1);
                string getmetarix1 = Class2.sozukes(regiongetme1);

                lblraygetme.Text = gelmetarix1;
                lblraygelme.Text = getmetarix1;
                if (gelmetarix1 != "")
                    lblraygelme0.Text = Convert.ToDateTime(gelmetarix1).ToString("yyyy-MM-dd");
                if (getmetarix1 != "")
                    lblraygetme0.Text = Convert.ToDateTime(getmetarix1).ToString("yyyy-MM-dd");
            }
            if (islem == "realtimeregioncome1")
            {
                dlnezaretarxiv.Visible = true;
                eztarixnezaret.BackColor = Color.GreenYellow;
                btneztarixnez.BackColor = SystemColors.ButtonFace;
                btneztarixnezarxiv.BackColor =  Color.Aquamarine;
                string regiongelme1;
                string regiongetme1;
                Session[rownumber] = rownumber;
                ezamiyyetarixnezaretarxiv();
                pnleztarixnezaret.Visible = true;
                pnlrealtarixgelme.Visible = false;
                //pnlteqvimelave.Visible = false;
                pnlrealtarixgetme.Visible = true;

                DataRow calendar1 = klas.GetDataRow("Select * from FRegions where RegionID=" + RegionID);

                regiongelme1 = calendar1["DateRealRegionCome"].ToString();
                regiongetme1 = calendar1["DateRealGoFromRegion"].ToString();

                string gelmetarix1 = Class2.sozukes(regiongelme1);
                string getmetarix1 = Class2.sozukes(regiongetme1);


                lblraygetme.Text = gelmetarix1;
                lblraygelme.Text = getmetarix1;
                if (gelmetarix1 != "")
                    lblraygelme0.Text = Convert.ToDateTime(gelmetarix1).ToString("yyyy-MM-dd");
                if (getmetarix1 != "")
                    lblraygetme0.Text = Convert.ToDateTime(getmetarix1).ToString("yyyy-MM-dd");
            }







            if (islem == "geri")
            {
                pnltesdiqolunmamiw.Visible = true;
                pnltesdiqolunmuw.Visible = false;
                pnlrayuzre2.Visible = false;
                pnlumumi2.Visible = false;
                btnumumi1.BackColor = SystemColors.ButtonFace;
                btntesdiqolmamiw.BackColor = Color.GreenYellow;
                btntesdiqolmuw.BackColor = SystemColors.ButtonFace;
                datalistrayontarix();
                pnlrayonuzre1.Visible = true;
                pnlumumi1.Visible = false;
                btnrayuzre1.BackColor = Color.Aquamarine;
                btnumumi1.BackColor = SystemColors.ButtonFace;
            }
            if (islem1 == "geri1")
            {
                pnltesdiqolunmamiw.Visible = false;
                pnltesdiqolunmuw.Visible = true;
                pnlrayuzre2.Visible = true;
                pnlumumi2.Visible = false;
                btnumumi1.BackColor = SystemColors.ButtonFace;
                btntesdiqolmamiw.BackColor = SystemColors.ButtonFace;
                btntesdiqolmuw.BackColor =  Color.GreenYellow;
                pnlrayonuzre1.Visible = false;
                pnlumumi1.Visible = false;
                datalistrayontarix2();
                btnrayuzre2.BackColor = Color.Aquamarine;
                btnumumi2.BackColor = SystemColors.ButtonFace;
            }
            if (islem1 == "geri13")
            {
                eztarixnezaret.BackColor = SystemColors.ButtonFace;
                btntesdiqolmuw0.BackColor = Color.GreenYellow;
                btntesdiqolmamiw.BackColor = SystemColors.ButtonFace;
                btntesdiqolmuw.BackColor = SystemColors.ButtonFace;
                btngonray.BackColor = Color.Aquamarine;
                btngonumumi.BackColor = SystemColors.ButtonFace;  
                pnlgonderilmeyen.Visible = true;
                teqdimolunmuw();
               
                Session[rownumber] = null;
                dlgonderumumi.Visible = false;
                dlteqdimolunmuw.Visible = true;
                btngonray.BackColor = Color.Aquamarine;
                btngonumumi.BackColor = SystemColors.ButtonFace; 

                pnlsebeb.Visible = false;

                Session[rownumber] = null;
                pnlrealtarixgetme.Visible = false;
                pnlrealtarixgelme.Visible = false;
                pnleztarixnezaret.Visible = false;
                pnltesdiqolunmamiw.Visible = false;
                pnltesdiqolunmuw.Visible = false;

              
            }
            if (islem1 == "geri14")
            {
                eztarixnezaret.BackColor = SystemColors.ButtonFace;
                btntesdiqolmuw0.BackColor = Color.GreenYellow;
                btntesdiqolmamiw.BackColor = SystemColors.ButtonFace;
                btntesdiqolmuw.BackColor = SystemColors.ButtonFace;
                btngonray.BackColor = Color.Aquamarine;
                btngonumumi.BackColor = SystemColors.ButtonFace;
                pnlgonderilmeyen.Visible = true;
                gonderumumi();

                btngonumumi.BackColor = Color.Aquamarine;
                btngonray.BackColor = SystemColors.ButtonFace;  
                pnlsebeb.Visible = false;

                Session[rownumber] = null;
                pnlrealtarixgetme.Visible = false;
                pnlrealtarixgelme.Visible = false;
                pnleztarixnezaret.Visible = false;
                pnltesdiqolunmamiw.Visible = false;
                pnltesdiqolunmuw.Visible = false;


            }
            if (islem1 == "geri15")
            {
                eztarixnezaret.BackColor = SystemColors.ButtonFace;
                btntesdiqolmuw0.BackColor = Color.GreenYellow;
                btntesdiqolmamiw.BackColor = SystemColors.ButtonFace;
                btntesdiqolmuw.BackColor = SystemColors.ButtonFace;
                btngonray.BackColor = SystemColors.ButtonFace;
                btnyenideniwle.BackColor = Color.Aquamarine;
                btngonumumi.BackColor = SystemColors.ButtonFace;
                pnlgonderilmeyen.Visible = true;
                dlyenideniwle.Visible = true;
                yenideniwle();
                dlgonderumumi.Visible = false;
                dlteqdimolunmuw.Visible = false;

                pnlsebeb.Visible = false;

                Session[rownumber] = null;
                pnlrealtarixgetme.Visible = false;
                pnlrealtarixgelme.Visible = false;
                pnleztarixnezaret.Visible = false;
                pnltesdiqolunmamiw.Visible = false;
                pnltesdiqolunmuw.Visible = false;


            }
            if (islem == "duzelis")
            {
                pnlumumi1.Visible = true;
                btntesdiqolmamiw.BackColor = Color.GreenYellow;
                btnumumi1.BackColor = Color.Aquamarine;
                btnrayuzre1.BackColor = SystemColors.ButtonFace;
                pnltesdiqolunmamiw.Visible = true;
           

                Session[rownumber] = rownumber;

                DataRow calendar = klas.GetDataRow("Select * from Fbusiness_trip where BusinessTripID=" + BusinessTripID);
                userid = calendar["UserID"].ToString();
                regionid = calendar["RegionID"].ToString();
                regiongelme = calendar["RegionCome"].ToString();
                regiongetme = calendar["GoFromRegion"].ToString();
                isecixma = calendar["ComingToWork"].ToString();
                

                string gelmetarix = Class2.sozukes(regiongelme);
                string getmetarix = Class2.sozukes(regiongetme);
                string isecixmatarix = Class2.sozukes(isecixma);
           

                lblgelmeredakte.Text = gelmetarix;
                lblbitmeredakte.Text = getmetarix;
                lblisecixma.Text = isecixmatarix;

                lblrayona.Text = Convert.ToDateTime(regiongelme).ToString("yyyy-MM-dd");
                lblcix.Text = Convert.ToDateTime(regiongetme).ToString("yyyy-MM-dd");

              
                pnlredakte.Visible = true;

                datalist1();
         
            }
            if (islem == "icazesil")
            {
                if (UserID != null) {
                    SqlConnection baglanti = klas.baglan();
                    SqlCommand cmd2 = new SqlCommand("Update Users set permit=@permit where UserID=" + UserID, baglanti);
                    cmd2.Parameters.Add("permit", "0");
                    cmd2.ExecuteNonQuery();
                }
            }
        }

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
    void icazever()
    {
        DataTable dtiller = klas.getdatatable("select UserID,Name+' '+Sname as Name,Fname,status_users from Users where status_users=0 order by [Name]");
        ddlicazever.DataTextField = "Name";
        ddlicazever.DataValueField = "UserID";
        ddlicazever.DataSource = dtiller;
        ddlicazever.DataBind();
        ddlicazever.Items.Insert(0, new ListItem("Seçin", "0"));
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
    void ryn2()
    {
        DataTable dtiller = klas.getdatatable("Select * from List_classification_Regions where  ForDelete=1 order by [Name]");
        ddlryn3.DataTextField = "Name";
        ddlryn3.DataValueField = "RegionsID";
        ddlryn3.DataSource = dtiller;
        ddlryn3.DataBind();
        ddlryn3.Items.Insert(0, new ListItem("Seçin", "0"));
        ddlryn3.Items.Insert(1, new ListItem("Ümumi", "-1"));
        ddlryn3.SelectedValue = "-1";
    }
    void ryn3()
    {
        DataTable dtiller = klas.getdatatable("Select * from List_classification_Regions where UserID='" + ddlusers3.SelectedValue + "' and ForDelete=1 order by [Name]");
        ddlryn3.DataTextField = "Name";
        ddlryn3.DataValueField = "RegionsID";
        ddlryn3.DataSource = dtiller;
        ddlryn3.DataBind();
        ddlryn3.Items.Insert(0, new ListItem("Seçin", "0"));
        ddlryn3.Items.Insert(1, new ListItem("Ümumi", "-1"));
        ddlryn3.SelectedValue = "-1";
    }


    void users()
    {
        DataTable region2 = klas.getdatatable("select UserID,Name+' '+Sname as Name,Fname,status_users from Users where status_users=0 order by [Name]");
        ddlusers.DataTextField = "Name";
        ddlusers.DataValueField = "UserID";
        ddlusers.DataSource = region2;
        ddlusers.DataBind();
    }
    void users3()
    {
        DataTable region2 = klas.getdatatable("select UserID,Name+' '+Sname as Name,Fname,status_users from Users where status_users=0 order by [Name]");
        ddlusers3.DataTextField = "Name";
        ddlusers3.DataValueField = "UserID";
        ddlusers3.DataSource = region2;
        ddlusers3.DataBind();
    }
    void datalist2() {
        string s = @"select u.Name+' '+U.Sname as nameuser,* from Fbusiness_trip as b 
inner join Users as u on b.UserID=u.UserID
where 
 b.BusinessTripID   in (select r.BusinessTripID from FRegions as r where r.Approval=4)  order by
nameuser,RegionCome DESC ";
        DataTable dtGruplar = klas.getdatatable(s);
        DataList2.DataSource = dtGruplar;
        DataList2.DataBind();

        //if (dtGruplar.Rows.Count > 0)
        //{
        //    DataList2.Visible = true;
        //}
        //else
        //{
        //    DataList2.Visible = false;
        //}
    }
    void datalist1()
    {
        string s = @"SELECT DISTINCT 
                       dbo.Fbusiness_trip.RegionCome, dbo.Fbusiness_trip.GoFromRegion, dbo.Fbusiness_trip.ComingToWork, dbo.Fbusiness_trip.UserID, 
                      dbo.Users.Name + ' ' + dbo.Users.Sname AS nameuser, dbo.Fbusiness_trip.BusinessTripID, dbo.Fbusiness_trip.Regions
FROM         dbo.Fbusiness_trip INNER JOIN dbo.Users ON dbo.Fbusiness_trip.UserID = dbo.Users.UserID INNER JOIN 
 dbo.FRegions ON dbo.Fbusiness_trip.BusinessTripID = dbo.FRegions.BusinessTripID
 WHERE    (dbo.FRegions.Approval = 1) or (dbo.FRegions.Approval = 2) 
ORDER BY nameuser, dbo.Fbusiness_trip.RegionCome DESC";

        DataTable dtGruplar = klas.getdatatable(s);
        DataList1.DataSource = dtGruplar;
        DataList1.DataBind();

        //if (dtGruplar.Rows.Count > 0)
        //{
        //    DataList1.Visible = true;
        //}
        //else
        //{
        //    DataList1.Visible = false;
        //}
    }
    void datalistrayontarix()
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
            userid = " and fre.UserID='" + ddlusers.SelectedValue + "' ";
            userid1 = " and btr.UserID='" + ddlusers.SelectedValue + "' ";
        }
        if (ddlryn.SelectedValue == "0" || ddlryn.SelectedValue == "-1" || ddlryn.SelectedValue == "")
        {
            rayon = "  ";
            rayon1 = "  ";
        }
        else
        {
            rayon = " and fre.RegionCode='" + ddlryn.SelectedValue + "' ";
            rayon1 = " and btr.RegionCode='" + ddlryn.SelectedValue + "' ";
        }


        string tarixs1 = "";
        string tarixs2 = "";
        string tarixs11 = "";
        string tarixs22 = "";
        if (lblgetme1.Text != "")
        {
            tarixs1 = " and fre.GoFromRegion <='" + lblgetme1.Text + "'";
            tarixs11 = "and btr.GoFromRegion <='" + lblgetme1.Text + "'";
        }
        if (lblgelme1.Text != "")
        {
            tarixs2 = "and fre.RegionCome >= '" + lblgelme1.Text + "'";
            tarixs22 = "and btr.RegionCome >='" + lblgelme1.Text + "'";
        }


        string s = @"select distinct *,case when xxx.BusinessTripID is null then '' else N'Tarix səhvdir'  end as busi
  from ( SELECT    fre.DateApproval_ze,fre.RegionCode, fre.RegionID, fre.Name, fre.RegionCome, fre.GoFromRegion, 
fre.BusinessTripID, u.Name + ' ' + u.Sname AS nameuser, u.UserID, fre.Approval from FRegions as fre 
INNER JOIN Fbusiness_trip as fbis ON fre.BusinessTripID = fbis.BusinessTripID 
INNER JOIN Users as u ON fbis.UserID = u.UserID
WHERE     ((fre.Approval =1)  or (fre.Approval=2)) " + tarixs2 + " " + " " + tarixs1 + "  " + rayon + "  " + " " + userid + "  ) as cc left join ( "
+ " select  fb.BusinessTripID from Fbusiness_trip as fb inner join FRegions as fr on fb.BusinessTripID=fr.BusinessTripID where  fb.BusinessTripID not in("
 + " select distinct fb.BusinessTripID from Fbusiness_trip as fb "
    + " inner join FRegions as fr on fb.BusinessTripID=fr.BusinessTripID where approval=0 ) "
                          + " and  (fb.BusinessTripID not in("
                          + "select  fb.BusinessTripID from Fbusiness_trip as fb "
                          + " inner join FRegions as fr on fb.BusinessTripID=fr.BusinessTripID where  fb.BusinessTripID not in("
                          + " select distinct fb.BusinessTripID from Fbusiness_trip as fb "
                          + " inner join FRegions as fr on fb.BusinessTripID=fr.BusinessTripID where approval=0) "
                          + " and fb.RegionCome=fr.RegionCome) or fb.BusinessTripID not in("
                          + " select  fb.BusinessTripID from Fbusiness_trip as fb "
                          + " inner join FRegions as fr on fb.BusinessTripID=fr.BusinessTripID where  fb.BusinessTripID not in( "
                          + " select distinct fb.BusinessTripID from Fbusiness_trip as fb  "
                          + " inner join FRegions as fr on fb.BusinessTripID=fr.BusinessTripID where approval=0 ) "
                          + "and fb.GoFromRegion=fr.GoFromRegion))) as xxx on cc.BusinessTripID=xxx.BusinessTripID "
                          + "ORDER BY nameuser, RegionCome DESC";

        DataTable dtGruplar = klas.getdatatable(s);
        dlrayontarix.DataSource = dtGruplar;
        dlrayontarix.DataBind();
        if (dtGruplar.Rows.Count > 0)
        {
            if (ddlryn.SelectedValue != "0")
            {
                lblmesage.Text = "";
            }
            else
            {
                lblmesage.Text = "Rayon seçin";
                lblmesage.ForeColor = Color.Red;
            }
        }
        else
        {
            lblmesage.Text = "Tapılmadı";
            lblmesage.ForeColor = Color.Red;
        }


    }
    void dlezamiyyetarixnezaret()
    {

        string s = @"SELECT     dbo.FRegions.DateApproval_ze, dbo.FRegions.RegionCode, dbo.FRegions.RegionID, dbo.FRegions.Name, dbo.FRegions.RegionCome, 
                      dbo.FRegions.GoFromRegion, dbo.FRegions.BusinessTripID, dbo.Users.Name + ' ' + dbo.Users.Sname AS nameuser, dbo.Users.UserID, dbo.FRegions.Approval, 
                      dbo.FRegions.DateRealGoFromRegion, dbo.FRegions.DateRealRegionCome, dbo.FRegions.Purpose, dbo.Fbusiness_trip.RegionCome AS BusRegionCome, 
                      dbo.Fbusiness_trip.GoFromRegion AS BusGoFromRegion, dbo.Fbusiness_trip.ComingToWork
FROM         dbo.FRegions INNER JOIN
                      dbo.Fbusiness_trip ON dbo.FRegions.BusinessTripID = dbo.Fbusiness_trip.BusinessTripID INNER JOIN
                      dbo.Users ON dbo.Fbusiness_trip.UserID = dbo.Users.UserID
WHERE     (dbo.FRegions.Approval = 4) and (dbo.FRegions.Arxiv=0) ORDER BY nameuser, dbo.FRegions.RegionCome DESC";

        DataTable dtGruplar = klas.getdatatable(s);
        dleztarixnez.DataSource = dtGruplar;
        dleztarixnez.DataBind();

        //if (dtGruplar.Rows.Count > 0)
        //{
        //    dleztarixnez.Visible = true;
        //}
        //else
        //{
        //    dleztarixnez.Visible = false;
        //}
    }
    void ezamiyyetarixnezaretarxiv()
    {

        string s = @"SELECT     dbo.FRegions.DateApproval_ze, dbo.FRegions.RegionCode, dbo.FRegions.RegionID, dbo.FRegions.Name, dbo.FRegions.RegionCome, 
                      dbo.FRegions.GoFromRegion, dbo.FRegions.BusinessTripID, dbo.Users.Name + ' ' + dbo.Users.Sname AS nameuser, dbo.Users.UserID, dbo.FRegions.Approval, 
                      dbo.FRegions.DateRealGoFromRegion, dbo.FRegions.DateRealRegionCome, dbo.FRegions.Purpose, dbo.Fbusiness_trip.RegionCome AS BusRegionCome, 
                      dbo.Fbusiness_trip.GoFromRegion AS BusGoFromRegion, dbo.Fbusiness_trip.ComingToWork
FROM         dbo.FRegions INNER JOIN
                      dbo.Fbusiness_trip ON dbo.FRegions.BusinessTripID = dbo.Fbusiness_trip.BusinessTripID INNER JOIN
                      dbo.Users ON dbo.Fbusiness_trip.UserID = dbo.Users.UserID
WHERE     (dbo.FRegions.Approval = 4) and (dbo.FRegions.Arxiv=1 or dbo.FRegions.Arxiv=2)  ORDER BY nameuser, dbo.FRegions.RegionCome DESC";

        DataTable dtGruplar = klas.getdatatable(s);
        dlnezaretarxiv.DataSource = dtGruplar;
        dlnezaretarxiv.DataBind();

        //if (dtGruplar.Rows.Count > 0)
        //{
        //    dlnezaretarxiv.Visible = true;
        //}
        //else
        //{
        //    dlnezaretarxiv.Visible = false;
        //}
    }
    public static string planagir(string planagirme2)
    {
        string deger = "";
        if (planagirme2 == "2")
        {
            deger = "Təklif olunub";
        }
        else {
            deger = "";
        }
        return deger;
    }
    public static string planagirme2(string planagirme2)
    {
        string deger = "";
        if (planagirme2 == "2")
        {
            deger = "Green";
        }
        else
        {
            deger = "Red";
        }
        return deger;
    }
    public static string tarix(string uygun)
    {
        string qiymet = "";
        if (uygun == "")
        {
            qiymet = "Tarix";
        }
        else if(uygun.Length >= 10)
        {
            qiymet = uygun.Substring(0, 10);
        } 
        return qiymet;
    }
    public static string sebeb(string uygun)
    {
        string qiymet = "";
        if (uygun == "")
        {
            qiymet = "Səbəb.";
        }
        else 
        {
            qiymet = uygun+".";
        }
        return qiymet;
    }
    void datalistrayontarix2()
    {

        string rayon;
        string rayon1;
        string userid;
        string userid1;
        if (ddlusers3.SelectedValue == "0" || ddlusers3.SelectedValue == "-1" || ddlusers3.SelectedValue == "")
        {
            userid = "  ";
            userid1 = "  ";
        }
        else
        {
            userid = " and fre.UserID='" + ddlusers3.SelectedValue + "' ";
            userid1 = " and btr.UserID='" + ddlusers3.SelectedValue + "' ";
        }
        if (ddlryn3.SelectedValue == "0" || ddlryn3.SelectedValue == "-1" || ddlryn3.SelectedValue == "")
        {
            rayon = "  ";
            rayon1 = "  ";
        }
        else
        {
            rayon = " and fre.RegionCode='" + ddlryn3.SelectedValue + "' ";
            rayon1 = " and btr.RegionCode='" + ddlryn3.SelectedValue + "' ";
        }


        string tarixs1 = "";
        string tarixs2 = "";
        string tarixs11 = "";
        string tarixs22 = "";
        if (lblgetme13.Text != "")
        {
            tarixs1 = " and fre.GoFromRegion <='" + lblgetme13.Text + "'";
            tarixs11 = "and btr.GoFromRegion <='" + lblgetme13.Text + "'";
        }
        if (lblgelme13.Text != "")
        {
            tarixs2 = "and fre.RegionCome >= '" + lblgelme13.Text + "'";
            tarixs22 = "and btr.RegionCome >='" + lblgelme13.Text + "'";
        }


        string s = @"select distinct *,case when xxx.BusinessTripID is null then '' else N'Tarix səhvdir'  end as busi
  from ( SELECT    fre.DateApproval_ze,fre.RegionCode, fre.RegionID, fre.Name, fre.RegionCome, fre.GoFromRegion, 
fre.BusinessTripID, u.Name + ' ' + u.Sname AS nameuser, u.UserID, fre.Approval from FRegions as fre 
INNER JOIN Fbusiness_trip as fbis ON fre.BusinessTripID = fbis.BusinessTripID 
INNER JOIN Users as u ON fbis.UserID = u.UserID
WHERE    fre.Approval =4 " + tarixs2 + " " + " " + tarixs1 + "  " + rayon + "  " + " " + userid + "  ) as cc left join ( "
+ " select  fb.BusinessTripID from Fbusiness_trip as fb inner join FRegions as fr on fb.BusinessTripID=fr.BusinessTripID where  fb.BusinessTripID not in("
 + " select distinct fb.BusinessTripID from Fbusiness_trip as fb "
    + " inner join FRegions as fr on fb.BusinessTripID=fr.BusinessTripID where approval=0 ) "
                          + " and  (fb.BusinessTripID not in("
                          + "select  fb.BusinessTripID from Fbusiness_trip as fb "
                          + " inner join FRegions as fr on fb.BusinessTripID=fr.BusinessTripID where  fb.BusinessTripID not in("
                          + " select distinct fb.BusinessTripID from Fbusiness_trip as fb "
                          + " inner join FRegions as fr on fb.BusinessTripID=fr.BusinessTripID where approval=0) "
                          + " and fb.RegionCome=fr.RegionCome) or fb.BusinessTripID not in("
                          + " select  fb.BusinessTripID from Fbusiness_trip as fb "
                          + " inner join FRegions as fr on fb.BusinessTripID=fr.BusinessTripID where  fb.BusinessTripID not in( "
                          + " select distinct fb.BusinessTripID from Fbusiness_trip as fb  "
                          + " inner join FRegions as fr on fb.BusinessTripID=fr.BusinessTripID where approval=0 ) "
                          + "and fb.GoFromRegion=fr.GoFromRegion))) as xxx on cc.BusinessTripID=xxx.BusinessTripID "
                          + "ORDER BY nameuser, RegionCome DESC";

        DataTable dtGruplar = klas.getdatatable(s);
        dlrayontarix0.DataSource = dtGruplar;
        dlrayontarix0.DataBind();
        if (dtGruplar.Rows.Count > 0)
        {
            if (ddlryn3.SelectedValue != "0")
            {
                lblmesage3.Text = "";
            }
            else
            {
                lblmesage3.Text = "Rayon seçin";
                lblmesage3.ForeColor = Color.Red;
            }

        }
        else
        {
            lblmesage3.Text = "Tapılmadı";
            lblmesage3.ForeColor = Color.Red;
        }
    }
    
            void yenideniwle()
    {
        string s = @"SELECT    dbo.FRegions.DateApproval_ze,dbo.FRegions.RegionCode, dbo.FRegions.RegionID, dbo.FRegions.Name, dbo.FRegions.RegionCome, dbo.FRegions.GoFromRegion, 
                      dbo.FRegions.BusinessTripID, dbo.Users.Name + ' ' + dbo.Users.Sname AS nameuser, dbo.Users.UserID, dbo.FRegions.Approval,dbo.FRegions.FileName
FROM         dbo.FRegions INNER JOIN
                      dbo.Fbusiness_trip ON dbo.FRegions.BusinessTripID = dbo.Fbusiness_trip.BusinessTripID INNER JOIN
                      dbo.Users ON dbo.Fbusiness_trip.UserID = dbo.Users.UserID
WHERE    (dbo.FRegions.Approval = 3)  ORDER BY nameuser, dbo.FRegions.RegionCome DESC";
        DataTable dtGruplar = klas.getdatatable(s);
        dlyenideniwle.DataSource = dtGruplar;
        dlyenideniwle.DataBind();
    }
    void teqdimolunmuw()
    {
        string s = @"SELECT    dbo.FRegions.DateApproval_ze,dbo.FRegions.RegionCode, dbo.FRegions.RegionID, dbo.FRegions.Name, dbo.FRegions.RegionCome, dbo.FRegions.GoFromRegion, 
                      dbo.FRegions.BusinessTripID, dbo.Users.Name + ' ' + dbo.Users.Sname AS nameuser, dbo.Users.UserID, dbo.FRegions.Approval,dbo.FRegions.FileName
FROM         dbo.FRegions INNER JOIN
                      dbo.Fbusiness_trip ON dbo.FRegions.BusinessTripID = dbo.Fbusiness_trip.BusinessTripID INNER JOIN
                      dbo.Users ON dbo.Fbusiness_trip.UserID = dbo.Users.UserID
WHERE     (dbo.FRegions.Approval = 0)  ORDER BY nameuser, dbo.FRegions.RegionCome DESC";
        DataTable dtGruplar = klas.getdatatable(s);
        dlteqdimolunmuw.DataSource = dtGruplar;
        dlteqdimolunmuw.DataBind();
    }
    void gonderumumi()
    {
        string s = @"SELECT DISTINCT 
                       dbo.Fbusiness_trip.RegionCome, dbo.Fbusiness_trip.GoFromRegion, dbo.Fbusiness_trip.ComingToWork, dbo.Fbusiness_trip.UserID, 
                      dbo.Users.Name + ' ' + dbo.Users.Sname AS nameuser, dbo.Fbusiness_trip.BusinessTripID, dbo.Fbusiness_trip.Regions
FROM         dbo.Fbusiness_trip INNER JOIN
                      dbo.Users ON dbo.Fbusiness_trip.UserID = dbo.Users.UserID INNER JOIN
                      dbo.FRegions ON dbo.Fbusiness_trip.BusinessTripID = dbo.FRegions.BusinessTripID
WHERE     (dbo.FRegions.Approval = 0)   ORDER BY nameuser, dbo.Fbusiness_trip.RegionCome DESC";
        DataTable dtGruplar = klas.getdatatable(s);
        dlgonderumumi.DataSource = dtGruplar;
        dlgonderumumi.DataBind();

        //if (dtGruplar.Rows.Count > 0)
        //{
        //    dlgonderumumi.Visible = true;
        //}
        //else
        //{
        //    dlgonderumumi.Visible = false;
        //}
    }
    protected void imgcldbawla_Click(object sender, ImageClickEventArgs e)
    {
        if (cldgelme.Visible)
        {
            cldgelme.Visible = false;
            lblgelmeredakte.Visible = true;

        }
        else
        {
            cldgelme.Visible = true;
            lblgelmeredakte.Visible = false;
        }
        datalist1();
    }
    protected void imgbitme_Click(object sender, ImageClickEventArgs e)
    {
        if (lblgelmeredakte.Text != "")
        {
            if (cldbitme.Visible)
            {
                cldbitme.Visible = false;
                lblbitmeredakte.Visible = true;
            }
            else
            {
                cldbitme.Visible = true;
                lblbitmeredakte.Visible = false;
            }
        }
        else
        {
            message.Visible = true;
            message.Text = "Rayona,şəhərə gəlmə tarixini daxil edin";
            message.ForeColor = Color.Red;
        }
        datalist1();
    }
    protected void imgiwecixma_Click(object sender, ImageClickEventArgs e)
    {
        if (lblbitmeredakte.Text != "")
        {
            if (cldisecixma.Visible)
            {
                cldisecixma.Visible = false;
                lblisecixma.Visible = true;
            }
            else
            {

                cldisecixma.Visible = true;
                lblisecixma.Visible = false;
            }
        }
        else
        {
            lblredaktemsg.Visible = true;
            lblredaktemsg.Text = "Rayondan,şəhərdən getmə tarixini daxil edin:";
            lblredaktemsg.ForeColor = Color.Red;
        }
        datalist1();
    }
    protected void cldgelme_SelectionChanged(object sender, EventArgs e)
    {
        lblgelmeredakte.Text = cldgelme.SelectedDate.ToString("d");
        lblrayona.Text = cldgelme.SelectedDate.ToString("yyyy-MM-dd");
        //Response.Write(lblrayona.Text);
        cldgelme.Visible = false;
        lblgelmeredakte.Visible = true;
        datalist1();
    }

    protected void cldbitme_SelectionChanged(object sender, EventArgs e)
    {
        lblbitmeredakte.Text = cldbitme.SelectedDate.ToString("d");
        cldbitme.Visible = false;
        lblbitmeredakte.Visible = true;
        datalist1();
    }
    protected void cldisecixma_SelectionChanged(object sender, EventArgs e)
    {
        lblisecixma.Text = cldisecixma.SelectedDate.ToString("d");
        lblcix.Text = cldisecixma.SelectedDate.ToString("yyyy-MM-dd");
        cldisecixma.Visible = false;
        lblisecixma.Visible = true;
        datalist1();
    }
    protected void cldgelme_DayRender(object sender, DayRenderEventArgs e)
    {

    }
    protected void cldbitme_DayRender(object sender, DayRenderEventArgs e)
    {
        
    }
    protected void cldisecixma_DayRender(object sender, DayRenderEventArgs e)
    {
       
    }
    protected void btnredakte_Click(object sender, EventArgs e)
    {
        lblredaktemsg.Visible = true;
        lblredaktemsg.Text = "";

        if (lblgelmeredakte.Text != "" && lblbitmeredakte.Text != "" && lblisecixma.Text != "")
        {
            string gelme = lblgelmeredakte.Text + " " + "00:00:00.000";
            string getme = lblbitmeredakte.Text + " " + "00:00:00.000";
            string cixma = lblisecixma.Text + " " + "00:00:00.000";
            string gelme1 = lblrayona.Text + " " + "00:00:00.000";
            string cix = lblcix.Text + " " + "00:00:00.000";

            DataRow raygelyoxla = klas.GetDataRow("select RegionCome,BusinessTripID,UserID  from Fbusiness_trip where RegionCome > '" + gelme1 + "' and RegionCome <'" + cix + "' and BusinessTripID !='" + BusinessTripID + "' and UserID=" + UserID);
            DataRow iwecixyoxla = klas.GetDataRow("select ComingToWork,BusinessTripID,UserID from Fbusiness_trip where ComingToWork > '" + gelme1 + "' and ComingToWork <'" + cix + "' and BusinessTripID !='" + BusinessTripID + "' and UserID=" + UserID);
            string ortaveziyyet1 = klas.getdatacell("select ComingToWork,BusinessTripID,UserID   from Fbusiness_trip where ComingToWork >= '" + cix + "' and BusinessTripID !='" + BusinessTripID + "' and UserID='" + UserID + "' order by  ComingToWork ");
            string ortaveziyyet = klas.getdatacell("select RegionCome,BusinessTripID,UserID from Fbusiness_trip where RegionCome <= '" + gelme1 + "' and BusinessTripID !='" + BusinessTripID + "' and UserID='" + UserID + "' order by  RegionCome desc");
            string sonyoxla = null;
            string gel;
            string iwe;
            if (ortaveziyyet1 != null && ortaveziyyet != null)
            {
                iwe = Convert.ToDateTime(ortaveziyyet1).ToString("yyyy-MM-dd") + " " + "00:00:00.000";
                gel = Convert.ToDateTime(ortaveziyyet).ToString("yyyy-MM-dd") + " " + "00:00:00.000";

                // Response.Write(iwe);
                //Response.Write(gel);
                sonyoxla = klas.getdatacell("select RegionCome,ComingToWork,BusinessTripID,UserID  from Fbusiness_trip where RegionCome = '" + gel + "'  and ComingToWork = '" + iwe + "' and UserID=" + UserID);
            }
            string regionagoremin = null;
            string regionagoremax = null;
            string rayonagor = "0";

            regionagoremin = klas.getdatacell("   SELECT     MIN(dbo.FRegions.RegionCome) AS minimum, dbo.FRegions.BusinessTripID, dbo.Fbusiness_trip.UserID " +
                "FROM         dbo.FRegions INNER JOIN dbo.Fbusiness_trip ON dbo.FRegions.BusinessTripID = dbo.Fbusiness_trip.BusinessTripID " +
                " WHERE     (dbo.FRegions.BusinessTripID = '" + BusinessTripID + "') and (dbo.Fbusiness_trip.UserID = '" + UserID + "') " +
                "GROUP BY dbo.FRegions.BusinessTripID, dbo.Fbusiness_trip.UserID");

            regionagoremax = klas.getdatacell("SELECT     MAX(dbo.FRegions.GoFromRegion) AS maximum, dbo.FRegions.BusinessTripID, dbo.Fbusiness_trip.UserID " +
                "FROM         dbo.FRegions INNER JOIN " +
                "dbo.Fbusiness_trip ON dbo.FRegions.BusinessTripID = dbo.Fbusiness_trip.BusinessTripID " +
                "WHERE     (dbo.FRegions.BusinessTripID = '" + BusinessTripID + "') AND (dbo.Fbusiness_trip.UserID = '" + UserID + "') " +
                "GROUP BY dbo.FRegions.BusinessTripID, dbo.Fbusiness_trip.UserID");
            if (regionagoremin != "" && regionagoremax != "")
            {
                //Response.Write("min" + regionagoremin);
                //Response.Write("max" + regionagoremax);
                if (Convert.ToDateTime(gelme) <= Convert.ToDateTime(regionagoremin) && Convert.ToDateTime(getme) >= Convert.ToDateTime(regionagoremax))
                {
                    rayonagor = "1";
                }
                // && regionagoremax != null
                //Response.Write("max"+regionagoremax);
            }
            else
            { rayonagor = "1"; }

            if (rayonagor == "1" && Convert.ToDateTime(gelme) <= Convert.ToDateTime(getme) && Convert.ToDateTime(gelme) <= Convert.ToDateTime(getme) && Convert.ToDateTime(getme) <= Convert.ToDateTime(cixma) && raygelyoxla == null && iwecixyoxla == null && sonyoxla == null)
            {
                SqlConnection baglanti = klas.baglan();
                SqlCommand cmd = new SqlCommand("Update Fbusiness_trip set RegionCome=@RegionCome,GoFromRegion=@GoFromRegion,ComingToWork=@ComingToWork where BusinessTripID=" + BusinessTripID, baglanti);

                cmd.Parameters.Add("RegionCome", Convert.ToDateTime(gelme));
                cmd.Parameters.Add("GoFromRegion", Convert.ToDateTime(getme));
                cmd.Parameters.Add("ComingToWork", Convert.ToDateTime(cixma));
                cmd.ExecuteNonQuery();
                lblredaktemsg.Visible = true;
                lblredaktemsg.Text = "Məlumat yadda saxlanıldı";
                lblredaktemsg.ForeColor = Color.Green;
                Session[rownumber] = null;
                lblgelmeredakte.Text = "";
                lblbitmeredakte.Text = "";
                lblisecixma.Text = "";
                lblrayona.Text = "";
                lblcix.Text = "";

                datalist1();
                pnlredakte.Visible = false;
            }
            else
            {
                lblredaktemsg.Text = "Tarix  duz deyil";
                lblredaktemsg.ForeColor = Color.Red;
                datalist1();
            }
        }
        else
        {
            if (lblgelmeredakte.Text == "" || lblbitmeredakte.Text == "" || lblisecixma.Text == "")
            {
                lblredaktemsg.Text = "Tarix  boş ola bilməz";
                lblredaktemsg.ForeColor = Color.Red;
                datalist1();
            }
        }
    }

    protected void btntesdiqolmamiw_Click(object sender, EventArgs e)
    {
        btntesdiqolmuw0.BackColor = SystemColors.ButtonFace;
        pnlgonderilmeyen.Visible = false;
        DataList1.Visible = false;
        pnlrayonuzre1.Visible = false;
        eztarixnezaret.BackColor = SystemColors.ButtonFace;
        pnleztarixnezaret.Visible = false;
        pnltesdiqolunmamiw.Visible = true;
        pnltesdiqolunmuw.Visible = false;
        pnlrayuzre2.Visible = false;
        pnlumumi2.Visible = false;
        btnumumi1.BackColor = SystemColors.ButtonFace;
        btnrayuzre1.BackColor = SystemColors.ButtonFace;
        btntesdiqolmamiw.BackColor = Color.GreenYellow;
        btntesdiqolmuw.BackColor = SystemColors.ButtonFace;
        //if (pnlrayonuzre1.Visible)
        //{
        //    btnrayuzre1.BackColor = Color.Aquamarine;
        //}
        //if (DataList1.Visible)
        //{
        //btnumumi1.BackColor = Color.Aquamarine;
        //}
    }
    protected void btntesdiqolmuw_Click(object sender, EventArgs e)
    {
        pnlgonderilmeyen.Visible = false;
        pnlrayuzre2.Visible = false;
        pnlumumi2.Visible = false;
        eztarixnezaret.BackColor = SystemColors.ButtonFace;
        btntesdiqolmuw0.BackColor = SystemColors.ButtonFace;
        pnleztarixnezaret.Visible = false;
        btnumumi2.BackColor = SystemColors.ButtonFace;
        btnrayuzre2.BackColor = SystemColors.ButtonFace;
        btntesdiqolmuw.BackColor = Color.GreenYellow;
        btntesdiqolmamiw.BackColor = SystemColors.ButtonFace;
        pnltesdiqolunmamiw.Visible = false;
        pnltesdiqolunmuw.Visible = true;
        pnlrayonuzre1.Visible = false;
        pnlumumi1.Visible = false;
        //if (pnlrayuzre2.Visible)
        //{
        //    btnrayuzre2.BackColor = Color.Aquamarine;
        //}
        //if (pnlumumi2.Visible)
        //{
        //    btnumumi2.BackColor = Color.Aquamarine;
        //}
        
    }

    protected void btnrayuzre1_Click(object sender, EventArgs e)
    {
        Calendar1.Visible = false;
        Calendar3.Visible = false;
        datalistrayontarix();
       
        ddlusers.SelectedValue = "-1";
      
            ryn1();
  
        lblmesage.Text = "";
        lblgelme.Text = "";
        lblgetme.Text = "";
        lblgelme1.Text = "";
        lblgetme1.Text = "";
        imgbsilgelme.Visible = false;

        imgbsilgetme0.Visible = false;

        pnlrayonuzre1.Visible = true;
        pnlumumi1.Visible = false;
        btnrayuzre1.BackColor = Color.Aquamarine;
        btnumumi1.BackColor = SystemColors.ButtonFace;
 
  
        
    }
    protected void btnumumi1_Click(object sender, EventArgs e)
    {
        Session[rownumber] = null;
        DataList1.Visible = true;
        datalist1();
        pnlumumi1.Visible = true;
        pnlrayonuzre1.Visible = false;
        pnlredakte.Visible = false;
        btnumumi1.BackColor = Color.Aquamarine;
        btnrayuzre1.BackColor = SystemColors.ButtonFace;

    }
    protected void btnumumi2_Click(object sender, EventArgs e)
    {
        btnumumi2.BackColor = Color.Aquamarine;
        btnrayuzre2.BackColor = SystemColors.ButtonFace;
        pnlumumi2.Visible = true;
        pnlrayuzre2.Visible = false;
        datalist2();
    }
    protected void btnrayuzre2_Click(object sender, EventArgs e)
    {
        Calendar2.Visible = false;
        Calendar4.Visible = false;
        ddlusers3.SelectedValue = "-1";
      
            ryn2();
      
        lblmesage3.Text = "";
        lblgelme3.Text = "";
        lblgetme3.Text = "";
        lblgelme13.Text = "";
        lblgetme13.Text = "";
        imgbsilgelme3.Visible = false;

        imgbsilgetme03.Visible = false;


        btnrayuzre2.BackColor = Color.Aquamarine;
        btnumumi2.BackColor = SystemColors.ButtonFace;
        pnlumumi2.Visible = false;
        pnlrayuzre2.Visible = true;
        datalistrayontarix2();
    }
    protected void DataList1_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {
            if (Session[rownumber] != null)
            {
                if (e.Item.ItemIndex == int.Parse(Session[rownumber].ToString()))
                {
                    e.Item.BackColor = System.Drawing.Color.Aqua;
                }
            }
        }
    }

    protected void btntesdiqolmuw0_Click(object sender, EventArgs e)
    {
     
        btnyenideniwle.BackColor = SystemColors.ButtonFace;
        eztarixnezaret.BackColor = SystemColors.ButtonFace;
        btntesdiqolmuw0.BackColor =  Color.GreenYellow;
        btntesdiqolmamiw.BackColor = SystemColors.ButtonFace;
        btntesdiqolmuw.BackColor = SystemColors.ButtonFace;
        pnlgonderilmeyen.Visible = true;
        dlgonderumumi.Visible = false;
        dlteqdimolunmuw.Visible = false;
        btngonumumi.BackColor = SystemColors.ButtonFace;  
        btngonray.BackColor = SystemColors.ButtonFace;  
        
        pnlsebeb.Visible = false;
        dlyenideniwle.Visible = false;
        Session[rownumber] = null;
        pnlrealtarixgetme.Visible = false;
        pnlrealtarixgelme.Visible = false;
        pnleztarixnezaret.Visible = false;
        pnltesdiqolunmamiw.Visible = false;
        pnltesdiqolunmuw.Visible = false;
       
    }

    protected void eztarixnezaret_Click(object sender, EventArgs e)
    {
        lblsebeb1.Visible = false;
        btneztarixnez.BackColor = SystemColors.ButtonFace;
        btneztarixnezarxiv.BackColor = SystemColors.ButtonFace;
        btnicazever.BackColor = SystemColors.ButtonFace;
        dlnezaretarxiv.Visible = false;
        pnlgonderilmeyen.Visible = false;
        pnlsebeb.Visible = false;
        lblsebeb.Text = "";
        Session[rownumber] = null;
        pnlrealtarixgetme.Visible = false;
        pnlrealtarixgelme.Visible = false;
        pnleztarixnezaret.Visible = true;
        dleztarixnez.Visible = false;
        pnlicazever.Visible = false;
        pnltesdiqolunmamiw.Visible = false;
        pnltesdiqolunmuw.Visible = false;
        pnlicazever.Visible = false;
        eztarixnezaret.BackColor = Color.GreenYellow;
        btntesdiqolmuw0.BackColor = SystemColors.ButtonFace;
        btntesdiqolmamiw.BackColor = SystemColors.ButtonFace;
        btntesdiqolmuw.BackColor = SystemColors.ButtonFace;
    }
    protected void ImageButton1_Click1(object sender, ImageClickEventArgs e)
    {
        if (cldraygetmetrx.Visible)
        {
            cldraygetmetrx.Visible = false;
            lblraygetme.Visible = true;

        }
        else
        {
            cldraygetmetrx.Visible = true;
            lblraygetme.Visible = false;
        }
        if (islem == "realtimeregioncome")
        {
            dlezamiyyetarixnezaret();
            dlnezaretarxiv.Visible = false;
        }
        if (islem == "realtimeregioncome1")
        {
            ezamiyyetarixnezaretarxiv();
            dleztarixnez.Visible = false;
        }
        if (islem == "realtimegofromregion")
        {
            dlezamiyyetarixnezaret();
            dlnezaretarxiv.Visible = false;
        }
        if (islem == "realtimegofromregion1")
        {
            ezamiyyetarixnezaretarxiv();
            dleztarixnez.Visible = false;
        }
        if (islem == "sebeb")
        {
            dlezamiyyetarixnezaret();
            dlnezaretarxiv.Visible = false;
        }
        if (islem == "sebeb1")
        {
            ezamiyyetarixnezaretarxiv();
            dleztarixnez.Visible = false;
        }
        
    }
    protected void ImageButton2_Click1(object sender, ImageClickEventArgs e)
    {
        if (cldraygelmetrx.Visible)
        {
            cldraygelmetrx.Visible = false;
            lblraygelme.Visible = true;
        }
        else
        {
            cldraygelmetrx.Visible = true;
            lblraygelme.Visible = false;
        }
        if (islem == "realtimeregioncome")
        {
            dlezamiyyetarixnezaret();
            dlnezaretarxiv.Visible = false;
        }
        if (islem == "realtimeregioncome1")
        {
            ezamiyyetarixnezaretarxiv();
            dleztarixnez.Visible = false;
        }
        if (islem == "realtimegofromregion")
        {
            dlezamiyyetarixnezaret();
            dlnezaretarxiv.Visible = false;
        }
        if (islem == "realtimegofromregion1")
        {
            ezamiyyetarixnezaretarxiv();
            dleztarixnez.Visible = false;
        }
        if (islem == "sebeb")
        {
            dlezamiyyetarixnezaret();
            dlnezaretarxiv.Visible = false;
        }
        if (islem == "sebeb1")
        {
            ezamiyyetarixnezaretarxiv();
            dleztarixnez.Visible = false;
        }
        
    }
    protected void btnrayontrx_Click(object sender, EventArgs e)
    {
        if (lblraygetme.Text != "")
        {
            string gelme = lblraygetme.Text + " " + "00:00:00.000";
            string getme = lblraygelme.Text + " " + "00:00:00.000";

            string gelme1 = lblraygetme0.Text + " " + "00:00:00.000";
            string cix = lblraygelme0.Text + " " + "00:00:00.000";

            Boolean getmeni = false;
            if (getme == " 00:00:00.000")
            {
     
                getmeni = true;
            }
            if ((Convert.ToDateTime(gelme) <= Convert.ToDateTime(getme)) || getmeni == true)
            {
                SqlConnection baglanti = klas.baglan();
                SqlCommand cmd = new SqlCommand("Update FRegions set DateRealRegionCome=@DateRealRegionCome where RegionID=" + Session["RegionID"].ToString(), baglanti);
                cmd.Parameters.Add("DateRealRegionCome", Convert.ToDateTime(gelme));
                cmd.ExecuteNonQuery();
                lbltrxmesage.Text = "Tarix əlavə edildi";
                lbltrxmesage.ForeColor = Color.Green;
                Session[rownumber] = null;
                pnlrealtarixgetme.Visible = false;
                pnlrealtarixgelme.Visible = false;
            }
            else
            {
                lbltrxmesage.Text = "Tarix  duz deyil";
                lbltrxmesage.ForeColor = Color.Red;
            }
        }
        else
        {
            if (lblraygetme.Text == "" || lblraygelme.Text == "")
            {
                lbltrxmesage.Text = "Tarix  boş ola bilməz";
                lbltrxmesage.ForeColor = Color.Red;
            }
        }
        if (islem == "realtimeregioncome")
        {
            dlezamiyyetarixnezaret();
            dlnezaretarxiv.Visible = false;
        }
        if (islem == "realtimeregioncome1")
        {
            ezamiyyetarixnezaretarxiv();
            dleztarixnez.Visible = false;
        }
        if (islem == "realtimegofromregion")
        {
            dlezamiyyetarixnezaret();
            dlnezaretarxiv.Visible = false;
        }
        if (islem == "realtimegofromregion1")
        {
            ezamiyyetarixnezaretarxiv();
            dleztarixnez.Visible = false;
        }
        if (islem == "sebeb")
        {
            dlezamiyyetarixnezaret();
            dlnezaretarxiv.Visible = false;
        }
        if (islem == "sebeb1")
        {
            ezamiyyetarixnezaretarxiv();
            dleztarixnez.Visible = false;
        }
    }
    protected void cldraygelmetrx_SelectionChanged(object sender, EventArgs e)
    {
        if (islem == "realtimeregioncome")
        {
            dlezamiyyetarixnezaret();
            dlnezaretarxiv.Visible = false;
        }
        if (islem == "realtimeregioncome1")
        {
            ezamiyyetarixnezaretarxiv();
            dleztarixnez.Visible = false;
        }
        if (islem == "realtimegofromregion")
        {
            dlezamiyyetarixnezaret();
            dlnezaretarxiv.Visible = false;
        }
        if (islem == "realtimegofromregion1")
        {
            ezamiyyetarixnezaretarxiv();
            dleztarixnez.Visible = false;
        }
        if (islem == "sebeb")
        {
            dlezamiyyetarixnezaret();
            dlnezaretarxiv.Visible = false;
        }
        if (islem == "sebeb1")
        {
            ezamiyyetarixnezaretarxiv();
            dleztarixnez.Visible = false;
        }
        
        lblraygetme.Text = cldraygetmetrx.SelectedDate.ToString("d");
        lblraygetme0.Text = cldraygetmetrx.SelectedDate.ToString("yyyy-MM-dd");

        cldraygetmetrx.Visible = false;
        lblraygetme.Visible = true;
    }
    protected void cldraygetmetrx_SelectionChanged(object sender, EventArgs e)
    {
        if (islem == "realtimeregioncome")
        {
            dlezamiyyetarixnezaret();
            dlnezaretarxiv.Visible = false;
        }
        if (islem == "realtimeregioncome1")
        {
            ezamiyyetarixnezaretarxiv();
            dleztarixnez.Visible = false;
        }
        if (islem == "realtimegofromregion")
        {
            dlezamiyyetarixnezaret();
            dlnezaretarxiv.Visible = false;
        }
        if (islem == "realtimegofromregion1")
        {
            ezamiyyetarixnezaretarxiv();
            dleztarixnez.Visible = false;
        }
        if (islem == "sebeb")
        {
            dlezamiyyetarixnezaret();
            dlnezaretarxiv.Visible = false;
        }
        if (islem == "sebeb1")
        {
            ezamiyyetarixnezaretarxiv();
            dleztarixnez.Visible = false;
        }
        lblraygelme.Text = cldraygelmetrx.SelectedDate.ToString("d");
        lblraygelme0.Text = cldraygelmetrx.SelectedDate.ToString("yyyy-MM-dd");

        cldraygelmetrx.Visible = false;
        lblraygelme.Visible = true;
        
    }

    protected void dleztarixnez_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {
            if (Session[rownumber] != null)
            {
                if (e.Item.ItemIndex == int.Parse(Session[rownumber].ToString()))
                {
                    e.Item.BackColor = System.Drawing.Color.Aqua;
                }
            }
        }
    }
    protected void btnrayondangetme_Click(object sender, EventArgs e)
    {
        if (lblraygelme.Text != "")
        {
            string gelme = lblraygetme.Text + " " + "00:00:00.000";
            string getme = lblraygelme.Text + " " + "00:00:00.000";

            string gelme1 = lblraygetme0.Text + " " + "00:00:00.000";
            string cix = lblraygelme0.Text + " " + "00:00:00.000";

            Boolean gelmeni = false;
            if (gelme == " 00:00:00.000")
            {
           
                gelmeni = true;
            }
            if ((Convert.ToDateTime(gelme) <= Convert.ToDateTime(getme)) || gelmeni == true)
            {
                SqlConnection baglanti = klas.baglan();
                SqlCommand cmd = new SqlCommand("Update FRegions set DateRealGoFromRegion=@DateRealGoFromRegion where RegionID=" + Session["RegionID"].ToString(), baglanti);
                cmd.Parameters.Add("DateRealGoFromRegion", Convert.ToDateTime(getme));
                cmd.ExecuteNonQuery();
                lbltrxmesage1.Text = "Tarix əlavə edildi";
                lbltrxmesage1.ForeColor = Color.Green;
                Session[rownumber] = null;
                pnlrealtarixgetme.Visible = false;
                pnlrealtarixgelme.Visible = false;
            }
            else
            {
                lbltrxmesage1.Text = "Tarix  duz deyil";
                lbltrxmesage1.ForeColor = Color.Red;

            }
        }
        else
        {
            if (lblraygetme.Text == "" || lblraygelme.Text == "")
            {
                lbltrxmesage1.Text = "Tarix  boş ola bilməz";
                lbltrxmesage1.ForeColor = Color.Red;
            }
        }
        if (islem == "realtimeregioncome")
        {
            dlezamiyyetarixnezaret();
            dlnezaretarxiv.Visible = false;
        }
        if (islem == "realtimeregioncome1")
        {
            ezamiyyetarixnezaretarxiv();
            dleztarixnez.Visible = false;
        }
        if (islem == "realtimegofromregion")
        {
            dlezamiyyetarixnezaret();
            dlnezaretarxiv.Visible = false;
        }
        if (islem == "realtimegofromregion1")
        {
            ezamiyyetarixnezaretarxiv();
            dleztarixnez.Visible = false;
        }
        if (islem == "sebeb")
        {
            dlezamiyyetarixnezaret();
            dlnezaretarxiv.Visible = false;
        }
        if (islem == "sebeb1")
        {
            ezamiyyetarixnezaretarxiv();
            dleztarixnez.Visible = false;
        }
    }
    protected void btnsebeb_Click(object sender, EventArgs e)
    {
        if (txtsebeb.Text !="")
        {
            SqlConnection baglanti = klas.baglan();
            SqlCommand cmd = new SqlCommand("Update FRegions set Purpose=@Purpose where RegionID=" + Session["RegionID"].ToString(), baglanti);
            cmd.Parameters.Add("Purpose", txtsebeb.Text);
            cmd.ExecuteNonQuery();
            lblsebeb.Text = "Səbəb əlavə edildi";
            lblsebeb.ForeColor = Color.Green;
            Session[rownumber] = null;
            pnlrealtarixgetme.Visible = false;
            pnlrealtarixgelme.Visible = false;
            pnlsebeb.Visible = false;
        }
        else
        {
            lblsebeb.Text = "Səbəb  boşluq ola bilməz";
            lblsebeb.ForeColor = Color.Red;

        }
        if (islem == "realtimeregioncome")
        {
            dlezamiyyetarixnezaret();
        }
        if (islem == "realtimeregioncome1")
        {
            ezamiyyetarixnezaretarxiv();
        }
        if (islem == "realtimegofromregion")
        {
            dlezamiyyetarixnezaret();
        }
        if (islem == "realtimegofromregion1")
        {
            ezamiyyetarixnezaretarxiv();
        }
        if (islem == "sebeb")
        {
            dlezamiyyetarixnezaret();
        }
        if (islem == "sebeb1")
        {
            ezamiyyetarixnezaretarxiv();
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
        if (lblgelme.Text == "") {
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
    protected void Button1_Click(object sender, EventArgs e)
    {
        datalistrayontarix();

    }

    protected void exele_Click(object sender, EventArgs e)
    {

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
    protected void planabax3_Click(object sender, EventArgs e)
    {
        datalistrayontarix2();

    }

    protected void imgbsilgelme3_Click(object sender, ImageClickEventArgs e)
    {
        lblgelme3.Text = "";
        lblgelme13.Text = "";
        imgbsilgelme3.Visible = false;
    }
    protected void imgbsilgetme03_Click(object sender, ImageClickEventArgs e)
    {
        lblgetme3.Text = "";
        lblgetme13.Text = "";
        imgbsilgetme03.Visible = false;
    }
    protected void ImageButton3_Click1(object sender, ImageClickEventArgs e)
    {
        if (Calendar2.Visible)
        {
            Calendar2.Visible = false;
            lblgelme3.Visible = true;
            imgbsilgelme3.Visible = true;
        }
        else
        {
            imgbsilgelme3.Visible = false;
            Calendar2.Visible = true;
            lblgelme3.Visible = false;
        }
        if (lblgelme3.Text == "")
        {
            imgbsilgelme3.Visible = false;
        }
    }
    protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
    {
        if (Calendar4.Visible)
        {
            Calendar4.Visible = false;
            lblgetme3.Visible = true;
            imgbsilgetme03.Visible = true;
        }
        else
        {
            Calendar4.Visible = true;
            lblgetme3.Visible = false;
            imgbsilgetme03.Visible = false;
        }
        if (lblgetme3.Text == "")
        {
            imgbsilgetme03.Visible = false;
        }
    }
    protected void Calendar2_SelectionChanged(object sender, EventArgs e)
    {
        lblgelme3.Text = Calendar2.SelectedDate.ToString("d");
        lblgelme13.Text = Calendar2.SelectedDate.ToString("yyyy-MM-dd");
        Calendar2.Visible = false;
        lblgelme3.Visible = true;
        imgbsilgelme3.Visible = true;
    }
    protected void Calendar4_SelectionChanged(object sender, EventArgs e)
    {
        lblgetme3.Text = Calendar4.SelectedDate.ToString("d");
        lblgetme13.Text = Calendar4.SelectedDate.ToString("yyyy-MM-dd");
        Calendar4.Visible = false;
        lblgetme3.Visible = true;
        imgbsilgetme03.Visible = true;
    }

    protected void excele3_Click(object sender, EventArgs e)
    {

    }
    protected void ddlusers_SelectedIndexChanged(object sender, EventArgs e)
    {

        if (ddlusers.SelectedValue == "-1")
        {
            ryn1();
        }
        else {
            ryn();
        }
 
    }
    protected void ddlusers3_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlusers3.SelectedValue == "-1")
        {

            ryn2();
        }
        else
        {
            ryn3();
        }
    }
    protected void btngonumumi_Click(object sender, EventArgs e)
    {
        Session[rownumber] = null;
        btngonumumi.BackColor = Color.Aquamarine;
        btngonray.BackColor = SystemColors.ButtonFace;
        btnyenideniwle.BackColor = SystemColors.ButtonFace;
        gonderumumi();
        dlgonderumumi.Visible = true;
        dlteqdimolunmuw.Visible = false;
        dlyenideniwle.Visible = false;
    }
    protected void btngonray_Click(object sender, EventArgs e)
    {
        teqdimolunmuw();
        Session[rownumber] = null;
        dlgonderumumi.Visible =false ;
        dlteqdimolunmuw.Visible = true;
        dlyenideniwle.Visible = false;
        btngonray.BackColor = Color.Aquamarine;
        btngonumumi.BackColor = SystemColors.ButtonFace;
        btnyenideniwle.BackColor = SystemColors.ButtonFace;
    }
    protected void btneztarixnez_Click(object sender, EventArgs e)
    {
        lblsebeb1.Visible = false;
        pnlsebeb.Visible = false;
        pnlicazever.Visible = false;
        lblsebeb.Text = "";
        Session[rownumber] = null;
        pnlrealtarixgetme.Visible = false;
        pnlrealtarixgelme.Visible = false;
        dlezamiyyetarixnezaret();
        btneztarixnez.BackColor = Color.Aquamarine;
        btneztarixnezarxiv.BackColor = SystemColors.ButtonFace;
        btnicazever.BackColor = SystemColors.ButtonFace;
        dlnezaretarxiv.Visible = false;
        dleztarixnez.Visible = true;
    }
    protected void btneztarixnezarxiv_Click(object sender, EventArgs e)
    {
        lblsebeb1.Visible = false;
        pnlsebeb.Visible = false;
        pnlicazever.Visible = false;
        lblsebeb.Text = "";
        Session[rownumber] = null;
        pnlrealtarixgetme.Visible = false;
        pnlrealtarixgelme.Visible = false;
        dleztarixnez.Visible = false;
        ezamiyyetarixnezaretarxiv();
        dlnezaretarxiv.Visible = true;
        btneztarixnez.BackColor = SystemColors.ButtonFace; 
        btneztarixnezarxiv.BackColor = Color.Aquamarine;
        btnicazever.BackColor = SystemColors.ButtonFace;
    }
    protected void btnyenideniwle_Click(object sender, EventArgs e)
    {
        yenideniwle();
        Session[rownumber] = null;
        btnyenideniwle.BackColor = Color.Aquamarine;
        btngonray.BackColor = SystemColors.ButtonFace;
        btngonumumi.BackColor = SystemColors.ButtonFace;
        dlgonderumumi.Visible = false;
        dlteqdimolunmuw.Visible = false;
        dlyenideniwle.Visible = true;
    }
    void icaze()
    {
        DataTable dtGruplar = klas.getdatatable(@"Select Userid,Name+' '+Sname as Name from Users  where status_users=0 and permit=1");
        dlicaze.DataSource = dtGruplar;
        dlicaze.DataBind();
    }
    protected void btnicazever_Click(object sender, EventArgs e)
    {
        pnlicazever.Visible = true;
        lblsebeb1.Visible = false;
        pnlsebeb.Visible = false;
        lblicazever.Text = "";
        Session[rownumber] = null;
        pnlrealtarixgetme.Visible = false;
        pnlrealtarixgelme.Visible = false;
        icazever();
        btnicazever.BackColor = Color.Aquamarine;
        btneztarixnez.BackColor = SystemColors.ButtonFace;
        btneztarixnezarxiv.BackColor = SystemColors.ButtonFace;
        dlnezaretarxiv.Visible = false;
        dleztarixnez.Visible = false;
        icaze();
    }
    protected void btnicazesaxla_Click(object sender, EventArgs e)
    {
        string s = klas.getdatacell("select * from Users where status_users=0 and permit=1 and UserID=" + ddlicazever.SelectedValue);
        if (ddlicazever.SelectedValue != "0" && s==null)
        {
            SqlConnection baglanti = klas.baglan();
            SqlCommand cmd = new SqlCommand("Update Users Set permit=@permit Where status_users=0 and UserID=" + ddlicazever.SelectedValue, baglanti);
            cmd.Parameters.Add("permit", 1);
            cmd.ExecuteNonQuery();
            Response.Redirect("Yeniezamiyye.aspx");
            //icaze();
        }
        else {
            lblicazever.Text = "Kurator şeçilməyib";
            if (s != null) {
                lblicazever.Text = "Artıq icazə verilib";
            }
        }
    }
}
