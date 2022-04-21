
Imports System.Text.RegularExpressions

Public Class BorrowersInfo


    Private Sub linkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)



    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click



    End Sub







    Private Sub phoneno1_Validated_1(sender As Object, e As EventArgs)


    End Sub

    Private Sub maristats1_KeyPress(sender As Object, e As KeyPressEventArgs)

    End Sub

    Private Sub email1_KeyPress(sender As Object, e As KeyPressEventArgs)

    End Sub
    Private Function Vld(ByVal ParamArray ctl() As Object) As Boolean


    End Function

    Private Sub phoneno1_KeyPress(sender As Object, e As KeyPressEventArgs)

    End Sub

    Private Sub textBox1_KeyPress(sender As Object, e As KeyPressEventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub label13_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub dataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        If Loan_status.Text = "Pending" Then
            Button4.Text = "Mark as Released"
        ElseIf Loan_status.Text = "Ongoing" Then
            Button4.Text = "Mark as Complete"

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AppFormA.view = True
        AppFormB.view = True
        AppFormA.Show()
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        AddLoanPayment.Show()
    End Sub

    Private Sub AP_CONFIRMBTN_Click(sender As Object, e As EventArgs) Handles AP_CONFIRMBTN.Click
        BorrowersSavings.Show()

        Me.Hide()

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Date.Now.ToString("dd MMM yyyy       hh:mm:ss tt")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim response1, response2




        If Loan_status.Text = "Pending" Then
            response1 = MsgBox("Do you want to released this loan?", vbYesNo, "Mark Released")
            If response1 = vbYes Then

                Loan_status.Text = "Ongoing"
                Loan_status.BackColor = Color.SeaGreen
                Button4.BackColor = Color.SeaGreen
                Button4.Enabled = False
                Button4.Text = "Mark as Completed"

                'enter code here for update status from pending to released

            End If

        ElseIf Loan_status.Text = "Ongoing" Then

            response2 = MsgBox("Do you want to Mark as Complete this loan?", vbYesNo, "Mark Completed")
            If response2 = vbYes Then

                Loan_status.Text = "Completed"
                Loan_status.BackColor = Color.SteelBlue
                Button4.BackColor = Color.SteelBlue
                Button4.Text = "Renew Loan"

                'enter code here for update status from release to completed



            End If


        ElseIf Loan_status.Text = "Completed" Then

                SummaryLoanRelease.Show()


            End If


    End Sub

    Private Sub loan_balancetxt_TextChanged(sender As Object, e As EventArgs) Handles loan_balancetxt.TextChanged
        If loan_balancetxt.Text = 0 Then
            Button4.Enabled = True

        End If
    End Sub

    Private Sub Loan_status_Click(sender As Object, e As EventArgs) Handles Loan_status.Click

    End Sub
End Class
