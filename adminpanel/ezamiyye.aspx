<%@ Page Language="C#" AutoEventWireup="true" EnableEventValidation="false" CodeFile="ezamiyye.aspx.cs" Inherits="adminpanel_ezamiyye" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<%-- <script type = "text/javascript">
         function PrintPanel() {
             var panel = document.getElementById("<%=pnlContents.ClientID %>");
              var printWindow = window.open('', '', 'height=400,width=800');
              printWindow.document.write('<html><head><title>DIV Contents</title>');
              printWindow.document.write('</head><body >');
              printWindow.document.write(panel.innerHTML);
              printWindow.document.write('</body></html>');
              printWindow.document.close();
              setTimeout(function () {
                  printWindow.print();
              }, 500);
              return false;
          }
    </script>--%>
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

<body onpageshow="if (event.persisted) noBack();" style="font-family: Arial">
    <form id="form1" runat="server">

        <asp:Panel ID="pnlhtml" runat="server">
            <div style="height: auto; width: 1024px; margin-right: auto; margin-left: auto; white-space: normal; font-family: Arial, Helvetica, sans-serif; font-weight: 200; white-space: normal;">

                <div style="height: auto;">
                    <div style="float: left;">
                        <asp:Button ID="btnesassehife" runat="server" Text="Geri" OnClick="btnesassehife_Click" Width="120px" />
                    </div>
                    <div style="clear: both;"></div>
                    <asp:Panel ID="pnlzynltarix" Visible="false" runat="server">
                        <br />
                        <div style="height: auto; width: 100%;">
                            <div style="width: 250px; float: left; border-style: solid; border-width: 1px;">
                                <asp:TextBox ID="txtzynltarix" runat="server" ReadOnly="True" Width="100px"></asp:TextBox>
                                &nbsp;<asp:ImageButton ID="ImageButton5" runat="server" Height="23px" ImageUrl="~/images/calendar-icon.png" Width="23px" OnClick="ImageButton1_Click" />
                                &nbsp;&nbsp;
                        <asp:Panel ID="pnlcalendar" runat="server">
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
                        </asp:Panel>
                                <br />
                                <asp:Button ID="btnzynltarix" runat="server" OnClick="btnzynltarix_Click" Text="Təsdiq" Width="250px" />
                            </div>







                            <div style="width: 250px; float: left; border-style: solid; border-width: 1px;">
                                <asp:TextBox ID="txtra" runat="server" ReadOnly="True" Width="100px"></asp:TextBox>
                                &nbsp;<asp:ImageButton ID="imgcald" runat="server" ImageUrl="~/images/calendar-icon.png" Width="23px" OnClick="imgcald_Click" Height="23px" />
                                &nbsp;&nbsp;
                       
                        <asp:Panel ID="pnlcald" runat="server">
                            <asp:Calendar ID="cald" runat="server" BackColor="White" BorderColor="#999999" Visible="false"
                                CellSpacing="1" DayNameFormat="Shortest" Font-Names="Arial" Font-Size="9pt" ForeColor="Black"
                                Height="180px" OnSelectionChanged="cald_SelectionChanged" Width="213px">
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
                                <asp:Button ID="btnezamtesdiq" runat="server" OnClick="btnezamtesdiq_Click" Text="Hesabatın təsdiq edilməsi təklif olunur" Width="250px" />
                            </div>

                            <div style="width: 250px; float: left; border-style: solid; border-width: 1px">
                                <asp:FileUpload ID="fugonder" runat="server" Height="29px" />

                                <br />

                                <br />
                                <asp:Button ID="btnyeniden" runat="server" OnClick="btnyeniden_Click" Text="Hesabatın yenidən işlənməsi təklif olunur" Width="250px" />
                            </div>
                            <div style="width: 250px; float: left; border-style: solid; border-width: 1px;">
                                <asp:TextBox ID="txtkur" runat="server" ReadOnly="True" Width="100px"></asp:TextBox>
                                &nbsp;<asp:ImageButton ID="ImageButton1" runat="server" Height="23px" ImageUrl="~/images/calendar-icon.png" Width="23px" OnClick="ImageButton1_Click1" />
                                &nbsp;&nbsp;
                        <asp:Panel ID="pnlcaldkur" runat="server">
                            <asp:Calendar ID="caldkur" runat="server" BackColor="White" BorderColor="#999999" Visible="false"
                                CellSpacing="1" DayNameFormat="Shortest" Font-Names="Arial" Font-Size="9pt" ForeColor="Black"
                                Height="180px" OnSelectionChanged="caldkur_SelectionChanged" Width="213px">
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
                                <asp:Button ID="btnkurtarix" runat="server" OnClick="btnkurtarix_Click" Text="Təqdim edilmə tarixini dəyiş" Width="250px" />
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

                <div style="padding-top: 5px; text-align: right; padding-right: 75px; font-weight: bold; white-space: normal; height: auto;">


                    <div style="width: 1024px; text-align: center; font-weight: bold; white-space: normal;">
                        <asp:Label ID="lbladsoyad" runat="server"></asp:Label>
                        <asp:Label ID="lblrayon" runat="server"></asp:Label>
                        ezamiyyə dövründə görülmüş işlər barədə hesabatı
                    </div>
                </div>
                <div>&nbsp;</div>







                <div>
                    <asp:Label ID="Label66" Style="font-weight: bold;" runat="server" Text="Ezamiyyənin müddəti:"></asp:Label>&nbsp;<asp:Label ID="lblezambawlama" runat="server"></asp:Label>
                    <asp:Label ID="lblbitme" runat="server"></asp:Label>
                </div>



                <div>
                    <asp:Label ID="Label67" Style="font-weight: bold;" runat="server" Text="İşə çıxma tarixi:"></asp:Label>
                    <asp:Label ID="lblcixma" Font-Bold="False" Font-Italic="False" runat="server"></asp:Label>
                </div>


                <div>
                    <asp:Label ID="Label3" Style="font-weight: bold;" runat="server" Text="Ezamiyyənin məqsədi:"></asp:Label>
                </div>

                <asp:DataList ID="dlmeqsed" runat="server">
                    <ItemTemplate>
                        <%--       <div>
                            <%#Container.ItemIndex+1 %>. <%#Eval("Other") %>.
                        </div>--%>


                        <div>
                            <div>
                                <%#Container.ItemIndex+1 %>. <%#Eval("Other") %>.
                            </div>

                            <table style="width: 100%; white-space: normal;">
                                <tr>
                                    <td style="width: 18px; white-space: normal;">&nbsp;</td>
                                    <td style="width: 943px; white-space: normal;">
                                        <asp:Label ID="Label30" runat="server" Text="Görülmüş işlər" Font-Underline="True"></asp:Label>:
                                        <%#Eval("WorkView") %>.<br />

                                        <asp:Label ID="Label38" runat="server" Text="Əldə olunmuş nəticə" Font-Underline="True"></asp:Label>:
                                        <%#Eval("ResultView") %>.<br />
                                        <asp:Panel ID="Panel9" Visible='<%#Convert.ToBoolean(bowdursacixma(Eval("recommendedView").ToString()))%>' runat="server">

                                            <asp:Label ID="Label39" runat="server" Text="Verilmiş tövsiyyə" Font-Underline="True"></asp:Label>:
    <%#Eval("recommendedView")%>.
                                        </asp:Panel>

                                        <asp:Panel ID="Panel8" runat="server">
                                            <asp:Label ID="Label21" runat="server" Text="İcra vəziyyəti:" Font-Underline="True"></asp:Label>
                                            <asp:Label ID="Label18" runat="server" Text='<%#icradadir1(Convert.ToBoolean(Eval("CommandYesNo").ToString()))%>'></asp:Label><br />
                                            <asp:Label ID="Label40" Visible='<%#Convert.ToBoolean(bowdursacixma(Eval("CommandText").ToString()))%>' runat="server" Text="İcrası barədə qeyd:" Font-Underline="True"></asp:Label>
                                            <asp:Label ID="Label20" Visible='<%#Convert.ToBoolean(bowdursacixma(Eval("CommandText").ToString()))%>' runat="server" Text='<%#Eval("CommandText").ToString() + "." %>'></asp:Label>
                                            <asp:Label ID="Label57" Visible='<%#Convert.ToBoolean(bowdursacixma(Eval("CommandText").ToString()))%>' runat="server" Text='<%#Class2.sozukes(Eval("CommandDate").ToString()) + "."%>'></asp:Label>


                                        </asp:Panel>


                                    </td>
                                    <td>&nbsp;</td>
                                </tr>
                            </table>

                        </div>
                    </ItemTemplate>
                </asp:DataList>

                <div>
                    <asp:Label ID="Label60" runat="server" Text="Plandan əlavə"></asp:Label>
                </div>
                <asp:DataList ID="dlmeqsed0" runat="server">
                    <ItemTemplate>
                        <%--                        <div>
                            <%#Container.ItemIndex+1 %>. <%#Eval("Other") %>.
                        </div>--%>


      <div>
                            <div>
                                <%#Container.ItemIndex+1 %>. <%#Eval("Other") %>.
                            </div>

                            <table style="width: 100%; white-space: normal;">
                                <tr>
                                    <td style="width: 18px; white-space: normal;">&nbsp;</td>
                                    <td style="width: 943px; white-space: normal;">
                                        <asp:Label ID="Label30" runat="server" Text="Görülmüş işlər" Font-Underline="True"></asp:Label>:
                                        <%#Eval("WorkView") %>.<br />

                                        <asp:Label ID="Label38" runat="server" Text="Əldə olunmuş nəticə" Font-Underline="True"></asp:Label>:
                                        <%#Eval("ResultView") %>.<br />
                                        <asp:Panel ID="Panel9" Visible='<%#Convert.ToBoolean(bowdursacixma(Eval("recommendedView").ToString()))%>' runat="server">

                                            <asp:Label ID="Label39" runat="server" Text="Verilmiş tövsiyyə" Font-Underline="True"></asp:Label>:
    <%#Eval("recommendedView")%>.
                                        </asp:Panel>

                                        <asp:Panel ID="Panel8" runat="server">
                                            <asp:Label ID="Label21" runat="server" Text="İcra vəziyyəti:" Font-Underline="True"></asp:Label>
                                            <asp:Label ID="Label18" runat="server" Text='<%#icradadir1(Convert.ToBoolean(Eval("CommandYesNo").ToString()))%>'></asp:Label><br />
                                            <asp:Label ID="Label40" Visible='<%#Convert.ToBoolean(bowdursacixma(Eval("CommandText").ToString()))%>' runat="server" Text="İcrası barədə qeyd:" Font-Underline="True"></asp:Label>
                                            <asp:Label ID="Label20" Visible='<%#Convert.ToBoolean(bowdursacixma(Eval("CommandText").ToString()))%>' runat="server" Text='<%#Eval("CommandText").ToString() + "." %>'></asp:Label>
                                            <asp:Label ID="Label57" Visible='<%#Convert.ToBoolean(bowdursacixma(Eval("CommandText").ToString()))%>' runat="server" Text='<%#Class2.sozukes(Eval("CommandDate").ToString()) + "."%>'></asp:Label>


                                        </asp:Panel>


                                    </td>
                                    <td>&nbsp;</td>
                                </tr>
                            </table>

                        </div>
                    </ItemTemplate>
                </asp:DataList>


                <div>
                    <asp:Label ID="Label1" Style="font-weight: bold;" runat="server" Text="Olduğu İHB nümayəndəlikləri:"></asp:Label>
                </div>



                <asp:DataList ID="dlihbnum" runat="server" RepeatDirection="Horizontal">
                    <ItemTemplate>
                        <div>
                            <%#Eval("DelegateOther") %><%#Eval("Sn").ToString()%>
                        </div>
                    </ItemTemplate>
                </asp:DataList>


                <asp:Label ID="Label85" Style="float: left;" runat="server" Text="Plandan əlavə&nbsp;"></asp:Label>

                <asp:DataList ID="dlihbnum0" runat="server" RepeatDirection="Horizontal">
                    <ItemTemplate>
                        <div>
                            <%#Eval("DelegateOther") %><%#Eval("Sn").ToString()%>
                        </div>
                    </ItemTemplate>
                </asp:DataList>


                <div>
                    <asp:Label ID="Label68" Style="font-weight: bold;" runat="server" Text="Olmadığı İHB nümayəndəlikləri:"></asp:Label>
                </div>

                <asp:DataList ID="dlolmadigiihb" runat="server">
                    <ItemTemplate>
                        <div>
                            <div><%#Container.ItemIndex+1 %>. <%#Eval("DelegateOther")%> üzrə.</div>
                            <table style="width: 100%; white-space: normal;">
                                <tr>
                                    <td style="width: 18px; white-space: normal;">&nbsp;</td>
                                    <td style="width: 943px; white-space: normal;">
                                        <asp:Label ID="Label14" runat="server" Text="Səbəb" Font-Underline="True"></asp:Label>:
                             <%#Eval("NoteText") %>.</td>
                                    <td>&nbsp;</td>
                                </tr>
                            </table>
                        </div>
                    </ItemTemplate>
                </asp:DataList>



                <div>
                    <asp:Label ID="Label2" Style="font-weight: bold;" runat="server" Text="Olduğu yaşayış məntəqələri:"></asp:Label>
                </div>


                <asp:DataList ID="dlyawayiw" RepeatDirection="Horizontal" runat="server">
                    <ItemTemplate>
                        <div>
                            <%#Eval("LivingOther") %><%#Eval("Sn").ToString()%>
                        </div>
                    </ItemTemplate>
                </asp:DataList>
                <asp:Label ID="Label87" Style="float: left;" runat="server" Text="Plandan əlavə&nbsp;"></asp:Label>

                <asp:DataList ID="dlyawayiw0" RepeatDirection="Horizontal" runat="server">
                    <ItemTemplate>
                        <div>
                            <%#Eval("LivingOther") %><%#Eval("Sn").ToString()%>
                        </div>
                    </ItemTemplate>
                </asp:DataList>


                <div>
                    <asp:Label ID="Label69" Style="font-weight: bold;" runat="server" Text="Olmadığı yaşayış məntəqələri:"></asp:Label>
                </div>

                <asp:DataList ID="dlolmadigiyawayiwmen" runat="server">
                    <ItemTemplate>
                        <div>
                            <div>
                                <%#Container.ItemIndex+1 %>. <%#Eval("LivingOther") %>.
                            </div>
                            <table style="width: 100%; white-space: normal;">
                                <tr>
                                    <td style="width: 18px; white-space: normal;">&nbsp;</td>
                                    <td style="width: 943px; white-space: normal;">

                                        <asp:Label ID="Label15" runat="server" Text="Səbəb" Font-Underline="True"></asp:Label>: 
                            <%#Eval("NoteText") %>.</td>
                                    <td>&nbsp;</td>
                                </tr>
                            </table>
                        </div>
                    </ItemTemplate>
                </asp:DataList>



                <div>
                    <asp:Label ID="Label5" Style="font-weight: bold;" runat="server" Text="İştirak etdiyi tədbirlər:"></asp:Label>
                </div>

                <asp:DataList ID="dliwttedbir" runat="server">
                    <ItemTemplate>

                        <div>
                            <div>
                                <%#Container.ItemIndex+1 %>. <%#Eval("ParticipationOther") %>.
                            </div>

                            <table style="width: 100%; white-space: normal;">
                                <tr>
                                    <td style="width: 18px; white-space: normal;">&nbsp;</td>
                                    <td style="width: 943px; white-space: normal;">
                                        <asp:Panel ID="pnlmuzakire" Visible='<%#Convert.ToBoolean(tedbir1(Convert.ToBoolean(Eval("OlunubYesNo").ToString())))%>' runat="server">
                                            <asp:Label ID="Label151" runat="server" Text="Müzakirə olunmuş məsələ" Font-Underline="True"></asp:Label>: 
                        <%#Eval("DiscussedOther")%>.<br />
                                        </asp:Panel>
                                        <asp:Panel ID="pnlgorulmuwiw" Visible='<%#Convert.ToBoolean(tedbir2(Convert.ToBoolean(Eval("BaxilibYesNo").ToString()),Convert.ToBoolean(Eval("OlunubYesNo").ToString())))%>' runat="server">
                                            <asp:Panel ID="Panel3" Visible='<%#Convert.ToBoolean(bowdursacixma(Eval("WorkView").ToString()))%>' runat="server">

                                                <asp:Label ID="Label16" runat="server" Text="Görülmüş işlər" Font-Underline="True"></asp:Label>: 
                <%#Eval("WorkView") %>.<br />
                                            </asp:Panel>
                                            <asp:Panel ID="Panel13" Visible='<%#Convert.ToBoolean(bowdursacixma(Eval("ResultView").ToString()))%>' runat="server">

                                                <asp:Label ID="Label17" runat="server" Text="Əldə olunmuş nəticə" Font-Underline="True"></asp:Label>: 
                <%#Eval("ResultView") %>.<br />
                                            </asp:Panel>
                                        </asp:Panel>
                                        <asp:Panel ID="pnlsebeb" Visible='<%#Convert.ToBoolean(tedbir(Convert.ToBoolean(Eval("OlunubYesNo").ToString())))%>' runat="server">
                                            <asp:Label ID="Label72" runat="server" Text="Müzakirə olunmamış məsələ" Font-Underline="True"></asp:Label>: 
                        <%#Eval("DiscussedOther") %>.<br />
                                            <asp:Label ID="Label19" runat="server" Text="Səbəb" Font-Underline="True"></asp:Label>:
                             <%#Eval("NoteText") %>.
                                        </asp:Panel>

                                    </td>
                                    <td>&nbsp;</td>
                                </tr>
                            </table>
                        </div>

                    </ItemTemplate>
                </asp:DataList>






                <div>
                    <asp:Label ID="Label81" runat="server" Text="Plandan əlavə"></asp:Label>
                </div>
                <asp:DataList ID="dliwttedbir0" runat="server">
                    <ItemTemplate>

                        <div>
                            <div>
                                <%#Container.ItemIndex+1 %>. <%#Eval("ParticipationOther") %>.
                            </div>

                            <table style="width: 100%; white-space: normal;">
                                <tr>
                                    <td style="width: 18px; white-space: normal;">&nbsp;</td>
                                    <td style="width: 943px; white-space: normal;">
                                        <asp:Panel ID="pnlmuzakire" Visible='<%#Convert.ToBoolean(tedbir1(Convert.ToBoolean(Eval("OlunubYesNo").ToString())))%>' runat="server">
                                            <asp:Label ID="Label151" runat="server" Text="Müzakirə olunmuş məsələ" Font-Underline="True"></asp:Label>: 
                        <%#Eval("DiscussedOther")%>.<br />
                                        </asp:Panel>
                                        <asp:Panel ID="pnlgorulmuwiw" Visible='<%#Convert.ToBoolean(tedbir2(Convert.ToBoolean(Eval("BaxilibYesNo").ToString()),Convert.ToBoolean(Eval("OlunubYesNo").ToString())))%>' runat="server">
                                            <asp:Panel ID="Panel3" Visible='<%#Convert.ToBoolean(bowdursacixma(Eval("WorkView").ToString()))%>' runat="server">

                                                <asp:Label ID="Label16" runat="server" Text="Görülmüş işlər" Font-Underline="True"></asp:Label>: 
                <%#Eval("WorkView") %>.<br />
                                            </asp:Panel>
                                            <asp:Panel ID="Panel13" Visible='<%#Convert.ToBoolean(bowdursacixma(Eval("ResultView").ToString()))%>' runat="server">

                                                <asp:Label ID="Label17" runat="server" Text="Əldə olunmuş nəticə" Font-Underline="True"></asp:Label>: 
                <%#Eval("ResultView") %>.<br />
                                            </asp:Panel>
                                        </asp:Panel>
                                        <asp:Panel ID="pnlsebeb" Visible='<%#Convert.ToBoolean(tedbir(Convert.ToBoolean(Eval("OlunubYesNo").ToString())))%>' runat="server">
                                            <asp:Label ID="Label72" runat="server" Text="Müzakirə olunmamış məsələ" Font-Underline="True"></asp:Label>: 
                        <%#Eval("DiscussedOther") %>.<br />
                                            <asp:Label ID="Label19" runat="server" Text="Səbəb" Font-Underline="True"></asp:Label>:
                             <%#Eval("NoteText") %>.
                                        </asp:Panel>

                                    </td>
                                    <td>&nbsp;</td>
                                </tr>
                            </table>
                        </div>

                    </ItemTemplate>
                </asp:DataList>





                <div>
                    <asp:Label ID="Label70" Style="font-weight: bold;" runat="server" Text="İştirak etmədiyi tədbirlər:"></asp:Label>
                </div>

                <asp:DataList ID="dliiwetmediyitedbir" runat="server">
                    <ItemTemplate>
                        <div>
                            <div>
                                <%#Container.ItemIndex+1 %>. <%#Eval("ParticipationOther") %>.
                            </div>

                            <table style="width: 100%; white-space: normal;">
                                <tr>
                                    <td style="width: 18px; white-space: normal;">&nbsp;</td>
                                    <td style="width: 943px; white-space: normal;">

                                        <asp:Label ID="Label19" runat="server" Text="Səbəb" Font-Underline="True"></asp:Label>:
                             <%#Eval("NoteText") %>.
      
                                    </td>
                                    <td>&nbsp;</td>
                                </tr>
                            </table>

                        </div>

                    </ItemTemplate>
                </asp:DataList>

                <asp:Panel ID="Panel14" Visible="false" runat="server">
                <div>
                    <asp:Label ID="Label11" Style="font-weight: bold;" runat="server" Text="Baxılmış, araşdırılmış məsələlər:"></asp:Label>
                </div>

                <asp:DataList ID="dlbaxarawmes" runat="server">
                    <ItemTemplate>
                        <div>
                            <div>
                                <%#Container.ItemIndex+1 %>. <%#Eval("Other") %>.
                            </div>

                            <table style="width: 100%; white-space: normal;">
                                <tr>
                                    <td style="width: 18px; white-space: normal;">&nbsp;</td>
                                    <td style="width: 943px; white-space: normal;">
                                        <asp:Label ID="Label30" runat="server" Text="Görülmüş işlər" Font-Underline="True"></asp:Label>:
                                        <%#Eval("WorkView") %>.<br />

                                        <asp:Label ID="Label38" runat="server" Text="Əldə olunmuş nəticə" Font-Underline="True"></asp:Label>:
                                        <%#Eval("ResultView") %>.<br />
                                        <asp:Panel ID="Panel9" Visible='<%#Convert.ToBoolean(bowdursacixma(Eval("NoteText").ToString()))%>' runat="server">

                                            <asp:Label ID="Label39" runat="server" Text="Verilmiş tövsiyyə və tapşırıqlar" Font-Underline="True"></asp:Label>:
    <%#Eval("NoteText")%>.
                                            <asp:Label ID="Label18" runat="server" Text='<%#icradadir(Eval("CommandPost").ToString())%>'></asp:Label><br />
                                            <asp:Panel ID="Panel8" Visible='<%#Convert.ToBoolean(bowdursacixma(Eval("CommandPost").ToString()))%>' runat="server">
                                                <asp:Label ID="Label40" runat="server" Text="İcrası barədə qeyd" Font-Underline="True"></asp:Label>:
             <%#Eval("CommandPost")%>. <%#Class2.sozukes(Eval("DatePost").ToString()) %>.
                                            </asp:Panel>
                                        </asp:Panel>

                                    </td>
                                    <td>&nbsp;</td>
                                </tr>
                            </table>

                        </div>
                    </ItemTemplate>
                </asp:DataList>

                <div>
                    <asp:Label ID="Label83" runat="server" Text="Plandan əlavə"></asp:Label>
                </div>
                <asp:DataList ID="dlbaxarawmes0" runat="server">
                    <ItemTemplate>
                        <div>
                            <div>
                                <%#Container.ItemIndex+1 %>. <%#Eval("Other") %>.
                            </div>

                            <table style="width: 100%; white-space: normal;">
                                <tr>
                                    <td style="width: 18px; white-space: normal;">&nbsp;</td>
                                    <td style="width: 943px; white-space: normal;">
                                        <asp:Label ID="Label30" runat="server" Text="Görülmüş işlər" Font-Underline="True"></asp:Label>:

                                        <%#Eval("WorkView") %>.<br />

                                        <asp:Label ID="Label38" runat="server" Text="Əldə olunmuş nəticə" Font-Underline="True"></asp:Label>:
                                        <%#Eval("ResultView") %>.<br />
                                        <asp:Panel ID="Panel9" Visible='<%#Convert.ToBoolean(bowdursacixma(Eval("NoteText").ToString()))%>' runat="server">

                                            <asp:Label ID="Label39" runat="server" Text="Verilmiş tövsiyyə və tapşırıqlar" Font-Underline="True"></asp:Label>:
    <%#Eval("NoteText")%>.
                                            <asp:Label ID="Label18" runat="server" Text='<%#icradadir(Eval("CommandPost").ToString())%>'></asp:Label><br />
                                            <asp:Panel ID="Panel8" Visible='<%#Convert.ToBoolean(bowdursacixma(Eval("CommandPost").ToString()))%>' runat="server">
                                                <asp:Label ID="Label40" runat="server" Text="İcrası barədə qeyd" Font-Underline="True"></asp:Label>:
             <%#Eval("CommandPost")%>. <%#Class2.sozukes(Eval("DatePost").ToString()) %>.
                                            </asp:Panel>
                                        </asp:Panel>

                                    </td>
                                    <td>&nbsp;</td>
                                </tr>
                            </table>

                        </div>
                    </ItemTemplate>
                </asp:DataList>


                <div>
                    <asp:Label ID="Label71" Style="font-weight: bold;" runat="server" Text="Baxılmamış, araşdırılmamış məsələlər:"></asp:Label>
                </div>

                <asp:DataList ID="dlbaxilmamiwmesele" runat="server">
                    <ItemTemplate>
                        <div>
                            <div><%#Container.ItemIndex+1 %>. <%#Eval("Other") %>.</div>
                            <table style="width: 100%; white-space: normal;">
                                <tr>
                                    <td style="width: 18px; white-space: normal;">&nbsp;</td>
                                    <td style="width: 943px; white-space: normal;">

                                        <asp:Label ID="Label181" runat="server" Text="Səbəb" Font-Underline="True"></asp:Label>:
                             <%#Eval("SerbestMetn") %>.
                                    </td>
                                    <td>&nbsp;</td>
                                </tr>
                            </table>
                        </div>
                    </ItemTemplate>
                </asp:DataList>





                <div>
                    <asp:Label ID="Label51" Style="font-weight: bold;" runat="server" Text="Baxış keçirilmiş istismarda olan obyektlər:"></asp:Label>
                </div>

                <asp:DataList ID="dlistismarda" runat="server">
                    <ItemTemplate>
                        <div>
                            <div>
                                <%#Container.ItemIndex+1 %>. <%#Eval("SubObjectOther1") %>.
                            </div>
                            <table style="width: 100%; white-space: normal;">
                                <tr>
                                    <td style="width: 18px; white-space: normal;">&nbsp;</td>
                                    <td style="width: 943px; white-space: normal;">
                                        <asp:Label ID="Label52" runat="server" Text="Yaşayış məntəqəsi" Font-Underline="True"></asp:Label>: <%#Eval("Living_Point") %>.<br />
                                        <asp:Label ID="Label53" runat="server" Text="Obyektin adı" Font-Underline="True"></asp:Label>: <%#Eval("ObjectName") %>.<br />
                                        <asp:Label ID="Label54" runat="server" Text="İstismar vəziyyəti" Font-Underline="True"></asp:Label>: <%#Eval("Construction_works") %>.<br />
                                        <asp:Panel ID="Panel1" Visible='<%#Convert.ToBoolean(bowdursacixma(Eval("IHBMektub").ToString()))%>' runat="server">
                                            <asp:Label ID="Label55" runat="server" Text="Problemin aradan qaldırılması ilə bağlı görülmüş tədbirlər <br /> İHB məktubu" Font-Underline="True"></asp:Label>: <%#Eval("IHBMektub") %>,&nbsp;
    <asp:Label ID="Label56" runat="server" Text="№"></asp:Label>: <%#Eval("MektubNomre") %>,&nbsp;
 <%#Eval("MektubTarix") %>.<br />
                                            <asp:Label ID="Label58" runat="server" Text="İcrası" Font-Underline="True"></asp:Label>
                                            <%#Eval("DPAdi") %>
                                            <asp:Label ID="Label23" runat="server" Text='<%#dpda(Eval("dp_diger").ToString())%>'></asp:Label>
                                            <%#Eval("DPIL") %>&nbsp;ildə nəzərdə tutulmuşdur.<br />
                                            <asp:Label ID="Label59" runat="server" Text="İcrası razılaşdırılıb" Font-Underline="True"></asp:Label>: <%#Eval("IcrasiRazilashdirilib") %>
                                       &nbsp;<%#Eval("Vezifesi") %>&nbsp;<%#Eval("Soyadi") %>&nbsp;<%#Eval("Adi") %>,
    
     <asp:Label ID="Label63" runat="server" Text="Telefon nömrəsi"></asp:Label>: <%#Eval("Telefonu") %>.<br />
                                        </asp:Panel>

                                        <asp:Panel ID="Panel8" Visible='<%#Convert.ToBoolean(bowdursacixma(Eval("CommandPost").ToString()))%>' runat="server">
                                            <asp:Label ID="Label40" runat="server" Text="İcrası barədə qeyd" Font-Underline="True"></asp:Label>:
             <%#Eval("CommandPost")%>. <%#Class2.sozukes(Eval("DatePost").ToString()) %>.
                                        </asp:Panel>

                                        <asp:Panel ID="Panel3" Visible='<%#Convert.ToBoolean(bowdursacixma(Eval("WorkView").ToString()))%>' runat="server">
                                            <asp:Label ID="Label8" runat="server" Text="Görülmüş işlər" Font-Underline="True"></asp:Label>: <%#Eval("WorkView") %>.<br />
                                        </asp:Panel>
                                        <asp:Panel ID="Panel4" Visible='<%#Convert.ToBoolean(bowdursacixma(Eval("ResultView").ToString()))%>' runat="server">
                                            <asp:Label ID="Label13" runat="server" Text="Əldə olunmuş nəticə" Font-Underline="True"></asp:Label>: <%#Eval("ResultView") %>.
                                        </asp:Panel>
                                    </td>
                                    <td>&nbsp;</td>
                                </tr>
                            </table>
                        </div>
                    </ItemTemplate>
                </asp:DataList>




                <div>
                    <asp:Label ID="Label89" runat="server" Text="Plandan əlavə"></asp:Label>
                </div>
                <asp:DataList ID="dlistismarda0" runat="server">
                    <ItemTemplate>
                        <div>
                            <div>
                                <%#Container.ItemIndex+1 %>. <%#Eval("SubObjectOther1") %>.
                            </div>
                            <table style="width: 100%; white-space: normal;">
                                <tr>
                                    <td style="width: 18px; white-space: normal;">&nbsp;</td>
                                    <td style="width: 943px; white-space: normal;">
                                        <asp:Label ID="Label52" runat="server" Text="Yaşayış məntəqəsi" Font-Underline="True"></asp:Label>: <%#Eval("Living_Point") %>.<br />
                                        <asp:Label ID="Label53" runat="server" Text="Obyektin adı" Font-Underline="True"></asp:Label>: <%#Eval("ObjectName") %>.<br />
                                        <asp:Label ID="Label54" runat="server" Text="İstismar vəziyyəti" Font-Underline="True"></asp:Label>: <%#Eval("Construction_works") %>.<br />
                                        <asp:Panel ID="Panel1" Visible='<%#Convert.ToBoolean(bowdursacixma(Eval("IHBMektub").ToString()))%>' runat="server">
                                            <asp:Label ID="Label55" runat="server" Text="Problemin aradan qaldırılması ilə bağlı görülmüş tədbirlər <br /> İHB məktubu" Font-Underline="True"></asp:Label>: <%#Eval("IHBMektub") %>,&nbsp;
    <asp:Label ID="Label56" runat="server" Text="№"></asp:Label>: <%#Eval("MektubNomre") %>,&nbsp;
 <%#Eval("MektubTarix") %>.<br />
                                            <asp:Label ID="Label58" runat="server" Text="İcrası" Font-Underline="True"></asp:Label>
                                            <%#Eval("DPAdi") %>
                                            <asp:Label ID="Label23" runat="server" Text='<%#dpda(Eval("dp_diger").ToString())%>'></asp:Label>
                                            <%#Eval("DPIL") %>&nbsp;ildə nəzərdə tutulmuşdur.<br />
                                            <asp:Label ID="Label59" runat="server" Text="İcrası razılaşdırılıb" Font-Underline="True"></asp:Label>: <%#Eval("IcrasiRazilashdirilib") %>
                                       &nbsp;<%#Eval("Vezifesi") %>&nbsp;<%#Eval("Soyadi") %>&nbsp;<%#Eval("Adi") %>,
    
     <asp:Label ID="Label63" runat="server" Text="Telefon nömrəsi"></asp:Label>: <%#Eval("Telefonu") %>.<br />
                                        </asp:Panel>

                                        <asp:Panel ID="Panel8" Visible='<%#Convert.ToBoolean(bowdursacixma(Eval("CommandPost").ToString()))%>' runat="server">
                                            <asp:Label ID="Label40" runat="server" Text="İcrası barədə qeyd" Font-Underline="True"></asp:Label>:
             <%#Eval("CommandPost")%>. <%#Class2.sozukes(Eval("DatePost").ToString()) %>.
                                        </asp:Panel>

                                        <asp:Panel ID="Panel3" Visible='<%#Convert.ToBoolean(bowdursacixma(Eval("WorkView").ToString()))%>' runat="server">
                                            <asp:Label ID="Label8" runat="server" Text="Görülmüş işlər" Font-Underline="True"></asp:Label>: <%#Eval("WorkView") %>.<br />
                                        </asp:Panel>
                                        <asp:Panel ID="Panel4" Visible='<%#Convert.ToBoolean(bowdursacixma(Eval("ResultView").ToString()))%>' runat="server">
                                            <asp:Label ID="Label13" runat="server" Text="Əldə olunmuş nəticə" Font-Underline="True"></asp:Label>: <%#Eval("ResultView") %>.
                                        </asp:Panel>
                                    </td>
                                    <td>&nbsp;</td>
                                </tr>
                            </table>
                        </div>
                    </ItemTemplate>
                </asp:DataList>






                <div>
                    <asp:Label ID="Label64" Style="font-weight: bold;" runat="server" Text="Baxış keçirilmiş inşa və ya əsaslı təmir olunan obyektlər:"></asp:Label>
                </div>

                <asp:DataList ID="dlesaslitemir" runat="server">
                    <ItemTemplate>
                        <div>
                            <div>
                                <%#Container.ItemIndex+1 %>. <%#Eval("SubObjectOther1") %>.
                            </div>
                            <table style="width: 100%; white-space: normal;">
                                <tr>
                                    <td style="width: 18px; white-space: normal;">&nbsp;</td>
                                    <td style="width: 943px; white-space: normal;">
                                        <asp:Label ID="Label52" runat="server" Text="Yaşayış məntəqəsi" Font-Underline="True"></asp:Label>: <%#Eval("Living_Point") %>.<br />
                                        <asp:Label ID="Label53" runat="server" Text="Obyektin adı" Font-Underline="True"></asp:Label>: <%#Eval("ObjectName") %>.<br />
                                        <asp:Label ID="Label54" runat="server" Text="İnşaat işlərinin vəziyyəti" Font-Underline="True"></asp:Label>:  
    <asp:Label ID="Label18" runat="server" Text='<%#inwaatiwvez(Eval("ConductedDate").ToString(),Eval("SuspendedDate").ToString(),Eval("operationDate").ToString())%>'></asp:Label>
                                        <asp:Label ID="Label22" runat="server" Text='<%#Class2.sozukes(inwaatiwveztarix(Eval("ConductedDate").ToString(),Eval("SuspendedDate").ToString(),Eval("operationDate").ToString()))%>'></asp:Label>. <%#Eval("CouseOther1") %>
                                        <asp:Panel ID="Panel1" Visible='<%#Convert.ToBoolean(bowdursacixma(Eval("IHBMektub").ToString()))%>' runat="server">
                                            <asp:Label ID="Label55" runat="server" Text="Problemin aradan qaldırılması ilə bağlı görülmüş tədbirlər <br /> İHB məktubu" Font-Underline="True"></asp:Label>: <%#Eval("IHBMektub") %>,
    <asp:Label ID="Label56" runat="server" Text="№"></asp:Label>: <%#Eval("MektubNomre") %>, <%#Eval("MektubTarix") %>.<br />
                                            <asp:Label ID="Label58" runat="server" Text="İcrası" Font-Underline="True"></asp:Label>
                                            <%#Eval("DPAdi") %>
                                            <asp:Label ID="Label23" runat="server" Text='<%#dpda(Eval("dp_diger").ToString())%>'></asp:Label>
                                            <%#Eval("DPIL") %>&nbsp;ildə nəzərdə tutulmuşdur.<br />
                                            <asp:Label ID="Label59" runat="server" Text="İcrası razılaşdırılıb" Font-Underline="True"></asp:Label>: <%#Eval("IcrasiRazilashdirilib") %>
                                            <%#Eval("Vezifesi") %> <%#Eval("Soyadi") %> <%#Eval("Adi") %>
                                            <asp:Label ID="Label63" runat="server" Text="Telefon nömrəsi"></asp:Label>: <%#Eval("Telefonu") %>.<br />
                                        </asp:Panel>

                                        <asp:Panel ID="Panel8" Visible='<%#Convert.ToBoolean(bowdursacixma(Eval("CommandPost").ToString()))%>' runat="server">
                                            <asp:Label ID="Label40" runat="server" Text="İcrası barədə qeyd" Font-Underline="True"></asp:Label>:
             <%#Eval("CommandPost")%>. <%#Class2.sozukes(Eval("DatePost").ToString()) %>.
                                        </asp:Panel>
                                        <asp:Panel ID="Panel3" Visible='<%#Convert.ToBoolean(bowdursacixma(Eval("WorkView").ToString()))%>' runat="server">
                                            <asp:Label ID="Label8" runat="server" Text="Görülmüş işlər" Font-Underline="True"></asp:Label>: <%#Eval("WorkView") %>.<br />
                                        </asp:Panel>
                                        <asp:Panel ID="Panel10" Visible='<%#Convert.ToBoolean(bowdursacixma(Eval("ResultView").ToString()))%>' runat="server">
                                            <asp:Label ID="Label13" runat="server" Text="Əldə olunmuş nəticə" Font-Underline="True"></asp:Label>: <%#Eval("ResultView") %>.
                                        </asp:Panel>
                                    </td>

                                    <td>&nbsp;</td>
                                </tr>
                            </table>
                        </div>
                    </ItemTemplate>
                </asp:DataList>



                <div>
                    <asp:Label ID="Label91" runat="server" Text="Plandan əlavə"></asp:Label>
                </div>
                <asp:DataList ID="dlesaslitemir0" runat="server">
                    <ItemTemplate>
                        <div>
                            <div>
                                <%#Container.ItemIndex+1 %>. <%#Eval("SubObjectOther1") %>.
                            </div>
                            <table style="width: 100%; white-space: normal;">
                                <tr>
                                    <td style="width: 18px; white-space: normal;">&nbsp;</td>
                                    <td style="width: 943px; white-space: normal;">
                                        <asp:Label ID="Label52" runat="server" Text="Yaşayış məntəqəsi" Font-Underline="True"></asp:Label>: <%#Eval("Living_Point") %>.<br />
                                        <asp:Label ID="Label53" runat="server" Text="Obyektin adı" Font-Underline="True"></asp:Label>: <%#Eval("ObjectName") %>.<br />
                                        <asp:Label ID="Label54" runat="server" Text="İnşaat işlərinin vəziyyəti" Font-Underline="True"></asp:Label>:  
    <asp:Label ID="Label18" runat="server" Text='<%#inwaatiwvez(Eval("ConductedDate").ToString(),Eval("SuspendedDate").ToString(),Eval("operationDate").ToString())%>'></asp:Label>
                                        <asp:Label ID="Label22" runat="server" Text='<%#Class2.sozukes(inwaatiwveztarix(Eval("ConductedDate").ToString(),Eval("SuspendedDate").ToString(),Eval("operationDate").ToString()))%>'></asp:Label>. <%#Eval("CouseOther1") %>
                                        <asp:Panel ID="Panel1" Visible='<%#Convert.ToBoolean(bowdursacixma(Eval("IHBMektub").ToString()))%>' runat="server">
                                            <asp:Label ID="Label55" runat="server" Text="Problemin aradan qaldırılması ilə bağlı görülmüş tədbirlər <br /> İHB məktubu" Font-Underline="True"></asp:Label>: <%#Eval("IHBMektub") %>,
    <asp:Label ID="Label56" runat="server" Text="№"></asp:Label>: <%#Eval("MektubNomre") %>, <%#Eval("MektubTarix") %>.<br />
                                            <asp:Label ID="Label58" runat="server" Text="İcrası" Font-Underline="True"></asp:Label>
                                            <%#Eval("DPAdi") %>
                                            <asp:Label ID="Label23" runat="server" Text='<%#dpda(Eval("dp_diger").ToString())%>'></asp:Label>
                                            <%#Eval("DPIL") %>&nbsp;ildə nəzərdə tutulmuşdur.<br />
                                            <asp:Label ID="Label59" runat="server" Text="İcrası razılaşdırılıb" Font-Underline="True"></asp:Label>: <%#Eval("IcrasiRazilashdirilib") %>
                                            <%#Eval("Vezifesi") %> <%#Eval("Soyadi") %> <%#Eval("Adi") %>
                                            <asp:Label ID="Label63" runat="server" Text="Telefon nömrəsi"></asp:Label>: <%#Eval("Telefonu") %>.<br />
                                        </asp:Panel>

                                        <asp:Panel ID="Panel8" Visible='<%#Convert.ToBoolean(bowdursacixma(Eval("CommandPost").ToString()))%>' runat="server">
                                            <asp:Label ID="Label40" runat="server" Text="İcrası barədə qeyd" Font-Underline="True"></asp:Label>:
             <%#Eval("CommandPost")%>. <%#Class2.sozukes(Eval("DatePost").ToString()) %>.
                                        </asp:Panel>
                                        <asp:Panel ID="Panel3" Visible='<%#Convert.ToBoolean(bowdursacixma(Eval("WorkView").ToString()))%>' runat="server">
                                            <asp:Label ID="Label8" runat="server" Text="Görülmüş işlər" Font-Underline="True"></asp:Label>: <%#Eval("WorkView") %>.<br />
                                        </asp:Panel>
                                        <asp:Panel ID="Panel10" Visible='<%#Convert.ToBoolean(bowdursacixma(Eval("ResultView").ToString()))%>' runat="server">
                                            <asp:Label ID="Label13" runat="server" Text="Əldə olunmuş nəticə" Font-Underline="True"></asp:Label>: <%#Eval("ResultView") %>.
                                        </asp:Panel>
                                    </td>

                                    <td>&nbsp;</td>
                                </tr>
                            </table>
                        </div>
                    </ItemTemplate>
                </asp:DataList>

                    </asp:Panel>


                <div>
                    <asp:Label ID="Label6" Style="font-weight: bold;" runat="server" Text="Vətəndaşlarla keçirilmiş görüşlər"></asp:Label>
                </div>

                <asp:DataList ID="dlvetendaw" runat="server">
                    <ItemTemplate>
                        <div>
                            <div>
                                <%#Container.ItemIndex+1 %>. Məqsəd: <%#Eval("PurposeOther") %>.
                            </div>
                            <table style="width: 100%; white-space: normal;">
                                <tr>
                                    <td style="width: 18px; white-space: normal;">&nbsp;</td>
                                    <td style="width: 943px; white-space: normal;">
                                        <asp:Label ID="Label24" runat="server" Text="Vətəndaş"></asp:Label>
                                        <%#Eval("Citizen_FullName") %>
                                        <%#Eval("Sname") %>
                                        <%#Eval("adress1") %>.<br />
                                        <asp:Label ID="Label27" runat="server" Text="Qaldırdığı məsələ" Font-Underline="True"></asp:Label>: 
               <%#Eval("Measures_taken") %>.<br />
                                        <asp:Label ID="Label28" runat="server" Text="Məsələ ilə bağlı verilmiş tövsiyyə" Font-Underline="True"></asp:Label>:
               <%#Eval("SubMeasures_taken") %>.
                                    <asp:Label ID="Label18" runat="server" Text='<%#icradadir(Eval("ImplementPost").ToString())%>'></asp:Label><br />

                                        <asp:Panel ID="Panel4" Visible='<%#Convert.ToBoolean(bowdursacixma(Eval("ImplementPost").ToString()))%>' runat="server">

                                            <asp:Label ID="Label29" runat="server" Text="İcrası barədə qeyd" Font-Underline="True"></asp:Label>:
               <%#Eval("ImplementPost") %>.
                                        
                            <%#Class2.sozukes(Eval("DatePost").ToString()) %>.<br />
                                        </asp:Panel>
                                        <asp:Panel ID="Panel3" Visible='<%#Convert.ToBoolean(bowdursacixma(Eval("WorkView").ToString()))%>' runat="server">

                                            <asp:Label ID="Label31" runat="server" Text="Görülmüş işlər" Font-Underline="True"></asp:Label>: 
               <%#Eval("WorkView") %>.<br />
                                        </asp:Panel>
                                        <asp:Panel ID="Panel11" Visible='<%#Convert.ToBoolean(bowdursacixma(Eval("ResultView").ToString()))%>' runat="server">

                                            <asp:Label ID="Label32" runat="server" Text="Əldə olunmuş nəticə" Font-Underline="True"></asp:Label>:
               <%#Eval("ResultView") %>.
                                        </asp:Panel>
                                    </td>
                                    <td>&nbsp;</td>
                                </tr>
                            </table>
                        </div>
                    </ItemTemplate>
                </asp:DataList>


                <div>
                    <asp:Label ID="Label80" runat="server" Text="Plandan əlavə"></asp:Label>
                </div>
                <asp:DataList ID="dlvetendaw0" runat="server">
                    <ItemTemplate>
                        <div>
                            <div>
                                <%#Container.ItemIndex+1 %>. Məqsəd: <%#Eval("PurposeOther") %>.
                            </div>
                            <table style="width: 100%; white-space: normal;">
                                <tr>
                                    <td style="width: 18px; white-space: normal;">&nbsp;</td>
                                    <td style="width: 943px; white-space: normal;">
                                        <asp:Label ID="Label24" runat="server" Text="Vətəndaş"></asp:Label>
                                        <%#Eval("Citizen_FullName") %>
                                        <%#Eval("Sname") %>
                                        <%#Eval("adress1") %>.<br />
                                        <asp:Label ID="Label27" runat="server" Text="Qaldırdığı məsələ" Font-Underline="True"></asp:Label>: 
               <%#Eval("Measures_taken") %>.<br />
                                        <asp:Label ID="Label28" runat="server" Text="Məsələ ilə bağlı verilmiş tövsiyyə" Font-Underline="True"></asp:Label>:
               <%#Eval("SubMeasures_taken") %>.
                                    <asp:Label ID="Label18" runat="server" Text='<%#icradadir(Eval("ImplementPost").ToString())%>'></asp:Label><br />

                                        <asp:Panel ID="Panel4" Visible='<%#Convert.ToBoolean(bowdursacixma(Eval("ImplementPost").ToString()))%>' runat="server">

                                            <asp:Label ID="Label29" runat="server" Text="İcrası barədə qeyd" Font-Underline="True"></asp:Label>:
               <%#Eval("ImplementPost") %>.
                                        
                            <%#Class2.sozukes(Eval("DatePost").ToString()) %>.<br />
                                        </asp:Panel>
                                        <asp:Panel ID="Panel3" Visible='<%#Convert.ToBoolean(bowdursacixma(Eval("WorkView").ToString()))%>' runat="server">

                                            <asp:Label ID="Label31" runat="server" Text="Görülmüş işlər" Font-Underline="True"></asp:Label>: 
               <%#Eval("WorkView") %>.<br />
                                        </asp:Panel>
                                        <asp:Panel ID="Panel11" Visible='<%#Convert.ToBoolean(bowdursacixma(Eval("ResultView").ToString()))%>' runat="server">

                                            <asp:Label ID="Label32" runat="server" Text="Əldə olunmuş nəticə" Font-Underline="True"></asp:Label>:
               <%#Eval("ResultView") %>.
                                        </asp:Panel>
                                    </td>
                                    <td>&nbsp;</td>
                                </tr>
                            </table>
                        </div>
                    </ItemTemplate>
                </asp:DataList>


                <div>
                    <asp:Label ID="Label9" Style="font-weight: bold;" runat="server" Text="İctimai-siyasi vəziyyət və dini durum:"></asp:Label>
                </div>

                <asp:DataList ID="dlictimaisiyasi" runat="server">
                    <ItemTemplate>
                        <div>
                            <div>
                                <%#Container.ItemIndex+1 %>. Məqsəd: <%#Eval("ReligiousOther") %>.
                            </div>
                            <table style="width: 100%; white-space: normal;">
                                <tr>
                                    <td style="width: 18px; white-space: normal;">&nbsp;</td>
                                    <td style="width: 943px; white-space: normal;">
                                        <asp:Label ID="Label32" runat="server" Text="Rəy" Font-Underline="True"></asp:Label>: 
               <%#Eval("SubReligiousOther") %>.<br />
                                        <asp:Panel ID="Panel12" Visible='<%#Convert.ToBoolean(bowdursacixma(Eval("NoteText").ToString()))%>' runat="server">
                                            <asp:Label ID="Label33" runat="server" Text="Səbəb" Font-Underline="True"></asp:Label>:
               <%#Eval("NoteText") %>.<br />
                                        </asp:Panel>
                                        <asp:Panel ID="Panel5" Visible='<%#Convert.ToBoolean(bowdursacixma(Eval("Offer").ToString()))%>' runat="server">
                                            <asp:Label ID="Label34" runat="server" Text="Təklif" Font-Underline="True"></asp:Label>: 
               <%#Eval("Offer") %>.
              <asp:Label ID="Label18" runat="server" Text='<%#icradadir(Eval("Implementation").ToString())%>'></asp:Label><br />

                                        </asp:Panel>
                                        <asp:Panel ID="Panel2" Visible='<%#Convert.ToBoolean(bowdursacixma(Eval("Implementation").ToString()))%>' runat="server">
                                            <asp:Label ID="Label35" runat="server" Text="İcrası barədə qeyd" Font-Underline="True"></asp:Label>: 
               <%#Eval("Implementation") %>. 
               <%#Class2.sozukes(Eval("DatePost").ToString()) %>.
                                        </asp:Panel>
                                    </td>
                                    <td>&nbsp;</td>
                                </tr>
                            </table>
                        </div>
                    </ItemTemplate>
                </asp:DataList>



                <div>
                    <asp:Label ID="Label78" runat="server" Text="Plandan əlavə"></asp:Label>
                </div>
                <asp:DataList ID="dlictimaisiyasi0" runat="server">
                    <ItemTemplate>
                        <div>
                            <div>
                                <%#Container.ItemIndex+1 %>. Məqsəd: <%#Eval("ReligiousOther") %>.
                            </div>
                            <table style="width: 100%; white-space: normal;">
                                <tr>
                                    <td style="width: 18px; white-space: normal;">&nbsp;</td>
                                    <td style="width: 943px; white-space: normal;">
                                        <asp:Label ID="Label32" runat="server" Text="Rəy" Font-Underline="True"></asp:Label>: 
               <%#Eval("SubReligiousOther") %>.<br />
                                        <asp:Panel ID="Panel12" Visible='<%#Convert.ToBoolean(bowdursacixma(Eval("NoteText").ToString()))%>' runat="server">
                                            <asp:Label ID="Label33" runat="server" Text="Səbəb" Font-Underline="True"></asp:Label>:
               <%#Eval("NoteText") %>.<br />
                                        </asp:Panel>
                                        <asp:Panel ID="Panel5" Visible='<%#Convert.ToBoolean(bowdursacixma(Eval("Offer").ToString()))%>' runat="server">
                                            <asp:Label ID="Label34" runat="server" Text="Təklif" Font-Underline="True"></asp:Label>: 
               <%#Eval("Offer") %>.
              <asp:Label ID="Label18" runat="server" Text='<%#icradadir(Eval("Implementation").ToString())%>'></asp:Label><br />

                                        </asp:Panel>
                                        <asp:Panel ID="Panel2" Visible='<%#Convert.ToBoolean(bowdursacixma(Eval("Implementation").ToString()))%>' runat="server">
                                            <asp:Label ID="Label35" runat="server" Text="İcrası barədə qeyd" Font-Underline="True"></asp:Label>: 
               <%#Eval("Implementation") %>. 
               <%#Class2.sozukes(Eval("DatePost").ToString()) %>.
                                        </asp:Panel>
                                    </td>
                                    <td>&nbsp;</td>
                                </tr>
                            </table>
                        </div>
                    </ItemTemplate>
                </asp:DataList>


                <div>
                    <asp:Label ID="Label4" Style="font-weight: bold;" runat="server" Text="Sosial və humanitar sahələrdə həlli vacib olan problemlər:"></asp:Label>
                </div>
                <asp:DataList ID="dlsosialhuman" runat="server">
                    <ItemTemplate>

                        <div>
                            <%#Container.ItemIndex+1 %>. &nbsp;
            <%#Eval("sh1")%> sahəsində problem: <%#Eval("SerbestMetn1") %><br />
                            <table style="width: 100%; white-space: normal;">
                                <tr>
                                    <td style="width: 18px; white-space: normal;">&nbsp;</td>
                                    <td style="width: 943px; white-space: normal;">
                                        <asp:Panel ID="Panel1" Visible='<%#Convert.ToBoolean(bowdursacixma(Eval("IHBMektub").ToString()))%>' runat="server">
                                            <asp:Label ID="Label55" runat="server" Text="Problemin aradan qaldırılması ilə bağlı görülmüş tədbirlər <br /> İHB məktubu" Font-Underline="True"></asp:Label>: <%#Eval("IHBMektub") %>,&nbsp;
    <asp:Label ID="Label56" runat="server" Text="№"></asp:Label>: <%#Eval("MektubNomre") %>,&nbsp;
    <%#Eval("MektubTarix") %>.<br />

                                            <asp:Label ID="Label58" runat="server" Text="İcrası" Font-Underline="True"></asp:Label>
                                            <%#Eval("DPAdi") %>
                                            <asp:Label ID="Label23" runat="server" Text='<%#dpda(Eval("dp_diger").ToString())%>'></asp:Label>
                                            <%#Eval("DPIL") %> ildə nəzərdə tutulmuşdur.<br />
                                            <asp:Label ID="Label59" runat="server" Text="İcrası razılaşdırılıb" Font-Underline="True"></asp:Label>: <%#Eval("IcrasiRazilashdirilib") %>
                                            <%#Eval("Vezifesi") %> <%#Eval("Adi") %> <%#Eval("Soyadi") %>,&nbsp;
     <asp:Label ID="Label63" runat="server" Text="Telefon nömrəsi"></asp:Label>: <%#Eval("Telefonu") %>.<br />

                                            <asp:Label ID="Label47" runat="server" Text="İcra vəziyyəti" Font-Underline="True"></asp:Label>:
    <asp:Label ID="Label18" runat="server" Text='<%#icradadirsosial(Eval("IcraBaredeMelumat").ToString())%>'></asp:Label>

                                            <asp:Label ID="Label48" runat="server" Visible='<%#Convert.ToBoolean(icrabaredemelumat1(Eval("IcraBaredeMelumat").ToString()))%>' Text='<%#Class2.sozukes((Eval("Icra_tarix").ToString()))%>'></asp:Label>
                                            <asp:Label ID="Label50" runat="server"
                                                Visible='<%#Convert.ToBoolean(icrabaredemelumat1(Eval("IcraBaredeMelumat").ToString()))%>'
                                                Text="Tarixə"></asp:Label>
                                            <asp:Label ID="Label49" runat="server"
                                                Visible='<%#Convert.ToBoolean(icrabaredemelumat1(Eval("IcraBaredeMelumat").ToString()))%>'
                                                Text='<%#Eval("SerbestMetn2").ToString() %>'></asp:Label>.                   
             <asp:Panel ID="Panel6" Visible='<%#Convert.ToBoolean(icrabaredemelumat(Eval("IcraBaredeMelumat").ToString()))%>' runat="server">
                 <asp:Label ID="Label25" runat="server" Text="Səbəb" Font-Underline="True"></asp:Label>:<%#Eval("Sebeb") %>.
             </asp:Panel>
                                        </asp:Panel>
                                    </td>
                                    <td>&nbsp;</td>
                                </tr>
                            </table>
                        </div>
                    </ItemTemplate>
                </asp:DataList>





                <div>
                    <asp:Label ID="Label12" Style="font-weight: bold;" runat="server" Text="İqtisadi və sahibkarlıq sahələrində həlli vacib olan problemlər:"></asp:Label>
                </div>
                <asp:DataList ID="dliqtisadisahib" runat="server">
                    <ItemTemplate>

                        <div>

                            <%#Container.ItemIndex+1 %>. &nbsp;
             <%#Eval("sh1") %>  sahəsində problem: <%#Eval("SerbestMetn1") %><br />

                            <table style="width: 100%; white-space: normal;">
                                <tr>
                                    <td style="width: 18px; white-space: normal;">&nbsp;</td>
                                    <td style="width: 943px; white-space: normal;">


                                        <asp:Panel ID="Panel1" Visible='<%#Convert.ToBoolean(bowdursacixma(Eval("IHBMektub").ToString()))%>' runat="server">

                                            <asp:Label ID="Label55" runat="server" Text="Problemin aradan qaldırılması ilə bağlı görülmüş tədbirlər <br /> İHB məktubu" Font-Underline="True"></asp:Label>: <%#Eval("IHBMektub") %>,&nbsp;
    <asp:Label ID="Label56" runat="server" Text="№"></asp:Label>: <%#Eval("MektubNomre") %>,&nbsp;
                                            <%#Eval("MektubTarix") %>.<br />
                                            <asp:Label ID="Label58" runat="server" Text="İcrası" Font-Underline="True"></asp:Label>
                                            <%#Eval("DPAdi") %>
                                            <asp:Label ID="Label23" runat="server" Text='<%#dpda(Eval("dp_diger").ToString())%>'></asp:Label>
                                            <%#Eval("DPIL") %>&nbsp;ildə nəzərdə tutulmuşdur.<br />
                                            <asp:Label ID="Label59" runat="server" Text="İcrası razılaşdırılıb" Font-Underline="True"></asp:Label>: <%#Eval("IcrasiRazilashdirilib") %>
                                            <%#Eval("Vezifesi") %> <%#Eval("Adi") %> <%#Eval("Soyadi") %>,
     <asp:Label ID="Label63" runat="server" Text="Telefon nömrəsi"></asp:Label>: <%#Eval("Telefonu") %>.
                                        </asp:Panel>

                                        <asp:Label ID="Label47" runat="server" Text="İcra vəziyyəti" Font-Underline="True"></asp:Label>:
    <asp:Label ID="Label18" runat="server" Text='<%#icradadirsosial(Eval("IcraBaredeMelumat").ToString())%>'></asp:Label>

                                        <asp:Label ID="Label48" runat="server" Visible='<%#Convert.ToBoolean(icrabaredemelumat1(Eval("IcraBaredeMelumat").ToString()))%>' Text='<%#Class2.sozukes((Eval("Icra_tarix").ToString()))%>'></asp:Label>
                                        <asp:Label ID="Label50" runat="server"
                                            Visible='<%#Convert.ToBoolean(icrabaredemelumat1(Eval("IcraBaredeMelumat").ToString()))%>' Text="Tarixə"></asp:Label>
                                        <asp:Label ID="Label49" runat="server"
                                            Visible='<%#Convert.ToBoolean(icrabaredemelumat1(Eval("IcraBaredeMelumat").ToString()))%>'
                                            Text='<%#Eval("SerbestMetn2").ToString() %>'></asp:Label>



                                        <asp:Panel ID="Panel6" Visible='<%#Convert.ToBoolean(icrabaredemelumat(Eval("IcraBaredeMelumat").ToString()))%>' runat="server">
                                            <asp:Label ID="Label25" runat="server" Text="Səbəb" Font-Underline="True"></asp:Label>:<%#Eval("Sebeb") %>.
                                        </asp:Panel>
                                    </td>
                                    <td>&nbsp;</td>
                                </tr>
                            </table>
                        </div>
                    </ItemTemplate>
                </asp:DataList>

                <div>
                    <asp:Label ID="Label7" Style="font-weight: bold;" runat="server" Text="Mövcud əyani təşviqat vasitələrinin vəziyyəti:"></asp:Label>
                </div>

                <asp:DataList ID="dlmovcudeyani" runat="server">
                    <ItemTemplate>
                        <div>
                            <div>
                                <%-- <%#Eval("Sn").ToString()%>--%><%#Container.ItemIndex+1 %>.
        <%--<%#planauygunluq((bool)Eval("Plan1")) %>--%> Mövcud <%#Eval("Situation_SUM") %> əyani təşviqat vasitəsindən <%#Class2.sozukes(Eval("DatePost").ToString()) %>
         tarixə <%#Eval("Situation_Excellent") %> əla, <%#Eval("Situation_fit") %> yararlı, <%#Eval("Situation_unfit") %> yararsız vəziyyətdədir.
                            </div>

                            <table style="width: 100%; white-space: normal;">
                                <tr>
                                    <td style="width: 18px; white-space: normal;">&nbsp;</td>
                                    <td style="width: 943px; white-space: normal;">
                                        <asp:Label ID="Label36" runat="server" Text="Təklif" Font-Underline="True"></asp:Label>:
               <%#Eval("Offer") %>.<asp:Label ID="Label18" runat="server" Text='<%#icradadir(Eval("OfferPost").ToString())%>'></asp:Label><br />
                                        <asp:Panel ID="Panel5" Visible='<%#Convert.ToBoolean(bowdursacixma(Eval("OfferPost").ToString()))%>' runat="server">
                                            <asp:Label ID="Label37" runat="server" Text="Görülmüş tədbirlər" Font-Underline="True"></asp:Label>:
               <%#Eval("OfferPost") %>.   
 <%#Class2.sozukes(Eval("DatePost").ToString()) %>.
                                        </asp:Panel>
                                    </td>
                                    <td>&nbsp;</td>
                                </tr>
                            </table>
                        </div>
                    </ItemTemplate>
                </asp:DataList>





                <div>
                    <asp:Label ID="Label8" Style="font-weight: bold;" runat="server" Text="Fərdi söhbət aparılmış kadrlar:"></asp:Label>
                </div>
                <asp:DataList ID="dlferdisohbet" runat="server">
                    <ItemTemplate>
                        <div>
                            <div>
                                <%#Container.ItemIndex+1 %>.
                                <%#Eval("Sub_FramesOther") %> <%#Eval("Name") %>.
                              <br />

                            </div>
                            <asp:Panel ID="Panel7" Visible='<%#Convert.ToBoolean(bowdursacixma2(Eval("WorkView").ToString(),Eval("ResultView").ToString(),Eval("TextNote").ToString()))%>' runat="server">

                                <table style="width: 100%; white-space: normal;">
                                    <tr>
                                        <td style="width: 18px; white-space: normal;">&nbsp;</td>
                                        <td style="width: 943px; white-space: normal;">
                                            <asp:Panel ID="Panel1" Visible='<%#Convert.ToBoolean(bowdursacixma(Eval("TextNote").ToString()))%>' runat="server">
                                                <asp:Label ID="Label41" runat="server" Text="Təklif" Font-Underline="True"></asp:Label>:
               <%#Eval("TextNote") %>.
           <asp:Label ID="Label18" runat="server" Text='<%#icradadirferdi(Eval("TextNote").ToString())%>'></asp:Label><br />
                                            </asp:Panel>
                                            <asp:Panel ID="Panel3" Visible='<%#Convert.ToBoolean(bowdursacixma(Eval("WorkView").ToString()))%>' runat="server">

                                                <asp:Label ID="Label42" runat="server" Text="Görülmüş işlər" Font-Underline="True"></asp:Label>: 
               <%#Eval("WorkView") %>.<br />
                                            </asp:Panel>
                                            <asp:Panel ID="Panel13" Visible='<%#Convert.ToBoolean(bowdursacixma(Eval("ResultView").ToString()))%>' runat="server">
                                                <asp:Label ID="Label26" runat="server" Text="Əldə olunmuş nəticə" Font-Underline="True"></asp:Label>: 
               <%#Eval("ResultView") %>.
                                            </asp:Panel>
                                        </td>
                                        <td>&nbsp;</td>
                                    </tr>
                                </table>
                            </asp:Panel>
                        </div>
                    </ItemTemplate>
                </asp:DataList>




                <div>
                    <asp:Label ID="Label10" Style="font-weight: bold;" runat="server" Text="Digər görüşlər:"></asp:Label>
                </div>

                <asp:DataList ID="dlumumigoruw" runat="server">
                    <ItemTemplate>
                        <div>
                            <div><%#Container.ItemIndex+1 %>. <%#Eval("Meetings") %> görüş keçirilmişdir.</div>
                            <table style="width: 100%; white-space: normal;">
                                <tr>
                                    <td style="width: 18px; white-space: normal;">&nbsp;</td>
                                    <td style="width: 943px; white-space: normal;">
                                        <asp:Label ID="Label43" runat="server" Text="Keçirilmiş görüş" Font-Underline="True"></asp:Label>:
               <%#Eval("Meetings") %>.<br />
                                        <asp:Label ID="Label44" runat="server" Text="Müzakirə edilmiş məsələ" Font-Underline="True"></asp:Label>:
                <%#Eval("MOM") %>.<br />
                                        <asp:Panel ID="Panel3" Visible='<%#Convert.ToBoolean(bowdursacixma(Eval("WorkView").ToString()))%>' runat="server">

                                            <asp:Label ID="Label45" runat="server" Text="Görülmüş işlər" Font-Underline="True"></asp:Label>:
                <%#Eval("WorkView") %>.<br />
                                        </asp:Panel>
                                        <asp:Panel ID="Panel13" Visible='<%#Convert.ToBoolean(bowdursacixma(Eval("ResultView").ToString()))%>' runat="server">

                                            <asp:Label ID="Label46" runat="server" Text="Əldə olunmuş nəticə" Font-Underline="True"></asp:Label>:
               <%#Eval("ResultView") %>.
                                        </asp:Panel>

                                    </td>
                                    <td>&nbsp;</td>
                                </tr>
                            </table>
                        </div>
                    </ItemTemplate>
                </asp:DataList>



                <div>
                    <asp:Label ID="Label76" runat="server" Text="Plandan əlavə"></asp:Label>
                </div>
                <asp:DataList ID="dlumumigoruw0" runat="server">
                    <ItemTemplate>
                        <div>
                            <div><%#Container.ItemIndex+1 %>. <%#Eval("Meetings") %> görüş keçirilmişdir.</div>
                            <table style="width: 100%; white-space: normal;">
                                <tr>
                                    <td style="width: 18px; white-space: normal;">&nbsp;</td>
                                    <td style="width: 943px; white-space: normal;">
                                        <asp:Label ID="Label43" runat="server" Text="Keçirilmiş görüş" Font-Underline="True"></asp:Label>:
               <%#Eval("Meetings") %>.<br />
                                        <asp:Label ID="Label44" runat="server" Text="Müzakirə edilmiş məsələ" Font-Underline="True"></asp:Label>:
                <%#Eval("MOM") %>.<br />
                                        <asp:Panel ID="Panel3" Visible='<%#Convert.ToBoolean(bowdursacixma(Eval("WorkView").ToString()))%>' runat="server">

                                            <asp:Label ID="Label45" runat="server" Text="Görülmüş işlər" Font-Underline="True"></asp:Label>:
                <%#Eval("WorkView") %>.<br />
                                        </asp:Panel>
                                        <asp:Panel ID="Panel13" Visible='<%#Convert.ToBoolean(bowdursacixma(Eval("ResultView").ToString()))%>' runat="server">

                                            <asp:Label ID="Label46" runat="server" Text="Əldə olunmuş nəticə" Font-Underline="True"></asp:Label>:
               <%#Eval("ResultView") %>.
                                        </asp:Panel>

                                    </td>
                                    <td>&nbsp;</td>
                                </tr>
                            </table>
                        </div>
                    </ItemTemplate>
                </asp:DataList>


                <div style="padding-top: 5px; text-align: right; font-weight: bold; height: 170px; white-space: normal;">
                    <asp:Panel Style="text-align: left; float: left;" ID="pnltsdq" runat="server" Width="431px">
                        <asp:Button ID="btnPrint" runat="server" Text="Wordə çıxart" OnClientClick="return PrintPanel();" Width="300px" OnClick="btnPrint_Click" />
                        <br />
                        <asp:Panel ID="pnlkuratortesdiq" Visible="false" runat="server">

                            <br />
                            <asp:Button ID="btntesdiqkur" runat="server" OnClick="btntesdiqkur_Click" Text="Təsdiq et" Visible="False" Width="300px" />
                            <br />
                        </asp:Panel>

                        <br />



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
