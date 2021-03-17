<%@ Page Title="" Language="C#" MasterPageFile="~/adminpanel/adminMasterPage.master" AutoEventWireup="true" CodeFile="Kuratorlar.aspx.cs" Inherits="adminpanel_Kuratorlar" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 777px;
        }
        .auto-style2 {
            width: 200px;
        }
        .auto-style6 {
            width: 4px;
        }
        .auto-style7 {
            width: 1002px;
        }
        .auto-style9 {
            width: 193px;
        }
        .auto-style16 {
            width: 188px;
        }
        .auto-style22 {
            width: 160px;
        }
        .auto-style25 {
            width: 164px;
        }
        .auto-style30 {
            width: 181px;
        }
        .auto-style36 {
            width: 19px;
        }
        .auto-style42 {
            width: 32px;
        }
        .auto-style45 {
            width: 187px;
        }
        .auto-style46 {
            width: 265px;
        }
        .auto-style49 {
            width: 102%;
            height: 54px;
        }
        .auto-style52 {
            width: 544px;
        }
        .auto-style55 {
            width: 45px;
        }
        .auto-style60 {
            width: 100%;
        }
        .auto-style61 {
            width: 184px;
            }
        .auto-style62 {
            width: 66px;
        }
        .auto-style65 {
            width: 74px;
            }
        .auto-style68 {
            width: 169px;
            }
        .auto-style70 {
            width: 75px;
        }
        .auto-style71 {
            width: 391px;
        }
        .auto-style72 {
            width: 64px;
        }
        .auto-style73 {
            width: 226px;
        }
        .auto-style74 {
            width: 206px;
        }
        .auto-style75 {
            width: 105px;
        }
        .auto-style76 {
            width: 248px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
     <div >
                <table class="auto-style7">
                    <tr>
                        <td class="auto-style72">&nbsp;</td>
                        <td class="auto-style9">
                            
                            <asp:Button ID="btnkurasiyabax" runat="server" OnClick="btnkurasiyabax_Click" Text="Kurasiyalara bax" Width="150px" />
                            
                        </td>
                        <td class="auto-style2">
                            
                            <asp:Button ID="btnkuratorelave" runat="server" OnClick="btnkuratorelave_Click" Text="Kurator əlavə et" Width="150px" />
                            
                        </td>
                       <td class="auto-style73">
                            <asp:Button ID="kuratorduzaliw" runat="server" OnClick="kuratorduzaliw_Click" Text="Kurator düzəliş" Width="150px" />
                       </td>
                            <td class="auto-style74">
                           <asp:Button ID="btnad" runat="server" Text="Kuratorun adını dəyiş"  Width="150px" OnClick="btnad_Click" />
                        </td>
                          <td class="auto-style16">
                           <asp:Button ID="kuratorsil" runat="server" Text="Kurator sil" OnClick="kuratorsil_Click" Width="150px" />
                        </td>
                        <td class="auto-style6">
                            &nbsp;</td>
                    </tr>
                </table>
            </div>


        <asp:Panel ID="pnladdeyiw" Visible="false" runat="server">
                <div style="padding-top:50px;">
                <table style="height: 149px; width: 878px;" >
                    <tr>
                      <td class="auto-style75">&nbsp;</td>
                        <td class="auto-style42" >Kurator</td>
                        <td class="auto-style22">
                            <asp:DropDownList ID="ddladdeyiw" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddladdeyiw_SelectedIndexChanged" Width="169px">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style75" ></td>
                        <td class="auto-style42" >Ad</td>
                        <td class="auto-style30">
                            <asp:TextBox ID="txtad" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                       <tr>
                        <td class="auto-style75" ></td>
                        <td class="auto-style42" >Soyad</td>
                        <td class="auto-style25">
                            <asp:TextBox ID="txtsyd" runat="server"></asp:TextBox>
                           </td>
                    </tr>
                      <tr>
                        <td class="auto-style75" >&nbsp;</td>
                        <td class="auto-style42" >&nbsp;</td>
                        <td class="auto-style22">
                            &nbsp;</td>
                    </tr>

                       <tr>
                        <td class="auto-style75" >&nbsp;</td>
                        <td class="auto-style42" >&nbsp;</td>
                        <td class="auto-style22">
                            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Yadda saxla" />
                            </td>
                    </tr>
                          
                     
                </table>
                    
           

                            <table class="auto-style7">
                    <tr>
                        <td class="auto-style46">&nbsp;</td>
                        <td> &nbsp;   </td>
                    </tr>
                         <tr>
                        <td class="auto-style46">&nbsp;</td>
                        <td><asp:Label ID="lblmessage" runat="server"></asp:Label> </td>
                    </tr>
                </table>
            
           </div>
    
      
            </asp:Panel>




  <div><asp:Panel ID="pnlkuratorelave" Visible="false" runat="server">
                <div style="padding-top:50px;">
                <table style="height: 149px; width: 602px;" >
                    <tr>
                      <td class="auto-style45">&nbsp;</td>
                        <td class="auto-style42" >Ad</td>
                        <td class="auto-style22">
                            <asp:TextBox ID="txtadi" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style45" ></td>
                        <td class="auto-style42" >Soyad</td>
                        <td class="auto-style30">
                            <asp:TextBox ID="txtsoyadi" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                       <tr>
                        <td class="auto-style45" ></td>
                        <td class="auto-style42" >Parol</td>
                        <td class="auto-style25">
                            <asp:TextBox ID="txtpassvord" runat="server"></asp:TextBox>
                           </td>
                    </tr>
                      <tr>
                        <td class="auto-style45" >&nbsp;</td>
                        <td class="auto-style42" >&nbsp;</td>
                        <td class="auto-style22">
                            &nbsp;</td>
                    </tr>

                       <tr>
                        <td class="auto-style45" >&nbsp;</td>
                        <td class="auto-style42" >&nbsp;</td>
                        <td class="auto-style22">
                            <asp:Button ID="btnkurelave" runat="server" OnClick="btnkurelave_Click" Text="Yadda saxla" />
                            </td>
                    </tr>
                          
                     
                </table>
                    
           

                            <table class="auto-style7">
                    <tr>
                        <td class="auto-style46">&nbsp;</td>
                        <td> &nbsp;   </td>
                    </tr>
                         <tr>
                        <td class="auto-style46">&nbsp;</td>
                        <td><asp:Label ID="lblerror" runat="server"></asp:Label> </td>
                    </tr>
                </table>
            
           </div>
    
      
            </asp:Panel>
     





<asp:Panel ID="pnlkurator" Visible="false"  runat="server">   
                   
                        <div style="float:right;margin-right:10px;margin-top:30px; width: 220px;">


                            <table class="auto-style49">
                                <tr>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Button ID="btnyaddasaxla" runat="server" OnClick="btnyaddasaxla_Click"  Text="Yadda saxla" Width="150px" Height="33px" />
                                    </td>
                                </tr>
                                 <tr>
                                    <td>
                                        &nbsp;
                                     </td>
                                </tr>
                            </table>
                            <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
                            <br />
                            <br />
                            <br />

        <asp:DataList ID="dlbowolan" runat="server" CellPadding="1" ForeColor="#333333" BorderStyle="Solid" Width="205px" >
            <AlternatingItemStyle BackColor="White" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
              <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderTemplate>
                         <table  style="width:170px;">
                            <tr>
                               <td >
                                   Kuratoru təyin olunmayan rayonlar</td>
                               
                            </tr>
                        </table>
                    </HeaderTemplate>
            <ItemStyle BackColor="#EFF3FB" />
            <ItemTemplate>
                 <table  style="width:170px;">
                    <tr>
                        <td><%#Eval("Name") %></td>
                                      </tr>
                </table>
            </ItemTemplate>
            <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        </asp:DataList>

    </div> 
                    <div style="padding-left:0px;padding-top:30px;">

            <table class="auto-style1">
        <tr>
            <td class="auto-style36" >&nbsp;</td>
            <td class="auto-style70" >Kurator:</td>
            <td class="auto-style71" >
                <asp:DropDownList ID="ddlusersreg" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlusersreg_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td >&nbsp;</td>
    
        </tr>
        <tr>
            <td class="auto-style36" >&nbsp;</td>
            <td class="auto-style70" >
              
                &nbsp;</td>
            <td class="auto-style71" >
               
                &nbsp;</td>
            <td >
               
                &nbsp;</td>
            
        </tr>
    </table>
          
     
    <div>&nbsp;</div>
     
            <asp:CheckBoxList ID="chkrayon" runat="server" RepeatColumns="5" CellPadding="1" CellSpacing="3"></asp:CheckBoxList>

        </div>
                </asp:Panel>







               <asp:Panel ID="pnlsil" runat="server"  Visible="False">
             <div class="altbawliqlar">Kurator sil</div>
        <div>&nbsp;</div>
        <table class="auto-style1">
           <tr>
                <td class="auto-style55">&nbsp;</td>
                <td class="auto-style52">&nbsp;</td>
      
            </tr>
              <tr>
                <td class="auto-style55">&nbsp;</td>
                <td class="auto-style52">Kurator :</td>
             
            </tr>
            <tr>
                <td class="auto-style55">&nbsp;</td>
                <td class="auto-style52">
                    <asp:DropDownList ID="ddlrayonsil" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlrayonsil_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
       
            </tr>
            <tr>
                <td class="auto-style55">&nbsp;</td>
                <td class="auto-style52">&nbsp;</td>
            
            </tr>
                    <tr>
                <td class="auto-style55">&nbsp;</td>
                <td class="auto-style52">
                    <asp:Button ID="btnrayonsil" runat="server" OnClick="btnrayonsil_Click1" Text="Sil" Width="100px" />
                        </td>
              
            </tr>
        </table>
              
                <div class="message">
                    <asp:Label ID="lblrayonsil" runat="server"></asp:Label>
                </div>
           
        <div id="pnlilSil" style="display: none;" class="popupConfirmation">
            <div class="popup_Container">
                <div class="popup_Titlebar" id="PopupHeader">
                    <div class="TitlebarLeft">Diqqətli olun!!!</div>
                   <%-- <div class="TitlebarRight" onclick="cancel();"></div>--%>
                </div>
                <div class="popup_Body">
                    Silməyə əminsinizmi?
                </div>
                <div class="popup_Buttons">
                 <asp:Button ID="btnOkay" runat="server" Text="Bəli" OnClick="btnOkay_Click" />
                 <input id="btnCancel" value="Xeyr" type="button" onclick="cancel();" />
                    
                </div>
            </div>
        </div>


         </asp:Panel>
      <asp:Panel ID="pnlkurasiyabax" Visible="false" runat="server">
                    
          <table style="padding-top:30px;" class="auto-style60">
              <tr>
                  <td class="auto-style76"></td>
                  <td class="auto-style65">Kurator:</td>
                  <td class="auto-style68">
                      <asp:DropDownList ID="ddlkurasiya" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlkurasiya_SelectedIndexChanged"></asp:DropDownList>
                      </td>
                  <td></td>
              </tr>
          </table>
          <div>&nbsp;</div>
          
           <table style="height: 149px; width: 977px;" >
                    <tr>
                      
                        <td class="auto-style62">&nbsp;</td>
                        <td class="auto-style22">
                            <asp:DataList ID="dlkurasiya" runat="server" BorderStyle="Solid" CellPadding="1" ForeColor="#333333" Width="205px">
                                <AlternatingItemStyle BackColor="White" />
                                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <HeaderTemplate>
                                    <table style="width:170px;">
                                        <tr>
                                            <td>Rayonları</td>
                                        </tr>
                                    </table>
                                </HeaderTemplate>
                                <ItemStyle BackColor="#EFF3FB" />
                                <ItemTemplate>
                                    <table style="width:170px;">
                                        <tr>
                                            <td><%#Eval("Name") %></td>
                                        </tr>
                                    </table>
                                </ItemTemplate>
                                <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            </asp:DataList>
                        </td>
                    </tr>
      
              </table>

        
         
      </asp:Panel>

    </div>
                

  
</asp:Content>

