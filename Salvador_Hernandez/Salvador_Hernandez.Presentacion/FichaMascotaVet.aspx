<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FichaMascotaVet.aspx.cs" Inherits="Salvador_Hernandez.Presentacion.FichaMascotaVet" %>

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
            width: 209px;
            font-weight: bold;
        }
        .auto-style4 {
            width: 244px;
            height: 120px;
        }
        .auto-style5 {
            width: 244px;
            height: 96px;
        }
        .auto-style6 {
            width: 243px;
            height: 114px;
        }
        .auto-style7 {
            width: 245px;
            height: 103px;
        }
        .auto-style8 {
            width: 209px;
            height: 26px;
        }
        .auto-style9 {
            width: 164px;
            height: 26px;
        }
        .auto-style10 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width: 100%;">
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style2">FICHA MASCOTA</td>
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
                        <asp:DropDownList ID="ddlMascota" runat="server" AutoPostBack="True" Height="17px" Width="173px" OnSelectedIndexChanged="ddlMascota_SelectedIndexChanged">
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
                        <asp:TextBox ID="txtPeso" runat="server" ReadOnly="True"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Temperatura</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtTemperatura" runat="server" ReadOnly="True"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">Frecuencia cardiaca</td>
                    <td class="auto-style9">
                        <asp:TextBox ID="txtFrecCardiaca" runat="server" ReadOnly="True"></asp:TextBox>
                    </td>
                    <td class="auto-style10"></td>
                    <td class="auto-style10"></td>
                </tr>
                <tr>
                    <td class="auto-style1">Frecuencia respiratoria</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtFrecRespiratoria" runat="server" ReadOnly="True"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Anamnesis</td>
                    <td class="auto-style2">
                       
                        <textarea id="txtAnamnesis" name="S1" runat="server" class="auto-style4" ReadOnly="True"></textarea></td>
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
                        <asp:TextBox ID="txtPDiagnostico" runat="server" ReadOnly="True"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Diagnostico</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtDiagnostico" runat="server" ReadOnly="True"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Pronostico</td>
                    <td class="auto-style2">
                        <textarea id="txtPronostico" name="S2" class="auto-style5" runat="server" ReadOnly="True"></textarea></td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Tratamiento</td>
                    <td class="auto-style2">
                        <textarea id="txtTratamiento" name="S3" class="auto-style6" runat="server" ReadOnly="True"></textarea></td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Observaciones</td>
                    <td class="auto-style2">
                        <textarea id="txtObservaciones" name="S4" class="auto-style7" runat="server" ReadOnly="True"></textarea></td>
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
                        <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Vacunas administradas"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:GridView ID="gvVacunas" runat="server" Height="263px" Width="491px">
                        </asp:GridView>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        &nbsp;</td>
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
                <tr>
                    <td class="auto-style3">Farmacos administrados</td>
                    <td class="auto-style2">
                        <asp:GridView ID="gvFarmacos" runat="server" Height="231px" Width="492px">
                        </asp:GridView>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        &nbsp;</td>
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
                <tr>
                    <td class="auto-style3">Examenes administrados</td>
                    <td class="auto-style2">
                        <asp:GridView ID="gvExamen" runat="server" Height="182px" Width="491px">
                        </asp:GridView>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        &nbsp;</td>
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
