Imports DBConnection
Public Class Navigation
    Private Sub attendancebutton_Click(sender As Object, e As EventArgs) Handles applicationbttn.Click

        Dim loanSummaries As List(Of LoanSummary) = New List(Of LoanSummary)
        Dim exception As Exception = SQLHelper.GetAllLoan(HolderSingleton.connection, loanSummaries)
        If exception IsNot Nothing Then
            MessageBox.Show(exception.Message)
        End If

        Dim application As Application = New Application()
        application.TopLevel = False
        application.AutoSize = True
        Navigationpanel.Controls.Add(application)
        For Each loanSummary As LoanSummary In loanSummaries
            application.DataGridView1.Rows.Add({loanSummary.LoanId, loanSummary.BorrowerFN, loanSummary.BorrowerMN, loanSummary.BorrowerLN, loanSummary.LoanAmount, loanSummary.LoanStatus, loanSummary.DateCreated})
        Next
        application.BringToFront()
        application.Show()

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
        Dim loanSummaries As List(Of LoanSummary) = New List(Of LoanSummary)
        Dim exception As Exception = SQLHelper.GetAllLoan(HolderSingleton.connection, loanSummaries)
        If exception IsNot Nothing Then
            MessageBox.Show(exception.Message)
        End If

        Dim loanProcessing As LoanProcessing = New LoanProcessing()
        loanProcessing.TopLevel = False
        loanProcessing.AutoSize = True
        Navigationpanel.Controls.Add(loanProcessing)
        For Each loanSummary As LoanSummary In loanSummaries
            loanProcessing.DataGridView1.Rows.Add({loanSummary.LoanId, loanSummary.BorrowerFN, loanSummary.BorrowerMN, loanSummary.BorrowerLN, loanSummary.LoanAmount, loanSummary.LoanStatus, loanSummary.DateCreated})
        Next

        loanProcessing.BringToFront()
        loanProcessing.Show()
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
End Class