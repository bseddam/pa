using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class adminpanel_YasmenIhbtehlil : System.Web.UI.Page
{
    Class2 klas = new Class2(); string islem; string UserID; string RegionID; string BusinessTripID; string tarix1; string tarix2;
    string tarix3; string tarix4;
   
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            islem = Request.QueryString["islem"];
            UserID = Request.QueryString["UserID"];
            RegionID = Request.QueryString["RegionID"];
            BusinessTripID = Request.QueryString["BusinessTripID"];
            tarix1 = Request.QueryString["tarix1"];
            tarix2 = Request.QueryString["tarix2"];
            tarix3 = Request.QueryString["tarix3"];
            tarix4 = Request.QueryString["tarix4"];
        }
        catch (Exception)
        {
            throw;
        }
        Calendar1.SelectedDates.Clear();
        Calendar3.SelectedDates.Clear();




        if (Page.IsPostBack == false)
        {


            LinkButton lblprofil = (LinkButton)Master.FindControl("Hesabattehlili");
            lblprofil.BackColor = Color.Peru;
            if (UserID != null)
            {
                lbluseradi.Text = klas.getdatacell(@"Select Name+' '+Sname from Users where UserID=" + UserID);
            }

            if (islem == "rayon0")
            {
                ryn();
                ddlryn.SelectedValue = RegionID;
                lblgelme1.Text = tarix1;
                lblgetme1.Text = tarix2;
                lblgelme.Text = tarix3;
                lblgetme.Text = tarix4;
                if (lblgelme.Text != "")
                {
                    imgbsilgelme.Visible = true;
                }
                else
                {
                    imgbsilgelme.Visible = false;
                }
                if (lblgetme.Text != "")
                {
                    imgbsilgetme0.Visible = true;
                }
                else
                {
                    imgbsilgetme0.Visible = false;
                }
                birinci();

            }
            if (islem == "rayon1")
            {
                ryn();
                ddlryn.SelectedValue = RegionID;
                lblgelme1.Text = tarix1;
                lblgetme1.Text = tarix2;
                lblgelme.Text = tarix3;
                lblgetme.Text = tarix4;
                if (lblgelme.Text != "")
                {
                    imgbsilgelme.Visible = true;
                }
                else
                {
                    imgbsilgelme.Visible = false;
                }
                if (lblgetme.Text != "")
                {
                    imgbsilgetme0.Visible = true;
                }
                else
                {
                    imgbsilgetme0.Visible = false;
                }
                ikinci();

            }
            if (islem == "rayon2")
            {
                ryn();

                ddlryn.SelectedValue = RegionID;
                lblgelme1.Text = tarix1;
                lblgetme1.Text = tarix2;
                lblgelme.Text = tarix3;
                lblgetme.Text = tarix4;
                if (lblgelme.Text != "")
                {
                    imgbsilgelme.Visible = true;
                }
                else
                {
                    imgbsilgelme.Visible = false;
                }
                if (lblgetme.Text != "")
                {
                    imgbsilgetme0.Visible = true;
                }
                else
                {
                    imgbsilgetme0.Visible = false;
                }
                ucuncu();

            }








            if (islem == "rayon20")
            {
                ryn();

                ddlryn.SelectedValue = RegionID;
                lblgelme1.Text = tarix1;
                lblgetme1.Text = tarix2;
                lblgelme.Text = tarix3;
                lblgetme.Text = tarix4;
                if (lblgelme.Text != "")
                {
                    imgbsilgelme.Visible = true;
                }
                else
                {
                    imgbsilgelme.Visible = false;
                }
                if (lblgetme.Text != "")
                {
                    imgbsilgetme0.Visible = true;
                }
                else
                {
                    imgbsilgetme0.Visible = false;
                }
                ucuncu0();

            }

            if (islem == "rayon21")
            {
                ryn();

                ddlryn.SelectedValue = RegionID;
                lblgelme1.Text = tarix1;
                lblgetme1.Text = tarix2;
                lblgelme.Text = tarix3;
                lblgetme.Text = tarix4;
                if (lblgelme.Text != "")
                {
                    imgbsilgelme.Visible = true;
                }
                else
                {
                    imgbsilgelme.Visible = false;
                }
                if (lblgetme.Text != "")
                {
                    imgbsilgetme0.Visible = true;
                }
                else
                {
                    imgbsilgetme0.Visible = false;
                }
                ucuncu1();

            }
            if (islem == "rayon22")
            {
                ryn();

                ddlryn.SelectedValue = RegionID;
                lblgelme1.Text = tarix1;
                lblgetme1.Text = tarix2;
                lblgelme.Text = tarix3;
                lblgetme.Text = tarix4;
                if (lblgelme.Text != "")
                {
                    imgbsilgelme.Visible = true;
                }
                else
                {
                    imgbsilgelme.Visible = false;
                }
                if (lblgetme.Text != "")
                {
                    imgbsilgetme0.Visible = true;
                }
                else
                {
                    imgbsilgetme0.Visible = false;
                }
                ucuncu2();

            }


            if (islem == "rayon3")
            {
                ryn();
                ddlryn.SelectedValue = RegionID;
                lblgelme1.Text = tarix1;
                lblgetme1.Text = tarix2;
                lblgelme.Text = tarix3;
                lblgetme.Text = tarix4;
                if (lblgelme.Text != "")
                {
                    imgbsilgelme.Visible = true;
                }
                else
                {
                    imgbsilgelme.Visible = false;
                }
                if (lblgetme.Text != "")
                {
                    imgbsilgetme0.Visible = true;
                }
                else
                {
                    imgbsilgetme0.Visible = false;
                }
                dorduncu();

            }
            if (islem == "rayon4")
            {
                ryn();

                ddlryn.SelectedValue = RegionID;
                lblgelme1.Text = tarix1;
                lblgetme1.Text = tarix2;
                lblgelme.Text = tarix3;
                lblgetme.Text = tarix4;
                if (lblgelme.Text != "")
                {
                    imgbsilgelme.Visible = true;
                }
                else
                {
                    imgbsilgelme.Visible = false;
                }
                if (lblgetme.Text != "")
                {
                    imgbsilgetme0.Visible = true;
                }
                else
                {
                    imgbsilgetme0.Visible = false;
                }
                besinci();

            }
            if (islem == "rayon5")
            {
                ryn();
                ddlryn.SelectedValue = RegionID;
                lblgelme1.Text = tarix1;
                lblgetme1.Text = tarix2;
                lblgelme.Text = tarix3;
                lblgetme.Text = tarix4;
                if (lblgelme.Text != "")
                {
                    imgbsilgelme.Visible = true;
                }
                else
                {
                    imgbsilgelme.Visible = false;
                }
                if (lblgetme.Text != "")
                {
                    imgbsilgetme0.Visible = true;
                }
                else
                {
                    imgbsilgetme0.Visible = false;
                }
                altinci();

            }
            if (islem == "rayon6")
            {
                ryn();
                ddlryn.SelectedValue = RegionID;
                lblgelme1.Text = tarix1;
                lblgetme1.Text = tarix2;
                lblgelme.Text = tarix3;
                lblgetme.Text = tarix4;
                if (lblgelme.Text != "")
                {
                    imgbsilgelme.Visible = true;
                }
                else
                {
                    imgbsilgelme.Visible = false;
                }
                if (lblgetme.Text != "")
                {
                    imgbsilgetme0.Visible = true;
                }
                else
                {
                    imgbsilgetme0.Visible = false;
                }
                yeddinci();

            }
            if (islem == "rayon7")
            {
                ryn();
                ddlryn.SelectedValue = RegionID;
                lblgelme1.Text = tarix1;
                lblgetme1.Text = tarix2;
                lblgelme.Text = tarix3;
                lblgetme.Text = tarix4;
                if (lblgelme.Text != "")
                {
                    imgbsilgelme.Visible = true;
                }
                else
                {
                    imgbsilgelme.Visible = false;
                }
                if (lblgetme.Text != "")
                {
                    imgbsilgetme0.Visible = true;
                }
                else
                {
                    imgbsilgetme0.Visible = false;
                }
                sekkizinci();
            }
            if (islem == "rayon8")
            {
                ryn();
                ddlryn.SelectedValue = RegionID;
                lblgelme1.Text = tarix1;
                lblgetme1.Text = tarix2;
                lblgelme.Text = tarix3;
                lblgetme.Text = tarix4;
                if (lblgelme.Text != "")
                {
                    imgbsilgelme.Visible = true;
                }
                else
                {
                    imgbsilgelme.Visible = false;
                }
                if (lblgetme.Text != "")
                {
                    imgbsilgetme0.Visible = true;
                }
                else
                {
                    imgbsilgetme0.Visible = false;
                }
                doqquzuncu();
            }
        }

    }
    void birinci()
    {
        Panel1.Visible = true;
        Panel2.Visible = false;
        Panel3.Visible = false;
        Panel4.Visible = false;
        string rayon;
        string rayon1;


        if (ddlryn.SelectedValue == "0" || ddlryn.SelectedValue == "-1" || ddlryn.SelectedValue == "")
        {
            rayon = "  ";
            rayon1 = "  ";
        }
        else
        {
            rayon = " and bis.RegionID='" + ddlryn.SelectedValue + "' ";
            rayon1 = " and btr.RegionID='" + ddlryn.SelectedValue + "' ";
        }
        string tarixs1 = "";
        string tarixs2 = "";
        string tarixs11 = "";
        string tarixs22 = "";
        if (lblgetme1.Text != "")
        {
            tarixs1 = " and bis.GoFromRegion <='" + lblgetme1.Text + "'";
            tarixs11 = "and btr.GoFromRegion <='" + lblgetme1.Text + "'";
        }
        if (lblgelme1.Text != "")
        {
            tarixs2 = "and bis.RegionCome >= '" + lblgelme1.Text + "'";
            tarixs22 = "and btr.RegionCome >='" + lblgelme1.Text + "'";
        }


//        DataTable region2 = klas.getdatatable(@"select  DISTINCT  UserID,Name,rayonsayim,(select COUNT(*) as Setrsayi  from 
//     (SELECT     r.BusinessTripID FROM       Conn_PurposeOfTrip as r INNER JOIN
// business_trip as bis ON r.BusinessTripID = bis.BusinessTripID   " + tarixs2 + " " +
//" " + tarixs1 + "  " + rayon + "  " +
//"  INNER JOIN Users as us ON bis.UserID = us.UserID and (us.UserID=i.UserID)) as f) as umumimeqsedsay from " +
//"(SELECT     DISTINCT  bt1.RegionID, bt1.BusinessTripID, U.Name + ' ' + u.Sname AS Name, U.UserID, " +
//"(select count(*) from (SELECT     DISTINCT  btr.RegionID, btr.BusinessTripID,  " +
//" usr.Name + ' ' + usr.Sname AS Name, usr.UserID  FROM         business_trip as  btr " +
//"INNER JOIN Users as usr ON btr.UserID = usr.UserID and usr.UserID=u.UserID " +
//"where 1=1 " + tarixs22 + " " + tarixs11 + " " +
//" " + rayon1 + "  " + " group by RegionID,btr.BusinessTripID,usr.Name,usr.Sname,usr.UserID) as t) " +
//"as rayonsayim FROM  business_trip as bt1 " +
//" INNER JOIN Users as u ON bt1.UserID = U.UserID  group by RegionID,bt1.BusinessTripID,U.Name,U.Sname,U.UserID)as i");


        DataTable region2 = klas.getdatatable(@"select  DISTINCT  UserID,Name,rayonsayim, (select COUNT(*) as Setrsayi  from 
     (SELECT     r.BusinessTripID FROM       Conn_delegate_IHB  as r INNER JOIN
 business_trip as bis ON r.BusinessTripID = bis.BusinessTripID "+tarixs2+" "+tarixs1+ "  " +rayon+
"  and r.IshtirakYesNo='false' "+
"INNER JOIN Users as us ON bis.UserID = us.UserID and (us.UserID=i.UserID)) as f) as ihbsayi0 "+
",(select COUNT(*) as Setrsayi  from "+
"(SELECT     r.BusinessTripID FROM       Conn_delegate_IHB  as r INNER JOIN "+
" business_trip as bis ON r.BusinessTripID = bis.BusinessTripID  " + tarixs2 + " " + tarixs1 + "  " + rayon +
"  and r.IshtirakYesNo='true' "+
"  INNER JOIN Users as us ON bis.UserID = us.UserID and (us.UserID=i.UserID)) as f) as ihbsayi1 "+
",(select COUNT(*) as Setrsayi  from "+
"(SELECT     r.BusinessTripID FROM       Conn_living  as r INNER JOIN "+
"business_trip as bis ON r.BusinessTripID = bis.BusinessTripID  " + tarixs2 + " " + tarixs1 + "  " + rayon +
" and r.IshtirakYesNo='false' "+
" INNER JOIN Users as us ON bis.UserID = us.UserID and (us.UserID=i.UserID)) as f) as yawmensayi0 "+

",(select COUNT(*) as Setrsayi  from  "+
"(SELECT     r.BusinessTripID FROM       Conn_living  as r INNER JOIN "+
"business_trip as bis ON r.BusinessTripID = bis.BusinessTripID  " + tarixs2 + " " + tarixs1 + "  " + rayon +
" and r.IshtirakYesNo='true' "+
" INNER JOIN Users as us ON bis.UserID = us.UserID and (us.UserID=i.UserID)) as f) as yawmensayi1 "+
"from  (SELECT     DISTINCT  bt1.RegionID, bt1.BusinessTripID, U.Name + ' ' + u.Sname AS Name, U.UserID, "+
"(select count(*) from (SELECT     DISTINCT  btr.RegionID, btr.BusinessTripID,  "+
" usr.Name + ' ' + usr.Sname AS Name, usr.UserID  FROM         business_trip as  btr "+
"INNER JOIN Users as usr ON btr.UserID = usr.UserID and usr.UserID=u.UserID "+
" where 1=1 " + tarixs22 + " " + tarixs11 + "  " + rayon1 +
"group by RegionID,btr.BusinessTripID,usr.Name,usr.Sname,usr.UserID) as t) "+
" as rayonsayim FROM  business_trip as bt1 "+
" INNER JOIN Users as u ON bt1.UserID = U.UserID  group by RegionID,bt1.BusinessTripID,U.Name,U.Sname,U.UserID)as i");

        DataList1.DataSource = region2;
        DataList1.DataBind();


        if (region2.Rows.Count > 0)
        {

            lblmesage.Text = "";
            exele.Visible = true;
        }
        else
        {

            lblmesage.Text = "Tapılmadı";
            lblmesage.ForeColor = Color.Red;
            exele.Visible = false;
            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = false;
            Panel4.Visible = false;
        }

    }
    void ikinci()
    {
        Panel1.Visible = false;
        Panel2.Visible = true;
        Panel3.Visible = false;
        Panel4.Visible = false;
        string rayon;
        string user1;
        string user21;
        string rayon1;
        if (ddlryn.SelectedValue == "0" || ddlryn.SelectedValue == "-1" || ddlryn.SelectedValue == "")
        {
            rayon = "  ";
            rayon1 = "  ";
        }
        else
        {
            rayon = " and t.RegionID='" + ddlryn.SelectedValue + "' ";
            rayon1 = " and b.RegionID='" + ddlryn.SelectedValue + "' ";
        }


        user1 = " and t.UserID='" + UserID + "' ";
        user21 = " and b.UserID='" + UserID + "' ";



        string tarixs1 = "";
        string tarixs2 = "";
        string tarixs11 = "";
        string tarixs22 = "";
        if (lblgetme1.Text != "")
        {
            tarixs1 = " and t.GoFromRegion <='" + lblgetme1.Text + "'";
            tarixs11 = " and b.GoFromRegion <='" + lblgetme1.Text + "'";
        }
        if (lblgelme1.Text != "")
        {
            tarixs2 = "and t.RegionCome >='" + lblgelme1.Text + "'";
            tarixs22 = "and b.RegionCome >='" + lblgelme1.Text + "'";
        }
//        DataTable region2 = klas.getdatatable(@"select rayonagetmesayi,RegionID,Regions,UserID,
//case when meqsedsay is null then 0  else meqsedsay end as meqsedsay from( 
//select case when rayonagetmesayi is null then 0  else rayonagetmesayi end as rayonagetmesayi,
//RegionID,Regions,UserID,meqsedsay from (
//select COUNT(*) as rayonagetmesayi,RegionID,Regions,UserID from 
//(SELECT   distinct  t.Regions, t.RegionID,t.UserID,t.BusinessTripID
//FROM  business_trip as t where 1=1 "
//+ tarixs2 + " " + tarixs1 + " " + user1 + "  " + rayon + "   ) as z group by RegionID,Regions,UserID) as ll left join " +
//"(select * from ( select distinct RegionID RegionID1,Regions Regions1,UserID UserID1 from  business_trip as b " +
//"where 1=1 " + user21 + " " + tarixs22 + " " + tarixs11 + "  " + rayon1 + "  ) as d full join " +
//"(select COUNT(*) meqsedsay,RegionID RegionID2,Regions Regions2,UserID UserID2 from  business_trip as b " +
//"inner  join Conn_PurposeOfTrip as c on b.BusinessTripID=c.BusinessTripID  " +
//" where  1=1 " + user21 + " " + tarixs22 + " " + tarixs11 + "  " + rayon1 + "  " +
//"group by RegionID,Regions,UserID) as k on k.RegionID2=d.RegionID1) as sa  on ll.RegionID=sa.RegionID1 ) as sss");
        DataTable region2 = klas.getdatatable(@"select rayonagetmesayi,RegionID,Regions,UserID,
case when ihb1 is null then 0  else ihb1 end as ihb1,
case when ihb0 is null then 0  else ihb0 end as ihb0,
case when yawmensayi1 is null then 0  else yawmensayi1 end as yawmensayi1,
case when yawmensayi0 is null then 0  else yawmensayi0 end as yawmensayi0
 from
(
select case when rayonagetmesayi is null then 0  else rayonagetmesayi end as rayonagetmesayi,
RegionID,Regions,UserID,ihb1,ihb0,yawmensayi0,yawmensayi1 from (
select COUNT(*) as rayonagetmesayi,RegionID,Regions,UserID from 
(

SELECT   distinct  t.Regions, t.RegionID,t.UserID,t.BusinessTripID
FROM  business_trip as t where 1=1   "+ tarixs2 + " " + tarixs1 + " " + user1 + "  " + rayon +
") as z group by RegionID,Regions,UserID) as ll "+
"left join ( "+
"select * from ( select distinct RegionID RegionID1,Regions Regions1,UserID UserID1 from  business_trip as b "+
"where 1=1 " + user21 + " " + tarixs22 + " " + tarixs11 + "  ) as d "+

"full join ( "+
"select COUNT(*) ihb1,RegionID RegionID2,Regions Regions2,UserID UserID2 from  business_trip as b  "+
"inner  join Conn_delegate_IHB as c on b.BusinessTripID=c.BusinessTripID   "+
"where 1=1 " + user21 + " " + tarixs22 + " " + tarixs11 + "   and c.IshtirakYesNo='true' "+
"group by RegionID,Regions,UserID) as k on k.RegionID2=d.RegionID1 "+


"full join ( "+
"select COUNT(*) ihb0,RegionID RegionID3,Regions Regions3,UserID UserID3 from  business_trip as b  "+
"inner  join Conn_delegate_IHB as c on b.BusinessTripID=c.BusinessTripID   "+
"where  1=1 " + user21 + " " + tarixs22 + " " + tarixs11 + " and c.IshtirakYesNo='false' " +
"group by RegionID,Regions,UserID) as ihb0 on ihb0.RegionID3=d.RegionID1 "+

"full join ( "+
"select COUNT(*) yawmensayi1,RegionID RegionID4,Regions Regions4,UserID UserID4 from  business_trip as b "+
"inner  join Conn_living as c on b.BusinessTripID=c.BusinessTripID    "+
"where 1=1 " + user21 + " " + tarixs22 + " " + tarixs11 + " and c.IshtirakYesNo='true' " +
"group by RegionID,Regions,UserID) as yawmensayi1 on yawmensayi1.RegionID4=d.RegionID1 "+

"full join ( "+
"select COUNT(*) yawmensayi0,RegionID RegionID5,Regions Regions5,UserID UserID5 from  business_trip as b  "+
"inner  join Conn_living as c on b.BusinessTripID=c.BusinessTripID   "+
"where 1=1 " + user21 + " " + tarixs22 + " " + tarixs11 + " and c.IshtirakYesNo='false' " +
"group by RegionID,Regions,UserID) as yawmensayi0 on yawmensayi0.RegionID5=d.RegionID1 ) as sa  on ll.RegionID=sa.RegionID1) "+
"as sss order by rayonagetmesayi");
        DataList2.DataSource = region2;
        DataList2.DataBind();


        if (region2.Rows.Count > 0)
        {

            lblmesage.Text = "";
            exele.Visible = true;
        }
        else
        {

            lblmesage.Text = "Tapılmadı";
            lblmesage.ForeColor = Color.Red;
            exele.Visible = false;
            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = false;
            Panel4.Visible = false;
        }

    }
    void ucuncu()
    {
        Panel1.Visible = false;
        Panel2.Visible = false;
        Panel3.Visible = true;
        Panel4.Visible = false;
        string rayon;
        string user1;
        if (ddlryn.SelectedValue == "0" || ddlryn.SelectedValue == "-1" || ddlryn.SelectedValue == "")
        {
            rayon = "  ";
        }
        else
        {
            rayon = " and b.RegionID='" + ddlryn.SelectedValue + "'  ";
        }

        user1 = " and b.UserID='" + UserID + "' ";

        string tarixs11 = "";
        string tarixs22 = "";
        if (lblgetme1.Text != "")
        {
            tarixs11 = " and b.GoFromRegion <='" + lblgetme1.Text + "'";
        }
        if (lblgelme1.Text != "")
        {
            tarixs22 = "and b.RegionCome >='" + lblgelme1.Text + "'";
        }

        DataTable region2 = klas.getdatatable(@"select * from 
(select COUNT(*) as rayonsayi,RegionID,Regions,UserID,DelegateOther as Other,RegionCome,GoFromRegion
 from 
(SELECT distinct b.BusinessTripID,b.Regions, b.RegionID,b.UserID,c.DelegateOther,b.RegionCome,b.GoFromRegion FROM  business_trip as b INNER JOIN
      Conn_delegate_IHB as c ON b.BusinessTripID = c.BusinessTripID " + user1 + " " + rayon + " " +
        " " + tarixs22 + " " + tarixs11 + " and c.IshtirakYesNo='true') as i " +
        "group  by RegionID,Regions,UserID,DelegateOther,RegionCome,GoFromRegion) as l " +
        "INNER JOIN (SELECT     b.RegionID,b.UserID,COUNT(*) as meqsedsayi " +
        "FROM  business_trip as b INNER JOIN " +
        "Conn_delegate_IHB as c ON b.BusinessTripID = c.BusinessTripID  " +
        " " + user1 + " " + rayon + "  " + tarixs22 + " " + tarixs11 + "  and c.IshtirakYesNo='true'" +
        "group by b.RegionID,b.Regions, b.UserID) as j ON j.RegionID=l.RegionID order by RegionCome desc");





        DataList3.DataSource = region2;
        DataList3.DataBind();
        if (region2.Rows.Count > 0)
        {

            lblmesage.Text = "";
            exele.Visible = true;
        }
        else
        {

            lblmesage.Text = "Tapılmadı";
            lblmesage.ForeColor = Color.Red;
            exele.Visible = false;
            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = false;
            Panel4.Visible = false;
        }

    }



    void ucuncu0()
    {
        Panel1.Visible = false;
        Panel2.Visible = false;
        Panel3.Visible = true;
        Panel4.Visible = false;
        string rayon;
        string user1;
        if (ddlryn.SelectedValue == "0" || ddlryn.SelectedValue == "-1" || ddlryn.SelectedValue == "")
        {
            rayon = "  ";
        }
        else
        {
            rayon = " and b.RegionID='" + ddlryn.SelectedValue + "'  ";
        }

        user1 = " and b.UserID='" + UserID + "' ";

        string tarixs11 = "";
        string tarixs22 = "";
        if (lblgetme1.Text != "")
        {
            tarixs11 = " and b.GoFromRegion <='" + lblgetme1.Text + "'";
        }
        if (lblgelme1.Text != "")
        {
            tarixs22 = "and b.RegionCome >='" + lblgelme1.Text + "'";
        }

        DataTable region2 = klas.getdatatable(@"select * from 
(select COUNT(*) as rayonsayi,RegionID,Regions,UserID,DelegateOther as Other,RegionCome,GoFromRegion from 
(SELECT distinct b.BusinessTripID,b.Regions, b.RegionID,b.UserID,c.DelegateOther,b.RegionCome,b.GoFromRegion FROM  business_trip as b INNER JOIN
      Conn_delegate_IHB as c ON b.BusinessTripID = c.BusinessTripID " + user1 + " " + rayon + " " +
        " " + tarixs22 + " " + tarixs11 + " and c.IshtirakYesNo='false') as i " +
        "group  by RegionID,Regions,UserID,DelegateOther,RegionCome,GoFromRegion) as l " +
        "INNER JOIN (SELECT     b.RegionID,b.UserID,COUNT(*) as meqsedsayi " +
        "FROM  business_trip as b INNER JOIN " +
        "Conn_delegate_IHB as c ON b.BusinessTripID = c.BusinessTripID  " +
        " " + user1 + " " + rayon + "  " + tarixs22 + " " + tarixs11 + "  and c.IshtirakYesNo='false'" +
        "group by b.RegionID,b.Regions, b.UserID) as j ON j.RegionID=l.RegionID order by RegionCome desc");







        DataList3.DataSource = region2;
        DataList3.DataBind();
        if (region2.Rows.Count > 0)
        {

            lblmesage.Text = "";
            exele.Visible = true;
        }
        else
        {

            lblmesage.Text = "Tapılmadı";
            lblmesage.ForeColor = Color.Red;
            exele.Visible = false;
            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = false;
            Panel4.Visible = false;
        }

    }







    void ucuncu1()
    {
        Panel1.Visible = false;
        Panel2.Visible = false;
        Panel3.Visible = true;
        Panel4.Visible = false;
        string rayon;
        string user1;
        if (ddlryn.SelectedValue == "0" || ddlryn.SelectedValue == "-1" || ddlryn.SelectedValue == "")
        {
            rayon = "  ";
        }
        else
        {
            rayon = " and b.RegionID='" + ddlryn.SelectedValue + "'  ";
        }

        user1 = " and b.UserID='" + UserID + "' ";

        string tarixs11 = "";
        string tarixs22 = "";
        if (lblgetme1.Text != "")
        {
            tarixs11 = " and b.GoFromRegion <='" + lblgetme1.Text + "'";
        }
        if (lblgelme1.Text != "")
        {
            tarixs22 = "and b.RegionCome >='" + lblgelme1.Text + "'";
        }

        DataTable region2 = klas.getdatatable(@"select * from 
(select COUNT(*) as rayonsayi,RegionID,Regions,UserID,LivingOther as Other,RegionCome,GoFromRegion from 
(SELECT distinct b.BusinessTripID,b.Regions, b.RegionID,b.UserID,c.LivingOther,b.RegionCome,b.GoFromRegion FROM  business_trip as b INNER JOIN
      Conn_living as c ON b.BusinessTripID = c.BusinessTripID " + user1 + " " + rayon + " " +
        " " + tarixs22 + " " + tarixs11 + " and c.IshtirakYesNo='true') as i " +
        "group  by RegionID,Regions,UserID,LivingOther,RegionCome,GoFromRegion) as l " +
        "INNER JOIN (SELECT     b.RegionID,b.UserID,COUNT(*) as meqsedsayi " +
        "FROM  business_trip as b INNER JOIN " +
        "Conn_living as c ON b.BusinessTripID = c.BusinessTripID  " +
        " " + user1 + " " + rayon + "  " + tarixs22 + " " + tarixs11 + "  and c.IshtirakYesNo='true'" +
        "group by b.RegionID,b.Regions, b.UserID) as j ON j.RegionID=l.RegionID order by RegionCome desc");



        DataList3.DataSource = region2;
        DataList3.DataBind();
        if (region2.Rows.Count > 0)
        {

            lblmesage.Text = "";
            exele.Visible = true;
        }
        else
        {

            lblmesage.Text = "Tapılmadı";
            lblmesage.ForeColor = Color.Red;
            exele.Visible = false;
            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = false;
            Panel4.Visible = false;
        }

    }






    void ucuncu2()
    {
        Panel1.Visible = false;
        Panel2.Visible = false;
        Panel3.Visible = true;
        Panel4.Visible = false;
        string rayon;
        string user1;
        if (ddlryn.SelectedValue == "0" || ddlryn.SelectedValue == "-1" || ddlryn.SelectedValue == "")
        {
            rayon = "  ";
        }
        else
        {
            rayon = " and b.RegionID='" + ddlryn.SelectedValue + "'  ";
        }

        user1 = " and b.UserID='" + UserID + "' ";

        string tarixs11 = "";
        string tarixs22 = "";
        if (lblgetme1.Text != "")
        {
            tarixs11 = " and b.GoFromRegion <='" + lblgetme1.Text + "'";
        }
        if (lblgelme1.Text != "")
        {
            tarixs22 = "and b.RegionCome >='" + lblgelme1.Text + "'";
        }

        DataTable region2 = klas.getdatatable(@"select * from 
(select COUNT(*) as rayonsayi,RegionID,Regions,UserID,LivingOther as Other,RegionCome,GoFromRegion from 
(SELECT distinct b.BusinessTripID,b.Regions, b.RegionID,b.UserID,c.LivingOther,b.RegionCome,b.GoFromRegion FROM  business_trip as b INNER JOIN
      Conn_living as c ON b.BusinessTripID = c.BusinessTripID " + user1 + " " + rayon + " " +
        " " + tarixs22 + " " + tarixs11 + " and c.IshtirakYesNo='false') as i " +
        "group  by RegionID,Regions,UserID,LivingOther,RegionCome,GoFromRegion) as l " +
        "INNER JOIN (SELECT     b.RegionID,b.UserID,COUNT(*) as meqsedsayi " +
        "FROM  business_trip as b INNER JOIN " +
        "Conn_living as c ON b.BusinessTripID = c.BusinessTripID  " +
        " " + user1 + " " + rayon + "  " + tarixs22 + " " + tarixs11 + "  and c.IshtirakYesNo='false'" +
        "group by b.RegionID,b.Regions, b.UserID) as j ON j.RegionID=l.RegionID order by RegionCome desc");



        DataList3.DataSource = region2;
        DataList3.DataBind();
        if (region2.Rows.Count > 0)
        {

            lblmesage.Text = "";
            exele.Visible = true;
        }
        else
        {

            lblmesage.Text = "Tapılmadı";
            lblmesage.ForeColor = Color.Red;
            exele.Visible = false;
            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = false;
            Panel4.Visible = false;
        }

    }









    void dorduncu()
    {
        Panel1.Visible = false;
        Panel2.Visible = false;
        Panel3.Visible = false;
        Panel4.Visible = true;
        string rayon;
        string rayon1;
        string user1;
        string user2;
        if (ddlryn.SelectedValue == "0" || ddlryn.SelectedValue == "-1" || ddlryn.SelectedValue == "")
        {
            rayon = "  ";
            rayon1 = "  ";
        }
        else
        {
            rayon = " and b.RegionID='" + ddlryn.SelectedValue + "'  ";
            rayon1 = " and t.RegionID='" + ddlryn.SelectedValue + "'  ";
        }


        user1 = " and t.UserID='" + UserID + "' ";
        user2 = " and b.UserID='" + UserID + "' ";


        string tarixs1 = "";
        string tarixs2 = "";
        string tarixs11 = "";
        string tarixs22 = "";
        if (lblgetme1.Text != "")
        {
            tarixs1 = " and t.GoFromRegion <='" + lblgetme1.Text + "'";
            tarixs11 = "and b.GoFromRegion <='" + lblgetme1.Text + "'";
        }
        if (lblgelme1.Text != "")
        {
            tarixs2 = "and t.RegionCome >='" + lblgelme1.Text + "'";
            tarixs22 = "and b.RegionCome >='" + lblgelme1.Text + "'";
        }

//        DataTable region2 = klas.getdatatable(@"select BusinessTripID1 BusinessTripID,UserID1 UserID,Regions1 Regions,RegionCome,GoFromRegion,ComingToWork,r1.RegionID,
//case when meqsedsay is null then 0  else meqsedsay end as meqsedsay
// from (
//select BusinessTripID BusinessTripID1,UserID UserID1,Regions Regions1,RegionCome,GoFromRegion,ComingToWork,RegionID from business_trip b 
//where 1=1 " + rayon + "  " +
//  " " + user2 + " " + tarixs22 + " " + tarixs11 + " " +
//   " ) as r1 full join (select * from  (SELECT COUNT(*) as meqsedsay, t.BusinessTripID, t.RegionID, t.Regions, " +
//   "t.UserID FROM  business_trip as t INNER JOIN Conn_PurposeOfTrip as c ON t.BusinessTripID = c.BusinessTripID where " +
//   "1=1 " + tarixs2 + " " + tarixs1 + " " + user1 + "  " + rayon1 + " " +
//"group by t.BusinessTripID, t.RegionID, t.Regions, t.UserID ) as cc1) as cs on r1.BusinessTripID1=cs.BusinessTripID order by RegionCome desc");

        DataTable region2 = klas.getdatatable(@"

select BusinessTripID1 BusinessTripID,UserID1 UserID,Regions1 Regions,RegionCome,GoFromRegion,ComingToWork,r1.RegionID,
case when ihb0 is null then 0  else ihb0 end as ihb0 ,
case when ihb1 is null then 0  else ihb1 end as ihb1,
case when yawmensayi0 is null then 0  else yawmensayi0 end as yawmensayi0,
case when yawmensayi1 is null then 0  else yawmensayi1 end as yawmensayi1 from (
select BusinessTripID BusinessTripID1,UserID UserID1,Regions Regions1,RegionCome,GoFromRegion,ComingToWork,RegionID
 from business_trip b  where 1=1  " + user2 + " " + rayon + "  " + tarixs22 + " " + tarixs11 + ") as r1 " +
"full join(select * from (SELECT COUNT(*) as ihb1, b.BusinessTripID, b.RegionID, b.Regions, " +
" b.UserID FROM  business_trip as b INNER JOIN Conn_delegate_IHB as c ON b.BusinessTripID = c.BusinessTripID where 1=1  " +
" " + user2 + " " + rayon + "  " + tarixs22 + " " + tarixs11 + " and c.IshtirakYesNo='false' " +
"group by b.BusinessTripID, b.RegionID, b.Regions, b.UserID ) as cc1) as cs on r1.BusinessTripID1=cs.BusinessTripID " +


"full join(select * from (SELECT COUNT(*) as ihb0, b.BusinessTripID, b.RegionID, b.Regions,  " +
"b.UserID FROM  business_trip as b INNER JOIN Conn_delegate_IHB as c ON b.BusinessTripID = c.BusinessTripID where 1=1  " +
" " + user2 + " " + rayon + "  " + tarixs22 + " " + tarixs11 + " and c.IshtirakYesNo='true' " +
" group by b.BusinessTripID, b.RegionID, b.Regions, b.UserID ) as cc1  ) as cs1 on r1.BusinessTripID1=cs1.BusinessTripID  " +

" full join(select * from (SELECT COUNT(*) as yawmensayi0, b.BusinessTripID, b.RegionID, b.Regions, " +
" b.UserID FROM  business_trip as b INNER JOIN Conn_living as c ON b.BusinessTripID = c.BusinessTripID where 1=1" +
" " + user2 + " " + rayon + "  " + tarixs22 + " " + tarixs11 + " and c.IshtirakYesNo='false' " +
" group by b.BusinessTripID, b.RegionID, b.Regions, b.UserID  ) as cc1 ) as cs2 on r1.BusinessTripID1=cs2.BusinessTripID " +

" full join(select * from (SELECT COUNT(*) as yawmensayi1, b.BusinessTripID, b.RegionID, b.Regions,  " +
" b.UserID FROM  business_trip as b INNER JOIN Conn_living as c ON b.BusinessTripID = c.BusinessTripID where 1=1  " +
" " + user2 + " " + rayon + "  " + tarixs22 + " " + tarixs11 + " and c.IshtirakYesNo='true' " +
" group by b.BusinessTripID, b.RegionID, b.Regions, b.UserID ) as cc1    " +
  "     ) as cs3 on r1.BusinessTripID1=cs3.BusinessTripID  order by RegionCome");





        DataList4.DataSource = region2;
        DataList4.DataBind();
        if (region2.Rows.Count > 0)
        {

            lblmesage.Text = "";
            exele.Visible = true;
        }
        else
        {

            lblmesage.Text = "Tapılmadı";
            lblmesage.ForeColor = Color.Red;
            exele.Visible = false;
            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = false;
            Panel4.Visible = false;
        }

    }
    void besinci()
    {
        Panel1.Visible = false;
        Panel2.Visible = false;
        Panel3.Visible = true;
        Panel4.Visible = false;
        string rayon;
        string user2;
        if (ddlryn.SelectedValue == "0" || ddlryn.SelectedValue == "-1" || ddlryn.SelectedValue == "")
        {
            rayon = "  ";
        }
        else
        {
            rayon = " and b.RegionID='" + ddlryn.SelectedValue + "'  ";
        }


        user2 = " and b.UserID='" + UserID + "' ";


        string tarixs1 = "";
        string tarixs2 = "";

        if (lblgetme1.Text != "")
        {
            tarixs1 = " and b.GoFromRegion <='" + lblgetme1.Text + "'";
        }
        if (lblgelme1.Text != "")
        {
            tarixs2 = "and b.RegionCome >='" + lblgelme1.Text + "'";
        }

        DataTable region2 = klas.getdatatable(@"SELECT     b.BusinessTripID, b.RegionID, b.RegionCome, b.GoFromRegion, b.Regions, 
 b.UserID, c.DelegateOther as Other FROM  business_trip as b INNER JOIN Conn_delegate_IHB as c ON b.BusinessTripID = c.BusinessTripID where
b.BusinessTripID='" + BusinessTripID + "' " + user2 + " " + rayon + " " + tarixs1 + " " + tarixs2 + " and c.IshtirakYesNo='true' order by b.RegionCome desc");
        DataList3.DataSource = region2;
        DataList3.DataBind();
        if (region2.Rows.Count > 0)
        {
            lblmesage.Text = "";
            exele.Visible = true;
        }
        else
        {
            lblmesage.Text = "Tapılmadı";
            lblmesage.ForeColor = Color.Red;
            exele.Visible = false;
            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = false;
            Panel4.Visible = false;
        }

    }
    void altinci()
    {
        Panel1.Visible = false;
        Panel2.Visible = false;
        Panel3.Visible = true;
        Panel4.Visible = false;
        string rayon;
        string user1;
        if (ddlryn.SelectedValue == "0" || ddlryn.SelectedValue == "-1" || ddlryn.SelectedValue == "")
        {
            rayon = "  ";
        }
        else
        {
            rayon = " and b.RegionID='" + ddlryn.SelectedValue + "'  ";
        }


        user1 = " and b.UserID='" + UserID + "' ";


        string tarixs11 = "";
        string tarixs22 = "";
        if (lblgetme1.Text != "")
        {
            tarixs11 = " and b.GoFromRegion <='" + lblgetme1.Text + "'";
        }
        if (lblgelme1.Text != "")
        {
            tarixs22 = "and b.RegionCome >='" + lblgelme1.Text + "'";
        }


        DataTable region2 = klas.getdatatable(@"SELECT     b.BusinessTripID, b.RegionID, b.RegionCome, b.GoFromRegion, b.Regions, 
   b.UserID, c.DelegateOther as Other FROM  business_trip as b INNER JOIN Conn_delegate_IHB as c ON b.BusinessTripID = c.BusinessTripID where 1=1
" + rayon + "   " + tarixs22 + " " + tarixs11 + " " + user1 + " and c.IshtirakYesNo='true' order by b.RegionCome desc");
        DataList3.DataSource = region2;
        DataList3.DataBind();
        if (region2.Rows.Count > 0)
        {
            lblmesage.Text = "";
            exele.Visible = true;
            lblihbyaw.Text = "Getdiyi İHB";
        }
        else
        {
            lblmesage.Text = "Tapılmadı";
            lblmesage.ForeColor = Color.Red;
            exele.Visible = false;
            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = false;
            Panel4.Visible = false;
        }
    }
    void yeddinci()
    {
        Panel1.Visible = false;
        Panel2.Visible = false;
        Panel3.Visible = true;
        Panel4.Visible = false;
        string rayon;
        string user1;
        if (ddlryn.SelectedValue == "0" || ddlryn.SelectedValue == "-1" || ddlryn.SelectedValue == "")
        {
            rayon = "  ";
        }
        else
        {
            rayon = " and b.RegionID='" + ddlryn.SelectedValue + "'  ";
        }


        user1 = " and b.UserID='" + UserID + "' ";


        string tarixs11 = "";
        string tarixs22 = "";
        if (lblgetme1.Text != "")
        {
            tarixs11 = " and b.GoFromRegion <='" + lblgetme1.Text + "'";
        }
        if (lblgelme1.Text != "")
        {
            tarixs22 = "and b.RegionCome >='" + lblgelme1.Text + "'";
        }


        DataTable region2 = klas.getdatatable(@"SELECT     b.BusinessTripID, b.RegionID, b.RegionCome, b.GoFromRegion, b.Regions, 
   b.UserID, c.DelegateOther as Other FROM  business_trip as b INNER JOIN Conn_delegate_IHB as c ON b.BusinessTripID = c.BusinessTripID where 1=1
" + rayon + "   " + tarixs22 + " " + tarixs11 + " " + user1 + " and c.IshtirakYesNo='false' order by b.RegionCome desc");
        DataList3.DataSource = region2;
        DataList3.DataBind();
        if (region2.Rows.Count > 0)
        {
            lblmesage.Text = "";
            exele.Visible = true;
            lblihbyaw.Text = "Getmədiyi İHB";
        }
        else
        {
            lblmesage.Text = "Tapılmadı";
            lblmesage.ForeColor = Color.Red;
            exele.Visible = false;
            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = false;
            Panel4.Visible = false;
        }
    }
    void sekkizinci()
    {
        Panel1.Visible = false;
        Panel2.Visible = false;
        Panel3.Visible = true;
        Panel4.Visible = false;
        string rayon;
        string user1;
        if (ddlryn.SelectedValue == "0" || ddlryn.SelectedValue == "-1" || ddlryn.SelectedValue == "")
        {
            rayon = "  ";
        }
        else
        {
            rayon = " and b.RegionID='" + ddlryn.SelectedValue + "'  ";
        }


        user1 = " and b.UserID='" + UserID + "' ";


        string tarixs11 = "";
        string tarixs22 = "";
        if (lblgetme1.Text != "")
        {
            tarixs11 = " and b.GoFromRegion <='" + lblgetme1.Text + "'";
        }
        if (lblgelme1.Text != "")
        {
            tarixs22 = "and b.RegionCome >='" + lblgelme1.Text + "'";
        }


        DataTable region2 = klas.getdatatable(@"SELECT     b.BusinessTripID, b.RegionID, b.RegionCome, b.GoFromRegion, b.Regions, 
   b.UserID, c.LivingOther as Other FROM  business_trip as b INNER JOIN Conn_living as c ON b.BusinessTripID = c.BusinessTripID where 1=1
" + rayon + "   " + tarixs22 + " " + tarixs11 + " " + user1 + " and c.IshtirakYesNo='true' order by b.RegionCome desc");
        DataList3.DataSource = region2;
        DataList3.DataBind();
        if (region2.Rows.Count > 0)
        {
            lblmesage.Text = "";
            exele.Visible = true;
            lblihbyaw.Text = "Olduğu yaşayış məntəqələri";
        }
        else
        {
            lblmesage.Text = "Tapılmadı";
            lblmesage.ForeColor = Color.Red;
            exele.Visible = false;
            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = false;
            Panel4.Visible = false;
        }
    }

    void doqquzuncu()
    {
        Panel1.Visible = false;
        Panel2.Visible = false;
        Panel3.Visible = true;
        Panel4.Visible = false;
        string rayon;
        string user1;
        if (ddlryn.SelectedValue == "0" || ddlryn.SelectedValue == "-1" || ddlryn.SelectedValue == "")
        {
            rayon = "  ";
        }
        else
        {
            rayon = " and b.RegionID='" + ddlryn.SelectedValue + "'  ";
        }


        user1 = " and b.UserID='" + UserID + "' ";


        string tarixs11 = "";
        string tarixs22 = "";
        if (lblgetme1.Text != "")
        {
            tarixs11 = " and b.GoFromRegion <='" + lblgetme1.Text + "'";
        }
        if (lblgelme1.Text != "")
        {
            tarixs22 = "and b.RegionCome >='" + lblgelme1.Text + "'";
        }


        DataTable region2 = klas.getdatatable(@"SELECT     b.BusinessTripID, b.RegionID, b.RegionCome, b.GoFromRegion, b.Regions, 
   b.UserID, c.LivingOther as Other FROM  business_trip as b INNER JOIN Conn_living as c ON b.BusinessTripID = c.BusinessTripID where 1=1
" + rayon + "   " + tarixs22 + " " + tarixs11 + " " + user1 + " and c.IshtirakYesNo='false' order by b.RegionCome desc");
        DataList3.DataSource = region2;
        DataList3.DataBind();
        if (region2.Rows.Count > 0)
        {
            lblmesage.Text = "";
            exele.Visible = true;
            lblihbyaw.Text = "Olmadığı yaşayış məntəqələri";
        }
        else
        {
            lblmesage.Text = "Tapılmadı";
            lblmesage.ForeColor = Color.Red;
            exele.Visible = false;
            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = false;
            Panel4.Visible = false;
        }
    }
    protected void btngeri_Click(object sender, EventArgs e)
    {
        if (islem == "rayon0")
        {

            Response.Redirect("Hesabattehlili.aspx");
        }
        if (islem == "rayon1")
        {
            Response.Redirect("Yasmenihbtehlil.aspx?islem=rayon0&tarix1=" + lblgelme1.Text + "&tarix2=" + lblgetme1.Text + "&tarix3=" + lblgelme.Text + "&tarix4=" + lblgetme.Text);
        }
        if (islem == "rayon2")
        {
            Response.Redirect("Yasmenihbtehlil.aspx?islem=rayon1&UserID=" + UserID + "&tarix1=" + lblgelme1.Text + "&tarix2=" + lblgetme1.Text + "&tarix3=" + lblgelme.Text + "&tarix4=" + lblgetme.Text);
        }
        if (islem == "rayon20")
        {
            Response.Redirect("Yasmenihbtehlil.aspx?islem=rayon1&UserID=" + UserID + "&tarix1=" + lblgelme1.Text + "&tarix2=" + lblgetme1.Text + "&tarix3=" + lblgelme.Text + "&tarix4=" + lblgetme.Text);
        }
        if (islem == "rayon21")
        {
            Response.Redirect("Yasmenihbtehlil.aspx?islem=rayon1&UserID=" + UserID + "&tarix1=" + lblgelme1.Text + "&tarix2=" + lblgetme1.Text + "&tarix3=" + lblgelme.Text + "&tarix4=" + lblgetme.Text);
        }
        if (islem == "rayon22")
        {
            Response.Redirect("Yasmenihbtehlil.aspx?islem=rayon1&UserID=" + UserID + "&tarix1=" + lblgelme1.Text + "&tarix2=" + lblgetme1.Text + "&tarix3=" + lblgelme.Text + "&tarix4=" + lblgetme.Text);
        }
        if (islem == "rayon3")
        {
            Response.Redirect("Yasmenihbtehlil.aspx?islem=rayon1&UserID=" + UserID + "&tarix1=" + lblgelme1.Text + "&tarix2=" + lblgetme1.Text + "&tarix3=" + lblgelme.Text + "&tarix4=" + lblgetme.Text);
        }
        if (islem == "rayon4")
        {
            Response.Redirect("Yasmenihbtehlil.aspx?islem=rayon3&RegionID=" + RegionID + "&UserID=" + UserID + "&tarix1=" + lblgelme1.Text + "&tarix2=" + lblgetme1.Text + "&tarix3=" + lblgelme.Text + "&tarix4=" + lblgetme.Text);
        }
        if (islem == "rayon5")
        {
            Response.Redirect("Yasmenihbtehlil.aspx?islem=rayon0&tarix1=" + lblgelme1.Text + "&tarix2=" + lblgetme1.Text + "&tarix3=" + lblgelme.Text + "&tarix4=" + lblgetme.Text);
        }
        if (islem == "rayon6")
        {
            Response.Redirect("Yasmenihbtehlil.aspx?islem=rayon0&tarix1=" + lblgelme1.Text + "&tarix2=" + lblgetme1.Text + "&tarix3=" + lblgelme.Text + "&tarix4=" + lblgetme.Text);
        }
        if (islem == "rayon7")
        {
            Response.Redirect("Yasmenihbtehlil.aspx?islem=rayon0&tarix1=" + lblgelme1.Text + "&tarix2=" + lblgetme1.Text + "&tarix3=" + lblgelme.Text + "&tarix4=" + lblgetme.Text);
        }
        if (islem == "rayon8")
        {
            Response.Redirect("Yasmenihbtehlil.aspx?islem=rayon0&tarix1=" + lblgelme1.Text + "&tarix2=" + lblgetme1.Text + "&tarix3=" + lblgelme.Text + "&tarix4=" + lblgetme.Text);
        }
  
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        if (Calendar1.Visible)
        {
            Calendar1.Visible = false;
            lblgelme.Visible = true;
            imgbsilgelme.Visible = true;

        }
        else
        {
            imgbsilgelme.Visible = false;
            Calendar1.Visible = true;
            lblgelme.Visible = false;
        }
        if (lblgelme.Text == "")
        {
            imgbsilgelme.Visible = false;
        }
    }
    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        if (Calendar3.Visible)
        {
            Calendar3.Visible = false;
            lblgetme.Visible = true;
            imgbsilgetme0.Visible = true;
        }
        else
        {
            Calendar3.Visible = true;
            lblgetme.Visible = false;
            imgbsilgetme0.Visible = false;
        }
        if (lblgetme.Text == "")
        {
            imgbsilgetme0.Visible = false;
        }
    }
    protected void imgbsilgelme_Click(object sender, ImageClickEventArgs e)
    {
        lblgelme.Text = "";
        lblgelme1.Text = "";
        imgbsilgelme.Visible = false;

    }
    protected void imgbsilgetme0_Click(object sender, ImageClickEventArgs e)
    {
        lblgetme.Text = "";
        lblgetme1.Text = "";
        imgbsilgetme0.Visible = false;

    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        lblgelme.Text = Calendar1.SelectedDate.ToString("d");
        lblgelme1.Text = Calendar1.SelectedDate.ToString("yyyy-MM-dd");
        Calendar1.Visible = false;
        lblgelme.Visible = true;
        imgbsilgelme.Visible = true;

    }
    protected void Calendar3_SelectionChanged(object sender, EventArgs e)
    {
        lblgetme.Text = Calendar3.SelectedDate.ToString("d");
        lblgetme1.Text = Calendar3.SelectedDate.ToString("yyyy-MM-dd");
        Calendar3.Visible = false;
        lblgetme.Visible = true;
        imgbsilgetme0.Visible = true;

    }
    protected void exele_Click(object sender, EventArgs e)
    {
        if (islem == "rayon0")
        {
            birinci();
            Response.ClearContent();
            Response.AppendHeader("content-disposition", "attachment; filename=Hesabattehlil.doc");
            Response.ContentType = "application/excel";
            Response.ContentEncoding = System.Text.Encoding.UTF8;
            Response.BinaryWrite(System.Text.Encoding.UTF8.GetPreamble());
            StringWriter stringWritter = new StringWriter();
            HtmlTextWriter htmlTextWritter = new HtmlTextWriter(stringWritter);
            Panel1.RenderControl(htmlTextWritter);
            Response.Write(stringWritter.ToString());
            Response.End();
        }
        if (islem == "rayon1")
        {
            ikinci();
            Response.ClearContent();
            Response.AppendHeader("content-disposition", "attachment; filename=Hesabattehlil.doc");
            Response.ContentType = "application/excel";
            Response.ContentEncoding = System.Text.Encoding.UTF8;
            Response.BinaryWrite(System.Text.Encoding.UTF8.GetPreamble());
            StringWriter stringWritter = new StringWriter();
            HtmlTextWriter htmlTextWritter = new HtmlTextWriter(stringWritter);
            Panel2.RenderControl(htmlTextWritter);
            Response.Write(stringWritter.ToString());
            Response.End();
        }
        if (islem == "rayon2")
        {
            ucuncu();
            Response.ClearContent();
            Response.AppendHeader("content-disposition", "attachment; filename=Hesabattehlil.doc");
            Response.ContentType = "application/excel";
            Response.ContentEncoding = System.Text.Encoding.UTF8;
            Response.BinaryWrite(System.Text.Encoding.UTF8.GetPreamble());
            StringWriter stringWritter = new StringWriter();
            HtmlTextWriter htmlTextWritter = new HtmlTextWriter(stringWritter);
            Panel3.RenderControl(htmlTextWritter);
            Response.Write(stringWritter.ToString());
            Response.End();
        }
               if (islem == "rayon20")
        {
            ucuncu0();
            Response.ClearContent();
            Response.AppendHeader("content-disposition", "attachment; filename=Hesabattehlil.doc");
            Response.ContentType = "application/excel";
            Response.ContentEncoding = System.Text.Encoding.UTF8;
            Response.BinaryWrite(System.Text.Encoding.UTF8.GetPreamble());
            StringWriter stringWritter = new StringWriter();
            HtmlTextWriter htmlTextWritter = new HtmlTextWriter(stringWritter);
            Panel3.RenderControl(htmlTextWritter);
            Response.Write(stringWritter.ToString());
            Response.End();
        }
               if (islem == "rayon21")
               {
                   ucuncu1();
                   Response.ClearContent();
                   Response.AppendHeader("content-disposition", "attachment; filename=Hesabattehlil.doc");
                   Response.ContentType = "application/excel";
                   Response.ContentEncoding = System.Text.Encoding.UTF8;
                   Response.BinaryWrite(System.Text.Encoding.UTF8.GetPreamble());
                   StringWriter stringWritter = new StringWriter();
                   HtmlTextWriter htmlTextWritter = new HtmlTextWriter(stringWritter);
                   Panel3.RenderControl(htmlTextWritter);
                   Response.Write(stringWritter.ToString());
                   Response.End();
               }
               if (islem == "rayon22")
               {
                   ucuncu2();
                   Response.ClearContent();
                   Response.AppendHeader("content-disposition", "attachment; filename=Hesabattehlil.doc");
                   Response.ContentType = "application/excel";
                   Response.ContentEncoding = System.Text.Encoding.UTF8;
                   Response.BinaryWrite(System.Text.Encoding.UTF8.GetPreamble());
                   StringWriter stringWritter = new StringWriter();
                   HtmlTextWriter htmlTextWritter = new HtmlTextWriter(stringWritter);
                   Panel3.RenderControl(htmlTextWritter);
                   Response.Write(stringWritter.ToString());
                   Response.End();
               }

        if (islem == "rayon3")
        {
            dorduncu();
            Response.ClearContent();
            Response.AppendHeader("content-disposition", "attachment; filename=Hesabattehlil.doc");
            Response.ContentType = "application/excel";
            Response.ContentEncoding = System.Text.Encoding.UTF8;
            Response.BinaryWrite(System.Text.Encoding.UTF8.GetPreamble());
            StringWriter stringWritter = new StringWriter();
            HtmlTextWriter htmlTextWritter = new HtmlTextWriter(stringWritter);
            Panel4.RenderControl(htmlTextWritter);
            Response.Write(stringWritter.ToString());
            Response.End();
        }
        if (islem == "rayon4")
        {
            besinci();
            Response.ClearContent();
            Response.AppendHeader("content-disposition", "attachment; filename=Hesabattehlil.doc");
            Response.ContentType = "application/excel";
            Response.ContentEncoding = System.Text.Encoding.UTF8;
            Response.BinaryWrite(System.Text.Encoding.UTF8.GetPreamble());
            StringWriter stringWritter = new StringWriter();
            HtmlTextWriter htmlTextWritter = new HtmlTextWriter(stringWritter);
            Panel3.RenderControl(htmlTextWritter);
            Response.Write(stringWritter.ToString());
            Response.End();
        }
        if (islem == "rayon5")
        {
            altinci();
            Response.ClearContent();
            Response.AppendHeader("content-disposition", "attachment; filename=Hesabattehlil.doc");
            Response.ContentType = "application/excel";
            Response.ContentEncoding = System.Text.Encoding.UTF8;
            Response.BinaryWrite(System.Text.Encoding.UTF8.GetPreamble());
            StringWriter stringWritter = new StringWriter();
            HtmlTextWriter htmlTextWritter = new HtmlTextWriter(stringWritter);
            Panel3.RenderControl(htmlTextWritter);
            Response.Write(stringWritter.ToString());
            Response.End();
        }
        if (islem == "rayon6")
        {
            yeddinci();
            Response.ClearContent();
            Response.AppendHeader("content-disposition", "attachment; filename=Hesabattehlil.doc");
            Response.ContentType = "application/excel";
            Response.ContentEncoding = System.Text.Encoding.UTF8;
            Response.BinaryWrite(System.Text.Encoding.UTF8.GetPreamble());
            StringWriter stringWritter = new StringWriter();
            HtmlTextWriter htmlTextWritter = new HtmlTextWriter(stringWritter);
            Panel3.RenderControl(htmlTextWritter);
            Response.Write(stringWritter.ToString());
            Response.End();
        }
        if (islem == "rayon7")
        {
            sekkizinci();
            Response.ClearContent();
            Response.AppendHeader("content-disposition", "attachment; filename=Hesabattehlil.doc");
            Response.ContentType = "application/excel";
            Response.ContentEncoding = System.Text.Encoding.UTF8;
            Response.BinaryWrite(System.Text.Encoding.UTF8.GetPreamble());
            StringWriter stringWritter = new StringWriter();
            HtmlTextWriter htmlTextWritter = new HtmlTextWriter(stringWritter);
            Panel3.RenderControl(htmlTextWritter);
            Response.Write(stringWritter.ToString());
            Response.End();
        }
        if (islem == "rayon8")
        {
            doqquzuncu();
            Response.ClearContent();
            Response.AppendHeader("content-disposition", "attachment; filename=Hesabattehlil.doc");
            Response.ContentType = "application/excel";
            Response.ContentEncoding = System.Text.Encoding.UTF8;
            Response.BinaryWrite(System.Text.Encoding.UTF8.GetPreamble());
            StringWriter stringWritter = new StringWriter();
            HtmlTextWriter htmlTextWritter = new HtmlTextWriter(stringWritter);
            Panel3.RenderControl(htmlTextWritter);
            Response.Write(stringWritter.ToString());
            Response.End();
        }

    }


    void ryn()
    {
        DataTable dtiller = klas.getdatatable("Select * from List_classification_Regions where  ForDelete=1 order by [Name]");
        ddlryn.DataTextField = "Name";
        ddlryn.DataValueField = "RegionsID";
        ddlryn.DataSource = dtiller;
        ddlryn.DataBind();
        ddlryn.Items.Insert(0, new ListItem("Seçin", "0"));
        ddlryn.Items.Insert(1, new ListItem("Ümumi", "-1"));
        ddlryn.SelectedValue = "-1";
    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        if (islem == "rayon0")
        {
            birinci();
        }
        if (islem == "rayon1")
        {
            ikinci();
        }
        if (islem == "rayon2")
        {
            ucuncu();
        }
        if (islem == "rayon20")
        {
            ucuncu0();
        }
        if (islem == "rayon21")
        {
            ucuncu1();
        }
        if (islem == "rayon22")
        {
            ucuncu2();
        }
        if (islem == "rayon3")
        {
            dorduncu();
        }
        if (islem == "rayon4")
        {
            besinci();
        }
        if (islem == "rayon5")
        {
            altinci();
        }
        if (islem == "rayon6")
        {
            yeddinci();
        }
        if (islem == "rayon7")
        {
            sekkizinci();
        }
        if (islem == "rayon8")
        {
            doqquzuncu();
        }
    }

}