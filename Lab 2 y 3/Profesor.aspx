<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm11.aspx.vb" Inherits="Lab_2_y_3.WebForm11" %>

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
            width: 236px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style1">
        <div>
          
            <table class="auto-style2">
                <tr>
                    <td class="auto-style5">
          
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/TareasProfesor.aspx">Tareas</asp:HyperLink>
          
                        <br />
                        <br />
      
        <asp:HyperLink ID="HyperLink2" runat="server">Asignaturas</asp:HyperLink>
                        <br />
                        <br />
        <asp:HyperLink ID="HyperLink3" runat="server">Grupos</asp:HyperLink>
        
      
                        <br />
                        <br />
                        <br />
        <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/ImportarTareasXMLDocument.aspx" BackColor="#CCCCCC" BorderColor="#666666" BorderStyle="Solid" CssClass="auto-style3" Height="44px" Width="141px">Importar v. XMLDocument</asp:HyperLink>
                        <br />
                        <br />
                        <br />
        <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/ExportarTareas.aspx" BackColor="#CCCCCC" BorderColor="#666666" BorderStyle="Solid" CssClass="auto-style4" Height="38px" Width="141px">Exportar</asp:HyperLink>
                        <br />
                    </td>
                    <td>
                        <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" Text="Gestión Web de Tareas-Dedicación Profesores"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
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
