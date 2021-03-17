using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class adminpanel_Yasayismen : System.Web.UI.Page
{
    Class2 klas = new Class2();
    protected void Page_Load(object sender, EventArgs e)
    {
 
      

        if (Page.IsPostBack == false)
        {

      
        LinkButton lblvizual1 = (LinkButton)Master.Master.FindControl("Tesnifatlar");
        lblvizual1.BackColor = Color.Peru;

        ContentPlaceHolder cp = this.Master.Master.FindControl("ContentPlaceHolder1") as ContentPlaceHolder;
        LinkButton tb = cp.FindControl("Yasayismen") as LinkButton;
        tb.BackColor = Color.Brown;
        }
    
    }
    protected void btnrayon_Click(object sender, EventArgs e)
    {
        btngeri.Enabled = true;
        btndeleterayon.BackColor = SystemColors.ButtonFace;
        btninsertrayon.BackColor = SystemColors.ButtonFace;
        btnupdaterayon.BackColor = SystemColors.ButtonFace;

        btnrayon.BackColor = Color.GreenYellow;
        btnihb.BackColor = SystemColors.ButtonFace;
        btnyawayiw.BackColor = SystemColors.ButtonFace;
        btnihb.Enabled = false;
        btnyawayiw.Enabled = false;

        pnlrayon.Visible = true;
        pnlyawayiw.Visible = false;
        pnlihb.Visible = false;
        pnlinsertrayon.Visible = false;
        pnlupdaterayon.Visible = false;
        pnlsil.Visible = false;
    }
    protected void btnyawayiw_Click(object sender, EventArgs e)
    {

        btngeri.Enabled = true;

        btnyawayiwsild.BackColor = SystemColors.ButtonFace;
        btnyawayiwelaved.BackColor = SystemColors.ButtonFace;
        btnyawayiwredakted.BackColor = SystemColors.ButtonFace;
        btnyawayiw.BackColor = Color.GreenYellow;
        btnrayon.BackColor = SystemColors.ButtonFace;
        btnihb.BackColor = SystemColors.ButtonFace;

        btnrayon.Enabled = false;
        btnihb.Enabled = false;
        pnlyawayiwelave.Visible = false;
        pnlyawayiwredakte.Visible = false;
        pnlyawayiwsil.Visible = false;
        pnlyawayiw.Visible = true;
        pnlihb.Visible = false;
        pnlrayon.Visible = false;

    }
    void regionredkte()
    {
        DataTable dtiller = klas.getdatatable("Select RegionsID,UserID,CASE WHEN CityID =  2 THEN Name" +
            " +' '+'rayonu' WHEN CityID =1 THEN Name +' '+N'şəhəri' END as Name from List_classification_Regions where ForDelete=1 order by [Name]");
        ddlrayonredakte.DataTextField = "Name";
        ddlrayonredakte.DataValueField = "RegionsID";
        ddlrayonredakte.DataSource = dtiller;
        ddlrayonredakte.DataBind();
    }
    void status()
    {
        DataTable dtiller = klas.getdatatable("Select RegionsID,UserID,CASE WHEN CityID =  2 THEN Name" +
            " +' '+'rayonu' WHEN CityID =1 THEN Name +' '+N'şəhəri' END as Name from List_classification_Regions where ForDelete=1 order by [Name]");
        ddlrayonredakte.DataTextField = "Name";
        ddlrayonredakte.DataValueField = "RegionsID";
        ddlrayonredakte.DataSource = dtiller;
        ddlrayonredakte.DataBind();
    }
    void regionsil()
    {
        DataTable dtiller = klas.getdatatable("Select RegionsID,UserID,CASE WHEN CityID =  2 THEN Name" +
            " +' '+'rayonu' WHEN CityID =1 THEN Name +' '+N'şəhəri' END as Name from List_classification_Regions where ForDelete=1 order by [Name]");
        ddlrayonsil.DataTextField = "Name";
        ddlrayonsil.DataValueField = "RegionsID";
        ddlrayonsil.DataSource = dtiller;
        ddlrayonsil.DataBind();
    }
    void regionihb()
    {
        DataTable dtiller = klas.getdatatable("Select RegionsID,UserID,CASE WHEN CityID =  2 THEN Name" +
            " +' '+'rayonu' WHEN CityID =1 THEN Name +' '+N'şəhəri' END as Name from List_classification_Regions where ForDelete=1  order by [Name]");
        ddlihbrayonelave.DataTextField = "Name";
        ddlihbrayonelave.DataValueField = "RegionsID";
        ddlihbrayonelave.DataSource = dtiller;
        ddlihbrayonelave.DataBind();
    }

    void rayonihbredakte()
    {
        DataTable dtiller2 = klas.getdatatable("Select RegionsID,UserID,CASE WHEN CityID =  2 THEN Name" +
            " +' '+'rayonu' WHEN CityID =1 THEN Name +' '+N'şəhəri' END as Name from List_classification_Regions where ForDelete=1 order by [Name]");
        ddlihbrayonredakte.DataTextField = "Name";
        ddlihbrayonredakte.DataValueField = "RegionsID";
        ddlihbrayonredakte.DataSource = dtiller2;
        ddlihbrayonredakte.DataBind();
    }

    void ihbredakte()
    {
        DataTable dtilceler = klas.getdatatable("Select * from Administrative_Department Where RegionID=" + ddlihbrayonredakte.SelectedValue + " and ForDelete=1 order by [DepartmentName]");
        ddlihbredakte.DataTextField = "DepartmentName";
        ddlihbredakte.DataValueField = "DepartmentID";
        ddlihbredakte.DataSource = dtilceler;
        ddlihbredakte.DataBind();
    }

    void rayonihbsil()
    {
        DataTable dtiller2 = klas.getdatatable("Select RegionsID,UserID,CASE WHEN CityID =  2 THEN Name" +
            " +' '+'rayonu' WHEN CityID =1 THEN Name +' '+N'şəhəri' END as Name from List_classification_Regions where ForDelete=1 order by [Name]");
        ddlihbraysil.DataTextField = "Name";
        ddlihbraysil.DataValueField = "RegionsID";
        ddlihbraysil.DataSource = dtiller2;
        ddlihbraysil.DataBind();
    }
    void ihbsil()
    {
        DataTable dtilceler = klas.getdatatable("Select * from Administrative_Department Where RegionID=" + ddlihbraysil.SelectedValue + " and ForDelete=1  order by [DepartmentName]");
        ddlihbsil.DataTextField = "DepartmentName";
        ddlihbsil.DataValueField = "DepartmentID";
        ddlihbsil.DataSource = dtilceler;
        ddlihbsil.DataBind();
    }

    void regionyawayiwelave()
    {
        DataTable dtiller2 = klas.getdatatable("Select RegionsID,UserID,CASE WHEN CityID =  2 THEN Name" +
            " +' '+'rayonu' WHEN CityID =1 THEN Name +' '+N'şəhəri' END as Name from List_classification_Regions where ForDelete=1 order by [Name]");
        ddlregyawayiwelave.DataTextField = "Name";
        ddlregyawayiwelave.DataValueField = "RegionsID";
        ddlregyawayiwelave.DataSource = dtiller2;
        ddlregyawayiwelave.DataBind();
    }
    void yawayiwiedelave()
    {
        DataTable dtilceler = klas.getdatatable("Select * from Administrative_Department Where RegionID=" + ddlregyawayiwelave.SelectedValue + " and ForDelete=1  order by [DepartmentName]");
        ddliedyawayiwelave.DataTextField = "DepartmentName";
        ddliedyawayiwelave.DataValueField = "DepartmentID";
        ddliedyawayiwelave.DataSource = dtilceler;
        ddliedyawayiwelave.DataBind();
    }
    void yawayiwtypeelave()
    {
        DataTable dtilceler = klas.getdatatable("Select * from List_SubRegions_type order by [Name]");
        ddltypeyawayiw.DataTextField = "Name";
        ddltypeyawayiw.DataValueField = "AreaID";
        ddltypeyawayiw.DataSource = dtilceler;
        ddltypeyawayiw.DataBind();
    }
    void regionyawayiwredakte()
    {
        DataTable dtiller2 = klas.getdatatable("Select RegionsID,UserID,CASE WHEN CityID =  2 THEN Name" +
            " +' '+'rayonu' WHEN CityID =1 THEN Name +' '+N'şəhəri' END as Name from List_classification_Regions where ForDelete=1 order by [Name]");
        ddlyawayiwredreg.DataTextField = "Name";
        ddlyawayiwredreg.DataValueField = "RegionsID";
        ddlyawayiwredreg.DataSource = dtiller2;
        ddlyawayiwredreg.DataBind();
    }
    void yawayiwredakte()
    {
        DataTable dtilceler = klas.getdatatable("Select CityID,CASE WHEN TypeID = 4 THEN Name + ' ' + N'kəndi'  WHEN TypeID = 3 THEN Name + ' ' + N'qəsəbəsi' WHEN TypeID = 2 THEN Name + ' ' + N'şəhəri' WHEN TypeID = 5 THEN Name + ' ' + N'rayonu' else Name  END as Name  from List_SubRegions Where RegionID=" + ddlyawayiwredreg.SelectedValue + " and ForDelete=1 order by [Name]");
        ddlyawayiwredakte.DataTextField = "Name";
        ddlyawayiwredakte.DataValueField = "CityID";
        ddlyawayiwredakte.DataSource = dtilceler;
        ddlyawayiwredakte.DataBind();
    }
    void yawayiwtyperedakte()
    {
        DataTable dtilceler = klas.getdatatable("Select * from List_SubRegions_type where areaid<>1  order by [Name]");
        ddlyawayiwtype.DataTextField = "Name";
        ddlyawayiwtype.DataValueField = "AreaID";
        ddlyawayiwtype.DataSource = dtilceler;
        ddlyawayiwtype.DataBind();
    }

    void regionyawayiwsil()
    {
        DataTable dtiller2 = klas.getdatatable("Select RegionsID,UserID,CASE WHEN CityID =  2 THEN Name" +
            " +' '+'rayonu' WHEN CityID =1 THEN Name +' '+N'şəhəri' END as Name from List_classification_Regions where ForDelete=1 order by [Name]");
        ddlregyawayiwsil.DataTextField = "Name";
        ddlregyawayiwsil.DataValueField = "RegionsID";
        ddlregyawayiwsil.DataSource = dtiller2;
        ddlregyawayiwsil.DataBind();
    }
    void yawayiwsil()
    {
        DataTable dtilceler = klas.getdatatable("Select CityID,CASE WHEN TypeID = 4 THEN Name + ' ' + N'kəndi'  WHEN TypeID = 3 THEN Name + ' ' + N'qəsəbəsi' WHEN TypeID = 2 THEN Name + ' ' + N'şəhəri' WHEN TypeID = 5 THEN Name + ' ' + N'rayonu' else Name  END as Name  from List_SubRegions Where RegionID=" + ddlregyawayiwsil.SelectedValue + "  and ForDelete=1 order by [Name]");
        ddlyawayiwsil.DataTextField = "Name";
        ddlyawayiwsil.DataValueField = "CityID";
        ddlyawayiwsil.DataSource = dtilceler;
        ddlyawayiwsil.DataBind();
    }

    protected void ddlrayonredakte_SelectedIndexChanged(object sender, EventArgs e)
    {
        string b = klas.getdatacell("select CityID from List_classification_Regions where RegionsID=" + ddlrayonredakte.SelectedValue);
        ddlstatusray.SelectedValue = b;
        if (ddlrayonredakte.SelectedValue != "0")
        {
            string a = klas.getdatacell("select Name from List_classification_Regions where RegionsID=" + ddlrayonredakte.SelectedValue);
            txtredakte.Text = a;
        }
        else
        {
            txtredakte.Text = "";
        }
    }

    protected void btnrayonelave_Click(object sender, EventArgs e)
    {
        if (txtrayonelave.Text != "")
        {
            DataRow drrayon = klas.GetDataRow("Select * from List_classification_Regions Where Name=N'" + txtrayonelave.Text + "' and ForDelete=1");
            if (drrayon == null && ddlstatusray0.SelectedValue!="0")
            {
                SqlConnection baglanti = klas.baglan();
                SqlCommand cmd = new SqlCommand("Insert into List_classification_Regions (Name,CityID) values(@Name,@CityID)", baglanti);
                cmd.Parameters.Add("Name", txtrayonelave.Text);

                cmd.Parameters.Add("CityID", ddlstatusray0.SelectedValue);
                cmd.ExecuteNonQuery();
                lblrayonelave.Text = "Rayon əlavə edildi";
                lblrayonelave.ForeColor = Color.Green;
                txtrayonelave.Text = "";
                Response.Redirect("Yasayismen.aspx");
            }
            else
            {
                lblrayonelave.Text = "Elavə etmək istədiyiniz rayon artıq bazada var";
                lblrayonelave.ForeColor = Color.Red;
                if (ddlstatusray0.SelectedValue == "0") {
                    lblrayonelave.Text = "Status seçilməyib";
                    lblrayonelave.ForeColor = Color.Red;
                }
            }
        }
        else
        {
            lblrayonelave.Text = "Rayon adı boşluq ola bilməz";
            lblrayonelave.ForeColor = Color.Red;
        }
    }
    protected void btnrayonredakte_Click(object sender, EventArgs e)
    {
        DataRow drrayon = klas.GetDataRow("Select * from List_classification_Regions Where Name=N'" + txtredakte.Text + "' and ForDelete=1 and RegionsID<>" + ddlrayonredakte.SelectedValue);
       
        if (ddlrayonredakte.SelectedValue != "0" && txtredakte.Text != "" && drrayon==null&& ddlstatusray.SelectedValue !="0")
        {
            SqlConnection baglanti = klas.baglan();
            SqlCommand cmd = new SqlCommand("Update List_classification_Regions Set Name=@Name,CityID=@CityID Where RegionsID=" + ddlrayonredakte.SelectedValue, baglanti);
            cmd.Parameters.Add("Name", txtredakte.Text);
            cmd.Parameters.Add("CityID", ddlstatusray.SelectedValue);
            cmd.ExecuteNonQuery();
            lblrayonredakte.Text = "Dəyişiklik qeydə alındı";
            lblrayonredakte.ForeColor = Color.Green;
            regionredkte();
            ddlrayonredakte.Items.Insert(0, new ListItem("Seçin", "0"));
            txtredakte.Text = "";
            Response.Redirect("Yasayismen.aspx");
        }
        else
        {
           
            if (txtredakte.Text == "")
            {
                lblrayonredakte.Text = "Rayon adı boşluq ola bilməz";
            }
            if (ddlrayonredakte.SelectedValue == "0")
            {
                lblrayonredakte.Text = "Rayon seçilməyib";
            }
            if (drrayon != null) {
                lblrayonredakte.Text = "Bu ad bazada var";
            }
            if (ddlstatusray.SelectedValue == "0") {
                lblrayonredakte.Text = "Status seçilməyib";
            
            }
            lblrayonredakte.ForeColor = Color.Red;
        }
    }
    protected void btnupdaterayon_Click(object sender, EventArgs e)
    {
  
        btnupdaterayon.BackColor = Color.Aquamarine;
        btninsertrayon.BackColor = SystemColors.ButtonFace;
        btndeleterayon.BackColor = SystemColors.ButtonFace;
        txtredakte.Text = "";
        lblrayonredakte.Text = "";
        pnlupdaterayon.Visible = true;
        pnlinsertrayon.Visible = false;
        pnlsil.Visible = false;
        regionredkte();
        ddlrayonredakte.Items.Insert(0, new ListItem("Seçin", "0"));
        ddlstatusray.SelectedValue = "0";
    }
    protected void btndeleterayon_Click(object sender, EventArgs e)
    {
        btnrayonsil.Enabled = false;
        btndeleterayon.BackColor = Color.Aquamarine;
        btninsertrayon.BackColor = SystemColors.ButtonFace;
        btnupdaterayon.BackColor = SystemColors.ButtonFace;
        lblrayonsil.Text = "";
        pnlupdaterayon.Visible = false;
        pnlinsertrayon.Visible = false;
        pnlsil.Visible = true;
        regionsil();
        ddlrayonsil.Items.Insert(0, new ListItem("Seçin", "0"));
    }
    protected void btninsertrayon_Click(object sender, EventArgs e)
    {
        btninsertrayon.BackColor = Color.Aquamarine;
        btnupdaterayon.BackColor = SystemColors.ButtonFace;
        btndeleterayon.BackColor = SystemColors.ButtonFace;
        pnlinsertrayon.Visible = true;
        pnlsil.Visible = false;
        pnlupdaterayon.Visible = false;
        lblrayonelave.Text = "";
        txtrayonelave.Text = "";
        ddlstatusray0.SelectedValue = "0";
    }

    protected void btnihb_Click(object sender, EventArgs e)
    {
        btngeri.Enabled = true;
        btnihbsild.BackColor = SystemColors.ButtonFace;
        btnihbelaved.BackColor = SystemColors.ButtonFace;
        btnihbredakted.BackColor = SystemColors.ButtonFace;
        btnihb.BackColor = Color.GreenYellow;
        btnrayon.BackColor = SystemColors.ButtonFace;
        btnyawayiw.BackColor = SystemColors.ButtonFace;
        btnrayon.Enabled = false;
        btnyawayiw.Enabled = false;
        pnlihb.Visible = true;
        pnlyawayiw.Visible = false;
        pnlrayon.Visible = false;
        pnlihbelave.Visible = false;
        pnlihbredakte.Visible = false;
        pnlihbsil.Visible = false;
    }

    protected void btnrayonsil_Click1(object sender, EventArgs e)
    {
        if (ddlrayonsil.SelectedValue != "0")
        {
            btnrayonsil.Enabled = false;
            SqlConnection baglanti = klas.baglan();
            SqlCommand cmd = new SqlCommand("Update List_classification_Regions Set ForDelete=0 Where RegionsID=" + ddlrayonsil.SelectedValue, baglanti);
            cmd.ExecuteNonQuery();
            lblrayonsil.Text = "Rayon silindi";
            lblrayonsil.ForeColor = Color.Green;
            Response.Redirect("Yasayismen.aspx");
        }
        else
        {
            lblrayonsil.Text = "Rayon seçilməyib";
            lblrayonsil.ForeColor = Color.Red;
        }
        regionsil();
        ddlrayonsil.Items.Insert(0, new ListItem("Seçin", "0"));



    }

    protected void ddlihbrayonelave_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnihbelave_Click(object sender, EventArgs e)
    {
        if (txtihbelave.Text != "" && ddlihbrayonelave.SelectedValue != "0")
        {
            DataRow drrayon1 = klas.GetDataRow("Select * from Administrative_Department Where DepartmentName=N'" + txtihbelave.Text + "' and RegionID='" + ddlihbrayonelave.SelectedValue + "' and ForDelete=1 ");
            if (drrayon1 == null)
            {
                SqlConnection baglanti = klas.baglan();
                SqlCommand cmd = new SqlCommand("Insert into Administrative_Department (DepartmentName,RegionID) values(@DepartmentName,@RegionID)", baglanti);
                cmd.Parameters.Add("DepartmentName", txtihbelave.Text);
                cmd.Parameters.Add("RegionID", ddlihbrayonelave.SelectedValue);
                cmd.ExecuteNonQuery();
                lblihbelave.Text = "İƏD əlavə edildi";
                lblihbelave.ForeColor = Color.Green;
                Response.Redirect("Yasayismen.aspx");
            }
            else
            {
                lblihbelave.Text = "Elavə etmək istədiyiniz İƏD artıq bazada var";
                lblihbelave.ForeColor = Color.Red;

            }
        }
        else
        {
            lblihbelave.Text = "İƏD adı boşluq ola bilməz";
            lblihbelave.ForeColor = Color.Red;
            if (ddlihbrayonelave.SelectedValue == "0")
            {
                lblihbelave.Text = "Rayonu seçin";
                lblihbelave.ForeColor = Color.Red;
            }
        }
    }
    protected void btnihbelaved_Click(object sender, EventArgs e)
    {
        btnihbelaved.BackColor = Color.Aquamarine;
        btnihbredakted.BackColor = SystemColors.ButtonFace;
        btnihbsild.BackColor = SystemColors.ButtonFace;

        txtihbelave.Text = "";
        lblihbelave.Text = "";
        regionihb();
        ddlihbrayonelave.Items.Insert(0, new ListItem("Seçin", "0"));
        pnlihbelave.Visible = true;
        pnlihbredakte.Visible = false;
        pnlihbsil.Visible = false;
    }
    protected void btnihbredakted_Click(object sender, EventArgs e)
    {
        btnihbredakted.BackColor = Color.Aquamarine;
        btnihbelaved.BackColor = SystemColors.ButtonFace;
        btnihbsild.BackColor = SystemColors.ButtonFace;

        txtihbredakte.Text = "";
        lblihbredakte.Text = "";
        pnlihbsil.Visible = false;
        pnlihbelave.Visible = false;
        pnlihbredakte.Visible = true;
        ddlihbredakte.Enabled = false;
        txtihbredakte.Enabled = false;
        btnihbredakte.Enabled = false;
        rayonihbredakte();
        ddlihbrayonredakte.Items.Insert(0, new ListItem("Seçin", "0"));
        ihbredakte();
        ddlihbredakte.Items.Insert(0, new ListItem("Seçin", "0"));

    }

    protected void ddlihbrayonredakte_SelectedIndexChanged(object sender, EventArgs e)
    {
        ihbredakte();
        ddlihbredakte.Items.Insert(0, new ListItem("Seçin", "0"));
        txtihbredakte.Text = "";
        ddlihbredakte.SelectedValue = "0";
        btnihbredakte.Enabled = false;
        txtihbredakte.Enabled = false;
        ddlihbredakte.Enabled = true;
    }
    protected void ddlihbredakte_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlihbredakte.SelectedValue != "0")
        {
            txtihbredakte.Text = ddlihbredakte.SelectedItem.Text;
            txtihbredakte.Enabled = true;
            btnihbredakte.Enabled = true;
        }
        else
        {
            txtihbredakte.Text = "";
        }
    }
    protected void btnihbredakte_Click(object sender, EventArgs e)
    {
        DataRow drrayon = klas.GetDataRow("Select * from Administrative_Department Where DepartmentName=N'" + txtihbredakte.Text + "' and RegionID='" + ddlihbrayonredakte.SelectedValue+ "'");
        if (ddlihbredakte.SelectedValue != "0" && txtihbredakte.Text != "" && drrayon==null)
        {
            SqlConnection baglanti = klas.baglan();
            SqlCommand cmd = new SqlCommand("Update Administrative_Department Set DepartmentName=@DepartmentName Where DepartmentID=" + ddlihbredakte.SelectedValue, baglanti);
            cmd.Parameters.Add("DepartmentName", txtihbredakte.Text);
            cmd.ExecuteNonQuery();
            lblihbredakte.Text = "Dəyişiklik qeydə alındı";
            lblihbredakte.ForeColor = Color.Green;
            ihbredakte();
            ddlihbredakte.Items.Insert(0, new ListItem("Seçin", "0"));
            txtihbredakte.Text = "";
            Response.Redirect("Yasayismen.aspx");

        }
        else
        {
            if (ddlihbredakte.SelectedValue == "0")
            {
                lblihbredakte.Text = "IHB seçməmisiniz";
            }
            if (txtihbredakte.Text == "")
            {
                lblihbredakte.Text = "IHB adı boşluq ola bilməz";
            }
            if (drrayon != null) {
                lblihbredakte.Text = "Bu ad bazada var";
            }
            lblihbredakte.ForeColor = Color.Red;
        }
    }
    protected void btnihbsild_Click(object sender, EventArgs e)
    {
        btnihbsil.Enabled = false;
        btnihbsild.BackColor = Color.Aquamarine;
        btnihbelaved.BackColor = SystemColors.ButtonFace;
        btnihbredakted.BackColor = SystemColors.ButtonFace;

        ddlihbsil.Enabled = false;
        lblihbsil.Text = "";
        pnlihbsil.Visible = true;
        pnlihbelave.Visible = false;
        pnlihbredakte.Visible = false;
        rayonihbsil();
        ddlihbraysil.Items.Insert(0, new ListItem("Seçin", "0"));
        ihbsil();
        ddlihbsil.Items.Insert(0, new ListItem("Seçin", "0"));
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlihbraysil.SelectedValue != "0")
        {
            ihbsil();
            ddlihbsil.Items.Insert(0, new ListItem("Seçin", "0"));
            ddlihbsil.Enabled = true;
        }
        else
        {
            ddlihbsil.Enabled = false;
        }
    }
    protected void btnihbsil_Click(object sender, EventArgs e)
    {
        if (ddlihbsil.SelectedValue != "0" && ddlihbraysil.SelectedValue != "0")
        {
            btnihbsil.Enabled = false;

            SqlConnection baglanti = klas.baglan();
            SqlCommand cmd = new SqlCommand("Update Administrative_Department Set ForDelete=0 Where DepartmentID=" + ddlihbsil.SelectedValue, baglanti);
            cmd.ExecuteNonQuery();
            lblihbsil.Text = "IHB silindi";
            lblihbsil.ForeColor = Color.Green;
            Response.Redirect("Yasayismen.aspx");
        }
        else
        {
            lblihbsil.Text = "IHB seçilməyib";
            lblihbsil.ForeColor = Color.Red;
        }
        ihbsil();
        ddlihbsil.Items.Insert(0, new ListItem("Seçin", "0"));
    }
    protected void ddlregyawayiwelave_SelectedIndexChanged(object sender, EventArgs e)
    {
        yawayiwiedelave();
        ddliedyawayiwelave.Items.Insert(0, new ListItem("Seçin", "0"));
        yawayiwtypeelave();
        ddltypeyawayiw.Items.Insert(0, new ListItem("Seçin", "0"));

        ddltypeyawayiw.Enabled = false;
        txtyawayiwelave.Enabled = false;
        btnyawayiwelave.Enabled = false;
        txtyawayiwelave.Text = "";
        ddliedyawayiwelave.Enabled = true;

    }
    protected void ddlyawayiwelave_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddliedyawayiwelave.SelectedValue != "0")
        {
            ddltypeyawayiw.Enabled = true;
        }
        else
        {
            ddltypeyawayiw.Enabled = false;
        }

        txtyawayiwelave.Enabled = false;
        btnyawayiwelave.Enabled = false;
        txtyawayiwelave.Text = "";

        yawayiwtypeelave();
        ddltypeyawayiw.Items.Insert(0, new ListItem("Seçin", "0"));


    }
    protected void btnyawayiwelaved_Click(object sender, EventArgs e)
    {

        btnyawayiwelaved.BackColor = Color.Aquamarine;
        btnyawayiwredakted.BackColor = SystemColors.ButtonFace;
        btnyawayiwsild.BackColor = SystemColors.ButtonFace;

        txtyawayiwelave.Text = "";
        pnlyawayiwredakte.Visible = false;
        pnlyawayiwsil.Visible = false;
        pnlyawayiwelave.Visible = true;
        ddltypeyawayiw.Enabled = false;
        txtyawayiwelave.Enabled = false;
        btnyawayiwelave.Enabled = false;
        ddliedyawayiwelave.Enabled = false;
        regionyawayiwelave();
        ddlregyawayiwelave.Items.Insert(0, new ListItem("Seçin", "0"));
        yawayiwiedelave();
        ddliedyawayiwelave.Items.Insert(0, new ListItem("Seçin", "0"));
        yawayiwtypeelave();
        ddltypeyawayiw.Items.Insert(0, new ListItem("Seçin", "0"));
    }

    protected void btnyawayiwelave_Click(object sender, EventArgs e)
    {
        if (txtyawayiwelave.Text != "")
        {
            DataRow drrayon1 = klas.GetDataRow("Select * from List_SubRegions Where Name=N'" + txtyawayiwelave.Text + "' and RegionID='" + ddlregyawayiwelave.SelectedValue + "'and ForDelete=1");

            if (drrayon1 == null)
            {
                SqlConnection baglanti = klas.baglan();
                SqlCommand cmd = new SqlCommand("Insert into List_SubRegions (Name,RegionID,TypeID,ADminsDepartID) values(@Name,@RegionID,@TypeID,@ADminsDepartID)", baglanti);
                cmd.Parameters.Add("Name", txtyawayiwelave.Text);
                cmd.Parameters.Add("RegionID", ddlregyawayiwelave.SelectedValue);
                cmd.Parameters.Add("TypeID", ddltypeyawayiw.SelectedValue);
                cmd.Parameters.Add("ADminsDepartID", ddliedyawayiwelave.SelectedValue);
                cmd.ExecuteNonQuery();
                lblyawayiwelave.Text = "Yaşayış məntəqəsi əlavə edildi";
                lblyawayiwelave.ForeColor = Color.Green;
                Response.Redirect("Yasayismen.aspx");
            }
            else
            {
                lblyawayiwelave.Text = "Elavə etmək istədiyiniz yaşayış məntəqəsi artıq bazada var";
                lblyawayiwelave.ForeColor = Color.Red;

            }
        }
        else
        {
            lblyawayiwelave.Text = "Yaşayış məntəqəsi adı boşluq ola bilməz";
            lblyawayiwelave.ForeColor = Color.Red;
            if (ddltypeyawayiw.SelectedValue == "0")
            {
                lblyawayiwelave.Text = "Tip seçin";
                lblyawayiwelave.ForeColor = Color.Red;
            }
        }
    }

    protected void ddltypeyawayiw_SelectedIndexChanged1(object sender, EventArgs e)
    {
        if (ddltypeyawayiw.SelectedValue != "0")
        {
            txtyawayiwelave.Enabled = true;
            btnyawayiwelave.Enabled = true;

        }
        else
        {
            txtyawayiwelave.Enabled = false;
            btnyawayiwelave.Enabled = false;
            txtyawayiwelave.Text = "";
        }
    }
    protected void btnyawayiwredakted_Click(object sender, EventArgs e)
    {

        btnyawayiwredakted.BackColor = Color.Aquamarine;
        btnyawayiwelaved.BackColor = SystemColors.ButtonFace;
        btnyawayiwsild.BackColor = SystemColors.ButtonFace;

        pnlyawayiwelave.Visible = false;
        pnlyawayiwsil.Visible = false;
        lblyawayiwredakte.Text = "";

        pnlyawayiwredakte.Visible = true;
        regionyawayiwredakte();
        ddlyawayiwredreg.Items.Insert(0, new ListItem("Seçin", "0"));


        yawayiwredakte();
        ddlyawayiwredakte.Items.Insert(0, new ListItem("Seçin", "0"));

        yawayiwtyperedakte();
        ddlyawayiwtype.Items.Insert(0, new ListItem("Seçin", "0"));
        txtyawayiwredakte.Text = "";
        ddlregyawayiwelave.Enabled = true;
        ddlyawayiwredakte.Enabled = false;
        ddlyawayiwtype.Enabled = false;
        txtyawayiwredakte.Enabled = false;
        btnyawayiwredakte.Enabled = false;
    }
    protected void ddlyawayiwredreg_SelectedIndexChanged(object sender, EventArgs e)
    {
        yawayiwredakte();
        ddlyawayiwredakte.Items.Insert(0, new ListItem("Seçin", "0"));
        ddlyawayiwredakte.Enabled = true;
        ddlyawayiwtype.Enabled = false;
        txtyawayiwredakte.Enabled = false;
        btnyawayiwredakte.Enabled = false;
        txtyawayiwredakte.Text = "";
    }
    protected void btnyawayiwredakte_Click(object sender, EventArgs e)
    {
        //DataRow drrayon = klas.GetDataRow("Select * from List_SubRegions Where Name=N'" + txtyawayiwredakte.Text + "' and RegionID='" + ddlyawayiwredreg.SelectedValue + "'");
   //  && drrayon==null
        if (ddlyawayiwtype.SelectedValue != "0" && txtyawayiwredakte.Text != "" )
        {
            SqlConnection baglanti = klas.baglan();
            SqlCommand cmd = new SqlCommand("Update List_SubRegions Set Name=@Name,TypeID=@TypeID Where CityID=" + ddlyawayiwredakte.SelectedValue, baglanti);
            cmd.Parameters.Add("Name", txtyawayiwredakte.Text);
            cmd.Parameters.Add("TypeID", ddlyawayiwtype.SelectedValue);
            cmd.ExecuteNonQuery();
            lblyawayiwredakte.Text = "Dəyişiklik qeydə alındı";
            lblyawayiwredakte.ForeColor = Color.Green;
            yawayiwredakte();
            ddlyawayiwredakte.Items.Insert(0, new ListItem("Seçin", "0"));
            txtyawayiwredakte.Text = "";
            yawayiwtyperedakte();
            ddlyawayiwtype.Items.Insert(0, new ListItem("Seçin", "0"));
            Response.Redirect("Yasayismen.aspx");
        }
        else
        {
            if (ddlyawayiwtype.SelectedValue == "0")
            {
                lblyawayiwredakte.Text = "Tip seçməmisiniz";
            }
            if (txtyawayiwredakte.Text == "")
            {
                lblyawayiwredakte.Text = "Yawayiş məntəqəsi boşluq ola bilməz";
            }
            //if (drrayon != null) {
            //    lblyawayiwredakte.Text = "Bu ad bazada var";
            //}
            lblyawayiwredakte.ForeColor = Color.Red;
        }
    }

    protected void ddlyawayiwredakte_SelectedIndexChanged(object sender, EventArgs e)
    {

        if (ddlyawayiwredakte.SelectedValue != "0")
        {
            string a = klas.getdatacell("select Name from List_SubRegions where CityID=" + ddlyawayiwredakte.SelectedValue);
            txtyawayiwredakte.Text = a;
           
            txtyawayiwredakte.Enabled = true;
            yawayiwtyperedakte();
            ddlyawayiwtype.Items.Insert(0, new ListItem("Seçin", "0"));
            ddlyawayiwtype.Enabled = true;
        }
        else
        {
            txtyawayiwredakte.Text = "";
        }

    }
    protected void ddlyawayiwtype_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtyawayiwredakte.Enabled = true;
        btnyawayiwredakte.Enabled = true;
        if (ddlyawayiwtype.SelectedValue == "0")
        {
            btnyawayiwredakte.Enabled = false;
        }
    }
    protected void btnyawayiwsild_Click(object sender, EventArgs e)
    {
        btnyawayiwsil.Enabled = false;
        btnyawayiwsild.BackColor = Color.Aquamarine;
        btnyawayiwelaved.BackColor = SystemColors.ButtonFace;
        btnyawayiwredakted.BackColor = SystemColors.ButtonFace;

        lblyawayiwsil.Text = "";
        pnlyawayiwelave.Visible = false;
        pnlyawayiwredakte.Visible = false;
        pnlyawayiwsil.Visible = true;

        regionyawayiwsil();
        ddlregyawayiwsil.Items.Insert(0, new ListItem("Seçin", "0"));

        yawayiwsil();
        ddlyawayiwsil.Items.Insert(0, new ListItem("Seçin", "0"));
    }
    protected void ddlregyawayiwsil_SelectedIndexChanged(object sender, EventArgs e)
    {
        yawayiwsil();
        ddlyawayiwsil.Items.Insert(0, new ListItem("Seçin", "0"));
    }
    protected void btnyawayiwsil_Click(object sender, EventArgs e)
    {
        if (ddlyawayiwsil.SelectedValue != "0" && ddlregyawayiwsil.SelectedValue != "0")
        {
            btnyawayiwsil.Enabled = false;

            SqlConnection baglanti = klas.baglan();
            SqlCommand cmd = new SqlCommand("Update List_SubRegions Set ForDelete=0 Where CityID=" + ddlyawayiwsil.SelectedValue, baglanti);
            cmd.ExecuteNonQuery();


            lblyawayiwsil.Text = "Yaşayış məntəqəsi silindi";
            lblyawayiwsil.ForeColor = Color.Green;
            Response.Redirect("Yasayismen.aspx");
        }
        else
        {
            lblyawayiwsil.Text = "Yaşayış məntəqəsi seçilməyib";
            lblyawayiwsil.ForeColor = Color.Red;
        }
        yawayiwsil();
        ddlyawayiwsil.Items.Insert(0, new ListItem("Seçin", "0"));
    }

    protected void btnOkay_Click(object sender, EventArgs e)
    {
       
    }
    protected void btnelavegeri_Click(object sender, EventArgs e)
    {
        btngeri.Enabled = false;
        btnrayon.BackColor = SystemColors.ButtonFace;
        btnihb.BackColor = SystemColors.ButtonFace;
        btnyawayiw.BackColor = SystemColors.ButtonFace;
        btnrayon.Enabled = true;
        btnihb.Enabled = true;
        btnyawayiw.Enabled = true;
        pnlrayon.Visible = false;
        pnlihb.Visible = false;
        pnlyawayiw.Visible = false;
    }
    protected void btniedsil_Click(object sender, EventArgs e)
    {
      
    }
    protected void btnyayiw_Click(object sender, EventArgs e)
    {
        
    }
    protected void ddlrayonsil_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlrayonsil.SelectedValue != "0")
        {
            btnrayonsil.Enabled = true;

        }
        else
        {
            btnrayonsil.Enabled = false;
        }
    }
    protected void ddlihbsil_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlihbsil.SelectedValue != "0")
        {
            btnihbsil.Enabled = true;

        }
        else
        {
            btnihbsil.Enabled = false;
        }
    }
    protected void ddlyawayiwsil_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlyawayiwsil.SelectedValue != "0")
        {
            btnyawayiwsil.Enabled = true;

        }
        else
        {
            btnyawayiwsil.Enabled = false;
        }
    }
}