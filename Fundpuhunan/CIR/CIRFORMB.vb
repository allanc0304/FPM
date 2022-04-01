Public Class CIRFORMB

    Private Sub TxtBLname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSubmittedBy.KeyPress, txtBMname.KeyPress, txtBLname.KeyPress, txtBFname.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This is field will accept Letters only")


        End If
    End Sub

    Private Sub txtAppGSale_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtWBill.KeyPress, txtTranspo.KeyPress, txtSpoSalary.KeyPress, txtSpoNProfit.KeyPress, txtSpoGSale.KeyPress, txtSpoCSale.KeyPress, txtRental.KeyPress, txtPLoan.KeyPress, txtPersoOther.KeyPress, txtPAmount.KeyPress, txtNIncome.KeyPress, txtHSalary.KeyPress, txtFood.KeyPress, txtExpenses.KeyPress, txtEBill.KeyPress, txtDelinquent.KeyPress, txtBalance.KeyPress, txtAvailment.KeyPress, txtAppSalary.KeyPress, txtAppNProfit.KeyPress, txtAppGSale.KeyPress, txtAppCSale.KeyPress, txtAmountApproved.KeyPress, txtAllowance.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This is field will accept number only")


        End If
    End Sub

    Private Function Vld(ByVal ParamArray ctl() As Object) As Boolean

        For i As Integer = 0 To UBound(ctl)
            If ctl(i).text = "" Then
                ErrorProvider1.SetError(ctl(i), ctl(i).tag)
                Return False
                Exit Function
            End If
        Next
        Return True
    End Function

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If Vld(txtSubmittedBy, txtBMname, txtBLname, txtBFname) = False Then
            MessageBox.Show("Fill up all fields")

        ElseIf Vld(txtWBill, txtTranspo, txtSpoSalary, txtSpoNProfit, txtSpoGSale, txtSpoCSale, txtRental, txtPLoan, txtPersoOther, txtPAmount, txtNIncome, txtHSalary, txtFood, txtExpenses, txtEBill, txtDelinquent, txtBalance, txtAvailment, txtAppSalary, txtAppNProfit, txtAppGSale, txtAppCSale, txtAccSignature, txtAmountApproved, txtAllowance, txtAmountApproved, txtApprovedBy, txtPAmount, txtSubmittedBy) = False Then
            MessageBox.Show("Fill up all fields")

            Exit Sub
        Else

            MsgBox("Proceed to the Dashboard")
            LoanProcessing.Show()
            Me.Hide()

        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        CIRFORMA.Show()
    End Sub

    Private Sub CIRFORMB_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        CIRFORMA = Nothing
    End Sub
End Class