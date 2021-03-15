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
            Dim t = accesoDatosSQL.tipoUsuario(tEmail.Text)
            If (t = 1) Then
                HttpContext.Current.Response.Redirect("~/Profesor.aspx")
            ElseIf (t = 2) Then
                HttpContext.Current.Response.Redirect("~/Alumno.aspx")
            End If
        End If



    End Sub
End Class