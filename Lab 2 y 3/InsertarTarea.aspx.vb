Imports System.Data.SqlClient
Public Class WebForm10
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
            bldTareas.QuotePrefix = "["
            bldTareas.QuoteSuffix = "]"
            dapTareas.Fill(dstTareas, "TareasGenericas")
            tblTareas = dstTareas.Tables("TareasGenericas")
            Session("datos") = dstTareas
            Session("adaptador") = dapTareas
            Session("builder") = bldTareas
        End If
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        tblTareas = dstTareas.Tables("TareasGenericas")
        Dim rowTareas As DataRow = tblTareas.NewRow()
        rowTareas("Codigo") = tCode.Text
        rowTareas("Descripcion") = tDescripcion.Text
        rowTareas("CodAsig") = dAsignatura.SelectedValue
        rowTareas("HEstimadas") = tHoras.Text
        rowTareas("Explotacion") = 0
        rowTareas("TipoTarea") = dTarea.SelectedValue
        tblTareas.Rows.Add(rowTareas)
        dapTareas.Update(tblTareas)

    End Sub

    Protected Sub tHoras_TextChanged(sender As Object, e As EventArgs) Handles tHoras.TextChanged

    End Sub
End Class