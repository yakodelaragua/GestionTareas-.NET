Public Class WebForm3
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub bRestablecer_Click(sender As Object, e As EventArgs) Handles bRestablecer.Click
        accesoDatosSQL.modificarContraseña(tEmail.Text, tNewPass1.Text, tNewPass2.Text)
    End Sub

    Protected Sub bEnviar_Click(sender As Object, e As EventArgs) Handles bEnviar.Click
        Dim correoCorrecto = accesoDatosSQL.emailContraseña(tEmail.Text)
        If correoCorrecto = True Then
            bRestablecer.Enabled = True
        Else

        End If
    End Sub
End Class