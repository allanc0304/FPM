Imports System.Net.Http
Imports System.Text.Json
Imports System.IO
Public Class CIRFORMB

    Private Sub TxtBLname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBMname.KeyPress, txtBLname.KeyPress, txtBFname.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This is field will accept Letters only")


        End If
    End Sub

    Private Sub txtAppGSale_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtWBill.KeyPress, txtTranspo.KeyPress, txtSpoSalary.KeyPress, txtSpoNProfit.KeyPress, txtSpoGSale.KeyPress, txtSpoCSale.KeyPress, txtRental.KeyPress, txtPLoan.KeyPress, txtPersoOther.KeyPress, txtPAmount.KeyPress, txtNIncome.KeyPress, txtHSalary.KeyPress, txtFood.KeyPress, txtExpenses.KeyPress, txtEBill.KeyPress, txtDelinquent.KeyPress, txtBalance.KeyPress, txtAvailment.KeyPress, txtAppSalary.KeyPress, txtAppNProfit.KeyPress, txtAppGSale.KeyPress, txtAppCSale.KeyPress, txtAllowance.KeyPress
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
        If Vld(txtBMname, txtBLname, txtBFname, txtWBill, txtTranspo, txtSpoSalary, txtSpoNProfit, txtSpoGSale, txtSpoCSale, txtRental, txtPLoan, txtPersoOther, txtPAmount, txtNIncome, txtHSalary, txtFood, txtExpenses, txtEBill, txtDelinquent, txtBalance, txtAvailment, txtAppSalary, txtAppNProfit, txtAppGSale, txtAppCSale, txtAccSignature, txtAllowance, txtPAmount) = False Then

            MessageBox.Show("Fill up all fields")

        ElseIf PictureBoxAppForm.Image Is Nothing Then
            MsgBox("Please Upload Copy of Application Form")



        ElseIf PictureBoxCIR.Image Is Nothing Then
            MsgBox("Please Upload Copy of Application Form")


        Else
            Dim Ask As MsgBoxResult = MsgBox("Would you like to confirm and see computation", MsgBoxStyle.YesNo, "Exit")
            If Ask = MsgBoxResult.No Then
                MsgBox("Stop proceeding")
            Else
                MsgBox("Proceeding to computation")

                Dim loanForm As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
                loanForm.Add("borrower_mn", AppFormA.P1_MIDDLENAME.Text)
                loanForm.Add("borrower_fn", AppFormA.P1_GIVENNAME.Text)
                loanForm.Add("borrower_ln", Nothing)
                loanForm.Add("borrower_suffix", Nothing)
                loanForm.Add("house_no", Nothing)
                loanForm.Add("street", Nothing)
                loanForm.Add("brgy", Nothing)
                loanForm.Add("municipality", Nothing)
                loanForm.Add("province", Nothing)
                loanForm.Add("birth_date", Nothing)
                loanForm.Add("ismale", Nothing)
                loanForm.Add("age", Nothing)
                loanForm.Add("religion", Nothing)
                loanForm.Add("contact_no", Nothing)
                loanForm.Add("spouse_fn", Nothing)
                loanForm.Add("spouse_mn", Nothing)
                loanForm.Add("spouse_ln", Nothing)
                loanForm.Add("spouse_suffix", Nothing)
                loanForm.Add("spouse_house_no", Nothing)
                loanForm.Add("spouse_street", Nothing)
                loanForm.Add("spouse_brgy", Nothing)
                loanForm.Add("spouse_municipality", Nothing)
                loanForm.Add("spouse_province", Nothing)
                loanForm.Add("spouse_birth_date", Nothing)
                loanForm.Add("spouse_ismale", Nothing)
                loanForm.Add("spouse_age", Nothing)
                loanForm.Add("spouse_religion", Nothing)
                loanForm.Add("children", Nothing)
                loanForm.Add("income_source", Nothing)
                loanForm.Add("weekly_income", Nothing)
                loanForm.Add("weekly_household_income", Nothing)
                loanForm.Add("expenses", Nothing)
                loanForm.Add("net_income", Nothing)
                loanForm.Add("guarantor_fn", Nothing)
                loanForm.Add("gurantor_mn", Nothing)
                loanForm.Add("guarantor_ln", Nothing)
                loanForm.Add("guarantor_suffix", Nothing)
                loanForm.Add("guarantor_house_no", Nothing)
                loanForm.Add("guarontor_street", Nothing)
                loanForm.Add("guarantor_brgy", Nothing)
                loanForm.Add("guarantor_municipality", Nothing)
                loanForm.Add("guarantor_province", Nothing)
                loanForm.Add("guarantor_birth_date", Nothing)
                loanForm.Add("guarantor_ismale", Nothing)
                loanForm.Add("guarantor_age", Nothing)
                loanForm.Add("guarantor_income_source", Nothing)
                loanForm.Add("guarantor_business_type", Nothing)
                loanForm.Add("loan_amount", Nothing)
                loanForm.Add("monthly_interest_rate", Nothing)
                loanForm.Add("overdue_interest_rate", Nothing)
                loanForm.Add("penalty_rate", Nothing)
                loanForm.Add("term_payment", Nothing)
                loanForm.Add("terms", Nothing)
                loanForm.Add("start_date", Nothing)
                loanForm.Add("payment_mode", Nothing)
                loanForm.Add("recommendedby_name", Nothing)
                loanForm.Add("checkedby_name", Nothing)
                loanForm.Add("relative_fn", Nothing)
                loanForm.Add("realtive_mn", Nothing)
                loanForm.Add("relative_ln", Nothing)
                loanForm.Add("relative_suffix", Nothing)
                loanForm.Add("realtive_house_no", Nothing)
                loanForm.Add("relative_street", Nothing)
                loanForm.Add("relative_brgy", Nothing)
                loanForm.Add("realtive_municipality", Nothing)
                loanForm.Add("relative_province", Nothing)
                loanForm.Add("relation", Nothing)
                loanForm.Add("relative_contact_no", Nothing)
                loanForm.Add("nonschooling_dependents", Nothing)
                loanForm.Add("elementary", Nothing)
                loanForm.Add("highschool", Nothing)
                loanForm.Add("college", Nothing)
                loanForm.Add("private_elementary", Nothing)
                loanForm.Add("private_highschool", Nothing)
                loanForm.Add("private_college", Nothing)
                loanForm.Add("elementary_tuition", Nothing)
                loanForm.Add("highschool_tuition", Nothing)
                loanForm.Add("college_tuition", Nothing)
                loanForm.Add("loan_type", Nothing)
                loanForm.Add("applied_amount", Nothing)
                loanForm.Add("purpose", Nothing)
                loanForm.Add("business_type", Nothing)
                loanForm.Add("business_name", Nothing)
                loanForm.Add("business_house_no", Nothing)
                loanForm.Add("business_street", Nothing)
                loanForm.Add("business_brgy", Nothing)
                loanForm.Add("business_municipality", Nothing)
                loanForm.Add("business_province", Nothing)
                loanForm.Add("business_contact_no", Nothing)
                loanForm.Add("business_age", Nothing)
                loanForm.Add("beginning_capital", Nothing)
                loanForm.Add("borrower_company", Nothing)
                loanForm.Add("borrower_position", Nothing)
                loanForm.Add("borrower_status", Nothing)
                loanForm.Add("borrower_service_length", Nothing)
                loanForm.Add("borrower_monthly_salary", Nothing)
                loanForm.Add("spouse_company", Nothing)
                loanForm.Add("spouse_position", Nothing)
                loanForm.Add("spouse_status", Nothing)
                loanForm.Add("spouse_service_length", Nothing)
                loanForm.Add("spouse_monthly_salary", Nothing)
                loanForm.Add("comaker_fn", Nothing)
                loanForm.Add("comaker_mn", Nothing)
                loanForm.Add("comaker_ln", Nothing)
                loanForm.Add("comaker_suffix", Nothing)
                loanForm.Add("comaker_house_no", Nothing)
                loanForm.Add("comaker_street", Nothing)
                loanForm.Add("comaker_brgy", Nothing)
                loanForm.Add("comaker_municipality", Nothing)
                loanForm.Add("comaker_province", Nothing)
                loanForm.Add("comaker_relation", Nothing)
                loanForm.Add("comaker_occupation", Nothing)
                loanForm.Add("comaker_monthly_income", Nothing)
                loanForm.Add("neighbor1", Nothing)
                loanForm.Add("neighbor2", Nothing)
                loanForm.Add("house_address_rented", Nothing)
                loanForm.Add("business_address_rented", Nothing)
                loanForm.Add("ha_owner_remarks", Nothing)
                loanForm.Add("ba_owner_remarks", Nothing)
                loanForm.Add("house_lot_type", Nothing)
                loanForm.Add("borrower_gross_sale", Nothing)
                loanForm.Add("borrower_sales_cost", Nothing)
                loanForm.Add("borrower_salary", Nothing)
                loanForm.Add("borrower_net_profit", Nothing)
                loanForm.Add("spouse_gross_sale", Nothing)
                loanForm.Add("spouse_sales_cost", Nothing)
                loanForm.Add("spouse_salary", Nothing)
                loanForm.Add("spouse_net_profit", Nothing)
                loanForm.Add("other_specify", Nothing)
                loanForm.Add("total_gross_monthly_income", Nothing)
                loanForm.Add("food", Nothing)
                loanForm.Add("rental", Nothing)
                loanForm.Add("education", Nothing)
                loanForm.Add("transportation", Nothing)
                loanForm.Add("electricity_bill", Nothing)
                loanForm.Add("water_bill", Nothing)
                loanForm.Add("helper_salary", Nothing)
                loanForm.Add("other_expenses", Nothing)
                loanForm.Add("total_monthly_expenses", Nothing)
                loanForm.Add("net_monthly_income", Nothing)
                loanForm.Add("previous_loan", Nothing)
                loanForm.Add("balance", Nothing)
                loanForm.Add("date_granted", Nothing)
                loanForm.Add("days_delinquent", Nothing)
                loanForm.Add("maturity_date", Nothing)
                loanForm.Add("availment", Nothing)
                loanForm.Add("last_payment_date", Nothing)
                loanForm.Add("accounting_staff_name", Nothing)
                loanForm.Add("rbf_business_type", Nothing)
                loanForm.Add("rbf_income", Nothing)
                loanForm.Add("rbf_character", Nothing)
                loanForm.Add("rbf_collateral", Nothing)
                loanForm.Add("principal_amount", Nothing)
                loanForm.Add("remark", Nothing)
                loanForm.Add("submittedby_name", Nothing)
                loanForm.Add("approvedby_name", Nothing)
                loanForm.Add("date_submitted", Nothing)
                loanForm.Add("date_approved", Nothing)
                loanForm.Add("amount_approved", Nothing)
                loanForm.Add("", Nothing)

                Dim collaterals As List(Of Dictionary(Of String, Object)) =
                New List(Of Dictionary(Of String, Object))

                For Each item As ListViewItem In CIRFORMA.ListView2.Items
                    Dim collateral As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
                    collateral.Add("description", item.SubItems(0))
                    collateral.Add("model", item.SubItems(1))
                    collateral.Add("serial_no", item.SubItems(2))
                    collateral.Add("purchase_year", item.SubItems(3))
                    collateral.Add("price", item.SubItems(4))
                    collaterals.Add(collateral)
                Next

                Dim liablities As List(Of Dictionary(Of String, Object)) =
                New List(Of Dictionary(Of String, Object))

                For Each item As ListViewItem In CIRFORMA.ListView1.Items
                    Dim liablity As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
                    liablity.Add("bank", item.SubItems(0))
                    liablity.Add("creditor_name", item.SubItems(1))
                    liablity.Add("loan_amount", item.SubItems(4))
                    liablity.Add("balance", item.SubItems(5))
                    liablity.Add("date_granted", item.SubItems(2))
                    liablity.Add("due_date", item.SubItems(3))
                    liablities.Add(liablity)
                Next

                Dim url As String = "http://wllaneconsulting.com/fundpuhunan/add_loan.php"
                Dim content As MultipartFormDataContent = New MultipartFormDataContent()
                'content.Add(New StringContent(JsonSerializer.Serialize(loanForm)), "loan")
                ' content.Add(New StringContent(JsonSerializer.Serialize(collaterals)), "collaterals")
                'content.Add(New StringContent(JsonSerializer.Serialize(liablities)), "liabilities")
                content.Add(New StreamContent(
                        New FileStream(AppFormA.OpenFileDialog1.FileName, FileMode.Open)),
                        "borrowerPic")
                content.Add(New StreamContent(
                        New FileStream(AppFormA.OpenFileDialog1.FileName, FileMode.Open)),
                        "guarantorSignature")
                content.Add(New StreamContent(
                        New FileStream(AppFormB.OpenFileDialog2.FileName, FileMode.Open)),
                        "householdMemberSignature")
                content.Add(New StreamContent(
                        New FileStream(AppFormB.OpenFileDialog1.FileName, FileMode.Open)),
                        "borrowerSignature")
                content.Add(New StreamContent(
                        New FileStream(AppFormB.OpenFileDialog1.FileName, FileMode.Open)),
                        "accountingStaffSignature")
                content.Add(New StreamContent(
                        New FileStream(AppFormA.OpenFileDialog1.FileName, FileMode.Open)),
                        "submittedbySignature")
                content.Add(New StreamContent(
                        New FileStream(AppFormA.OpenFileDialog1.FileName, FileMode.Open)),
                        "approvedbySignature")
                Me.Close()
            End If
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        CIRFORMA.Show()
    End Sub

    Private Sub CIRFORMB_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        CIRFORMA = Nothing
    End Sub

    Private Sub UploadAppForm_Click(sender As Object, e As EventArgs) Handles UploadAppForm.Click
        Dim OpenFileDialog1 As New OpenFileDialog

        OpenFileDialog1.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg;*.png"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBoxAppForm.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub UploadCIRForm_Click(sender As Object, e As EventArgs) Handles UploadCIRForm.Click
        Dim OpenFileDialog2 As New OpenFileDialog

        OpenFileDialog2.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg;*.png"
        If OpenFileDialog2.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBoxCIR.Image = Image.FromFile(OpenFileDialog2.FileName)
        End If
    End Sub
End Class