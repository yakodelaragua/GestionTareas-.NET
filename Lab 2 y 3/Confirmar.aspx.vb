Public Class WebForm2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim email = Request.QueryString("email")
        Dim numconf = Request.QueryString("numconf")
        accesoDatosSQL.Conectar()
        accesoDatosSQL.confirmarUsuario(email, numconf)



    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class