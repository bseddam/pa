<%@ Page Title="" Language="C#" MasterPageFile="~/adminpanel/adminMasterPage.master" AutoEventWireup="true" CodeFile="Baxkecisttehlil.aspx.cs" Inherits="adminpanel_Baxkecisttehlil" %>

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

        table.MsoNormalTable {
            font-size: 11.0pt;
            font-family: "Arial","sans-serif";
            width: 1021px;
        }
        .auto-style3 {
            height: 8.35pt;
            width: 147pt;
        }
        .auto-style4 {
            width: 147pt;
        }
        .auto-style5 {
            height: 8.35pt;
            width: 116pt;
        }
        .auto-style6 {
            width: 116pt;
        }
        .auto-style7 {
            height: 8.35pt;
            width: 83pt;
        }
        .auto-style8 {
            width: 83pt;
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

            <div style="float: left; width: 346px; padding-top: 10px; height: 208px;">
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
                <b style="mso-bidi-font-weight: normal"><span lang="AZ-LATIN"  style="font-size:12.0pt; mso-ansi-language: AZ-LATIN">Şöbə əməkdaşları tərəfindən ezamiyyətlərdə baxış keçirilmiş istismarda olan obyektlər 
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



            <table border="1" cellpadding="0" cellspacing="0" class="MsoNormalTable" style="border-style: none; border-color: inherit; border-width: medium; border-collapse: collapse; mso-table-layout-alt: fixed; mso-border-alt: solid windowtext .5pt; mso-yfti-tbllook: 1184; mso-padding-alt: 0in 5.4pt 0in 5.4pt; mso-border-insideh: .5pt solid windowtext; mso-border-insidev: .5pt solid windowtext; width: 1018px;">
                <tr style="mso-yfti-irow: 0; mso-yfti-firstrow: yes">
                    <td rowspan="4" style="width: 29.2pt; border: solid windowtext 1.0pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt"
                        valign="center" width="39">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="mso-bidi-font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">S/n<o:p></o:p></span>
                        </p>
                    </td>
                    <td rowspan="4" style="width: 108.8pt; border: solid windowtext 1.0pt; border-left: none; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt"
                        valign="center" width="145">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="mso-bidi-font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">Adı, soyadı<o:p></o:p></span>
                        </p>
                    </td>
                    <td colspan="8" style="width: 610.15pt; border: solid windowtext 1.0pt; border-left: none; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt"
                        valign="center" width="814">
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
                    <td rowspan="3" style="width: 76.4pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 16.2pt"
                        valign="center" width="102">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="mso-bidi-font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">Şəhər və rayonlara ezamiyyətlərin sayı<o:p></o:p></span>
                        </p>
                    </td>
                    <td rowspan="3" style="width: 83.3pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 16.2pt"
                        valign="center" width="111">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="mso-bidi-font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">Şəhər, rayon<o:p></o:p></span>
                        </p>
                    </td>
                    <td colspan="6" style="width: 450.45pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 16.2pt"
                        valign="center" width="601">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="mso-bidi-font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">Baxış keçirilmiş istismarda olan obyektlər<b style="mso-bidi-font-weight: normal"><sup><o:p></o:p></sup></b></span>
                        </p>
                    </td>
                </tr>
                <tr style="mso-yfti-irow: 2; height: 15.65pt">
                    <td rowspan="2" style="width: 85.35pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 15.65pt"
                        valign="center" width="114">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="mso-bidi-font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">Yaşayış məntəqəsi<b style="mso-bidi-font-weight: normal"><sup><o:p></o:p></sup></b></span>
                        </p>
                    </td>
                    <td rowspan="2" style="width: 89.5pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 15.65pt"
                        valign="center" width="119">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="mso-bidi-font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">Sahələr üzrə<b style="mso-bidi-font-weight: normal"><sup><o:p></o:p></sup></b></span>
                        </p>
                    </td>
                    <td rowspan="2" style="width: 116.95pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 15.65pt"
                        valign="center" width="156">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="mso-bidi-font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">Təyinatı üzrə<b style="mso-bidi-font-weight: normal"><sup><o:p></o:p></sup></b></span>
                        </p>
                    </td>
                    <td colspan="3" style="width: 158.65pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 15.65pt"
                        valign="center" width="212">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="mso-bidi-font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">İstismar vəziyyəti<b style="mso-bidi-font-weight: normal"><sup><o:p></o:p></sup></b></span>
                        </p>
                    </td>
                </tr>
                <tr style="mso-yfti-irow: 3; height: 22.55pt">
                    <td style="width: 47.6pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 22.55pt"
                        valign="center" width="63">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="mso-bidi-font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">əla<b style="mso-bidi-font-weight: normal"><sup><o:p></o:p></sup></b></span>
                        </p>
                    </td>
                    <td style="width: 53.8pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 22.55pt"
                        valign="center" width="72">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="mso-bidi-font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">yararlı<b style="mso-bidi-font-weight: normal"><sup><o:p></o:p></sup></b></span>
                        </p>
                    </td>
                    <td style="width: 57.25pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 22.55pt"
                        valign="center" width="76">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="mso-bidi-font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">yararsız<b style="mso-bidi-font-weight: normal"><sup><o:p></o:p></sup></b></span>
                        </p>
                    </td>
                </tr>
                <tr style="mso-yfti-irow: 4; height: 8.35pt">
                    <td colspan="2" style="width: 138.0pt; border: solid windowtext 1.0pt; border-top: none; mso-border-top-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 8.35pt"
                        valign="center" width="184">
                        <p align="right" class="MsoNormal" style="text-align: right">
                            <span lang="AZ-LATIN" style="mso-bidi-font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">Cəmi:</span><b style="mso-bidi-font-weight: normal"><sup><span style="mso-bidi-font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: EN-US"><o:p></o:p></span></sup></b>
                        </p>
                    </td>
                    <td style="width: 76.4pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 8.35pt"
                        valign="center" width="102">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="mso-bidi-font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                                <o:p>
                      <asp:Label runat="server" ID="lblezamsay"></asp:Label></o:p>
                            </span>
                        </p>
                    </td>
                    <td style="width: 83.3pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 8.35pt"
                        valign="center" width="111">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="mso-bidi-font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                                <o:p>
                    <asp:Label ID="lblfreg" runat="server"></asp:Label></o:p>
                            </span>
                        </p>
                    </td>
                    <td style="width: 85.35pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 8.35pt"
                        valign="center" width="114">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="mso-bidi-font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                                <o:p>
                   <asp:Label ID="lblferqli" runat="server"></asp:Label></o:p>
                            </span>
                        </p>
                    </td>
                    <td style="width: 89.5pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 8.35pt"
                        valign="center" width="119">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="mso-bidi-font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                                <o:p>
                  <asp:Label ID="lblsaheler" runat="server"></asp:Label></o:p>
                            </span>
                        </p>
                    </td>
                    <td style="width: 116.95pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 8.35pt"
                        valign="center" width="156">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="mso-bidi-font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                                <o:p>
                    <asp:Label ID="lblteyuzre" runat="server"></asp:Label></o:p>
                            </span>
                        </p>
                    </td>
                    <td style="width: 47.6pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 8.35pt"
                        valign="center" width="63">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="mso-bidi-font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                                <o:p>
                               <a class="aucun" style="text-decoration:none;" href='Baxkecisttehlil.aspx?islem=rayon5&Construction_works=əla&SubObjectID=<%= lblteyinat.Text %>&ObjectID=<%= lblsahe.Text %>&userkod=<%= lblkurator.Text %>&rayonkod=<%= lblrayon.Text %>>&tarix1=<%=lblgelme1.Text%>&tarix2=<%=lblgetme1.Text%>&tarix3=<%=lblgelme.Text%>&tarix4=<%=lblgetme.Text%>&siralama1=<%=lblsira.Text%>'> <asp:Label ID="lblela" runat="server"></asp:Label></a>      
                                    
                   </o:p>
                            </span>
                        </p>
                    </td>
                    <td style="width: 53.8pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 8.35pt"
                        valign="center" width="72">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="mso-bidi-font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                                <o:p>
              <a class="aucun" style="text-decoration:none;" href='Baxkecisttehlil.aspx?islem=rayon5&Construction_works=yararlı&SubObjectID=<%= lblteyinat.Text %>&ObjectID=<%= lblsahe.Text %>&userkod=<%= lblkurator.Text %>&rayonkod=<%= lblrayon.Text %>>&tarix1=<%=lblgelme1.Text%>&tarix2=<%=lblgetme1.Text%>&tarix3=<%=lblgelme.Text%>&tarix4=<%=lblgetme.Text%>&siralama1=<%=lblsira.Text%>'> <asp:Label ID="lblyararli" runat="server"></asp:Label> </a>      

                                </o:p>
                            </span>
                        </p>
                    </td>
                    <td style="width: 57.25pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 8.35pt"
                        valign="center" width="76">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="mso-bidi-font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                                <o:p>
                <a class="aucun" style="text-decoration:none;" href='Baxkecisttehlil.aspx?islem=rayon5&Construction_works=yararsız&SubObjectID=<%= lblteyinat.Text %>&ObjectID=<%= lblsahe.Text %>&userkod=<%= lblkurator.Text %>&rayonkod=<%= lblrayon.Text %>>&tarix1=<%=lblgelme1.Text%>&tarix2=<%=lblgetme1.Text%>&tarix3=<%=lblgelme.Text%>&tarix4=<%=lblgetme.Text%>&siralama1=<%=lblsira.Text%>'>  <asp:Label ID="lblyararsiz" runat="server"></asp:Label> </a>      
    </o:p>
                            </span>
                        </p>
                    </td>
                </tr>




                <asp:Repeater ID="DataList1" runat="server">
                    <ItemTemplate>


                        <tr style="mso-yfti-irow: 5; mso-yfti-lastrow: yes">
                            <td style="width: 29.2pt; border: solid windowtext 1.0pt; border-top: none; mso-border-top-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt"
                                valign="center" width="39">
                                <p align="center" class="MsoNormal" style="text-align: center">
                                    <span lang="AZ-LATIN" style="mso-bidi-font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                                        <o:p>
                    <%#Container.ItemIndex+1 %>.</o:p>
                                    </span>
                                </p>
                            </td>
                            <td style="width: 108.8pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt"
                                valign="center" width="145">
                                <p align="center" class="MsoNormal" style="text-align: left">
                                    <span lang="AZ-LATIN" style="mso-bidi-font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                                        <o:p>
                   <%#Eval("Username")%></o:p>
                                    </span>
                                </p>
                            </td>
                            <td style="width: 76.4pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt"
                                valign="center" width="102">
                                <p align="center" class="MsoNormal" style="text-align: center">
                                    <span lang="AZ-LATIN" style="mso-bidi-font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                                        <o:p>
                     <%#Eval("rynsay")%></o:p>
                                    </span>
                                </p>
                            </td>
                            <td style="width: 83.3pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt"
                                valign="center" width="111">
                                <p align="center" class="MsoNormal" style="text-align: left">
                                    <span lang="AZ-LATIN" style="mso-bidi-font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                                        <o:p>
                  <%#Eval("Name")%></o:p>
                                    </span>
                                </p>
                            </td>
                            <td style="width: 85.35pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt"
                                valign="center" width="114">
                                <p align="center" class="MsoNormal" style="text-align: left">
                                    <span lang="AZ-LATIN" style="mso-bidi-font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                                        <o:p>
                 <%#Eval("Living_Point")%></o:p>
                                    </span>
                                </p>
                            </td>
                            <td style="width: 89.5pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt"
                                valign="center" width="119">
                                <p align="center" class="MsoNormal" style="text-align: left">
                                    <span lang="AZ-LATIN" style="mso-bidi-font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                                        <o:p>
                  <%#Eval("ObjectOther")%>  </o:p>
                                    </span>
                                </p>
                            </td>
                            <td style="width: 116.95pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt"
                                valign="center" width="156">
                                <p align="center" class="MsoNormal" style="text-align: left">
                                    <span lang="AZ-LATIN" style="mso-bidi-font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                                        <o:p>
                   <%#Eval("SubObjectOther")%>  </o:p>
                                    </span>
                                </p>
                            </td>
                            <td style="width: 47.6pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt"
                                valign="center" width="63">
                                <p align="center" class="MsoNormal" style="text-align: center">
                                    <span lang="AZ-LATIN" style="mso-bidi-font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                                        <o:p>
                    <a class="aucun" style="text-decoration:none;" href='Baxkecisttehlil.aspx?islem=rayon5&Construction_works=əla&SubObjectID=<%#Eval("SubObjectID")%>&Living_PointID=<%#Eval("Living_PointID")%>&ObjectID=<%#Eval("ObjectID")%>&UserID=<%#Eval("UserID")%>&RegionID=<%#Eval("RegionID")%>&tarix1=<%#lblgelme1.Text%>&tarix2=<%#lblgetme1.Text%>&tarix3=<%#lblgelme.Text%>&tarix4=<%#lblgetme.Text%>&siralama1=<%#lblsira.Text%>'><%#Eval("ela") %></a>   </o:p>
                                    </span>
                                </p>
                            </td>
                            <td style="width: 53.8pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt"
                                valign="center" width="72">
                                <p align="center" class="MsoNormal" style="text-align: center">
                                    <span lang="AZ-LATIN" style="mso-bidi-font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                                        <o:p>
                <a class="aucun" style="text-decoration:none;" href='Baxkecisttehlil.aspx?islem=rayon5&Construction_works=yararlı&SubObjectID=<%#Eval("SubObjectID")%>&Living_PointID=<%#Eval("Living_PointID")%>&ObjectID=<%#Eval("ObjectID")%>&UserID=<%#Eval("UserID")%>&RegionID=<%#Eval("RegionID")%>&tarix1=<%#lblgelme1.Text%>&tarix2=<%#lblgetme1.Text%>&tarix3=<%#lblgelme.Text%>&tarix4=<%#lblgetme.Text%>&siralama1=<%#lblsira.Text%>'><%#Eval("yararli") %></a>  </o:p>
                                    </span>
                                </p>
                            </td>
                            <td style="width: 57.25pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt"
                                valign="center" width="76">
                                <p align="center" class="MsoNormal" style="text-align: center">
                                    <span lang="AZ-LATIN" style="mso-bidi-font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                                        <o:p>
                  <a class="aucun" style="text-decoration:none;" href='Baxkecisttehlil.aspx?islem=rayon5&Construction_works=yararsız&SubObjectID=<%#Eval("SubObjectID")%>&Living_PointID=<%#Eval("Living_PointID")%>&ObjectID=<%#Eval("ObjectID")%>&UserID=<%#Eval("UserID")%>&RegionID=<%#Eval("RegionID")%>&tarix1=<%#lblgelme1.Text%>&tarix2=<%#lblgetme1.Text%>&tarix3=<%#lblgelme.Text%>&tarix4=<%#lblgetme.Text%>&siralama1=<%#lblsira.Text%>'><%#Eval("yararsiz") %></a> </o:p>
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


                <asp:Panel ID="pnlbirinci"  runat="server">

                <asp:Button ID="exele0" runat="server" Text="Wordə çıxart" OnClick="exele0_Click" Width="120px" />
        <br />
        <br />

    
              <asp:Panel ID="pnlprint" runat="server">

            <table  cellpadding="0" cellspacing="0" class="MsoNormalTable">
                <tr style="mso-yfti-irow:0;mso-yfti-firstrow:yes;height:8.35pt">
                    <td style="width:50.2pt;border:solid windowtext 1.0pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:8.35pt" valign="center" width="67">
                        <p align="center" class="MsoNormal">
                            <span style="font-size: 11.0pt; mso-bidi-font-family: Arial; color: #141823; background: white; mso-ansi-language: EN-US">Kurator</span></p>
                    </td>
                    <td style="width:67.5pt;border:solid windowtext 1.0pt;
  border-left:none;mso-border-left-alt:solid windowtext .5pt;mso-border-alt:
  solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:8.35pt" valign="center" width="90">
                        <p align="center" class="MsoNormal">
                            <span lang="RU" style="font-size: 11.0pt; mso-bidi-font-family: Arial; color: #141823; background: white">Şəhər, rayon</span></p>
                    </td>
                    <td style="width:67.5pt;border:solid windowtext 1.0pt;
  border-left:none;mso-border-left-alt:solid windowtext .5pt;mso-border-alt:
  solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:8.35pt" valign="center" width="90">
                        <p align="center" class="MsoNormal">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; color: #141823; background: white; mso-ansi-language: AZ-LATIN">Şəhərə və rayona gəlmə tarixi</span></p>
                    </td>
                    <td style="width:1.0in;border:solid windowtext 1.0pt;
  border-left:none;mso-border-left-alt:solid windowtext .5pt;mso-border-alt:
  solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:8.35pt" valign="center" width="96">
                        <p align="center" class="MsoNormal">
                            <span style="font-size: 11.0pt; mso-bidi-font-family: Arial; color: #141823; background: white; mso-ansi-language: EN-US">Şəhərdən və rayondan getmə tarixi</span></p>
                    </td>
                    <td style="width:63.0pt;border:solid windowtext 1.0pt;
  border-left:none;mso-border-left-alt:solid windowtext .5pt;mso-border-alt:
  solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:8.35pt" valign="center" width="84">
                        <p align="center" class="MsoNormal">
                            <span lang="RU" style="font-size: 11.0pt; mso-bidi-font-family: Arial; color: #141823; background: white">Yaşayış məntəqəsi</span></p>
                    </td>
                    <td style="width:67.5pt;border:solid windowtext 1.0pt;
  border-left:none;mso-border-left-alt:solid windowtext .5pt;mso-border-alt:
  solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:8.35pt" valign="center" width="90">
                        <p align="center" class="MsoNormal">
                            <span lang="RU" style="font-size: 11.0pt; mso-bidi-font-family: Arial; color: #141823; background: white">Sahələr üzrə</span></p>
                    </td>
                    <td style="border-right: 1.0pt solid windowtext; border-top: 1.0pt solid windowtext; border-bottom: 1.0pt solid windowtext; mso-border-left-alt:solid windowtext .5pt; mso-border-alt:
  solid windowtext .5pt; padding:0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium;" valign="center" class="auto-style7">
                        <p align="center" class="MsoNormal">
                            <span lang="RU" style="font-size: 11.0pt; mso-bidi-font-family: Arial; color: #141823; background: white">Təyinatı üzrə</span></p>
                    </td>
                    <td style="border-right: 1.0pt solid windowtext; border-top: 1.0pt solid windowtext; border-bottom: 1.0pt solid windowtext; mso-border-left-alt:solid windowtext .5pt; mso-border-alt:
  solid windowtext .5pt; padding:0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium;" valign="center" class="auto-style3">
                        <p align="center" class="MsoNormal">
                            <span lang="RU" style="font-size: 11.0pt; mso-bidi-font-family: Arial; color: #141823; background: white">İstismar vəziyyəti</span></p>
                    </td>
                    <td style="border-right: 1.0pt solid windowtext; border-top: 1.0pt solid windowtext; border-bottom: 1.0pt solid windowtext; mso-border-left-alt:solid windowtext .5pt; mso-border-alt:
  solid windowtext .5pt; padding:0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium;" valign="center" class="auto-style5">
                        <p align="center" class="MsoNormal">
                            <span lang="RU" style="font-size: 11.0pt; mso-bidi-font-family: Arial; color: #141823; background: white">Görülmüş işlər</span></p>
                    </td>
                    <td style="width:102.95pt;border:solid windowtext 1.0pt;
  border-left:none;mso-border-left-alt:solid windowtext .5pt;mso-border-alt:
  solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:8.35pt" valign="center" width="137">
                        <p align="center" class="MsoNormal">
                            <span lang="RU" style="font-size: 11.0pt; mso-bidi-font-family: Arial; color: #141823; background: white">Əldə olunan nəticə</span></p>
                    </td>
                         <asp:Panel ID="pnlbaxiw0" runat="server">
                    <td style="width:57.25pt;border:solid windowtext 1.0pt;
  border-left:none;mso-border-left-alt:solid windowtext .5pt;mso-border-alt:
  solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:8.35pt" valign="center" width="76">
                        <p align="center" class="MsoNormal">
                            <span lang="RU" style="font-size: 11.0pt; mso-bidi-font-family: Arial; color: #141823; background: white">Baxış</span></p>
                    </td>
                             </asp:Panel>
                </tr>



                         <asp:Repeater ID="DataList3" runat="server">
                    <ItemTemplate>


                <tr style="mso-yfti-irow:1">
                    <td style="width:50.2pt;border:solid windowtext 1.0pt;
  border-top:none;mso-border-top-alt:solid windowtext .5pt;mso-border-alt:solid windowtext .5pt;
  padding:0in 5.4pt 0in 5.4pt" valign="top" width="67">
                        <p align="left" class="MsoNormal">
                             <%#Eval("Username")%></p>
                    </td>
                    <td style="width:67.5pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt" valign="top" width="90">
                        <p align="left" class="MsoNormal">
                            <%#Eval("Name")%></p>
                    </td>
                    <td style="width:67.5pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt" valign="top" width="90">
                        <p align="center" class="MsoNormal">
                             <%#Class2.sozukes(Eval("RegionCome").ToString()) %></p>
                    </td>
                    <td style="width:1.0in;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt" valign="top" width="96">
                        <p align="center" class="MsoNormal">
                           <%#Class2.sozukes(Eval("GoFromRegion").ToString()) %></p>
                    </td>
                    <td style="width:63.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt" valign="top" width="84">
                        <p align="left" class="MsoNormal">
                          <%#Eval("Living_Point")%></p>
                    </td>
                    <td style="width:67.5pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt" valign="top" width="90">
                        <p align="left" class="MsoNormal">
                           <%#Eval("ObjectOther")%></p>
                    </td>
                    <td style="border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;" valign="top" class="auto-style8">
                        <p align="left" class="MsoNormal">
                            <%#Eval("SubObjectOther")%></p>
                    </td>
                    <td style="border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;" valign="top" class="auto-style4">
                        <p align="left" class="MsoNormal">
                           <%#Eval("Construction_works")%> </p>
                    </td>
                    <td style="border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;" valign="top" class="auto-style6">
                        <p align="left" class="MsoNormal">
                            <%#Eval("WorkView")%></p>
                    </td>
                    <td style="width:102.95pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt" valign="top" width="137">
                        <p align="left" class="MsoNormal">
                             <%#Eval("ResultView")%></p>
                    </td>
                      <asp:Panel ID="pnlbaxiw1" runat="server">
                    <td style="width:57.25pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt" valign="top" width="76">
                        <p align="center" class="MsoNormal">
                          <a href="ezamiyye.aspx?BusinessTripID=<%#Eval("BusinessTripID") %>&islem1=baxkecistehlil&RegionID=<%#Eval("RegionID") %>&controlBusinesTrip=1&UserID=<%#Eval("UserID") %>">Baxış</a>  </p>
                    </td>
                          </asp:Panel>
                </tr>
                        </ItemTemplate>
                             </asp:Repeater>
                
            </table>
                                 </asp:Panel>




    </asp:Panel>

    <div class="temizle"></div>
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

