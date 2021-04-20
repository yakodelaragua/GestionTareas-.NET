Public Class WebForm15
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim ws As New Dedicacion.WebService1SoapClient
        Dim res = ws.dedAcumulada(DropDownList1.SelectedValue)
        Label1.Text = res.ToString

    End Sub
End Class