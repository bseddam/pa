<%@ Page Title="" Language="C#" MasterPageFile="~/adminpanel/adminMasterPage.master" AutoEventWireup="true" CodeFile="Muddetlertehlil.aspx.cs" Inherits="adminpanel_Muddetlertehlil" %>

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
            font-size: 12.0pt;
            font-family: "Arial","sans-serif";
            margin-left: 0in;
            margin-right: 0in;
            margin-top: 0in;
        }

        .auto-style4 {
            width: 769.05pt;
            border-collapse: collapse;
            font-size: 11.0pt;
            font-family: Calibri, sans-serif;
            border-style: none;
            border-color: inherit;
            border-width: medium;
        }

        .auto-style5 {
            width: 764pt;
            border-collapse: collapse;
            font-size: 11.0pt;
            font-family: Calibri, sans-serif;
            border-style: none;
            border-color: inherit;
            border-width: medium;
            margin-left: 0;
        }
        .auto-style6 {
            border-collapse: collapse;
            font-size: 11.0pt;
            font-family: Calibri, sans-serif;
            border-style: none;
            border-color: inherit;
            border-width: medium;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

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

    <asp:Panel ID="Panel1" runat="server">
        <div>

            <div>
                &nbsp;
            </div>


            <div style="float: left; width: 284px; white-space: normal;">
                <strong>Şəhərə və rayona gəlmə tarixi:&nbsp; </strong>
                <asp:ImageButton ID="ImageButton7" runat="server" Height="23px" ImageUrl="~/images/calendar-icon.png" OnClick="ImageButton1_Click" Width="23px" />
            </div>
            <div style="float: left; width: 313px; white-space: normal;">
                <strong>Şəhərdən və rayondan getmə tarixi:&nbsp;
            <asp:ImageButton ID="ImageButton6" runat="server" Height="23px" ImageUrl="~/images/calendar-icon.png" OnClick="ImageButton3_Click" Width="23px" />
                </strong>
            </div>


            <div style="float: right; width: 405px; height: 226px;">

                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Axtar" Width="120px" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="exele" runat="server" OnClick="exele_Click" Text="Wordə çıxart" Width="120px" />
                &nbsp;&nbsp;<br />
                <br />
                <br />
                <asp:Label ID="lblmesage" runat="server" Text=""></asp:Label>
                <br />
                <br />
            </div>
            <br />
            <br />
            <div style="float: left; width: 284px; height: 193px;">
                <asp:Label ID="lblgelme" runat="server" Text=""></asp:Label>
                <asp:ImageButton ID="imgbsilgelme" runat="server" Height="14px" OnClick="imgbsilgelme_Click" src="images/iconlar/sil.png" Visible="False" Width="14px" />
                <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#999999" CellSpacing="1" DayNameFormat="Shortest" Font-Names="Arial" Font-Size="9pt" ForeColor="Black" Height="180px" OnSelectionChanged="Calendar1_SelectionChanged" Visible="false" Width="213px">
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
            <div style="float: left; width: 316px; height: 193px;">
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


        </div>


        <div class="temizle"></div>


        <asp:Panel ID="pnlprint" runat="server">
            <p align="center" class="MsoNormal">
                <b style="mso-bidi-font-weight: normal"><span lang="AZ-LATIN" style="mso-ansi-language: AZ-LATIN">Şöbə əməkdaşlarının ezamiyyətlərdə olduqları müddətlər barədə məlumat
                </span></b>

            </p>
            <p align="center" class="MsoNormal">
                <br />
                <table cellpadding="0" cellspacing="0" class="auto-style4" style="mso-border-alt: solid windowtext .5pt; mso-yfti-tbllook: 1184; mso-padding-alt: 0in 5.4pt 0in 5.4pt; mso-border-insideh: .5pt solid windowtext; mso-border-insidev: .5pt solid windowtext" width="1025">
                    <tr style="mso-yfti-irow: 0; mso-yfti-firstrow: yes; height: 14.55pt">
                        <td rowspan="2" style="width: 29.15pt; border: solid windowtext 1.0pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 14.55pt"
                            valign="top" width="39">
                            <p align="center" class="MsoNormal">
                                <span lang="AZ-LATIN" style="mso-ansi-language: AZ-LATIN">S/n</span>
                            </p>
                        </td>
                        <td rowspan="2" style="width: 81.1pt; border: solid windowtext 1.0pt; border-left: none; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 14.55pt"
                            valign="top" width="108">
                            <p align="center" class="MsoNormal">
                                <span lang="AZ-LATIN" style="mso-ansi-language: AZ-LATIN">Adı, soyadı</span>
                            </p>
                        </td>
                        <td colspan="13" style="width: 658.65pt; border: solid windowtext 1.0pt; border-left: none; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 14.55pt"
                            valign="top" width="878">
                            <p align="center" class="MsoNormal">
                                <span lang="AZ-LATIN" style="mso-ansi-language: AZ-LATIN">
                                    <asp:Label ID="lblgelme2" runat="server" Text=""></asp:Label>
                                    -
                                 <asp:Label ID="lblgetme2" runat="server" Text=""></asp:Label>
                                </span>
                            </p>
                        </td>
                    </tr>
                    <tr style="mso-yfti-irow: 1; height: 7.65pt">
                        <td style="width: 66.55pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 7.65pt"
                            valign="top" width="89">
                            <p align="center" class="MsoNormal">
                                <span lang="AZ-LATIN" style="mso-ansi-language: AZ-LATIN">Cəmi (gün/fərq)</span>
                            </p>
                        </td>
                        <td style="width: 49.3pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 7.65pt"
                            valign="top" width="66">
                            <p align="center" class="MsoNormal">
                                <span lang="AZ-LATIN" style="mso-ansi-language: AZ-LATIN">yanvar (gün)</span>
                            </p>
                        </td>
                        <td style="width: 48.4pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 7.65pt"
                            valign="top" width="65">
                            <p align="center" class="MsoNormal">
                                <span lang="AZ-LATIN" style="mso-ansi-language: AZ-LATIN">fevral (gün)</span>
                            </p>
                        </td>
                        <td style="width: 48.1pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 7.65pt"
                            valign="top" width="64">
                            <p align="center" class="MsoNormal">
                                <span lang="AZ-LATIN" style="mso-ansi-language: AZ-LATIN">mart (gün)</span>
                            </p>
                        </td>
                        <td style="width: 48.25pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 7.65pt"
                            valign="top" width="64">
                            <p align="center" class="MsoNormal">
                                <span lang="AZ-LATIN" style="mso-ansi-language: AZ-LATIN">aprel (gün)</span>
                            </p>
                        </td>
                        <td style="width: 48.05pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 7.65pt"
                            valign="top" width="64">
                            <p align="center" class="MsoNormal">
                                <span lang="AZ-LATIN" style="mso-ansi-language: AZ-LATIN">may (gün)</span>
                            </p>
                        </td>
                        <td style="width: 48.0pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 7.65pt"
                            valign="top" width="64">
                            <p align="center" class="MsoNormal">
                                <span lang="AZ-LATIN" style="mso-ansi-language: AZ-LATIN">iyun (gün)</span>
                            </p>
                        </td>
                        <td style="width: 47.85pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 7.65pt"
                            valign="top" width="64">
                            <p align="center" class="MsoNormal">
                                <span lang="AZ-LATIN" style="mso-ansi-language: AZ-LATIN">iyul (gün)</span>
                            </p>
                        </td>
                        <td style="width: 49.15pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 7.65pt"
                            valign="top" width="66">
                            <p align="center" class="MsoNormal">
                                <span lang="AZ-LATIN" style="mso-ansi-language: AZ-LATIN">avqust (gün)</span>
                            </p>
                        </td>
                        <td style="width: 56.2pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 7.65pt"
                            valign="top" width="75">
                            <p align="center" class="MsoNormal">
                                <span lang="AZ-LATIN" style="mso-ansi-language: AZ-LATIN">sentyabr (gün)</span>
                            </p>
                        </td>
                        <td style="width: 50.0pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 7.65pt"
                            valign="top" width="67">
                            <p align="center" class="MsoNormal">
                                <span lang="AZ-LATIN" style="mso-ansi-language: AZ-LATIN">oktyabr (gün)</span>
                            </p>
                        </td>
                        <td style="width: 49.45pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 7.65pt"
                            valign="top" width="66">
                            <p align="center" class="MsoNormal">
                                <span lang="AZ-LATIN" style="mso-ansi-language: AZ-LATIN">noyabr (gün)</span>
                            </p>
                        </td>
                        <td style="width: 49.45pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 7.65pt"
                            valign="top" width="66">
                            <p align="center" class="MsoNormal">
                                <span lang="AZ-LATIN" style="mso-ansi-language: AZ-LATIN">dekabr (gün)</span>
                            </p>
                        </td>
                    </tr>
                    <tr style="mso-yfti-irow: 2; height: 13.95pt">
                        <td colspan="2" style="width: 110.3pt; border: solid windowtext 1.0pt; border-top: none; mso-border-top-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 13.95pt"
                            valign="top" width="147">
                            <p align="right" class="MsoNormal">
                                <span lang="AZ-LATIN" style="mso-ansi-language: AZ-LATIN">Cəmi:</span>
                            </p>
                        </td>
                        <td style="width: 66.55pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 13.95pt"
                            valign="top" width="89">
                            <p align="center" class="MsoNormal">
                                &nbsp;
                            </p>
                        </td>
                        <td style="width: 49.3pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 13.95pt"
                            valign="top" width="66">
                            <p align="center" class="MsoNormal">
                                &nbsp;
                            </p>
                        </td>
                        <td style="width: 48.4pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 13.95pt"
                            valign="top" width="65">
                            <p align="center" class="MsoNormal">
                                &nbsp;
                            </p>
                        </td>
                        <td style="width: 48.1pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 13.95pt"
                            valign="top" width="64">
                            <p align="center" class="MsoNormal">
                                &nbsp;
                            </p>
                        </td>
                        <td style="width: 48.25pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 13.95pt"
                            valign="top" width="64">
                            <p align="center" class="MsoNormal">
                                &nbsp;
                            </p>
                        </td>
                        <td style="width: 48.05pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 13.95pt"
                            valign="top" width="64">
                            <p align="center" class="MsoNormal">
                                &nbsp;
                            </p>
                        </td>
                        <td style="width: 48.0pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 13.95pt"
                            valign="top" width="64">
                            <p align="center" class="MsoNormal">
                                &nbsp;
                            </p>
                        </td>
                        <td style="width: 47.85pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 13.95pt"
                            valign="top" width="64">
                            <p align="center" class="MsoNormal">
                                &nbsp;
                            </p>
                        </td>
                        <td style="width: 49.15pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 13.95pt"
                            valign="top" width="66">
                            <p align="center" class="MsoNormal">
                                &nbsp;
                            </p>
                        </td>
                        <td style="width: 56.2pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 13.95pt"
                            valign="top" width="75">
                            <p align="center" class="MsoNormal">
                                &nbsp;
                            </p>
                        </td>
                        <td style="width: 50.0pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 13.95pt"
                            valign="top" width="67">
                            <p align="center" class="MsoNormal">
                                &nbsp;
                            </p>
                        </td>
                        <td style="width: 49.45pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 13.95pt"
                            valign="top" width="66">
                            <p align="center" class="MsoNormal">
                                &nbsp;
                            </p>
                        </td>
                        <td style="width: 49.45pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 13.95pt"
                            valign="top" width="66">
                            <p align="center" class="MsoNormal">
                                &nbsp;
                            </p>
                        </td>
                    </tr>
                    <asp:Repeater ID="DataList1" runat="server">
                        <ItemTemplate>
                            <tr style="mso-yfti-irow: 3; mso-yfti-lastrow: yes; height: 14.55pt">
                                <td style="width: 29.15pt; border: solid windowtext 1.0pt; border-top: none; mso-border-top-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 14.55pt"
                                    valign="top" width="39">
                                    <p align="center" class="MsoNormal">
                                        <%#Container.ItemIndex+1 %>.
                                    </p>
                                </td>
                                <td style="width: 81.1pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 14.55pt"
                                    valign="top" width="108">
                                    <p align="left" class="MsoNormal">
                                        <a class="aucun" style="text-decoration: none;" href='Muddetlertehlil.aspx?UserID=<%#Eval("UserID") %>&amp;islem=userler&amp;tarix1=<%#lblgelme1.Text%>&amp;tarix2=<%#lblgetme1.Text%>&amp;tarix3=<%#lblgelme.Text%>&amp;tarix4=<%#lblgetme.Text%>'><%#Eval("Name") %></a>
                                    </p>
                                </td>
                                <td style="width: 66.55pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 14.55pt"
                                    valign="top" width="89">
                                    <p align="center" class="MsoNormal">
                                        <%#Eval("cemi")%>
                                    </p>
                                </td>
                                <td style="width: 49.3pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 14.55pt"
                                    valign="top" width="66">
                                    <p align="center" class="MsoNormal">
                                        <a class="aucun" style="text-decoration: none;" href='Muddetlertehlil.aspx?UserID=<%#Eval("UserID") %>&islem=01&tarix1=<%#lblgelme1.Text%>&tarix2=<%#lblgetme1.Text%>&tarix3=<%#lblgelme.Text%>tarix4=<%#lblgetme.Text%>'>

                                            <asp:Label ID="Label1" runat="server" ForeColor='<%#System.Drawing.Color.FromName(Class2.reng(Eval("Yanvar").ToString()))%>' Text='<%#kesiki(Eval("Yanvar").ToString())%>'></asp:Label>
                                        </a>
                                    </p>
                                </td>
                                <td style="width: 48.4pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 14.55pt"
                                    valign="top" width="65">
                                    <p align="center" class="MsoNormal">
                                        <a class="aucun" style="text-decoration: none;" href='Muddetlertehlil.aspx?UserID=<%#Eval("UserID") %>&islem=02&tarix1=<%#lblgelme1.Text%>&tarix2=<%#lblgetme1.Text%>&tarix3=<%#lblgelme.Text%>tarix4=<%#lblgetme.Text%>'>


                                            <asp:Label ID="Label2" runat="server" ForeColor='<%#System.Drawing.Color.FromName(Class2.reng(Eval("Fevral").ToString()))%>' Text='<%#kesiki(Eval("Fevral").ToString())%>'></asp:Label>
                                        </a>
                                    </p>
                                </td>
                                <td style="width: 48.1pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 14.55pt"
                                    valign="top" width="64">
                                    <p align="center" class="MsoNormal">
                                        <a class="aucun" style="text-decoration: none;" href='Muddetlertehlil.aspx?UserID=<%#Eval("UserID") %>&islem=03&tarix1=<%#lblgelme1.Text%>&tarix2=<%#lblgetme1.Text%>&tarix3=<%#lblgelme.Text%>tarix4=<%#lblgetme.Text%>'>

                                            <asp:Label ID="Label3" runat="server" ForeColor='<%#System.Drawing.Color.FromName(Class2.reng(Eval("Mart").ToString()))%>' Text='<%#kesiki(Eval("Mart").ToString())%>'></asp:Label>
                                        </a>
                                    </p>
                                </td>
                                <td style="width: 48.25pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 14.55pt"
                                    valign="top" width="64">
                                    <p align="center" class="MsoNormal">
                                        <a class="aucun" style="text-decoration: none;" href='Muddetlertehlil.aspx?UserID=<%#Eval("UserID") %>&islem=04&tarix1=<%#lblgelme1.Text%>&tarix2=<%#lblgetme1.Text%>&tarix3=<%#lblgelme.Text%>tarix4=<%#lblgetme.Text%>'>

                                            <asp:Label ID="Label4" runat="server" ForeColor='<%#System.Drawing.Color.FromName(Class2.reng(Eval("Aprel").ToString()))%>' Text='<%#kesiki(Eval("Aprel").ToString())%>'></asp:Label>
                                        </a>
                                    </p>
                                </td>
                                <td style="width: 48.05pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 14.55pt"
                                    valign="top" width="64">
                                    <p align="center" class="MsoNormal">
                                        <span lang="AZ-LATIN" style="mso-ansi-language: AZ-LATIN">
                                            <a class="aucun" style="text-decoration: none;" href='Muddetlertehlil.aspx?UserID=<%#Eval("UserID") %>&islem=05&tarix1=<%#lblgelme1.Text%>&tarix2=<%#lblgetme1.Text%>&tarix3=<%#lblgelme.Text%>tarix4=<%#lblgetme.Text%>'>

                                                <asp:Label ID="Label5" runat="server" ForeColor='<%#System.Drawing.Color.FromName(Class2.reng(Eval("May").ToString()))%>' Text='<%#kesiki(Eval("May").ToString())%>'></asp:Label>
                                            </a>
                                        </span>
                                    </p>
                                </td>
                                <td style="width: 48.0pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 14.55pt"
                                    valign="top" width="64">
                                    <p align="center" class="MsoNormal">
                                        <span lang="AZ-LATIN" style="mso-ansi-language: AZ-LATIN">
                                            <a class="aucun" style="text-decoration: none;" href='Muddetlertehlil.aspx?UserID=<%#Eval("UserID") %>&islem=06&tarix1=<%#lblgelme1.Text%>&tarix2=<%#lblgetme1.Text%>&tarix3=<%#lblgelme.Text%>tarix4=<%#lblgetme.Text%>'>

                                                <asp:Label ID="Label13" runat="server" ForeColor='<%#System.Drawing.Color.FromName(Class2.reng(Eval("İyun").ToString()))%>' Text='<%#kesiki(Eval("İyun").ToString())%>'></asp:Label>
                                            </a>

                                        </span>
                                    </p>
                                </td>
                                <td style="width: 47.85pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 14.55pt"
                                    valign="top" width="64">
                                    <p align="center" class="MsoNormal">
                                        <span lang="AZ-LATIN" style="mso-ansi-language: AZ-LATIN">
                                            <a class="aucun" style="text-decoration: none;" href='Muddetlertehlil.aspx?UserID=<%#Eval("UserID") %>&islem=07&tarix1=<%#lblgelme1.Text%>&tarix2=<%#lblgetme1.Text%>&tarix3=<%#lblgelme.Text%>tarix4=<%#lblgetme.Text%>'>

                                                <asp:Label ID="Label14" runat="server" ForeColor='<%#System.Drawing.Color.FromName(Class2.reng(Eval("İyul").ToString()))%>' Text='<%#kesiki(Eval("İyul").ToString())%>'></asp:Label>

                                            </a></span>
                                    </p>
                                </td>
                                <td style="width: 49.15pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 14.55pt"
                                    valign="top" width="66">
                                    <p align="center" class="MsoNormal">
                                        <span lang="AZ-LATIN" style="mso-ansi-language: AZ-LATIN">
                                            <a class="aucun" style="text-decoration: none;" href='Muddetlertehlil.aspx?UserID=<%#Eval("UserID") %>&islem=08&tarix1=<%#lblgelme1.Text%>&tarix2=<%#lblgetme1.Text%>&tarix3=<%#lblgelme.Text%>tarix4=<%#lblgetme.Text%>'>

                                                <asp:Label ID="Label15" runat="server" ForeColor='<%#System.Drawing.Color.FromName(Class2.reng(Eval("Avqust").ToString()))%>' Text='<%#kesiki(Eval("Avqust").ToString())%>'></asp:Label>
                                            </a></span>
                                    </p>
                                </td>
                                <td style="width: 56.2pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 14.55pt"
                                    valign="top" width="75">
                                    <p align="center" class="MsoNormal">
                                        <span lang="AZ-LATIN" style="mso-ansi-language: AZ-LATIN">
                                            <a class="aucun" style="text-decoration: none;" href='Muddetlertehlil.aspx?UserID=<%#Eval("UserID") %>&islem=09&tarix1=<%#lblgelme1.Text%>&tarix2=<%#lblgetme1.Text%>&tarix3=<%#lblgelme.Text%>tarix4=<%#lblgetme.Text%>'>

                                                <asp:Label ID="Label16" runat="server" ForeColor='<%#System.Drawing.Color.FromName(Class2.reng(Eval("Sentyabr").ToString()))%>' Text='<%#kesiki(Eval("Sentyabr").ToString())%>'></asp:Label>

                                            </a></span>
                                    </p>
                                </td>
                                <td style="width: 50.0pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 14.55pt"
                                    valign="top" width="67">
                                    <p align="center" class="MsoNormal">
                                        <span lang="AZ-LATIN" style="mso-ansi-language: AZ-LATIN">
                                            <a class="aucun" style="text-decoration: none;" href='Muddetlertehlil.aspx?UserID=<%#Eval("UserID") %>&islem=10&tarix1=<%#lblgelme1.Text%>&tarix2=<%#lblgetme1.Text%>&tarix3=<%#lblgelme.Text%>tarix4=<%#lblgetme.Text%>'>

                                                <asp:Label ID="Label17" runat="server" ForeColor='<%#System.Drawing.Color.FromName(Class2.reng(Eval("Oktyabr").ToString()))%>' Text='<%#kesiki(Eval("Oktyabr").ToString())%>'></asp:Label>
                                            </a>
                                        </span>
                                    </p>
                                </td>
                                <td style="width: 49.45pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 14.55pt"
                                    valign="top" width="66">
                                    <p align="center" class="MsoNormal">
                                        <span lang="AZ-LATIN" style="mso-ansi-language: AZ-LATIN">
                                            <a class="aucun" style="text-decoration:none;" href='Muddetlertehlil.aspx?UserID=<%#Eval("UserID") %>&islem=11&tarix1=<%#lblgelme1.Text%>&tarix2=<%#lblgetme1.Text%>&tarix3=<%#lblgelme.Text%>tarix4=<%#lblgetme.Text%>'>

                                                <asp:Label ID="Label18" runat="server" ForeColor='<%#System.Drawing.Color.FromName(Class2.reng(Eval("Noyabr").ToString()))%>' Text='<%#kesiki(Eval("Noyabr").ToString())%>'></asp:Label>
                                            </a>
                                        </span>
                                    </p>
                                </td>
                                <td style="width: 49.45pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 14.55pt"
                                    valign="top" width="66">
                                    <p align="center" class="MsoNormal">
                                        <span lang="AZ-LATIN" style="mso-ansi-language: AZ-LATIN">
                                            <a class="aucun" style="text-decoration:none;" href='Muddetlertehlil.aspx?UserID=<%#Eval("UserID") %>&islem=12&tarix1=<%#lblgelme1.Text%>&tarix2=<%#lblgetme1.Text%>&tarix3=<%#lblgelme.Text%>tarix4=<%#lblgetme.Text%>'>

                                                <asp:Label ID="Label19" runat="server" ForeColor='<%#System.Drawing.Color.FromName(Class2.reng(Eval("Dekabr").ToString()))%>' Text='<%#kesiki(Eval("Dekabr").ToString())%>'></asp:Label>
                                            </a>
                                        </span>
                                    </p>
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </table>
            </p>
        </asp:Panel>
    </asp:Panel>






    <asp:Panel ID="Panel2" runat="server">


        <table border="1" cellpadding="0" cellspacing="0" class="auto-style5" style="mso-border-alt: solid windowtext .5pt; mso-yfti-tbllook: 1184; mso-padding-alt: 0in 5.4pt 0in 5.4pt; mso-border-insideh: .5pt solid windowtext; mso-border-insidev: .5pt solid windowtext">
            <tr style="mso-yfti-irow: 0; mso-yfti-firstrow: yes; height: 7.65pt">
                <td style="width: 66.5pt; border: solid windowtext 1.0pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 7.65pt"
                    valign="top" width="89">
                    <p align="center" class="MsoNormal">
                        <span lang="AZ-LATIN" style="mso-ansi-language: AZ-LATIN">Kurator</span>
                    </p>
                </td>
                <td style="width: 66.5pt; border: solid windowtext 1.0pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 7.65pt"
                    valign="top" width="89">
                    <p align="center" class="MsoNormal">
                        <span lang="AZ-LATIN" style="mso-ansi-language: AZ-LATIN">Rayon</span>
                    </p>
                </td>
                <td style="width: 49.3pt; border: solid windowtext 1.0pt; border-left: none; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 7.65pt"
                    valign="top" width="66">
                    <p align="center" class="MsoNormal">
                        <span lang="AZ-LATIN" style="mso-ansi-language: AZ-LATIN">yanvar (gün)</span>
                    </p>
                </td>
                <td style="width: 48.35pt; border: solid windowtext 1.0pt; border-left: none; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 7.65pt"
                    valign="top" width="64">
                    <p align="center" class="MsoNormal">
                        <span lang="AZ-LATIN" style="mso-ansi-language: AZ-LATIN">fevral (gün)</span>
                    </p>
                </td>
                <td style="width: 48.0pt; border: solid windowtext 1.0pt; border-left: none; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 7.65pt"
                    valign="top" width="64">
                    <p align="center" class="MsoNormal">
                        <span lang="AZ-LATIN" style="mso-ansi-language: AZ-LATIN">mart (gün)</span>
                    </p>
                </td>
                <td style="width: 48.15pt; border: solid windowtext 1.0pt; border-left: none; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 7.65pt"
                    valign="top" width="64">
                    <p align="center" class="MsoNormal">
                        <span lang="AZ-LATIN" style="mso-ansi-language: AZ-LATIN">aprel (gün)</span>
                    </p>
                </td>
                <td style="width: 47.95pt; border: solid windowtext 1.0pt; border-left: none; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 7.65pt"
                    valign="top" width="64">
                    <p align="center" class="MsoNormal">
                        <span lang="AZ-LATIN" style="mso-ansi-language: AZ-LATIN">may (gün)</span>
                    </p>
                </td>
                <td style="width: 47.9pt; border: solid windowtext 1.0pt; border-left: none; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 7.65pt"
                    valign="top" width="64">
                    <p align="center" class="MsoNormal">
                        <span lang="AZ-LATIN" style="mso-ansi-language: AZ-LATIN">iyun (gün)</span>
                    </p>
                </td>
                <td style="width: 47.8pt; border: solid windowtext 1.0pt; border-left: none; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 7.65pt"
                    valign="top" width="64">
                    <p align="center" class="MsoNormal">
                        <span lang="AZ-LATIN" style="mso-ansi-language: AZ-LATIN">iyul (gün)</span>
                    </p>
                </td>
                <td style="width: 49.15pt; border: solid windowtext 1.0pt; border-left: none; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 7.65pt"
                    valign="top" width="66">
                    <p align="center" class="MsoNormal">
                        <span lang="AZ-LATIN" style="mso-ansi-language: AZ-LATIN">avqust (gün)</span>
                    </p>
                </td>
                <td style="width: 56.85pt; border: solid windowtext 1.0pt; border-left: none; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 7.65pt"
                    valign="top" width="76">
                    <p align="center" class="MsoNormal">
                        <span lang="AZ-LATIN" style="mso-ansi-language: AZ-LATIN">sentyabr (gün)</span>
                    </p>
                </td>
                <td style="width: 50.2pt; border: solid windowtext 1.0pt; border-left: none; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 7.65pt"
                    valign="top" width="67">
                    <p align="center" class="MsoNormal">
                        <span lang="AZ-LATIN" style="mso-ansi-language: AZ-LATIN">oktyabr (gün)</span>
                    </p>
                </td>
                <td style="width: 49.45pt; border: solid windowtext 1.0pt; border-left: none; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 7.65pt"
                    valign="top" width="66">
                    <p align="center" class="MsoNormal">
                        <span lang="AZ-LATIN" style="mso-ansi-language: AZ-LATIN">noyabr (gün)</span>
                    </p>
                </td>
                <td style="width: 49.45pt; border: solid windowtext 1.0pt; border-left: none; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 7.65pt"
                    valign="top" width="66">
                    <p align="center" class="MsoNormal">
                        <span lang="AZ-LATIN" style="mso-ansi-language: AZ-LATIN">dekabr (gün)</span>
                    </p>
                </td>
            </tr>




            <asp:Repeater ID="DataList2" runat="server">
                <ItemTemplate>
                    <tr style="mso-yfti-irow: 1; height: 13.95pt">
                        <td style="width: 66.5pt; border: solid windowtext 1.0pt; border-top: none; mso-border-top-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 13.95pt"
                            valign="top" width="89">
                            <p align="left" class="MsoNormal">
                                <%#Eval("Name") %>
                            </p>
                        </td>
                        <td style="width: 66.5pt; border: solid windowtext 1.0pt; border-top: none; mso-border-top-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 13.95pt"
                            valign="top" width="89">
                            <p align="left" class="MsoNormal">
                                <%#Eval("region") %>
                            </p>
                        </td>
                        <td style="width: 49.3pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 13.95pt"
                            valign="top" width="66">
                            <p align="center" class="MsoNormal">

                                <a class="aucun" style="text-decoration:none;" href='Muddetlertehlil.aspx?UserID=<%#Eval("UserID") %>&RegionID=<%#Eval("RegionID") %>&islem=01&tarix1=<%#lblgelme1.Text%>&tarix2=<%#lblgetme1.Text%>&tarix3=<%#lblgelme.Text%>tarix4=<%#lblgetme.Text%>'>
                                    <asp:Label ID="Label1" runat="server" ForeColor='<%#System.Drawing.Color.FromName(Class2.reng(Eval("Yanvar").ToString()))%>' Text='<%#Eval("Yanvar").ToString()%>'></asp:Label>
                                </a>


                            </p>
                        </td>
                        <td style="width: 48.35pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 13.95pt"
                            valign="top" width="64">
                            <p align="center" class="MsoNormal">
                                <a class="aucun" style="text-decoration:none;" href='Muddetlertehlil.aspx?UserID=<%#Eval("UserID")%>&RegionID=<%#Eval("RegionID") %>&islem=02&tarix1=<%#lblgelme1.Text%>&tarix2=<%#lblgetme1.Text%>&tarix3=<%#lblgelme.Text%>tarix4=<%#lblgetme.Text%>'>

                                    <asp:Label ID="Label2" runat="server" ForeColor='<%#System.Drawing.Color.FromName(Class2.reng(Eval("Fevral").ToString()))%>' Text='<%#Eval("Fevral").ToString()%>'></asp:Label>
                                </a>
                            </p>
                        </td>
                        <td style="width: 48.0pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 13.95pt"
                            valign="top" width="64">
                            <p align="center" class="MsoNormal">
                                <a class="aucun" style="text-decoration:none;" href='Muddetlertehlil.aspx?UserID=<%#Eval("UserID") %>&RegionID=<%#Eval("RegionID") %>&islem=03&tarix1=<%#lblgelme1.Text%>&tarix2=<%#lblgetme1.Text%>&tarix3=<%#lblgelme.Text%>tarix4=<%#lblgetme.Text%>'>

                                    <asp:Label ID="Label3" runat="server" ForeColor='<%#System.Drawing.Color.FromName(Class2.reng(Eval("Mart").ToString()))%>' Text='<%#Eval("Mart").ToString()%>'></asp:Label>
                                </a>
                            </p>
                        </td>
                        <td style="width: 48.15pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 13.95pt"
                            valign="top" width="64">
                            <p align="center" class="MsoNormal">
                                <a class="aucun" style="text-decoration:none;" href='Muddetlertehlil.aspx?UserID=<%#Eval("UserID") %>&RegionID=<%#Eval("RegionID") %>&islem=04&tarix1=<%#lblgelme1.Text%>&tarix2=<%#lblgetme1.Text%>&tarix3=<%#lblgelme.Text%>tarix4=<%#lblgetme.Text%>'>

                                    <asp:Label ID="Label4" runat="server" ForeColor='<%#System.Drawing.Color.FromName(Class2.reng(Eval("Aprel").ToString()))%>' Text='<%#Eval("Aprel").ToString()%>'></asp:Label>
                                </a>
                            </p>
                        </td>
                        <td style="width: 47.95pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 13.95pt"
                            valign="top" width="64">
                            <p align="center" class="MsoNormal">
                                <a class="aucun" style="text-decoration:none;" href='Muddetlertehlil.aspx?UserID=<%#Eval("UserID") %>&RegionID=<%#Eval("RegionID") %>&islem=05&tarix1=<%#lblgelme1.Text%>&tarix2=<%#lblgetme1.Text%>&tarix3=<%#lblgelme.Text%>tarix4=<%#lblgetme.Text%>'>

                                    <asp:Label ID="Label5" runat="server" ForeColor='<%#System.Drawing.Color.FromName(Class2.reng(Eval("May").ToString()))%>' Text='<%#Eval("May").ToString()%>'></asp:Label>
                                </a>
                            </p>
                        </td>
                        <td style="width: 47.9pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 13.95pt"
                            valign="top" width="64">
                            <p align="center" class="MsoNormal">
                                <a class="aucun" style="text-decoration:none;" href='Muddetlertehlil.aspx?UserID=<%#Eval("UserID") %>&RegionID=<%#Eval("RegionID") %>&islem=06&tarix1=<%#lblgelme1.Text%>&tarix2=<%#lblgetme1.Text%>&tarix3=<%#lblgelme.Text%>tarix4=<%#lblgetme.Text%>'>

                                    <asp:Label ID="Label6" runat="server" ForeColor='<%#System.Drawing.Color.FromName(Class2.reng(Eval("İyun").ToString()))%>' Text='<%#Eval("İyun").ToString()%>'></asp:Label>
                                </a>
                            </p>
                        </td>
                        <td style="width: 47.8pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 13.95pt"
                            valign="top" width="64">
                            <p align="center" class="MsoNormal">
                                <a class="aucun" style="text-decoration:none;" href='Muddetlertehlil.aspx?UserID=<%#Eval("UserID") %>&RegionID=<%#Eval("RegionID") %>&islem=07&tarix1=<%#lblgelme1.Text%>&tarix2=<%#lblgetme1.Text%>&tarix3=<%#lblgelme.Text%>tarix4=<%#lblgetme.Text%>'>

                                    <asp:Label ID="Label7" runat="server" ForeColor='<%#System.Drawing.Color.FromName(Class2.reng(Eval("İyul").ToString()))%>' Text='<%#Eval("İyul").ToString()%>'></asp:Label>
                                </a>
                            </p>
                        </td>
                        <td style="width: 49.15pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 13.95pt"
                            valign="top" width="66">
                            <p align="center" class="MsoNormal">
                                <a class="aucun" style="text-decoration:none;" href='Muddetlertehlil.aspx?UserID=<%#Eval("UserID") %>&RegionID=<%#Eval("RegionID") %>&islem=08&tarix1=<%#lblgelme1.Text%>&tarix2=<%#lblgetme1.Text%>&tarix3=<%#lblgelme.Text%>tarix4=<%#lblgetme.Text%>'>

                                    <asp:Label ID="Label8" runat="server" ForeColor='<%#System.Drawing.Color.FromName(Class2.reng(Eval("Avqust").ToString()))%>' Text='<%#Eval("Avqust").ToString()%>'></asp:Label>
                                </a>
                            </p>
                        </td>
                        <td style="width: 56.85pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 13.95pt"
                            valign="top" width="76">
                            <p align="center" class="MsoNormal">
                                <a class="aucun" style="text-decoration:none;" href='Muddetlertehlil.aspx?UserID=<%#Eval("UserID") %>&RegionID=<%#Eval("RegionID") %>&islem=09&tarix1=<%#lblgelme1.Text%>&tarix2=<%#lblgetme1.Text%>&tarix3=<%#lblgelme.Text%>tarix4=<%#lblgetme.Text%>'>

                                    <asp:Label ID="Label9" runat="server" ForeColor='<%#System.Drawing.Color.FromName(Class2.reng(Eval("Sentyabr").ToString()))%>' Text='<%#Eval("Sentyabr").ToString()%>'></asp:Label>
                                </a>
                            </p>
                        </td>
                        <td style="width: 50.2pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 13.95pt"
                            valign="top" width="67">
                            <p align="center" class="MsoNormal">
                                <a class="aucun" style="text-decoration:none;" href='Muddetlertehlil.aspx?UserID=<%#Eval("UserID") %>&RegionID=<%#Eval("RegionID") %>&islem=10&tarix1=<%#lblgelme1.Text%>&tarix2=<%#lblgetme1.Text%>&tarix3=<%#lblgelme.Text%>tarix4=<%#lblgetme.Text%>'>

                                    <asp:Label ID="Label10" runat="server" ForeColor='<%#System.Drawing.Color.FromName(Class2.reng(Eval("Oktyabr").ToString()))%>' Text='<%#Eval("Oktyabr").ToString()%>'></asp:Label>
                                </a>
                            </p>
                        </td>
                        <td style="width: 49.45pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 13.95pt"
                            valign="top" width="66">
                            <p align="center" class="MsoNormal">
                                <a class="aucun" style="text-decoration:none;" href='Muddetlertehlil.aspx?UserID=<%#Eval("UserID") %>&RegionID=<%#Eval("RegionID") %>&islem=11&tarix1=<%#lblgelme1.Text%>&tarix2=<%#lblgetme1.Text%>&tarix3=<%#lblgelme.Text%>tarix4=<%#lblgetme.Text%>'>

                                    <asp:Label ID="Label11" runat="server" ForeColor='<%#System.Drawing.Color.FromName(Class2.reng(Eval("Noyabr").ToString()))%>' Text='<%#Eval("Noyabr").ToString()%>'></asp:Label>
                                </a>
                            </p>
                        </td>
                        <td style="width: 49.45pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 13.95pt"
                            valign="top" width="66">
                            <p align="center" class="MsoNormal">
                                <a class="aucun" style="text-decoration:none;" href='Muddetlertehlil.aspx?UserID=<%#Eval("UserID") %>&RegionID=<%#Eval("RegionID") %>&islem=12&tarix1=<%#lblgelme1.Text%>&tarix2=<%#lblgetme1.Text%>&tarix3=<%#lblgelme.Text%>tarix4=<%#lblgetme.Text%>'>

                                    <asp:Label ID="Label12" runat="server" ForeColor='<%#System.Drawing.Color.FromName(Class2.reng(Eval("Dekabr").ToString()))%>' Text='<%#Eval("Dekabr").ToString()%>'></asp:Label>
                                </a>
                            </p>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>



    </asp:Panel>



    <asp:Panel ID="Panel3" Visible="false" runat="server">


    <p align="center" class="MsoNormal">
        <span lang="AZ-LATIN" style="font-size:12.0pt;mso-bidi-font-family:Arial;mso-ansi-language:AZ-LATIN"><o:p>&nbsp;</o:p></span></p>
    <table border="1" cellpadding="0" cellspacing="0" class="auto-style6" style="mso-table-layout-alt: fixed; mso-border-alt: solid windowtext .5pt; mso-yfti-tbllook: 1184; mso-padding-alt: 0in 5.4pt 0in 5.4pt; mso-border-insideh: .5pt solid windowtext; mso-border-insidev: .5pt solid windowtext; width: 998px;">
        <tr style="mso-yfti-irow:0;mso-yfti-firstrow:yes;height:56.2pt">
            <td style="width:30.85pt;border:solid windowtext 1.0pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:56.2pt" valign="center" width="41">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:12.0pt;mso-bidi-font-family:Arial;mso-ansi-language:
  AZ-LATIN">S/n<o:p></o:p></span></p>
            </td>
            <td style="width:86.85pt;border:solid windowtext 1.0pt;
  border-left:none;mso-border-left-alt:solid windowtext .5pt;mso-border-alt:
  solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:56.2pt" valign="center" width="116">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:12.0pt;mso-ansi-language:AZ-LATIN">Adı, soyadı<o:p></o:p></span></p>
            </td>
            <td style="width:112.4pt;border:solid windowtext 1.0pt;
  border-left:none;mso-border-left-alt:solid windowtext .5pt;mso-border-alt:
  solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:56.2pt" valign="center" width="150">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:12.0pt;mso-bidi-font-family:Arial;mso-ansi-language:
  AZ-LATIN">Şəhər, rayon<b style="mso-bidi-font-weight:normal"><sup><o:p></o:p></sup></b></span></p>
            </td>
            <td style="width:116.8pt;border:solid windowtext 1.0pt;
  border-left:none;mso-border-left-alt:solid windowtext .5pt;mso-border-alt:
  solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:56.2pt" valign="center" width="156">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:12.0pt; mso-bidi-font-family: Arial; color: #141823; background: white; mso-ansi-language: AZ-LATIN">Şəhərə və rayona gəlmə tarixi</span><b style="mso-bidi-font-weight:normal"><sup><span lang="AZ-LATIN" style="font-size:12.0pt;mso-bidi-font-family:Arial;mso-ansi-language:AZ-LATIN"><o:p></o:p></span></sup></b></p>
            </td>
            <td style="width:123.85pt;border:solid windowtext 1.0pt;
  border-left:none;mso-border-left-alt:solid windowtext .5pt;mso-border-alt:
  solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:56.2pt" valign="center" width="165">
                <p align="center" class="MsoNormal">
                    <span style="font-size:12.0pt; mso-bidi-font-family: Arial; color: #141823; background: white; mso-ansi-language: EN-US">Şəhərdən və rayondan getmə tarixi</span><b style="mso-bidi-font-weight:normal"><sup><span style="font-size:12.0pt;
  mso-bidi-font-family:Arial;mso-ansi-language:EN-US"><o:p></o:p></span></sup></b></p>
            </td>
            <td style="width:123.85pt;border:solid windowtext 1.0pt;
  border-left:none;mso-border-left-alt:solid windowtext .5pt;mso-border-alt:
  solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:56.2pt" valign="center" width="165">
                <p align="center" class="MsoNormal">
                    <span style="font-size: 12.0pt; mso-bidi-font-family: Arial; color: #141823; background: white; mso-ansi-language: EN-US">Baxış</span><b style="mso-bidi-font-weight:normal"><sup><span style="font-size:12.0pt;
  mso-bidi-font-family:Arial;mso-ansi-language:EN-US"></span></sup></b></p>
            </td>
        </tr>




        <asp:Repeater ID="rp3" runat="server">
            <ItemTemplate>
        <tr style="mso-yfti-irow:1;mso-yfti-lastrow:yes;height:12.1pt">
            <td style="width:30.85pt;border:solid windowtext 1.0pt;
  border-top:none;mso-border-top-alt:solid windowtext .5pt;mso-border-alt:solid windowtext .5pt;
  padding:0in 5.4pt 0in 5.4pt;height:12.1pt" valign="top" width="41">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:12.0pt;mso-bidi-font-family:Arial;mso-ansi-language:
  AZ-LATIN"><o:p><%#Container.ItemIndex+1 %>.</o:p></span></p>
            </td>
            <td style="width:86.85pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:12.1pt" valign="top" width="116">
                <p align="left" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:12.0pt;mso-bidi-font-family:Arial;mso-ansi-language:
  AZ-LATIN"><o:p><%#Eval("Name")%></o:p></span></p>
            </td>
            <td style="width:112.4pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:12.1pt" valign="top" width="150">
                <p align="left" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:12.0pt;mso-bidi-font-family:Arial;mso-ansi-language:
  AZ-LATIN"><o:p><%#Eval("Regions")%></o:p></span></p>
            </td>
            <td style="width:116.8pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:12.1pt" valign="top" width="156">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:12.0pt;mso-bidi-font-family:Arial;mso-ansi-language:
  AZ-LATIN"><o:p><%#Class2.sozukes(Eval("RegionCome").ToString()) %></o:p></span></p>
            </td>
            <td style="width:123.85pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:12.1pt" valign="top" width="165">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:12.0pt;mso-bidi-font-family:Arial;mso-ansi-language:
  AZ-LATIN"><o:p><%#Class2.sozukes(Eval("GoFromRegion").ToString()) %></o:p></span></p>
            </td>
            <td style="width:123.85pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:12.1pt" valign="top" width="165">
                <p align="center" class="MsoNormal">
                    <a href='ezamiyye.aspx?BusinessTripID=<%#Eval("BusinessTripID") %>&amp;islem1=muddettehlil&amp;RegionID=<%#Eval("RegionID") %>&amp;controlBusinesTrip=1&amp;UserID=<%#Eval("UserID") %>'>Baxış</a></p>
            </td>
        </tr>
                      </ItemTemplate>
        </asp:Repeater>
    </table>


    </asp:Panel>



    <br />
    <asp:Label ID="lblgelme1" Visible="false" runat="server"></asp:Label>
    <asp:Label ID="lblgetme1" Visible="false" runat="server"></asp:Label>

 
                <asp:Label ID="lblgelme3" runat="server" Visible="False"></asp:Label>
                <asp:Label ID="lblgetme3" runat="server" Visible="False"></asp:Label>

                <asp:Label ID="lblgelme4" runat="server" Visible="False"></asp:Label>
                <asp:Label ID="lblgetme4" runat="server" Visible="False"></asp:Label>

                <asp:Label ID="lblkurator" runat="server" Visible="False"></asp:Label>

                <asp:Label ID="lblrayon" runat="server" Visible="False"></asp:Label>
          



</asp:Content>

