Public Class WebForm3
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim result As String
        result = accesoDatosSQL.Conectar()
    End Sub

    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        accesoDatosSQL.cerrarconexion()
    End Sub

    Protected Sub bRestablecer_Click(sender As Object, e As EventArgs) Handles bRestablecer.Click
        If tNewPass1.Text = tNewPass2.Text Then
            If accesoDatosSQL.modificarContraseña(tEmail.Text, tNewPass1.Text, tCode.Text) = False Then
                lPassDiferente.Text = "Comprueba que el código introducido sea correcto"
            Else
                bRestablecer.Enabled = False
                tCode.Enabled = False
                tNewPass1.Enabled = False
                tNewPass2.Enabled = False
                lPassModificada.Text = "Se ha modificado la contraseña"

            End If

        Else
            lPassDiferente.Text = "La contraseña no coincide"
        End If
    End Sub

    Protected Sub bEnviar_Click(sender As Object, e As EventArgs) Handles bEnviar.Click
        If accesoDatosSQL.estaRegistrado(tEmail.Text) Then
            Dim correoCorrecto = accesoDatosSQL.emailContraseña(tEmail.Text)
            If correoCorrecto = True Then
                bRestablecer.Enabled = True
                tCode.Enabled = True
                tNewPass1.Enabled = True
                tNewPass2.Enabled = True
                tEmail.Enabled = False
            End If
        Else
            lPassDiferente.Text = "El correo introducido no está registrado"
        End If

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles bInicio.Click

    End Sub
End Class