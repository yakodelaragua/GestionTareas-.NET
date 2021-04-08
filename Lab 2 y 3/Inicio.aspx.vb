Public Class WebForm1
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        accesoDatosSQL.Conectar()
        accesoDatosSQL.eliminarNoConfirmados()
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        accesoDatosSQL.Conectar()

        Dim pass As String = encriptarPass(tPass.Text)
        Dim exists = accesoDatosSQL.iniciarSesion(tEmail.Text, pass)

        If (Not exists) Then
            Label1.Text = "El usuario o contraseña son incorrectos"
            tPass.Text = ""
        Else
            Session.Add("email", tEmail.Text)
            Dim t = accesoDatosSQL.tipoUsuario(tEmail.Text)

            If (t = 1) Then
                Session("tipo") = 1
                If (tEmail.Text = "vadillo@ehu.es") Then
                    FormsAuthentication.SetAuthCookie("Vadillo", True)
                Else
                    FormsAuthentication.SetAuthCookie("Profesor", True)
                End If
                Application("lProfesor").add(Session("email"))
                HttpContext.Current.Response.Redirect("~/Profesor/Profesor.aspx")
            ElseIf (t = 2) Then
                Dim lProf As List(Of String) = Application("lProfesor")
                lProf.Add(tEmail.Text)
                Application("lProfesor") = lProf

                FormsAuthentication.SetAuthCookie("Alumno", True)
                Application("lAlumno").add(Session("email"))
                HttpContext.Current.Response.Redirect("~/Alumno/Alumno.aspx")
            End If
        End If

    End Sub

    Private Function encriptarPass(ByVal pass As String) As String
        Dim hash As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim bytValue() As Byte
        Dim bytHash() As Byte

        encriptarPass = ""
        bytValue = System.Text.Encoding.UTF8.GetBytes(pass)
        bytHash = hash.ComputeHash(bytValue)
        hash.Clear()

        Dim i As Integer
        For i = 0 To bytHash.Length - 1
            encriptarPass &= bytHash(i).ToString("x").PadLeft(2, "0")
        Next

    End Function
End Class