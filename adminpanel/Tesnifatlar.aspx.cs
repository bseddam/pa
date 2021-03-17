using System;
using System.Collections.Generic;
using System.Drawing;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class adminpanel_Tesnifatlar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        LinkButton lblvizual = (LinkButton)Master.Master.FindControl("Tesnifatlar");
        lblvizual.BackColor = Color.Peru;
    
    }
}