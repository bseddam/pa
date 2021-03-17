<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Default2"
    Culture="az-Latn-AZ" UICulture="az-Latn-AZ" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Azərbaycan Respublikası regionlarının sosial-iqtisadi inkişafı analitik-informasiya
        sistemi</title>
    <style type="text/css">
        a, a:visited
        {
            color: #3f6da9;
            font-weight: bold;
            text-decoration: none;
        }
        a:hover
        {
            color: #7fade9;
            text-decoration: underline;
        }
        .lbut
        {
            background: #ffffff;
            border-bottom: #DECFA6 1px solid;
            border-left: #DECFA6 1px solid;
            border-right: #DECFA6 1px solid;
            border-top: #DECFA6 1px solid;
            color: #333333;
            cursor: hand;
            font: 11px Arial;
            font-weight: bold;
        }
    </style>
</head>
<body style="background-color: #DDDDDD">
    <form id="form1" runat="server">
    <div style="text-align: center; width: 1024px;">
        <div style="font-family: Arial; color: #000080; font-size: 17pt; font-weight: bold;">
            Azərbaycan Respublikası Regionlarının Sosial-İqtisadi İnkişafı Analitik-İnformasiya
            Sistemi
        </div>
        <table cellpadding="0" cellspacing="0" width="1024px">
            <tr>
                <!--<td style="width:628px;" valign="top"><img src="Images/head01.gif" width="628" height="137" alt="" /></td>-->
                <!-- 828 -->
                <td style="padding-right: 15px;" valign="top">
                    <br />
                    <img src="Images/lefthead.GIF" height="98" alt="" />
                </td>
                <td valign="top" width="580px">
                    <br />
                    <object classid="clsid:d27cdb6e-ae6d-11cf-96b8-444553540000" codebase="http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=7,0,0,0"
                        id="kemper2" width="580" height="98">
                        <param name="movie" value="Images/Flash3.swf" />
                        <param name="quality" value="high" />
                        <param name="bgcolor" value="#DDDDDD" />
                        <embed src="Images/Flash3.swf" quality="high" bgcolor="#000000" width="580" height="98"
                            id="kemper1" name="kemper1" align="middle" type="application/x-shockwave-flash"
                            pluginspage="http://www.macromedia.com/go/getflashplayer">
                    </object>
                </td>
                <td style="width: 150px; padding-left: 15px; padding-top: 20px;" valign="top">
                    <img src="Images/headflag.gif" width="132" height="90" alt="" />
                </td>
            </tr>
            <tr>
                <td valign="top" colspan="3" height="100" style="padding-top: 15px;">
                    <!--<div style="font-family:Arial; font-size:13pt; text-align:center; color:#303030; font-weight:bold;">Azərbaycan Respublikası regionlarının sosial-iqtisadi inkişafı analitik-informasiya sistemi</div><br />
                    <div style="font-family:Arial; font-size:9pt; text-align:left; padding-left: 372px; color:#303030; background-color:#B8B8B8; font-weight:bold;">Hadisələr</div>-->
                    <marquee onmouseover='this.stop();' onmouseout='this.start();' direction="left" scrollamount="15"
                        bgcolor="#1f4da9" width="100%" style="padding: 15px; height: 100;">
                        <div id="divscrollingtext" style="font-family: Arial; font-size:15pt; color:#FFFFFF; font-weight:bold;">
                            <asp:Label id="scrollingtext" runat="server">
                            </asp:Label>                        
                        </div>
                    </marquee>
                </td>
            </tr>
            <tr>
                <td colspan="3" style="padding-top: 15px; height: 409px;">
                    <table cellpadding="0" cellspacing="0" border="0" style="width: 100%">
                        <tr>
                            <td style="width: 1%; text-align: left; vertical-align: top; background-color: #DDDDDD;">
                                <!--<td style="width: 1%;text-align:left; vertical-align:top; padding-right: 10px;">-->
                                <div style="font-family: Arial; font-size: 9pt; text-align: left; color: #303030;
                                    background-color: #B8B8B8; font-weight: bold;">
                                </div>
                                <!--<br />-->
                                <!--<a style="font-family:'Arial';font-size:10pt; color:Red;font-weight:bold;" href="Belediyye/Sechki2009/Default.aspx">Bələdiyyə - 2009</a><br /><br />-->
                                <!--BackColor="#E3EAEB" ForeColor="SteelBlue"-->
                                <div style="border: solid 1px #808080;">
                                    <div style="font-family: Arial; font-size: 9pt; text-align: center; color: #303030;
                                        background-color: #B8B8B8; font-weight: bold;Şöbənin iş üslubu</div>
                                    <br />
                                    <asp:Menu ID="Menu1" runat="server" DynamicHorizontalOffset="2" Font-Names="Arial"
                                        Font-Size="8pt" StaticSubMenuIndent="0px" OnMenuItemClick="Menu1_MenuItemClick">
                                        <Items>
                                            <asp:MenuItem Text="Nəzarət" Value="Nəzarət ">
                                                <asp:MenuItem Text="İş planı" Value="Kadr">
                                                <asp:MenuItem NavigateUrl="~/Ish_plani/2016_1.doc" Text="I yarım il" Value="Kadr">
                                                </asp:MenuItem>
                                                 </asp:MenuItem>
                                                <asp:MenuItem NavigateUrl="~/Meeting/Login.aspx" Text="Şöbə müdiri tərəfindən veilən tapşırıqlar"
                                                    Value="Kadr"></asp:MenuItem>
                                                <asp:MenuItem NavigateUrl="~/ImageGallery2/Default.aspx" Text="Təbliğat vasitələri"
                                                    Value="Kadr"></asp:MenuItem>
                                                <asp:MenuItem NavigateUrl="~/Kadr/EzamMezun.aspx" Text="Məzuniyyət və ezamiyyələr"
                                                    Value="Kadr"></asp:MenuItem>
                                                <asp:MenuItem NavigateUrl="~/Dqulluqchusu/Default.aspx" Text="Dövlət qulluqçuları haqqında məlumat"
                                                    Value="Kadr"></asp:MenuItem>
                                                <asp:MenuItem NavigateUrl="~/Kadr2013/Default.aspx" Text="Vakansiyalar" Value="Kadr">
                                                </asp:MenuItem>
                                                <asp:MenuItem NavigateUrl="~/shobe/IhbSeyyarQebullar.aspx" Text="Səyyar qəbulların qrafiki"
                                                    Value="Kadr"></asp:MenuItem>
                                            </asp:MenuItem>
                                            <asp:MenuItem NavigateUrl="~/Belediyye/Default.aspx" Text="Bələdiyyələr" Value="Bel">
                                            </asp:MenuItem>
                                            <asp:MenuItem Text="X&#252;susi hesabatlar" Value="Itm1">
                                                <asp:MenuItem Text="Sosial-iqtisadi inkişafa dair Dövlət proqramları"
                                                    Value="Itm2">
                                                    <asp:MenuItem NavigateUrl="~/GosProg.aspx" Text="Regionların sosial-iqtisadi inkişafına dair Dövlət proqramı (2004-2008-ci illər)"
                                                        Value="2004-2008-ci illər &#252;zrə D&#246;vlət proqramı"></asp:MenuItem>
                                                    <asp:MenuItem NavigateUrl="~/GosProg2009.aspx" Text="Regionların sosial-iqtisadi inkişafına dair Dövlət proqramı (2009-2013-cü illər)"
                                                        Value="2009-2013-c&#252; illər &#252;zrə D&#246;vlət proqramı"></asp:MenuItem>
                                                    <asp:MenuItem NavigateUrl="~/GosProg2014R.aspx" Text="Regionların sosial-iqtisadi inkişafına dair Dövlət proqramı (2014-2018-ci illər)"
                                                        Value="2014-2018-ci illər &#252;zrə D&#246;vlət proqramı"></asp:MenuItem>
                                                <asp:MenuItem NavigateUrl="~/GosProg2011.aspx" Text="2011-2013-cü illərdə Bakı şəhərinin və onun qəsəbələrinin sosial-iqtisadi inkişafına dair Dövlət Proqramı"
                                                    Value="2011-2013-cü illər üzrə Dövlət Proqramı"></asp:MenuItem>
                                                <asp:MenuItem NavigateUrl="~/GosProg2014B.aspx" Text="2014-2016-cı illərdə Bakı şəhərinin və onun qəsəbələrinin sosial-iqtisadi inkişafına dair Dövlət Proqramı"
                                                    Value="2014-2016-cü illər üzrə Dövlət Proqramı"></asp:MenuItem>
                                                </asp:MenuItem>
                                                <asp:MenuItem NavigateUrl="~/SocioEconomProb.aspx" Text="Sosial-iqtisadi problemlər"
                                                    Value="Itm3"></asp:MenuItem>
                                                <asp:MenuItem NavigateUrl="~/Expenses.aspx" Text="Ayrılmış vəsaitin xərclənmə vəziyyəti"
                                                    Value="Itm4"></asp:MenuItem>
                                                <asp:MenuItem Text="İH Başçılarının səyyar qəbulları"
                                                    Value="Itm2">
                                                <asp:MenuItem NavigateUrl="~/HEMeeting.aspx" Text="İH Baş&#231;ısının qəbulları"
                                                    Value="Itm5"></asp:MenuItem>
                                                <asp:MenuItem NavigateUrl="~/HEmeetingAyliqHesabat.aspx" Text="Aylıq hesabatlar"
                                                    Value="Itm5"></asp:MenuItem>
                                                </asp:MenuItem>
                                                <asp:MenuItem NavigateUrl="~/EventsMeeting.aspx" Text="Salnamə" Value="Itm4"></asp:MenuItem>
                                                <asp:MenuItem NavigateUrl="~/PropagandMeeting.aspx" Text="Təbliğat qruplarının keçirdikləri görüşlər">
                                                </asp:MenuItem>
                                                <asp:MenuItem NavigateUrl="~/GroundUsing.aspx" Text="Torpaqlardan istifadə vəziyyəti"
                                                    Value="Bələdiyyələr &#252;zrə torpaqlardan istifadəyə dair məlumat"></asp:MenuItem>
                                                <asp:MenuItem Text="B&#252;dcə vəsaitlərindən istifadə" Value="B&#252;dcə vəsaitlərindən istifadə">
                                                    <asp:MenuItem Text="B&#252;dcə g&#246;stəricilərinə dair məlumat" Value="B&#252;dcə g&#246;stəricilərinə dair məlumat"
                                                        NavigateUrl="~/MFBudgetIndex.aspx"></asp:MenuItem>
                                                    <asp:MenuItem Text="D&#246;vlət b&#252;dcəsinin Ehtiyat Fondundan ayrılmış vəsait barədə məlumat"
                                                        Value="D&#246;vlət b&#252;dcəsinin Ehtiyat Fondundan ayrılmış vəsait barədə məlumat"
                                                        NavigateUrl="~/MFBudgetReserve.aspx"></asp:MenuItem>
                                                    <asp:MenuItem Text="D&#246;vlət b&#252;dcəsində nəzərdə tutulmuş Azərbaycan Respublikası Prezidentinin Ehtiyat Fondundan ayrılmış vəsait barədə məlumat "
                                                        Value="D&#246;vlət b&#252;dcəsində nəzərdə tutulmuş Azərbaycan Respublikası Prezidentinin Ehtiyat Fondundan ayrılmış vəsait barədə məlumat "
                                                        NavigateUrl="~/MFPresidentReserve.aspx"></asp:MenuItem>
                                                    <asp:MenuItem Text="D&#246;vlət b&#252;dcəsində d&#246;vlət əsaslı vəsait qoyuluşu &#252;&#231;&#252;n nəzərdə tutulmuş vəsaitdən ayrılmıış vəsait barədə məlumat"
                                                        Value="D&#246;vlət b&#252;dcəsində d&#246;vlət əsaslı vəsait qoyuluşu &#252;&#231;&#252;n nəzərdə tutulmuş vəsaitdən ayrılmıış vəsait barədə məlumat"
                                                        NavigateUrl="~/MFStateAssets.aspx"></asp:MenuItem>
                                                    <asp:MenuItem Text="Digər mənbələrdən ayrılmış vəsait barədə məlumat" Value="Digər mənbələrdən ayrılmış vəsait barədə məlumat"
                                                        NavigateUrl="~/MFOtherSourcesAssets.aspx"></asp:MenuItem>
                                                    <asp:MenuItem Text="D&#246;vlət b&#252;dcəsinin mərkəzləşdirilmiş xərclərindən əlavə ayrılmış vəsait barədə məlumat "
                                                        Value="D&#246;vlət b&#252;dcəsinin mərkəzləşdirilmiş xərclərindən əlavə ayrılmış vəsait barədə məlumat "
                                                        NavigateUrl="~/MFCentralizedCharge.aspx"></asp:MenuItem>
                                                </asp:MenuItem>
                                                <asp:MenuItem Text="Məscidlər" Value="Məscidlər">
                                                    <asp:MenuItem Text="Arayış" Value="Arayış" NavigateUrl="~/Mescid/Arayish.doc"></asp:MenuItem>
                                                    <asp:MenuItem Text="Statistik göstəricilər" Value="Statistik göstəricilər" NavigateUrl="~/Mescid/MescidStatistika.doc">
                                                    </asp:MenuItem>
                                                    <asp:MenuItem Text="Məscidlər haqqında ümumi məlumat" Value="Məscidlər haqqında ümumi məlumat"
                                                        NavigateUrl="~/Mescid/MescidUmumi.doc"></asp:MenuItem>
                                                    <asp:MenuItem Text="Əsas məscidlər haqqında məlumat" Value="Əsas məscidlər haqqında ümumi məlumat"
                                                        NavigateUrl="~/Mescid/MescidEsas.doc"></asp:MenuItem>
                                                </asp:MenuItem>
                                                   <asp:MenuItem  Text="Ezamiyyə"
                                                    Value="Ezamiyyə"></asp:MenuItem>
                                                    
                                                               <asp:MenuItem NavigateUrl="atr_ordenler.pdf" Text="Orden və medallar"
                                                Value="Orden və medallar"></asp:MenuItem>
                                                <asp:MenuItem NavigateUrl="~/yol.html" Text="Magistral yollar" Value="Trass"></asp:MenuItem>
                                            </asp:MenuItem>
                                            
                                            <asp:MenuItem NavigateUrl="~/Reports.aspx" Text="Təhlil və proqnoz " Value="Təhlil və proqnoz ">
                                            </asp:MenuItem>
                                            <asp:MenuItem NavigateUrl="http://192.168.150.2:7070/azemap" Text="Coğrafi təhlil"
                                                Value="Coğrafi təhlil"></asp:MenuItem>
									    <asp:MenuItem NavigateUrl="" Text="Referendum" Value="Bel">
                                           <asp:MenuItem NavigateUrl="~/SechkiRef2016/Sechki2016.aspx" Text="Referendum 2016" Value="2016">
                                            </asp:MenuItem>
                                            <asp:MenuItem NavigateUrl="~/DefaultRef.aspx" Text="Referendum 2009" Value="2009">
                                            </asp:MenuItem>
                                            </asp:MenuItem>
									    </Items>
                                        <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                                        <DynamicHoverStyle BackColor="SteelBlue" ForeColor="White" />
                                        <DynamicMenuStyle BackColor="#E3EAEB" BorderColor="Transparent" />
                                        <DynamicItemTemplate>
                                            <%# Eval("Text") %>
                                        </DynamicItemTemplate>
                                        <StaticSelectedStyle BackColor="#1C5E55" />
                                        <DynamicSelectedStyle BackColor="#1C5E55" />
                                        <DynamicMenuItemStyle BorderColor="DarkGray" BorderStyle="Solid" BorderWidth="0px"
                                            HorizontalPadding="5px" VerticalPadding="2px" />
                                        <StaticHoverStyle BackColor="Transparent" ForeColor="White" />
                                    </asp:Menu>
                                    <br />
                                </div>
                                <!-- #E3EAEB -->
                                <br />
                                <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#999999"
                                    CellSpacing="1" DayNameFormat="Shortest" Font-Names="Arial" Font-Size="9pt" ForeColor="Black"
                                    Height="180px" OnSelectionChanged="Calendar1_SelectionChanged">
                                    <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                                    <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                                    <SelectorStyle BackColor="#CCCCCC" />
                                    <WeekendDayStyle BackColor="#FFFFCC" />
                                    <OtherMonthDayStyle ForeColor="White" />
                                    <NextPrevStyle VerticalAlign="Bottom" />
                                    <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                                    <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                                </asp:Calendar>
                                <br />
                                <div style="text-align: center;">
                                    <asp:Button ID="buttonToday" runat="server" Text="Bu gün" CssClass="lbut" OnClick="buttonToday_Click" />
                                </div>
                            </td>
                            <td style="padding-left: 10px; width: 85%; vertical-align: top; padding-right: 10px;">
                                <div style="font-family: Arial; font-size: 9pt; text-align: center; color: #303030;
                                    background-color: #B8B8B8; font-weight: bold;">
                                    Tədbirlər</div>
                                <br />
                                <div>
                                    <asp:Literal runat="server" ID="ltInfo" />
                                </div>
                                <div id="divnewstext" style="font-family: Arial; font-size: 9pt; text-align: left;
                                    color: #333333;">
                                    <div style="height: 300px; overflow: auto; scrollbar-base-color: #B8B8B8;">
                                        <asp:Label ID="newstext" runat="server"></asp:Label>
                                    </div>
                                    <br />
                                    <br />
                                </div>
                                <%-- <table>
                                    <tr>
                                        <td style="padding-left: 10px; width: 50%; vertical-align: top; padding-right: 10px;">
                                            <div style="font-family: Arial; font-size: 9pt; text-align: center; color: #303030;
                                                background-color: #B8B8B8; font-weight: bold;">
                                                Prezident seçkiləri ilə bağlı keçirilən tədbirlər</div>
                                        </td>
                                        <td style="padding-left: 10px; width: 50%; vertical-align: top; padding-right: 10px;">
                                            <div style="font-family: Arial; font-size: 9pt; text-align: center; color: #303030;
                                                background-color: #B8B8B8; font-weight: bold;">
                                                Gündəlik tədbirlər</div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div id="divSechkinewstext" style="font-family: Arial; font-size: 9pt; text-align: left;
                                                color: #333333;">
                                                <div style="height: 300px; overflow: auto; scrollbar-base-color: #B8B8B8;">
                                                    <asp:Label ID="Sechkinewstext" runat="server"></asp:Label>
                                                </div>
                                                <br />
                                                <br />
                                            </div>
                                        </td>
                                        <td>
                                            <div id="divnewstext" style="font-family: Arial; font-size: 9pt; text-align: left;
                                                color: #333333;">
                                                <div style="height: 300px; overflow: auto; scrollbar-base-color: #B8B8B8;">
                                                    <asp:Label ID="newstext" runat="server"></asp:Label>
                                                </div>
                                                <br />
                                                <br />
                                            </div>
                                        </td>
                                    </tr>
                                </table>--%>
                                <%--  <div id="divnewstext" style="font-family: Arial; font-size: 9pt; text-align: left;color: #333333; width:50%">
                                    <div style="height: 300px;  scrollbar-base-color: #B8B8B8;">
                                        <!--<marquee OnMouseOver='this.stop();' OnMouseOut='this.start();' direction="up" scrollamount="1"> -->
                                        <asp:label id="newstext" runat="server"></asp:label>
                                            <!--</marquee>-->
                                    </div>
                                    <br />
                                    <br />
                                </div>
                                <div id="divSechkinewstext" style="font-family: Arial; font-size: 9pt; text-align: left;color: #333333; width:50%">
                                    <div style="height: 300px; overflow: auto; scrollbar-base-color: #B8B8B8;">
                                        <asp:label id="Sechkinewstext" runat="server"></asp:label>
                                    </div>
                                    <br />
                                    <br />
                                </div>--%>
                            </td>
                            <td style="width: 15%; border: solid 1px #808080; vertical-align: top; background-color: #E8E8E8;">
                                <div style="font-family: Arial; font-size: 9pt; text-align: center; color: #303030;
                                    background-color: #B8B8B8; font-weight: bold;">
                                    Şəhər və rayonlar</div>
                                <br />
                                <div id="divregionlinks" style="font-family: Arial; font-size: 9pt; text-align: left;
                                    color: #808080; padding: 5px;">
                                    <div style="height: 300px; overflow: auto; scrollbar-base-color: #B8B8B8;">
                                        <!--<a href='  Respublika/Azerbaijan.doc'>  Azərbaycan</a>-->
                                        <asp:TreeView ID="treeregions" runat="server" ShowLines="true">
                                        </asp:TreeView>
                                        <asp:Label ID="regionlinks" runat="server">
                                        </asp:Label>
                                    </div>
                                </div>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <!-- Placeholder for Archive
   
            <tr><td>
            <a style="font-size:12pt; text-align:left; " href="Arxiv.aspx">Arxiv</a>
            </td></tr>
-->
            <!-- moved out   
            <tr>
                <td colspan="3" style="padding-top:20px; height: 39px;">                 
                    <div style="font-family:Arial; font-size:9pt; text-align:center; ">
                       <asp:LinkButton ID="LinkEnter" Text="Təhlil və proqnoz" runat="server" PostBackUrl="Reports.aspx"></asp:LinkButton>
                       <asp:Menu runat="server" ID="menu" Orientation="Horizontal" BackColor="#E3EAEB" BorderColor="Gray" BorderStyle="Solid" BorderWidth="1px" DynamicHorizontalOffset="2" Font-Names="Arial" Font-Size="8pt" ForeColor="#666666" StaticSubMenuIndent="10px">
                           <Items>
                               <asp:MenuItem NavigateUrl="~/Reports.aspx" Text="Təhlil və proqnoz " Value="Təhlil və proqnoz ">
                               </asp:MenuItem>
                               <asp:MenuItem Text="X&#252;susi hesabatlar" Value="Itm1">
                                   <asp:MenuItem Text="D&#246;vlət proqramının icra vəziyyəti" Value="Itm2" NavigateUrl="~/GosProg.aspx"></asp:MenuItem>
                                   <asp:MenuItem NavigateUrl="~/SocioEconomProb.aspx" Text="Sosial-iqtisadi problemlər"
                                       Value="Itm3"></asp:MenuItem>
                                   <asp:MenuItem NavigateUrl="~/Expenses.aspx" Text="Ayrılmış vəsaitin xərclənmə vəziyyəti"
                                       Value="Itm4"></asp:MenuItem>
                                   <asp:MenuItem NavigateUrl="~/HEMeeting.aspx" Text="İH Baş&#231;ısının qəbulları"
                                       Value="Itm5"></asp:MenuItem>
                                   <asp:MenuItem NavigateUrl="~/EventsMeeting.aspx" Text="Salnamə" Value="Itm4"></asp:MenuItem>
                               </asp:MenuItem>
                           </Items>
                           <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                           <DynamicHoverStyle BackColor="Transparent" ForeColor="White" />
                           <DynamicMenuStyle BackColor="#E3EAEB" BorderColor="Transparent" />
                           <DynamicItemTemplate>
                               <%# Eval("Text") %>
                           </DynamicItemTemplate>
                           <StaticSelectedStyle BackColor="#1C5E55" />
                           <DynamicSelectedStyle BackColor="#1C5E55" />
                           <DynamicMenuItemStyle BorderColor="DarkGray" BorderStyle="Solid" BorderWidth="1px"
                               HorizontalPadding="5px" VerticalPadding="2px" />
                           <StaticHoverStyle BackColor="Transparent" ForeColor="White" />
                       </asp:Menu>
                    </div>
                </td>            
            </tr>
           -->
        </table>
    </div>
    </form>
</body>
</html>
