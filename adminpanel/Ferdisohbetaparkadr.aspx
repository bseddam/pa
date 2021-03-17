<%@ Page Title="" Language="C#" MasterPageFile="~/adminpanel/TesnifatMasterPage.master" AutoEventWireup="true" CodeFile="Ferdisohbetaparkadr.aspx.cs" Inherits="adminpanel_Ferdisohbetaparkadr" %>



<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     
    <div>
               <table style="width: 100%">

            <tr>
                <td class="elaveet" style="width: 93px">&nbsp;</td>
                <td style="width: 106px" class="elaveet">
                    &nbsp;</td>
                <td class="elaveet" style="width: 276px">
                    <asp:Button ID="btnistismar" runat="server" Text="İcra orqanları" Width="150px" OnClick="btnistismar_Click" />
                </td>
                <td class="elaveet" style="width: 162px">
                    <asp:Button ID="btnobyekt" runat="server" Text="Vəzifələr" Width="150px" OnClick="btnobyekt_Click" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    </div>

    <asp:Panel ID="pnlbirinci" Visible="false" runat="server">

        <div>

        <table style="width: 100%">

             <tr>
                <td class="elaveet" style="width: 36px">&nbsp;</td>
                <td style="width: 198px" class="elaveet">
                   </td>
                <td class="elaveet" style="width: 184px">
                  </td>
                <td class="elaveet" style="width: 186px">
                 </td>
                <td>
                 </td>
            </tr>

            <tr>
                <td class="elaveet" style="width: 36px">&nbsp;</td>
                <td style="width: 198px" class="elaveet">
                    <asp:Button ID="btnelave" runat="server" OnClick="btnelave_Click" Text="Əlavə et" Width="150px" />
                </td>
                <td class="elaveet" style="width: 184px">
                    <asp:Button ID="btnredakte" runat="server" OnClick="btnredakte_Click" Text="Redaktə et" Width="150px" />
                </td>
                <td class="elaveet" style="width: 186px">
                    <asp:Button ID="btnsil" runat="server" OnClick="btnsil_Click" Text="Sil" Width="150px" />
                </td>
                <td>
                    <asp:Button ID="btngeri" runat="server" OnClick="btngeri_Click" Text="Geri" Width="150px" />
                </td>
            </tr>
        </table>
         <asp:Panel ID="pnlinsertmeqsed" runat="server"  Visible="False">
       <div class="altbawliqlar">İcra orqanı əlavə et</div>
       <div>&nbsp;
           <table style="width: 100%">
                       <tr>
                   <td style="width: 53px">&nbsp;</td>
                   <td style="width: 390px"> Təsnifatda yeri:</td>
                   <td></td>
               </tr>
               <tr>
                   <td style="width: 53px">&nbsp;</td>
                   <td style="width: 390px">
                       <asp:DropDownList ID="ddlmeqsedsort" runat="server">
                       </asp:DropDownList>
                   </td>
                   <td>&nbsp;</td>
               </tr>
                <tr>
                   <td style="width: 53px">&nbsp;</td>
                   <td style="width: 390px"></td>
                   <td></td>
               </tr>
                     <tr>
                   <td style="width: 53px">&nbsp;</td>
                   <td style="width: 390px">Yeni icra orqanı:</td>
                   <td></td>
               </tr>
                     <tr>
                   <td style="width: 53px">&nbsp;</td>
                   <td style="width: 390px">
                       <asp:TextBox ID="txtmeqsedelave" runat="server" Width="640px" TextMode="MultiLine"></asp:TextBox>
                         </td>
                   <td></td>
               </tr>
      <tr>
                   <td style="width: 53px">&nbsp;</td>
                   <td style="width: 390px"></td>
                   <td></td>
               </tr>
                     <tr>
                   <td style="width: 53px">&nbsp;</td>
                   <td style="width: 390px">
                       <asp:Button ID="btnmeqsedelave" runat="server" OnClick="btnmeqsedelave_Click" Text="Əlavə et" Width="100px" />
                         </td>
                   <td></td>
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
                   <td style="width: 301px">
                    </td>
                   <td>
                     </td>
               </tr>
               <tr>
                   <td class="elaveet" style="width: 171px">&nbsp;</td>
                   <td style="width: 301px">
                       <asp:Button ID="btnmeqsedred" runat="server" OnClick="btnmeqsedred_Click" Text="Mətni dəyiş" Width="200px" />
                   </td>
                   <td>
                       <asp:Button ID="btntesnyeri" runat="server" OnClick="btntesnyeri_Click" Text="Yerini dəyiş" Width="200px" />
                   </td>
               </tr>
           </table>
            <asp:Panel ID="pnlmqsd" Visible="false" runat="server">
           <div class="altbawliqlar">
               İcra orqanı redaktə et</div>
           <div>
               &nbsp;</div>
           <div>   <table style="width: 100%">
                       <tr>
                   <td style="width: 57px">&nbsp;</td>
                   <td style="width: 81px"></td>
                   <td style="width: 567px"></td>        
               </tr>
               <tr>
                   <td style="width: 57px">&nbsp;</td>
                   <td style="width: 81px">İcra orqanı:</td>
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
                   <td style="width: 81px; height: 40px;"> Düzəliş:</td>
                   <td style="width: 567px; height: 40px;">
    
                       <asp:TextBox ID="txtmeqsedredakte" runat="server" Width="529px" TextMode="MultiLine"></asp:TextBox>
    
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
                <td>İcra orqanı:</td>
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
             <div class="altbawliqlar">İcra orqanı sil</div>
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


    </asp:Panel>

     







           <asp:Panel ID="pnlikinci" runat="server"  Visible="False">
         


               <table style="width: 100%">

             <tr>
                <td class="elaveet" style="width: 36px">&nbsp;</td>
                <td style="width: 198px" class="elaveet">
                   </td>
                <td class="elaveet" style="width: 184px">
                  </td>
                <td class="elaveet" style="width: 186px">
                 </td>
                <td>
                 </td>
            </tr>

            <tr>
                <td class="elaveet" style="width: 36px">&nbsp;</td>
                <td style="width: 198px" class="elaveet">
                   <asp:Button ID="btnihbelaved" runat="server" Text="Əlavə et" Width="150px" OnClick="btnihbelaved_Click" />

                </td>
                <td class="elaveet" style="width: 184px">
                    <asp:Button ID="btnihbredakted" runat="server" OnClick="btnihbredakted_Click" Text="Redaktə et" Width="150px" />
                </td>
                <td class="elaveet" style="width: 186px">
                    <asp:Button ID="btnihbsild" runat="server" OnClick="btnihbsild_Click" Text="Sil" Width="150px" />
                </td>
                <td>
                    <asp:Button ID="btngeriikinci" runat="server" OnClick="btnelavegeri_Click" Text="Geri" Width="150px" />
                </td>
            </tr>
        </table>



        



            <asp:Panel ID="pnlihbelave" runat="server" Visible="False">
                <div class="altbawliqlar">Vəzifələri əlavə et:</div>
                <div>&nbsp;</div>

                <table style="width: 767px">
                    <tr>
                        <td style="width: 15px" ></td>
                        <td >İcra orqanı</td>
                        
                    </tr>

                       <tr>
                        <td style="width: 15px" ></td>
                        <td >
                            <asp:DropDownList ID="ddlihbrayonelave" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlihbrayonelave_SelectedIndexChanged">
                            </asp:DropDownList>
                           </td>
                    </tr>
                             <tr>
                        <td style="width: 15px; height: 21px;" ></td>
                        <td style="height: 21px" >&nbsp;
                           </td>
                    </tr>

                       <tr>
                        <td style="width: 15px" ></td>
                        <td >Təsnifatda yeri: </td>
                        
                    </tr>
                       <tr>
                        <td style="width: 15px" ></td>
                        <td >
                            <asp:DropDownList ID="ddlmovqe" runat="server" AutoPostBack="True" Enabled="False" OnSelectedIndexChanged="ddlmovqe_SelectedIndexChanged">
                            </asp:DropDownList>
                           </td>
                        
                    </tr>
                                    <tr>
                        <td style="width: 15px; height: 19px;" ></td>
                        <td style="height: 19px" >&nbsp;</td>
                    </tr>
                          <tr>
                        <td style="width: 15px" ></td>
                        <td >
                              Vəzifə</td>
                    </tr>
                                     <tr>
                        <td style="width: 15px; height: 19px;" ></td>
                        <td style="height: 19px" >
                            <asp:TextBox ID="txtihbelave" runat="server" Enabled="False" TextMode="MultiLine" Width="640px"></asp:TextBox>
                           </td>
                    </tr>
                                     <tr>
                        <td style="width: 15px; height: 19px;" ></td>
                        <td style="height: 19px" >&nbsp;</td>
                    </tr>
                                     <tr>
                        <td style="width: 15px; height: 19px;" ></td>
                        <td style="height: 19px" >
                            <asp:Button ID="btnihbelave" runat="server" Enabled="False" OnClick="btnihbelave_Click" Text="Əlavə et" Width="100px" />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="lblihbelave" runat="server"></asp:Label>
                           </td>
                    </tr>
                </table>

                <div class="message">
                </div>
        </asp:Panel>
                











           <asp:Panel ID="pnldeyis" runat="server"  Visible="False">   
           <table style="width: 100%">
               <tr>
                   <td class="elaveet" style="width: 171px">&nbsp;</td>
                   <td style="width: 301px">
                    </td>
                   <td>
                     </td>
               </tr>
               <tr>
                   <td class="elaveet" style="width: 171px">&nbsp;</td>
                   <td style="width: 301px">
                       <asp:Button ID="btnmetndetish" runat="server" Text="Mətni dəyish" Width="200px" OnClick="btnmetndetish_Click" />
                   </td>
                   <td>
                       <asp:Button ID="btnyerdeyiw" runat="server" Text="Yerini dəyish" Width="200px" OnClick="btnyerdeyiw_Click" />
                   </td>
               </tr>
           </table>


     <asp:Panel ID="pnlyerinideyiw" runat="server" Visible="False">
                <div class="altbawliqlar">Yerini dəyiş:</div>
            <div>&nbsp;</div>
                            <table style="width: 767px">
                    <tr>
                        <td style="width: 55px" ></td>
                        <td >İcra orqanı</td>
                    </tr>
                       <tr>
                        <td style="width: 55px" ></td>
                        <td >
                            <asp:DropDownList ID="ddlicra" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlicra_SelectedIndexChanged">
                            </asp:DropDownList>
                           </td>
                    </tr>
                             <tr>
                        <td style="width: 55px; height: 35px;" ></td>
                        <td style="height: 35px" >&nbsp;
                           </td>
                    </tr>
                       <tr>
                        <td style="width: 55px" ></td>
                        <td >Vəzifə</td>
                    </tr>
                       <tr>
                        <td style="width: 55px" ></td>
                        <td >
                            <asp:DropDownList ID="ddlvezife" runat="server">
                            </asp:DropDownList>
                           </td>
                    </tr>
                                    <tr>
                        <td style="width: 55px; height: 34px;" ></td>
                        <td style="height: 34px" >&nbsp;
                           </td>
                    </tr>
                          <tr>
                        <td style="width: 55px" ></td>
                        <td >
                            Təsnifatda yeri</td>
                    </tr>
                        <tr>
                        <td style="width: 55px" ></td>
                        <td >
                            <asp:DropDownList ID="ddlyer" runat="server">
                            </asp:DropDownList>
                            </td>
                    </tr>
                    <tr>
                        <td style="width: 55px; height: 12px;" ></td>
                        <td style="height: 12px" >&nbsp;
                           </td>
                    </tr>
                      <tr>
                        <td style="width: 55px; height: 12px;" ></td>
                        <td style="height: 12px" ><asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Yadda saxla" Width="100px" />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label1" runat="server"></asp:Label>
                           </td>
                    </tr>
                </table>


                
                <div class="message">
                </div>
        </asp:Panel>


            <asp:Panel ID="pnlihbredakte" runat="server" Visible="False">
                <div class="altbawliqlar">Mətni redaktə et:</div>
            <div>&nbsp;</div>


                            <table style="width: 767px">
                    <tr>
                        <td style="width: 55px" ></td>
                        <td >İcra orqanı</td>
                        
                    </tr>

                       <tr>
                        <td style="width: 55px" ></td>
                        <td >
                            <asp:DropDownList ID="ddlihbrayonredakte" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlihbrayonredakte_SelectedIndexChanged">
                            </asp:DropDownList>
                           </td>
                    </tr>
                             <tr>
                        <td style="width: 55px; height: 35px;" ></td>
                        <td style="height: 35px" >&nbsp;
                           </td>
                    </tr>

                       <tr>
                        <td style="width: 55px" ></td>
                        <td >Vəzifə</td>
                        
                    </tr>
                       <tr>
                        <td style="width: 55px" ></td>
                        <td >
                            <asp:DropDownList ID="ddlihbredakte" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlihbredakte_SelectedIndexChanged">
                            </asp:DropDownList>
                           </td>
                        
                    </tr>
                                    <tr>
                        <td style="width: 55px; height: 34px;" ></td>
                        <td style="height: 34px" >&nbsp;
                           </td>
                    </tr>
                          <tr>
                        <td style="width: 55px" ></td>
                        <td >
                            Düzəliş:</td>
                        
                    </tr>
                        <tr>
                        <td style="width: 55px" ></td>
                        <td >
                            <asp:TextBox ID="txtihbredakte" runat="server" Width="640px" TextMode="MultiLine"></asp:TextBox>
                            </td>
                    </tr>
                    <tr>
                        <td style="width: 55px; height: 12px;" ></td>
                        <td style="height: 12px" >&nbsp;
                           </td>
                    </tr>
                      <tr>
                        <td style="width: 55px; height: 12px;" ></td>
                        <td style="height: 12px" ><asp:Button ID="btnihbredakte" runat="server" OnClick="btnihbredakte_Click" Text="Yadda saxla" Width="100px" />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="lblihbredakte" runat="server"></asp:Label>
                           </td>
                    </tr>
                </table>


                
                <div class="message">
                </div>
        </asp:Panel>


    </asp:Panel>



              <asp:Panel ID="pnlihbsil" runat="server"  Visible="False">
                  <div class="altbawliqlar">Vəzifələri sil:</div>
         <div>&nbsp;</div>

         <table style="width: 767px">
                    <tr>
                        <td style="width: 55px" ></td>
                        <td style="width: 432px" >İcra orqanı</td>
                        
                    </tr>

                       <tr>
                        <td style="width: 55px" ></td>
                        <td style="width: 432px" >
                            <asp:DropDownList ID="ddlihbraysil" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                            </asp:DropDownList>
                           </td>
                    </tr>
                             <tr>
                        <td style="width: 55px; height: 35px;" ></td>
                        <td style="height: 35px; width: 432px;" >&nbsp;
                           </td>
                    </tr>

                       <tr>
                        <td style="width: 55px" ></td>
                        <td style="width: 432px" >Vəzifə</td>
                        
                    </tr>
                       <tr>
                        <td style="width: 55px" ></td>
                        <td style="width: 432px" >
                            <asp:DropDownList ID="ddlihbsil" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlihbsil_SelectedIndexChanged">
                            </asp:DropDownList>
                           </td>
                        
                    </tr>
                                    <tr>
                        <td style="width: 55px; height: 36px;" ></td>
                        <td style="height: 36px; width: 432px;" >&nbsp;
                           </td>
                    </tr>
                          <tr>
                        <td style="width: 55px" ></td>
                        <td style="width: 432px" >
                            <asp:Button ID="btnihbsil" runat="server" OnClick="btnihbsil_Click" Text="Sil" Width="100px" Enabled="False" />
                              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="lblihbsil" runat="server"></asp:Label>
                              </td>
                        
                    </tr>
                </table>




                   

                <div class="message">
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
    
</asp:Content>

