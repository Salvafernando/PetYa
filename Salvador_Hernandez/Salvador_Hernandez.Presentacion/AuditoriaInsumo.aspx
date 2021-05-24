﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AuditoriaInsumo.aspx.cs" Inherits="Salvador_Hernandez.Presentacion.AuditoriaInsumo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <h1 style="text-align:center;">Modulo Auditoría</h1>
    <form id="form1" runat="server">
        

                <table style="width:100%;">
                    <tr>
                        <td>Buscar por accion:</td>
                        <td>
                             <asp:TextBox ID="txtAccion" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:Button ID="btnBuscar" runat="server" Text="Buscar Auditoria" OnClick="BtnBuscar_Click" />
                        </td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style2">Auditoría</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3" colspan="3">
                        <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" EnableTheming="True">
                            <AlternatingRowStyle BackColor="#F7F7F7" />
                            <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                            <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                            <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                            <SortedAscendingCellStyle BackColor="#F4F4FD" />
                            <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
                            <SortedDescendingCellStyle BackColor="#D8D8F0" />
                            <SortedDescendingHeaderStyle BackColor="#3E3277" />
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
                </tr>
                <tr>
                    <td class="auto-style4" colspan="3">
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/MenuAuditorias.aspx">Volver</asp:HyperLink>
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
