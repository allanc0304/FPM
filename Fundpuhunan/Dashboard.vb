Public Class Dashboard
    Private Sub eventsatatus_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVongoingloan.CellContentClick

    End Sub

    Private Sub AddNewoanbttn_Click(sender As Object, e As EventArgs) Handles AddNewoanbttn.Click
        With Application

            .TopLevel = False
            .AutoSize = True

            Navigation.Navigationpanel.Controls.Add(Application)
            .BringToFront()
            .Show()

        End With

        AppFormA.Show()
    End Sub

    Private Sub AccounSettingsbttn_Click(sender As Object, e As EventArgs) Handles AccounSettingsbttn.Click
        With MyAccount

            .TopLevel = False
            .AutoSize = True

            Navigation.Navigationpanel.Controls.Add(MyAccount)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub ViewAllLoanbttn_Click(sender As Object, e As EventArgs) Handles ViewAllLoanbttn.Click
        With Application

            .TopLevel = False
            .AutoSize = True

            Navigation.Navigationpanel.Controls.Add(Application)
            .BringToFront()
            .Show()

        End With
    End Sub
End Class