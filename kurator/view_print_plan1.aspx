<%@ Page Language="C#" AutoEventWireup="true" EnableEventValidation="false" CodeFile="view_print_plan1.aspx.cs" Inherits="kurator_view_print_plan" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="content-type" content="text/html;charset=UTF-8" />

    <title></title>
    <style type="text/css">
        @charset "utf-8";
    </style>
    <script type="text/javascript">
        window.onload = function () {
            noBack();
        }
        function noBack() {
            window.history.forward();
        }
    </script>
</head>

<body onpageshow="if (event.persisted) noBack();">
    <form id="form1" runat="server">
        <asp:Panel ID="pnlhtml" runat="server">
            <div style="height: auto; width: 1024px; margin-right: auto; margin-left: auto; white-space: normal; font-family: Arial, Helvetica, sans-serif; font-weight: 200; white-space: normal;">
                <div style="height: auto;">
                    <div style="float: left;">
                        <asp:Button ID="btngeri" runat="server" Text="Geri" OnClick="btngeri_Click" Width="120px" />
                    </div>
                    <div style="clear: both;"></div>
                    <asp:Panel ID="pnlzynltarix" Visible="false" runat="server">
                        <br />
                        <div style="height: auto; width: 100%;">
                            <div style="width: 210px; float: left; border-style: solid; border-width: 1px;">
                                <asp:TextBox ID="txtzynltarix" runat="server" ReadOnly="True" Width="100px"></asp:TextBox>
                                &nbsp;<asp:ImageButton ID="ImageButton5" runat="server" Height="23px" ImageUrl="~/images/calendar-icon.png" Width="23px" OnClick="ImageButton1_Click" />
                                &nbsp;&nbsp;
                        <asp:Panel ID="pnlcalendar" runat="server">
                            <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#999999" Visible="false"
                                CellSpacing="1" DayNameFormat="Shortest" Font-Names="Arial" Font-Size="9pt" ForeColor="Black"
                                Height="180px" OnSelectionChanged="Calendar1_SelectionChanged" Width="210px">
                                <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                                <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                                <SelectorStyle BackColor="#CCCCCC" />
                                <WeekendDayStyle BackColor="#FFFFCC" />
                                <OtherMonthDayStyle ForeColor="White" />
                                <NextPrevStyle VerticalAlign="Bottom" />
                                <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                                <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                            </asp:Calendar>
                        </asp:Panel>
                                <br />
                                <asp:Button ID="btnzynltarix" runat="server" OnClick="btnzynltarix_Click" Text="Təsdiq" Width="210px" />
                            </div>

                            <div style="width: 292px; float: left; border-style: solid; border-width: 1px;">
                                <asp:TextBox ID="txtra" runat="server" ReadOnly="True" Width="100px"></asp:TextBox>
                                &nbsp;<asp:ImageButton ID="imgcald" runat="server" ImageUrl="~/images/calendar-icon.png" Width="23px" OnClick="imgcald_Click" Height="23px" />
                                &nbsp;&nbsp;
                       
                        <asp:Panel ID="pnlcald" runat="server">
                            <asp:Calendar ID="cald" runat="server" BackColor="White" BorderColor="#999999" Visible="false"
                                CellSpacing="1" DayNameFormat="Shortest" Font-Names="Arial" Font-Size="9pt" ForeColor="Black"
                                Height="180px" OnSelectionChanged="cald_SelectionChanged" Width="210px">
                                <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                                <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                                <SelectorStyle BackColor="#CCCCCC" />
                                <WeekendDayStyle BackColor="#FFFFCC" />
                                <OtherMonthDayStyle ForeColor="White" />
                                <NextPrevStyle VerticalAlign="Bottom" />
                                <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                                <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                            </asp:Calendar>
                        </asp:Panel>
                                <br />
                                <asp:Button ID="btnezamtesdiq" runat="server" OnClick="btnezamtesdiq_Click" Text="Ezamiyyə planının təsdiq edilməsi təklif olunur" Width="292px" />
                            </div>

                            <div style="width: 312px; float: left; border-style: solid; border-width: 1px;">
                                <asp:FileUpload ID="fugonder" runat="server" Visible="False" Height="29px" />

                                <br />

                                <br />
                                <asp:Button ID="btnyeniden" runat="server" OnClick="btnyeniden_Click" Text="Ezamiyyə planının yenidən işlənməsi təklif olunur" Width="312px" />
                            </div>
                            <div style="width: 200px; float: left; border-style: solid; border-width: 1px;">
                                <asp:TextBox ID="txtkur" runat="server" ReadOnly="True" Width="100px"></asp:TextBox>
                                &nbsp;<asp:ImageButton ID="ImageButton1" runat="server" Height="23px" ImageUrl="~/images/calendar-icon.png" Width="23px" OnClick="ImageButton1_Click1" />
                                &nbsp;&nbsp;
                        <asp:Panel ID="pnlcaldkur" runat="server">
                            <asp:Calendar ID="caldkur" runat="server" BackColor="White" BorderColor="#999999" Visible="false"
                                CellSpacing="1" DayNameFormat="Shortest" Font-Names="Arial" Font-Size="9pt" ForeColor="Black"
                                Height="180px" OnSelectionChanged="caldkur_SelectionChanged" Width="200px">
                                <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                                <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                                <SelectorStyle BackColor="#CCCCCC" />
                                <WeekendDayStyle BackColor="#FFFFCC" />
                                <OtherMonthDayStyle ForeColor="White" />
                                <NextPrevStyle VerticalAlign="Bottom" />
                                <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                                <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                            </asp:Calendar>
                        </asp:Panel>
                                <br />
                                <asp:Button ID="btnkurtarix" runat="server" OnClick="btnkurtarix_Click" Text="Təqdim edilmə tarixini dəyiş" Width="200px" />
                            </div>

                            <div style="clear: both;"></div>
                        </div>
                        <br />
                    </asp:Panel>
                    <div style="font-weight: bold; white-space: normal; text-align: right;">
                        Qəbul olunub<br />
                        <asp:Label ID="carivaxt" runat="server"></asp:Label>
                    </div>

                </div>




                <div>
                    <asp:Label ID="lbltesdiqolundu" runat="server" Font-Bold="True"></asp:Label>
                    <asp:Label ID="lblgonderildi" runat="server" Font-Bold="True"></asp:Label>

                </div>

                <div style="width: 1024px; text-align: center; font-weight: bold; white-space: normal;">
                    <asp:Label ID="lbladsoyad" runat="server"></asp:Label>
                    <asp:Label ID="lblrayon" runat="server"></asp:Label>
                    ezamiyyə dövrünə dair iş planı
                </div>
                <div>&nbsp;</div>

                <div>
                    <asp:Label ID="Label2" Style="font-weight: bold;" runat="server" Text="Ezamiyyənin müddəti:"></asp:Label>&nbsp;<asp:Label ID="lblezambawlama" runat="server"></asp:Label>
                    <asp:Label ID="lblbitme" runat="server"></asp:Label>
                </div>
                <div>
                    <asp:Label ID="Label17" Style="font-weight: bold;" runat="server" Text="İşə çıxma tarixi:"></asp:Label>&nbsp;
                <asp:Label ID="lbliwecixma" runat="server"></asp:Label>
                </div>
                <div>
                    <asp:Label ID="Label3" Style="font-weight: bold;" runat="server" Text="Ezamiyyənin məqsədi:"></asp:Label>
                </div>
                <asp:DataList ID="rpmeqsed" runat="server">
                    <ItemTemplate>
                        <div>
                            <div>
                                <%#Eval("Sn").ToString()%>
                                <%#Eval("Purpose") %>
                            </div>
                            <table style="width: 100%; white-space: normal;">
                                <tr>
                                    <td style="width: 18px; white-space: normal;">&nbsp;</td>
                                    <td style="width: 943px; white-space: normal;">
                                        <asp:Label ID="Label13" runat="server" Text="Səbəb" Font-Underline="True"></asp:Label>: 
               <%#Eval("NoteText") %>.<br />
                                        <asp:Label ID="Label8" runat="server" Text="Görüləcək işlər" Font-Underline="True"></asp:Label>: 
               <%#Eval("Future_work") %>.<br />

                                        <asp:Label ID="Label9" runat="server" Text="Gözlənilən nəticə" Font-Underline="True"></asp:Label>:
               <%#Eval("Expected_results") %>.</td>
                                    <td>&nbsp;</td>
                                </tr>
                            </table>
                        </div>
                    </ItemTemplate>
                </asp:DataList>



                <div>
                    <asp:Label ID="Label4" Style="font-weight: bold;" runat="server" Text="İştirakı nəzərdə tutulmuş tədbirlər:"></asp:Label>
                </div>

                <asp:DataList ID="rpiwtirakineztutlan" runat="server">
                    <ItemTemplate>
                        <div>
                            <div>
                                <%#Eval("Sn").ToString()%>
                                <%#Eval("Actions").ToString()%>
                            </div>
                            <table style="width: 100%; white-space: normal;">
                                <tr>
                                    <td style="width: 18px; white-space: normal;">&nbsp;</td>
                                    <td style="width: 943px; white-space: normal;">
                                        <asp:Label ID="Label9" runat="server" Text="Müzakirə olunacaq məsələ" Font-Underline="True"></asp:Label>:
              <%#Eval("Issues") %>.<asp:Panel ID="pnlgozlennet" Visible="false" runat="server">
                  <br />
                  <asp:Label ID="Label10" runat="server" Text="Gözlənilən nəticə" Font-Underline="True"></asp:Label>:
                     <%#Eval("results") %>.
              </asp:Panel>
                                    </td>
                                    <td>&nbsp;</td>
                                </tr>
                            </table>
                        </div>

                    </ItemTemplate>
                </asp:DataList>
                <div>
                    <asp:Label ID="Label1" Style="font-weight: bold;" runat="server" Text="Nəzərdə tutulmuş görüş:"></asp:Label>
                </div>
                <asp:DataList ID="rpnezerdetutulmuwgoruw" runat="server">
                    <ItemTemplate>
                        <div>
                            <div>
                                <%#Eval("Sn").ToString()%>
        Vətəndaş <%#Eval("namelivinadres")%>
                            </div>
                            <table style="width: 100%; white-space: normal;">
                                <tr>
                                    <td style="width: 18px; white-space: normal;">&nbsp;</td>
                                    <td style="width: 943px; white-space: normal;">
                                        <asp:Label ID="Label10" runat="server" Text="Məqsəd" Font-Underline="True"></asp:Label>:
               <%#Eval("Purpose")%>.<br />
                                        <asp:Panel ID="pnlqaldirdigimes" Visible='<%#Convert.ToBoolean(Class2.muracietebax(Eval("PurposeID").ToString()))%>' runat="server">
                                            <asp:Label ID="Label11" runat="server" Text="Müraciətdə qaldırılan məsələ" Font-Underline="True"></asp:Label>:
                 <%#Eval("Appeal_raised_issue")%>.<br />
                                        </asp:Panel>
                                        <asp:Panel ID="pnlgozlnet" Visible="false" runat="server">
                                            <asp:Label ID="Label12" runat="server" Text="Gözlənilən nəticə" Font-Underline="True"></asp:Label>:
                <%#Eval("Expected_results")%>.
                                        </asp:Panel>
                                    </td>
                                    <td>&nbsp;</td>
                                </tr>
                            </table>

                        </div>
                    </ItemTemplate>
                </asp:DataList>



                <div>
                    <asp:Label ID="Label5" Style="font-weight: bold;" runat="server" Text="Fərdi söhbət nəzərdə tutulmuş kadrlar:"></asp:Label>
                </div>

                <asp:DataList ID="rpferdisohbetnezkadr" runat="server">
                    <ItemTemplate>

                        <div>
                            <div>
                                <%#Eval("Sn").ToString()%>
                                <%#Eval("namesnameposi")%>
                            </div>

                            <table style="width: 100%; white-space: normal;">
                                <tr>
                                    <td style="width: 18px; white-space: normal;">&nbsp;</td>
                                    <td style="width: 943px; white-space: normal;">
                                        <asp:Label ID="Label12" runat="server" Text="Məqsəd" Font-Underline="True"></asp:Label>:
               <%#Eval("Purpose")%>.</td>
                                    <td>&nbsp;</td>
                                </tr>
                            </table>

                        </div>

                    </ItemTemplate>
                </asp:DataList>



                <div>
                    <asp:Label ID="Label6" Style="font-weight: bold;" runat="server" Text="Olacağı İHB nümayəndəliyi:"></asp:Label>
                </div>

                <asp:DataList ID="rpIHBnumayende1" runat="server" RepeatDirection="Horizontal">
                    <ItemTemplate>
                        <div>
                            <div>
                                <%#Eval("Delegate") %><%#Eval("Sn").ToString()%>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:DataList>



                <div>
                    <asp:Label ID="Label7" Style="font-weight: bold;" runat="server" Text="Olacağı yaşayış məntəqəsi:"></asp:Label>
                </div>
                <asp:DataList ID="rpolacagiyawayiwmen" runat="server" RepeatDirection="Horizontal">
                    <ItemTemplate>

                        <div>
                            <div>

                                <%#Eval("Living") %><%#Eval("Sn").ToString()%>
                                <%-- <%#Eval("noqvergul").ToString()%>--%>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:DataList>




                <div style="padding-top: 5px; text-align: right; font-weight: bold; height: 170px; white-space: normal;">

                    <asp:Panel Style="text-align: left; float: left; width: 297px;" ID="pnltsdq" runat="server">

                        <br />
                        <asp:Button ID="btnword" runat="server" Text="Wordə çıxart" OnClick="btnword_Click" Width="300px" />
                        <br />
                        <asp:Panel ID="pnlkuratortesdiq" Visible="false" runat="server">
                            <br />
                            <asp:Button ID="btntesdiqkur" runat="server" Text="Təsdiq et" Width="300px" Visible="False" OnClick="btntesdiqkur_Click" />
                            <br />
                        </asp:Panel>


                    </asp:Panel>
                    <div style="float: right;">
                        <br />
                        <asp:Label ID="lbluser" runat="server"></asp:Label><br />
                        <asp:Label ID="lbltrx1" runat="server"></asp:Label><br />
                        <br />
                        <asp:Label ID="lbltesdiqra" runat="server"></asp:Label><br />
                        <br />
                        <asp:Label ID="lbltarix2" runat="server"></asp:Label>
                    </div>

                </div>


            </div>

        </asp:Panel>
    </form>
</body>
</html>
