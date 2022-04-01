Imports DBConnection
Public Class LoanProcessing
    Dim CIRFORM2
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        CIRFORM1.Show()
    End Sub


    Event DataGridView1ButtonClick(sender As DataGridView, e As DataGridViewCellEventArgs)
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Dim senderGrid = DirectCast(sender, DataGridView)

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
            e.RowIndex >= 0 Then
            RaiseEvent DataGridView1ButtonClick(senderGrid, e)
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With Application

            .TopLevel = False
            .AutoSize = True

            Navigation.Navigationpanel.Controls.Add(Application)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        SearchCIR.Show()
    End Sub
End Class