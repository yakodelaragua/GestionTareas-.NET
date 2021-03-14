Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Data
Imports System.Net.Mail

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

    Public Shared Function iniciarSesion(ByVal email As String, ByVal pass As String)
        Try
            Dim st = "select * from Usuarios where email='" + email + "' and pass='" + pass + "';"
            comando = New SqlCommand(st, conexion)
            Dim sql As SqlDataReader
            Try
                sql = comando.ExecuteReader()
            Catch ex As Exception
                Return ex.Message
            End Try
            If sql.HasRows Then
                sql.Close()
                Return True
            Else
                sql.Close()
                Return False
            End If
        Catch ex As Exception
            Return ex.Message
        End Try
        Return False
    End Function

    Public Shared Function enviarEmail(ByVal email As String, ByVal numConfirm As Integer) As Boolean
        Try
            'Direccion de origen
            Dim from_address As New MailAddress("emailconfirmation14@gmail.com", "HADS21-14")
            'Direccion de destino
            Dim to_address As New MailAddress(email)
            'Password de la cuenta
            Dim from_pass As String = "pepe14pruebas"
            'Objeto para el cliente smtp
            Dim smtp As New SmtpClient
            'Host en este caso el servidor de gmail
            smtp.Host = "smtp.gmail.com"
            'Puerto
            smtp.Port = 587
            'SSL activado para que se manden correos de manera segura
            smtp.EnableSsl = True
            'No usar los credenciales por defecto ya que si no no funciona
            smtp.UseDefaultCredentials = False
            'Credenciales
            smtp.Credentials = New System.Net.NetworkCredential(from_address.Address, from_pass)
            'Creamos el mensaje con los parametros de origen y destino
            Dim message As New MailMessage(from_address, to_address)
            'Añadimos el asunto
            message.Subject = "Confirmación de correo"
            'Concatenamos el cuerpo del mensaje a la plantilla
            message.Body = "<html><head></head><body>" + "<h1>Pulse CONTINUAR para confirmar el registro</h1>" + "<a href=" + "https://localhost:44348/Confirmar.aspx?email=" + email + "&numconf=" + numConfirm.ToString + ">CONTINUAR</a>" + "<br></br>Si ha recibido este correo por error ignórelo</body></html>"
            'Definimos el cuerpo como html para poder escojer mejor como lo mandamos
            message.IsBodyHtml = True
            'Se envia el correo
            smtp.Send(message)
        Catch e As Exception
            Return False
        End Try
        Return True
    End Function

    Public Shared Function emailContraseña(ByVal email As String) As Integer
        Try
            'Direccion de origen
            Dim from_address As New MailAddress("emailconfirmation14@gmail.com", "HADS21-14")
            'Direccion de destino
            Dim to_address As New MailAddress(email)
            'Password de la cuenta
            Dim from_pass As String = "pepe14pruebas"
            'Objeto para el cliente smtp
            Dim smtp As New SmtpClient
            'Host en este caso el servidor de gmail
            smtp.Host = "smtp.gmail.com"
            'Puerto
            smtp.Port = 587
            'SSL activado para que se manden correos de manera segura
            smtp.EnableSsl = True
            'No usar los credenciales por defecto ya que si no no funciona
            smtp.UseDefaultCredentials = False
            'Credenciales
            smtp.Credentials = New System.Net.NetworkCredential(from_address.Address, from_pass)
            'Creamos el mensaje con los parametros de origen y destino
            Dim message As New MailMessage(from_address, to_address)
            'Añadimos el asunto
            message.Subject = "Solicitud de cambio de contraseña"

            Dim codpass As Integer
            Randomize()
            codpass = Int((1000000 * Rnd()) + 1)

            Dim st = "update Usuarios set codpass=" + codpass.ToString + " where email='" + email + "';"
            comando = New SqlCommand(st, conexion)
            Dim numregs As Integer

            Try
                numregs = comando.ExecuteNonQuery()
            Catch ex As Exception
                Return ex.Message
            End Try
            'Concatenamos el cuerpo del mensaje a la plantilla
            message.Body = "<html><head></head><body>" + "<h1>Se ha solicitado un cambio de contraseña</h1> <p>Introduzca el siguiente código: </p>" + codpass.ToString + "<br></br> <p>Si ha recibido este mensaje por error ignórelo</p> </body></html>"
            'Definimos el cuerpo como html para poder escojer mejor como lo mandamos
            message.IsBodyHtml = True
            'Se envia el correo
            smtp.Send(message)
        Catch e As Exception
            Return False
        End Try
        Return True
    End Function

    Public Shared Function estaRegistrado(ByVal email As String) As Boolean
        Dim st = "select * from Usuarios where email='" + email + "';"
        comando = New SqlCommand(st, conexion)
        Dim sql As SqlDataReader

        Try
            sql = comando.ExecuteReader()
        Catch ex As Exception
            Return ex.Message
        End Try
        If sql.HasRows Then
            sql.Close()
            Return True
        Else
            sql.Close()
            Return False
        End If
    End Function
    Public Shared Function modificarContraseña(ByVal email As String, ByVal newPass As String, ByVal code As Integer) As Integer
        Try
            Dim st = "select * from Usuarios where email='" + email + "' and codpass=" + code.ToString + ";"
            comando = New SqlCommand(st, conexion)
            Dim sql As SqlDataReader

            Try
                sql = comando.ExecuteReader()
            Catch ex As Exception
                Return ex.Message
            End Try
            If sql.HasRows Then
                Dim st2 = "update Usuarios set pass='" + newPass + "'where email='" + email + "';"
                Dim numregs2 As Integer
                sql.Close()
                comando = New SqlCommand(st2, conexion)
                Try
                    numregs2 = comando.ExecuteNonQuery()
                Catch ex As Exception
                    Return ex.Message
                End Try
            Else
                Return False
            End If

        Catch e As Exception
            Return False
        End Try
        Return True


    End Function

    Public Shared Function confirmarUsuario(ByVal email As String, ByVal numconf As Integer)
        Dim st = "update Usuarios set confirmado = 1 where email = '" + email + "'"
        comando = New SqlCommand(st, conexion)
        Try
            Dim numregs = comando.ExecuteNonQuery()
        Catch ex As Exception
            Return ex.Message
        End Try
        Return True
    End Function
    Public Shared Function eliminarNoConfirmados()
        Dim st = "delete from Usuarios where Confirmado=0"
        Dim numregs As Integer
        comando = New SqlCommand(st, conexion)
        Try
            numregs = comando.ExecuteNonQuery()
        Catch ex As Exception
            Return ex.Message
        End Try
        Return True
    End Function

End Class
