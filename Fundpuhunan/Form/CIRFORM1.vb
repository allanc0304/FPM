Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Header

Public Class CIRFORM1
    Private Sub Label88_Click(sender As Object, e As EventArgs) Handles Label88.Click

    End Sub

    Private Sub ListView1_Click(sender As Object, e As EventArgs) Handles ListView1.Click
        If ListView1.SelectedItems.Count > 0 Then
            TextBox48.Text = ListView1.SelectedItems(0).SubItems(0).Text
            TextBox75.Text = ListView1.SelectedItems(0).SubItems(1).Text
            TextBox76.Text = ListView1.SelectedItems(0).SubItems(2).Text
            TextBox77.Text = ListView1.SelectedItems(0).SubItems(3).Text
            TextBox78.Text = ListView1.SelectedItems(0).SubItems(4).Text
            TextBox79.Text = ListView1.SelectedItems(0).SubItems(5).Text
        End If
    End Sub

    Private Sub Label218_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub CIRFORM1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim newitem As New ListViewItem(TextBox48.Text)
        newitem.SubItems.Add(TextBox75.Text)
        newitem.SubItems.Add(TextBox76.Text)
        newitem.SubItems.Add(TextBox77.Text)
        newitem.SubItems.Add(TextBox78.Text)
        newitem.SubItems.Add(TextBox79.Text)

        ListView1.Items.Add(newitem)

        TextBox48.Text = ""
        TextBox75.Text = ""
        TextBox76.Text = ""
        TextBox77.Text = ""
        TextBox78.Text = ""
        TextBox79.Text = ""
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If ListView1.SelectedItems.Count > 0 Then
            ListView1.SelectedItems(0).SubItems(0).Text = TextBox48.Text
            ListView1.SelectedItems(0).SubItems(1).Text = TextBox75.Text
            ListView1.SelectedItems(0).SubItems(2).Text = TextBox76.Text
            ListView1.SelectedItems(0).SubItems(3).Text = TextBox77.Text
            ListView1.SelectedItems(0).SubItems(4).Text = TextBox78.Text
            ListView1.SelectedItems(0).SubItems(5).Text = TextBox79.Text

            TextBox48.Text = ""
            TextBox75.Text = ""
            TextBox76.Text = ""
            TextBox77.Text = ""
            TextBox78.Text = ""
            TextBox79.Text = ""
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If ListView1.SelectedItems.Count > 0 Then
            ListView1.Items.Remove(ListView1.SelectedItems(0))

            TextBox48.Text = ""
            TextBox75.Text = ""
            TextBox76.Text = ""
            TextBox77.Text = ""
            TextBox78.Text = ""
            TextBox79.Text = ""
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ListView1.Items.Clear()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim newitem As New ListViewItem(TextBox80.Text)
        newitem.SubItems.Add(TextBox81.Text)
        newitem.SubItems.Add(TextBox82.Text)
        newitem.SubItems.Add(TextBox83.Text)
        newitem.SubItems.Add(TextBox84.Text)
        ListView2.Items.Add(newitem)

        TextBox80.Text = ""
        TextBox81.Text = ""
        TextBox82.Text = ""
        TextBox83.Text = ""
        TextBox84.Text = ""
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If ListView2.SelectedItems.Count > 0 Then
            ListView2.SelectedItems(0).SubItems(0).Text = TextBox80.Text
            ListView2.SelectedItems(0).SubItems(1).Text = TextBox81.Text
            ListView2.SelectedItems(0).SubItems(2).Text = TextBox82.Text
            ListView2.SelectedItems(0).SubItems(3).Text = TextBox83.Text
            ListView2.SelectedItems(0).SubItems(4).Text = TextBox84.Text

            TextBox80.Text = ""
            TextBox81.Text = ""
            TextBox82.Text = ""
            TextBox83.Text = ""
            TextBox84.Text = ""
        End If
    End Sub

    Private Sub ListView2_Click(sender As Object, e As EventArgs) Handles ListView2.Click
        If ListView2.SelectedItems.Count > 0 Then
            TextBox80.Text = ListView2.SelectedItems(0).SubItems(0).Text
            TextBox81.Text = ListView2.SelectedItems(0).SubItems(1).Text
            TextBox82.Text = ListView2.SelectedItems(0).SubItems(2).Text
            TextBox83.Text = ListView2.SelectedItems(0).SubItems(3).Text
            TextBox84.Text = ListView2.SelectedItems(0).SubItems(4).Text
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If ListView2.SelectedItems.Count > 0 Then
            ListView2.Items.Remove(ListView2.SelectedItems(0))

            TextBox80.Text = ""
            TextBox81.Text = ""
            TextBox82.Text = ""
            TextBox83.Text = ""
            TextBox84.Text = ""
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        ListView2.Items.Clear()
    End Sub
End Class