using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class adminpanel_Ferdimeqsed : System.Web.UI.Page
{
    Class2 klas = new Class2();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            LinkButton lblvizual1 = (LinkButton)Master.Master.FindControl("Tesnifatlar");
            lblvizual1.BackColor = Color.Peru;
            ContentPlaceHolder cp = this.Master.Master.FindControl("ContentPlaceHolder1") as ContentPlaceHolder;
            LinkButton tb = cp.FindControl("Ferdimeqsed") as LinkButton;
            tb.BackColor = Color.Brown;
        }
    }
    void meqsedyeri()
    {
        DataTable meqsed = klas.getdatatable("Select ClassifID,ClassifName,ListID from List_classifications where ListID=43 order by sort");
        ddlobject.DataTextField = "ClassifName";
        ddlobject.DataValueField = "ClassifID";
        ddlobject.DataSource = meqsed;
        ddlobject.DataBind();
    }
    void meqsedyeriredakte()
    {
        DataTable meqsed = klas.getdatatable("Select ClassifID,ClassifName,ListID from List_classifications where ListID=43 order by sort");
        ddlyeri.DataTextField = "ClassifName";
        ddlyeri.DataValueField = "ClassifID";
        ddlyeri.DataSource = meqsed;
        ddlyeri.DataBind();
    }

    void meqsedredakte()
    {
        DataTable meqsed = klas.getdatatable("Select ClassifID,ClassifName,ListID from List_classifications where ListID=43 order by sort");
        ddlmeqsedredakte.DataTextField = "ClassifName";
        ddlmeqsedredakte.DataValueField = "ClassifID";
        ddlmeqsedredakte.DataSource = meqsed;
        ddlmeqsedredakte.DataBind();
    }
    void meqsedsort()
    {
        DataTable meqsed = klas.getdatatable("Select ClassifID,ClassifName,ListID from List_classifications where ListID=43 order by sort");
        ddlmeqsedsort.DataTextField = "ClassifName";
        ddlmeqsedsort.DataValueField = "ClassifID";
        ddlmeqsedsort.DataSource = meqsed;
        ddlmeqsedsort.DataBind();
    }
    void meqsedsil()
    {
        DataTable meqsed = klas.getdatatable("Select ClassifID,ClassifName,ListID from List_classifications where ListID=43 order by sort");
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

        btnredakte.Enabled = false;
        btnsil.Enabled = false;
        btngeri.Enabled = true;
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
        btnelave.Enabled = false;
        btnsil.Enabled = false;
        btngeri.Enabled = true;
        btnmeqsedred.BackColor = SystemColors.ButtonFace;
        btntesnyeri.BackColor = SystemColors.ButtonFace;
        pnlyerdeyiw.Visible = false;
        pnlmqsd.Visible = false;
        btnredakte.BackColor = Color.Aquamarine;
        btnelave.BackColor = SystemColors.ButtonFace;
        btnsil.BackColor = SystemColors.ButtonFace;

        pnlupdatemeqsed.Visible = true;
        pnlinsertmeqsed.Visible = false;
        pnlsil.Visible = false;




    }
    protected void btnsil_Click(object sender, EventArgs e)
    {
        btnelave.Enabled = false;
        btnredakte.Enabled = false;
        btngeri.Enabled = true;
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
        DataRow drrayon = klas.GetDataRow("Select * from List_classifications Where ListID=43 and ClassifName=N'" + txtmeqsedredakte.Text + "'");
        if (ddlmeqsedredakte.SelectedValue != "0" && txtmeqsedredakte.Text != "" && drrayon == null)
        {
            SqlConnection baglanti = klas.baglan();
            SqlCommand cmd = new SqlCommand("Update List_classifications Set ClassifName=@ClassifName Where ListID=43 and ClassifID=" + ddlmeqsedredakte.SelectedValue, baglanti);
            cmd.Parameters.Add("ClassifName", txtmeqsedredakte.Text);
            cmd.ExecuteNonQuery();
            lblmeqsedredakte.Text = "Dəyişiklik qeydə alındı";
            lblmeqsedredakte.ForeColor = Color.Green;
            meqsedredakte();
            ddlmeqsedredakte.Items.Insert(0, new ListItem("Seçin", "0"));
            txtmeqsedredakte.Text = "";
            Response.Redirect("Ferdimeqsed.aspx");
        }
        else
        {
            if (ddlmeqsedredakte.SelectedValue == "0")
            {
                lblmeqsedredakte.Text = "Məqsəd seçməmisiniz";
            }
            if (txtmeqsedredakte.Text == "")
            {
                lblmeqsedredakte.Text = "Məqsəd boşluq ola bilməz";
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
            DataRow drrayon = klas.GetDataRow("Select * from List_classifications Where ListID=43 and ClassifName=N'" + txtmeqsedelave.Text + "'");
            if (drrayon == null && ddlmeqsedsort.SelectedValue != "-1")
            {
                if (ddlmeqsedsort.SelectedValue != "0")
                {
                    classifid = klas.GetDataRow("Select * from List_classifications Where ListID=43 and ClassifID='" + ddlmeqsedsort.SelectedValue + "'");
                    classifid1 = classifid["sort"].ToString();
                }
                else
                {
                    classifid = klas.GetDataRow("Select MIN(sort) as sort from List_classifications Where ListID=43");
                    //int.Parse(classifid.ToString()) - 1;
                    classifid1 = (int.Parse(classifid["sort"].ToString()) - 1).ToString();

                }
                int secilmiwsortid = int.Parse(classifid1.ToString());
                DataTable sorthamisi = klas.getdatatable("Select * from List_classifications Where ListID=43");
                for (int i = 0; i < sorthamisi.Rows.Count; i++)
                {
                    if (secilmiwsortid < int.Parse(sorthamisi.Rows[i]["sort"].ToString()))
                    {
                        int a1 = int.Parse(sorthamisi.Rows[i]["sort"].ToString()) + 1;
                        int a = int.Parse(sorthamisi.Rows[i]["sort"].ToString());
                        int classif = int.Parse(sorthamisi.Rows[i]["ClassifID"].ToString());
                        SqlConnection baglanti = klas.baglan();
                        SqlCommand cmd1 = new SqlCommand("Update List_classifications Set sort=@sort Where ListID=43 and sort='" + a.ToString() + "' and ClassifID='" + classif.ToString() + "'", baglanti);
                        cmd1.Parameters.Add("sort", a1);
                        cmd1.ExecuteNonQuery();
                    }
                }

                SqlConnection baglanti1 = klas.baglan();
                SqlCommand cmd = new SqlCommand("Insert into List_classifications (ClassifName,ListID,sort) values(@ClassifName,@ListID,@sort)", baglanti1);
                cmd.Parameters.Add("ClassifName", txtmeqsedelave.Text);
                cmd.Parameters.Add("ListID", 43);
                cmd.Parameters.Add("sort", int.Parse(classifid1.ToString()) + 1);
                cmd.ExecuteNonQuery();
                lblmeqsedelave.Text = "Məqsəd əlavə edildi";
                lblmeqsedelave.ForeColor = Color.Green;
                txtmeqsedelave.Text = "";
                meqsedsort();
                ddlmeqsedsort.Items.Insert(0, new ListItem("Seçin", "-1"));
                ddlmeqsedsort.Items.Insert(1, new ListItem("Əvvələ", "0"));
                Response.Redirect("Ferdimeqsed.aspx");
            }
            else
            {
                if (drrayon != null)
                {
                    lblmeqsedelave.Text = "Elavə etmək istədiyiniz məqsəd artıq bazada var";
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
            lblmeqsedelave.Text = "Məqsəd adı boşluq ola bilməz";
            lblmeqsedelave.ForeColor = Color.Red;
        }
    }
    protected void btnmeqsedsil_Click(object sender, EventArgs e)
    {
        if (ddlmeqsedsil.SelectedValue != "0")
        {
            DataRow classifid;
            string classifid1;
            classifid = klas.GetDataRow("Select * from List_classifications Where ListID=43 and ClassifID='" + ddlmeqsedsil.SelectedValue + "'");
            classifid1 = classifid["sort"].ToString();
            int secilmiwsortid = int.Parse(classifid1.ToString());

            DataTable sorthamisi = klas.getdatatable("Select * from List_classifications Where ListID=43");
            for (int i = 0; i < sorthamisi.Rows.Count; i++)
            {
                if (secilmiwsortid < int.Parse(sorthamisi.Rows[i]["sort"].ToString()))
                {
                    int a1 = int.Parse(sorthamisi.Rows[i]["sort"].ToString()) - 1;
                    int a = int.Parse(sorthamisi.Rows[i]["sort"].ToString());
                    int classif = int.Parse(sorthamisi.Rows[i]["ClassifID"].ToString());
                    SqlConnection baglanti = klas.baglan();
                    SqlCommand cmd1 = new SqlCommand("Update List_classifications Set sort=@sort Where ListID=43 and sort='" + a.ToString() + "' and ClassifID='" + classif.ToString() + "'", baglanti);
                    cmd1.Parameters.Add("sort", a1);
                    cmd1.ExecuteNonQuery();
                }

            }

            btnmeqsedsil.Enabled = false;
            klas.cmd("Delete from List_classifications  Where ListID=43 and ClassifID=" + ddlmeqsedsil.SelectedValue);
            lblmeqsedsil.Text = "Məqsəd silindi";
            lblmeqsedsil.ForeColor = Color.Green;
            Response.Redirect("Ferdimeqsed.aspx");
        }
        else
        {
            lblmeqsedsil.Text = "Məqsəd seçilməyib";
            lblmeqsedsil.ForeColor = Color.Red;
        }
        meqsedsil();
        ddlmeqsedsil.Items.Insert(0, new ListItem("Seçin", "0"));
    }
    protected void btngeri_Click(object sender, EventArgs e)
    {
        btngeri.Enabled = false;
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
    protected void btnyerinideyiw_Click(object sender, EventArgs e)
    {
        DataRow classifid;
        DataRow obyekt;
        string classifid1;
        string obyekt1;

        if (ddlyeri.SelectedValue != "-1" && ddlobject.SelectedValue != "0")
        {
            obyekt = klas.GetDataRow("Select * from List_classifications Where ListID=43 and ClassifID='" + ddlobject.SelectedValue + "'");
            obyekt1 = obyekt["sort"].ToString();
            int objekt = int.Parse(obyekt1.ToString());
            //Response.Write(obyekt1);
            if (ddlyeri.SelectedValue != "0")
            {
                classifid = klas.GetDataRow("Select * from List_classifications Where ListID=43 and ClassifID='" + ddlyeri.SelectedValue + "'");
                classifid1 = classifid["sort"].ToString();
            }
            else
            {
                classifid = klas.GetDataRow("Select MIN(sort) as sort from List_classifications Where ListID=43");
                //int.Parse(classifid.ToString()) - 1;
                classifid1 = (int.Parse(classifid["sort"].ToString()) - 1).ToString();
            }
            //Response.Write(classifid1);
            int secilmiwsortid = int.Parse(classifid1.ToString());
            DataTable sorthamisi = klas.getdatatable("Select * from List_classifications Where ListID=43");
            for (int i = 0; i < sorthamisi.Rows.Count; i++)
            {

                if ((secilmiwsortid >= int.Parse(sorthamisi.Rows[i]["sort"].ToString())) && (objekt < int.Parse(sorthamisi.Rows[i]["sort"].ToString())))
                {
                    int a1 = int.Parse(sorthamisi.Rows[i]["sort"].ToString()) - 1;
                    int a = int.Parse(sorthamisi.Rows[i]["sort"].ToString());
                    //Response.Write("a1=" + a1);
                    int classif = int.Parse(sorthamisi.Rows[i]["ClassifID"].ToString());
                    SqlConnection baglanti = klas.baglan();
                    SqlCommand cmd1 = new SqlCommand("Update List_classifications Set sort=@sort Where ListID=43 and sort='" + a.ToString() + "' and ClassifID='" + classif.ToString() + "'", baglanti);
                    cmd1.Parameters.Add("sort", a1);
                    cmd1.ExecuteNonQuery();
                    //Response.Write("obyekt="+objekt.ToString());
                    //Response.Write("yer=" + classifid1.ToString());
                    SqlConnection baglanti1 = klas.baglan();
                    SqlCommand cmd12 = new SqlCommand("Update List_classifications Set sort=@sort Where ListID=43 and sort='" + objekt.ToString() + "' and ClassifID='" + ddlobject.SelectedValue + "'", baglanti1);
                    cmd12.Parameters.Add("sort", classifid1);
                    cmd12.ExecuteNonQuery();

                }

                if ((secilmiwsortid < int.Parse(sorthamisi.Rows[i]["sort"].ToString())) && (objekt > int.Parse(sorthamisi.Rows[i]["sort"].ToString())))
                {
                    int a1 = int.Parse(sorthamisi.Rows[i]["sort"].ToString()) + 1;
                    int a = int.Parse(sorthamisi.Rows[i]["sort"].ToString());
                    // Response.Write("a1=" + a1);
                    int classif = int.Parse(sorthamisi.Rows[i]["ClassifID"].ToString());
                    SqlConnection baglanti = klas.baglan();
                    SqlCommand cmd1 = new SqlCommand("Update List_classifications Set sort=@sort Where ListID=43 and sort='" + a.ToString() + "' and ClassifID='" + classif.ToString() + "'", baglanti);
                    cmd1.Parameters.Add("sort", a1);
                    cmd1.ExecuteNonQuery();
                    //Response.Write("obyekt="+objekt.ToString());
                    //Response.Write("yer=" + classifid1.ToString());
                    SqlConnection baglanti1 = klas.baglan();
                    SqlCommand cmd12 = new SqlCommand("Update List_classifications Set sort=@sort Where ListID=43 and sort='" + objekt.ToString() + "' and ClassifID='" + ddlobject.SelectedValue + "'", baglanti1);
                    cmd12.Parameters.Add("sort", (secilmiwsortid + 1).ToString());
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
            Response.Redirect("Ferdimeqsed.aspx");
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
                lblyerdeyiw.Text = "Məqsəd seçilməyib";
                lblyerdeyiw.ForeColor = Color.Red;
            }

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
}