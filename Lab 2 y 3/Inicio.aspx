<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Inicio.aspx.vb" Inherits="Lab_2_y_3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 89px;
        }
        .auto-style2 {
            margin-top: 0px;
        }
        .auto-style3 {
            width: 252px;
        }
        .auto-style5 {
            height: 28px;
        }
    </style>
</head>
<body>
    <form id="formInicio" runat="server">
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">E-mail:</td>
                <td class="auto-style3"> <asp:TextBox ID="tEmail" runat="server" Width="250px"></asp:TextBox>
                </td>
                <td>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" BorderColor="Red" ControlToValidate="tEmail" ErrorMessage="RegularExpressionValidator" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Display="Dynamic">Formato de correo no válido</asp:RegularExpressionValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="tEmail" ErrorMessage="RequiredFieldValidator" ForeColor="Red" Display="Dynamic">Campo requerido</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Contraseña:</td>
                <td class="auto-style3"> <asp:TextBox ID="tPass" runat="server" Width="250px" TextMode="Password"></asp:TextBox>
                </td>
                <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tPass" ErrorMessage="Campo requerido" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td colspan="2" class="auto-style5">
            <asp:Button ID="Button1" runat="server" Text="Iniciar sesión" CssClass="auto-style2" Width="251px" />
                </td>
                <td class="auto-style5">
                    <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2">
            <asp:HyperLink ID="HLRegistro" runat="server" ForeColor="#0000EE" NavigateUrl="~/Registro.aspx">Quiero registrarme</asp:HyperLink>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2">
            <asp:HyperLink ID="HLCambioPass" runat="server" ForeColor="#0000EE" NavigateUrl="~/CambiarPassword.aspx">Modificar password</asp:HyperLink>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        
    </form>
</body>
</html>
