﻿Imports System.Data.SqlClient
Imports System.IO
Imports System.Text

Public Class WebForm13
    Inherits System.Web.UI.Page
    Dim conClsf As SqlConnection = New SqlConnection("Server=tcp:hads21-14.database.windows.net,1433;Initial Catalog=HADS21-14;Persist Security Info=False;User ID=yaracerio99@outlook.es@hads21-14;Password=Antonio14;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")
    Dim dapTareas As New SqlDataAdapter()
    Dim dstTareas As New DataSet()
    Dim tblTareas As New DataTable()
    Dim bldTareas As SqlCommandBuilder

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack Then
            dstTareas = Session("datos")
            dapTareas = Session("adaptador")
        Else
            dapTareas = New SqlDataAdapter("SELECT * FROM TareasGenericas", conClsf)
            bldTareas = New SqlCommandBuilder(dapTareas)
            dapTareas.Fill(dstTareas, "TareasGenericas")
            tblTareas = dstTareas.Tables("TareasGenericas")
            Session("datos") = dstTareas
            Session("adaptador") = dapTareas
        End If
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If dstTareas.Equals(vbNull) Then Return

        Dim filename = DropDownList1.SelectedValue + ".xml"
        Dim f As FileStream = File.Create(Server.MapPath("App_Data/" + filename))
        dstTareas.WriteXml(f)

    End Sub
End Class