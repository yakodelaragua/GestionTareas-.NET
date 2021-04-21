<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm11.aspx.vb" Inherits="Lab_2_y_3.WebForm11" %>

<%@ Register src="../WebUserControl.ascx" tagname="WebUserControl" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #form1 {
            width: 141px;
            height: 348px;
        }
        .auto-style1 {
            width: 672px;
            height: 404px;
        }
        .auto-style2 {
            width: 791%;
            height: 375px;
        }
        .auto-style3 {
            margin-bottom: 0px;
        }
        .auto-style4 {
            margin-bottom: 4px;
        }
        .auto-style5 {
            width: 374px;
        }
        .auto-style6 {
            width: 374px;
            height: 378px;
        }
        .auto-style7 {
            height: 378px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style1">
        <div>
          
            <table class="auto-style2">
                <tr>
                    <td class="auto-style6">
          
                        <asp:Panel ID="Panel1" runat="server" BorderColor="#CCCCCC" BorderStyle="Solid" Height="347px" Width="163px">
                            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Profesor/TareasProfesor.aspx">Tareas</asp:HyperLink>
                            <br />
                            <br />
                            <asp:HyperLink ID="HyperLink2" runat="server">Asignaturas</asp:HyperLink>
                            <br />
                            <br />
                            <asp:HyperLink ID="HyperLink3" runat="server">Grupos</asp:HyperLink>
                            <br />
                            <br />
                            <br />
                            <asp:HyperLink ID="HyperLink4" runat="server" BackColor="#CCCCCC" BorderColor="#666666" BorderStyle="Solid" CssClass="auto-style3" Height="44px" NavigateUrl="~/Vadillo/ImportarTareasXMLDocument.aspx" Width="141px">Importar v. XMLDocument</asp:HyperLink>
                            <br />
                            <br />
                            <asp:HyperLink ID="HyperLink5" runat="server" BackColor="#CCCCCC" BorderColor="#666666" BorderStyle="Solid" CssClass="auto-style4" Height="38px" NavigateUrl="~/Vadillo/ExportarTareas.aspx" Width="141px">Exportar</asp:HyperLink>
                            <br />
                            <br />
                            <asp:HyperLink ID="HyperLink6" runat="server" BackColor="#CCCCCC" BorderColor="#666666" BorderStyle="Solid" CssClass="auto-style4" Height="38px" NavigateUrl="~/Vadillo/coordinador.aspx" Width="141px">Dedicación acumulada</asp:HyperLink>
                        </asp:Panel>
                        <br />
                    </td>
                    <td class="auto-style7">
                        <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" Text="Gestión Web de Tareas-Dedicación Profesores"></asp:Label>
                    </td>
                    <td class="auto-style7"></td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <uc1:WebUserControl ID="WebUserControl1" runat="server" />
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">
        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Logout.aspx">Cerrar Sesión</asp:LinkButton>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
          
            <br />
          
            <br />
          
        </div>
      
        <br />
       <br />
        
      
        <br />
        <br />
        <br />
        <br />
        <br />
        </form>
     </body>
</html>
