using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
public partial class kurator_et_baxilmish_arash_mesele1 : System.Web.UI.Page
{
     public static SqlConnection SqlConn { get { return new SqlConnection(Config.ConvertString(System.Configuration.ConfigurationManager.ConnectionStrings["DBBusinessTrip"])); } }

    Class2 klas = new Class2(); string islem; string ConnID; string BusinessTripID;
    protected void Page_Load(object sender, EventArgs e)
    {
        LinkButton lblprofil = (LinkButton)Master.FindControl("Yeniezamiyye");

        lblprofil.BackColor = Color.Peru;
        try
        {
            //aranacak = Request.QueryString["aranacak"];

            islem = Request.QueryString["islem"];
            ConnID = Request.QueryString["ConnID"];

        }
        catch (Exception)
        { }
        
        if (!Page.IsPostBack)
        {
            txtezammeqsed.Visible = false;
            txtezammeqsed.Text = "";
            ddlezammeqsed.Visible = true;
            meqsed();
            selectBAM();
           
            if (islem == "sil") {

                klas.cmd("Delete from FPurposeOfTrip Where ConnID=" + ConnID);
                selectBAM();
            }

            if (islem == "duzelis")
            {
                DataRow drmeqs = klas.GetDataRow("SELECT * from FPurposeOfTrip where ConnID=" + ConnID);
                txtsebeb.Text = drmeqs["NoteText"].ToString();
                txtgorulecekiw.Text = drmeqs["Future_work"].ToString();
                txtgoznetice.Text = drmeqs["Expected_results"].ToString();
                if (drmeqs["PurposeID"].ToString() == "0")
                {
                    meqsed();
                    ddlezammeqsed.Items.Insert(0, new ListItem("", "0"));
                    ddlezammeqsed.SelectedIndex = 0;
                    ddlezammeqsed.Visible = false;
                    txtezammeqsed.Text = drmeqs["Purpose"].ToString();
                    txtezammeqsed.Visible = true;
                    chkmeqsed.Checked = true;
                }
                else
                {
                    ddlezammeqsed.SelectedValue = drmeqs["PurposeID"].ToString();
                }
            }
            if (islem == "duzeldi")
            {
                lblmsg.Text = "Dəyişiklik qeydə alındı";
                lblmsg.ForeColor = Color.Green;
            }
        }
    }
    protected void meqsed()
    {
        DataTable meqsed = klas.getdatatable("Select ClassifID,ClassifName,ListID from List_classifications where ListID=4 order by sort");
        ddlezammeqsed.Items.Clear();
        ddlezammeqsed.DataTextField = "ClassifName";
        ddlezammeqsed.DataValueField = "ClassifID";
        ddlezammeqsed.DataSource = meqsed;
        ddlezammeqsed.DataBind();
        ddlezammeqsed.Items.Insert(0, new ListItem("Seçin", "-1"));
    }
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        if (chkmeqsed.Checked == true)
        {
            meqsed();
            ddlezammeqsed.Items.Insert(0, new ListItem("", "0"));
            ddlezammeqsed.SelectedIndex = 0;
            ddlezammeqsed.Visible = false;
            txtezammeqsed.Text = "";
            txtezammeqsed.Visible = true;
          //  this.ComboBox1.DropDownStyle = ComboBoxStyle.DropDown;
        }
        else
        {
            meqsed();
            ddlezammeqsed.SelectedIndex = -1;
            ddlezammeqsed.Visible = true;
            txtezammeqsed.Text = "";
            txtezammeqsed.Visible = false;
          //  this.ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;          
        }
    }

    protected void selectBAM()
    {
        string selects = "Select * from FPurposeOfTrip where RegionID=" + Session["FRegionsId"].ToString() + "order by Purpose "; 
        DataTable dtBAM = klas.getdatatable(selects);
        GridView1.DataSource = klas.tekrarlama("Purpose", "1", dtBAM);
        GridView1.DataBind();
        //if (dtBAM.Rows.Count > 1)
        //{
        //    GridView1.Columns[0].Visible = false;
        //    GridView1.Columns[1].Visible = false;
        //    GridView1.Columns[5].Visible = false;
        //}
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
          string spurpose;
            if (ddlezammeqsed.SelectedValue == "-1")
            {
                spurpose = txtezammeqsed.Text;
            }
            else
            {
                spurpose = ddlezammeqsed.SelectedItem.ToString() + txtezammeqsed.Text;
            }
            if (islem != "duzelis")
        {
            DataTable dt = klas.getdatatable(@"Select * from FPurposeOfTrip where (Purpose=N'" + seo.temizle(spurpose) + "')  and (RegionID=" + Session["FRegionsID"].ToString() + ")");
            if (dt.Rows.Count == 0)
            {
                if ((spurpose.Length > 0) && (txtsebeb.Text != "") && (txtgoznetice.Text != "") && (txtsebeb.Text != ""))
                {
                    SqlConnection baglan = klas.baglan();
                    SqlCommand cmd = new SqlCommand("Insert into FPurposeOfTrip (PurposeID,Purpose,Future_work,Expected_results,RegionID,NoteText) values(@PurposeID,@Purpose,@Future_work,@Expected_results,@RegionID,@NoteText)", baglan);
                    if (chkmeqsed.Checked == true)
                    {
                        cmd.Parameters.Add("PurposeID", Int32.Parse("0"));
                    }
                    else
                    {
                        cmd.Parameters.Add("PurposeID", ddlezammeqsed.SelectedValue);
                    }
                    cmd.Parameters.Add("Purpose", spurpose);
                    cmd.Parameters.Add("Future_work", txtgorulecekiw.Text);
                    cmd.Parameters.Add("Expected_results", txtgoznetice.Text);
                    cmd.Parameters.Add("RegionID", Convert.ToInt32(Session["FRegionsId"].ToString()));
                    cmd.Parameters.Add("NoteText", txtsebeb.Text);
                    cmd.ExecuteNonQuery();
                    selectBAM();
                    lblmsg.Text = "Məlumat əlavə edildi";
                    lblmsg.ForeColor = Color.Green;
                    this.chkmeqsed.Checked = false;
                    this.txtsebeb.Text = "";
                    this.txtgoznetice.Text = "";
                    this.txtgorulecekiw.Text = "";
                    this.txtezammeqsed.Text = "";
                    ddlezammeqsed.Visible = true;
                    txtezammeqsed.Visible = false;
                    meqsed();
                    ddlezammeqsed.SelectedIndex = -1;
                }
                else
                {
                    lblmsg.Text = "Məlumat tam deyil";
                    lblmsg.ForeColor = Color.Red;
                    //txtmeqsedelave.Text = "";
                    // meqsedsort();
                }
            }
            else
            {
                lblmsg.Text = "Məlumat mövcuddur";
                lblmsg.ForeColor = Color.Red;
            }

        }
        else if (islem == "duzelis")
        {

            DataTable dt1 = klas.getdatatable(@"Select * from FPurposeOfTrip where (Purpose=N'" + seo.temizle(spurpose) + "')  and (RegionID=" + Session["FRegionsID"].ToString() + ") and (ConnID<>" + ConnID + ")");
            if (dt1.Rows.Count == 0)
            {
                if ((spurpose.Length > 0) && (txtsebeb.Text != "") && (txtgoznetice.Text != "") && (txtsebeb.Text != ""))
                {
                    SqlConnection baglan = klas.baglan();
                    SqlCommand cmd = new SqlCommand("update FPurposeOfTrip set PurposeID=@PurposeID,Purpose=@Purpose,Future_work=@Future_work,Expected_results=@Expected_results,RegionID=@RegionID,NoteText=@NoteText  where ConnID=" + ConnID, baglan);
                    if (chkmeqsed.Checked == true)
                    {
                        cmd.Parameters.Add("PurposeID", Int32.Parse("0"));
                    }
                    else
                    {
                        cmd.Parameters.Add("PurposeID", ddlezammeqsed.SelectedValue);
                    }
                    cmd.Parameters.Add("Purpose", spurpose);
                    cmd.Parameters.Add("Future_work", txtgorulecekiw.Text);
                    cmd.Parameters.Add("Expected_results", txtgoznetice.Text);
                    cmd.Parameters.Add("RegionID", Convert.ToInt32(Session["FRegionsId"].ToString()));
                    cmd.Parameters.Add("NoteText", txtsebeb.Text);
                    cmd.ExecuteNonQuery();
                    selectBAM();
                    Response.Redirect("et_baxilmish_arash_mesele.aspx?islem=duzeldi");
                    lblmsg.Text = "Məlumat əlavə edildi";
                    lblmsg.ForeColor = Color.Green;
                    this.chkmeqsed.Checked = false;
                    this.txtsebeb.Text = "";
                    this.txtgorulecekiw.Text = "";
                    this.txtgoznetice.Text = "";
                    this.txtezammeqsed.Text = "";
                    ddlezammeqsed.Visible = true;
                    txtezammeqsed.Visible = false;
                    meqsed();
                    ddlezammeqsed.SelectedIndex = -1;
      
                }
                else
                {
                    lblmsg.Text = "Məlumat tam deyil";
                    lblmsg.ForeColor = Color.Red;
                    //txtmeqsedelave.Text = "";
                    // meqsedsort();
                }
            }
            else
            {
                lblmsg.Text = "Məlumat mövcuddur";
                lblmsg.ForeColor = Color.Red;
            }
        }



    }

    private Type GetRouteUrl()
    {
        throw new NotImplementedException();
    }

    protected void btngeri_Click(object sender, EventArgs e)
    {
        Response.Redirect("Ezamiyyənin_Planı.aspx?RegionCode=" + Session["RegionID"].ToString()+"&BusinessTripID="+Session["BusinessTripID"].ToString()+"&RayonID1="+Session["FRegionsId"].ToString());
    }
}