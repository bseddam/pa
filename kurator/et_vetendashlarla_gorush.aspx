<%@ Page Title="" Language="C#" MasterPageFile="~/kurator/KuratorhisseMasterPage.master" AutoEventWireup="true" CodeFile="et_vetendashlarla_gorush.aspx.cs" Inherits="kurator_et_vetendashlarla_gorush" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script>
      <!--
    function isNumberKey(evt) {
        var charCode = (evt.which) ? evt.which : event.keyCode
        if (charCode > 31 && (charCode < 48 || charCode > 57)) {
            return false;
        }
        return true;
    }
    //-->
    </script>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 49px;
        }

        .auto-style3 {
            width: 256px;
        }

        .auto-style4 {
            width: 292px;
        }

        #div1 {
            height: 398px;
        }

        #div2 {
            height: 147px;
        }

        #div3 {
            height: 414px;
        }

        .auto-style5 {
            width: 100%;
            height: 227px;
        }

        .auto-style6 {
            width: 100%;
        }

        .auto-style9 {
            width: 693px;
            height: 33px;
        }

        .auto-style11 {
            height: 33px;
        }

        .auto-style14 {
            height: 36px;
        }

        .auto-style17 {
            height: 34px;
        }

        .auto-style18 {
            height: 228px;
        }

        .auto-style21 {
            height: 73px;
        }

        .auto-style25 {
            width: 108px;
            height: 73px;
        }

        .auto-style29 {
            width: 634px;
            height: 73px;
        }

        .auto-style37 {
            width: 214px;
            height: 33px;
        }

        .auto-style38 {
            width: 214px;
            height: 36px;
        }

        .auto-style40 {
            width: 214px;
            height: 34px;
        }

        .auto-style41 {
            width: 214px;
            height: 73px;
        }

        .auto-style42 {
            width: 449px;
            height: 33px;
        }

        .auto-style43 {
            width: 449px;
            height: 36px;
        }

        .auto-style44 {
            width: 449px;
            height: 34px;
        }

        .auto-style45 {
            width: 449px;
            height: 73px;
        }

        .auto-style48 {
            width: 498px;
            height: 59px;
        }

        .auto-style49 {
            width: 498px;
            height: 8px;
        }

        .auto-style50 {
            width: 498px;
            height: 73px;
        }

        .auto-style52 {
            width: 204px;
            height: 59px;
        }

        .auto-style53 {
            width: 204px;
            height: 8px;
        }

        .auto-style54 {
            width: 204px;
            height: 73px;
        }

        .auto-style55 {
            width: 204px;
            height: 62px;
        }

        .auto-style56 {
            width: 498px;
            height: 62px;
        }

        .auto-style57 {
            height: 62px;
        }

        .auto-style58 {
            height: 59px;
        }

        .auto-style59 {
            height: 8px;
        }

        .auto-style60 {
            width: 108px;
            height: 42px;
        }

        .auto-style61 {
            width: 634px;
            height: 42px;
        }

        .auto-style62 {
            height: 42px;
        }

        .auto-style63 {
            width: 108px;
            height: 44px;
        }

        .auto-style64 {
            width: 634px;
            height: 44px;
        }

        .auto-style65 {
            height: 44px;
        }

        .auto-style69 {
            width: 214px;
            height: 15px;
        }

        .auto-style70 {
            width: 449px;
            height: 32px;
        }

        .auto-style72 {
            width: 214px;
            height: 17px;
        }

        .auto-style73 {
            width: 449px;
            height: 32px;
        }

        .auto-style75 {
            width: 108px;
            height: 19px;
        }

        .auto-style76 {
            width: 634px;
            height: 35px;
        }

        .auto-style77 {
            height: 19px;
        }

        .auto-style78 {
            width: 108px;
            height: 10px;
        }

        .auto-style79 {
            width: 634px;
            height: 35px;
        }

        .auto-style80 {
            height: 10px;
        }

        .auto-style81 {
            width: 108px;
            height: 17px;
        }

        .auto-style82 {
            width: 634px;
            height: 35px;
        }

        .auto-style83 {
            height: 17px;
        }

        .auto-style84 {
            height: 15px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div style="width: 1024px; height: auto; margin-left: auto; margin-right: auto">
        <div>
            <table style="width: 100%;">
                <tr>
                    <td style="width: 880px;">&nbsp;</td>
                    <td>
                        <asp:Button ID="btngeri" runat="server" Text="Geri" Width="120px" OnClick="btngeri_Click" />
                    </td>
                </tr>
            </table>
        </div>
        <table class="auto-style1">
            <tr>

                <td>
                    <table class="auto-style1">
                        <tr>
                            <td class="auto-style3">
                                <asp:Button ID="Button1" runat="server" Height="41px" Text="Nəzərdə tutulmuş vətəndaşlarla fərdi görüşlər" Width="395px" OnClick="Button1_Click" Font-Size="13pt" BorderColor="#0033CC" />
                            </td>
                            <td class="auto-style4">
                                <asp:Button ID="Button2" runat="server" Height="41px" Text="Fərdi söhbət nəzərdə tutulmuş kadrlar" Width="327px" OnClick="Button2_Click" BorderColor="Blue" Font-Size="13pt" Style="margin-left: 0px" />
                            </td>
                            <td>
                                <asp:Button ID="Button3" runat="server" Height="41px" Text="Digər görüşlər" Width="281px" OnClick="Button3_Click" BorderColor="#0033CC" Font-Size="13pt" Style="margin-left: 0px" Visible="False" />
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr style="height: 500px">
                <td>
                    <div id="div1" runat="server" style="margin-top: auto; height: auto;">

                        <table class="auto-style5">
                            <tr>
                                <td class="auto-style18">
                                    <table class="auto-style6">
                                        <tr>
                                            <td class="auto-style37"></td>
                                            <td class="auto-style42">
                                                <table class="auto-style9">
                                                    <tr>
                                                        <td style="width: 100px; text-align: right">Ad
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="txt_name" runat="server" Height="20px" Width="150px"></asp:TextBox>
                                                        </td>
                                                        <td style="width: 100px; text-align: right">Soyad
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="txt_sname" runat="server" Height="20px" Width="150px"></asp:TextBox>
                                                        </td>
                                                        <td style="width: 50px; text-align: center">və
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="txt_count" runat="server" onkeypress="return isNumberKey(event)" Height="20px" Width="150px" Text="0"></asp:TextBox>
                                                        </td>
                                                        <td style="width: 60px">nəfər
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                            <td class="auto-style11">&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style72">Yaşayış məntəqəsi </td>
                                            <td class="auto-style73">
                                                <asp:DropDownList ID="ddlyasmen" runat="server" AutoPostBack="True" CausesValidation="True" Height="30px" Width="692px"></asp:DropDownList>
                                                <asp:TextBox ID="txt_c1" runat="server" Font-Names="Arial" Height="26px" TextMode="SingleLine" Width="688px" Visible="False"></asp:TextBox>
                                            </td>
                                            <td class="auto-style83">
                                                <asp:CheckBox ID="CheckBox11" Visible="false" runat="server" Text="Digər" AutoPostBack="True" OnCheckedChanged="CheckBox11_CheckedChanged" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style38">Ünvan </td>
                                            <td class="auto-style43">
                                                <asp:TextBox ID="txt_unvan" runat="server" Font-Names="Arial" Height="43px" TextMode="MultiLine" Width="687px"></asp:TextBox>
                                            </td>
                                            <td class="auto-style14">&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style69">Məqsəd  </td>
                                            <td class="auto-style70">
                                                <asp:DropDownList ID="ddlmeqsed" runat="server" AutoPostBack="True" CausesValidation="True"
                                                    Height="30px" Width="692px"
                                                    OnSelectedIndexChanged="ComboBox1_SelectedIndexChanged">
                                                </asp:DropDownList>
                                                <asp:TextBox ID="txt_c2" runat="server" Font-Names="Arial" Height="26px" TextMode="SingleLine" Width="688px" Visible="False"></asp:TextBox>
                                            </td>
                                            <td class="auto-style84">
                                                <asp:CheckBox ID="CheckBox12"  Visible="false" runat="server" Text="Digər" AutoPostBack="True" OnCheckedChanged="CheckBox12_CheckedChanged" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style40">Müraciətdə qaldırılmış məsələnin qısa məzmunu</td>
                                            <td class="auto-style44">
                                                <asp:TextBox ID="txt_mq_mesele" runat="server" Font-Names="Arial" Height="43px" TextMode="MultiLine" Width="687px"></asp:TextBox>
                                            </td>
                                            <td class="auto-style17"></td>
                                        </tr>
                                        <asp:Panel ID="pnlgozlenilennetice" Visible="false" runat="server">
                                            <tr>
                                                <td class="auto-style40">Gözlənilən nəticə</td>
                                                <td class="auto-style44">
                                                    <asp:TextBox ID="txt_g_netice" runat="server" Font-Names="Arial" Height="43px" TextMode="MultiLine" Width="687px"></asp:TextBox>
                                                </td>
                                                <td class="auto-style17"></td>
                                            </tr>
                                        </asp:Panel>
                                        <tr>
                                            <td class="auto-style41"></td>
                                            <td class="auto-style45">
                                                <asp:Button ID="Button4" runat="server" Height="34px" OnClick="Button4_Click" Text="Yadda saxla" Width="117px" BorderColor="#0033CC" />
                                            </td>
                                            <td class="auto-style21">&nbsp;</td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>


                        <div>
                            &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lblmsg" runat="server"></asp:Label>
                            <br />
                        </div>
                        <asp:DataList ID="GridView1" runat="server" ForeColor="#333333" Width="1024px">
                            <AlternatingItemStyle BackColor="White" />
                            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <HeaderTemplate>
                                <table style="width: 100%;">
                                    <tr>
                                        <td style="padding-left: 3px; text-align: left; width: 12%; white-space: normal;">Ad</td>
                                        <td style="padding-left: 3px; text-align: left; width: 15%; white-space: normal;">Yaşayış məntəqəsi</td>
                                        <td style="padding-left: 3px; text-align: left; width: 15%; white-space: normal;">Ünvan</td>
                                        <td style="padding-left: 3px; text-align: center; width: 7%; white-space: normal;">Nəfər</td>
                                        <td style="padding-left: 3px; text-align: left; width: 10%; white-space: normal;">Məqsəd</td>
                                        <td style="padding-left: 3px; text-align: left; width: 12%; white-space: normal;">Müraciətdə
                                            <br />
                                            qaldıracağı məsələ</td>
                                        <%-- <td style="padding-left:3px;text-align:left;width:12%;white-space: normal;">Gözlənilən nəticə</td>--%>
                                        <td style="padding-left: 3px; text-align: left; width: 7%; white-space: normal;">Düzəliş</td>
                                        <td style="padding-left: 3px; text-align: left; width: 4%; white-space: normal;">Sil</td>
                                    </tr>
                                </table>
                            </HeaderTemplate>
                            <ItemStyle />
                            <ItemTemplate>
                                <table style="border-bottom-style: dotted; border-bottom-width: thin; width: 100%; border-left-style: dotted; border-left-width: thin; border-right-style: dotted; border-right-width: thin;">
                                    <tr>
                                        <td style="padding-left: 3px; text-align: left; width: 12%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><%#Eval("Name") %></td>
                                        <td style="padding-left: 3px; text-align: left; width: 15%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><%#Eval("Living_point") %></td>
                                        <td style="padding-left: 3px; text-align: left; width: 15%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><%#Eval("Adres") %></td>
                                        <td style="padding-left: 3px; text-align: center; width: 7%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><%#Eval("Other") %></td>
                                        <td style="padding-left: 3px; text-align: left; width: 10%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><%#Eval("Purpose") %></td>
                                        <td style="padding-left: 3px; text-align: left; width: 12%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><%#Eval("Appeal_raised_issue") %></td>
                                        <%--                <td style="padding-left:3px;text-align:left;width:12%;white-space: normal;border-right:dotted; border-right-style: dotted; border-right-width: thin;"><%#Eval("Expected_results")%></td>--%>
                                        <td style="padding-left: 3px; text-align: left; width: 7%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;">
                                            <a href='et_vetendashlarla_gorush.aspx?ConnID=<%#Eval("ConnID") %>&islem=duzelis'>Düzəliş</a></td>
                                        <td style="padding-left: 3px; text-align: left; width: 4%; white-space: normal;"><a class="aucun" href='et_vetendashlarla_gorush.aspx?islem=sil&ConnID=<%#Eval("ConnID") %>'>Sil</a></td>
                                    </tr>
                                </table>
                            </ItemTemplate>
                            <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                        </asp:DataList>
                    </div>



                    <asp:Panel ID="pnl2" runat="server">
                        <table class="auto-style5">
                            <tr>
                                <td class="auto-style18">
                                    <table class="auto-style6">
                                        <tr>
                                            <td class="auto-style81">İcra orqanı  </td>
                                            <td class="auto-style82">
                                                <asp:DropDownList ID="CBIcraOrqan" runat="server" AutoPostBack="True" CausesValidation="True" Height="30px" Width="806px" OnSelectedIndexChanged="CBIcraOrqan_SelectedIndexChanged">
                                                </asp:DropDownList>
                                                <asp:TextBox ID="txt_IcraOrqan" runat="server" Font-Names="Arial" Height="26px" Width="802px" Visible="False"></asp:TextBox>
                                            </td>
                                            <td class="auto-style83">
                                                <asp:CheckBox ID="CheckBox4" runat="server" Text="Digər" AutoPostBack="True" OnCheckedChanged="CheckBox4_CheckedChanged" Visible="False" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style75">Tutduğu vəzifə </td>
                                            <td class="auto-style76">
                                                <asp:DropDownList ID="CBtutduquVezife" runat="server" AutoPostBack="True" CausesValidation="True" Height="30px" Width="806px">
                                                </asp:DropDownList>
                                                <asp:TextBox ID="txt_Tutduqu_vezife" runat="server" Font-Names="Arial" Height="26px" Width="802px" Visible="False"></asp:TextBox>
                                            </td>
                                            <td class="auto-style77"></td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style60">Ad </td>
                                            <td class="auto-style61">
                                                <asp:TextBox ID="txt_name_fredi" runat="server" Font-Names="Arial" Height="17px" Width="800px"></asp:TextBox>
                                            </td>
                                            <td class="auto-style62"></td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style63">Soyad</td>
                                            <td class="auto-style64">
                                                <asp:TextBox ID="txt_sname_ferdi" runat="server" Font-Names="Arial" Height="16px" Width="800px"></asp:TextBox>
                                            </td>
                                            <td class="auto-style65"></td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style78">Məqsəd</td>
                                            <td class="auto-style79">
                                                <asp:DropDownList ID="CBMeqsed_ferdi" runat="server" AutoPostBack="True" CausesValidation="True" Height="30px" Width="806px">
                                                </asp:DropDownList>
                                                <asp:TextBox ID="txt_meqsed" runat="server" Font-Names="Arial" Height="26px" Width="802px" Visible="False"></asp:TextBox>
                                            </td>
                                            <td class="auto-style80">
                                                <asp:CheckBox ID="CheckBox13" runat="server" Text="Digər" AutoPostBack="True" OnCheckedChanged="CheckBox13_CheckedChanged" Visible="False" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style25"></td>
                                            <td class="auto-style29">
                                                <asp:Button ID="Button5" runat="server" Height="34px" OnClick="Button5_Click" Text="Yadda saxla" Width="117px" BorderColor="#0033CC" />
                                            </td>
                                            <td class="auto-style21">&nbsp;</td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <div>
                                        &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lblmesag2" runat="server"></asp:Label>

                                        <br />
                                    </div>


                                </td>
                            </tr>
                        </table>

                        <asp:DataList ID="GridView2" runat="server" ForeColor="#333333" Width="1024px">
                            <AlternatingItemStyle BackColor="White" />
                            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <HeaderTemplate>
                                <table style="width: 100%;">
                                    <tr>
                                        <td style="padding-left: 3px; text-align: left; width: 18%; white-space: normal;">İcra orqanı</td>
                                        <td style="padding-left: 3px; text-align: left; width: 18%; white-space: normal;">Tutduğu vəzifə</td>
                                        <td style="padding-left: 3px; text-align: left; width: 18%; white-space: normal;">Ad</td>
                                        <td style="padding-left: 3px; text-align: left; width: 18%; white-space: normal;">Soyad </td>
                                        <td style="padding-left: 3px; text-align: left; width: 18%; white-space: normal;">Məqsəd</td>
                                        <td style="padding-left: 3px; text-align: left; width: 18%; white-space: normal;">Düzəliş</td>
                                        <td style="padding-left: 3px; text-align: left; width: 5%; white-space: normal;">Sil</td>
                                    </tr>
                                </table>
                            </HeaderTemplate>
                            <ItemStyle />
                            <ItemTemplate>
                                <table style="border-bottom-style: dotted; border-bottom-width: thin; width: 100%; border-left-style: dotted; border-left-width: thin; border-right-style: dotted; border-right-width: thin;">
                                    <tr>
                                        <td style="padding-left: 3px; text-align: left; width: 18%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><%#Eval("Executive_body") %></td>
                                        <td style="padding-left: 3px; text-align: left; width: 18%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><%#Eval("Positions") %></td>
                                        <td style="padding-left: 3px; text-align: left; width: 18%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><%#Eval("Name") %></td>
                                        <td style="padding-left: 3px; text-align: left; width: 18%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><%#Eval("SName") %></td>
                                        <td style="padding-left: 3px; text-align: left; width: 18%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><%#Eval("Purpose")%></td>
                                        <td style="padding-left: 3px; text-align: left; width: 18%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><a href='et_vetendashlarla_gorush.aspx?ConnID=<%#Eval("ConnID") %>&islem=duzelis2'>Düzəliş</a></td>
                                        <td style="padding-left: 3px; text-align: left; width: 5%; white-space: normal;"><a class="aucun" href='et_vetendashlarla_gorush.aspx?islem=sil1&ConnID=<%#Eval("ConnID") %>'>Sil</a></td>
                                    </tr>
                                </table>
                            </ItemTemplate>
                            <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                        </asp:DataList>
                    </asp:Panel>


                    <div id="div3" runat="server" style="margin-top: auto; height: 500px;">

                        <table class="auto-style5">
                            <tr>
                                <td class="auto-style18">
                                    <table class="auto-style6">
                                        <tr>
                                            <td class="auto-style55">Keçiriləcək görüş</td>
                                            <td class="auto-style56">
                                                <asp:TextBox ID="txt_kecrilmish_gorush" runat="server" Font-Names="Arial" Height="43px" TextMode="MultiLine" Width="732px"></asp:TextBox>
                                            </td>
                                            <td class="auto-style57"></td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style55">Məqsəd</td>
                                            <td class="auto-style56">
                                                <asp:TextBox ID="txt_meqsed_umumi" runat="server" Font-Names="Arial" Height="43px" TextMode="MultiLine" Width="732px"></asp:TextBox>
                                            </td>
                                            <td class="auto-style57"></td>
                                        </tr>
                                        <asp:Panel ID="gozlenilennet" Visible="false" runat="server">
                                            <tr>
                                                <td class="auto-style52">Gözlənilən nəticə</td>
                                                <td class="auto-style48">
                                                    <asp:TextBox ID="txt_results_umumi" runat="server" Font-Names="Arial" Height="43px" TextMode="MultiLine" Width="732px"></asp:TextBox>
                                                </td>
                                                <td class="auto-style58"></td>
                                            </tr>
                                        </asp:Panel>
                                        <tr>
                                            <td class="auto-style53"></td>
                                            <td class="auto-style49"></td>
                                            <td class="auto-style59"></td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style54"></td>
                                            <td class="auto-style50">
                                                <asp:Button ID="Button6" runat="server" Height="34px" OnClick="Button6_Click" Text="Yadda saxla" Width="117px" BorderColor="#0033CC" />
                                            </td>
                                            <td class="auto-style21">&nbsp;</td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td>

                                    <div>
                                        &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lblmesag3" runat="server"></asp:Label>

                                        <br />
                                    </div>
                                    <asp:DataList ID="GridView3" runat="server" ForeColor="#333333" Width="1024px">
                                        <AlternatingItemStyle BackColor="White" />
                                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                        <HeaderTemplate>
                                            <table style="width: 100%;">
                                                <tr>
                                                    <td style="padding-left: 3px; text-align: left; width: 25%; white-space: normal;">Keçirilmiş görüş</td>
                                                    <td style="padding-left: 3px; text-align: left; width: 25%; white-space: normal;">Məqsəd</td>
                                                    <%--<td style="padding-left: 3px; text-align: left; width: 25%; white-space: normal;">Gözlənilən nəticə</td>--%>
                                                    <td style="padding-left: 3px; text-align: left; width: 15%; white-space: normal;">Düzəliş</td>
                                                    <td style="padding-left: 3px; text-align: left; width: 5%; white-space: normal;">Sil</td>
                                                </tr>
                                            </table>
                                        </HeaderTemplate>
                                        <ItemStyle />
                                        <ItemTemplate>
                                            <table style="border-bottom-style: dotted; border-bottom-width: thin; width: 100%; border-left-style: dotted; border-left-width: thin; border-right-style: dotted; border-right-width: thin;">
                                                <tr>
                                                    <td style="padding-left: 3px; text-align: left; width: 25%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><%#Eval("Meetings") %></td>
                                                    <td style="padding-left: 3px; text-align: left; width: 25%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><%#Eval("Purpose") %></td>
                                                    <%--<td style="padding-left: 3px; text-align: left; width: 25%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><%#Eval("results")%></td>--%>
                                                    <td style="padding-left: 3px; text-align: left; width: 15%; white-space: normal; border-right: dotted; border-right-style: dotted; border-right-width: thin;"><a href='et_vetendashlarla_gorush.aspx?ConnID=<%#Eval("ConnID") %>&islem=duzelis3'>Düzəliş</a></td>

                                                    <td style="padding-left: 3px; text-align: left; width: 5%; white-space: normal;"><a class="aucun" href='et_vetendashlarla_gorush.aspx?islem=sil2&ConnID=<%#Eval("ConnID") %>'>Sil</a></td>
                                                </tr>

                                            </table>
                                        </ItemTemplate>
                                        <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                    </asp:DataList>


                                </td>
                            </tr>
                        </table>


                    </div>
                </td>
            </tr>
        </table>

    </div>
</asp:Content>

