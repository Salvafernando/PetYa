<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CRUDUsuarios.aspx.cs" Inherits="Salvador_Hernandez.CRUDUsuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 123px;
        }
        .auto-style2 {
            width: 72px;
        }
        .auto-style3 {
            text-align: right;
        }
        .auto-style4 {
            text-align: center;
            font-weight: bold;
            font-size: xx-large;
            color: #0000FF;
        }
        .auto-style5 {
            width: 72px;
            height: 24px;
        }
        .auto-style6 {
            width: 123px;
            height: 24px;
        }
        .auto-style7 {
            height: 24px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style4" colspan="3">FICHA USUARIO</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style1">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Rut:</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="TextBoxRut" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxRut" EnableClientScript="False" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Debe ingresar un rut</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Nombre:</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="TextBoxNombre" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxNombre" EnableClientScript="False" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Debe ingresar un nombre</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Username:</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="TextBoxUsername" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBoxUsername" EnableClientScript="False" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Debe ingresar un username</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">Password:</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="TextBoxPassword" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                    <td class="auto-style7">
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBoxPassword" ControlToValidate="TextBoxRepassword" EnableClientScript="False" ErrorMessage="CompareValidator" ForeColor="Red">La password debe ser igual</asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Repassword</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="TextBoxRepassword" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style1">
                        <asp:Label ID="LabelOk" runat="server" ForeColor="#3333FF"></asp:Label>
                        <asp:Label ID="LabelError" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:Button ID="ButtonAgregar" runat="server" Height="26px" Text="Agregar" Width="100px" OnClick="Button1_Click" />
                        <asp:Button ID="ButtonBuscar" runat="server" Text="Buscar" Width="100px" OnClick="ButtonBuscar_Click" />
                        <asp:Button ID="ButtonEliminar" runat="server" Text="Eliminar" Width="100px" OnClick="ButtonEliminar_Click" />
                        <asp:Button ID="ButtonModificar" runat="server" Text="Modificar" Width="100px" OnClick="ButtonModificar_Click" />
                        <asp:Button ID="ButtonListar" runat="server" OnClick="Button5_Click" Text="Listar" Width="100px" />
                    </td>
                </tr>
                <tr>
                    <td colspan="3" class="auto-style3">
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/AgendaPacientes.aspx">Volver</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td colspan="3">
                        Fono contacto +56 97979798&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Sitio web www.cachupin.cl</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
