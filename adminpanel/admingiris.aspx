<%@ Page Language="C#" AutoEventWireup="true" CodeFile="admingiris.aspx.cs" Inherits="adminpanel_admingiris" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title></title>
      <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 400px;
        }
        .style3
        {
            width: 8%;
        }
        .style4
        {
            height: 23px;
        }
          .auto-style1 {
              height: 175px;
          }
          .auto-style2 {
              width: 9%;
          }
    </style>
                <script type = "text/javascript" >
                    window.onload = function () {
                        noBack();
                    }
                    function noBack() {
                        window.history.forward();
                    }
</script>
</head>

<body  onpageshow="if (event.persisted) noBack();">
    <form id="form1" runat="server" defaultbutton="btnGiris">
  <div>
    
        <table class="style1">
            <tr>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="font-family: Arial, Helvetica, sans-serif; font-size: 16px; color: #000099; font-weight: bold; text-align: center;">
                    Sistemə daxilolma səhifəsi</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <table align="center" class="style2" style="border: medium double #3366FF">
                        <tr>
                            <td colspan="2" style="text-align: center" width="30%" class="style4">
                                <asp:Label ID="lblBilgi" runat="server" Font-Bold="True" ForeColor="#CC0000"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style2">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style2">
                                  &nbsp;&nbsp;&nbsp;Şifrə:</td>
                            <td>
                                <asp:TextBox ID="txtparol"  runat="server"  Width="200px" TextMode="Password"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style2">
                                &nbsp;</td>
                            <td>
                                 &nbsp;
                            </td>
                        </tr>
                          <tr>
                            <td class="auto-style2">
                                &nbsp;</td>
                            <td>
                             <asp:Button ID="btnGiris" runat="server" onclick="btnGiris_Click" 
                                    Text="Giriş" Width="100px" />
                            </td>
                        </tr>
                          <tr>
                            <td class="auto-style2">
                                &nbsp;</td>
                            <td>
                                 &nbsp;
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
