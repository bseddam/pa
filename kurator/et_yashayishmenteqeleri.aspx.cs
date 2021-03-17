using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

public partial class kurator_et_yashayishmenteqeleri : System.Web.UI.Page
{
    Class2 klas = new Class2(); string islem; string ConnID; string BusinessTripID;
    protected void Page_Load(object sender, EventArgs e)
    {
        LinkButton lblprofil = (LinkButton)Master.FindControl("Yeniezamiyye");

        lblprofil.BackColor = Color.Peru;
       
        if (!Page.IsPostBack)
        {
            TextBox4.Visible = false;
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
            
                klas.cmd("Delete from FLiving_point Where ConnID=" + ConnID);
                selectBAM();
            }
        }
    }
    protected void FillCombobox()
    {
        DataTable meqsed = klas.getdatatable("select CityID,CASE WHEN TypeID = 4 THEN Name + ' ' + N'kəndi'  WHEN TypeID = 3 THEN Name + ' ' + N'qəsəbəsi' WHEN TypeID = 2 THEN Name + ' ' + N'şəhəri' WHEN TypeID = 5 THEN Name + ' ' + N'rayonu' else Name  END as Rayon from List_SubRegions where regionID=" + Session["RegionID"].ToString());
        ComboBox1.Items.Clear();
        ComboBox1.DataTextField = "Rayon";
        ComboBox1.DataValueField = "CityID";
        ComboBox1.DataSource = meqsed;
        ComboBox1.DataBind();
        ComboBox1.Items.Insert(0, new ListItem("Seçin", "-1"));
    }
  
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        if (CheckBox1.Checked == true)
        {
            FillCombobox();
            ComboBox1.Items.Insert(0, new ListItem("", "0"));
            ComboBox1.SelectedIndex = 0;
           // this.ComboBox1.DropDownStyle = ComboBoxStyle.DropDown;
            ComboBox1.Visible = false;
            TextBox4.Visible = true;
        }
        else
        {
            FillCombobox();
            ComboBox1.SelectedIndex = -1;
            ComboBox1.Visible = true;
            TextBox4.Text = "";
            TextBox4.Visible = false;
          //  this.ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }

    protected void selectBAM()
    {
        string selects = "Select * from FLiving_point where RegionID=" + Session["FRegionsId"].ToString() + "order by Living";
        DataTable dtBAM = klas.getdatatable(selects);
        GridView1.DataSource = klas.tekrarlama("Living","1",dtBAM);
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
        string sliving;
        if (ComboBox1.SelectedValue == "-1")
        {
            sliving = TextBox4.Text;
        }
         else
        {
            sliving = ComboBox1.SelectedItem.ToString() + TextBox4.Text;
        }
       
        
        string selects = "Select * from FLiving_point where (Living=N'" + seo.temizle(sliving) + "')  and (RegionID=" + Session["FRegionsID"].ToString() + ")";
        DataTable dt = klas.getdatatable(selects);
        if (dt.Rows.Count == 0)
        {
            if ((sliving.Length > 0))
            {

                SqlConnection baglanti1 = klas.baglan();
                SqlCommand cmd = new SqlCommand("Insert into FLiving_point (LivingID,Living,RegionID) values(@LivingID,@Living,@RegionID)", baglanti1);
                if (CheckBox1.Checked)
                {
                    cmd.Parameters.Add("LivingID", Int32.Parse("0"));
                }
                else
                {
                    cmd.Parameters.Add("LivingID", ComboBox1.SelectedValue);
                }
                cmd.Parameters.Add("Living", sliving);
                cmd.Parameters.Add("RegionID", Convert.ToInt32(Session["FRegionsId"].ToString()));
                cmd.ExecuteNonQuery();
                selectBAM();
                FillCombobox();
                lblmsg.Text = "Məlumat əlavə edildi";
                lblmsg.ForeColor = Color.Green;
                this.CheckBox1.Checked = false;
                this.TextBox4.Visible =false;
                this.ComboBox1.Visible = true;
                this.ComboBox1.SelectedIndex = -1;
                this.TextBox4.Text = "";
            }
            else
            {
                lblmsg.Text = "Məlumat tam deyil";
                lblmsg.ForeColor = Color.Red;
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