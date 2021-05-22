<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PruebaPayPal.aspx.cs" Inherits="Salvador_Hernandez.Presentacion.PruebaPayPal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 22px;
            width: 340px;
        }
        .auto-style2 {
            width: 247px;
        }
        .auto-style3 {
            height: 22px;
            width: 317px;
        }
        .auto-style4 {
            width: 317px;
        }
        .auto-style5 {
            margin-left: 64px;
        }
        .auto-style6 {
            height: 22px;
            width: 180px;
        }
        .auto-style7 {
            height: 22px;
            width: 182px;
        }
        .auto-style8 {
            height: 22px;
            width: 247px;
        }
    </style>
</head>
<body>
   <form id="form1" runat="server">
        <div>
            <table class="auto-style7">
                <tr>
                    <td class="auto-style13" colspan="3">Pago Reserva</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style2">
                        &nbsp;</td>
                    <td class="auto-style4">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">RUT Usuario</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtRut" runat="server" ReadOnly="True"></asp:TextBox>
                    </td>
                    <td class="auto-style4">
                        <asp:Button ID="btnBuscarH" runat="server" CssClass="auto-style5" OnClick="btnBuscarH_Click" Text="Buscar Horario" Width="114px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Veterinario</td>
                    <td class="auto-style2">
                        <asp:DropDownList ID="ddlVeterinario" runat="server" AutoPostBack="True" Height="16px" OnSelectedIndexChanged="ddlVeterinario_SelectedIndexChanged" Width="184px">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style4">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Horario</td>
                    <td class="auto-style2">
                        <asp:DropDownList ID="ddlHorario" runat="server" Height="16px" Width="184px" AutoPostBack="True" OnSelectedIndexChanged="ddlHorario_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style4">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Hora</td>
                    <td class="auto-style8">
                        <asp:DropDownList ID="ddlHora" runat="server" Height="18px" Width="129px">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style3">
                        </td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style2">
                        &nbsp;</td>
                    <td class="auto-style4">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1"></td>
                    <td class="auto-style8">
                    </td>
                    <td class="auto-style3">
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Button ID="btnPago" runat="server" OnClick="Button1_Click" Text="Pago Reserva" style="height: 26px" />
                    </td>
                    <td class="auto-style2">
                        &nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="3" class="auto-style14">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td colspan="3" class="auto-style6">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td colspan="3" class="auto-style12">
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/VistaAdmin.aspx">Volver</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td colspan="3" class="auto-style11">
                        Fono contacto +56 97979798&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Sitio web www.cachupin.cl</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>