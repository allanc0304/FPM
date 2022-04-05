Public Class AddLoanPayment

    Private Sub AddLoanPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub AP_CB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AP_CB.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept number only")
        End If
    End Sub

    Private Sub AP_EA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AP_EA.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept number only")
        End If
    End Sub

    Private Sub AP_REM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AP_REM.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept number only")
        End If
    End Sub

    Private Sub AP_PEN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AP_PEN.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept number only")
        End If
    End Sub

    Private Sub AP_COLB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AP_COLB.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept number only")
        End If
    End Sub

    Private Sub AP_CONFIRMBTN_Click(sender As Object, e As EventArgs) Handles AP_CONFIRMBTN.Click
        Dim ask As MsgBoxResult = MsgBox("Would you like to exit?", MsgBoxStyle.YesNo, "Exit")
        If ask = MsgBoxResult.Yes Then
            BorrowersList.Show()
            Me.Hide()
        Else
            MsgBox("You will go back to Add Payment page", MsgBoxStyle.OkCancel, "Exit")
        End If
    End Sub

    Private Sub AP_CANCELBTN_Click(sender As Object, e As EventArgs) Handles AP_CANCELBTN.Click
        BorrowersList.Show()
        Me.Hide()
    End Sub

End Class