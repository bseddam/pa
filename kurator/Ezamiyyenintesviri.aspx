<%@ Page Title="" Language="C#" MasterPageFile="~/kurator/KuratorhisseMasterPage.master" AutoEventWireup="true" CodeFile="Ezamiyyenintesviri.aspx.cs" Inherits="adminpanel_Ezamiyyenintesviri" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
        <meta http-equiv="content-type" content="text/html;charset=UTF-8" />
   
    <meta http-equiv="content-type" content="application/xhtml+xml; charset=UTF-8" />
    <style type="text/css">
          @charset "utf-8";
        .aucun:hover {
            color: red;
        }

        .auto-style1 {
            width: 288px;
        }

        .auto-style12 {
            width: 93%;
        }

        .auto-style9 {
            height: 22px;
            width: 324px;
        }

        .auto-style10 {
            width: 324px;
        }

        .auto-style19 {
            height: 22px;
            width: 339px;
        }

        .auto-style20 {
            width: 339px;
        }

        .auto-style137 {
           
            width: 10px;
        }

        .auto-style140 {
            width: 305px;
        }

        .style1 {
            width: 100%;
        }

        .auto-style144 {
            width: 135px;
        }
    .auto-style145 {
        width: 220px;
    }
    .auto-style146 {
        width: 225px;
    }
        .auto-style147 {
            width: 362px;
        }
        .auto-style148 {
            width: 136px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <meta http-equiv="content-type" content="application/xhtml+xml; charset=UTF-8" />

     <div>    
                <table style="width: 1012px">
                    <tr>
                        <td class="auto-style137">&nbsp;</td>
                        <td class="auto-style144">
                             <asp:Button ID="btnteqvimelave" runat="server" OnClick="btnteqvimelave_Click" Text="Yeni ezamiyyə planı" Width="130px" />  
                             </td>
                        <td class="auto-style146">
                           <asp:Button ID="btnezamsiyahi" runat="server" OnClick="btnezamsiyahi_Click" Text="Təsdiq edilməmiş ezamiyyə planları" Width="227px" />
                           
                               
                        </td>
              <td class="auto-style145">
                        <asp:Button ID="btntesdiqolunmuw" runat="server" Text="Təsdiq edilmiş ezamiyyə planları" Width="215px" OnClick="btntesdiqolunmuw_Click" /> 
                        </td>
                        <td class="auto-style140">
                       
                           
        <asp:Button ID="btnyenideniwle" runat="server"  Width="304px" Text="Yenidən işlənməsi təklif olunan ezamiyyə planları" OnClick="btnyenideniwle_Click" />
                       
                           
                        </td>
            <td>     <asp:Button ID="btnumgeri" runat="server" OnClick="btnumgeri_Click" Text="Geri" Width="70px" />
                        </td>
                    </tr>
                </table>
 
                       </div>
     <div>&nbsp;
     </div>
         <asp:Panel ID="pnlsilolmaz" Visible="false" runat="server">
             <asp:Label ID="lblsilolmaz" runat="server" Font-Bold="True"></asp:Label>
</asp:Panel>
     
            <asp:Panel ID="pnlteqvimelave"  runat="server" >
    <div style="float:left;padding-top:5px;width:600px; height: auto;">
       <div style="float:left;width: 283px;">
          <table class="auto-style12">
             <tr>
                 <td class="auto-style19">
                     &nbsp;</td>
             </tr>
             <tr>
                 <td class="auto-style20">
                     <asp:CheckBoxList ID="chkregion" runat="server">
                     </asp:CheckBoxList>
                 </td>
                  
             </tr>
               <tr>
                 <td class="auto-style20">
&nbsp;
                 </td>
             </tr>

         </table>
           </div>
        <div style="float:left;width: 305px;">      
             <table class="auto-style12">
             <tr>
                 <td class="auto-style19">
                     Digər rayonlar:</td>
             </tr>
             <tr>
                 <td class="auto-style20">
                     <asp:CheckBoxList ID="chkdigerrayon" runat="server">
                     </asp:CheckBoxList>
                 </td>
                  
             </tr>
         </table>

        </div>
        
  </div>
            <div style="float:left;width:400px;">  
     
     <div style=" padding-top:20px; width: 300px;">
        
         <table class="auto-style1">
            <tr>
                <td><strong>Ezamiyyənin başlama tarixi:&nbsp; </strong><asp:ImageButton ID="ImageButton5" runat="server" Height="23px" ImageUrl="~/images/calendar-icon.png" OnClick="ImageButton1_Click" Width="23px" />
                </td>
                
            </tr>
               <tr>
                <td>
                    <asp:Label ID="lblgelme" runat="server" Text=""></asp:Label>
         


                    <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#999999"  Visible="false"
                                    CellSpacing="1" DayNameFormat="Shortest" Font-Names="Arial" Font-Size="9pt" ForeColor="Black"
                                    Height="180px" OnSelectionChanged="Calendar1_SelectionChanged" Width="213px">
                                    <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                                    <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                                    <SelectorStyle BackColor="#CCCCCC" />
                                    <WeekendDayStyle BackColor="#FFFFCC" />
                                    <OtherMonthDayStyle ForeColor="White" />
                                    <NextPrevStyle VerticalAlign="Bottom" />
                                    <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                                    <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                                </asp:Calendar>
                   </td>
                
            </tr>
               <tr>
                <td>&nbsp;</td>
                
            </tr>
              <tr>
                <td><strong>Ezamiyyənin bitmə tarixi:&nbsp; <asp:ImageButton ID="ImageButton3" runat="server" Height="23px" ImageUrl="~/images/calendar-icon.png" OnClick="ImageButton3_Click" Width="23px" />
                    </strong></td>
                
            </tr>
             
             
              <tr>
                 <td class="auto-style9">
                     <asp:Label ID="lblgetme" runat="server" Text=""></asp:Label>
                     <asp:Calendar ID="Calendar3" runat="server" BackColor="White" BorderColor="#999999"  Visible="false"
                                    CellSpacing="1" DayNameFormat="Shortest" Font-Names="Arial" Font-Size="9pt" ForeColor="Black"
                                    Height="180px" OnSelectionChanged="Calendar3_SelectionChanged" Width="213px">
                                    <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                                    <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                                    <SelectorStyle BackColor="#CCCCCC" />
                                    <WeekendDayStyle BackColor="#FFFFCC" />
                                    <OtherMonthDayStyle ForeColor="White" />
                                    <NextPrevStyle VerticalAlign="Bottom" />
                                    <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                                    <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                                </asp:Calendar>
                    
                  </td>
                 
                 
             </tr>


             <tr>
                 <td class="auto-style10">
                     &nbsp;</td>
                 
                 
             </tr>
                     <tr>
                <td><strong>İşə çıxma tarixi:&nbsp; <asp:ImageButton ID="ImageButton6" runat="server" Height="23px" ImageUrl="~/images/calendar-icon.png" OnClick="ImageButton2_Click" Width="23px" />
                    </strong></td>
                
            </tr>
                     <tr>
                <td>
                    <asp:Label ID="lblcixma" runat="server" Text=""></asp:Label>
                
                    <asp:Calendar ID="Calendar2" runat="server" BackColor="White" BorderColor="#999999"  Visible="false"
                                    CellSpacing="1" DayNameFormat="Shortest" Font-Names="Arial" Font-Size="9pt" ForeColor="Black"
                                    Height="180px" OnSelectionChanged="Calendar2_SelectionChanged" Width="213px">
                                    <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                                    <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                                    <SelectorStyle BackColor="#CCCCCC" />
                                    <WeekendDayStyle BackColor="#FFFFCC" />
                                    <OtherMonthDayStyle ForeColor="White" />
                                    <NextPrevStyle VerticalAlign="Bottom" />
                                    <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                                    <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                                </asp:Calendar>
                          </td>
                
            </tr>
            
         </table>
          <asp:Button ID="btnezamteqvim" style="margin-top:70px;" runat="server"  OnClick="btnezamteqvim_Click" Text="Yadda saxla" Width="130px" Height="36px" />
 
        
         <br />
         <br />
         <asp:Label ID="message" runat="server" Font-Bold="True"></asp:Label>
 
        
  </div>
       
                 </div>
                
    <div class="temizle"></div>

 
    
       
   </asp:Panel>







       <asp:Panel ID="pnlredakte" Visible="false" runat="server">
    <div style="float:left;padding-left:100px;padding-top:5px; width: 318px; height: 347px;">
       &nbsp; 
  </div>
            <div style="float:left;width:327px;">  
                <asp:Panel ID="Panel2" runat="server">
     <div style=" padding-top:20px; width: 300px;">
        
         <table class="auto-style1">
            <tr>
                <td><strong>Ezamiyyənin başlama tarixi:&nbsp; </strong><asp:ImageButton ID="imgcldbawla" runat="server" Height="23px" ImageUrl="~/images/calendar-icon.png" Width="23px" OnClick="imgcldbawla_Click" />
                </td>
                
            </tr>
               <tr>
                <td>
                    <asp:Label ID="lblgelmeredakte" runat="server"></asp:Label>
          
                    <asp:Calendar ID="cldgelme" runat="server" BackColor="White" BorderColor="#999999"  Visible="false"
                                    CellSpacing="1" DayNameFormat="Shortest" Font-Names="Arial" Font-Size="9pt" ForeColor="Black"
                                    Height="180px" OnSelectionChanged="cldgelme_SelectionChanged" Width="213px">
                                    <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                                    <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                                    <SelectorStyle BackColor="#CCCCCC" />
                                    <WeekendDayStyle BackColor="#FFFFCC" />
                                    <OtherMonthDayStyle ForeColor="White" />
                                    <NextPrevStyle VerticalAlign="Bottom" />
                                    <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                                    <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                                </asp:Calendar>
                   </td>
                
            </tr>
               <tr>
                <td>&nbsp;</td>
                
            </tr>
              <tr>
                <td><strong>Ezamiyyənin bitmə tarixi:&nbsp; <asp:ImageButton ID="imgbitme" runat="server" Height="23px" ImageUrl="~/images/calendar-icon.png" Width="23px" OnClick="imgbitme_Click" />
                    </strong></td>
                
            </tr>
             
             
              <tr>
                 <td class="auto-style9">
                     <asp:Label ID="lblbitmeredakte" runat="server"></asp:Label>
 


                        <asp:Calendar ID="cldbitme" runat="server" BackColor="White" BorderColor="#999999"  Visible="false"
                                    CellSpacing="1" DayNameFormat="Shortest" Font-Names="Arial" Font-Size="9pt" ForeColor="Black"
                                    Height="180px" OnSelectionChanged="cldbitme_SelectionChanged" Width="213px">
                                    <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                                    <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                                    <SelectorStyle BackColor="#CCCCCC" />
                                    <WeekendDayStyle BackColor="#FFFFCC" />
                                    <OtherMonthDayStyle ForeColor="White" />
                                    <NextPrevStyle VerticalAlign="Bottom" />
                                    <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                                    <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                                </asp:Calendar>
                  </td>
                 
                 
             </tr>


             <tr>
                 <td class="auto-style10">
                     &nbsp;</td>
                 
                 
             </tr>
                     <tr>
                <td><strong>İşə çıxma tarixi:&nbsp; <asp:ImageButton ID="imgiwecixma" runat="server" Height="23px" ImageUrl="~/images/calendar-icon.png" Width="23px" OnClick="imgiwecixma_Click" />
                    </strong></td>
                
            </tr>
                     <tr>
                <td>
                    <asp:Label ID="lblisecixma" runat="server"></asp:Label>
     


                    <asp:Calendar ID="cldisecixma" runat="server" BackColor="White" BorderColor="#999999"  Visible="false"
                                    CellSpacing="1" DayNameFormat="Shortest" Font-Names="Arial" Font-Size="9pt" ForeColor="Black"
                                    Height="180px" OnSelectionChanged="cldisecixma_SelectionChanged" Width="213px">
                                    <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                                    <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                                    <SelectorStyle BackColor="#CCCCCC" />
                                    <WeekendDayStyle BackColor="#FFFFCC" />
                                    <OtherMonthDayStyle ForeColor="White" />
                                    <NextPrevStyle VerticalAlign="Bottom" />
                                    <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                                    <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                                </asp:Calendar>
                          </td>
                
            </tr>
            
         </table>
          <asp:Button ID="btnredakte" style="margin-top:70px;" runat="server" Text="Yadda saxla" Width="130px" Height="36px" OnClick="btnredakte_Click" />

         <br />

         <asp:Label ID="lblrayona" runat="server" Visible="False"></asp:Label>
 
         <asp:Label ID="lblcix" runat="server" Visible="False"></asp:Label>
 
        
         <br />
         <asp:Label ID="lblredaktemsg" runat="server" Font-Bold="True"></asp:Label>
 
        
  </div>
        </asp:Panel>
                 </div>
                <div class="message">
           </div>
    <div class="temizle"></div>
       
   </asp:Panel>




    <asp:Panel ID="pnlrayontarix" Visible="false" runat="server">
        <asp:Panel ID="pnltarixinsert" Visible="false" runat="server">

      
             
     <div style="float:left;  width: 1000px;">
        

                   <div style="float:left;width:280px;">
&nbsp; <strong>Rayona gəlmə tarixi:&nbsp; </strong>
<asp:ImageButton ID="ImageButton1" runat="server" Height="23px" ImageUrl="~/images/calendar-icon.png" OnClick="ImageButton1_Click1" Width="23px" />

                   </div>    
           <div style="float:left;width:280px; height: 25px;">
          &nbsp; <strong>Rayondan getmə tarixi:&nbsp; <asp:ImageButton ID="ImageButton2" runat="server" Height="23px" ImageUrl="~/images/calendar-icon.png" OnClick="ImageButton2_Click1" Width="23px" />
                    </strong>

           </div>  
           <div style="width:324px; float:left;">
               &nbsp; <asp:Button ID="btnrayontrx" runat="server" OnClick="btnrayontrx_Click"  Text="Yadda saxla" Width="120px" />
               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
               <asp:Label ID="lbltrxmesage" runat="server"></asp:Label>
               </div>    
         <div class="temizle">
                   </div>
           <div style="float:left;width:280px;height:240px;">
               &nbsp; <asp:Label ID="lblraygetme" runat="server"></asp:Label>
           

                      <asp:Calendar ID="cldraygetmetrx" runat="server" BackColor="White" BorderColor="#999999"  Visible="false"
                                    CellSpacing="1" DayNameFormat="Shortest" Font-Names="Arial" Font-Size="9pt" ForeColor="Black"
                                    Height="180px" OnSelectionChanged="cldraygelmetrx_SelectionChanged" Width="213px">
                                    <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                                    <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                                    <SelectorStyle BackColor="#CCCCCC" />
                                    <WeekendDayStyle BackColor="#FFFFCC" />
                                    <OtherMonthDayStyle ForeColor="White" />
                                    <NextPrevStyle VerticalAlign="Bottom" />
                                    <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                                    <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                                </asp:Calendar>
               <asp:Label ID="lblraygetme0" runat="server" Visible="False"></asp:Label>
            </div>    
           <div style="float:left;width:280px;height:240px;">
               &nbsp;     
                 <asp:Label ID="lblraygelme" runat="server"></asp:Label>
                        <asp:Calendar ID="cldraygelmetrx" runat="server" BackColor="White" BorderColor="#999999"  Visible="false"
                                    CellSpacing="1" DayNameFormat="Shortest" Font-Names="Arial" Font-Size="9pt" ForeColor="Black"
                                    Height="180px" OnSelectionChanged="cldraygetmetrx_SelectionChanged" Width="213px">
                                    <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                                    <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                                    <SelectorStyle BackColor="#CCCCCC" />
                                    <WeekendDayStyle BackColor="#FFFFCC" />
                                    <OtherMonthDayStyle ForeColor="White" />
                                    <NextPrevStyle VerticalAlign="Bottom" />
                                    <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                                    <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                                </asp:Calendar>
               <asp:Label ID="lblraygelme0" runat="server" Visible="False"></asp:Label>
            </div>  
           <div style="width:280px;float:left;">
               &nbsp;
               </div>    
<div class="temizle"></div>
 
        

        
  </div>
       
               
        </asp:Panel>



        <asp:Panel ID="pnlradiobuttarixdeyiw" Visible="false" runat="server">
               <div style="float:left;width:auto;">
        <asp:RadioButtonList ID="rblredakte" runat="server" AutoPostBack="True" OnSelectedIndexChanged="rblredakte_SelectedIndexChanged" >
        </asp:RadioButtonList>
                   </div>
                  <div style="width:auto;">
         <asp:RadioButtonList ID="digerrblredakte" runat="server" AutoPostBack="True" OnSelectedIndexChanged="digerrblredakte_SelectedIndexChanged" RepeatColumns="3" >
        </asp:RadioButtonList>
      </div>
            <div class="temizle"></div>
        
        <asp:Button ID="btnrayondeyiw" runat="server" OnClick="btnrayondeyiw_Click" Text="Yadda saxla" Width="120px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;<asp:Label ID="lblerror" runat="server"></asp:Label>
&nbsp;
           <div>&nbsp;</div>
     </asp:Panel>
  <asp:Panel ID="pnlrayonelave" Visible="false" runat="server">
      <div style="float:left;width:auto;">
        <asp:CheckBoxList ID="rayonelave" runat="server"></asp:CheckBoxList>
           </div>
      <div style="width:auto;">
           <asp:CheckBoxList ID="digerrayonelave" runat="server" RepeatColumns="3"></asp:CheckBoxList>
      </div>
        <div class="temizle"></div>
      <asp:Button ID="btnregionelave" runat="server" Text="Yadda saxla" OnClick="btnregionelave_Click" Width="120px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblmessag" runat="server"></asp:Label>
        
<div>&nbsp;</div>
        
        </asp:Panel>
        <div class="temizle"></div>
        <asp:DataList ID="dlrayontarix" runat="server" ForeColor="#333333" OnItemDataBound="dlrayontarix_ItemDataBound" Width="1024px">
            <AlternatingItemStyle BackColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderTemplate>
                <table class="style1">
                    <tr>
 <td style="padding-left:2px;text-align:left;width:3%;word-break:break-all">№</td>                     
    <td style="padding-left:10px;text-align:left;width:20%;white-space: normal;">Ezamiyyə dövrü üçün müəyyən edilmiş şəhər və rayonlar</td>
     <td style="padding-left:10px;text-align:left;width:13%;white-space: normal;">Şəhərə və rayona gəlmə tarixi</td>
    <td style="padding-left:10px;text-align:left;width:13%;white-space: normal;">Şəhərdən və rayondan getmə tarixi</td>
    <td style="padding-left:10px;text-align:left;width:11%;white-space: normal;">Tarix seçimi</td>
     <td style="padding-left:10px;text-align:left;width:10%;white-space: normal;">Ezamiyyə planı</td>
     <td style="padding-left:10px;text-align:left;width:9%;white-space: normal;">Rayonu dəyiş</td>
     <td style="padding-left:10px;text-align:left;width:4%;white-space: normal;">Sil</td>
     <td style="padding-left:10px;text-align:left;width:6%;white-space: normal;">Baxış</td>
     <td style="padding-left:10px;text-align:left;width:10%;white-space: normal;">Təqdim olunma</td>
                    </tr>
                </table>
            </HeaderTemplate>
            <ItemStyle />
            <ItemTemplate>
                <table style="border-bottom-style: dotted; border-bottom-width: thin;width:100%; border-left-style: dotted; border-left-width: thin; border-right-style: dotted; border-right-width: thin;">
                    <tr>
                         <td style="padding-left:2px;text-align:left;width:3%;word-break:break-all;white-space: normal;border-right:dotted; border-right-style: dotted; border-right-width: thin;"><%#Container.ItemIndex+1 %></td>
                        
                        <td style="padding-left:10px;text-align:left;width:20%;white-space: normal;border-right:dotted; border-right-style: dotted; border-right-width: thin;"><%#Eval("Name") %></td>
                        <td style="padding-left:10px;text-align:left;width:13%;white-space: normal;border-right:dotted; border-right-style: dotted; border-right-width: thin;"><%#Class2.sozukes(Eval("RegionCome").ToString()) %></td>
                        <td style="padding-left:10px;text-align:left;width:13%;white-space: normal;border-right:dotted; border-right-style: dotted; border-right-width: thin;"><%#Class2.sozukes(Eval("GoFromRegion").ToString())%></td>
                        <td style="padding-left:10px;text-align:left;width:11%;white-space: normal;border-right:dotted; border-right-style: dotted; border-right-width: thin;">
                            <asp:Panel ID="Panel7" Visible='<%#Convert.ToBoolean(Class2.planagirme(Eval("Approval").ToString()))%>' runat="server"><a class="aucun" href='Ezamiyyenintesviri.aspx?RayonID=<%#Eval("RegionID") %>&BusinessTripID=<%#Eval("BusinessTripID") %>&islem=tarix&rownumber=<%#Container.ItemIndex %>'>
                            <asp:Label ID="Label2" runat="server" Text="Seçim"></asp:Label>
                            </a></asp:Panel></td>
                        <td style="padding-left:10px;text-align:left;width:10%;white-space: normal;border-right:dotted; border-right-style: dotted; border-right-width: thin;">
                            <asp:Panel ID="Panel6" Visible='<%#Convert.ToBoolean(Class2.planagirme(Eval("Approval").ToString()))%>' runat="server">
                            <a class="aucun" href='Ezamiyyənin_Planı.aspx?RegionCode=<%#Eval("RegionCode") %>&RayonID1=<%#Eval("RegionID") %>&BusinessTripID=<%#Eval("BusinessTripID") %>'>Plan</a></asp:Panel></td>
                        <td style="padding-left:10px;text-align:left;width:9%;white-space: normal;border-right:dotted; border-right-style: dotted; border-right-width: thin;">
                            <asp:Panel ID="Panel1" Visible='<%#Convert.ToBoolean(Class2.planagirme(Eval("Approval").ToString()))%>' runat="server">
                            <a class="aucun" href='Ezamiyyenintesviri.aspx?RayonID=<%#Eval("RegionID") %>&islem=rayondeyiw&RegionCode=<%#Eval("RegionCode") %>&BusinessTripID=<%#Eval("BusinessTripID") %>&rownumber=<%#Container.ItemIndex %>'>Dəyiş</a></asp:Panel></td>
                        <td style="text-align:center;width:4%;white-space: normal;border-right-style: dotted; border-right-width: thin;">
                            <asp:Panel ID="Panel3" Visible='<%#Convert.ToBoolean(Class2.planagirme(Eval("Approval").ToString()))%>' runat="server">
                            <a class="aucun" href='Ezamiyyenintesviri.aspx?RayonID=<%#Eval("RegionID") %>&islem=rayonsil&BusinessTripID=<%#Eval("BusinessTripID") %>&rownumber=<%#Container.ItemIndex %>'>Sil</a></asp:Panel></td>
                     
                        <td style="padding-left:10px;text-align:left;width:6%;white-space: normal;border-right-style: dotted; border-right-width: thin;"><a class="aucun" href='view_print_plan1.aspx?RayonID=<%#Eval("RegionID") %>&islem=bax&RegionCode=<%#Eval("RegionCode") %>&BusinessTripID=<%#Eval("BusinessTripID") %>'>Baxış</a></td>
                    <td style="padding-left:10px;text-align:left;width:10%;white-space: normal;">
                        <asp:Label ID="Label1" runat="server"  Text='<%#planagirme1(Eval("Approval").ToString())%>' ForeColor='<%#System.Drawing.Color.FromName(planagirme2(Eval("Approval").ToString()))%>' Font-Bold="True"></asp:Label>

                    </td>
                    </tr>
                </table>
            </ItemTemplate>
            <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        </asp:DataList>
          &nbsp;&nbsp;&nbsp;<asp:LinkButton class="aucun" ID="btnrayonelaveet" runat="server" OnClick="btnrayonelaveet_Click1">Rayon əlavə et</asp:LinkButton>
    </asp:Panel>



   


            <asp:Panel ID="pnlsiyahi" Visible="false" runat="server">
                <div style=" font-weight: bold;">
                    Ezamiyyə planının şəhər və rayonlar üzrə bölünməsi</div>
                <div>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Excele çıxart" Visible="False" />
                </div>
                 <div>&nbsp;<asp:DataList ID="DataList1" runat="server" ForeColor="#333333" OnItemDataBound="DataList1_ItemDataBound" Width="1024px">
                     <AlternatingItemStyle BackColor="White" />
                     <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                     <HeaderTemplate>
                         <table class="style1">
                             <tr>
                                  <td style="padding-left:2px;text-align:left;width:3%;word-break:break-all">№</td>
                           
                                 <td style="padding-left:10px;text-align:left;width:30%;white-space: normal;">Ezamiyyə dövrü üçün müəyyən  edilmiş şəhər və rayonlar</td>
                                
                                 <td style="padding-left:10px;text-align:left;width:13%;white-space: normal;">Ezamiyyənin başlama tarixi</td>
                                 <td style="padding-left:10px;text-align:left;width:13%;white-space: normal;">Ezamiyyənin bitmə tarixi</td>
                                 <td style="padding-left:10px;text-align:left;width:13%;white-space: normal;">İşə çıxma tarixi</td>
                                 <td style="padding-left:10px;text-align:left;width:15%;white-space: normal;">Ezamiyyə tarixinə düzəliş</td>
                                 <td style="text-align:left;width:3%;white-space: normal;">Sil</td>
                                  <td style="padding-left:10px;text-align:left;width:13%;white-space: normal;">Şəhər və  rayonlar üzrə</td>
                             </tr>
                         </table>
                     </HeaderTemplate>
                     <ItemStyle />
                     <ItemTemplate>
                         <table style="border-bottom-style: dotted; border-bottom-width: thin;width:100%; border-left-style: dotted; border-left-width: thin; border-right-style: dotted; border-right-width: thin;">
                             <tr>
                                <td style="padding-left:2px;text-align:left;width:3%;word-break:break-all;white-space: normal;border-right:dotted; border-right-style: dotted; border-right-width: thin;"><%#Container.ItemIndex+1 %></td>
                        
                                 <td style="padding-left:10px;text-align:left;width:30%;white-space:normal;border-right:dotted; border-right-style: dotted; border-right-width: thin;"><%#Eval("Regions") %></td>
                                 <td style="padding-left:10px;text-align:left;width:13%;white-space:normal;border-right:dotted; border-right-style: dotted; border-right-width: thin;"><%#Class2.sozukes(Eval("RegionCome").ToString()) %></td>
                                 <td style="padding-left:10px;text-align:left;width:13%;white-space:normal;border-right:dotted; border-right-style: dotted; border-right-width: thin;"><%#Class2.sozukes(Eval("GoFromRegion").ToString())%></td>
                                 <td style="padding-left:10px;text-align:left;width:13%;white-space:normal;border-right:dotted; border-right-style: dotted; border-right-width: thin;"><%#Class2.sozukes(Eval("ComingToWork").ToString()) %></td>
                                 <asp:Panel ID="Panel4" runat="server">
                                     <td style="padding-left:10px;width:15%;white-space: normal;border-right:dotted; border-right-style: dotted; border-right-width: thin;"><a class="aucun" href='Ezamiyyenintesviri.aspx?BusinessTripID=<%#Eval("BusinessTripID") %>&islem=duzelis&rownumber=<%#Container.ItemIndex %>'>
                                         <asp:Label ID="Label3" runat="server" Text="Düzəliş"></asp:Label>
                                         </a></td>
                                 </asp:Panel>
                                 <td style="padding-left:2px;width:3%;white-space: normal;border-right:dotted; border-right-style: dotted; border-right-width: thin;">
                                     <asp:Panel ID="Panel5" runat="server">
                                         <a class="aucun" href='Ezamiyyenintesviri.aspx?BusinessTripID=<%#Eval("BusinessTripID") %>&islem=sil'>Sil</a>
                                     </asp:Panel>
                                 </td>
                                  <td style="padding-left:10px;text-align:left;width:13%;white-space: normal;"><a class="aucun" href='Ezamiyyenintesviri.aspx?BusinessTripID=<%#Eval("BusinessTripID") %>&islem=rayontarix'>Rayonlar</a></td>
                                
                                 <%--  <td style="text-align:left;width:30%;word-break: break-all;white-space: normal;padding-left:10px;">
                              <a href="Ezamiyyenintesviri.aspx?BusinessTripID=<%#Eval("BusinessTripID") %>&islem=meqsed&rownumber=<%#Container.ItemIndex %>"">
                              Məqsəd və onu əsaslandıran səbəb</a></td>--%>
                             </tr>
                         </table>
                     </ItemTemplate>
                     <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                     </asp:DataList>
                </div>
             




             
                 </asp:Panel>

    <asp:Panel ID="pnltesdiqolunmuw" Visible="false" runat="server">
         <table class="style1">
               <tr>
                   <td class="auto-style147">&nbsp;</td>
                   <td class="auto-style148">
                       <asp:Button ID="btnumumi" runat="server" OnClick="btnumumi_Click" Text="Ümumi" Width="120px" />
                   </td>
                   <td>
                       <asp:Button ID="btnrayuzre" runat="server" OnClick="btnrayuzre_Click" Text="Rayonlar üzrə" Width="120px" />
                   </td>
               </tr>
           </table>
       <asp:Panel ID="pnl1" Visible="false" runat="server">
          
           <asp:DataList ID="DataList3" runat="server" ForeColor="#333333" OnItemDataBound="DataList1_ItemDataBound" Width="1024px">
               <AlternatingItemStyle BackColor="White" />
               <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
               <HeaderTemplate>
                   <table class="style1">
                       <tr>
                           <td style="padding-left:2px;text-align:left;width:3%;white-space: normal;">№</td>
                           <td style="padding-left:10px;text-align:left;width:30%;white-space: normal;">Ezamiyyə dövrü üçün müəyyən edilmiş şəhər və rayonlar</td>
                           <td style="padding-left:10px;text-align:left;width:11%;white-space: normal;">Ezamiyyənin başlama tarixi</td>
                           <td style="padding-left:10px;text-align:left;width:11%;white-space: normal;">Ezamiyyənin bitmə tarixi</td>
                           <td style="padding-left:10px;text-align:left;width:11%;white-space: normal;">İşə çıxma tarixi</td>
                      <%--     <td style="padding-left:10px;text-align:left;width:13%;white-space: normal;">Şəhər və rayonlar üzrə</td>
                     --%>  </tr>
                   </table>
               </HeaderTemplate>
               <ItemStyle />
               <ItemTemplate>
                   <table style="border-bottom-style: dotted; border-bottom-width: thin;width:100%; border-left-style: dotted; border-left-width: thin; border-right-style: dotted; border-right-width: thin;">
                       <tr>
                           <td style="padding-left:2px;text-align:left;width:3%;word-break:break-all;white-space: normal;border-right:dotted; border-right-style: dotted; border-right-width: thin;"><%#Container.ItemIndex+1 %></td>
                           <td style="padding-left:10px;text-align:left;width:30%;white-space:normal;border-right:dotted; border-right-style: dotted; border-right-width: thin;"><%#Eval("Regions") %></td>
                           <td style="padding-left:10px;text-align:left;width:11%;white-space:normal;border-right:dotted; border-right-style: dotted; border-right-width: thin;"><%#Class2.sozukes(Eval("RegionCome").ToString()) %></td>
                           <td style="padding-left:10px;text-align:left;width:11%;white-space:normal;border-right:dotted; border-right-style: dotted; border-right-width: thin;"><%#Class2.sozukes(Eval("GoFromRegion").ToString())%></td>
                           <td style="padding-left:10px;text-align:left;width:11%;white-space:normal;"><%#Class2.sozukes(Eval("ComingToWork").ToString()) %></td>
                       <%--    <td style="padding-left:10px;text-align:left;width:13%;white-space: normal;"><a class="aucun" href='Ezamiyyenintesviri.aspx?BusinessTripID=<%#Eval("BusinessTripID") %>&amp;islem1=rayontarix1'>Rayonlar</a></td>
                      --%> </tr>
                   </table>
               </ItemTemplate>
               <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
           </asp:DataList>
            </asp:Panel>
        <asp:Panel ID="pnl2" Visible="false" runat="server">
         <asp:DataList ID="dlrayontarix0" runat="server" ForeColor="#333333" OnItemDataBound="dlrayontarix_ItemDataBound" Width="1024px">
                <AlternatingItemStyle BackColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderTemplate>
                    <table class="style1">
                        <tr>
                            <td style="padding-left:2px;text-align:left;width:3%;word-break:break-all;">№</td>
                             <td style="padding-left:10px;text-align:left;width:19%;white-space: normal;">Ezamiyyə dövrü üçün müəyyən edilmiş şəhər və rayonlar</td>
                            <td style="padding-left:10px;text-align:left;width:13%;white-space: normal;">Şəhərə və rayona gəlmə tarixi</td>
                            <td style="padding-left:10px;text-align:left;width:13%;white-space: normal;">Şəhərdən və rayondan getmə tarixi</td>
                            <td style="padding-left:10px;text-align:left;width:13%;">Təsdiq olunma tarixi</td>
                             <td style="padding-left:10px;text-align:left;width:6%;">Baxış</td>
                           
                        </tr>
                    </table>
                </HeaderTemplate>
                <ItemStyle />
                <ItemTemplate>
                    <table style="border-bottom-style: dotted; border-bottom-width: thin;width:100%; border-left-style: dotted; border-left-width: thin; border-right-style: dotted; border-right-width: thin;">
                        <tr>
                            <td style="padding-left:2px;text-align:left;width:3%;word-break:break-all;white-space: normal;border-right:dotted; border-right-style: dotted; border-right-width: thin;"><%#Container.ItemIndex+1 %></td>
                            <td style="padding-left:10px;text-align:left;width:19%;white-space: normal;border-right:dotted; border-right-style: dotted; border-right-width: thin;"><%#Eval("Name") %></td>
                            <td style="padding-left:10px;text-align:left;width:13%;white-space: normal;border-right:dotted; border-right-style: dotted; border-right-width: thin;"><%#Class2.sozukes(Eval("RegionCome").ToString()) %></td>
                            <td style="padding-left:10px;text-align:left;width:13%;white-space: normal;border-right:dotted; border-right-style: dotted; border-right-width: thin;"><%#Class2.sozukes(Eval("GoFromRegion").ToString())%></td>
                            <td style="padding-left:10px;text-align:left;width:13%;white-space: normal;border-right:dotted; border-right-style: dotted; border-right-width: thin;"><%#Class2.sozukes(Eval("DateApproval_ze").ToString())%></td>
                            <td style="padding-left:10px;text-align:left;width:6%;white-space: normal;"><a class="aucun" href='view_print_plan1.aspx?RayonID=<%#Eval("RegionID") %>&islem=bax&RegionCode=<%#Eval("RegionCode") %>&islem1=rayontarix1&BusinessTripID=<%#Eval("BusinessTripID") %>'>Baxış</a></td>
                   
                        </tr>
                    </table>
                </ItemTemplate>
                <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            </asp:DataList>
            </asp:Panel>



    </asp:Panel>

     <asp:Panel ID="pnlyenideniwle" Visible="false" runat="server">
 
  <div class="altbawliqlar" style="color:red">Yenidən işlənməsi təklif olunan ezamiyyə planları</div>
    <asp:DataList ID="dtyenideniwle" runat="server" ForeColor="#333333"  Width="1024px">
        <AlternatingItemStyle BackColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderTemplate>
            <table class="style1">
                <tr>
                       <td style="padding-left:2px;text-align:left;width:3%;word-break:break-all;">№</td>
                       
                    <td style="padding-left:10px;text-align:left;width:19%;white-space: normal;">Ezamiyyə dövrü üçün müəyyən edilmiş şəhər və rayonlar</td>
                    <td style="padding-left:10px;text-align:left;width:13%;white-space: normal;">Şəhərə və rayona gəlmə tarixi</td>
                    <td style="padding-left:10px;text-align:left;width:13%;white-space: normal;">Şəhərdən və rayondan getmə tarixi</td>
                    <td style="padding-left:10px;text-align:left;width:13%;white-space: normal;">Təklif</td>
                   <%-- <td style="padding-left:10px;text-align:left;width:13%;white-space: normal;">Faylı sil</td>--%>
                         
                </tr>
            </table>
        </HeaderTemplate>
        <ItemStyle />
        <ItemTemplate>
            <table style="border-bottom-style: dotted; border-bottom-width: thin;width:100%; border-left-style: dotted; border-left-width: thin; border-right-style: dotted; border-right-width: thin;">
                <tr>
                      <td style="padding-left:2px;text-align:left;width:3%;word-break:break-all;white-space: normal;border-right:dotted; border-right-style: dotted; border-right-width: thin;"><%#Container.ItemIndex+1 %></td>
                          
                    <td style="padding-left:10px;text-align:left;width:19%;white-space: normal;border-right:dotted; border-right-style: dotted; border-right-width: thin;"><%#Eval("Name") %></td>
                    <td style="padding-left:10px;text-align:left;width:13%;white-space: normal;border-right:dotted; border-right-style: dotted; border-right-width: thin;"><%#Class2.sozukes(Eval("RegionCome").ToString()) %></td>
                    <td style="padding-left:10px;text-align:left;width:13%;white-space: normal;border-right:dotted; border-right-style: dotted; border-right-width: thin;"><%#Class2.sozukes(Eval("GoFromRegion").ToString())%></td>
                    <td style="padding-left:10px;text-align:left;width:13%;white-space: normal;">
                        <asp:Panel ID="pnlyukle" Visible='<%#Convert.ToBoolean(yuklegorun(Eval("FileName").ToString()))%>'  runat="server">
                        <a class="aucun" href='Ezamiyyenintesviri.aspx?RayonID=<%#Eval("RegionID") %>&islem=fayl&filename=<%#Eval("FileName") %>'>Yüklə</a>
                            </asp:Panel>
                            </td>
                 <%-- <td style="padding-left:10px;text-align:left;width:13%;white-space: normal;">
                        <asp:Panel ID="Panel9" Visible='<%#Convert.ToBoolean(yuklegorun(Eval("FileName").ToString()))%>'  runat="server">
                        <a class="aucun" href='Ezamiyyenintesviri.aspx?RayonID=<%#Eval("RegionID") %>&islem=faylsil&filename=<%#Eval("FileName") %>'>Sil</a>
                            </asp:Panel>
                            </td>--%>
                   
                </tr>
            </table>
        </ItemTemplate>
        <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
    </asp:DataList>

     </asp:Panel>



           


</asp:Content>

