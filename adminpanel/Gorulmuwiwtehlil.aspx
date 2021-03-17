<%@ Page Title="" Language="C#" MasterPageFile="~/adminpanel/adminMasterPage.master" AutoEventWireup="true" CodeFile="Gorulmuwiwtehlil.aspx.cs" Inherits="adminpanel_Gorulmuwiwtehlil" %>

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
            font-family: "Arial","sans-serif";
            width: 1014px;
        }
        .auto-style1 {
            width: 1019px;
        }
        .auto-style2 {
            width: 853px;
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
  <div>  
      <p align="center" class="MsoNormal">
          <b style="mso-bidi-font-weight:
normal"><span lang="AZ-LATIN" style="mso-ansi-language:AZ-LATIN">Hesabatların təqdim edilməsi vəziyyəti barədə məlumat</span></b></p>
      <p align="center" class="MsoNormal">
          &nbsp;</p>
              </div>
    <table cellpadding="0" cellspacing="0" class="MsoNormalTable">
        <tr style="mso-yfti-irow:0;mso-yfti-firstrow:yes">
            <td rowspan="4" style="width:29.3pt;border:solid windowtext 1.0pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt" valign="top" width="39">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:12.0pt;mso-ansi-language:AZ-LATIN">S/n<o:p></o:p></span></p>
            </td>
            <td rowspan="4" style="width:76.2pt;border:solid windowtext 1.0pt;
  border-left:none;mso-border-left-alt:solid windowtext .5pt;mso-border-alt:
  solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt" valign="top" width="102">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:12.0pt;mso-ansi-language:AZ-LATIN">Adı, soyadı<o:p></o:p></span></p>
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:12.0pt;mso-ansi-language:AZ-LATIN"><o:p>&nbsp;</o:p></span></p>
            </td>
            <td colspan="12" style="width:671.6pt;border:solid windowtext 1.0pt;
  border-left:none;mso-border-left-alt:solid windowtext .5pt;mso-border-alt:
  solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt" valign="top" width="895">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:12.0pt;mso-bidi-font-family:Arial;mso-ansi-language:
  AZ-LATIN"><o:p> <asp:Label ID="lblgelme2" runat="server" Text=""></asp:Label>
                                    -
                                 <asp:Label ID="lblgetme2" runat="server" Text=""></asp:Label></o:p></span></p>
            </td>
        </tr>
        <tr style="mso-yfti-irow:1;height:23.3pt">
            <td colspan="6" style="width:291.45pt;border-top:none;
  border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:23.3pt" valign="top" width="389">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:12.0pt;mso-ansi-language:AZ-LATIN">Təqdim edilmiş hesabatlar<b style="mso-bidi-font-weight:normal"><sup><o:p></o:p></sup></b></span></p>
            </td>
            <td colspan="6" style="width:294.65pt;border-top:none;
  border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:23.3pt" valign="top" width="393">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:12.0pt;mso-ansi-language:AZ-LATIN">Təqdim edilməmiş hesabatlar<b style="mso-bidi-font-weight:normal"><sup><o:p></o:p></sup></b></span></p>
            </td>
        </tr>
        <tr style="mso-yfti-irow:2;height:28.85pt">
            <td colspan="2" style="width:106.75pt;border-top:none;
  border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:28.85pt" valign="top" width="142">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:12.0pt;mso-ansi-language:AZ-LATIN">Cəmi<b style="mso-bidi-font-weight:normal"><sup><o:p></o:p></sup></b></span></p>
            </td>
            <td colspan="2" style="width:92.1pt;border-top:none;
  border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:28.85pt" valign="top" width="123">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:12.0pt;mso-ansi-language:AZ-LATIN">Vaxtında<b style="mso-bidi-font-weight:normal"><sup><o:p></o:p></sup></b></span></p>
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:12.0pt;mso-ansi-language:AZ-LATIN"><o:p>&nbsp;</o:p></span></p>
            </td>
            <td colspan="2" style="width:92.6pt;border-top:none;
  border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:28.85pt" valign="top" width="123">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:12.0pt;mso-ansi-language:AZ-LATIN">Gecikdirməklə<b style="mso-bidi-font-weight:normal"><sup><o:p></o:p></sup></b></span></p>
            </td>
            <td colspan="2" style="width:97.25pt;border-top:none;
  border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:28.85pt" valign="top" width="130">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:12.0pt;mso-ansi-language:AZ-LATIN">Cəmi<b style="mso-bidi-font-weight:normal"><sup><o:p></o:p></sup></b></span></p>
            </td>
            <td colspan="2" style="width:96.2pt;border-top:none;
  border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:28.85pt" valign="top" width="128">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:12.0pt;mso-ansi-language:AZ-LATIN">İcra müddəti vardır<b style="mso-bidi-font-weight:normal"><sup><o:p></o:p></sup></b></span></p>
            </td>
            <td colspan="2" style="width:101.2pt;border-top:none;
  border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:28.85pt" valign="top" width="135">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:12.0pt;mso-ansi-language:AZ-LATIN">Gecikdirilir<b style="mso-bidi-font-weight:normal"><sup><o:p></o:p></sup></b></span></p>
            </td>
        </tr>
        <tr style="mso-yfti-irow:3;height:17.25pt">
            <td style="width:64.2pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:17.25pt" valign="top" width="86">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:12.0pt;mso-ansi-language:AZ-LATIN">rəqəm<o:p></o:p></span></p>
            </td>
            <td style="width:42.55pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:17.25pt" valign="top" width="57">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:12.0pt;mso-ansi-language:AZ-LATIN">%<o:p></o:p></span></p>
            </td>
            <td style="width:49.6pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:17.25pt" valign="top" width="66">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:12.0pt;mso-ansi-language:AZ-LATIN">rəqəm<o:p></o:p></span></p>
            </td>
            <td style="width:42.5pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:17.25pt" valign="top" width="57">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:12.0pt;mso-ansi-language:AZ-LATIN">%<o:p></o:p></span></p>
            </td>
            <td style="width:49.6pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:17.25pt" valign="top" width="66">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:12.0pt;mso-ansi-language:AZ-LATIN">rəqəm<o:p></o:p></span></p>
            </td>
            <td style="width:43.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:17.25pt" valign="top" width="57">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:12.0pt;mso-ansi-language:AZ-LATIN">%<o:p></o:p></span></p>
            </td>
            <td style="width:53.2pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:17.25pt" valign="top" width="71">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:12.0pt;mso-ansi-language:AZ-LATIN">rəqəm<o:p></o:p></span></p>
            </td>
            <td style="width:44.05pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:17.25pt" valign="top" width="59">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:12.0pt;mso-ansi-language:AZ-LATIN">%<o:p></o:p></span></p>
            </td>
            <td style="width:53.9pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:17.25pt" valign="top" width="72">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:12.0pt;mso-ansi-language:AZ-LATIN">rəqəm<o:p></o:p></span></p>
            </td>
            <td style="width:42.3pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:17.25pt" valign="top" width="56">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:12.0pt;mso-ansi-language:AZ-LATIN">%<o:p></o:p></span></p>
            </td>
            <td style="width:55.7pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:17.25pt" valign="top" width="74">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:12.0pt;mso-ansi-language:AZ-LATIN">rəqəm<o:p></o:p></span></p>
            </td>
            <td style="width:45.5pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:17.25pt" valign="top" width="61">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:12.0pt;mso-ansi-language:AZ-LATIN">%<o:p></o:p></span></p>
            </td>
        </tr>
        <tr style="mso-yfti-irow:4">
            <td colspan="2" style="width:105.5pt;border:solid windowtext 1.0pt;
  border-top:none;mso-border-top-alt:solid windowtext .5pt;mso-border-alt:solid windowtext .5pt;
  padding:0in 5.4pt 0in 5.4pt" valign="top" width="141">
                <p align="right" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:12.0pt;mso-ansi-language:AZ-LATIN">Cəmi:<o:p></o:p></span></p>
            </td>
            <td style="width:64.2pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt" valign="top" width="86">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:12.0pt;mso-ansi-language:AZ-LATIN"><o:p>&nbsp;</o:p></span></p>
            </td>
            <td style="width:42.55pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt" valign="top" width="57">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:12.0pt;mso-ansi-language:AZ-LATIN"><o:p>&nbsp;</o:p></span></p>
            </td>
            <td style="width:49.6pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt" valign="top" width="66">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:12.0pt;mso-ansi-language:AZ-LATIN"><o:p>&nbsp;</o:p></span></p>
            </td>
            <td style="width:42.5pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt" valign="top" width="57">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:12.0pt;mso-ansi-language:AZ-LATIN"><o:p>&nbsp;</o:p></span></p>
            </td>
            <td style="width:49.6pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt" valign="top" width="66">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:12.0pt;mso-ansi-language:AZ-LATIN"><o:p>&nbsp;</o:p></span></p>
            </td>
            <td style="width:43.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt" valign="top" width="57">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:12.0pt;mso-ansi-language:AZ-LATIN"><o:p>&nbsp;</o:p></span></p>
            </td>
            <td style="width:53.2pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt" valign="top" width="71">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:12.0pt;mso-ansi-language:AZ-LATIN"><o:p>&nbsp;</o:p></span></p>
            </td>
            <td style="width:44.05pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt" valign="top" width="59">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:12.0pt;mso-ansi-language:AZ-LATIN"><o:p>&nbsp;</o:p></span></p>
            </td>
            <td style="width:53.9pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt" valign="top" width="72">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:12.0pt;mso-ansi-language:AZ-LATIN"><o:p>&nbsp;</o:p></span></p>
            </td>
            <td style="width:42.3pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt" valign="top" width="56">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:12.0pt;mso-ansi-language:AZ-LATIN"><o:p>&nbsp;</o:p></span></p>
            </td>
            <td style="width:55.7pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt" valign="top" width="74">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:12.0pt;mso-ansi-language:AZ-LATIN"><o:p>&nbsp;</o:p></span></p>
            </td>
            <td style="width:45.5pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt" valign="top" width="61">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:12.0pt;mso-ansi-language:AZ-LATIN"><o:p>&nbsp;</o:p></span></p>
            </td>
        </tr>




     
        <asp:Repeater ID="DataList1" runat="server">
            <ItemTemplate>

        <tr style="mso-yfti-irow:5">
            <td style="width:29.3pt;border:solid windowtext 1.0pt;
  border-top:none;mso-border-top-alt:solid windowtext .5pt;mso-border-alt:solid windowtext .5pt;
  padding:0in 5.4pt 0in 5.4pt" valign="top" width="39">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:12.0pt;mso-ansi-language:AZ-LATIN"><o:p><%#Container.ItemIndex+1 %>.</o:p></span></p>
            </td>
            <td style="width:76.2pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt" valign="top" width="102">
                <p align="left" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:12.0pt;mso-ansi-language:AZ-LATIN"><o:p>
                         <a class="aucun" style="text-decoration: none;" href='Gorulmuwiwtehlil.aspx?UserID=<%#Eval("UserID") %>&islem=userler&tarix1=<%#lblgelme1.Text%>&tarix2=<%#lblgetme1.Text%>&tarix3=<%#lblgelme.Text%>tarix4=<%#lblgetme.Text%>'>

                        <%#Eval("Name") %>
                             </a>
                             </o:p></span></p>
            </td>
            <td style="width:64.2pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt" valign="top" width="86">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:12.0pt;mso-ansi-language:AZ-LATIN"><o:p><%#Eval("umumiGonderilme") %></o:p></span></p>
            </td>
            <td style="width:42.55pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt" valign="top" width="57">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:12.0pt;mso-ansi-language:AZ-LATIN"><o:p><%#Eval("umumiFaizG") %></o:p></span></p>
            </td>
            <td style="width:49.6pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt" valign="top" width="66">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:12.0pt;mso-ansi-language:AZ-LATIN"><o:p><%#Eval("VaxtindaGonderilme") %></o:p></span></p>
            </td>
            <td style="width:42.5pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt" valign="top" width="57">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:12.0pt;mso-ansi-language:AZ-LATIN"><o:p><%#Eval("vaxtindagonderilmefaiz") %></o:p></span></p>
            </td>
            <td style="width:49.6pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt" valign="top" width="66">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:12.0pt;mso-ansi-language:AZ-LATIN"><o:p><%#Eval("GecikdirmekleGonderilme") %></o:p></span></p>
            </td>
            <td style="width:43.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt" valign="top" width="57">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:12.0pt;mso-ansi-language:AZ-LATIN"><o:p><%#Eval("gecikdirmeklegonderilmefaiz") %></o:p></span></p>
            </td>
            <td style="width:53.2pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt" valign="top" width="71">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:12.0pt;mso-ansi-language:AZ-LATIN"><o:p><%#Eval("umumiGonderilmeyen") %></o:p></span></p>
            </td>
            <td style="width:44.05pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt" valign="top" width="59">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:12.0pt;mso-ansi-language:AZ-LATIN"><o:p><%#Eval("umumigonderilmeyenfaiz") %></o:p></span></p>
            </td>
            <td style="width:53.9pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt" valign="top" width="72">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:12.0pt;mso-ansi-language:AZ-LATIN"><o:p><%#Eval("VaxtindaGonderilmeyen") %></o:p></span></p>
            </td>
            <td style="width:42.3pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt" valign="top" width="56">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:12.0pt;mso-ansi-language:AZ-LATIN"><o:p><%#Eval("VaxtindaFaizGonderilmeyen") %></o:p></span></p>
            </td>
            <td style="width:55.7pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt" valign="top" width="74">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:12.0pt;mso-ansi-language:AZ-LATIN"><o:p><%#Eval("GecikdirmekleGonderilmeyen") %></o:p></span></p>
            </td>
            <td style="width:45.5pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt" valign="top" width="61">
                <p align="center" class="MsoNormal">
                    <span lang="AZ-LATIN" style="font-size:12.0pt;mso-ansi-language:AZ-LATIN"><o:p><%#Eval("GecikdirmekleFaizGonderilmeyen") %></o:p></span></p>
            </td>
        </tr>
                </ItemTemplate>
            </asp:Repeater>

        </table>
              </asp:Panel>
        </asp:Panel>
    <br />

    <asp:Panel ID="Panel3" runat="server" Visible="false">
        <table cellpadding="0" cellspacing="0" class="auto-style6" style="mso-table-layout-alt: fixed; mso-border-alt: solid windowtext .5pt; mso-yfti-tbllook: 1184; mso-padding-alt: 0in 5.4pt 0in 5.4pt; mso-border-insideh: .5pt solid windowtext; mso-border-insidev: .5pt solid windowtext; width: 998px;">
            <tr style="mso-yfti-irow:0;mso-yfti-firstrow:yes;height:56.2pt">
                <td style="width:30.85pt;border:solid windowtext 1.0pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:56.2pt" valign="center" width="41">
                    <p align="center" class="MsoNormal">
                        <span lang="AZ-LATIN" style="font-size:12.0pt;mso-bidi-font-family:Arial;mso-ansi-language:
  AZ-LATIN">S/n</span></p>
                </td>
                <td style="width:86.85pt;border:solid windowtext 1.0pt;
  border-left:none;mso-border-left-alt:solid windowtext .5pt;mso-border-alt:
  solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:56.2pt" valign="center" width="116">
                    <p align="center" class="MsoNormal">
                        <span lang="AZ-LATIN" style="font-size:12.0pt;mso-ansi-language:AZ-LATIN">Adı, soyadı</span></p>
                </td>
                <td style="width:112.4pt;border:solid windowtext 1.0pt;
  border-left:none;mso-border-left-alt:solid windowtext .5pt;mso-border-alt:
  solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:56.2pt" valign="center" width="150">
                    <p align="center" class="MsoNormal">
                        <span lang="AZ-LATIN" style="font-size:12.0pt;mso-bidi-font-family:Arial;mso-ansi-language:
  AZ-LATIN">Şəhər, rayon</span></p>
                </td>
                <td style="width:116.8pt;border:solid windowtext 1.0pt;
  border-left:none;mso-border-left-alt:solid windowtext .5pt;mso-border-alt:
  solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:56.2pt" valign="center" width="156">
                    <p align="center" class="MsoNormal">
                        <span lang="AZ-LATIN" style="font-size: 12.0pt; mso-bidi-font-family: Arial; color: #141823; background: white; mso-ansi-language: AZ-LATIN">Şəhərə və rayona gəlmə tarixi</span></p>
                </td>
                <td style="width:123.85pt;border:solid windowtext 1.0pt;
  border-left:none;mso-border-left-alt:solid windowtext .5pt;mso-border-alt:
  solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:56.2pt" valign="center" width="165">
                    <p align="center" class="MsoNormal">
                        <span style="font-size: 12.0pt; mso-bidi-font-family: Arial; color: #141823; background: white; mso-ansi-language: EN-US">Şəhərdən və rayondan getmə tarixi</span></p>
                </td>
                <td style="width:123.85pt;border:solid windowtext 1.0pt;
  border-left:none;mso-border-left-alt:solid windowtext .5pt;mso-border-alt:
  solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:56.2pt" valign="center" width="165">
                    <p align="center" class="MsoNormal">
                        <span style="font-size: 12.0pt; mso-bidi-font-family: Arial; color: #141823; background: white; mso-ansi-language: EN-US">Baxış</span></p>
                </td>
            </tr>
            <asp:Repeater ID="rp3" runat="server">
                <ItemTemplate>
                    <tr style="mso-yfti-irow:1;mso-yfti-lastrow:yes;height:12.1pt">
                        <td style="width:30.85pt;border:solid windowtext 1.0pt;
  border-top:none;mso-border-top-alt:solid windowtext .5pt;mso-border-alt:solid windowtext .5pt;
  padding:0in 5.4pt 0in 5.4pt;height:12.1pt" valign="top" width="41">
                            <p align="center" class="MsoNormal">
                               <%#Container.ItemIndex+1 %>.</p>
                        </td>
                        <td style="width:86.85pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:12.1pt" valign="top" width="116">
                            <p align="left" class="MsoNormal">
                                <span lang="AZ-LATIN" style="font-size:12.0pt;mso-bidi-font-family:Arial;mso-ansi-language:
  AZ-LATIN">
       
                                    <%#Eval("Name")%>
                        
                                </span>
                              
                            </p>
                        </td>
                        <td style="width:112.4pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:12.1pt" valign="top" width="150">
                            <p align="left" class="MsoNormal">
                                <span lang="AZ-LATIN" style="font-size:12.0pt;mso-bidi-font-family:Arial;mso-ansi-language:
  AZ-LATIN">
                            
                                    <%#Eval("Regions")%>
                               
                                </span>
                        
                            </p>
                        </td>
                        <td style="width:116.8pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:12.1pt" valign="top" width="156">
                            <p align="center" class="MsoNormal">
                                <span lang="AZ-LATIN" style="font-size:12.0pt;mso-bidi-font-family:Arial;mso-ansi-language:
  AZ-LATIN">
                             
                                    <%#Class2.sozukes(Eval("RegionCome").ToString()) %>
                               
                                </span>
                             
                            </p>
                        </td>
                        <td style="width:123.85pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:12.1pt" valign="top" width="165">
                            <p align="center" class="MsoNormal">
                                <span lang="AZ-LATIN" style="font-size:12.0pt;mso-bidi-font-family:Arial;mso-ansi-language:
  AZ-LATIN">
                            
                                    <%#Class2.sozukes(Eval("GoFromRegion").ToString()) %>
                             
                                </span>
                               
                            </p>
                        </td>
                        <td style="width:123.85pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:12.1pt" valign="top" width="165">
                            <p align="center" class="MsoNormal">
                                <span lang="AZ-LATIN" style="font-size:12.0pt;mso-bidi-font-family:Arial;mso-ansi-language:
  AZ-LATIN"><a href='ezamiyye.aspx?BusinessTripID=<%#Eval("BusinessTripID") %>&amp;islem1=gorulmuwiw&amp;RegionID=<%#Eval("RegionID") %>&amp;controlBusinesTrip=1&amp;UserID=<%#Eval("UserID") %>'>Baxış</a></span></p>
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

