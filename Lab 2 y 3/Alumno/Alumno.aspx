<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Alumno.aspx.vb" Inherits="Lab_2_y_3.WebForm5" %>

<%@ Register src="../WebUserControl.ascx" tagname="WebUserControl" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #form1 {
            width: 600px;
            height: 348px;
        }
        .auto-style1 {
            width: 156px;
            height: 464px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style1">
        <div>

          
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Alumno/TareasAlumno.aspx">Tareas Genéricas</asp:HyperLink>
          
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
        <br />
        <uc1:WebUserControl ID="WebUserControl1" runat="server" />
        <p>
        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Logout.aspx">Cerrar Sesión</asp:LinkButton>
        </p>
        </form>
     </body>
</html>
