using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class kurator_view_print_plan : System.Web.UI.Page
{
    Class2 klas = new Class2(); string RegionCode; string RayonID; string UserID; string islem1; string BusinessTripID;
    protected void Page_Load(object sender, EventArgs e)
    {
        Calendar1.SelectedDates.Clear();
        Page.Response.Cache.SetCacheability(HttpCacheability.NoCache);
        //if (Session["UserID2"]!=null)
        //    Response.Write("UserID2=" + Session["UserID2"].ToString());
        //if (Session["UserID1"] != null)
        //    Response.Write("UserID1=" + Session["UserID1"].ToString());
        //if (Session["UserID"] != null)
        //    Response.Write("UserID=" + Session["UserID"].ToString());
          try
        {
            islem1 = Request.QueryString["islem1"];
            RegionCode = Request.QueryString["RegionCode"];
            RayonID = Request.QueryString["RayonID"];
            UserID = Request.QueryString["UserID"];
            BusinessTripID = Request.QueryString["BusinessTripID"];
            Session["BusinessTripID"] = BusinessTripID;
            if (UserID != null)
                Session["UserID"] = UserID;
        }
        catch (Exception)
        { }
          DataRow approval = klas.GetDataRow("select * from FRegions where RegionID=" + RayonID);
          if (approval["Approval"].ToString() == "2")
          {
              lbltesdiqra.Text = "Ezamiyyə planının təsdiq edilməsi təklif olunur";
          }
          if (approval["Approval"].ToString() == "3")
          {
              lbltesdiqra.Text = "Planın yenidən işlənməsi təklif olunur";
          }
        
          if (Session["UserID1"] != null && Session["UserID2"] == null)
              {
                  pnlzynltarix.Visible = true;
                  fugonder.Visible = true;
               
                  lblgonderildi.Visible = true;
                  btntesdiqkur.Visible = false;
                  //btngeri.Visible = false;
                  lbltesdiqolundu.Visible = false;
              }else
              if (Session["UserID"] != null)
              {
                  DataRow drgoryoxla = klas.GetDataRow("SELECT dbo.Users.UserID, dbo.Fbusiness_trip.BusinessTripID, dbo.FRegions.RegionCode, dbo.FRegions.RegionID " +
                      "FROM dbo.Users INNER JOIN " +
                      "dbo.Fbusiness_trip ON dbo.Users.UserID = dbo.Fbusiness_trip.UserID INNER JOIN " +
                      "dbo.FRegions ON dbo.Fbusiness_trip.BusinessTripID = dbo.FRegions.BusinessTripID " +
    "WHERE (dbo.Fbusiness_trip.BusinessTripID = " + BusinessTripID + ") AND (dbo.FRegions.RegionCode = " +
 RegionCode + ") AND (dbo.FRegions.RegionID = " + RayonID + ") AND (dbo.Users.UserID = " + Session["UserID"].ToString() + ")");
                  if (drgoryoxla == null)
                  {
                      Response.Redirect("~/Default.aspx");
                      //Response.Redirect("~/adminpanel/admingiris.aspx");
                  }
                  btntesdiqkur.Visible = true;
                  btngeri.Visible = true;
                  pnlkuratortesdiq.Visible = true;
                  pnlzynltarix.Visible = false;
                  if (approval["Approval"].ToString() != "0")
                  {
                      btntesdiqkur.Enabled = false;
                    
                      lbltesdiqolundu.Text = "Təsdiq üçün təqdim olunub";
                      lbltesdiqolundu.Visible = true;
                      lbltesdiqolundu.ForeColor = Color.Green;
                      if (approval["Approval"].ToString() == "3")
                      {
                          btntesdiqkur.Enabled = true;
                          pnlkuratortesdiq.Visible = true;
                          lbltesdiqolundu.Visible = false;
                      }
                      if (approval["Approval"].ToString() == "4")
                      {
                              lbltesdiqra.Text = "";
                              lbltarix2.Text = ""; 
                          lbltesdiqolundu.Text = "";
                          lbltesdiqolundu.Visible = true;
                          lbltesdiqolundu.ForeColor = Color.Green;
                      }
                  }
              }


          
        DataRow drtesdiqtarix = klas.GetDataRow("select * from FRegions where RegionID=" + RayonID);
        carivaxt.Text = Class2.sozukes(drtesdiqtarix["DateApproval_ze"].ToString());
        lbltrx1.Text = Class2.sozukes(drtesdiqtarix["DateApproval_oz"].ToString());
        lbltarix2.Text = Class2.sozukes(drtesdiqtarix["DateApproval_ra"].ToString());


DataTable dtmeqsed = klas.getdatatable(@"Select NoteText,ConnID,PurposeID,Purpose +'.' as Purpose,Future_work,Expected_results,
RegionID,case when sort Is null then 100000 else sort  end  as sort
from FPurposeOfTrip left join List_classifications on ClassifID=PurposeID 
where RegionID='" + RayonID + "' order by sort");
rpmeqsed.DataSource = klas.tekrarlama("Purpose", "Sn", dtmeqsed);
        rpmeqsed.DataBind();

        if (rpmeqsed.Items.Count == 0)
        {
            rpmeqsed.Visible = false;
            Label3.Visible = false;
        }



DataTable iwtirakineztutlan = klas.getdatatable(@"Select ConnID,ActionsID,Actions +'.' as Actions,IssuesID,Issues,
results,RegionID,case when b.sort Is null then 100000 else b.sort  end  as sort1,
case when k.sort Is null then 100000 else k.sort  end  as sort2 
from FIssues_of_results left join List_classifications as b on b.ClassifID=ActionsID 
left join List_classifications as k on k.ClassifID=IssuesID where RegionID='" + RayonID + "' order by sort1,sort2");
        rpiwtirakineztutlan.DataSource = klas.tekrarlama("Actions", "Sn", iwtirakineztutlan);
        rpiwtirakineztutlan.DataBind();

        if (rpiwtirakineztutlan.Items.Count == 0)
        {
            rpiwtirakineztutlan.Visible = false;
            Label4.Visible = false;
        }




DataTable dtneztutlmuwgoruw = klas.getdatatable(@"SELECT Name+ ' '+ SurName  +', '+ Living_point +', '+ Adres +'.' as namelivinadres,
ConnID,Other,Living_pointId,Name,Adres,Living_point,PurposeID,Purpose,Appeal_raised_issue,Expected_results,RegionID
,case when sort Is null then 100000 else sort  end  as sort from 
FIndividual_meetings_citizens left join List_classifications on ClassifID=PurposeID 
WHERE RegionID = '" + RayonID + "' order by namelivinadres,sort");
        rpnezerdetutulmuwgoruw.DataSource = klas.tekrarlama("namelivinadres", "Sn", dtneztutlmuwgoruw);
        rpnezerdetutulmuwgoruw.DataBind();

        if (rpnezerdetutulmuwgoruw.Items.Count == 0)
        {
            rpnezerdetutulmuwgoruw.Visible = false;
            Label1.Visible = false;
        }


DataTable dtferdisoh = klas.getdatatable(@"Select ConnID,Executive_bodyID,Executive_body,PositionsID,Positions +' '+ Name +' '+ SName +'.' as namesnameposi,
Purpose,PurposeID,RegionID,case when b.sort Is null then 100000 else b.sort  end  as sort1,
case when k.sort Is null then 100000 else k.sort  end  as sort2 
from FDesigned_staff left join List_classifications as b on b.ClassifID=Executive_bodyID 
left join List_classifications as k on k.ClassifID=PositionsID where RegionID='" + RayonID + "' order by namesnameposi,sort1,sort2");
        rpferdisohbetnezkadr.DataSource = klas.tekrarlama("namesnameposi", "Sn", dtferdisoh);
        rpferdisohbetnezkadr.DataBind();

        if (rpferdisohbetnezkadr.Items.Count == 0)
        {
            Label5.Visible = false;
            rpferdisohbetnezkadr.Visible = false;
        }


        DataTable dtolacagiihb = klas.getdatatable(@"Select ConnID,DelegateID,Delegate,Purpose,PurposeID,
Reason_justifying,Results,RegionID,case when sort Is null then 100000 else sort  end  as sort 
from FDelegate_IHB left join List_classifications on ClassifID=PurposeID 
where RegionID='" + RayonID + "' order by Delegate,sort");
        rpIHBnumayende1.DataSource = klas.vergul("Delegate", "Sn", dtolacagiihb);
        rpIHBnumayende1.DataBind();
        if (rpIHBnumayende1.Items.Count == 0)
        {
            Label6.Visible = false;
            rpIHBnumayende1.Visible = false;
        }


DataTable dtolacagiyawayiwmen = klas.getdatatable(@"Select ConnID,LivingID,Living,Purpose,PurposeID,
Reason_justifying,Results,RegionID,case when sort Is null then 100000 else sort  end  as sort 
from FLiving_point left join List_classifications on ClassifID=PurposeID 
where RegionID='" + RayonID + "' order by Living,sort");
rpolacagiyawayiwmen.DataSource = klas.vergul("Living", "Sn", dtolacagiyawayiwmen);
        rpolacagiyawayiwmen.DataBind();
        if (rpolacagiyawayiwmen.Items.Count == 0)
        {
            Label7.Visible = false;
            rpolacagiyawayiwmen.Visible = false;
        }


        if (Session["UserID"] == null) {
            //Response.Redirect("~/adminpanel/admingiris.aspx");
            Response.Redirect("~/Default.aspx");
        }
        DataRow dradsoyad = klas.GetDataRow("select UserID, CASE WHEN SUBSTRING(rtrim(Sname), len(rtrim(Sname)) - 2, 3) = 'yev' THEN Name + ' ' + Sname + 'in' WHEN SUBSTRING(rtrim(Sname), len(rtrim(Sname)) - 1, 3)  = 'ov' THEN Name + ' ' + Sname + 'un' WHEN SUBSTRING(rtrim(Sname), len(rtrim(Sname)) - 2, 3)  = 'ova' THEN Name + ' ' + Sname + N'nın' END as Name from Users where UserID="+Session["UserID"].ToString());
        DataRow drrayon = klas.GetDataRow("select RegionsID,CASE WHEN CityID = 2 THEN Name + ' ' + 'rayonunda' WHEN CityID = 1 THEN Name + ' ' + N'şəhərində' END as Rayon from List_classification_Regions where ForDelete=1 and RegionsID=" + RegionCode);
        
        if (dradsoyad != null && drrayon != null)
        {
            lbladsoyad.Text = dradsoyad["Name"].ToString();
            lblrayon.Text = drrayon["Rayon"].ToString();
        }
        DataRow bawlamatrx = klas.GetDataRow(@"select * from FRegions where RegionID=" + RayonID);
        DataRow iwecixma = klas.GetDataRow(@"select * from Fbusiness_trip b inner join FRegions r on
 b.BusinessTripID=r.BusinessTripID where r.RegionID=" + RayonID);

        if (iwecixma != null)
        {
            lbliwecixma.Text = Class2.sozukes(iwecixma["ComingToWork"].ToString());
        }
        else {
            lbliwecixma.Visible = false;
        }

        if (bawlamatrx != null) {
            lblezambawlama.Text =Class2.sozukes1( bawlamatrx["RegionCome"].ToString())+" - ";
            lblbitme.Text = Class2.sozukes(bawlamatrx["GoFromRegion"].ToString());
           
            if (bawlamatrx["RegionCome"].ToString() == bawlamatrx["GoFromRegion"].ToString()) {
                lblezambawlama.Visible = false;
            }
        }
        DataRow user = klas.GetDataRow("select Name +' '+ Sname as Name from Users where UserID="+Session["UserID"].ToString());
        if (user != null)
        {
           lbluser.Text=user["Name"].ToString();
        }
        if (approval["Approval"].ToString() == "4")
        {
            lbltesdiqra.Text = "";
            lbltarix2.Text = "";
        }
    }
    protected void btnword_Click(object sender, EventArgs e)
    {
        pnltsdq.Visible = false;
        pnlzynltarix.Visible = false;
        btngeri.Visible = false;
        lbltesdiqolundu.Visible = false;
        lblgonderildi.Visible = false;
        btnword.Visible = false;

        Response.ClearContent();
        Response.AppendHeader("content-disposition", "attachment; filename=" + lbluser.Text + " " + lblrayon.Text + ".doc");
        Response.ContentType = "application/excel";
        Response.ContentEncoding = System.Text.Encoding.UTF8;
        Response.BinaryWrite(System.Text.Encoding.UTF8.GetPreamble());
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        StringWriter stringWritter = new StringWriter();
        HtmlTextWriter htmlTextWritter = new HtmlTextWriter(stringWritter);
        pnlhtml.RenderControl(htmlTextWritter);
        Response.Write(stringWritter.ToString());
        Response.End();

        btngeri.Visible = true;
        lbltesdiqolundu.Visible = true;
        pnlzynltarix.Visible = true;
        pnltsdq.Visible = true;
        lblgonderildi.Visible = true;
        btnword.Visible = true;
    }
    public override void VerifyRenderingInServerForm(Control control)
    {

    }
    protected void btngeri_Click(object sender, EventArgs e)
    {

        if (Session["UserID2"] != null) {
            Response.Redirect("Ezamiyyenintesviri.aspx?islem1=" + islem1 + "&islem=rayontarix&BusinessTripID=" + Session["BusinessTripID"].ToString());
        }
        else if (Session["UserID1"] != null)
        {
            if (islem1 != "plantehlil")
            {
                Response.Redirect("~/adminpanel/Yeniezamiyye.aspx?islem1=" + islem1 + "&islem=geri");
            }
            else {
                Response.Redirect("~/adminpanel/Ezmeqsedplantehlil.aspx?islem=rayon0");
            }
               
            
        }
        else if (Session["UserID"] != null)
        {
            Response.Redirect("Ezamiyyenintesviri.aspx?islem1=" + islem1 + "&islem=rayontarix&BusinessTripID=" + Session["BusinessTripID"].ToString());
        }
      
    }
    protected void btntesdiqkur_Click(object sender, EventArgs e)
    {

        if ((lblezambawlama.Text != " - " && lblbitme.Text != "" && rpmeqsed.Items.Count > 0 && rpolacagiyawayiwmen.Items.Count > 0) || (lblezambawlama.Text != " - " && lblbitme.Text != "" && rpmeqsed.Items.Count > 0 && (RegionCode == "79" || RegionCode == "76" || RegionCode == "72" || RegionCode == "80" || RegionCode == "78" || RegionCode == "77" || RegionCode == "73" || RegionCode == "81")))
        {
            string hecvaxti = klas.getdatacell("SELECT GETDATE() as indikivaxt");
            string hecvaxti1 = klas.tarixkesdatetime(hecvaxti);
            lbltrx1.Text = hecvaxti1;
            string tesdiqoz = lbltrx1.Text + " " + "00:00:00.000";
            SqlConnection baglanti = klas.baglan();
            SqlCommand cmd = new SqlCommand("Update FRegions Set Approval=@Approval,DateApproval_oz=@DateApproval_oz Where RegionID=" + RayonID, baglanti);
            cmd.Parameters.Add("Approval", 4);
            cmd.Parameters.Add("DateApproval_oz", Convert.ToDateTime(tesdiqoz));
            cmd.ExecuteNonQuery();
            btntesdiqkur.Enabled = false;
            lbltesdiqolundu.Visible = true;
            lbltesdiqolundu.Text = "Təsdiq üçün təqdim olundu";
            lbltesdiqolundu.ForeColor = Color.Green;
            lbltesdiqra.Text = "";
            lbltarix2.Text = "";
        }
        else {
            lbltesdiqolundu.Visible = true;
            lbltesdiqolundu.Text = "Məlumat tam deyil";
            lbltesdiqolundu.ForeColor = Color.Red;
        }
    }
    protected void btnezamtesdiq_Click(object sender, EventArgs e)
    {

       string yoxlaa1 = ""; string hecvaxti; string hecvaxti1;

        if (txtra.Text == "")
        {
            hecvaxti = klas.getdatacell("SELECT GETDATE() as indikivaxt");
            hecvaxti1 = klas.tarixkesdatetime(hecvaxti);
            yoxlaa1 = "1";
        }
        else
        {

            string tesdiqku = ""; string tesdiqra1 = "";

            if (lbltrx1.Text != "")
            {
                tesdiqku = Convert.ToDateTime(lbltrx1.Text).ToString("yyyy-MM-dd");
                tesdiqra1 = Convert.ToDateTime(txtra.Text).ToString("yyyy-MM-dd");


                if (tesdiqku != "" && tesdiqra1 != "")
                {
                    if (Convert.ToDateTime(tesdiqku) <= Convert.ToDateTime(tesdiqra1))
                    {
                        yoxlaa1 = "1";
                        hecvaxti1 = klas.tarixkesdatetime(txtra.Text);
                    }
                    else
                    {
                        yoxlaa1 = "0";
                        hecvaxti1 = "";
                    }
                }
                else
                {
                    yoxlaa1 = "0";
                    hecvaxti1 = "";
                }
            }
            else
            {

                yoxlaa1 = "0";
                hecvaxti1 = "";
            }
        }
        if (txtra.Text != "" && lbltrx1.Text == "")
        {
            yoxlaa1 = "1";
            hecvaxti1 = klas.tarixkesdatetime(txtra.Text);
        }
        
        
        
        
        string draproval = klas.getdatacell("select Approval from FRegions where RegionID=" + RayonID);
        if (draproval != "4" && yoxlaa1=="1")
        {
 
          
            lbltarix2.Text = hecvaxti1;
            string tesdiqra = lbltarix2.Text + " " + "00:00:00.000";
            lbltesdiqra.Text = "Ezamiyyə planının təsdiq edilməsi təklif olunur";
            SqlConnection baglanti = klas.baglan();
            SqlCommand cmd = new SqlCommand("Update FRegions Set Approval=@Approval,DateApproval_ra=@DateApproval_ra Where RegionID=" + RayonID, baglanti);
            cmd.Parameters.Add("DateApproval_ra", Convert.ToDateTime(tesdiqra));
            cmd.Parameters.Add("Approval", 2);
            cmd.ExecuteNonQuery();
            lblgonderildi.Text = "Təsdiq edilməsi təklif olunur";
            lblgonderildi.ForeColor = Color.Green;
        }
        else
        {
            lblgonderildi.Text = "Artıq təsdiq olunub";
            lblgonderildi.ForeColor = Color.Red;
            if (yoxlaa1 == "0")
            {
                lblgonderildi.Text = "Tarix düz deyil";
                lblgonderildi.ForeColor = Color.Red;
            }
        }
       
    }
    protected void btnyeniden_Click(object sender, EventArgs e)
    {
        SqlConnection baglanti = klas.baglan();
        string fileadi = "";
        string uzanti = Path.GetExtension(fugonder.PostedFile.FileName);
        if ((fugonder.HasFile && uzanti == ".doc") || (fugonder.HasFile && uzanti == ".docx"))
        {
            string folder = Server.MapPath("~/iradlar/" + lbluser.Text + "");
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
            string filename = Path.GetFileNameWithoutExtension(fugonder.FileName);
            // string filename = Path.GetFileName(fugonder.FileName); uzati ile birlikde
            fileadi = filename + RayonID + uzanti;
            fugonder.SaveAs(Server.MapPath("~/iradlar/" + lbluser.Text + "/") + fileadi);

         
        }

        string hecvaxti = klas.getdatacell("SELECT GETDATE() as indikivaxt");
        string hecvaxti1 = klas.tarixkesdatetime(hecvaxti);

        lbltarix2.Text = hecvaxti1;
        string tesdiqra = lbltarix2.Text + " " + "00:00:00.000";
        lbltesdiqra.Text = "Planın yenidən işlənməsi təklif olunur";

        SqlCommand cmd = new SqlCommand("Update FRegions Set FileName=@FileName,Approval=@Approval,DateApproval_ra=@DateApproval_ra,DateApproval_ze=null,Arxiv=0 Where RegionID=" + RayonID, baglanti);
        cmd.Parameters.Add("DateApproval_ra", Convert.ToDateTime(tesdiqra));
        cmd.Parameters.Add("Approval", 3);
        cmd.Parameters.Add("FileName", fileadi);
        cmd.ExecuteNonQuery();


        DataRow drtesdiqtarix = klas.GetDataRow("select * from FRegions where RegionID=" + RayonID);
        carivaxt.Text = Class2.sozukes(drtesdiqtarix["DateApproval_ze"].ToString());

        lblgonderildi.Text = "Məlumat göndərildi";
        lblgonderildi.ForeColor = Color.Green;
    }
    protected void btnzynltarix_Click(object sender, EventArgs e)
    {
        string tesdiqra = ""; string tesdiqze = ""; string tesdiqrambaza = "";
        //tesdiqrambaza = klas.getdatacell(@"select DateApproval_ra from FRegions where RegionID=" + RayonID);
        tesdiqrambaza = klas.getdatacell(@"select DateApproval_oz from FRegions where RegionID=" + RayonID);
        if (tesdiqrambaza != "" && txtzynltarix.Text != "")
        {
            tesdiqra = Convert.ToDateTime(tesdiqrambaza).ToString("yyyy-MM-dd");
            tesdiqze = Convert.ToDateTime(txtzynltarix.Text).ToString("yyyy-MM-dd");

            string yoxlaa = "";
            if (tesdiqra != "" && tesdiqze != "")
            {
                if (Convert.ToDateTime(tesdiqra) <= Convert.ToDateTime(tesdiqze))
                {
                    yoxlaa = "1";
                }
            }

            string draproval = klas.getdatacell("select Approval from FRegions where RegionID=" + RayonID);
            if ((draproval == "2" || draproval == "4") && (yoxlaa == "1"))
            {
                string replace = txtzynltarix.Text.Replace("/", ".");
                carivaxt.Text = replace;
                string mmm = carivaxt.Text + " " + "00:00:00.000";
                SqlConnection baglanti = klas.baglan();
                SqlCommand cmd = new SqlCommand("Update FRegions Set Approval=@Approval,DateApproval_ze=@DateApproval_ze Where RegionID=" + RayonID, baglanti);
                cmd.Parameters.Add("Approval", 4);
                cmd.Parameters.Add("DateApproval_ze", Convert.ToDateTime(mmm));
                cmd.ExecuteNonQuery();
                lblgonderildi.Text = "Ezamiyyə planı təsdiq edildi";
                lblgonderildi.ForeColor = Color.Green;
                lbltesdiqra.Text = "";
                lbltarix2.Text = "";
            }
            else
            {
                lblgonderildi.Text = "Təsdiq edilməyib";
                lblgonderildi.ForeColor = Color.Red;
                if (yoxlaa != "1")
                {
                    lblgonderildi.Text = "Tarix düz deyil";
                    lblgonderildi.ForeColor = Color.Red;
                }
            }
        }
        else {
            lblgonderildi.Text = "Tarix qeyd edilməyib";
            lblgonderildi.ForeColor = Color.Red;
            if (tesdiqrambaza == "")
            {
                lblgonderildi.Text = "Ezamiyyə planı təsdiq olunmayıb";
                lblgonderildi.ForeColor = Color.Red;
            }
        }

    }


    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        if (Calendar1.Visible)
        {
            Calendar1.Visible = false;
        }
        else
        {
            Calendar1.Visible = true;
        }
    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        txtzynltarix.Text = Calendar1.SelectedDate.ToString("d");
        Calendar1.Visible = false;
        txtzynltarix.Visible = true;
    }
    protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
    {

    }
    protected void imgcald_Click(object sender, ImageClickEventArgs e)
    {
        if (cald.Visible)
        {
            cald.Visible = false;
        }
        else
        {
            cald.Visible = true;
        }
    }
    protected void cald_SelectionChanged(object sender, EventArgs e)
    {
        txtra.Text = cald.SelectedDate.ToString("d");
        cald.Visible = false;
        txtra.Visible = true;
    }
    protected void ImageButton1_Click1(object sender, ImageClickEventArgs e)
    {

        if (caldkur.Visible)
        {
            caldkur.Visible = false;
        }
        else
        {
            caldkur.Visible = true;
        }
    }
    protected void caldkur_SelectionChanged(object sender, EventArgs e)
    {
        txtkur.Text = caldkur.SelectedDate.ToString("d");
        caldkur.Visible = false;
        txtkur.Visible = true;
    }
    protected void btnkurtarix_Click(object sender, EventArgs e)
    {
        string yoxlaa1 = ""; string hecvaxti1 = ""; string tesdiqrambaza = "";
        tesdiqrambaza = klas.getdatacell(@"select DateApproval_ze from FRegions where RegionID=" + RayonID);
        if (txtkur.Text != "" && tesdiqrambaza == "")
        {
            yoxlaa1 = "1";
            hecvaxti1 = klas.tarixkesdatetime(txtkur.Text);
        }
        else if (txtkur.Text != "" && tesdiqrambaza != "")
        {
            string tesdiqkura = ""; string tesdiqram = "";
            tesdiqkura = Convert.ToDateTime(txtkur.Text).ToString("yyyy-MM-dd");
            tesdiqram = Convert.ToDateTime(tesdiqrambaza).ToString("yyyy-MM-dd");


            if (tesdiqkura != "" && tesdiqram != "")
            {
                if (Convert.ToDateTime(tesdiqkura) <= Convert.ToDateTime(tesdiqram))
                {
                    yoxlaa1 = "1";
                    hecvaxti1 = klas.tarixkesdatetime(txtkur.Text);
                }
                else
                {
                    yoxlaa1 = "0";
                    hecvaxti1 = "";
                }
            }

        }



        //  string draproval = klas.getdatacell("select AssortinID from business_trip where BusinessTripID=" + BusinesTripId);
        string draproval = klas.getdatacell("select Approval from FRegions where RegionID=" + RayonID);
        //     if (draproval != "4" && yoxlaa1 == "1")
        //{

        if (yoxlaa1 == "1")
        {

            lbltrx1.Text = hecvaxti1;
            string tesdiqra = lbltrx1.Text + " " + "00:00:00.000";
            SqlConnection baglanti = klas.baglan();
            SqlCommand cmd = new SqlCommand("Update FRegions Set DateApproval_oz=@DateApproval_oz Where RegionID=" + RayonID, baglanti);
            cmd.Parameters.Add("DateApproval_oz", Convert.ToDateTime(tesdiqra));
            cmd.ExecuteNonQuery();
            lblgonderildi.Text = "Təqdim olunma tarixi dəyişdirildi";
            lblgonderildi.ForeColor = Color.Green;
        }
        else
        {
            lblgonderildi.Text = "Tarix qeyd olunmayıb";
            lblgonderildi.ForeColor = Color.Red;
            if (draproval == "4")
            {
                lblgonderildi.Text = "Artıq təsdiq olunub";
                lblgonderildi.ForeColor = Color.Red;
            }
            if (yoxlaa1 == "0")
            {
                lblgonderildi.Text = "Tarix düz deyil";
                lblgonderildi.ForeColor = Color.Red;
            }
        }
    }
}