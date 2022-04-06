Public Class WithdrawSavings
    Private Sub WithdrawSavings_Load(sender As Object, e As EventArgs) Handles MyBase.Load


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
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim ask As MsgBoxResult
        If Vld(TextBox4) = False Then
            MessageBox.Show("Fill up all fields")

        Else



            ask = MsgBox("Would you like to withdraw?", MsgBoxStyle.YesNo, "Withdraw")
        End If
        If ask = MsgBoxResult.Yes Then
                    MsgBox("Withdraw Successful")

                    BorrowersSavings.Show()
                    Me.Hide()

                Else

                End If



    End Sub



    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This is field will accept Numbers only")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BorrowersSavings.Show()
        Me.Hide()

    End Sub
End Class