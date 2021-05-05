<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Salvador_Hernandez.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style2 {
            text-align: center;
            font-weight: bold;
            font-size: xx-large;
            color: #0000FF;
        }
        .auto-style3 {
            width: 244px;
        }
        .auto-style4 {
            width: 275px;
        }
        .auto-style5 {
            width: 167px;
        }
        .auto-style6 {
            width: 244px;
            height: 31px;
        }
        .auto-style7 {
            width: 167px;
            height: 31px;
        }
        .auto-style8 {
            width: 275px;
            height: 31px;
        }
        .auto-style9 {
            height: 31px;
        }
        .auto-style10 {
            width: 244px;
            height: 33px;
        }
        .auto-style11 {
            width: 167px;
            height: 33px;
        }
        .auto-style12 {
            width: 275px;
            height: 33px;
        }
        .auto-style13 {
            height: 33px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="4">LOGIN</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style10"></td>
                    <td class="auto-style11">Usuario</td>
                    <td class="auto-style12">
                        <asp:TextBox ID="TextBoxUsuario" runat="server" OnTextChanged="TextBoxUsuario_TextChanged"></asp:TextBox>
                    </td>
                    <td class="auto-style13"></td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style5">Password</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBoxPassword" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style4">
                        <asp:Label ID="LabelError" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Aceptar" Width="150px" />
                    </td>
                    <td class="auto-style4">
                        <asp:Button ID="ButtonCrearCuenta" runat="server" Text="Crear Cuenta" Width="150px" OnClick="Button2_Click" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6"></td>
                    <td class="auto-style7"></td>
                    <td class="auto-style8">
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/RecuperarContraseña.aspx">Recuperar contraseña</asp:HyperLink>
                    </td>
                    <td class="auto-style9"></td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="4">Fono contacto +56 97979798&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Sitio web www.cachupin.cl</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
