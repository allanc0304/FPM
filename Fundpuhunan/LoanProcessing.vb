Imports DBConnection
Public Class LoanProcessing
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CIRFORM1.Show()
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
            Dim exception = SQLHelper.GetCIR(connection, HolderSingleton.selectedCIR, loanId)
            If exception IsNot Nothing Then
                MessageBox.Show(exception.Message)
                Exit Sub
            End If
            Dim cirObj = HolderSingleton.selectedCIR
            CIRFORM1.TextBox1.Text = cirObj.BorrowerLN
            CIRFORM1.TextBox2.Text = cirObj.BorrowerFN
            CIRFORM1.TextBox3.Text = cirObj.BorrowerMN
            CIRFORM1.TextBox4.Text = cirObj.BorrowerSuffix
            CIRFORM1.ComboBox2.Items.Add(cirObj.BirthDate.Month)
            CIRFORM1.ComboBox3.Items.Add(cirObj.BirthDate.Day)
            CIRFORM1.ComboBox4.Items.Add(cirObj.BirthDate.Year)
            CIRFORM1.ComboBox2.SelectedIndex = 0
            CIRFORM1.ComboBox3.SelectedIndex = 0
            CIRFORM1.ComboBox4.SelectedIndex = 0
            CIRFORM1.ComboBox1.Items.Add(cirObj.Age)
            CIRFORM1.ComboBox1.SelectedIndex = 0
            CIRFORM1.TextBox10.Text = cirObj.HouseNo
            CIRFORM1.TextBox9.Text = cirObj.Street
            CIRFORM1.TextBox8.Text = cirObj.Brgy
            CIRFORM1.TextBox11.Text = cirObj.Municipality
            CIRFORM1.TextBox12.Text = cirObj.Province
            CIRFORM1.TextBox18.Text = cirObj.ContactNo
            CIRFORM1.TextBox16.Text = cirObj.RelativeLN
            CIRFORM1.TextBox15.Text = cirObj.RelativeFN
            CIRFORM1.TextBox14.Text = cirObj.RelativeMN
            CIRFORM1.TextBox13.Text = cirObj.RelativeSuffix
            CIRFORM1.TextBox17.Text = cirObj.Relation
            CIRFORM1.TextBox24.Text = cirObj.RelativeHouseNo
            CIRFORM1.TextBox23.Text = cirObj.RelativeStreet
            CIRFORM1.TextBox22.Text = cirObj.RelativeBrgy
            CIRFORM1.TextBox21.Text = cirObj.RelativeMunicipality
            CIRFORM1.TextBox20.Text = cirObj.RelativeProvince
            CIRFORM1.TextBox19.Text = cirObj.RelativeContactNo
            CIRFORM1.ComboBox5.Items.Add(cirObj.NonSchoolingDependents)
            CIRFORM1.ComboBox5.SelectedIndex = 0
            CIRFORM1.TextBox36.Text = cirObj.PrivateElementary
            CIRFORM1.TextBox37.Text = cirObj.PrivateHighSchool
            CIRFORM1.TextBox38.Text = cirObj.PrivateCollege
            CIRFORM1.TextBox41.Text = cirObj.Elementary
            CIRFORM1.TextBox40.Text = cirObj.HighSchool
            CIRFORM1.TextBox39.Text = cirObj.College
            CIRFORM1.TextBox44.Text = cirObj.ElementaryTuition
            CIRFORM1.TextBox43.Text = cirObj.HighSchoolTuition
            CIRFORM1.TextBox42.Text = cirObj.CollegeTuition
            If cirObj.LoanType = "new" Then
                CIRFORM1.CheckBox1.Checked = True
            ElseIf cirObj.LoanType = "renewal" Then
                CIRFORM1.CheckBox2.Checked = True
            Else
                CIRFORM1.CheckBox3.Checked = True
            End If
            CIRFORM1.TextBox51.Text = cirObj.AppliedAmount
            CIRFORM1.TextBox50.Text = cirObj.Purpose
            CIRFORM1.TextBox49.Text = cirObj.Terms
            CIRFORM1.TextBox53.Text = cirObj.MonthlyInterestRate
            CIRFORM1.TextBox52.Text = cirObj.PaymentMode
            CIRFORM1.TextBox59.Text = cirObj.BusinessName
            CIRFORM1.TextBox60.Text = cirObj.BusinessContactNo
            CIRFORM1.TextBox58.Text = cirObj.BusinessHouseNo
            CIRFORM1.TextBox57.Text = cirObj.BusinessStreet
            CIRFORM1.TextBox56.Text = cirObj.BusinessBrgy
            CIRFORM1.TextBox55.Text = cirObj.BusinessMunicipality
            CIRFORM1.TextBox54.Text = cirObj.BusinessProvince
            CIRFORM1.TextBox62.Text = cirObj.BusinessType
            CIRFORM1.TextBox61.Text = cirObj.BusinessAge
            CIRFORM1.TextBox63.Text = cirObj.BeginningCapital
            CIRFORM1.TextBox64.Text = cirObj.BorrowerCompany
            CIRFORM1.TextBox65.Text = cirObj.BorrowerPosition
            CIRFORM1.TextBox66.Text = cirObj.BorrowerStatus
            CIRFORM1.TextBox67.Text = cirObj.BorrowerServiceLength
            CIRFORM1.TextBox68.Text = cirObj.BorrowerMonthlySalary
            CIRFORM1.TextBox73.Text = cirObj.SpouseCompany
            CIRFORM1.TextBox72.Text = cirObj.SpousePosition
            CIRFORM1.TextBox71.Text = cirObj.SpouseStatus
            CIRFORM1.TextBox70.Text = cirObj.SpouseServiceLength
            CIRFORM1.TextBox69.Text = cirObj.SpouseMonthlySalary
            For Each liability As Liability In cirObj.Liabilities
                Dim str(6) As String
                str(0) = liability.Bank
                str(1) = liability.CreditorName
                str(2) = liability.DateGranted
                str(3) = liability.DueDate
                str(4) = liability.LoanAmount
                str(5) = liability.Balance
                Dim item As ListViewItem = New ListViewItem(str)
                CIRFORM1.ListView1.Items.Add(item)
            Next
            CIRFORM1.TextBox35.Text = cirObj.ComakerLN
            CIRFORM1.TextBox34.Text = cirObj.ComakerFN
            CIRFORM1.TextBox33.Text = cirObj.ComakerMN
            CIRFORM1.TextBox32.Text = cirObj.ComakerSuffix
            CIRFORM1.TextBox31.Text = cirObj.ComakerRelation
            CIRFORM1.TextBox74.Text = cirObj.ComakerOccupation
            CIRFORM1.TextBox30.Text = cirObj.ComakerHouseNo
            CIRFORM1.TextBox29.Text = cirObj.ComakerStreet
            CIRFORM1.TextBox28.Text = cirObj.ComakerBrgy
            CIRFORM1.TextBox27.Text = cirObj.ComakerMunicipality
            CIRFORM1.TextBox26.Text = cirObj.ComakerProvince
            CIRFORM1.TextBox25.Text = cirObj.ComakerMonthlyIncome


            CIRFORM1.Show()
            CIRFORM1.BringToFront()
        ElseIf e.ColumnIndex = 7 Then
            MessageBox.Show("delete")
        End If
    End Sub
End Class