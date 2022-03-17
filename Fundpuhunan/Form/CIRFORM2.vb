Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

    End Sub

    Private Sub txtBLname_TextChanged(sender As Object, e As EventArgs) Handles txtBLname.TextChanged

    End Sub

    Private Sub txtBLname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBLname.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")

        End If
    End Sub
End Class