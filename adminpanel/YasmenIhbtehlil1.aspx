<%@ Page Title="" Language="C#" MasterPageFile="~/adminpanel/adminMasterPage.master" AutoEventWireup="true" CodeFile="YasmenIhbtehlil1.aspx.cs" Inherits="adminpanel_YasmenIhbtehlil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
        <style type="text/css">
        .auto-style1 {
            width: 100%;
        }

        .auto-style2 {
            width: 828px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <div id="div" runat="server" visible="false">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="btngeri" runat="server" OnClick="btngeri_Click" Text="Geri" Width="150px" />
                </td>
            </tr>
        </table>
    </div>



    <asp:Panel ID="pnlhesabatabax" runat="server">

        <div>&nbsp;</div>
        <div style="float: left; width: 347px;">
            Rayon:&nbsp;&nbsp;
                        <asp:DropDownList ID="ddlryn" runat="server">
                        </asp:DropDownList>
        </div>


        <div style="float: left; width: 284px; white-space: normal;">
            <strong>Şəhərə və rayona gəlmə tarixi:&nbsp; </strong>
            <asp:ImageButton ID="ImageButton7" runat="server" Height="23px" ImageUrl="~/images/calendar-icon.png" OnClick="ImageButton1_Click" Width="23px" />
        </div>
        <div style="float: left; width: 328px; white-space: normal;">
            <strong>Şəhərdən və rayondan getmə tarixi:&nbsp;
                        <asp:ImageButton ID="ImageButton6" runat="server" Height="23px" ImageUrl="~/images/calendar-icon.png" OnClick="ImageButton3_Click" Width="23px" />
            </strong>
        </div>

        <div style="float: left; width: 346px; padding-top: 10px; padding-bottom: 10px; height: 187px;">
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Axtar" Width="120px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="exele" runat="server" OnClick="exele_Click" Text="Wordə çıxart" Visible="False" Width="120px" />


            <br />
            <br />
            <asp:Label ID="lblmesage" runat="server" Text=""></asp:Label>
            <asp:Label ID="lblgelme1" runat="server" Visible="False"></asp:Label>
            <asp:Label ID="lblgetme1" runat="server" Visible="False"></asp:Label>
        </div>

        <div style="float: left; width: 284px;">
            <asp:Label ID="lblgelme" runat="server" Text=""></asp:Label>
            <asp:ImageButton ID="imgbsilgelme" runat="server" Height="14px" OnClick="imgbsilgelme_Click" src="images/iconlar/sil.png" Visible="False" Width="14px" />
            <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#999999" Visible="false"
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
            &nbsp;&nbsp;
        </div>

        <div style="float: left; width: 377px;">
            <asp:Label ID="lblgetme" runat="server" Text=""></asp:Label>

            <asp:ImageButton ID="imgbsilgetme0" runat="server" Height="14px" OnClick="imgbsilgetme0_Click" src="images/iconlar/sil.png" Visible="False" Width="14px" />
            <asp:Calendar ID="Calendar3" runat="server" BackColor="White" BorderColor="#999999" CellSpacing="1" DayNameFormat="Shortest" Font-Names="Arial" Font-Size="9pt" ForeColor="Black" Height="180px" OnSelectionChanged="Calendar3_SelectionChanged" Visible="false" Width="213px">
                <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                <SelectorStyle BackColor="#CCCCCC" />
                <WeekendDayStyle BackColor="#FFFFCC" />
                <OtherMonthDayStyle ForeColor="White" />
                <NextPrevStyle VerticalAlign="Bottom" />
                <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
            </asp:Calendar>
            &nbsp;
        </div>




        <div class="temizle"></div>


    </asp:Panel>

    <div style="text-align: center;">
        <asp:Label ID="lbluseradi" runat="server" Font-Bold="True"></asp:Label>
    </div>

    <asp:Panel ID="Panel1" runat="server">
        <div class="temizle"></div>
        <div>
            <table style="border-collapse: collapse; width: 100%;">
                <tr>
                    <td style="border-style: solid solid none solid; border-width: 1px 1px 0px 1px; border-color: black; text-align: center; width: 16%; white-space: normal;"><strong>Kuratorun adı</strong></td>
                    <td style="border-style: solid solid none solid; border-width: 1px 1px 0px 1px; border-color: black; text-align: center; width: 16%; white-space: normal;"><strong>Şəhər və rayonlara ezamiyyələrin sayı</strong></td>
                    <td style="border-style: solid solid none solid; border-width: 1px 1px 0px 1px; border-color: black; text-align: center; width: 16%; white-space: normal;"><strong>Getdiyi İHB sayı</strong></td>
                    <td style="border-style: solid solid none solid; border-width: 1px 1px 0px 1px; border-color: black; text-align: center; width: 16%; white-space: normal;"><strong>Getmədiyi İHB sayı</strong></td>
                    <td style="border-style: solid solid none solid; border-width: 1px 1px 0px 1px; border-color: black; text-align: center; width: 16%; white-space: normal;"><strong>Getdiyi yaşayış məntəqələrinin sayı</strong></td>
                    <td style="border-style: solid solid none solid; border-width: 1px 1px 0px 1px; border-color: black; text-align: center; width: 16%; white-space: normal;"><strong>Getmədiyi yaşayış məntəqələrinin sayı</strong></td>

              
                     </tr>
            </table>
            <div class="temizle"></div>

            <table style="border-collapse: collapse; width: 100%;">
                <asp:Repeater ID="DataList1" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td style="border: 1px solid black; padding-left: 7px; text-align: left; width: 16%; white-space: normal;"><%#Eval("Name") %></td>
                            <td style="border: 1px solid black; padding-left: 7px; text-align: center; width: 16%; white-space: normal;">
                                <a class="aucun" href='Yasmenihbtehlil.aspx?UserID=<%#Eval("UserID") %>&islem=rayon1&RegionID=<%#ddlryn.SelectedValue%>&tarix1=<%#lblgelme1.Text%>&tarix2=<%#lblgetme1.Text%>&tarix3=<%#lblgelme.Text%>&tarix4=<%#lblgetme.Text%>'><%#Eval("rayonsayim") %></a>
                            </td>
                            <td style="border: 1px solid black; text-align: center; width: 16%; white-space: normal;">
                                <a class="aucun" href='Yasmenihbtehlil.aspx?UserID=<%#Eval("UserID")%>&islem=rayon5&RegionID=<%#ddlryn.SelectedValue%>&tarix1=<%#lblgelme1.Text%>&tarix2=<%#lblgetme1.Text%>&tarix3=<%#lblgelme.Text%>&tarix4=<%#lblgetme.Text%>'><%#Eval("ihbsayi1") %></a>
                            </td>
                                  <td style="border: 1px solid black; text-align: center; width: 16%; white-space: normal;">
                                <a class="aucun" href='Yasmenihbtehlil.aspx?UserID=<%#Eval("UserID")%>&islem=rayon6&RegionID=<%#ddlryn.SelectedValue%>&tarix1=<%#lblgelme1.Text%>&tarix2=<%#lblgetme1.Text%>&tarix3=<%#lblgelme.Text%>&tarix4=<%#lblgetme.Text%>'><%#Eval("ihbsayi0") %></a>
                            </td>
                               <td style="border: 1px solid black; text-align: center; width: 16%; white-space: normal;">
                                <a class="aucun" href='Yasmenihbtehlil.aspx?UserID=<%#Eval("UserID")%>&islem=rayon7&RegionID=<%#ddlryn.SelectedValue%>&tarix1=<%#lblgelme1.Text%>&tarix2=<%#lblgetme1.Text%>&tarix3=<%#lblgelme.Text%>&tarix4=<%#lblgetme.Text%>'><%#Eval("yawmensayi1") %></a>
                            </td>
                               <td style="border: 1px solid black; text-align: center; width: 16%; white-space: normal;">
                                <a class="aucun" href='Yasmenihbtehlil.aspx?UserID=<%#Eval("UserID")%>&islem=rayon8&RegionID=<%#ddlryn.SelectedValue%>&tarix1=<%#lblgelme1.Text%>&tarix2=<%#lblgetme1.Text%>&tarix3=<%#lblgelme.Text%>&tarix4=<%#lblgetme.Text%>'><%#Eval("yawmensayi0") %></a>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
        </div>
    </asp:Panel>




    <asp:Panel ID="Panel2" runat="server">
        <div class="temizle"></div>
        <div>
            <table style="border-collapse: collapse; width: 100%;">
                <tr>
                    <td style="border-style: solid solid none solid; border-width: 1px 1px 0px 1px; border-color: black; text-align: center; width: 16%; white-space: normal;"><strong>Getdiyi rayonların, şəhərlərin adı</strong></td>
                    <td style="border-style: solid solid none solid; border-width: 1px 1px 0px 1px; border-color: black; text-align: center; width: 16%; white-space: normal;"><strong>Şəhər və rayonlara ezamiyyələrin sayı</strong></td>
                    <td style="border-style: solid solid none solid; border-width: 1px 1px 0px 1px; border-color: black; text-align: center; width: 16%; white-space: normal;"><strong>Getdiyi İHB sayı</strong></td>
                  <td style="border-style: solid solid none solid; border-width: 1px 1px 0px 1px; border-color: black; text-align: center; width: 16%; white-space: normal;"><strong>Getmədiyi İHB sayı</strong></td>
                 <td style="border-style: solid solid none solid; border-width: 1px 1px 0px 1px; border-color: black; text-align: center; width: 16%; white-space: normal;"><strong>Getdiyi yaşayış məntəqələrinin sayı</strong></td>
                 <td style="border-style: solid solid none solid; border-width: 1px 1px 0px 1px; border-color: black; text-align: center; width: 16%; white-space: normal;"><strong>Getmədiyi yaşayış məntəqələrinin sayı</strong></td>
              
                     </tr>
            </table>
            <div class="temizle"></div>

            <table style="border-collapse: collapse; width: 100%;">
                <asp:Repeater ID="DataList2" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td style="border: 1px solid black; padding-left: 7px; text-align: left; width: 16%; white-space: normal;"><%#Eval("Regions") %></td>
                            <td style="border: 1px solid black; padding-left: 7px; text-align: center; width: 16%; white-space: normal;">
                                <a class="aucun" href='Yasmenihbtehlil.aspx?UserID=<%#Eval("UserID")%>&RegionID=<%#Eval("RegionID")%>&islem=rayon3&tarix1=<%#lblgelme1.Text%>&tarix2=<%#lblgetme1.Text%>&tarix3=<%#lblgelme.Text%>&tarix4=<%#lblgetme.Text%>'><%#Eval("rayonagetmesayi") %></a>
                            </td>
                            <td style="border: 1px solid black; text-align: center; width: 16%; white-space: normal;">
                                <a class="aucun" href='Yasmenihbtehlil.aspx?UserID=<%#Eval("UserID")%>&RegionID=<%#Eval("RegionID")%>&islem=rayon2&tarix1=<%#lblgelme1.Text%>&tarix2=<%#lblgetme1.Text%>&tarix3=<%#lblgelme.Text%>&tarix4=<%#lblgetme.Text%>'><%#Eval("ihb1") %></a>
                            </td>
                             <td style="border: 1px solid black; text-align: center; width: 16%; white-space: normal;">
                                <a class="aucun" href='Yasmenihbtehlil.aspx?UserID=<%#Eval("UserID")%>&RegionID=<%#Eval("RegionID")%>&islem=rayon20&tarix1=<%#lblgelme1.Text%>&tarix2=<%#lblgetme1.Text%>&tarix3=<%#lblgelme.Text%>&tarix4=<%#lblgetme.Text%>'><%#Eval("ihb0") %></a>
                            </td>
                                <td style="border: 1px solid black; text-align: center; width: 16%; white-space: normal;">
                                <a class="aucun" href='Yasmenihbtehlil.aspx?UserID=<%#Eval("UserID")%>&RegionID=<%#Eval("RegionID")%>&islem=rayon21&tarix1=<%#lblgelme1.Text%>&tarix2=<%#lblgetme1.Text%>&tarix3=<%#lblgelme.Text%>&tarix4=<%#lblgetme.Text%>'><%#Eval("yawmensayi1") %></a>
                            </td>
                                <td style="border: 1px solid black; text-align: center; width: 16%; white-space: normal;">
                                <a class="aucun" href='Yasmenihbtehlil.aspx?UserID=<%#Eval("UserID")%>&RegionID=<%#Eval("RegionID")%>&islem=rayon22&tarix1=<%#lblgelme1.Text%>&tarix2=<%#lblgetme1.Text%>&tarix3=<%#lblgelme.Text%>&tarix4=<%#lblgetme.Text%>'><%#Eval("yawmensayi0") %></a>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
        </div>
    </asp:Panel>





    <asp:Panel ID="Panel3" runat="server">

        <div class="temizle"></div>
        <div>
            <table style="border-collapse: collapse; width: 100%;">
                <tr>
                    <td style="border-style: solid solid none solid; border-width: 1px 1px 0px 1px; border-color: black; text-align: center; width: 25%; white-space: normal;"><strong>Getdiyi rayonların, şəhərlərin adı</strong></td>
                    <td style="border-style: solid solid none solid; border-width: 1px 1px 0px 1px; border-color: black; text-align: center; width: 20%; white-space: normal;"><strong>Şəhərə və rayona gəlmə tarixi</strong></td>
                    <td style="border-style: solid solid none solid; border-width: 1px 1px 0px 1px; border-color: black; text-align: center; width: 20%; white-space: normal;"><strong>Şəhərdən və rayondan getmə tarixi</strong></td>
                    <td style="border-style: solid solid none solid; border-width: 1px 1px 0px 1px; border-color: black; text-align: center; width: 35%; white-space: normal;"><strong>
                        <asp:Label ID="lblihbyaw" runat="server" Text="Label"></asp:Label></strong></td>
                </tr>
            </table>
            <div class="temizle"></div>

            <table style="border-collapse: collapse; width: 100%;">
                <asp:Repeater ID="DataList3" runat="server">
                    <ItemTemplate>
                        <tr>
  <td style="border: 1px solid black; padding-left: 7px; text-align: left; width: 25%; white-space: normal;">
          <%#Eval("Regions") %></td>
  <td style="border: 1px solid black; padding-left: 7px; text-align: center; width: 20%; white-space: normal;">
                                <%#Class2.sozukes(Eval("RegionCome").ToString()) %>   </td>
                            <td style="border: 1px solid black; text-align: center; width: 20%; white-space: normal;">
                                <%#Class2.sozukes(Eval("GoFromRegion").ToString()) %></td>
                            <td style="border: 1px solid black; padding-left: 7px; width: 35%; white-space: normal;">
                                <%#Eval("Other") %></td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
        </div>



    </asp:Panel>






    <asp:Panel ID="Panel4" runat="server">

        <div class="temizle"></div>
        <div>
            <table style="border-collapse: collapse; width: 100%;">
                <tr>
                    <td style="border-style: solid solid none solid; border-width: 1px 1px 0px 1px; border-color: black; text-align: center; width: 15%; white-space: normal;"><strong>Şəhərə və rayona gəlmə tarixi</strong></td>
                    <td style="border-style: solid solid none solid; border-width: 1px 1px 0px 1px; border-color: black; text-align: center; width: 15%; white-space: normal;"><strong>Şəhərə və rayona gəlmə tarixi</strong></td>
                    <td style="border-style: solid solid none solid; border-width: 1px 1px 0px 1px; border-color: black; text-align: center; width: 15%; white-space: normal;"><strong>Şəhərdən və rayondan getmə tarixi</strong></td>
                    <td style="border-style: solid solid none solid; border-width: 1px 1px 0px 1px; border-color: black; text-align: center; width: 12%; white-space: normal;"><strong>Olduğu İHB sayı</strong></td>
                   <td style="border-style: solid solid none solid; border-width: 1px 1px 0px 1px; border-color: black; text-align: center; width: 12%; white-space: normal;"><strong>Olmadığı İHB sayı</strong></td>
                  <td style="border-style: solid solid none solid; border-width: 1px 1px 0px 1px; border-color: black; text-align: center; width: 18%; white-space: normal;"><strong>Olduğu yaşayış məntəqələrinin sayı</strong></td>
                  <td style="border-style: solid solid none solid; border-width: 1px 1px 0px 1px; border-color: black; text-align: center; width: 18%; white-space: normal;"><strong>Olmadığı yaşayış məntəqələrinin sayı</strong></td>
            
                     </tr>
            </table>
            <div class="temizle"></div>

            <table style="border-collapse: collapse; width: 100%;">
                <asp:Repeater ID="DataList4" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td style="border: 1px solid black; padding-left: 7px; text-align: left; width: 15%; white-space: normal;"><%#Eval("Regions") %></td>
                            <td style="border: 1px solid black; padding-left: 7px; text-align: center; width: 15%; white-space: normal;">
                                <%#Class2.sozukes(Eval("RegionCome").ToString()) %> </td>
                            <td style="border: 1px solid black; text-align: center; width: 15%; white-space: normal;">
                                <%#Class2.sozukes(Eval("GoFromRegion").ToString())%> </td>
                            <td style="border: 1px solid black; text-align: center; width: 12%; white-space: normal;">
                                <a class="aucun" href='Yasmenihbtehlil.aspx?UserID=<%#Eval("UserID")%>&BusinessTripID=<%#Eval("BusinessTripID")%>&islem=rayon4&RegionID=<%#ddlryn.SelectedValue%>&tarix1=<%#lblgelme1.Text%>&tarix2=<%#lblgetme1.Text%>&tarix3=<%#lblgelme.Text%>&tarix4=<%#lblgetme.Text%>'><%#Eval("ihb1") %></a> </td>
                            <td style="border: 1px solid black; text-align: center; width: 12%; white-space: normal;">
                                <a class="aucun" href='Yasmenihbtehlil.aspx?UserID=<%#Eval("UserID")%>&BusinessTripID=<%#Eval("BusinessTripID")%>&islem=rayon4&RegionID=<%#ddlryn.SelectedValue%>&tarix1=<%#lblgelme1.Text%>&tarix2=<%#lblgetme1.Text%>&tarix3=<%#lblgelme.Text%>&tarix4=<%#lblgetme.Text%>'><%#Eval("ihb0") %></a> </td>
                         <td style="border: 1px solid black; text-align: center; width: 18%; white-space: normal;">
                                <a class="aucun" href='Yasmenihbtehlil.aspx?UserID=<%#Eval("UserID")%>&BusinessTripID=<%#Eval("BusinessTripID")%>&islem=rayon4&RegionID=<%#ddlryn.SelectedValue%>&tarix1=<%#lblgelme1.Text%>&tarix2=<%#lblgetme1.Text%>&tarix3=<%#lblgelme.Text%>&tarix4=<%#lblgetme.Text%>'><%#Eval("yawmensayi1") %></a> </td>
                      <td style="border: 1px solid black; text-align: center; width: 18%; white-space: normal;">
                                <a class="aucun" href='Yasmenihbtehlil.aspx?UserID=<%#Eval("UserID")%>&BusinessTripID=<%#Eval("BusinessTripID")%>&islem=rayon4&RegionID=<%#ddlryn.SelectedValue%>&tarix1=<%#lblgelme1.Text%>&tarix2=<%#lblgetme1.Text%>&tarix3=<%#lblgelme.Text%>&tarix4=<%#lblgetme.Text%>'><%#Eval("yawmensayi0") %></a> </td>
                    
                             </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
        </div>

    </asp:Panel>

</asp:Content>

