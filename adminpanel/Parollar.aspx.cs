using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class adminpanel_Parollar : System.Web.UI.Page
{
    Class2 klas = new Class2();
    protected void Page_Load(object sender, EventArgs e)
    {




        //string s = @"Select * from List_classification_Regions  where UserID=0";
        //DataTable dtGruplar = klas.getdatatable(s);
        //dlbowolan.DataSource = dtGruplar;
        //dlbowolan.DataBind();

        //if (dtGruplar.Rows.Count > 0)
        //{
        //    dlbowolan.Visible = true;
        //}
        //else
        //{
        //    dlbowolan.Visible = false;
        //}


        if (Page.IsPostBack == false)
        {
            
            //regionchk();
            users();
            ddlistifadeci.Items.Insert(0, new ListItem("Seçin", "0"));
           
            //usersreg();
            //ddlusersreg.Items.Insert(0, new ListItem("Seçin", "0"));
      
        LinkButton lblprofil = (LinkButton)Master.FindControl("parollar");
        lblprofil.BackColor = Color.Peru; 
        }
    }
    void users()
    {
        DataTable region2 = klas.getdatatable("select UserID,"+
            "case when Sname is null then Name "+
            "else Name+' '+Sname end as Name,Fname,status_users from Users where status_users=1 or status_users=0 order by [SortID]");
        ddlistifadeci.DataTextField = "Name";
        ddlistifadeci.DataValueField = "UserID";
        ddlistifadeci.DataSource = region2;
        ddlistifadeci.DataBind();
    }
    //void regionchk()
    //{
    //    DataTable region2 = klas.getdatatable("Select * from List_classification_Regions order by [Name]");
    //    chkrayon.DataTextField = "Name";
    //    chkrayon.DataValueField = "RegionsID";
    //    chkrayon.DataSource = region2;
    //    chkrayon.DataBind();
    //}

    //void usersreg()
    //{
    //    DataTable region2 = klas.getdatatable("select UserID,Name+' '+Sname as Name,Fname,status_users from Users where status_users=0 order by [Name]");
    //    ddlusersreg.DataTextField = "Name";
    //    ddlusersreg.DataValueField = "UserID";
    //    ddlusersreg.DataSource = region2;
    //    ddlusersreg.DataBind();
    //}

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (ddlistifadeci.SelectedValue != "0")
        {
            DataRow region2 = klas.GetDataRow("Select passvord from Users where passvord=" + txtyeniparol.Text);
            if (ddlistifadeci.SelectedValue != "0" && txtyeniparol.Text != "" && region2== null)
            {
                SqlConnection baglanti = klas.baglan();
                SqlCommand cmd = new SqlCommand("Update Users Set passvord=@passvord Where UserID=" + ddlistifadeci.SelectedValue, baglanti);
                cmd.Parameters.Add("passvord", txtyeniparol.Text);
                cmd.ExecuteNonQuery();
                lblmessage.Text = "Parol dəyişikliyi qeydə alındı.   Yeni parol: " + txtyeniparol.Text;
                lblmessage.ForeColor = Color.Green;
                txtkohneparol.Text = "";
                txtyeniparol.Text = "";
                users();
                ddlistifadeci.Items.Insert(0, new ListItem("Seçin", "0"));
                Response.Redirect("Parollar.aspx");
            }
            else
            {
                if (region2 != null)
                {
                    lblmessage.Text = "Bu parol istifadə olunub";
                    lblmessage.ForeColor = Color.Red;
                }
                else if (txtyeniparol.Text == "")
                {
                    lblmessage.Text = "Yeni parol boş ola bilməz";
                    lblmessage.ForeColor = Color.Red;
                }
            } 
        }
        else {
            lblmessage.Text = "İstifadəçi seçilməyib";
            lblmessage.ForeColor = Color.Red;
        }
    }
    protected void ddlistifadeci_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlistifadeci.SelectedValue != "0")
        {
            DataRow region2 = klas.GetDataRow("Select passvord from Users where UserID=" + ddlistifadeci.SelectedValue);
            txtkohneparol.Text = region2[0].ToString();
        }
        else {
            txtkohneparol.Text = "";
            txtyeniparol.Text = "";
        }
    }
   
   
    protected void btnparol_Click(object sender, EventArgs e)
    {
        //btnkuratorelave.Enabled = false;
        users();
        ddlistifadeci.Items.Insert(0, new ListItem("Seçin", "0"));
        lblmessage.Text = "";
        txtyeniparol.Text = "";
        txtkohneparol.Text = "";

        btnparol.BackColor = Color.Aquamarine;
        pnlparol.Visible = true;
        //pnlkurator.Visible = false;
        btngeri.Enabled = true;
    }

    protected void btngeri_Click(object sender, EventArgs e)
    {
        //btnkuratorelave.Enabled = true;
        //pnlkuratorelave.Visible = false;
        
        btnparol.Enabled = true;
        btngeri.Enabled = false;
        //btnkuratorelave.BackColor = SystemColors.ButtonFace;
      
        btnparol.BackColor = SystemColors.ButtonFace;
        pnlparol.Visible = false;
        //pnlkurator.Visible = false;
    }
    protected void btnkuratorelave_Click(object sender, EventArgs e)
    {
        btngeri.Enabled = true;
        //pnlkuratorelave.Visible = true;
        //btnkuratorelave.BackColor = Color.Aquamarine;
        btnparol.BackColor = SystemColors.ButtonFace;
    
        btnparol.Enabled =false ;

    }

}