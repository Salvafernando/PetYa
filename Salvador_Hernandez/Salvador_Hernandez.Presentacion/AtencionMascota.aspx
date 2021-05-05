<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AtencionMascota.aspx.cs" Inherits="Salvador_Hernandez.Presentacion.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 209px;
        }
        .auto-style2 {
            width: 164px;
        }
        .auto-style3 {
            width: 355px;
            height: 167px;
        }
        .auto-style4 {
            width: 351px;
            height: 105px;
        }
        .auto-style5 {
            width: 347px;
            height: 129px;
        }
        .auto-style6 {
            width: 345px;
            height: 109px;
        }
        .auto-style7 {
            width: 349px;
            height: 114px;
        }
        .auto-style8 {
            width: 350px;
            height: 142px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width: 100%;">
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style2">ATENCION MASCOTA</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Rut dueño</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtRutDueno" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btnBusqueda" runat="server" Text="Buscar" Width="109px" OnClick="btnBusqueda_Click" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Lista mascotas dueño</td>
                    <td class="auto-style2">
                        <asp:DropDownList ID="ddlMascota" runat="server" Height="16px" Width="126px" OnSelectedIndexChanged="ddlMascota_SelectedIndexChanged" AutoPostBack="True">
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:Label ID="LabelOk" runat="server" ForeColor="#3366CC"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        &nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:Label ID="LabelError" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Nombre Mascota</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtNombreMascota" runat="server" ReadOnly="True"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Raza</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtRaza" runat="server" ReadOnly="True"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Especie</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtEspecie" runat="server" ReadOnly="True"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Sexo</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtSexo" runat="server" ReadOnly="True"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Fecha Nacimiento</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtFechaNacimiento" runat="server" ReadOnly="True"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Datos Clínicos"></asp:Label>
                    </td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Peso</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtPeso" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Temperatura</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtTemperatura" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Frecuencia cardiaca</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtFrecCardiaca" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Frecuencia respiratoria</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtFrecRespiratoria" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Anamnesis</td>
                    <td class="auto-style2">
                        <textarea id="txtAnamnesis" name="S1" class="auto-style3" runat="server"></textarea></td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Signos vitales</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtSVitales" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Prediagnostico</td>
                    <td class="auto-style2">
                        <textarea id="txtPDiagnostico" class="auto-style7" name="S5" runat="server"></textarea></td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Diagnostico</td>
                    <td class="auto-style2">
                        <textarea id="txtDiagnostico" class="auto-style8" name="S6" runat="server"></textarea></td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Pronostico</td>
                    <td class="auto-style2">
                        <textarea id="txtPronostico" name="S2" class="auto-style4" runat="server"></textarea></td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Tratamiento</td>
                    <td class="auto-style2">
                        <textarea id="txtTratamiento" name="S3" class="auto-style5" runat="server"></textarea></td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Observaciones</td>
                    <td class="auto-style2">
                        <textarea id="txtObservaciones" name="S4" class="auto-style6" runat="server"></textarea></td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Button ID="btnActualizar" runat="server" Text="Ingresar datos" OnClick="btnActualizar_Click" />
                    </td>
                    <td class="auto-style2">
                        <asp:Button ID="btnVolverFicha" runat="server" Height="28px" Text="Ir a ficha mascota" Width="152px" OnClick="btnVolverFicha_Click" />
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
