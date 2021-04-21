Imports System.ComponentModel
Imports System.Web.Services
Imports System.Web.Services.Protocols

' Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente.
<System.Web.Script.Services.ScriptService()>
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class WebService1
    Inherits System.Web.Services.WebService

    <WebMethod()>
    Public Function passSecurity(ByVal pass As String) As String
        Dim er1 As String = "(.){6,}" '>=6 cualquier expresion con mas de 6 caracteres
        Dim er2 As String = "(?=\w*\d)(?=\w*[A-Z])(?=\w*[a-z])\S{8,16}" 'digitos, minusculas y mayusculas
        Dim er3 As String = "(?=.*\d)(?=.*[\u0021-\u002b\u003c-\u0040])(?=.*[A-Z])(?=.*[a-z])\S{8,16}" 'digitos, mayusculas, minusculas y simbolos

        Dim r1 As Regex = New Regex(er1)
        Dim r2 As Regex = New Regex(er2)
        Dim r3 As Regex = New Regex(er3)

        If r3.IsMatch(pass) Then
            'high security
            Return 3
        End If

        If r2.IsMatch(pass) Then
            'medium security
            Return 2
        End If

        If r1.IsMatch(pass) Then
            'low security
            Return 1
        End If
        Return 0

    End Function

End Class