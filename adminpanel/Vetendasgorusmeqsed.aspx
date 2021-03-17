<%@ Page Title="" Language="C#" MasterPageFile="~/adminpanel/TesnifatMasterPage.master" AutoEventWireup="true" CodeFile="Vetendasgorusmeqsed.aspx.cs" Inherits="adminpanel_Vetendasgorusmeqsed" %>



<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <div>

        <table style="width: 100%">

            <tr>
                <td class="elaveet" style="width: 93px">&nbsp;</td>
                <td style="width: 179px" class="elaveet">
                    <asp:Button ID="btnelave" runat="server" OnClick="btnelave_Click" Text="Əlavə et" Width="100px" />
                </td>
                <td class="elaveet" style="width: 171px">
                    <asp:Button ID="btnredakte" runat="server" OnClick="btnredakte_Click" Text="Redaktə et" Width="100px" />
                </td>
                <td class="elaveet" style="width: 162px">
                    <asp:Button ID="btnsil" runat="server" OnClick="btnsil_Click" Text="Sil" Width="100px" />
                </td>
                <td>
                    <asp:Button ID="btngeri" runat="server" OnClick="btngeri_Click" Text="Geri" Width="100px" Enabled="False" />
                </td>
            </tr>
        </table>
         <asp:Panel ID="pnlinsertmeqsed" runat="server"  Visible="False">
       <div class="altbawliqlar">Vətəndaşlarla keçirilmiş görüşün məqsədinə əlavə et</div>
       <div>&nbsp;
           <table style="width: 100%">
                       <tr>
                   <td style="width: 53px">&nbsp;</td>
                   <td style="width: 390px"> 
                       Təsnifatda yeri:</td>
                   
               </tr>
               <tr>
                   <td style="width: 53px; height: 22px;"></td>
                   <td style="width: 390px; height: 22px;">
                       <asp:DropDownList ID="ddlmeqsedsort" runat="server">
                       </asp:DropDownList>
                   </td>
                   
               </tr>
                <tr>
                   <td style="width: 53px">&nbsp;</td>
                   <td style="width: 390px">
                     
                       &nbsp;</td>
                   
               </tr>
                <tr>
                   <td style="width: 53px; height: 22px;"></td>
                   <td style="width: 390px; height: 22px;">
                       <asp:TextBox ID="txtmeqsedelave" runat="server" Width="230px"></asp:TextBox>
                   </td>
                   
               </tr>
                               <tr>
                   <td style="width: 53px">&nbsp;</td>
                   <td style="width: 390px">
                     
                       &nbsp;</td>
                   
               </tr>
                               <tr>
                   <td style="width: 53px">&nbsp;</td>
                   <td style="width: 390px">
                     
                       <asp:Button ID="btnmeqsedelave" runat="server" OnClick="btnmeqsedelave_Click" Text="Əlavə et" Width="100px" />
                                   </td>
                   
               </tr>
           </table>
        </div>
       <div class="message">
                    <asp:Label ID="lblmeqsedelave" runat="server"></asp:Label>
                </div>
             </asp:Panel>

       
       <asp:Panel ID="pnlupdatemeqsed" runat="server"  Visible="False">

           <table style="width: 100%">
               <tr>
                   <td class="elaveet" style="width: 171px">&nbsp;</td>
                   <td style="width: 355px">
                    </td>
                   <td>
                     </td>
               </tr>
               <tr>
                   <td class="elaveet" style="width: 171px">&nbsp;</td>
                   <td style="width: 355px">
                       <asp:Button ID="btnmeqsedred" runat="server" OnClick="btnmeqsedred_Click" Text="Mətni dəyiş" Width="200px" />
                   </td>
                   <td>
                       <asp:Button ID="btntesnyeri" runat="server" OnClick="btntesnyeri_Click" Text="Yerini dəyiş" Width="200px" />
                   </td>
               </tr>
           </table>


           <asp:Panel ID="pnlmqsd" Visible="false" runat="server">
           <div class="altbawliqlar">
               Vətəndaşlarla keçirilmiş görüşün məqsədini redaktə et</div>
           <div>
               &nbsp;</div>
           <div>   <table style="width: 100%">
                       <tr>
                   <td style="width: 57px">&nbsp;</td>
                   <td style="width: 81px">
                     
                   </td>
                   <td style="width: 567px">
    
                   </td>
                             
               </tr>
               <tr>
                   <td style="width: 57px">&nbsp;</td>
                   <td style="width: 81px">
                       Məqsəd:</td>
                   <td style="width: 567px">
                       <asp:DropDownList ID="ddlmeqsedredakte" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlmeqsedredakte_SelectedIndexChanged">
                       </asp:DropDownList>
                   </td>
               </tr>
                <tr>
                   <td style="width: 57px">&nbsp;</td>
                   <td style="width: 81px"> </td>
                   <td style="width: 567px"> </td>
               </tr>
                   <tr>
                   <td style="width: 57px; height: 40px;"></td>
                   <td style="width: 81px; height: 40px;">
                     
                       Düzəliş:</td>
                   <td style="width: 567px; height: 40px;">
    
                       <asp:TextBox ID="txtmeqsedredakte" runat="server" Width="230px"></asp:TextBox>
    
                   </td>
               </tr>
                       <tr>
                   <td style="width: 57px">&nbsp;</td>
                   <td style="width: 81px">
                     
                       &nbsp;</td>
                   <td style="width: 567px">  &nbsp;</td>
                   
               </tr>
                 <tr>
                   <td style="width: 57px">&nbsp;</td>
                   <td style="width: 81px">
                     
                       <asp:Button ID="btnsaxlaredakte" runat="server" Height="26px" Text="Yadda saxla" Width="100px" OnClick="btnsaxlaredakte_Click" />
                     </td>
                   <td style="width: 567px"> &nbsp;</td>
               </tr>
           </table></div>
           <div class="message">
                    <asp:Label ID="lblmeqsedredakte" runat="server"></asp:Label>
                </div>
           </asp:Panel>


           <asp:Panel ID="pnlyerdeyiw" Visible="false" runat="server">
            
                  <div class="altbawliqlar">
                      Təsnifatda yerini redaktə et</div>
           <table style="width: 100%">
                      <tr>
                <td style="width: 56px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
             <tr>
                <td style="width: 56px">&nbsp;</td>
                <td>Məqsəd:</td>
            </tr>
            <tr>
                <td style="width: 56px">&nbsp;</td>
                <td>
                    <asp:DropDownList ID="ddlobject" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
              <tr>
                <td style="width: 56px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
              <tr>
                <td style="width: 56px">&nbsp;</td>
                <td>
                    Təsnifatda yeri:</td>
            </tr>
                     <tr>
                <td style="width: 56px">&nbsp;</td>
                <td>
                    <asp:DropDownList ID="ddlyeri" runat="server">
                    </asp:DropDownList>
                         </td>
            </tr>
                             <tr>
                <td style="width: 56px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
                     <tr>
                <td style="width: 56px">&nbsp;</td>
                <td>
                    <asp:Button ID="btnyerinideyiw" runat="server" Text="Yadda saxla" OnClick="btnyerinideyiw_Click" Width="100px" /></td>
            </tr>
        </table>
            <div class="message">
                    <asp:Label ID="lblyerdeyiw" runat="server"></asp:Label>
                </div>
        </asp:Panel>

           </asp:Panel>




          <asp:Panel ID="pnlsil" runat="server"  Visible="False">
             <div class="altbawliqlar">Vətəndaşlarla keçirilmiş görüşün məqsədi sil</div>
        <div>&nbsp;</div>
                     <div>&nbsp;<table style="width: 100%">
                       <tr>
                   <td style="width: 53px">&nbsp;</td>
                   <td style="width: 358px"> 
                   </td>
                   <td> </td>
               
               </tr>
               <tr>
                   <td style="width: 53px">&nbsp;</td>
                   <td style="width: 358px">
                       <asp:DropDownList ID="ddlmeqsedsil" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlmeqsedsil_SelectedIndexChanged">
                       </asp:DropDownList>
                   </td>
                   <td>
                       &nbsp;</td>
                    
               </tr>
                <tr>
                   <td style="width: 53px">&nbsp;</td>
                   <td style="width: 358px">    </td>
                   <td> </td>
               </tr>
                               <tr>
                   <td style="width: 53px">&nbsp;</td>
                   <td style="width: 358px">    
                       <asp:Button ID="btnmeqsedsil" runat="server" OnClick="btnmeqsedsil_Click" Text="Sil" Width="100px" Enabled="False" />
                                   </td>
                   <td> </td>
               </tr>
           </table>
        </div>
                  <div class="message">
                    <asp:Label ID="lblmeqsedsil" runat="server"></asp:Label>
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
   </div>
</asp:Content>

