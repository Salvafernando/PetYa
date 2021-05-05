<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BusquedaInfoVet.aspx.cs" Inherits="Salvador_Hernandez.Presentacion.BusquedaInfoVet" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <h1 style="text-align:center;">Modulo Busqueda Veterinario</h1>
    <form id="form1" runat="server">
        

                <table style="width:100%;">
                    <tr>
                        <td>Ingresar palabra para busqueda:</td>
                        <td>
                             <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:Button ID="btnBuscar" runat="server" Text="Buscar Información" OnClick="BtnBuscar_Click" />
                        </td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style2">Busqueda</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3" colspan="3">
                        <asp:GridView ID="GridView1" runat="server" Height="142px" Width="249px">
                        </asp:GridView>
                    </td>
                </tr>
               
                    
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style1">
                        <asp:Label ID="LabelOk" runat="server" ForeColor="#3333FF"></asp:Label>
                        <asp:Label ID="LabelError" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                    <td>
                        &nbsp;</td>
                    <td class="auto-style4" colspan="3">
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/CRUDMascota.aspx">Volver</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4" colspan="3">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4" colspan="3">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4" colspan="3">
                        &nbsp;</td>
                </tr>
            </table>
    </form>
</body>
</html>