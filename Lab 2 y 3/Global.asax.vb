Imports System.Web.SessionState

Public Class Global_asax
    Inherits System.Web.HttpApplication

    Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena al iniciar la aplicación
        Dim lProfesor As New List(Of String)
        Dim lAlumno As New List(Of String)

        Application("lProfesor") = lProfesor
        Application("lAlumno") = lAlumno

    End Sub

    Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena al iniciar la sesión

    End Sub

    Sub Application_BeginRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena al comienzo de cada solicitud
    End Sub

    Sub Application_AuthenticateRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena al intentar autenticar el uso
    End Sub

    Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena cuando se produce un error
    End Sub

    Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena cuando finaliza la sesión
        If Session("tipo") = 2 Then
            Application("lAlumno").Remove(Session("email"))
        Else
            Application("lProfesor").Remove(Session("email"))
        End If
    End Sub

    Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

End Class