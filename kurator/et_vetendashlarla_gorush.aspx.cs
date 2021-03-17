using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class kurator_et_vetendashlarla_gorush : System.Web.UI.Page
{
    Class2 klas = new Class2(); string ConID2;
    int fgorushid; string RegionCode; string BusinessTripID; string FRegionsId; string islem; string ConnID;
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

            Button1.BackColor = Color.Coral;
            Button2.BackColor = SystemColors.ButtonFace;
            Button3.BackColor = SystemColors.ButtonFace;
            div1.Visible = true;
            pnl2.Visible = false;
            div3.Visible = false;
            txt_c1.Visible = false;
            txt_c2.Visible = false;
            ddlmeqsed.Visible = true;
            ddlyasmen.Visible = true;
            getmeqsed();
            getregion();
            selectIcraOrqan();
          //  getrowgorush(Int32.Parse(Session["FRegionsId"].ToString()), ComboBox10.SelectedItem.ToString());
            getdatatableGorush();
            getmeqsed_ferdi();

            if (islem == "1") {
                txt_mq_mesele.Enabled = false;

                lblmsg.Text = "";
                txt_name.Text = "";
                txt_sname.Text = "";
                txt_count.Text = "0";
                txt_c1.Text = "";
                txt_unvan.Text = "";
                txt_c2.Text = "";
                txt_mq_mesele.Text = "";

                txt_g_netice.Text = "";


                Button1.BackColor = Color.Coral;
                Button2.BackColor = SystemColors.ButtonFace;
                Button3.BackColor = SystemColors.ButtonFace;
                div1.Visible = true;
                pnl2.Visible = false;
                div3.Visible = false;
                getrowgorush(Int32.Parse(Session["FRegionsID"].ToString()), ddlyasmen.SelectedItem.ToString());
                getdatatableGorush();
                getregion();
                CheckBox11.Checked = false;
                CheckBox12.Checked = false;

                this.ddlyasmen.SelectedIndex = -1;
                this.txt_c1.Visible = false;
                this.txt_c1.Text = "";
                this.ddlyasmen.Visible = true;
                getmeqsed();
                this.ddlmeqsed.SelectedIndex = -1;
                this.txt_c2.Visible = false;
                this.txt_c2.Text = "";
                this.ddlmeqsed.Visible = true;
            }

            if (islem == "2") {
                CheckBox4.Checked = false;
                CheckBox13.Checked = false;
                txt_sname_ferdi.Text = "";
                txt_name_fredi.Text = "";
                getmeqsed_ferdi();
                lblmesag2.Text = "";
                SelectFerdi();
                Button1.BackColor = SystemColors.ButtonFace;
                Button2.BackColor = Color.Coral;
                Button3.BackColor = SystemColors.ButtonFace;
                div1.Visible = false;
                pnl2.Visible = true;
                div3.Visible = false;
                selectIcraOrqan();
                SelectUmumiGorush();
                if (CBIcraOrqan.SelectedValue != null)
                {
                    icraorq();
                }
                txt_IcraOrqan.Text = "";
                txt_Tutduqu_vezife.Text = "";
                txt_meqsed.Text = "";

                this.CBIcraOrqan.SelectedIndex = -1;
                txt_IcraOrqan.Visible = false;
                txt_IcraOrqan.Text = "";
                CBIcraOrqan.Visible = true;
                // this.CBIcraOrqan.DropDownStyle = ComboBoxStyle.DropDownList;
                txt_Tutduqu_vezife.Visible = false;
                txt_Tutduqu_vezife.Text = "";
                CBtutduquVezife.Visible = true;

                this.CBMeqsed_ferdi.SelectedIndex = -1;
                txt_meqsed.Visible = false;
                txt_meqsed.Text = "";
                CBMeqsed_ferdi.Visible = true;
            }

            if (islem == "3") {
                lblmesag3.Text = "";
                txt_kecrilmish_gorush.Text = "";
                txt_meqsed_umumi.Text = "";
                txt_results_umumi.Text = "";

                Button1.BackColor = SystemColors.ButtonFace;
                Button2.BackColor = SystemColors.ButtonFace;
                Button3.BackColor = Color.Coral;
                div1.Visible = false;
                pnl2.Visible = false;
                div3.Visible = true;
                SelectFerdi();
                SelectUmumiGorush();
            }
            if (islem == "sil")
            {
                
                klas.cmd("Delete from FIndividual_meetings_citizens Where ConnID=" + ConnID);
                getdatatableGorush();
                div1.Visible = true;
                pnl2.Visible = false;
                div3.Visible = false;
                Button1.BackColor = Color.Coral;
                Button2.BackColor = SystemColors.ButtonFace;
                Button3.BackColor = SystemColors.ButtonFace;
            }
            if (islem == "sil1")
            {
                klas.cmd("Delete from FDesigned_staff Where ConnID=" + ConnID);
                SelectFerdi();
                div1.Visible = false;
                pnl2.Visible = true;
                div3.Visible = false;
                Button2.BackColor = Color.Coral;
                Button1.BackColor = SystemColors.ButtonFace;
                Button3.BackColor = SystemColors.ButtonFace;
            }
            if (islem == "sil2")
            {
                div1.Visible = false;
                pnl2.Visible = false;
                div3.Visible = true;
                Button3.BackColor = Color.Coral;
                Button1.BackColor = SystemColors.ButtonFace;
                Button2.BackColor = SystemColors.ButtonFace;
                klas.cmd("Delete from FOther_meettings Where ConnID=" + ConnID);
                SelectUmumiGorush();
            }

            if (islem == "duzelis")
            {
                DataRow drmeqs = klas.GetDataRow("SELECT * from FIndividual_meetings_citizens where ConnID=" + ConnID);
                txt_name.Text = drmeqs["Name"].ToString();
                txt_sname.Text = drmeqs["SurName"].ToString();
                txt_count.Text = drmeqs["Other"].ToString();
                txt_unvan.Text = drmeqs["Adres"].ToString();
                txt_mq_mesele.Text = drmeqs["Appeal_raised_issue"].ToString();
                txt_g_netice.Text = drmeqs["Expected_results"].ToString();
                if (drmeqs["Living_pointId"].ToString() == "0")
                {
                    getregion();
                    this.ddlyasmen.Items.Insert(0, new ListItem("", "0"));
                    this.ddlyasmen.SelectedIndex = 0;
                    this.txt_c1.Visible = true;
                    this.txt_c1.Text = drmeqs["Living_point"].ToString();
                    this.ddlyasmen.Visible = false;
                    CheckBox11.Checked = true;
                }
                else
                {
                    ddlyasmen.SelectedValue = drmeqs["Living_pointId"].ToString();
                }
                if (drmeqs["PurposeID"].ToString() == "0")
                {
                    getmeqsed();
                    this.ddlmeqsed.Items.Insert(0, new ListItem("", "0"));
                    this.ddlmeqsed.SelectedIndex = 0;
                    this.txt_c2.Visible = true;
                    this.txt_c2.Text = drmeqs["Purpose"].ToString();
                    this.ddlmeqsed.Visible = false;
                    txt_mq_mesele.Enabled = false;
                    txt_mq_mesele.Text = "";
                    CheckBox12.Checked = true;
                }
                else
                {
                    ddlmeqsed.SelectedValue = drmeqs["PurposeID"].ToString();
                }
            }
            if (islem == "duzeldi")
            {
                lblmsg.Text = "Dəyişiklik qeydə alındı";
                lblmsg.ForeColor = Color.Green;
            }
            if (islem == "duzeldi2")
            {
                CheckBox4.Checked = false;
                CheckBox13.Checked = false;
                txt_sname_ferdi.Text = "";
                txt_name_fredi.Text = "";
                getmeqsed_ferdi();
                lblmesag2.Text = "";
                SelectFerdi();
                Button1.BackColor = SystemColors.ButtonFace;
                Button2.BackColor = Color.Coral;
                Button3.BackColor = SystemColors.ButtonFace;
                div1.Visible = false;
                pnl2.Visible = true;
                div3.Visible = false;
                selectIcraOrqan();
                SelectUmumiGorush();
                if (CBIcraOrqan.SelectedValue != null)
                {
                    icraorq();
                }
                txt_IcraOrqan.Text = "";
                txt_Tutduqu_vezife.Text = "";
                txt_meqsed.Text = "";

                this.CBIcraOrqan.SelectedIndex = -1;
                txt_IcraOrqan.Visible = false;
                txt_IcraOrqan.Text = "";
                CBIcraOrqan.Visible = true;
                // this.CBIcraOrqan.DropDownStyle = ComboBoxStyle.DropDownList;
                txt_Tutduqu_vezife.Visible = false;
                txt_Tutduqu_vezife.Text = "";
                CBtutduquVezife.Visible = true;

                this.CBMeqsed_ferdi.SelectedIndex = -1;
                txt_meqsed.Visible = false;
                txt_meqsed.Text = "";
                CBMeqsed_ferdi.Visible = true;
                lblmesag2.Text = "Dəyişiklik qeydə alındı";
                lblmesag2.ForeColor = Color.Green;
            }
      
        if(islem == "duzelis2"){

            CheckBox4.Checked = false;
            CheckBox13.Checked = false;
            txt_sname_ferdi.Text = "";
            txt_name_fredi.Text = "";
            getmeqsed_ferdi();
            lblmesag2.Text = "";
            SelectFerdi();
            Button1.BackColor = SystemColors.ButtonFace;
            Button2.BackColor = Color.Coral;
            Button3.BackColor = SystemColors.ButtonFace;
            div1.Visible = false;
            pnl2.Visible = true;
            div3.Visible = false;
            selectIcraOrqan();
            SelectUmumiGorush();
            if (CBIcraOrqan.SelectedValue != null)
            {
                icraorq();
            }
            txt_IcraOrqan.Text = "";
            txt_Tutduqu_vezife.Text = "";
            txt_meqsed.Text = "";

            txt_IcraOrqan.Visible = false;
            txt_IcraOrqan.Text = "";
            CBIcraOrqan.Visible = true;
            // this.CBIcraOrqan.DropDownStyle = ComboBoxStyle.DropDownList;
            txt_Tutduqu_vezife.Visible = false;
            txt_Tutduqu_vezife.Text = "";
            CBtutduquVezife.Visible = true;
            txt_meqsed.Visible = false;
            txt_meqsed.Text = "";
            CBMeqsed_ferdi.Visible = true;









                DataRow drmeqs = klas.GetDataRow(@"SELECT * from FDesigned_staff where ConnID=" + ConnID);
                txt_name_fredi.Text = drmeqs["Name"].ToString();
                txt_sname_ferdi.Text = drmeqs["SName"].ToString();
                if (drmeqs["Executive_bodyID"].ToString() == "0")
                {
                    selectIcraOrqan();
                    this.CBIcraOrqan.Items.Insert(0, new ListItem("", "0"));
                    this.CBIcraOrqan.SelectedIndex = 0;
                    txt_IcraOrqan.Visible = true;
                    txt_IcraOrqan.Text = drmeqs["Executive_body"].ToString();
                    CBIcraOrqan.Visible = false;
                    //this.CBtutduquVezife.Items.Clear();
                    //this.CBtutduquVezife.Items.Insert(0, new ListItem("", "0"));
                    //this.CBtutduquVezife.SelectedIndex = 0;
                    //txt_Tutduqu_vezife.Visible = true;
                    //txt_Tutduqu_vezife.Text = drmeqs["Positions"].ToString();
                    //CBtutduquVezife.Visible = false;
                    //CheckBox4.Checked = true;
                }
                else
                {
                    CBIcraOrqan.SelectedValue = drmeqs["Executive_bodyID"].ToString();
                }
                if (drmeqs["PositionsID"].ToString() == "0")
                {
                    selectIcraOrqan();
                    icraorq();
                    this.CBtutduquVezife.Items.Clear();
                    this.CBtutduquVezife.Items.Insert(0, new ListItem("", "0"));
                    this.CBtutduquVezife.SelectedIndex = 0;
                    txt_Tutduqu_vezife.Visible = true;
                    txt_Tutduqu_vezife.Text = drmeqs["Positions"].ToString();
                    CBtutduquVezife.Visible = false;
                    CheckBox4.Checked = true;
                }
                else
                {
                    DataTable IcraOrqan = klas.getdatatable("select * from List_classifications where ListID=" + CBIcraOrqan.SelectedValue.ToString() + " order by sort");
                    CBtutduquVezife.DataTextField = "ClassifName";
                    CBtutduquVezife.DataValueField = "ClassifID";
                    CBtutduquVezife.DataSource = IcraOrqan;
                    CBtutduquVezife.DataBind();
                    CBtutduquVezife.Items.Insert(0, new ListItem("Seçin", "-1"));
                    CBtutduquVezife.SelectedValue = drmeqs["PositionsID"].ToString();
                }
                if (drmeqs["PurposeID"].ToString() == "0")
                {
                    getmeqsed_ferdi();
                    this.CBMeqsed_ferdi.Items.Insert(0, new ListItem("", "0"));
                    this.CBMeqsed_ferdi.SelectedIndex = 0;
                    txt_meqsed.Visible = true;
                    txt_meqsed.Text = drmeqs["Purpose"].ToString();
                    CBMeqsed_ferdi.Visible = false;
                    CheckBox13.Checked = true;
                }
                else {
                    CBMeqsed_ferdi.SelectedValue = drmeqs["PurposeID"].ToString();
                }
        }





        if (islem == "duzelis3")
        {
            lblmesag3.Text = "";
            txt_kecrilmish_gorush.Text = "";
            txt_meqsed_umumi.Text = "";
            txt_results_umumi.Text = "";

            Button1.BackColor = SystemColors.ButtonFace;
            Button2.BackColor = SystemColors.ButtonFace;
            Button3.BackColor = Color.Coral;
            div1.Visible = false;
            pnl2.Visible = false;
            div3.Visible = true;
            SelectFerdi();
            SelectUmumiGorush();

            DataRow drmeqs = klas.GetDataRow("SELECT * from FOther_meettings where ConnID=" + ConnID);
            txt_kecrilmish_gorush.Text = drmeqs["Meetings"].ToString();
            txt_meqsed_umumi.Text = drmeqs["Purpose"].ToString();
            txt_results_umumi.Text = drmeqs["results"].ToString();
        }

        if (islem == "duzeldi3")
        {
            lblmesag3.Text = "";
            txt_kecrilmish_gorush.Text = "";
            txt_meqsed_umumi.Text = "";
            txt_results_umumi.Text = "";
            Button1.BackColor = SystemColors.ButtonFace;
            Button2.BackColor = SystemColors.ButtonFace;
            Button3.BackColor = Color.Coral;
            div1.Visible = false;
            pnl2.Visible = false;
            div3.Visible = true;
            SelectFerdi();
            SelectUmumiGorush();
            lblmesag3.Text = "Dəyişiklik qeydə alındı";
            lblmesag3.ForeColor = Color.Green;
        }
        }
    }
    protected void getregion()
    {
        DataTable SubRegion = klas.getdatatable("select CityID,CASE WHEN TypeID = 4 THEN Name + ' ' + N'kəndi'  WHEN TypeID = 3 THEN Name + ' ' + N'qəsəbəsi' WHEN TypeID = 2 THEN Name + ' ' + N'şəhəri' WHEN TypeID = 5 THEN Name + ' ' + N'rayonu' else Name  END as Rayon from List_SubRegions where RegionID=" + Session["RegionId"].ToString());
        ddlyasmen.Items.Clear();
        ddlyasmen.DataTextField = "Rayon";
        ddlyasmen.DataValueField = "CityID";
        ddlyasmen.DataSource = SubRegion;
        ddlyasmen.DataBind();
        ddlyasmen.Items.Insert(0, new ListItem("Seçin", "-1"));
    }
    protected void getmeqsed()
    {
        DataTable meqsed = klas.getdatatable("Select ClassifID,ClassifName,ListID from List_classifications where ListID=13 order by sort");
        ddlmeqsed.Items.Clear();
        ddlmeqsed.DataTextField = "ClassifName";
        ddlmeqsed.DataValueField = "ClassifID";
        ddlmeqsed.DataSource = meqsed;
        ddlmeqsed.DataBind();
        ddlmeqsed.Items.Insert(0, new ListItem("Seçin", "-1"));
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("et_vetendashlarla_gorush.aspx?islem=1");

       
    }
    protected void Button2_Click(object sender, EventArgs e)
    {


        Response.Redirect("et_vetendashlarla_gorush.aspx?islem=2");

    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("et_vetendashlarla_gorush.aspx?islem=3");
    }
    protected void getrowgorush(int n,string s)
    {
        DataRow dr = klas.GetDataRow("Select * from FIndividual_meetings_citizens where (RegionID=" + seo.temizle(n.ToString()) + ") and (Living_point='" + seo.temizle(s) + "')");
        if (dr != null)
        {
            if (dr["Living_pointID"].ToString() == "0")
            {
               // getregion();
                this.ddlyasmen.Items.Insert(0, new ListItem(dr["Living_point"].ToString(), "0"));
                this.ddlyasmen.SelectedValue = "0";
            }
            fgorushid = Int32.Parse(dr["ConnID"].ToString());
            txt_name.Text = dr["Name"].ToString();
            txt_sname.Text = dr["SurName"].ToString();
            txt_count.Text = dr["Other"].ToString();
            if (dr["Living_pointID"].ToString() != "0")
            {
                ddlyasmen.SelectedValue = dr["Living_pointID"].ToString();
            }
            //ComboBox10.Text = dr["Living_point"].ToString();
            txt_unvan.Text = dr["Adres"].ToString();
        }
    }
    protected void selectIcraOrqan()
    {
        DataTable IcraOrqan = klas.getdatatable("select * from List_classifications where ListID=17");
        CBIcraOrqan.Items.Clear();
        CBIcraOrqan.DataTextField = "ClassifName";
        CBIcraOrqan.DataValueField = "ClassifID";
        CBIcraOrqan.DataSource = IcraOrqan;
        CBIcraOrqan.DataBind();
        CBIcraOrqan.Items.Insert(0, new ListItem("Seçin", "-1"));
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        string sPurpose, sLiving_point;
        if (ddlyasmen.SelectedValue == "-1")
        {
            sLiving_point = txt_c1.Text;
        }
        else
        {
            sLiving_point = ddlyasmen.SelectedItem.ToString() + txt_c1.Text;
        }

        if (ddlmeqsed.SelectedValue == "-1")
        {
            sPurpose = txt_c2.Text;
        }
        else
        {
            sPurpose = ddlmeqsed.SelectedItem.ToString() + txt_c2.Text;
        }


        if (islem != "duzelis")
        {
            DataTable dt = klas.getdatatable(@"Select * from FIndividual_meetings_citizens where (Purpose=N'" + seo.temizle(sPurpose) + "') and (Living_point='" + seo.temizle(sLiving_point) + "') and (RegionID=" + Session["RegionId"].ToString() + ")");
            if (dt.Rows.Count == 0)
            {
                //&& (txt_g_netice.Text != "")
                if ((txt_name.Text != "") && (txt_sname.Text != "") && (txt_unvan.Text != "")  && (sPurpose != "") && (sLiving_point != "") && (txt_count.Text != ""))
                {
                    SqlConnection baglanti1 = klas.baglan();
                    SqlCommand cmd = new SqlCommand("Insert into FIndividual_meetings_citizens (Name,SurName,Other,Living_pointId,Living_point,Adres,PurposeID,Purpose,Appeal_raised_issue,Expected_results,RegionID) values(@Name,@SurName,@Other,@Living_pointId,@Living_point,@Adres,@PurposeID,@Purpose,@Appeal_raised_issue,@Expected_results,@RegionID)", baglanti1);
                    cmd.Parameters.Add("Name", txt_name.Text);
                    cmd.Parameters.Add("SurName", txt_sname.Text);
                    cmd.Parameters.Add("Other", Int32.Parse(txt_count.Text));
                    if (!CheckBox11.Checked)
                    {
                        cmd.Parameters.Add("Living_pointId", ddlyasmen.SelectedValue);
                    }
                    else
                    {
                        cmd.Parameters.Add("Living_pointId", Int32.Parse("0"));
                    }
                    cmd.Parameters.Add("Living_point", sLiving_point);
                    cmd.Parameters.Add("Adres", txt_unvan.Text);
                    if (!CheckBox12.Checked)
                    {
                        cmd.Parameters.Add("PurposeID", ddlmeqsed.SelectedValue);
                    }
                    else
                    {
                        cmd.Parameters.Add("PurposeID", Int32.Parse("0"));
                    }
                    cmd.Parameters.Add("Purpose", sPurpose);
                    cmd.Parameters.Add("Appeal_raised_issue", txt_mq_mesele.Text);
                    cmd.Parameters.Add("Expected_results", txt_g_netice.Text);
                    cmd.Parameters.Add("RegionID", Convert.ToInt32(Session["FRegionsID"].ToString()));
                    cmd.ExecuteNonQuery();
                    getdatatableGorush();
                    getregion();
                    getmeqsed();
                    txt_mq_mesele.Enabled = false;
                    txt_mq_mesele.Text = "";
                    CheckBox11.Checked = false;
                    CheckBox12.Checked = false;
                    txt_name.Text = "";
                    txt_sname.Text = "";
                    txt_count.Text = "0";
                    txt_unvan.Text = "";

                    txt_g_netice.Text = "";
                    txt_c1.Text = "";
                    txt_c2.Text = "";
                    ddlmeqsed.Visible = true;
                    ddlyasmen.Visible = true;
                    txt_c1.Visible = false;
                    txt_c2.Visible = false;
                    lblmsg.Text = "Məlumat əlavə edildi";
                    lblmsg.ForeColor = Color.Green;

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



        else if (islem == "duzelis")
        {
            DataTable dt = klas.getdatatable(@"Select * from FIndividual_meetings_citizens where (Purpose=N'" + seo.temizle(sPurpose) + "') and (Living_point='" + seo.temizle(sLiving_point) + "') and (RegionID=" + Session["RegionId"].ToString() + ")  and (ConnID<>"+ConnID+")");
            if (dt.Rows.Count == 0)
            {
                //&& (txt_g_netice.Text != "") 
                if ((txt_name.Text != "") && (txt_sname.Text != "") && (txt_unvan.Text != "") && (sPurpose != "") && (sLiving_point != "") && (txt_count.Text != ""))
                {
                    SqlConnection baglanti1 = klas.baglan();
                    SqlCommand cmd = new SqlCommand("Update FIndividual_meetings_citizens set Name=@Name,SurName=@SurName,Other=@Other,Living_pointId=@Living_pointId,Living_point=@Living_point,Adres=@Adres,PurposeID=@PurposeID,Purpose=@Purpose,Appeal_raised_issue=@Appeal_raised_issue,Expected_results=@Expected_results,RegionID=@RegionID where ConnID=" + ConnID, baglanti1);
                    cmd.Parameters.Add("Name", txt_name.Text);
                    cmd.Parameters.Add("SurName", txt_sname.Text);
                    cmd.Parameters.Add("Other", Int32.Parse(txt_count.Text));
                    if (!CheckBox11.Checked)
                    {
                        cmd.Parameters.Add("Living_pointId", ddlyasmen.SelectedValue);
                    }
                    else
                    {
                        cmd.Parameters.Add("Living_pointId", Int32.Parse("0"));
                    }
                    cmd.Parameters.Add("Living_point", sLiving_point);
                    cmd.Parameters.Add("Adres", txt_unvan.Text);
                    if (!CheckBox12.Checked)
                    {
                        cmd.Parameters.Add("PurposeID", ddlmeqsed.SelectedValue);
                    }
                    else
                    {
                        cmd.Parameters.Add("PurposeID", Int32.Parse("0"));
                    }
                    cmd.Parameters.Add("Purpose", sPurpose);
                    cmd.Parameters.Add("Appeal_raised_issue", txt_mq_mesele.Text);
                    cmd.Parameters.Add("Expected_results", txt_g_netice.Text);
                    cmd.Parameters.Add("RegionID", Convert.ToInt32(Session["FRegionsID"].ToString()));
                    cmd.ExecuteNonQuery();
                    getdatatableGorush();
                    getregion();
                    getmeqsed();
                    txt_mq_mesele.Enabled = false;
                    txt_mq_mesele.Text = "";
                    CheckBox11.Checked = false;
                    CheckBox12.Checked = false;
                    txt_name.Text = "";
                    txt_sname.Text = "";
                    txt_count.Text = "0";
                    txt_unvan.Text = "";

                    Response.Redirect("et_vetendashlarla_gorush.aspx?islem=duzeldi");

                    txt_g_netice.Text = "";
                    txt_c1.Text = "";
                    txt_c2.Text = "";
                    ddlmeqsed.Visible = true;
                    ddlyasmen.Visible = true;
                    txt_c1.Visible = false;
                    txt_c2.Visible = false;
                    lblmsg.Text = "Məlumat əlavə edildi";
                    lblmsg.ForeColor = Color.Green;

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


    }
    protected void getdatatableGorush()
    {

        string selects =" SELECT ConnID,Name +' '+ SurName as  Name,Other+1 as Other,Living_pointId,Living_point" +
                         " ,Adres,PurposeID,Purpose,Appeal_raised_issue,Expected_results,RegionID"+
                         " from FIndividual_meetings_citizens where RegionID=" + Session["FRegionsID"].ToString()+" order by PurposeID";
        DataTable dtBAM = klas.getdatatable(selects);
        GridView1.DataSource = klas.tekrarlama("Purpose", "1", dtBAM);
        GridView1.DataBind();
        
    }
    protected void SelectUmumiGorush()
    {
        string selects = "Select * from FOther_meettings where RegionsID=" + Session["FRegionsID"].ToString();
        DataTable dtBAM = klas.getdatatable(selects);
        GridView3.DataSource = dtBAM;
        GridView3.DataBind();
    }
    protected void SelectFerdi()
    {
        string selects = "Select * from FDesigned_staff where RegionID=" + Session["FRegionsID"].ToString();
        DataTable dtBAM = klas.getdatatable(selects);
        GridView2.DataSource = dtBAM;
        GridView2.DataBind();
    }
    protected void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (Int32.Parse(ddlmeqsed.SelectedValue.ToString()) == 130)
        {
            txt_mq_mesele.Enabled = true;
            txt_mq_mesele.Text = "";
        }
        else
        {
            txt_mq_mesele.Enabled = false;
            txt_mq_mesele.Text = "";
        }
    }
    protected void CheckBox11_CheckedChanged(object sender, EventArgs e)
    {
        if (CheckBox11.Checked == true)
        {
            getregion();
            this.ddlyasmen.Items.Insert(0, new ListItem("", "0"));
            this.ddlyasmen.SelectedIndex = 0;
            this.txt_c1.Visible = true;
            this.txt_c1.Text = "";
            this.ddlyasmen.Visible = false;
            //this.ComboBox10.DropDownStyle = ComboBoxStyle.DropDown;
        }
        else
        {
                  getregion();
            this.ddlyasmen.SelectedIndex = -1;
            this.txt_c1.Visible = false;
            this.txt_c1.Text = "";
            this.ddlyasmen.Visible = true;
          //  this.ComboBox10.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
    protected void CheckBox12_CheckedChanged(object sender, EventArgs e)
    {
        if (CheckBox12.Checked == true)
        {
            getmeqsed();
            this.ddlmeqsed.Items.Insert(0, new ListItem("", "0"));
            this.ddlmeqsed.SelectedIndex = 0;
            this.txt_c2.Visible = true;
            this.txt_c2.Text = "";
            this.ddlmeqsed.Visible = false;
            txt_mq_mesele.Enabled = false;
            txt_mq_mesele.Text = "";
        //    this.ComboBox1.DropDownStyle = ComboBoxStyle.DropDown;
        }
        else
        {
            getmeqsed();
            this.ddlmeqsed.SelectedIndex = -1;
            this.txt_c2.Visible = false;
            this.txt_c2.Text = "";
            this.ddlmeqsed.Visible = true;
         //   this.ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
    protected void icraorq()
    {
        DataTable IcraOrqan = klas.getdatatable("select * from List_classifications where ListID=" + CBIcraOrqan.SelectedValue.ToString() + " order by sort");
        CBtutduquVezife.DataTextField = "ClassifName";
        CBtutduquVezife.DataValueField = "ClassifID";
        CBtutduquVezife.DataSource = IcraOrqan;
        CBtutduquVezife.DataBind();
        CBtutduquVezife.Items.Insert(0, new ListItem("Seçin", "-1"));
        CBtutduquVezife.SelectedIndex = -1;
    }

    protected void CBIcraOrqan_SelectedIndexChanged(object sender, EventArgs e)
    {

        if (CBIcraOrqan.SelectedValue != null)
        {
            icraorq();
        }

    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        if (islem != "duzelis3")
        {

            //&& (txt_results_umumi.Text != "")
            if ((txt_kecrilmish_gorush.Text != "") && (txt_meqsed_umumi.Text != "") )
            {
                SqlConnection baglanti1 = klas.baglan();
                SqlCommand cmd = new SqlCommand("Insert into FOther_meettings (Meetings,Purpose,results,RegionsID) values(@Meetings,@Purpose,@results,@RegionsID)", baglanti1);

                cmd.Parameters.Add("Meetings", txt_kecrilmish_gorush.Text);
                cmd.Parameters.Add("Purpose", txt_meqsed_umumi.Text);
                cmd.Parameters.Add("results", txt_results_umumi.Text);
                cmd.Parameters.Add("RegionsID", Convert.ToInt32(Session["FRegionsID"].ToString()));
                cmd.ExecuteNonQuery();
                SelectUmumiGorush();
                lblmesag3.Text = "Məlumat əlavə edildi";
                lblmesag3.ForeColor = Color.Green;

                txt_kecrilmish_gorush.Text = "";
                txt_meqsed_umumi.Text = "";
                txt_results_umumi.Text = "";
            }
            else
            {
                lblmesag3.Text = "Məlumat tam deyil";
                lblmesag3.ForeColor = Color.Red;
            }
        }
        else if (islem == "duzelis3")
        {
            // && (txt_results_umumi.Text != "")
            if ((txt_kecrilmish_gorush.Text != "") && (txt_meqsed_umumi.Text != ""))
            {
                SqlConnection baglanti1 = klas.baglan();
                SqlCommand cmd = new SqlCommand("Update FOther_meettings set Meetings=@Meetings,Purpose=@Purpose,results=@results,RegionsID=@RegionsID where ConnID=" + ConnID, baglanti1);

                cmd.Parameters.Add("Meetings", txt_kecrilmish_gorush.Text);
                cmd.Parameters.Add("Purpose", txt_meqsed_umumi.Text);
                cmd.Parameters.Add("results", txt_results_umumi.Text);
                cmd.Parameters.Add("RegionsID", Convert.ToInt32(Session["FRegionsID"].ToString()));
                cmd.ExecuteNonQuery();
                SelectUmumiGorush();
                //Response.Redirect("et_vetendashlarla_gorush.aspx?islem=duzeldi3");
                lblmesag3.Text = "Məlumat əlavə edildi";
                lblmesag3.ForeColor = Color.Green;

                txt_kecrilmish_gorush.Text = "";
                txt_meqsed_umumi.Text = "";
                txt_results_umumi.Text = "";
            }
            else
            {
                lblmesag3.Text = "Məlumat tam deyil";
                lblmesag3.ForeColor = Color.Red;
            }
        }

    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        string sicraorqan, svezife, smeqsed_ferdi;
        if (CheckBox4.Checked ==true)
        {
            sicraorqan = txt_IcraOrqan.Text;
        }
        else
        {
            sicraorqan = CBIcraOrqan.SelectedItem.ToString() + txt_IcraOrqan.Text;
        }
        if (CBtutduquVezife.SelectedValue == "-1")
        {
            svezife = txt_Tutduqu_vezife.Text;
        }
        else
        {
            svezife = CBtutduquVezife.SelectedItem + txt_Tutduqu_vezife.Text;
        } 
        if (CBMeqsed_ferdi.SelectedValue == "-1")
        {
            smeqsed_ferdi = txt_meqsed.Text;
        }
        else
        {
            smeqsed_ferdi = CBMeqsed_ferdi.SelectedItem.ToString() + txt_meqsed.Text;
        }



        if (islem != "duzelis2")
        {
            if ((sicraorqan != "") && (svezife != "") && (txt_name_fredi.Text != "") && (txt_sname_ferdi.Text != "") && (smeqsed_ferdi != ""))
            {
                SqlConnection baglanti1 = klas.baglan();
                SqlCommand cmd = new SqlCommand("Insert into FDesigned_staff (Executive_bodyID,Executive_body,PositionsID,Positions,Name,SName,Purpose,PurposeID,RegionID) values(@Executive_bodyID,@Executive_body,@PositionsID,@Positions,@Name,@SName,@Purpose,@PurposeID,@RegionID)", baglanti1);
                if (CheckBox4.Checked == true)
                {
                    cmd.Parameters.Add("Executive_bodyID", Int32.Parse("0"));
                }
                else
                {
                    cmd.Parameters.Add("Executive_bodyID", CBIcraOrqan.SelectedValue);
                }
                cmd.Parameters.Add("Executive_body", sicraorqan);
                if (CBtutduquVezife.SelectedValue.ToString() == CBtutduquVezife.SelectedItem.ToString())
                {
                    cmd.Parameters.Add("PositionsID", Int32.Parse("0"));
                }
                else
                {
                    cmd.Parameters.Add("PositionsID", CBtutduquVezife.SelectedValue);
                }
                cmd.Parameters.Add("Positions", svezife);
                cmd.Parameters.Add("Name", txt_name_fredi.Text);
                cmd.Parameters.Add("SName", txt_sname_ferdi.Text);
                cmd.Parameters.Add("Purpose", smeqsed_ferdi);
                if (CheckBox13.Checked == true)
                {
                    cmd.Parameters.Add("PurposeID", Int32.Parse("0"));
                }
                else
                {
                    cmd.Parameters.Add("PurposeID", CBMeqsed_ferdi.SelectedValue);
                }
                cmd.Parameters.Add("RegionID", Convert.ToInt32(Session["FRegionsID"].ToString()));
                cmd.ExecuteNonQuery();
                SelectUmumiGorush();
                SelectFerdi();


                lblmesag2.Text = "Məlumat əlavə edildi";
                lblmesag2.ForeColor = Color.Green;
                selectIcraOrqan();
                getmeqsed_ferdi();

                this.CBtutduquVezife.Items.Clear();

                txt_name_fredi.Text = "";
                txt_sname_ferdi.Text = "";

                CheckBox13.Checked = false;
                CheckBox4.Checked = false;
                txt_meqsed.Text = "";
                txt_meqsed.Visible = false;
                txt_IcraOrqan.Text = "";
                txt_IcraOrqan.Visible = false;
                txt_Tutduqu_vezife.Text = "";
                txt_Tutduqu_vezife.Visible = false;
                CBMeqsed_ferdi.Visible = true;
                CBIcraOrqan.Visible = true;
                CBtutduquVezife.Visible = true;
                sicraorqan = "";
            }
            else
            {
                lblmesag2.Text = "Məlumat tam deyil";
                lblmesag2.ForeColor = Color.Red;
            }
        }
        else if (islem == "duzelis2")
        {
            if ((sicraorqan != "") && (svezife != "") && (txt_name_fredi.Text != "") && (txt_sname_ferdi.Text != "") && (smeqsed_ferdi != ""))
            {
                SqlConnection baglanti1 = klas.baglan();
                SqlCommand cmd = new SqlCommand("Update FDesigned_staff set Executive_bodyID=@Executive_bodyID,Executive_body=@Executive_body,PositionsID=@PositionsID,Positions=@Positions,Name=@Name,SName=@SName,Purpose=@Purpose,PurposeID=@PurposeID,RegionID=@RegionID where ConnID=" + ConnID, baglanti1);
                if (CheckBox4.Checked == true)
                {
                    cmd.Parameters.Add("Executive_bodyID", Int32.Parse("0"));
                }
                else
                {
                    cmd.Parameters.Add("Executive_bodyID", CBIcraOrqan.SelectedValue);
                }
                cmd.Parameters.Add("Executive_body", sicraorqan);
                if (CBtutduquVezife.SelectedValue.ToString() == CBtutduquVezife.SelectedItem.ToString())
                {
                    cmd.Parameters.Add("PositionsID", Int32.Parse("0"));
                }
                else
                {
                    cmd.Parameters.Add("PositionsID", CBtutduquVezife.SelectedValue);
                }
                cmd.Parameters.Add("Positions", svezife);
                cmd.Parameters.Add("Name", txt_name_fredi.Text);
                cmd.Parameters.Add("SName", txt_sname_ferdi.Text);
                cmd.Parameters.Add("Purpose", smeqsed_ferdi);
                if (CheckBox13.Checked == true)
                {
                    cmd.Parameters.Add("PurposeID", Int32.Parse("0"));
                }
                else
                {
                    cmd.Parameters.Add("PurposeID", CBMeqsed_ferdi.SelectedValue);
                }
                cmd.Parameters.Add("RegionID", Convert.ToInt32(Session["FRegionsID"].ToString()));
                cmd.ExecuteNonQuery();
                SelectUmumiGorush();
                SelectFerdi();

                Response.Redirect("et_vetendashlarla_gorush.aspx?islem=duzeldi2");
                lblmesag2.Text = "Məlumat əlavə edildi";
                lblmesag2.ForeColor = Color.Green;
                selectIcraOrqan();
                getmeqsed_ferdi();

                this.CBtutduquVezife.Items.Clear();

                txt_name_fredi.Text = "";
                txt_sname_ferdi.Text = "";
                sicraorqan = "";
                CheckBox13.Checked = false;
                CheckBox4.Checked = false;
                txt_meqsed.Text = "";
                txt_meqsed.Visible = false;
                txt_IcraOrqan.Text = "";
                txt_IcraOrqan.Visible = false;
                txt_Tutduqu_vezife.Text = "";
                txt_Tutduqu_vezife.Visible = false;
                CBMeqsed_ferdi.Visible = true;
                CBIcraOrqan.Visible = true;
                CBtutduquVezife.Visible = true;
            }
            else
            {
                lblmesag2.Text = "Məlumat tam deyil";
                lblmesag2.ForeColor = Color.Red;
            }
        }



    }

    protected void CheckBox4_CheckedChanged(object sender, EventArgs e)
    {
        if (CheckBox4.Checked == true)
        {
            selectIcraOrqan();
            this.CBIcraOrqan.Items.Insert(0, new ListItem("", "0"));
            this.CBIcraOrqan.SelectedIndex = 0;
            txt_IcraOrqan.Visible = true;
            txt_IcraOrqan.Text = "";
            CBIcraOrqan.Visible = false;
            this.CBtutduquVezife.Items.Clear();
            this.CBtutduquVezife.Items.Insert(0, new ListItem("", "0"));
            this.CBtutduquVezife.SelectedIndex = 0;
            txt_Tutduqu_vezife.Visible = true;
            txt_Tutduqu_vezife.Text = "";
            CBtutduquVezife.Visible = false;
        //    this.CBIcraOrqan.DropDownStyle = ComboBoxStyle.DropDown;
          //  this.CBtutduquVezife.DropDownStyle = ComboBoxStyle.DropDown;
        }
        else
        {
            selectIcraOrqan();
            this.CBIcraOrqan.SelectedIndex = -1;
            txt_IcraOrqan.Visible = false;
            txt_IcraOrqan.Text = "";
            CBIcraOrqan.Visible = true;
           // this.CBIcraOrqan.DropDownStyle = ComboBoxStyle.DropDownList;
            this.CBtutduquVezife.SelectedIndex = -1;
            txt_Tutduqu_vezife.Visible = false;
            txt_Tutduqu_vezife.Text = "";
            CBtutduquVezife.Visible = true;
            
         //   this.CBtutduquVezife.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
    protected void getmeqsed_ferdi()
    {
        DataTable IcraOrqan = klas.getdatatable("select * from List_classifications where ListID=43 order by sort");
        CBMeqsed_ferdi.Items.Clear();
        CBMeqsed_ferdi.SelectedIndex = -1;
        CBMeqsed_ferdi.DataTextField = "ClassifName";
        CBMeqsed_ferdi.DataValueField = "ClassifID";
        CBMeqsed_ferdi.DataSource = IcraOrqan;
        CBMeqsed_ferdi.DataBind();
        CBMeqsed_ferdi.Items.Insert(0, new ListItem("Seçin", "-1"));
        CBMeqsed_ferdi.SelectedIndex = -1;
    }
    protected void CheckBox13_CheckedChanged(object sender, EventArgs e)
    {
        if (CheckBox13.Checked == true)
        {
            getmeqsed_ferdi();
            this.CBMeqsed_ferdi.Items.Insert(0, new ListItem("", "0"));
            this.CBMeqsed_ferdi.SelectedIndex = 0;
            txt_meqsed.Visible = true;
            txt_meqsed.Text = "";
            CBMeqsed_ferdi.Visible = false;
          //  this.CBMeqsed_ferdi.DropDownStyle = ComboBoxStyle.DropDown;
        }
        else
        {
            getmeqsed_ferdi();
            this.CBMeqsed_ferdi.SelectedIndex = -1;
            txt_meqsed.Visible = false;
            txt_meqsed.Text = "";
            CBMeqsed_ferdi.Visible = true;
          //  this.CBMeqsed_ferdi.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
    protected void btngeri_Click(object sender, EventArgs e)
    {
        Response.Redirect("Ezamiyyənin_Planı.aspx?RegionCode=" + Session["RegionID"].ToString() + "&BusinessTripID=" + Session["BusinessTripID"].ToString() + "&RayonID1=" + Session["FRegionsId"].ToString());
    }
}