<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Inicio.aspx.vb" Inherits="Inicio.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="formInicio" runat="server">
        <div style="height: 322px; margin-left: 80px;" id="msgErrorDireccion">
            Inicia sesión<br />
            <br />
            E-mail:&nbsp;&nbsp;&nbsp; <asp:TextBox ID="tEmail" runat="server"></asp:TextBox>
            &nbsp;&nbsp;
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" BorderColor="Red" ControlToValidate="tEmail" ErrorMessage="RegularExpressionValidator" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            <br />
            <br />
            Password:&nbsp;&nbsp;&nbsp; <asp:TextBox ID="tPass" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tPass" ErrorMessage="Campo requerido" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="LOGIN" />
            <br />
            <br />
            <asp:HyperLink ID="HLRegistro" runat="server" ForeColor="#0000EE">Quiero registrarme</asp:HyperLink>
            <br />
            <asp:HyperLink ID="HLCambioPass" runat="server" ForeColor="#0000EE">Modificar password</asp:HyperLink>
            <br />
            <br />
        </div>
        
    </form>
</body>
</html>
