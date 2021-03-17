<%@ Page Title="" Language="C#" MasterPageFile="~/adminpanel/adminMasterPage.master" AutoEventWireup="true" CodeFile="Sosialhumtehlil.aspx.cs" Inherits="adminpanel_Sosialhumtehlil" %>

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
	{font-size:11.0pt;
	font-family:"Calibri","sans-serif";
	}
         .auto-style1 {
            width: 100%;
        }

        .auto-style2 {
            width: 828px;
        }
        .auto-style3 {
            width: 59pt;
        }
        .auto-style4 {
            height: 55.2pt;
            width: 67pt;
        }
        .auto-style5 {
            height: 17.25pt;
            width: 67pt;
        }
        .auto-style6 {
            width: 67pt;
        }
        .auto-style7 {
            height: 55.2pt;
            width: 70pt;
        }
        .auto-style8 {
            height: 17.25pt;
            width: 70pt;
        }
        .auto-style9 {
            width: 70pt;
        }
        .auto-style13 {
            height: 55.2pt;
            width: 0.64in;
        }
        .auto-style14 {
            height: 17.25pt;
            width: 0.64in;
        }
        .auto-style15 {
            width: 0.64in;
        }
        .auto-style16 {
            height: 55.2pt;
            width: 66pt;
        }
        .auto-style17 {
            height: 17.25pt;
            width: 66pt;
        }
        .auto-style18 {
            width: 66pt;
        }
        .auto-style22 {
            height: 55.2pt;
            width: 233pt;
        }
        .auto-style23 {
            height: 17.25pt;
            width: 233pt;
        }
        .auto-style24 {
            width: 233pt;
        }
        .auto-style25 {
            height: 55.2pt;
            width: 283pt;
        }
        .auto-style26 {
            height: 17.25pt;
            width: 283pt;
        }
        .auto-style27 {
            width: 283pt;
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

        <div style="float: left; width: 346px; padding-top: 10px;  height: 252px;">
            Rayon:&nbsp;&nbsp;
            <asp:DropDownList ID="ddlryn" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            Sahə:&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddlsahe" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlsahe_SelectedIndexChanged">
            </asp:DropDownList>
            <br />
            <br />
            Təyinat:
            <asp:DropDownList ID="ddlteyinat" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            İcrası barədə qeyd:
            <asp:DropDownList ID="ddlicrabarqeyd" runat="server">
                <asp:ListItem Value="0">Ümumi</asp:ListItem>
                <asp:ListItem Value="1">Başlanmamışdır</asp:ListItem>
                <asp:ListItem Value="2">Başlanmışdır</asp:ListItem>
                <asp:ListItem Value="3">İcra olunub</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            Sıralama:
            <asp:DropDownList ID="ddlsiralama" runat="server">
                <asp:ListItem Value="1">Şəhər və rayonlar üzrə</asp:ListItem>
                <asp:ListItem Value="2">Sahələr üzrə</asp:ListItem>
                <asp:ListItem Value="3">Təyinatı üzrə</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
           
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Axtar" Width="120px" />


            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="exele" runat="server" OnClick="exele_Click" Text="Wordə çıxart" Visible="False" Width="120px" />


            <br />
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
normal"><span lang="AZ-LATIN" style="mso-ansi-language:AZ-LATIN">Şöbə əməkdaşlarının ezamiyyətlərdə sosial və humanitar sahələrdə həlli vacib olan problemlərin araşdırılması  
barədə məlumat

<o:p></o:p></span></b></p>
    <p class="MsoNormal" style="text-align:justify">
        <span lang="AZ-LATIN" style="mso-ansi-language:AZ-LATIN">
        <o:p>
        &nbsp;</o:p></span></p>


    <table border="1" cellpadding="0" cellspacing="0" class="MsoNormalTable" style="border-style: none; border-color: inherit; border-width: medium;  border-collapse: collapse; mso-table-layout-alt: fixed; mso-border-alt: solid windowtext .5pt; mso-yfti-tbllook: 1184; mso-padding-alt: 0in 5.4pt 0in 5.4pt; mso-border-insideh: .5pt solid windowtext; mso-border-insidev: .5pt solid windowtext; width: 1015px;">
        <tr style="mso-yfti-irow:0;mso-yfti-firstrow:yes">
            <td rowspan="2" style="width:28.9pt;border:solid windowtext 1.0pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt" valign="center" width="39">
                <p align="center" class="MsoNormal" style="text-align:center">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">S/n<o:p></o:p></span></p>
            </td>
            <td rowspan="2" style="border-right: 1.0pt solid windowtext; border-top: 1.0pt solid windowtext; border-bottom: 1.0pt solid windowtext; mso-border-left-alt:solid windowtext .5pt; mso-border-alt:
  solid windowtext .5pt; padding:0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium;" valign="center" class="auto-style3">
                <p align="center" class="MsoNormal" style="text-align:center">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">Adı, soyadı<o:p></o:p></span></p>
            </td>
            <td colspan="7" style="width:652.5pt;border:solid windowtext 1.0pt;
  border-left:none;mso-border-left-alt:solid windowtext .5pt;mso-border-alt:
  solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt" valign="center" width="870">
                <p align="center" class="MsoNormal" style="text-align:center">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-bidi-font-family:Arial;mso-ansi-language:
  AZ-LATIN">
                    <o:p>
                     <asp:Label ID="lblgelme2" runat="server" Text=""></asp:Label>
                    -
                    <asp:Label ID="lblgetme2" runat="server" Text=""></asp:Label></o:p></span></p>
            </td>
        </tr>
        <tr style="mso-yfti-irow:1;height:55.2pt">
            <td style="border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;" valign="center" class="auto-style7">
                <p align="center" class="MsoNormal" style="text-align:center">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">Şəhər və rayonlara ezamiyyətlərin sayı<o:p></o:p></span></p>
            </td>
            <td style="border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;" valign="center" class="auto-style4">
                <p align="center" class="MsoNormal" style="text-align:center">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">Şəhər, rayon<b style="mso-bidi-font-weight:normal"><sup><o:p></o:p></sup></b></span></p>
            </td>
            <td style="border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;" valign="center" class="auto-style16">
                <p align="center" class="MsoNormal" style="text-align:center">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">Sahələr<b style="mso-bidi-font-weight:normal"><sup><o:p></o:p></sup></b></span></p>
            </td>
            <td style="border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;" valign="center" class="auto-style13">
                <p align="center" class="MsoNormal" style="text-align:center">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">İstiqamətlər<b style="mso-bidi-font-weight:normal"><sup><o:p></o:p></sup></b></span></p>
            </td>
            <td style="border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;" valign="center" class="auto-style25">
                <p align="center" class="MsoNormal" style="text-align:center">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">Problem<b style="mso-bidi-font-weight:normal"><sup><o:p></o:p></sup></b></span></p>
            </td>
            <td style="border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;" valign="center" class="auto-style22">
                <p align="center" class="MsoNormal" style="text-align:center">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">İcrası barədə qeyd</span></p>
            </td>
            <td style="border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:55.2pt" valign="center" width="20px">
                <p align="center" class="MsoNormal" style="text-align:center">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">Baxış</span></p>
            </td>
        </tr>
        <tr style="mso-yfti-irow:2;height:17.25pt">
            <td colspan="2" style="border-left: 1.0pt solid windowtext; border-right: 1.0pt solid windowtext; border-bottom: 1.0pt solid windowtext; mso-border-top-alt:solid windowtext .5pt; mso-border-alt:solid windowtext .5pt;
  padding:0in 5.4pt 0in 5.4pt; height:17.25pt; border-top-style: none; border-top-color: inherit; border-top-width: medium;" valign="center">
                <p align="right" class="MsoNormal" style="text-align:right">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">Cəmi</span><span style="font-size:11.0pt;mso-ansi-language:EN-US">:<b style="mso-bidi-font-weight:
  normal"><sup><o:p></o:p></sup></b></span></p>
            </td>
            <td style="border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;" valign="center" class="auto-style8">
                <p align="center" class="MsoNormal" style="text-align:center">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">
                    <o:p>
                    &nbsp;<span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN"><asp:Label ID="lblezamsay" runat="server"></asp:Label> </span></o:p></span></p>
            </td>
            <td style="border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;" valign="center" class="auto-style5">
                <p align="center" class="MsoNormal" style="text-align:center">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">
                    <o:p>
                  <asp:Label ID="lblfreg" runat="server"></asp:Label></o:p></span></p>
            </td>
            <td style="border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;" valign="center" class="auto-style17">
                <p align="center" class="MsoNormal" style="text-align:center">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">
                    <o:p>
                    <asp:Label ID="lblsaheler" runat="server"></asp:Label></o:p></span></p>
            </td>
            <td style="border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;" valign="center" class="auto-style14">
                <p align="center" class="MsoNormal" style="text-align:center">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">
                    <o:p>
                   <asp:Label ID="lblteyuzre" runat="server"></asp:Label></o:p></span></p>
            </td>
            <td style="border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;" valign="center" class="auto-style26">
                <p align="center" class="MsoNormal" style="text-align:center">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">
                    <o:p>
                    &nbsp;</o:p></span></p>
            </td>
            <td style="border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;" valign="center" class="auto-style23">&nbsp;</td>
            <td style="border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:17.25pt" valign="center" width="20px">
                <p align="center" class="MsoNormal" style="text-align:center">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">
                    <o:p>
                    &nbsp;</o:p></span></p>
            </td>
        </tr>


              <asp:Repeater ID="DataList1" runat="server">
                    <ItemTemplate>


        <tr style="mso-yfti-irow:3">
            <td style="width:28.9pt;border:solid windowtext 1.0pt;
  border-top:none;mso-border-top-alt:solid windowtext .5pt;mso-border-alt:solid windowtext .5pt;
  padding:0in 5.4pt 0in 5.4pt" valign="top" width="39">
                <p align="center" class="MsoNormal" style="text-align:center">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">
                    <o:p>
                    <%#Container.ItemIndex+1 %>.</o:p></span></p>
            </td>
            <td style="border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;" valign="top" class="auto-style3">
                <p align="center" class="MsoNormal" style="text-align:left">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">
                    <o:p>
                    <%#Eval("Username")%></o:p></span></p>
            </td>
            <td style="border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;" valign="top" class="auto-style9">
                <p align="center" class="MsoNormal" style="text-align:center">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">
                    <o:p>
                   <%#Eval("rynsay")%></o:p></span></p>
            </td>
            <td style="border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;" valign="top" class="auto-style6">
                <p align="center" class="MsoNormal" style="text-align:left">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">
                    <o:p>
                    <%#Eval("Name")%></o:p></span></p>
            </td>
            <td style="border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;" valign="top" class="auto-style18">
                <p align="center" class="MsoNormal" style="text-align:left">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">
                    <o:p>
                    <%#Eval("sh1")%></o:p></span></p>
            </td>
            <td style="border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;" valign="top" class="auto-style15">
                <p align="center" class="MsoNormal" style="text-align:left">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">
                    <o:p>
                   <%#Eval("sh2")%></o:p></span></p>
            </td>
            <td style="border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;" valign="top" class="auto-style27">
                <p align="center" class="MsoNormal" style="text-align:left">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">
                    <o:p>
                  <%#Eval("SerbestMetn1")%> </o:p></span></p>
            </td>
            <td style="border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;" valign="top" class="auto-style24">
                <p align="center" class="MsoNormal" style="text-align:left">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">
                         <%#Eval("icrabarmel")%>
                    </span>
                </p>
            </td>
            <td style="border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt" valign="top" width="20px">
                <p align="center" class="MsoNormal" style="text-align:center;">
                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">
                   <a href="ezamiyye.aspx?BusinessTripID=<%#Eval("BusinessTripID") %>&islem1=sosial&RegionID=<%#Eval("RegionID") %>&controlBusinesTrip=1&UserID=<%#Eval("UserID") %>">Baxış</a></span></p>
            </td>
        </tr>

                        </ItemTemplate>
                  </asp:Repeater>


        </table>
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
        </asp:Panel>
        </asp:Panel>

</asp:Content>

