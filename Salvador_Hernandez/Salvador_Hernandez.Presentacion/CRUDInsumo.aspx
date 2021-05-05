<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CRUDInsumo.aspx.cs" Inherits="Salvador_Hernandez.Presentacion.CRUDInsumo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
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
                    <td class="auto-style1">ID insumo:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBoxId" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxId" EnableClientScript="False" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Debe ingresar un id</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Nombre Insumo:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBoxNombre" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxNombre" EnableClientScript="False" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Debe ingresar nombre del Insumo</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Descripción Insumo:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBoxDescripcion" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBoxDescripcion" EnableClientScript="False" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Debe ingresar la Descripción del insumo</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Precio:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBoxPrecio" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBoxPrecio" EnableClientScript="False" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Debe Ingresar el precio del insumo</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Cantidad:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBoxCantidad" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TextBoxCantidad" EnableClientScript="False" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Debe ingresar la Cantidad del insumo</asp:RequiredFieldValidator>
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
                    <td colspan="3" class="auto-style14">
                        <asp:Button ID="ButtonAgregar" runat="server" Text="Agregar" Width="100px" OnClick="Button2_Click" />
                        <asp:Button ID="ButtonBuscar" runat="server" Text="Buscar" Width="100px" OnClick="Button4_Click" />
                        <asp:Button ID="ButtonEliminar" runat="server" Text="Eliminar" Width="100px" OnClick="ButtonEliminar_Click" />
                        <asp:Button ID="ButtonModificar" runat="server" Text="Modificar" Width="100px" OnClick="Button6_Click" />
                        <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="Listar" Width="100px" style="height: 26px" />
                    </td>
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
