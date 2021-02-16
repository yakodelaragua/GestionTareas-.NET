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

End Class
