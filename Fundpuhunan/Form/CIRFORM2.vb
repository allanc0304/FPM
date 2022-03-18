
﻿Public Class CIRFORM2
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        If String.IsNullOrEmpty(txtBLname.Text.Trim) Then
            ErrorProvider1.SetError(txtBLname, "Please Enter Borrower Last Name")
            txtBLname.Focus()
        Else
            ErrorProvider1.SetError(txtBLname, String.Empty)
        End If

        If String.IsNullOrEmpty(txtBFname.Text.Trim) Then
            ErrorProvider2.SetError(txtBFname, "Please Enter Borrower Last Name")
            txtBFname.Focus()
        Else
            ErrorProvider2.SetError(txtBFname, String.Empty)
        End If

        If String.IsNullOrEmpty(txtBMname.Text.Trim) Then
            ErrorProvider3.SetError(txtBMname, "Please Enter Borrower Last Name")
            txtBMname.Focus()
        Else
            ErrorProvider3.SetError(txtBMname, String.Empty)
        End If

        If String.IsNullOrEmpty(txtBSuffix.Text.Trim) Then
            ErrorProvider4.SetError(txtBSuffix, "Please Enter Borrower Last Name")
            txtBSuffix.Focus()
        Else
            ErrorProvider4.SetError(txtBSuffix, String.Empty)
        End If

        If String.IsNullOrEmpty(txtAppGSale.Text.Trim) Then
            ErrorProvider5.SetError(txtAppGSale, "Please Enter Borrower Last Name")
            txtAppGSale.Focus()
        Else
            ErrorProvider5.SetError(txtAppGSale, String.Empty)
        End If

        If String.IsNullOrEmpty(txtAppCSale.Text.Trim) Then
            ErrorProvider6.SetError(txtAppCSale, "Please Enter Borrower Last Name")
            txtAppCSale.Focus()
        Else
            ErrorProvider6.SetError(txtAppCSale, String.Empty)
        End If

        If String.IsNullOrEmpty(txtAppNProfit.Text.Trim) Then
            ErrorProvider7.SetError(txtAppNProfit, "Please Enter Borrower Last Name")
            txtAppNProfit.Focus()
        Else
            ErrorProvider7.SetError(txtAppNProfit, String.Empty)
        End If

        If String.IsNullOrEmpty(txtAppSalary.Text.Trim) Then
            ErrorProvider8.SetError(txtAppSalary, "Please Enter Borrower Last Name")
            txtAppSalary.Focus()
        Else
            ErrorProvider8.SetError(txtAppSalary, String.Empty)
        End If

        If String.IsNullOrEmpty(txtSpoGSale.Text.Trim) Then
            ErrorProvider9.SetError(txtSpoGSale, "Please Enter Borrower Last Name")
            txtSpoGSale.Focus()
        Else
            ErrorProvider9.SetError(txtSpoGSale, String.Empty)
        End If

        If String.IsNullOrEmpty(txtSpoCSale.Text.Trim) Then
            ErrorProvider10.SetError(txtSpoCSale, "Please Enter Borrower Last Name")
            txtSpoCSale.Focus()
        Else
            ErrorProvider10.SetError(txtSpoCSale, String.Empty)
        End If

        If String.IsNullOrEmpty(txtSpoNProfit.Text.Trim) Then
            ErrorProvider11.SetError(txtSpoNProfit, "Please Enter Borrower Last Name")
            txtSpoNProfit.Focus()
        Else
            ErrorProvider11.SetError(txtSpoNProfit, String.Empty)
        End If

        If String.IsNullOrEmpty(txtSpoSalary.Text.Trim) Then
            ErrorProvider12.SetError(txtSpoSalary, "Please Enter Borrower Last Name")
            txtSpoSalary.Focus()
        Else
            ErrorProvider12.SetError(txtSpoSalary, String.Empty)
        End If



        If String.IsNullOrEmpty(txtGIncome.Text.Trim) Then
            ErrorProvider14.SetError(txtGIncome, "Please Enter Borrower Last Name")
            txtGIncome.Focus()
        Else
            ErrorProvider14.SetError(txtGIncome, String.Empty)
        End If

        If String.IsNullOrEmpty(txtFood.Text.Trim) Then
            ErrorProvider15.SetError(txtFood, "Please Enter Borrower Last Name")
            txtFood.Focus()
        Else
            ErrorProvider15.SetError(txtFood, String.Empty)
        End If

        If String.IsNullOrEmpty(txtRental.Text.Trim) Then
            ErrorProvider16.SetError(txtRental, "Please Enter Borrower Last Name")
            txtRental.Focus()
        Else
            ErrorProvider16.SetError(txtRental, String.Empty)
        End If

        If String.IsNullOrEmpty(txtAllowance.Text.Trim) Then
            ErrorProvider17.SetError(txtAllowance, "Please Enter Borrower Last Name")
            txtAllowance.Focus()
        Else
            ErrorProvider17.SetError(txtAllowance, String.Empty)
        End If

        If String.IsNullOrEmpty(txtTranspo.Text.Trim) Then
            ErrorProvider18.SetError(txtTranspo, "Please Enter Borrower Last Name")
            txtTranspo.Focus()
        Else
            ErrorProvider18.SetError(txtTranspo, String.Empty)
        End If

        If String.IsNullOrEmpty(txtEBill.Text.Trim) Then
            ErrorProvider19.SetError(txtEBill, "Please Enter Borrower Last Name")
            txtEBill.Focus()
        Else
            ErrorProvider19.SetError(txtEBill, String.Empty)
        End If

        If String.IsNullOrEmpty(txtWBill.Text.Trim) Then
            ErrorProvider20.SetError(txtWBill, "Please Enter Borrower Last Name")
            txtWBill.Focus()
        Else
            ErrorProvider20.SetError(txtWBill, String.Empty)
        End If

        If String.IsNullOrEmpty(txtHSalary.Text.Trim) Then
            ErrorProvider21.SetError(txtHSalary, "Please Enter Borrower Last Name")
            txtHSalary.Focus()
        Else
            ErrorProvider21.SetError(txtHSalary, String.Empty)
        End If

        If String.IsNullOrEmpty(txtPersoOther.Text.Trim) Then
            ErrorProvider22.SetError(txtPersoOther, "Please Enter Borrower Last Name")
            txtPersoOther.Focus()
        Else
            ErrorProvider22.SetError(txtPersoOther, String.Empty)
        End If

        If String.IsNullOrEmpty(txtExpenses.Text.Trim) Then
            ErrorProvider23.SetError(txtExpenses, "Please Enter Borrower Last Name")
            txtExpenses.Focus()
        Else
            ErrorProvider23.SetError(txtExpenses, String.Empty)
        End If

        If String.IsNullOrEmpty(txtNIncome.Text.Trim) Then
            ErrorProvider24.SetError(txtNIncome, "Please Enter Borrower Last Name")
            txtNIncome.Focus()
        Else
            ErrorProvider24.SetError(txtNIncome, String.Empty)
        End If

        If String.IsNullOrEmpty(txtPLoan.Text.Trim) Then
            ErrorProvider25.SetError(txtPLoan, "Please Enter Borrower Last Name")
            txtPLoan.Focus()
        Else
            ErrorProvider25.SetError(txtPLoan, String.Empty)
        End If

        If String.IsNullOrEmpty(txtBalance.Text.Trim) Then
            ErrorProvider26.SetError(txtBalance, "Please Enter Borrower Last Name")
            txtBalance.Focus()
        Else
            ErrorProvider26.SetError(txtBalance, String.Empty)
        End If

        If String.IsNullOrEmpty(txtDelinquent.Text.Trim) Then
            ErrorProvider27.SetError(txtDelinquent, "Please Enter Borrower Last Name")
            txtDelinquent.Focus()
        Else
            ErrorProvider27.SetError(txtDelinquent, String.Empty)
        End If

        If String.IsNullOrEmpty(txtAvailment.Text.Trim) Then
            ErrorProvider28.SetError(txtAvailment, "Please Enter Borrower Last Name")
            txtAvailment.Focus()
        Else
            ErrorProvider28.SetError(txtAvailment, String.Empty)
        End If



        If String.IsNullOrEmpty(txtAccSignature.Text.Trim) Then
            ErrorProvider30.SetError(txtAccSignature, "Please Enter Borrower Last Name")
            txtAccSignature.Focus()
        Else
            ErrorProvider30.SetError(txtAccSignature, String.Empty)
        End If

        If String.IsNullOrEmpty(txtPAmount.Text.Trim) Then
            ErrorProvider31.SetError(txtPAmount, "Please Enter Borrower Last Name")
            txtPAmount.Focus()
        Else
            ErrorProvider31.SetError(txtPAmount, String.Empty)
        End If



        If String.IsNullOrEmpty(txtSubmittedBy.Text.Trim) Then
            ErrorProvider33.SetError(txtSubmittedBy, "Please Enter Borrower Last Name")
            txtSubmittedBy.Focus()
        Else
            ErrorProvider33.SetError(txtSubmittedBy, String.Empty)
        End If

        If String.IsNullOrEmpty(txtApprovedBy.Text.Trim) Then
            ErrorProvider34.SetError(txtApprovedBy, "Please Enter Borrower Last Name")
            txtApprovedBy.Focus()
        Else
            ErrorProvider34.SetError(txtApprovedBy, String.Empty)
        End If

        If String.IsNullOrEmpty(txtAmountApproved.Text.Trim) Then
            ErrorProvider35.SetError(txtAmountApproved, "Please Enter Borrower Last Name")
            txtAmountApproved.Focus()
        Else
            ErrorProvider35.SetError(txtAmountApproved, String.Empty)
        End If


    End Sub

    Private Sub txtBLname_TextChanged(sender As Object, e As EventArgs) Handles txtBLname.TextChanged

    End Sub

    Private Sub txtBLname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBLname.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")

        End If
    End Sub

    Private Sub txtBFname_TextChanged(sender As Object, e As EventArgs) Handles txtBFname.TextChanged

    End Sub

    Private Sub txtBFname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBFname.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")

        End If
    End Sub

    Private Sub txtBMname_TextChanged(sender As Object, e As EventArgs) Handles txtBMname.TextChanged

    End Sub

    Private Sub txtBMname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBMname.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")

        End If
    End Sub

    Private Sub txtOtherSpec_TextChanged(sender As Object, e As EventArgs) Handles txtOtherSpec.TextChanged

    End Sub

    Private Sub txtOtherSpec_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOtherSpec.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")

        End If
    End Sub

    Private Sub txtAccRemarks_TextChanged(sender As Object, e As EventArgs) Handles txtAccRemarks.TextChanged

    End Sub

    Private Sub txtAccRemarks_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAccRemarks.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")

        End If
    End Sub

    Private Sub txtAccSignature_TextChanged(sender As Object, e As EventArgs) Handles txtAccSignature.TextChanged

    End Sub

    Private Sub txtAccSignature_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAccSignature.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")

        End If
    End Sub

    Private Sub txtRecRemarks_TextChanged(sender As Object, e As EventArgs) Handles txtRecRemarks.TextChanged

    End Sub

    Private Sub txtRecRemarks_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRecRemarks.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")

        End If
    End Sub

    Private Sub txtSubmittedBy_TextChanged(sender As Object, e As EventArgs) Handles txtSubmittedBy.TextChanged

    End Sub

    Private Sub txtSubmittedBy_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSubmittedBy.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")

        End If
    End Sub

    Private Sub txtApprovedBy_TextChanged(sender As Object, e As EventArgs) Handles txtApprovedBy.TextChanged

    End Sub

    Private Sub txtApprovedBy_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApprovedBy.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")

        End If
    End Sub

    Private Sub txtBSuffix_TextChanged(sender As Object, e As EventArgs) Handles txtBSuffix.TextChanged

    End Sub

    Private Sub txtBSuffix_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBSuffix.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")

        End If
    End Sub

    Private Sub txtAppGSale_TextChanged(sender As Object, e As EventArgs) Handles txtAppGSale.TextChanged

    End Sub

    Private Sub txtAppGSale_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAppGSale.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only")

        End If
    End Sub

    Private Sub txtAppCSale_TextChanged(sender As Object, e As EventArgs) Handles txtAppCSale.TextChanged

    End Sub

    Private Sub txtAppCSale_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAppCSale.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only")

        End If
    End Sub

    Private Sub txtAppNProfit_TextChanged(sender As Object, e As EventArgs) Handles txtAppNProfit.TextChanged

    End Sub

    Private Sub txtAppNProfit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAppNProfit.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only")

        End If
    End Sub

    Private Sub txtAppSalary_TextChanged(sender As Object, e As EventArgs) Handles txtAppSalary.TextChanged

    End Sub

    Private Sub txtAppSalary_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAppSalary.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only")

        End If
    End Sub

    Private Sub txtSpoGSale_TextChanged(sender As Object, e As EventArgs) Handles txtSpoGSale.TextChanged

    End Sub

    Private Sub txtSpoGSale_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSpoGSale.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only")

        End If
    End Sub

    Private Sub txtSpoCSale_TextChanged(sender As Object, e As EventArgs) Handles txtSpoCSale.TextChanged

    End Sub

    Private Sub txtSpoCSale_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSpoCSale.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only")

        End If
    End Sub

    Private Sub txtSpoNProfit_TextChanged(sender As Object, e As EventArgs) Handles txtSpoNProfit.TextChanged

    End Sub

    Private Sub txtSpoNProfit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSpoNProfit.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only")

        End If
    End Sub

    Private Sub txtSpoSalary_TextChanged(sender As Object, e As EventArgs) Handles txtSpoSalary.TextChanged

    End Sub

    Private Sub txtSpoSalary_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSpoSalary.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only")

        End If
    End Sub

    Private Sub txtGIncome_TextChanged(sender As Object, e As EventArgs) Handles txtGIncome.TextChanged

    End Sub

    Private Sub txtGIncome_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGIncome.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only")

        End If
    End Sub

    Private Sub txtFood_TextChanged(sender As Object, e As EventArgs) Handles txtFood.TextChanged

    End Sub

    Private Sub txtFood_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFood.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only")

        End If
    End Sub

    Private Sub txtRental_TextChanged(sender As Object, e As EventArgs) Handles txtRental.TextChanged

    End Sub

    Private Sub txtRental_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRental.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only")

        End If
    End Sub

    Private Sub txtAllowance_TextChanged(sender As Object, e As EventArgs) Handles txtAllowance.TextChanged

    End Sub

    Private Sub txtAllowance_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAllowance.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only")

        End If
    End Sub

    Private Sub txtTranspo_TextChanged(sender As Object, e As EventArgs) Handles txtTranspo.TextChanged

    End Sub

    Private Sub txtTranspo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTranspo.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only")

        End If
    End Sub

    Private Sub txtEBill_TextChanged(sender As Object, e As EventArgs) Handles txtEBill.TextChanged

    End Sub

    Private Sub txtEBill_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEBill.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only")

        End If
    End Sub

    Private Sub txtWBill_TextChanged(sender As Object, e As EventArgs) Handles txtWBill.TextChanged

    End Sub

    Private Sub txtWBill_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtWBill.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only")

        End If
    End Sub

    Private Sub txtHSalary_TextChanged(sender As Object, e As EventArgs) Handles txtHSalary.TextChanged

    End Sub

    Private Sub txtHSalary_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHSalary.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only")

        End If
    End Sub

    Private Sub txtPersoOther_TextChanged(sender As Object, e As EventArgs) Handles txtPersoOther.TextChanged

    End Sub

    Private Sub txtPersoOther_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPersoOther.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only")

        End If
    End Sub

    Private Sub txtExpenses_TextChanged(sender As Object, e As EventArgs) Handles txtExpenses.TextChanged

    End Sub

    Private Sub txtExpenses_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtExpenses.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only")

        End If
    End Sub

    Private Sub txtNIncome_TextChanged(sender As Object, e As EventArgs) Handles txtNIncome.TextChanged

    End Sub

    Private Sub txtNIncome_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNIncome.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only")

        End If
    End Sub

    Private Sub txtPLoan_TextChanged(sender As Object, e As EventArgs) Handles txtPLoan.TextChanged

    End Sub

    Private Sub txtPLoan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPLoan.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only")

        End If
    End Sub

    Private Sub txtBalance_TextChanged(sender As Object, e As EventArgs) Handles txtBalance.TextChanged

    End Sub

    Private Sub txtBalance_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBalance.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only")

        End If
    End Sub

    Private Sub txtDelinquent_TextChanged(sender As Object, e As EventArgs) Handles txtDelinquent.TextChanged

    End Sub

    Private Sub txtDelinquent_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDelinquent.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only")

        End If
    End Sub

    Private Sub txtAvailment_TextChanged(sender As Object, e As EventArgs) Handles txtAvailment.TextChanged

    End Sub

    Private Sub txtAvailment_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAvailment.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only")

        End If
    End Sub

    Private Sub txtPAmount_TextChanged(sender As Object, e As EventArgs) Handles txtPAmount.TextChanged

    End Sub

    Private Sub txtPAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPAmount.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only")

        End If
    End Sub

    Private Sub txtAmountApproved_TextChanged(sender As Object, e As EventArgs) Handles txtAmountApproved.TextChanged

    End Sub

    Private Sub txtAmountApproved_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAmountApproved.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only")

        End If
    End Sub

    Private Sub chbCommercial_CheckedChanged(sender As Object, e As EventArgs) Handles chbCommercial.CheckedChanged
        If chbCommercial.Checked = True Then
            chbIndustrial.Enabled = False
            chbResidential.Enabled = False
            chbAgricultural.Enabled = False

        ElseIf chbCommercial.Checked = False Then
            chbIndustrial.Enabled = True
            chbResidential.Enabled = True
            chbAgricultural.Enabled = True
        End If
    End Sub

    Private Sub chbIndustrial_CheckedChanged(sender As Object, e As EventArgs) Handles chbIndustrial.CheckedChanged
        If chbIndustrial.Checked = True Then
            chbCommercial.Enabled = False
            chbResidential.Enabled = False
            chbAgricultural.Enabled = False

        ElseIf chbIndustrial.Checked = False Then
            chbCommercial.Enabled = True
            chbResidential.Enabled = True
            chbAgricultural.Enabled = True
        End If
    End Sub

    Private Sub chbResidential_CheckedChanged(sender As Object, e As EventArgs) Handles chbResidential.CheckedChanged
        If chbResidential.Checked = True Then
            chbCommercial.Enabled = False
            chbIndustrial.Enabled = False
            chbAgricultural.Enabled = False

        ElseIf chbResidential.Checked = False Then
            chbCommercial.Enabled = True
            chbIndustrial.Enabled = True
            chbAgricultural.Enabled = True
        End If
    End Sub

    Private Sub chbAgricultural_CheckedChanged(sender As Object, e As EventArgs) Handles chbAgricultural.CheckedChanged
        If chbAgricultural.Checked = True Then
            chbIndustrial.Enabled = False
            chbResidential.Enabled = False
            chbCommercial.Enabled = False

        ElseIf chbAgricultural.Checked = False Then
            chbIndustrial.Enabled = True
            chbResidential.Enabled = True
            chbCommercial.Enabled = True
        End If

﻿Public Class Form1
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged


    End Sub
End Class