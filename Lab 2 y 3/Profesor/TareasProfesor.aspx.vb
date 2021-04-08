Public Class WebForm9
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load, GridView1.DataBinding, DropDownList1.SelectedIndexChanged
        If (ScriptManager1.IsInAsyncPostBack) Then

        End If
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Response.Redirect("~/Profesor/InsertarTarea.aspx")
    End Sub

    Protected Sub LinkButton1_Click(sender As Object, e As EventArgs) Handles LinkButton1.Click
        Session.Remove("email")
        Response.Redirect("~/Inicio.aspx")

    End Sub


    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged
        System.Threading.Thread.Sleep(2000)
    End Sub


End Class