<%@ Page Title="" Language="C#" MasterPageFile="~/kurator/KuratorhisseMasterPage.master" AutoEventWireup="true" CodeFile="et_ihb_numayendelik.aspx.cs" Inherits="kurator_et_ihb_numayendelik" %>


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
             width: 250px;
             height: 38px;
         }
        .auto-style5
        {
             width: 538px;
             height: 38px;
         }
        .auto-style6
        {
            height: 38px;
        }
        .auto-style19
        {
             width: 250px;
             height: 62px;
         }
        .auto-style20
        {
             width: 538px;
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
        .auto-style25
        {
            width: 250px;
            height: 48px;
        }
        .auto-style26
        {
            width: 538px;
            height: 48px;
        }
        .auto-style27
        {
            height: 48px;
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
            <table class="auto-style1">
                <tr >
                    <td class="auto-style4">Olacağı İHB nümayəndəlikləri</td>
                    <td class="auto-style5"> 
                        <asp:DropDownList ID="ComboBox1" runat="server" AutoPostBack="True" CausesValidation="True" Height="30px" Width="673px">
                        </asp:DropDownList>
                        <asp:TextBox ID="TextBox3" runat="server" Font-Names="Arial" Height="26px" MaxLength="1000" TextMode="SingleLine" Width="668px"></asp:TextBox>
                    </td>
                   
                     <td class="auto-style6"><asp:CheckBox ID="CheckBox1" Visible="false" runat="server" AutoPostBack="True" Text="Digər" OnCheckedChanged="CheckBox1_CheckedChanged" /></td>
                </tr>
              <%--  <tr >
                    <td class="auto-style4">Məqsəd</td>
                    <td class="auto-style5"> 
                        <asp:DropDownList ID="ComboBox2" runat="server" AutoPostBack="True" CausesValidation="True" Height="30px" Width="673px">
                        </asp:DropDownList>
                        <asp:TextBox ID="TextBox4" runat="server" Font-Names="Arial" Height="26px" MaxLength="1000" TextMode="SingleLine" Width="668px"></asp:TextBox>
                    </td>
                   
                     <td class="auto-style6"><asp:CheckBox ID="CheckBox2" runat="server" AutoPostBack="True" Text="Digər" OnCheckedChanged="CheckBox2_CheckedChanged" /></td>
                </tr>
                <tr>
                    <td class="auto-style19">Görüləcək işlər</td>
                    <td class="auto-style20"> 
                        <asp:TextBox ID="TextBox1" runat="server" Font-Names="Arial" Height="47px" MaxLength="1000" TextMode="MultiLine" Width="668px"></asp:TextBox>
                    </td>
                    <td class="auto-style21"></td>
                </tr>
                  <tr>
                    <td class="auto-style19">Gözlənilən nəticə</td>
                    <td class="auto-style20"> 
                        <asp:TextBox ID="TextBox2" runat="server" Font-Names="Arial" Height="47px" MaxLength="1000" TextMode="MultiLine" Width="669px"></asp:TextBox>
                    </td>
                    <td class="auto-style21"></td>
                </tr>--%>
                <tr>
                    <td class="auto-style25"></td>
                    <td class="auto-style26">
                        <asp:Button ID="Button1" runat="server" Text="Əlavə et" OnClick="Button1_Click" /></td>
                    <td class="auto-style27"></td>
                </tr>
             
            </table>
           <div>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lblmsg" runat="server"></asp:Label>
                </div>
            
           
         

            <asp:DataList ID="GridView1" runat="server" ForeColor="#333333"  Width="1024px">
            <AlternatingItemStyle BackColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderTemplate>
                <table style="width:100%">
                    <tr>
 <td style="padding-left:3px;text-align:left;width:25%;white-space: normal;">Olacağı nümayəndəlik</td>
 <td style="padding-left:3px;text-align:left;width:10%;white-space: normal; ">Sil</td>                     
                    </tr>
                </table>
            </HeaderTemplate>
            <ItemStyle />
            <ItemTemplate>
                <table style="border-bottom-style: dotted; border-bottom-width: thin;width:100%; border-left-style: dotted; border-left-width: thin; border-right-style: dotted; border-right-width: thin;">
                    <tr>
                   <td style="padding-left:3px;text-align:left;width:25%;white-space: normal;border-right:dotted; border-right-style: dotted; border-right-width: thin;"><%#Eval("Delegate") %></td>
                   <td style="padding-left:3px;text-align:left;width:10%;white-space: normal; "><a class="aucun" href='et_ihb_numayendelik.aspx?islem=sil&ConnID=<%#Eval("ConnID") %>'>Sil</a></td>
                         </tr>
                </table>
            </ItemTemplate>
            <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        </asp:DataList>

      
        </div>
</asp:Content>

