Public Class WebForm15
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If ScriptManager1.IsInAsyncPostBack.Equals(False) Then
            DropDownList1.SelectedValue = "ADSI"
        End If

        Dim ws As New Dedicacion.WebService1
        Dim res = ws.dedAcumulada(DropDownList1.SelectedValue)
        Label1.Text = res.ToString

    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged

    End Sub
End Class