﻿Public Class WebUserControl
    Inherits System.Web.UI.UserControl
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()

        For Each elem As String In Application("lProfesor")
            ListBox1.Items.Add(elem)
        Next

        For Each elem As String In Application("lAlumno")
            ListBox2.Items.Add(elem)
        Next

        If (ListBox1.Items.Count > 0) Then
            lProfesor.Text = ListBox1.Items.Count
        Else
            lProfesor.Text = 0
        End If

        If (ListBox2.Items.Count > 0) Then
            lAlum.Text = ListBox2.Items.Count
        Else
            lAlum.Text = 0
        End If

    End Sub

End Class