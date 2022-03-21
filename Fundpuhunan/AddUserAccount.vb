Public Class AddUserAccount

    Private Sub btnAddUserApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddUserApply.Click
        If String.IsNullOrEmpty(txtLname.Text.Trim) Then
            ErrorProvider1.SetError(txtLname, "Please Enter Borrower Last Name")
            txtLname.Focus()
        Else
            ErrorProvider1.SetError(txtLname, String.Empty)
        End If

        If String.IsNullOrEmpty(txtFname.Text.Trim) Then
            ErrorProvider1.SetError(txtFname, "Please Enter Borrower Last Name")
            txtFname.Focus()
        Else
            ErrorProvider1.SetError(txtFname, String.Empty)
        End If

        If String.IsNullOrEmpty(txtMname.Text.Trim) Then
            ErrorProvider1.SetError(txtMname, "Please Enter Borrower Last Name")
            txtMname.Focus()
        Else
            ErrorProvider1.SetError(txtMname, String.Empty)
        End If

        If String.IsNullOrEmpty(cmbboxPosition.Text.Trim) Then
            ErrorProvider1.SetError(cmbboxPosition, "Please Enter Borrower Last Name")
            cmbboxPosition.Focus()
        Else
            ErrorProvider1.SetError(cmbboxPosition, String.Empty)
        End If

        If String.IsNullOrEmpty(txtUsername.Text.Trim) Then
            ErrorProvider1.SetError(txtUsername, "Please Enter Borrower Last Name")
            txtUsername.Focus()
        Else
            ErrorProvider1.SetError(txtUsername, String.Empty)
        End If

        If String.IsNullOrEmpty(txtPassword.Text.Trim) Then
            ErrorProvider1.SetError(txtPassword, "Please Enter Borrower Last Name")
            txtPassword.Focus()
        Else
            ErrorProvider1.SetError(txtPassword, String.Empty)
        End If
    End Sub


    Private Sub txtFname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFname.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")

        End If
    End Sub

    Private Sub txtLname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLname.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")

        End If
    End Sub

    Private Sub txtMname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMname.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")

        End If
    End Sub

    Private Sub cmbboxPosition_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbboxPosition.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")

        End If
    End Sub
End Class