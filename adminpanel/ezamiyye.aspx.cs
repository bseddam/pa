using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class adminpanel_ezamiyye : System.Web.UI.Page
{
    Class2 klas = new Class2();
    string userid = ""; int controlBusinesTrip; int BusinesTripId; string RayonID; string islem1; string RegionCode; 
    protected void Page_Load(object sender, EventArgs e)
    {

        Page.Response.Cache.SetCacheability(HttpCacheability.NoCache);
        try
        {
            controlBusinesTrip = int.Parse(Request.QueryString["controlBusinesTrip"].ToString());
            userid = Request.QueryString["UserID"];
            RayonID = Request.QueryString["RegionID"];
            islem1 = Request.QueryString["islem1"];
            RegionCode = Request.QueryString["RegionCode"];
            BusinesTripId = int.Parse(Request.QueryString["BusinessTripID"].ToString());
            Session["BusinessTripID"] = BusinesTripId;
            if (userid != null)
                Session["UserID"] = userid;
        }
        catch (Exception)
        { }
        Calendar1.SelectedDates.Clear();
        caldkur.SelectedDates.Clear();
        cald.SelectedDates.Clear();

        DataRow approval = klas.GetDataRow("select * from business_trip where BusinessTripID=" + BusinesTripId);
        if (approval["AssortinID"].ToString() == "2")
        {
            lbltesdiqra.Text = "Hesabatın təsdiq edilməsi təklif olunur";
        }
        if (approval["AssortinID"].ToString() == "3")
        {
            lbltesdiqra.Text = "Hesabatın yenidən işlənməsi təklif olunur";
        }

       if (Session["UserID1"] != null && Session["UserID2"] == null)
       {

                  lblgonderildi.Visible = true;
                  pnlzynltarix.Visible = true;
                  btnkurtarix.Visible = true;
                  lbltesdiqolundu.Visible = false;
                  btntesdiqkur.Visible = false;
                  //btnesassehife.Visible = false;
                  
       }
       else if (Session["UserID"] != null)
       {
               pnlzynltarix.Visible = false;
               btntesdiqkur.Visible = true;
               btnesassehife.Visible = true;
               pnlkuratortesdiq.Visible = true;
               if (approval["AssortinID"].ToString() != "0")
               {
                   btntesdiqkur.Enabled = false;

                   lbltesdiqolundu.Text = "Təsdiq üçün təqdim olunub";
                   lbltesdiqolundu.Visible = true;
                   lbltesdiqolundu.ForeColor = Color.Green;
                   if (approval["AssortinID"].ToString() == "3")
                   {
                       btntesdiqkur.Enabled = true;
                       lbltesdiqolundu.Visible = false;
                       pnlkuratortesdiq.Visible = true;
                   }
                   if (approval["AssortinID"].ToString() == "4")
                   {
                       lbltesdiqra.Text = "";
                       lbltarix2.Text = "";
                       lbltesdiqolundu.Text = "";
                       lbltesdiqolundu.Visible = true;
                       lbltesdiqolundu.ForeColor = Color.Green;
                   }
                 
               }
           }
       
        if (controlBusinesTrip == 1)
        {
            DataRow drtesdiqtarix = klas.GetDataRow("select * from business_trip where BusinessTripID=" + BusinesTripId);
            carivaxt.Text = Class2.sozukes(drtesdiqtarix["DateApproval_ze"].ToString());
            lbltarix2.Text = Class2.sozukes(drtesdiqtarix["DateApproval_ra"].ToString());
            lbltrx1.Text = Class2.sozukes(drtesdiqtarix["AssertionDate"].ToString());

            DataRow user = klas.GetDataRow("select Name +' '+ Sname as Name from Users where UserID=" + Session["UserID"].ToString());
            if (user != null)
            {
                lbluser.Text = user["Name"].ToString();
            }

            DataRow dr = klas.GetDataRow("select * from business_trip where BusinessTripID=" + BusinesTripId);
            
            DataTable dtmeqsed = klas.getdatatable(@"select *,case when sort Is null then 100000 else sort  end  as sort1
from Conn_PurposeOfTrip left join List_classifications on ClassifID=PurposeID  where 
BusinessTripID='" + BusinesTripId + "'  and plan1='true' order by sort1");

            dlmeqsed.DataSource = klas.tekrarlama("Other", "Sn", dtmeqsed);
            dlmeqsed.DataBind();


            DataTable dtmeqsed0 = klas.getdatatable(@"select *,case when sort Is null then 100000 else sort  end  as sort1
from Conn_PurposeOfTrip left join List_classifications on ClassifID=PurposeID  where 
BusinessTripID='" + BusinesTripId + "' and plan1='false' order by sort1");

            dlmeqsed0.DataSource = klas.tekrarlama("Other", "Sn", dtmeqsed0);
            dlmeqsed0.DataBind();
            if (dtmeqsed0.Rows.Count > 0)
            {
                Label60.Visible = true;
            }
            else
            {
                Label60.Visible = false;
            }
            if (dtmeqsed.Rows.Count > 0 || dtmeqsed0.Rows.Count > 0)
            {
                Label3.Visible = true;
            }
            else
            {
                Label3.Visible = false;
            }


            DataTable dtihb = klas.getdatatable("select * from Conn_delegate_IHB where BusinessTripID='"
            + BusinesTripId + "' and IshtirakYesNo='true' and plan1='true' order by  DelegateOther");
            dlihbnum.DataSource = klas.vergul("Delegate", "Sn", dtihb);
            dlihbnum.DataBind();


            DataTable dtihb0 = klas.getdatatable("select * from Conn_delegate_IHB where BusinessTripID='"
          + BusinesTripId + "' and IshtirakYesNo='true' and plan1='false' order by   DelegateOther");
            dlihbnum0.DataSource = klas.vergul("Delegate", "Sn", dtihb0);
            dlihbnum0.DataBind();
            if (dtihb0.Rows.Count > 0)
            {
                Label85.Visible = true;
            }
            else
            {
                Label85.Visible = false;
            }
            if (dtihb0.Rows.Count > 0 || dtihb.Rows.Count > 0)
            {
                Label1.Visible = true;
            }
            else
            {
                Label1.Visible = false;
            }





            DataTable dtolmadigiihb = klas.getdatatable("select * from Conn_delegate_IHB where BusinessTripID='" + BusinesTripId + "' and IshtirakYesNo='false' and plan1='true' order by   DelegateOther");
            dlolmadigiihb.DataSource = klas.tekrarlama("DelegateOther", "Sn", dtolmadigiihb);
            dlolmadigiihb.DataBind();
            if (dtolmadigiihb.Rows.Count > 0)
            {
                Label68.Visible = true;
            }
            else
            {
                Label68.Visible = false;
            }

            DataTable dtyawayiw = klas.getdatatable("select * from Conn_living where BusinessTripID='" 
                + BusinesTripId + "' and IshtirakYesNo='true' and plan1='true' order by LivingOther");
            dlyawayiw.DataSource = klas.vergul("LivingOther", "Sn", dtyawayiw);
            dlyawayiw.DataBind();

            DataTable dtyawayiw0 = klas.getdatatable("select * from Conn_living where BusinessTripID='"
               + BusinesTripId + "' and IshtirakYesNo='true' and plan1='false' order by LivingOther");
            dlyawayiw0.DataSource = klas.vergul("LivingOther", "Sn", dtyawayiw0);
            dlyawayiw0.DataBind();
            if (dtyawayiw0.Rows.Count > 0)
            {
                Label87.Visible = true;
            }
            else
            {
                Label87.Visible = false;
            }
            if (dtyawayiw0.Rows.Count > 0 || dtyawayiw.Rows.Count > 0)
            {
                Label2.Visible = true;
            }
            else
            {
                Label2.Visible = false;
            }


            DataTable dtolmadigiyawayiw = klas.getdatatable("select * from Conn_living where BusinessTripID='" + BusinesTripId + "' and IshtirakYesNo='false' and plan1='true' order by    LivingOther");
            dlolmadigiyawayiwmen.DataSource = klas.tekrarlama("LivingOther", "Sn", dtolmadigiyawayiw);
            dlolmadigiyawayiwmen.DataBind();
            if (dtolmadigiyawayiw.Rows.Count > 0)
            {
                Label69.Visible = true;
            }
            else
            {
                Label69.Visible = false;
            }



            DataTable dtiwttedbir = klas.getdatatable(@"select *,case when b.sort Is null then 100000 else b.sort  end  as sort1,
case when k.sort Is null then 100000 else k.sort  end  as sort2 
from Conn_participation_measure left join List_classifications as b on b.ClassifID=ParticipationID 
left join List_classifications as k on k.ClassifID=DiscussedID where BusinessTripID='" + BusinesTripId +
 "' and BaxilibYesNo='true' and plan1='true' order by  OlunubYesNo desc, sort1,sort2");
            dliwttedbir.DataSource = klas.tekrarlama("ParticipationOther", "Sn", dtiwttedbir);
            dliwttedbir.DataBind();

            DataTable dtiwttedbir0 = klas.getdatatable(@"select *,case when b.sort Is null then 100000 else b.sort  end  as sort1,
case when k.sort Is null then 100000 else k.sort  end  as sort2 
from Conn_participation_measure left join List_classifications as b on b.ClassifID=ParticipationID 
left join List_classifications as k on k.ClassifID=DiscussedID where BusinessTripID='" + BusinesTripId +
"' and BaxilibYesNo='true' and plan1='false' order by  OlunubYesNo desc, sort1,sort2");
            dliwttedbir0.DataSource = klas.tekrarlama("ParticipationOther", "Sn", dtiwttedbir0);
            dliwttedbir0.DataBind();
            if (dtiwttedbir0.Rows.Count > 0)
            {
                Label81.Visible = true;
            }
            else
            {
                Label81.Visible = false;
            }
            if (dtiwttedbir0.Rows.Count > 0 || dtiwttedbir.Rows.Count > 0)
            {
                Label5.Visible = true;
            }
            else
            {
                Label5.Visible = false;
            }



            DataTable dtiwtetmediyitedbir = klas.getdatatable(@"select *,case when sort Is null then 100000 else sort  end  as sort1
from Conn_participation_measure left join List_classifications as b on b.ClassifID=ParticipationID  where BusinessTripID='"
     + BusinesTripId + "' and BaxilibYesNo='false' and Plan1='true'  order by  sort1");
            dliiwetmediyitedbir.DataSource = klas.tekrarlama("ParticipationOther", "Sn", dtiwtetmediyitedbir);
            dliiwetmediyitedbir.DataBind();
            if (dtiwtetmediyitedbir.Rows.Count > 0)
            {
                Label70.Visible = true;
            }
            else
            {
                Label70.Visible = false;
            }








            DataTable dtbaxarawmes = klas.getdatatable(@"select *,case when sort Is null then 100000 else sort  end  as sort1
from Conn_Reviewed left join List_classifications as b on b.ClassifID=ReviewedID 
where BusinessTripID='" + BusinesTripId + "' and baxilib='true' and plan1='true' order by  sort1");
            dlbaxarawmes.DataSource = klas.tekrarlama("Other", "Sn", dtbaxarawmes);
            dlbaxarawmes.DataBind();


            DataTable dtbaxarawmes0 = klas.getdatatable(@"select *,case when sort Is null then 100000 else sort  end  as sort1
from Conn_Reviewed left join List_classifications as b on b.ClassifID=ReviewedID 
where BusinessTripID='" + BusinesTripId + "' and baxilib='true' and plan1='false' order by  sort1");
            dlbaxarawmes0.DataSource = klas.tekrarlama("Other", "Sn", dtbaxarawmes0);
            dlbaxarawmes0.DataBind();
            if (dtbaxarawmes0.Rows.Count > 0)
            {
                Label83.Visible = true;
            }
            else
            {
                Label83.Visible = false;
            }
            if (dtbaxarawmes0.Rows.Count > 0 || dtbaxarawmes.Rows.Count > 0)
            {
                Label11.Visible = true;
            }
            else
            {
                Label11.Visible = false;
            }







            DataTable dtbaxilmamiwmes = klas.getdatatable(@"select *,case when sort Is null then 100000 else sort  end  as sort1
from Conn_Reviewed  left join List_classifications as b on b.ClassifID=ReviewedID  where BusinessTripID='"
      + BusinesTripId + "' and baxilib='false' and plan1='true'  order by  sort1");
            dlbaxilmamiwmesele.DataSource = klas.tekrarlama("Other", "Sn", dtbaxilmamiwmes);
            dlbaxilmamiwmesele.DataBind();
            if (dtbaxilmamiwmes.Rows.Count > 0)
            {
                Label71.Visible = true;
            }
            else
            {
                Label71.Visible = false;
            }




            DataTable dtistismarda = klas.getdatatable(@"SELECT *,
 case when SubObjectOther = ''  or SubObjectOther is null then ObjectOther  else 
 ObjectOther + ', '+ lower(SubObjectOther) end  as SubObjectOther1,CommandPost,DatePost
,case when b.sort Is null then 100000 else b.sort  end  as sort1,
case when k.sort Is null then 100000 else k.sort  end  as sort2  
 from  Conn_Object_operation  left join List_classifications as b on b.ClassifID=ObjectID 
left join List_SubClassifictions as k on k.ClassifID=subObjectID 
where BusinessTripID=" + BusinesTripId + " and plan1='true'  order by sort1,sort2");
            dlistismarda.DataSource = dtistismarda;
            dlistismarda.DataBind();





            DataTable dtistismarda0 = klas.getdatatable(@"SELECT *,
 case when SubObjectOther = ''  or SubObjectOther is null then ObjectOther  else 
 ObjectOther + ', '+ lower(SubObjectOther) end  as SubObjectOther1,CommandPost,DatePost
,case when b.sort Is null then 100000 else b.sort  end  as sort1,
case when k.sort Is null then 100000 else k.sort  end  as sort2  
 from  Conn_Object_operation  left join List_classifications as b on b.ClassifID=ObjectID 
left join List_SubClassifictions as k on k.ClassifID=subObjectID 
where BusinessTripID=" + BusinesTripId + " and plan1='false'  order by sort1,sort2");
            dlistismarda0.DataSource = dtistismarda0;
            dlistismarda0.DataBind();
            if (dtistismarda0.Rows.Count > 0)
            {
                Label89.Visible = true;
            }
            else
            {
                Label89.Visible = false;
            }
            if (dtistismarda0.Rows.Count > 0 || dtistismarda.Rows.Count > 0)
            {
                Label51.Visible = true;
            }
            else
            {
                Label51.Visible = false;
            }




            DataTable dtesaslitemir = klas.getdatatable(@"SELECT *,
case when SubObjectOther = '' or SubObjectOther is null then ObjectOther  else 
ObjectOther + ', '+ lower(SubObjectOther) end  as SubObjectOther1 ,
case when CouseOther is null then CouseOther else N'Səbəbi: '+ CouseOther + '.' end as CouseOther1,
CommandPost,DatePost  ,case when b.sort Is null then 100000 else b.sort  end  as sort1,
case when k.sort Is null then 100000 else k.sort  end  as sort2  
 from Conn_facilities  left join List_classifications as b on b.ClassifID=ObjectID 
left join List_SubClassifictions as k on k.ClassifID=subObjectID 
where BusinessTripID=" + BusinesTripId + " and plan1='true'  order by  sort1,sort2");
            dlesaslitemir.DataSource = dtesaslitemir;
            dlesaslitemir.DataBind();





            DataTable dtesaslitemir0 = klas.getdatatable(@"SELECT *,
case when SubObjectOther = '' or SubObjectOther is null then ObjectOther  else 
ObjectOther + ', '+ lower(SubObjectOther) end  as SubObjectOther1 ,
case when CouseOther is null then CouseOther else N'Səbəbi: '+ CouseOther + '.' end as CouseOther1,
CommandPost,DatePost  ,case when b.sort Is null then 100000 else b.sort  end  as sort1,
case when k.sort Is null then 100000 else k.sort  end  as sort2  
 from Conn_facilities  left join List_classifications as b on b.ClassifID=ObjectID 
left join List_SubClassifictions as k on k.ClassifID=subObjectID 
where BusinessTripID=" + BusinesTripId + "  and plan1='false'  order by sort1,sort2");
            dlesaslitemir0.DataSource = dtesaslitemir0;
            dlesaslitemir0.DataBind();
            if (dtesaslitemir0.Rows.Count > 0)
            {
                Label91.Visible = true;
            }
            else
            {
                Label91.Visible = false;
            }
            if (dtesaslitemir0.Rows.Count > 0 || dtesaslitemir.Rows.Count > 0)
            {
                Label64.Visible = true;
            }
            else
            {
                Label64.Visible = false;
            }




            DataTable dtvetendaw = klas.getdatatable(@"SELECT *,
case when Adres = '' or  Adres is null then Living_adres  else 
Living_adres + ', '+ Adres end  as adress1,case when sort Is null then 100000 else sort  end  as sort1
from  Conn_Meetings_with_citizens left join List_classifications on ClassifID=PurposeID  where BusinessTripID="
                + BusinesTripId + " and plan1='true'  order by   sort1");

            dlvetendaw.DataSource = klas.tekrarlama("PurposeOther", "Sn", dtvetendaw);
            dlvetendaw.DataBind();



            DataTable dtvetendaw0 = klas.getdatatable(@"SELECT *,
case when Adres = '' or  Adres is null then Living_adres  else 
Living_adres + ', '+ Adres end  as adress1,case when sort Is null then 100000 else sort  end  as sort1
from  Conn_Meetings_with_citizens left join List_classifications on ClassifID=PurposeID  where BusinessTripID="
              + BusinesTripId + " and plan1='false'  order by   sort1");

            dlvetendaw0.DataSource = klas.tekrarlama("PurposeOther", "Sn", dtvetendaw0);
            dlvetendaw0.DataBind();
            if (dtvetendaw0.Rows.Count > 0)
            {
                Label80.Visible = true;
            }
            else
            {
                Label80.Visible = false;
            }
            if (dtvetendaw0.Rows.Count > 0 || dtvetendaw.Rows.Count > 0)
            {
                Label6.Visible = true;
            }
            else
            {
                Label6.Visible = false;
            }






 DataTable dtictimaisiyasi = klas.getdatatable(@"select *,case when b.sort Is null then 100000 else b.sort  end  as sort1,
case when k.sort Is null then 100000 else k.sort  end  as sort2   from Conn_religious_political
 left join List_classifications as b on b.ClassifID=religious_politicalID 
left join List_SubClassifictions as k on k.ClassifID=Sub_religious_politicalID 
where BusinessTripID="+ BusinesTripId + " and plan1='true'  order by  sort1,sort2");
            dlictimaisiyasi.DataSource = klas.tekrarlama("ReligiousOther", "Sn", dtictimaisiyasi);
            dlictimaisiyasi.DataBind();



DataTable dtictimaisiyasi0 = klas.getdatatable(@"select *,case when b.sort Is null then 100000 else b.sort  end  as sort1,
case when k.sort Is null then 100000 else k.sort  end  as sort2   from Conn_religious_political
 left join List_classifications as b on b.ClassifID=religious_politicalID 
left join List_SubClassifictions as k on k.ClassifID=Sub_religious_politicalID 
where BusinessTripID=" + BusinesTripId + " and plan1='false'  order by  sort1,sort2");
            dlictimaisiyasi0.DataSource = klas.tekrarlama("ReligiousOther", "Sn", dtictimaisiyasi0);
            dlictimaisiyasi0.DataBind();
            if (dtictimaisiyasi0.Rows.Count > 0)
            {
                Label78.Visible = true;
            }
            else
            {
                Label78.Visible = false;
            }
            if (dtictimaisiyasi0.Rows.Count > 0 || dtictimaisiyasi.Rows.Count > 0)
            {
                Label9.Visible = true;
            }
            else
            {
                Label9.Visible = false;
            }


            DataTable dtmovcudeyani = klas.getdatatable(@"select * from Conn_Existing_Campaign where BusinessTripID="
                + BusinesTripId + "  ");
            dlmovcudeyani.DataSource = dtmovcudeyani;
            dlmovcudeyani.DataBind();
            if (dtmovcudeyani.Rows.Count > 0)
            {
                Label7.Visible = true;
            }
            else
            {
                Label7.Visible = false;
            }


            DataTable dtferdisohbet = klas.getdatatable(@"select ConnID,FramesID,FramesOther,CASE  
WHEN FramesID=341 then IHB +N' üzrə '+Sub_FramesOther   
WHEN FramesID=339  then Sub_FramesOther 
WHEN FramesID=342 then Sub_FramesOther 
end as Sub_FramesOther,Yes_No,FullName +' '+ Sname  +
CASE  
WHEN Yes_No=N'Hə' then N' vəzifəsinə uyğundur'  
else N' vəzifəsinə uyğun deyil'
end as Name
,TextNote,BusinessTripID,ModifeidDate,Plan1,WorkView,ResultView 
,case when b.sort Is null then 100000 else b.sort  end  as sort1,
case when k.sort Is null then 100000 else k.sort  end  as sort2 
from Conn_frames  left join List_classifications as b on b.ClassifID=FramesID 
left join List_SubClassifictions as k on k.ClassifID=Sub_FramesID 
where BusinessTripID=" + BusinesTripId + "  order by  Plan1 desc,sort1,sort2");
            dlferdisohbet.DataSource = dtferdisohbet;
            dlferdisohbet.DataBind();
            if (dtferdisohbet.Rows.Count > 0)
            {
                Label8.Visible = true;
            }
            else
            {
                Label8.Visible = false;
            }

            DataTable dtsosialhuman = klas.getdatatable(@"select Sebeb,IcraBaredeMelumat,sh1,SerbestMetn1,SerbestMetn2,
Icra_tarix,IHBMektub,MektubNomre,MektubTarix,DPAdi,DPIL,IcrasiRazilashdirilib,Vezifesi,Adi,Soyadi,Telefonu,dp_diger from 
 TS10_2 where BusinessTripID='" + BusinesTripId + "' and statussablon=0  order by  Plan1 desc,sh1");
            dlsosialhuman.DataSource = dtsosialhuman;
            dlsosialhuman.DataBind();
            if (dtsosialhuman.Rows.Count > 0)
            {
                Label4.Visible = true;
            }
            else
            {
                Label4.Visible = false;
            }




            DataTable dtiqtisadisahib = klas.getdatatable(@"select Sebeb,IcraBaredeMelumat,sh1,SerbestMetn1,SerbestMetn2,
Icra_tarix,IHBMektub,MektubNomre,MektubTarix,DPAdi,DPIL,IcrasiRazilashdirilib,Vezifesi,Adi,Soyadi,Telefonu,dp_diger
from TS10_2 where BusinessTripID='" + BusinesTripId + "' and statussablon=1  order by  Plan1 desc,sh1");
            dliqtisadisahib.DataSource = dtiqtisadisahib;
            dliqtisadisahib.DataBind();
            if (dtiqtisadisahib.Rows.Count > 0)
            {
                Label12.Visible = true;
            }
            else
            {
                Label12.Visible = false;
            }





 DataTable dtumumigoruw = klas.getdatatable("select * from Conn_Genereal_meetings where BusinessTripID=" + BusinesTripId +
                " and plan1='true'");
            dlumumigoruw.DataSource = dtumumigoruw;
            dlumumigoruw.DataBind();


 DataTable dtumumigoruw0 = klas.getdatatable("select * from Conn_Genereal_meetings where BusinessTripID=" + BusinesTripId +
               " and plan1='false'");
            dlumumigoruw0.DataSource = dtumumigoruw0;
            dlumumigoruw0.DataBind();
            if (dtumumigoruw0.Rows.Count > 0)
            {
                Label76.Visible = true;
            }
            else
            {
                Label76.Visible = false;
            }
            if (dtumumigoruw.Rows.Count > 0 || dtumumigoruw0.Rows.Count > 0)
            {
                Label10.Visible = true;
            }
            else {
                Label10.Visible = false;
            }

            if (dr != null)
            {
                lblezambawlama.Text = Class2.sozukes1(dr["RegionCome"].ToString()) + " - ";
                lblbitme.Text = Class2.sozukes(dr["GoFromRegion"].ToString());
                lblcixma.Text = Class2.sozukes(dr["ComingToWork"].ToString());
                if (dr["RegionCome"].ToString() == dr["GoFromRegion"].ToString())
                {
                    lblezambawlama.Visible = false;
                }
            }
        }


        if (Session["UserID"] == null)
            {
                Response.Redirect("~/Default.aspx");
            }
            else
            {

                DataRow user = klas.GetDataRow("select UserID, CASE WHEN SUBSTRING(rtrim(Sname), len(rtrim(Sname)) - 2, 3) = 'yev' THEN Name + ' ' + Sname + 'in' WHEN SUBSTRING(rtrim(Sname), len(rtrim(Sname)) - 1, 3)  = 'ov' THEN Name + ' ' + Sname + 'un' WHEN SUBSTRING(rtrim(Sname), len(rtrim(Sname)) - 2, 3)  = 'ova' THEN Name + ' ' + Sname + N'nın' END as Name from Users where UserID=" + Session["UserID"].ToString());
                DataRow drrayon = klas.GetDataRow("select RegionsID,CASE WHEN CityID = 2 THEN Name + ' ' + 'rayonunda' WHEN CityID = 1 THEN Name + ' ' + N'şəhərində' END as Rayon from List_classification_Regions where ForDelete=1 and RegionsID=" + RayonID);

                if (user != null && drrayon != null)
                {
                    lbladsoyad.Text = user["Name"].ToString();
                    lblrayon.Text = drrayon["Rayon"].ToString();
                }
            }
        
        if (approval["AssortinID"].ToString() == "4")
        {
            lbltesdiqra.Text = "";
            lbltarix2.Text = "";
        }
    }
    public static string planauygunluq(Boolean plan)
    {
        string deger = "";
        if (plan != null)
        {
            if (plan == true)
            {
                deger = "Planda nəzərdə tutulmuş";
            }
            else
            {
                deger = "Plandan əlavə";
            }
        }
        
        return deger;
    }
    public static string planbaxarawmes(Boolean plan)
    {
        string deger = "";
        if (plan != null)
        {
            if (plan == false)
            {
                deger = "false";
            }
            else
            {
                deger = "true";
            }
        }

        return deger;
    }
    public static string tedbir(Boolean muzolun)
    {
        string deger = "";

        if (muzolun==true)
        {
            deger = "false";
        }
       
        else
        {
            deger = "true";
        }

        return deger;
    }
    public static string tedbir1( Boolean muzolun)
    {
        string deger = "";

        if (muzolun == true)
        {
            deger = "true";
        }
        else 
        {
            deger = "false";
        }
       

        return deger;
    }
    public static string tedbir2(Boolean iwtet, Boolean muzolun)
    {
        string deger = "";

        if (iwtet == true && muzolun == true)
        {
            
            deger = "true";
        }
       
        else
        {
            deger = "false";
        }

        return deger;
    }

   
  

    //public static string vezifesineuygunluq(string iwtet)
    //{
    //    string deger = "";

    //    if (iwtet == "Hə")
    //    {

    //        deger = "vəzifəsinə uyğundur";
    //    }

    //    else
    //    {
    //        deger = "vəzifəsinə uyğun deyil";
    //    }

    //    return deger;
    //}

  
    public static string rey(string iwtet)
    {
        string deger = "";

        if (iwtet == "Müsbətdir" || iwtet == "Təsir yoxdur" || iwtet == "Qeyri sabitdir")
        {

            deger = "false";
        }
        else
        {
            deger = "true";
        }

        return deger;
    }
   


    public static string bowdursacixma(string textler)
    {
        string deger = "";

        if (textler == "")
        {
            deger = "false";
        }
        else
        {
            deger = "true";
        }

        return deger;
    }
    public static string bowdursacixma1(string textler, string textler1)
    {
        string deger = "";

        if (textler == "" && textler1 == "")
        {
            deger = "false";
        }
        else
        {
            deger = "true";
        }

        return deger;
    }
    public static string bowdursacixma2(string textler, string textler1, string textler2)
    {
        string deger = "";

        if (textler == "" && textler1 == "" && textler2 == "")
        {
            deger = "false";
        }
        else
        {
            deger = "true";
        }

        return deger;
    }
    public static string icradadir(string textler)
    {
        string deger = "";
        if (textler == "")
        {
            deger = "İcradadır.";
        }
        else
        {
            deger = "";
        }
        return deger;
    }
    public static string icradadir1(bool textler)
    {
        string deger = "";
        if (textler == true)
        {
            deger = "İcra olunmuşdur.";
        }
        else
        {
            deger = "İcra olunur.";
        }
        return deger;
    }
    public static string dpda(string textler)
    {
        string deger = "";
        if (textler == "1")
        {
            deger = " Dövlət Proqramında ";
        }
        else
        {
            deger = " əsasında ";
        }
        return deger;
    }

  

    public static string inwaatiwvez(string aparilir,string dayandirilib,string hazirdir)
    {
        string deger = "";
        if (aparilir != "")
        {
            deger = "Aparılır.";
        }
        else if (dayandirilib != "") {
            deger = "Dayandırılıb.";
        }
        else if (hazirdir != "")
        {
            deger = "İstismara hazırdır.";
        }
        else 
        {
            deger = "";
        }
        return deger;
    }
    public static string inwaatiwveztarix(string aparilir, string dayandirilib, string hazirdir)
    {
        string deger = "";
        if (aparilir != "")
        {
            deger = aparilir;
        }
        else if (dayandirilib != "")
        {
            deger = dayandirilib;
        }
        else if (hazirdir != "")
        {
            deger = hazirdir;
        }
        else
        {
            deger = "";
        }
        return deger;
    }



    public static string icradadirferdi(string textler)
    {
        string deger = "";
        if (textler == "")
        {
            deger = "";
        }
        else
        {
            deger = "İcradadır.";
        }
        return deger;
    }
    public static string icradadirsosial(string textler)
    {
        string deger = "";
        if (textler == "2" || textler == "3")
        {
            deger = "";
        }
        else
        {
            deger = "İcrasına başlanmamışdır";
        }
        return deger;
    }

    public static string icrabaredemelumat(string textler)
    {
        string deger = "";

        if (textler == "1")
        {
            deger = "true";
        }
        else
        {
            deger = "false";
        }

        return deger;
    }
    public static string icrabaredemelumat1(string textler)
    {
        string deger = "";

        if (textler == "2" || textler == "3")
        {
            deger = "true";
        }
        else
        {
            deger = "false";
        }

        return deger;
    }
 
    protected void btnPrint_Click(object sender, EventArgs e)
    {
        lblgonderildi.Visible = false;
        btnPrint.Visible = false;
        btnesassehife.Visible = false;

        pnltsdq.Visible = false;
        pnlzynltarix.Visible = false;
        lbltesdiqolundu.Visible = false;

   




        Response.ClearContent();
        Response.AppendHeader("content-disposition", "attachment; filename=" + lbluser.Text + " " + lblrayon.Text + ".doc");
        Response.ContentType = "application/word";
        Response.ContentEncoding = System.Text.Encoding.UTF8;
        Response.BinaryWrite(System.Text.Encoding.UTF8.GetPreamble());
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        StringWriter stringWritter = new StringWriter();
        HtmlTextWriter htmlTextWritter = new HtmlTextWriter(stringWritter);
        pnlhtml.RenderControl(htmlTextWritter);
        Response.Write(stringWritter.ToString());
        Response.End();



        btnesassehife.Visible = true; ;
        btnPrint.Visible = true;

        lblgonderildi.Visible = true;
        pnltsdq.Visible = true;
        pnlzynltarix.Visible = true;
        lbltesdiqolundu.Visible = true;
    }

    protected void btnesassehife_Click(object sender, EventArgs e)
    {
        if (Session["UserID2"] != null)
        {
            if (islem1 == "adminislem1")
            {
                Response.Redirect("~/kurator/HesabatKurator.aspx?islem1=adminislem1");
            }
            else if (islem1 == "adminislem3")
            {
                Response.Redirect("~/kurator/HesabatKurator.aspx?islem1=adminislem3");
            }
            else if (islem1 == "adminislem4")
            {
                Response.Redirect("~/kurator/HesabatKurator.aspx?islem1=adminislem4");
            }
          
        }
        else if (Session["UserID1"] != null)
        {

            if (islem1 == "adminislem1")
            {
                Response.Redirect("~/adminpanel/Hesabatlar.aspx?islem1=adminislem1");
            }
            else if (islem1 == "adminislem3")
            {
                Response.Redirect("~/adminpanel/Hesabatlar.aspx?islem1=adminislem3");
            }
            else if (islem1 == "adminislem4")
            {
                Response.Redirect("~/adminpanel/Hesabatlar.aspx?islem1=adminislem4");
            }
            else if (islem1 == "ezmeqtehlil")
            {
                Response.Redirect("~/adminpanel/Ezmeqsedtehlil.aspx?islem=rayon0");
            }
            else if (islem1 == "baxkecistehlil")
            {
                Response.Redirect("~/adminpanel/Baxkecisttehlil.aspx?islem=rayon0");
            }
             else if (islem1 == "Baxkecesaslitobtehlil")
            {
                Response.Redirect("~/adminpanel/Baxkecesaslitobtehlil.aspx?islem=rayon0");
            }
            else if (islem1 == "Vetendawgoruwtehlil")
            {
                Response.Redirect("~/adminpanel/Vetendawgoruwtehlil.aspx?islem=rayon0");
            }
            else if (islem1 == "Ictimaisiyasiveztehlil")
            {
                Response.Redirect("~/adminpanel/Ictimaisiyasiveztehlil.aspx?islem=rayon0");
            }
            else if (islem1 == "Movcudeyanitehlil")
            {
                Response.Redirect("~/adminpanel/Movcudeyanitehlil.aspx?islem=rayon0");
            }
                 else if (islem1 == "Ihtovsiyetehlil")
            {
                Response.Redirect("~/adminpanel/Ihtovsiyetehlil.aspx?islem=rayon0");
            }
            else if (islem1 == "Yasmentehlil")
            {
                Response.Redirect("~/adminpanel/Yasmentehlil.aspx?islem=rayon0");
            }
            else if (islem1 == "IHBtehlil")
            {
                Response.Redirect("~/adminpanel/IHBtehlil.aspx?islem=rayon0");
            }
            else if (islem1 == "sosial")
            {
                Response.Redirect("~/adminpanel/Sosialhumtehlil.aspx?islem=rayon0");
            }
            else if (islem1 == "iqtisadi")
            {
                Response.Redirect("~/adminpanel/Iqtisadisahibktehlil.aspx?islem=rayon0");
            }
            else if (islem1 == "ferdisohbet")
            {
                Response.Redirect("~/adminpanel/Ferdisohbettehlil.aspx?islem=rayon0");
            }
            else if (islem1 == "muddettehlil")
            {
                Response.Redirect("~/adminpanel/Muddetlertehlil.aspx?islem=rayon0");
            }
            else if (islem1 == "gorulmuwiw")
            {
                Response.Redirect("~/adminpanel/Gorulmuwiwtehlil.aspx?islem=rayon0");
            }
            else if (islem1 == "goriwtehlil")
            {
                Response.Redirect("~/adminpanel/Gordukleriiwtehlil.aspx?islem=rayon0");
            }
            else if (islem1 == "Meqsedezamsay")
            {
                Response.Redirect("~/adminpanel/Meqsedezamsay.aspx?islem=rayon0");
            }
            
            
            
            
            
        }
        else if (Session["UserID"] != null)
        {
            if (islem1 == "adminislem1")
            {
                Response.Redirect("~/kurator/HesabatKurator.aspx?islem1=adminislem1");
            }
            else if (islem1 == "adminislem3")
            {
                Response.Redirect("~/kurator/HesabatKurator.aspx?islem1=adminislem3");
            }
            else if (islem1 == "adminislem4")
            {
                Response.Redirect("~/kurator/HesabatKurator.aspx?islem1=adminislem4");
            }

           
        }
    }

    protected void btnyeniden_Click(object sender, EventArgs e)
    {


        string fileadi = "";
        string user1 = "";
        DataRow user3 = klas.GetDataRow("select Name +' '+ Sname as Name from Users where UserID=" + userid);
        if (user3 != null)
        {
            user1 = user3["Name"].ToString();
        }
        string uzanti = Path.GetExtension(fugonder.PostedFile.FileName);
        if ((fugonder.HasFile && uzanti == ".doc") || (fugonder.HasFile && uzanti == ".docx"))
        {
            string folder = Server.MapPath("~/hesabatirad/" + user1 + "");
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
            string filename = Path.GetFileNameWithoutExtension(fugonder.FileName);
            // string filename = Path.GetFileName(fugonder.FileName); uzati ile birlikde
            fileadi = filename + RayonID + uzanti;
            fugonder.SaveAs(Server.MapPath("~/hesabatirad/" + user1 + "/") + fileadi);
        }
        string hecvaxti = klas.getdatacell("SELECT GETDATE() as indikivaxt");
        string hecvaxti1 = klas.tarixkesdatetime(hecvaxti);


        lbltarix2.Text = hecvaxti1;
        string tesdiqra = lbltarix2.Text + " " + "00:00:00.000";
        lbltesdiqra.Text = "Hesabatın yenidən işlənməsi təklif olunur";


        SqlConnection baglanti = klas.baglan();
        SqlCommand cmd = new SqlCommand("Update business_trip Set AssortinID=3,DateApproval_ra=@DateApproval_ra,FileName=@FileName,DateApproval_ze=null  Where BusinessTripID=" + BusinesTripId, baglanti);
        cmd.Parameters.Add("FileName", fileadi);
        cmd.Parameters.Add("DateApproval_ra", Convert.ToDateTime(tesdiqra));
        cmd.ExecuteNonQuery();
        lblgonderildi.Text = "Məlumat göndərildi";
        lblgonderildi.ForeColor = Color.Green;




        DataRow drtesdiqtarix = klas.GetDataRow("select * from business_trip where BusinessTripID=" + BusinesTripId);
        carivaxt.Text = Class2.sozukes(drtesdiqtarix["DateApproval_ze"].ToString());

 
    }
    protected void btnezamtesdiq_Click(object sender, EventArgs e)
    {
        string yoxlaa1 = ""; string hecvaxti; string hecvaxti1;

        if (txtra.Text == "")
        {
            // lbltrx1 <= hecvaxti

            hecvaxti = klas.getdatacell("SELECT GETDATE() as indikivaxt");
            hecvaxti1 = klas.tarixkesdatetime(hecvaxti);
            yoxlaa1 = "1";
            if (lbltrx1.Text != "")
            {
                string hv = Convert.ToDateTime(hecvaxti).ToString("yyyy-MM-dd");
                string vv = Convert.ToDateTime(lbltrx1.Text).ToString("yyyy-MM-dd");
                if (Convert.ToDateTime(hv) < Convert.ToDateTime(vv))
                {
                    yoxlaa1 = "0";
                }
            }
        }
        else
        {

            string tesdiqku = ""; string tesdiqra1 = "";

            if (lbltrx1.Text != "")
            {
                tesdiqku = Convert.ToDateTime(lbltrx1.Text).ToString("yyyy-MM-dd");
                tesdiqra1 = Convert.ToDateTime(txtra.Text).ToString("yyyy-MM-dd");


                if (tesdiqku != "" && tesdiqra1 != "")
                {
                    if (Convert.ToDateTime(tesdiqku) <= Convert.ToDateTime(tesdiqra1))
                    {
                        yoxlaa1 = "1";
                        hecvaxti1 = klas.tarixkesdatetime(txtra.Text);
                    }
                    else
                    {
                        yoxlaa1 = "0";
                        hecvaxti1 = "";
                    }
                }
                else
                {
                    yoxlaa1 = "0";
                    hecvaxti1 = "";
                }
            }
            else
            {

                yoxlaa1 = "0";
                hecvaxti1 = "";
            }
        }
        if (txtra.Text != "" && lbltrx1.Text == "")
        {
            yoxlaa1 = "1";
            hecvaxti1 = klas.tarixkesdatetime(txtra.Text);
        }
        


        string draproval = klas.getdatacell("select AssortinID from business_trip where BusinessTripID=" + BusinesTripId);
        if (draproval != "4" && yoxlaa1=="1")
        {

            lbltarix2.Text = hecvaxti1;
            string tesdiqra = lbltarix2.Text + " " + "00:00:00.000";
            lbltesdiqra.Text = "Hesabatın təsdiq edilməsi təklif olunur";
            SqlConnection baglanti = klas.baglan();
            SqlCommand cmd = new SqlCommand("Update business_trip Set AssortinID=@AssortinID,DateApproval_ra=@DateApproval_ra Where BusinessTripID=" + BusinesTripId, baglanti);
            cmd.Parameters.Add("DateApproval_ra", Convert.ToDateTime(tesdiqra));
            cmd.Parameters.Add("AssortinID", 2);
            cmd.ExecuteNonQuery();
            lblgonderildi.Text = "Təsdiq edilməsi təklif olunur";
            lblgonderildi.ForeColor = Color.Green;
        }
        else
        {
            lblgonderildi.Text = "Artıq təsdiq olunub";
            lblgonderildi.ForeColor = Color.Red;

            if (yoxlaa1 == "0")
            {
                lblgonderildi.Text = "Tarix düz deyil";
                lblgonderildi.ForeColor = Color.Red;
            }
        }
    }
    protected void btnzynltarix_Click(object sender, EventArgs e)
    {
        string tesdiqra = ""; string tesdiqze = "";string tesdiqrambaza = "";
        //tesdiqrambaza = klas.getdatacell(@"select DateApproval_ra from business_trip where BusinessTripID=" + BusinesTripId);
        tesdiqrambaza = klas.getdatacell(@"select AssertionDate from business_trip where BusinessTripID=" + BusinesTripId);

        if (tesdiqrambaza != "" && txtzynltarix.Text != "")
        {
            tesdiqra = Convert.ToDateTime(tesdiqrambaza).ToString("yyyy-MM-dd");
            tesdiqze = Convert.ToDateTime(txtzynltarix.Text).ToString("yyyy-MM-dd");

            string yoxlaa = "";
            if (tesdiqra != "" && tesdiqze != "")
            {
                if (Convert.ToDateTime(tesdiqra) <= Convert.ToDateTime(tesdiqze))
                {
                    yoxlaa = "1";
                }
            }

        string draproval = klas.getdatacell("select AssortinID from business_trip where BusinessTripID=" + BusinesTripId);
        if ((draproval == "2" || draproval == "4")&& (yoxlaa == "1"))
        {
            string replace = txtzynltarix.Text.Replace("/", ".");
            carivaxt.Text = replace;
            string mmm = carivaxt.Text + " " + "00:00:00.000";
            SqlConnection baglanti = klas.baglan();
            SqlCommand cmd = new SqlCommand("Update business_trip Set AssortinID=@AssortinID,DateApproval_ze=@DateApproval_ze Where BusinessTripID=" + BusinesTripId, baglanti);
            cmd.Parameters.Add("AssortinID", 4);
            cmd.Parameters.Add("DateApproval_ze", Convert.ToDateTime(mmm));
            cmd.ExecuteNonQuery();
            lblgonderildi.Text = "Hesabat təsdiq edildi";
            lblgonderildi.ForeColor = Color.Green;
            lbltesdiqra.Text = "";
            lbltarix2.Text = "";
        }
        else
        {
            lblgonderildi.Text = "Təsdiq edilməyib";
            lblgonderildi.ForeColor = Color.Red;
            if (yoxlaa != "1")
            {
                lblgonderildi.Text = "Tarix düz deyil";
                lblgonderildi.ForeColor = Color.Red;
            }
        }
        }

        else
        {
            lblgonderildi.Text = "Tarix qeyd edilməyib";
            lblgonderildi.ForeColor = Color.Red;
            if (tesdiqrambaza == "")
            {
                lblgonderildi.Text = "Hesabat təsdiq olunmayıb";
                lblgonderildi.ForeColor = Color.Red;
            }
        }
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        if (Calendar1.Visible)
        {
            Calendar1.Visible = false;
        }
        else
        {
            Calendar1.Visible = true;
        }
    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        txtzynltarix.Text = Calendar1.SelectedDate.ToString("d");
        Calendar1.Visible = false;
        txtzynltarix.Visible = true;
    }
    protected void imgcald_Click(object sender, ImageClickEventArgs e)
    {
        if (cald.Visible)
        {
            cald.Visible = false;
        }
        else
        {
            cald.Visible = true;
        }
    }
    protected void cald_SelectionChanged(object sender, EventArgs e)
    {
        txtra.Text = cald.SelectedDate.ToString("d");
        cald.Visible = false;
        txtra.Visible = true;
    }
    protected void btntesdiqkur_Click(object sender, EventArgs e)
    {
        string hecvaxti = klas.getdatacell("SELECT GETDATE() as indikivaxt");
        string hecvaxti1 = klas.tarixkesdatetime(hecvaxti);
        lbltrx1.Text = hecvaxti1;
        string tesdiqoz = lbltrx1.Text + " " + "00:00:00.000";
        SqlConnection baglanti = klas.baglan();
        SqlCommand cmd = new SqlCommand("Update business_trip Set AssortinID=@AssortinID,AssertionDate=@AssertionDate Where BusinessTripID=" + BusinesTripId, baglanti);
        cmd.Parameters.Add("AssortinID", 4);
        cmd.Parameters.Add("AssertionDate", Convert.ToDateTime(tesdiqoz));
        cmd.ExecuteNonQuery();
        btntesdiqkur.Enabled = false;
        lbltesdiqolundu.Visible = true;
        lbltesdiqolundu.Text = "Təsdiq üçün təqdim olundu";
        lbltesdiqolundu.ForeColor = Color.Green;
        lbltesdiqra.Text = "";
        lbltarix2.Text = "";
    }
    protected void ImageButton1_Click1(object sender, ImageClickEventArgs e)
    {
        if (caldkur.Visible)
        {
            caldkur.Visible = false;
        }
        else
        {
            caldkur.Visible = true;
        }
    }
    protected void caldkur_SelectionChanged(object sender, EventArgs e)
    {
        txtkur.Text = caldkur.SelectedDate.ToString("d");
        caldkur.Visible = false;
        txtkur.Visible = true;
    }
    protected void btnkurtarix_Click(object sender, EventArgs e)
    {
        string yoxlaa1 = ""; string hecvaxti1 = ""; string tesdiqrambaza="";
        tesdiqrambaza = klas.getdatacell(@"select DateApproval_ze from business_trip where BusinessTripID=" + BusinesTripId);
        if (txtkur.Text != "" && tesdiqrambaza == "")
        {
            yoxlaa1 = "1";
            hecvaxti1 = klas.tarixkesdatetime(txtkur.Text);
        }
        else if (txtkur.Text != "" && tesdiqrambaza != "")
        {
            string tesdiqkura = ""; string tesdiqram = "";
            tesdiqkura = Convert.ToDateTime(txtkur.Text).ToString("yyyy-MM-dd");
            tesdiqram = Convert.ToDateTime(tesdiqrambaza).ToString("yyyy-MM-dd");


            if (tesdiqkura != "" && tesdiqram != "")
            {
                if (Convert.ToDateTime(tesdiqkura) <= Convert.ToDateTime(tesdiqram))
                {
                    yoxlaa1 = "1";
                    hecvaxti1 = klas.tarixkesdatetime(txtkur.Text);
                }
                else
                {
                    yoxlaa1 = "0";
                    hecvaxti1 = "";
                }
            }
           
        }
        


      //  string draproval = klas.getdatacell("select AssortinID from business_trip where BusinessTripID=" + BusinesTripId);
        string draproval = klas.getdatacell("select AssortinID from business_trip where BusinessTripID=" + BusinesTripId);

        //  if (draproval != "4" && yoxlaa1 == "1")
        //{
        if (yoxlaa1 == "1")
        {

            lbltrx1.Text = hecvaxti1;
            string tesdiqra = lbltrx1.Text + " " + "00:00:00.000";
            SqlConnection baglanti = klas.baglan();
            SqlCommand cmd = new SqlCommand("Update business_trip Set AssertionDate=@AssertionDate Where BusinessTripID=" + BusinesTripId, baglanti);
            cmd.Parameters.Add("AssertionDate", Convert.ToDateTime(tesdiqra));
            cmd.ExecuteNonQuery();
            lblgonderildi.Text = "Təqdim olunma tarixi dəyişdirildi";
            lblgonderildi.ForeColor = Color.Green;
        }
        else
        {
            lblgonderildi.Text = "Tarix qeyd olunmayıb";
            lblgonderildi.ForeColor = Color.Red;
            if (draproval == "4")
            {
                lblgonderildi.Text = "Artıq təsdiq olunub";
                lblgonderildi.ForeColor = Color.Red;
            }
            if (yoxlaa1 == "0")
            {
                lblgonderildi.Text = "Tarix düz deyil";
                lblgonderildi.ForeColor = Color.Red;
            }
        }
    }
}