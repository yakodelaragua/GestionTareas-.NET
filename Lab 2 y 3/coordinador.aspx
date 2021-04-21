<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="coordinador.aspx.vb" Inherits="Lab_2_y_3.WebForm15" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                        <br />
                        <asp:Label ID="Label2" runat="server" Text="PROYECTO GESTIÓN DE TAREAS COORDINADOR DE TAREAS"></asp:Label>
                        <br />
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate>
                                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="codigo" DataValueField="codigo" Height="16px" Width="181px">
                                </asp:DropDownList>
                                <br />
                                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:HADS21-14ConnectionString %>" SelectCommand="SELECT [codigo] FROM [Asignaturas]"></asp:SqlDataSource>
                                <br />
                                <br />
                                <asp:Button ID="Button1" runat="server" Text="Obtener dedicación media" />
                                <br />
                                <br />
                                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                        <br />

            <br />
            <br />
        </div>
    </form>
</body>
</html>
