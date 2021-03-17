using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class adminpanel_Iqtisadisahibkar : System.Web.UI.Page
{
    Class2 klas = new Class2();
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Page.IsPostBack == false)
        {
            LinkButton lblvizual1 = (LinkButton)Master.Master.FindControl("Tesnifatlar");
            lblvizual1.BackColor = Color.Peru;
            ContentPlaceHolder cp = this.Master.Master.FindControl("ContentPlaceHolder1") as ContentPlaceHolder;
            LinkButton tb = cp.FindControl("lbiqtisadisahib") as LinkButton;
            tb.BackColor = Color.Brown;
        }
    }

    void meqsedyeri()
    {
        DataTable meqsed = klas.getdatatable("Select ClassifID,ClassifName,ListID from List_classifications_SHablon where ListID=11 order by SortA_Z");
        ddlobject.DataTextField = "ClassifName";
        ddlobject.DataValueField = "ClassifID";
        ddlobject.DataSource = meqsed;
        ddlobject.DataBind();
    }
    void ihbredakte1()
    {
        DataTable dtilceler = klas.getdatatable("Select * from List_SubClassifictions_SHablon Where MainClassifId=" + ddlicra.SelectedValue + " order by [sort]");
        ddlvezife.DataTextField = "ClassificationName";
        ddlvezife.DataValueField = "ClassifID";
        ddlvezife.DataSource = dtilceler;
        ddlvezife.DataBind();
        ddlvezife.Items.Insert(0, new ListItem("Seçin", "0"));
        ddlvezife.SelectedValue = "0";
    }
    void ihbredakte12()
    {
        DataTable dtilceler = klas.getdatatable("Select * from List_SubClassifictions_SHablon Where MainClassifId=" + ddlicra.SelectedValue + " order by [sort]");
        ddlyer.DataTextField = "ClassificationName";
        ddlyer.DataValueField = "ClassifID";
        ddlyer.DataSource = dtilceler;
        ddlyer.DataBind();
        ddlyer.Items.Insert(0, new ListItem("Seçin", "-1"));
        ddlyer.Items.Insert(1, new ListItem("Əvvələ", "0"));
    }
    void meqsedyeriredakte()
    {
        DataTable meqsed = klas.getdatatable("Select ClassifID,ClassifName,ListID from List_classifications_SHablon where ListID=11 order by SortA_Z");
        ddlyeri.DataTextField = "ClassifName";
        ddlyeri.DataValueField = "ClassifID";
        ddlyeri.DataSource = meqsed;
        ddlyeri.DataBind();
    }


    void meqsedsort()
    {
        DataTable meqsed = klas.getdatatable("Select ClassifID,ClassifName,ListID from List_classifications_SHablon where ListID=11 order by SortA_Z");
        ddlmeqsedsort.DataTextField = "ClassifName";
        ddlmeqsedsort.DataValueField = "ClassifID";
        ddlmeqsedsort.DataSource = meqsed;
        ddlmeqsedsort.DataBind();
    }

    void regionihb()
    {
        DataTable dtiller = klas.getdatatable("Select ClassifID,ClassifName,ListID from List_classifications_SHablon where ListID=11 order by SortA_Z");
        ddlihbrayonelave.DataTextField = "ClassifName";
        ddlihbrayonelave.DataValueField = "ClassifID";
        ddlihbrayonelave.DataSource = dtiller;
        ddlihbrayonelave.DataBind();
    }

    void rayonihbredakte()
    {
        DataTable dtiller2 = klas.getdatatable("Select ClassifID,ClassifName,ListID from List_classifications_SHablon where ListID=11 order by SortA_Z");
        ddlihbrayonredakte.DataTextField = "ClassifName";
        ddlihbrayonredakte.DataValueField = "ClassifID";
        ddlihbrayonredakte.DataSource = dtiller2;
        ddlihbrayonredakte.DataBind();
    }
    void rayonihbredakte1()
    {
        DataTable dtiller2 = klas.getdatatable("Select ClassifID,ClassifName,ListID from List_classifications_SHablon where ListID=11 order by SortA_Z");
        ddlicra.DataTextField = "ClassifName";
        ddlicra.DataValueField = "ClassifID";
        ddlicra.DataSource = dtiller2;
        ddlicra.DataBind();
        ddlicra.Items.Insert(0, new ListItem("Seçin", "0"));
    }

    void ihbredakte()
    {
        DataTable dtilceler = klas.getdatatable("Select * from List_SubClassifictions_SHablon Where MainClassifId=" + ddlihbrayonredakte.SelectedValue + " order by [sort]");
        ddlihbredakte.DataTextField = "ClassificationName";
        ddlihbredakte.DataValueField = "ClassifID";
        ddlihbredakte.DataSource = dtilceler;
        ddlihbredakte.DataBind();
    }
    void ihbsort()
    {
        DataTable dtilceler = klas.getdatatable("Select * from List_SubClassifictions_SHablon Where MainClassifId=" + ddlihbrayonelave.SelectedValue + " order by [sort]");
        ddlmovqe.DataTextField = "ClassificationName";
        ddlmovqe.DataValueField = "ClassifID";
        ddlmovqe.DataSource = dtilceler;
        ddlmovqe.DataBind();
    }
    void rayonihbsil()
    {
        DataTable dtiller2 = klas.getdatatable("Select ClassifID,ClassifName,ListID from List_classifications_SHablon where ListID=11 order by SortA_Z");
        ddlihbraysil.DataTextField = "ClassifName";
        ddlihbraysil.DataValueField = "ClassifID";
        ddlihbraysil.DataSource = dtiller2;
        ddlihbraysil.DataBind();
    }
    void ihbsil()
    {
        DataTable dtilceler = klas.getdatatable("Select * from List_SubClassifictions_SHablon Where MainClassifId=" + ddlihbraysil.SelectedValue + " order by [sort]");
        ddlihbsil.DataTextField = "ClassificationName";
        ddlihbsil.DataValueField = "ClassifID";
        ddlihbsil.DataSource = dtilceler;
        ddlihbsil.DataBind();
    }




    void meqsedredakte()
    {
        DataTable meqsed = klas.getdatatable("Select ClassifID,ClassifName,ListID from List_classifications_SHablon where ListID=11 order by SortA_Z");
        ddlmeqsedredakte.DataTextField = "ClassifName";
        ddlmeqsedredakte.DataValueField = "ClassifID";
        ddlmeqsedredakte.DataSource = meqsed;
        ddlmeqsedredakte.DataBind();
    }
    void meqsedsil()
    {
        DataTable meqsed = klas.getdatatable("Select ClassifID,ClassifName,ListID from List_classifications_SHablon where ListID=11 order by SortA_Z");
        ddlmeqsedsil.DataTextField = "ClassifName";
        ddlmeqsedsil.DataValueField = "ClassifID";
        ddlmeqsedsil.DataSource = meqsed;
        ddlmeqsedsil.DataBind();
    }
    protected void btnelave_Click(object sender, EventArgs e)
    {
        meqsedsort();
        ddlmeqsedsort.Items.Insert(0, new ListItem("Seçin", "-1"));
        ddlmeqsedsort.Items.Insert(1, new ListItem("Əvvələ", "0"));

        btnelave.BackColor = Color.Aquamarine;
        btnredakte.BackColor = SystemColors.ButtonFace;
        btnsil.BackColor = SystemColors.ButtonFace;
        pnlinsertmeqsed.Visible = true;
        pnlsil.Visible = false;
        pnlupdatemeqsed.Visible = false;
        lblmeqsedelave.Text = "";
        txtmeqsedelave.Text = "";
    }
    protected void btnredakte_Click(object sender, EventArgs e)
    {

        btnredakte.BackColor = Color.Aquamarine;
        btnelave.BackColor = SystemColors.ButtonFace;
        btnsil.BackColor = SystemColors.ButtonFace;
        txtmeqsedredakte.Text = "";
        lblmeqsedredakte.Text = "";
        pnlupdatemeqsed.Visible = true;
        pnlinsertmeqsed.Visible = false;
        pnlsil.Visible = false;
        meqsedredakte();
        ddlmeqsedredakte.Items.Insert(0, new ListItem("Seçin", "0"));

        btnmeqsedred.BackColor = SystemColors.ButtonFace;
        btntesnyeri.BackColor = SystemColors.ButtonFace;
        pnlyerdeyiw.Visible = false;
        pnlmqsd.Visible = false;
    }
    protected void btnsil_Click(object sender, EventArgs e)
    {
        btnsil.BackColor = Color.Aquamarine;
        btnelave.BackColor = SystemColors.ButtonFace;
        btnredakte.BackColor = SystemColors.ButtonFace;
        lblmeqsedsil.Text = "";
        pnlupdatemeqsed.Visible = false;
        pnlinsertmeqsed.Visible = false;
        pnlsil.Visible = true;
        meqsedsil();
        ddlmeqsedsil.Items.Insert(0, new ListItem("Seçin", "0"));

    }

    protected void btnsaxlaredakte_Click(object sender, EventArgs e)
    {
        DataRow drrayon = klas.GetDataRow("Select ClassifID,ClassifName,ListID from List_classifications_SHablon where ListID=11  and ClassifName=N'" + txtmeqsedredakte.Text + "'");

        if (ddlmeqsedredakte.SelectedValue != "0" && txtmeqsedredakte.Text != "" && drrayon == null)
        {
            SqlConnection baglanti = klas.baglan();
            SqlCommand cmd = new SqlCommand("Update List_classifications_SHablon Set ClassifName=@ClassifName Where ListID=11 and ClassifID=" + ddlmeqsedredakte.SelectedValue, baglanti);
            cmd.Parameters.Add("ClassifName", txtmeqsedredakte.Text);
            cmd.ExecuteNonQuery();
            lblmeqsedredakte.Text = "Dəyişiklik qeydə alındı";
            lblmeqsedredakte.ForeColor = Color.Green;
            meqsedredakte();
            ddlmeqsedredakte.Items.Insert(0, new ListItem("Seçin", "0"));
            txtmeqsedredakte.Text = "";
            Response.Redirect("Iqtisadisahibkar.aspx");
        }
        else
        {
            if (ddlmeqsedredakte.SelectedValue == "0")
            {
                lblmeqsedredakte.Text = "İqtisadi və sahibkarlıq sahə seçməmisiniz";
            }
            if (txtmeqsedredakte.Text == "")
            {
                lblmeqsedredakte.Text = "İqtisadi və sahibkarlıq sahə boşluq ola bilməz";
            }
            if (drrayon != null)
            {
                lblmeqsedredakte.Text = "Bu ad bazada var";
            }
            lblmeqsedredakte.ForeColor = Color.Red;
        }
    }
    protected void ddlmeqsedredakte_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlmeqsedredakte.SelectedValue != "0")
        {
            txtmeqsedredakte.Text = ddlmeqsedredakte.SelectedItem.Text;
        }
        else
        {
            txtmeqsedredakte.Text = "";
        }
    }
    protected void btnmeqsedelave_Click(object sender, EventArgs e)
    {
        DataRow classifid;
        string classifid1;
        if (txtmeqsedelave.Text != "")
        {
            DataRow drrayon = klas.GetDataRow("Select ClassifID,ClassifName,ListID from List_classifications_SHablon where ListID=11 and ClassifName=N'" + txtmeqsedelave.Text + "'");
            if (drrayon == null && ddlmeqsedsort.SelectedValue != "-1")
            {
                if (ddlmeqsedsort.SelectedValue != "0")
                {
                    classifid = klas.GetDataRow("Select * from List_classifications_SHablon where ListID=11 and ClassifID='" + ddlmeqsedsort.SelectedValue + "'");
                    classifid1 = classifid["SortA_Z"].ToString();
                }
                else
                {
                    classifid = klas.GetDataRow("Select MIN(SortA_Z) as SortA_Z from List_classifications_SHablon Where ListID=11");
                    //int.Parse(classifid.ToString()) - 1;
                    classifid1 = (int.Parse(classifid["SortA_Z"].ToString()) - 1).ToString();

                }
                int secilmiwsortid = int.Parse(classifid1.ToString());
                DataTable sorthamisi = klas.getdatatable("Select * from List_classifications_SHablon Where ListID=11");
                for (int i = 0; i < sorthamisi.Rows.Count; i++)
                {
                    if (secilmiwsortid < int.Parse(sorthamisi.Rows[i]["SortA_Z"].ToString()))
                    {
                        int a1 = int.Parse(sorthamisi.Rows[i]["SortA_Z"].ToString()) + 1;
                        int a = int.Parse(sorthamisi.Rows[i]["SortA_Z"].ToString());
                        int classif = int.Parse(sorthamisi.Rows[i]["ClassifID"].ToString());
                        SqlConnection baglanti = klas.baglan();
                        SqlCommand cmd1 = new SqlCommand("Update List_classifications_SHablon Set SortA_Z=@SortA_Z Where ListID=11 and SortA_Z='" + a.ToString() + "' and ClassifID='" + classif.ToString() + "'", baglanti);
                        cmd1.Parameters.Add("SortA_Z", a1);
                        cmd1.ExecuteNonQuery();
                    }
                }

                SqlConnection baglanti1 = klas.baglan();
                SqlCommand cmd = new SqlCommand("Insert into List_classifications_SHablon (ClassifName,ListID,SortA_Z) values(@ClassifName,@ListID,@SortA_Z)", baglanti1);
                cmd.Parameters.Add("ClassifName", txtmeqsedelave.Text);
                cmd.Parameters.Add("ListID", 11);
                cmd.Parameters.Add("SortA_Z", int.Parse(classifid1.ToString()) + 1);
                cmd.ExecuteNonQuery();
                lblmeqsedelave.Text = "İqtisadi və sahibkarlıq sahə əlavə edildi";
                lblmeqsedelave.ForeColor = Color.Green;
                txtmeqsedelave.Text = "";
                meqsedsort();
                ddlmeqsedsort.Items.Insert(0, new ListItem("Seçin", "-1"));
                ddlmeqsedsort.Items.Insert(1, new ListItem("Əvvələ", "0"));
                Response.Redirect("Iqtisadisahibkar.aspx");
            }
            else
            {
                if (drrayon != null)
                {
                    lblmeqsedelave.Text = "Elavə etmək istədiyiniz  artıq bazada var";
                    lblmeqsedelave.ForeColor = Color.Red;
                }
                if (ddlmeqsedsort.SelectedValue == "-1")
                {
                    lblmeqsedelave.Text = "Mövqe seçilməyib";
                    lblmeqsedelave.ForeColor = Color.Red;
                }

            }
        }
        else
        {
            lblmeqsedelave.Text = "İqtisadi və sahibkarlıq sahə adı boşluq ola bilməz";
            lblmeqsedelave.ForeColor = Color.Red;
        }
    }
    protected void btnmeqsedsil_Click(object sender, EventArgs e)
    {
        if (ddlmeqsedsil.SelectedValue != "0")
        {
            DataRow classifid;
            string classifid1;
            classifid = klas.GetDataRow("Select * from List_classifications_SHablon where ListID=11 and ClassifID='" + ddlmeqsedsil.SelectedValue + "'");
            classifid1 = classifid["SortA_Z"].ToString();
            int secilmiwsortid = int.Parse(classifid1.ToString());

            DataTable sorthamisi = klas.getdatatable("Select * from List_classifications_SHablon where ListID=11");
            for (int i = 0; i < sorthamisi.Rows.Count; i++)
            {
                if (secilmiwsortid < int.Parse(sorthamisi.Rows[i]["SortA_Z"].ToString()))
                {
                    int a1 = int.Parse(sorthamisi.Rows[i]["SortA_Z"].ToString()) - 1;
                    int a = int.Parse(sorthamisi.Rows[i]["SortA_Z"].ToString());
                    int classif = int.Parse(sorthamisi.Rows[i]["ClassifID"].ToString());
                    SqlConnection baglanti = klas.baglan();
                    SqlCommand cmd1 = new SqlCommand("Update List_classifications_SHablon Set SortA_Z=@SortA_Z Where ListID=11 and SortA_Z='" + a.ToString() + "' and ClassifID='" + classif.ToString() + "'", baglanti);
                    cmd1.Parameters.Add("SortA_Z", a1);
                    cmd1.ExecuteNonQuery();
                }

            }

            btnmeqsedsil.Enabled = false;
            klas.cmd("Delete from List_classifications_SHablon  Where ListID=11 and ClassifID=" + ddlmeqsedsil.SelectedValue);
            lblmeqsedsil.Text = "Silindi";
            lblmeqsedsil.ForeColor = Color.Green;
            Response.Redirect("Iqtisadisahibkar.aspx");
        }
        else
        {
            lblmeqsedsil.Text = "Seçilməyib";
            lblmeqsedsil.ForeColor = Color.Red;
        }
        meqsedsil();
        ddlmeqsedsil.Items.Insert(0, new ListItem("Seçin", "0"));
    }
    protected void btngeri_Click(object sender, EventArgs e)
    {

        btnobyekt.BackColor = SystemColors.ButtonFace;
        btnistismar.BackColor = SystemColors.ButtonFace;
        pnlbirinci.Visible = false;
        btnobyekt.Enabled = true;
        pnlinsertmeqsed.Visible = false;
        pnlupdatemeqsed.Visible = false;
        pnlsil.Visible = false;
        btnelave.Enabled = true;
        btnredakte.Enabled = true;
        btnsil.Enabled = true;
        btnelave.BackColor = SystemColors.ButtonFace;
        btnredakte.BackColor = SystemColors.ButtonFace;
        btnsil.BackColor = SystemColors.ButtonFace;
    }
    protected void btnistismar_Click(object sender, EventArgs e)
    {
        btnistismar.BackColor = Color.GreenYellow;
        btnobyekt.BackColor = SystemColors.ButtonFace;
        btnobyekt.Enabled = false;
        pnlbirinci.Visible = true;
        pnlikinci.Visible = false;
    }
    protected void btnobyekt_Click(object sender, EventArgs e)
    {
        btnobyekt.BackColor = Color.GreenYellow;
        btnistismar.BackColor = SystemColors.ButtonFace;
        btnistismar.Enabled = false;
        pnlbirinci.Visible = false;
        pnlikinci.Visible = true;
        pnldeyis.Visible = false;
    }
    protected void btnihbelave_Click(object sender, EventArgs e)
    {

        DataRow classifid;
        string classifid1;
        if (txtihbelave.Text != "" && ddlihbrayonelave.SelectedValue != "0")
        {
            DataRow drrayon = klas.GetDataRow("Select * from List_SubClassifictions_SHablon Where MainClassifId='" + ddlihbrayonelave.SelectedValue + "' and  ClassificationName=N'" + txtihbelave.Text + "' order by [ClassificationName]");
            if (drrayon == null && ddlmovqe.SelectedValue != "-1")
            {
                if (ddlmovqe.SelectedValue != "0")
                {
                    classifid = klas.GetDataRow("Select * from List_SubClassifictions_SHablon Where MainClassifId='" + ddlihbrayonelave.SelectedValue + "' and ClassifID='" + ddlmovqe.SelectedValue + "'");
                    classifid1 = classifid["sort"].ToString();
                }
                else
                {
                    classifid = klas.GetDataRow("Select MIN(sort) as sort from List_SubClassifictions_SHablon Where MainClassifId=" + ddlihbrayonelave.SelectedValue);
                    //int.Parse(classifid.ToString()) - 1;
                    classifid1 = (int.Parse(classifid["sort"].ToString()) - 1).ToString();

                }
                int secilmiwsortid = int.Parse(classifid1.ToString());
                DataTable sorthamisi = klas.getdatatable("Select * from List_SubClassifictions_SHablon Where MainClassifId=" + ddlihbrayonelave.SelectedValue);
                for (int i = 0; i < sorthamisi.Rows.Count; i++)
                {
                    if (secilmiwsortid < int.Parse(sorthamisi.Rows[i]["sort"].ToString()))
                    {
                        int a1 = int.Parse(sorthamisi.Rows[i]["sort"].ToString()) + 1;
                        int a = int.Parse(sorthamisi.Rows[i]["sort"].ToString());
                        int classif = int.Parse(sorthamisi.Rows[i]["ClassifID"].ToString());
                        SqlConnection baglanti = klas.baglan();
                        SqlCommand cmd1 = new SqlCommand("Update List_SubClassifictions_SHablon Set sort=@sort Where MainClassifId='" + ddlihbrayonelave.SelectedValue + "' and sort='" + a.ToString() + "' and ClassifID='" + classif.ToString() + "'", baglanti);
                        cmd1.Parameters.Add("sort", a1);
                        cmd1.ExecuteNonQuery();
                    }
                }

                SqlConnection baglanti1 = klas.baglan();
                SqlCommand cmd = new SqlCommand("Insert into List_SubClassifictions_SHablon (ClassificationName,MainClassifId,sort) values(@ClassificationName,@MainClassifId,@sort)", baglanti1);
                cmd.Parameters.Add("ClassificationName", txtihbelave.Text);
                cmd.Parameters.Add("MainClassifId", int.Parse(ddlihbrayonelave.SelectedValue));
                cmd.Parameters.Add("sort", int.Parse(classifid1.ToString()) + 1);
                cmd.ExecuteNonQuery();
                lblihbelave.Text = "İqtisadi və sahibkarlıq sahə əlavə edildi";
                lblihbelave.ForeColor = Color.Green;
                txtihbelave.Text = "";
                ihbsort();
                ddlmovqe.Items.Insert(0, new ListItem("Seçin", "-1"));
                ddlmovqe.Items.Insert(1, new ListItem("Əvvələ", "0"));
                Response.Redirect("Iqtisadisahibkar.aspx");
            }
            else
            {
                if (drrayon != null)
                {
                    lblihbelave.Text = "Elavə etmək istədiyiniz artıq bazada var";
                    lblihbelave.ForeColor = Color.Red;
                }
                if (ddlmovqe.SelectedValue == "-1")
                {
                    lblihbelave.Text = "Mövqe seçilməyib";
                    lblihbelave.ForeColor = Color.Red;
                }

            }
        }
        else
        {
            lblihbelave.Text = "İqtisadi və sahibkarlıq sahə boşluq ola bilməz";
            lblihbelave.ForeColor = Color.Red;
        }




    }
    protected void btnihbredakte_Click(object sender, EventArgs e)
    {
        DataRow drrayon = klas.GetDataRow("Select * from List_SubClassifictions_SHablon Where ClassifID='" + ddlihbredakte.SelectedValue + "' and ClassificationName=N'" + txtihbredakte.Text + "'");

        if (ddlihbredakte.SelectedValue != "0" && txtihbredakte.Text != "" && drrayon == null)
        {
            SqlConnection baglanti = klas.baglan();
            SqlCommand cmd = new SqlCommand("Update List_SubClassifictions_SHablon Set ClassificationName=@ClassificationName Where ClassifID=" + ddlihbredakte.SelectedValue, baglanti);
            cmd.Parameters.Add("ClassificationName", txtihbredakte.Text);
            cmd.ExecuteNonQuery();
            lblihbredakte.Text = "Dəyişiklik qeydə alındı";
            lblihbredakte.ForeColor = Color.Green;
            ihbredakte();
            ddlihbredakte.Items.Insert(0, new ListItem("Seçin", "0"));
            txtihbredakte.Text = "";
            Response.Redirect("Iqtisadisahibkar.aspx");

        }
        else
        {
            if (ddlihbredakte.SelectedValue == "0")
            {
                lblihbredakte.Text = "İqtisadi və sahibkarlıq sahə seçməmisiniz";
            }
            if (txtihbredakte.Text == "")
            {
                lblihbredakte.Text = "İqtisadi və sahibkarlıq sahə adı boşluq ola bilməz";
            }
            if (drrayon != null)
            {
                lblihbredakte.Text = "Bu ad bazada var";
            }
            lblihbredakte.ForeColor = Color.Red;
        }
    }
    protected void btnihbsil_Click(object sender, EventArgs e)
    {
        if (ddlihbsil.SelectedValue != "0" && ddlihbraysil.SelectedValue != "0")
        {
            DataRow classifid;
            string classifid1;
            classifid = klas.GetDataRow("Select * from List_SubClassifictions_SHablon Where MainClassifId='" + ddlihbraysil.SelectedValue + "' and ClassifID='" + ddlihbsil.SelectedValue + "'");
            classifid1 = classifid["sort"].ToString();
            int secilmiwsortid = int.Parse(classifid1.ToString());

            DataTable sorthamisi = klas.getdatatable("Select * from List_SubClassifictions_SHablon Where MainClassifId=" + ddlihbraysil.SelectedValue);
            for (int i = 0; i < sorthamisi.Rows.Count; i++)
            {
                if (secilmiwsortid < int.Parse(sorthamisi.Rows[i]["sort"].ToString()))
                {
                    int a1 = int.Parse(sorthamisi.Rows[i]["sort"].ToString()) - 1;
                    int a = int.Parse(sorthamisi.Rows[i]["sort"].ToString());
                    int classif = int.Parse(sorthamisi.Rows[i]["ClassifID"].ToString());
                    SqlConnection baglanti = klas.baglan();
                    SqlCommand cmd1 = new SqlCommand("Update List_SubClassifictions_SHablon Set sort=@sort Where MainClassifId='" + ddlihbraysil.SelectedValue + "' and sort='" + a.ToString() + "' and ClassifID='" + classif.ToString() + "'", baglanti);
                    cmd1.Parameters.Add("sort", a1);
                    cmd1.ExecuteNonQuery();
                }
            }
            btnmeqsedsil.Enabled = false;
            klas.cmd("Delete from List_SubClassifictions_SHablon  Where ClassifID=" + ddlihbsil.SelectedValue);
            lblihbsil.Text = "İqtisadi və sahibkarlıq sahə silindi";
            lblihbsil.ForeColor = Color.Green;
            btnihbsil.Enabled = false;
            Response.Redirect("Iqtisadisahibkar.aspx");
        }
        else
        {
            lblihbsil.Text = "İqtisadi və sahibkarlıq sahə seçilməyib";
            lblihbsil.ForeColor = Color.Red;
        }
        ihbsil();
        ddlihbsil.Items.Insert(0, new ListItem("Seçin", "0"));

    }
    protected void btnihbelaved_Click(object sender, EventArgs e)
    {

        regionihb();
        ddlihbrayonelave.Items.Insert(0, new ListItem("Seçin", "0"));
        ihbsort();
        ddlmovqe.Items.Insert(0, new ListItem("Seçin", "-1"));

        ddlmovqe.Enabled = false;
        txtihbelave.Enabled = false;
        btnihbelave.Enabled = false;

        //pnlgeri.Visible = false;
        btnihbelaved.BackColor = Color.Aquamarine;
        btnihbredakted.BackColor = SystemColors.ButtonFace;
        btnihbsild.BackColor = SystemColors.ButtonFace;

        txtihbelave.Text = "";
        lblihbelave.Text = "";
        pnldeyis.Visible = false;
        pnlihbelave.Visible = true;
        pnlihbredakte.Visible = false;
        pnlihbsil.Visible = false;
    }
    protected void btnihbredakted_Click(object sender, EventArgs e)
    {
        // pnlgeri.Visible = false;

        btnmetndetish.BackColor = SystemColors.ButtonFace;
        btnyerdeyiw.BackColor = SystemColors.ButtonFace;
        btnihbredakted.BackColor = Color.Aquamarine;
        btnihbelaved.BackColor = SystemColors.ButtonFace;
        btnihbsild.BackColor = SystemColors.ButtonFace;

        txtihbredakte.Text = "";
        lblihbredakte.Text = "";

        pnldeyis.Visible = true;
        pnlihbredakte.Visible = false;
        pnlyerinideyiw.Visible = false;
        pnlihbsil.Visible = false;
        pnlihbelave.Visible = false;
        ddlihbredakte.Enabled = false;
        btnihbredakte.Enabled = false;


        rayonihbredakte();
        ddlihbrayonredakte.Items.Insert(0, new ListItem("Seçin", "0"));
        ihbredakte();
        ddlihbredakte.Items.Insert(0, new ListItem("Seçin", "0"));
    }
    protected void btnihbsild_Click(object sender, EventArgs e)
    {
        btnihbsil.Enabled = false;
        // pnlgeri.Visible = false;
        btnihbsild.BackColor = Color.Aquamarine;
        btnihbelaved.BackColor = SystemColors.ButtonFace;
        btnihbredakted.BackColor = SystemColors.ButtonFace;
        pnldeyis.Visible = false;
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
    protected void btnelavegeri_Click(object sender, EventArgs e)
    {
        btnobyekt.BackColor = SystemColors.ButtonFace;
        btnistismar.BackColor = SystemColors.ButtonFace;
        pnlikinci.Visible = false;
        btnistismar.Enabled = true;
        pnlikinci.Visible = false;
        pnlihbelave.Visible = false;
        pnlihbredakte.Visible = false;
        pnlihbsil.Visible = false;

        btnihbsild.BackColor = SystemColors.ButtonFace;
        btnihbredakted.BackColor = SystemColors.ButtonFace;
        btnihbelaved.BackColor = SystemColors.ButtonFace;
    }
    protected void ddlihbrayonelave_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlihbrayonelave.SelectedValue == "0")
        {
            ddlmovqe.Enabled = false;

        }
        else
        {
            ddlmovqe.Enabled = true;
        }
        txtihbelave.Text = "";
        btnihbelave.Enabled = false;
        txtihbelave.Enabled = false;
        ihbsort();
        ddlmovqe.Items.Insert(0, new ListItem("Seçin", "-1"));
        ddlmovqe.Items.Insert(1, new ListItem("Əvvələ", "0"));

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
        btnihbsil.Enabled = false;
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
    protected void btniedsil_Click(object sender, EventArgs e)
    {










        //if (ddlihbsil.SelectedValue != "0" && ddlihbraysil.SelectedValue != "0")
        //{
        //    btnihbsil.Enabled = false;
        //    klas.cmd("Delete from List_SubClassifictions Where ClassifID=" + ddlihbsil.SelectedValue);
        //    lblihbsil.Text = "Obyekt silindi";
        //    lblihbsil.ForeColor = Color.Aquamarine;
        //}
        //else
        //{
        //    lblihbsil.Text = "Obyekt seçilməyib";
        //    lblihbsil.ForeColor = Color.GreenYellow;
        //}
        //ihbsil();
        //ddlihbsil.Items.Insert(0, new ListItem("Seçin", "0"));
    }
    protected void btnOkay_Click(object sender, EventArgs e)
    {


    }
    protected void ddlmeqsedsil_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlmeqsedsil.SelectedValue == "0")
        {
            btnmeqsedsil.Enabled = false;
        }
        else
        {
            btnmeqsedsil.Enabled = true;
        }
    }
    protected void ddlmovqe_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlmovqe.SelectedValue == "-1")
        {
            btnihbelave.Enabled = false;
            txtihbelave.Enabled = false;
        }
        else
        {
            btnihbelave.Enabled = true;
            txtihbelave.Enabled = true;
        }
    }
    protected void btnmeqsedred_Click(object sender, EventArgs e)
    {
        txtmeqsedredakte.Text = "";
        lblmeqsedredakte.Text = "";
        meqsedredakte();
        ddlmeqsedredakte.Items.Insert(0, new ListItem("Seçin", "0"));
        btnmeqsedred.BackColor = Color.GreenYellow;
        btntesnyeri.BackColor = SystemColors.ButtonFace;
        pnlmqsd.Visible = true;
        pnlyerdeyiw.Visible = false;
    }
    protected void btntesnyeri_Click(object sender, EventArgs e)
    {
        lblyerdeyiw.Text = "";
        meqsedyeri();
        ddlobject.Items.Insert(0, new ListItem("Seçin", "0"));
        meqsedyeriredakte();
        ddlyeri.Items.Insert(0, new ListItem("Seçin", "-1"));
        ddlyeri.Items.Insert(1, new ListItem("Əvvələ", "0"));
        btntesnyeri.BackColor = Color.GreenYellow;
        btnmeqsedred.BackColor = SystemColors.ButtonFace;
        pnlyerdeyiw.Visible = true;
        pnlmqsd.Visible = false;
    }
    protected void btnyerinideyiw_Click(object sender, EventArgs e)
    {
        DataRow classifid;
        DataRow obyekt;
        string classifid1;
        string obyekt1;

        if (ddlyeri.SelectedValue != "-1" && ddlobject.SelectedValue != "0")
        {
            obyekt = klas.GetDataRow("Select * from List_classifications_SHablon Where ListID=11 and ClassifID='" + ddlobject.SelectedValue + "'");
            obyekt1 = obyekt["SortA_Z"].ToString();
            int objekt = int.Parse(obyekt1.ToString());
            //Response.Write(obyekt1);
            if (ddlyeri.SelectedValue != "0")
            {
                classifid = klas.GetDataRow("Select * from List_classifications_SHablon Where ListID=11 and ClassifID='" + ddlyeri.SelectedValue + "'");
                classifid1 = classifid["SortA_Z"].ToString();
            }
            else
            {
                classifid = klas.GetDataRow("Select MIN(SortA_Z) as SortA_Z from List_classifications_SHablon Where ListID=11");
                //int.Parse(classifid.ToString()) - 1;
                classifid1 = (int.Parse(classifid["SortA_Z"].ToString()) - 1).ToString();
            }
            //Response.Write(classifid1);
            int secilmiwsortid = int.Parse(classifid1.ToString());
            DataTable sorthamisi = klas.getdatatable("Select * from List_classifications_SHablon Where ListID=11");
            for (int i = 0; i < sorthamisi.Rows.Count; i++)
            {

                if ((secilmiwsortid >= int.Parse(sorthamisi.Rows[i]["SortA_Z"].ToString())) && (objekt < int.Parse(sorthamisi.Rows[i]["SortA_Z"].ToString())))
                {
                    int a1 = int.Parse(sorthamisi.Rows[i]["SortA_Z"].ToString()) - 1;
                    int a = int.Parse(sorthamisi.Rows[i]["SortA_Z"].ToString());
                    //Response.Write("a1=" + a1);
                    int classif = int.Parse(sorthamisi.Rows[i]["ClassifID"].ToString());
                    SqlConnection baglanti = klas.baglan();
                    SqlCommand cmd1 = new SqlCommand("Update List_classifications_SHablon Set SortA_Z=@SortA_Z Where ListID=11 and SortA_Z='" + a.ToString() + "' and ClassifID='" + classif.ToString() + "'", baglanti);
                    cmd1.Parameters.Add("SortA_Z", a1);
                    cmd1.ExecuteNonQuery();
                    //Response.Write("obyekt="+objekt.ToString());
                    //Response.Write("yer=" + classifid1.ToString());
                    SqlConnection baglanti1 = klas.baglan();
                    SqlCommand cmd12 = new SqlCommand("Update List_classifications_SHablon Set SortA_Z=@SortA_Z Where ListID=11 and SortA_Z='" + objekt.ToString() + "' and ClassifID='" + ddlobject.SelectedValue + "'", baglanti1);
                    cmd12.Parameters.Add("SortA_Z", classifid1);
                    cmd12.ExecuteNonQuery();

                }

                if ((secilmiwsortid < int.Parse(sorthamisi.Rows[i]["SortA_Z"].ToString())) && (objekt > int.Parse(sorthamisi.Rows[i]["SortA_Z"].ToString())))
                {
                    int a1 = int.Parse(sorthamisi.Rows[i]["SortA_Z"].ToString()) + 1;
                    int a = int.Parse(sorthamisi.Rows[i]["SortA_Z"].ToString());
                    // Response.Write("a1=" + a1);
                    int classif = int.Parse(sorthamisi.Rows[i]["ClassifID"].ToString());
                    SqlConnection baglanti = klas.baglan();
                    SqlCommand cmd1 = new SqlCommand("Update List_classifications_SHablon Set SortA_Z=@SortA_Z Where ListID=11 and SortA_Z='" + a.ToString() + "' and ClassifID='" + classif.ToString() + "'", baglanti);
                    cmd1.Parameters.Add("SortA_Z", a1);
                    cmd1.ExecuteNonQuery();
                    //Response.Write("obyekt="+objekt.ToString());
                    //Response.Write("yer=" + classifid1.ToString());
                    SqlConnection baglanti1 = klas.baglan();
                    SqlCommand cmd12 = new SqlCommand("Update List_classifications_SHablon Set SortA_Z=@SortA_Z Where ListID=11 and SortA_Z='" + objekt.ToString() + "' and ClassifID='" + ddlobject.SelectedValue + "'", baglanti1);
                    cmd12.Parameters.Add("SortA_Z", (secilmiwsortid + 1).ToString());
                    cmd12.ExecuteNonQuery();

                }
            }


            lblyerdeyiw.ForeColor = Color.Green;
            txtmeqsedelave.Text = "";
            meqsedyeri();
            ddlobject.Items.Insert(0, new ListItem("Seçin", "0"));
            meqsedyeriredakte();
            ddlyeri.Items.Insert(0, new ListItem("Seçin", "-1"));
            ddlyeri.Items.Insert(1, new ListItem("Əvvələ", "0"));
            Response.Redirect("Iqtisadisahibkar.aspx");
        }
        else
        {

            if (ddlyeri.SelectedValue == "-1")
            {
                lblyerdeyiw.Text = "Mövqe seçilməyib";
                lblyerdeyiw.ForeColor = Color.Red;
            }
            if (ddlobject.SelectedValue == "0")
            {
                lblyerdeyiw.Text = "İqtisadi və sahibkarlıq sahə seçilməyib";
                lblyerdeyiw.ForeColor = Color.Red;
            }

        }
    }
    protected void btnmetndetish_Click(object sender, EventArgs e)
    {

        pnlihbsil.Visible = false;
        pnlihbelave.Visible = false;
        ddlihbredakte.Enabled = false;
        txtihbredakte.Enabled = false;
        btnihbredakte.Enabled = false;
        pnlihbredakte.Visible = true;
        pnlyerinideyiw.Visible = false;
        txtmeqsedredakte.Text = "";
        lblmeqsedredakte.Text = "";
        meqsedredakte();
        ddlmeqsedredakte.Items.Insert(0, new ListItem("Seçin", "0"));
        btnmetndetish.BackColor = Color.GreenYellow;
        btnyerdeyiw.BackColor = SystemColors.ButtonFace;
        txtihbredakte.Text = "";
        lblihbredakte.Text = "";
        rayonihbredakte();
        ddlihbrayonredakte.Items.Insert(0, new ListItem("Seçin", "0"));
        ihbredakte();
        ddlihbredakte.Items.Insert(0, new ListItem("Seçin", "0"));
    }
    protected void btnyerdeyiw_Click(object sender, EventArgs e)
    {
        btnyerdeyiw.BackColor = Color.GreenYellow;
        btnmetndetish.BackColor = SystemColors.ButtonFace;
        pnlyerinideyiw.Visible = true;
        pnlihbredakte.Visible = false;

        rayonihbredakte1();
        ihbredakte1();
        ihbredakte12();
        Label1.Text = "";

    }
    protected void ddlicra_SelectedIndexChanged(object sender, EventArgs e)
    {
        ihbredakte1();
        ihbredakte12();
        ddlyer.SelectedValue = "-1";
        btnihbredakte.Enabled = false;
        ddlihbredakte.Enabled = true;
        ddlyer.Enabled = true;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        DataRow classifid;
        DataRow obyekt;
        string classifid1;
        string obyekt1;

        if (ddlyer.SelectedValue != "-1" && ddlvezife.SelectedValue != "0")
        {
            obyekt = klas.GetDataRow("Select * from List_SubClassifictions_SHablon Where MainClassifId=" + ddlicra.SelectedValue + " and ClassifID='" + ddlvezife.SelectedValue + "'");
            obyekt1 = obyekt["sort"].ToString();
            int objekt = int.Parse(obyekt1.ToString());
            //Response.Write(obyekt1);
            if (ddlyer.SelectedValue != "0")
            {
                classifid = klas.GetDataRow("Select * from List_SubClassifictions_SHablon Where MainClassifId=" + ddlicra.SelectedValue + " and ClassifID='" + ddlyer.SelectedValue + "'");
                classifid1 = classifid["sort"].ToString();
            }
            else
            {
                classifid = klas.GetDataRow("Select MIN(sort) as sort from List_SubClassifictions_SHablon Where MainClassifId=" + ddlicra.SelectedValue + "");
                //int.Parse(classifid.ToString()) - 1;
                classifid1 = (int.Parse(classifid["sort"].ToString()) - 1).ToString();
            }
            //Response.Write(classifid1);
            int secilmiwsortid = int.Parse(classifid1.ToString());
            DataTable sorthamisi = klas.getdatatable("Select * from List_SubClassifictions_SHablon Where MainClassifId=" + ddlicra.SelectedValue + "");
            for (int i = 0; i < sorthamisi.Rows.Count; i++)
            {

                if ((secilmiwsortid >= int.Parse(sorthamisi.Rows[i]["sort"].ToString())) && (objekt < int.Parse(sorthamisi.Rows[i]["sort"].ToString())))
                {
                    int a1 = int.Parse(sorthamisi.Rows[i]["sort"].ToString()) - 1;
                    int a = int.Parse(sorthamisi.Rows[i]["sort"].ToString());
                    //Response.Write("a1=" + a1);
                    int classif = int.Parse(sorthamisi.Rows[i]["ClassifID"].ToString());
                    SqlConnection baglanti = klas.baglan();
                    SqlCommand cmd1 = new SqlCommand("Update List_SubClassifictions_SHablon Set sort=@sort Where MainClassifId=" + ddlicra.SelectedValue + " and sort='" + a.ToString() + "' and ClassifID='" + classif.ToString() + "'", baglanti);
                    cmd1.Parameters.Add("sort", a1);
                    cmd1.ExecuteNonQuery();
                    //Response.Write("obyekt="+objekt.ToString());
                    //Response.Write("yer=" + classifid1.ToString());
                    SqlConnection baglanti1 = klas.baglan();
                    SqlCommand cmd12 = new SqlCommand("Update List_SubClassifictions_SHablon Set sort=@sort Where MainClassifId=" + ddlicra.SelectedValue + " and sort='" + objekt.ToString() + "' and ClassifID='" + ddlvezife.SelectedValue + "'", baglanti1);
                    cmd12.Parameters.Add("sort", classifid1);
                    cmd12.ExecuteNonQuery();

                }

                if ((secilmiwsortid < int.Parse(sorthamisi.Rows[i]["sort"].ToString())) && (objekt > int.Parse(sorthamisi.Rows[i]["sort"].ToString())))
                {
                    int a1 = int.Parse(sorthamisi.Rows[i]["sort"].ToString()) + 1;
                    int a = int.Parse(sorthamisi.Rows[i]["sort"].ToString());
                    int classif = int.Parse(sorthamisi.Rows[i]["ClassifID"].ToString());
                    SqlConnection baglanti = klas.baglan();
                    SqlCommand cmd1 = new SqlCommand("Update List_SubClassifictions_SHablon Set sort=@sort Where MainClassifId=" + ddlicra.SelectedValue + " and sort='" + a.ToString() + "' and ClassifID='" + classif.ToString() + "'", baglanti);
                    cmd1.Parameters.Add("sort", a1);
                    cmd1.ExecuteNonQuery();
                    SqlConnection baglanti1 = klas.baglan();
                    SqlCommand cmd12 = new SqlCommand("Update List_SubClassifictions_SHablon Set sort=@sort Where MainClassifId=" + ddlicra.SelectedValue + " and sort='" + objekt.ToString() + "' and ClassifID='" + ddlvezife.SelectedValue + "'", baglanti1);
                    cmd12.Parameters.Add("sort", (secilmiwsortid + 1).ToString());
                    cmd12.ExecuteNonQuery();
                }
            }

            Label1.ForeColor = Color.Green;
            txtmeqsedelave.Text = "";
            meqsedyeri();
            ddlvezife.Items.Insert(0, new ListItem("Seçin", "0"));
            meqsedyeriredakte();

            Response.Redirect("Iqtisadisahibkar.aspx");
        }
        else
        {

            if (ddlyer.SelectedValue == "-1")
            {
                Label1.Text = "Mövqe seçilməyib";
                Label1.ForeColor = Color.Red;
            }
            if (ddlvezife.SelectedValue == "0")
            {
                Label1.Text = "Təyinat seçilməyib";
                Label1.ForeColor = Color.Red;
            }
        }
    }
}