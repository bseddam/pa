<%@ Page Title="" Language="C#" MasterPageFile="~/adminpanel/adminMasterPage.master" AutoEventWireup="true" CodeFile="Movcudeyanitehlil.aspx.cs" Inherits="adminpanel_Movcudeyanitehlil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

 p.MsoNormal
	{margin-bottom:.0001pt;
	font-size:12.0pt;
	font-family:"Arial","sans-serif";
	        margin-left: 0in;
            margin-right: 0in;
            margin-top: 0in;
        }
 table.MsoNormalTable
	{font-size:12.0pt;
	font-family:"Calibri","sans-serif";
            width: 1013px;
        }
        .auto-style1 {
            height: 13.25pt;
            width: 67pt;
        }
        .auto-style2 {
            height: 17.25pt;
            width: 67pt;
        }
        .auto-style3 {
            width: 78pt;
        }
        .auto-style4 {
            height: 13.25pt;
            width: 78pt;
        }
        .auto-style5 {
            height: 17.25pt;
            width: 78pt;
        }
        .auto-style6 {
            height: 13.25pt;
            width: 68pt;
        }
        .auto-style7 {
            height: 17.25pt;
            width: 68pt;
        }
        .auto-style9 {
            height: 26.3pt;
            width: 125pt;
        }
        .auto-style10 {
            height: 17.25pt;
            width: 125pt;
        }
                
        .auto-style1 {
            width: 100%;
        }

        .auto-style2 {
            width: 828px;
        }
        .auto-style14 {
            height: 26.3pt;
            width: 93pt;
        }
        .auto-style17 {
            height: 17.25pt;
            width: 93pt;
        }
        .auto-style20 {
            width: 68pt;
        }
        .auto-style23 {
            width: 62pt;
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

        <div style="float: left; width: 346px; padding-top: 10px;  height: 179px;">
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

    </asp:Panel>

    
        <div class="temizle"></div>

    <asp:Panel ID="Panel1" runat="server">

            <p align="center" class="MsoNormal" style="text-align:center">
        <b style="mso-bidi-font-weight:
normal"><span lang="AZ-LATIN" style="mso-ansi-language:AZ-LATIN">Şöbə əməkdaşlarının ezamiyyətlərdə mövcud əyani təşviqat vasitələrinin vəziyyətinin araşdırılması  
barədə məlumat
<o:p></o:p></span></b></p>
    <p class="MsoNormal" style="text-align:justify">
        <span lang="AZ-LATIN" style="mso-ansi-language:AZ-LATIN">
        <o:p>
        &nbsp;</o:p></span></p>


    <table border="1" cellpadding="0" cellspacing="0" class="MsoNormalTable" style="border-style: none; border-color: inherit; border-width: medium; border-collapse:collapse; mso-table-layout-alt:fixed;
 mso-border-alt:solid windowtext .5pt; mso-yfti-tbllook:1184;
 mso-padding-alt:0in 5.4pt 0in 5.4pt; mso-border-insideh:.5pt solid windowtext;
 mso-border-insidev:.5pt solid windowtext; width: 1014px;">
        <tr style="mso-yfti-irow:0;mso-yfti-firstrow:yes">
            <td rowspan="4" style="width:28.85pt;border:solid windowtext 1.0pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt" valign="center" width="38">
                <p align="center" class="MsoNormal" style="text-align:center">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">S/n<o:p></o:p></span></p>
            </td>
            <td rowspan="4" style="border-right: 1.0pt solid windowtext; border-top: 1.0pt solid windowtext; border-bottom: 1.0pt solid windowtext; mso-border-left-alt:solid windowtext .5pt; mso-border-alt:
  solid windowtext .5pt; padding:0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium;" valign="center" class="auto-style23">
                <p align="center" class="MsoNormal" style="text-align:center">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">Adı, soyadı<o:p></o:p></span></p>
                <p align="center" class="MsoNormal" style="text-align:center">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">
                    <o:p>
                    &nbsp;</o:p></span></p>
            </td>
            <td colspan="7" style="width:653.7pt;border:solid windowtext 1.0pt;
  border-left:none;mso-border-left-alt:solid windowtext .5pt;mso-border-alt:
  solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt" valign="center" width="872">
                <p align="center" class="MsoNormal" style="text-align:center">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-bidi-font-family:Arial;mso-ansi-language:
  AZ-LATIN">  <asp:Label ID="lblgelme2" runat="server" Text=""></asp:Label>
                    -
                    <asp:Label ID="lblgetme2" runat="server" Text=""></asp:Label></span></p>
            </td>
        </tr>
        <tr style="mso-yfti-irow:1;height:13.25pt">
            <td rowspan="3" style="border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;" valign="center" class="auto-style6">
                <p align="center" class="MsoNormal" style="text-align:center">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">Şəhər və rayonlara ezamiyyətlərin sayı<o:p></o:p></span></p>
            </td>
            <td rowspan="3" style="border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;" valign="center" class="auto-style4">
                <p align="center" class="MsoNormal" style="text-align:center">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">Şəhər, rayon<b style="mso-bidi-font-weight:normal"><sup><o:p></o:p></sup></b></span></p>
            </td>
            <td colspan="4" style="border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:13.25pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;" valign="center">
                <p align="center" class="MsoNormal" style="text-align:center">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">Əyani təşviqat vasitələri<o:p></o:p></span></p>
            </td>
            <td rowspan="3" style="width:207.0pt;border-top:none;
  border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:13.25pt" valign="center" width="276">
                <p align="center" class="MsoNormal" style="text-align:center">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">Təkliflər<o:p></o:p></span></p>
            </td>
        </tr>
        <tr style="mso-yfti-irow:2;height:14.35pt">
            <td rowspan="2" style="width:55.3pt;border-top:none;
  border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:14.35pt" valign="center" width="74">
                <p align="center" class="MsoNormal" style="text-align:center">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">Cəmi<o:p></o:p></span></p>
                <p align="center" class="MsoNormal" style="text-align:center">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">(ədədlə)<o:p></o:p></span></p>
            </td>
            <td colspan="3" style="border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:14.35pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;" valign="center">
                <p align="center" class="MsoNormal" style="text-align:center">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">İstismar vəsiyyəti<o:p></o:p></span></p>
            </td>
        </tr>
        <tr style="mso-yfti-irow:3;height:26.3pt">
            <td style="width:78.6pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:26.3pt" valign="center" width="105">
                <p align="center" class="MsoNormal" style="text-align:center">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">əla<o:p></o:p></span></p>
                <p align="center" class="MsoNormal" style="text-align:center">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">(ədədlə/%)<o:p></o:p></span></p>
            </td>
            <td style="border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;" valign="center" class="auto-style14">
                <p align="center" class="MsoNormal" style="text-align:center">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">yararlı<o:p></o:p></span></p>
                <p align="center" class="MsoNormal" style="text-align:center">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">(ədədlə/%)<o:p></o:p></span></p>
            </td>
            <td style="border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;" valign="center" class="auto-style9">
                <p align="center" class="MsoNormal" style="text-align:center">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">yararsız<o:p></o:p></span></p>
                <p align="center" class="MsoNormal" style="text-align:center">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">(ədədlə/%)<o:p></o:p></span></p>
            </td>
        </tr>
        <tr style="mso-yfti-irow:4;height:17.25pt">
            <td colspan="2" style="border-left: 1.0pt solid windowtext; border-right: 1.0pt solid windowtext; border-bottom: 1.0pt solid windowtext; mso-border-top-alt:solid windowtext .5pt; mso-border-alt:solid windowtext .5pt;
  padding:0in 5.4pt 0in 5.4pt; height:17.25pt; border-top-style: none; border-top-color: inherit; border-top-width: medium;" valign="center">
                <p align="right" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:
  AZ-LATIN">Cəmi:<b style="mso-bidi-font-weight:normal"><sup><o:p></o:p></sup></b></span></p>
            </td>
            <td style="border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;" valign="center" class="auto-style7">
                <p align="center" class="MsoNormal" style="text-align:center">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">
                    <o:p>
                    <asp:Label runat="server" ID="lblezamsay"></asp:Label></o:p></span></p>
            </td>
            <td style="border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;" valign="center" class="auto-style5">
                <p align="center" class="MsoNormal" style="text-align:center">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">
                    <o:p>
                     <asp:Label ID="lblfreg" runat="server"></asp:Label> </o:p></span></p>
            </td>
            <td style="width:55.3pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:17.25pt" valign="center" width="74">
                <p align="center" class="MsoNormal" style="text-align:center">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">
                    <o:p>
                  <asp:Label ID="lblcem" runat="server"></asp:Label></o:p></span></p>
            </td>
            <td style="width:78.6pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:17.25pt" valign="center" width="105">
                <p align="center" class="MsoNormal" style="text-align:center">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">
                    <o:p>
                   <asp:Label ID="lblela" runat="server"></asp:Label></o:p></span></p>
            </td>
            <td style="border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;" valign="center" class="auto-style17">
                <p align="center" class="MsoNormal" style="text-align:center">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">
                    <o:p>
                     <asp:Label ID="lblyararli" runat="server"></asp:Label></o:p></span></p>
            </td>
            <td style="border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;" valign="center" class="auto-style10">
                <p align="center" class="MsoNormal" style="text-align:center">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">
                    <o:p>
                    <asp:Label ID="lblyararsiz" runat="server"></asp:Label></o:p></span></p>
            </td>
            <td style="width:207.0pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:17.25pt" valign="center" width="276">
                <p align="center" class="MsoNormal" style="text-align:center">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">
                    <o:p>
                    &nbsp;</o:p></span></p>
            </td>
        </tr>


         <asp:Repeater ID="DataList1" runat="server">
                    <ItemTemplate>

        <tr style="mso-yfti-irow:5">
            <td style="width:28.85pt;border:solid windowtext 1.0pt;
  border-top:none;mso-border-top-alt:solid windowtext .5pt;mso-border-alt:solid windowtext .5pt;
  padding:0in 5.4pt 0in 5.4pt" valign="center" width="38">
                <p align="center" class="MsoNormal" style="text-align:center">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">
                    <o:p>
                    <%#Container.ItemIndex+1 %>.</o:p></span></p>
            </td>
            <td style="border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;" valign="center" class="auto-style23">
                <p align="center" class="MsoNormal" style="text-align:left">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">
                    <o:p>
                   <%#Eval("Username")%></o:p></span></p>
            </td>
            <td style="border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;" valign="center" class="auto-style20">
                <p align="center" class="MsoNormal" style="text-align:center">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">
                    <o:p>
                     <%#Eval("rynsay")%></o:p></span></p>
            </td>
            <td style="border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;" valign="center" class="auto-style3">
                <p align="center" class="MsoNormal" style="text-align:left">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">
                    <o:p>
                     <%#Eval("Name")%></o:p></span></p>
            </td>
            <td style="width:55.3pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt" valign="center" width="74">
                <p align="center" class="MsoNormal" style="text-align:center">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">
                    <o:p>
 <a class="aucun" style="text-decoration:none;" href='Movcudeyanitehlil.aspx?UserID=<%#Eval("UserID")%>&islem=rayon5&RegionID=<%#Eval("RegionID")%>&tarix1=<%#lblgelme1.Text%>&tarix2=<%#lblgetme1.Text%>&tarix3=<%#lblgelme.Text%>&tarix4=<%#lblgetme.Text%>'><%#Eval("cemumumi") %></a>
          
                    
                   </o:p></span></p>
            </td>
            <td style="width:78.6pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt" valign="center" width="105">
                <p align="center" class="MsoNormal" style="text-align:center">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">
                    <o:p>
                 <a class="aucun" style="text-decoration:none;" href='Movcudeyanitehlil.aspx?UserID=<%#Eval("UserID")%>&islem=rayon5&RegionID=<%#Eval("RegionID")%>&tarix1=<%#lblgelme1.Text%>&tarix2=<%#lblgetme1.Text%>&tarix3=<%#lblgelme.Text%>&tarix4=<%#lblgetme.Text%>'><%#Eval("ela")%></a></o:p></span></p>
            </td>
            <td style="width:81.0pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt" valign="center" width="108">
                <p align="center" class="MsoNormal" style="text-align:center">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">
                    <o:p>
                <a class="aucun" style="text-decoration:none;" href='Movcudeyanitehlil.aspx?UserID=<%#Eval("UserID")%>&islem=rayon5&RegionID=<%#Eval("RegionID")%>&tarix1=<%#lblgelme1.Text%>&tarix2=<%#lblgetme1.Text%>&tarix3=<%#lblgelme.Text%>&tarix4=<%#lblgetme.Text%>'><%#Eval("yararli")%></a>   </o:p></span></p>
            </td>
            <td style="width:85.5pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt" valign="center" width="114">
                <p align="center" class="MsoNormal" style="text-align:center">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">
                    <o:p>
                   <a class="aucun" style="text-decoration:none;" href='Movcudeyanitehlil.aspx?UserID=<%#Eval("UserID")%>&islem=rayon5&RegionID=<%#Eval("RegionID")%>&tarix1=<%#lblgelme1.Text%>&tarix2=<%#lblgetme1.Text%>&tarix3=<%#lblgelme.Text%>&tarix4=<%#lblgetme.Text%>'><%#Eval("yararsiz")%></a></o:p></span></p>
            </td>
            <td style="width:207.0pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt" valign="center" width="276">
                <p align="left" class="MsoNormal" style="text-align:left">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">
                    <o:p>
                    <%#Eval("Offer")%></o:p></span></p>
            </td>
        </tr>


                        </ItemTemplate>
             </asp:Repeater>


        </table>
          </asp:Panel>

        </asp:Panel>
    <br />



    <asp:Panel ID="pnlbirinci" runat="server">
              <asp:Button ID="exele0" runat="server" Text="Wordə çıxart" OnClick="exele0_Click" Width="120px" />
        <br />
        <br />
          <asp:Panel ID="pnlprint" runat="server">
             
    <table  cellpadding="0" cellspacing="0" class="MsoNormalTable">
        <tr style="mso-yfti-irow:0;mso-yfti-firstrow:yes;height:15.7pt">
            <td rowspan="3" style="width:30.05pt;border:solid windowtext 1.0pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:15.7pt" valign="center" width="40">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-bidi-font-family:Arial;mso-ansi-language:
  AZ-LATIN">S/n<o:p></o:p></span></p>
            </td>
            <td rowspan="3" style="width:58.55pt;border:solid windowtext 1.0pt;
  border-left:none;mso-border-left-alt:solid windowtext .5pt;mso-border-alt:
  solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:15.7pt" valign="center" width="78">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">Adı, soyadı</span><span lang="AZ-LATIN" style="font-size:11.0pt;mso-bidi-font-family:Arial;mso-ansi-language:
  AZ-LATIN"><o:p></o:p></span></p>
            </td>
            <td rowspan="3" style="width:60.65pt;border:solid windowtext 1.0pt;
  border-left:none;mso-border-left-alt:solid windowtext .5pt;mso-border-alt:
  solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:15.7pt" valign="center" width="81">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-bidi-font-family:Arial;mso-ansi-language:
  AZ-LATIN">Şəhər, rayon<o:p></o:p></span></p>
            </td>
            <td rowspan="3" style="width:78.55pt;border:solid windowtext 1.0pt;
  border-left:none;mso-border-left-alt:solid windowtext .5pt;mso-border-alt:
  solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:15.7pt" valign="center" width="105">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; color: #141823; background: white; mso-ansi-language: AZ-LATIN">Şəhərdən və rayona gəlmə tarixi<o:p></o:p></span></p>
            </td>
            <td rowspan="3" style="width:83.6pt;border:solid windowtext 1.0pt;
  border-left:none;mso-border-left-alt:solid windowtext .5pt;mso-border-alt:
  solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:15.7pt" valign="center" width="111">
                <p align="center" class="MsoNormal">
                    <span style="font-size: 11.0pt; mso-bidi-font-family: Arial; color: #141823; background: white; mso-ansi-language: EN-US">Şəhərdən və rayondan getmə tarixi</span><b style="mso-bidi-font-weight:normal"><sup><span style="font-size:11.0pt;
  mso-bidi-font-family:Arial;mso-ansi-language:EN-US"><o:p></o:p></span></sup></b></p>
            </td>
            <td colspan="4" style="width:291.8pt;border:solid windowtext 1.0pt;
  border-left:none;mso-border-left-alt:solid windowtext .5pt;mso-border-alt:
  solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:15.7pt" valign="center" width="389">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-bidi-font-family:Arial;mso-ansi-language:
  AZ-LATIN">Əyani təşviqat vasitələri<o:p></o:p></span></p>
            </td>
            <td rowspan="3" style="width:66.05pt;border:solid windowtext 1.0pt;
  border-left:none;mso-border-left-alt:solid windowtext .5pt;mso-border-alt:
  solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:15.7pt" valign="center" width="88">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-bidi-font-family:Arial;mso-ansi-language:
  AZ-LATIN">Təkliflər<o:p></o:p></span></p>
            </td>
                  <asp:Panel ID="pnlbaxiw0" runat="server">
            <td  rowspan="3" style="width:66.05pt;border:solid windowtext 1.0pt;
  border-left:none;mso-border-left-alt:solid windowtext .5pt;mso-border-alt:
  solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:15.7pt" valign="center" width="88">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-bidi-font-family:Arial;mso-ansi-language:
  AZ-LATIN">Baxış<o:p></o:p></span></p>
            </td>
                      </asp:Panel>
        </tr>
        <tr style="mso-yfti-irow:1;height:17.0pt">
            <td rowspan="2" style="width:60.3pt;border-top:none;
  border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:17.0pt" valign="center" width="80">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-bidi-font-family:Arial;mso-ansi-language:
  AZ-LATIN">Cəmi<o:p></o:p></span></p>
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-bidi-font-family:Arial;mso-ansi-language:
  AZ-LATIN">(ədədlə)<o:p></o:p></span></p>
            </td>
            <td colspan="3" style="width:231.5pt;border-top:none;
  border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:17.0pt" valign="center" width="309">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-bidi-font-family:Arial;mso-ansi-language:
  AZ-LATIN">İstismar vəsiyyəti<o:p></o:p></span></p>
            </td>
        </tr>
        <tr style="mso-yfti-irow:2;height:31.25pt">
            <td style="width:74.2pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:31.25pt" valign="center" width="99">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-bidi-font-family:Arial;mso-ansi-language:
  AZ-LATIN">əla<o:p></o:p></span></p>
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-bidi-font-family:Arial;mso-ansi-language:
  AZ-LATIN">(ədədlə/%)<o:p></o:p></span></p>
            </td>
            <td style="width:76.5pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:31.25pt" valign="center" width="102">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-bidi-font-family:Arial;mso-ansi-language:
  AZ-LATIN">yararlı<o:p></o:p></span></p>
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-bidi-font-family:Arial;mso-ansi-language:
  AZ-LATIN">(ədədlə/%)<o:p></o:p></span></p>
            </td>
            <td style="width:80.8pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:31.25pt" valign="center" width="108">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-bidi-font-family:Arial;mso-ansi-language:
  AZ-LATIN">yararsız<o:p></o:p></span></p>
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-bidi-font-family:Arial;mso-ansi-language:
  AZ-LATIN">(ədədlə/%)<o:p></o:p></span></p>
            </td>
        </tr>


                 <asp:Repeater ID="rp1" runat="server">
                    <ItemTemplate>
        <tr style="mso-yfti-irow:3;mso-yfti-lastrow:yes;height:14.1pt">
            <td style="width:30.05pt;border:solid windowtext 1.0pt;
  border-top:none;mso-border-top-alt:solid windowtext .5pt;mso-border-alt:solid windowtext .5pt;
  padding:0in 5.4pt 0in 5.4pt;height:14.1pt" valign="top" width="40">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-bidi-font-family:Arial;mso-ansi-language:
  AZ-LATIN"><o:p><%#Container.ItemIndex+1 %>.</o:p></span></p>
            </td>
            <td style="width:58.55pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:14.1pt" valign="top" width="78">
                <p align="left" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-bidi-font-family:Arial;mso-ansi-language:
  AZ-LATIN"><o:p><%#Eval("Username")%></o:p></span></p>
            </td>
            <td style="width:60.65pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:14.1pt" valign="top" width="81">
                <p align="left" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-bidi-font-family:Arial;mso-ansi-language:
  AZ-LATIN"><o:p><%#Eval("Name")%></o:p></span></p>
            </td>
            <td style="width:78.55pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:14.1pt" valign="top" width="105">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-bidi-font-family:Arial;mso-ansi-language:
  AZ-LATIN"><o:p><%#Class2.sozukes(Eval("RegionCome").ToString()) %></o:p></span></p>
            </td>
            <td style="width:83.6pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:14.1pt" valign="top" width="111">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-bidi-font-family:Arial;mso-ansi-language:
  AZ-LATIN"><o:p><%#Class2.sozukes(Eval("GoFromRegion").ToString()) %></o:p></span></p>
            </td>
            <td style="width:60.3pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:14.1pt" valign="top" width="80">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-bidi-font-family:Arial;mso-ansi-language:
  AZ-LATIN"><o:p><%#Eval("Situation_SUM")%> </o:p></span></p>
            </td>
            <td style="width:74.2pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:14.1pt" valign="top" width="99">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-bidi-font-family:Arial;mso-ansi-language:
  AZ-LATIN"><o:p><%#Eval("ela")%></o:p></span></p>
            </td>
            <td style="width:76.5pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:14.1pt" valign="top" width="102">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-bidi-font-family:Arial;mso-ansi-language:
  AZ-LATIN"><o:p><%#Eval("yararli")%></o:p></span></p>
            </td>
            <td style="width:80.8pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:14.1pt" valign="top" width="108">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-bidi-font-family:Arial;mso-ansi-language:
  AZ-LATIN"><o:p><%#Eval("yararsiz")%></o:p></span></p>
            </td>
            <td style="width:66.05pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:14.1pt" valign="top" width="88">
                <p align="left" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-bidi-font-family:Arial;mso-ansi-language:
  AZ-LATIN"><o:p><%#Eval("Offer")%></o:p></span></p>
            </td>
             <asp:Panel ID="pnlbaxiw1" runat="server">
            <td style="width:66.05pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:14.1pt" valign="top" width="88">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-bidi-font-family:Arial;mso-ansi-language:
  AZ-LATIN"><o:p><a href="ezamiyye.aspx?BusinessTripID=<%#Eval("BusinessTripID") %>&islem1=Movcudeyanitehlil&RegionID=<%#Eval("RegionID") %>&controlBusinesTrip=1&UserID=<%#Eval("UserID") %>">Baxış</a></o:p></span></p>
            </td>
                 </asp:Panel>
        </tr>
                        </ItemTemplate>
                     </asp:Repeater>
    </table>
               </asp:Panel>
        </asp:Panel>
    <p class="MsoNormal">
        <span lang="AZ-LATIN" style="font-size:11.0pt;mso-bidi-font-family:Arial;mso-ansi-language:AZ-LATIN"><o:p>&nbsp;</o:p><asp:Label ID="lblgelme3" runat="server" Visible="False"></asp:Label>
        <asp:Label ID="lblgetme3" runat="server" Visible="False"></asp:Label>
        <asp:Label ID="lblgelme4" runat="server" Visible="False"></asp:Label>
        <asp:Label ID="lblgetme4" runat="server" Visible="False"></asp:Label>
        <asp:Label ID="lblkurator" runat="server" Visible="False"></asp:Label>
        <asp:Label ID="lblrayon" runat="server" Visible="False"></asp:Label>
        </span></p>


</asp:Content>

