<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="TareasAlumno.aspx.vb" Inherits="Lab_2_y_3.WebForm6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel1" runat="server" HorizontalAlign="Center">
                ALUMNOS<br /> GESTIÓN DE TAREAS GENÉRICAS</asp:Panel>
        </div>
    <p>
        Seleccionar Asignatura (solo se muestran aquellas en las que está matriculado):</p>
    <p>
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="codigoasig" DataValueField="codigoasig">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:HADS21-14ConnectionString %>" SelectCommand="SELECT GruposClase.codigoasig FROM GruposClase INNER JOIN EstudiantesGrupo ON GruposClase.codigo = EstudiantesGrupo.Grupo WHERE (EstudiantesGrupo.Email = @email)">
            <SelectParameters>
                <asp:SessionParameter DefaultValue="" Name="email" SessionField="email" />
            </SelectParameters>
        </asp:SqlDataSource>
        </p>
    </form>
    </body>
</html>
