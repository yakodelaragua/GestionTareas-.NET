Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports System.Xml

Public Class WebForm13
    Inherits System.Web.UI.Page
    Dim conClsf As SqlConnection = New SqlConnection("Server=tcp:hads21-14.database.windows.net,1433;Initial Catalog=HADS21-14;Persist Security Info=False;User ID=yaracerio99@outlook.es@hads21-14;Password=Antonio14;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")
    Dim dapTareas As New SqlDataAdapter()
    Dim dstTareas As New DataSet()
    Dim tblTareas As New DataTable("Tarea")
    Dim bldTareas As SqlCommandBuilder
    Dim asig

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack Then
            asig = DropDownList1.SelectedValue
        End If
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dapTareas = New SqlDataAdapter("SELECT Codigo, Descripcion, HEstimadas, Explotacion, TipoTarea FROM TareasGenericas where CodAsig ='" + asig + "'", conClsf)
        bldTareas = New SqlCommandBuilder(dapTareas)
        dapTareas.Fill(dstTareas)
        tblTareas = dstTareas.Tables.Item(0)
        tblTareas.TableName = "tarea"
        tblTareas.Columns.Item(0).ColumnMapping = MappingType.Attribute
        dstTareas = tblTareas.DataSet
        dstTareas.DataSetName = "tareas"
        dstTareas.WriteXml(Server.MapPath("App_Data/" + DropDownList1.SelectedValue + ".xml"))
        Dim xml As New XmlDocument
        xml.Load(Server.MapPath("App_Data/" + DropDownList1.SelectedValue + ".xml"))
    End Sub
End Class