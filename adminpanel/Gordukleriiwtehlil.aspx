<%@ Page Title="" Language="C#" MasterPageFile="~/adminpanel/adminMasterPage.master" AutoEventWireup="true" CodeFile="Gordukleriiwtehlil.aspx.cs" Inherits="adminpanel_Gordukleriiw" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
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

        .auto-style7 {

            width: 40pt;
        }

        .auto-style8 {
  
            width: 40pt;
        }

        .auto-style9 {
  
            width: 45pt;
        }

        .auto-style10 {

            width: 45pt;
        }
          .auto-style11 {
              width: 27pt;
          }
          .auto-style12 {
              width: 71pt;
          }
          .auto-style13 {
              width: 40pt;
          }
          .auto-style14 {

              width: 76pt;
          }
          .auto-style15 {

              width: 76pt;
          }
          .auto-style16 {
              width: 76pt;
          }
          .auto-style23 {
              width: 327pt;
          }
          .auto-style24 {
              width: 318pt;
          }
          .auto-style25 {
              width: 77pt;
          }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    
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
                <asp:RadioButton ID="rdrayon" runat="server" Checked="True" GroupName="A" Text="Şəhər və rayonlar üzrə" Visible="False" />
                <br />
                <asp:RadioButton ID="rdmeqsed" runat="server" GroupName="A" Text="Məqsədlər üzrə" Visible="False" />
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
                <b style="mso-bidi-font-weight: normal"><span lang="AZ-LATIN" style="mso-ansi-language: AZ-LATIN">Şöbə əməkdaşlarının ezamiyyə dövründə gördükləri işlər barədə məlumat</span></b>
            </p>
            <p class="MsoNormal" style="text-align: justify">
                <span lang="AZ-LATIN" style="mso-ansi-language: AZ-LATIN">
                    <o:p>
        &nbsp;</o:p>
                </span>
            </p>
            <table border="1" cellpadding="0" cellspacing="0" class="MsoNormalTable" style="border-collapse: collapse; mso-table-layout-alt: fixed; border: none; mso-border-alt: solid windowtext .5pt; mso-yfti-tbllook: 1184; mso-padding-alt: 0in 5.4pt 0in 5.4pt; mso-border-insideh: .5pt solid windowtext; mso-border-insidev: .5pt solid windowtext"
                width="100%">
                <tr style="mso-yfti-irow: 0; mso-yfti-firstrow: yes">
                    <td rowspan="2" style="border: solid windowtext 1.0pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt"
                        valign="center" class="auto-style11">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">S/n</span></p>
                    </td>
                    <td rowspan="2" style="border-right: 1.0pt solid windowtext; border-top: 1.0pt solid windowtext; border-bottom: 1.0pt solid windowtext; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium;"
                        valign="center" class="auto-style12">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">Adı, soyadı</span></p>
                    </td>
                    <td colspan="5" style="width: 598.1pt; border: solid windowtext 1.0pt; border-left: none; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt"
                        valign="center" width="797">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                                <asp:Label ID="lblgelme2" runat="server" Text=""></asp:Label>
                                -
                    <asp:Label ID="lblgetme2" runat="server" Text=""></asp:Label>
                            </span>
                        </p>
                    </td>
                </tr>
                <tr style="mso-yfti-irow: 2; height: 38.25pt">
                    <td style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                        valign="top" class="auto-style14">


                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">Şəhər və rayonlara ezamiyyətlərin sayı</span></p>

                    </td>
                    <td style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                        valign="center" class="auto-style25">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">Şəhər, rayon</span></p>
                    </td>
                    <%--                    <td style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                        valign="center" class="auto-style4">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">Cəmi məqsəd sayı<b style="mso-bidi-font-weight: normal"><sup></sup></b></span>
                        </p>

                    </td>--%>
                    
                    <td class="auto-style24" style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;" valign="center">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">Görülmüş işlər</span></p>
                    </td>
                    <td class="auto-style23" style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;" valign="center">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">Əldə olunan nəticələr</span></p>
                    </td>
                    <td class="auto-style7" style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;" valign="center">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">Baxış</span></p>
                    </td>
                </tr>
                <tr style="mso-yfti-irow: 3; height: 17.25pt">
                    <td colspan="2" style="border-left: 1.0pt solid windowtext; border-right: 1.0pt solid windowtext; border-bottom: 1.0pt solid windowtext; mso-border-top-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 17.25pt; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                        valign="center" floa>
                        <p class="MsoNormal" style="text-align: right;">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">Cəmi:</span>

                        </p>
                    </td>
                    <td style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                        valign="center" class="auto-style15">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">
                                <o:p>
                <asp:Label runat="server" ID="lblezamsay"></asp:Label> </o:p>
                            </span>
                        </p>
                    </td>
                    <td style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                        valign="center" class="auto-style25">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">
                                <o:p>
                    <asp:Label ID="lblfreg" runat="server"></asp:Label> </o:p>
                            </span>
                        </p>
                    </td>
<%--                    <td style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                        valign="center" class="auto-style5">
                        <p align="center" class="MsoNormal" style="text-align: center;">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">
                         <a class="aucun" style="text-decoration:none;" href='Ezmeqsedtehlil.aspx?islem=rayon5&tarix1=<%= lblgelme3.Text %>&tarix2=<%= lblgetme3.Text %>&tarix3=<%= lblgelme4.Text %>&tarix4=<%= lblgetme4.Text %>&siralama1=<%= lblsira.Text %>&userkod=<%= lblkurator.Text %>&rayonkod=<%= lblrayon.Text %>'> 
       <asp:Label ID="lblcemmeq" runat="server"></asp:Label></a>
                            </span>
                        </p>
                    </td>--%>
                    
                    <td style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                        valign="center" class="auto-style24">
                        &nbsp;</td>
                    <td class="auto-style23" style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;" valign="center">&nbsp;</td>
              <td class="auto-style8" style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;" valign="center">&nbsp;</td>
                      </tr>








                <asp:Repeater ID="DataList1" runat="server">
                    <ItemTemplate>
                        <tr style="mso-yfti-irow: 4">
                            <td style="border-left: 1.0pt solid windowtext; border-right: 1.0pt solid windowtext; border-bottom: 1.0pt solid windowtext; word-break: break-all; mso-border-top-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                                valign="top" class="auto-style11">
                                <p align="center" class="MsoNormal" style="text-align: center">
                                    <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">
                                        <o:p>
                     <%#Container.ItemIndex+1 %>. <%--<%#Eval("Sn")%>--%></o:p>
                                    </span>
                                </p>
                            </td>
                            <td style="white-space: normal; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                                valign="top" class="auto-style12">
                                <p align="center" class="MsoNormal" style="text-align: left">
                                    <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">
                                        <o:p>
                     <%#Eval("Username")%></o:p>
                                    </span>
                                </p>
                            </td>
                            <td style="white-space: normal; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                                valign="top" class="auto-style16">
                                <p align="center" class="MsoNormal" style="text-align: center;">
                                    <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">
                                        <o:p>
                 <%#Eval("rynsay")%></o:p>
                                    </span>
                                </p>
                            </td>
                            <td style="white-space: normal; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                                valign="top" class="auto-style25">
                                <p align="center" class="MsoNormal" style="text-align: left">
                                    <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">
                                        <o:p>
                    <%#Eval("Name")%></o:p>
                                    </span>
                                </p>
                            </td>
<%--                            <td style="white-space: normal; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                                valign="top" class="auto-style6">
                                <p align="center" class="MsoNormal" style="text-align: center">
                                    <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">
                                        <o:p>
      <a class="aucun" style="text-decoration:none;" href='Ezmeqsedtehlil.aspx?userkod=<%#lblkurator.Text%>&rayonkod=<%#lblrayon.Text%>&PurposeID=<%#Eval("PurposeID")%>&islem=rayon5&tarix1=<%#lblgelme1.Text%>&tarix2=<%#lblgetme1.Text%>&tarix3=<%#lblgelme.Text%>&tarix4=<%#lblgetme.Text%>&siralama1=<%#lblsira.Text%>'><%#Eval("meqsedumumi")%></a>
                 
                   </o:p>
                                    </span>
                                </p>
                            </td>--%>
                            
                            <td style="white-space: normal; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                                valign="top" class="auto-style24">
                                <p align="center" class="MsoNormal" style="text-align: left">
                                    <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">
                                        <o:p>
                     <%#Eval("WorkView")%></o:p>
                                    </span>
                                </p>
                            </td>
                            <td style="white-space: normal; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                                valign="top" class="auto-style23">
                                <p align="center" class="MsoNormal" style="text-align: left">
                                    <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-ansi-language: AZ-LATIN">
                                        <o:p>
                     <%#Eval("ResultView")%></o:p>
                                    </span>
                                </p>
                            </td>
                            <td class="auto-style13" style="white-space: normal; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;" valign="top">
                                <p align="center" class="MsoNormal">
                                    <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                                 <a href="ezamiyye.aspx?BusinessTripID=<%#Eval("BusinessTripID") %>&islem1=goriwtehlil&RegionID=<%#Eval("RegionID") %>&controlBusinesTrip=1&UserID=<%#Eval("UserID") %>">Baxış</a>
                           </span></p>
                                         </td>
                        </tr>

                    </ItemTemplate>
                </asp:Repeater>
            </table>
            <p class="MsoNormal">
                <span style="mso-ansi-language: EN-US">
                    <o:p>
        &nbsp;</o:p>
                </span>
            </p>

        </asp:Panel>

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
                    <td style="width: 94.5pt; border: solid windowtext 1.0pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 55.2pt"
                        valign="center" width="126">
                        Kurator</td>
                    <td style="width: 85.5pt; border: solid windowtext 1.0pt; border-left: none; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 55.2pt"
                        valign="center" width="114">
                        <p align="center" class="MsoNormal">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">Getdiyi rayonların, şəhərlərin adı</span></p>
                    </td>
                    <td style="width: 85.5pt; border: solid windowtext 1.0pt; border-left: none; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 55.2pt" valign="center" width="114">
                        <p align="center" class="MsoNormal">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">Şəhərə və rayona gəlmə tarixi<b style="mso-bidi-font-weight: normal"><sup></sup></b></span></p>
                    </td>
                    <td style="width: 1.25in; border: solid windowtext 1.0pt; border-left: none; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 55.2pt"
                        valign="center" width="120">
                        <p align="center" class="MsoNormal">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">Şəhərdən və rayondan getmə tarixi<b style="mso-bidi-font-weight: normal"><sup><o:p></o:p></sup></b></span>
                        </p>
                    </td>
                    <td style="width: 154.4pt; border: solid windowtext 1.0pt; border-left: none; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 55.2pt"
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
                                        <o:p><a href="ezamiyye.aspx?BusinessTripID=<%#Eval("BusinessTripID") %>&islem1=ezmeqtehlil&RegionID=<%#Eval("RegionID") %>&controlBusinesTrip=1&UserID=<%#Eval("UserID") %>">Baxış</a></o:p>
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

