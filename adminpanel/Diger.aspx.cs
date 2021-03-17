using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class adminpanel_diger : System.Web.UI.Page
{
    Class2 klas = new Class2(); string islem; string OtherID; string Tesnifat; string Other; string PurPoseName;
    string rownumber = "";string Part; string Tesnifatsil; string OtherIDsil;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            //aranacak = Request.QueryString["aranacak"];
            rownumber = Request.QueryString["rownumber"];
            islem = Request.QueryString["islem"];
            OtherID = Request.QueryString["OtherID"];
            Tesnifat = Request.QueryString["Tesnifat"];
            Tesnifatsil = Request.QueryString["Tesnifatsil"];
            Other = Request.QueryString["Other"];
            PurPoseName = Request.QueryString["PurPoseName"];
            Part = Request.QueryString["Part"];
            OtherIDsil = Request.QueryString["OtherIDsil"];

        }
        catch (Exception)
        { }
           if (Page.IsPostBack == false)
        {
           
      

    
            if (islem == "sil")
            {
                if (Tesnifatsil == "57")
                {
                    klas.cmd("Update  FLiving_point Set PurposeID=-1 Where ConnID=" + OtherIDsil);
                }
                if (Tesnifatsil == "55")
                {
                    klas.cmd("Update  FDelegate_IHB Set PurposeID=-1 Where ConnID=" + OtherIDsil);
                }
                if (Tesnifatsil == "53")
                {
                    klas.cmd("Update  FDesigned_staff Set PurposeID=-1 Where ConnID=" + OtherIDsil);
                }
                if (Tesnifatsil == "56")
                {
                    klas.cmd("Update  FLiving_point Set LivingID=-1 Where ConnID=" + OtherIDsil);
                }
                if (Tesnifatsil == "54")
                {
                    klas.cmd("Update  FDelegate_IHB Set DelegateID=-1 Where ConnID=" + OtherIDsil);
                }
                if (Tesnifatsil == "52")
                {
                    klas.cmd("Update  FDesigned_staff Set PositionsID=-1 Where ConnID=" + OtherIDsil);
                }
                if (Tesnifatsil == "51")
                {
                    klas.cmd("Update  FDesigned_staff Set Executive_bodyID=-1 Where ConnID=" + OtherIDsil);
                }
                if (Tesnifatsil == "50")
                {
                    klas.cmd("Update  FIndividual_meetings_citizens Set PurposeID=-1 Where ConnID=" + OtherIDsil);
                }
                if (Tesnifatsil == "49")
                {
                    klas.cmd("Update  FIndividual_meetings_citizens Set Living_pointId=-1 Where ConnID=" + OtherIDsil);
                }
                if (Tesnifatsil == "48")
                {
                    klas.cmd("Update  FIssues_of_results Set IssuesID=-1 Where ConnID=" + OtherIDsil);
                }
                if (Tesnifatsil == "47")
                {
                    klas.cmd("Update  FIssues_of_results Set ActionsID=-1 Where ConnID=" + OtherIDsil);
                }
                if (Tesnifatsil == "46")
                {
                    klas.cmd("Update  FPurposeOfTrip Set PurposeID=-1 Where ConnID=" + OtherIDsil);
                }
                if (Tesnifatsil == "4")
                {
                    klas.cmd("Update  Conn_PurposeOfTrip Set PurposeId=-1 Where ConnID=" + OtherIDsil);
                }
                if (Tesnifatsil == "41")
                {
                    klas.cmd("Update  Conn_Meetings_with_citizens Set Living_adresID=-1 Where ConnID=" + OtherIDsil);
                }
                if (Tesnifatsil == "40")
                {
                    klas.cmd("Update  Conn_facilities Set Living_PointID=-1 Where ConnID=" + OtherIDsil);
                }
                if (Tesnifatsil == "39")
                {
                    klas.cmd("Update  Conn_facilities Set SubObjectID=-1 Where ConnID=" + OtherIDsil);
                }
                if (Tesnifatsil == "37")
                {
                    klas.cmd("Update  Conn_Object_operation Set Living_PointID=-1 Where ConnID=" + OtherIDsil);
                }
                if (Tesnifatsil == "5")
                {
                    klas.cmd("Update  Conn_delegate_IHB Set DelegateID=-1 Where ConnID=" + OtherIDsil);
                }
                if (Tesnifatsil == "36")
                {
                    klas.cmd("Update  Conn_Object_operation Set SubObjectID=-1 Where ConnID=" + OtherIDsil);
                }
                if (Tesnifatsil == "10")
                {
                    klas.cmd("Update  Conn_Reviewed Set ReviewedID=-1 Where ConnID=" + OtherIDsil);
                }
                if (Tesnifatsil == "18")
                {
                    klas.cmd("Update  Conn_participation_measure Set DiscussedID=-1 Where ConnID=" + OtherIDsil);
                }
                if (Tesnifatsil == "7")
                {
                    klas.cmd("Update  Conn_living Set LivingID=-1 Where ConnID=" + OtherIDsil);
                }
                if (Tesnifatsil == "38")
                {
                    klas.cmd("Update  Conn_facilities Set ObjectID=-1 Where ConnID=" + OtherIDsil);
                }
                if (Tesnifatsil == "13")
                {
                    klas.cmd("Update  Conn_Meetings_with_citizens Set PurposeID=-1 Where ConnID=" + OtherIDsil);
                }
                if (Tesnifatsil == "12")
                {
                    klas.cmd("Update  Conn_Object_operation Set ObjectID=-1 Where ConnID=" + OtherIDsil);
                }
                if (Tesnifatsil == "17")
                {
                    klas.cmd("Update  Conn_frames Set FramesID=-1 Where ConnID=" + OtherIDsil);
                }
                if (Tesnifatsil == "9")
                {
                    klas.cmd("Update  Conn_participation_measure Set ParticipationID=-1 Where ConnID=" + OtherIDsil);
                }
                if (Tesnifatsil == "31")
                {
                    klas.cmd("Update  Conn_frames Set Sub_FramesID=-1 Where ConnID=" + OtherIDsil);
                }
                if (Tesnifatsil == "14")
                {
                    klas.cmd("Update  Conn_religious_political Set religious_politicalID=-1 Where ConnID=" + OtherIDsil);
                }
                table(); 
                Response.Redirect("Diger.aspx");
            }


            if (islem == "duzelis")
            {
                Session[rownumber] = rownumber;
                if (Tesnifat == "57")
                {
                    Tesnifat = "45";
                }
                if (Tesnifat == "55")
                {
                    Tesnifat = "44";
                }
                if (Tesnifat == "53")
                {
                    Tesnifat = "43";
                }
                if (Tesnifat == "56")
                {
                    Tesnifat = "37";
                }
                if (Tesnifat == "54")
                {
                    Tesnifat = "5";
                }
                if (Tesnifat == "52")
                {
                    Tesnifat = "31";
                }
                if (Tesnifat == "51")
                {
                    Tesnifat = "17";
                }
                if (Tesnifat == "50")
                {
                    Tesnifat = "13";
                }
                if (Tesnifat == "49")
                {
                    Tesnifat = "37";
                }
                if (Tesnifat == "48")
                {
                    Tesnifat = "18";
                }
                if (Tesnifat == "47")
                {
                    Tesnifat = "9";
                }
                if (Tesnifat == "46")
                {
                    Tesnifat = "4";
                }
                if (Tesnifat == "38")
                {
                    Tesnifat = "12";
                }
                if (Tesnifat == "40")
                {
                    Tesnifat = "37";
                }
                if (Tesnifat == "7")
                {
                    Tesnifat = "37";
                }
                if (Tesnifat == "41")
                {
                    Tesnifat = "37";
                }
                if (Tesnifat == "39")
                {
                    Tesnifat = "36";
                }
             
                table();
                txtmeqsedelave.Text = Other;
                lbltesnifatadi.Text = PurPoseName;
                lblbolme.Text = Part;
                Panel1.Visible = true;
                lbltesnifatyeri.Text = "Təsnifatda yeri:";
             
                if (Tesnifat != "31" && Tesnifat != "36" && Tesnifat != "5"  && Tesnifat != "37" )
                {
                    meqsedsort();
                    ddlmeqsedsort.Items.Insert(0, new ListItem("Seçin", "-1"));
                    ddlmeqsedsort.Items.Insert(1, new ListItem("Əvvələ", "0"));
                    lbltesnifatyeri.Text = "Təsnifatda yeri:";
                    pnlelaveddl.Visible = false;
                }else if(Tesnifat == "31"){
                    ddlmeqsedsort.Enabled = false;
                    Session["Tesnifat"] = Tesnifat;
                    lbltesnif1.Text = "İcra orqanı:";
                    lbltesnifatyeri.Text = "Təsnifatda yeri:";
                    regionihb();
                    ddlihbrayonelave.Items.Insert(0, new ListItem("Seçin", "0"));
                    ihbsort();
                    ddlmeqsedsort.Items.Insert(0, new ListItem("Seçin", "-1"));
                    ddlmeqsedsort.Items.Insert(1, new ListItem("Əvvələ", "0"));
                    pnlelaveddl.Visible = true;
                }
                else if (Tesnifat == "36")
                {
                    ddlmeqsedsort.Enabled = false;
                    Session["Tesnifat"] = Tesnifat;
                    lbltesnif1.Text = "Sahə:";
                    lbltesnifatyeri.Text = "Təsnifatda yeri:";
                    regionihb1();
                    ddlihbrayonelave.Items.Insert(0, new ListItem("Seçin", "0"));
                    ihbsort1();
                    ddlmeqsedsort.Items.Insert(0, new ListItem("Seçin", "-1"));
                    ddlmeqsedsort.Items.Insert(1, new ListItem("Əvvələ", "0"));
                    pnlelaveddl.Visible = true;
                }
              
                else if (Tesnifat == "5") {
                    Session["Tesnifat"] = Tesnifat;
                    lbltesnifatyeri.Text = "Rayon:";
                    rayon();
                    ddlmeqsedsort.Items.Insert(0, new ListItem("Seçin", "0"));
                    pnlelaveddl.Visible = false;
                }
                else if (Tesnifat == "37")
                {
                    pnlyawayiw.Visible = true;
                   
                    Session["Tesnifat"] = Tesnifat;
                    lbltesnif1.Text = "Status:";
                    lbltesnifatyeri.Text = "Rayon:";
                    lblyawayiwied.Text = "İƏD:";
                    rayon();
                    ddlmeqsedsort.Items.Insert(0, new ListItem("Seçin", "0"));
                    status();
                    ddlihbrayonelave.Items.Insert(0, new ListItem("Seçin", "0"));
                    pnlelaveddl.Visible = true;
                }
             
            }
            else {
                Panel1.Visible = false;
            }

        }
        table();

        LinkButton lblvizual = (LinkButton)Master.FindControl("Tesnifatlar");
        lblvizual.BackColor = Color.Peru;
    }
    void table(){

        string s = @"select * from (
--ezamiyyenin meqsedi
SELECT     dbo.business_trip.UserID, dbo.Users.Name + ' ' + dbo.Users.Sname AS Name, dbo.Conn_PurposeOfTrip.Other, dbo.Conn_PurposeOfTrip.ConnID AS OtherID, 
                      dbo.List_classifications_Type.PurposeName, dbo.Conn_PurposeOfTrip.BusinessTripID, dbo.Conn_PurposeOfTrip.Tesnifat_meqsed AS Tesnifat, 
                      dbo.List_classifications_Type.Part,RegionCome,GoFromRegion,lr.Name as RegName
FROM         dbo.business_trip INNER JOIN
                      dbo.Users ON dbo.business_trip.UserID = dbo.Users.UserID INNER JOIN
                      dbo.Conn_PurposeOfTrip ON dbo.business_trip.BusinessTripID = dbo.Conn_PurposeOfTrip.BusinessTripID INNER JOIN
                      dbo.List_classifications_Type ON dbo.Conn_PurposeOfTrip.Tesnifat_meqsed = dbo.List_classifications_Type.ListID
 inner join List_classification_Regions as lr on lr.RegionsID=dbo.business_trip.RegionID 
WHERE     (dbo.Conn_PurposeOfTrip.PurposeId = 0)
--IHB numayendeleri
union 
SELECT     dbo.Users.UserID, dbo.Users.Name + ' ' + dbo.Users.Sname AS Name, dbo.Conn_delegate_IHB.DelegateOther AS Other, dbo.Conn_delegate_IHB.ConnID AS OtherID, 
                      dbo.List_classifications_Type.PurposeName, dbo.business_trip.BusinessTripID, dbo.Conn_delegate_IHB.tesnifat_ihb AS Tesnifat, 
                      dbo.List_classifications_Type.Part,RegionCome,GoFromRegion,lr.Name as RegName
FROM         dbo.Conn_delegate_IHB INNER JOIN
                      dbo.business_trip ON dbo.Conn_delegate_IHB.BusinessTripID = dbo.business_trip.BusinessTripID INNER JOIN
                      dbo.Users ON dbo.business_trip.UserID = dbo.Users.UserID INNER JOIN
                      dbo.List_classifications_Type ON dbo.Conn_delegate_IHB.tesnifat_ihb = dbo.List_classifications_Type.ListID
 inner join List_classification_Regions as lr on lr.RegionsID=dbo.business_trip.RegionID 
WHERE     (dbo.Conn_delegate_IHB.DelegateID = 0)
--iwtirak etdiyi tedbirler
union
SELECT     dbo.business_trip.UserID, dbo.Users.Name + ' ' + dbo.Users.Sname AS Name, dbo.Conn_participation_measure.ParticipationOther AS Other, 
                      dbo.Conn_participation_measure.ConnID AS OtherID, dbo.List_classifications_Type.PurposeName, dbo.business_trip.BusinessTripID, 
                      dbo.Conn_participation_measure.Tesnifatin_iwtedbir AS Tesnifat, dbo.List_classifications_Type.Part,RegionCome,GoFromRegion,lr.Name as RegName
FROM         dbo.business_trip INNER JOIN
                      dbo.Users ON dbo.business_trip.UserID = dbo.Users.UserID INNER JOIN
                      dbo.Conn_participation_measure ON dbo.business_trip.BusinessTripID = dbo.Conn_participation_measure.BusinessTripID INNER JOIN
                      dbo.List_classifications_Type ON dbo.Conn_participation_measure.Tesnifatin_iwtedbir = dbo.List_classifications_Type.ListID
 inner join List_classification_Regions as lr on lr.RegionsID=dbo.business_trip.RegionID 
WHERE     (dbo.Conn_participation_measure.ParticipationID = 0)
----muzakire olunan mesele
union
SELECT     dbo.business_trip.UserID, dbo.Users.Name + ' ' + dbo.Users.Sname AS Name, dbo.Conn_participation_measure.DiscussedOther AS Other, 
                      dbo.Conn_participation_measure.ConnID AS OtherID, dbo.List_classifications_Type.PurposeName, dbo.business_trip.BusinessTripID, 
                      dbo.Conn_participation_measure.Tesnifat_muzakire AS Tesnifat, dbo.List_classifications_Type.Part,RegionCome,GoFromRegion,lr.Name as RegName
FROM         dbo.business_trip INNER JOIN
                      dbo.Users ON dbo.business_trip.UserID = dbo.Users.UserID INNER JOIN
                      dbo.Conn_participation_measure ON dbo.business_trip.BusinessTripID = dbo.Conn_participation_measure.BusinessTripID INNER JOIN
                      dbo.List_classifications_Type ON dbo.Conn_participation_measure.Tesnifat_muzakire = dbo.List_classifications_Type.ListID
 inner join List_classification_Regions as lr on lr.RegionsID=dbo.business_trip.RegionID 
WHERE     (dbo.Conn_participation_measure.DiscussedID = 0)
----baxilmiw arawdirilmiw mesele
union
SELECT     dbo.business_trip.UserID, dbo.Users.Name + ' ' + dbo.Users.Sname AS Name, dbo.Conn_Reviewed.Other, dbo.Conn_Reviewed.ConnID AS OtherID, 
                      dbo.List_classifications_Type.PurposeName, dbo.business_trip.BusinessTripID, dbo.Conn_Reviewed.tes_baxilmiwaraw AS Tesnifat, 
                      dbo.List_classifications_Type.Part,RegionCome,GoFromRegion,lr.Name as RegName
FROM         dbo.business_trip INNER JOIN
                      dbo.Users ON dbo.business_trip.UserID = dbo.Users.UserID INNER JOIN
                      dbo.Conn_Reviewed ON dbo.business_trip.BusinessTripID = dbo.Conn_Reviewed.BusinessTripID INNER JOIN
                      dbo.List_classifications_Type ON dbo.Conn_Reviewed.tes_baxilmiwaraw = dbo.List_classifications_Type.ListID
 inner join List_classification_Regions as lr on lr.RegionsID=dbo.business_trip.RegionID 
WHERE     (dbo.Conn_Reviewed.ReviewedID = 0)
----baxiw kecirilmiw istismarda olan obyektler
union
SELECT     dbo.Users.UserID, dbo.Users.Name + ' ' + dbo.Users.Sname AS Name, dbo.Conn_Object_operation.ObjectOther AS Other, 
                      dbo.Conn_Object_operation.ConnID AS OtherID, dbo.List_classifications_Type.PurposeName, dbo.business_trip.BusinessTripID, 
                      dbo.Conn_Object_operation.tes_istobyekt AS Tesnifat, dbo.List_classifications_Type.Part,RegionCome,GoFromRegion,lr.Name as RegName
FROM         dbo.business_trip INNER JOIN
                      dbo.Users ON dbo.business_trip.UserID = dbo.Users.UserID INNER JOIN
                      dbo.Conn_Object_operation ON dbo.business_trip.BusinessTripID = dbo.Conn_Object_operation.BusinessTripID INNER JOIN
                      dbo.List_classifications_Type ON dbo.Conn_Object_operation.tes_istobyekt = dbo.List_classifications_Type.ListID
 inner join List_classification_Regions as lr on lr.RegionsID=dbo.business_trip.RegionID 
WHERE     (dbo.Conn_Object_operation.ObjectID = 0)
----baxiw kecirilmiw istismarda olan obyektler2 
union
SELECT     dbo.Users.UserID, dbo.Users.Name + ' ' + dbo.Users.Sname AS Name, dbo.Conn_Object_operation.SubObjectOther AS Other, 
                      dbo.Conn_Object_operation.ConnID AS OtherID, dbo.List_classifications_Type.PurposeName, dbo.business_trip.BusinessTripID, 
                      dbo.Conn_Object_operation.tes_istobyekt2 AS Tesnifat, dbo.List_classifications_Type.Part,RegionCome,GoFromRegion,lr.Name as RegName
FROM         dbo.business_trip INNER JOIN
                      dbo.Users ON dbo.business_trip.UserID = dbo.Users.UserID INNER JOIN
                      dbo.Conn_Object_operation ON dbo.business_trip.BusinessTripID = dbo.Conn_Object_operation.BusinessTripID INNER JOIN
                      dbo.List_classifications_Type ON dbo.Conn_Object_operation.tes_istobyekt2 = dbo.List_classifications_Type.ListID
 inner join List_classification_Regions as lr on lr.RegionsID=dbo.business_trip.RegionID 
WHERE     (dbo.Conn_Object_operation.SubObjectID = 0)
----baxiw kecirilmiw istismarda olan obyektler3
union
SELECT     dbo.business_trip.UserID, dbo.Users.Name + ' ' + dbo.Users.Sname AS Name, dbo.Conn_Object_operation.Living_Point AS Other, 
                      dbo.Conn_Object_operation.ConnID AS OtherID, dbo.List_classifications_Type.PurposeName, dbo.business_trip.BusinessTripID, 
                      dbo.Conn_Object_operation.tes_istobyekt3 AS Tesnifat, dbo.List_classifications_Type.Part,RegionCome,GoFromRegion,lr.Name as RegName
FROM         dbo.business_trip INNER JOIN
                      dbo.Users ON dbo.business_trip.UserID = dbo.Users.UserID INNER JOIN
                      dbo.Conn_Object_operation ON dbo.business_trip.BusinessTripID = dbo.Conn_Object_operation.BusinessTripID INNER JOIN
                      dbo.List_classifications_Type ON dbo.Conn_Object_operation.tes_istobyekt3 = dbo.List_classifications_Type.ListID
 inner join List_classification_Regions as lr on lr.RegionsID=dbo.business_trip.RegionID 
WHERE     (dbo.Conn_Object_operation.Living_PointID = 0)
----baxiw kecirilmiw esaslitemir olunan obyektler
union
SELECT     dbo.Users.UserID, dbo.Users.Name + ' ' + dbo.Users.Sname AS Name, dbo.Conn_facilities.ObjectOther AS Other, dbo.Conn_facilities.ConnID AS OtherId, 
                      dbo.List_classifications_Type.PurposeName, dbo.business_trip.BusinessTripID, dbo.Conn_facilities.tesn_esaslitemir AS Tesnifat, 
                      dbo.List_classifications_Type.Part,RegionCome,GoFromRegion,lr.Name as RegName
FROM         dbo.business_trip INNER JOIN
                      dbo.Users ON dbo.business_trip.UserID = dbo.Users.UserID INNER JOIN
                      dbo.Conn_facilities ON dbo.business_trip.BusinessTripID = dbo.Conn_facilities.BusinessTripID INNER JOIN
                      dbo.List_classifications_Type ON dbo.Conn_facilities.tesn_esaslitemir = dbo.List_classifications_Type.ListID
 inner join List_classification_Regions as lr on lr.RegionsID=dbo.business_trip.RegionID 
WHERE     (dbo.Conn_facilities.ObjectID = 0)
----baxiw kecirilmiw esaslitemir olunan obyektler2
union
SELECT     dbo.Users.UserID, dbo.Users.Name + ' ' + dbo.Users.Sname AS Name, dbo.Conn_facilities.SubObjectOther AS Other, dbo.Conn_facilities.ConnID AS OtherID, 
                      dbo.List_classifications_Type.PurposeName, dbo.business_trip.BusinessTripID, dbo.Conn_facilities.tesn_esaslitemir1 AS Tesnifat, 
                      dbo.List_classifications_Type.Part,RegionCome,GoFromRegion,lr.Name as RegName
FROM         dbo.business_trip INNER JOIN
                      dbo.Users ON dbo.business_trip.UserID = dbo.Users.UserID INNER JOIN
                      dbo.Conn_facilities ON dbo.business_trip.BusinessTripID = dbo.Conn_facilities.BusinessTripID INNER JOIN
                      dbo.List_classifications_Type ON dbo.Conn_facilities.tesn_esaslitemir1 = dbo.List_classifications_Type.ListID
 inner join List_classification_Regions as lr on lr.RegionsID=dbo.business_trip.RegionID 
WHERE     (dbo.Conn_facilities.SubObjectID = 0)
----baxiw kecirilmiw esaslitemir olunan obyektler3
union
SELECT     dbo.Users.UserID, dbo.Users.Name + ' ' + dbo.Users.Sname AS Name, dbo.Conn_facilities.Living_point AS Other, dbo.Conn_facilities.ConnID AS OtherID, 
                      dbo.List_classifications_Type.PurposeName, dbo.business_trip.BusinessTripID, dbo.Conn_facilities.tesn_esaslitemir2 AS Tesnifat, 
                      dbo.List_classifications_Type.Part,RegionCome,GoFromRegion,lr.Name as RegName
FROM         dbo.business_trip INNER JOIN
                      dbo.Users ON dbo.business_trip.UserID = dbo.Users.UserID INNER JOIN
                      dbo.Conn_facilities ON dbo.business_trip.BusinessTripID = dbo.Conn_facilities.BusinessTripID INNER JOIN
                      dbo.List_classifications_Type ON dbo.Conn_facilities.tesn_esaslitemir2 = dbo.List_classifications_Type.ListID
 inner join List_classification_Regions as lr on lr.RegionsID=dbo.business_trip.RegionID 
WHERE     (dbo.Conn_facilities.Living_PointID = 0)
----vetendawlarla kecirilmiw goruwun meqsedi
union
SELECT     dbo.Users.UserID, dbo.Users.Name + ' ' + dbo.Users.Sname AS Name, dbo.Conn_Meetings_with_citizens.PurposeOther AS Other, 
                      dbo.Conn_Meetings_with_citizens.ConnID AS OtherID, dbo.List_classifications_Type.PurposeName, dbo.business_trip.BusinessTripID, 
                      dbo.Conn_Meetings_with_citizens.tesn_vetendawmeqsed AS Tesnifat, dbo.List_classifications_Type.Part,RegionCome,GoFromRegion,lr.Name as RegName
FROM         dbo.business_trip INNER JOIN
                      dbo.Users ON dbo.business_trip.UserID = dbo.Users.UserID INNER JOIN
                      dbo.Conn_Meetings_with_citizens ON dbo.business_trip.BusinessTripID = dbo.Conn_Meetings_with_citizens.BusinessTripID INNER JOIN
                      dbo.List_classifications_Type ON dbo.Conn_Meetings_with_citizens.tesn_vetendawmeqsed = dbo.List_classifications_Type.ListID
 inner join List_classification_Regions as lr on lr.RegionsID=dbo.business_trip.RegionID 
WHERE     (dbo.Conn_Meetings_with_citizens.PurposeID = 0)
----vetendawlarla kecirilmiw goruwun meqsedi2
union
SELECT     dbo.Users.UserID, dbo.Users.Name + ' ' + dbo.Users.Sname AS Name, dbo.Conn_Meetings_with_citizens.Living_adres, 
                      dbo.Conn_Meetings_with_citizens.ConnID AS OtherID, dbo.List_classifications_Type.PurposeName, dbo.business_trip.BusinessTripID, 
                      dbo.Conn_Meetings_with_citizens.tesn_vetendawmeqsed1 AS Tesnifat, dbo.List_classifications_Type.Part,RegionCome,GoFromRegion,lr.Name as RegName
FROM         dbo.business_trip INNER JOIN
                      dbo.Users ON dbo.business_trip.UserID = dbo.Users.UserID INNER JOIN
                      dbo.Conn_Meetings_with_citizens ON dbo.business_trip.BusinessTripID = dbo.Conn_Meetings_with_citizens.BusinessTripID INNER JOIN
                      dbo.List_classifications_Type ON dbo.Conn_Meetings_with_citizens.tesn_vetendawmeqsed1 = dbo.List_classifications_Type.ListID
 inner join List_classification_Regions as lr on lr.RegionsID=dbo.business_trip.RegionID 
WHERE     (dbo.Conn_Meetings_with_citizens.Living_adresID = 0)
----ictimai siyasi ve dini durum
union
SELECT     dbo.Users.UserID, dbo.Users.Name + ' ' + dbo.Users.Sname AS Name, dbo.Conn_religious_political.ReligiousOther AS Other, 
                      dbo.Conn_religious_political.ConnID AS OtherID, dbo.List_classifications_Type.PurposeName, dbo.business_trip.BusinessTripID, 
                      dbo.Conn_religious_political.tesn_ictimai AS Tesnifat, dbo.List_classifications_Type.Part,RegionCome,GoFromRegion,lr.Name as RegName
FROM         dbo.business_trip INNER JOIN
                      dbo.Users ON dbo.business_trip.UserID = dbo.Users.UserID INNER JOIN
                      dbo.Conn_religious_political ON dbo.business_trip.BusinessTripID = dbo.Conn_religious_political.BusinessTripID INNER JOIN
                      dbo.List_classifications_Type ON dbo.Conn_religious_political.tesn_ictimai = dbo.List_classifications_Type.ListID
 inner join List_classification_Regions as lr on lr.RegionsID=dbo.business_trip.RegionID 
WHERE     (dbo.Conn_religious_political.religious_politicalID = 0)
----ferdi sohbet aparilmiw kardrlar1
union
SELECT     dbo.Users.UserID, dbo.Users.Name + ' ' + dbo.Users.Sname AS Name, dbo.Conn_frames.FramesOther AS Other, dbo.Conn_frames.ConnID AS OtherID, 
                      dbo.List_classifications_Type.PurposeName, dbo.business_trip.BusinessTripID, dbo.Conn_frames.tesn_ferdisohbet AS Tesnifat, 
                      dbo.List_classifications_Type.Part,RegionCome,GoFromRegion,lr.Name as RegName
FROM         dbo.Conn_frames INNER JOIN
                      dbo.business_trip ON dbo.Conn_frames.BusinessTripID = dbo.business_trip.BusinessTripID INNER JOIN
                      dbo.Users ON dbo.business_trip.UserID = dbo.Users.UserID INNER JOIN
                      dbo.List_classifications_Type ON dbo.Conn_frames.tesn_ferdisohbet = dbo.List_classifications_Type.ListID
 inner join List_classification_Regions as lr on lr.RegionsID=dbo.business_trip.RegionID 
WHERE     (dbo.Conn_frames.FramesID = 0)
----ferdi sohbet aparilmiw kardrlar2
union
SELECT     dbo.Users.UserID, dbo.Users.Name + ' ' + dbo.Users.Sname AS Name, dbo.Conn_frames.Sub_FramesOther AS Other, dbo.Conn_frames.ConnID AS OtherID, 
                      dbo.List_classifications_Type.PurposeName, dbo.business_trip.BusinessTripID, dbo.Conn_frames.tesn_ferdisohbet2 AS Tesnifat, 
                      dbo.List_classifications_Type.Part,RegionCome,GoFromRegion,lr.Name as RegName
FROM         dbo.Conn_frames INNER JOIN
                      dbo.business_trip ON dbo.Conn_frames.BusinessTripID = dbo.business_trip.BusinessTripID INNER JOIN
                      dbo.Users ON dbo.business_trip.UserID = dbo.Users.UserID INNER JOIN
                      dbo.List_classifications_Type ON dbo.Conn_frames.tesn_ferdisohbet2 = dbo.List_classifications_Type.ListID
 inner join List_classification_Regions as lr on lr.RegionsID=dbo.business_trip.RegionID 
WHERE     (dbo.Conn_frames.Sub_FramesID = 0)
----yawayiw menteqesi
union
SELECT     dbo.Users.UserID,  dbo.Users.Name + ' ' + dbo.Users.Sname AS Name, dbo.Conn_living.LivingOther AS Other, dbo.Conn_living.ConnID AS OtherID, dbo.List_classifications_Type.PurposeName, 
                      dbo.Conn_living.BusinessTripID, dbo.Conn_living.tesn_yawayiwmen AS Tesnifat, dbo.List_classifications_Type.Part,RegionCome,GoFromRegion,lr.Name as RegName
FROM         dbo.business_trip INNER JOIN
                      dbo.Users ON dbo.business_trip.UserID = dbo.Users.UserID INNER JOIN
                      dbo.Conn_living ON dbo.business_trip.BusinessTripID = dbo.Conn_living.BusinessTripID INNER JOIN
                      dbo.List_classifications_Type ON dbo.Conn_living.tesn_yawayiwmen = dbo.List_classifications_Type.ListID
 inner join List_classification_Regions as lr on lr.RegionsID=dbo.business_trip.RegionID 
WHERE     (dbo.Conn_living.LivingID = 0)

--ezamiyyeninmeqsedi plandaki
union
SELECT     dbo.FRegions.UserID, dbo.Users.Name + ' ' + dbo.Users.Sname AS Name, dbo.FPurposeOfTrip.Purpose AS Other, dbo.FPurposeOfTrip.ConnID AS OtherID, 
                      dbo.List_classifications_Type.PurposeName, dbo.FPurposeOfTrip.RegionID AS BusinessTripID, dbo.FPurposeOfTrip.Tesn_meqsedplan AS Tesnifat, 
                      dbo.List_classifications_Type.Part,RegionCome,GoFromRegion,lr.Name as RegName
FROM         dbo.FPurposeOfTrip INNER JOIN
                      dbo.FRegions INNER JOIN
                      dbo.Users ON dbo.FRegions.UserID = dbo.Users.UserID ON dbo.FPurposeOfTrip.RegionID = dbo.FRegions.RegionID INNER JOIN
                      dbo.List_classifications_Type ON dbo.FPurposeOfTrip.Tesn_meqsedplan = dbo.List_classifications_Type.ListID
 inner join List_classification_Regions as lr on lr.RegionsID=dbo.FRegions.RegionCode
WHERE     (dbo.FPurposeOfTrip.PurposeID = 0)
union
--İştirakı nəzərdə tutulmuş tədbir plandaki
SELECT     dbo.FRegions.UserID, dbo.Users.Name + ' ' + dbo.Users.Sname AS Name, dbo.FIssues_of_results.Actions AS Other, dbo.FIssues_of_results.ConnID AS OtherID, 
                      dbo.List_classifications_Type.PurposeName, dbo.FIssues_of_results.RegionID AS BusinessTripID, dbo.FIssues_of_results.Tesn_iwtetbir AS Tesnifat, 
                      dbo.List_classifications_Type.Part,RegionCome,GoFromRegion,lr.Name as RegName
FROM         dbo.FRegions INNER JOIN
                      dbo.Users ON dbo.FRegions.UserID = dbo.Users.UserID INNER JOIN
                      dbo.FIssues_of_results ON dbo.FRegions.RegionID = dbo.FIssues_of_results.RegionID INNER JOIN
                      dbo.List_classifications_Type ON dbo.FIssues_of_results.Tesn_iwtetbir = dbo.List_classifications_Type.ListID
 inner join List_classification_Regions as lr on lr.RegionsID=dbo.FRegions.RegionCode 
WHERE     (dbo.FIssues_of_results.ActionsID = 0)
--Müzakirə olunacaq məsələ
union
SELECT     dbo.FRegions.UserID, dbo.Users.Name + ' ' + dbo.Users.Sname AS Name, dbo.FIssues_of_results.Issues AS Other, dbo.FIssues_of_results.ConnID AS OtherID, 
                      dbo.List_classifications_Type.PurposeName, dbo.FIssues_of_results.RegionID AS BusinessTripID, dbo.FIssues_of_results.Tesn_muzakire AS Tesnifat, 
                      dbo.List_classifications_Type.Part,RegionCome,GoFromRegion,lr.Name as RegName
FROM         dbo.FRegions INNER JOIN
                      dbo.Users ON dbo.FRegions.UserID = dbo.Users.UserID INNER JOIN
                      dbo.FIssues_of_results ON dbo.FRegions.RegionID = dbo.FIssues_of_results.RegionID INNER JOIN
                      dbo.List_classifications_Type ON dbo.FIssues_of_results.Tesn_muzakire = dbo.List_classifications_Type.ListID
 inner join List_classification_Regions as lr on lr.RegionsID=dbo.FRegions.RegionCode 
WHERE     (dbo.FIssues_of_results.IssuesID = 0)
--yawayiw menteqesi plan
union
SELECT     dbo.FRegions.UserID, dbo.Users.Name + ' ' + dbo.Users.Sname AS Name, dbo.FIndividual_meetings_citizens.Living_point AS Other, 
                      dbo.FIndividual_meetings_citizens.ConnID AS OtherID, dbo.List_classifications_Type.PurposeName, dbo.FIndividual_meetings_citizens.RegionID AS BusinessTripID, 
                      dbo.FIndividual_meetings_citizens.Tesn_yawayiw AS Tesnifat, dbo.List_classifications_Type.Part,RegionCome,GoFromRegion,lr.Name as RegName
FROM         dbo.FIndividual_meetings_citizens INNER JOIN
                      dbo.List_classifications_Type ON dbo.FIndividual_meetings_citizens.Tesn_yawayiw = dbo.List_classifications_Type.ListID INNER JOIN
                      dbo.FRegions INNER JOIN
                      dbo.Users ON dbo.FRegions.UserID = dbo.Users.UserID ON dbo.FIndividual_meetings_citizens.RegionID = dbo.FRegions.RegionID
 inner join List_classification_Regions as lr on lr.RegionsID=dbo.FRegions.RegionCode 
WHERE     (dbo.FIndividual_meetings_citizens.Living_pointId = 0)
--meqsed plan 
union
SELECT     dbo.FRegions.UserID, dbo.Users.Name + ' ' + dbo.Users.Sname AS Name, dbo.FIndividual_meetings_citizens.Purpose AS Other, 
                      dbo.FIndividual_meetings_citizens.ConnID AS OtherID, dbo.List_classifications_Type.PurposeName, dbo.FIndividual_meetings_citizens.RegionID AS BusinessTripID, 
                      dbo.FIndividual_meetings_citizens.Tesn_meqsed AS Tesnifat, dbo.List_classifications_Type.Part,RegionCome,GoFromRegion,lr.Name as RegName
FROM         dbo.FIndividual_meetings_citizens INNER JOIN
                      dbo.FRegions INNER JOIN
                      dbo.Users ON dbo.FRegions.UserID = dbo.Users.UserID ON dbo.FIndividual_meetings_citizens.RegionID = dbo.FRegions.RegionID INNER JOIN
                      dbo.List_classifications_Type ON dbo.FIndividual_meetings_citizens.Tesn_meqsed = dbo.List_classifications_Type.ListID
 inner join List_classification_Regions as lr on lr.RegionsID=dbo.FRegions.RegionCode 
WHERE     (dbo.FIndividual_meetings_citizens.PurposeID = 0)
--icra orqani
union
SELECT     dbo.FRegions.UserID, dbo.Users.Name + ' ' + dbo.Users.Sname AS Name, dbo.FDesigned_staff.Executive_body AS Other, dbo.FDesigned_staff.ConnID AS OtherID, 
                      dbo.List_classifications_Type.PurposeName, dbo.FDesigned_staff.RegionID AS BusinessTripID, dbo.FDesigned_staff.Tesn_icraorqan AS Tesnifat, 
                      dbo.List_classifications_Type.Part,RegionCome,GoFromRegion,lr.Name as RegName
FROM         dbo.FDesigned_staff INNER JOIN
                      dbo.List_classifications_Type ON dbo.FDesigned_staff.Tesn_icraorqan = dbo.List_classifications_Type.ListID INNER JOIN
                      dbo.FRegions INNER JOIN
                      dbo.Users ON dbo.FRegions.UserID = dbo.Users.UserID ON dbo.FDesigned_staff.RegionID = dbo.FRegions.RegionID
 inner join List_classification_Regions as lr on lr.RegionsID=dbo.FRegions.RegionCode 
WHERE     (dbo.FDesigned_staff.Executive_bodyID = 0)
--tutdugu vezife
union
SELECT     dbo.FRegions.UserID, dbo.Users.Name + ' ' + dbo.Users.Sname AS Name, dbo.FDesigned_staff.Positions AS Other, dbo.FDesigned_staff.ConnID AS OtherID, 
                      dbo.List_classifications_Type.PurposeName, dbo.FDesigned_staff.RegionID AS BusinessTripID, dbo.FDesigned_staff.Tesn_tutduguvez AS Tesnifat, 
                      dbo.List_classifications_Type.Part,RegionCome,GoFromRegion,lr.Name as RegName
FROM         dbo.FDesigned_staff INNER JOIN
                      dbo.FRegions INNER JOIN
                      dbo.Users ON dbo.FRegions.UserID = dbo.Users.UserID ON dbo.FDesigned_staff.RegionID = dbo.FRegions.RegionID INNER JOIN
                      dbo.List_classifications_Type ON dbo.FDesigned_staff.Tesn_tutduguvez = dbo.List_classifications_Type.ListID
 inner join List_classification_Regions as lr on lr.RegionsID=dbo.FRegions.RegionCode 
WHERE     (dbo.FDesigned_staff.PositionsID = 0)
--meqsed ferdi sohbet
union
SELECT     dbo.FRegions.UserID, dbo.Users.Name + ' ' + dbo.Users.Sname AS Name, dbo.FDesigned_staff.Purpose AS Other, dbo.FDesigned_staff.ConnID AS OtherID, 
                      dbo.List_classifications_Type.PurposeName, dbo.FDesigned_staff.RegionID AS BusinessTripID, dbo.FDesigned_staff.Tesn_meqsedferdi AS Tesnifat, 
                      dbo.List_classifications_Type.Part,RegionCome,GoFromRegion,lr.Name as RegName
FROM         dbo.FDesigned_staff INNER JOIN
                      dbo.FRegions INNER JOIN
                      dbo.Users ON dbo.FRegions.UserID = dbo.Users.UserID ON dbo.FDesigned_staff.RegionID = dbo.FRegions.RegionID INNER JOIN
                      dbo.List_classifications_Type ON dbo.FDesigned_staff.Tesn_meqsedferdi = dbo.List_classifications_Type.ListID
 inner join List_classification_Regions as lr on lr.RegionsID=dbo.FRegions.RegionCode 
WHERE     (dbo.FDesigned_staff.PurposeID = 0)
--Olacağı İHB nümayəndəlikləri
union
SELECT     dbo.FRegions.UserID, dbo.Users.Name + ' ' + dbo.Users.Sname AS Name, dbo.FDelegate_IHB.Delegate AS Other, dbo.FDelegate_IHB.ConnID AS OtherID, 
                      dbo.List_classifications_Type.PurposeName, dbo.FDelegate_IHB.RegionID AS BusinessTripID, dbo.FDelegate_IHB.Tesn_ihbnum AS Tesnifat, 
                      dbo.List_classifications_Type.Part,RegionCome,GoFromRegion,lr.Name as RegName
FROM         dbo.FRegions INNER JOIN
                      dbo.Users ON dbo.FRegions.UserID = dbo.Users.UserID INNER JOIN
                      dbo.FDelegate_IHB ON dbo.FRegions.RegionID = dbo.FDelegate_IHB.RegionID INNER JOIN
                      dbo.List_classifications_Type ON dbo.FDelegate_IHB.Tesn_ihbnum = dbo.List_classifications_Type.ListID
 inner join List_classification_Regions as lr on lr.RegionsID=dbo.FRegions.RegionCode 
WHERE     (dbo.FDelegate_IHB.DelegateID = 0)
-- olacagi ihb meqsed
union
SELECT     dbo.FRegions.UserID, dbo.Users.Name + ' ' + dbo.Users.Sname AS Name, dbo.FDelegate_IHB.Purpose AS Other, dbo.FDelegate_IHB.ConnID AS OtherID, 
                      dbo.List_classifications_Type.PurposeName, dbo.FDelegate_IHB.RegionID AS BusinessTripID, dbo.FDelegate_IHB.Tesnif_meqsed AS Tesnifat, 
                      dbo.List_classifications_Type.Part,RegionCome,GoFromRegion,lr.Name as RegName
FROM         dbo.FRegions INNER JOIN
                      dbo.Users ON dbo.FRegions.UserID = dbo.Users.UserID INNER JOIN
                      dbo.FDelegate_IHB ON dbo.FRegions.RegionID = dbo.FDelegate_IHB.RegionID INNER JOIN
                      dbo.List_classifications_Type ON dbo.FDelegate_IHB.Tesnif_meqsed = dbo.List_classifications_Type.ListID
 inner join List_classification_Regions as lr on lr.RegionsID=dbo.FRegions.RegionCode 
WHERE     (dbo.FDelegate_IHB.PurposeID = 0)
-- olacagi yawayiw menteqesi
union
SELECT     dbo.FRegions.UserID, dbo.Users.Name + ' ' + dbo.Users.Sname AS Name, dbo.FLiving_point.Living AS Other, dbo.FLiving_point.ConnID AS OtherID, 
                      dbo.List_classifications_Type.PurposeName, dbo.FLiving_point.RegionID AS BusinessTripID, dbo.FLiving_point.Tesn_yawayiw AS Tesnifat, 
                      dbo.List_classifications_Type.Part,RegionCome,GoFromRegion,lr.Name as RegName
FROM         dbo.FRegions INNER JOIN
                      dbo.Users ON dbo.FRegions.UserID = dbo.Users.UserID INNER JOIN
                      dbo.FLiving_point ON dbo.FRegions.RegionID = dbo.FLiving_point.RegionID INNER JOIN
                      dbo.List_classifications_Type ON dbo.FLiving_point.Tesn_yawayiw = dbo.List_classifications_Type.ListID
 inner join List_classification_Regions as lr on lr.RegionsID=dbo.FRegions.RegionCode 
WHERE  (dbo.FLiving_point.LivingID = 0)
--olacagi yawayiw menteqesi meqsed
union
SELECT     dbo.FRegions.UserID, dbo.Users.Name + ' ' + dbo.Users.Sname AS Name, dbo.FLiving_point.Purpose AS Other, dbo.FLiving_point.ConnID AS OtherID, 
                      dbo.List_classifications_Type.PurposeName, dbo.FLiving_point.RegionID AS BusinessTripID, dbo.FLiving_point.Tesn_meqsed AS Tesnifat, 
                      dbo.List_classifications_Type.Part,RegionCome,GoFromRegion,lr.Name as RegName
FROM         dbo.FRegions INNER JOIN
                      dbo.Users ON dbo.FRegions.UserID = dbo.Users.UserID INNER JOIN
                      dbo.FLiving_point ON dbo.FRegions.RegionID = dbo.FLiving_point.RegionID INNER JOIN
                      dbo.List_classifications_Type ON dbo.FLiving_point.Tesn_meqsed = dbo.List_classifications_Type.ListID
 inner join List_classification_Regions as lr on lr.RegionsID=dbo.FRegions.RegionCode 
WHERE     (dbo.FLiving_point.PurposeID = 0)) as kkk where kkk.Other is not null and kkk.Other<>''
order by  UserID,Name,Part,PurposeName,Other
";

        DataTable dtGruplar = klas.getdatatable(s);//and b.RegionCome >'" + Convert.ToDateTime(gelme) + "' order by [RegionCome]
        DataList1.DataSource = dtGruplar;
        DataList1.DataBind();
        if (dtGruplar.Rows.Count > 0)
        {
            DataList1.Visible = true;
        }
        else {
            DataList1.Visible = false;
            //lblmeqsedsil.Text = "";
        }
        lblmeqsedsil.ForeColor = Color.Green;
    }

    void yawayiwiedelave()
    {
        DataTable dtilceler = klas.getdatatable("Select * from Administrative_Department Where RegionID=" + ddlmeqsedsort.SelectedValue + " and ForDelete=1  order by [DepartmentName]");
        ddliedyawayiwelave.DataTextField = "DepartmentName";
        ddliedyawayiwelave.DataValueField = "DepartmentID";
        ddliedyawayiwelave.DataSource = dtilceler;
        ddliedyawayiwelave.DataBind();
    }
    void status()
    {
        DataTable dtilceler = klas.getdatatable("Select * from List_SubRegions_type   order by [Name]");
        ddlihbrayonelave.DataTextField = "Name";
        ddlihbrayonelave.DataValueField = "AreaID";
        ddlihbrayonelave.DataSource = dtilceler;
        ddlihbrayonelave.DataBind();
    }
    void rayon()
    {
        DataTable dtiller = klas.getdatatable("Select * from List_classification_Regions where ForDelete=1  order by [Name]");
        ddlmeqsedsort.DataTextField = "Name";
        ddlmeqsedsort.DataValueField = "RegionsID";
        ddlmeqsedsort.DataSource = dtiller;
        ddlmeqsedsort.DataBind();
    }
    void regionihb1()
    {
        DataTable dtiller = klas.getdatatable("Select ClassifID,ClassifName,ListID from List_classifications where ListID=12 order by sort");
        ddlihbrayonelave.DataTextField = "ClassifName";
        ddlihbrayonelave.DataValueField = "ClassifID";
        ddlihbrayonelave.DataSource = dtiller;
        ddlihbrayonelave.DataBind();
    }

    void ihbsort1()
    {
        DataTable dtilceler = klas.getdatatable("Select * from List_SubClassifictions Where ListID=" + ddlihbrayonelave.SelectedValue + " order by [sort]");
        ddlmeqsedsort.DataTextField = "ClassificationName";
        ddlmeqsedsort.DataValueField = "ClassifID";
        ddlmeqsedsort.DataSource = dtilceler;
        ddlmeqsedsort.DataBind();
    }
    void meqsedsort()
    {
        DataTable meqsed = klas.getdatatable("Select ClassifID,ClassifName,ListID from List_classifications where ListID='"+Tesnifat+"' order by sort");
        ddlmeqsedsort.DataTextField = "ClassifName";
        ddlmeqsedsort.DataValueField = "ClassifID";
        ddlmeqsedsort.DataSource = meqsed;
        ddlmeqsedsort.DataBind();
    }
    void regionihb()
    {
        DataTable dtiller = klas.getdatatable("Select ClassifID,ClassifName,ListID from List_classifications where ListID=17 order by sort");
        ddlihbrayonelave.DataTextField = "ClassifName";
        ddlihbrayonelave.DataValueField = "ClassifID";
        ddlihbrayonelave.DataSource = dtiller;
        ddlihbrayonelave.DataBind();
    }
    void ihbsort()
    {
        DataTable dtilceler = klas.getdatatable("Select * from List_classifications Where ListID=" + ddlihbrayonelave.SelectedValue + " order by sort");
        ddlmeqsedsort.DataTextField = "ClassifName";
        ddlmeqsedsort.DataValueField = "ClassifID";
        ddlmeqsedsort.DataSource = dtilceler;
        ddlmeqsedsort.DataBind();
    }
  
    //void meqsedsort1()
    //{
    //    DataTable meqsed = klas.getdatatable("Select ClassifID,ClassifName,ListID from List_classifications where ListID=4 order by sort");
    //    ddlmeqsedsort.DataTextField = "ClassifName";
    //    ddlmeqsedsort.DataValueField = "ClassifID";
    //    ddlmeqsedsort.DataSource = meqsed;
    //    ddlmeqsedsort.DataBind();
    //}
    protected void btnesas_Click1(object sender, EventArgs e)
    {
        if (Tesnifat == "4")
        {
            DataRow classifid;
            string classifid1;
            if (txtmeqsedelave.Text != "")
            {
                DataRow drrayon = klas.GetDataRow("Select * from List_classifications Where ListID=4 and ClassifName='" + txtmeqsedelave.Text + "'");
                if (drrayon == null && ddlmeqsedsort.SelectedValue != "-1")
                {
                    if (ddlmeqsedsort.SelectedValue != "0")
                    {
                        classifid = klas.GetDataRow("Select * from List_classifications Where ListID=4 and ClassifID='" + ddlmeqsedsort.SelectedValue + "'");
                        classifid1 = classifid["sort"].ToString();
                    }
                    else
                    {
                        classifid = klas.GetDataRow("Select MIN(sort) as sort from List_classifications Where ListID=4");
                        //int.Parse(classifid.ToString()) - 1;
                        classifid1 = (int.Parse(classifid["sort"].ToString()) - 1).ToString();

                    }
                    int secilmiwsortid = int.Parse(classifid1.ToString());
                    DataTable sorthamisi = klas.getdatatable("Select * from List_classifications Where ListID=4");
                    for (int i = 0; i < sorthamisi.Rows.Count; i++)
                    {
                        if (secilmiwsortid < int.Parse(sorthamisi.Rows[i]["sort"].ToString()))
                        {
                            int a1 = int.Parse(sorthamisi.Rows[i]["sort"].ToString()) + 1;
                            int a = int.Parse(sorthamisi.Rows[i]["sort"].ToString());
                            int classif = int.Parse(sorthamisi.Rows[i]["ClassifID"].ToString());
                            SqlConnection baglanti = klas.baglan();
                            SqlCommand cmd1 = new SqlCommand("Update List_classifications Set sort=@sort Where ListID=4 and sort='" + a.ToString() + "' and ClassifID='" + classif.ToString() + "'", baglanti);
                            cmd1.Parameters.Add("sort", a1);
                            cmd1.ExecuteNonQuery();
                        }
                    }

                    SqlConnection baglanti1 = klas.baglan();
                    SqlCommand cmd = new SqlCommand("Insert into List_classifications (ClassifName,ListID,sort) values(@ClassifName,@ListID,@sort)", baglanti1);
                    cmd.Parameters.Add("ClassifName", txtmeqsedelave.Text);
                    cmd.Parameters.Add("ListID", 4);
                    cmd.Parameters.Add("sort", int.Parse(classifid1.ToString()) + 1);
                    cmd.ExecuteNonQuery();
                    lblmeqsedelave.Text = "Məqsəd əlavə edildi";
                    lblmeqsedelave.ForeColor = Color.Green;

                    meqsedsort();
                    ddlmeqsedsort.Items.Insert(0, new ListItem("Seçin", "-1"));
                    ddlmeqsedsort.Items.Insert(1, new ListItem("Əvvələ", "0"));
                    DataRow maxmeqsed;
                    string maxmeqsed1;
                    maxmeqsed = klas.GetDataRow("Select MAX(ClassifID) as ClassifID from List_classifications Where ListID=4");
                    maxmeqsed1 = maxmeqsed["ClassifID"].ToString();
                    SqlConnection baglanti7 = klas.baglan();
                    SqlCommand cmd7 = new SqlCommand("Update Conn_PurposeOfTrip Set PurposeId=@PurposeId,Other=@Other Where ConnID=" + OtherID, baglanti7);
                    cmd7.Parameters.Add("PurposeId", maxmeqsed1);
                    cmd7.Parameters.Add("Other", txtmeqsedelave.Text);
                    cmd7.ExecuteNonQuery();
                    txtmeqsedelave.Text = "";

                    Response.Redirect("Diger.aspx");
                }
                else
                {
                    if (drrayon != null)
                    {
                        lblmeqsedelave.Text = "Elavə etmək istədiyiniz artıq bazada var";
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
                lblmeqsedelave.Text = "Digər boşluq ola bilməz";
                lblmeqsedelave.ForeColor = Color.Red;
            }
        }








        if (Tesnifat == "57")
        {
            DataRow classifid;
            string classifid1;
            if (txtmeqsedelave.Text != "")
            {
                DataRow drrayon = klas.GetDataRow("Select * from List_classifications Where ListID=45 and ClassifName='" + txtmeqsedelave.Text + "'");
                if (drrayon == null && ddlmeqsedsort.SelectedValue != "-1")
                {
                    if (ddlmeqsedsort.SelectedValue != "0")
                    {
                        classifid = klas.GetDataRow("Select * from List_classifications Where ListID=45 and ClassifID='" + ddlmeqsedsort.SelectedValue + "'");
                        classifid1 = classifid["sort"].ToString();
                    }
                    else
                    {
                        classifid = klas.GetDataRow("Select MIN(sort) as sort from List_classifications Where ListID=45");
                        //int.Parse(classifid.ToString()) - 1;
                        classifid1 = (int.Parse(classifid["sort"].ToString()) - 1).ToString();

                    }
                    int secilmiwsortid = int.Parse(classifid1.ToString());
                    DataTable sorthamisi = klas.getdatatable("Select * from List_classifications Where ListID=45");
                    for (int i = 0; i < sorthamisi.Rows.Count; i++)
                    {
                        if (secilmiwsortid < int.Parse(sorthamisi.Rows[i]["sort"].ToString()))
                        {
                            int a1 = int.Parse(sorthamisi.Rows[i]["sort"].ToString()) + 1;
                            int a = int.Parse(sorthamisi.Rows[i]["sort"].ToString());
                            int classif = int.Parse(sorthamisi.Rows[i]["ClassifID"].ToString());
                            SqlConnection baglanti = klas.baglan();
                            SqlCommand cmd1 = new SqlCommand("Update List_classifications Set sort=@sort Where ListID=45 and sort='" + a.ToString() + "' and ClassifID='" + classif.ToString() + "'", baglanti);
                            cmd1.Parameters.Add("sort", a1);
                            cmd1.ExecuteNonQuery();
                        }
                    }

                    SqlConnection baglanti1 = klas.baglan();
                    SqlCommand cmd = new SqlCommand("Insert into List_classifications (ClassifName,ListID,sort) values(@ClassifName,@ListID,@sort)", baglanti1);
                    cmd.Parameters.Add("ClassifName", txtmeqsedelave.Text);
                    cmd.Parameters.Add("ListID", 45);
                    cmd.Parameters.Add("sort", int.Parse(classifid1.ToString()) + 1);
                    cmd.ExecuteNonQuery();
                    lblmeqsedelave.Text = "Məqsəd əlavə edildi";
                    lblmeqsedelave.ForeColor = Color.Green;

                    meqsedsort();
                    ddlmeqsedsort.Items.Insert(0, new ListItem("Seçin", "-1"));
                    ddlmeqsedsort.Items.Insert(1, new ListItem("Əvvələ", "0"));
                    DataRow maxmeqsed;
                    string maxmeqsed1;
                    maxmeqsed = klas.GetDataRow("Select MAX(ClassifID) as ClassifID from List_classifications Where ListID=45");
                    maxmeqsed1 = maxmeqsed["ClassifID"].ToString();
                    SqlConnection baglanti7 = klas.baglan();
                    SqlCommand cmd7 = new SqlCommand("Update FLiving_point Set PurposeID=@PurposeID,Purpose=@Purpose Where ConnID=" + OtherID, baglanti7);
                    cmd7.Parameters.Add("PurposeId", maxmeqsed1);
                    cmd7.Parameters.Add("Purpose", txtmeqsedelave.Text);
                    cmd7.ExecuteNonQuery();
                    txtmeqsedelave.Text = "";

                    Response.Redirect("Diger.aspx");
                }
                else
                {
                    if (drrayon != null)
                    {
                        lblmeqsedelave.Text = "Elavə etmək istədiyiniz artıq bazada var";
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
                lblmeqsedelave.Text = "Digər boşluq ola bilməz";
                lblmeqsedelave.ForeColor = Color.Red;
            }
        }











        if (Tesnifat == "55")
        {
            DataRow classifid;
            string classifid1;
            if (txtmeqsedelave.Text != "")
            {
                DataRow drrayon = klas.GetDataRow("Select * from List_classifications Where ListID=44 and ClassifName='" + txtmeqsedelave.Text + "'");
                if (drrayon == null && ddlmeqsedsort.SelectedValue != "-1")
                {
                    if (ddlmeqsedsort.SelectedValue != "0")
                    {
                        classifid = klas.GetDataRow("Select * from List_classifications Where ListID=44 and ClassifID='" + ddlmeqsedsort.SelectedValue + "'");
                        classifid1 = classifid["sort"].ToString();
                    }
                    else
                    {
                        classifid = klas.GetDataRow("Select MIN(sort) as sort from List_classifications Where ListID=44");
                        //int.Parse(classifid.ToString()) - 1;
                        classifid1 = (int.Parse(classifid["sort"].ToString()) - 1).ToString();

                    }
                    int secilmiwsortid = int.Parse(classifid1.ToString());
                    DataTable sorthamisi = klas.getdatatable("Select * from List_classifications Where ListID=44");
                    for (int i = 0; i < sorthamisi.Rows.Count; i++)
                    {
                        if (secilmiwsortid < int.Parse(sorthamisi.Rows[i]["sort"].ToString()))
                        {
                            int a1 = int.Parse(sorthamisi.Rows[i]["sort"].ToString()) + 1;
                            int a = int.Parse(sorthamisi.Rows[i]["sort"].ToString());
                            int classif = int.Parse(sorthamisi.Rows[i]["ClassifID"].ToString());
                            SqlConnection baglanti = klas.baglan();
                            SqlCommand cmd1 = new SqlCommand("Update List_classifications Set sort=@sort Where ListID=44 and sort='" + a.ToString() + "' and ClassifID='" + classif.ToString() + "'", baglanti);
                            cmd1.Parameters.Add("sort", a1);
                            cmd1.ExecuteNonQuery();
                        }
                    }

                    SqlConnection baglanti1 = klas.baglan();
                    SqlCommand cmd = new SqlCommand("Insert into List_classifications (ClassifName,ListID,sort) values(@ClassifName,@ListID,@sort)", baglanti1);
                    cmd.Parameters.Add("ClassifName", txtmeqsedelave.Text);
                    cmd.Parameters.Add("ListID", 44);
                    cmd.Parameters.Add("sort", int.Parse(classifid1.ToString()) + 1);
                    cmd.ExecuteNonQuery();
                    lblmeqsedelave.Text = "Məqsəd əlavə edildi";
                    lblmeqsedelave.ForeColor = Color.Green;

                    meqsedsort();
                    ddlmeqsedsort.Items.Insert(0, new ListItem("Seçin", "-1"));
                    ddlmeqsedsort.Items.Insert(1, new ListItem("Əvvələ", "0"));
                    DataRow maxmeqsed;
                    string maxmeqsed1;
                    maxmeqsed = klas.GetDataRow("Select MAX(ClassifID) as ClassifID from List_classifications Where ListID=44");
                    maxmeqsed1 = maxmeqsed["ClassifID"].ToString();
                    SqlConnection baglanti7 = klas.baglan();
                    SqlCommand cmd7 = new SqlCommand("Update FDelegate_IHB Set PurposeID=@PurposeID,Purpose=@Purpose Where ConnID=" + OtherID, baglanti7);
                    cmd7.Parameters.Add("PurposeID", maxmeqsed1);
                    cmd7.Parameters.Add("Purpose", txtmeqsedelave.Text);
                    cmd7.ExecuteNonQuery();
                    txtmeqsedelave.Text = "";

                    Response.Redirect("Diger.aspx");
                }
                else
                {
                    if (drrayon != null)
                    {
                        lblmeqsedelave.Text = "Elavə etmək istədiyiniz artıq bazada var";
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
                lblmeqsedelave.Text = "Digər boşluq ola bilməz";
                lblmeqsedelave.ForeColor = Color.Red;
            }
        }







        if (Tesnifat == "53")
        {
            DataRow classifid;
            string classifid1;
            if (txtmeqsedelave.Text != "")
            {
                DataRow drrayon = klas.GetDataRow("Select * from List_classifications Where ListID=43 and ClassifName='" + txtmeqsedelave.Text + "'");
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

                    meqsedsort();
                    ddlmeqsedsort.Items.Insert(0, new ListItem("Seçin", "-1"));
                    ddlmeqsedsort.Items.Insert(1, new ListItem("Əvvələ", "0"));
                    DataRow maxmeqsed;
                    string maxmeqsed1;
                    maxmeqsed = klas.GetDataRow("Select MAX(ClassifID) as ClassifID from List_classifications Where ListID=43");
                    maxmeqsed1 = maxmeqsed["ClassifID"].ToString();
                    SqlConnection baglanti7 = klas.baglan();
                    SqlCommand cmd7 = new SqlCommand("Update FDesigned_staff Set PurposeID=@PurposeID,Purpose=@Purpose Where ConnID=" + OtherID, baglanti7);
                    cmd7.Parameters.Add("PurposeID", maxmeqsed1);
                    cmd7.Parameters.Add("Purpose", txtmeqsedelave.Text);
                    cmd7.ExecuteNonQuery();
                    txtmeqsedelave.Text = "";

                    Response.Redirect("Diger.aspx");
                }
                else
                {
                    if (drrayon != null)
                    {
                        lblmeqsedelave.Text = "Elavə etmək istədiyiniz artıq bazada var";
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
                lblmeqsedelave.Text = "Digər boşluq ola bilməz";
                lblmeqsedelave.ForeColor = Color.Red;
            }
        }












        if (Tesnifat == "46")
        {
            DataRow classifid;
            string classifid1;
            if (txtmeqsedelave.Text != "")
            {
                DataRow drrayon = klas.GetDataRow("Select * from List_classifications Where ListID=4 and ClassifName='" + txtmeqsedelave.Text + "'");
                if (drrayon == null && ddlmeqsedsort.SelectedValue != "-1")
                {
                    if (ddlmeqsedsort.SelectedValue != "0")
                    {
                        classifid = klas.GetDataRow("Select * from List_classifications Where ListID=4 and ClassifID='" + ddlmeqsedsort.SelectedValue + "'");
                        classifid1 = classifid["sort"].ToString();
                    }
                    else
                    {
                        classifid = klas.GetDataRow("Select MIN(sort) as sort from List_classifications Where ListID=4");
                        //int.Parse(classifid.ToString()) - 1;
                        classifid1 = (int.Parse(classifid["sort"].ToString()) - 1).ToString();

                    }
                    int secilmiwsortid = int.Parse(classifid1.ToString());
                    DataTable sorthamisi = klas.getdatatable("Select * from List_classifications Where ListID=4");
                    for (int i = 0; i < sorthamisi.Rows.Count; i++)
                    {
                        if (secilmiwsortid < int.Parse(sorthamisi.Rows[i]["sort"].ToString()))
                        {
                            int a1 = int.Parse(sorthamisi.Rows[i]["sort"].ToString()) + 1;
                            int a = int.Parse(sorthamisi.Rows[i]["sort"].ToString());
                            int classif = int.Parse(sorthamisi.Rows[i]["ClassifID"].ToString());
                            SqlConnection baglanti = klas.baglan();
                            SqlCommand cmd1 = new SqlCommand("Update List_classifications Set sort=@sort Where ListID=4 and sort='" + a.ToString() + "' and ClassifID='" + classif.ToString() + "'", baglanti);
                            cmd1.Parameters.Add("sort", a1);
                            cmd1.ExecuteNonQuery();
                        }
                    }

                    SqlConnection baglanti1 = klas.baglan();
                    SqlCommand cmd = new SqlCommand("Insert into List_classifications (ClassifName,ListID,sort) values(@ClassifName,@ListID,@sort)", baglanti1);
                    cmd.Parameters.Add("ClassifName", txtmeqsedelave.Text);
                    cmd.Parameters.Add("ListID", 4);
                    cmd.Parameters.Add("sort", int.Parse(classifid1.ToString()) + 1);
                    cmd.ExecuteNonQuery();
                    lblmeqsedelave.Text = "Məqsəd əlavə edildi";
                    lblmeqsedelave.ForeColor = Color.Green;

                    meqsedsort();
                    ddlmeqsedsort.Items.Insert(0, new ListItem("Seçin", "-1"));
                    ddlmeqsedsort.Items.Insert(1, new ListItem("Əvvələ", "0"));
                    DataRow maxmeqsed;
                    string maxmeqsed1;
                    maxmeqsed = klas.GetDataRow("Select MAX(ClassifID) as ClassifID from List_classifications Where ListID=4");
                    maxmeqsed1 = maxmeqsed["ClassifID"].ToString();
                    SqlConnection baglanti7 = klas.baglan();
                    SqlCommand cmd7 = new SqlCommand("Update FPurposeOfTrip Set PurposeID=@PurposeID,Purpose=@Purpose Where ConnID=" + OtherID, baglanti7);
                    cmd7.Parameters.Add("PurposeID", maxmeqsed1);
                    cmd7.Parameters.Add("Purpose", txtmeqsedelave.Text);
                    cmd7.ExecuteNonQuery();
                    txtmeqsedelave.Text = "";

                    Response.Redirect("Diger.aspx");
                }
                else
                {
                    if (drrayon != null)
                    {
                        lblmeqsedelave.Text = "Elavə etmək istədiyiniz artıq bazada var";
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
                lblmeqsedelave.Text = "Digər boşluq ola bilməz";
                lblmeqsedelave.ForeColor = Color.Red;
            }
        }








        if (Tesnifat == "47")
        {
            DataRow classifid;
            string classifid1;
            if (txtmeqsedelave.Text != "")
            {
                DataRow drrayon = klas.GetDataRow("Select * from List_classifications Where ListID=9 and ClassifName='" + txtmeqsedelave.Text + "'");
                if (drrayon == null && ddlmeqsedsort.SelectedValue != "-1")
                {
                    if (ddlmeqsedsort.SelectedValue != "0")
                    {
                        classifid = klas.GetDataRow("Select * from List_classifications Where ListID=9 and ClassifID='" + ddlmeqsedsort.SelectedValue + "'");
                        classifid1 = classifid["sort"].ToString();
                    }
                    else
                    {
                        classifid = klas.GetDataRow("Select MIN(sort) as sort from List_classifications Where ListID=9");
                        //int.Parse(classifid.ToString()) - 1;
                        classifid1 = (int.Parse(classifid["sort"].ToString()) - 1).ToString();

                    }
                    int secilmiwsortid = int.Parse(classifid1.ToString());
                    DataTable sorthamisi = klas.getdatatable("Select * from List_classifications Where ListID=9");
                    for (int i = 0; i < sorthamisi.Rows.Count; i++)
                    {
                        if (secilmiwsortid < int.Parse(sorthamisi.Rows[i]["sort"].ToString()))
                        {
                            int a1 = int.Parse(sorthamisi.Rows[i]["sort"].ToString()) + 1;
                            int a = int.Parse(sorthamisi.Rows[i]["sort"].ToString());
                            int classif = int.Parse(sorthamisi.Rows[i]["ClassifID"].ToString());
                            SqlConnection baglanti = klas.baglan();
                            SqlCommand cmd1 = new SqlCommand("Update List_classifications Set sort=@sort Where ListID=9 and sort='" + a.ToString() + "' and ClassifID='" + classif.ToString() + "'", baglanti);
                            cmd1.Parameters.Add("sort", a1);
                            cmd1.ExecuteNonQuery();
                        }
                    }

                    SqlConnection baglanti1 = klas.baglan();
                    SqlCommand cmd = new SqlCommand("Insert into List_classifications (ClassifName,ListID,sort) values(@ClassifName,@ListID,@sort)", baglanti1);
                    cmd.Parameters.Add("ClassifName", txtmeqsedelave.Text);
                    cmd.Parameters.Add("ListID", 9);
                    cmd.Parameters.Add("sort", int.Parse(classifid1.ToString()) + 1);
                    cmd.ExecuteNonQuery();
                    lblmeqsedelave.Text = "Məqsəd əlavə edildi";
                    lblmeqsedelave.ForeColor = Color.Green;

                    meqsedsort();
                    ddlmeqsedsort.Items.Insert(0, new ListItem("Seçin", "-1"));
                    ddlmeqsedsort.Items.Insert(1, new ListItem("Əvvələ", "0"));
                    DataRow maxmeqsed;
                    string maxmeqsed1;
                    maxmeqsed = klas.GetDataRow("Select MAX(ClassifID) as ClassifID from List_classifications Where ListID=9");
                    maxmeqsed1 = maxmeqsed["ClassifID"].ToString();
                    SqlConnection baglanti7 = klas.baglan();
                    SqlCommand cmd7 = new SqlCommand("Update FIssues_of_results Set ActionsID=@ActionsID,Actions=@Actions Where ConnID=" + OtherID, baglanti7);
                    cmd7.Parameters.Add("ActionsID", maxmeqsed1);
                    cmd7.Parameters.Add("Actions", txtmeqsedelave.Text);
                    cmd7.ExecuteNonQuery();
                    txtmeqsedelave.Text = "";

                    Response.Redirect("Diger.aspx");
                }
                else
                {
                    if (drrayon != null)
                    {
                        lblmeqsedelave.Text = "Elavə etmək istədiyiniz artıq bazada var";
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
                lblmeqsedelave.Text = "Digər boşluq ola bilməz";
                lblmeqsedelave.ForeColor = Color.Red;
            }
        }









        if (Tesnifat == "9")
        {
            DataRow classifid;
            string classifid1;
            if (txtmeqsedelave.Text != "")
            {
                DataRow drrayon = klas.GetDataRow("Select * from List_classifications Where ListID=9 and ClassifName='" + txtmeqsedelave.Text + "'");
                if (drrayon == null && ddlmeqsedsort.SelectedValue != "-1")
                {
                    if (ddlmeqsedsort.SelectedValue != "0")
                    {
                        classifid = klas.GetDataRow("Select * from List_classifications Where ListID=9 and ClassifID='" + ddlmeqsedsort.SelectedValue + "'");
                        classifid1 = classifid["sort"].ToString();
                    }
                    else
                    {
                        classifid = klas.GetDataRow("Select MIN(sort) as sort from List_classifications Where ListID=9");
                        //int.Parse(classifid.ToString()) - 1;
                        classifid1 = (int.Parse(classifid["sort"].ToString()) - 1).ToString();

                    }
                    int secilmiwsortid = int.Parse(classifid1.ToString());
                    DataTable sorthamisi = klas.getdatatable("Select * from List_classifications Where ListID=9");
                    for (int i = 0; i < sorthamisi.Rows.Count; i++)
                    {
                        if (secilmiwsortid < int.Parse(sorthamisi.Rows[i]["sort"].ToString()))
                        {
                            int a1 = int.Parse(sorthamisi.Rows[i]["sort"].ToString()) + 1;
                            int a = int.Parse(sorthamisi.Rows[i]["sort"].ToString());
                            int classif = int.Parse(sorthamisi.Rows[i]["ClassifID"].ToString());
                            SqlConnection baglanti = klas.baglan();
                            SqlCommand cmd1 = new SqlCommand("Update List_classifications Set sort=@sort Where ListID=9 and sort='" + a.ToString() + "' and ClassifID='" + classif.ToString() + "'", baglanti);
                            cmd1.Parameters.Add("sort", a1);
                            cmd1.ExecuteNonQuery();
                        }
                    }

                    SqlConnection baglanti1 = klas.baglan();
                    SqlCommand cmd = new SqlCommand("Insert into List_classifications (ClassifName,ListID,sort) values(@ClassifName,@ListID,@sort)", baglanti1);
                    cmd.Parameters.Add("ClassifName", txtmeqsedelave.Text);
                    cmd.Parameters.Add("ListID", 9);
                    cmd.Parameters.Add("sort", int.Parse(classifid1.ToString()) + 1);
                    cmd.ExecuteNonQuery();
                    lblmeqsedelave.Text = "Məqsəd əlavə edildi";
                    lblmeqsedelave.ForeColor = Color.Green;

                    meqsedsort();
                    ddlmeqsedsort.Items.Insert(0, new ListItem("Seçin", "-1"));
                    ddlmeqsedsort.Items.Insert(1, new ListItem("Əvvələ", "0"));
                    DataRow maxmeqsed;
                    string maxmeqsed1;
                    maxmeqsed = klas.GetDataRow("Select MAX(ClassifID) as ClassifID from List_classifications Where ListID=9");
                    maxmeqsed1 = maxmeqsed["ClassifID"].ToString();
                    SqlConnection baglanti7 = klas.baglan();
                    SqlCommand cmd7 = new SqlCommand("Update Conn_participation_measure Set ParticipationID=@ParticipationID,ParticipationOther=@ParticipationOther Where ConnID=" + OtherID, baglanti7);
                    cmd7.Parameters.Add("ParticipationID", maxmeqsed1);
                    cmd7.Parameters.Add("ParticipationOther", txtmeqsedelave.Text);
                    cmd7.ExecuteNonQuery();
                    txtmeqsedelave.Text = "";

                    Response.Redirect("Diger.aspx");
                }
                else
                {
                    if (drrayon != null)
                    {
                        lblmeqsedelave.Text = "Elavə etmək istədiyiniz artıq bazada var";
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
                lblmeqsedelave.Text = "Digər boşluq ola bilməz";
                lblmeqsedelave.ForeColor = Color.Red;
            }
        }




        if (Tesnifat == "18")
        {
            DataRow classifid;
            string classifid1;
            if (txtmeqsedelave.Text != "")
            {
                DataRow drrayon = klas.GetDataRow("Select * from List_classifications Where ListID=18 and ClassifName='" + txtmeqsedelave.Text + "'");
                if (drrayon == null && ddlmeqsedsort.SelectedValue != "-1")
                {
                    if (ddlmeqsedsort.SelectedValue != "0")
                    {
                        classifid = klas.GetDataRow("Select * from List_classifications Where ListID=18 and ClassifID='" + ddlmeqsedsort.SelectedValue + "'");
                        classifid1 = classifid["sort"].ToString();
                    }
                    else
                    {
                        classifid = klas.GetDataRow("Select MIN(sort) as sort from List_classifications Where ListID=18");
                        classifid1 = (int.Parse(classifid["sort"].ToString()) - 1).ToString();
                    }
                    int secilmiwsortid = int.Parse(classifid1.ToString());
                    DataTable sorthamisi = klas.getdatatable("Select * from List_classifications Where ListID=18");
                    for (int i = 0; i < sorthamisi.Rows.Count; i++)
                    {
                        if (secilmiwsortid < int.Parse(sorthamisi.Rows[i]["sort"].ToString()))
                        {
                            int a1 = int.Parse(sorthamisi.Rows[i]["sort"].ToString()) + 1;
                            int a = int.Parse(sorthamisi.Rows[i]["sort"].ToString());
                            int classif = int.Parse(sorthamisi.Rows[i]["ClassifID"].ToString());
                            SqlConnection baglanti = klas.baglan();
                            SqlCommand cmd1 = new SqlCommand("Update List_classifications Set sort=@sort Where ListID=18 and sort='" + a.ToString() + "' and ClassifID='" + classif.ToString() + "'", baglanti);
                            cmd1.Parameters.Add("sort", a1);
                            cmd1.ExecuteNonQuery();
                        }
                    }

                    SqlConnection baglanti1 = klas.baglan();
                    SqlCommand cmd = new SqlCommand("Insert into List_classifications (ClassifName,ListID,sort) values(@ClassifName,@ListID,@sort)", baglanti1);
                    cmd.Parameters.Add("ClassifName", txtmeqsedelave.Text);
                    cmd.Parameters.Add("ListID", 18);
                    cmd.Parameters.Add("sort", int.Parse(classifid1.ToString()) + 1);
                    cmd.ExecuteNonQuery();
                    lblmeqsedelave.Text = "Məqsəd əlavə edildi";
                    lblmeqsedelave.ForeColor = Color.Green;

                    meqsedsort();
                    ddlmeqsedsort.Items.Insert(0, new ListItem("Seçin", "-1"));
                    ddlmeqsedsort.Items.Insert(1, new ListItem("Əvvələ", "0"));
                    DataRow maxmeqsed;
                    string maxmeqsed1;
                    maxmeqsed = klas.GetDataRow("Select MAX(ClassifID) as ClassifID from List_classifications Where ListID=18");
                    maxmeqsed1 = maxmeqsed["ClassifID"].ToString();
                    SqlConnection baglanti7 = klas.baglan();
                    SqlCommand cmd7 = new SqlCommand("Update Conn_participation_measure Set DiscussedID=@DiscussedID,DiscussedOther=@DiscussedOther Where ConnID=" + OtherID, baglanti7);
                    cmd7.Parameters.Add("DiscussedID", maxmeqsed1);
                    cmd7.Parameters.Add("DiscussedOther", txtmeqsedelave.Text);
                    cmd7.ExecuteNonQuery();
                    txtmeqsedelave.Text = "";

                    Response.Redirect("Diger.aspx");
                }
                else
                {
                    if (drrayon != null)
                    {
                        lblmeqsedelave.Text = "Elavə etmək istədiyiniz artıq bazada var";
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
                lblmeqsedelave.Text = "Digər boşluq ola bilməz";
                lblmeqsedelave.ForeColor = Color.Red;
            }
        }









        if (Tesnifat == "48")
        {
            DataRow classifid;
            string classifid1;
            if (txtmeqsedelave.Text != "")
            {
                DataRow drrayon = klas.GetDataRow("Select * from List_classifications Where ListID=18 and ClassifName='" + txtmeqsedelave.Text + "'");
                if (drrayon == null && ddlmeqsedsort.SelectedValue != "-1")
                {
                    if (ddlmeqsedsort.SelectedValue != "0")
                    {
                        classifid = klas.GetDataRow("Select * from List_classifications Where ListID=18 and ClassifID='" + ddlmeqsedsort.SelectedValue + "'");
                        classifid1 = classifid["sort"].ToString();
                    }
                    else
                    {
                        classifid = klas.GetDataRow("Select MIN(sort) as sort from List_classifications Where ListID=18");
                        classifid1 = (int.Parse(classifid["sort"].ToString()) - 1).ToString();
                    }
                    int secilmiwsortid = int.Parse(classifid1.ToString());
                    DataTable sorthamisi = klas.getdatatable("Select * from List_classifications Where ListID=18");
                    for (int i = 0; i < sorthamisi.Rows.Count; i++)
                    {
                        if (secilmiwsortid < int.Parse(sorthamisi.Rows[i]["sort"].ToString()))
                        {
                            int a1 = int.Parse(sorthamisi.Rows[i]["sort"].ToString()) + 1;
                            int a = int.Parse(sorthamisi.Rows[i]["sort"].ToString());
                            int classif = int.Parse(sorthamisi.Rows[i]["ClassifID"].ToString());
                            SqlConnection baglanti = klas.baglan();
                            SqlCommand cmd1 = new SqlCommand("Update List_classifications Set sort=@sort Where ListID=18 and sort='" + a.ToString() + "' and ClassifID='" + classif.ToString() + "'", baglanti);
                            cmd1.Parameters.Add("sort", a1);
                            cmd1.ExecuteNonQuery();
                        }
                    }

                    SqlConnection baglanti1 = klas.baglan();
                    SqlCommand cmd = new SqlCommand("Insert into List_classifications (ClassifName,ListID,sort) values(@ClassifName,@ListID,@sort)", baglanti1);
                    cmd.Parameters.Add("ClassifName", txtmeqsedelave.Text);
                    cmd.Parameters.Add("ListID", 18);
                    cmd.Parameters.Add("sort", int.Parse(classifid1.ToString()) + 1);
                    cmd.ExecuteNonQuery();
                    lblmeqsedelave.Text = "Məqsəd əlavə edildi";
                    lblmeqsedelave.ForeColor = Color.Green;

                    meqsedsort();
                    ddlmeqsedsort.Items.Insert(0, new ListItem("Seçin", "-1"));
                    ddlmeqsedsort.Items.Insert(1, new ListItem("Əvvələ", "0"));
                    DataRow maxmeqsed;
                    string maxmeqsed1;
                    maxmeqsed = klas.GetDataRow("Select MAX(ClassifID) as ClassifID from List_classifications Where ListID=18");
                    maxmeqsed1 = maxmeqsed["ClassifID"].ToString();
                    SqlConnection baglanti7 = klas.baglan();
                    SqlCommand cmd7 = new SqlCommand("Update FIssues_of_results Set IssuesID=@IssuesID,Issues=@Issues Where ConnID=" + OtherID, baglanti7);
                    cmd7.Parameters.Add("IssuesID", maxmeqsed1);
                    cmd7.Parameters.Add("Issues", txtmeqsedelave.Text);
                    cmd7.ExecuteNonQuery();
                    txtmeqsedelave.Text = "";

                    Response.Redirect("Diger.aspx");
                }
                else
                {
                    if (drrayon != null)
                    {
                        lblmeqsedelave.Text = "Elavə etmək istədiyiniz artıq bazada var";
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
                lblmeqsedelave.Text = "Digər boşluq ola bilməz";
                lblmeqsedelave.ForeColor = Color.Red;
            }
        }







        if (Tesnifat == "10")
        {
            DataRow classifid;
            string classifid1;
            if (txtmeqsedelave.Text != "")
            {
                DataRow drrayon = klas.GetDataRow("Select * from List_classifications Where ListID=10 and ClassifName='" + txtmeqsedelave.Text + "'");
                if (drrayon == null && ddlmeqsedsort.SelectedValue != "-1")
                {
                    if (ddlmeqsedsort.SelectedValue != "0")
                    {
                        classifid = klas.GetDataRow("Select * from List_classifications Where ListID=10 and ClassifID='" + ddlmeqsedsort.SelectedValue + "'");
                        classifid1 = classifid["sort"].ToString();
                    }
                    else
                    {
                        classifid = klas.GetDataRow("Select MIN(sort) as sort from List_classifications Where ListID=10");
                        classifid1 = (int.Parse(classifid["sort"].ToString()) - 1).ToString();
                    }
                    int secilmiwsortid = int.Parse(classifid1.ToString());
                    DataTable sorthamisi = klas.getdatatable("Select * from List_classifications Where ListID=10");
                    for (int i = 0; i < sorthamisi.Rows.Count; i++)
                    {
                        if (secilmiwsortid < int.Parse(sorthamisi.Rows[i]["sort"].ToString()))
                        {
                            int a1 = int.Parse(sorthamisi.Rows[i]["sort"].ToString()) + 1;
                            int a = int.Parse(sorthamisi.Rows[i]["sort"].ToString());
                            int classif = int.Parse(sorthamisi.Rows[i]["ClassifID"].ToString());
                            SqlConnection baglanti = klas.baglan();
                            SqlCommand cmd1 = new SqlCommand("Update List_classifications Set sort=@sort Where ListID=10 and sort='" + a.ToString() + "' and ClassifID='" + classif.ToString() + "'", baglanti);
                            cmd1.Parameters.Add("sort", a1);
                            cmd1.ExecuteNonQuery();
                        }
                    }

                    SqlConnection baglanti1 = klas.baglan();
                    SqlCommand cmd = new SqlCommand("Insert into List_classifications (ClassifName,ListID,sort) values(@ClassifName,@ListID,@sort)", baglanti1);
                    cmd.Parameters.Add("ClassifName", txtmeqsedelave.Text);
                    cmd.Parameters.Add("ListID", 10);
                    cmd.Parameters.Add("sort", int.Parse(classifid1.ToString()) + 1);
                    cmd.ExecuteNonQuery();
                    lblmeqsedelave.Text = "Məqsəd əlavə edildi";
                    lblmeqsedelave.ForeColor = Color.Green;

                    meqsedsort();
                    ddlmeqsedsort.Items.Insert(0, new ListItem("Seçin", "-1"));
                    ddlmeqsedsort.Items.Insert(1, new ListItem("Əvvələ", "0"));
                    DataRow maxmeqsed;
                    string maxmeqsed1;
                    maxmeqsed = klas.GetDataRow("Select MAX(ClassifID) as ClassifID from List_classifications Where ListID=10");
                    maxmeqsed1 = maxmeqsed["ClassifID"].ToString();
                    SqlConnection baglanti7 = klas.baglan();
                    SqlCommand cmd7 = new SqlCommand("Update Conn_Reviewed Set ReviewedID=@ReviewedID,Other=@Other Where ConnID=" + OtherID, baglanti7);
                    cmd7.Parameters.Add("ReviewedID", maxmeqsed1);
                    cmd7.Parameters.Add("Other", txtmeqsedelave.Text);
                    cmd7.ExecuteNonQuery();
                    txtmeqsedelave.Text = "";

                    Response.Redirect("Diger.aspx");
                }
                else
                {
                    if (drrayon != null)
                    {
                        lblmeqsedelave.Text = "Elavə etmək istədiyiniz artıq bazada var";
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
                lblmeqsedelave.Text = "Digər boşluq ola bilməz";
                lblmeqsedelave.ForeColor = Color.Red;
            }
        }






        if (Tesnifat == "13")
        {
            DataRow classifid;
            string classifid1;
            if (txtmeqsedelave.Text != "")
            {
                DataRow drrayon = klas.GetDataRow("Select * from List_classifications Where ListID=13 and ClassifName='" + txtmeqsedelave.Text + "'");
                if (drrayon == null && ddlmeqsedsort.SelectedValue != "-1")
                {
                    if (ddlmeqsedsort.SelectedValue != "0")
                    {
                        classifid = klas.GetDataRow("Select * from List_classifications Where ListID=13 and ClassifID='" + ddlmeqsedsort.SelectedValue + "'");
                        classifid1 = classifid["sort"].ToString();
                    }
                    else
                    {
                        classifid = klas.GetDataRow("Select MIN(sort) as sort from List_classifications Where ListID=13");
                        classifid1 = (int.Parse(classifid["sort"].ToString()) - 1).ToString();
                    }
                    int secilmiwsortid = int.Parse(classifid1.ToString());
                    DataTable sorthamisi = klas.getdatatable("Select * from List_classifications Where ListID=13");
                    for (int i = 0; i < sorthamisi.Rows.Count; i++)
                    {
                        if (secilmiwsortid < int.Parse(sorthamisi.Rows[i]["sort"].ToString()))
                        {
                            int a1 = int.Parse(sorthamisi.Rows[i]["sort"].ToString()) + 1;
                            int a = int.Parse(sorthamisi.Rows[i]["sort"].ToString());
                            int classif = int.Parse(sorthamisi.Rows[i]["ClassifID"].ToString());
                            SqlConnection baglanti = klas.baglan();
                            SqlCommand cmd1 = new SqlCommand("Update List_classifications Set sort=@sort Where ListID=13 and sort='" + a.ToString() + "' and ClassifID='" + classif.ToString() + "'", baglanti);
                            cmd1.Parameters.Add("sort", a1);
                            cmd1.ExecuteNonQuery();
                        }
                    }
                    SqlConnection baglanti1 = klas.baglan();
                    SqlCommand cmd = new SqlCommand("Insert into List_classifications (ClassifName,ListID,sort) values(@ClassifName,@ListID,@sort)", baglanti1);
                    cmd.Parameters.Add("ClassifName", txtmeqsedelave.Text);
                    cmd.Parameters.Add("ListID", 13);
                    cmd.Parameters.Add("sort", int.Parse(classifid1.ToString()) + 1);
                    cmd.ExecuteNonQuery();
                    lblmeqsedelave.Text = "Məqsəd əlavə edildi";
                    lblmeqsedelave.ForeColor = Color.Green;

                    meqsedsort();
                    ddlmeqsedsort.Items.Insert(0, new ListItem("Seçin", "-1"));
                    ddlmeqsedsort.Items.Insert(1, new ListItem("Əvvələ", "0"));
                    DataRow maxmeqsed;
                    string maxmeqsed1;
                    maxmeqsed = klas.GetDataRow("Select MAX(ClassifID) as ClassifID from List_classifications Where ListID=13");
                    maxmeqsed1 = maxmeqsed["ClassifID"].ToString();
                    SqlConnection baglanti7 = klas.baglan();
                    SqlCommand cmd7 = new SqlCommand("Update Conn_Meetings_with_citizens Set PurposeID=@PurposeID,PurposeOther=@PurposeOther Where ConnID=" + OtherID, baglanti7);
                    cmd7.Parameters.Add("PurposeID", maxmeqsed1);
                    cmd7.Parameters.Add("PurposeOther", txtmeqsedelave.Text);
                    cmd7.ExecuteNonQuery();
                    txtmeqsedelave.Text = "";

                    Response.Redirect("Diger.aspx");
                }
                else
                {
                    if (drrayon != null)
                    {
                        lblmeqsedelave.Text = "Elavə etmək istədiyiniz artıq bazada var";
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
                lblmeqsedelave.Text = "Digər boşluq ola bilməz";
                lblmeqsedelave.ForeColor = Color.Red;
            }
        }






        if (Tesnifat == "50")
        {
            DataRow classifid;
            string classifid1;
            if (txtmeqsedelave.Text != "")
            {
                DataRow drrayon = klas.GetDataRow("Select * from List_classifications Where ListID=13 and ClassifName='" + txtmeqsedelave.Text + "'");
                if (drrayon == null && ddlmeqsedsort.SelectedValue != "-1")
                {
                    if (ddlmeqsedsort.SelectedValue != "0")
                    {
                        classifid = klas.GetDataRow("Select * from List_classifications Where ListID=13 and ClassifID='" + ddlmeqsedsort.SelectedValue + "'");
                        classifid1 = classifid["sort"].ToString();
                    }
                    else
                    {
                        classifid = klas.GetDataRow("Select MIN(sort) as sort from List_classifications Where ListID=13");
                        classifid1 = (int.Parse(classifid["sort"].ToString()) - 1).ToString();
                    }
                    int secilmiwsortid = int.Parse(classifid1.ToString());
                    DataTable sorthamisi = klas.getdatatable("Select * from List_classifications Where ListID=13");
                    for (int i = 0; i < sorthamisi.Rows.Count; i++)
                    {
                        if (secilmiwsortid < int.Parse(sorthamisi.Rows[i]["sort"].ToString()))
                        {
                            int a1 = int.Parse(sorthamisi.Rows[i]["sort"].ToString()) + 1;
                            int a = int.Parse(sorthamisi.Rows[i]["sort"].ToString());
                            int classif = int.Parse(sorthamisi.Rows[i]["ClassifID"].ToString());
                            SqlConnection baglanti = klas.baglan();
                            SqlCommand cmd1 = new SqlCommand("Update List_classifications Set sort=@sort Where ListID=13 and sort='" + a.ToString() + "' and ClassifID='" + classif.ToString() + "'", baglanti);
                            cmd1.Parameters.Add("sort", a1);
                            cmd1.ExecuteNonQuery();
                        }
                    }
                    SqlConnection baglanti1 = klas.baglan();
                    SqlCommand cmd = new SqlCommand("Insert into List_classifications (ClassifName,ListID,sort) values(@ClassifName,@ListID,@sort)", baglanti1);
                    cmd.Parameters.Add("ClassifName", txtmeqsedelave.Text);
                    cmd.Parameters.Add("ListID", 13);
                    cmd.Parameters.Add("sort", int.Parse(classifid1.ToString()) + 1);
                    cmd.ExecuteNonQuery();
                    lblmeqsedelave.Text = "Məqsəd əlavə edildi";
                    lblmeqsedelave.ForeColor = Color.Green;

                    meqsedsort();
                    ddlmeqsedsort.Items.Insert(0, new ListItem("Seçin", "-1"));
                    ddlmeqsedsort.Items.Insert(1, new ListItem("Əvvələ", "0"));
                    DataRow maxmeqsed;
                    string maxmeqsed1;
                    maxmeqsed = klas.GetDataRow("Select MAX(ClassifID) as ClassifID from List_classifications Where ListID=13");
                    maxmeqsed1 = maxmeqsed["ClassifID"].ToString();
                    SqlConnection baglanti7 = klas.baglan();
                    SqlCommand cmd7 = new SqlCommand("Update FIndividual_meetings_citizens Set PurposeID=@PurposeID,Purpose=@Purpose Where ConnID=" + OtherID, baglanti7);
                    cmd7.Parameters.Add("PurposeID", maxmeqsed1);
                    cmd7.Parameters.Add("Purpose", txtmeqsedelave.Text);
                    cmd7.ExecuteNonQuery();
                    txtmeqsedelave.Text = "";

                    Response.Redirect("Diger.aspx");
                }
                else
                {
                    if (drrayon != null)
                    {
                        lblmeqsedelave.Text = "Elavə etmək istədiyiniz artıq bazada var";
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
                lblmeqsedelave.Text = "Digər boşluq ola bilməz";
                lblmeqsedelave.ForeColor = Color.Red;
            }
        }





        if (Tesnifat == "14")
        {
            DataRow classifid;
            string classifid1;
            if (txtmeqsedelave.Text != "")
            {
                DataRow drrayon = klas.GetDataRow("Select * from List_classifications Where ListID=14 and ClassifName='" + txtmeqsedelave.Text + "'");
                if (drrayon == null && ddlmeqsedsort.SelectedValue != "-1")
                {
                    if (ddlmeqsedsort.SelectedValue != "0")
                    {
                        classifid = klas.GetDataRow("Select * from List_classifications Where ListID=14 and ClassifID='" + ddlmeqsedsort.SelectedValue + "'");
                        classifid1 = classifid["sort"].ToString();
                    }
                    else
                    {
                        classifid = klas.GetDataRow("Select MIN(sort) as sort from List_classifications Where ListID=14");
                        classifid1 = (int.Parse(classifid["sort"].ToString()) - 1).ToString();
                    }
                    int secilmiwsortid = int.Parse(classifid1.ToString());
                    DataTable sorthamisi = klas.getdatatable("Select * from List_classifications Where ListID=14");
                    for (int i = 0; i < sorthamisi.Rows.Count; i++)
                    {
                        if (secilmiwsortid < int.Parse(sorthamisi.Rows[i]["sort"].ToString()))
                        {
                            int a1 = int.Parse(sorthamisi.Rows[i]["sort"].ToString()) + 1;
                            int a = int.Parse(sorthamisi.Rows[i]["sort"].ToString());
                            int classif = int.Parse(sorthamisi.Rows[i]["ClassifID"].ToString());
                            SqlConnection baglanti = klas.baglan();
                            SqlCommand cmd1 = new SqlCommand("Update List_classifications Set sort=@sort Where ListID=14 and sort='" + a.ToString() + "' and ClassifID='" + classif.ToString() + "'", baglanti);
                            cmd1.Parameters.Add("sort", a1);
                            cmd1.ExecuteNonQuery();
                        }
                    }
                    SqlConnection baglanti1 = klas.baglan();
                    SqlCommand cmd = new SqlCommand("Insert into List_classifications (ClassifName,ListID,sort) values(@ClassifName,@ListID,@sort)", baglanti1);
                    cmd.Parameters.Add("ClassifName", txtmeqsedelave.Text);
                    cmd.Parameters.Add("ListID", 14);
                    cmd.Parameters.Add("sort", int.Parse(classifid1.ToString()) + 1);
                    cmd.ExecuteNonQuery();
                    lblmeqsedelave.Text = "Məqsəd əlavə edildi";
                    lblmeqsedelave.ForeColor = Color.Green;

                    meqsedsort();
                    ddlmeqsedsort.Items.Insert(0, new ListItem("Seçin", "-1"));
                    ddlmeqsedsort.Items.Insert(1, new ListItem("Əvvələ", "0"));
                    DataRow maxmeqsed;
                    string maxmeqsed1;
                    maxmeqsed = klas.GetDataRow("Select MAX(ClassifID) as ClassifID from List_classifications Where ListID=14");
                    maxmeqsed1 = maxmeqsed["ClassifID"].ToString();
                    SqlConnection baglanti7 = klas.baglan();
                    SqlCommand cmd7 = new SqlCommand("Update Conn_religious_political Set religious_politicalID=@religious_politicalID,ReligiousOther=@ReligiousOther Where ConnID=" + OtherID, baglanti7);
                    cmd7.Parameters.Add("religious_politicalID", maxmeqsed1);
                    cmd7.Parameters.Add("ReligiousOther", txtmeqsedelave.Text);
                    cmd7.ExecuteNonQuery();
                    txtmeqsedelave.Text = "";

                    Response.Redirect("Diger.aspx");
                }
                else
                {
                    if (drrayon != null)
                    {
                        lblmeqsedelave.Text = "Elavə etmək istədiyiniz artıq bazada var";
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
                lblmeqsedelave.Text = "Digər boşluq ola bilməz";
                lblmeqsedelave.ForeColor = Color.Red;
            }
        }







        if (Tesnifat == "12")
        {
            DataRow classifid;
            string classifid1;
            if (txtmeqsedelave.Text != "")
            {
                DataRow drrayon = klas.GetDataRow("Select * from List_classifications Where ListID=12 and ClassifName='" + txtmeqsedelave.Text + "'");
                if (drrayon == null && ddlmeqsedsort.SelectedValue != "-1")
                {
                    if (ddlmeqsedsort.SelectedValue != "0")
                    {
                        classifid = klas.GetDataRow("Select * from List_classifications Where ListID=12 and ClassifID='" + ddlmeqsedsort.SelectedValue + "'");
                        classifid1 = classifid["sort"].ToString();
                    }
                    else
                    {
                        classifid = klas.GetDataRow("Select MIN(sort) as sort from List_classifications Where ListID=12");
                        classifid1 = (int.Parse(classifid["sort"].ToString()) - 1).ToString();
                    }
                    int secilmiwsortid = int.Parse(classifid1.ToString());
                    DataTable sorthamisi = klas.getdatatable("Select * from List_classifications Where ListID=12");
                    for (int i = 0; i < sorthamisi.Rows.Count; i++)
                    {
                        if (secilmiwsortid < int.Parse(sorthamisi.Rows[i]["sort"].ToString()))
                        {
                            int a1 = int.Parse(sorthamisi.Rows[i]["sort"].ToString()) + 1;
                            int a = int.Parse(sorthamisi.Rows[i]["sort"].ToString());
                            int classif = int.Parse(sorthamisi.Rows[i]["ClassifID"].ToString());
                            SqlConnection baglanti = klas.baglan();
                            SqlCommand cmd1 = new SqlCommand("Update List_classifications Set sort=@sort Where ListID=12 and sort='" + a.ToString() + "' and ClassifID='" + classif.ToString() + "'", baglanti);
                            cmd1.Parameters.Add("sort", a1);
                            cmd1.ExecuteNonQuery();
                        }
                    }
                    SqlConnection baglanti1 = klas.baglan();
                    SqlCommand cmd = new SqlCommand("Insert into List_classifications (ClassifName,ListID,sort) values(@ClassifName,@ListID,@sort)", baglanti1);
                    cmd.Parameters.Add("ClassifName", txtmeqsedelave.Text);
                    cmd.Parameters.Add("ListID", 12);
                    cmd.Parameters.Add("sort", int.Parse(classifid1.ToString()) + 1);
                    cmd.ExecuteNonQuery();
                    lblmeqsedelave.Text = "Məqsəd əlavə edildi";
                    lblmeqsedelave.ForeColor = Color.Green;

                    meqsedsort();
                    ddlmeqsedsort.Items.Insert(0, new ListItem("Seçin", "-1"));
                    ddlmeqsedsort.Items.Insert(1, new ListItem("Əvvələ", "0"));
                    DataRow maxmeqsed;
                    string maxmeqsed1;
                    maxmeqsed = klas.GetDataRow("Select MAX(ClassifID) as ClassifID from List_classifications Where ListID=12");
                    maxmeqsed1 = maxmeqsed["ClassifID"].ToString();
                    SqlConnection baglanti7 = klas.baglan();
                    SqlCommand cmd7 = new SqlCommand("Update Conn_Object_operation Set ObjectID=@ObjectID,ObjectOther=@ObjectOther Where ConnID=" + OtherID, baglanti7);
                    cmd7.Parameters.Add("ObjectID", maxmeqsed1);
                    cmd7.Parameters.Add("ObjectOther", txtmeqsedelave.Text);
                    cmd7.ExecuteNonQuery();
                    txtmeqsedelave.Text = "";

                    Response.Redirect("Diger.aspx");
                }
                else
                {
                    if (drrayon != null)
                    {
                        lblmeqsedelave.Text = "Elavə etmək istədiyiniz artıq bazada var";
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
                lblmeqsedelave.Text = "Digər boşluq ola bilməz";
                lblmeqsedelave.ForeColor = Color.Red;
            }
        }







        if (Tesnifat == "38")
        {
            DataRow classifid;
            string classifid1;
            if (txtmeqsedelave.Text != "")
            {
                DataRow drrayon = klas.GetDataRow("Select * from List_classifications Where ListID=12 and ClassifName='" + txtmeqsedelave.Text + "'");
                if (drrayon == null && ddlmeqsedsort.SelectedValue != "-1")
                {
                    if (ddlmeqsedsort.SelectedValue != "0")
                    {
                        classifid = klas.GetDataRow("Select * from List_classifications Where ListID=12 and ClassifID='" + ddlmeqsedsort.SelectedValue + "'");
                        classifid1 = classifid["sort"].ToString();
                    }
                    else
                    {
                        classifid = klas.GetDataRow("Select MIN(sort) as sort from List_classifications Where ListID=12");
                        classifid1 = (int.Parse(classifid["sort"].ToString()) - 1).ToString();
                    }
                    int secilmiwsortid = int.Parse(classifid1.ToString());
                    DataTable sorthamisi = klas.getdatatable("Select * from List_classifications Where ListID=12");
                    for (int i = 0; i < sorthamisi.Rows.Count; i++)
                    {
                        if (secilmiwsortid < int.Parse(sorthamisi.Rows[i]["sort"].ToString()))
                        {
                            int a1 = int.Parse(sorthamisi.Rows[i]["sort"].ToString()) + 1;
                            int a = int.Parse(sorthamisi.Rows[i]["sort"].ToString());
                            int classif = int.Parse(sorthamisi.Rows[i]["ClassifID"].ToString());
                            SqlConnection baglanti = klas.baglan();
                            SqlCommand cmd1 = new SqlCommand("Update List_classifications Set sort=@sort Where ListID=12 and sort='" + a.ToString() + "' and ClassifID='" + classif.ToString() + "'", baglanti);
                            cmd1.Parameters.Add("sort", a1);
                            cmd1.ExecuteNonQuery();
                        }
                    }
                    SqlConnection baglanti1 = klas.baglan();
                    SqlCommand cmd = new SqlCommand("Insert into List_classifications (ClassifName,ListID,sort) values(@ClassifName,@ListID,@sort)", baglanti1);
                    cmd.Parameters.Add("ClassifName", txtmeqsedelave.Text);
                    cmd.Parameters.Add("ListID", 12);
                    cmd.Parameters.Add("sort", int.Parse(classifid1.ToString()) + 1);
                    cmd.ExecuteNonQuery();
                    lblmeqsedelave.Text = "Məqsəd əlavə edildi";
                    lblmeqsedelave.ForeColor = Color.Green;

                    meqsedsort();
                    ddlmeqsedsort.Items.Insert(0, new ListItem("Seçin", "-1"));
                    ddlmeqsedsort.Items.Insert(1, new ListItem("Əvvələ", "0"));
                    DataRow maxmeqsed;
                    string maxmeqsed1;
                    maxmeqsed = klas.GetDataRow("Select MAX(ClassifID) as ClassifID from List_classifications Where ListID=12");
                    maxmeqsed1 = maxmeqsed["ClassifID"].ToString();
                    SqlConnection baglanti7 = klas.baglan();
                    SqlCommand cmd7 = new SqlCommand("Update Conn_facilities Set ObjectID=@ObjectID,ObjectOther=@ObjectOther Where ConnID=" + OtherID, baglanti7);
                    cmd7.Parameters.Add("ObjectID", maxmeqsed1);
                    cmd7.Parameters.Add("ObjectOther", txtmeqsedelave.Text);
                    cmd7.ExecuteNonQuery();
                    txtmeqsedelave.Text = "";

                    Response.Redirect("Diger.aspx");
                }
                else
                {
                    if (drrayon != null)
                    {
                        lblmeqsedelave.Text = "Elavə etmək istədiyiniz artıq bazada var";
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
                lblmeqsedelave.Text = "Digər boşluq ola bilməz";
                lblmeqsedelave.ForeColor = Color.Red;
            }
        }















        if (Tesnifat == "17")
        {
            DataRow classifid;
            string classifid1;
            if (txtmeqsedelave.Text != "")
            {
                DataRow drrayon = klas.GetDataRow("Select * from List_classifications Where ListID=17 and ClassifName='" + txtmeqsedelave.Text + "'");
                if (drrayon == null && ddlmeqsedsort.SelectedValue != "-1")
                {
                    if (ddlmeqsedsort.SelectedValue != "0")
                    {
                        classifid = klas.GetDataRow("Select * from List_classifications Where ListID=17 and ClassifID='" + ddlmeqsedsort.SelectedValue + "'");
                        classifid1 = classifid["sort"].ToString();
                    }
                    else
                    {
                        classifid = klas.GetDataRow("Select MIN(sort) as sort from List_classifications Where ListID=17");
                        classifid1 = (int.Parse(classifid["sort"].ToString()) - 1).ToString();
                    }
                    int secilmiwsortid = int.Parse(classifid1.ToString());
                    DataTable sorthamisi = klas.getdatatable("Select * from List_classifications Where ListID=17");
                    for (int i = 0; i < sorthamisi.Rows.Count; i++)
                    {
                        if (secilmiwsortid < int.Parse(sorthamisi.Rows[i]["sort"].ToString()))
                        {
                            int a1 = int.Parse(sorthamisi.Rows[i]["sort"].ToString()) + 1;
                            int a = int.Parse(sorthamisi.Rows[i]["sort"].ToString());
                            int classif = int.Parse(sorthamisi.Rows[i]["ClassifID"].ToString());
                            SqlConnection baglanti = klas.baglan();
                            SqlCommand cmd1 = new SqlCommand("Update List_classifications Set sort=@sort Where ListID=17 and sort='" + a.ToString() + "' and ClassifID='" + classif.ToString() + "'", baglanti);
                            cmd1.Parameters.Add("sort", a1);
                            cmd1.ExecuteNonQuery();
                        }
                    }
                    SqlConnection baglanti1 = klas.baglan();
                    SqlCommand cmd = new SqlCommand("Insert into List_classifications (ClassifName,ListID,sort) values(@ClassifName,@ListID,@sort)", baglanti1);
                    cmd.Parameters.Add("ClassifName", txtmeqsedelave.Text);
                    cmd.Parameters.Add("ListID", 17);
                    cmd.Parameters.Add("sort", int.Parse(classifid1.ToString()) + 1);
                    cmd.ExecuteNonQuery();
                    lblmeqsedelave.Text = "Məqsəd əlavə edildi";
                    lblmeqsedelave.ForeColor = Color.Green;

                    meqsedsort();
                    ddlmeqsedsort.Items.Insert(0, new ListItem("Seçin", "-1"));
                    ddlmeqsedsort.Items.Insert(1, new ListItem("Əvvələ", "0"));

                    DataRow maxmeqsed;
                    string maxmeqsed1;
                    maxmeqsed = klas.GetDataRow("Select MAX(ClassifID) as ClassifID from List_classifications Where ListID=17");
                    maxmeqsed1 = maxmeqsed["ClassifID"].ToString();
                    SqlConnection baglanti7 = klas.baglan();
                    SqlCommand cmd7 = new SqlCommand("Update Conn_frames Set FramesID=@FramesID,FramesOther=@FramesOther Where ConnID=" + OtherID, baglanti7);
                    cmd7.Parameters.Add("FramesID", maxmeqsed1);
                    cmd7.Parameters.Add("FramesOther", txtmeqsedelave.Text);
                    cmd7.ExecuteNonQuery();
                    txtmeqsedelave.Text = "";

                    Response.Redirect("Diger.aspx");
                }
                else
                {
                    if (drrayon != null)
                    {
                        lblmeqsedelave.Text = "Elavə etmək istədiyiniz artıq bazada var";
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
                lblmeqsedelave.Text = "Digər boşluq ola bilməz";
                lblmeqsedelave.ForeColor = Color.Red;
            }
        }







        if (Tesnifat == "51")
        {
            DataRow classifid;
            string classifid1;
            if (txtmeqsedelave.Text != "")
            {
                DataRow drrayon = klas.GetDataRow("Select * from List_classifications Where ListID=17 and ClassifName='" + txtmeqsedelave.Text + "'");
                if (drrayon == null && ddlmeqsedsort.SelectedValue != "-1")
                {
                    if (ddlmeqsedsort.SelectedValue != "0")
                    {
                        classifid = klas.GetDataRow("Select * from List_classifications Where ListID=17 and ClassifID='" + ddlmeqsedsort.SelectedValue + "'");
                        classifid1 = classifid["sort"].ToString();
                    }
                    else
                    {
                        classifid = klas.GetDataRow("Select MIN(sort) as sort from List_classifications Where ListID=17");
                        classifid1 = (int.Parse(classifid["sort"].ToString()) - 1).ToString();
                    }
                    int secilmiwsortid = int.Parse(classifid1.ToString());
                    DataTable sorthamisi = klas.getdatatable("Select * from List_classifications Where ListID=17");
                    for (int i = 0; i < sorthamisi.Rows.Count; i++)
                    {
                        if (secilmiwsortid < int.Parse(sorthamisi.Rows[i]["sort"].ToString()))
                        {
                            int a1 = int.Parse(sorthamisi.Rows[i]["sort"].ToString()) + 1;
                            int a = int.Parse(sorthamisi.Rows[i]["sort"].ToString());
                            int classif = int.Parse(sorthamisi.Rows[i]["ClassifID"].ToString());
                            SqlConnection baglanti = klas.baglan();
                            SqlCommand cmd1 = new SqlCommand("Update List_classifications Set sort=@sort Where ListID=17 and sort='" + a.ToString() + "' and ClassifID='" + classif.ToString() + "'", baglanti);
                            cmd1.Parameters.Add("sort", a1);
                            cmd1.ExecuteNonQuery();
                        }
                    }
                    SqlConnection baglanti1 = klas.baglan();
                    SqlCommand cmd = new SqlCommand("Insert into List_classifications (ClassifName,ListID,sort) values(@ClassifName,@ListID,@sort)", baglanti1);
                    cmd.Parameters.Add("ClassifName", txtmeqsedelave.Text);
                    cmd.Parameters.Add("ListID", 17);
                    cmd.Parameters.Add("sort", int.Parse(classifid1.ToString()) + 1);
                    cmd.ExecuteNonQuery();
                    lblmeqsedelave.Text = "Məqsəd əlavə edildi";
                    lblmeqsedelave.ForeColor = Color.Green;

                    meqsedsort();
                    ddlmeqsedsort.Items.Insert(0, new ListItem("Seçin", "-1"));
                    ddlmeqsedsort.Items.Insert(1, new ListItem("Əvvələ", "0"));

                    DataRow maxmeqsed;
                    string maxmeqsed1;
                    maxmeqsed = klas.GetDataRow("Select MAX(ClassifID) as ClassifID from List_classifications Where ListID=17");
                    maxmeqsed1 = maxmeqsed["ClassifID"].ToString();
                    SqlConnection baglanti7 = klas.baglan();
                    SqlCommand cmd7 = new SqlCommand("Update FDesigned_staff Set Executive_bodyID=@Executive_bodyID,Executive_body=@Executive_body Where ConnID=" + OtherID, baglanti7);
                    cmd7.Parameters.Add("Executive_bodyID", maxmeqsed1);
                    cmd7.Parameters.Add("Executive_body", txtmeqsedelave.Text);
                    cmd7.ExecuteNonQuery();
                    txtmeqsedelave.Text = "";

                    Response.Redirect("Diger.aspx");
                }
                else
                {
                    if (drrayon != null)
                    {
                        lblmeqsedelave.Text = "Elavə etmək istədiyiniz artıq bazada var";
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
                lblmeqsedelave.Text = "Digər boşluq ola bilməz";
                lblmeqsedelave.ForeColor = Color.Red;
            }
        }






        if (Tesnifat == "31") {
            DataRow classifid;
            string classifid1;
            if (txtmeqsedelave.Text != "" && ddlihbrayonelave.SelectedValue != "0")
            {
                DataRow drrayon = klas.GetDataRow("Select * from List_classifications Where ListID='" + ddlihbrayonelave.SelectedValue + "' and  ClassifName='" + txtmeqsedelave.Text + "' order by [ClassifName]");
                if (drrayon == null && ddlmeqsedsort.SelectedValue != "-1")
                {
                    if (ddlmeqsedsort.SelectedValue != "0")
                    {
                        classifid = klas.GetDataRow("Select * from List_classifications Where ListID='" + ddlihbrayonelave.SelectedValue + "' and ClassifID='" + ddlmeqsedsort.SelectedValue + "'");
                        classifid1 = classifid["sort"].ToString();
                    }
                    else
                    {
                        classifid = klas.GetDataRow("Select MIN(sort) as sort from List_classifications Where ListID=" + ddlihbrayonelave.SelectedValue);
                        //int.Parse(classifid.ToString()) - 1;
                        classifid1 = (int.Parse(classifid["sort"].ToString()) - 1).ToString();
                    }
                    int secilmiwsortid = int.Parse(classifid1.ToString());
                    DataTable sorthamisi = klas.getdatatable("Select * from List_classifications Where ListID=" + ddlihbrayonelave.SelectedValue);
                    for (int i = 0; i < sorthamisi.Rows.Count; i++)
                    {
                        if (secilmiwsortid < int.Parse(sorthamisi.Rows[i]["sort"].ToString()))
                        {
                            int a1 = int.Parse(sorthamisi.Rows[i]["sort"].ToString()) + 1;
                            int a = int.Parse(sorthamisi.Rows[i]["sort"].ToString());
                            int classif = int.Parse(sorthamisi.Rows[i]["ClassifID"].ToString());
                            SqlConnection baglanti = klas.baglan();
                            SqlCommand cmd1 = new SqlCommand("Update List_classifications Set sort=@sort Where ListID='" + ddlihbrayonelave.SelectedValue + "' and sort='" + a.ToString() + "' and ClassifID='" + classif.ToString() + "'", baglanti);
                            cmd1.Parameters.Add("sort", a1);
                            cmd1.ExecuteNonQuery();
                        }
                    }
                    SqlConnection baglanti1 = klas.baglan();
                    SqlCommand cmd = new SqlCommand("Insert into List_classifications (ClassifName,ListID,sort) values(@ClassifName,@ListID,@sort)", baglanti1);
                    cmd.Parameters.Add("ClassifName", txtmeqsedelave.Text);
                    cmd.Parameters.Add("ListID", int.Parse(ddlihbrayonelave.SelectedValue));
                    cmd.Parameters.Add("sort", int.Parse(classifid1.ToString()) + 1);
                    cmd.ExecuteNonQuery();
                    lblmeqsedelave.Text = "Məqsəd əlavə edildi";
                    lblmeqsedelave.ForeColor = Color.Green;
                 
                    ihbsort();
                    ddlmeqsedsort.Items.Insert(0, new ListItem("Seçin", "-1"));
                    ddlmeqsedsort.Items.Insert(1, new ListItem("Əvvələ", "0"));

                    DataRow maxmeqsed;
                    string maxmeqsed1;
                    maxmeqsed = klas.GetDataRow("Select MAX(ClassifID) as ClassifID from List_classifications Where ListID=" + ddlihbrayonelave.SelectedValue);
                    maxmeqsed1 = maxmeqsed["ClassifID"].ToString();
                    SqlConnection baglanti7 = klas.baglan();
                    SqlCommand cmd7 = new SqlCommand("Update Conn_frames Set Sub_FramesID=@Sub_FramesID,Sub_FramesOther=@Sub_FramesOther Where ConnID=" + OtherID, baglanti7);
                    cmd7.Parameters.Add("Sub_FramesID", maxmeqsed1);
                    cmd7.Parameters.Add("Sub_FramesOther", txtmeqsedelave.Text);
                    cmd7.ExecuteNonQuery();
                    txtmeqsedelave.Text = "";

                    Response.Redirect("Diger.aspx");
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
                lblmeqsedelave.Text = "Tutduğu vəzifə boşluq ola bilməz";
                lblmeqsedelave.ForeColor = Color.Red;
            }
        }








        if (Tesnifat == "52")
        {
            DataRow classifid;
            string classifid1;
            if (txtmeqsedelave.Text != "" && ddlihbrayonelave.SelectedValue != "0")
            {
                DataRow drrayon = klas.GetDataRow("Select * from List_classifications Where ListID='" + ddlihbrayonelave.SelectedValue + "' and  ClassifName='" + txtmeqsedelave.Text + "' order by [ClassifName]");
                if (drrayon == null && ddlmeqsedsort.SelectedValue != "-1")
                {
                    if (ddlmeqsedsort.SelectedValue != "0")
                    {
                        classifid = klas.GetDataRow("Select * from List_classifications Where ListID='" + ddlihbrayonelave.SelectedValue + "' and ClassifID='" + ddlmeqsedsort.SelectedValue + "'");
                        classifid1 = classifid["sort"].ToString();
                    }
                    else
                    {
                        classifid = klas.GetDataRow("Select MIN(sort) as sort from List_classifications Where ListID=" + ddlihbrayonelave.SelectedValue);
                        //int.Parse(classifid.ToString()) - 1;
                        classifid1 = (int.Parse(classifid["sort"].ToString()) - 1).ToString();
                    }
                    int secilmiwsortid = int.Parse(classifid1.ToString());
                    DataTable sorthamisi = klas.getdatatable("Select * from List_classifications Where ListID=" + ddlihbrayonelave.SelectedValue);
                    for (int i = 0; i < sorthamisi.Rows.Count; i++)
                    {
                        if (secilmiwsortid < int.Parse(sorthamisi.Rows[i]["sort"].ToString()))
                        {
                            int a1 = int.Parse(sorthamisi.Rows[i]["sort"].ToString()) + 1;
                            int a = int.Parse(sorthamisi.Rows[i]["sort"].ToString());
                            int classif = int.Parse(sorthamisi.Rows[i]["ClassifID"].ToString());
                            SqlConnection baglanti = klas.baglan();
                            SqlCommand cmd1 = new SqlCommand("Update List_classifications Set sort=@sort Where ListID='" + ddlihbrayonelave.SelectedValue + "' and sort='" + a.ToString() + "' and ClassifID='" + classif.ToString() + "'", baglanti);
                            cmd1.Parameters.Add("sort", a1);
                            cmd1.ExecuteNonQuery();
                        }
                    }
                    SqlConnection baglanti1 = klas.baglan();
                    SqlCommand cmd = new SqlCommand("Insert into List_classifications (ClassifName,ListID,sort) values(@ClassifName,@ListID,@sort)", baglanti1);
                    cmd.Parameters.Add("ClassifName", txtmeqsedelave.Text);
                    cmd.Parameters.Add("ListID", int.Parse(ddlihbrayonelave.SelectedValue));
                    cmd.Parameters.Add("sort", int.Parse(classifid1.ToString()) + 1);
                    cmd.ExecuteNonQuery();
                    lblmeqsedelave.Text = "Məqsəd əlavə edildi";
                    lblmeqsedelave.ForeColor = Color.Green;

                    ihbsort();
                    ddlmeqsedsort.Items.Insert(0, new ListItem("Seçin", "-1"));
                    ddlmeqsedsort.Items.Insert(1, new ListItem("Əvvələ", "0"));

                    DataRow maxmeqsed;
                    string maxmeqsed1;
                    maxmeqsed = klas.GetDataRow("Select MAX(ClassifID) as ClassifID from List_classifications Where ListID=" + ddlihbrayonelave.SelectedValue);
                    maxmeqsed1 = maxmeqsed["ClassifID"].ToString();
                    SqlConnection baglanti7 = klas.baglan();
                    SqlCommand cmd7 = new SqlCommand("Update FDesigned_staff Set PositionsID=@PositionsID,Positions=@Positions Where ConnID=" + OtherID, baglanti7);
                    cmd7.Parameters.Add("PositionsID", maxmeqsed1);
                    cmd7.Parameters.Add("Positions", txtmeqsedelave.Text);
                    cmd7.ExecuteNonQuery();
                    txtmeqsedelave.Text = "";

                    Response.Redirect("Diger.aspx");
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
                lblmeqsedelave.Text = "Tutduğu vəzifə boşluq ola bilməz";
                lblmeqsedelave.ForeColor = Color.Red;
            }
        }
















        if (Tesnifat == "36") {

            DataRow classifid;
            string classifid1;
            if (txtmeqsedelave.Text != "" && ddlihbrayonelave.SelectedValue != "0")
            {
                DataRow drrayon = klas.GetDataRow("Select * from List_SubClassifictions Where ListID='" + ddlihbrayonelave.SelectedValue + "' and  ClassificationName='" + txtmeqsedelave.Text + "' order by [ClassificationName]");
                if (drrayon == null && ddlmeqsedsort.SelectedValue != "-1")
                {
                    if (ddlmeqsedsort.SelectedValue != "0")
                    {
                        classifid = klas.GetDataRow("Select * from List_SubClassifictions Where ListID='" + ddlihbrayonelave.SelectedValue + "' and ClassifID='" + ddlmeqsedsort.SelectedValue + "'");
                        classifid1 = classifid["sort"].ToString();
                    }
                    else
                    {
                        classifid = klas.GetDataRow("Select MIN(sort) as sort from List_SubClassifictions Where ListID=" + ddlihbrayonelave.SelectedValue);
                        //int.Parse(classifid.ToString()) - 1;
                        classifid1 = (int.Parse(classifid["sort"].ToString()) - 1).ToString();

                    }
                    int secilmiwsortid = int.Parse(classifid1.ToString());
                    DataTable sorthamisi = klas.getdatatable("Select * from List_SubClassifictions Where ListID=" + ddlihbrayonelave.SelectedValue);
                    for (int i = 0; i < sorthamisi.Rows.Count; i++)
                    {
                        if (secilmiwsortid < int.Parse(sorthamisi.Rows[i]["sort"].ToString()))
                        {
                            int a1 = int.Parse(sorthamisi.Rows[i]["sort"].ToString()) + 1;
                            int a = int.Parse(sorthamisi.Rows[i]["sort"].ToString());
                            int classif = int.Parse(sorthamisi.Rows[i]["ClassifID"].ToString());
                            SqlConnection baglanti = klas.baglan();
                            SqlCommand cmd1 = new SqlCommand("Update List_SubClassifictions Set sort=@sort Where ListID='" + ddlihbrayonelave.SelectedValue + "' and sort='" + a.ToString() + "' and ClassifID='" + classif.ToString() + "'", baglanti);
                            cmd1.Parameters.Add("sort", a1);
                            cmd1.ExecuteNonQuery();
                        }
                    }

                    SqlConnection baglanti1 = klas.baglan();
                    SqlCommand cmd = new SqlCommand("Insert into List_SubClassifictions (ClassificationName,ListID,sort) values(@ClassificationName,@ListID,@sort)", baglanti1);
                    cmd.Parameters.Add("ClassificationName", txtmeqsedelave.Text);
                    cmd.Parameters.Add("ListID", int.Parse(ddlihbrayonelave.SelectedValue));
                    cmd.Parameters.Add("sort", int.Parse(classifid1.ToString()) + 1);
                    cmd.ExecuteNonQuery();
                    lblmeqsedelave.Text = "Obyekt əlavə edildi";
                    lblmeqsedelave.ForeColor = Color.Green;
                   
                    ihbsort();
                    ddlmeqsedsort.Items.Insert(0, new ListItem("Seçin", "-1"));
                    ddlmeqsedsort.Items.Insert(1, new ListItem("Əvvələ", "0"));



                    DataRow maxmeqsed;
                    string maxmeqsed1;
                    maxmeqsed = klas.GetDataRow("Select MAX(ClassifID) as ClassifID from List_SubClassifictions Where ListID=" + ddlihbrayonelave.SelectedValue);
                    maxmeqsed1 = maxmeqsed["ClassifID"].ToString();
                    SqlConnection baglanti7 = klas.baglan();
                    SqlCommand cmd7 = new SqlCommand("Update Conn_Object_operation Set SubObjectID=@SubObjectID,SubObjectOther=@SubObjectOther Where ConnID=" + OtherID, baglanti7);
                    cmd7.Parameters.Add("SubObjectID", maxmeqsed1);
                    cmd7.Parameters.Add("SubObjectOther", txtmeqsedelave.Text);
                    cmd7.ExecuteNonQuery();
                    txtmeqsedelave.Text = "";

                    Response.Redirect("Diger.aspx");
                }
                else
                {
                    if (drrayon != null)
                    {
                        lblmeqsedelave.Text = "Elavə etmək istədiyiniz obyekt artıq bazada var";
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
                lblmeqsedelave.Text = "Obyekt boşluq ola bilməz";
                lblmeqsedelave.ForeColor = Color.Red;
            }
        }









        if (Tesnifat == "39")
        {

            DataRow classifid;
            string classifid1;
            if (txtmeqsedelave.Text != "" && ddlihbrayonelave.SelectedValue != "0")
            {
                DataRow drrayon = klas.GetDataRow("Select * from List_SubClassifictions Where ListID='" + ddlihbrayonelave.SelectedValue + "' and  ClassificationName='" + txtmeqsedelave.Text + "' order by [ClassificationName]");
                if (drrayon == null && ddlmeqsedsort.SelectedValue != "-1")
                {
                    if (ddlmeqsedsort.SelectedValue != "0")
                    {
                        classifid = klas.GetDataRow("Select * from List_SubClassifictions Where ListID='" + ddlihbrayonelave.SelectedValue + "' and ClassifID='" + ddlmeqsedsort.SelectedValue + "'");
                        classifid1 = classifid["sort"].ToString();
                    }
                    else
                    {
                        classifid = klas.GetDataRow("Select MIN(sort) as sort from List_SubClassifictions Where ListID=" + ddlihbrayonelave.SelectedValue);
                        //int.Parse(classifid.ToString()) - 1;
                        classifid1 = (int.Parse(classifid["sort"].ToString()) - 1).ToString();

                    }
                    int secilmiwsortid = int.Parse(classifid1.ToString());
                    DataTable sorthamisi = klas.getdatatable("Select * from List_SubClassifictions Where ListID=" + ddlihbrayonelave.SelectedValue);
                    for (int i = 0; i < sorthamisi.Rows.Count; i++)
                    {
                        if (secilmiwsortid < int.Parse(sorthamisi.Rows[i]["sort"].ToString()))
                        {
                            int a1 = int.Parse(sorthamisi.Rows[i]["sort"].ToString()) + 1;
                            int a = int.Parse(sorthamisi.Rows[i]["sort"].ToString());
                            int classif = int.Parse(sorthamisi.Rows[i]["ClassifID"].ToString());
                            SqlConnection baglanti = klas.baglan();
                            SqlCommand cmd1 = new SqlCommand("Update List_SubClassifictions Set sort=@sort Where ListID='" + ddlihbrayonelave.SelectedValue + "' and sort='" + a.ToString() + "' and ClassifID='" + classif.ToString() + "'", baglanti);
                            cmd1.Parameters.Add("sort", a1);
                            cmd1.ExecuteNonQuery();
                        }
                    }

                    SqlConnection baglanti1 = klas.baglan();
                    SqlCommand cmd = new SqlCommand("Insert into List_SubClassifictions (ClassificationName,ListID,sort) values(@ClassificationName,@ListID,@sort)", baglanti1);
                    cmd.Parameters.Add("ClassificationName", txtmeqsedelave.Text);
                    cmd.Parameters.Add("ListID", int.Parse(ddlihbrayonelave.SelectedValue));
                    cmd.Parameters.Add("sort", int.Parse(classifid1.ToString()) + 1);
                    cmd.ExecuteNonQuery();
                    lblmeqsedelave.Text = "Obyekt əlavə edildi";
                    lblmeqsedelave.ForeColor = Color.Green;

                    ihbsort();
                    ddlmeqsedsort.Items.Insert(0, new ListItem("Seçin", "-1"));
                    ddlmeqsedsort.Items.Insert(1, new ListItem("Əvvələ", "0"));



                    DataRow maxmeqsed;
                    string maxmeqsed1;
                    maxmeqsed = klas.GetDataRow("Select MAX(ClassifID) as ClassifID from List_SubClassifictions Where ListID=" + ddlihbrayonelave.SelectedValue);
                    maxmeqsed1 = maxmeqsed["ClassifID"].ToString();
                    SqlConnection baglanti7 = klas.baglan();
                    SqlCommand cmd7 = new SqlCommand("Update Conn_facilities Set SubObjectID=@SubObjectID,SubObjectOther=@SubObjectOther Where ConnID=" + OtherID, baglanti7);
                    cmd7.Parameters.Add("SubObjectID", maxmeqsed1);
                    cmd7.Parameters.Add("SubObjectOther", txtmeqsedelave.Text);
                    cmd7.ExecuteNonQuery();
                    txtmeqsedelave.Text = "";

                    Response.Redirect("Diger.aspx");
                }
                else
                {
                    if (drrayon != null)
                    {
                        lblmeqsedelave.Text = "Elavə etmək istədiyiniz obyekt artıq bazada var";
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
                lblmeqsedelave.Text = "Obyekt boşluq ola bilməz";
                lblmeqsedelave.ForeColor = Color.Red;
            }
        }









        if (Tesnifat == "5") {
            if (txtmeqsedelave.Text != "" && ddlmeqsedsort.SelectedValue != "0")
            {
                DataRow drrayon1 = klas.GetDataRow("Select * from Administrative_Department Where DepartmentName=N'" + txtmeqsedelave.Text + "' and RegionID='" + ddlmeqsedsort.SelectedValue+ "' and ForDelete=1 ");
                if (drrayon1 == null)
                {
                    SqlConnection baglanti = klas.baglan();
                    SqlCommand cmd = new SqlCommand("Insert into Administrative_Department (DepartmentName,RegionID) values(@DepartmentName,@RegionID)", baglanti);
                    cmd.Parameters.Add("DepartmentName", txtmeqsedelave.Text);
                    cmd.Parameters.Add("RegionID", ddlmeqsedsort.SelectedValue);
                    cmd.ExecuteNonQuery();
                    lblmeqsedelave.Text = "İƏD əlavə edildi";
                    lblmeqsedelave.ForeColor = Color.Green;

                    DataRow maxmeqsed;
                    string maxmeqsed1;
                    maxmeqsed = klas.GetDataRow("Select MAX(DepartmentID) as DepartmentID from Administrative_Department Where RegionID=" + ddlmeqsedsort.SelectedValue);
                    maxmeqsed1 = maxmeqsed["DepartmentID"].ToString();
                    SqlConnection baglanti7 = klas.baglan();
                    SqlCommand cmd7 = new SqlCommand("Update Conn_delegate_IHB Set DelegateID=@DelegateID,DelegateOther=@DelegateOther Where ConnID=" + OtherID, baglanti7);
                    cmd7.Parameters.Add("DelegateID", maxmeqsed1);
                    cmd7.Parameters.Add("DelegateOther", txtmeqsedelave.Text);
                    cmd7.ExecuteNonQuery();
                    txtmeqsedelave.Text = "";

                    Response.Redirect("Diger.aspx");
                }
                else
                {
                    lblmeqsedelave.Text = "Elavə etmək istədiyiniz İƏD artıq bazada var";
                    lblmeqsedelave.ForeColor = Color.Red;
                }
            }
            else
            {
                lblmeqsedelave.Text = "İƏD adı boşluq ola bilməz";
                lblmeqsedelave.ForeColor = Color.Red;
                if (ddlmeqsedsort.SelectedValue == "0")
                {
                    lblmeqsedelave.Text = "Rayonu seçin";
                    lblmeqsedelave.ForeColor = Color.Red;
                }
            }
        }










        if (Tesnifat == "54")
        {
            if (txtmeqsedelave.Text != "" && ddlmeqsedsort.SelectedValue != "0")
            {
                DataRow drrayon1 = klas.GetDataRow("Select * from Administrative_Department Where DepartmentName=N'" + txtmeqsedelave.Text + "' and RegionID='" + ddlmeqsedsort.SelectedValue + "' and ForDelete=1 ");
                if (drrayon1 == null)
                {
                    SqlConnection baglanti = klas.baglan();
                    SqlCommand cmd = new SqlCommand("Insert into Administrative_Department (DepartmentName,RegionID) values(@DepartmentName,@RegionID)", baglanti);
                    cmd.Parameters.Add("DepartmentName", txtmeqsedelave.Text);
                    cmd.Parameters.Add("RegionID", ddlmeqsedsort.SelectedValue);
                    cmd.ExecuteNonQuery();
                    lblmeqsedelave.Text = "İƏD əlavə edildi";
                    lblmeqsedelave.ForeColor = Color.Green;

                    DataRow maxmeqsed;
                    string maxmeqsed1;
                    maxmeqsed = klas.GetDataRow("Select MAX(DepartmentID) as DepartmentID from Administrative_Department Where RegionID=" + ddlmeqsedsort.SelectedValue);
                    maxmeqsed1 = maxmeqsed["DepartmentID"].ToString();
                    SqlConnection baglanti7 = klas.baglan();
                    SqlCommand cmd7 = new SqlCommand("Update FDelegate_IHB Set DelegateID=@DelegateID,Delegate=@Delegate Where ConnID=" + OtherID, baglanti7);
                    cmd7.Parameters.Add("DelegateID", maxmeqsed1);
                    cmd7.Parameters.Add("Delegate", txtmeqsedelave.Text);
                    cmd7.ExecuteNonQuery();
                    txtmeqsedelave.Text = "";

                    Response.Redirect("Diger.aspx");
                }
                else
                {
                    lblmeqsedelave.Text = "Elavə etmək istədiyiniz İƏD artıq bazada var";
                    lblmeqsedelave.ForeColor = Color.Red;
                }
            }
            else
            {
                lblmeqsedelave.Text = "İƏD adı boşluq ola bilməz";
                lblmeqsedelave.ForeColor = Color.Red;
                if (ddlmeqsedsort.SelectedValue == "0")
                {
                    lblmeqsedelave.Text = "Rayonu seçin";
                    lblmeqsedelave.ForeColor = Color.Red;
                }
            }
        }












        if (Tesnifat == "37")
        {
            if (txtmeqsedelave.Text != "" && ddlihbrayonelave.SelectedValue != "0" && ddlmeqsedsort.SelectedValue != "0" && ddliedyawayiwelave.SelectedValue !="0")
            {
                DataRow drrayon1 = klas.GetDataRow("Select * from List_SubRegions Where Name=N'" + txtmeqsedelave.Text + "' and RegionID='" + ddlmeqsedsort.SelectedValue + "' and ForDelete=1 ");
                if (drrayon1 == null)
                {
                    SqlConnection baglanti = klas.baglan();
                    SqlCommand cmd = new SqlCommand("Insert into List_SubRegions (Name,TypeID,RegionID,ADminsDepartID) values(@Name,@TypeID,@RegionID,@ADminsDepartID)", baglanti);
                    cmd.Parameters.Add("Name", txtmeqsedelave.Text);
                    cmd.Parameters.Add("TypeID", ddlihbrayonelave.SelectedValue);
                    cmd.Parameters.Add("RegionID", ddlmeqsedsort.SelectedValue);
                    cmd.Parameters.Add("ADminsDepartID", ddliedyawayiwelave.SelectedValue);
                    cmd.ExecuteNonQuery();
                    lblmeqsedelave.Text = "Yaşayış məntəqəsi əlavə edildi";
                    lblmeqsedelave.ForeColor = Color.Green;

                    DataRow maxmeqsed;
                    string maxmeqsed1;
                    maxmeqsed = klas.GetDataRow("Select MAX(CityID) as CityID from List_SubRegions Where RegionID=" + ddlmeqsedsort.SelectedValue);
                    maxmeqsed1 = maxmeqsed["CityID"].ToString();
                    SqlConnection baglanti7 = klas.baglan();
                    SqlCommand cmd7 = new SqlCommand("Update Conn_Object_operation Set Living_PointID=@Living_PointID,Living_Point=@Living_Point Where ConnID=" + OtherID, baglanti7);
                    cmd7.Parameters.Add("Living_PointID", maxmeqsed1);
                    cmd7.Parameters.Add("Living_Point", txtmeqsedelave.Text);
                    cmd7.ExecuteNonQuery();
                    txtmeqsedelave.Text = "";

                    Response.Redirect("Diger.aspx");
                }
                else
                {
                    lblmeqsedelave.Text = "Elavə etmək istədiyiniz İƏD artıq bazada var";
                    lblmeqsedelave.ForeColor = Color.Red;
                }
            }
            else
            {
                if (txtmeqsedelave.Text == "")
                {
                    lblmeqsedelave.Text = "İƏD adı boşluq ola bilməz";
                }
              
                if (ddlmeqsedsort.SelectedValue == "0")
                {
                    lblmeqsedelave.Text = "Rayonu seçin";
                }
                if (ddlihbrayonelave.SelectedValue == "0") {
                    lblmeqsedelave.Text = "Status seçin";
                }
                if (ddliedyawayiwelave.SelectedValue == "0") {
                    lblmeqsedelave.Text = "İƏD seçin";
                }
                lblmeqsedelave.ForeColor = Color.Red;
            }
        }











        if (Tesnifat == "56")
        {
            if (txtmeqsedelave.Text != "" && ddlihbrayonelave.SelectedValue != "0" && ddlmeqsedsort.SelectedValue != "0" && ddliedyawayiwelave.SelectedValue != "0")
            {
                DataRow drrayon1 = klas.GetDataRow("Select * from List_SubRegions Where Name=N'" + txtmeqsedelave.Text + "' and RegionID='" + ddlmeqsedsort.SelectedValue + "' and ForDelete=1 ");
                if (drrayon1 == null)
                {
                    SqlConnection baglanti = klas.baglan();
                    SqlCommand cmd = new SqlCommand("Insert into List_SubRegions (Name,TypeID,RegionID,ADminsDepartID) values(@Name,@TypeID,@RegionID,@ADminsDepartID)", baglanti);
                    cmd.Parameters.Add("Name", txtmeqsedelave.Text);
                    cmd.Parameters.Add("TypeID", ddlihbrayonelave.SelectedValue);
                    cmd.Parameters.Add("RegionID", ddlmeqsedsort.SelectedValue);
                    cmd.Parameters.Add("ADminsDepartID", ddliedyawayiwelave.SelectedValue);
                    cmd.ExecuteNonQuery();
                    lblmeqsedelave.Text = "Yaşayış məntəqəsi əlavə edildi";
                    lblmeqsedelave.ForeColor = Color.Aquamarine;

                    DataRow maxmeqsed;
                    string maxmeqsed1;
                    maxmeqsed = klas.GetDataRow("Select MAX(CityID) as CityID from List_SubRegions Where RegionID=" + ddlmeqsedsort.SelectedValue);
                    maxmeqsed1 = maxmeqsed["CityID"].ToString();
                    SqlConnection baglanti7 = klas.baglan();
                    SqlCommand cmd7 = new SqlCommand("Update FLiving_point Set LivingID=@LivingID,Living=@Living Where ConnID=" + OtherID, baglanti7);
                    cmd7.Parameters.Add("LivingID", maxmeqsed1);
                    cmd7.Parameters.Add("Living", txtmeqsedelave.Text);
                    cmd7.ExecuteNonQuery();
                    txtmeqsedelave.Text = "";

                    Response.Redirect("Diger.aspx");
                }
                else
                {
                    lblmeqsedelave.Text = "Elavə etmək istədiyiniz İƏD artıq bazada var";
                    lblmeqsedelave.ForeColor = Color.GreenYellow;
                }
            }
            else
            {
                if (txtmeqsedelave.Text == "")
                {
                    lblmeqsedelave.Text = "İƏD adı boşluq ola bilməz";
                }

                if (ddlmeqsedsort.SelectedValue == "0")
                {
                    lblmeqsedelave.Text = "Rayonu seçin";
                }
                if (ddlihbrayonelave.SelectedValue == "0")
                {
                    lblmeqsedelave.Text = "Status seçin";
                }
                if (ddliedyawayiwelave.SelectedValue == "0")
                {
                    lblmeqsedelave.Text = "İƏD seçin";
                }
                lblmeqsedelave.ForeColor = Color.GreenYellow;
            }
        }










        if (Tesnifat == "49")
        {
            if (txtmeqsedelave.Text != "" && ddlihbrayonelave.SelectedValue != "0" && ddlmeqsedsort.SelectedValue != "0" && ddliedyawayiwelave.SelectedValue != "0")
            {
                DataRow drrayon1 = klas.GetDataRow("Select * from List_SubRegions Where Name=N'" + txtmeqsedelave.Text + "' and RegionID='" + ddlmeqsedsort.SelectedValue + "' and ForDelete=1 ");
                if (drrayon1 == null)
                {
                    SqlConnection baglanti = klas.baglan();
                    SqlCommand cmd = new SqlCommand("Insert into List_SubRegions (Name,TypeID,RegionID,ADminsDepartID) values(@Name,@TypeID,@RegionID,@ADminsDepartID)", baglanti);
                    cmd.Parameters.Add("Name", txtmeqsedelave.Text);
                    cmd.Parameters.Add("TypeID", ddlihbrayonelave.SelectedValue);
                    cmd.Parameters.Add("RegionID", ddlmeqsedsort.SelectedValue);
                    cmd.Parameters.Add("ADminsDepartID", ddliedyawayiwelave.SelectedValue);
                    cmd.ExecuteNonQuery();
                    lblmeqsedelave.Text = "Yaşayış məntəqəsi əlavə edildi";
                    lblmeqsedelave.ForeColor = Color.Aquamarine;

                    DataRow maxmeqsed;
                    string maxmeqsed1;
                    maxmeqsed = klas.GetDataRow("Select MAX(CityID) as CityID from List_SubRegions Where RegionID=" + ddlmeqsedsort.SelectedValue);
                    maxmeqsed1 = maxmeqsed["CityID"].ToString();
                    SqlConnection baglanti7 = klas.baglan();
                    SqlCommand cmd7 = new SqlCommand("Update FIndividual_meetings_citizens Set Living_pointId=@Living_PointID,Living_point=@Living_point Where ConnID=" + OtherID, baglanti7);
                    cmd7.Parameters.Add("Living_pointId", maxmeqsed1);
                    cmd7.Parameters.Add("Living_point", txtmeqsedelave.Text);
                    cmd7.ExecuteNonQuery();
                    txtmeqsedelave.Text = "";

                    Response.Redirect("Diger.aspx");
                }
                else
                {
                    lblmeqsedelave.Text = "Elavə etmək istədiyiniz İƏD artıq bazada var";
                    lblmeqsedelave.ForeColor = Color.GreenYellow;
                }
            }
            else
            {
                if (txtmeqsedelave.Text == "")
                {
                    lblmeqsedelave.Text = "İƏD adı boşluq ola bilməz";
                }

                if (ddlmeqsedsort.SelectedValue == "0")
                {
                    lblmeqsedelave.Text = "Rayonu seçin";
                }
                if (ddlihbrayonelave.SelectedValue == "0")
                {
                    lblmeqsedelave.Text = "Status seçin";
                }
                if (ddliedyawayiwelave.SelectedValue == "0")
                {
                    lblmeqsedelave.Text = "İƏD seçin";
                }
                lblmeqsedelave.ForeColor = Color.GreenYellow;
            }
        }









        if (Tesnifat == "40")
        {
            if (txtmeqsedelave.Text != "" && ddlihbrayonelave.SelectedValue != "0" && ddlmeqsedsort.SelectedValue != "0" && ddliedyawayiwelave.SelectedValue != "0")
            {
                DataRow drrayon1 = klas.GetDataRow("Select * from List_SubRegions Where Name=N'" + txtmeqsedelave.Text + "' and RegionID='" + ddlmeqsedsort.SelectedValue + "' and ForDelete=1 ");
                if (drrayon1 == null)
                {
                    SqlConnection baglanti = klas.baglan();
                    SqlCommand cmd = new SqlCommand("Insert into List_SubRegions (Name,TypeID,RegionID,ADminsDepartID) values(@Name,@TypeID,@RegionID,@ADminsDepartID)", baglanti);
                    cmd.Parameters.Add("Name", txtmeqsedelave.Text);
                    cmd.Parameters.Add("TypeID", ddlihbrayonelave.SelectedValue);
                    cmd.Parameters.Add("RegionID", ddlmeqsedsort.SelectedValue);
                    cmd.Parameters.Add("ADminsDepartID", ddliedyawayiwelave.SelectedValue);
                    cmd.ExecuteNonQuery();
                    lblmeqsedelave.Text = "Yaşayış məntəqəsi əlavə edildi";
                    lblmeqsedelave.ForeColor = Color.Aquamarine;

                    DataRow maxmeqsed;
                    string maxmeqsed1;
                    maxmeqsed = klas.GetDataRow("Select MAX(CityID) as CityID from List_SubRegions Where RegionID=" + ddlmeqsedsort.SelectedValue);
                    maxmeqsed1 = maxmeqsed["CityID"].ToString();
                    SqlConnection baglanti7 = klas.baglan();
                    SqlCommand cmd7 = new SqlCommand("Update Conn_facilities Set Living_PointID=@Living_PointID,Living_point=@Living_point Where ConnID=" + OtherID, baglanti7);
                    cmd7.Parameters.Add("Living_PointID", maxmeqsed1);
                    cmd7.Parameters.Add("Living_point", txtmeqsedelave.Text);
                    cmd7.ExecuteNonQuery();
                    txtmeqsedelave.Text = "";

                    Response.Redirect("Diger.aspx");
                }
                else
                {
                    lblmeqsedelave.Text = "Elavə etmək istədiyiniz İƏD artıq bazada var";
                    lblmeqsedelave.ForeColor = Color.GreenYellow;
                }
            }
            else
            {
                if (txtmeqsedelave.Text == "")
                {
                    lblmeqsedelave.Text = "İƏD adı boşluq ola bilməz";
                }

                if (ddlmeqsedsort.SelectedValue == "0")
                {
                    lblmeqsedelave.Text = "Rayonu seçin";
                }
                if (ddlihbrayonelave.SelectedValue == "0")
                {
                    lblmeqsedelave.Text = "Status seçin";
                }
                if (ddliedyawayiwelave.SelectedValue == "0")
                {
                    lblmeqsedelave.Text = "İƏD seçin";
                }
                lblmeqsedelave.ForeColor = Color.GreenYellow;
            }
        }





        if (Tesnifat == "7")
        {
            if (txtmeqsedelave.Text != "" && ddlihbrayonelave.SelectedValue != "0" && ddlmeqsedsort.SelectedValue != "0" && ddliedyawayiwelave.SelectedValue != "0")
            {
                DataRow drrayon1 = klas.GetDataRow("Select * from List_SubRegions Where Name=N'" + txtmeqsedelave.Text + "' and RegionID='" + ddlmeqsedsort.SelectedValue + "' and ForDelete=1 ");
                if (drrayon1 == null)
                {
                    SqlConnection baglanti = klas.baglan();
                    SqlCommand cmd = new SqlCommand("Insert into List_SubRegions (Name,TypeID,RegionID,ADminsDepartID) values(@Name,@TypeID,@RegionID,@ADminsDepartID)", baglanti);
                    cmd.Parameters.Add("Name", txtmeqsedelave.Text);
                    cmd.Parameters.Add("TypeID", ddlihbrayonelave.SelectedValue);
                    cmd.Parameters.Add("RegionID", ddlmeqsedsort.SelectedValue);
                    cmd.Parameters.Add("ADminsDepartID", ddliedyawayiwelave.SelectedValue);
                    cmd.ExecuteNonQuery();
                    lblmeqsedelave.Text = "Yaşayış məntəqəsi əlavə edildi";
                    lblmeqsedelave.ForeColor = Color.Aquamarine;

                    DataRow maxmeqsed;
                    string maxmeqsed1;
                    maxmeqsed = klas.GetDataRow("Select MAX(CityID) as CityID from List_SubRegions Where RegionID=" + ddlmeqsedsort.SelectedValue);
                    maxmeqsed1 = maxmeqsed["CityID"].ToString();
                    SqlConnection baglanti7 = klas.baglan();
                    SqlCommand cmd7 = new SqlCommand("Update Conn_living Set LivingID=@LivingID,LivingOther=@LivingOther Where ConnID=" + OtherID, baglanti7);
                    cmd7.Parameters.Add("LivingID", maxmeqsed1);
                    cmd7.Parameters.Add("LivingOther", txtmeqsedelave.Text);
                    cmd7.ExecuteNonQuery();
                    txtmeqsedelave.Text = "";

                    Response.Redirect("Diger.aspx");
                }
                else
                {
                    lblmeqsedelave.Text = "Elavə etmək istədiyiniz İƏD artıq bazada var";
                    lblmeqsedelave.ForeColor = Color.GreenYellow;
                }
            }
            else
            {
                if (txtmeqsedelave.Text == "")
                {
                    lblmeqsedelave.Text = "İƏD adı boşluq ola bilməz";
                }

                if (ddlmeqsedsort.SelectedValue == "0")
                {
                    lblmeqsedelave.Text = "Rayonu seçin";
                }
                if (ddlihbrayonelave.SelectedValue == "0")
                {
                    lblmeqsedelave.Text = "Status seçin";
                }
                if (ddliedyawayiwelave.SelectedValue == "0")
                {
                    lblmeqsedelave.Text = "İƏD seçin";
                }
                lblmeqsedelave.ForeColor = Color.GreenYellow;
            }
        }


        if (Tesnifat == "41")
        {
            if (txtmeqsedelave.Text != "" && ddlihbrayonelave.SelectedValue != "0" && ddlmeqsedsort.SelectedValue != "0" && ddliedyawayiwelave.SelectedValue != "0")
            {
                DataRow drrayon1 = klas.GetDataRow("Select * from List_SubRegions Where Name=N'" + txtmeqsedelave.Text + "' and RegionID='" + ddlmeqsedsort.SelectedValue + "' and ForDelete=1 ");
                if (drrayon1 == null)
                {
                    SqlConnection baglanti = klas.baglan();
                    SqlCommand cmd = new SqlCommand("Insert into List_SubRegions (Name,TypeID,RegionID,ADminsDepartID) values(@Name,@TypeID,@RegionID,@ADminsDepartID)", baglanti);
                    cmd.Parameters.Add("Name", txtmeqsedelave.Text);
                    cmd.Parameters.Add("TypeID", ddlihbrayonelave.SelectedValue);
                    cmd.Parameters.Add("RegionID", ddlmeqsedsort.SelectedValue);
                    cmd.Parameters.Add("ADminsDepartID", ddliedyawayiwelave.SelectedValue);
                    cmd.ExecuteNonQuery();
                    lblmeqsedelave.Text = "Yaşayış məntəqəsi əlavə edildi";
                    lblmeqsedelave.ForeColor = Color.Aquamarine;

                    DataRow maxmeqsed;
                    string maxmeqsed1;
                    maxmeqsed = klas.GetDataRow("Select MAX(CityID) as CityID from List_SubRegions Where RegionID=" + ddlmeqsedsort.SelectedValue);
                    maxmeqsed1 = maxmeqsed["CityID"].ToString();
                    SqlConnection baglanti7 = klas.baglan();
                    SqlCommand cmd7 = new SqlCommand("Update Conn_Meetings_with_citizens Set Living_adresID=@Living_adresID,Living_adres=@Living_adres Where ConnID=" + OtherID, baglanti7);
                    cmd7.Parameters.Add("Living_adresID", maxmeqsed1);
                    cmd7.Parameters.Add("Living_adres", txtmeqsedelave.Text);
                    cmd7.ExecuteNonQuery();
                    txtmeqsedelave.Text = "";

                    Response.Redirect("Diger.aspx");
                }
                else
                {
                    lblmeqsedelave.Text = "Elavə etmək istədiyiniz İƏD artıq bazada var";
                    lblmeqsedelave.ForeColor = Color.GreenYellow;
                }
            }
            else
            {
                if (txtmeqsedelave.Text == "")
                {
                    lblmeqsedelave.Text = "İƏD adı boşluq ola bilməz";
                }

                if (ddlmeqsedsort.SelectedValue == "0")
                {
                    lblmeqsedelave.Text = "Rayonu seçin";
                }
                if (ddlihbrayonelave.SelectedValue == "0")
                {
                    lblmeqsedelave.Text = "Status seçin";
                }
                if (ddliedyawayiwelave.SelectedValue == "0")
                {
                    lblmeqsedelave.Text = "İƏD seçin";
                }
                lblmeqsedelave.ForeColor = Color.GreenYellow;
            }
        }
    }
    protected void btngeri_Click(object sender, EventArgs e)
    {
        if (Panel1.Visible == false)
        {
            Response.Redirect("Tesnifatlar.aspx");
        }
        else {
            Panel1.Visible = false;
            Session[rownumber] = null;
            table();
        }
    }
    protected void ddlihbrayonelave_SelectedIndexChanged(object sender, EventArgs e)
    {
    
       
        if (Session["Tesnifat"].ToString() == "31") {
            if (ddlihbrayonelave.SelectedValue == "0")
                ddlmeqsedsort.Enabled = false;
            else
                ddlmeqsedsort.Enabled = true;
        ihbsort();
        ddlmeqsedsort.Items.Insert(0, new ListItem("Seçin", "-1"));
        ddlmeqsedsort.Items.Insert(1, new ListItem("Əvvələ", "0"));
        }
        else if (Session["Tesnifat"].ToString() == "36") {
            if (ddlihbrayonelave.SelectedValue == "0")
                ddlmeqsedsort.Enabled = false;
            else
                ddlmeqsedsort.Enabled = true;
            ihbsort1();
            ddlmeqsedsort.Items.Insert(0, new ListItem("Seçin", "-1"));
            ddlmeqsedsort.Items.Insert(1, new ListItem("Əvvələ", "0"));
        }
      
 

    }
    protected void ddlmeqsedsort_SelectedIndexChanged(object sender, EventArgs e)
    {

            
            yawayiwiedelave();
            ddliedyawayiwelave.Items.Insert(0, new ListItem("Seçin", "0"));
        
    }
    protected void DataList1_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {
            if (Session[rownumber] != null)
            {
                if (e.Item.ItemIndex == int.Parse(Session[rownumber].ToString()))
                {
                    e.Item.BackColor = System.Drawing.Color.Aqua;
                }
            }
        }
    }
}