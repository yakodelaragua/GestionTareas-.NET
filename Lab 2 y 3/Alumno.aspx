<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Alumno.aspx.vb" Inherits="Lab_2_y_3.WebForm5" %>

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
          
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/TareasAlumno.aspx">Tareas Genéricas</asp:HyperLink>
          
            <br />
          
            <br />
          
        </div>
      
        <asp:HyperLink ID="HyperLink2" runat="server">Tareas propias</asp:HyperLink>
        <br />
       <br />
        <asp:HyperLink ID="HyperLink3" runat="server">Grupos</asp:HyperLink>
        
      
        <br />
        <br />
        <br />
        </form>
     </body>
</html>
