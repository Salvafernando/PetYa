<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VistaAdmin.aspx.cs" Inherits="Salvador_Hernandez.VistaAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 182px;
        }
        .auto-style2 {
            width: 194px;
        }
        .auto-style3 {
            text-align: center;
        }
        .auto-style4 {
            width: 182px;
            height: 39px;
        }
        .auto-style5 {
            width: 194px;
            height: 39px;
        }
        .auto-style6 {
            height: 39px;
        }
        .auto-style12 {
            height: 68px;
        }
        .auto-style13 {
            height: 67px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style3" colspan="3">ADMINISTRADOR</td>
                </tr>
                <tr>
                    <td class="auto-style4"></td>
                    <td class="auto-style5"></td>
                    <td class="auto-style6"></td>
                </tr>
                <tr>
                    <td class="auto-style13" colspan="2">
                        <asp:Button ID="ButtonUsuario" runat="server" Height="30px" Text="Usuarios" Width="100px" OnClick="ButtonUsuario_Click" />
                    </td>
                    <td class="auto-style13"></td>
                </tr>
                <tr>
                    <td class="auto-style12" colspan="2">
                        <asp:Button ID="ButtonExamen" runat="server" OnClick="ButtonExamen_Click" Text="Examen" Width="100px" />
                    </td>
                    <td class="auto-style12">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style12" colspan="2">
                        <asp:Button ID="ButtonFarmaco" runat="server" OnClick="ButtonFarmaco_Click" Text="Farmaco" Width="100px" />
                    </td>
                    <td class="auto-style12">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style12" colspan="2">
                        <asp:Button ID="ButtonVacuna" runat="server" OnClick="ButtonVacuna_Click" Text="Vacuna" Width="100px" />
                    </td>
                    <td class="auto-style12">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style12" colspan="2">
                        <asp:Button ID="ButtonInsumos" runat="server" OnClick="ButtonInsumo_Click" Text="Insumo" Width="100px" />
                    </td>
                    <td class="auto-style12">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style12" colspan="2">
                        <asp:Button ID="ButtonPatologia" runat="server" OnClick="ButtonPatologia_Click" Text="Patologias" Width="100px" />
                    </td>
                    <td class="auto-style12">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style12" colspan="2">
                        <asp:Button ID="ButtonReporteria" runat="server" Height="34px" Text="Reporteria" Width="100px" OnClick="ButtonReporteria_Click" />
                    </td>
                    <td class="auto-style12">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Login.aspx">Volver a Login</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="3">Fono contacto +56 97979798&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Sitio web www.cachupin.cl</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
