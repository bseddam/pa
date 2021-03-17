<%@ Page Title="" Language="C#" MasterPageFile="~/adminpanel/adminMasterPage.master" AutoEventWireup="true" CodeFile="Ferdisohbettehlil.aspx.cs" Inherits="adminpanel_Ferdisohbettehlil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        p.MsoNormal {
            margin-bottom: .0001pt;
            font-size: 12.0pt;
            font-family: "Arial","sans-serif";
            margin-left: 0in;
            margin-right: 0in;
            margin-top: 0in;
        }

        table.MsoNormalTable {
            font-size: 12.0pt;
            font-family: "Calibri","sans-serif";
        }

        .auto-style1 {
            width: 100%;
        }

        .auto-style2 {
            width: 828px;
        }

        .auto-style4 {
            height: 15.75pt;
            }
        .auto-style5 {
            height: 38.8pt;
            width: 127px;
        }
        .auto-style6 {
            height: 17.25pt;
            width: 127px;
        }
        .auto-style7 {
            width: 127px;
        }
        .auto-style8 {
            height: 15.75pt;
            width: 68pt;
        }
        .auto-style9 {
            height: 17.25pt;
            width: 68pt;
        }
        .auto-style10 {
            width: 68pt;
        }
        .auto-style12 {
            width: 9%;
        }
        .auto-style13 {
            height: 38.8pt;
            width: 120pt;
        }
        .auto-style14 {
            height: 17.25pt;
            width: 120pt;
        }
        .auto-style15 {
            width: 120pt;
        }
        .auto-style16 {
            height: 15.75pt;
            width: 77pt;
        }
        .auto-style17 {
            height: 17.25pt;
            width: 77pt;
        }
        .auto-style18 {
            width: 77pt;
        }
        .auto-style19 {
            height: 38.8pt;
            width: 164pt;
        }
        .auto-style20 {
            height: 17.25pt;
            width: 164pt;
        }
        .auto-style21 {
            width: 164pt;
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

            <div style="float: left; width: 346px; padding-top: 10px; height: 236px;">
                Rayon:&nbsp;&nbsp;
            <asp:DropDownList ID="ddlryn" runat="server">
            </asp:DropDownList>
                <br />
                <br />
                İcra orqanı:&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddlsahe" runat="server" OnSelectedIndexChanged="ddlsahe_SelectedIndexChanged" AutoPostBack="True">
            </asp:DropDownList>
                <br />
                <br />
                Vəzifəsi:
            <asp:DropDownList ID="ddlteyinat" runat="server">
            </asp:DropDownList>
                <br />
                <br />
                Sıralama:
            <asp:DropDownList ID="ddlsiralama" runat="server">
                <asp:ListItem Value="1">Şəhər və rayonlar üzrə</asp:ListItem>
                <asp:ListItem Value="2">İcra orqanı üzrə</asp:ListItem>
                <asp:ListItem Value="3">Vəzifə üzrə</asp:ListItem>
            </asp:DropDownList>
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Axtar" Width="120px" />


                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="exele" runat="server" OnClick="exele_Click" Text="Wordə çıxart" Visible="False" Width="120px" />


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
                <b style="mso-bidi-font-weight: normal"><span lang="AZ-LATIN" style="mso-ansi-language: AZ-LATIN">Şöbə əməkdaşlarının ezamiyyətlərdə söhbət aparılmış kadrlar  
barədə məlumat
                    <o:p></o:p>
                </span></b>
            </p>
            <p class="MsoNormal" style="text-align: justify">
                <span lang="AZ-LATIN" style="mso-ansi-language: AZ-LATIN">
                    <o:p>
        &nbsp;</o:p>
                </span>
            </p>
            <table border="1" cellpadding="0" cellspacing="0" class="MsoNormalTable" style="border-style: none; border-color: inherit; border-width: medium; border-collapse: collapse; mso-table-layout-alt: fixed; mso-border-alt: solid windowtext .5pt; mso-yfti-tbllook: 1184; mso-padding-alt: 0in 5.4pt 0in 5.4pt; mso-border-insideh: .5pt solid windowtext; mso-border-insidev: .5pt solid windowtext; width: 1013px;">
                <tr style="mso-yfti-irow: 0; mso-yfti-firstrow: yes">
                    <td rowspan="3" style="width: 29.05pt; border: solid windowtext 1.0pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt"
                        valign="center" width="39">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">S/n<o:p></o:p></span>
                        </p>
                    </td>
                    <td rowspan="3" style="border-right: 1.0pt solid windowtext; border-top: 1.0pt solid windowtext; border-bottom: 1.0pt solid windowtext; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium;"
                        valign="center" class="auto-style12">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">Adı, soyadı</span></p>
                    </td>
                    <td colspan="8" style="width: 616.85pt; border: solid windowtext 1.0pt; border-left: none; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt"
                        valign="center" width="822">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                                <o:p>
                     <asp:Label ID="lblgelme2" runat="server" Text=""></asp:Label>
                    -
                    <asp:Label ID="lblgetme2" runat="server" Text=""></asp:Label></o:p>
                            </span>
                        </p>
                    </td>
                </tr>
                <tr style="mso-yfti-irow: 1; height: 15.75pt">
                    <td rowspan="2" style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                        valign="center" class="auto-style8">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">Şəhər və rayonlara ezamiyyətlərin sayı<o:p></o:p></span>
                        </p>
                       
                    </td>
                    <td rowspan="2" style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                        valign="center" class="auto-style16">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">Şəhər, rayon<o:p></o:p></span>
                        </p>
                    </td>
                    <td style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                        valign="center" class="auto-style4" colspan="6">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">Söhbət aparılmış kadrlar</span></p>
                    </td>
                </tr>
                <tr style="mso-yfti-irow: 2; height: 38.8pt">
                    <td style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                        valign="center" class="auto-style5">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">İcra orqanı</span></p></td>
                    <td style="width: 78.2pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 38.8pt" valign="center" width="104">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">Vəzifəsi</span></p>
                    </td>
                    <td style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                        valign="center" class="auto-style13">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">Adı və soyadı<b style="mso-bidi-font-weight: normal"><sup><o:p></o:p></sup></b></span>
                        </p>
                    </td>
                    <td style="width: 106.2pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 38.8pt"
                        valign="center" width="142">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">Vəzifəyə uyğunluğu (hə/yox)</span></p>
                    </td>
                    <td style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                        valign="center" class="auto-style19">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">Təklif</span></p>
                    </td>
                    <td style="width: 177.4pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 38.8pt" valign="center" width="237">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">Baxış</span></p>
                    </td>
                </tr>
                <tr style="mso-yfti-irow: 3; height: 17.25pt">
                    <td colspan="2" style="border-left: 1.0pt solid windowtext; border-right: 1.0pt solid windowtext; border-bottom: 1.0pt solid windowtext; mso-border-top-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 17.25pt; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                        valign="center">
                        <p align="right" class="MsoNormal" style="text-align: right">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">Cəmi</span><span style="font-size: 11.0pt; mso-ansi-language: EN-US">:<b style="mso-bidi-font-weight: normal"><sup><o:p></o:p></sup></b></span>
                        </p>
                    </td>
                    <td style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                        valign="center" class="auto-style9">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">
                                <o:p>
                    &nbsp;<asp:Label ID="lblezamsay" runat="server"></asp:Label> </o:p>
                            </span>
                        </p>
                    </td>
                    <td style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                        valign="center" class="auto-style17">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">
                                <o:p>
                    &nbsp;<asp:Label ID="lblfreg" runat="server"></asp:Label>
                            </o:p>
                            </span>
                        </p>
                    </td>
                    <td style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                        valign="center" class="auto-style6">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <asp:Label ID="lblsaheler" runat="server"></asp:Label>
                        </p>
                    </td>
                    <td style="width: 78.2pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 17.25pt" valign="center" width="104">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">
                                 <asp:Label ID="lblteyuzre" runat="server"></asp:Label>
                            </span>
                        </p>
                    </td>
                    <td style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                        valign="center" class="auto-style14">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">
                                <o:p>
                    &nbsp;</o:p>
                            </span>
                        </p>
                    </td>
                    <td style="width: 106.2pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 17.25pt"
                        valign="center" width="142">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">
                                <o:p>
                    &nbsp;</o:p>
                            </span>
                        </p>
                    </td>
                    <td class="auto-style20" style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;" valign="center">&nbsp;</td>
                    <td style="width: 177.4pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 17.25pt"
                        valign="center" width="237">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">
                                <o:p>
                    &nbsp;</o:p>
                            </span>
                        </p>
                    </td>
                </tr>


                <asp:Repeater ID="DataList1" runat="server">
                    <ItemTemplate>

                        <tr style="mso-yfti-irow: 4">
                            <td style="width: 29.05pt; border: solid windowtext 1.0pt; border-top: none; mso-border-top-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt"
                                valign="center" width="39">
                                <p align="center" class="MsoNormal" style="text-align: center">
                                    <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">
                                        <o:p>
                     <%#Container.ItemIndex+1 %>.</o:p>
                                    </span>
                                </p>
                            </td>
                            <td style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                                valign="center" class="auto-style12">
                                <p align="center" class="MsoNormal" style="text-align: left">
                                    <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">
                                        <o:p>
                    <%#Eval("Username")%></o:p>
                                    </span>
                                </p>
                            </td>
                            <td style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                                valign="center" class="auto-style10">
                                <p align="center" class="MsoNormal" style="text-align: center">
                                    <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">
                                        <o:p>
                     <%#Eval("rynsay")%></o:p>
                                    </span>
                                </p>
                            </td>
                            <td style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                                valign="center" class="auto-style18">
                                <p align="center" class="MsoNormal" style="text-align: left">
                                    <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">
                                        <o:p>
                    <%#Eval("Name")%></o:p>
                                    </span>
                                </p>
                            </td>
                            <td style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                                valign="center" class="auto-style7">
                               <p align="center" class="MsoNormal" style="text-align: left">
                                    <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">
                                        <%#Eval("FramesOther")%>
                                    </span>
                                </p></td>
                            <td style="width: 78.2pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt" valign="center" width="104">
                                <p align="center" class="MsoNormal" style="text-align: left">
                                    <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">
                                        <%#Eval("Sub_FramesOther")%>
                                    </span>
                                </p>
                            </td>
                            <td style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                                valign="center" class="auto-style15">
                                <p align="center" class="MsoNormal" style="text-align: left">
                                    <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">
                                        <o:p>
                     <%#Eval("name1")%></o:p>
                                    </span>
                                </p>
                            </td>
                            <td style="width: 106.2pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt"
                                valign="center" width="142">
                                <p align="center" class="MsoNormal" style="text-align: center">
                                    <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">
                                        <o:p>
                    <%#Eval("Yes_No")%></o:p>
                                    </span>
                                </p>
                            </td>
                            <td class="auto-style21" style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;" valign="center">
                                <p align="center" class="MsoNormal" style="text-align: left">
                                    <%#Eval("TextNote")%></p>
                            </td>
                            <td style="width: 177.4pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt"
                                valign="center" width="237">
        <p align="center" class="MsoNormal" style="text-align:center;">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">
                   <a href="ezamiyye.aspx?BusinessTripID=<%#Eval("BusinessTripID") %>&islem1=ferdisohbet&RegionID=<%#Eval("RegionID") %>&controlBusinesTrip=1&UserID=<%#Eval("UserID") %>">Baxış</a></span></p>

                            </td>
                        </tr>

                    </ItemTemplate>
                </asp:Repeater>


            </table>

        </asp:Panel>
    </asp:Panel>
    <br />



    <br />
            <asp:Label ID="lblgelme3" runat="server" Visible="False"></asp:Label>
            <asp:Label ID="lblgetme3" runat="server" Visible="False"></asp:Label>
            <asp:Label ID="lblgelme4" runat="server" Visible="False"></asp:Label>
            <asp:Label ID="lblgetme4" runat="server" Visible="False"></asp:Label>
            <asp:Label ID="lblkurator" runat="server" Visible="False"></asp:Label>
            <asp:Label ID="lblrayon" runat="server" Visible="False"></asp:Label>
            <asp:Label ID="lblmesage" runat="server" Visible="False"></asp:Label>
            <asp:Label ID="lblgelme1" runat="server" Visible="False"></asp:Label>
            <asp:Label ID="lblgetme1" runat="server" Visible="False"></asp:Label>
            <asp:Label ID="lblsira" runat="server" Visible="False"></asp:Label>
            <asp:Label ID="lblsahe" runat="server" Visible="False"></asp:Label>
            <asp:Label ID="lblteyinat" runat="server" Visible="False"></asp:Label>
   
  

</asp:Content>

