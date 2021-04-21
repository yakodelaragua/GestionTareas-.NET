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

        Dim er1 As String = "([A-Za-z]){6,}" '>=6 alphabethic characters
        Dim er2 As String = "([A-Za-z0-9]){9,}" '>=9 alphanumeric characters
        Dim er3 As String = "([A-Za-z0-9!@#$%^&*()_]){12,}" '>=12 (alphanumeric characters + symbols)

        Dim r1 As Regex = New Regex(er1)
        Dim r2 As Regex = New Regex(er2)
        Dim r3 As Regex = New Regex(er3)

        Dim security = 0

        If r1.IsMatch(pass) Then
            'low security
            security = 1
        End If

        If r2.IsMatch(pass) Then
            'medium security
            security = 2
        End If

        If r3.IsMatch(pass) Then
            'high security
            security = 3
        End If

        Return security
    End Function

End Class