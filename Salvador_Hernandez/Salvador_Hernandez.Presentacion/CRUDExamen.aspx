<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CRUDExamen.aspx.cs" Inherits="Salvador_Hernandez.Presentacion.CRUDExamen" %>

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
        .auto-style8 {
            width: 232px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style4" colspan="3">FICHA EXAMEN</td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style1">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">ID:</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="TextBoxId" runat="server" TextMode="Number" OnTextChanged="TextBoxId_TextChanged"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxId" EnableClientScript="False" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Debe ingresar un Id</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">Nombre:</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="TextBoxNombre" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxNombre" EnableClientScript="False" ErrorMessage="RequiredFieldValidator" ForeColor="Red" EnableTheming="False">Debe ingresar un nombre</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">Descripcion</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="TextBoxDescripcion" runat="server" Height="200px" Width="300px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBoxDescripcion" EnableClientScript="False" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Debe ingresar una descripcion</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">Precio</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="TextBoxPrecio" runat="server" TextMode="Number"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBoxPrecio" EnableClientScript="False" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Debe ingresar un valor</asp:RequiredFieldValidator>
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
