using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class adminpanel_Hesabatlar : System.Web.UI.Page
{
    Class2 klas = new Class2();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            LinkButton lblprofil = (LinkButton)Master.FindControl("Hesabattehlili");
            lblprofil.BackColor = Color.Peru;
            HttpRequest request = base.Request;
            string useraddress = request.UserHostAddress;
            if (useraddress == "192.168.150.17")
            {
                pnladm.Visible = false;
            }
            else if (useraddress == "192.168.150.77")
            {
                pnladm.Visible = false;
            }
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Muddetlertehlil.aspx?islem=rayon0");
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Gorulmuwiwtehlil.aspx?islem=rayon0");
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Response.Redirect("Ezmeqsedtehlil.aspx?islem=rayon0");
    }
    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        Response.Redirect("Yasmentehlil.aspx?islem=rayon0");
    }
    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        Response.Redirect("Istetdiyitedbirtehlil.aspx?islem=rayon0");
    }
    protected void LinkButton19_Click(object sender, EventArgs e)
    {
        Response.Redirect("IHBtehlil.aspx?islem=rayon0");
    }
    protected void LinkButton7_Click(object sender, EventArgs e)
    {
        Response.Redirect("Baxilmismestehlil.aspx?islem=rayon0");
    }
    protected void LinkButton6_Click(object sender, EventArgs e)
    {
        Response.Redirect("Isetmediyitedbirtehlil.aspx?islem=rayon0");
    }
    protected void LinkButton20_Click(object sender, EventArgs e)
    {
        Response.Redirect("Muzakireolmestehlil.aspx?islem=rayon0");
    }
    protected void LinkButton8_Click(object sender, EventArgs e)
    {
        Response.Redirect("Baxilmamismestehlil.aspx?islem=rayon0");
    }
    protected void LinkButton9_Click(object sender, EventArgs e)
    {
        Response.Redirect("Baxkecisttehlil.aspx?islem=rayon0");
    }
    protected void LinkButton10_Click(object sender, EventArgs e)
    {
        Response.Redirect("Baxkecesaslitobtehlil.aspx?islem=rayon0");
    }
    protected void LinkButton11_Click(object sender, EventArgs e)
    {
        Response.Redirect("Vetendawgoruwtehlil.aspx?islem=rayon0");
    }
    protected void LinkButton12_Click(object sender, EventArgs e)
    {
        Response.Redirect("Ictimaisiyasiveztehlil.aspx?islem=rayon0");
    }
    protected void LinkButton15_Click(object sender, EventArgs e)
    {
       Response.Redirect("Movcudeyanitehlil.aspx?islem=rayon0");
    }
    protected void LinkButton16_Click(object sender, EventArgs e)
    {
      Response.Redirect("Ferdisohbettehlil.aspx?islem=rayon0");
    }
    protected void LinkButton17_Click(object sender, EventArgs e)
    {
        Response.Redirect("Ihtovsiyetehlil.aspx?islem=rayon0");
    }
    protected void LinkButton13_Click(object sender, EventArgs e)
    {
        Response.Redirect("Sosialhumtehlil.aspx?islem=rayon0");
    }
    protected void LinkButton14_Click(object sender, EventArgs e)
    {
        Response.Redirect("Iqtisadisahibktehlil.aspx?islem=rayon0");
    }
    protected void LinkButton6_Click1(object sender, EventArgs e)
    {
        Response.Redirect("Ezmeqsedplantehlil.aspx?islem=rayon0");
    }
    protected void LinkButton25_Click(object sender, EventArgs e)
    {
        Response.Redirect("Gordukleriiwtehlil.aspx?islem=rayon0");
    }
    protected void LinkButton6_Click2(object sender, EventArgs e)
    {
        Response.Redirect("Meqsedezamsay.aspx?islem=rayon0");
    }
}