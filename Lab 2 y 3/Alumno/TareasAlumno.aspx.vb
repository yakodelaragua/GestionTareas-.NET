Imports System.Data.OleDb

Public Class WebForm6
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub SqlDataSource1_Selecting(sender As Object, e As SqlDataSourceSelectingEventArgs) Handles SqlDataSource1.Selecting

    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs)
        '  Dim conClsf As OleDbConnection
        '  Dim dapMbrs As OleDbDataAdapter
        ' Dim dstMbrs As DataSet
        'conClsf = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=HADS21-14;User ID=yaracerio99@outlook.es@hads21-14;Password=Antonio14;")
        ' dapMbrs = New OleDbDataAdapter("select * from Usuarios", conClsf)
        ' dstMbrs = New DataSet()
        ' dapMbrs.Fill(dstMbrs, "Usuarios") 'Se carga la tabla Members en una Datable de un DataSet
        '  GridView2.DataSource = dstMbrs.Tables("Usuarios") 'Se enlaza la DataTable con el DataGrid
        '  GridView2.DataBind()

    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged1(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged

    End Sub

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged
        Dim Tarea = GridView1.SelectedRow.Cells(1).Text
        Dim Usuario = Session("email")
        Dim Horas = GridView1.SelectedRow.Cells(3).Text

        Response.Redirect("Alumno/InstanciarTarea.aspx?Tarea=" + Tarea + "&Usuario=" + Usuario + "&Horas=" + Horas)
    End Sub

    Protected Sub LinkButton1_Click(sender As Object, e As EventArgs) Handles LinkButton1.Click
        Session.Remove("email")
    End Sub
End Class