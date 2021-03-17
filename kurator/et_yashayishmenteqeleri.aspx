<%@ Page Title="" Language="C#" MasterPageFile="~/kurator/KuratorhisseMasterPage.master" AutoEventWireup="true" CodeFile="et_yashayishmenteqeleri.aspx.cs" Inherits="kurator_et_yashayishmenteqeleri" %>



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
        .auto-style19
        {
            width: 209px;
            height: 62px;
        }
        .auto-style20
        {
            width: 535px;
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
            width: 209px;
            height: 48px;
        }
        .auto-style26
        {
            width: 535px;
            height: 48px;
        }
        .auto-style27
        {
            height: 48px;
        }
          .auto-style31
          {
              width: 209px;
              height: 37px;
          }
          .auto-style32
          {
              width: 535px;
              height: 37px;
          }
          .auto-style33
          {
              height: 37px;
          }
          .auto-style34
          {
              width: 209px;
              height: 34px;
          }
          .auto-style35
          {
              width: 535px;
              height: 34px;
          }
          .auto-style36
          {
              height: 34px;
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
                    <td class="auto-style34">Olacağı yaşayış məntəqəsi</td>
                    <td class="auto-style35">  
                        <asp:DropDownList ID="ComboBox1" runat="server" AutoPostBack="True" CausesValidation="True" Height="30px" Width="732px">
                        </asp:DropDownList>
                        <asp:TextBox ID="TextBox4" runat="server" Font-Names="Arial" Height="26px" MaxLength="1000" Width="728px"></asp:TextBox>

                    </td>
                    <td class="auto-style36"><asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" Text="Digər" OnCheckedChanged="CheckBox1_CheckedChanged" Visible="False" /></td>
                </tr>
            
                <tr>
                    <td class="auto-style25"></td>
                    <td class="auto-style26">
                        <asp:Button ID="Button1" runat="server" Text="Əlavə et" OnClick="Button1_Click" style="height: 26px" /></td>
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
                <table style="width:100%;">
                    <tr>
 <td style="padding-left:3px;text-align:left;width:23%;white-space: normal;">Olacağı yaşayış məntəqəsi</td>
 <td style="padding-left:3px;text-align:left;width:5%;white-space: normal; ">Sil</td>                     
                    </tr>
                </table>
            </HeaderTemplate>
            <ItemStyle />
            <ItemTemplate>
                <table style="border-bottom-style: dotted; border-bottom-width: thin;width:100%; border-left-style: dotted; border-left-width: thin; border-right-style: dotted; border-right-width: thin;">
                    <tr>
                   <td style="padding-left:3px;text-align:left;width:23%;white-space: normal;border-right:dotted; border-right-style: dotted; border-right-width: thin;"><%#Eval("Living") %></td>
                   <td style="padding-left:3px;text-align:left;width:5%;white-space: normal; "><a class="aucun" href='et_yashayishmenteqeleri.aspx?islem=sil&ConnID=<%#Eval("ConnID") %>'>Sil</a></td>
                         </tr>
                </table>
            </ItemTemplate>
            <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        </asp:DataList>

      
        </div>
</asp:Content>

