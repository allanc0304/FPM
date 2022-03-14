Public Class ApplictaionForm1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label31_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Label37_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ApplictaionForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        ApplicationForm2.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        OpenFileDialog1.Filter = "All files|*.*"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Button2.Text = OpenFileDialog1.FileName
        End If
    End Sub
End Class
