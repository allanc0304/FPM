Imports DBConnection
Public Class Application
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        AppFormA.Show()


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
            AppFormA.P1_LASTNAME.Text = applicationObj.BorrowerLN
            AppFormA.P1_GIVENNAME.Text = applicationObj.BorrowerFN
            AppFormA.P1_MIDDLENAME.Text = applicationObj.BorrowerMN
            AppFormA.P1_SUFFIX.Text = applicationObj.BorrowerSuffix
            AppFormA.T1_HOUSENO.Text = applicationObj.HouseNo
            AppFormA.T1_STREET.Text = applicationObj.Street
            AppFormA.T1_BARANGAY.Text = applicationObj.Brgy
            AppFormA.T1_MUNICIPALITY.Text = applicationObj.Municipality
            AppFormA.T1_PROVINCE.Text = applicationObj.Province
            AppFormA.K1_MONTH.Text = applicationObj.BirthDate.Month
            AppFormA.K1_DAY.Text = applicationObj.BirthDate.Day
            AppFormA.K1_YEAR.Text = applicationObj.BirthDate.Year
            If applicationObj.IsMale = True Then
                AppFormA.RadioButton1.Checked = True
            Else
                AppFormA.RadioButton2.Checked = True
            End If
            AppFormA.E1_AGE.Text = applicationObj.Age
            AppFormA.R1_RELIGION.Text = applicationObj.Religion
            AppFormA.C1_CONTACT.Text = applicationObj.ContactNo
            AppFormA.P2_LASTNAME.Text = applicationObj.SpouseLN
            AppFormA.P2_GIVENNAME.Text = applicationObj.SpouseFN
            AppFormA.P2_MIDDLENAME.Text = applicationObj.SpouseMN
            AppFormA.P2_SUFFIX.Text = applicationObj.SpouseSuffix
            AppFormA.T2_HOUSENO.Text = applicationObj.SpouseHouseNo
            AppFormA.T2_STREET.Text = applicationObj.SpouseStreet
            AppFormA.T2_BARANGAY.Text = applicationObj.SpouseBrgy
            AppFormA.T2_MUNICIPALITY.Text = applicationObj.SpouseMunicipality
            AppFormA.T2_PROVINCE.Text = applicationObj.SpouseProvince
            AppFormA.K2_MONTH.Text = applicationObj.SpouseBirthDate.Month
            AppFormA.K2_DAY.Text = applicationObj.SpouseBirthDate.Day
            AppFormA.K2_YEAR.Text = applicationObj.SpouseBirthDate.Year
            If applicationObj.SpouseIsMale = True Then
                AppFormA.RadioButton4.Checked = True
            Else
                AppFormA.RadioButton3.Checked = True
            End If
            AppFormA.E2_AGE.Text = applicationObj.SpouseAge
            AppFormA.B2_ANAK.Text = applicationObj.Children
            AppFormA.R2_RELIGION.Text = applicationObj.SpouseReligion
            AppFormA.P3_BUSINESS.Text = applicationObj.IncomeSource
            AppFormA.L3_SALARY.Text = applicationObj.WeeklyIncome
            AppFormA.L3_EXPENSES.Text = applicationObj.Expenses
            AppFormA.L3_WEEKLYINCOME.Text = applicationObj.WeeklyHouseholdIncome
            AppFormA.M3_CLEANSALARY.Text = applicationObj.DisposableIncome
            AppFormA.P4_LASTNAME.Text = applicationObj.GuarantorLN
            AppFormA.P4_GIVENNAME.Text = applicationObj.GuarantorFN
            AppFormA.P4_MIDDLENAME.Text = applicationObj.GuarantorMN
            AppFormA.P4_SUFFIX.Text = applicationObj.GuarantorSuffix
            AppFormA.T4_HOUSENO.Text = applicationObj.GuarantorHouseNo
            AppFormA.T4_STREET.Text = applicationObj.GuarantorStreet
            AppFormA.T4_BARANGAY.Text = applicationObj.GuarantorBrgy
            AppFormA.T4_MUNICIPALITY.Text = applicationObj.GuarantorMunicipality
            AppFormA.T4_PROVINCE.Text = applicationObj.GuarantorProvince

            AppFormA.K4_DAY.Text = applicationObj.GuarantorBirthDate.Day
            AppFormA.K4_YEAR.Text = applicationObj.GuarantorBirthDate.Year
            If applicationObj.GuarantorIsMale = True Then
                AppFormA.RadioButton6.Checked = True
            Else
                AppFormA.RadioButton5.Checked = True
            End If
            AppFormA.B4_BUSINESS.Text = applicationObj.GuarantorIncomeSource
            AppFormA.T4_TYPEOFBUSINESS.Text = applicationObj.GuarantorBusinessType
            AppFormA.E4_AGE.Text = applicationObj.GuarantorAge

            AppFormB.P1_LASTNAME.Text = applicationObj.BorrowerLN
            AppFormB.P1_GIVENNAME.Text = applicationObj.BorrowerFN

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

            AppFormA.Show()
            AppFormA.BringToFront()

        ElseIf e.ColumnIndex = 7 Then
            MessageBox.Show("delete")
        End If
    End Sub

    Private Sub Application_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        AppFormA.Show()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)
        SearchApplication.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        AppFormA.Show()


    End Sub
End Class