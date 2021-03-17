<%@ Page Title="" Language="C#" MasterPageFile="~/adminpanel/adminMasterPage.master" AutoEventWireup="true" CodeFile="Yeniezamiyye.aspx.cs" Inherits="adminpanel_Ezamteqvim" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <meta http-equiv="content-type" content="text/html;charset=UTF-8" />
    <meta http-equiv="content-type" content="application/xhtml+xml; charset=UTF-8" />
    <style type="text/css">
        
        .auto-style141 {
            width: 146px;
        }

        .style1 {
            width: 100%;
        }

        .auto-style142 {
            height: 22px;
            width: 8px;
        }

        .auto-style144 {
            height: 22px;
            width: 264px;
        }

        .auto-style152 {
            width: 249px;
        }

        .auto-style154 {
            width: 356px;
        }

        .auto-style159 {
            width: 36px;
        }

        .auto-style160 {
            width: 243px;
        }

        .auto-style161 {
            width: 144px;
        }

        .auto-style162 {
            width: 132px;
        }

        .auto-style163 {
            width: 153px;
        }

        .auto-style165 {
            width: 68px;
        }

        .auto-style167 {
            width: 344px;
        }

        .auto-style168 {
            height: 22px;
            width: 508px;
        }

        .auto-style169 {
            width: 645px;
        }

        .auto-style171 {
            width: 135px;
        }

        .auto-style172 {
            width: 549px;
        }
        .auto-style173 {
            width: 142px;
        }
        .auto-style181 {
            width: 172px;
        }
        .auto-style182 {
            width: 325px;
        }
        .auto-style185 {
            width: 70px;
        }
        .auto-style186 {
            width: 321px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <meta http-equiv="content-type" content="application/xhtml+xml; charset=UTF-8" />
    <table style="width: 1019px">
        <tr>
            <td class="auto-style159">&nbsp;</td>
            <td class="auto-style152">
                <asp:Button ID="btntesdiqolmuw0" runat="server" Text="Təqdim edilməmiş" Width="200px" OnClick="btntesdiqolmuw0_Click" />
            </td>
            <td class="auto-style160">
                <asp:Button ID="btntesdiqolmamiw" runat="server" OnClick="btntesdiqolmamiw_Click" Text="Təsdiq olunmamış" Width="200px" />
            </td>
            <td>
                <asp:Button ID="btntesdiqolmuw" runat="server" OnClick="btntesdiqolmuw_Click" Text="Təsdiq olunmuş" Width="200px" />
            </td>
            <td>
                <asp:Button ID="eztarixnezaret" runat="server" Text="Ezamiyyə tarixinə nəzarət" Width="200px" OnClick="eztarixnezaret_Click" />
            </td>
        </tr>
    </table>
    <asp:Panel ID="pnltesdiqolunmamiw" Visible="false" runat="server">


        <table style="width: 1019px">
            <tr>
                <td class="auto-style144">&nbsp;</td>
                <td class="auto-style162">
                    <asp:Button ID="btnumumi1" runat="server" OnClick="btnumumi1_Click" Text="Ümumi" Width="120px" />

                </td>
                <td class="auto-style154">
                    <asp:Button ID="btnrayuzre1" runat="server" OnClick="btnrayuzre1_Click" Text="Rayonlar üzrə" Width="120px" />

                </td>
                <td>&nbsp;</td>

            </tr>
        </table>
        <asp:Panel ID="pnlumumi1" Visible="false" runat="server">

            <asp:Panel ID="pnlredakte" Visible="false" runat="server">



                <div style="float: left; padding-left: 100px; padding-top: 5px; width: 318px; height: 347px;">
                </div>
                <div style="float: left; width: 327px;">
                    <asp:Panel ID="Panel2" runat="server">
                        <div style="padding-top: 20px; width: 300px;">

                            <table class="auto-style1">
                                <tr>
                                    <td><strong>Ezamiyyənin başlama tarixi:&nbsp; </strong>
                                        <asp:ImageButton ID="imgcldbawla" runat="server" Height="23px" ImageUrl="~/images/calendar-icon.png" Width="23px" OnClick="imgcldbawla_Click" />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lblgelmeredakte" runat="server"></asp:Label>



                                        <asp:Calendar ID="cldgelme" runat="server" OnDayRender="cldgelme_DayRender" OnSelectionChanged="cldgelme_SelectionChanged" Visible="False" BackColor="White" BorderColor="#999999"
                                            CellSpacing="1" DayNameFormat="Shortest" Font-Names="Arial" Font-Size="9pt" ForeColor="Black"
                                            Height="180px" Width="213px">
                                            <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                                            <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                                            <SelectorStyle BackColor="#CCCCCC" />
                                            <WeekendDayStyle BackColor="#FFFFCC" />
                                            <OtherMonthDayStyle ForeColor="White" />
                                            <NextPrevStyle VerticalAlign="Bottom" />
                                            <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                                            <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                                        </asp:Calendar>
                                    </td>

                                </tr>
                                <tr>
                                    <td>&nbsp;</td>

                                </tr>
                                <tr>
                                    <td><strong>Ezamiyyənin bitmə tarixi:&nbsp;
                                        <asp:ImageButton ID="imgbitme" runat="server" Height="23px" ImageUrl="~/images/calendar-icon.png" Width="23px" OnClick="imgbitme_Click" />
                                    </strong></td>
                                </tr>
                                <tr>
                                    <td class="auto-style9">
                                        <asp:Label ID="lblbitmeredakte" runat="server"></asp:Label>


                                        <asp:Calendar ID="cldbitme" runat="server" OnDayRender="cldbitme_DayRender" OnSelectionChanged="cldbitme_SelectionChanged" Visible="False" BackColor="White" BorderColor="#999999"
                                            CellSpacing="1" DayNameFormat="Shortest" Font-Names="Arial" Font-Size="9pt" ForeColor="Black"
                                            Height="180px" Width="213px">
                                            <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                                            <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                                            <SelectorStyle BackColor="#CCCCCC" />
                                            <WeekendDayStyle BackColor="#FFFFCC" />
                                            <OtherMonthDayStyle ForeColor="White" />
                                            <NextPrevStyle VerticalAlign="Bottom" />
                                            <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                                            <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                                        </asp:Calendar>
                                    </td>


                                </tr>
                                <tr>
                                    <td class="auto-style10">&nbsp;</td>


                                </tr>
                                <tr>
                                    <td><strong>İşə çıxma tarixi:&nbsp;
                                        <asp:ImageButton ID="imgiwecixma" runat="server" Height="23px" ImageUrl="~/images/calendar-icon.png" Width="23px" OnClick="imgiwecixma_Click" />
                                    </strong></td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lblisecixma" runat="server"></asp:Label>



                                        <asp:Calendar ID="cldisecixma" runat="server" OnDayRender="cldisecixma_DayRender" OnSelectionChanged="cldisecixma_SelectionChanged" Visible="false" BackColor="White" BorderColor="#999999"
                                            CellSpacing="1" DayNameFormat="Shortest" Font-Names="Arial" Font-Size="9pt" ForeColor="Black"
                                            Height="180px" Width="213px">
                                            <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                                            <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                                            <SelectorStyle BackColor="#CCCCCC" />
                                            <WeekendDayStyle BackColor="#FFFFCC" />
                                            <OtherMonthDayStyle ForeColor="White" />
                                            <NextPrevStyle VerticalAlign="Bottom" />
                                            <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                                            <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                                        </asp:Calendar>
                                    </td>

                                </tr>

                            </table>
                            <asp:Button ID="btnredakte" Style="margin-top: 70px;" runat="server" Text="Yadda saxla" Width="130px" Height="36px" OnClick="btnredakte_Click" />

                            <asp:Label ID="lblrayona" runat="server" Visible="False"></asp:Label>

                            <asp:Label ID="lblcix" runat="server" Visible="False"></asp:Label>


                        </div>
                    </asp:Panel>
                </div>
                <div class="message">
                    <asp:Label ID="lblredaktemsg" Font-Bold="True" runat="server"></asp:Label>
                </div>
                <div class="message">
                    <asp:Label ID="message" Font-Bold="True" runat="server"></asp:Label>
                </div>
                <div class="temizle"></div>

            </asp:Panel>








            <asp:DataList ID="DataList1" runat="server" ForeColor="#333333" OnItemDataBound="DataList1_ItemDataBound" Width="1024px">
                <AlternatingItemStyle BackColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderTemplate>
                    <table class="style1">
                        <tr>
                            <td style="padding-left: 2px; text-align: left; width: 3%; white-space: normal;">№</td>

                            <td style="padding-left: 10px; text-align: left; width: 13%; white-space: normal;">Kuratorun adı</td>
                            <td style="padding-left: 10px; text-align: left; width: 30%; white-space: normal;">Ezamiyyə dövrü üçün müəyyən  edilmiş şəhər və rayonlar</td>
                            <td style="padding-left: 10px; text-align: left; width: 11%; white-space: normal;">Ezamiyyənin başlama tarixi</td>
                            <td style="padding-left: 10px; text-align: left; width: 11%; white-space: normal;">Ezamiyyənin bitmə tarixi</td>
                            <td style="padding-left: 10px; text-align: left; width: 11%; white-space: normal;">İşə çıxma tarixi</td>
                            <%--    <td style="padding-left:10px;text-align:left;width:11%;white-space: normal;">Ezamiyyə tarixinə düzəliş</td>
                            --%>  <%--   <td style="text-align:left;width:3%;white-space: normal;">Sil</td>--%>
                            <%--    <td style="padding-left:10px;text-align:left;width:17%;white-space: normal;">Şəhər və  rayonlar üzrə</td>
                            --%>
                        </tr>
                    </table>
                </HeaderTemplate>
                <ItemStyle />
                <ItemTemplate>
                    <table style="border-bottom-style: dotted; border-bottom-width: thin; width: 100%; border-left-style: dotted; border-left-width: thin; border-right-style: dotted; border-right-width: thin;">
                        <tr>
                            <td style="padding-left: 2px; text-align: left; width: 3%; word-break: break-all; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><%#Container.ItemIndex+1 %></td>
                            <td style="padding-left: 10px; text-align: left; width: 13%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><%#Eval("nameuser") %></td>

                            <td style="padding-left: 10px; text-align: left; width: 30%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><%#Eval("Regions") %></td>
                            <td style="padding-left: 10px; text-align: left; width: 11%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><%#Class2.sozukes(Eval("RegionCome").ToString()) %></td>
                            <td style="padding-left: 10px; text-align: left; width: 11%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><%#Class2.sozukes(Eval("GoFromRegion").ToString())%></td>
                            <td style="padding-left: 10px; text-align: left; width: 11%; white-space: normal;"><%#Class2.sozukes(Eval("ComingToWork").ToString()) %></td>

                            <%-- <td style="padding-left:10px;width:11%;white-space: normal;"><a class="aucun" href='Yeniezamiyye.aspx?BusinessTripID=<%#Eval("BusinessTripID") %>&UserID=<%#Eval("UserID") %>&islem=duzelis&rownumber=<%#Container.ItemIndex %>'>
                                         <asp:Label ID="Label3" runat="server" Text="Düzəliş"></asp:Label>
                                         </a></td>
                            --%>
                            <%--                                       <asp:Panel  ID="Panel5" runat="server">
                                 <td style="padding-left:2px;width:3%;white-space: normal;border-right:dotted; border-right-style: dotted; border-right-width: thin;">   
                                         <a class="aucun" href='Ezamiyyenintesviri.aspx?BusinessTripID=<%#Eval("BusinessTripID") %>&islem=sil'>Sil</a>                            
                                 </td>
                                           </asp:Panel>--%>
                            <%--    <td style="padding-left:10px;text-align:left;width:17%;white-space: normal;"><a class="aucun" href='Yeniezamiyye.aspx?BusinessTripID=<%#Eval("BusinessTripID") %>&islem=rayontarix'>Rayonlar</a></td>
                            --%>
                        </tr>
                    </table>
                </ItemTemplate>
                <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            </asp:DataList>

        </asp:Panel>

        <asp:Panel ID="pnlrayonuzre1" Visible="false" runat="server">

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




            <div style="float: left; width: 346px; padding-top: 10px; height: 187px;">
                Rayon:&nbsp;&nbsp;
                <asp:DropDownList ID="ddlryn" runat="server">
                </asp:DropDownList>
                <br />
                <br />
                &nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Axtar" Width="120px" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="exele" runat="server" OnClick="exele_Click" Text="Wordə çıxart" Visible="False" Width="120px" />
                <br />
                <br />
                <asp:Label ID="lblmesage" Font-Bold="True" runat="server" Text=""></asp:Label>
                <asp:Label ID="lblgetme1" runat="server" Visible="False"></asp:Label>
                <asp:Label ID="lblgelme1" runat="server" Visible="False"></asp:Label>
            </div>

            <div style="float: left; width: 284px; height: 206px;">
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

            <div style="float: left; width: 377px; height: 206px;">
                <asp:Label ID="lblgetme" runat="server" Text=""></asp:Label>

                <asp:ImageButton ID="imgbsilgetme0" runat="server" Height="14px" OnClick="imgbsilgetme0_Click" src="images/iconlar/sil.png" Visible="False" Width="14px" />

                <asp:Calendar ID="Calendar3" runat="server" BackColor="White" BorderColor="#999999" Visible="false"
                    CellSpacing="1" DayNameFormat="Shortest" Font-Names="Arial" Font-Size="9pt" ForeColor="Black"
                    Height="180px" OnSelectionChanged="Calendar3_SelectionChanged" Width="213px">
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




            <div class="temizle"></div>





            <asp:DataList ID="dlrayontarix" runat="server" ForeColor="#333333" Width="1024px">
                <AlternatingItemStyle BackColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderTemplate>
                    <table class="style1">
                        <tr>
                            <td style="padding-left: 2px; text-align: left; width: 3%; white-space: normal;">№</td>
                            <td style="padding-left: 10px; text-align: left; width: 15%; white-space: normal;">Kuratorun adı</td>
                            <td style="padding-left: 10px; text-align: left; width: 15%; white-space: normal;">Ezamiyyə dövrü üçün müəyyən edilmiş şəhər və rayonlar</td>
                            <td style="padding-left: 10px; text-align: center; width: 15%; white-space: normal;">Şəhərə, rayona gəlmə tarixi</td>
                            <td style="padding-left: 10px; text-align: center; width: 15%; white-space: normal;">Şəhərdən, rayondan getmə tarixi</td>
                            <td style="padding-left: 10px; text-align: center; width: 10%; white-space: normal;">Baxış</td>
                         <td style="padding-left: 10px; text-align: left; width: 10%;">Təsdiq edilməsi</td>
                            <td style=" text-align: left; width: 12%;">Tarixlərin yoxlanması</td>
                            <%--    <td style="padding-left: 10px; text-align: left; width: 13%;">Düzəliş</td>--%>
                        </tr>
                    </table>
                </HeaderTemplate>
                <ItemStyle />
                <ItemTemplate>
                    <table style="border-bottom-style: dotted; border-bottom-width: thin; width: 100%; border-left-style: dotted; border-left-width: thin; border-right-style: dotted; border-right-width: thin;">
                        <tr>
                            <td style="padding-left: 2px; text-align: left; width: 3%; word-break: break-all; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><%#Container.ItemIndex+1 %></td>
                            <td style="padding-left: 10px; text-align: left; width: 15%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><%#Eval("nameuser") %></td>
                            <td style="padding-left: 10px; text-align: left; width: 15%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><%#Eval("Name")%></td>
                            <td style="padding-left: 10px; text-align: center; width: 15%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><%#Class2.sozukes(Eval("RegionCome").ToString()) %></td>
                            <td style="padding-left: 10px; text-align: center; width: 15%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><%#Class2.sozukes(Eval("GoFromRegion").ToString())%></td>
                            <td style="padding-left: 10px; text-align: center; width: 10%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><a class="aucun" href='../kurator/view_print_plan1.aspx?islem1=g2r2i1&RayonID=<%#Eval("RegionID") %>&UserID=<%#Eval("UserID") %>&islem=bax&RegionCode=<%#Eval("RegionCode") %>&BusinessTripID=<%#Eval("BusinessTripID") %>'>Baxış</a></td>
                            <td style="padding-left: 10px; text-align: left; width: 10%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;">   <asp:Label ID="Label1" runat="server"  Text='<%#planagir(Eval("Approval").ToString())%>' ForeColor='<%#System.Drawing.Color.FromName(planagirme2(Eval("Approval").ToString()))%>' Font-Bold="True"></asp:Label>
 <td style="color:red; text-align: left; width: 12%; white-space: normal; font-weight: bold;">   
     <%#Eval("busi")%>
</td>

                        </tr>
                    </table>
                </ItemTemplate>
                <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            </asp:DataList>



        </asp:Panel>

    </asp:Panel>
    <asp:Panel ID="pnltesdiqolunmuw" Visible="false" runat="server">

        <table style="width: 1019px">
            <tr>
                <td class="auto-style168">&nbsp;</td>
                <td class="auto-style162">
                    <asp:Button ID="btnumumi2" runat="server" OnClick="btnumumi2_Click" Text="Ümumi" Width="120px" />

                </td>
                <td class="auto-style154">
                    <asp:Button ID="btnrayuzre2" runat="server" OnClick="btnrayuzre2_Click" Text="Rayonlar üzrə" Width="120px" />

                </td>
                <td>&nbsp;</td>

            </tr>
        </table>
        <asp:Panel ID="pnlumumi2" Visible="false" runat="server">

            <asp:DataList ID="DataList2" runat="server" ForeColor="#333333" OnItemDataBound="DataList1_ItemDataBound" Width="1024px">
                <AlternatingItemStyle BackColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderTemplate>
                    <table class="style1">
                        <tr>
                            <td style="padding-left: 2px; text-align: left; width: 3%; white-space: normal;">№</td>
                            <td style="padding-left: 10px; text-align: left; width: 13%; white-space: normal;">Kuratorun adı</td>
                            <td style="padding-left: 10px; text-align: left; width: 30%; white-space: normal;">Ezamiyyə dövrü üçün müəyyən edilmiş şəhər və rayonlar</td>
                            <td style="padding-left: 10px; text-align: left; width: 11%; white-space: normal;">Ezamiyyənin başlama tarixi</td>
                            <td style="padding-left: 10px; text-align: left; width: 11%; white-space: normal;">Ezamiyyənin bitmə tarixi</td>
                            <td style="padding-left: 10px; text-align: left; width: 11%; white-space: normal;">İşə çıxma tarixi</td>
                            <%--  <td style="padding-left:10px;text-align:left;width:11%;white-space: normal;">Ezamiyyə tarixinə düzəliş</td>
                            --%>  <%--   <td style="text-align:left;width:3%;white-space: normal;">Sil</td>--%><%--    <td style="padding-left:10px;text-align:left;width:17%;white-space: normal;">Şəhər və  rayonlar üzrə</td>
                            --%>
                        </tr>
                    </table>
                </HeaderTemplate>
                <ItemStyle />
                <ItemTemplate>
                    <table style="border-bottom-style: dotted; border-bottom-width: thin; width: 100%; border-left-style: dotted; border-left-width: thin; border-right-style: dotted; border-right-width: thin;">
                        <tr>
                            <td style="padding-left: 2px; text-align: left; word-break: break-all; width: 3%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><%#Container.ItemIndex+1 %></td>
                            <td style="padding-left: 10px; text-align: left; width: 13%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><%#Eval("nameuser") %></td>
                            <td style="padding-left: 10px; text-align: left; width: 30%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><%#Eval("Regions") %></td>
                            <td style="padding-left: 10px; text-align: left; width: 11%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><%#Class2.sozukes(Eval("RegionCome").ToString()) %></td>
                            <td style="padding-left: 10px; text-align: left; width: 11%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><%#Class2.sozukes(Eval("GoFromRegion").ToString())%></td>
                            <td style="padding-left: 10px; text-align: left; width: 11%; white-space: normal;"><%#Class2.sozukes(Eval("ComingToWork").ToString()) %></td>
                            <%-- <td style="padding-left:10px;width:11%;white-space: normal;"><a class="aucun" href='Yeniezamiyye.aspx?BusinessTripID=<%#Eval("BusinessTripID") %>&amp;UserID=<%#Eval("UserID") %>&amp;islem=duzelis&amp;rownumber=<%#Container.ItemIndex %>'>
                                <asp:Label ID="Label4" runat="server" Text="Düzəliş"></asp:Label>
                                </a></td>
                            --%>  <%--                                       <asp:Panel  ID="Panel5" runat="server">
                                 <td style="padding-left:2px;width:3%;white-space: normal;border-right:dotted; border-right-style: dotted; border-right-width: thin;">   
                                         <a class="aucun" href='Ezamiyyenintesviri.aspx?BusinessTripID=<%#Eval("BusinessTripID") %>&islem=sil'>Sil</a>                            
                                 </td>
                                           </asp:Panel>--%><%--    <td style="padding-left:10px;text-align:left;width:17%;white-space: normal;"><a class="aucun" href='Yeniezamiyye.aspx?BusinessTripID=<%#Eval("BusinessTripID") %>&islem=rayontarix'>Rayonlar</a></td>
                                           --%>
                        </tr>
                    </table>
                </ItemTemplate>
                <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            </asp:DataList>
        </asp:Panel>
        <asp:Panel ID="pnlrayuzre2" Visible="false" runat="server">





            <div>&nbsp;</div>
            <div style="float: left; width: 347px; height: 22px;">
                Kurator:&nbsp;
                <asp:DropDownList ID="ddlusers3" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlusers3_SelectedIndexChanged">
                </asp:DropDownList>
            </div>


            <div style="float: left; width: 284px; white-space: normal;">
                <strong>Şəhərə və rayona gəlmə tarixi:&nbsp; </strong>
                <asp:ImageButton ID="ImageButton3" runat="server" Height="23px" ImageUrl="~/images/calendar-icon.png" OnClick="ImageButton3_Click1" Width="23px" />
            </div>
            <div style="float: left; width: 328px; white-space: normal;">
                <strong>Şəhərdən və rayondan getmə tarixi:&nbsp;
                        <asp:ImageButton ID="ImageButton4" runat="server" Height="23px" ImageUrl="~/images/calendar-icon.png" OnClick="ImageButton4_Click" Width="23px" />
                </strong>
            </div>



            <div style="float: left; width: 346px; padding-top: 10px; height: 173px;">
                Rayon:&nbsp;&nbsp;
                <asp:DropDownList ID="ddlryn3" runat="server">
                </asp:DropDownList>
                <br />
                <br />
                &nbsp;<asp:Button ID="planabax3" runat="server" OnClick="planabax3_Click" Text="Axtar" Width="120px" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="excele3" runat="server" OnClick="excele3_Click" Text="Wordə çıxart" Visible="False" Width="120px" />
                <asp:Label ID="lblgelme13" runat="server" Visible="False"></asp:Label>
                <asp:Label ID="lblgetme13" runat="server" Visible="False"></asp:Label>
                <br />
                <br />
                <asp:Label ID="lblmesage3" Font-Bold="True" runat="server" Text=""></asp:Label>
            </div>

            <%-- <div style="float:left;width:347px; height: 64px; padding-top:20px;">&nbsp;<asp:Button ID="planabax3"  runat="server" OnClick="planabax3_Click" Text="Plana bax" Width="120px" />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 <asp:Button ID="excele3" runat="server" OnClick="excele3_Click" Text="Wordə çıxart" Width="120px" Visible="False" />

                        <br />
                        <br />
                        <asp:Label ID="lblmesage3" runat="server"></asp:Label>
                    </div>--%>



            <div style="float: left; width: 284px; height: 202px;">
                <asp:Label ID="lblgelme3" runat="server"></asp:Label>

                <asp:ImageButton ID="imgbsilgelme3" runat="server" Height="14px" OnClick="imgbsilgelme3_Click" src="images/iconlar/sil.png" Visible="False" Width="14px" />
                <asp:Calendar ID="Calendar2" runat="server" BackColor="White" BorderColor="#999999" Visible="false"
                    CellSpacing="1" DayNameFormat="Shortest" Font-Names="Arial" Font-Size="9pt" ForeColor="Black"
                    Height="180px" OnSelectionChanged="Calendar2_SelectionChanged" Width="213px">
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
            <div style="float: left; width: 377px; height: 205px;">
                <asp:Label ID="lblgetme3" runat="server"></asp:Label>

                <asp:ImageButton ID="imgbsilgetme03" runat="server" Height="14px" OnClick="imgbsilgetme03_Click" src="images/iconlar/sil.png" Visible="False" Width="14px" />

                <asp:Calendar ID="Calendar4" runat="server" BackColor="White" BorderColor="#999999" Visible="false"
                    CellSpacing="1" DayNameFormat="Shortest" Font-Names="Arial" Font-Size="9pt" ForeColor="Black"
                    Height="180px" OnSelectionChanged="Calendar4_SelectionChanged" Width="213px">
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



            <asp:Panel ID="Panel1" Visible="false" runat="server">
                s
            </asp:Panel>


            <asp:DataList ID="dlrayontarix0" runat="server" ForeColor="#333333" Width="1024px">
                <AlternatingItemStyle BackColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderTemplate>
                    <table class="style1">
                        <tr>
                            <td style="padding-left: 2px; text-align: left; width: 3%; white-space: normal;">№</td>
                            <td style="padding-left: 10px; text-align: left; width: 19%; white-space: normal;">Kuratorun adı</td>
                            <td style="padding-left: 10px; text-align: left; width: 19%; white-space: normal;">Ezamiyyə dövrü üçün müəyyən edilmiş şəhər və rayonlar</td>
                            <td style="padding-left: 10px; text-align: left; width: 13%; white-space: normal;">Şəhərə, rayona gəlmə tarixi</td>
                            <td style="padding-left: 10px; text-align: left; width: 13%; white-space: normal;">Şəhərdən, rayondan getmə tarixi</td>
                            <td style="padding-left: 10px; text-align: left; width: 13%; white-space: normal;">Təsdiq olunma tarixi</td>
                            <td style=" text-align: center; width: 8%; white-space: normal;">Baxış</td>
                            <td style=" text-align: left; width: 13%; white-space: normal;">Tarixlərin yoxlanması</td>

                        </tr>
                    </table>
                </HeaderTemplate>
                <ItemStyle />
                <ItemTemplate>
                    <table style="border-bottom-style: dotted; border-bottom-width: thin; width: 100%; border-left-style: dotted; border-left-width: thin; border-right-style: dotted; border-right-width: thin;">
                        <tr>
                            <td style="padding-left: 2px; text-align: left; width: 3%; word-break: break-all; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><%#Container.ItemIndex+1 %></td>
                            <td style="padding-left: 10px; text-align: left; width: 19%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><%#Eval("nameuser") %></td>
                            <td style="padding-left: 10px; text-align: left; width: 19%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><%#Eval("Name") %></td>
                            <td style="padding-left: 10px; text-align: left; width: 13%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><%#Class2.sozukes(Eval("RegionCome").ToString()) %></td>
                            <td style="padding-left: 10px; text-align: left; width: 13%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><%#Class2.sozukes(Eval("GoFromRegion").ToString())%></td>
                            <td style="padding-left: 10px; text-align: left; width: 13%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><%#Class2.sozukes(Eval("DateApproval_ze").ToString())%></td>
                            <td style=" text-align: center; width: 8%; white-space: normal;border-right: dotted; border-right-style: dotted; border-right-width: thin;"><a class="aucun" href='../kurator/view_print_plan1.aspx?islem1=geri1&RayonID=<%#Eval("RegionID") %>&amp;UserID=<%#Eval("UserID") %>&amp;islem=bax&amp;RegionCode=<%#Eval("RegionCode") %>&amp;BusinessTripID=<%#Eval("BusinessTripID") %>'>Baxış</a></td>
                        <td style="text-align: left; width: 12%; white-space: normal; font-weight: bold; color: red;">
                            <%#Eval("busi") %>
                        </td>
                     
                             </tr>
                    </table>
                </ItemTemplate>
                <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            </asp:DataList>
        </asp:Panel>
    </asp:Panel>










    <asp:Panel ID="pnleztarixnezaret" Visible="false" runat="server">
        <table class="style1">
            <tr>
                <td class="auto-style169">&nbsp;</td>
                <td class="auto-style173" >
                    <asp:Button ID="btnicazever" runat="server" OnClick="btnicazever_Click" Text="İcazə vermək" Width="120px" />
                </td>
                <td class="auto-style171">
                    <asp:Button ID="btneztarixnez" runat="server" Text="Nəzarətdə olan" Width="120px" OnClick="btneztarixnez_Click" />
                </td>
                <td>
                    <asp:Button ID="btneztarixnezarxiv" runat="server" Text="Arxiv" Width="120px" OnClick="btneztarixnezarxiv_Click" />
                </td>
            </tr>
        </table>

        <asp:Panel ID="pnlicazever" Visible="false" runat="server">

            <table class="style1">
                <tr>
                    <td class="auto-style182">&nbsp;</td>
                    <td class="auto-style185">&nbsp;</td>
                    <td class="auto-style181">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style182">&nbsp;</td>
                    <td class="auto-style185">Kurator:</td>
                    <td class="auto-style181">
                        <asp:DropDownList ID="ddlicazever" runat="server">
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:Button ID="btnicazesaxla" runat="server" Text="İcazə ver" Width="120px" OnClick="btnicazesaxla_Click" />
                        &nbsp;&nbsp;&nbsp;
                        <asp:Label ID="lblicazever" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
            </table>
            <div>


                <table class="style1">
                    <tr>
                        <td class="auto-style186">&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style186">&nbsp;</td>
                        <td>
                            <asp:DataList ID="dlicaze" runat="server" BorderStyle="None" CellPadding="1" ForeColor="#333333" Width="374px">
                                <AlternatingItemStyle BackColor="White" />
                                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <HeaderTemplate>
                                    <table style="width:100%">
                                        <tr>
                                            <td style="width:70%">İcazə verilmiş kuratorlar</td>
                                               <td style="width:30%">İcazə vermə</td>
                                        </tr>
                                    </table>
                                </HeaderTemplate>
                                <ItemStyle BackColor="#EFF3FB" />
                                <ItemTemplate>
                                    <table style="width:100%;">
                                        <tr>
                                            <td style="width:70%"><%#Eval("Name") %></td>
                                               <td style="width:30%">
     <a class="aucun" href='Yeniezamiyye.aspx?islem=icazesil&UserID=<%#Eval("UserID") %>'>İcazə vermə</a>                                                 
                                                   
                                                  </td>
                                        </tr>

                                    </table>
                                </ItemTemplate>
                                <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                            </asp:DataList>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
                <br />


            </div>
        </asp:Panel>

        <asp:Panel ID="pnlrealtarixgetme" Visible="false" runat="server">
            <div style="float: left; width: 280px;">
                &nbsp; <strong>Rayona gəlmə tarixi:&nbsp; </strong>
                <asp:ImageButton ID="ImageButton1" runat="server" Height="23px" ImageUrl="~/images/calendar-icon.png" OnClick="ImageButton1_Click1" Width="23px" />

            </div>

            <div style="width: 679px; height: 30px;">

                <asp:Button ID="btnrayontrx" runat="server" OnClick="btnrayontrx_Click" Text="Yadda saxla" Width="120px" />
                &nbsp;&nbsp;
                      <asp:Label ID="lbltrxmesage" Font-Bold="True" runat="server"></asp:Label>

            </div>
            <div style="width: 280px; height: 240px;">
                &nbsp;
                <asp:Label ID="lblraygetme" runat="server"></asp:Label>


                <asp:Calendar ID="cldraygetmetrx" runat="server" BackColor="White" BorderColor="#999999" Visible="false"
                    CellSpacing="1" DayNameFormat="Shortest" Font-Names="Arial" Font-Size="9pt" ForeColor="Black"
                    Height="180px" OnSelectionChanged="cldraygelmetrx_SelectionChanged" Width="213px">
                    <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                    <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <SelectorStyle BackColor="#CCCCCC" />
                    <WeekendDayStyle BackColor="#FFFFCC" />
                    <OtherMonthDayStyle ForeColor="White" />
                    <NextPrevStyle VerticalAlign="Bottom" />
                    <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                    <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                </asp:Calendar>
                <asp:Label ID="lblraygetme0" runat="server" Visible="False"></asp:Label>
            </div>
        </asp:Panel>


        <asp:Panel ID="pnlrealtarixgelme" Visible="false" runat="server">
            <div style="float: left; width: 280px; height: 25px;">
                &nbsp; <strong>Rayondan getmə tarixi:&nbsp;
                    <asp:ImageButton ID="ImageButton2" runat="server" Height="23px" ImageUrl="~/images/calendar-icon.png" OnClick="ImageButton2_Click1" Width="23px" />
                </strong>

            </div>
            <div style="width: 569px; height: 25px;">
                      <asp:Button ID="btnrayondangetme" runat="server" OnClick="btnrayondangetme_Click" Text="Yadda saxla" Width="120px" />
                &nbsp;<asp:Label ID="lbltrxmesage1" Font-Bold="True" runat="server"></asp:Label>

            </div>
            <div style="float: left; width: 280px; height: 240px;">
                &nbsp;     
                 <asp:Label ID="lblraygelme" runat="server"></asp:Label>
                <asp:Calendar ID="cldraygelmetrx" runat="server" BackColor="White" BorderColor="#999999" Visible="false"
                    CellSpacing="1" DayNameFormat="Shortest" Font-Names="Arial" Font-Size="9pt" ForeColor="Black"
                    Height="180px" OnSelectionChanged="cldraygetmetrx_SelectionChanged" Width="213px">
                    <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                    <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <SelectorStyle BackColor="#CCCCCC" />
                    <WeekendDayStyle BackColor="#FFFFCC" />
                    <OtherMonthDayStyle ForeColor="White" />
                    <NextPrevStyle VerticalAlign="Bottom" />
                    <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                    <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                </asp:Calendar>
                <asp:Label ID="lblraygelme0" runat="server" Visible="False"></asp:Label>
            </div>
        </asp:Panel>


        <div class="temizle"></div>


        <asp:Panel ID="pnlsebeb" Visible="false" runat="server">


            <table class="style1">
                <tr>
                    <td class="auto-style163">&nbsp;</td>
                    <td class="auto-style165">&nbsp;</td>
                    <td class="auto-style167">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style163">&nbsp;</td>
                    <td class="auto-style165">Səbəb:</td>
                    <td class="auto-style167">
                        <asp:TextBox ID="txtsebeb" runat="server" TextMode="MultiLine" Width="300px">Rəhbərliyin tapşırığı</asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btnsebeb" runat="server" OnClick="btnsebeb_Click" Text="Yadda saxla" Width="120px" />
                        &nbsp;&nbsp;
                           <asp:Label ID="lblsebeb" Font-Bold="True" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style163">&nbsp;</td>
                    <td class="auto-style165">&nbsp;</td>
                    <td class="auto-style167">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>

            <%--   <td class="auto-style170">
                               </td>
                        <td class="auto-style154">
                            </td>
            --%>
        </asp:Panel>










        <asp:Label ID="lblsebeb1" Visible="False" runat="server" Text="Label" ForeColor="Red" Font-Bold="True"></asp:Label><br />

        <div class="temizle"></div>
        <asp:DataList ID="dleztarixnez" runat="server" ForeColor="#333333" OnItemDataBound="dleztarixnez_ItemDataBound" Width="1024px" Visible="False">
            <AlternatingItemStyle BackColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderTemplate>
                <table class="style1">
                    <tr>
                        <td style="padding-left: 2px; text-align: left; width: 3%; white-space: normal;">№</td>
                        <td style="padding-left: 2px; text-align: left; width: 13%; white-space: normal;">Kuratorun adı</td>
                        <td style="padding-left: 2px; text-align: left; width: 15%; white-space: normal;">Nəzərdə tutulmuş şəhər və rayonlar</td>
                        <td style="padding-left: 2px; text-align: left; width: 9%; white-space: normal;">Gəlmə tarixi</td>
                        <td style="padding-left: 2px; text-align: left; width: 9%; white-space: normal;">Faktiki olaraq gəlmə tarixi</td>

                        <td style="padding-left: 2px; text-align: left; width: 9%; white-space: normal;">Getmə tarixi</td>
                        <td style="padding-left: 2px; text-align: left; width: 9%; white-space: normal;">Faktiki olaraq getmə tarixi</td>
                        <td style="padding-left: 2px; text-align: left; width: 25%; white-space: normal;">Uyğunsuzluq səbəbi </td>
                        <td style="padding-left: 2px; text-align: left; width: 7%; white-space: normal;">Arxivə göndər</td>
                    </tr>
                </table>
            </HeaderTemplate>
            <ItemStyle />
            <ItemTemplate>
                <table style="border-bottom-style: dotted; border-bottom-width: thin; width: 100%; border-left-style: dotted; border-left-width: thin; border-right-style: dotted; border-right-width: thin;">
                    <tr>
                        <td style="padding-left: 2px; text-align: left; width: 3%; word-break: break-all; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><%#Container.ItemIndex+1 %></td>

                        <td style="padding-left: 2px; text-align: left; width: 13%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><%#Eval("nameuser") %></td>
                        <td style="padding-left: 2px; text-align: left; width: 15%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><%#Eval("Name") %></td>
                        <td style="padding-left: 2px; text-align: left; width: 9%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><%#Class2.sozukes(Eval("RegionCome").ToString()) %></td>
                        <td style="padding-left: 2px; text-align: left; width: 9%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><a class="aucun" href='Yeniezamiyye.aspx?RayonID=<%#Eval("RegionID") %>&RealTime=<%#Eval("DateRealRegionCome") %>&islem=realtimeregioncome&rownumber=<%#Container.ItemIndex %>'><%#tarix(Eval("DateRealRegionCome").ToString()) %></a></td>
                        <td style="padding-left: 2px; text-align: left; width: 9%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><%#Class2.sozukes(Eval("GoFromRegion").ToString()) %></td>
                        <td style="padding-left: 2px; text-align: left; width: 9%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><a class="aucun" href='Yeniezamiyye.aspx?RayonID=<%#Eval("RegionID") %>&RealTime=<%#Eval("DateRealRegionCome") %>&islem=realtimegofromregion&rownumber=<%#Container.ItemIndex %>'><%#tarix(Eval("DateRealGoFromRegion").ToString()) %></a> </td>
                        <td style="padding-left: 2px; text-align: left; width: 25%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><a class="aucun" href='Yeniezamiyye.aspx?RayonID=<%#Eval("RegionID") %>&Purpose=<%#Eval("Purpose") %>&islem=sebeb&rownumber=<%#Container.ItemIndex %>'><%#sebeb(Eval("Purpose").ToString()) %></a></td>
                        <td style="padding-left: 2px; text-align: left; width: 7%; white-space: normal;"><a class="aucun" href='Yeniezamiyye.aspx?RayonID=<%#Eval("RegionID") %>&Purpose=<%#Eval("Purpose") %>&islem=gonder'>Göndər</a></td>

                    </tr>
                </table>
            </ItemTemplate>
            <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        </asp:DataList>



        <asp:DataList ID="dlnezaretarxiv" runat="server" ForeColor="#333333" OnItemDataBound="dleztarixnez_ItemDataBound" Width="1024px" Visible="False">
            <AlternatingItemStyle BackColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderTemplate>
                <table class="style1">
                    <tr>
                        <td style="padding-left: 2px; text-align: left; width: 3%; white-space: normal;">№</td>
                        <td style="padding-left: 2px; text-align: left; width: 13%; white-space: normal;">Kuratorun adı</td>
                        <td style="padding-left: 2px; text-align: left; width: 15%; white-space: normal;">Nəzərdə tutulmuş şəhər və rayonlar</td>
                        <td style="padding-left: 2px; text-align: left; width: 9%; white-space: normal;">Gəlmə tarixi</td>
                        <td style="padding-left: 2px; text-align: left; width: 9%; white-space: normal;">Faktiki gəlmə tarixi</td>

                        <td style="padding-left: 2px; text-align: left; width: 9%; white-space: normal;">Getmə tarixi</td>
                        <td style="padding-left: 2px; text-align: left; width: 9%; white-space: normal;">Faktiki getmə tarixi</td>
                        <td style="padding-left: 2px; text-align: left; width: 20%; white-space: normal;">Uyğunsuzluq səbəbi </td>
                   <%--     <td style="padding-left: 2px; text-align: left; width: 10%; white-space: normal;">Nəzarətdə olana göndər</td>
                  --%>  </tr>
                </table>
            </HeaderTemplate>
            <ItemStyle />
            <ItemTemplate>
                <table style="border-bottom-style: dotted; border-bottom-width: thin; width: 100%; border-left-style: dotted; border-left-width: thin; border-right-style: dotted; border-right-width: thin;">
                    <tr>
                        <td style="padding-left: 2px; text-align: left; width: 3%; word-break: break-all; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><%#Container.ItemIndex+1 %></td>
                        <td style="padding-left: 2px; text-align: left; width: 13%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><%#Eval("nameuser") %></td>
                        <td style="padding-left: 2px; text-align: left; width: 15%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><%#Eval("Name") %></td>
                        <td style="padding-left: 2px; text-align: left; width: 9%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><%#Class2.sozukes(Eval("RegionCome").ToString()) %></td>
                        <td style="padding-left: 2px; text-align: left; width: 9%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><a class="aucun" href='Yeniezamiyye.aspx?RayonID=<%#Eval("RegionID") %>&RealTime=<%#Eval("DateRealRegionCome") %>&islem=realtimeregioncome1&rownumber=<%#Container.ItemIndex %>'><%#tarix(Eval("DateRealRegionCome").ToString()) %></a></td>

                        <td style="padding-left: 2px; text-align: left; width: 9%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><%#Class2.sozukes(Eval("GoFromRegion").ToString()) %></td>
                        <td style="padding-left: 2px; text-align: left; width: 9%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><a class="aucun" href='Yeniezamiyye.aspx?RayonID=<%#Eval("RegionID") %>&RealTime=<%#Eval("DateRealRegionCome") %>&islem=realtimegofromregion1&rownumber=<%#Container.ItemIndex %>'><%#tarix(Eval("DateRealGoFromRegion").ToString()) %></a> </td>
                        <td style="padding-left: 2px; text-align: left; width: 20%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><a class="aucun" href='Yeniezamiyye.aspx?RayonID=<%#Eval("RegionID") %>&Purpose=<%#Eval("Purpose") %>&islem=sebeb1&rownumber=<%#Container.ItemIndex %>'><%#sebeb(Eval("Purpose").ToString()) %></a></td>
                    <%--    <td style="padding-left: 2px; text-align: left; width: 10%; white-space: normal;"><a class="aucun" href='Yeniezamiyye.aspx?RayonID=<%#Eval("RegionID") %>&Purpose=<%#Eval("Purpose") %>&islem=gerigonder'>Göndər</a></td>--%>

                    </tr>
                </table>
            </ItemTemplate>
            <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        </asp:DataList>
    </asp:Panel>

    <asp:Panel ID="pnlgonderilmeyen" Visible="false" runat="server">

        <table style="width: 1012px">
            <tr>
                <td class="auto-style142">&nbsp;</td>
                <td class="auto-style161">
                    <asp:Button ID="btngonumumi" runat="server" Text="Ümumi" Width="120px" OnClick="btngonumumi_Click" />

                </td>
                <td class="auto-style141">
                    <asp:Button ID="btngonray" runat="server" Text="Rayonlar üzrə" Width="120px" OnClick="btngonray_Click" />
                </td>
                <td class="auto-style172">
                    <asp:Button ID="btnyenideniwle" runat="server" OnClick="btnyenideniwle_Click" Text="Yenidən işlənməsi təklif olunan" Width="220px" />
                </td>
                <td></td>
            </tr>
        </table>
        <asp:DataList ID="dlgonderumumi" runat="server" ForeColor="#333333" Width="1024px" Visible="False">
            <AlternatingItemStyle BackColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderTemplate>
                <table class="style1">
                    <tr>
                        <td style="padding-left: 2px; text-align: left; width: 3%; white-space: normal;">№</td>
                        <td style="padding-left: 10px; text-align: left; width: 12%; white-space: normal;">Kuratorun adı</td>
                        <td style="padding-left: 10px; text-align: left; width: 28%; white-space: normal;">Ezamiyyə dövrü üçün müəyyən edilmiş şəhər və rayonlar</td>
                        <td style="padding-left: 10px; text-align: left; width: 13%; white-space: normal;">Şəhərə, rayona gəlmə tarixi</td>
                        <td style="padding-left: 10px; text-align: left; width: 13%; white-space: normal;">Şəhərdən, rayondan getmə tarixi</td>
                        <%--    <td style="padding-left:10px;text-align:left;width:13%;white-space: normal;">Baxış</td>
                        --%>
                    </tr>
                </table>
            </HeaderTemplate>
            <ItemStyle />
            <ItemTemplate>
                <table style="border-bottom-style: dotted; border-bottom-width: thin; width: 100%; border-left-style: dotted; border-left-width: thin; border-right-style: dotted; border-right-width: thin;">
                    <tr>

                        <td style="padding-left: 2px; text-align: left; width: 3%; word-break: break-all; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><%#Container.ItemIndex+1 %></td>
                        <td style="padding-left: 10px; text-align: left; width: 12%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><%#Eval("nameuser") %></td>
                        <td style="padding-left: 10px; text-align: left; width: 30%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><%#Eval("Regions") %></td>
                        <td style="padding-left: 10px; text-align: left; width: 13%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><%#Class2.sozukes(Eval("RegionCome").ToString()) %></td>
                        <td style="padding-left: 10px; text-align: left; width: 13%; white-space: normal;"><%#Class2.sozukes(Eval("GoFromRegion").ToString())%></td>

                        <%--      <td style="padding-left:10px;text-align:left;width:13%; white-space: normal;"><a class="aucun" href='../kurator/view_print_plan1.aspx?islem1=geri14&RayonID=<%#Eval("RegionID") %>&amp;UserID=<%#Eval("UserID") %>&amp;islem=bax&amp;RegionCode=<%#Eval("RegionCode") %>&amp;BusinessTripID=<%#Eval("BusinessTripID") %>'>Baxış</a></td>
                        --%>
                    </tr>
                </table>
            </ItemTemplate>
            <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        </asp:DataList>

        <asp:DataList ID="dlteqdimolunmuw" runat="server" ForeColor="#333333" Width="1024px" Visible="False">
            <AlternatingItemStyle BackColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderTemplate>
                <table class="style1">
                    <tr>
                        <td style="padding-left: 2px; text-align: left; width: 3%; word-break: break-all; white-space: normal;">№</td>
                        <td style="padding-left: 10px; text-align: left; width: 19%; white-space: normal;">Kuratorun adı</td>
                        <td style="padding-left: 10px; text-align: left; width: 19%; white-space: normal;">Ezamiyyə dövrü üçün müəyyən edilmiş şəhər və rayonlar</td>
                        <td style="padding-left: 10px; text-align: left; width: 13%; white-space: normal;">Şəhərə, rayona gəlmə tarixi</td>
                        <td style="padding-left: 10px; text-align: left; width: 13%; white-space: normal;">Şəhərdən, rayondan getmə tarixi</td>
                        <td style="padding-left: 10px; text-align: left; width: 13%; white-space: normal;">Baxış</td>
                        <%--         <td style="padding-left:10px;text-align:left;width:13%;white-space: normal;">Təklif</td>
                    <td style="padding-left:10px;text-align:left;width:13%;white-space: normal;">Faylı sil</td>
                        --%>
                    </tr>
                </table>
            </HeaderTemplate>
            <ItemStyle />
            <ItemTemplate>
                <table style="border-bottom-style: dotted; border-bottom-width: thin; width: 100%; border-left-style: dotted; border-left-width: thin; border-right-style: dotted; border-right-width: thin;">
                    <tr>
                        <td style="padding-left: 2px; text-align: left; width: 3%; word-break: break-all; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><%#Container.ItemIndex+1 %></td>
                        <td style="padding-left: 10px; text-align: left; width: 19%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><%#Eval("nameuser") %></td>
                        <td style="padding-left: 10px; text-align: left; width: 19%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><%#Eval("Name") %></td>
                        <td style="padding-left: 10px; text-align: left; width: 13%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><%#Class2.sozukes(Eval("RegionCome").ToString()) %></td>
                        <td style="padding-left: 10px; text-align: left; width: 13%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><%#Class2.sozukes(Eval("GoFromRegion").ToString())%></td>

                        <td style="padding-left: 10px; text-align: left; width: 13%; white-space: normal;"><a class="aucun" href='../kurator/view_print_plan1.aspx?islem1=geri13&RayonID=<%#Eval("RegionID") %>&amp;UserID=<%#Eval("UserID") %>&amp;islem=bax&amp;RegionCode=<%#Eval("RegionCode") %>&amp;BusinessTripID=<%#Eval("BusinessTripID") %>'>Baxış</a></td>
                        <%--        <td style="padding-left:10px;text-align:left;width:13%;white-space: normal;border-right:dotted; border-right-style: dotted; border-right-width: thin;">
                        <asp:Panel ID="pnlyukle" Visible='<%#Convert.ToBoolean(yuklegorun(Eval("FileName").ToString()))%>'  runat="server">
                        <a class="aucun" href='Yeniezamiyye.aspx?RayonID=<%#Eval("RegionID") %>&islem=fayl&UserID=<%#Eval("UserID") %>&filename=<%#Eval("FileName") %>'>Yüklə</a>
                            </asp:Panel>
                            </td>
                  <td style="padding-left:10px;text-align:left;width:13%;white-space: normal;">
                        <asp:Panel ID="Panel9" Visible='<%#Convert.ToBoolean(yuklegorun(Eval("FileName").ToString()))%>'  runat="server">
                        <a class="aucun" href='Yeniezamiyye.aspx?RayonID=<%#Eval("RegionID") %>&islem=faylsil&UserID=<%#Eval("UserID") %>&filename=<%#Eval("FileName") %>'>Sil</a>
                            </asp:Panel>
                            </td>--%>
                    </tr>
                </table>
            </ItemTemplate>
            <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        </asp:DataList>
        <asp:DataList ID="dlyenideniwle" runat="server" ForeColor="#333333" Width="1024px" Visible="False">
            <AlternatingItemStyle BackColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderTemplate>
                <table class="style1">
                    <tr>
                        <td style="padding-left: 2px; text-align: left; width: 3%; word-break: break-all; white-space: normal;">№</td>
                        <td style="padding-left: 10px; text-align: left; width: 19%; white-space: normal;">Kuratorun adı</td>
                        <td style="padding-left: 10px; text-align: left; width: 19%; white-space: normal;">Ezamiyyə dövrü üçün müəyyən edilmiş şəhər və rayonlar</td>
                        <td style="padding-left: 10px; text-align: left; width: 13%; white-space: normal;">Şəhərə, rayona gəlmə tarixi</td>
                        <td style="padding-left: 10px; text-align: left; width: 13%; white-space: normal;">Şəhərdən, rayondan getmə tarixi</td>
                        <td style="padding-left: 10px; text-align: left; width: 13%; white-space: normal;">Baxış</td>
                        <td style="padding-left: 10px; text-align: left; width: 13%; white-space: normal;">Təklif</td>
                        <td style="padding-left: 10px; text-align: left; width: 13%; white-space: normal;">Faylı sil</td>

                    </tr>
                </table>
            </HeaderTemplate>
            <ItemStyle />
            <ItemTemplate>
                <table style="border-bottom-style: dotted; border-bottom-width: thin; width: 100%; border-left-style: dotted; border-left-width: thin; border-right-style: dotted; border-right-width: thin;">
                    <tr>
                        <td style="padding-left: 2px; text-align: left; width: 3%; word-break: break-all; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><%#Container.ItemIndex+1 %></td>
                        <td style="padding-left: 10px; text-align: left; width: 19%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><%#Eval("nameuser") %></td>
                        <td style="padding-left: 10px; text-align: left; width: 19%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><%#Eval("Name") %></td>
                        <td style="padding-left: 10px; text-align: left; width: 13%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><%#Class2.sozukes(Eval("RegionCome").ToString()) %></td>
                        <td style="padding-left: 10px; text-align: left; width: 13%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><%#Class2.sozukes(Eval("GoFromRegion").ToString())%></td>

                        <td style="padding-left: 10px; text-align: left; width: 13%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><a class="aucun" href='../kurator/view_print_plan1.aspx?islem1=geri15&RayonID=<%#Eval("RegionID") %>&amp;UserID=<%#Eval("UserID") %>&amp;islem=bax&amp;RegionCode=<%#Eval("RegionCode") %>&amp;BusinessTripID=<%#Eval("BusinessTripID") %>'>Baxış</a></td>
                        <td style="padding-left: 10px; text-align: left; width: 13%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;">
                            <asp:Panel ID="pnlyukle" Visible='<%#Convert.ToBoolean(yuklegorun(Eval("FileName").ToString()))%>' runat="server">
                                <a class="aucun" href='Yeniezamiyye.aspx?RayonID=<%#Eval("RegionID") %>&islem=fayl&UserID=<%#Eval("UserID") %>&filename=<%#Eval("FileName") %>'>Yüklə</a>
                            </asp:Panel>
                        </td>
                        <td style="padding-left: 10px; text-align: left; width: 13%; white-space: normal;">
                            <asp:Panel ID="Panel9" Visible='<%#Convert.ToBoolean(yuklegorun(Eval("FileName").ToString()))%>' runat="server">
                                <a class="aucun" href='Yeniezamiyye.aspx?RayonID=<%#Eval("RegionID") %>&islem=faylsil&UserID=<%#Eval("UserID") %>&filename=<%#Eval("FileName") %>'>Sil</a>
                            </asp:Panel>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
            <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        </asp:DataList>
    </asp:Panel>
</asp:Content>

