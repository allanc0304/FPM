Public Class BorrowersSavings
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        WithdrawSavings.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AddSavingsDeposit.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        BorrowersLoan.Show()
        Me.Hide()


    End Sub

    Private Sub BorrowersSavings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class