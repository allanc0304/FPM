Public Class AddUserAccount

    Private Sub btnAddUserApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddUserApply.Click
        If String.IsNullOrEmpty(txtLname.Text.Trim) Then
            ErrorProvider1.SetError(txtLname, "Please Enter Last Name")
        Else
            ErrorProvider1.SetError(txtLname, String.Empty)
        End If

        If String.IsNullOrEmpty(txtFname.Text.Trim) Then
            ErrorProvider1.SetError(txtFname, "Please Enter First Name")
        Else
            ErrorProvider1.SetError(txtFname, String.Empty)
        End If

        If String.IsNullOrEmpty(txtMname.Text.Trim) Then
            ErrorProvider1.SetError(txtMname, "Please Enter Middle Name")
        Else
            ErrorProvider1.SetError(txtMname, String.Empty)
        End If

        If String.IsNullOrEmpty(cmbboxPosition.Text.Trim) Then
            ErrorProvider1.SetError(cmbboxPosition, "Please Enter Position")
        Else
            ErrorProvider1.SetError(cmbboxPosition, String.Empty)
        End If

        If String.IsNullOrEmpty(txtUsername.Text.Trim) Then
            ErrorProvider1.SetError(txtUsername, "Please Enter Username")
        Else
            ErrorProvider1.SetError(txtUsername, String.Empty)
        End If

        If String.IsNullOrEmpty(txtPassword.Text.Trim) Then
            ErrorProvider1.SetError(txtPassword, "Please Enter Password")
        Else
            ErrorProvider1.SetError(txtPassword, String.Empty)
        End If

        If txtLname.Text = "" Or txtFname.Text = "" Or txtMname.Text = "" Or cmbboxPosition.Text = "" Or txtUsername.Text = "" Or txtPassword.Text = "" Then

            MsgBox("A field is missing")
        End If

        If Trim(txtUsername.Text).Length > 0 Then
            If txtUsername.Text.Length <= 7 Then
                MsgBox("Username not valid")
                ErrorProvider1.SetError(txtUsername, "Enter at least 8 characters")
            Else
                ErrorProvider1.SetError(txtUsername, "")
            End If
        End If

        If Trim(txtPassword.Text).Length > 0 Then
            If txtPassword.Text.Length <= 7 Then
                MsgBox("Password not valid")
                ErrorProvider1.SetError(txtPassword, "Enter at least 8 characters")
            Else
                ErrorProvider1.SetError(txtPassword, "")
            End If
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

    Private Sub chbSPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chbSPassword.CheckedChanged
        If chbSPassword.Checked = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnAddUserCancel_Click(sender As Object, e As EventArgs) Handles btnAddUserCancel.Click
        Me.Close()
    End Sub
End Class