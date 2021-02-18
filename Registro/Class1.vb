Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Data

Public Class accesoDatosSQL
    Private Shared conexion As New SqlConnection
    Private Shared comando As New SqlCommand
    Public Shared Function Conectar() As String
        Try
            conexion.ConnectionString = "Server=tcp:hads21-14.database.windows.net,1433;Initial Catalog=HADS21-14;Persist Security Info=False;User ID=yaracerio99@outlook.es@hads21-14;Password=Antonio14;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"
            conexion.Open()
        Catch ex As Exception
            Return "ERROR DE CONEXIÓN: " + ex.Message
        End Try
        Return "CONEXION OK"
    End Function
    Public Shared Sub cerrarconexion()
        conexion.Close()
    End Sub

    Public Shared Function insertar(ByVal email As String, ByVal nombre As String, ByVal apellidos As String, ByVal numconfir As Integer, ByVal confirmado As Boolean, ByVal tipo As String, ByVal pass As String, ByVal codPass As Integer) As String
        Dim conf
        If (confirmado = True) Then
            conf = 1
        Else
            conf = 0
        End If

        Dim type
        If (tipo = "rbStudent") Then
            type = "Alumno"
        Else
            type = "Profesor"
        End If

        Dim st = "insert into Usuarios values ('" & email & "', '" & nombre & "', '" & apellidos & "', " & numconfir & ", " & conf & ", '" & type & "', '" & pass & "', " & codPass & ");"
        Dim numregs As Integer
        comando = New SqlCommand(st, conexion)
        Try
            numregs = comando.ExecuteNonQuery()
        Catch ex As Exception
            Return ex.Message
        End Try
        Return (numregs & " registro(s) insertado(s) en la BD ")
    End Function


End Class
