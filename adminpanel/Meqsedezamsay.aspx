<%@ Page Title="" Language="C#" MasterPageFile="~/adminpanel/adminMasterPage.master" AutoEventWireup="true" CodeFile="Meqsedezamsay.aspx.cs" Inherits="adminpanel_Meqsedezamsay" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

    <style type="text/css">
        p.MsoNormal {
            margin-bottom: .0001pt;
            font-size: 12.0pt;
            font-family: "Arial";
            margin-left: 0in;
            margin-right: 0in;
            margin-top: 0in;
        }


        table.MsoNormalTable {
            font-size: 12.0pt;
            font-family: "Arial";
            width: 1022px;
        }

        .auto-style1 {
            width: 100%;
        }

        .auto-style2 {
            width: 828px;
        }

        .auto-style9 {
            width: 45pt;
        }

        .auto-style10 {
            width: 45pt;
        }

        .auto-style11 {
            width: 167px;
            
        }

        .auto-style12 {
            width: 167px;
        }

        .auto-style13 {
            width: 448px;
              
        }

        .auto-style14 {
            width: 448px;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">


    <div id="Div1" runat="server" visible="false">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="btngeri" runat="server" OnClick="btngeri_Click" Text="Geri" Width="150px" />
                </td>
            </tr>
        </table>
    </div>


    <asp:Panel ID="pnlesasseh" runat="server">
        <asp:Panel ID="pnlhesabatabax" runat="server">

            <div>&nbsp;</div>
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

            <div style="float: left; width: 346px; padding-top: 10px; height: 179px;">
                Rayon:&nbsp;&nbsp;
            <asp:DropDownList ID="ddlryn" runat="server">
            </asp:DropDownList>
                <br />
                <br />
                <br />

                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Axtar" Width="120px" />


                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="exele" runat="server" OnClick="exele_Click" Text="Wordə çıxart" Visible="False" Width="120px" />


                <br />
                <br />
                <asp:Label ID="lblmesage" runat="server" Text=""></asp:Label>
                <asp:Label ID="lblgelme1" runat="server" Visible="False"></asp:Label>
                <asp:Label ID="lblgetme1" runat="server" Visible="False"></asp:Label>
                <asp:Label ID="lblsira" runat="server" Visible="False"></asp:Label>
            </div>

            <div style="float: left; width: 284px; height: 203px;">
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

            <div style="float: left; width: 377px; height: 204px;">
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

        </asp:Panel>


        <div class="temizle"></div>

        <asp:Panel ID="Panel1" runat="server">






            <p align="center" class="MsoNormal" style="text-align: center">
                <b style="mso-bidi-font-weight: normal"><span lang="AZ-LATIN" style="mso-ansi-language: AZ-LATIN"> Məqsədlərlə bağlı ezamiyyələrin sayı</span></b>
            </p>
            <p align="center" class="MsoNormal" style="text-align: center">
                <b style="mso-bidi-font-weight: normal"><span lang="AZ-LATIN" style="mso-ansi-language: AZ-LATIN"><span lang="AZ-LATIN" style="font-size: 12.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                    <asp:Label ID="lblgelme2" runat="server" Text=""></asp:Label>
                    -
                <asp:Label ID="lblgetme2" runat="server" Text=""></asp:Label>
                </span></span></b>
            </p>
            <p class="MsoNormal" style="text-align: justify">
                <span lang="AZ-LATIN" style="mso-ansi-language: AZ-LATIN">
                    <o:p>
        &nbsp;</o:p>
                </span>
            </p>
            <p class="MsoNormal">
                <span style="mso-ansi-language: EN-US">
                    <o:p>
        &nbsp;</o:p>
                </span>
            </p>

        </asp:Panel>
            <table cellpadding="0" cellspacing="0" class="MsoNormalTable">
        <tr style="mso-yfti-irow: 0; mso-yfti-firstrow: yes;">
            <td style="border: solid windowtext 1.0pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt;"
                valign="center" class="auto-style11">S/n</td>
            <td style="text-align: center; border-right: 1.0pt solid windowtext; border-top: 1.0pt solid windowtext; border-bottom: 1.0pt solid windowtext; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium;"
                valign="center" class="auto-style13">

                <span lang="AZ-LATIN" style="text-align: center; font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">Məqsədlər</span></td>
            <td style="text-align: center; border: solid windowtext 1.0pt; border-left: none; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; " valign="center">

                <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">Ezamiyyələrin sayı</span></td>
            <%--               <td style="width: 147.1pt; border: solid windowtext 1.0pt; border-left: none; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 55.2pt"
                        valign="center" width="196">
                        <p align="center" class="MsoNormal">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">Görülmüş işlər<o:p></o:p></span>
                        </p>
                    </td>
                    <td style="width: 139.5pt; border: solid windowtext 1.0pt; border-left: none; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 55.2pt"
                        valign="center" width="186">
                        <p align="center" class="MsoNormal">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">Əldə olunan nəticə<b style="mso-bidi-font-weight: normal"><sup><o:p></o:p></sup></b></span>
                        </p>
                    </td>
            --%>
        </tr>


        <tr>
            <td style="border-left: 1.0pt solid windowtext; border-right: 1.0pt solid windowtext; border-bottom: 1.0pt solid windowtext; mso-border-top-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                valign="top" class="auto-style12">
                <p align="right" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">Cəmi</span>
                </p>
            </td>
            <td style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                valign="top" class="auto-style14">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="text-align: center; font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">

                        <span lang="AZ-LATIN" style="text-align: center; font-size: 12.0pt; mso-ansi-language: AZ-LATIN">
                            <asp:Label ID="lblfmetn" runat="server"></asp:Label>
                        </span>

                    </span>
                </p>
            </td>
            <td style="border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 17.25pt" valign="top">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">

                        <span lang="AZ-LATIN" style="font-size: 12.0pt; mso-ansi-language: AZ-LATIN">
                            <asp:Label runat="server" ID="lblezamsay"></asp:Label>
                        </span>

                    </span>
                </p>
            </td>
        </tr>



        <asp:Repeater ID="DataList1" runat="server">
            <ItemTemplate>

                <tr style="mso-yfti-irow: 1; height: 17.25pt">
                    <td style="border-left: 1.0pt solid windowtext; border-right: 1.0pt solid windowtext; border-bottom: 1.0pt solid windowtext; mso-border-top-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                        valign="top" class="auto-style12">
                        <p align="left" class="MsoNormal">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                               <%#Container.ItemIndex+1 %>
                            </span>
                        </p>
                    </td>
                    <td style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                        valign="top" class="auto-style14">
                        <p align="left" class="MsoNormal">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                                <%#Eval("Other")%>
                            </span>
                        </p>
                    </td>
                    <td style="border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 17.25pt" valign="top">
                        <p align="center" class="MsoNormal">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                                         <a class="aucun" style="text-decoration:none;" href='Meqsedezamsay.aspx?PurposeID=<%#Eval("PurposeID")%>&UserID=<%=lblkurator.Text%>&islem=rayon5&RegionID=<%=lblrayon.Text%>&tarix1=<%#lblgelme1.Text%>&tarix2=<%#lblgetme1.Text%>&tarix3=<%#lblgelme.Text%>&tarix4=<%#lblgetme.Text%>&siralama1=<%#lblsira.Text%>'><%#Eval("meqseds") %></a> 
                            </span>
                        </p>
                    </td>
                    <%--                            <td style="width: 147.1pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 17.25pt"
                                valign="top" width="196">
                                <p align="left" class="MsoNormal">
                                    <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                                        <o:p><%#Eval("WorkView")%></o:p>
                                    </span>
                                </p>
                            </td>
                            <td style="width: 139.5pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 17.25pt"
                                valign="top" width="186">
                                <p align="left" class="MsoNormal">
                                    <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                                        <o:p><%#Eval("ResultView")%></o:p>
                                    </span>
                                </p>
                            </td>--%>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
    </asp:Panel>

    <div class="temizle"></div>
    <asp:Panel ID="pnlbirinci" Visible="false" runat="server">
        <asp:Button ID="exele0" runat="server" Text="Wordə çıxart" OnClick="exele0_Click" Width="120px" />
        <br />
        <br />
        <asp:Panel ID="pnlprint" runat="server">
            <p class="MsoNormal">
                <table cellpadding="0" cellspacing="0" class="MsoNormalTable">
                    <tr style="mso-yfti-irow: 0; mso-yfti-firstrow: yes; height: 55.2pt">
                
                        <td style="border: solid windowtext 1.0pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 55.2pt"
                            valign="center" width="126">Kurator</td>
                        <td style="border: solid windowtext 1.0pt; border-left: none; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 55.2pt"
                            valign="center" width="114">
                            <p align="center" class="MsoNormal">
                                <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">Getdiyi rayonların, şəhərlərin adı</span>
                            </p>
                        </td>
                        <td style="width: 85.5pt; border: solid windowtext 1.0pt; border-left: none; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 55.2pt" valign="center" width="114">
                            <p align="center" class="MsoNormal">
                                <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">Şəhərə və rayona gəlmə tarixi<b style="mso-bidi-font-weight: normal"><sup></sup></b></span>
                            </p>
                        </td>
                        <td style="border: solid windowtext 1.0pt; border-left: none; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 55.2pt"
                            valign="center" width="120">
                            <p align="center" class="MsoNormal">
                                <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">Şəhərdən və rayondan getmə tarixi<b style="mso-bidi-font-weight: normal"><sup><o:p></o:p></sup></b></span>
                            </p>
                        </td>
                        <td style="border: solid windowtext 1.0pt; border-left: none; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 55.2pt"
                            valign="center" width="206">
                            <p align="center" class="MsoNormal">
                                <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">Məqsədlər<b style="mso-bidi-font-weight: normal"><sup><o:p></o:p></sup></b></span>
                            </p>
                        </td>
                        <%--               <td style="width: 147.1pt; border: solid windowtext 1.0pt; border-left: none; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 55.2pt"
                        valign="center" width="196">
                        <p align="center" class="MsoNormal">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">Görülmüş işlər<o:p></o:p></span>
                        </p>
                    </td>
                    <td style="width: 139.5pt; border: solid windowtext 1.0pt; border-left: none; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 55.2pt"
                        valign="center" width="186">
                        <p align="center" class="MsoNormal">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">Əldə olunan nəticə<b style="mso-bidi-font-weight: normal"><sup><o:p></o:p></sup></b></span>
                        </p>
                    </td>
                        --%>
                        <asp:Panel ID="pnlbaxiw0" runat="server">
                            <td style="border-right: 1.0pt solid windowtext; border-top: 1.0pt solid windowtext; border-bottom: 1.0pt solid windowtext; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium;"
                                valign="center" class="auto-style9">
                                <p align="center" class="MsoNormal">
                                    <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">Baxış<b style="mso-bidi-font-weight: normal"><sup><o:p></o:p></sup></b></span>
                                </p>
                            </td>
                        </asp:Panel>
                    </tr>






                    <asp:Repeater ID="DataList3" runat="server">
                        <ItemTemplate>
                            <tr style="mso-yfti-irow: 1; height: 17.25pt">

                                <td style="border: solid windowtext 1.0pt; border-top: none; mso-border-top-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 17.25pt"
                                    valign="top">
                                    <p align="left" class="MsoNormal">
                                        <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                                            <%#Eval("username")%>
                                        </span>
                                    </p>
                                </td>
                                <td style="border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 17.25pt"
                                    valign="top">
                                    <p align="left" class="MsoNormal">
                                        <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                                            <%#Eval("Name")%>
                                        </span>
                                    </p>
                                </td>
                                <td style="border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 17.25pt" valign="top">
                                    <p align="center" class="MsoNormal">
                                        <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                                            <%#Class2.sozukes(Eval("RegionCome").ToString()) %>
                                        </span>
                                    </p>
                                </td>
                                <td style="border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 17.25pt"
                                    valign="top">
                                    <p align="center" class="MsoNormal">
                                        <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                                            <o:p><%#Class2.sozukes(Eval("GoFromRegion").ToString()) %></o:p>
                                        </span>
                                    </p>
                                </td>
                                <td style="border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 17.25pt"
                                    valign="top">
                                    <p align="left" class="MsoNormal">
                                        <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                                            <o:p><%#Eval("Other") %></o:p>
                                        </span>
                                    </p>
                                </td>
                                <%--                            <td style="width: 147.1pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 17.25pt"
                                valign="top" width="196">
                                <p align="left" class="MsoNormal">
                                    <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                                        <o:p><%#Eval("WorkView")%></o:p>
                                    </span>
                                </p>
                            </td>
                            <td style="width: 139.5pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 17.25pt"
                                valign="top" width="186">
                                <p align="left" class="MsoNormal">
                                    <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                                        <o:p><%#Eval("ResultView")%></o:p>
                                    </span>
                                </p>
                            </td>--%>
                                <asp:Panel ID="pnlbaxiw1" runat="server">
                                    <td style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                                        valign="top" class="auto-style10">
                                        <p align="center" class="MsoNormal">
                                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                                                <o:p><a href="ezamiyye.aspx?BusinessTripID=<%#Eval("BusinessTripID") %>&islem1=Meqsedezamsay&RegionID=<%#Eval("RegionID") %>&controlBusinesTrip=1&UserID=<%#Eval("UserID") %>">Baxış</a></o:p>
                                            </span>
                                        </p>
                                    </td>
                                </asp:Panel>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </table>
        </asp:Panel>

    </asp:Panel>


    <asp:Label ID="lblgelme3" runat="server" Visible="False"></asp:Label>
    <asp:Label ID="lblgetme3" runat="server" Visible="False"></asp:Label>

    <asp:Label ID="lblgelme4" runat="server" Visible="False"></asp:Label>
    <asp:Label ID="lblgetme4" runat="server" Visible="False"></asp:Label>

    <asp:Label ID="lblkurator" runat="server" Visible="False"></asp:Label>

    <asp:Label ID="lblrayon" runat="server" Visible="False"></asp:Label>




</asp:Content>


