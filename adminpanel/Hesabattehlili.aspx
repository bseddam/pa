<%@ Page Title="" Language="C#" MasterPageFile="~/adminpanel/adminMasterPage.master" AutoEventWireup="true" CodeFile="Hesabattehlili.aspx.cs" Inherits="adminpanel_Hesabatlar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }

        .auto-style2 {
            width: 43px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>

        <table class="auto-style1">

            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>

                <td>
                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">1. Şöbə əməkdaşlarının ezamiyyətlərdə olduqları müddətlər barədə məlumat </asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">2. Hesabatların təqdim edilməsi vəziyyəti barədə məlumat
                    </asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:LinkButton ID="LinkButton25" runat="server" OnClick="LinkButton25_Click">3.
Şöbə əməkdaşlarının ezamiyyə dövründə gördükləri işlər barədə məlumat
                    </asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:LinkButton ID="LinkButton17" runat="server" OnClick="LinkButton17_Click">4. Şöbə əməkdaşlarının ezamiyyətlərdə verdikləri tövsiyyə və təkliflər barədə məlumat
                    </asp:LinkButton>
                </td>
            </tr>

            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click">5.
Şöbə əməkdaşlarının ezamiyyətlərinin məqsədləri barədə məlumat
                    </asp:LinkButton>
                </td>

            </tr>

            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:LinkButton ID="LinkButton12" runat="server" OnClick="LinkButton12_Click">6. Şöbə əməkdaşlarının ezamiyyətlərdə ictimai-siyasi vəziyyətinin və dini durumun araşdırılması  
barədə məlumat

                    </asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:LinkButton ID="LinkButton26" runat="server" OnClick="LinkButton13_Click">7. Şöbə əməkdaşlarının ezamiyyətlərdə sosial və humanitar sahələrdə həlli vacib olan problemlərin araşdırılması  
barədə məlumat

                    </asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:LinkButton ID="LinkButton27" runat="server" OnClick="LinkButton14_Click">8. Şöbə əməkdaşlarının ezamiyyətlərdə iqtisadi və sahibkarlıq sahələrdə həlli vacib olan problemlərin araşdırılması  
barədə məlumat

                    </asp:LinkButton>
                </td>
            </tr>

                       <div id="pnladm" runat="server">
            



            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:LinkButton ID="LinkButton28" runat="server" OnClick="LinkButton15_Click">9. Şöbə əməkdaşlarının ezamiyyətlərdə mövcud əyani təşviqat vasitələrinin vəziyyətinin araşdırılması  
barədə məlumat

                    </asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:LinkButton ID="LinkButton29" runat="server" OnClick="LinkButton16_Click">10. Şöbə əməkdaşlarının ezamiyyətlərdə söhbət aparılmış kadrlar  
barədə məlumat


                    </asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:LinkButton ID="LinkButton11" runat="server" OnClick="LinkButton11_Click">11. Şöbə əməkdaşlarının ezamiyyətlərdə vətəndaşlarla keçirilmiş görüşlər  
barədə məlumat

                    </asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:LinkButton ID="LinkButton5" runat="server" OnClick="LinkButton5_Click"> 12. Şöbə əməkdaşlarının ezamiyyətlər dövründə iştirak etdikləri tədbirlər  
barədə məlumat
                    </asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:LinkButton ID="LinkButton24" runat="server" OnClick="LinkButton6_Click"> 13. Şöbə əməkdaşlarının iştirak etmədikləri tədbirlər barədə məlumat
                    </asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:LinkButton ID="LinkButton20" runat="server" OnClick="LinkButton20_Click"> 14. Şöbə əməkdaşlarının müzakirəsində iştirak etmədikləri məsələlər barədə məlumat
                    </asp:LinkButton>
                </td>
            </tr>

            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:LinkButton ID="LinkButton19" runat="server" OnClick="LinkButton19_Click"> 15. Şöbə əməkdaşlarının ezamiyyətlər dövründə olduqları İH başçılarının nümayəndəlikləri barədə məlumat</asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton4_Click"> 16. Şöbə əməkdaşlarının ezamiyyətlər dövründə olduqları yaşayış məntəqələri barədə məlumat
</asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:LinkButton ID="LinkButton6" runat="server" OnClick="LinkButton6_Click2"> 17. Məqsədlərlə bağlı ezamiyyələrin sayı </asp:LinkButton>
                </td>
            </tr>
                      </div>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>

            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <%--            <tr>
                <td class="auto-style2">&nbsp;</td>

                <td>
                    <asp:LinkButton ID="LinkButton6" runat="server" OnClick="LinkButton6_Click1">21. Şöbə əməkdaşlarının ezamiyyə planları barədə məlumat </asp:LinkButton>
                </td>
                </tr>
               <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>--%>
        </table>

    </div>
</asp:Content>

