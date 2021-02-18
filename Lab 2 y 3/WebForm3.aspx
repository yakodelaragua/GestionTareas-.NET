<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm3.aspx.vb" Inherits="Lab_2_y_3.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 289px;
        }
        .auto-style2 {
            width: 289px;
            height: 26px;
        }
        .auto-style3 {
            height: 26px;
        }
        .auto-style4 {
            height: 26px;
            width: 116px;
        }
        .auto-style5 {
            width: 116px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table style="width: 100%;">
            <tr>
                <td class="auto-style2">Introduce el email parar recuperar contraseña:</td>
                <td class="auto-style4">
                    <asp:TextBox ID="tEmail" runat="server" Width="290px"></asp:TextBox>
                </td>
                <td class="auto-style3">
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="tEmail" Display="Dynamic" ErrorMessage="RegularExpressionValidator" ForeColor="Red" ValidationGroup="email">Formato de email no válido</asp:RegularExpressionValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tEmail" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ValidationGroup="email" Display="Dynamic">Campo obligatorio</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="bEnviar" runat="server" Text="Enviar" ValidationGroup="email" Width="250px" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Introduzca el código recibido:</td>
                <td class="auto-style5">
                    <asp:TextBox ID="tCode" runat="server" Width="290px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tCode" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ValidationGroup="Code">Campo obligatorio</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Introduzca la nueva contraseña:</td>
                <td class="auto-style5">
                    <asp:TextBox ID="tNewPass1" runat="server" Width="290px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="tNewPass1" Display="Dynamic" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ValidationGroup="Code">Campo obligatorio</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="tNewPass1" Display="Dynamic" ErrorMessage="RegularExpressionValidator" ForeColor="Red" ValidationExpression="([A-Za-z0-9]){6,}" ValidationGroup="Code">La contraseña debe contener al menos 6 caracteres alfanuméricos</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Repita la nueva contraseña:</td>
                <td class="auto-style5">
                    <asp:TextBox ID="tNewPass2" runat="server" Width="290px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="tNewPass2" Display="Dynamic" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ValidationGroup="Code">Campo obligatorio</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="tNewPass2" Display="Dynamic" ErrorMessage="RegularExpressionValidator" ForeColor="Red" ValidationExpression="([A-Za-z0-9]){6,}" ValidationGroup="Code">La contraseña debe contener al menos 6 caracteres alfanuméricos</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="bRestablecer" runat="server" Text="Restablecer" Width="250px" ValidationGroup="Code" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>

