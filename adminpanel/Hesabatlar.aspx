<%@ Page Title="" Language="C#" MasterPageFile="~/adminpanel/adminMasterPage.master" AutoEventWireup="true" CodeFile="Hesabatlar.aspx.cs" Inherits="Vizuallawma" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style9 {
            width: 191px;
            white-space: normal;
        }

        .auto-style10 {
            width: 314px;
            white-space: normal;
        }

        .auto-style11 {
            width: 317px;
            white-space: normal;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>

        <table style="width: 1000px">
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style10">
                    <asp:Button ID="btnbaxish" runat="server" Width="270px" Text="Təsdiq olunmamış hesabatlar" OnClick="btnbaxish_Click" />
                </td>
                <td class="auto-style11">
                    <asp:Button ID="btntesdiqolunmuw" runat="server" Text="Təsdiq olunmuş hesabatlar" Width="270px" OnClick="btntesdiqolunmuw_Click"  />
                </td>
                <td>
                    <asp:Button ID="btnyenidenile" runat="server" Text="Yenidən işlənməsi təklif olunan hesabatlar" Width="270px" OnClick="btnyenidenile_Click" />
                </td>
            </tr>
        </table>


        <div>&nbsp;</div>


        <asp:Panel ID="pnlhesabatabax" Visible="false" runat="server">



            <div style="float: left; width: 347px;">
                Kurator:&nbsp;
                <asp:DropDownList ID="ddlusers" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlusers_SelectedIndexChanged">
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

            <div style="float: left; width: 346px; padding-top: 10px; height: 156px;">
                Rayon:&nbsp;&nbsp;
                <asp:DropDownList ID="ddlryn" runat="server">
                </asp:DropDownList>
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Hesabata bax" Width="120px"  />
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="exele" runat="server" OnClick="exele_Click" Text="Wordə çıxart" Visible="False" Width="120px" />
                <br />
                <br />
                <asp:Label ID="lblmesage" runat="server" Font-Bold="True"></asp:Label>
                <asp:Label ID="lblgelme1" runat="server" Visible="False"></asp:Label>
                <asp:Label ID="lblgetme1" runat="server" Visible="False"></asp:Label>
                <br />
                <asp:Label ID="lbldey" runat="server" Text="1" Visible="False"></asp:Label>
                <br />
            </div>

            <div style="float: left; width: 284px; height: 194px;">
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

            <div style="float: left; width: 377px; height: 193px;">
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









            <asp:Panel ID="Panel1" runat="server">
                
                <div>
                    <table style="border-collapse: collapse; width: 100%;">
                        <tr>
                            <td style="border-style: solid solid none solid;padding-left: 7px; border-width: 1px 1px 0px 1px; border-color: black; padding-left: 7px; width: 15%; white-space: normal;"><strong>Kuratorun adı</strong></td>
                            <td style="border-style: solid solid none solid; padding-left: 7px; border-width: 1px 1px 0px 1px; border-color: black; padding-left: 7px; width: 20%; white-space: normal;"><strong>Rayonun, şəhərin adı</strong></td>
                            <td style="border-style: solid solid none solid; border-width: 1px 1px 0px 1px; border-color: black; text-align: center; width: 15%; white-space: normal;"><strong>Şəhərə və rayona<br />
                                gəlmə tarixi</strong></td>
                            <td style="border-style: solid solid none solid; border-width: 1px 1px 0px 1px; border-color: black; text-align: center; width: 20%; white-space: normal;"><strong>Şəhərdən və rayondan<br />
                                getmə tarixi</strong></td>
                            <asp:Panel ID="Panel3" runat="server">
                                <td style="border-style: solid solid none solid; border-width: 1px 1px 0px 1px; border-color: black; text-align: center; width: 6%; white-space: normal;"><strong>Baxış</strong></td>
                                <td style="border-style: solid solid none solid; border-width: 1px 1px 0px 1px; border-color: black; text-align: center; width: 11%; white-space: normal;"><strong>Təklif</strong></td>
                                <td style="border-style: solid solid none solid; border-width: 1px 1px 0px 1px; border-color: black; text-align: center; width: 10%; white-space: normal;"><strong>Təklifi sil</strong></td>
                            </asp:Panel>
                        </tr>
                    </table>
                    <div class="temizle"></div>

                    <table style="border-collapse: collapse; width: 100%;">
                        <asp:Repeater ID="DataList1" runat="server">
                            <ItemTemplate>
                                <tr>
                                    <td style="border: 1px solid black; padding-left: 7px; width: 15%; white-space: normal;"><%#Eval("username") %></td>
                                    <td style="border: 1px solid black; padding-left: 7px; width: 20%; white-space: normal;"><%#Eval("Regions") %></td>
                                    <td style="border: 1px solid black; text-align: center; width: 15%; white-space: normal;"><%#Class2.sozukes(Eval("RegionCome").ToString()) %></td>
                                    <td style="border: 1px solid black; text-align: center; width: 20%; white-space: normal;"><%#Class2.sozukes(Eval("GoFromRegion").ToString()) %></td>
                                    <asp:Panel ID="Panel2" runat="server">
                                        <td style="border: 1px solid black; text-align: center; width: 6%; white-space: normal;"><a href="ezamiyye.aspx?BusinessTripID=<%#Eval("BusinessTripID") %>&islem1=adminislem<%#lbldey.Text%>&RegionID=<%#Eval("RegionID") %>&controlBusinesTrip=1&UserID=<%#Eval("UserID") %>">Baxış</a></td>
                                        <td style="border: 1px solid black; text-align: center; width: 11%; white-space: normal;">
                                            <asp:Panel ID="pnlyukle" Visible='<%#Convert.ToBoolean(yuklegorun(Eval("FileName").ToString()))%>' runat="server">
                                                <a class="aucun" href='Hesabatlar.aspx?RayonID=<%#Eval("RegionID") %>&UserID=<%#Eval("UserID") %>&BusinessTripID=<%#Eval("BusinessTripID") %>&islem=fayl&filename=<%#Eval("FileName") %>'>Yüklə</a>
                                            </asp:Panel>
                                        </td>
                                        <td style="border: 1px solid black; text-align: center; width: 10%; white-space: normal;">
                                            <asp:Panel ID="Panel9" Visible='<%#Convert.ToBoolean(yuklegorun(Eval("FileName").ToString()))%>' runat="server">
                                                <a class="aucun" href='Hesabatlar.aspx?RayonID=<%#Eval("RegionID") %>&UserID=<%#Eval("UserID") %>&BusinessTripID=<%#Eval("BusinessTripID") %>&islem1=adminislem<%#lbldey.Text%>&islem=faylsil&filename=<%#Eval("FileName") %>'>Sil</a>
                                            </asp:Panel>
                                        </td>
                                    </asp:Panel>

                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>
                    </table>
                </div>
            </asp:Panel>

        </asp:Panel>









        <asp:Panel ID="pnlyenideniwle" runat="server">

            <asp:Label ID="lbltapilmadi" runat="server" Font-Bold="True"></asp:Label>
            <div class="temizle"></div>
            <asp:Panel ID="Panel4" runat="server">
                <div>
                    <table style="border-collapse: collapse; width: 100%;">
                        <tr>
                            <td style="border-style: solid solid none solid;padding-left: 7px; border-width: 1px 1px 0px 1px; border-color: black; padding-left: 7px; width: 15%; white-space: normal;"><strong>Kuratorun adı</strong></td>
                            <td style="border-style: solid solid none solid;padding-left: 7px; border-width: 1px 1px 0px 1px; border-color: black; padding-left: 7px; width: 20%; white-space: normal;"><strong>Rayonun, şəhərin adı</strong></td>
                            <td style="border-style: solid solid none solid; border-width: 1px 1px 0px 1px; border-color: black; text-align: center; width: 15%; white-space: normal;"><strong>Şəhərə və rayona<br />
                                gəlmə tarixi</strong></td>
                            <td style="border-style: solid solid none solid; border-width: 1px 1px 0px 1px; border-color: black; text-align: center; width: 20%; white-space: normal;"><strong>Şəhərdən və rayondan<br />
                                getmə tarixi</strong></td>
                            <asp:Panel ID="Panel5" runat="server">
                                <td style="border-style: solid solid none solid; border-width: 1px 1px 0px 1px; border-color: black; text-align: center; width: 6%; white-space: normal;"><strong>Baxış</strong></td>
                                <td style="border-style: solid solid none solid; border-width: 1px 1px 0px 1px; border-color: black; text-align: center; width: 11%; white-space: normal;"><strong>Təklif</strong></td>
                                <td style="border-style: solid solid none solid; border-width: 1px 1px 0px 1px; border-color: black; text-align: center; width: 10%; white-space: normal;"><strong>Təklifi sil</strong></td>
                            </asp:Panel>
                        </tr>
                    </table>
                    <div class="temizle"></div>
                    <table style="border-collapse: collapse; width: 100%;">
                        <asp:Repeater ID="rpyenideniwle" runat="server">
                            <ItemTemplate>
                                <tr>
                                    <td style="border: 1px solid black; padding-left: 7px; width: 15%; white-space: normal;"><%#Eval("username") %></td>
                                    <td style="border: 1px solid black; padding-left: 7px; width: 20%; white-space: normal;"><%#Eval("Regions") %></td>
                                    <td style="border: 1px solid black; text-align: center; width: 15%; white-space: normal;"><%#Class2.sozukes(Eval("RegionCome").ToString()) %></td>
                                    <td style="border: 1px solid black; text-align: center; width: 20%; white-space: normal;"><%#Class2.sozukes(Eval("GoFromRegion").ToString()) %></td>
                                    <asp:Panel ID="Panel2" runat="server">
                                        <td style="border: 1px solid black; text-align: center; width: 6%; white-space: normal;"><a href="ezamiyye.aspx?BusinessTripID=<%#Eval("BusinessTripID") %>&islem1=adminislem3&RegionID=<%#Eval("RegionID") %>&controlBusinesTrip=1&UserID=<%#Eval("UserID") %>">Baxış</a></td>
                                        <td style="border: 1px solid black; text-align: center; width: 11%; white-space: normal;">
                                            <asp:Panel ID="pnlyukle" Visible='<%#Convert.ToBoolean(yuklegorun(Eval("FileName").ToString()))%>' runat="server">
                                                <a class="aucun" href='Hesabatlar.aspx?RayonID=<%#Eval("RegionID") %>&UserID=<%#Eval("UserID") %>&BusinessTripID=<%#Eval("BusinessTripID") %>&islem=fayl&filename=<%#Eval("FileName") %>'>Yüklə</a>
                                            </asp:Panel>
                                        </td>
                                        <td style="border: 1px solid black; text-align: center; width: 10%; white-space: normal;">
                                            <asp:Panel ID="Panel9" Visible='<%#Convert.ToBoolean(yuklegorun(Eval("FileName").ToString()))%>' runat="server">
                                                <a class="aucun" href='Hesabatlar.aspx?RayonID=<%#Eval("RegionID") %>&UserID=<%#Eval("UserID") %>&BusinessTripID=<%#Eval("BusinessTripID") %>&islem=faylsil&filename=<%#Eval("FileName") %>'>Sil</a>
                                            </asp:Panel>
                                        </td>
                                    </asp:Panel>

                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>
                    </table>
                </div>
            </asp:Panel>
        </asp:Panel>





    </div>









</asp:Content>

