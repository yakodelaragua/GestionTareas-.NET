Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        accesoDatosSQL.Conectar()
        accesoDatosSQL.eliminarNoConfirmados()
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        accesoDatosSQL.Conectar()
        Dim exists = accesoDatosSQL.iniciarSesion(tEmail.Text, tPass.Text)
        If (Not exists) Then
            Label1.Text = "El usuario o contraseña son incorrectos"
            tPass.Text = ""
        Else
            Session.Add("email", tEmail.Text)
            HttpContext.Current.Response.Redirect("~/TareasAlumno.aspx")
        End If



    End Sub
End Class