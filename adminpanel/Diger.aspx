<%@ Page Title="" Language="C#" MasterPageFile="~/adminpanel/adminMasterPage.master" AutoEventWireup="true" CodeFile="Diger.aspx.cs" Inherits="adminpanel_diger" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style2 {
            width: 744px;
        }
        .auto-style14 {
            width: 119px;
            height: 28px;
        }
        .auto-style15 {
            width: 744px;
            height: 28px;
        }
        .auto-style17 {
            width: 119px;
            height: 39px;
        }
        .auto-style18 {
            width: 744px;
            height: 39px;
        }
        .auto-style23 {
            width: 119px;
            height: 31px;
        }
        .auto-style24 {
            width: 744px;
            height: 31px;
        }
        .auto-style26 {
            width: 119px;
            height: 38px;
        }
        .auto-style27 {
            width: 744px;
            height: 38px;
        }
        .auto-style29 {
            width: 100%;
        }
        .auto-style30 {
            width: 858px;
        }
        .auto-style31 {
            width: 119px;
            height: 50px;
        }
        .auto-style32 {
            width: 744px;
            height: 50px;
        }
        .auto-style33 {
            width: 119px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">



            <table class="auto-style29">
            <tr>
                <td class="auto-style30" style="    font-family: Arial, Helvetica, sans-serif;font-size: 20px;font-weight: bold;font-style: normal;">
                    &nbsp;
                    Qeyd olunmuş digər məsələlər:</td>
                <td>
                <asp:Button ID="btngeri" runat="server" OnClick="btngeri_Click" Text="Geri" Width="150px" Visible="false" />
                </td>
            </tr>
        </table>
    <div class="message">
        <asp:Label ID="lblmeqsedsil" runat="server" Text=""></asp:Label></div>
<%--    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>--%>

        
    <asp:Panel ID="Panel1" Visible="false" runat="server">

    <table style="width: 100%">
        <tr>
            <td class="auto-style33" style="text-align:right;"><strong>Bölmənin adı:&nbsp;</strong></td>
            <td class="auto-style2">

                <asp:Label ID="lblbolme" runat="server"></asp:Label>
                <br />
            </td>
        </tr>
         <tr>
            <td class="auto-style26" style="text-align:right;"><strong>Təsnifatın adı:</strong>&nbsp;&nbsp;</td>
            <td class="auto-style27"><asp:Label ID="lbltesnifatadi" runat="server"></asp:Label>
             </td>
        </tr>
        <tr>
            <td class="auto-style23" style="text-align:right;"><strong>Digər:</strong>&nbsp;&nbsp;</td>
            <td class="auto-style24">
    <asp:TextBox ID="txtmeqsedelave" runat="server" Width="670px" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>

    
          <asp:Panel ID="pnlelaveddl"  runat="server">
          <tr>
            <td class="auto-style14" style="text-align:right;">
               <strong> <asp:Label ID="lbltesnif1" runat="server" Text=""></asp:Label></strong>&nbsp;&nbsp;</td>
            <td class="auto-style15">
<asp:DropDownList ID="ddlihbrayonelave" runat="server" AutoPostBack="True"
 OnSelectedIndexChanged="ddlihbrayonelave_SelectedIndexChanged">
</asp:DropDownList>
                           
                </td>
        </tr>
  
</asp:Panel>
        


          <tr>
            <td class="auto-style17" style="text-align:right;">
                <strong><asp:Label ID="lbltesnifatyeri" runat="server"></asp:Label></strong>
                &nbsp;&nbsp;</td>
            <td class="auto-style18">
                <asp:DropDownList ID="ddlmeqsedsort" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlmeqsedsort_SelectedIndexChanged">
                </asp:DropDownList>
              </td>
        </tr>

              <asp:Panel ID="pnlyawayiw" Visible="false" runat="server">   
          <tr>
            <td class="auto-style14" style="text-align:right;">
               <strong> <asp:Label ID="lblyawayiwied" runat="server" Text=""></asp:Label></strong>&nbsp;&nbsp;</td>
            <td class="auto-style15">
<asp:DropDownList ID="ddliedyawayiwelave" runat="server" AutoPostBack="True">
</asp:DropDownList>
                           
                </td>
        </tr>
   
</asp:Panel>
          <tr>
            <td class="auto-style33">&nbsp;</td>
            <td class="auto-style2">
                <asp:Button ID="btnesas" runat="server" OnClick="btnesas_Click1" Text="Əsasa əlavə et" Width="150px" /></td>
        </tr>
                <tr>
            <td class="auto-style31"></td>
            <td class="auto-style32">
                    <asp:Label ID="lblmeqsedelave" runat="server"></asp:Label>
                    </td>
        </tr>
    </table>
    </asp:Panel>

       <%--     </ContentTemplate>
    </asp:UpdatePanel>--%>
         <asp:DataList ID="DataList1" runat="server"  ForeColor="#333333" Width="1024px" OnItemDataBound="DataList1_ItemDataBound">
            <AlternatingItemStyle BackColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
               <HeaderTemplate>
                       <table style="width:100%;" >
                                    <tr>
                                        <td style="width:15%; white-space: normal;">Kuratorun adı</td>
                                        <td style="width:24%; white-space: normal;padding-left:4px;">Bölmənin adı</td>
                                        <td style="width:23%; white-space: normal;padding-left:10px;">Təsnifatın adı</td>
                                        <td style="width:26%; white-space: normal;padding-left:10px;">Digər</td>
                                        <td style="width:8%; white-space: normal;padding-left:10px;">Düzəliş</td>
                                        <td style="width:4%; white-space: normal;padding-left:10px;">Sil</td>
                                          </tr>
                                </table>
             </HeaderTemplate>

            <ItemTemplate>
                <table style="border-bottom-style: dotted; border-bottom-width: thin;width:100%; border-left-style: dotted; border-left-width: thin; border-right-style: dotted; border-right-width: thin;">
                    <tr>
                        <td style="width:15%; white-space: normal;border-right:dotted; border-right-style: dotted; border-right-width: thin;"><%#Eval("Name") %></td><%--<%#Class2.sozukes(Eval("RegionCome").ToString()) %>--%>
                        <td style="width:24%; white-space: normal;padding-left:4px;padding-right:4px;border-right:dotted; border-right-style: dotted; border-right-width: thin;"><%#Eval("Part") %></td>            
                        <td style="width:23%; white-space: normal;padding-left:10px;border-right:dotted; border-right-style: dotted; border-right-width: thin;"><%#Eval("PurPoseName") %></td>
                        <td style="width:26%; white-space: normal;padding-left:10px;border-right:dotted; border-right-style: dotted; border-right-width: thin;"><%#Eval("Other")%></td>
                        <td style="width:8%; white-space: normal;padding-left:10px;border-right:dotted; border-right-style: dotted; border-right-width: thin;"><a href="Diger.aspx?Other=<%#Eval("Other") %>&Tesnifat=<%#Eval("Tesnifat")%>&islem=duzelis&OtherID=<%#Eval("OtherID") %>&PurPoseName=<%#Eval("PurPoseName") %>&Part=<%#Eval("Part") %>&rownumber=<%#Container.ItemIndex %>">Düzəliş</a></td>
                        <td style="width:4%; white-space: normal;padding-left:10px;"><a href="Diger.aspx?islem=sil&OtherIDsil=<%#Eval("OtherID") %>&Tesnifatsil=<%#Eval("Tesnifat") %>">Sil</a></td>
                    </tr>
                </table>
            </ItemTemplate>
            <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        </asp:DataList>
                  
   
</asp:Content>

