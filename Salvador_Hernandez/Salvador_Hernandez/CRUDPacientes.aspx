<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CRUDPacientes.aspx.cs" Inherits="Salvador_Hernandez.CRUDPacientes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 188px;
        }
        .auto-style2 {
            width: 332px;
        }
        .auto-style6 {
            text-align: center;
        }
        .auto-style7 {
            width: 100%;
        }
        .auto-style8 {
            width: 188px;
            height: 24px;
        }
        .auto-style9 {
            width: 332px;
            height: 24px;
        }
        .auto-style10 {
            height: 24px;
        }
        .auto-style11 {
            text-align: left;
        }
        .auto-style12 {
            text-align: right;
        }
        .auto-style13 {
            text-align: center;
            font-weight: bold;
            font-size: xx-large;
            color: #0000FF;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style7">
                <tr>
                    <td class="auto-style13" colspan="3">FICHA PACIENTES</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style2">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">ID:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBoxId" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxId" EnableClientScript="False" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Debe ingresar un id</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Nombre mascota:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBoxNomMasc" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxNomMasc" EnableClientScript="False" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Debe ingresar nombre de mascota</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Raza:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBoxRaza" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBoxRaza" EnableClientScript="False" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Debe ingresar raza</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">Fecha nacimiento:</td>
                    <td class="auto-style9">
                        <asp:TextBox ID="TextBoxFechaNac" runat="server"></asp:TextBox>
                        <asp:Button ID="ButtonVerCalendario" runat="server" OnClick="ButtonVerCalendario_Click" Text="Ver Calendario" Width="99px" />
                        <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged" Visible="False"></asp:Calendar>
                    </td>
                    <td class="auto-style10">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBoxFechaNac" EnableClientScript="False" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Debe ingresar fecha nacimiento</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Genero:</td>
                    <td class="auto-style2">
                        <asp:DropDownList ID="DropDownListGenero" runat="server" AutoPostBack="True" Height="27px" Width="117px">
                            <asp:ListItem></asp:ListItem>
                            <asp:ListItem Value="Femenino"></asp:ListItem>
                            <asp:ListItem Value="Masculino"></asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="DropDownListGenero" EnableClientScript="False" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Debe seleccionar un género</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Foto:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBoxFoto" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBoxFoto" EnableClientScript="False" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Debe seleccionar una foto</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">RUT dueño:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBoxRutDueno" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TextBoxRutDueno" EnableClientScript="False" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Debe ingresar rut de dueño</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Nombre dueño:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBoxNomDueno" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="TextBoxNomDueno" EnableClientScript="False" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Debe ingresar nombre dueño</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style2">
                        <asp:Label ID="LabelOk" runat="server" ForeColor="#0033CC"></asp:Label>
                        <asp:Label ID="LabelError" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:Button ID="ButtonAgregar" runat="server" Text="Agregar" Width="100px" OnClick="Button2_Click" />
                        <asp:Button ID="ButtonBuscar" runat="server" Text="Buscar" Width="100px" OnClick="Button4_Click" />
                        <asp:Button ID="ButtonEliminar" runat="server" Text="Eliminar" Width="100px" OnClick="ButtonEliminar_Click" />
                        <asp:Button ID="ButtonModificar" runat="server" Text="Modificar" Width="100px" OnClick="Button6_Click" />
                        <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="Listar" Width="100px" />
                    </td>
                </tr>
                <tr>
                    <td colspan="3" class="auto-style6">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td colspan="3" class="auto-style12">
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/AgendaPacientes.aspx">Volver</asp:HyperLink>
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
