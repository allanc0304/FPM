Public Class Navigation
    Private Sub attendancebutton_Click(sender As Object, e As EventArgs) Handles applicationbttn.Click
        With BorrowersList

            .TopLevel = False
            .AutoSize = True

            Navigationpanel.Controls.Add(BorrowersList)
            .BringToFront()
            .Show()

        End With


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles loanreleasedbttn.Click
        With Dashboard

            .TopLevel = False
            .AutoSize = True

            Navigationpanel.Controls.Add(Dashboard)
            .BringToFront()
            .Show()

        End With
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






    Private Sub accountbttn_Click(sender As Object, e As EventArgs) Handles accountbttn.Click
        With MyAccount

            .TopLevel = False
            .AutoSize = True

            Navigationpanel.Controls.Add(MyAccount)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub filebttn_Click(sender As Object, e As EventArgs) Handles filebttn.Click
        With AccountUserManagement

            .TopLevel = False
            .AutoSize = True

            Navigationpanel.Controls.Add(AccountUserManagement
)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        With FilesandRecords

            .TopLevel = False
            .AutoSize = True

            Navigationpanel.Controls.Add(FilesandRecords
)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Navigation_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        System.Windows.Forms.Application.Exit()
    End Sub

    Private Sub Navigation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub savingsbttn_Click(sender As Object, e As EventArgs) Handles savingsbttn.Click
        With Savings

            .TopLevel = False
            .AutoSize = True

            Navigationpanel.Controls.Add(Savings)

            .BringToFront()
            .Show()
        End With

    End Sub
End Class