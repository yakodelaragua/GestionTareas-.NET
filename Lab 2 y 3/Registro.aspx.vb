Public Class Registro
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim result As String
        result = accesoDatosSQL.Conectar()

    End Sub

    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        accesoDatosSQL.cerrarconexion()
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles bRegister.Click
        Randomize()
        Dim numconfirm = CLng(Rnd() * 9000000) + 1000000
        Dim exists = accesoDatosSQL.estaRegistrado(tEmail.Text)
        If (Not exists) Then
            If (tPass1.Text = tPass2.Text) Then
                Dim pass As String = encriptarPass(tPass1.Text)
                accesoDatosSQL.enviarEmail(tEmail.Text, numconfirm)
                accesoDatosSQL.insertar(tEmail.Text, tName.Text, tSurname.Text, numconfirm, False, rbList.SelectedValue, pass, 0)
                Label1.Text = "Compruebe la bandeja de entrada de su correo"
                Label2.Text = ""
            Else
                Label2.Text = "Las contraseñas no coinciden"
            End If
        Else
            Label1.Text = ""
            Label2.Text = "Ya se ha registrado con este correo, pruebe con otro"
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