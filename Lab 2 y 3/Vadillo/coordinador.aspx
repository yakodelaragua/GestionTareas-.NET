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

                        <asp:Panel ID="Panel1" runat="server" Height="102px" Direction="LeftToRight" HorizontalAlign="Left" BackColor="Silver">
                            <br />
                            <br />
                                                    <asp:Label ID="Label2" runat="server" Text="PROYECTO GESTIÓN DE TAREAS COORDINADOR DE TAREAS" BackColor="Silver" BorderColor="Black" Font-Size="X-Large"></asp:Label>

                                                    <br />
                                                    <br />

                        </asp:Panel>

                        <asp:ScriptManager ID="ScriptManager1" runat="server">
                        </asp:ScriptManager>
                        <br />
                        Selecciona la asignatura:<br />
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate>
                                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="codigo" DataValueField="codigo" Height="16px" Width="181px">
                                    <asp:ListItem Selected="True"></asp:ListItem>
                                </asp:DropDownList>
                                <br />
                                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:HADS21-14ConnectionString %>" SelectCommand="SELECT [codigo] FROM [Asignaturas]"></asp:SqlDataSource>
                                <br />
                                <asp:Label ID="Label3" runat="server" Text="La media de dedicación es:"></asp:Label>
                                <asp:Label ID="Label1" runat="server" Font-Size="Medium"></asp:Label>
                                <br />
                                <br />
                                <br />
                            </ContentTemplate>
                        </asp:UpdatePanel>
<br />
<br />
            <br />
        </div>
    </form>
</body>
</html>
