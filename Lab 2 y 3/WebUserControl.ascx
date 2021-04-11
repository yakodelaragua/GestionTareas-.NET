<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="WebUserControl.ascx.vb" Inherits="Lab_2_y_3.WebUserControl" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<asp:ScriptManager ID="ScriptManager1" runat="server">
</asp:ScriptManager>
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
        <br />
        USUARIOS LOGUEADOS:
        <asp:Label ID="lAlum" runat="server"></asp:Label>
        &nbsp;Alumno/s y
        <asp:Label ID="lProfesor" runat="server"></asp:Label>
        &nbsp;Profe/s<br />
        <br />
        <asp:ListBox ID="ListBox2" runat="server" Enabled="False" Height="73px" Width="128px"></asp:ListBox>
        <asp:ListBox ID="ListBox1" runat="server" Height="74px" Width="135px" Enabled="False"></asp:ListBox>
        <br />
        <asp:Timer ID="Timer1" runat="server" Interval="2000">
        </asp:Timer>
        <br />
    </ContentTemplate>
</asp:UpdatePanel>



