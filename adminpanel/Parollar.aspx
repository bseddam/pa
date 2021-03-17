<%@ Page Title="" Language="C#" MasterPageFile="~/adminpanel/adminMasterPage.master" AutoEventWireup="true" CodeFile="Parollar.aspx.cs" Inherits="adminpanel_Parollar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 64px;
        }
        .auto-style3 {
            width: 183px;
        }
        .auto-style4 {
            width: 53px;
        }
        .auto-style5 {
            width: 175px;
        }
        .auto-style6 {
            width: 195px;
        }
        .auto-style7 {
            width: 100%;
        }
        .auto-style15 {
            width: 182px;
        }
        .auto-style16 {
            width: 221px;
        }
        .auto-style20 {
            width: 189px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 
            <div >
                <table class="auto-style7">
                    <tr>
                        <td class="auto-style15">&nbsp;</td>
                        <td class="auto-style20">
                            <asp:Button ID="btnparol" runat="server" OnClick="btnparol_Click" style="margin-left: 0px" Text="Parol dəyiş" Width="150px" Visible="False" />
                        </td>
                        <td class="auto-style15">
                            &nbsp;</td>
                        <td class="auto-style16">
                            <asp:Button ID="btngeri" runat="server" Text="Geri" OnClick="btngeri_Click" Width="100px" Enabled="False" Visible="False" />
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                </table>
            </div>
            <asp:Panel ID="pnlparol"  runat="server">

   <div style="padding-top:50px;">
    <table class="auto-style1">
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style6">İstifadəçi:</td>
            <td class="auto-style3">Köhnə parol:</td>
            <td class="auto-style5">Yeni parol:</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style6">
                <asp:DropDownList ID="ddlistifadeci" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlistifadeci_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="txtkohneparol" runat="server" Enabled="False"></asp:TextBox>
            </td>
            <td class="auto-style5">
                <asp:TextBox ID="txtyeniparol" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Yadda saxla" OnClick="Button1_Click" />
            </td>
        </tr>
    </table>
       
                <table class="auto-style7">
                    <tr>
                        <td class="auto-style4">&nbsp;</td>
                        <td> &nbsp;   </td>
                    </tr>
                         <tr>
                        <td class="auto-style4">&nbsp;</td>
                        <td><asp:Label ID="lblmessage" runat="server"></asp:Label> </td>
                    </tr>
                </table>
       </div>
 </asp:Panel>


      
</asp:Content>

