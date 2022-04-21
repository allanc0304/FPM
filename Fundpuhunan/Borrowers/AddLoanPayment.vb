Public Class AddLoanPayment

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

    Private Sub AP_REM_KeyPress(sender As Object, e As KeyPressEventArgs)
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

    Private Sub AP_CONFIRMBTN_Click(sender As Object, e As EventArgs) Handles AP_CONFIRMBTN.Click
        Dim ask As MsgBoxResult
        If Vld(AP_EA, AP_PEN, AP_COLB) = False Then
            MessageBox.Show("Fill up all fields")
        Else
            MsgBox("Would you like to Add this Payment?", MsgBoxStyle.YesNo, "Payment")
        End If
        If ask = MsgBoxResult.Yes Then
            MsgBox("Payment Successful")

            Me.Close()
        Else
        End If
    End Sub

    Private Sub AP_CANCELBTN_Click(sender As Object, e As EventArgs) Handles AP_CANCELBTN.Click

        Me.Close()
    End Sub

    Private Sub AddLoanPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class