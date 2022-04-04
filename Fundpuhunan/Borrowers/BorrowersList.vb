Imports DBConnection
Public Class BorrowersList
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        AppFormA.Show()


    End Sub

    Event DataGridView1ButtonClick(sender As DataGridView, e As DataGridViewCellEventArgs)
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Application_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AppFormA = Nothing
        AppFormB = Nothing
        CIRFORMA = Nothing
        CIRFORMB = Nothing
        AppFormA.Show()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)
        SearchApplication.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        BorrowersLoan.Show()


    End Sub
End Class