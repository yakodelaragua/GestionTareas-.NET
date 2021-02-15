Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Data

Public Class accesoDatosSQL
    Private Shared conexion As New SqlConnection
    Private Shared comando As New SqlCommand
    Public Function Conectar() As String
        Try
            conexion.ConnectionString = “string para la BD de Azure"
            conexion.Open()
        Catch ex As Exception
            Return "ERROR DE CONEXIÓN: " + ex.Message
        End Try
        Return "CONEXION OK"
    End Function
End Class
