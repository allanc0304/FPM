Imports DBConnection
Public Class BorrowersList
    Private Sub Label1_Click(sender As Object, e As EventArgs)
        Timer1.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        AppFormA.Show()


    End Sub

    Event DataGridView1ButtonClick(sender As DataGridView, e As DataGridViewCellEventArgs)
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Application_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Button3.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AppFormA.view = False
        AppFormB.view = False
        CIRFORMA.view = False
        CIRFORMB.view = False
        CIRFORMB.newBorrower = True

        AppFormA = Nothing
        AppFormB = Nothing
        CIRFORMA = Nothing

        CIRFORMB = Nothing
        AppFormA.Show()


    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        BorrowersInfo.Show()
        AppFormB.view = True
        CIRFORMA.view = True
        AppFormA.view = True
        CIRFORMB.view = True
        Button5.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = Date.Now.ToString("dd MMM yyyy       hh:mm:ss tt")
    End Sub

    Private Sub Button5_Leave(sender As Object, e As EventArgs) Handles Button5.Leave
        Button3.Enabled = True
    End Sub
End Class