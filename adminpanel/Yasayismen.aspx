<%@ Page Title="" Language="C#" MasterPageFile="~/adminpanel/TesnifatMasterPage.master" AutoEventWireup="true" CodeFile="Yasayismen.aspx.cs" Inherits="adminpanel_Yasayismen" %>



<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

        <script language="javascript" type="text/javascript">
            function cancel() {
                window.parent.document.getElementById('btnCancel').click();
            }
    </script>

    <style type="text/css">

            .auto-style1 {
            width: 100%;
        }
    
    .auto-style2 {
        width: 51px;
    }
    
         .auto-style5 {
             width: 239px;
         }
    
         .auto-style6 {
             width: 55px;
         }
         .auto-style7 {
             width: 164px;
         }
    
         .auto-style12 {
             width: 130px;
         }
         .auto-style13 {
             width: 137px;
         }
    
         .auto-style14 {
             width: 238px;
         }
    
         .auto-style15 {
             width: 189px;
         }
         .auto-style16 {
             width: 143px;
         }
    
         .auto-style51 {
            width: 77px;
        }
    
         .auto-style55 {
            width: 175px;
        }
    
         .auto-style56 {
            width: 180px;
        }
        .auto-style57 {
            width: 199px;
        }
    
         .auto-style59 {
            width: 155px;
        }
    
         .auto-style60 {
            width: 63px;
        }
    
         .auto-style62 {
            width: 157px;
        }
    
         .auto-style63 {
            width: 67px;
        }
            
         .auto-style68 {
            width: 57px;
        }
        .auto-style71 {
            width: 153px;
        }
    
         .auto-style72 {
            width: 58px;
        }
        .auto-style74 {
            width: 82px;
        }
    
         .auto-style75 {
            width: 61px;
        }
        .auto-style76 {
            width: 121px;
        }
    
         .auto-style77 {
            width: 170px;
        }
    
         </style>











  
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style56"><asp:Button ID="btnrayon" class="btn btn-default" runat="server" Text="Rayon və şəhərlər" OnClick="btnrayon_Click" Width="130px" /></td>
            <td class="auto-style55"><asp:Button ID="btnihb" class="btn btn-default" runat="server" Text="İƏD-lər" Width="130px" OnClick="btnihb_Click" /> </td>
            <td class="auto-style57"><asp:Button ID="btnyawayiw" class="btn btn-default" runat="server" Text="Şəhər,qəsəbə,kənd" OnClick="btnyawayiw_Click" Width="130px" /></td>
            <td>
                <asp:Button ID="btngeri" runat="server" OnClick="btnelavegeri_Click" Text="Geri" Width="130px" Enabled="False" />
            </td>
        </tr>
    </table>


    <asp:Panel ID="pnlrayon" runat="server" Visible="False">
         <div>&nbsp;</div>
     <table class="auto-style1">
        
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style5">
                <asp:Button ID="btninsertrayon" runat="server" Text="Rayon, şəhər əlavə et" Width="210px" OnClick="btninsertrayon_Click" /></td>
            <td class="auto-style14">
                <asp:Button ID="btnupdaterayon" runat="server" Text="Rayon, şəhər redaktə et" Width="210px" OnClick="btnupdaterayon_Click" /></td>
            <td>
                <asp:Button ID="btndeleterayon" runat="server" Text="Rayon, şəhər sil" Width="210px" OnClick="btndeleterayon_Click" /></td>
        </tr>
    </table>
    

     
    <asp:Panel ID="pnlinsertrayon" runat="server"  Visible="False">
        <div class="altbawliqlar">Rayon, şəhər əlavə et</div>
        <div>&nbsp;</div>
        <table class="auto-style1">
           <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style13">&nbsp; </td>
                <td class="auto-style12">
                    &nbsp;</td>
               <td class="auto-style51">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
              <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style7">Rayon, şəhər:</td>
                <td class="auto-style13">Status:</td>
                  <td class="auto-style12">&nbsp;</td>
                  <td class="auto-style51">&nbsp;</td>
                  <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style7"><asp:TextBox ID="txtrayonelave" runat="server" Width="146px"></asp:TextBox></td>
                <td class="auto-style13">
                    <asp:DropDownList ID="ddlstatusray0" runat="server">
                        <asp:ListItem Value="0">Seçin</asp:ListItem>
                        <asp:ListItem Value="1">Şəhər</asp:ListItem>
                        <asp:ListItem Value="2">Rayon</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style12">
                    <asp:Button ID="btnrayonelave" runat="server" OnClick="btnrayonelave_Click" Text="Əlavə et" Width="100px" />
                </td>
                <td class="auto-style51">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
            
                <div class="message">
                    <asp:Label ID="lblrayonelave" runat="server"></asp:Label>
                </div>
         </asp:Panel>

        
    <asp:Panel ID="pnlupdaterayon" runat="server"  Visible="False">
        <div class="altbawliqlar">Rayon, şəhər redaktə et</div>
         <div>&nbsp;</div>
        <table class="auto-style1">
           <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style77">&nbsp;</td>
                <td class="auto-style77">
                    &nbsp;</td>
               <td>&nbsp;</td>
            </tr>
              <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style7">Rayon, şəhər:</td>
                <td class="auto-style77">Düzəliş:</td>
                <td class="auto-style77">Status:</td>
                  <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style7"> 
                    <asp:DropDownList ID="ddlrayonredakte" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlrayonredakte_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td class="auto-style77">
                    <asp:TextBox ID="txtredakte" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style77">
                    <asp:DropDownList ID="ddlstatusray" runat="server">
                        <asp:ListItem Value="0">Seçin</asp:ListItem>
                        <asp:ListItem Value="1">Şəhər</asp:ListItem>
                        <asp:ListItem Value="2">Rayon</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:Button ID="btnrayonredakte" runat="server" OnClick="btnrayonredakte_Click" Text="Yadda saxla" Width="100px" />
                </td>
                <td>
                    &nbsp;</td>
              </tr>
               
        </table>
            
                <div class="message">
                    <asp:Label ID="lblrayonredakte" runat="server"></asp:Label>
                </div>
         </asp:Panel>




         <asp:Panel ID="pnlsil" runat="server"  Visible="False">
             <div class="altbawliqlar">Rayon, şəhər sil</div>
        <div>&nbsp;</div>
        <table class="auto-style1">
           <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style12">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
              <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style7">Rayon, şəhər:</td>
                <td class="auto-style13">&nbsp;</td>
                  <td class="auto-style12">&nbsp;</td>
                  <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style7">
                    <asp:DropDownList ID="ddlrayonsil" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlrayonsil_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td class="auto-style13">
                    <asp:Button ID="btnrayonsil" runat="server" OnClick="btnrayonsil_Click1" Text="Sil" Width="100px" />
                </td>
                <td class="auto-style12">
                    
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
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
       

         </asp:Panel>



        <asp:Panel ID="pnlihb" runat="server"  Visible="False">
         <div>&nbsp;</div>
            
                 <table class="auto-style1">
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style5">
                <asp:Button ID="btnihbelaved" runat="server" Text="İƏD əlavə et" Width="210px" OnClick="btnihbelaved_Click" /></td>
            <td class="auto-style14">
                <asp:Button ID="btnihbredakted" runat="server" Text="İƏD redaktə et" Width="210px" OnClick="btnihbredakted_Click" /></td>
            <td>
                <asp:Button ID="btnihbsild" runat="server" Text="İƏD sil" Width="210px" OnClick="btnihbsild_Click" /></td>
        </tr>
    </table>
        




            <asp:Panel ID="pnlihbelave" runat="server" Visible="False">
                <div class="altbawliqlar">İƏD əlavə et:</div>
                <div>&nbsp;</div>
                 <table class="auto-style1">
           <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style16">
                    &nbsp;</td>
               <td>&nbsp;</td>
               <td>&nbsp;</td>
            </tr>
              <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style7">Rayon, şəhər:</td>
                <td class="auto-style15">Yeni İƏD:</td>
                <td class="auto-style16">&nbsp;</td>
                  <td>&nbsp;</td>
                  <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style7"> 
                    <asp:DropDownList ID="ddlihbrayonelave" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlihbrayonelave_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td class="auto-style15">
                    <asp:TextBox ID="txtihbelave" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style16">
                    <asp:Button ID="btnihbelave" runat="server" OnClick="btnihbelave_Click" Text="Əlavə et" Width="100px" />
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
              </tr>
               
        </table>
                 
                <div class="message">
                    <asp:Label ID="lblihbelave" runat="server"></asp:Label>
                </div>
        </asp:Panel>




            <asp:Panel ID="pnlihbredakte" runat="server" Visible="False">
                <div class="altbawliqlar">İƏD redaktə et:</div>
            <div>&nbsp;</div>
                <div>
                    <table class="auto-style1">
                        <tr>
                            <td class="auto-style75">&nbsp;</td>
                            <td class="auto-style76">Rayon, şəhər:</td>
                            <td>
                                <asp:DropDownList ID="ddlihbrayonredakte" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlihbrayonredakte_SelectedIndexChanged">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style75">&nbsp;</td>
                            <td class="auto-style76">&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style75">&nbsp;</td>
                            <td class="auto-style76">İƏD:</td>
                            <td>
                                <asp:DropDownList ID="ddlihbredakte" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlihbredakte_SelectedIndexChanged">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style75">&nbsp;</td>
                            <td class="auto-style76">&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style75">&nbsp;</td>
                            <td class="auto-style76">Düzəliş:</td>
                            <td>
                                <asp:TextBox ID="txtihbredakte" runat="server" Width="190px"></asp:TextBox>
                            </td>
                        </tr>
                                                <tr>
                            <td class="auto-style75">&nbsp;</td>
                            <td class="auto-style76">&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                                                   <tr>
                            <td class="auto-style75">&nbsp;</td>
                            <td class="auto-style76">
                                <asp:Button ID="btnihbredakte" runat="server" OnClick="btnihbredakte_Click" Text="Yadda saxla" Width="100px" />
                                                       </td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                </div>
                
                <div class="message"><asp:Label ID="lblihbredakte" runat="server"></asp:Label>
                </div>
        </asp:Panel>





              <asp:Panel ID="pnlihbsil" runat="server"  Visible="False">
                  <div class="altbawliqlar">İƏD sil:</div>
         <div>&nbsp;</div>
                  <div>
                      <table class="auto-style1">
                          <tr>
                              <td class="auto-style72">&nbsp;</td>
                              <td class="auto-style74">Rayon:</td>
                              <td>
                                  <asp:DropDownList ID="ddlihbraysil" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                                  </asp:DropDownList>
                              </td>
                          </tr>
                          <tr>
                              <td class="auto-style72">&nbsp;</td>
                              <td class="auto-style74">&nbsp;</td>
                              <td>&nbsp;</td>
                          </tr>
                          <tr>
                              <td class="auto-style72">&nbsp;</td>
                              <td class="auto-style74">İƏD:</td>
                              <td>
                                  <asp:DropDownList ID="ddlihbsil" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlihbsil_SelectedIndexChanged">
                                  </asp:DropDownList>
                              </td>
                          </tr>
                          <tr>
                              <td class="auto-style72">&nbsp;</td>
                              <td class="auto-style74">&nbsp;</td>
                              <td>&nbsp;</td>
                          </tr>
                          <tr>
                              <td class="auto-style72">&nbsp;</td>
                              <td class="auto-style74">
                                  <asp:Button ID="btnihbsil" runat="server" OnClick="btnihbsil_Click" Text="Sil" Width="100px" />
                              </td>
                              <td>&nbsp;</td>
                          </tr>
                      </table>
                  </div>
                   

                <div class="message">
                    <asp:Label ID="lblihbsil" runat="server"></asp:Label>
                </div>


        <div id="pliedsil" style="display: none;" class="popupConfirmation">
            <div class="popup_Container">
                <div class="popup_Titlebar" id="PopupHeader1">
                    <div class="TitlebarLeft">Diqqətli olun!!!</div>
                    <%--<div class="TitlebarRight" onclick="cancel();"></div>--%>
                </div>
                <div class="popup_Body">
                    Silməyə əminsinizmi?
                </div>
                <div class="popup_Buttons">
                 <asp:Button ID="btniedsil" runat="server" Text="Bəli" OnClick="btniedsil_Click"  />
                 <input id="Button4" value="Xeyr" type="button" onclick="cancel();" />
                    
                </div>
            </div>
        </div>
         </asp:Panel>
</asp:Panel>
          
            
             
                    <asp:Panel ID="pnlyawayiw" runat="server"  Visible="False">
         <div>&nbsp;</div>
            
                 <table class="auto-style1">
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style5">
                <asp:Button ID="btnyawayiwelaved" runat="server" Text="Şəhər,qəsəbə,kənd əlavə et" Width="210px" OnClick="btnyawayiwelaved_Click" /></td>
            <td class="auto-style14">
                <asp:Button ID="btnyawayiwredakted" runat="server" Text="Şəhər,qəsəbə,kənd redaktə et" Width="210px" OnClick="btnyawayiwredakted_Click" />
            </td>
            <td>
                <asp:Button ID="btnyawayiwsild" runat="server" Text="Şəhər,qəsəbə,kənd sil" Width="210px" OnClick="btnyawayiwsild_Click" />
            </td>
        </tr>
    </table>





            <asp:Panel ID="pnlyawayiwelave" runat="server" Visible="False">
                <div class="altbawliqlar">&nbsp;Şəhər, qəsəbə, kənd əlavə et:</div>
            <div>&nbsp;</div>
               <div>
                   <table class="auto-style1">
                       <tr>
                           <td class="auto-style63">&nbsp;</td>
                           <td class="auto-style59">Rayon, şəhər:</td>
                           <td>
                               <asp:DropDownList ID="ddlregyawayiwelave" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlregyawayiwelave_SelectedIndexChanged">
                               </asp:DropDownList>
                           </td>
                       </tr>
                       <tr>
                           <td class="auto-style63">&nbsp;</td>
                           <td class="auto-style59">&nbsp;</td>
                           <td>&nbsp;</td>
                       </tr>
                       <tr>
                           <td class="auto-style63">&nbsp;</td>
                           <td class="auto-style59">İƏD:</td>
                           <td>
                               <asp:DropDownList ID="ddliedyawayiwelave" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlyawayiwelave_SelectedIndexChanged" style="height: 22px">
                               </asp:DropDownList>
                           </td>
                       </tr>
                       <tr>
                           <td class="auto-style63">&nbsp;</td>
                           <td class="auto-style59">&nbsp;</td>
                           <td>&nbsp;</td>
                       </tr>
                        <tr>
                           <td class="auto-style63">&nbsp;</td>
                           <td class="auto-style59">Status:</td>
                           <td>
                               <asp:DropDownList ID="ddltypeyawayiw" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddltypeyawayiw_SelectedIndexChanged1">
                               </asp:DropDownList>
                            </td>
                       </tr>
                       <tr>
                           <td class="auto-style63">&nbsp;</td>
                           <td class="auto-style59">&nbsp;</td>
                           <td>&nbsp;</td>
                       </tr>
                                    <tr>
                           <td class="auto-style63">&nbsp;</td>
                           <td class="auto-style59">Şəhər, qəsəbə, kənd:</td>
                           <td>
                               <asp:TextBox ID="txtyawayiwelave" runat="server" Width="150px"></asp:TextBox>
                                        </td>
                       </tr>
                                    <tr>
                           <td class="auto-style63">&nbsp;</td>
                           <td class="auto-style59">&nbsp;</td>
                           <td>&nbsp;</td>
                       </tr>
                                                           <tr>
                           <td class="auto-style63">&nbsp;</td>
                           <td class="auto-style59">
                               <asp:Button ID="btnyawayiwelave" runat="server" OnClick="btnyawayiwelave_Click" Text="Əlavə et" Width="100px" />
                                                               </td>
                           <td>&nbsp;</td>
                       </tr>
                   </table>
                </div>
                
                <div class="message"><asp:Label ID="lblyawayiwelave" runat="server"></asp:Label>
                </div>
        </asp:Panel>







            <asp:Panel ID="pnlyawayiwredakte" runat="server" Visible="False">
                <div class="altbawliqlar">Şəhər, qəsəbə, kənd redaktə et:</div>
                <div>&nbsp;</div>
                <div>
                    <table class="auto-style1">
                        <tr>
                            <td class="auto-style60">&nbsp;</td>
                            <td class="auto-style62">Rayon, şəhər:</td>
                            <td>
                                <asp:DropDownList ID="ddlyawayiwredreg" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlyawayiwredreg_SelectedIndexChanged">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style60">&nbsp;</td>
                            <td class="auto-style62">&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style60">&nbsp;</td>
                            <td class="auto-style62">Şəhər,qəsəbə,kənd:</td>
                            <td>
                                <asp:DropDownList ID="ddlyawayiwredakte" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlyawayiwredakte_SelectedIndexChanged">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style60">&nbsp;</td>
                            <td class="auto-style62">&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style60">&nbsp;</td>
                            <td class="auto-style62">Status:</td>
                            <td>
                                <asp:DropDownList ID="ddlyawayiwtype" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlyawayiwtype_SelectedIndexChanged">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style60">&nbsp;</td>
                            <td class="auto-style62">&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style60">&nbsp;</td>
                            <td class="auto-style62">Şəhər, qəsəbə, kənd:</td>
                            <td>
                                <asp:TextBox ID="txtyawayiwredakte" runat="server" Width="150px"></asp:TextBox>
                            </td>
                        </tr>
                                                <tr>
                            <td class="auto-style60">&nbsp;</td>
                            <td class="auto-style62">&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                                                                        <tr>
                            <td class="auto-style60">&nbsp;</td>
                            <td class="auto-style62">
                                <asp:Button ID="btnyawayiwredakte" runat="server" OnClick="btnyawayiwredakte_Click" Text="Yadda saxla" Width="100px" />
                                                                            </td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                </div>
            
                
                <div class="message"><asp:Label ID="lblyawayiwredakte" runat="server"></asp:Label>
                </div>
        </asp:Panel>








  <asp:Panel ID="pnlyawayiwsil" runat="server" Visible="False">
      <div class="altbawliqlar">Şəhər, qəsəbə, kənd sil:</div>
            <div>&nbsp;</div>
               <div>
                   <table class="auto-style1">
                       <tr>
                           <td class="auto-style68">&nbsp;</td>
                           <td class="auto-style71">Rayon, şəhər:</td>
                           <td>
                               <asp:DropDownList ID="ddlregyawayiwsil" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlregyawayiwsil_SelectedIndexChanged">
                               </asp:DropDownList>
                           </td>
                       </tr>
                       <tr>
                           <td class="auto-style68">&nbsp;</td>
                           <td class="auto-style71">&nbsp;</td>
                           <td>&nbsp;</td>
                       </tr>
                       <tr>
                           <td class="auto-style68">&nbsp;</td>
                           <td class="auto-style71">Şəhər,qəsəbə,kənd:</td>
                           <td>
                               <asp:DropDownList ID="ddlyawayiwsil" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlyawayiwsil_SelectedIndexChanged">
                               </asp:DropDownList>
                           </td>
                       </tr>
                       <tr>
                           <td class="auto-style68">&nbsp;</td>
                           <td class="auto-style71">&nbsp;</td>
                           <td>&nbsp;</td>
                       </tr>
                       <tr>
                           <td class="auto-style68">&nbsp;</td>
                           <td class="auto-style71">
                               <asp:Button ID="btnyawayiwsil" runat="server" OnClick="btnyawayiwsil_Click" Text="Sil" Width="100px" />
                           </td>
                           <td>&nbsp;</td>
                       </tr>

                   </table>
      </div>
                
                <div class="message"><asp:Label ID="lblyawayiwsil" runat="server"></asp:Label>
                </div>



       
                     
        <div id="Div1" style="display: none;" class="popupConfirmation">
            <div class="popup_Container">
                <div class="popup_Titlebar" id="PopupHeader2">
                    <div class="TitlebarLeft">Diqqətli olun!!!</div>
                   <%-- <div class="TitlebarRight" onclick="cancel();"></div>--%>
                </div>
                <div class="popup_Body">
                    Silməyə əminsinizmi?
                </div>
                <div class="popup_Buttons">
                 <asp:Button ID="btnyayiw" runat="server" Text="Bəli" OnClick="btnyayiw_Click" />
                 <input id="Button5" value="Xeyr" type="button" onclick="cancel();" />
                    
                </div>
            </div>
        </div>
        </asp:Panel>


</asp:Panel>
         

</asp:Content>

