Public Class Navigation
    Private Sub attendancebutton_Click(sender As Object, e As EventArgs) Handles applicationbttn.Click
        With Application

            .TopLevel = False
            .AutoSize = True

            Navigationpanel.Controls.Add(Application)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles loanreleasedbttn.Click

    End Sub

    Private Sub dashboardbutton_Click(sender As Object, e As EventArgs) Handles dashboardbutton.Click
        With Dashboard

            .TopLevel = False
            .AutoSize = True

            Navigationpanel.Controls.Add(Dashboard)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Navigationpanel_Paint(sender As Object, e As PaintEventArgs) Handles Navigationpanel.Paint
        With Dashboard

            .TopLevel = False
            .AutoSize = True

            Navigationpanel.Controls.Add(Dashboard)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub processingbttn_Click(sender As Object, e As EventArgs) Handles processingbttn.Click
        With LoanProcessing

            .TopLevel = False
            .AutoSize = True

            Navigationpanel.Controls.Add(LoanProcessing)
            .BringToFront()
            .Show()

        End With
    End Sub
End Class