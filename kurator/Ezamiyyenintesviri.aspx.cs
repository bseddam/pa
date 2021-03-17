using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class adminpanel_Ezamiyyenintesviri : System.Web.UI.Page
{
    Class2 klas = new Class2(); int a = 0; string islem; string BusinessTripID; string userid; string regionid; string rownumber = "";
    string regiongelme; string regiongetme; string isecixma; string RayonID; string RegionCode; string islem1; string userid1 = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        LinkButton lblprofil = (LinkButton)Master.FindControl("Yeniezamiyye");
        lblprofil.BackColor = Color.Peru;

        userid1 = Request.QueryString["UserID"];
        if (userid1 != null)
        {
            Session["UserID"] = userid1;
        }

        if (Session["UserID"] == null)
        {
            Response.Redirect("~/adminpanel/admingiris.aspx", true);
        }
  
      
        Calendar3.SelectedDates.Clear();
        Calendar1.SelectedDates.Clear();
        Calendar2.SelectedDates.Clear();
        cldgelme.SelectedDates.Clear();
        cldbitme.SelectedDates.Clear();
        cldisecixma.SelectedDates.Clear();
        cldraygetmetrx.SelectedDates.Clear();
        cldraygelmetrx.SelectedDates.Clear();
       
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

        }
        catch (Exception)
        { }



        if (Page.IsPostBack == false)
        {
            btnumgeri.Visible = false;
            if (BusinessTripID != null )
            {
                DataRow dryoxla = klas.GetDataRow("SELECT     dbo.Users.UserID, dbo.Fbusiness_trip.BusinessTripID " +
                    "FROM         dbo.Fbusiness_trip INNER JOIN " +
                    " dbo.Users ON dbo.Fbusiness_trip.UserID = dbo.Users.UserID " +
                    "WHERE     (dbo.Fbusiness_trip.UserID = " + Session["UserID"].ToString() + ") AND (dbo.Fbusiness_trip.BusinessTripID = " + BusinessTripID + ") ");
                if (dryoxla == null)
                {
                    Response.Redirect("~/adminpanel/admingiris.aspx");
                }

            }

            lblgelme.Text = "";
            lblcixma.Text = "";
            lblgetme.Text = "";
            pnlteqvimelave.Visible = false;
            string useradsoyad;
            DataRow user = klas.GetDataRow("select Name +' '+ Sname as Name from Users where UserID=" + Session["UserID"].ToString());
            if (user != null)
            {
                useradsoyad = user["Name"].ToString();
                if (islem == "Default") {

                    pnlyenideniwle.Visible = true;

                    btnyenideniwle.BackColor = Color.Aquamarine;
                    btntesdiqolunmuw.BackColor = SystemColors.ButtonFace;
                    btnteqvimelave.BackColor = SystemColors.ButtonFace;
                    btnezamsiyahi.BackColor = SystemColors.ButtonFace;
                    dlyenideniwle();
                    pnl1.Visible = false;
                    pnl2.Visible = false;
                    pnltesdiqolunmuw.Visible = false;
                    pnlsiyahi.Visible = false;
                    pnlteqvimelave.Visible = false;
                    pnlredakte.Visible = false;
                    pnlrayontarix.Visible = false;


                    btnumgeri.Visible = false;
                    message.Visible = false;
                    pnlteqvimelave.Visible = false;
                }
            if (islem == "fayl") {
                btnyenideniwle.BackColor = Color.Aquamarine;
                pnlyenideniwle.Visible = true;
                pnlteqvimelave.Visible = false;
                pnlrayontarix.Visible = false;
                pnltesdiqolunmuw.Visible = false;
                btnumgeri.Visible = false;
             
                dlyenideniwle();
                DataRow dtcel = klas.GetDataRow("select FileName from FRegions where RegionID=" + RayonID);
                if (dtcel["FileName"].ToString() != "" && dtcel!=null)
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
            }
            
            if (islem == "faylsil")
            {
                btnyenideniwle.BackColor = Color.Aquamarine;
                pnlyenideniwle.Visible = true;
                pnlteqvimelave.Visible = false;
                pnlrayontarix.Visible = false;
                pnltesdiqolunmuw.Visible = false;
                btnumgeri.Visible = false;

                DataRow dtsil = klas.GetDataRow("select FileName from FRegions where RegionID=" + RayonID);
                if (dtsil["FileName"].ToString() != "" && dtsil != null)
                {
                    System.IO.FileInfo file = new System.IO.FileInfo(Server.MapPath("~/iradlar/" + useradsoyad + "/" + dtsil["FileName"].ToString()));

              
                    if (file.Exists)//check file exsit or not
                    {
                        file.Delete();
                        SqlConnection baglanti = klas.baglan();
                        SqlCommand cmd2 = new SqlCommand("Update FRegions set FileName=null where RegionID=" + RayonID, baglanti);
                     
                        cmd2.ExecuteNonQuery();
                    }
            
                }
                dlyenideniwle();
            }
            }

            if (islem == "rayontarix")
            {
                btnumgeri.Visible = true;
                if (BusinessTripID != null)
                {
                    Session["BusinessTripidmax"] = BusinessTripID;
                }
                pnlrayontarix.Visible = true;
                datalistrayontarix();
                pnlteqvimelave.Visible = false;
                pnlyenideniwle.Visible = false;
                btnezamsiyahi.BackColor = Color.Aquamarine;
            }
            if (islem1 == "rayontarix1")
            {
                btnumgeri.Visible = true;
                if (BusinessTripID != null)
                {
                    Session["BusinessTripidmax"] = BusinessTripID;
                }
                pnltesdiqolunmuw.Visible = true;
                pnl2.Visible = true;
                pnl1.Visible = false;
                datalist3();
                datalistrayontarix12();
                btnezamsiyahi.BackColor = SystemColors.ButtonFace;
                pnltesdiqolunmuw.Visible = true;
                pnlsiyahi.Visible = false;
                pnlteqvimelave.Visible = false;
                pnlredakte.Visible = false;
                pnlrayontarix.Visible = false;
                btnrayuzre.BackColor = Color.GreenYellow;
                btntesdiqolunmuw.BackColor = Color.Aquamarine;

                btnumgeri.Visible = false;
                message.Visible = false;
                pnlteqvimelave.Visible = false;


            }
        
            if (islem == "rayondeyiw")
            {
                btnumgeri.Visible = true;
                pnlradiobuttarixdeyiw.Visible = true;
                Session["BusinessTripID1"] = BusinessTripID.ToString();
                Session[rownumber] = rownumber;
                pnlrayontarix.Visible = true;
                pnlredakte.Visible = false;
                datalistrayontarix();
                pnlteqvimelave.Visible = false;
                regionredaktechk();
                digerregionredaktechk();
                btnezamsiyahi.BackColor = Color.Aquamarine;
            
                rblredakte.ClearSelection();

                for (int i = 0; i < 100; i++)
                {
                    string a = RegionCode;
                    

                    for (int j = 0; j < rblredakte.Items.Count; j++)
                    {
                        if (rblredakte.Items[j].Value == a)
                        {
                            rblredakte.Items[j].Selected = true;
                        }
                    }
                }
             
                digerrayonelave.ClearSelection();

                for (int i = 0; i < 100; i++)
                {
                    string a = RegionCode;


                    for (int j = 0; j < digerrayonelave.Items.Count; j++)
                    {
                        if (digerrayonelave.Items[j].Value == a)
                        {
                            digerrayonelave.Items[j].Selected = true;
                        }
                    }
                }
            }
            if (islem == "tarix")
            {
                btnezamsiyahi.BackColor = Color.Aquamarine;
                btnumgeri.Visible = true;
                string regiongelme1;
                string regiongetme1;
                Session[rownumber] = rownumber;
                datalistrayontarix();
                pnlrayontarix.Visible = true;
                pnlteqvimelave.Visible = false;
                pnltarixinsert.Visible = true;

                DataRow calendar1 = klas.GetDataRow("Select * from FRegions where RegionID=" +RayonID);
                
                regiongelme1 = calendar1["RegionCome"].ToString();
                regiongetme1 = calendar1["GoFromRegion"].ToString();

                string gelmetarix1 = Class2.sozukes(regiongelme1);
                string getmetarix1 = Class2.sozukes(regiongetme1);

                lblraygetme.Text = gelmetarix1;
                lblraygelme.Text = getmetarix1;
                if (gelmetarix1 != "")
                lblraygelme0.Text = Convert.ToDateTime(gelmetarix1).ToString("yyyy-MM-dd");
                if (getmetarix1 != "")
                lblraygetme0.Text = Convert.ToDateTime(getmetarix1).ToString("yyyy-MM-dd"); 
            }

            if (islem == "duzelis")
            {
                btnezamsiyahi.BackColor = Color.Aquamarine;
                btnumgeri.Visible = true;
                pnlteqvimelave.Visible = false;
                btnezamsiyahi.BackColor = Color.Aquamarine;
                btnteqvimelave.BackColor = SystemColors.ButtonFace;
                
                Session[rownumber] = rownumber;

                DataRow calendar = klas.GetDataRow("Select * from Fbusiness_trip where BusinessTripID=" + BusinessTripID);
                userid = calendar["UserID"].ToString();
                regionid = calendar["RegionID"].ToString();
                regiongelme = calendar["RegionCome"].ToString();
                regiongetme = calendar["GoFromRegion"].ToString();
                isecixma = calendar["ComingToWork"].ToString();
                regionredaktechk();
                digerregionredaktechk();
                string gelmetarix = Class2.sozukes(regiongelme);
                string getmetarix = Class2.sozukes(regiongetme);
                string isecixmatarix = Class2.sozukes(isecixma);

                lblgelmeredakte.Text = gelmetarix;
                lblbitmeredakte.Text = getmetarix;
                lblisecixma.Text = isecixmatarix;

                lblrayona.Text = Convert.ToDateTime(regiongelme).ToString("yyyy-MM-dd");
                lblcix.Text = Convert.ToDateTime(regiongetme).ToString("yyyy-MM-dd"); 

                //for (int k = 0; k < rblredakte.Items.Count; k++)
                //{
                //    rblredakte.Items[k].Selected = false;
                //}

                //for (int i = 0; i < 100; i++)
                //{
                //    string a = regionid;
                //    Session["regionid"] = regionid;

                //    for (int j = 0; j < rblredakte.Items.Count; j++)
                //    {
                //        if (rblredakte.Items[j].Value == a)
                //        {
                //            rblredakte.Items[j].Selected = true;
                //        }
                //    }
                //}
                pnlredakte.Visible = true;
                pnlsiyahi.Visible = true;

                datalist1();
                //datalist2();
            }
            if (islem == "sil")
            {
                DataRow dt = klas.GetDataRow("select * from FRegions Where BusinessTripID=" + BusinessTripID + " and Approval=4");
                if (dt == null)
                {
                    btnezamsiyahi.BackColor = Color.Aquamarine;
                    btnumgeri.Visible = true;
                    klas.cmd("Delete from Fbusiness_trip Where BusinessTripID=" + BusinessTripID);
                    klas.cmd("Delete from FRegions Where BusinessTripID=" + BusinessTripID);
                    pnlsiyahi.Visible = true;
                    pnlteqvimelave.Visible = false;
                    datalist1();
                    Session[rownumber] = null;
                }
                else
                {
                    pnlsilolmaz.Visible = true;
                    lblsilolmaz.Text = "Silinə bilməz bu ezamiyyədə təsdiq olunan rayon var";
                    lblsilolmaz.ForeColor = Color.Red;
                }
            }
           
            if (islem == "rayonsil")
            {
                DataTable rayon1deneqalibsa=klas.getdatatable("select * from FRegions where BusinessTripID=" + BusinessTripID);
                btnezamsiyahi.BackColor = Color.Aquamarine;
                btnumgeri.Visible = true;
                DataRow fregion = klas.GetDataRow("select * from FRegions where BusinessTripID='" + BusinessTripID+ "' and RegionID="+RayonID.ToString());
                DataRow bsregion = klas.GetDataRow("select * from Fbusiness_trip where BusinessTripID=" + BusinessTripID);

                string replace;
                if (bsregion["Regions"].ToString().LastIndexOf(", " + fregion["Name"].ToString()) >= 0)
                {
                    replace = bsregion["Regions"].ToString().Replace(", " + fregion["Name"].ToString(), "");
                }
                else if (bsregion["Regions"].ToString().LastIndexOf(fregion["Name"].ToString() + ", ") >= 0)
                {
                    replace = bsregion["Regions"].ToString().Replace(fregion["Name"].ToString()+", ", "");
                }
                else 
                {
                    replace = bsregion["Regions"].ToString().Replace(fregion["Name"].ToString(), "");
                }

           

                SqlConnection baglanti = klas.baglan();
                SqlCommand cmd2 = new SqlCommand("Update Fbusiness_trip set Regions=@Regions where BusinessTripID=" + BusinessTripID, baglanti);
                cmd2.Parameters.Add("Regions", replace);
                cmd2.ExecuteNonQuery();

                pnlrayontarix.Visible = true;
                datalistrayontarix();
                pnlteqvimelave.Visible = false;
                klas.cmd("Delete from FRegions Where BusinessTripID='" + BusinessTripID + "' and RegionID=" + RayonID.ToString());
                datalistrayontarix();
                Session[rownumber] = null;
                if (rayon1deneqalibsa.Rows.Count ==1)
                {
                    klas.cmd("Delete from Fbusiness_trip Where BusinessTripID="+BusinessTripID);
                    Response.Redirect("Ezamiyyenintesviri.aspx");
                }
            }
            if (islem == "meqsed")
            {
                btnumgeri.Visible = true;
                pnlteqvimelave.Visible = false;
                btnezamsiyahi.BackColor = Color.Aquamarine;
                btnteqvimelave.BackColor = SystemColors.ButtonFace;
                Session[rownumber] = rownumber;

                cldgelme.Visible = false;
                cldbitme.Visible = false;
                cldisecixma.Visible = false;
                pnlsiyahi.Visible = true;

                datalist1();
            }
        }
    }

    public static string planagirme1(string planagirme2)
    {
        string deger = "";
        if (planagirme2 == "1" || planagirme2 == "4")
        {
            deger = "Təqdim olunub";
        }
        else if (planagirme2 == "2")
        {
            deger = "Təsdiqə verilməlidir";
        }
        else if (planagirme2 == "3")
        {
            deger = "Yenidən işlənməsi təklif olunur";
        }
        else
        {
            deger = "Təqdim olunmayıb";
        }
        return deger;
    }
    public static string planagirme2(string planagirme2)
    {
        string deger = "";
        if (planagirme2 == "1" || planagirme2 == "4")
        {
            deger = "Green";
        }
        else
        {
            deger = "Red";
        }
        return deger;
    }
    void datalistrayontarix()
    {

        string s = @"SELECT    dbo.FRegions.DateApproval_ze,dbo.FRegions.RegionCode, dbo.FRegions.RegionID, dbo.FRegions.Name, dbo.FRegions.RegionCome, dbo.FRegions.GoFromRegion, 
                      dbo.FRegions.BusinessTripID, dbo.Users.Name + ' ' + dbo.Users.Sname AS nameuser, dbo.Users.UserID, dbo.FRegions.Approval
FROM         dbo.FRegions INNER JOIN
                      dbo.Fbusiness_trip ON dbo.FRegions.BusinessTripID = dbo.Fbusiness_trip.BusinessTripID INNER JOIN
                      dbo.Users ON dbo.Fbusiness_trip.UserID = dbo.Users.UserID
WHERE    (dbo.FRegions.Approval <> 4) and dbo.FRegions.BusinessTripID = '" + Session["BusinessTripID"].ToString() + "' ORDER BY nameuser, dbo.FRegions.RegionCome DESC,dbo.FRegions.GoFromRegion DESC";
        DataTable dtGruplar = klas.getdatatable(s);
        dlrayontarix.DataSource = dtGruplar;
        dlrayontarix.DataBind();

        //if (dtGruplar.Rows.Count > 0)
        //{
        //    dlrayontarix.Visible = true;
        //}
        //else
        //{
        //    dlrayontarix.Visible = false;
        //}
    }



    void datalist3()
    {
        string s = @"select u.Name+' '+U.Sname as nameuser,* from Fbusiness_trip as b 
inner join Users as u on b.UserID=u.UserID
where 
 b.BusinessTripID   in (select r.BusinessTripID from FRegions as r where r.Approval=4) 
 and u.UserID='" + Session["UserID"].ToString() + "' order by nameuser,RegionCome DESC ";

        DataTable dtGruplar = klas.getdatatable(s);
        DataList3.DataSource = dtGruplar;
        DataList3.DataBind();

        //if (dtGruplar.Rows.Count > 0)
        //{
        //    DataList3.Visible = true;
        //}
        //else
        //{
        //    DataList3.Visible = false;
        //}
    }
    void datalistrayontarix12()
    {

        string s = @"SELECT  dbo.FRegions.DateApproval_ze,dbo.FRegions.RegionCode, dbo.FRegions.RegionID, dbo.FRegions.Name, dbo.FRegions.RegionCome, dbo.FRegions.GoFromRegion, 
                      dbo.FRegions.BusinessTripID, dbo.Users.Name + ' ' + dbo.Users.Sname AS nameuser, dbo.Users.UserID, dbo.FRegions.Approval
FROM         dbo.FRegions INNER JOIN
                      dbo.Fbusiness_trip ON dbo.FRegions.BusinessTripID = dbo.Fbusiness_trip.BusinessTripID INNER JOIN
                      dbo.Users ON dbo.Fbusiness_trip.UserID = dbo.Users.UserID
WHERE     (dbo.FRegions.Approval = 4) and (dbo.Users.UserID='" + Session["UserID"].ToString() + "') ORDER BY nameuser, dbo.FRegions.RegionCome DESC";
        DataTable dtGruplar = klas.getdatatable(s);
        dlrayontarix0.DataSource = dtGruplar;
        dlrayontarix0.DataBind();

        //if (dtGruplar.Rows.Count > 0)
        //{
        //    dlrayontarix0.Visible = true;
        //}
        //else
        //{
        //    dlrayontarix0.Visible = false;
        //}
    }



    void datalist1()
    {
        string s = @"SELECT DISTINCT 
                       dbo.Fbusiness_trip.RegionCome, dbo.Fbusiness_trip.GoFromRegion, dbo.Fbusiness_trip.ComingToWork, dbo.Fbusiness_trip.UserID, 
                      dbo.Users.Name + ' ' + dbo.Users.Sname AS nameuser, dbo.Fbusiness_trip.BusinessTripID, dbo.Fbusiness_trip.Regions
FROM         dbo.Fbusiness_trip INNER JOIN
                      dbo.Users ON dbo.Fbusiness_trip.UserID = dbo.Users.UserID INNER JOIN
                      dbo.FRegions ON dbo.Fbusiness_trip.BusinessTripID = dbo.FRegions.BusinessTripID
WHERE     (dbo.FRegions.Approval <> 4)  and dbo.Users.UserID='" + Session["UserID"].ToString() + "' ORDER BY nameuser, dbo.Fbusiness_trip.RegionCome DESC";
       
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




    void regionchk()
    {
        DataTable region2 = klas.getdatatable("SELECT  RegionsID,UserID,CASE WHEN CityID =  2 THEN Name" +
            " +' '+'rayonu' WHEN CityID =1 THEN Name +' '+N'şəhəri' END as Name FROM List_classification_Regions" +
 " where UserID='" + Session["UserID"].ToString() + "' and ForDelete=1  order by [Name]");
        chkregion.DataTextField = "Name";
        chkregion.DataValueField = "RegionsID";
        chkregion.DataSource = region2;
        chkregion.DataBind();
    }

    void digerregionchk()
    {
        DataTable region2 = klas.getdatatable("select RegionsID,CASE WHEN CityID =  2 THEN Name "+
            "+' '+'rayonu' WHEN CityID =1 THEN Name +' '+N'şəhəri' END as Name  from List_classification_Regions " +
            " where ForDelete=1 and RegionsID not in (SELECT  RegionsID FROM List_classification_Regions "+
            "where UserID='" + Session["UserID"].ToString() + "' and ForDelete=1  ) order by [Name]");
        chkdigerrayon.DataTextField = "Name";
        chkdigerrayon.DataValueField = "RegionsID";
        chkdigerrayon.DataSource = region2;
        chkdigerrayon.DataBind();
    }
    void regionelaveet()
    {
        DataTable region2 = klas.getdatatable("SELECT  RegionsID,UserID,Name=CASE WHEN CityID =  2 THEN Name "+
            "+' '+'rayonu' WHEN CityID =1 THEN Name +' '+N'şəhəri' END "+
            "FROM List_classification_Regions where UserID='" + Session["UserID"].ToString() + "' and ForDelete=1   and  RegionsID  not in " +
            "(select r.RegionsID from FRegions as b inner join List_classification_Regions as r "+
            "on  b.RegionCode=r.RegionsID where b.BusinessTripID='" + Session["BusinessTripID"].ToString()+ "')  order by Name");

        rayonelave.DataTextField = "Name";
        rayonelave.DataValueField = "RegionsID";
        rayonelave.DataSource = region2;
        rayonelave.DataBind();
    }
    void digerregionelaveet()
    {
        DataTable region2 = klas.getdatatable("SELECT  RegionsID,UserID,Name=CASE WHEN CityID =  2 THEN Name "+
            "+' '+'rayonu' WHEN CityID =1 THEN Name +' '+N'şəhəri' END "+
        "FROM List_classification_Regions where  ForDelete=1 and UserID <>'" + Session["UserID"].ToString() + "'  and  RegionsID  not in " +
            "(select r.RegionsID from FRegions as b inner join List_classification_Regions as r "+
            "on  b.RegionCode=r.RegionsID where b.BusinessTripID='" + Session["BusinessTripID"].ToString() + "')  order by Name");

        digerrayonelave.DataTextField = "Name";
        digerrayonelave.DataValueField = "RegionsID";
        digerrayonelave.DataSource = region2;
        digerrayonelave.DataBind();
    }

    void regionredaktechk()
    {
        DataTable region2 = klas.getdatatable("SELECT  RegionsID,UserID,Name=CASE WHEN CityID =  2 THEN Name " +
            "+' '+'rayonu' WHEN CityID =1 THEN Name +' '+N'şəhəri' END " +
            "FROM List_classification_Regions where UserID='" + Session["UserID"].ToString() + "' and ForDelete=1   and  RegionsID  not in " +
            "(select r.RegionsID from FRegions as b inner join List_classification_Regions as r " +
            "on  b.RegionCode=r.RegionsID where b.BusinessTripID='" + Session["BusinessTripID"].ToString() + "')  order by Name");
        rblredakte.DataTextField = "Name";
        rblredakte.DataValueField = "RegionsID";
        rblredakte.DataSource = region2;
        rblredakte.DataBind();
    }
    void digerregionredaktechk()
    {
        DataTable region2 = klas.getdatatable("SELECT  RegionsID,UserID,Name=CASE WHEN CityID =  2 THEN Name " +
            "+' '+'rayonu' WHEN CityID =1 THEN Name +' '+N'şəhəri' END " +
        "FROM List_classification_Regions where  ForDelete=1 and UserID <>'" + Session["UserID"].ToString() + "'  and  RegionsID  not in " +
            "(select r.RegionsID from FRegions as b inner join List_classification_Regions as r " +
            "on  b.RegionCode=r.RegionsID where b.BusinessTripID='" + Session["BusinessTripID"].ToString() + "')  order by Name");
        digerrblredakte.DataTextField = "Name";
        digerrblredakte.DataValueField = "RegionsID";
        digerrblredakte.DataSource = region2;
        digerrblredakte.DataBind();
    }

  
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {

        if (Calendar1.Visible)
        {
            Calendar1.Visible = false;
            lblgelme.Visible = true;

        }
        else
        {
            Calendar1.Visible = true;
            lblgelme.Visible = false;
        }
    }
    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {

        if (Calendar3.Visible)
        {
            Calendar3.Visible = false;
            lblgetme.Visible = true;
        }
        else
        {
            Calendar3.Visible = true;
            lblgetme.Visible = false;
        }


    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {

        if (Calendar2.Visible)
        {
            Calendar2.Visible = false;
            lblcixma.Visible = true;
        }
        else
        {

            Calendar2.Visible = true;
            lblcixma.Visible = false;
        }



    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        lblgelme.Text = Calendar1.SelectedDate.ToString("d");
        Calendar1.Visible = false;
        lblgelme.Visible = true;
    }
    protected void Calendar3_SelectionChanged(object sender, EventArgs e)
    {
        lblgetme.Text = Calendar3.SelectedDate.ToString("d");
       
        Calendar3.Visible = false;
        lblgetme.Visible = true;
    }
    protected void Calendar2_SelectionChanged(object sender, EventArgs e)
    {
        lblcixma.Text = Calendar2.SelectedDate.ToString("d");
        Calendar2.Visible = false;
        lblcixma.Visible = true;
    }
    protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
    {
        //if (lblgetme.Text != "")
        //{
        //    if (e.Day.Date > Convert.ToDateTime(lblgetme.Text))
        //    {
        //        e.Day.IsSelectable = false;
        //    }
        //}

    }
    protected void Calendar3_DayRender(object sender, DayRenderEventArgs e)
    {
        //if (lblgelme.Text != "")
        //{

        //    if (e.Day.Date < Convert.ToDateTime(lblgelme.Text))
        //    {
        //        e.Day.IsSelectable = false;
        //    }
        //}
        //if (lblcixma.Text != "")
        //{
        //    if (e.Day.Date > Convert.ToDateTime(lblcixma.Text))
        //    {
        //        e.Day.IsSelectable = false;
        //    }
        //}
    }
    protected void Calendar2_DayRender(object sender, DayRenderEventArgs e)
    {
        //if (lblgetme.Text != "")
        //{
        //    if (e.Day.Date < Convert.ToDateTime(lblgetme.Text))
        //    {
        //        e.Day.IsSelectable = false;
        //    }
        //}
    }

    protected void btnezamteqvim_Click(object sender, EventArgs e)
    {
        string hecvaxti = klas.getdatacell("SELECT GETDATE()-1 as indikivaxt");
        string izcazeli = klas.getdatacell("SELECT * from Users where status_users=0 and (permit=0)  and userid=" + Session["UserID"].ToString());
        string iwecixmaenboyuk1 = hecvaxti;
        message.Visible = true;
        message.Text = "";
        for (int j = 0; j < chkregion.Items.Count; j++)
        {
            if (chkregion.Items[j].Selected)
            {
                a = 1;
            }
        }
        for (int j = 0; j < chkdigerrayon.Items.Count; j++)
        {
            if (chkdigerrayon.Items[j].Selected)
            {
                a = 1;
            }
        }

        string s1 = "";
        if (lblgelme.Text != "" && lblgetme.Text != "" && lblcixma.Text != "" && a == 1)
        {

            if (chkregion.Items.Count > 0 || chkdigerrayon.Items.Count > 0)
            {
                string gelme = Convert.ToDateTime(lblgelme.Text).ToString("yyyy-MM-dd") + " " + "00:00:00.000";
                string getme = Convert.ToDateTime(lblgetme.Text).ToString("yyyy-MM-dd") + " " + "00:00:00.000";
                string cixma = Convert.ToDateTime(lblcixma.Text).ToString("yyyy-MM-dd") + " " + "00:00:00.000";


                DataRow raygelyoxla = klas.GetDataRow("select RegionCome,BusinessTripID,UserID  from Fbusiness_trip where RegionCome > '" + gelme + "' and RegionCome <'" + cixma + "'  and UserID=" + Session["UserID"].ToString());
                DataRow iwecixyoxla = klas.GetDataRow("select ComingToWork,BusinessTripID,UserID from Fbusiness_trip where ComingToWork > '" + gelme + "' and ComingToWork <'" + cixma + "'  and UserID=" + Session["UserID"].ToString());
                string ortaveziyyet1 = klas.getdatacell("select ComingToWork,BusinessTripID,UserID   from Fbusiness_trip where ComingToWork >= '" + cixma + "'  and UserID='" + Session["UserID"].ToString() + "' order by  ComingToWork ");
                string ortaveziyyet = klas.getdatacell("select RegionCome,BusinessTripID,UserID from Fbusiness_trip where RegionCome <= '" + gelme + "'  and UserID='" + Session["UserID"].ToString() + "' order by  RegionCome desc");
                string sonyoxla = null;
                string gel;
                string iwe;
                if (ortaveziyyet1 != null && ortaveziyyet != null)
                {
                    iwe = Convert.ToDateTime(ortaveziyyet1).ToString("yyyy-MM-dd") + " " + "00:00:00.000";
                    gel = Convert.ToDateTime(ortaveziyyet).ToString("yyyy-MM-dd") + " " + "00:00:00.000";

                    sonyoxla = klas.getdatacell("select RegionCome,ComingToWork,BusinessTripID,UserID  from Fbusiness_trip where RegionCome = '" + gel + "'  and ComingToWork = '" + iwe + "' and UserID=" + Session["UserID"].ToString());
                }




                if (raygelyoxla == null && iwecixyoxla == null && sonyoxla == null && (Convert.ToDateTime(gelme) <= Convert.ToDateTime(getme)) && (Convert.ToDateTime(getme) <= Convert.ToDateTime(cixma)) && (Convert.ToDateTime(iwecixmaenboyuk1) <= Convert.ToDateTime(gelme) || izcazeli!=null))
                {
                    for (int i = 0; i < chkregion.Items.Count; i++)
                    {
                        if (chkregion.Items[i].Selected)
                        {
                            s1 = s1 + chkregion.Items[i].Text + ", ";
                        }
                    }
                    for (int i = 0; i < chkdigerrayon.Items.Count; i++)
                    {
                        if (chkdigerrayon.Items[i].Selected)
                        {
                            s1 = s1 + chkdigerrayon.Items[i].Text + ", ";
                        }
                    }
                    SqlConnection baglanti = klas.baglan();
                    SqlCommand cmd = new SqlCommand("Insert into Fbusiness_trip (RegionID,Regions,RegionCome,GoFromRegion,ComingToWork,UserID) values (@RegionID,@Regions,@RegionCome,@GoFromRegion,@ComingToWork,@UserID)", baglanti);
                    cmd.Parameters.Add("RegionID", Int32.Parse("0"));
                    cmd.Parameters.Add("Regions", s1.Substring(0, s1.Length - 2));
                    cmd.Parameters.Add("RegionCome", Convert.ToDateTime(gelme));
                    cmd.Parameters.Add("GoFromRegion", Convert.ToDateTime(getme));
                    cmd.Parameters.Add("ComingToWork", Convert.ToDateTime(cixma));
                    cmd.Parameters.Add("UserID", Session["UserID"].ToString());
                    cmd.ExecuteNonQuery();
                    message.Visible = true;
                    message.Text = "Məlumat əlavə edildi";
                    message.ForeColor = Color.Green;
                    if (Convert.ToDateTime(iwecixmaenboyuk1) >= Convert.ToDateTime(gelme))
                    {
                        SqlCommand cmd5 = new SqlCommand("Update Users set permit=@permit where UserID=" + Session["UserID"].ToString(), baglanti);
                        cmd5.Parameters.Add("permit", "0");
                        cmd5.ExecuteNonQuery();
                    }



                    a = 0;
                    lblgelme.Text = "";
                    lblgetme.Text = "";
                    lblcixma.Text = "";
                    DataRow dr = klas.GetDataRow("select max(BusinessTripID) as bisnes from Fbusiness_trip ");
                    BusinessTripID = dr["bisnes"].ToString();
                    Session["BusinessTripidmax"] = BusinessTripID;
                    for (int i = 0; i < chkregion.Items.Count; i++)
                    {
                        if (chkregion.Items[i].Selected)
                        {
                            SqlConnection baglanRegion = klas.baglan();
                            SqlCommand cmd1 = new SqlCommand("Insert into Fregions (Name,RegionCode,BusinessTripID,UserID) values(@Name,@RegionCode,@BusinessTripID,@UserID)", baglanRegion);
                            cmd1.Parameters.Add("Name", chkregion.Items[i].Text);
                            cmd1.Parameters.Add("RegionCode", chkregion.Items[i].Value);
                            cmd1.Parameters.Add("BusinessTripID", BusinessTripID.ToString());
                            cmd1.Parameters.Add("UserID", Session["UserID"].ToString());
                            cmd1.ExecuteNonQuery();
                        }
                    }
                    for (int i = 0; i < chkdigerrayon.Items.Count; i++)
                    {
                        if (chkdigerrayon.Items[i].Selected)
                        {
                            SqlConnection baglanRegion = klas.baglan();
                            SqlCommand cmd1 = new SqlCommand("Insert into Fregions (Name,RegionCode,BusinessTripID,UserID) values(@Name,@RegionCode,@BusinessTripID,@UserID)", baglanRegion);
                            cmd1.Parameters.Add("Name", chkdigerrayon.Items[i].Text);
                            cmd1.Parameters.Add("RegionCode", chkdigerrayon.Items[i].Value);
                            cmd1.Parameters.Add("BusinessTripID", BusinessTripID.ToString());
                            cmd1.Parameters.Add("UserID", Session["UserID"].ToString());
                            cmd1.ExecuteNonQuery();
                        }
                    }


                    message.Visible = false;
                    pnlteqvimelave.Visible = false;
                    pnlteqvimelave.Visible = false;
                    pnlredakte.Visible = false;
                    pnlrayontarix.Visible = false;
                    pnlsiyahi.Visible = true;
                    Session[rownumber] = null;

                    datalist1();
            
                    btnezamsiyahi.BackColor = Color.Aquamarine;
                    btnteqvimelave.BackColor = SystemColors.ButtonFace;

                   
                }
                else
                {
                    message.Text = "Tarix düz deyil";
                    message.ForeColor = Color.Red;
                }
            }
        }
        else
        {
            if (lblgelme.Text == "" || lblgetme.Text == "" || lblcixma.Text == "")
            {
                message.Text = "Tarix qeyd olunmalıdır";
                message.ForeColor = Color.Red;
            }
            if (a == 0)
            {
                message.Text = "Rayon, şəhər qeyd olunmalıdır";
                message.ForeColor = Color.Red;
            }

        }
    }
    protected void btnteqvimelave_Click(object sender, EventArgs e)
    {
        pnlsilolmaz.Visible = false;
        lblsilolmaz.Text = "";
        pnlyenideniwle.Visible = false;
        btnyenideniwle.BackColor = SystemColors.ButtonFace;
        pnltesdiqolunmuw.Visible = false;
        btntesdiqolunmuw.BackColor = SystemColors.ButtonFace;
        btnumgeri.Visible = false;
        pnlrayontarix.Visible = false;
        regionchk();
        digerregionchk();
        pnlredakte.Visible = false;
        Calendar1.Visible = false;
        Calendar2.Visible = false;
        Calendar3.Visible = false;
        lblgelme.Text = "";
        lblgetme.Text = "";
        lblcixma.Text = "";



        btnteqvimelave.BackColor = Color.Aquamarine;
        btnezamsiyahi.BackColor = SystemColors.ButtonFace;
        pnlsiyahi.Visible = false;
        message.Visible = false;

        pnlteqvimelave.Visible = true;
        pnlteqvimelave.Visible = true;
       
    }



   
    protected void btnezamsiyahi_Click(object sender, EventArgs e)
    {
        pnlsilolmaz.Visible = false;
        lblsilolmaz.Text = "";
        btnyenideniwle.BackColor = SystemColors.ButtonFace;
        btntesdiqolunmuw.BackColor = SystemColors.ButtonFace;
       // btnumgeri.Visible = true;
        pnlyenideniwle.Visible = false;
        pnltesdiqolunmuw.Visible = false;
        message.Visible = false;
        pnlteqvimelave.Visible = false;
        pnlteqvimelave.Visible = false;
        pnlredakte.Visible = false;
        pnlrayontarix.Visible = false;
        pnlsiyahi.Visible = true;
        Session[rownumber] = null;
      
        datalist1();
 
        btnezamsiyahi.BackColor = Color.Aquamarine;
        btnteqvimelave.BackColor = SystemColors.ButtonFace;
    }

    protected void btnredakte_Click(object sender, EventArgs e)
    {
        lblredaktemsg.Visible = true;
        lblredaktemsg.Text = "";
        if (lblgelmeredakte.Text != "" && lblbitmeredakte.Text != "" && lblisecixma.Text != "" )
        {
 string gelme = lblgelmeredakte.Text + " " + "00:00:00.000";
 string getme = lblbitmeredakte.Text + " " + "00:00:00.000";
 string cixma = lblisecixma.Text + " " + "00:00:00.000";
 string gelme1 = lblrayona.Text + " " + "00:00:00.000";
 string cix=lblcix.Text + " " + "00:00:00.000";


 string hecvaxti = klas.getdatacell("SELECT GETDATE()-1 as indikivaxt");
 string izcazeli = klas.getdatacell("SELECT * from Users where status_users=0 and permit=0 and userid=" + Session["UserID"].ToString());
 string iwecixmaenboyuk1 = hecvaxti;
    

 DataRow raygelyoxla = klas.GetDataRow("select RegionCome,BusinessTripID,UserID  from Fbusiness_trip where RegionCome > '" + gelme1 + "' and RegionCome <'" + cix + "' and BusinessTripID !='" + BusinessTripID+"' and UserID="+ Session["UserID"].ToString());
 DataRow iwecixyoxla = klas.GetDataRow("select ComingToWork,BusinessTripID,UserID from Fbusiness_trip where ComingToWork > '" + gelme1 + "' and ComingToWork <'" + cix + "' and BusinessTripID !='" + BusinessTripID + "' and UserID=" + Session["UserID"].ToString());
 string ortaveziyyet1 = klas.getdatacell("select ComingToWork,BusinessTripID,UserID   from Fbusiness_trip where ComingToWork >= '" + cix + "' and BusinessTripID !='" + BusinessTripID + "' and UserID='" + Session["UserID"].ToString() + "' order by  ComingToWork ");
 string ortaveziyyet = klas.getdatacell("select RegionCome,BusinessTripID,UserID from Fbusiness_trip where RegionCome <= '" + gelme1 + "' and BusinessTripID !='" + BusinessTripID + "' and UserID='" + Session["UserID"].ToString() + "' order by  RegionCome desc");
            string sonyoxla=null; 
            string gel;
            string iwe;
            if (ortaveziyyet1 != null && ortaveziyyet != null)
            {
                iwe = Convert.ToDateTime(ortaveziyyet1).ToString("yyyy-MM-dd") + " " + "00:00:00.000";
                gel = Convert.ToDateTime(ortaveziyyet).ToString("yyyy-MM-dd") + " " + "00:00:00.000";
                sonyoxla = klas.getdatacell("select RegionCome,ComingToWork,BusinessTripID,UserID  from Fbusiness_trip where RegionCome = '" + gel + "'  and ComingToWork = '" + iwe + "' and UserID=" + Session["UserID"].ToString());
            }
            string regionagoremin=null;
            string regionagoremax=null;
            string rayonagor="0";
            regionagoremin = klas.getdatacell("SELECT     MIN(dbo.FRegions.RegionCome) AS minimum, dbo.FRegions.BusinessTripID, dbo.Fbusiness_trip.UserID "+
                "FROM         dbo.FRegions INNER JOIN dbo.Fbusiness_trip ON dbo.FRegions.BusinessTripID = dbo.Fbusiness_trip.BusinessTripID "+
                " WHERE     (dbo.FRegions.BusinessTripID = '" + BusinessTripID + "') and (dbo.Fbusiness_trip.UserID = '" + Session["UserID"].ToString() + "') " +
                "GROUP BY dbo.FRegions.BusinessTripID, dbo.Fbusiness_trip.UserID");

            regionagoremax = klas.getdatacell("SELECT     MAX(dbo.FRegions.GoFromRegion) AS maximum, dbo.FRegions.BusinessTripID, dbo.Fbusiness_trip.UserID "+
                "FROM         dbo.FRegions INNER JOIN "+
                "dbo.Fbusiness_trip ON dbo.FRegions.BusinessTripID = dbo.Fbusiness_trip.BusinessTripID "+
                "WHERE     (dbo.FRegions.BusinessTripID = '" + BusinessTripID + "') AND (dbo.Fbusiness_trip.UserID = '" + Session["UserID"].ToString() + "') " +
                "GROUP BY dbo.FRegions.BusinessTripID, dbo.Fbusiness_trip.UserID");
           
            if (regionagoremin != "" && regionagoremax != "")
            {
                if (Convert.ToDateTime(gelme) <= Convert.ToDateTime(regionagoremin) && Convert.ToDateTime(getme) >= Convert.ToDateTime(regionagoremax))
                {
                    rayonagor = "1";
                }
            }
            else
            { 
                rayonagor = "1";
            }
            if (rayonagor == "1" && Convert.ToDateTime(gelme) <= Convert.ToDateTime(getme) && Convert.ToDateTime(gelme) <= Convert.ToDateTime(getme) && Convert.ToDateTime(getme) <= Convert.ToDateTime(cixma) && raygelyoxla == null && iwecixyoxla == null && sonyoxla == null && (Convert.ToDateTime(iwecixmaenboyuk1) <= Convert.ToDateTime(gelme) || izcazeli == null))
                {
                            SqlConnection baglanti = klas.baglan();
                            SqlCommand cmd = new SqlCommand("Update Fbusiness_trip set RegionCome=@RegionCome,GoFromRegion=@GoFromRegion,ComingToWork=@ComingToWork,UserID=@UserID where BusinessTripID=" + BusinessTripID, baglanti);
                            cmd.Parameters.Add("RegionCome", Convert.ToDateTime(gelme));
                            cmd.Parameters.Add("GoFromRegion", Convert.ToDateTime(getme));
                            cmd.Parameters.Add("ComingToWork", Convert.ToDateTime(cixma));
                            cmd.Parameters.Add("UserID", Session["UserID"].ToString());
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
                            if (Convert.ToDateTime(iwecixmaenboyuk1) >= Convert.ToDateTime(gelme))
                            {
                                SqlCommand cmd5 = new SqlCommand("Update Users set permit=@permit where UserID=" + Session["UserID"].ToString(), baglanti);
                                cmd5.Parameters.Add("permit", "0");
                                cmd5.ExecuteNonQuery();
                            }
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
                lblredaktemsg.Text = "Tarix qeyd olunmalıdır";
                lblredaktemsg.ForeColor = Color.Red;
                datalist1();
            }
        }
    }
    protected void cldgelme_SelectionChanged(object sender, EventArgs e)
    {
        lblgelmeredakte.Text = cldgelme.SelectedDate.ToString("d");
        lblrayona.Text = cldgelme.SelectedDate.ToString("yyyy-MM-dd");

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
        //if (lblbitmeredakte.Text != "")
        //{
        //    if (e.Day.Date > Convert.ToDateTime(lblbitmeredakte.Text))
        //    {
        //        e.Day.IsSelectable = false;
        //    }
        //}
    }
    protected void cldbitme_DayRender(object sender, DayRenderEventArgs e)
    {
        //if (lblgelmeredakte.Text != "")
        //{

        //    if (e.Day.Date < Convert.ToDateTime(lblgelmeredakte.Text))
        //    {
        //        e.Day.IsSelectable = false;
        //    }
        //}
        //if (lblisecixma.Text != "")
        //{
        //    if (e.Day.Date > Convert.ToDateTime(lblisecixma.Text))
        //    {
        //        e.Day.IsSelectable = false;
        //    }
        //}
    }
    protected void cldisecixma_DayRender(object sender, DayRenderEventArgs e)
    {
        //if (lblbitmeredakte.Text != "")
        //{
        //    if (e.Day.Date < Convert.ToDateTime(lblbitmeredakte.Text))
        //    {
        //        e.Day.IsSelectable = false;
        //    }
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
    protected void Button1_Click(object sender, EventArgs e)
    {
        //Response.ClearContent();
        //Response.AppendHeader("content-disposition", "attachment; filename=Employees.xls");
        //Response.ContentType = "application/excel";
        //Response.ContentEncoding = System.Text.Encoding.UTF8;
        //Response.BinaryWrite(System.Text.Encoding.UTF8.GetPreamble());
        //StringWriter stringWritter = new StringWriter();
        //HtmlTextWriter htmlTextWritter = new HtmlTextWriter(stringWritter);
        //DataList2.RenderControl(htmlTextWritter);

        //Response.End();
    }

    protected void dlrayontarix_ItemDataBound(object sender, DataListItemEventArgs e)
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
        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {
            Panel panel3 = e.Item.FindControl("Panel3") as Panel;
            Panel panel6 = e.Item.FindControl("Panel6") as Panel;
            Panel panel7 = e.Item.FindControl("Panel7") as Panel;
            Panel panel1 = e.Item.FindControl("Panel1") as Panel;
            if (panel3 != null && panel6 != null && panel7 != null && panel1 != null && Session["UserID1"] != null)
            {
                panel3.Visible = true;
                panel6.Visible = true;
                panel7.Visible = true;
                panel1.Visible = true;
            }
        }
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
        datalistrayontarix();
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
        datalistrayontarix();
    }
    protected void cldraygelmetrx_SelectionChanged(object sender, EventArgs e)
    {
        datalistrayontarix();
        lblraygetme.Text = cldraygetmetrx.SelectedDate.ToString("d");
        lblraygetme0.Text = cldraygetmetrx.SelectedDate.ToString("yyyy-MM-dd");

        cldraygetmetrx.Visible = false;
        lblraygetme.Visible = true;
    }
    protected void cldraygetmetrx_SelectionChanged(object sender, EventArgs e)
    {
        lblraygelme.Text = cldraygelmetrx.SelectedDate.ToString("d");
        lblraygelme0.Text = cldraygelmetrx.SelectedDate.ToString("yyyy-MM-dd");

        cldraygelmetrx.Visible = false;
        lblraygelme.Visible = true;
        datalistrayontarix();
    }
    protected void btnrayontrx_Click(object sender, EventArgs e)
    {
        DataRow tarixinterval = klas.GetDataRow("select RegionCome,GoFromRegion from Fbusiness_trip where BusinessTripID=" + Session["BusinessTripID"].ToString());
        if (lblraygetme.Text != "" && lblraygelme.Text != "")
        {
            string gelme = Convert.ToDateTime(lblraygetme.Text).ToString("yyyy-MM-dd") + " " + "00:00:00.000";
            string getme = Convert.ToDateTime(lblraygelme.Text).ToString("yyyy-MM-dd") + " " + "00:00:00.000";
            DataRow berabertarixler = klas.GetDataRow("select GoFromRegion,RegionID,BusinessTripID from FRegions where RegionCome = '" + gelme + "' and GoFromRegion ='" + getme + "' and RegionCome <> GoFromRegion and RegionID !='" + RayonID + "' and BusinessTripID=" + Session["BusinessTripID"].ToString());
           
            DataRow raygelyoxla = klas.GetDataRow("select RegionCome,RegionID,BusinessTripID  from FRegions where RegionCome > '" + gelme + "' and RegionCome <'" + getme + "' and RegionID !='" + RayonID + "' and BusinessTripID=" + Session["BusinessTripID"].ToString());
            DataRow iwecixyoxla = klas.GetDataRow("select GoFromRegion,RegionID,BusinessTripID from FRegions where GoFromRegion > '" + gelme + "' and GoFromRegion <'" + getme + "' and RegionID !='" + RayonID + "' and BusinessTripID=" + Session["BusinessTripID"].ToString());
         
            string ebqrayondangelme = klas.getdatacell("Select max(GoFromRegion) as ebqrayonqayitma from FRegions where  BusinessTripID='" + Session["BusinessTripID"].ToString() + "'");
            string ekqrayonagetme = klas.getdatacell("Select min(RegionCome) as ebqrayonqayitma from FRegions where  BusinessTripID='" + Session["BusinessTripID"].ToString() + "'");
            string rayondangelme = klas.getdatacell("Select GoFromRegion  from Fbusiness_trip where  BusinessTripID='" + Session["BusinessTripID"].ToString() + "'");
            string rayonagetme = klas.getdatacell("Select RegionCome  from Fbusiness_trip where  BusinessTripID='" + Session["BusinessTripID"].ToString() + "'");

            string ortaveziyyet1 = klas.getdatacell("select GoFromRegion,RegionID,BusinessTripID   from FRegions where GoFromRegion >= '" + getme + "' and RegionID !='" + RayonID + "' and BusinessTripID='" + Session["BusinessTripID"].ToString() + "' order by  GoFromRegion ");
            string ortaveziyyet = klas.getdatacell("select RegionCome,RegionID,BusinessTripID from FRegions where RegionCome <= '" + gelme + "' and RegionID !='" + RayonID + "' and BusinessTripID='" + Session["BusinessTripID"].ToString() + "' order by  RegionCome desc");
            //string sonyoxla = null;
            //string gel;
            //string iwe;
            //if (ortaveziyyet1 != null && ortaveziyyet != null)
            //{
            //    iwe = Convert.ToDateTime(ortaveziyyet1).ToString("yyyy-MM-dd") + " " + "00:00:00.000";
            //    gel = Convert.ToDateTime(ortaveziyyet).ToString("yyyy-MM-dd") + " " + "00:00:00.000";
            //    sonyoxla = klas.getdatacell("select RegionCome,GoFromRegion,BusinessTripID  from FRegions where RegionCome = '" + gel + "'  and GoFromRegion = '" + iwe + "' ");
            //}

          //DataRow calendar1 = klas.GetDataRow("Select * from FRegions where RegionID=" + RayonID);
          //string  secilenrayonagetme = calendar1["RegionCome"].ToString();
          //string secilenrayondangelme = calendar1["GoFromRegion"].ToString();
        
        
         

         
           if (berabertarixler==null && (Convert.ToDateTime(gelme) <= Convert.ToDateTime(getme)) && Convert.ToDateTime(tarixinterval["RegionCome"].ToString()) <= Convert.ToDateTime(gelme) && Convert.ToDateTime(tarixinterval["GoFromRegion"].ToString()) >= Convert.ToDateTime(getme) && raygelyoxla == null && iwecixyoxla == null)
            {
                SqlConnection baglanti = klas.baglan();
                SqlCommand cmd = new SqlCommand("Update FRegions set RegionCome=@RegionCome,GoFromRegion=@GoFromRegion where RegionID=" + RayonID, baglanti);
                cmd.Parameters.Add("RegionCome", Convert.ToDateTime(gelme));
                cmd.Parameters.Add("GoFromRegion", Convert.ToDateTime(getme));
                cmd.ExecuteNonQuery();
                lbltrxmesage.Text = "Tarix əlavə edildi";
                lbltrxmesage.ForeColor = Color.Green;
                Session[rownumber] = null;
                pnltarixinsert.Visible = false;
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
                lbltrxmesage.Text = "Tarix qeyd olunmalıdır";
                lbltrxmesage.ForeColor = Color.Red;
            }
        }
        datalistrayontarix();
    }


    protected void btnrayondeyiw_Click(object sender, EventArgs e)
    {
        if (rblredakte.SelectedValue != "")
        {


            DataRow fregion1 = klas.GetDataRow("select * from FRegions where BusinessTripID='" + BusinessTripID + "' and RegionCode=" + rblredakte.SelectedValue.ToString());
            if (fregion1 == null)
            {
                string replace;
                DataRow fregion = klas.GetDataRow("select * from FRegions where BusinessTripID='" + BusinessTripID + "' and RegionID=" + Session["RayonID"].ToString());
                DataRow bsregion = klas.GetDataRow("select * from Fbusiness_trip where BusinessTripID=" + Session["BusinessTripID1"].ToString());



                replace = bsregion["Regions"].ToString().Replace(fregion["Name"].ToString(), rblredakte.SelectedItem.ToString());


                SqlConnection baglanti = klas.baglan();
                SqlCommand cmd2 = new SqlCommand("Update FRegions set Name=@Name,RegionCode=@RegionCode where RegionID=" + Session["RayonID"].ToString(), baglanti);
                cmd2.Parameters.Add("Name", rblredakte.SelectedItem.ToString());
                cmd2.Parameters.Add("RegionCode", Convert.ToInt32(rblredakte.SelectedValue));
                cmd2.ExecuteNonQuery();


                SqlConnection baglanti3 = klas.baglan();
                SqlCommand cmd4 = new SqlCommand("Update Fbusiness_trip set Regions=@Regions where BusinessTripID=" + Session["BusinessTripID1"].ToString(), baglanti3);
                cmd4.Parameters.Add("Regions", replace);
                cmd4.ExecuteNonQuery();
                Session[rownumber] = null;
                datalistrayontarix();

                lblerror.Text = "";
                lblerror.Text = "Dəyişdi";
                lblerror.ForeColor = Color.Green;
                pnlradiobuttarixdeyiw.Visible = false;
            }
            else
            {
                lblerror.Text = "Eyni rayon 2 dəfə ola bilməz";
                lblerror.ForeColor = Color.Red;
                datalistrayontarix();

            }
        }
        if (digerrblredakte.SelectedValue != "")
        {


            DataRow fregion1 = klas.GetDataRow("select * from FRegions where BusinessTripID='" + BusinessTripID + "' and RegionCode=" + digerrblredakte.SelectedValue.ToString());
            if (fregion1 == null)
            {
                string replace;
                DataRow fregion = klas.GetDataRow("select * from FRegions where BusinessTripID='" + BusinessTripID + "' and RegionID=" + Session["RayonID"].ToString());
                DataRow bsregion = klas.GetDataRow("select * from Fbusiness_trip where BusinessTripID=" + Session["BusinessTripID1"].ToString());



                replace = bsregion["Regions"].ToString().Replace(fregion["Name"].ToString(), digerrblredakte.SelectedItem.ToString());


                SqlConnection baglanti = klas.baglan();
                SqlCommand cmd2 = new SqlCommand("Update FRegions set Name=@Name,RegionCode=@RegionCode where RegionID=" + Session["RayonID"].ToString(), baglanti);
                cmd2.Parameters.Add("Name", digerrblredakte.SelectedItem.ToString());
                cmd2.Parameters.Add("RegionCode", Convert.ToInt32(digerrblredakte.SelectedValue));
                cmd2.ExecuteNonQuery();


                SqlConnection baglanti3 = klas.baglan();
                SqlCommand cmd4 = new SqlCommand("Update Fbusiness_trip set Regions=@Regions where BusinessTripID=" + Session["BusinessTripID1"].ToString(), baglanti3);
                cmd4.Parameters.Add("Regions", replace);
                cmd4.ExecuteNonQuery();
                Session[rownumber] = null;
                datalistrayontarix();

                lblerror.Text = "";
                lblerror.Text = "Dəyişdi";
                lblerror.ForeColor = Color.Green;
                pnlradiobuttarixdeyiw.Visible = false;
            }
            else
            {
                lblerror.Text = "Eyni rayon 2 dəfə ola bilməz";
                lblerror.ForeColor = Color.Red;
                datalistrayontarix();

            }
        }
    }

    protected void btnrayonelaveet_Click1(object sender, EventArgs e)
    {
       // Response.Write("ela");
        Session[rownumber] = null;
        lblmessag.Text = "";
        pnlradiobuttarixdeyiw.Visible = false;
        datalistrayontarix();
        pnltarixinsert.Visible = false;
        pnlrayonelave.Visible = true;
        pnlteqvimelave.Visible = false;
        regionelaveet();
        digerregionelaveet();
    }
    protected void btnregionelave_Click(object sender, EventArgs e)
    {
        Session[rownumber] = null;
        string s1 = "";
        string topla="";
           
        for (int j = 0; j < rayonelave.Items.Count; j++)
        {
            if (rayonelave.Items[j].Selected)
            {
                a = 1;
            }
        }
        for (int j = 0; j < digerrayonelave.Items.Count; j++)
        {
            if (digerrayonelave.Items[j].Selected)
            {
                a = 1;
            }
        }

        
        for (int i = 0; i < rayonelave.Items.Count; i++)
        {
            if (rayonelave.Items[i].Selected)
            {
                DataRow rayontekrarolmasin = klas.GetDataRow("select * from FRegions where BusinessTripID='" + Session["BusinessTripID"].ToString() + "' and RegionCode=" + rayonelave.Items[i].Value);
                if (rayontekrarolmasin != null)
                {
                    topla = "1";
                    break;
                }
                
            }
        }
        for (int i = 0; i < digerrayonelave.Items.Count; i++)
        {
            if (digerrayonelave.Items[i].Selected)
            {
                DataRow rayontekrarolmasin = klas.GetDataRow("select * from FRegions where BusinessTripID='" + Session["BusinessTripID"].ToString() + "' and RegionCode=" + digerrayonelave.Items[i].Value);
                if (rayontekrarolmasin != null)
                {
                    topla = "1";
                    break;
                }

            }
        }
        //Response.Write(topla);

        if (a == 1 && topla != "1")
        {

            if (rayonelave.Items.Count > 0 || digerrayonelave.Items.Count > 0)
            {
                for (int i = 0; i < rayonelave.Items.Count; i++)
                {
                    if (rayonelave.Items[i].Selected)
                    {
                        s1 = s1 + rayonelave.Items[i].Text + ", ";
                    }
                }
                for (int i = 0; i < digerrayonelave.Items.Count; i++)
                {
                    if (digerrayonelave.Items[i].Selected)
                    {
                        s1 = s1 + digerrayonelave.Items[i].Text + ", ";
                    }
                }
                DataRow regionname = klas.GetDataRow("select * from Fbusiness_trip where BusinessTripID=" + Session["BusinessTripID"].ToString());
                //update olacag
                s1 = s1 + regionname["Regions"].ToString();
                SqlConnection baglanti = klas.baglan();
                SqlCommand cmd2 = new SqlCommand("Update Fbusiness_trip set Regions=@Regions where BusinessTripID=" + Session["BusinessTripID"].ToString(), baglanti);
                cmd2.Parameters.Add("RegionID", Int32.Parse("0"));
                cmd2.Parameters.Add("Regions", s1);
                cmd2.Parameters.Add("UserID", Session["UserID"].ToString());
                cmd2.ExecuteNonQuery();
                a = 0;
                for (int i = 0; i < rayonelave.Items.Count; i++)
                {
                    if (rayonelave.Items[i].Selected)
                    {
                        SqlConnection baglanRegion = klas.baglan();
                        SqlCommand cmd1 = new SqlCommand("Insert into Fregions (Name,RegionCode,BusinessTripID,UserID) values(@Name,@RegionCode,@BusinessTripID,@UserID)", baglanRegion);
                        cmd1.Parameters.Add("Name", rayonelave.Items[i].Text);
                        cmd1.Parameters.Add("RegionCode", rayonelave.Items[i].Value);
                        cmd1.Parameters.Add("BusinessTripID", Session["BusinessTripID"].ToString());
                        cmd1.Parameters.Add("UserID", Session["UserID"].ToString());
                        cmd1.ExecuteNonQuery();
                        datalistrayontarix();
                        pnlrayonelave.Visible = false;
                    }
                }
             
                rayonelave.ClearSelection();

                for (int i = 0; i < digerrayonelave.Items.Count; i++)
                {
                    if (digerrayonelave.Items[i].Selected)
                    {
                        SqlConnection baglanRegion = klas.baglan();
                        SqlCommand cmd1 = new SqlCommand("Insert into Fregions (Name,RegionCode,BusinessTripID) values(@Name,@RegionCode,@BusinessTripID)", baglanRegion);
                        cmd1.Parameters.Add("Name", digerrayonelave.Items[i].Text);
                        cmd1.Parameters.Add("RegionCode", digerrayonelave.Items[i].Value);
                        cmd1.Parameters.Add("BusinessTripID", Session["BusinessTripID"].ToString());
                        cmd1.ExecuteNonQuery();
                        datalistrayontarix();
                        pnlrayonelave.Visible = false;
                    }
                }
                digerrayonelave.ClearSelection();
               
            }
            else
            {
                lblmessag.Text = "Tarix  duz deyil";
                lblmessag.ForeColor = Color.Red;
            }
        }
        else { 
        if(topla == "1")
            lblmessag.Text = "Daxil edilmiş rayon yenidən daxil edilə bilməz";
            lblmessag.ForeColor = Color.Red;
        }
        if (a != 1) {
            lblmessag.Text = "Rayon seçilməyib";
            lblmessag.ForeColor = Color.Red;
        }
    }


    protected void btnumgeri_Click(object sender, EventArgs e)
    {
        
        pnlyenideniwle.Visible = false;
        btnyenideniwle.BackColor = SystemColors.ButtonFace;
        if (islem == "duzelis") {
            pnlredakte.Visible = false;

        }
      
     
        if (islem == "rayontarix") {
       
            if (!pnlrayonelave.Visible)
            {
                message.Visible = false;
                pnlteqvimelave.Visible = false;
                pnlteqvimelave.Visible = false;
                pnlredakte.Visible = false;
                pnlrayontarix.Visible = false;
               
                pnlsiyahi.Visible = true;
            }
           
            Session[rownumber] = null;

            datalist1();
            //datalist2();
            btnezamsiyahi.BackColor = Color.Aquamarine;
            btnteqvimelave.BackColor = SystemColors.ButtonFace;

           
        }
        if (pnlrayonelave.Visible || pnlradiobuttarixdeyiw.Visible || pnltarixinsert.Visible)
        {
            pnlrayonelave.Visible = false;
            pnlradiobuttarixdeyiw.Visible = false;
            pnltarixinsert.Visible = false;
        }
        else {
            message.Visible = false;
            pnlteqvimelave.Visible = false;
            pnlteqvimelave.Visible = false;
            pnlredakte.Visible = false;
            pnlrayontarix.Visible = false;
            pnlsiyahi.Visible = true;
            Session[rownumber] = null;
            datalist1();
            //datalist2();
            btnezamsiyahi.BackColor = Color.Aquamarine;
            btnteqvimelave.BackColor = SystemColors.ButtonFace;
        }
        if (!pnlredakte.Visible)
        {
            btnumgeri.Visible = false;
        }
        if (dlrayontarix.Visible)
        {
            btnumgeri.Visible = true;
        }
    }
    protected void btntesdiqolunmuw_Click(object sender, EventArgs e)
    {
        pnlsilolmaz.Visible = false;
        lblsilolmaz.Text = "";
        pnlyenideniwle.Visible = false;
        btnyenideniwle.BackColor = SystemColors.ButtonFace;
        btnumumi.BackColor = SystemColors.ButtonFace;
        btnrayuzre.BackColor = SystemColors.ButtonFace;
        datalist3();
        pnl1.Visible = false;
        pnl2.Visible = false;
        pnltesdiqolunmuw.Visible = true;
        pnlsiyahi.Visible = false;
        pnlteqvimelave.Visible = false;
        pnlredakte.Visible = false;
        pnlrayontarix.Visible = false;


        btnumgeri.Visible = false;
        message.Visible = false;
        pnlteqvimelave.Visible = false;
        Session[rownumber] = null;

        datalist1();
        //datalist2();
        
        btntesdiqolunmuw.BackColor = Color.Aquamarine;
        btnteqvimelave.BackColor = SystemColors.ButtonFace;
        btnezamsiyahi.BackColor = SystemColors.ButtonFace;
    }
    protected void btnumumi_Click(object sender, EventArgs e)
    {
        pnl1.Visible = true;
        pnl2.Visible = false;
        btnumumi.BackColor = Color.GreenYellow;
        btnrayuzre.BackColor = SystemColors.ButtonFace;
    }
    protected void btnrayuzre_Click(object sender, EventArgs e)
    {
        pnl1.Visible = false;
        pnl2.Visible = true;
        datalistrayontarix12();
        btnrayuzre.BackColor = Color.GreenYellow;
        btnumumi.BackColor = SystemColors.ButtonFace;
    }
    protected void btnyenideniwle_Click(object sender, EventArgs e)
    {
        pnlsilolmaz.Visible = false;
        lblsilolmaz.Text = "";
        pnlyenideniwle.Visible = true;
        btnyenideniwle.BackColor = Color.Aquamarine;
        btntesdiqolunmuw.BackColor = SystemColors.ButtonFace;
        btnteqvimelave.BackColor = SystemColors.ButtonFace;
        btnezamsiyahi.BackColor = SystemColors.ButtonFace;
        dlyenideniwle();
        pnl1.Visible = false;
        pnl2.Visible = false;
        pnltesdiqolunmuw.Visible = false;
        pnlsiyahi.Visible = false;
        pnlteqvimelave.Visible = false;
        pnlredakte.Visible = false;
        pnlrayontarix.Visible = false;
        btnumgeri.Visible = false;
        message.Visible = false;
        pnlteqvimelave.Visible = false;
    }
    void dlyenideniwle()
    {
        string s = @"SELECT    dbo.FRegions.FileName,dbo.FRegions.DateApproval_ze,dbo.FRegions.RegionCode, dbo.FRegions.RegionID, dbo.FRegions.Name, dbo.FRegions.RegionCome, dbo.FRegions.GoFromRegion, 
                      dbo.FRegions.BusinessTripID, dbo.Users.Name + ' ' + dbo.Users.Sname AS nameuser, dbo.Users.UserID, dbo.FRegions.Approval
FROM         dbo.FRegions INNER JOIN
                      dbo.Fbusiness_trip ON dbo.FRegions.BusinessTripID = dbo.Fbusiness_trip.BusinessTripID INNER JOIN
                      dbo.Users ON dbo.Fbusiness_trip.UserID = dbo.Users.UserID
WHERE    (dbo.FRegions.Approval = 3) and dbo.Users.UserID = '" + Session["UserID"].ToString() + "' ORDER BY nameuser, dbo.FRegions.RegionCome DESC";
        DataTable dtGruplar = klas.getdatatable(s);
        dtyenideniwle.DataSource = dtGruplar;
        dtyenideniwle.DataBind();

        //if (dtGruplar.Rows.Count > 0)
        //{
        //    dtyenideniwle.Visible = true;
    
        //}
        //else
        //{
        //    dtyenideniwle.Visible = false;
          
        //}
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


    protected void rblredakte_SelectedIndexChanged(object sender, EventArgs e)
    {

        digerrblredakte.ClearSelection();
       
        datalistrayontarix();
    }
    protected void digerrblredakte_SelectedIndexChanged(object sender, EventArgs e)
    {
     
        rblredakte.ClearSelection();
        datalistrayontarix();
    }
}