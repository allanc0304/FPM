Public Class SummaryLoanRelease
    Private Sub SUM_BRGY_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SUM_BRGY.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")
        End If
    End Sub

    Private Sub SUM_DAY_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SUM_DAY.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")
        End If
    End Sub

    Private Sub SUM_AO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SUM_AO.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")
        End If
    End Sub

    Private Sub SUM_PB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SUM_PB.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")
        End If
    End Sub

    Private Sub SUM_CB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SUM_CB.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")
        End If
    End Sub

    Private Sub SUM_CN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SUM_CN.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")
        End If
    End Sub

    Private Sub SUM_BRGY_TextChanged(sender As Object, e As EventArgs) Handles SUM_BRGY.TextChanged
        SUM_BRGY1.Text = SUM_BRGY.Text
    End Sub

    Private Sub SUM_DAY_TextChanged(sender As Object, e As EventArgs) Handles SUM_DAY.TextChanged
        SUM_DAY1.Text = SUM_DAY.Text
    End Sub

    Private Sub SUM_CN_TextChanged(sender As Object, e As EventArgs) Handles SUM_CN.TextChanged
        SUM_CN1.Text = SUM_CN.Text
    End Sub
End Class