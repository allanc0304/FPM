Imports System.Net.Http
Imports System.Text.Json
Imports System.IO
Public Class CIRFORMB
    Public Shared view As Boolean = False
    Private Shared ReadOnly client As HttpClient = New HttpClient()
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

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
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
                loanForm.Add("borrower_ln", AppFormA.P1_LASTNAME.Text)
                loanForm.Add("borrower_suffix", AppFormA.P1_SUFFIX.Text)
                loanForm.Add("house_no", AppFormA.T1_HOUSENO.Text)
                loanForm.Add("street", AppFormA.T1_STREET.Text)
                loanForm.Add("brgy", AppFormA.T1_BARANGAY.Text)
                loanForm.Add("municipality", AppFormA.T1_MUNICIPALITY.Text)
                loanForm.Add("province", AppFormA.T1_PROVINCE.Text)
                loanForm.Add("birth_date", AppFormA.DateTimePicker1.Value.Date)
                loanForm.Add("ismale", AppFormA.RadioButton1.Checked)
                loanForm.Add("age", Convert.ToInt32(AppFormA.E1_AGE.Text))
                loanForm.Add("religion", AppFormA.R1_RELIGION.Text)
                loanForm.Add("contact_no", AppFormA.C1_CONTACT.Text)
                loanForm.Add("spouse_fn", AppFormA.P2_GIVENNAME.Text)
                loanForm.Add("spouse_mn", AppFormA.P2_MIDDLENAME.Text)
                loanForm.Add("spouse_ln", AppFormA.P2_LASTNAME.Text)
                loanForm.Add("spouse_suffix", AppFormA.P2_SUFFIX.Text)
                loanForm.Add("spouse_house_no", AppFormA.T2_HOUSENO.Text)
                loanForm.Add("spouse_street", AppFormA.T2_STREET.Text)
                loanForm.Add("spouse_brgy", AppFormA.T2_BARANGAY.Text)
                loanForm.Add("spouse_municipality", AppFormA.T2_MUNICIPALITY.Text)
                loanForm.Add("spouse_province", AppFormA.T2_PROVINCE.Text)
                loanForm.Add("spouse_birth_date", AppFormA.DateTimePicker2.Value.Date)
                loanForm.Add("spouse_ismale", AppFormA.RadioButton4.Checked)
                loanForm.Add("spouse_age", Convert.ToInt32(AppFormA.E2_AGE.Text))
                loanForm.Add("spouse_religion", AppFormA.R2_RELIGION.Text)
                loanForm.Add("children", Convert.ToInt32(AppFormA.B2_ANAK.Text))
                loanForm.Add("income_source", AppFormA.P3_BUSINESS.Text)
                loanForm.Add("weekly_income", Convert.ToDouble(AppFormA.L3_SALARY.Text))
                loanForm.Add("weekly_household_income", Convert.ToDouble(AppFormA.L3_WEEKLYINCOME.Text))
                loanForm.Add("expenses", Convert.ToDouble(AppFormA.L3_EXPENSES.Text))
                loanForm.Add("net_income", Convert.ToDouble(AppFormA.M3_CLEANSALARY.Text))
                loanForm.Add("guarantor_fn", AppFormA.P4_GIVENNAME.Text)
                loanForm.Add("gurantor_mn", AppFormA.P4_MIDDLENAME.Text)
                loanForm.Add("guarantor_ln", AppFormA.P4_LASTNAME.Text)
                loanForm.Add("guarantor_suffix", AppFormA.P4_SUFFIX)
                loanForm.Add("guarantor_house_no", AppFormA.T4_HOUSENO.Text)
                loanForm.Add("guarontor_street", AppFormA.T4_STREET.Text)
                loanForm.Add("guarantor_brgy", AppFormA.T4_BARANGAY.Text)
                loanForm.Add("guarantor_municipality", AppFormA.T4_MUNICIPALITY.Text)
                loanForm.Add("guarantor_province", AppFormA.T4_PROVINCE.Text)
                loanForm.Add("guarantor_birth_date", AppFormA.DateTimePicker3.Value.Date)
                loanForm.Add("guarantor_ismale", AppFormA.RadioButton6.Checked)
                loanForm.Add("guarantor_age", Convert.ToInt32(AppFormA.E4_AGE.Text))
                loanForm.Add("guarantor_income_source", AppFormA.B4_BUSINESS.Text)
                loanForm.Add("guarantor_business_type", AppFormA.T4_TYPEOFBUSINESS.Text)
                loanForm.Add("loan_amount", Convert.ToInt32(AppFormB.H1_HALAGA.Text))
                loanForm.Add("monthly_interest_rate", 3.75)
                loanForm.Add("overdue_interest_rate", 6.0)
                loanForm.Add("penalty_rate", 3.0)
                loanForm.Add("term_payment", Convert.ToInt32(AppFormB.PH1_PAGHULOG.Text))
                loanForm.Add("terms", Convert.ToInt32(AppFormB.TP2_TAGAL_NG_PAGBAYAD.Text))
                loanForm.Add("start_date", AppFormB.DateTimePicker1.Value.Date)
                loanForm.Add("payment_mode", AppFormB.PP2_PARAAN_PAGBAYAD.Text)
                loanForm.Add("recommendedby_name", AppFormB.R2_RECOMMENDED.Text)
                loanForm.Add("checkedby_name", AppFormB.CB2_CHECKEDBY.Text)
                loanForm.Add("relative_fn", CIRFORMA.NOR_GN.Text)
                loanForm.Add("realtive_mn", CIRFORMA.NOR_MN.Text)
                loanForm.Add("relative_ln", CIRFORMA.NOR_LN)
                loanForm.Add("relative_suffix", CIRFORMA.NOR_SUFF.Text)
                loanForm.Add("realtive_house_no", CIRFORMA.CIR_HOUSENO1.Text)
                loanForm.Add("relative_street", CIRFORMA.CIR_ST1.Text)
                loanForm.Add("relative_brgy", CIRFORMA.CIR_BRGY1.Text)
                loanForm.Add("realtive_municipality", CIRFORMA.CIR_MUN1.Text)
                loanForm.Add("relative_province", CIRFORMA.CIR_PRO1.Text)
                loanForm.Add("relation", CIRFORMA.CIR_RELATION.Text)
                loanForm.Add("relative_contact_no", CIRFORMA.CIR_CONTACT1.Text)
                loanForm.Add("nonschooling_dependents", Convert.ToInt32(CIRFORMA.NOD_NS.Text))
                loanForm.Add("elementary", Convert.ToInt32(CIRFORMA.ELEM_GS.Text))
                loanForm.Add("highschool", Convert.ToInt32(CIRFORMA.HS_GS.Text))
                loanForm.Add("college", Convert.ToInt32(CIRFORMA.COLLEGE_GS))
                loanForm.Add("private_elementary", Convert.ToInt32(CIRFORMA.ELEM_PS.Text))
                loanForm.Add("private_highschool", Convert.ToInt32(CIRFORMA.HS_PS.Text))
                loanForm.Add("private_college", Convert.ToInt32(CIRFORMA.COLLEGE_PS))
                loanForm.Add("elementary_tuition", Convert.ToDouble(CIRFORMA.ELEM_TF.Text))
                loanForm.Add("highschool_tuition", Convert.ToDouble(CIRFORMA.HS_TF))
                loanForm.Add("college_tuition", Convert.ToDouble(CIRFORMA.COLLEGE_TF))
                loanForm.Add("loan_type", "new") 'tatanggalin na yung radioBtn kaya constant muna
                loanForm.Add("applied_amount", Convert.ToDouble(CIRFORMA.TOL_AAP.Text))
                loanForm.Add("purpose", CIRFORMA.TOL_PURP.Text)
                loanForm.Add("business_type", CIRFORMA.BR_TOB.Text)
                loanForm.Add("business_name", CIRFORMA.BR_NOB.Text)
                loanForm.Add("business_house_no", CIRFORMA.BR_HOUSENO.Text)
                loanForm.Add("business_street", CIRFORMA.BR_ST.Text)
                loanForm.Add("business_brgy", CIRFORMA.BR_BRGY.Text)
                loanForm.Add("business_municipality", CIRFORMA.BR_MUN.Text)
                loanForm.Add("business_province", CIRFORMA.BR_PRO.Text)
                loanForm.Add("business_contact_no", CIRFORMA.BR_CONT.Text)
                loanForm.Add("business_age", Convert.ToInt32(CIRFORMA.BR_NYB.Text))
                loanForm.Add("beginning_capital", Convert.ToDouble(CIRFORMA.BR_BC.Text))
                loanForm.Add("borrower_company", CIRFORMA.ER_COMP.Text)
                loanForm.Add("borrower_position", CIRFORMA.ER_POS.Text)
                loanForm.Add("borrower_status", CIRFORMA.ER_STATUS.Text)
                loanForm.Add("borrower_service_length", Convert.ToInt32(CIRFORMA.ER_LOS.Text))
                loanForm.Add("borrower_monthly_salary", Convert.ToDouble(CIRFORMA.ER_MS.Text))
                loanForm.Add("spouse_company", CIRFORMA.ER_COMP1.Text)
                loanForm.Add("spouse_position", CIRFORMA.ER_POS1.Text)
                loanForm.Add("spouse_status", CIRFORMA.ER_STATUS1.Text)
                loanForm.Add("spouse_service_length", Convert.ToInt32(CIRFORMA.ER_LOS1.Text))
                loanForm.Add("spouse_monthly_salary", Convert.ToDouble(CIRFORMA.ER_MS1.Text))
                loanForm.Add("comaker_fn", CIRFORMA.N_GN.Text)
                loanForm.Add("comaker_mn", CIRFORMA.N_MN.Text)
                loanForm.Add("comaker_ln", CIRFORMA.N_LN.Text)
                loanForm.Add("comaker_suffix", CIRFORMA.N_SUFF.Text)
                loanForm.Add("comaker_house_no", CIRFORMA.CC_HOUSENO.Text)
                loanForm.Add("comaker_street", CIRFORMA.CC_ST.Text)
                loanForm.Add("comaker_brgy", CIRFORMA.CC_BRGY.Text)
                loanForm.Add("comaker_municipality", CIRFORMA.CC_MUN.Text)
                loanForm.Add("comaker_province", CIRFORMA.CC_PRO.Text)
                loanForm.Add("comaker_relation", CIRFORMA.CC_RELATION.Text)
                loanForm.Add("comaker_occupation", CIRFORMA.CC_OCCU.Text)
                loanForm.Add("comaker_monthly_income", Convert.ToDouble(CIRFORMA.CC_MI.Text))
                loanForm.Add("neighbor1", CIRFORMA.NF_NAIN1.Text)
                loanForm.Add("neighbor2", CIRFORMA.NF_NAIN2.Text)
                loanForm.Add("house_address_rented", CIRFORMA.NF_RENT_HOME.Checked)
                loanForm.Add("business_address_rented", CIRFORMA.NF_RENT_BUSINESS.Checked)
                loanForm.Add("ha_owner_remarks", CIRFORMA.NF_ROR.Text)
                loanForm.Add("ba_owner_remarks", CIRFORMA.NF_ROR1.Text)
                If (CIRFORMA.CB_AGRI.Checked) Then
                    loanForm.Add("house_lot_type", "agricultural")
                ElseIf (CIRFORMA.CB_COM.Checked) Then
                    loanForm.Add("house_lot_type", "commercial")
                ElseIf (CIRFORMA.CB_INDU.Checked) Then
                    loanForm.Add("house_lot_type", "industrial")
                ElseIf (CIRFORMA.CB_RESI.Checked) Then
                    loanForm.Add("house_lot_type", "residential")
                Else
                    loanForm.Add("house_lot_type", "residential")
                End If
                loanForm.Add("borrower_gross_sale", Convert.ToDouble(txtAppGSale.Text))
                loanForm.Add("borrower_sales_cost", Convert.ToDouble(txtAppCSale.Text))
                loanForm.Add("borrower_salary", Convert.ToDouble(txtAppSalary.Text))
                loanForm.Add("borrower_net_profit", Convert.ToDouble(txtAppNProfit.Text))
                loanForm.Add("spouse_gross_sale", Convert.ToDouble(txtSpoGSale.Text))
                loanForm.Add("spouse_sales_cost", Convert.ToDouble(txtSpoCSale.Text))
                loanForm.Add("spouse_salary", Convert.ToDouble(txtSpoSalary.Text))
                loanForm.Add("spouse_net_profit", Convert.ToDouble(txtSpoNProfit.Text))
                loanForm.Add("other_specify", txtOtherSpec.Text)
                loanForm.Add("total_gross_monthly_income", Convert.ToDouble(txtGIncome.Text))
                loanForm.Add("food", Convert.ToDouble(txtFood.Text))
                loanForm.Add("rental", Convert.ToDouble(txtRental.Text))
                loanForm.Add("education", Convert.ToDouble(txtAllowance.Text))
                loanForm.Add("transportation", Convert.ToDouble(txtTranspo.Text))
                loanForm.Add("electricity_bill", Convert.ToDouble(txtEBill.Text))
                loanForm.Add("water_bill", Convert.ToDouble(txtWBill.Text))
                loanForm.Add("helper_salary", Convert.ToDouble(txtHSalary.Text))
                loanForm.Add("other_expenses", Convert.ToDouble(txtPersoOther.Text))
                loanForm.Add("total_monthly_expenses", Convert.ToDouble(txtExpenses.Text))
                loanForm.Add("net_monthly_income", Convert.ToDouble(txtNIncome.Text))
                loanForm.Add("previous_loan", Convert.ToDouble(txtPLoan.Text))
                loanForm.Add("balance", Convert.ToDouble(txtBalance.Text))
                loanForm.Add("date_granted", calDGranted.Value.Date)
                loanForm.Add("days_delinquent", Convert.ToInt32(txtDelinquent.Text))
                loanForm.Add("maturity_date", calMDate.Value.Date)
                loanForm.Add("availment", Convert.ToInt32(txtAvailment.Text))
                loanForm.Add("last_payment_date", calLPayment.Value.Date)
                loanForm.Add("accounting_staff_name", txtAccSignature.Text)
                loanForm.Add("rbf_business_type", chbBusiness.Checked)
                loanForm.Add("rbf_income", chbIncome.Checked)
                loanForm.Add("rbf_character", chbCharacter.Checked)
                loanForm.Add("rbf_collateral", chbCollateral.Checked)
                loanForm.Add("principal_amount", Convert.ToDouble(txtPAmount.Text))
                loanForm.Add("remark", txtRecRemarks.Text)
                loanForm.Add("accounting_staff_remark", txtAccRemarks.Text)

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
                ' content.Add(New StringContent(JsonSerializer.Serialize(loanForm)), "loan") '
                ' content.Add(New StringContent(JsonSerializer.Serialize(collaterals)), "collaterals") '
                ' content.Add(New StringContent(JsonSerializer.Serialize(liablities)), "liabilities")'
                content.Add(New StreamContent(
                            New FileStream(AppFormA.OpenFileDialog1.FileName, FileMode.Open)),
                            "borrowerPic")
                content.Add(New StreamContent(
                        New FileStream(PictureBoxAppForm.ImageLocation, FileMode.Open)),
                        "form1")
                content.Add(New StreamContent(
                        New FileStream(PictureBoxCIR.ImageLocation, FileMode.Open)),
                        "form2")
                Dim response = Await client.PostAsync(url, content)
                Dim responseCode = Convert.ToInt32(response.StatusCode)
                If (Not responseCode = 201) Then
                    MessageBox.Show(Await response.Content.ReadAsStringAsync(), "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show(Await response.Content.ReadAsStringAsync())
                End If
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

    Private Sub CIRFORMB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtBLname.Text = AppFormA.P1_LASTNAME.Text
        Me.txtBFname.Text = AppFormA.P1_GIVENNAME.Text
        Me.txtBMname.Text = AppFormA.P1_MIDDLENAME.Text
        Me.txtBSuffix.Text = AppFormA.P1_SUFFIX.Text
        Button1.Visible = False
        If View = True Then
            For Each control As Control In Me.Controls
                If (Not TypeOf (control) Is Label) Then
                    control.Enabled = False
                End If
            Next
            Button1.Visible = True
            btnSubmit.Visible = False
            Button1.Enabled = True
            btnCancel.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

End Class