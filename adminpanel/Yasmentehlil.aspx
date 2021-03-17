<%@ Page Title="" Language="C#" MasterPageFile="~/adminpanel/adminMasterPage.master" AutoEventWireup="true" CodeFile="Yasmentehlil.aspx.cs" Inherits="adminpanel_Yasmentehlil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
      <style type="text/css">

        p.MsoNormal
	{margin-bottom:.0001pt;
	font-size:11.0pt;
	font-family:"Arial","sans-serif";
	        margin-left: 0in;
            margin-right: 0in;
            margin-top: 0in;
        }
 table.MsoNormalTable
	{font-size:11.0pt;
	font-family:"Arial","sans-serif";
              width: 1013px;
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

        <div style="float: left; width: 346px; padding-top: 10px;  height: 158px;">
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

        <div style="float: left; width: 284px; height: 198px;">
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

        <div style="float: left; width: 377px; height: 195px;">
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

        <span lang="AZ-LATIN" style="mso-ansi-language:AZ-LATIN">
        <p align="center" class="MsoNormal">
            <b style="mso-bidi-font-weight:
normal"><span lang="AZ-LATIN" style="font-size:12.0pt;mso-ansi-language:AZ-LATIN">Şöbə əməkdaşlarının ezamiyyətlər dövründə olduqları yaşayış məntəqələri barədə məlumat</span></b></p>
        <p align="center" class="MsoNormal">
            &nbsp;</p>
        </span>
        <table  cellpadding="0" cellspacing="0" class="MsoNormalTable" width="1036">
            <tr style="mso-yfti-irow:0;mso-yfti-firstrow:yes;height:11.75pt">
                <td rowspan="3" style="width:33.95pt;border:solid windowtext 1.0pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:11.75pt" valign="center" width="45">
                    <p align="center" class="MsoNormal">
                        <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">S/n</span></p>
                </td>
                <td rowspan="3" style="width:72.35pt;border:solid windowtext 1.0pt;
  border-left:none;mso-border-left-alt:solid windowtext .5pt;mso-border-alt:
  solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:11.75pt" valign="center" width="96">
                    <p align="center" class="MsoNormal">
                        <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">Adı, soyadı</span></p>
                </td>
                <td colspan="7" style="width:671.05pt;border:solid windowtext 1.0pt;
  border-left:none;mso-border-left-alt:solid windowtext .5pt;mso-border-alt:
  solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:11.75pt" valign="center" width="895">
                    <p align="center" class="MsoNormal">
                        <span lang="AZ-LATIN" style="font-size:
  11.0pt;mso-bidi-font-family:Arial;mso-ansi-language:AZ-LATIN">
                        <asp:Label ID="lblgelme2" runat="server" Text=""></asp:Label>
                        -
                        <asp:Label ID="lblgetme2" runat="server" Text=""></asp:Label>
                        </span>
                    </p>
                </td>
            </tr>
            <tr style="mso-yfti-irow:1;height:11.25pt">
                <td rowspan="2" style="width:89.05pt;border-top:none;
  border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:11.25pt" valign="center" width="119">
                    <p align="center" class="MsoNormal">
                        <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">Şəhər və rayonlara ezamiyyətlərin sayı</span></p>
                </td>
                <td rowspan="2" style="width:104.75pt;border-top:none;
  border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:11.25pt" valign="center" width="140">
                    <p align="center" class="MsoNormal">
                        <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">Şəhər, rayon</span></p>
                </td>
                <td colspan="5" style="width:477.25pt;border-top:none;
  border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:11.25pt" valign="center" width="636">
                    <p align="center" class="MsoNormal">
                        <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">Yaşayış məntəqələri</span></p>
                </td>
            </tr>
            <tr style="mso-yfti-irow:2;height:34.75pt">
                <td style="width:115.4pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:34.75pt" valign="center" width="154">
                    <p align="center" class="MsoNormal">
                        <span lang="RU" style="font-size: 11.0pt; mso-bidi-font-family: Arial; color: #141823; background: white">Yaşayış məntəqələrinin sayı</span></p>
                </td>
                                <td style="width:84.0pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:34.75pt" valign="center" width="112">
                    <p align="center" class="MsoNormal">
                        Olduğu yaşayış məntəqələrinin sayı</p>
                </td>
                <td style="width:84.0pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:34.75pt" valign="center" width="112">
                    <p align="center" class="MsoNormal">
                        <span lang="RU" style="font-size: 11.0pt; mso-bidi-font-family: Arial; color: #141823; background: white">Əhatəlilik</span><span lang="RU" style="font-size: 11.0pt; mso-bidi-font-family: Arial; color: #141823; background: white; mso-ansi-language: AZ-LATIN"> </span><span lang="RU" style="font-size: 11.0pt; mso-bidi-font-family: Arial; color: #141823; background: white">(Faiz)</span></p>
                </td>

                <td style="width:84.0pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:34.75pt" valign="center" width="112">
                    <p align="center" class="MsoNormal">
                        <span lang="RU" style="font-size: 11.0pt; mso-bidi-font-family: Arial; color: #141823; background: white">Adı</span></p>
                </td>
                <td style="width:84.0pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:34.75pt" valign="center" width="112">
                    <p align="center" class="MsoNormal">
                        <span lang="RU" style="font-size: 11.0pt; mso-bidi-font-family: Arial; color: #141823; background: white">Olmuşdur (dəfə)</span></p>
                </td>
            </tr>
            <tr style="mso-yfti-irow:3;height:18.7pt">
                <td colspan="2" style="width:106.3pt;border:solid windowtext 1.0pt;
  border-top:none;mso-border-top-alt:solid windowtext .5pt;mso-border-alt:solid windowtext .5pt;
  padding:0in 5.4pt 0in 5.4pt;height:18.7pt" valign="center" width="142">
                    <p align="right" class="MsoNormal">
                        <span lang="AZ-LATIN" style="font-size:11.0pt;mso-ansi-language:AZ-LATIN">Cəmi</span></p>
                </td>
                <td style="width:89.05pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:18.7pt" valign="center" width="119">
                    <p align="center" class="MsoNormal">
                        <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">
                        <asp:Label ID="lblezamsay" runat="server"></asp:Label>
                        </span>
                    </p>
                </td>
                <td style="width:104.75pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:18.7pt" valign="center" width="140">
                    <p align="center" class="MsoNormal">
                        <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">
                        <asp:Label ID="lblfreg" runat="server"></asp:Label>
                        </span>
                    </p>
                </td>
                <td style="width:115.4pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:18.7pt" valign="center" width="154">
                    <p align="center" class="MsoNormal">
                        <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">
                        <asp:Label ID="lblfmetn" runat="server"></asp:Label>
                        </span></p>
                </td>
                <td style="width:84.0pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:18.7pt" valign="center" width="112">
                    <p align="center" class="MsoNormal">
                        <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">
                        <asp:Label ID="lblolferqli" runat="server"></asp:Label>
                        </span></p>
                </td>
                <td style="width:84.0pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:18.7pt" valign="center" width="112">
                    <p align="center" class="MsoNormal">
                       <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">
                        <asp:Label ID="lblehatelik" runat="server"></asp:Label>
                        </span></p>
                </td>
                <td style="width:84.0pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:18.7pt" valign="center" width="112">
                    <p align="center" class="MsoNormal">
                        &nbsp;</p>
                </td>
                <td style="width:84.0pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:18.7pt" valign="center" width="112">
                    <p align="center" class="MsoNormal">
                        <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">
                        
                                <a class="aucun" href='Yasmentehlil.aspx?islem=rayon5&tarix1=<%=lblgelme1.Text%>&amp;tarix2=<%=lblgetme1.Text%>&amp;tarix3=<%=lblgelme.Text%>&amp;tarix4=<%=lblgetme.Text%>' style="text-decoration:none;">
                                   <asp:Label ID="lblolyasmen" runat="server"></asp:Label></a>
                        </span></p>
                </td>
            </tr>


                 <asp:Repeater ID="DataList1" runat="server">
                    <ItemTemplate>

            <tr style="mso-yfti-irow:4;height:12.55pt">
                <td style="width:33.95pt;border:solid windowtext 1.0pt;
  border-top:none;mso-border-top-alt:solid windowtext .5pt;mso-border-alt:solid windowtext .5pt;
  padding:0in 5.4pt 0in 5.4pt;height:12.55pt" valign="top" width="45">
                    <p align="center" class="MsoNormal">
                        <%#Container.ItemIndex+1 %>.</p>
                </td>
                <td style="width:72.35pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:12.55pt" valign="top" width="96">
                    <p align="left" class="MsoNormal">
                        <%#Eval("Username")%>
                    </p>
                </td>
                <td style="width:89.05pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:12.55pt" valign="top" width="119">
                    <p align="center" class="MsoNormal">
                        <%#Eval("rynsay")%>
                    </p>
                </td>
                <td style="width:104.75pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:12.55pt" valign="top" width="140">
                    <p align="left" class="MsoNormal">
                        <%#Eval("Name")%>
                    </p>
                </td>
                <td style="width:115.4pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:12.55pt" valign="top" width="154">
                    <p align="center" class="MsoNormal">
                        <%#Eval("cemimensayi")%></p>
                </td>
<%--                <td style="width:109.85pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:12.55pt" valign="top" width="146">
                    <p align="center" class="MsoNormal">
                       <%#Eval("oldsay")%></p>
                </td>--%>
                                <td style="width:84.0pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:12.55pt" valign="top" width="112">
                    <p align="center" class="MsoNormal">
                     <%#Eval("oldsayi")%>  </p>
                </td>
                <td style="width:84.0pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:12.55pt" valign="top" width="112">
                    <p align="center" class="MsoNormal">
                   <%#Eval("ehatefaiz")%></p>
                </td>

                <td style="width:84.0pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:12.55pt" valign="top" width="112">
                    <p align="left" class="MsoNormal">
                        <%#Eval("LivingOther")%>
                    </p>
                </td>
                <td style="width:84.0pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:12.55pt" valign="top" width="112">
                    <p align="center" class="MsoNormal">
                        <a class="aucun" href='Yasmentehlil.aspx?LivingID=<%#Eval("LivingID")%>&amp;UserID=<%#Eval("UserID")%>&amp;islem=rayon5&amp;RegionID=<%#Eval("RegionID")%>&amp;tarix1=<%#lblgelme1.Text%>&amp;tarix2=<%#lblgetme1.Text%>&amp;tarix3=<%#lblgelme.Text%>&amp;tarix4=<%#lblgetme.Text%>' style="text-decoration:none;"><%#Eval("meqseds") %></a>
                    </p>
                </td>
            </tr>
                        </ItemTemplate>
                     </asp:Repeater>
        </table>
   
    </asp:Panel>

        </asp:Panel>
     <div class="temizle"></div>
        <br />
        <asp:Panel ID="pnlbirinci" Visible="false" runat="server">
  <asp:Button ID="btnworde" runat="server"  Text="Wordə çıxart" Width="120px" OnClick="btnworde_Click" />
        <br />
        <br />
          <asp:Panel ID="pnlprnt" runat="server">
       
       <div>
           <table  cellpadding="0" cellspacing="0" class="MsoNormalTable">
               <tr style="mso-yfti-irow:0;mso-yfti-firstrow:yes;height:56.2pt">
                   <td style="width:30.85pt;border:solid windowtext 1.0pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:56.2pt" valign="center" width="41">
                       <p align="center" class="MsoNormal">
                           <b style="mso-bidi-font-weight:normal"><span lang="AZ-LATIN" style="font-size:
  11.0pt;mso-bidi-font-family:Arial;mso-ansi-language:AZ-LATIN">S/n</span></b></p>
                   </td>
                   <td style="width:86.85pt;border:solid windowtext 1.0pt;
  border-left:none;mso-border-left-alt:solid windowtext .5pt;mso-border-alt:
  solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:56.2pt" valign="center" width="116">
                       <p align="center" class="MsoNormal">
                           <b style="mso-bidi-font-weight:normal"><span lang="AZ-LATIN" style="font-size:
  11.0pt;mso-ansi-language:AZ-LATIN">Adı, soyadı</span></b></p>
                   </td>
                   <td style="width:112.4pt;border:solid windowtext 1.0pt;
  border-left:none;mso-border-left-alt:solid windowtext .5pt;mso-border-alt:
  solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:56.2pt" valign="center" width="150">
                       <p align="center" class="MsoNormal">
                           <b style="mso-bidi-font-weight:normal"><span lang="AZ-LATIN" style="font-size:
  11.0pt;mso-bidi-font-family:Arial;mso-ansi-language:AZ-LATIN">Şəhər, rayon</span></b></p>
                   </td>
                   <td style="width:116.8pt;border:solid windowtext 1.0pt;
  border-left:none;mso-border-left-alt:solid windowtext .5pt;mso-border-alt:
  solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:56.2pt" valign="center" width="156">
                       <p align="center" class="MsoNormal">
                           <b style="mso-bidi-font-weight:normal"><span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; color: #141823; background: white; mso-ansi-language: AZ-LATIN">Şəhərə və rayona gəlmə tarixi</span></b></p>
                   </td>
                   <td style="width:123.85pt;border:solid windowtext 1.0pt;
  border-left:none;mso-border-left-alt:solid windowtext .5pt;mso-border-alt:
  solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:56.2pt" valign="center" width="165">
                       <p align="center" class="MsoNormal">
                           <b style="mso-bidi-font-weight:normal"><span style="font-size: 11.0pt; mso-bidi-font-family: Arial; color: #141823; background: white; mso-ansi-language: EN-US">Şəhərdən və rayondan getmə tarixi</span></b></p>
                   </td>
                   <td style="width:163.75pt;border:solid windowtext 1.0pt;
  border-left:none;mso-border-left-alt:solid windowtext .5pt;mso-border-alt:
  solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:56.2pt" valign="center" width="218">
                       <p align="center" class="MsoNormal">
                           <strong><span lang="RU" style="font-size: 11.0pt; font-family: &quot;Arial&quot;,&quot;sans-serif&quot;; color: #141823; background: white">Yaşayış məntəqələri</span></strong></p>
                   </td>
                                       <asp:Panel ID="pnlbaxiw0" runat="server">
                   <td style="width:83.95pt;border:solid windowtext 1.0pt;
  border-left:none;mso-border-left-alt:solid windowtext .5pt;mso-border-alt:
  solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:56.2pt" valign="center" width="112">
                       <p align="center" class="MsoNormal">
                           <strong><span style="font-size: 11.0pt; font-family: &quot;Arial&quot;,&quot;sans-serif&quot;; color: #141823; background: white; mso-ansi-language: EN-US">Baxış</span></strong></p>
                   </td>
                                           </asp:Panel>
               </tr>
               <asp:Repeater ID="DataList3" runat="server">
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
                               <p align="center" class="MsoNormal">
                                   <%#Eval("Username")%>
                               </p>
                           </td>
                           <td style="width:112.4pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:12.1pt" valign="top" width="150">
                               <p align="center" class="MsoNormal">
                                   <%#Eval("Regions")%>
                               </p>
                           </td>
                           <td style="width:116.8pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:12.1pt" valign="top" width="156">
                               <p align="center" class="MsoNormal">
                                   <%#Class2.sozukes(Eval("RegionCome").ToString()) %>
                               </p>
                           </td>
                           <td style="width:123.85pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:12.1pt" valign="top" width="165">
                               <p align="center" class="MsoNormal">
                                   <%#Class2.sozukes(Eval("GoFromRegion").ToString()) %>
                               </p>
                           </td>
                           <td style="width:163.75pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:12.1pt" valign="top" width="218">
                               <p align="center" class="MsoNormal">
                                   <%#Eval("LivingOther") %>
                               </p>
                           </td>
                           <asp:Panel ID="pnlbaxiw1" runat="server">
                           <td style="width:83.95pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:12.1pt" valign="top" width="112">
                               <p align="center" class="MsoNormal">
                                  <a href="ezamiyye.aspx?BusinessTripID=<%#Eval("BusinessTripID") %>&islem1=Yasmentehlil&RegionID=<%#Eval("RegionID") %>&controlBusinesTrip=1&UserID=<%#Eval("UserID") %>">Baxış</a></p>
                           </td>
                               </asp:Panel>
                       </tr>
                   </ItemTemplate>
               </asp:Repeater>
           </table>
            </div>
              </asp:Panel>
    </asp:Panel>

</asp:Content>

