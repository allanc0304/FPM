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
            ApplictaionForm1.TextBox1.Text = applicationObj.BorrowerLN
            ApplictaionForm1.Middlename_1.Text = applicationObj.BorrowerFN
            ApplictaionForm1.TextBox2.Text = applicationObj.BorrowerMN
            ApplictaionForm1.suffix_1.Text = applicationObj.BorrowerSuffix
            ApplictaionForm1.TextBox3.Text = applicationObj.HouseNo
            ApplictaionForm1.TextBox4.Text = applicationObj.Street
            ApplictaionForm1.TextBox5.Text = applicationObj.Brgy
            ApplictaionForm1.TextBox6.Text = applicationObj.Municipality
            ApplictaionForm1.TextBox7.Text = applicationObj.Province
            ApplictaionForm1.TextBox8.Text = applicationObj.BirthDate.Month
            ApplictaionForm1.TextBox9.Text = applicationObj.BirthDate.Day
            ApplictaionForm1.TextBox10.Text = applicationObj.BirthDate.Year
            If applicationObj.IsMale = True Then
                ApplictaionForm1.RadioButton1.Checked = True
            Else
                ApplictaionForm1.RadioButton2.Checked = True
            End If
            ApplictaionForm1.TextBox11.Text = applicationObj.Age
            ApplictaionForm1.TextBox12.Text = applicationObj.Religion
            ApplictaionForm1.TextBox13.Text = applicationObj.ContactNo
            ApplictaionForm1.TextBox14.Text = applicationObj.SpouseLN
            ApplictaionForm1.Middllename_2.Text = applicationObj.SpouseFN
            ApplictaionForm1.TextBox15.Text = applicationObj.SpouseMN
            ApplictaionForm1.Suffix_2.Text = applicationObj.SpouseSuffix
            ApplictaionForm1.TextBox16.Text = applicationObj.SpouseHouseNo
            ApplictaionForm1.TextBox17.Text = applicationObj.SpouseStreet
            ApplictaionForm1.TextBox18.Text = applicationObj.SpouseBrgy
            ApplictaionForm1.TextBox19.Text = applicationObj.SpouseMunicipality
            ApplictaionForm1.TextBox20.Text = applicationObj.SpouseProvince
            ApplictaionForm1.TextBox21.Text = applicationObj.SpouseBirthDate.Month
            ApplictaionForm1.TextBox22.Text = applicationObj.SpouseBirthDate.Day
            ApplictaionForm1.TextBox23.Text = applicationObj.SpouseBirthDate.Year
            If applicationObj.SpouseIsMale = True Then
                ApplictaionForm1.RadioButton4.Checked = True
            Else
                ApplictaionForm1.RadioButton3.Checked = True
            End If
            ApplictaionForm1.TextBox24.Text = applicationObj.SpouseAge
            ApplictaionForm1.TextBox25.Text = applicationObj.Children
            ApplictaionForm1.TextBox26.Text = applicationObj.SpouseReligion
            ApplictaionForm1.TextBox27.Text = applicationObj.IncomeSource
            ApplictaionForm1.TextBox28.Text = applicationObj.WeeklyIncome
            ApplictaionForm1.TextBox29.Text = applicationObj.Expenses
            ApplictaionForm1.TextBox30.Text = applicationObj.WeeklyHouseholdIncome
            ApplictaionForm1.TextBox31.Text = applicationObj.DisposableIncome
            ApplictaionForm1.TextBox33.Text = applicationObj.GuarantorLN
            ApplictaionForm1.Middlename_3.Text = applicationObj.GuarantorFN
            ApplictaionForm1.TextBox32.Text = applicationObj.GuarantorMN
            ApplictaionForm1.Suffix_3.Text = applicationObj.GuarantorSuffix
            ApplictaionForm1.TextBox38.Text = applicationObj.GuarantorHouseNo
            ApplictaionForm1.TextBox37.Text = applicationObj.GuarantorStreet
            ApplictaionForm1.TextBox36.Text = applicationObj.GuarantorBrgy
            ApplictaionForm1.TextBox35.Text = applicationObj.GuarantorMunicipality
            ApplictaionForm1.TextBox34.Text = applicationObj.GuarantorProvince
            ApplictaionForm1.TextBox41.Text = applicationObj.GuarantorBirthDate.Month
            ApplictaionForm1.TextBox40.Text = applicationObj.GuarantorBirthDate.Day
            ApplictaionForm1.TextBox39.Text = applicationObj.GuarantorBirthDate.Year
            If applicationObj.GuarantorIsMale = True Then
                ApplictaionForm1.RadioButton6.Checked = True
            Else
                ApplictaionForm1.RadioButton5.Checked = True
            End If
            ApplictaionForm1.TextBox43.Text = applicationObj.GuarantorIncomeSource
            ApplictaionForm1.TextBox44.Text = applicationObj.GuarantorBusinessType
            ApplictaionForm1.TextBox42.Text = applicationObj.GuarantorAge

            AppFormB.TextBox1.Text = applicationObj.BorrowerLN
            AppFormB.TextBox2.Text = applicationObj.BorrowerFN
            AppFormB.TextBox3.Text = applicationObj.BorrowerMN
            AppFormB.TextBox4.Text = applicationObj.BorrowerSuffix
            AppFormB.TextBox5.Text = applicationObj.HouseNo
            AppFormB.TextBox6.Text = applicationObj.Street
            AppFormB.TextBox7.Text = applicationObj.Brgy
            AppFormB.TextBox8.Text = applicationObj.Municipality
            AppFormB.TextBox9.Text = applicationObj.Province
            AppFormB.TextBox10.Text = applicationObj.LoanAmount
            AppFormB.TextBox11.Text = applicationObj.WeeklyPayment
            AppFormB.DateTimePicker1.Value = applicationObj.StartDate
            For Each collateral As Collateral In applicationObj.Collaterals
                Dim item As New ListViewItem(collateral.Description)
                item.SubItems.Add(collateral.Model)
                item.SubItems.Add(collateral.SerialNo)
                item.SubItems.Add(collateral.Price)
                AppFormB.ListView1.Items.Add(item)
            Next
            AppFormB.TextBox16.Text = applicationObj.BorrowerLN
            AppFormB.TextBox17.Text = applicationObj.BorrowerFN
            AppFormB.TextBox18.Text = applicationObj.BorrowerMN
            AppFormB.TextBox19.Text = applicationObj.BorrowerSuffix
            AppFormB.TextBox20.Text = applicationObj.HouseNo
            AppFormB.TextBox21.Text = applicationObj.Street
            AppFormB.TextBox22.Text = applicationObj.Brgy
            AppFormB.TextBox24.Text = applicationObj.Municipality
            AppFormB.TextBox23.Text = applicationObj.Province
            AppFormB.DateTimePicker2.Value = applicationObj.StartDate
            AppFormB.TextBox25.Text = applicationObj.LoanAmount
            AppFormB.TextBox26.Text = applicationObj.LoanAmount
            AppFormB.TextBox27.Text = applicationObj.Term.ToString + " Weeks"
            AppFormB.TextBox28.Text = "Weekly"
            AppFormB.TextBox29.Text = applicationObj.RecommenderName
            AppFormB.TextBox30.Text = applicationObj.LoanAmount
            AppFormB.TextBox31.Text = applicationObj.CheckerName

            ApplictaionForm1.Show()
            ApplictaionForm1.BringToFront()

        ElseIf e.ColumnIndex = 7 Then
            MessageBox.Show("delete")
        End If
    End Sub
End Class