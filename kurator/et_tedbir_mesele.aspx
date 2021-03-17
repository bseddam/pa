<%@ Page Title="" Language="C#" MasterPageFile="~/kurator/KuratorhisseMasterPage.master" AutoEventWireup="true" CodeFile="et_tedbir_mesele.aspx.cs" Inherits="kurator_et_tedbir_mesele" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style>
        csrowbam
        {
            width:350px;
        }
        .auto-style1
        {
            width: 100%;
        }
        .auto-style4
        {
            width: 220px;
            height: 38px;
        }
        .auto-style5
        {
            width: 533px;
            height: 38px;
        }
        .auto-style6
        {
            height: 38px;
        }
        .auto-style16
        {
            width: 220px;
            height: 65px;
        }
        .auto-style17
        {
            width: 533px;
            height: 65px;
        }
        .auto-style18
        {
            height: 65px;
        }
        .auto-style19
        {
            width: 220px;
            height: 62px;
        }
        .auto-style20
        {
            width: 533px;
            height: 62px;
        }
        .auto-style21
        {
            height: 62px;
        }
        #TextArea1
        {
            height: 45px;
            width: 574px;
        }
        #TextArea2
        {
            height: 46px;
            width: 574px;
        }
        .auto-style22
        {
            width: 220px;
            height: 44px;
        }
        .auto-style23
        {
            width: 533px;
            height: 44px;
        }
        .auto-style24
        {
            height: 44px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

            <div>
        <table style=" width: 100%;">
            <tr>
                <td style=" width: 880px;">&nbsp;</td>
                <td>
                    <asp:Button ID="btngeri" runat="server" Text="Geri" Width="120px" OnClick="btngeri_Click" />
                </td>
            </tr>
        </table>
    </div>



        <div style="margin-left:auto; margin-right:auto; width: 1024px">
            <table class="auto-style1"  style="background-color:white;">
                <tr >
                    <td class="auto-style4">İştirakı nəzərdə tutulmuş tədbir</td>
                    <td class="auto-style5"> 
                        <asp:DropDownList ID="ddltedbir" runat="server" AutoPostBack="True" CausesValidation="True" Height="30px" Width="692px">
                        </asp:DropDownList>
                        <asp:TextBox ID="txtiwttedbir" runat="server" Font-Names="Arial" Height="26px" MaxLength="1000" TextMode="SingleLine" Width="688px"></asp:TextBox>
                    </td>
                   
                    <td class="auto-style6"><asp:CheckBox ID="CheckBox1" Visible="false" runat="server" AutoPostBack="True" Text="Digər" OnCheckedChanged="CheckBox1_CheckedChanged" /></td>
                </tr>
                <tr>
                    <td class="auto-style22">Müzakirə olunacaq məsələ</td>
                    <td class="auto-style23"> 
                        <asp:DropDownList ID="ddlmuzmesele" runat="server" AutoPostBack="True" CausesValidation="True" Height="30px" Width="692px">
                        </asp:DropDownList>
                        <asp:TextBox ID="txtmuzmes" runat="server" Font-Names="Arial" Height="26px" MaxLength="1000" TextMode="SingleLine" Width="688px"></asp:TextBox>
                    </td>
                    <td class="auto-style24"><asp:CheckBox ID="CheckBox2" Visible="false" runat="server" AutoPostBack="True" Text="Digər" OnCheckedChanged="CheckBox2_CheckedChanged" /></td>
                </tr>
                <asp:Panel ID="pnlgozlenilennetice" Visible="false" runat="server">
                <tr>
                    <td class="auto-style16">Gözlənilən nəticə</td>
                    <td class="auto-style17">
                        <asp:TextBox ID="txtgoznetice" runat="server" Font-Names="Arial" Height="47px" MaxLength="1000" TextMode="MultiLine" Width="688px"></asp:TextBox>
                    </td>
                    <td class="auto-style18"></td>
                </tr>
                    </asp:Panel>
                <tr>
                    <td class="auto-style19">
                        &nbsp;</td>
                    <td class="auto-style20"><asp:Button ID="Button1" runat="server" Text="Yadda saxla" OnClick="Button1_Click" />
                    </td>
                    <td class="auto-style21"></td>
                </tr>
            </table>
           
                    <div>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lblmsg" runat="server"></asp:Label>
                        <br />
                </div>
         

            <asp:DataList ID="GridView1" runat="server" ForeColor="#333333"  Width="1024px">
            <AlternatingItemStyle BackColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderTemplate>
                <table style="width:100%;">
                    <tr>
 <td style="padding-left:3px;text-align:left;width:20%;white-space: normal;">İştirakı nəzərdə tutulmuş tədbir</td>
 <td style="padding-left:3px;text-align:left;width:25%;white-space: normal;">Müzakirə olunacaq məsələ</td>
<%-- <td style="padding-left:3px;text-align:left;width:25%;white-space: normal;"> Gözlənilən nəticə</td>--%>
                        <td style="padding-left:3px;text-align:left;width:10%;white-space: normal;">Düzəliş</td>
 <td style="padding-left:3px;text-align:left;width:5%;white-space: normal; ">Sil</td>                     
                    </tr>
                </table>
            </HeaderTemplate>
            <ItemStyle />
            <ItemTemplate>
                <table style="border-bottom-style: dotted; border-bottom-width: thin;width:100%; border-left-style: dotted; border-left-width: thin; border-right-style: dotted; border-right-width: thin;">
                    <tr>
                   <td style="padding-left:3px;text-align:left;width:20%;white-space: normal;border-right:dotted; border-right-style: dotted; border-right-width: thin;"><%#Eval("Actions") %></td>
                   <td style="padding-left:3px;text-align:left;width:25%;white-space: normal;border-right:dotted; border-right-style: dotted; border-right-width: thin;"><%#Eval("Issues") %></td>
                   <%--<td style="padding-left:3px;text-align:left;width:25%;white-space: normal;border-right:dotted; border-right-style: dotted; border-right-width: thin;"><%#Eval("results")%></td>--%>
                <td style="padding-left:3px;text-align:left;width:10%;white-space: normal;border-right:dotted; border-right-style: dotted; border-right-width: thin;"><a href='et_tedbir_mesele.aspx?ConnID=<%#Eval("ConnID") %>&islem=duzelis'>Düzəliş</a>
  </td>
                  <td style="padding-left:3px;text-align:left;width:5%;word-break: break-all;white-space: normal; "><a class="aucun" href='et_tedbir_mesele.aspx?islem=sil&ConnID=<%#Eval("ConnID") %>'>Sil</a></td>
                
                                      </tr>
                </table>
            </ItemTemplate>
            <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        </asp:DataList>

      
        </div>
</asp:Content>

