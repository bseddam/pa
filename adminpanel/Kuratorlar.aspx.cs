using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class adminpanel_Kuratorlar : System.Web.UI.Page
{
    Class2 klas = new Class2(); seo klas1 =new seo();
    protected void Page_Load(object sender, EventArgs e)
    {
 if (Page.IsPostBack == false)
        {
        LinkButton lblprofil = (LinkButton)Master.FindControl("Kuratorlar");
        lblprofil.BackColor = Color.Peru;
        users();
        ddladdeyiw.Items.Insert(0, new ListItem("Seçin", "0"));



        string s = @"Select * from List_classification_Regions  where UserID=0 and ForDelete=1";
        DataTable dtGruplar = klas.getdatatable(s);
        dlbowolan.DataSource = dtGruplar;
        dlbowolan.DataBind();

        if (dtGruplar.Rows.Count > 0)
        {
            dlbowolan.Visible = true;
        }
        else
        {
            dlbowolan.Visible = false;
        }
       

            regionchk();


            usersreg();
            ddlusersreg.Items.Insert(0, new ListItem("Seçin", "0"));
        }
    }

    void regionchk()
    {
        DataTable region2 = klas.getdatatable("Select * from List_classification_Regions where ForDelete=1 order by [Name]");
        chkrayon.DataTextField = "Name";
        chkrayon.DataValueField = "RegionsID";
        chkrayon.DataSource = region2;
        chkrayon.DataBind();
    }
    void kurasiya()
    {
        DataTable dtiller = klas.getdatatable("select UserID,Name+' '+Sname as Name,Fname,status_users from Users where status_users=0 order by [Name]");
        ddlkurasiya.DataTextField = "Name";
        ddlkurasiya.DataValueField = "UserID";
        ddlkurasiya.DataSource = dtiller;
        ddlkurasiya.DataBind();
    }
    void regionsil()
    {
        DataTable dtiller = klas.getdatatable("select UserID,Name+' '+Sname as Name,Fname,status_users from Users where status_users=0 order by [Name]");
        ddlrayonsil.DataTextField = "Name";
        ddlrayonsil.DataValueField = "UserID";
        ddlrayonsil.DataSource = dtiller;
        ddlrayonsil.DataBind();
    }

    void usersreg()
    {
        DataTable region2 = klas.getdatatable("select UserID,Name+' '+Sname as Name,Fname,status_users from Users where status_users=0 order by [Name]");
        ddlusersreg.DataTextField = "Name";
        ddlusersreg.DataValueField = "UserID";
        ddlusersreg.DataSource = region2;
        ddlusersreg.DataBind();
    }

    void users()
    {
        DataTable region2 = klas.getdatatable("select UserID," +
            "case when Sname is null then Name " +
            "else Name+' '+Sname end as Name,Fname,status_users from Users where status_users=0 order by [SortID]");
        ddladdeyiw.DataTextField = "Name";
        ddladdeyiw.DataValueField = "UserID";
        ddladdeyiw.DataSource = region2;
        ddladdeyiw.DataBind();
    }
    protected void ddlusersreg_SelectedIndexChanged(object sender, EventArgs e)
    {

        lblmsg.Text = "";

      
        chkrayon.ClearSelection();

        DataTable region2 = klas.getdatatable("Select * from List_classification_Regions where UserID='" + ddlusersreg.SelectedValue+"' and ForDelete=1");

        if (region2 != null)
        {

            for (int i = 0; i < region2.Rows.Count; i++)
            {
                string a = region2.Rows[i]["RegionsID"].ToString();


                for (int j = 0; j < chkrayon.Items.Count; j++)
                {
                    if (chkrayon.Items[j].Value == a)
                    {
                        chkrayon.Items[j].Selected = true;
                    }
                }
            }
        }
        if (ddlusersreg.SelectedValue == "0")
        {
         
            chkrayon.ClearSelection();
        }
    }
    protected void btnkurelave_Click(object sender, EventArgs e)
    {
        DataRow drkurator = klas.GetDataRow("Select * from Users Where Name='" + seo.temizle(txtadi.Text) + "' and Sname='" + seo.temizle(txtsoyadi.Text) + "'");

        if (txtadi.Text != "" && txtsoyadi.Text != "" && txtpassvord.Text != "" && drkurator==null)
        {
            SqlConnection baglanti = klas.baglan();
            SqlCommand cmd = new SqlCommand("Insert into Users (Name,Sname,passvord,Duty) values(@Name,@Sname,@passvord,@Duty)", baglanti);
            cmd.Parameters.Add("Name", txtadi.Text);
            cmd.Parameters.Add("Sname", txtsoyadi.Text);
            cmd.Parameters.Add("passvord", txtpassvord.Text);
            cmd.Parameters.Add("Duty", "Kurator");
            cmd.ExecuteNonQuery();
            lblerror.Text = "Kurator əlavə edildi";
            lblerror.ForeColor = Color.Green;
            Response.Redirect("Kuratorlar.aspx");
        }
        else
        {
            if (txtadi.Text == "")
            {
                lblerror.Text = "Kuratorun adını daxil edin";
                lblerror.ForeColor = Color.Red;
            }
            else if (txtsoyadi.Text == "")
            {
                lblerror.Text = "Kuratorun soyadını daxil edin";
                lblerror.ForeColor = Color.Red;
            }
            else if (drkurator != null)
            {
                lblerror.Text = "Bu ad və soyadda kurator var";
                lblerror.ForeColor = Color.Red;
            } 
            else
            {
                lblerror.Text = "Kuratorun parolunu daxil edin";
                lblerror.ForeColor = Color.Red;
            }
        }
    }
    protected void btnyaddasaxla_Click(object sender, EventArgs e)
    {
        if (ddlusersreg.SelectedValue != "0")
        {
            if (chkrayon.Items.Count > 0)
            {
                for (int j = 0; j < chkrayon.Items.Count; j++)
                {
                    if (chkrayon.Items[j].Selected == false)
                    {
                        SqlConnection baglanti = klas.baglan();
                        SqlCommand cmd = new SqlCommand("Update List_classification_Regions Set UserID=0 Where UserID=" + ddlusersreg.SelectedValue, baglanti);
                        cmd.ExecuteNonQuery();

                    }
                }
                
            }
            if (chkrayon.Items.Count > 0)
            {
                for (int i = 0; i < chkrayon.Items.Count; i++)
                {
                    if (chkrayon.Items[i].Selected)
                    {
                        SqlConnection baglanti = klas.baglan();
                        SqlCommand cmd = new SqlCommand("Update List_classification_Regions Set UserID=@UserID Where RegionsID=" + chkrayon.Items[i].Value, baglanti);
                        cmd.Parameters.Add("UserID", ddlusersreg.SelectedValue);
                        cmd.ExecuteNonQuery();
                        lblmsg.Text = "Məlumat yadda saxlanıldı";
                        lblmsg.ForeColor = Color.Green;
                        string s = @"Select * from List_classification_Regions  where UserID=0 and ForDelete=1";
                        DataTable dtGruplar = klas.getdatatable(s);
                        dlbowolan.DataSource = dtGruplar;
                        dlbowolan.DataBind();

                        if (dtGruplar.Rows.Count > 0)
                        {
                            dlbowolan.Visible = true;
                        }
                        else
                        {
                            dlbowolan.Visible = false;
                        }
                    }
                }
                Response.Redirect("Kuratorlar.aspx");
            }
        }
        else
        {
            lblmsg.Text = "Kurator seçilməyib";
            lblmsg.ForeColor = Color.Red;
        }
    }
    protected void kuratorduzaliw_Click(object sender, EventArgs e)
    {
        lblmsg.Text = "";
        btnad.BackColor = SystemColors.ButtonFace;
        pnladdeyiw.Visible = false;
        pnlkuratorelave.Visible = false;
        pnlsil.Visible = false;
        pnlkurator.Visible = true;
        pnlkurasiyabax.Visible = false;
        //btnkuratorelave.Enabled = false;
        regionchk();

        usersreg();

        ddlusersreg.Items.Insert(0, new ListItem("Seçin", "0"));
        kuratorduzaliw.BackColor = Color.Aquamarine;
        btnkuratorelave.BackColor = SystemColors.ButtonFace;
        btnkurasiyabax.BackColor = SystemColors.ButtonFace;
        kuratorsil.BackColor = SystemColors.ButtonFace;
    }
    protected void btnkuratorelave_Click(object sender, EventArgs e)
    {
        lblerror.Text = "";
        txtadi.Text = "";
        txtsoyadi.Text = "";
        txtpassvord.Text = "";
        btnad.BackColor = SystemColors.ButtonFace;
        pnladdeyiw.Visible = false;
        btnkuratorelave.BackColor = Color.Aquamarine;
        btnkurasiyabax.BackColor = SystemColors.ButtonFace;
        kuratorduzaliw.BackColor = SystemColors.ButtonFace;
        kuratorsil.BackColor = SystemColors.ButtonFace;
        pnlkuratorelave.Visible = true;
        pnlsil.Visible = false;
        pnlkurator.Visible = false;
        pnlkurasiyabax.Visible = false;
      
    }
    
    protected void kuratorsil_Click(object sender, EventArgs e)
    {
        btnad.BackColor = SystemColors.ButtonFace;
        pnladdeyiw.Visible = false;
        pnlkurasiyabax.Visible = false;
        kuratorsil.BackColor = Color.Aquamarine;
        kuratorduzaliw.BackColor = SystemColors.ButtonFace;
        btnkuratorelave.BackColor = SystemColors.ButtonFace;
        btnkurasiyabax.BackColor = SystemColors.ButtonFace;
        lblrayonsil.Text = "";
        pnlkuratorelave.Visible = false;
        pnlkurator.Visible = false;
        pnlsil.Visible = true;
        regionsil();
        ddlrayonsil.Items.Insert(0, new ListItem("Seçin", "0"));
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
    protected void btnrayonsil_Click1(object sender, EventArgs e)
    {
        if (ddlrayonsil.SelectedValue != "0")
        {
            SqlConnection baglanti = klas.baglan();
            SqlCommand cmd = new SqlCommand("Update List_classification_Regions Set UserID=0 Where UserID=" + ddlrayonsil.SelectedValue, baglanti);
            cmd.ExecuteNonQuery();
            btnrayonsil.Enabled = false;
            klas.cmd("Update Users set status_users=2  Where  UserID=" + ddlrayonsil.SelectedValue);
            lblrayonsil.Text = "Kurator silindi";
            lblrayonsil.ForeColor = Color.Green;
            Response.Redirect("Kuratorlar.aspx");
        }
        else
        {
            lblrayonsil.Text = "Kurator seçilməyib";
            lblrayonsil.ForeColor = Color.Red;
        }
        regionsil();
        ddlrayonsil.Items.Insert(0, new ListItem("Seçin", "0"));
    }
    protected void btnOkay_Click(object sender, EventArgs e)
    {
       
    }
    protected void btnkurasiyabax_Click(object sender, EventArgs e)
    {
        dlkurasiya.Visible = false;
        pnlkuratorelave.Visible = false;
        pnlsil.Visible = false;
        pnlkurator.Visible = false;
        pnlkurasiyabax.Visible = true;
        kurasiya();
        btnad.BackColor = SystemColors.ButtonFace;
        pnladdeyiw.Visible = false;
        ddlkurasiya.Items.Insert(0, new ListItem("Seçin", "0"));
        btnkurasiyabax.BackColor = Color.Aquamarine;
        btnkuratorelave.BackColor = SystemColors.ButtonFace;
        kuratorduzaliw.BackColor = SystemColors.ButtonFace;
        kuratorsil.BackColor = SystemColors.ButtonFace;
            
    }
    protected void ddlkurasiya_SelectedIndexChanged(object sender, EventArgs e)
    {
        dlkurasiya.Visible = true;
        if (ddlkurasiya.SelectedValue == "0") {
            dlkurasiya.Visible = false;
        }
        string s = @"Select * from List_classification_Regions  where ForDelete=1 and UserID=" + ddlkurasiya.SelectedValue;
        DataTable dtGruplar = klas.getdatatable(s);
        dlkurasiya.DataSource = dtGruplar;
        dlkurasiya.DataBind();
    }
    protected void btnad_Click(object sender, EventArgs e)
    {
        txtad.Text = "";
        txtsyd.Text = "";
        lblmessage.Text = "";
        users();
        ddladdeyiw.Items.Insert(0, new ListItem("Seçin", "0"));
        pnladdeyiw.Visible = true;
        pnlkuratorelave.Visible = false;
        pnlsil.Visible = false;
        pnlkurator.Visible = false;
        pnlkurasiyabax.Visible = false;
  
        kuratorduzaliw.BackColor = SystemColors.ButtonFace;
        btnkuratorelave.BackColor = SystemColors.ButtonFace;
        btnkurasiyabax.BackColor = SystemColors.ButtonFace;
        kuratorsil.BackColor = SystemColors.ButtonFace;
        btnad.BackColor = Color.Aquamarine;
    }

    protected void ddladdeyiw_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddladdeyiw.SelectedValue != "0")
        {
            DataRow region2 = klas.GetDataRow("Select * from Users where UserID=" + ddladdeyiw.SelectedValue);
            txtad.Text = region2["Name"].ToString();
            txtsyd.Text = region2["SName"].ToString();
        }
        else
        {
            txtad.Text = "";
            txtsyd.Text = "";
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (ddladdeyiw.SelectedValue != "0")
        {
            DataRow region2 = klas.GetDataRow("Select * from Users where Name=N'" + txtad.Text+"' and SName=N'"+txtsyd.Text+"'");
            if (ddladdeyiw.SelectedValue != "0" && txtad.Text != "" && region2 == null)
            {
                SqlConnection baglanti = klas.baglan();
                SqlCommand cmd = new SqlCommand("Update Users Set Name=@Name,SName=@SName Where UserID=" + ddladdeyiw.SelectedValue, baglanti);
                cmd.Parameters.Add("Name", txtad.Text);
                cmd.Parameters.Add("SName", txtsyd.Text);
                cmd.ExecuteNonQuery();
                lblmessage.Text = "Dəyişikliyi qeydə alındı.";
                lblmessage.ForeColor = Color.Green;
                txtad.Text = "";
                txtsyd.Text = "";
                users();
                ddladdeyiw.Items.Insert(0, new ListItem("Seçin", "0"));
                Response.Redirect("Kuratorlar.aspx");
            }
            else
            {
                if (region2 != null)
                {
                    lblmessage.Text = "Bu ad soyad istifadə olunub";
                    lblmessage.ForeColor = Color.Red;
                }
                else if (txtad.Text == "" || txtsyd.Text == "")
                {
                    lblmessage.Text = "Yeni ad və ya soyad boş ola bilməz";
                    lblmessage.ForeColor = Color.Red;
                }
            }
        }
        else
        {
            lblmessage.Text = "İstifadəçi seçilməyib";
            lblmessage.ForeColor = Color.Red;
        }
    }
}