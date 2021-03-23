Imports System.Data.SqlClient
Imports System.IO
Imports System.Text

Public Class WebForm13
    Inherits System.Web.UI.Page
    Dim conClsf As SqlConnection = New SqlConnection("Server=tcp:hads21-14.database.windows.net,1433;Initial Catalog=HADS21-14;Persist Security Info=False;User ID=yaracerio99@outlook.es@hads21-14;Password=Antonio14;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")
    Dim dapTareas As New SqlDataAdapter()
    Dim dstTareas As New DataSet()
    Dim tblTareas As New DataTable()
    Dim bldTareas As SqlCommandBuilder
    Dim asig

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack Then
            asig = DropDownList1.SelectedValue
        End If
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dapTareas = New SqlDataAdapter("SELECT * FROM TareasGenericas where CodAsig ='" + asig + "'", conClsf)
        bldTareas = New SqlCommandBuilder(dapTareas)
        dstTareas.DataSetName = "Tareas"
        dapTareas.Fill(dstTareas, "Tarea")
        tblTareas = dstTareas.Tables("Tarea")
        tblTareas.Columns.Item(0).ColumnMapping = MappingType.Attribute
        tblTareas.Columns.Remove("CodAsig")
        dstTareas = tblTareas.DataSet
        Dim filename = DropDownList1.SelectedValue + ".xml"
        Dim f As FileStream = File.Create(Server.MapPath("App_Data/" + filename))
        dstTareas.WriteXml(f)
        f.Close()


    End Sub
End Class