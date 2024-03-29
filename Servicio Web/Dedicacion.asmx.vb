﻿Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Web.Services
Imports System.Web.Services.Protocols

' Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente.
<System.Web.Script.Services.ScriptService()>
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class WebService1
    Inherits System.Web.Services.WebService
    Private Shared conexion As New SqlConnection
    Private Shared comando As New SqlCommand
    <WebMethod()>
    Public Function dedAcumulada(ByVal asignatura As String) As String
        'abrir conexion
        Try
            conexion.ConnectionString = "Server=tcp:hads21-14.database.windows.net,1433;Initial Catalog=HADS21-14;Persist Security Info=False;User ID=yaracerio99@outlook.es@hads21-14;Password=Antonio14;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"
            conexion.Open()
        Catch ex As Exception
            Return "ERROR DE CONEXIÓN: " + ex.Message
        End Try

        Dim st = "select avg(et.HReales) from EstudiantesTareas as et inner join TareasGenericas as tg on et.CodTarea = tg.Codigo where CodAsig='" + asignatura + "'"
        comando = New SqlCommand(st, conexion)
        Try
            Dim reader = comando.ExecuteReader()
            If reader.HasRows Then
                reader.Read()
                Try
                    Dim resul = reader.GetInt32(0)
                    conexion.Close()
                    reader.Close()
                    Return resul
                Catch ex As Exception
                    conexion.Close()
                    reader.Close()
                    Return 0
                End Try

            Else
                reader.Close()
                conexion.Close()
                Return -2
            End If
        Catch ex As Exception
            conexion.Close()
            Return -3
        End Try

        Return False
    End Function

End Class