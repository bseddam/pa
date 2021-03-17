<%@ Page Title="" Language="C#" MasterPageFile="~/kurator/KuratorhisseMasterPage.master" AutoEventWireup="true" CodeFile="Ezamiyyənin_Planı.aspx.cs" Inherits="kurator_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 11px;
        }
        .auto-style3 {
            width: 11px;
            height: 17px;
        }
        .auto-style4 {
            height: 17px;
        }
           .auto-style23 {
            width: 880px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="flex-align:center; position:relative; width:1024px; text-align:left;" >
      
        
            <div>
        <table style=" width: 100%;">
            <tr>
                <td class="auto-style23">&nbsp;</td>
                <td>
                    <asp:Button ID="btngeri" runat="server" Text="Geri" Width="120px" OnClick="btngeri_Click" />
                </td>
            </tr>
        </table>
    </div>
        
        
         <div>
             <table class="auto-style1">
                      <tr>
                     <td class="auto-style2">&nbsp;</td>
                     <td>&nbsp;</td>
                 </tr>
                      <tr>
                     <td class="auto-style2">&nbsp;</td>
                     <td>
                         <asp:LinkButton ID="Button1" OnClick="Button1_Click" runat="server">Ezamiyyənin məqsədi, bununla bağlı görüləcək işlər</asp:LinkButton>
                          </td>
                 </tr>
                      <tr>
                     <td class="auto-style2">&nbsp;</td>
                     <td>&nbsp;</td>
                 </tr>
                      <tr>
                     <td class="auto-style2">&nbsp;</td>
                     <td>
                         <asp:LinkButton ID="Button2" OnClick="Button2_Click" runat="server">İştirakı nəzərdə tutulmuş tədbirlər, müzakirə olunacaq məsələlər</asp:LinkButton>
                          </td>
                 </tr>
                      <tr>
                     <td class="auto-style2">&nbsp;</td>
                     <td>&nbsp;</td>
                 </tr>
                      <tr>
                     <td class="auto-style2">&nbsp;</td>
                     <td>
                         <asp:LinkButton ID="Button3" OnClick="Button3_Click" runat="server">Əməkdaşın nəzərdə tutulmuş görüşləri, məqsədlər, müzakirə olunacaq məsələlər</asp:LinkButton>
                          </td>
                 </tr>
                          <tr>
                     <td class="auto-style2">&nbsp;</td>
                     <td>&nbsp;</td>
                 </tr>

                 <tr>
                     <td class="auto-style2">&nbsp;</td>
                     <td>
                         <asp:LinkButton ID="Button4" OnClick="Button4_Click" runat="server">Olacağı İHB nümayəndəlikləri</asp:LinkButton>
                     </td>
                 </tr>

                  <tr>
                     <td class="auto-style2">&nbsp;</td>
                     <td>&nbsp;</td>
                 </tr>
                      <tr>
                     <td class="auto-style2">&nbsp;</td>
                     <td>
                         <asp:LinkButton ID="Button5" OnClick="Button5_Click" runat="server">Olacağı yaşayış məntəqələri<%--, görüləcək işlər və gözlənilən nəticələr--%></asp:LinkButton>
                          </td>
                 </tr>


             </table>
         </div>

            </div>
</asp:Content>

