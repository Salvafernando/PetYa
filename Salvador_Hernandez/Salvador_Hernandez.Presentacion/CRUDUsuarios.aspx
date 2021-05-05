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
        .auto-style3 {
            text-align: right;
        }
        .auto-style4 {
            text-align: center;
            font-weight: bold;
            font-size: xx-large;
            color: #0000FF;
        }
        .auto-style6 {
            width: 123px;
            height: 24px;
        }
        .auto-style7 {
            height: 24px;
        }
        .auto-style8 {
            width: 232px;
        }
        .auto-style9 {
            width: 232px;
            height: 24px;
        }
        .auto-style10 {
            width: 232px;
            height: 33px;
        }
        .auto-style11 {
            width: 123px;
            height: 33px;
        }
        .auto-style12 {
            height: 33px;
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
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style1">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">Rut:</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="TextBoxRut" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxRut" EnableClientScript="False" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Debe ingresar un rut</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">Primer nombre:</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="TextBoxPrimerNombre" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxPrimerNombre" EnableClientScript="False" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Debe ingresar un primer nombre</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">Segundo nombre</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="TextBoxSegundoNombre" runat="server" Height="29px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBoxSegundoNombre" EnableClientScript="False" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Debe ingresar un segindo nombre</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">Apellido paterno</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="TextBoxApellidoPaterno" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBoxApellidoPaterno" EnableClientScript="False" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Debe ingresar un primer apellido</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">Apellido materno</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="TextBoxApellidoMaterno" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBoxApellidoPaterno" EnableClientScript="False" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Debe ingresar un segundo apellido</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">Email</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="TextBoxEmail" runat="server" TextMode="Email"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBoxEmail" EnableClientScript="False" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Debe ingresar un correo</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">Pregunta secreta</td>
                    <td class="auto-style1">
                        <asp:DropDownList ID="DropDownListPreguntaSecreta" runat="server">
                            <asp:ListItem Value="0">Selecciona una pregunta</asp:ListItem>
                            <asp:ListItem Value="1">¿Cual es el nombre de tu madre?</asp:ListItem>
                            <asp:ListItem Value="2">¿A que colegio asististe?</asp:ListItem>
                            <asp:ListItem Value="3">¿Cual es tu color favorito?</asp:ListItem>
                            <asp:ListItem Value="4">¿Cual es el nombre de tu abuelo?</asp:ListItem>
                        </asp:DropDownList>
                    </td>

                    
                </tr>
                <tr>
                    <td class="auto-style8">Respuesta</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="TextBoxRespuesta" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TextBoxRespuesta" EnableClientScript="False" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Debe ingresar una respuesta</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style10">Tipo Usuario</td>
                    <td class="auto-style11">
                        <asp:DropDownList ID="DropDownListTipoUsuario" runat="server" Width="330px">
                            <asp:ListItem Value="0">Seleccionar Tipo de Usuario</asp:ListItem>
                            <asp:ListItem Value="1">Administrador</asp:ListItem>
                            <asp:ListItem Value="2">Veterinario</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style12">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style10">Estado</td>
                    <td class="auto-style11">
                        <asp:DropDownList ID="DropDownListEstado" runat="server" Width="330px">
                            <asp:ListItem Value="0">Selecciona un estado</asp:ListItem>
                            <asp:ListItem>Activo</asp:ListItem>
                            <asp:ListItem>Inactivo</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style12">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style10">Direccion</td>
                    <td class="auto-style11">
                        <asp:TextBox ID="TextBoxDireccion" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style12">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="TextBoxDireccion" EnableClientScript="False" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Debe ingresar una direccion</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">Telefono</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="TextBoxTelefono" runat="server" MaxLength="9" TextMode="Number"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="TextBoxTelefono" EnableClientScript="False" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Debe ingresar un telefono</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">Password:</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="TextBoxPassword" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                    <td class="auto-style7">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="TextBoxRepassword" EnableClientScript="False" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Debe ingresar una password</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">Repassword</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="TextBoxRepassword" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                    <td>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBoxPassword" ControlToValidate="TextBoxRepassword" EnableClientScript="False" ErrorMessage="CompareValidator" ForeColor="Red">La password debe ser igual</asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;</td>
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
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/VistaAdmin.aspx">Volver</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        &nbsp;</td>
                </tr>
                </table>
        </div>
    </form>
</body>
</html>