Imports DBConnection
Public Class LoanProcessing
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CIRFORM1.Show()
    End Sub

    Event DataGridView1ButtonClick(sender As DataGridView, e As DataGridViewCellEventArgs)
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
            e.RowIndex >= 0 Then
            RaiseEvent DataGridView1ButtonClick(senderGrid, e)
        End If
    End Sub
    Private Sub DataGridView1_ButtonClick(sender As DataGridView, e As DataGridViewCellEventArgs) Handles Me.DataGridView1ButtonClick
        If e.ColumnIndex = 8 Then
            Dim loanId As String = sender.Rows(e.RowIndex).Cells(0).Value
            Dim connection = HolderSingleton.connection
            Dim exception = SQLHelper.GetCIR(connection, HolderSingleton.selectedCIR, loanId)
            If exception IsNot Nothing Then
                MessageBox.Show(exception.Message)
                Exit Sub
            End If
            Dim cirObj = HolderSingleton.selectedCIR
            CIRFORM1.TextBox1.Text = cirObj.BorrowerLN
            CIRFORM1.TextBox2.Text = cirObj.BorrowerFN
            CIRFORM1.TextBox3.Text = cirObj.BorrowerMN
            CIRFORM1.TextBox4.Text = cirObj.BorrowerSuffix

            CIRFORM1.Show()
            CIRFORM1.BringToFront()
        ElseIf e.ColumnIndex = 7 Then
            MessageBox.Show("delete")
        End If
    End Sub
End Class