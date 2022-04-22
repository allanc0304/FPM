Public Class AddUserAccount
    Dim ResizedImage As Image

    Private Sub btnAddUserApply_Click(sender As Object, e As EventArgs) Handles btnAddUserApply.Click
        If Vld(txtFname, txtLname, txtMname, cmbboxPosition, txtUsername, txtPassword) = False Then
            MessageBox.Show("Fill up all fields", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf cmbboxPosition.SelectedIndex < 0 Then
            MessageBox.Show("Please choose position from drop down box", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf txtUsername.Text.Length <= 7 Then
            MessageBox.Show("Username should have minimum length 8 alphanumeric characters", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf txtPassword.Text.Length <= 7 Then
            MessageBox.Show("Password should have minimum length 8 alphanumeric characters", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf pictureboxAddUser.Image Is Nothing Then
            MessageBox.Show("Upload user picture")

        Else
            MsgBox("Adding Account Successfully", MsgBoxStyle.OkOnly, "Adding Account")
            Me.Close()
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

    Private Sub txtUsername_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUsername.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters and numbers only")
        End If
    End Sub

    Private Sub txtPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters and numbers only")
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

    Private Function Vld(ByVal ParamArray ctl() As Object) As Boolean

        For i As Integer = 0 To UBound(ctl)
            If ctl(i).text = "" Then
                ErrorProvider1.SetError(ctl(i), ctl(i).tag)
                Return False
                Exit Function
            End If
        Next
        Return True
    End Function

    Private Sub btnCFile_Click(sender As Object, e As EventArgs) Handles btnCFile.Click
        Dim OpenFileDialog1 As New OpenFileDialog
        OpenFileDialog1.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg;*.jpeg;*.png;*.tiff"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            btnCFile.Text = OpenFileDialog1.FileName
            pictureboxAddUser.BackgroundImage = Image.FromFile(btnCFile.Text)

            Dim NewSize As New Size(100, 100)
            ResizedImage = New Bitmap(pictureboxAddUser.BackgroundImage, NewSize)
            pictureboxAddUser.BackgroundImage = ResizedImage
            pictureboxAddUser.BackgroundImageLayout = ImageLayout.Stretch

        End If
    End Sub
End Class