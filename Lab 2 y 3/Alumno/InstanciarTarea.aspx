<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="InstanciarTarea.aspx.vb" Inherits="Lab_2_y_3.WebForm7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Usuario<asp:TextBox ID="TBUsuario" runat="server" Width="145px"></asp:TextBox>
            <br />
            <br />
            Tarea<asp:TextBox ID="TBTarea" runat="server" Width="158px"></asp:TextBox>
            <br />
            <br />
            Horas Est.<asp:TextBox ID="TBHorasEstimadas" runat="server" Width="125px"></asp:TextBox>
            <br />
            <br />
            Horas reales<asp:TextBox ID="TBHorasReales" runat="server" Width="112px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Crear tarea" />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:HADS21-14ConnectionString %>" SelectCommand="SELECT [Email], [CodTarea], [HEstimadas], [HReales] FROM [EstudiantesTareas] WHERE ([CodTarea] &lt;&gt; @CodTarea)">
                <SelectParameters>
                    <asp:QueryStringParameter Name="CodTarea" QueryStringField="Tarea" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="Email,CodTarea" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="Email" HeaderText="Email" ReadOnly="True" SortExpression="Email" />
                    <asp:BoundField DataField="CodTarea" HeaderText="CodTarea" ReadOnly="True" SortExpression="CodTarea" />
                    <asp:BoundField DataField="HEstimadas" HeaderText="HEstimadas" SortExpression="HEstimadas" />
                    <asp:BoundField DataField="HReales" HeaderText="HReales" SortExpression="HReales" />
                </Columns>
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:HADS21-14ConnectionString %>" DeleteCommand="DELETE FROM [EstudiantesTareas] WHERE [Email] = @Email AND [CodTarea] = @CodTarea" InsertCommand="INSERT INTO [EstudiantesTareas] ([Email], [CodTarea], [HEstimadas], [HReales]) VALUES (@Email, @CodTarea, @HEstimadas, @HReales)" SelectCommand="SELECT * FROM [EstudiantesTareas]" UpdateCommand="UPDATE [EstudiantesTareas] SET [HEstimadas] = @HEstimadas, [HReales] = @HReales WHERE [Email] = @Email AND [CodTarea] = @CodTarea">
                <DeleteParameters>
                    <asp:Parameter Name="Email" Type="String" />
                    <asp:Parameter Name="CodTarea" Type="String" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="Email" Type="String" />
                    <asp:Parameter Name="CodTarea" Type="String" />
                    <asp:Parameter Name="HEstimadas" Type="Int32" />
                    <asp:Parameter Name="HReales" Type="Int32" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="HEstimadas" Type="Int32" />
                    <asp:Parameter Name="HReales" Type="Int32" />
                    <asp:Parameter Name="Email" Type="String" />
                    <asp:Parameter Name="CodTarea" Type="String" />
                </UpdateParameters>
            </asp:SqlDataSource>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/TareasAlumno.aspx">Página anterior</asp:HyperLink>
        </div>
    </form>
</body>
</html>
