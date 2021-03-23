Imports System.Data.SqlClient
Imports System.Xml

Public Class WebForm12
    Inherits System.Web.UI.Page
    Dim conClsf As SqlConnection = New SqlConnection("Server=tcp:hads21-14.database.windows.net,1433;Initial Catalog=HADS21-14;Persist Security Info=False;User ID=yaracerio99@outlook.es@hads21-14;Password=Antonio14;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")
    Dim dapTareas As New SqlDataAdapter()
    Dim dstTareas As New DataSet()
    Dim tblTareas As New DataTable()
    Dim bldTareas As SqlCommandBuilder
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Xml1.DocumentSource = Server.MapPath("App_Data/" & DropDownList1.SelectedValue & ".xml")
        Xml1.TransformSource = Server.MapPath("App_Data/VerTablaTareas.xsl")

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
        End If
    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged
        Xml1.DocumentSource = Server.MapPath("App_Data/" & DropDownList1.SelectedValue & ".xml")
        Xml1.TransformSource = Server.MapPath("App_Data/VerTablaTareas.xsl")
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim xd As New XmlDocument
        xd.Load(Server.MapPath("App_Data/" & DropDownList1.SelectedValue & ".xml"))
        Dim Tareas As XmlNodeList
        Tareas = xd.GetElementsByTagName("tarea")
        Dim nTarea As XmlNode
        Dim i As Integer
        For Each nTarea In Tareas
            tblTareas = dstTareas.Tables("TareasGenericas")
            Dim rowTareas As DataRow = tblTareas.NewRow()
            rowTareas("Codigo") = nTarea.Attributes.ItemOf(0).Value
            rowTareas("Descripcion") = nTarea.ChildNodes(0).ChildNodes(0).Value
            rowTareas("CodAsig") = DropDownList1.SelectedValue
            rowTareas("HEstimadas") = nTarea.ChildNodes(1).ChildNodes(0).Value
            rowTareas("Explotacion") = nTarea.ChildNodes(2).ChildNodes(0).Value
            rowTareas("TipoTarea") = nTarea.ChildNodes(3).ChildNodes(0).Value
            tblTareas.Rows.Add(rowTareas)
            Try
                dapTareas.Update(tblTareas)
            Catch ex As Exception

            End Try

        Next


        lError.Text = "Se han importado las tareas"




    End Sub

    Protected Sub SqlDataSource1_Selecting(sender As Object, e As SqlDataSourceSelectingEventArgs) Handles SqlDataSource1.Selecting

    End Sub
End Class