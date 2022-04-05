Public Class AddSavingsDeposit
    Private Sub AddSavingsDeposit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = Date.Now.ToString("MMM dd yyyy hh:mm:ss")
    End Sub

    Private Sub SD_AD_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SD_AD.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only")
        End If
    End Sub

    Private Sub SD_RB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SD_RB.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only")
        End If
    End Sub

    Private Sub SD_COLB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SD_COLB.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept number only")
        End If
    End Sub

    Private Sub SD_CONFIRMBTN_Click(sender As Object, e As EventArgs) Handles SD_CONFIRMBTN.Click
        Dim ask As MsgBoxResult = MsgBox("Would you like to exit?", MsgBoxStyle.YesNo, "Exit")
        If ask = MsgBoxResult.Yes Then
            BorrowersSavings.Show()
            Me.Hide()
        Else
            MsgBox("You will go back to Saving Deposit page", MsgBoxStyle.OkCancel, "Exit")
        End If
    End Sub

    Private Sub SD_CANCELBTN_Click(sender As Object, e As EventArgs) Handles SD_CANCELBTN.Click
        BorrowersSavings.Show()
        Me.Hide()
    End Sub
End Class