<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ImportarTareasXMLDocument.aspx.vb" Inherits="Lab_2_y_3.WebForm12" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 300px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            PROFESOR<br />
            IMPORTAR TAREAS GENÉRICAS<br />
            <br />
            <table style="width: 100%; height: 231px;">
                <tr>
                    <td class="auto-style1">
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="codigoasig" DataValueField="codigoasig" AutoPostBack="True">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:HADS21-14ConnectionString %>" SelectCommand="SELECT GruposClase.codigoasig FROM ProfesoresGrupo INNER JOIN GruposClase ON ProfesoresGrupo.codigogrupo = GruposClase.codigo WHERE (ProfesoresGrupo.email = @email)">
                <SelectParameters>
                    <asp:SessionParameter Name="email" SessionField="email" DefaultValue="blanco@ehu.es" />
                </SelectParameters>
            </asp:SqlDataSource>
                    </td>
                    <td>
                        <asp:Xml ID="Xml1" runat="server" DocumentSource="~/App_Data/HAS.xml" TransformSource="~/App_Data/VerTablaTareas.xsl"></asp:Xml>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Button ID="Button1" runat="server" Text="IMPORTAR (XMLD)" />
                        <br />
                        <asp:Label ID="lError" runat="server" Text="lError"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:HyperLink ID="HyperLink1" runat="server">Menú profesor</asp:HyperLink>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
