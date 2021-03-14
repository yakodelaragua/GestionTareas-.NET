Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class WebForm7
    Inherits System.Web.UI.Page
    Dim conClsf As SqlConnection = New SqlConnection("Server=tcp:hads21-14.database.windows.net,1433;Initial Catalog=HADS21-14;Persist Security Info=False;User ID=yaracerio99@outlook.es@hads21-14;Password=Antonio14;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")
    Dim dapTareas As New SqlDataAdapter()
    Dim dstTareas As New DataSet()
    Dim tblTareas As New DataTable()

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        TBUsuario.Text = Request.QueryString("Usuario")
        TBTarea.Text = Request.QueryString("Tarea")
        TBHorasEstimadas.Text = Request.QueryString("Horas")

        If Page.IsPostBack Then
            dstTareas = Session("datos")
            dapTareas = Session("adaptador")
        Else
            dapTareas = New SqlDataAdapter("SELECT * FROM EstudiantesTareas", conClsf)
            Dim bldTareas As New SqlCommandBuilder(dapTareas)
            bldTareas.QuotePrefix = "["
            bldTareas.QuoteSuffix = "]"
            dapTareas.Fill(dstTareas, "EstudiantesTareas")
            tblTareas = dstTareas.Tables("EstudiantesTareas")
            Session("datos") = dstTareas
            Session("adaptador") = dapTareas
        End If
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' tblTareas = dstTareas.Tables("EstudiantesTareas")
        'Dim rowTareas As DataRow = tblTareas.NewRow()
        'rowTareas("Email") = TBUsuario.Text
        'rowTareas("CodTarea") = TBTarea.Text
        ' rowTareas("HEstimadas") = TBHorasEstimadas.Text
        'rowTareas("HReales") = TBHorasReales.Text
        ' tblTareas.Rows.Add(rowTareas)
        accesoDatosSQL.update(TBTarea.Text, TBHorasReales.Text)
        'dapTareas.Update(tblTareas)
    End Sub


End Class