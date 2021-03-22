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
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
          
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/TareasProfesor.aspx">Tareas</asp:HyperLink>
          
            <br />
          
            <br />
          
        </div>
      
        <asp:HyperLink ID="HyperLink2" runat="server">Asignaturas</asp:HyperLink>
        <br />
       <br />
        <asp:HyperLink ID="HyperLink3" runat="server">Grupos</asp:HyperLink>
        
      
        <br />
        <br />
        <br />
        <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/ImportarTareasXMLDocument.aspx">Importar v. XMLDocument</asp:HyperLink>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink5" runat="server">Exportar</asp:HyperLink>
        </form>
     </body>
</html>
