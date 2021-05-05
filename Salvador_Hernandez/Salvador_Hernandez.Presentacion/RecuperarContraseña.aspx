<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RecuperarContraseña.aspx.cs" Inherits="Salvador_Hernandez.RecuperarContraseña" %>

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
            height: 29px;
        }
        .auto-style11 {
            width: 160px;
        }
        .auto-style12 {
            width: 160px;
            height: 24px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style4" colspan="3">Crear Cuenta</td>
                    <td class="auto-style4">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style1">
                        &nbsp;</td>
                    <td class="auto-style11">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">Rut:</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="TextBoxRut" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style11">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxRut" EnableClientScript="False" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Debe ingresar un rut</asp:RequiredFieldValidator>
                    </td>
                    <td>
                        <asp:Button ID="ButtonEnviar" runat="server" OnClick="ButtonEnviar_Click" Text="Enviar" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">Email</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="TextBoxEmail" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style11">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">Pregunta secreta</td>
                    <td class="auto-style1">
                        <asp:DropDownList ID="DropDownListPreguntaSecreta" runat="server" Enabled="False">
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
                        <asp:TextBox ID="TextBoxRespuesta" runat="server" Enabled="False"></asp:TextBox>
                    </td>
                    <td class="auto-style11">
                        &nbsp;</td>
                    <td>
                        <asp:Button ID="ButtonEnviarRespuesta" runat="server" Enabled="False" OnClick="ButtonEnviarRespuesta_Click" Text="Enviar" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">Password:</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="TextBoxPassword" runat="server" TextMode="Password" Enabled="False"></asp:TextBox>
                    </td>
                    <td class="auto-style12">
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBoxPassword" ControlToValidate="TextBoxRepassword" EnableClientScript="False" ErrorMessage="CompareValidator" ForeColor="Red">La password debe ser igual</asp:CompareValidator>
                    </td>
                    <td class="auto-style7">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">Repassword</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="TextBoxRepassword" runat="server" TextMode="Password" Enabled="False"></asp:TextBox>
                    </td>
                    <td class="auto-style11">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style1">
                        <asp:Label ID="LabelOk" runat="server" ForeColor="#3333FF"></asp:Label>
                        <asp:Label ID="LabelError" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                    <td class="auto-style11">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td colspan="3" class="auto-style10">
                        <asp:Button ID="ButtonCambiarContraseña" runat="server" Height="26px" Text="Cambiar Contraseña" Width="200px" OnClick="Button1_Click" Enabled="False" />
                    </td>
                    <td class="auto-style10">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td colspan="3" class="auto-style3">
                        &nbsp;</td>
                    <td class="auto-style3">
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Login.aspx">Volver</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td colspan="3">
                        Fono contacto +56 97979798&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Sitio web www.cachupin.cl</td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
