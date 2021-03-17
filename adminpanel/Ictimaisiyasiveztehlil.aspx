<%@ Page Title="" Language="C#" MasterPageFile="~/adminpanel/adminMasterPage.master" AutoEventWireup="true" CodeFile="Ictimaisiyasiveztehlil.aspx.cs" Inherits="adminpanel_Ictimaisiyasiveztehlil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
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
            font-family: Arial,"sans-serif";
        }

        .auto-style1 {
            width: 100%;
        }

        .auto-style2 {
            width: 828px;
        }
        .auto-style3 {
            height: 55.2pt;
            width: 278pt;
        }
        .auto-style4 {
            height: 17.25pt;
            width: 278pt;
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

            <div style="float: left; width: 346px; padding-top: 10px; height: 179px;">
                Rayon:&nbsp;&nbsp;
            <asp:DropDownList ID="ddlryn" runat="server">
            </asp:DropDownList>
                <br />
                <br />
                <asp:RadioButton ID="rdrayon" runat="server" Checked="True" GroupName="A" Text="Şəhər və rayonlar üzrə" />
                <br />
                <asp:RadioButton ID="rdmeqsed" runat="server" GroupName="A" Text="Məqsədlər üzrə" />
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
                <b style="mso-bidi-font-weight: normal"><span lang="AZ-LATIN" style="mso-ansi-language: AZ-LATIN">Şöbə əməkdaşlarının ezamiyyətlərdə ictimai-siyasi vəziyyətinin və dini durumun araşdırılması  
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
            <table  cellpadding="0" cellspacing="0" class="MsoNormalTable" width="1019">
                <tr style="mso-yfti-irow: 0; mso-yfti-firstrow: yes; height: 11.0pt;">
                    <td rowspan="3" style="width: 32.65pt; border: solid windowtext 1.0pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 11.0pt;"
                        valign="top" width="44">
                        <p align="center" class="MsoNormal">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">S/n</span></p>
                    </td>
                    <td rowspan="3" style="width: 56.0pt; border: solid windowtext 1.0pt; border-left: none; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 11.0pt;"
                        valign="top" width="75">
                        <p align="center" class="MsoNormal">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">Adı, soyadı</span></p>
                    </td>
                    <td colspan="8" style="width: 675.6pt; border: solid windowtext 1.0pt; border-left: none; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 11.0pt;"
                        valign="top" width="901" aligtn="center">
                        <p align="center" class="MsoNormal" style="text-align: center">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                            <asp:Label ID="lblgelme2" runat="server" Text=""></asp:Label>
                            -
                            <asp:Label ID="lblgetme2" runat="server" Text=""></asp:Label>
                            </span></p>
                    </td>
                </tr>
                <tr style="mso-yfti-irow: 1; height: 17.35pt">
                    <td style="width: 74.8pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 17.35pt"
                        valign="top" width="100" rowspan="2">
                        <p align="center" class="MsoNormal">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">Şəhər və rayonlara ezamiyyətlərin sayı</span></p>
                    </td>
                    <td style="width: 66.0pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 17.35pt"
                        valign="top" width="88" rowspan="2">
                        <p align="center" class="MsoNormal">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">Şəhər, rayon</span></p>
                    </td>
                    <td style="width: 184.75pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 17.35pt"
                        valign="top" width="246" colspan="2">
                        <p align="center" class="MsoNormal">
                            <span lang="AZ-LATIN" style="background: white; font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN; color: #141823;">İctimai-siyasi vəziyyətə və dini duruma aid məsələlər</span><b style="mso-bidi-font-weight:normal"><sup><span lang="AZ-LATIN" style="font-size:11.0pt;mso-bidi-font-family:Arial;mso-ansi-language:
  AZ-LATIN"></span></sup></b></p>
                    </td>
                    <td style="width: 61.6pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 17.35pt"
                        valign="top" width="82" rowspan="2">
                        <p align="center" class="MsoNormal">
                            <span style="background: white; font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: EN-US; color: #141823;">R</span><span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; color: #141823; background: white; mso-ansi-language: AZ-LATIN">əy</span><span lang="AZ-LATIN" style="font-size:11.0pt;mso-bidi-font-family:
  Arial;mso-ansi-language:AZ-LATIN"></span></p>
                    </td>
                    <td style="width: 96.8pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 17.35pt"
                        valign="top" width="129" rowspan="2">
                        <p align="center" class="MsoNormal">
                            <span lang="AZ-LATIN" style="background: white; font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN; color: #141823;">Səbəb</span></p>
                        <p align="center" class="MsoNormal">
                            <span lang="AZ-LATIN" style="background: white; font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN; color: #141823;">(rəy</span><span style="background: white; font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN; color: #141823;"> </span><span lang="AZ-LATIN" style="background: white; font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN; color: #141823;">mənfi olduğu halda)</span></p>
                    </td>
                    <td style="width: 96.8pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 17.35pt"
                        valign="top" width="129" rowspan="2">
                        <p align="center" class="MsoNormal">
                            <span lang="AZ-LATIN" style="background: white; font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN; color: #141823;">Təklif</span></p>
                    </td>
                    <td style="width: 94.9pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 17.35pt"
                        valign="top" width="127" rowspan="2">
                        <p align="center" class="MsoNormal">
                            <span lang="AZ-LATIN" style="background: white; font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN; color: #141823;">İcrası barədə qeyd</span></p>
                    </td>
                </tr>
                <tr style="mso-yfti-irow: 2; height: 41.0pt">
<%--                    <td style="border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; width: 35.2pt; border-top: none; mso-border-top-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 41.0pt; mso-border-left-alt: solid windowtext .5pt;"
                        valign="top" width="47">
                        <p align="center" class="MsoNormal">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">Cəmi</span></p>
                    </td>--%>
                    <td style="width: 118.75pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 41.0pt"
                        valign="top" width="158">
                        <p align="center" class="MsoNormal">
                            <span lang="AZ-LATIN" style="font-size:11.0pt;mso-bidi-font-family:Arial;mso-ansi-language:
  AZ-LATIN">Mətn</span></p>
                    </td>
                    <td style="width: 30.8pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 41.0pt"
                        valign="top" width="41">
                        <p align="center" class="MsoNormal">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                                Sayı</span></p>
                    </td>
                </tr>






         
                        <tr style="mso-yfti-irow: 3; height: 18.45pt;">
                            <td style="width: 88.65pt; border: solid windowtext 1.0pt; border-top: none; mso-border-top-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 18.45pt;"
                                valign="top" width="118" colspan="2">
                                <p align="right" class="MsoNormal">
                                    <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                                        Cəmi</span><span style="font-size:11.0pt;mso-bidi-font-family:Arial;mso-ansi-language:EN-US">:<b style="mso-bidi-font-weight:normal"><sup></sup></b></span></p>
                            </td>
                            <td style="width: 74.8pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 18.45pt;"
                                valign="top" width="100">
                                <p align="center" class="MsoNormal">
                                    <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                                        <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                                    <asp:Label ID="lblezamsay" runat="server"></asp:Label>
                                    </span>
                                    </span>
                                </p>
                            </td>
                            <td style="width: 66.0pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 18.45pt;"
                                valign="top" width="88">
                                <p align="center" class="MsoNormal">
                                    <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                                    <span lang="AZ-LATIN" style="font-size: 12.0pt; mso-ansi-language: AZ-LATIN">
                                    <asp:Label ID="lblfreg" runat="server"></asp:Label>
                                    </span>
                                    </span>
                                </p>
                            </td>
<%--                            <td style="width: 35.2pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 18.45pt;"
                                valign="top" width="47">
                                <p align="center" class="MsoNormal">
                                    <span lang="AZ-LATIN" style="font-size: 12.0pt; mso-ansi-language: AZ-LATIN"><a class="aucun" href="Ictimaisiyasiveztehlil.aspx?islem=rayon5&amp;tarix1=<%= lblgelme3.Text %>&amp;tarix2=<%= lblgetme3.Text %>&amp;tarix3=<%= lblgelme4.Text %>&amp;tarix4=<%= lblgetme4.Text %>&amp;siralama1=<%= lblsira.Text %>&amp;userkod=<%= lblkurator.Text %>&amp;rayonkod=<%= lblrayon.Text %>" style="text-decoration:none;">
                                    <asp:Label ID="lblcemmeq" runat="server"></asp:Label>
                                    </a></span></p>
                            </td>--%>
                            <td style="width: 118.75pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 18.45pt;"
                                valign="top" width="158">
                                <p align="center" class="MsoNormal">
                                    <span lang="AZ-LATIN" style="font-size: 12.0pt; mso-ansi-language: AZ-LATIN">
                                    <asp:Label ID="lblfmetn" runat="server"></asp:Label>
                                    </span></p>
                            </td>
                            <td style="width: 30.8pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 18.45pt;"
                                valign="top" width="41">
                                <p align="center" class="MsoNormal">
                                    &nbsp;</p>
                            </td>
                            <td style="width: 61.6pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 18.45pt;"
                                valign="top" width="82">
                                <p align="center" class="MsoNormal">
                                    &nbsp;</p>
                            </td>
                            <td style="width: 96.8pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 18.45pt;"
                                valign="top" width="129">
                                <p align="center" class="MsoNormal">
                                    &nbsp;</p>
                            </td>
                            <td style="width: 96.8pt; border-top: none; border-left: none; border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 18.45pt;"
                                valign="top" width="129">
                                <p align="center" class="MsoNormal">
                                    &nbsp;</p>
                            </td>
                            <td style="width:94.9pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:18.45pt" valign="top" width="127">
                                <p align="center" class="MsoNormal">
                                    &nbsp;</p>
                            </td>
                        </tr>


                <asp:Repeater ID="DataList1" runat="server">
                    <ItemTemplate>
                        <tr style="mso-yfti-irow:4;height:11.0pt">
                            <td style="width:32.65pt;border:solid windowtext 1.0pt;
  border-top:none;mso-border-top-alt:solid windowtext .5pt;mso-border-alt:solid windowtext .5pt;
  padding:0in 5.4pt 0in 5.4pt;height:11.0pt" valign="top" width="44">
                                <p align="center" class="MsoNormal">
                                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-bidi-font-family:Arial;mso-ansi-language:
  AZ-LATIN"><%#Container.ItemIndex+1 %>.</span>
                                </p>
                            </td>
                            <td style="width:56.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:11.0pt" valign="top" width="75">
                                <p align="left" class="MsoNormal">
                                    <%#Eval("username")%></p>
                            </td>
                            <td style="width:74.8pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:11.0pt" valign="top" width="100">
                                <p align="center" class="MsoNormal">
                                    <span lang="AZ-LATIN" style="font-size:11.0pt;mso-bidi-font-family:Arial;mso-ansi-language:
  AZ-LATIN"><%#Eval("rynsay")%></span>
                                </p>
                            </td>
                            <td style="width:66.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:11.0pt" valign="top" width="88">
                                <p align="left" class="MsoNormal">
                                    <%#Eval("Name")%>
                                </p>
                            </td>
<%--                            <td style="width:35.2pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:11.0pt" valign="top" width="47">
                                <p align="center" class="MsoNormal">
                                     <a class="aucun" style="text-decoration:none;" href='Ictimaisiyasiveztehlil.aspx?userkod=<%#lblkurator.Text%>&rayonkod=<%#lblrayon.Text%>&PurposeID=<%#Eval("religious_politicalID")%>&islem=rayon5&tarix1=<%#lblgelme1.Text%>&tarix2=<%#lblgetme1.Text%>&tarix3=<%#lblgelme.Text%>&tarix4=<%#lblgetme.Text%>&siralama1=<%#lblsira.Text%>'><%#Eval("meqsedumumi")%></a> 
                                            </p>
                            </td>--%>
                            <td style="width:118.75pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:11.0pt" valign="top" width="158">
                                <p align="left" class="MsoNormal">
                                    <%#Eval("ReligiousOther")%>
                                </p>
                            </td>
                            <td style="width:30.8pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:11.0pt" valign="top" width="41">
                                <p align="center" class="MsoNormal">
                                  <a class="aucun" style="text-decoration:none;" href='Ictimaisiyasiveztehlil.aspx?PurposeID=<%#Eval("religious_politicalID")%>&UserID=<%#Eval("UserID")%>&islem=rayon5&RegionID=<%#Eval("RegionID")%>&tarix1=<%#lblgelme1.Text%>&tarix2=<%#lblgetme1.Text%>&tarix3=<%#lblgelme.Text%>&tarix4=<%#lblgetme.Text%>&siralama1=<%#lblsira.Text%>'><%#Eval("meqseds") %></a>
              </p>
                            </td>
                            <td style="width:61.6pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:11.0pt" valign="top" width="82">
                                <p align="left" class="MsoNormal">
                                    <%#Eval("SubReligiousOther")%>
                                </p>
                            </td>
                            <td style="width:96.8pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:11.0pt" valign="top" width="129">
                                <p align="left" class="MsoNormal">
                                    <%#Eval("NoteText")%>
                                </p>
                            </td>
                            <td style="width:96.8pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:11.0pt" valign="top" width="129">
                                <p align="left" class="MsoNormal">
                                    <%#Eval("Offer")%>
                                </p>
                            </td>
                            <td style="width:94.9pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;
  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:11.0pt" valign="top" width="127">
                                <p align="left" class="MsoNormal">
                                    <%#Eval("Implementation")%>
                                </p>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>


            </table>
           
        </asp:Panel>
    </asp:Panel> 

     <div class="temizle"></div>
    <asp:Panel ID="pnlbirinci" Visible="false" runat="server">
        <asp:Button ID="exele0" runat="server" Text="Wordə çıxart" OnClick="exele0_Click" Width="120px" />
        <br />
        <br />
        <asp:Panel ID="pnlprint" runat="server">
        <p class="MsoNormal">
            <table cellpadding="0" cellspacing="0" width="1000px" class="MsoNormalTable">
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
                    <td style="border-right: 1.0pt solid windowtext; border-top: 1.0pt solid windowtext; border-bottom: 1.0pt solid windowtext; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium;"
                        valign="center" class="auto-style3">
                        <p align="center" class="MsoNormal">
                            <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">İctimai-siyasi vəziyyətə və dini duruma aid məsələlər<b style="mso-bidi-font-weight: normal"><sup><o:p></o:p></sup></b></span>
                        </p>
                    </td>
<%--                    <td style="width: 147.1pt; border: solid windowtext 1.0pt; border-left: none; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; height: 55.2pt"
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
                    </td>--%>
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
                            <td style="border-bottom: solid windowtext 1.0pt; border-right: solid windowtext 1.0pt; mso-border-top-alt: solid windowtext .5pt; mso-border-left-alt: solid windowtext .5pt; mso-border-alt: solid windowtext .5pt; padding: 0in 5.4pt 0in 5.4pt; border-left-style: none; border-left-color: inherit; border-left-width: medium; border-top-style: none; border-top-color: inherit; border-top-width: medium;"
                                valign="top" class="auto-style4">
                                <p align="left" class="MsoNormal">
                                    <span lang="AZ-LATIN" style="font-size: 11.0pt; mso-bidi-font-family: Arial; mso-ansi-language: AZ-LATIN">
                                        <o:p><%#Eval("ReligiousOther") %></o:p>
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
                                        <o:p><a href="ezamiyye.aspx?BusinessTripID=<%#Eval("BusinessTripID") %>&islem1=Ictimaisiyasiveztehlil&RegionID=<%#Eval("RegionID") %>&controlBusinesTrip=1&UserID=<%#Eval("UserID") %>">Baxış</a></o:p>
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
            <asp:Label ID="lblgelme3" runat="server" Visible="False"></asp:Label>
            <asp:Label ID="lblgetme3" runat="server" Visible="False"></asp:Label>
            <asp:Label ID="lblgelme4" runat="server" Visible="False"></asp:Label>
            <asp:Label ID="lblgetme4" runat="server" Visible="False"></asp:Label>
            <asp:Label ID="lblkurator" runat="server" Visible="False"></asp:Label>
            <asp:Label ID="lblrayon" runat="server" Visible="False"></asp:Label>



</asp:Content>

