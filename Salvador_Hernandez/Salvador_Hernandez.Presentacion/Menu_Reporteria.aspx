<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu_Reporteria.aspx.cs" Inherits="Salvador_Hernandez.Presentacion.Menu_Reporteria" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table>  
            <tr>
                <td><h1>Menu de reportería - Administrador</h1></td>
            </tr>
            <tr>
                <td style="width:300px">
                    <asp:Menu ID="Menu1" runat="server"></asp:Menu>
                    <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />
                </td>           
            <td>
        <div>
            <asp:Button ID="btnUsuarios" runat="server" Text="Lista Usuarios" OnClick="btnUsuarios_Click" />
            <asp:Button ID="btnMascotas" runat="server" Text="Lista Mascotas" OnClick="btnMascotas_Click" />
            <br />
            <asp:Button ID="btnExamenes" runat="server" Text="Lista Examenes Aplicados"  OnClick="btnExamenes_Click"/>
            <asp:Button ID="btnFarmacos" runat="server" Text="Lista Farmacos Aplicados"  OnClick="btnFarmacos_Click"/>
            
        </div>
                </td>
                <td>
                    <asp:Button ID="BtnAuditoria" runat="server" Text="Auditorias" OnClick="btnAuditorias_Click" />
                </td>
                </tr>
            <tr>
                <td style="width:300px">
                    &nbsp;</td>           
            <td>
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/VistaAdmin.aspx">Volver</asp:HyperLink>
                </td>
                </tr>
            </table>
    </form>
</body>
</html>
