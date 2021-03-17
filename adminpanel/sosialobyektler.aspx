<%@ Page Title="" Language="C#" MasterPageFile="~/adminpanel/TesnifatMasterPage.master" AutoEventWireup="true" CodeFile="sosialobyektler.aspx.cs" Inherits="adminpanel_sosialobyektler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <div style="padding-left:20px; padding-top:20px;">
      <asp:DataList ID="DataList1" runat="server" CellPadding="4" ForeColor="#333333" Width="685px">
            <AlternatingItemStyle BackColor="White" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
               <HeaderTemplate>
                       <table style="width:100%;">
                                    <tr>
                                        <td style="width:33%; white-space: normal;">Sosial obyektlər və texnika</td>
                                        <td style="width:33%; white-space: normal;padding-left:10px;">Rayonun adı</td>
                                        <td style="width:33%; white-space: normal;padding-left:25px;">Sayı</td>
                                   
                                          </tr>
                                </table>
             </HeaderTemplate>
            <ItemStyle BackColor="#EFF3FB" />
            <ItemTemplate>
                <table style="width:100%;">
                    <tr>
                          <td style="width:33%; white-space: normal;"><%#Eval("Texnika") %></td>
                        <td style="width:33%; white-space: normal;padding-left:10px;"><%#Eval("Name") %></td><%--<%#Class2.sozukes(Eval("RegionCome").ToString()) %>--%>
                          <td style="width:33%; white-space: normal;padding-left:25px;"><%#Eval("Count_n")%></td>
                       
                    </tr>
                </table>
            </ItemTemplate>
            <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        </asp:DataList>
      </div>
</asp:Content>

