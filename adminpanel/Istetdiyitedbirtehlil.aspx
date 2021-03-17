<%@ Page Title="" Language="C#" MasterPageFile="~/adminpanel/adminMasterPage.master" AutoEventWireup="true" CodeFile="Istetdiyitedbirtehlil.aspx.cs" Inherits="adminpanel_Istetdiyitedbirtehlil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }

        .auto-style2 {
            width: 828px;
        }

        p.MsoNormal {
            margin-bottom: .0001pt;
            font-size: 11.0pt;
            font-family: "Arial","sans-serif";
            margin-left: 0in;
            margin-right: 0in;
            margin-top: 0in;
        }

        .auto-style3 {
            border-collapse: collapse;
            font-family: Arial;
            border-style: none;
            border-color: inherit;
            border-width: medium;
        }

        .auto-style4 {
            height: 16.2pt;
        }

        .auto-style8 {
            height: 16.2pt;
        }

        .auto-style12 {
            width: 79pt;
        }

        .auto-style13 {
            height: 16.2pt;
            width: 71pt;
        }

        .auto-style14 {
            height: 17.25pt;
            width: 71pt;
        }

        .auto-style15 {
            width: 71pt;
        }

        .auto-style19 {
            height: 38.25pt;
            width: 30pt;
        }

        .auto-style20 {
            height: 17.25pt;
            width: 30pt;
        }

        .auto-style22 {
            border-collapse: collapse;
            font-size: 11.0pt;
            font-family: Calibri, sans-serif;
            border-style: none;
            border-color: inherit;
            border-width: medium;
            margin-left: 0in;
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

            <div style="float: left; width: 346px; padding-top: 10px; height: 186px;">
                Rayon:&nbsp;&nbsp;
            <asp:DropDownList ID="ddlryn" runat="server">
            </asp:DropDownList>
                <br />
                <br />
                <asp:RadioButton ID="rdrayon" runat="server" Checked="True" GroupName="A" Text="Şəhər və rayonlar üzrə" />
                <br />
                <asp:RadioButton ID="rdmeqsed" runat="server" GroupName="A" Text="İştirak etdiyi tədbirlər üzrə" />
                <br />
                <asp:RadioButton ID="rdmesele" runat="server" GroupName="A" Text="Müzakirə olunmuş məsələlər üzrə" />
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


            <div>

                <p align="center" class="MsoNormal" style="text-align: center;font-size:12pt;">
                    <b style="mso-bidi-font-weight: normal"><span lang="AZ-LATIN" style="mso-ansi-language: AZ-LATIN">Şöbə əməkdaşlarının ezamiyyətlər dövründə iştirak etdikləri tədbirlər barədə məlumat</span></b>
                </p>
                <p class="MsoNormal" style="text-align: justify">
                    <span lang="AZ-LATIN" style="mso-ansi-language: AZ-LATIN">
                        <o:p>
        &nbsp;</o:p>
                    </span>
                </p>



                <table border="1" cellpadding="0" cellspacing="0" class="auto-style3" style="mso-table-layout-alt: fixed; mso-border-alt: solid windowtext .5pt; mso-yfti-tbllook: 1184; mso-padding-alt: 0in 5.4pt 0in 5.4pt; mso-border-insideh: .5pt solid windowtext; mso-border-insidev: .5pt solid windowtext; width: 1019px;">
                    <tr style="mso-yfti-irow: 0; mso-yfti-firstrow: yes">
                        <td rowspan="3" style="width: 29.25pt; border: solid windowtext 1.0pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt"
                            valign="center" width="39">
                            <p class="MsoNormal">
                                <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">S/n </span>
                            </p>
                        </td>
                        <td rowspan="3" style="border-right: 1.0pt solid windowtext; border-top: 1.0pt solid windowtext; border-bottom: 1.0pt solid windowtext; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium;"
                            valign="center" class="auto-style12">
                            <p align="center" class="MsoNormal" style="text-align: center">
                                <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">Adı, soyadı </span>
                            </p>
                        </td>
                        <td colspan="6" style="width: 626.5pt; border: solid windowtext 1.0pt; border-left: none; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt"
                            valign="center" width="835">
                            <p align="center" class="MsoNormal" style="text-align: center">
                                <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                                    <asp:Label ID="lblgelme2" runat="server" Text=""></asp:Label>
                                    -
                                    <asp:Label ID="lblgetme2" runat="server" Text=""></asp:Label>
                                </span>
                            </p>
                        </td>
                    </tr>
                    <tr style="mso-yfti-irow: 1; height: 16.2pt">
                        <td rowspan="2" style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                            valign="center" class="auto-style13">
                            <p align="center" class="MsoNormal" style="text-align: center">
                                <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">Şəhər və rayonlara ezamiyyətlərin sayı</span>
                            </p>
                        </td>
                        <td rowspan="2" style="width: 98.85pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 16.2pt"
                            valign="center" width="132">
                            <p align="center" class="MsoNormal" style="text-align: center">
                                <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">Şəhər, rayon</span>
                            </p>
                        </td>
                        <td colspan="2" style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                            valign="center" class="auto-style4">
                            <p align="center" class="MsoNormal" style="text-align: center">
                                <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">İştirak etdiyi tədbirlər</span>
                            </p>
                        </td>
                        <td colspan="2" style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                            valign="center" class="auto-style8">
                            <p align="center" class="MsoNormal" style="text-align: center">
                                <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">Müzakirə olunmuş məsələlər</span>
                            </p>
                        </td>
                    </tr>
                    <tr style="mso-yfti-irow: 2; height: 38.25pt">
<%--                        <td style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                            valign="center" class="auto-style16">
                            <p align="center" class="MsoNormal" style="text-align: center">
                                <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">Cəmi&nbsp; sayı</span>
                            </p>
                        </td>--%>
                        <td style="width: 162.15pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 38.25pt" valign="center" width="216">
                            <p align="center" class="MsoNormal" style="text-align: center">
                                <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">Mətn</span></p>
                        </td>
                        <td style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                            valign="center" class="auto-style19">
                            <p align="center" class="MsoNormal" style="text-align: center">
                                <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">Sayı<b style="mso-bidi-font-weight: normal"><sup></sup></b></span>
                            </p>
                        </td>
<%--                        <td style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                            valign="center" class="auto-style9">
                            <p align="center" class="MsoNormal" style="text-align: center">
                                <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">Cəmi&nbsp; sayı</span></p>
                        </td>--%>
                        <td style="width: 2.75in; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 38.25pt" valign="center" width="264">
                            <p align="center" class="MsoNormal" style="text-align: center">
                                <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">Mətn<b style="mso-bidi-font-weight: normal"><sup></sup></b></span>
                            </p>
                        </td>
                        <td style="width: 43.6pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 38.25pt"
                            valign="center" width="58">
                            <p align="center" class="MsoNormal" style="text-align: center">
                                <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">Sayı<b style="mso-bidi-font-weight: normal"><sup></sup></b></span>
                            </p>
                        </td>
                    </tr>
                    <tr style="mso-yfti-irow: 3; height: 17.25pt">
                        <td colspan="2" style="border-left: 1.0pt solid windowtext; border-right: 1.0pt solid windowtext; border-bottom: 1.0pt solid windowtext; mso-border-top-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 17.25pt; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                            valign="center">
                            <p align="right" class="MsoNormal" style="text-align: right">
                                <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">Cəmi</span><span style="font-size: 11.0pt; mso-ansi-language: EN-US">:<b style="mso-bidi-font-weight: normal"><sup></sup></b></span>
                            </p>
                        </td>
                        <td style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                            valign="center" class="auto-style14">
                            <p align="center" class="MsoNormal" style="text-align: center;">
                                <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN"><span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">
                                    <asp:Label ID="lblezamsay" runat="server"></asp:Label>
                                </span></span>

                            </p>
                        </td>
                        <td style="width: 98.85pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 17.25pt"
                            valign="top" width="132">
                            <p align="center" class="MsoNormal" style="text-align: center;">
                                <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">&nbsp;</span>
                                <span lang="AZ-LATIN" style="font-size: 12.0pt; mso-ansi-language: AZ-LATIN">
                                    <asp:Label ID="lblfreg" runat="server"></asp:Label>
                                </span>
                            </p>

                        </td>
<%--                        <td style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                            valign="top" class="auto-style17">
                            <p align="center" class="MsoNormal" style="text-align: center;">

                                <span lang="AZ-LATIN" style="font-size: 12.0pt; mso-ansi-language: AZ-LATIN">
                                    <a class="aucun" style="text-decoration: none;" href='Istetdiyitedbirtehlil.aspx?islem=rayon5&tarix1=<%= lblgelme3.Text %>&tarix2=<%= lblgetme3.Text %>&tarix3=<%= lblgelme4.Text %>&tarix4=<%= lblgetme4.Text %>&siralama1=<%= lblsira.Text %>&userkod=<%= lblkurator.Text %>&rayonkod=<%= lblrayon.Text %>'>
                                        <asp:Label ID="lbltedbir" runat="server"></asp:Label>
                                    </a></span>
                            </p>
                        </td>--%>
                        <td style="width: 162.15pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 17.25pt" valign="top" width="216">
                            <p align="center" class="MsoNormal" style="text-align: center;">
                                <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">&nbsp;</span>
                                <span lang="AZ-LATIN" style="font-size: 12.0pt; mso-ansi-language: AZ-LATIN">
                                    <asp:Label ID="lblfmetn" runat="server"></asp:Label>
                                </span>
                            </p>
                        </td>
                        <td style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                            valign="top" class="auto-style20">
                            <p align="center" class="MsoNormal" style="text-align: center;">
                                <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">&nbsp;</span>
                            </p>

                        </td>
<%--                        <td style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                            valign="top" class="auto-style10">
                            <p align="center" class="MsoNormal" style="text-align: center;">
                                <span lang="AZ-LATIN" style="font-size: 12.0pt; mso-ansi-language: AZ-LATIN"><a class="aucun" href="Istetdiyitedbirtehlil.aspx?islem=rayon5&tarix1=<%= lblgelme3.Text %>&tarix2=<%= lblgetme3.Text %>&tarix3=<%= lblgelme4.Text %>&tarix4=<%= lblgetme4.Text %>&siralama1=<%= lblsira.Text %>&userkod=<%= lblkurator.Text %>&rayonkod=<%= lblrayon.Text %>" style="text-decoration: none;">
                                    <asp:Label ID="lblmesele" runat="server"></asp:Label>
                                </a></span>
                            </p>
                        </td>--%>
                        <td style="width: 2.75in; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 17.25pt" valign="top" width="264">
                            <p align="center" class="MsoNormal" style="text-align: center;">
                                <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">&nbsp;</span>
                                <span lang="AZ-LATIN" style="font-size: 12.0pt; mso-ansi-language: AZ-LATIN">
                                    <asp:Label ID="lblfmetn0" runat="server"></asp:Label>
                                </span>
                            </p>
                        </td>
                        <td style="width: 43.6pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 17.25pt"
                            valign="top" width="58">
                            <p align="center" class="MsoNormal" style="text-align: center;">
                                <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">&nbsp;</span>
                            </p>

                        </td>
                    </tr>



                    <asp:Repeater ID="DataList1" runat="server">
                        <ItemTemplate>
                            <tr style="mso-yfti-irow: 4; mso-yfti-lastrow: yes">
                                <td style="width: 29.25pt; border: solid windowtext 1.0pt; border-top: none; mso-border-top-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt"
                                    valign="top" width="39">
                                    <p align="center" class="MsoNormal" style="text-align: center;">
                                        <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">
                                            <%#Container.ItemIndex+1 %>.</span>
                                    </p>
                                </td>
                                <td style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                                    valign="top" class="auto-style12">
                                    <p align="center" class="MsoNormal" style="text-align: left">
                                        <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">
                                            <o:p>
                     <%#Eval("Username")%></o:p>
                                        </span>
                                    </p>
                                </td>
                                <td style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                                    valign="top" class="auto-style15">
                                    <p align="center" class="MsoNormal" style="text-align: center;">
                                        <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN"><%#Eval("rynsay")%></span>
                                    </p>

                                </td>
                                <td style="width: 98.85pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt"
                                    valign="top" width="132">
                                    <p align="center" class="MsoNormal" style="text-align: left">
                                        <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">

                                            <%#Eval("Name")%></span>
                                        </span>
                                    </p>

                                </td>
<%--                                <td style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                                    valign="top" class="auto-style18">
                                    <p align="center" class="MsoNormal" style="text-align: center;">
                                        <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">

                                            <a class="aucun" style="text-decoration: none;" href='Istetdiyitedbirtehlil.aspx?userkod=<%#lblkurator.Text%>&rayonkod=<%#lblrayon.Text%>&ParticipationID=<%#Eval("ParticipationID")%>&islem=rayon5&tarix1=<%#lblgelme1.Text%>&tarix2=<%#lblgetme1.Text%>&tarix3=<%#lblgelme.Text%>&tarix4=<%#lblgetme.Text%>&siralama1=<%#lblsira.Text%>'>
                                                <%#Eval("meqsedumumi")%>
                                            </a>
                                        </span>
                                    </p>
                                </td>--%>
                                <td style="border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; width: 162.15pt;" valign="top" width="216">
                                    <p align="center" class="MsoNormal" style="text-align: left;">
                                        <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN"><%#Eval("ParticipationOther")%></span>
                                    </p>
                                </td>
                                <td style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                                    valign="top" class="auto-style20">
                                    <p align="center" class="MsoNormal" style="text-align: center;">
                                        <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">
                                            <a class="aucun" href='Istetdiyitedbirtehlil.aspx?userkod=<%#lblkurator.Text%>&rayonkod=<%#lblrayon.Text%>&ParticipationID=<%#Eval("ParticipationID")%>&UserID=<%#Eval("UserID")%>&islem=rayon5&RegionID=<%#Eval("RegionID")%>&tarix1=<%#lblgelme1.Text%>&tarix2=<%#lblgetme1.Text%>&tarix3=<%#lblgelme.Text%>&tarix4=<%#lblgetme.Text%>' style="text-decoration: none;"><%#Eval("tedbir")%></a></span>
                                    </p>
                                </td>
<%--                                <td style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;" valign="top" class="auto-style11">
                                    <p align="center" class="MsoNormal" style="text-align: center;">
                                        <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">
                                            <a class="aucun" href='Istetdiyitedbirtehlil.aspx?userkod=<%#lblkurator.Text%>&rayonkod=<%#lblrayon.Text%>&DiscussedID=<%#Eval("DiscussedID")%>&islem=rayon5&tarix1=<%#lblgelme1.Text%>&tarix2=<%#lblgetme1.Text%>&tarix3=<%#lblgelme.Text%>&tarix4=<%#lblgetme.Text%>&siralama1=<%#lblsira.Text%>' style="text-decoration: none;">
                                             <%#Eval("umumimesele")%> </a>

                                        </span>
                                    </p>
                                </td>--%>
                                <td style="border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; width: 2.75in;" valign="top" width="264">
                                    <p align="center" class="MsoNormal" style="text-align: left">
                                        <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN"><%#Eval("DiscussedOther")%></span>
                                    </p>
                                </td>
                                <td style="width: 43.6pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt" valign="top" width="58">
                                    <p align="center" class="MsoNormal" style="text-align: center">
                                        <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">

                                            <a class="aucun" href='Istetdiyitedbirtehlil.aspx?userkod=<%#lblkurator.Text%>&amp;rayonkod=<%#lblrayon.Text%>&amp;ParticipationID=<%#Eval("ParticipationID")%>&amp;DiscussedID=<%#Eval("DiscussedID")%>&amp;UserID=<%#Eval("UserID")%>&amp;islem=rayon5&amp;RegionID=<%#Eval("RegionID")%>&amp;tarix1=<%#lblgelme1.Text%>&amp;tarix2=<%#lblgetme1.Text%>&amp;tarix3=<%#lblgelme.Text%>&amp;tarix4=<%#lblgetme.Text%>&amp;siralama1=<%#lblsira.Text%>' style="text-decoration: none;"><%#Eval("mesele")%></a>
                                           
                                        </span>
                                    </p>
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </table>




            </div>



        </asp:Panel>

    </asp:Panel>
    <div class="temizle"></div>



    <asp:Panel ID="pnlbirinci" Visible="false" runat="server">

                <asp:Button ID="exele0" runat="server" Text="Wordə çıxart" OnClick="exele0_Click" Width="120px" />
        <br />
        <br />

    
              <asp:Panel ID="pnlprint" runat="server">
            <table border="1" cellpadding="0" cellspacing="0" class="auto-style22" style="mso-table-layout-alt: fixed; mso-border-alt: solid windowtext .5pt; mso-yfti-tbllook: 1184; mso-padding-alt: 0in 5.4pt 0in 5.4pt; mso-border-insideh: .5pt solid windowtext; mso-border-insidev: .5pt solid windowtext; width: 1015px;">
                <tr style="mso-yfti-irow: 0; mso-yfti-firstrow: yes; height: 55.2pt">
                    <td style="width: 67.5pt; border: solid windowtext 1.0pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 55.2pt"
                        valign="center" width="90">
                        <p align="center" class="MsoNormal">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">Kurator</span>
                        </p>
                    </td>
                    <td style="width: 81.0pt; border: solid windowtext 1.0pt; border-left: none; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 55.2pt"
                        valign="center" width="108">
                        <p align="center" class="MsoNormal">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">Getdiyi rayonların, şəhərlərin adı</span>
                        </p>
                    </td>
                    <td style="width: 1.0in; border: solid windowtext 1.0pt; border-left: none; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 55.2pt"
                        valign="center" width="96">
                        <p align="center" class="MsoNormal">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">Şəhərə və rayona gəlmə tarixi<b style="mso-bidi-font-weight: normal"><sup></sup></b></span>
                        </p>
                    </td>
                    <td style="width: 1.0in; border: solid windowtext 1.0pt; border-left: none; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 55.2pt"
                        valign="center" width="96">
                        <p align="center" class="MsoNormal">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">Şəhərdən və rayondan getmə tarixi<b style="mso-bidi-font-weight: normal"><sup></sup></b></span>
                        </p>
                    </td>
                    <td style="width: 103.5pt; border: solid windowtext 1.0pt; border-left: none; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 55.2pt"
                        valign="center" width="138">
                        <p align="center" class="MsoNormal">
                            <strong><span lang="RU" style="font-size: 11.0pt; font-family: Arial; color: #141823; background: white; font-weight: normal; mso-bidi-font-weight: bold">İştirak etdiyi tədbirlər</span></strong><b style="mso-bidi-font-weight: normal"><span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN"></span></b>
                        </p>
                    </td>
                    <td style="width: 1.5in; border: solid windowtext 1.0pt; border-left: none; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 55.2pt"
                        valign="center" width="144">
                        <p align="center" class="MsoNormal">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">Müzakirə olunan məsələlər<b style="mso-bidi-font-weight: normal"><sup></sup></b></span>
                        </p>
                    </td>
                <%--    <td style="width: 85.5pt; border: solid windowtext 1.0pt; border-left: none; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 55.2pt"
                        valign="center" width="114">
                        <p align="center" class="MsoNormal">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">Görülmüş işlər</span>
                        </p>
                    </td>
                    <td style="width: 94.5pt; border: solid windowtext 1.0pt; border-left: none; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 55.2pt"
                        valign="center" width="126">
                        <p align="center" class="MsoNormal">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">Əldə olunan nəticə</span>
                        </p>
                    </td>--%>
                    <asp:Panel ID="pnlbaxiw0" runat="server">
                        <td style="width: 67.5pt; border: solid windowtext 1.0pt; border-left: none; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 55.2pt"
                            valign="center" width="90">
                            <p align="center" class="MsoNormal">
                                <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">Baxış<b style="mso-bidi-font-weight: normal"><sup></sup></b></span>
                            </p>
                        </td>
                    </asp:Panel>
                </tr>
                <asp:Repeater ID="DataList3" runat="server">
                    <ItemTemplate>
                        <tr style="mso-yfti-irow: 1; mso-yfti-lastrow: yes; height: 17.25pt">
                            <td style="width: 67.5pt; border: solid windowtext 1.0pt; border-top: none; mso-border-top-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 17.25pt"
                                valign="top" width="90">
                                <p align="left" class="MsoNormal">
                                    <%#Eval("username") %>
                                </p>
                            </td>
                            <td style="width: 81.0pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 17.25pt"
                                valign="top" width="108">
                                <p align="left" class="MsoNormal">
                                    <%#Eval("Name") %><span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN"></span>
                                </p>
                            </td>
                            <td style="width: 1.0in; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 17.25pt"
                                valign="top" width="96">
                                <p align="center" class="MsoNormal">
                                    <%#Class2.sozukes(Eval("RegionCome").ToString()) %>
                                </p>
                            </td>
                            <td style="width: 1.0in; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 17.25pt"
                                valign="top" width="96">
                                <p align="center" class="MsoNormal">
                                    <%#Class2.sozukes(Eval("GoFromRegion").ToString()) %>
                                </p>
                            </td>
                            <td style="width: 103.5pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 17.25pt"
                                valign="top" width="138">
                                <p align="left" class="MsoNormal">
                                    <%#Eval("ParticipationOther") %>
                                </p>
                            </td>
                            <td style="width: 1.5in; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 17.25pt"
                                valign="top" width="144">
                                <p align="left" class="MsoNormal">
                                    <%#Eval("DiscussedOther") %>
                                </p>
                            </td>
                           <%-- <td style="width: 85.5pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 17.25pt"
                                valign="top" width="114">
                                <p align="left" class="MsoNormal">
                                    <%#Eval("WorkView") %>
                                </p>
                            </td>
                            <td style="width: 94.5pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 17.25pt"
                                valign="top" width="126">
                                <p align="left" class="MsoNormal">
                                    <%#Eval("ResultView") %>
                                </p>
                            </td>--%>
                            <asp:Panel ID="pnlbaxiw1" runat="server">
                                <td style="width: 67.5pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 17.25pt"
                                    valign="top" width="90">
                                    <p align="center" class="MsoNormal">
                                        <a href='ezamiyye.aspx?BusinessTripID=<%#Eval("BusinessTripID") %>&islem1=ezmeqtehlil&RegionID=<%#Eval("RegionID") %>&controlBusinesTrip=1&UserID=<%#Eval("UserID") %>'>Baxış</a>
                                    </p>
                                </td>
                            </asp:Panel>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
                  </asp:Panel>




    </asp:Panel>

    <div class="temizle"></div>

    <%-- <asp:Panel ID="pnlikinci" Visible="false" runat="server">
        <div>
            <table style="border-collapse: collapse; width: 100%;">
                <tr>
                    <td style="border-style: solid solid none solid; border-width: 1px 1px 0px 1px; border-color: black; text-align: center; width: 20%; white-space: normal;"><strong>Getdiyi rayonların, şəhərlərin adı</strong></td>
                    <td style="border-style: solid solid none solid; border-width: 1px 1px 0px 1px; border-color: black; text-align: center; width: 20%; white-space: normal;"><strong>Şəhərə və rayona gəlmə tarixi</strong></td>
                    <td style="border-style: solid solid none solid; border-width: 1px 1px 0px 1px; border-color: black; text-align: center; width: 20%; white-space: normal;"><strong>Şəhərdən və rayondan getmə tarixi</strong></td>
                    <td style="border-style: solid solid none solid; border-width: 1px 1px 0px 1px; border-color: black; text-align: center; width: 15%; white-space: normal;"><strong>İştirak etdiyi tədbirlər</strong></td>
                    <td style="border-style: solid solid none solid; border-width: 1px 1px 0px 1px; border-color: black; text-align: center; width: 20%; white-space: normal;"><strong>Müzakirə olunmuş məsələlər</strong></td>

                </tr>
            </table>
            <div class="temizle"></div>

            <table style="border-collapse: collapse; width: 100%;">
                <asp:Repeater ID="rpmesele" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td style="border: 1px solid black; padding-left: 7px; text-align: left; width: 20%; white-space: normal;"><%#Eval("Regions") %></td>
                            <td style="border: 1px solid black; padding-left: 7px; text-align: center; width: 20%; white-space: normal;">
                                <%#Class2.sozukes(Eval("RegionCome").ToString()) %>   </td>
                            <td style="border: 1px solid black; text-align: center; width: 20%; white-space: normal;">
                                <%#Class2.sozukes(Eval("GoFromRegion").ToString()) %></td>
                            <td style="border: 1px solid black; padding-left: 7px; width: 15%; white-space: normal;">
                                <%#Eval("ParticipationOther") %></td>
                            <td style="border: 1px solid black; padding-left: 7px; width: 20%; white-space: normal;">
                                <%#Eval("DiscussedOther") %></td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
        </div>
    </asp:Panel>--%>


    <br />


    <asp:Label ID="lblgelme3" runat="server" Visible="False"></asp:Label>
    <asp:Label ID="lblgetme3" runat="server" Visible="False"></asp:Label>

    <asp:Label ID="lblgelme4" runat="server" Visible="False"></asp:Label>
    <asp:Label ID="lblgetme4" runat="server" Visible="False"></asp:Label>

    <asp:Label ID="lblkurator" runat="server" Visible="False"></asp:Label>

    <asp:Label ID="lblrayon" runat="server" Visible="False"></asp:Label>




</asp:Content>

