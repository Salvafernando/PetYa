<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MenuAuditorias.aspx.cs" Inherits="Salvador_Hernandez.Presentacion.WebForm2" %>

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
                <td><h1>Menu de auditoría - Administrador</h1></td>
            </tr>
            <tr>
                <td style="width:300px">
                    <asp:Menu ID="Menu1" runat="server"></asp:Menu>
                    <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />
                </td>           
            <td>
                <div>
                    <asp:Button ID="BtnAuditoria" runat="server" Text="Auditoria Usuarios" OnClick="btnAuditorias_Click" />
                    <br />
                    <asp:Button ID="BtnFichas" runat="server" Text="Auditoria Fichas medicas" OnClick="BtnAuditoriaFichas_Click" />
                    <br />
                    <asp:Button ID="Button3" runat="server" Text="Auditoria Examenes" OnClick="BtnAuditoriaExamen_Click" />
                    <br />
                    <asp:Button ID="Button5" runat="server" Text="Auditoria Farmacos" OnClick="BtnAuditoriaFarmaco_Click" />
                    <br />
                    <asp:Button ID="Button6" runat="server" Text="Auditoria Reservas" OnClick="BtnAuditoriaReserva_Click" />
                </div>
            <td>
                    <asp:Button ID="Button1" runat="server" Text="Auditoria Vacunas" OnClick="BtnAuditoriaVacunas_Click" />
                    <br />
                    <asp:Button ID="Button2" runat="server" Text="Auditoria Insumos" OnClick="BtnAuditoriaInsumos_Click" />
                <br />
                <asp:Button ID="Button4" runat="server" Text="Auditoria GPS" OnClick="BtnAuditoriaGps_Click" />
                <br />
                    <asp:Button ID="Button7" runat="server" Text="Auditoria Patologias" OnClick="BtnAuditoriaPatologia_Click" />
            </td>
                </td>
                </tr>
                
            <tr>
                <td style="width:300px">
                    &nbsp;</td>           
            <td>
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Menu_Reporteria.aspx">Volver</asp:HyperLink>
                </td>
                </tr>
            </table>
    </form>
</body>
</html>
