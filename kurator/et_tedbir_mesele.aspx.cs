using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

public partial class kurator_et_tedbir_mesele : System.Web.UI.Page
{
    Class2 klas = new Class2(); string islem; string ConnID; string BusinessTripID;
    protected void Page_Load(object sender, EventArgs e)
    {
        LinkButton lblprofil = (LinkButton)Master.FindControl("Yeniezamiyye");

        lblprofil.BackColor = Color.Peru;
        try
        {

            islem = Request.QueryString["islem"];
            ConnID = Request.QueryString["ConnID"];

        }
        catch (Exception)
        { }
        if (!Page.IsPostBack)
        {
            ddltedbir.Visible = true;
            ddlmuzmesele.Visible = true;
            txtiwttedbir.Visible = false;
            txtmuzmes.Visible = false;
            FillCombobox1();
            FillCombobox2();
            selectBAM();
           
            if (islem == "sil")
            {
               
                klas.cmd("Delete from FIssues_of_results Where ConnID=" + ConnID);
                selectBAM();
            }
            if (islem == "duzelis")
            {
                DataRow drmeqs = klas.GetDataRow("SELECT * from FIssues_of_results where ConnID=" + ConnID);
                txtgoznetice.Text = drmeqs["results"].ToString();
                if (drmeqs["ActionsID"].ToString() == "0")
                {
                    FillCombobox1();
                    this.ddltedbir.Items.Insert(0, new ListItem("", "0"));
                    ddltedbir.SelectedIndex = 0;
                    txtiwttedbir.Text = drmeqs["Actions"].ToString();
                    txtiwttedbir.Visible = true;
                    ddltedbir.Visible = false;
                    CheckBox1.Checked = true;
                }
                else
                {
                    ddltedbir.SelectedValue = drmeqs["ActionsID"].ToString();
                }
                if (drmeqs["IssuesID"].ToString() == "0")
                {
                    FillCombobox2();
                    this.ddlmuzmesele.Items.Insert(0, new ListItem("", "0"));
                    ddlmuzmesele.SelectedIndex = 0;
                    txtmuzmes.Text = drmeqs["Issues"].ToString();
                    txtmuzmes.Visible = true;
                    ddlmuzmesele.Visible = false;
                    CheckBox2.Checked = true;
                }
                else
                {
                    ddlmuzmesele.SelectedValue = drmeqs["IssuesID"].ToString();
                }
            }
            if (islem == "duzeldi")
            {
                lblmsg.Text = "Dəyişiklik qeydə alındı";
                lblmsg.ForeColor = Color.Green;
            }
        }
    }
    protected void FillCombobox2()
    {
        DataTable meqsed1 = klas.getdatatable("select * from List_classifications where ListID=18 order by sort");
        this.ddlmuzmesele.Items.Clear();
        this.ddlmuzmesele.DataTextField = "ClassifName";
        this.ddlmuzmesele.DataValueField = "ClassifID";
        this.ddlmuzmesele.DataSource = meqsed1;
        this.ddlmuzmesele.DataBind();
        this.ddlmuzmesele.Items.Insert(0, new ListItem("Seçin", "-1"));
    }
    protected void FillCombobox1()
    {
        DataTable meqsed = klas.getdatatable("select * from List_classifications where ListID=9 order by sort");
        this.ddltedbir.Items.Clear();
        this.ddltedbir.DataTextField = "ClassifName";
        this.ddltedbir.DataValueField = "ClassifID";
        this.ddltedbir.DataSource = meqsed;
        this.ddltedbir.DataBind();
        this.ddltedbir.Items.Insert(0, new ListItem("Seçin", "-1"));
    }
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        if (CheckBox1.Checked == true)
        {
            FillCombobox1();
            this.ddltedbir.Items.Insert(0, new ListItem("", "0"));
            ddltedbir.SelectedIndex = 0;
            txtiwttedbir.Text = "";
            txtiwttedbir.Visible = true;
            ddltedbir.Visible = false;
         //   this.ComboBox1.DropDownStyle = ComboBoxStyle.DropDown;
        }
        else
        {
            FillCombobox1();
            ddltedbir.SelectedIndex = -1;
            txtiwttedbir.Text = "";
            txtiwttedbir.Visible = false;
            ddltedbir.Visible = true;
         //   this.ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }

    protected void selectBAM()
    {
        DataTable dtBAM = klas.getdatatable(@"Select Actions ,Issues ,results ,ConnID from FIssues_of_results where RegionID=" + Session["FRegionsId"].ToString() + " order by Actions");
        GridView1.DataSource = klas.tekrarlama("Actions", "1", dtBAM);
        GridView1.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string sActions, sIssues;
        if (ddltedbir.SelectedValue == "-1")
        {
            sActions = txtiwttedbir.Text;
        }
        else
        {
            sActions = ddltedbir.SelectedItem.ToString() + txtiwttedbir.Text;
        }
        if (ddlmuzmesele.SelectedValue == "-1")
        {
            sIssues = txtmuzmes.Text;
        }
        else
        {
            sIssues = ddlmuzmesele.SelectedItem.ToString() + txtmuzmes.Text;
        }




        if (islem != "duzelis")
        {
            DataTable dt = klas.getdatatable( @"Select * from FIssues_of_results where (Actions=N'" + seo.temizle(sActions) + "') and (Issues=N'" + seo.temizle(sIssues) + "') and (RegionID=" + Session["FRegionsID"].ToString() + ")");
            if (dt.Rows.Count == 0)
            {
                // && (txtgoznetice.Text != "")
                if ((sActions.Length > 0) && (sIssues.Length > 0))
                {
                    SqlConnection baglanti1 = klas.baglan();
                    SqlCommand cmd = new SqlCommand("Insert into FIssues_of_results (ActionsID,Actions,IssuesID,Issues,results,RegionID) values(@ActionsID,@Actions,@IssuesID,@Issues,@results,@RegionID)", baglanti1);
                    if (CheckBox1.Checked)
                    {
                        cmd.Parameters.Add("ActionsID", Int32.Parse("0"));
                    }
                    else
                    {
                        cmd.Parameters.Add("ActionsID", ddltedbir.SelectedValue);
                    }
                    cmd.Parameters.Add("Actions", sActions);
                    if (CheckBox2.Checked)
                    {
                        cmd.Parameters.Add("IssuesID", Int32.Parse("0"));
                    }
                    else
                    {
                        cmd.Parameters.Add("IssuesID", ddlmuzmesele.SelectedValue);
                    }
                    cmd.Parameters.Add("Issues", sIssues);
                    cmd.Parameters.Add("results", txtgoznetice.Text);
                    cmd.Parameters.Add("RegionID", Convert.ToInt32(Session["FRegionsId"].ToString()));
                    cmd.ExecuteNonQuery();
                    selectBAM();
                    //    lblmeqsedelave.Text = "Baxılmış, araşdırılmış məsələ əlavə edildi";
                    //    lblmeqsedelave.ForeColor = Color.Green;
                    lblmsg.Text = "Məlumat əlavə edildi";
                    lblmsg.ForeColor = Color.Green;
                    this.CheckBox1.Checked = false;
                    this.CheckBox2.Checked = false;
                    ddltedbir.Visible = true;
                    ddlmuzmesele.Visible = true;
                    txtiwttedbir.Visible = false;
                    txtmuzmes.Visible = false;
                    this.ddltedbir.SelectedIndex = -1;
                    this.ddlmuzmesele.SelectedIndex = -1;
                    this.txtgoznetice.Text = "";
                    this.txtiwttedbir.Text = "";
                    this.txtmuzmes.Text = "";
                    FillCombobox1();
                    ddltedbir.SelectedIndex = -1;
                    //   this.ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
                    FillCombobox2();
                    ddlmuzmesele.SelectedIndex = -1;
                    //   this.ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
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
            DataTable dt = klas.getdatatable(@"Select * from FIssues_of_results where (Actions=N'" + seo.temizle(sActions) + "') and (Issues=N'" + sIssues + "') and (RegionID=" + Session["FRegionsID"].ToString() + ") and (ConnID<>"+ConnID+")");
            if (dt.Rows.Count == 0)
            {
                //&& (txtgoznetice.Text != "")
                if ((sActions.Length > 0) && (sIssues.Length > 0) )
                {
                    SqlConnection baglanti1 = klas.baglan();
                    SqlCommand cmd = new SqlCommand("Update  FIssues_of_results set ActionsID=@ActionsID,Actions=@Actions,IssuesID=@IssuesID,Issues=@Issues,results=@results,RegionID=@RegionID where ConnID=" + ConnID, baglanti1);
                    if (CheckBox1.Checked)
                    {
                        cmd.Parameters.Add("ActionsID", Int32.Parse("0"));
                    }
                    else
                    {
                        cmd.Parameters.Add("ActionsID", ddltedbir.SelectedValue);
                    }
                    cmd.Parameters.Add("Actions", sActions);
                    if (CheckBox2.Checked)
                    {
                        cmd.Parameters.Add("IssuesID", Int32.Parse("0"));
                    }
                    else
                    {
                        cmd.Parameters.Add("IssuesID", ddlmuzmesele.SelectedValue);
                    }
                    cmd.Parameters.Add("Issues", sIssues);
                    cmd.Parameters.Add("results", txtgoznetice.Text);
                    cmd.Parameters.Add("RegionID", Convert.ToInt32(Session["FRegionsId"].ToString()));
                    cmd.ExecuteNonQuery();
                    selectBAM();
                    //    lblmeqsedelave.Text = "Baxılmış, araşdırılmış məsələ əlavə edildi";
                    //    lblmeqsedelave.ForeColor = Color.Green;
                    Response.Redirect("et_tedbir_mesele.aspx?islem=duzeldi");
                   
                    lblmsg.Text = "Məlumat əlavə edildi";
                    lblmsg.ForeColor = Color.Green;
                    this.CheckBox1.Checked = false;
                    this.CheckBox2.Checked = false;
                    ddltedbir.Visible = true;
                    ddlmuzmesele.Visible = true;
                    txtiwttedbir.Visible = false;
                    txtmuzmes.Visible = false;
                    this.ddltedbir.SelectedIndex = -1;
                    this.ddlmuzmesele.SelectedIndex = -1;
                    this.txtgoznetice.Text = "";
                    this.txtiwttedbir.Text = "";
                    this.txtmuzmes.Text = "";
                    FillCombobox1();
                    ddltedbir.SelectedIndex = -1;
                    //   this.ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
                    FillCombobox2();
                    ddlmuzmesele.SelectedIndex = -1;
                    //   this.ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
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

    protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
    {
        if (CheckBox2.Checked == true)
        {
            FillCombobox2();
            this.ddlmuzmesele.Items.Insert(0, new ListItem("", "0"));
            ddlmuzmesele.SelectedIndex = 0;
            txtmuzmes.Text = "";
            txtmuzmes.Visible = true;
            ddlmuzmesele.Visible = false;
         //   this.ComboBox2.DropDownStyle = ComboBoxStyle.DropDown;
        }
        else
        {
            FillCombobox2();
            ddlmuzmesele.SelectedIndex = -1;
            txtmuzmes.Text = "";
            txtmuzmes.Visible = false;
            ddlmuzmesele.Visible = true;
        //    this.ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }

    protected void btngeri_Click(object sender, EventArgs e)
    {
        Response.Redirect("Ezamiyyənin_Planı.aspx?RegionCode=" + Session["RegionID"].ToString() + "&BusinessTripID=" + Session["BusinessTripID"].ToString() + "&RayonID1=" + Session["FRegionsId"].ToString());
    }
}