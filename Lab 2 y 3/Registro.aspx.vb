Public Class Registro
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim result As String
        result = accesoDatosSQL.Conectar()
        Label1.Text = result
    End Sub

    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        accesoDatosSQL.cerrarconexion()
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles bRegister.Click
        Randomize()
        Dim numconfirm = CLng(Rnd() * 9000000) + 1000000
        accesoDatosSQL.insertar(tEmail.Text, tName.Text, tSurname.Text, numconfirm, False, rbList.SelectedValue, tPass1.Text, 0)

    End Sub
End Class