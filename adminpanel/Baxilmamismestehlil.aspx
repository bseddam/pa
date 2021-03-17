<%@ Page Title="" Language="C#" MasterPageFile="~/adminpanel/adminMasterPage.master" AutoEventWireup="true" CodeFile="Baxilmamismestehlil.aspx.cs" Inherits="adminpanel_Baxilmamismestehlil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
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
            font-family: Arial,"sans-serif";
        }

        .auto-style1 {
            width: 100%;
        }

        .auto-style2 {
            width: 828px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div runat="server" visible="false">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="btngeri" runat="server" OnClick="btngeri_Click" Text="Geri" Width="150px" />
                </td>
            </tr>
        </table>
    </div>




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
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Axtar" Width="120px" />


        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="exele" runat="server" OnClick="exele_Click" Text="Wordə çıxart" Visible="False" Width="120px" />


        <br />
        <br />
        <asp:Label ID="lblmesage" runat="server" Text=""></asp:Label>
        <asp:Label ID="lblgelme1" runat="server" Visible="False"></asp:Label>
        <asp:Label ID="lblgetme1" runat="server" Visible="False"></asp:Label>
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

    <div class="temizle"></div>
    <asp:Panel ID="Panel1" runat="server">

                          <p align="center" class="MsoNormal" style="text-align:center">
        <b style="mso-bidi-font-weight:
normal"><span lang="AZ-LATIN" style="mso-ansi-language:AZ-LATIN">Şöbə əməkdaşlarının ezamiyyətlərdə baxılmamış, araşdırılmamış məsələlər  
barədə məlumat
<o:p></o:p></span></b></p>


                    <p class="MsoNormal" style="text-align:justify">
        <span lang="AZ-LATIN" style="mso-ansi-language:AZ-LATIN">
        <o:p>
        &nbsp;</o:p></span></p>




        <table border="1" cellpadding="0" cellspacing="0" class="MsoNormalTable" style="border-style: none; border-color: inherit; border-width: medium; border-collapse: collapse; mso-table-layout-alt: fixed; mso-border-alt: solid windowtext .5pt; mso-yfti-tbllook: 1184; mso-padding-alt: 0in 5.4pt 0in 5.4pt; mso-border-insideh: .5pt solid windowtext; mso-border-insidev: .5pt solid windowtext; width: 1016px;">
            <tr style="mso-yfti-irow: 0; mso-yfti-firstrow: yes">
                <td rowspan="2" style="width: 29.0pt; border: solid windowtext 1.0pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt"
                    valign="center" width="39">
                    <p align="center" class="MsoNormal" style="text-align: center">
                        <span lang="AZ-LATIN" style="mso-bidi-font-size: 12.0pt; mso-ansi-language: AZ-LATIN">S/n<o:p></o:p></span>
                    </p>
                </td>
                <td rowspan="2" style="width: 126.4pt; border: solid windowtext 1.0pt; border-left: none; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt"
                    valign="center" width="169">
                    <p align="center" class="MsoNormal" style="text-align: center">
                        <span lang="AZ-LATIN" style="mso-bidi-font-size: 12.0pt; mso-ansi-language: AZ-LATIN">Adı, soyadı</span>
                    </p>
                </td>
                <td colspan="3" style="width: 518.6pt; border: solid windowtext 1.0pt; border-left: none; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt"
                    valign="center" width="691">
                    <p align="center" class="MsoNormal" style="text-align: center">
                        <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                            <asp:Label ID="lblgelme2" runat="server" Text=""></asp:Label>
                            -
                    <asp:Label ID="lblgetme2" runat="server" Text=""></asp:Label>
                        </span>
                    </p>
                </td>
            </tr>
            <tr style="mso-yfti-irow: 1; height: 55.2pt">
                <td style="width: 92.0pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 55.2pt"
                    valign="center" width="123">
                    <p align="center" class="MsoNormal" style="text-align: center">
                        <span lang="AZ-LATIN" style="mso-bidi-font-size: 12.0pt; mso-ansi-language: AZ-LATIN">Şəhər və rayonlara ezamiyyətlərin sayı<o:p></o:p></span>
                    </p>

                </td>
                <td style="width: 149.5pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 55.2pt"
                    valign="center" width="199">
                    <p align="center" class="MsoNormal" style="text-align: center">
                        <span lang="AZ-LATIN" style="mso-bidi-font-size: 12.0pt; mso-ansi-language: AZ-LATIN">Şəhər, rayon<o:p></o:p></span>
                    </p>
                </td>
                <td style="width: 277.1pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 55.2pt"
                    valign="center" width="369">
                    <p align="center" class="MsoNormal" style="text-align: center">
                        <span lang="AZ-LATIN" style="mso-bidi-font-size: 12.0pt; mso-ansi-language: AZ-LATIN">Baxılmamış, araşdırılmamış məsələlər<sup><o:p></o:p></sup></span>
                    </p>
                </td>
            </tr>
            <tr style="mso-yfti-irow: 2; height: 17.25pt">
                <td colspan="2" style="width: 155.4pt; border: solid windowtext 1.0pt; border-top: none; mso-border-top-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 17.25pt"
                    valign="center" width="207">
                    <p align="right" class="MsoNormal" style="text-align: right; width: 263px;">
                        <span lang="AZ-LATIN" style="mso-bidi-font-size: 12.0pt; mso-ansi-language: AZ-LATIN">Cəmi:<b style="mso-bidi-font-weight: normal"><sup><o:p></o:p></sup></b></span>
                    </p>
                </td>
                <td style="width: 92.0pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 17.25pt"
                    valign="center" width="123">
                    <p align="center" class="MsoNormal" style="text-align: center">
                        <span lang="AZ-LATIN" style="mso-bidi-font-size: 12.0pt; mso-ansi-language: AZ-LATIN">
                            <o:p>
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN"><asp:Label runat="server" ID="lblezamsay" Visible="False"></asp:Label> </span></o:p>
                        </span>
                    </p>
                </td>
                <td style="width: 149.5pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 17.25pt"
                    valign="center" width="199">
                    <p align="center" class="MsoNormal" style="text-align: center">
                        <span lang="AZ-LATIN" style="mso-bidi-font-size: 12.0pt; mso-ansi-language: AZ-LATIN">
                            <o:p>
                    &nbsp;</o:p>
                        </span>
                    </p>
                </td>
                <td style="width: 277.1pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 17.25pt"
                    valign="center" width="369">
                    <p align="center" class="MsoNormal" style="text-align: center">
                        <span lang="AZ-LATIN" style="mso-bidi-font-size: 12.0pt; mso-ansi-language: AZ-LATIN">
                            <o:p>
                    &nbsp;</o:p>
                        </span>
                    </p>
                </td>
            </tr>




            <asp:Repeater ID="DataList1" runat="server">
                <ItemTemplate>

                    <tr style="mso-yfti-irow: 3; mso-yfti-lastrow: yes">
                        <td style="width: 29.0pt; border: solid windowtext 1.0pt; border-top: none; mso-border-top-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt"
                            valign="center" width="39">
                            <p align="center" class="MsoNormal" style="text-align: center">
                                <span lang="AZ-LATIN" style="mso-bidi-font-size: 12.0pt; mso-ansi-language: AZ-LATIN">
                                    <o:p>
                     <%#Container.ItemIndex+1 %>.</o:p>
                                </span>
                            </p>
                        </td>
                        <td style="width: 126.4pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt"
                            valign="center" width="169">
                            <p align="center" class="MsoNormal" style="text-align: left">
                                <span lang="AZ-LATIN" style="mso-bidi-font-size: 12.0pt; mso-ansi-language: AZ-LATIN">
                                    <o:p>
                    <%#Eval("Username")%></o:p>
                                </span>
                            </p>
                        </td>
                        <td style="width: 92.0pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt"
                            valign="center" width="123">
                            <p align="center" class="MsoNormal" style="text-align: center">
                                <span lang="AZ-LATIN" style="mso-bidi-font-size: 12.0pt; mso-ansi-language: AZ-LATIN">
                                    <o:p>
                     <%#Eval("rynsay")%></o:p>
                                </span>
                            </p>
                        </td>
                        <td style="width: 149.5pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt"
                            valign="center" width="199">
                            <p align="center" class="MsoNormal" style="text-align: left">
                                <span lang="AZ-LATIN" style="mso-bidi-font-size: 12.0pt; mso-ansi-language: AZ-LATIN">
                                    <o:p>
                    <%#Eval("Name")%></o:p>
                                </span>
                            </p>
                        </td>
                        <td style="width: 277.1pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt"
                            valign="center" width="369">
                            <p align="center" class="MsoNormal" style="text-align: left">
                                <span lang="AZ-LATIN" style="mso-bidi-font-size: 12.0pt; mso-ansi-language: AZ-LATIN">
                                    <o:p>
                     <%#Eval("ClassifName")%></o:p>
                                </span>
                            </p>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
    </asp:Panel>
</asp:Content>

