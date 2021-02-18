<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm2.aspx.vb" Inherits="Lab_2_y_3.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Registro</title>
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
        .auto-style2 {
            width: 88px;
        }
        .auto-style3 {
            width: 69%;
        }
        .auto-style6 {
            width: 88px;
            height: 26px;
        }
        .auto-style7 {
            width: 258px;
            height: 26px;
        }
        .auto-style8 {
            width: 632px;
            height: 26px;
        }
        .auto-style9 {
            width: 258px;
        }
        .auto-style10 {
            width: 632px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style3">
                <tr>
                    <td class="auto-style1" colspan="3">REGISTRO DE USUARIOS</td>
                </tr>
                <tr>
                    <td class="auto-style6">Email</td>
                    <td class="auto-style7">
                        <asp:TextBox ID="tEmail" runat="server" Width="250px" Wrap="False"></asp:TextBox>
                    </td>
                    <td class="auto-style8">
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="tEmail" Display="Dynamic" ErrorMessage="RegularExpressionValidator" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">Formato de email no válido</asp:RegularExpressionValidator>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tEmail" Display="Dynamic" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Campo obligatorio</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Nombre</td>
                    <td class="auto-style9">
                        <asp:TextBox ID="tName" runat="server" Width="250px"></asp:TextBox>
                    </td>
                    <td class="auto-style10">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tName" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Campo obligatorio</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Apellidos</td>
                    <td class="auto-style9">
                        <asp:TextBox ID="tSurname" runat="server" Width="250px"></asp:TextBox>
                    </td>
                    <td class="auto-style10">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="tSurname" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Campo obligatorio</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Password</td>
                    <td class="auto-style9">
                        <asp:TextBox ID="tPass1" runat="server" Width="250px" ReadOnly="False" TextMode="Password"></asp:TextBox>
                    </td>
                    <td class="auto-style10">
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="tPass1" Display="Dynamic" ErrorMessage="RegularExpressionValidator" ForeColor="Red" ValidationExpression="([A-Za-z0-9]){6,}">La contraseña debe contener al menos 6 caracteres alfanuméricos</asp:RegularExpressionValidator>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="tPass1" Display="Dynamic" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Campo obligatorio</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Repetir Psw</td>
                    <td class="auto-style9">
                        <asp:TextBox ID="tPass2" runat="server" Width="250px" TextMode="Password"></asp:TextBox>
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td class="auto-style10">
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="tPass2" Display="Dynamic" ErrorMessage="RegularExpressionValidator" ForeColor="Red" ValidationExpression="([A-Za-z0-9]){6,}">La contraseña debe contener al menos 6 caracteres alfanuméricos</asp:RegularExpressionValidator>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="tPass2" Display="Dynamic" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Campo obligatorio</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Rol</td>
                    <td class="auto-style9">
                        <asp:RadioButtonList ID="rbList" runat="server" Width="223px">
                            <asp:ListItem Value="rbStudent">Alumno</asp:ListItem>
                            <asp:ListItem Value="rbProfessor">Profesor</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    <td class="auto-style10">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="rbList" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Debe seleccionar uno</asp:RequiredFieldValidator>
                    </td>
                </tr>
            </table>
        </div>
        <asp:Button ID="bRegister" runat="server" Text="Registrar" Width="214px" />
        <p>
            &nbsp;</p>
    </form>
</body>
</html>