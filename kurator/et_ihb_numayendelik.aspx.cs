using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

public partial class kurator_et_ihb_numayendelik : System.Web.UI.Page
{
    Class2 klas = new Class2(); string islem; string ConnID; string BusinessTripID;
    protected void Page_Load(object sender, EventArgs e)
    {
        LinkButton lblprofil = (LinkButton)Master.FindControl("Yeniezamiyye");

        lblprofil.BackColor = Color.Peru;
       
        if (!Page.IsPostBack)
        {
            TextBox3.Visible = false;
            TextBox3.Text = "";
            FillCombobox();
            selectBAM();

            try
            {
                islem = Request.QueryString["islem"];
                ConnID = Request.QueryString["ConnID"];
            }
            catch (Exception)
            { }
            if (islem == "sil")
            {
                klas.cmd("Delete from FDelegate_IHB Where ConnID=" + ConnID);
                selectBAM();
            }
        }

    }
    protected void FillCombobox()
    {
        DataTable meqsed = klas.getdatatable("select * from Administrative_Department where regionID=" + Session["RegionID"].ToString());
        ComboBox1.Items.Clear();
        ComboBox1.DataTextField = "DepartmentName";
        ComboBox1.DataValueField = "DepartmentID";
        ComboBox1.DataSource = meqsed;
        ComboBox1.DataBind();
        ComboBox1.Items.Insert(0, new ListItem("Seçin", "-1"));
      //  ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
    }
  
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        if (CheckBox1.Checked == true)
        {
            FillCombobox();
            ComboBox1.Items.Insert(0, new ListItem("", "0"));
            ComboBox1.SelectedIndex = 0;
            ComboBox1.Visible = false;
            TextBox3.Visible = true;
            TextBox3.Text = "";
        //    this.ComboBox1.DropDownStyle = ComboBoxStyle.DropDown;
        }
        else
        {
            FillCombobox();
            ComboBox1.SelectedIndex = -1;
            TextBox3.Visible = false;
            TextBox3.Text = "";
            ComboBox1.Visible = true;
          //  this.ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }

    protected void selectBAM()
    {
        string selects = "Select * from FDelegate_IHB where RegionID=" + Session["FRegionsID"].ToString() + "order by delegate";
        DataTable dtBAM = klas.getdatatable(selects);
        GridView1.DataSource = klas.tekrarlama("delegate","1",dtBAM);
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
          string sdelegate;
          if (ComboBox1.SelectedValue == "-1")
          {
              sdelegate = TextBox3.Text;              
          }
          else
          {
              sdelegate = ComboBox1.SelectedItem.ToString() + TextBox3.Text;  
          }
        
          string selects = "Select * from FDelegate_IHB where (Delegate=N'" + seo.temizle(sdelegate) + "') and(RegionID=" + Session["FRegionsID"].ToString() + ")";
        DataTable dt = klas.getdatatable(selects);
        if (dt.Rows.Count == 0)
        {
            if ( (sdelegate.Length > 0))
                {
                    SqlConnection baglanti1 = klas.baglan();
                    SqlCommand cmd = new SqlCommand("Insert into FDelegate_IHB (DelegateID,Delegate,RegionID) values(@DelegateID,@Delegate,@RegionID)", baglanti1);
                    if (CheckBox1.Checked)
                    {
                        cmd.Parameters.Add("DelegateID", Int32.Parse("0"));
                    }
                    else 
                    {
                        cmd.Parameters.Add("DelegateID", ComboBox1.SelectedValue);
                    }
                    cmd.Parameters.Add("Delegate", sdelegate);
                    cmd.Parameters.Add("RegionID", Convert.ToInt32(Session["FRegionsId"].ToString()));
                    cmd.ExecuteNonQuery();
                    selectBAM();
                    //    lblmeqsedelave.Text = "Baxılmış, araşdırılmış məsələ əlavə edildi";
                    //    lblmeqsedelave.ForeColor = Color.Green;
                    lblmsg.Text = "Məlumat əlavə edildi";
                    lblmsg.ForeColor = Color.Green;                                      
                    FillCombobox();
                    this.CheckBox1.Checked = false;
                    this.ComboBox1.Visible = true;
                    this.TextBox3.Visible = false;
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

    private Type GetRouteUrl()
    {
        throw new NotImplementedException();
    }
    protected void Delete(object sender, GridViewDeleteEventArgs e)
    {

    }
    protected void btngeri_Click(object sender, EventArgs e)
    {
        Response.Redirect("Ezamiyyənin_Planı.aspx?RegionCode=" + Session["RegionID"].ToString() + "&BusinessTripID=" + Session["BusinessTripID"].ToString() + "&RayonID1=" + Session["FRegionsId"].ToString());
    }
   
}