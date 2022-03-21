Imports DBConnection
Public Class Application
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ApplictaionForm1.Show()


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
            Dim exception = SQLHelper.GetApplication(connection, HolderSingleton.selectedLoanApplication, loanId)
            If exception IsNot Nothing Then
                MessageBox.Show(exception.Message)
                Exit Sub
            End If
            Dim applicationObj = HolderSingleton.selectedLoanApplication
            ApplictaionForm1.P1_LASTNAME.Text = applicationObj.BorrowerLN
            ApplictaionForm1.P1_GIVENNAME.Text = applicationObj.BorrowerFN
            ApplictaionForm1.P1_MIDDLENAME.Text = applicationObj.BorrowerMN
            ApplictaionForm1.P1_SUFFIX.Text = applicationObj.BorrowerSuffix
            ApplictaionForm1.T1_HOUSENO.Text = applicationObj.HouseNo
            ApplictaionForm1.T1_STREET.Text = applicationObj.Street
            ApplictaionForm1.T1_BARANGAY.Text = applicationObj.Brgy
            ApplictaionForm1.T1_MUNICIPALITY.Text = applicationObj.Municipality
            ApplictaionForm1.T1_PROVINCE.Text = applicationObj.Province
            ApplictaionForm1.K1_MONTH.Text = applicationObj.BirthDate.Month
            ApplictaionForm1.K1_DAY.Text = applicationObj.BirthDate.Day
            ApplictaionForm1.S.Text = applicationObj.BirthDate.Year
            If applicationObj.IsMale = True Then
                ApplictaionForm1.RadioButton1.Checked = True
            Else
                ApplictaionForm1.RadioButton2.Checked = True
            End If
            ApplictaionForm1.E1_AGE.Text = applicationObj.Age
            ApplictaionForm1.R1_RELIGION.Text = applicationObj.Religion
            ApplictaionForm1.C1_CONTACT.Text = applicationObj.ContactNo
            ApplictaionForm1.P2_LASTNAME.Text = applicationObj.SpouseLN
            ApplictaionForm1.P2_GIVENNAME.Text = applicationObj.SpouseFN
            ApplictaionForm1.P2_MIDDLENAME.Text = applicationObj.SpouseMN
            ApplictaionForm1.P2_SUFFIX.Text = applicationObj.SpouseSuffix
            ApplictaionForm1.T2_HOUSENO.Text = applicationObj.SpouseHouseNo
            ApplictaionForm1.T2_STREET.Text = applicationObj.SpouseStreet
            ApplictaionForm1.T2_BARANGAY.Text = applicationObj.SpouseBrgy
            ApplictaionForm1.T2_MUNICIPALITY.Text = applicationObj.SpouseMunicipality
            ApplictaionForm1.T2_PROVINCE.Text = applicationObj.SpouseProvince
            ApplictaionForm1.K2_MONTH.Text = applicationObj.SpouseBirthDate.Month
            ApplictaionForm1.K2_DAY.Text = applicationObj.SpouseBirthDate.Day
            ApplictaionForm1.K2_YEAR.Text = applicationObj.SpouseBirthDate.Year
            If applicationObj.SpouseIsMale = True Then
                ApplictaionForm1.RadioButton4.Checked = True
            Else
                ApplictaionForm1.RadioButton3.Checked = True
            End If
            ApplictaionForm1.E2_AGE.Text = applicationObj.SpouseAge
            ApplictaionForm1.B2_ANAK.Text = applicationObj.Children
            ApplictaionForm1.R2_RELIGION.Text = applicationObj.SpouseReligion
            ApplictaionForm1.P3_BUSINESS.Text = applicationObj.IncomeSource
            ApplictaionForm1.L3_SALARY.Text = applicationObj.WeeklyIncome
            ApplictaionForm1.L3_EXPENSES.Text = applicationObj.Expenses
            ApplictaionForm1.L3_WEEKLYINCOME.Text = applicationObj.WeeklyHouseholdIncome
            ApplictaionForm1.M3_CLEANSALARY.Text = applicationObj.DisposableIncome
            ApplictaionForm1.P4_LASTNAME.Text = applicationObj.GuarantorLN
            ApplictaionForm1.P4_GIVENNAME.Text = applicationObj.GuarantorFN
            ApplictaionForm1.P4_MIDDLENAME.Text = applicationObj.GuarantorMN
            ApplictaionForm1.P4_SUFFIX.Text = applicationObj.GuarantorSuffix
            ApplictaionForm1.T4_HOUSENO.Text = applicationObj.GuarantorHouseNo
            ApplictaionForm1.T4_STREET.Text = applicationObj.GuarantorStreet
            ApplictaionForm1.T4_BARANGAY.Text = applicationObj.GuarantorBrgy
            ApplictaionForm1.T4_MUNICIPALITY.Text = applicationObj.GuarantorMunicipality
            ApplictaionForm1.T4_PROVINCE.Text = applicationObj.GuarantorProvince
            ApplictaionForm1.K4_MONTH.Text = applicationObj.GuarantorBirthDate.MonthS
            ApplictaionForm1.K4_DAY.Text = applicationObj.GuarantorBirthDate.Day
            ApplictaionForm1.K4_YEAR.Text = applicationObj.GuarantorBirthDate.Year
            If applicationObj.GuarantorIsMale = True Then
                ApplictaionForm1.RadioButton6.Checked = True
            Else
                ApplictaionForm1.RadioButton5.Checked = True
            End If
            ApplictaionForm1.B4_BUSINESS.Text = applicationObj.GuarantorIncomeSource
            ApplictaionForm1.T4_TYPEOFBUSINESS.Text = applicationObj.GuarantorBusinessType
            ApplictaionForm1.E4_AGE.Text = applicationObj.GuarantorAge

            AppFormB.P1_LASTNAME.Text = applicationObj.BorrowerLN
            AppFormB.P1_GIVENNAME.Text = applicationObj.BorrowerFN
            AppFormB.P1_MIDDLENAME.Text = applicationObj.BorrowerMNS
            AppFormB.P1_SUFFIX.Text = applicationObj.BorrowerSuffix
            AppFormB.T1_HOUSENO.Text = applicationObj.HouseNo
            AppFormB.T1_STREET.Text = applicationObj.Street
            AppFormB.T1_BARANGAY.Text = applicationObj.Brgy
            AppFormB.T1_MUNICIPALITY.Text = applicationObj.Municipality
            AppFormB.T1_PROVINCE.Text = applicationObj.Province
            AppFormB.H1_HALAGA.Text = applicationObj.LoanAmount
            AppFormB.PH1_PAGHULOG.Text = applicationObj.WeeklyPayment
            AppFormB.DateTimePicker1.Value = applicationObj.StartDate
            For Each collateral As Collateral In applicationObj.Collaterals
                Dim item As New ListViewItem(collateral.Description)
                item.SubItems.Add(collateral.Model)
                item.SubItems.Add(collateral.SerialNo)
                item.SubItems.Add(collateral.Price)
                AppFormB.ListView1.Items.Add(item)
            Next
            AppFormB.P2_LASTNAME.Text = applicationObj.BorrowerLN
            AppFormB.P2_GIVENNAME.Text = applicationObj.BorrowerFN
            AppFormB.P2_MIDDLENAME.Text = applicationObj.BorrowerMN
            AppFormB.P2_SUFFIX.Text = applicationObj.BorrowerSuffix
            AppFormB.T2_HOUSENO.Text = applicationObj.HouseNo
            AppFormB.T2_STREET.Text = applicationObj.Street
            AppFormB.T2_BARANGAY.Text = applicationObj.Brgy
            AppFormB.T2_MUNICIPALITY.Text = applicationObj.Municipality
            AppFormB.T2_PROVINCE.Text = applicationObj.Province
            AppFormB.DateTimePicker2.Value = applicationObj.StartDate
            AppFormB.H2_HALAGA.Text = applicationObj.LoanAmount
            AppFormB.HH2_HALAGANG_HINIRAM.Text = applicationObj.LoanAmount
            AppFormB.TP2_TAGAL_NG_PAGBAYAD.Text = applicationObj.Term.ToString + " Weeks"
            AppFormB.PP2_PARAAN_PAGBAYAD.Text = "Weekly"
            AppFormB.R2_RECOMMENDED.Text = applicationObj.RecommenderName
            AppFormB.AL2_LOAN.Text = applicationObj.LoanAmount
            AppFormB.CB2_CHECKEDBY.Text = applicationObj.CheckerName

            ApplictaionForm1.Show()
            ApplictaionForm1.BringToFront()

        ElseIf e.ColumnIndex = 7 Then
            MessageBox.Show("delete")
        End If
    End Sub

    Private Sub Application_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class