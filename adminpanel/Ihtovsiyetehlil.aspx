<%@ Page Title="" Language="C#" MasterPageFile="~/adminpanel/adminMasterPage.master" AutoEventWireup="true" CodeFile="Ihtovsiyetehlil.aspx.cs" Inherits="adminpanel_İhtovsiyetehlil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        p.MsoNormal
        {
            margin-bottom: .0001pt;
            font-size: 12.0pt;
            font-family: "Arial","sans-serif";
            margin-left: 0in;
            margin-right: 0in;
            margin-top: 0in;
        }

        table.MsoNormalTable
        {
            font-size: 12.0pt;
            font-family: "Arial","sans-serif";
        }

        .auto-style1x
        {
            width: 100%;
        }

        .auto-style2x
        {
            width: 828px;
        }

        .auto-style9
        {
            width: 114pt;
        }

        .auto-style10
        {
            height: 15.75pt;
            width: 116pt;
        }

        .auto-style13
        {
            height: 17.25pt;
            width: 103pt;
        }

        .auto-style14
        {
            width: 103pt;
        }

        .auto-style15
        {
            height: 38.8pt;
            width: 74pt;
        }

        .auto-style16
        {
            height: 17.25pt;
            width: 394pt;
        }

        .auto-style17
        {
            width: 74pt;
        }

        .auto-style18
        {
            height: 38.8pt;
            width: 50pt;
        }

        .auto-style19
        {
            height: 17.25pt;
            width: 50pt;
        }

        .auto-style20
        {
            width: 50pt;
        }

        .auto-style23
        {
            width: 308pt;
        }
        .auto-style24 {
            width: 78pt;
        }
        .auto-style25 {
            height: 15.75pt;
            width: 103pt;
        }
        .auto-style26 {
            height: 38.8pt;
            width: 308pt;
        }
        .auto-style27 {
            height: 17.25pt;
            width: 308pt;
        }
        .auto-style28 {
            height: 38.8pt;
            width: 394pt;
        }
        .auto-style29 {
            width: 394pt;
        }
        .auto-style30 {
            height: 38.8pt;
            width: 401pt;
        }
        .auto-style31 {
            height: 17.25pt;
            width: 401pt;
        }
        .auto-style32 {
            width: 401pt;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">



     <div id="Div1" runat="server" visible="false">
        <table class="auto-style1x">
            <tr>
                <td class="auto-style2x">&nbsp;</td>
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
                İcrası barədə qeyd:
            <asp:DropDownList ID="ddlicrabarqeyd" runat="server">
                <asp:ListItem Value="0">Ümumi</asp:ListItem>
                <asp:ListItem Value="3">İcra olunub</asp:ListItem>
                <asp:ListItem Value="2">Nəzarətdədir</asp:ListItem>
            </asp:DropDownList>
                <br />
                <br />
                <asp:RadioButton ID="rdrayon" runat="server" Checked="True" GroupName="A" Text="Şəhər və rayonlar üzrə" />
                <br />
                <asp:RadioButton ID="rdmeqsed" runat="server" GroupName="A" Text="Məsələ üzrə" />
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
                <b style="mso-bidi-font-weight: normal"><span lang="AZ-LATIN" style="mso-ansi-language: AZ-LATIN">Şöbə əməkdaşlarının ezamiyyətlərdə verdikləri tövsiyyə və təkliflər barədə məlumat
               
                </span></b>
            </p>
 <br />

            <table border="1" cellpadding="0" cellspacing="0" class="MsoNormalTable" style="border-style: none; border-color: inherit; border-width: medium; border-collapse: collapse; mso-table-layout-alt: fixed; mso-border-alt: solid windowtext .5pt; mso-yfti-tbllook: 1184; mso-padding-alt: 0in 5.4pt 0in 5.4pt; mso-border-insideh: .5pt solid windowtext; mso-border-insidev: .5pt solid windowtext; width: 1019px;">
                <tr style="mso-yfti-irow: 0; mso-yfti-firstrow: yes">
                    <td rowspan="3" style="width: 29.0pt; border: solid windowtext 1.0pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt"
                        valign="center" width="39">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">S/n<o:p></o:p></span>
                        </p>
                    </td>
                    <td rowspan="3" style="border-right: 1.0pt solid windowtext; border-top: 1.0pt solid windowtext; border-bottom: 1.0pt solid windowtext; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium;"
                        valign="center" class="auto-style24">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">Adı, soyadı</span></p>
                    </td>
                    <td colspan="7" style="border-right: 1.0pt solid windowtext; border-top: 1.0pt solid windowtext; border-bottom: 1.0pt solid windowtext; width: 1668px; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium;"
                        valign="center">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                                <asp:Label ID="lblgelme2" runat="server" Text=""></asp:Label>
                                -
                    <asp:Label ID="lblgetme2" runat="server" Text=""></asp:Label>
                                <o:p></o:p>
                            </span>
                        </p>
                    </td>
                </tr>
                <tr style="mso-yfti-irow: 1; height: 15.75pt">
                    <td rowspan="2" style="width: 76.5pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 15.75pt"
                        valign="center" width="102">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">Şəhər və rayonlara ezamiyyətlərin sayı<o:p></o:p></span>
                        </p>
                    </td>
                    <td rowspan="2" style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                        valign="center" class="auto-style25">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">Şəhər, rayon</span></p>
                    </td>
                    <td style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 15.75pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                        valign="center" colspan="3">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">Verilmiş tövsiyə və təkliflər</span>
                        </p>
                    </td>
                    <td colspan="2" style="width: 279.0pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 15.75pt"
                        valign="center" width="372">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">Tövsiyələrlə bağlı görülmüş işlər</span>
                        </p>
                    </td>
                </tr>
                <tr style="mso-yfti-irow: 2; height: 38.8pt">
                    <%--            <td style="border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;" valign="center" class="auto-style18">
                <p align="center" class="MsoNormal" style="text-align:center">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-bidi-font-family:Arial;mso-ansi-language:
  AZ-LATIN">Cəmi sayı</span></p>
            </td>--%>
                    <td class="auto-style26" style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                        valign="center">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">Məsələlər</span></p>
                    </td>
                    <td class="auto-style18" style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                        valign="center">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">Sayı</span></p>
                    </td>
                    <td style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                        valign="center" class="auto-style30">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">Mətn</span></p>
                    </td>
                    <td style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                        valign="center" class="auto-style30">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">İcrası barədə qeyd</span></p>
                    </td>
                    <td style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                        valign="center" class="auto-style15">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">Tarix</span></p>
                    </td>

                </tr>
                <tr style="mso-yfti-irow: 3; height: 17.25pt">
                    <td colspan="2" style="border-left: 1.0pt solid windowtext; border-right: 1.0pt solid windowtext; border-bottom: 1.0pt solid windowtext; mso-border-top-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 17.25pt; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                        valign="center">
                        <p align="right" class="MsoNormal" style="text-align: right">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">Cəmi:</span>
                        </p>
                    </td>
                    <td style="width: 76.5pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 17.25pt"
                        valign="center" width="102">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                                <o:p>
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN"><asp:Label ID="lblezamsay" runat="server"></asp:Label> </span></o:p>
                            </span>
                        </p>
                    </td>
                    <td style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                        valign="center" class="auto-style13">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                                <o:p>
                    <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN"><asp:Label ID="lblfreg" runat="server"></asp:Label> 
                            </span>
                        </o:p>
                            </span>
                        </p>
                    </td>
                    <%--            <td style="border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;" valign="center" class="auto-style19">
                                       <p align="center" class="MsoNormal" style="text-align: center;">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">
                         <a class="aucun" style="text-decoration:none;" href='Ihtovsiyetehlil.aspx?islem=rayon5&tarix1=<%= lblgelme3.Text %>&tarix2=<%= lblgetme3.Text %>&tarix3=<%= lblgelme4.Text %>&tarix4=<%= lblgetme4.Text %>&siralama1=<%= lblsira.Text %>&userkod=<%= lblkurator.Text %>&rayonkod=<%= lblrayon.Text %>'> 
       <asp:Label ID="lblcemmeq" runat="server"></asp:Label></a>
                            </span>
                        </p></td>--%>
                    <td class="auto-style27" style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                        valign="center">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN"><span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">
                                <asp:Label ID="lblfmetn" runat="server"></asp:Label>
                            </span></span>
                        </p>
                    </td>
                    <td class="auto-style19" style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                        valign="center">&nbsp;</td>
                    <td style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                        valign="center" class="auto-style31">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                                <o:p>
                    &nbsp;</o:p>
                            </span>
                        </p>
                    </td>
                    <td style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                        valign="center" class="auto-style31">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                                <o:p>
                    &nbsp;</o:p>
                            </span>
                        </p>
                    </td>
                    <td style="width: 100pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 17.25pt"
                        valign="center" width="270">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                                <o:p>
                    &nbsp;</o:p>
                            </span>
                        </p>
                    </td>
                </tr>





                <asp:Repeater ID="DataList1" runat="server">
                    <ItemTemplate>
                        <tr style="mso-yfti-irow: 4; mso-yfti-lastrow: yes">
                            <td style="width: 29.0pt; border: solid windowtext 1.0pt; border-top: none; mso-border-top-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt"
                                valign="top" width="39">
                                <p align="center" class="MsoNormal" style="text-align: center">
                                    <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                                        <o:p>
                    <%#Container.ItemIndex+1 %>.</o:p>
                                    </span>
                                </p>
                            </td>
                            <td style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                                valign="top" class="auto-style24">
                                <p align="center" class="MsoNormal" style="text-align: left">
                                    <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                                        <o:p>
                    <%#Eval("Username")%></o:p>
                                    </span>
                                </p>
                            </td>
                            <td style="width: 76.5pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt"
                                valign="top" width="102">
                                <p align="center" class="MsoNormal" style="text-align: center">
                                    <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                                        <o:p>
                    <%#Eval("rynsay")%></o:p>
                                    </span>
                                </p>
                            </td>
                            <td style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                                valign="top" class="auto-style14">
                                <p align="center" class="MsoNormal" style="text-align: left">
                                    <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                                        <o:p>
                    <%#Eval("Name")%></o:p>
                                    </span>
                                </p>
                            </td>
                            <%--            <td style="border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;text-align:center;border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;" valign="top" class="auto-style20">
                 <o:p>
                       <p align="center" class="MsoNormal" style="text-align:center;font-size:11.0pt;"> 
                       <a class="aucun" style="text-decoration:none;" href='Ihtovsiyetehlil.aspx?userkod=<%#lblkurator.Text%>&rayonkod=<%#lblrayon.Text%>&PurposeID=<%#Eval("ReviewedID")%>&islem=rayon5&tarix1=<%#lblgelme1.Text%>&tarix2=<%#lblgetme1.Text%>&tarix3=<%#lblgelme.Text%>&tarix4=<%#lblgetme.Text%>&siralama1=<%#lblsira.Text%>'><%#Eval("meqsedumumi")%></a>
    </p></o:p></td>--%>
                            <td class="auto-style23" style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                                valign="top">
                                <p align="center" class="MsoNormal" style="text-align: left">
                                    <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                                        <o:p>
                                    <%#Eval("Other")%></o:p>
                                    </span>
                                </p>
                            </td>
                            <td class="auto-style20" style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                                valign="top">
                                <p align="center" class="MsoNormal" style="text-align: center; font-size: 11.0pt;">
                                    <a class="aucun" style="text-decoration: none;" href='Ihtovsiyetehlil.aspx?PurposeID=<%#Eval("PurposeId")%>&UserID=<%#Eval("UserID")%>&islem=rayon5&RegionID=<%#Eval("RegionID")%>&tarix1=<%#lblgelme1.Text%>&tarix2=<%#lblgetme1.Text%>&tarix3=<%#lblgelme.Text%>&tarix4=<%#lblgetme.Text%>&siralama1=<%#lblsira.Text%>'><%#Eval("meqseds") %></a>

                                </p>
                            </td>
                            <td style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                                valign="top" class="auto-style32">


                                <p align="center" class="MsoNormal" style="text-align: left;">
                                    <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                                        <o:p>
                    <%#Eval("recommendedView")%></o:p>
                                    </span>
                                </p>
                            </td>

                            <td style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                                valign="top" class="auto-style32">
                                <p align="center" class="MsoNormal" style="text-align: left">
                                    <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                                        <o:p>
                  <%#Eval("CommandText")%>  </o:p>
                                    </span>
                                </p>
                            </td>
                            <td style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                                valign="top" class="auto-style17">
                                <p align="center" class="MsoNormal" style="text-align: center">
                                    <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                                        <o:p>
                    <%#Class2.sozukes(Eval("CommandDate").ToString()) %></o:p>
                                    </span>
                                </p>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>

            </table>
        </asp:Panel>
    </asp:Panel>
    <br />
    <br />

    <asp:Panel ID="pnlbirinci" Visible="false" runat="server">
        <asp:Button ID="exele0" runat="server" Text="Wordə çıxart" OnClick="exele0_Click" Width="120px" />
        <br />
        <br />
        <asp:Panel ID="pnlprint" runat="server">
            <p class="MsoNormal">
                <table cellpadding="0" cellspacing="0" class="MsoNormalTable">
                    <tr style="mso-yfti-irow: 0; mso-yfti-firstrow: yes; height: 55.2pt">
                        <td style="width: 94.5pt; border: solid windowtext 1.0pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 55.2pt"
                            valign="center" width="126">Kurator</td>
                        <td style="width: 85.5pt; border: solid windowtext 1.0pt; border-left: none; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 55.2pt"
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
                        <td style="width: 1.25in; border: solid windowtext 1.0pt; border-left: none; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 55.2pt"
                            valign="center" width="120">
                            <p align="center" class="MsoNormal">
                                <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">Şəhərdən və rayondan getmə tarixi</span>
                            </p>
                        </td>
                        <td style="width: 154.4pt; border: solid windowtext 1.0pt; border-left: none; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 55.2pt"
                            valign="center" width="206">
                            <p align="center" class="MsoNormal">
                                <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">Baxılmış, araşdırılmış məsələlər</span>
                            </p>
                        </td>
                        <td style="width: 147.1pt; border: solid windowtext 1.0pt; border-left: none; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 55.2pt"
                            valign="center" width="196">
                            <p align="center" class="MsoNormal">
                                <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">Görülmüş işlər<o:p></o:p></span>
                            </p>
                        </td>
                        <td style="width: 139.5pt; border: solid windowtext 1.0pt; border-left: none; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 55.2pt"
                            valign="center" width="186">
                            <p align="center" class="MsoNormal">
                                <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">Əldə olunan nəticə</span>
                            </p>
                        </td>
                        <asp:Panel ID="pnlbaxiw0" runat="server">
                            <td style="border-right: 1.0pt solid windowtext; border-top: 1.0pt solid windowtext; border-bottom: 1.0pt solid windowtext; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium;"
                                valign="center" class="auto-style9">
                                <p align="center" class="MsoNormal">
                                    <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">Baxış</span>
                                </p>
                            </td>
                        </asp:Panel>
                    </tr>






                    <asp:Repeater ID="DataList3" runat="server">
                        <ItemTemplate>
                            <tr style="mso-yfti-irow: 1; height: 17.25pt">
                                <td style="width: 94.5pt; border: solid windowtext 1.0pt; border-top: none; mso-border-top-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 17.25pt"
                                    valign="top" width="126">
                                    <p align="left" class="MsoNormal">
                                        <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                                            <%#Eval("username")%>
                                        </span>
                                    </p>
                                </td>
                                <td style="width: 85.5pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 17.25pt"
                                    valign="top" width="114">
                                    <p align="left" class="MsoNormal">
                                        <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                                            <%#Eval("Name")%>
                                        </span>
                                    </p>
                                </td>
                                <td style="width: 85.5pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 17.25pt" valign="top" width="114">
                                    <p align="center" class="MsoNormal">
                                        <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                                            <%#Class2.sozukes(Eval("RegionCome").ToString()) %>
                                        </span>
                                    </p>
                                </td>
                                <td style="width: 1.25in; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 17.25pt"
                                    valign="top" width="120">
                                    <p align="center" class="MsoNormal">
                                        <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                                            <o:p><%#Class2.sozukes(Eval("GoFromRegion").ToString()) %></o:p>
                                        </span>
                                    </p>
                                </td>
                                <td style="width: 154.4pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 17.25pt"
                                    valign="top" width="206">
                                    <p align="left" class="MsoNormal">
                                        <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                                            <o:p><%#Eval("Other") %></o:p>
                                        </span>
                                    </p>
                                </td>
                                <td style="width: 147.1pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 17.25pt"
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
                                </td>
                                <asp:Panel ID="pnlbaxiw1" runat="server">
                                    <td style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                                        valign="top" class="auto-style10">
                                        <p align="center" class="MsoNormal">
                                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                                                <o:p><a href="ezamiyye.aspx?BusinessTripID=<%#Eval("BusinessTripID") %>&islem1=Ihtovsiyetehlil&RegionID=<%#Eval("RegionID") %>&controlBusinesTrip=1&UserID=<%#Eval("UserID") %>">Baxış</a></o:p>
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
    <br />
    <br />
    <asp:Label ID="lblgelme3" runat="server" Visible="False"></asp:Label>
    <asp:Label ID="lblgetme3" runat="server" Visible="False"></asp:Label>
    <asp:Label ID="lblgelme4" runat="server" Visible="False"></asp:Label>
    <asp:Label ID="lblgetme4" runat="server" Visible="False"></asp:Label>
    <asp:Label ID="lblkurator" runat="server" Visible="False"></asp:Label>
    <asp:Label ID="lblrayon" runat="server" Visible="False"></asp:Label>

</asp:Content>

