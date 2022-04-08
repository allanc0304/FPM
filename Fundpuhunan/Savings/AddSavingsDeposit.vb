Public Class AddSavingsDeposit
    Private Sub AddSavingsDeposit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
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

    Private Sub DS_CONFIRMBTN_Click(sender As Object, e As EventArgs) Handles DS_CONFIRMBTN.Click
        Dim ask As MsgBoxResult
        If Vld(SD_AD, SD_COLB) = False Then
            MessageBox.Show("Fill up all fields")
        Else
            MsgBox("Would you like to Add this Deposit?", MsgBoxStyle.YesNo, "Deposit")
        End If
        If ask = MsgBoxResult.Yes Then
            MsgBox("Deposit Successful")
            Me.Close()
        Else
        End If
    End Sub

    Private Sub SD_CANCELBTN_Click(sender As Object, e As EventArgs) Handles SD_CANCELBTN.Click
        BorrowersSavings.Show()
        Me.Hide()
    End Sub

End Class