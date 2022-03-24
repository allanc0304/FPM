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
            CIRFORM1.NOB_LN.Text = cirObj.BorrowerLN
            CIRFORM1.NOB_GN.Text = cirObj.BorrowerFN
            CIRFORM1.NOB_MN.Text = cirObj.BorrowerMN
            CIRFORM1.NOB_SUFF.Text = cirObj.BorrowerSuffix
            CIRFORM1.CIR_MON.Items.Add(cirObj.BirthDate.Month)
            CIRFORM1.CIR_DAY.Items.Add(cirObj.BirthDate.Day)
            CIRFORM1.CIR_YR.Items.Add(cirObj.BirthDate.Year)
            CIRFORM1.CIR_MON.SelectedIndex = 0
            CIRFORM1.CIR_DAY.SelectedIndex = 0
            CIRFORM1.CIR_YR.SelectedIndex = 0
            CIRFORM1.CIR_AGE.Items.Add(cirObj.Age)
            CIRFORM1.CIR_AGE.SelectedIndex = 0
            CIRFORM1.CIR_HOUSENO.Text = cirObj.HouseNo
            CIRFORM1.CIR_ST.Text = cirObj.Street
            CIRFORM1.CIR_BRGY.Text = cirObj.Brgy
            CIRFORM1.CIR_MUN.Text = cirObj.Municipality
            CIRFORM1.CIR_PRO.Text = cirObj.Province
            CIRFORM1.CIR_CONTACT.Text = cirObj.ContactNo
            CIRFORM1.NOR_LN.Text = cirObj.RelativeLN
            CIRFORM1.NOR_GN.Text = cirObj.RelativeFN
            CIRFORM1.NOR_MN.Text = cirObj.RelativeMN
            CIRFORM1.NOR_SUFF.Text = cirObj.RelativeSuffix
            CIRFORM1.CIR_RELATION.Text = cirObj.Relation
            CIRFORM1.CIR_HOUSENO1.Text = cirObj.RelativeHouseNo
            CIRFORM1.CIR_ST1.Text = cirObj.RelativeStreet
            CIRFORM1.CIR_BRGY1.Text = cirObj.RelativeBrgy
            CIRFORM1.CIR_MUN1.Text = cirObj.RelativeMunicipality
            CIRFORM1.CIR_PRO1.Text = cirObj.RelativeProvince
            CIRFORM1.CIR_CONTACT1.Text = cirObj.RelativeContactNo
            CIRFORM1.NOD_NS.Items.Add(cirObj.NonSchoolingDependents)
            CIRFORM1.NOD_NS.SelectedIndex = 0
            CIRFORM1.ELEM_PS.Text = cirObj.PrivateElementary
            CIRFORM1.HS_PS.Text = cirObj.PrivateHighSchool
            CIRFORM1.COLLEGE_PS.Text = cirObj.PrivateCollege
            CIRFORM1.ELEM_GS.Text = cirObj.Elementary
            CIRFORM1.HS_GS.Text = cirObj.HighSchool
            CIRFORM1.COLLEGE_GS.Text = cirObj.College
            CIRFORM1.ELEM_TF.Text = cirObj.ElementaryTuition
            CIRFORM1.HS_TF.Text = cirObj.HighSchoolTuition
            CIRFORM1.COLLEGE_TF.Text = cirObj.CollegeTuition
            If cirObj.LoanType = "new" Then
                CIRFORM1.CB_NEW.Checked = True
            ElseIf cirObj.LoanType = "renewal" Then
                CIRFORM1.CB_RENEW.Checked = True
            Else
                CIRFORM1.CB_RESTUCT.Checked = True
            End If
            CIRFORM1.TOL_AAP.Text = cirObj.AppliedAmount
            CIRFORM1.TOL_PURP.Text = cirObj.Purpose
            CIRFORM1.TOL_TERMS.Text = cirObj.Terms
            CIRFORM1.TOL_MR.Text = cirObj.MonthlyInterestRate
            CIRFORM1.TOL_MOP.Text = cirObj.PaymentMode
            CIRFORM1.BR_NOB.Text = cirObj.BusinessName
            CIRFORM1.BR_CONT.Text = cirObj.BusinessContactNo
            CIRFORM1.BR_HOUSENO.Text = cirObj.BusinessHouseNo
            CIRFORM1.BR_ST.Text = cirObj.BusinessStreet
            CIRFORM1.BR_BRGY.Text = cirObj.BusinessBrgy
            CIRFORM1.BR_MUN.Text = cirObj.BusinessMunicipality
            CIRFORM1.BR_PRO.Text = cirObj.BusinessProvince
            CIRFORM1.BR_TOB.Text = cirObj.BusinessType
            CIRFORM1.BR_NYB.Text = cirObj.BusinessAge
            CIRFORM1.BR_BC.Text = cirObj.BeginningCapital
            CIRFORM1.ER_COMP.Text = cirObj.BorrowerCompany
            CIRFORM1.ER_POS.Text = cirObj.BorrowerPosition
            CIRFORM1.ER_STATUS.Text = cirObj.BorrowerStatus
            CIRFORM1.ER_LOS.Text = cirObj.BorrowerServiceLength
            CIRFORM1.ER_MS.Text = cirObj.BorrowerMonthlySalary
            CIRFORM1.ER_COMP1.Text = cirObj.SpouseCompany
            CIRFORM1.ER_POS1.Text = cirObj.SpousePosition
            CIRFORM1.ER_STATUS1.Text = cirObj.SpouseStatus
            CIRFORM1.ER_LOS1.Text = cirObj.SpouseServiceLength
            CIRFORM1.ER_MS1.Text = cirObj.SpouseMonthlySalary
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
            CIRFORM1.N_LN.Text = cirObj.ComakerLN
            CIRFORM1.N_GN.Text = cirObj.ComakerFN
            CIRFORM1.N_MN.Text = cirObj.ComakerMN
            CIRFORM1.N_SUFF.Text = cirObj.ComakerSuffix
            CIRFORM1.CC_RELATION.Text = cirObj.ComakerRelation
            CIRFORM1.CC_OCCU.Text = cirObj.ComakerOccupation
            CIRFORM1.CC_HOUSENO.Text = cirObj.ComakerHouseNo
            CIRFORM1.CC_ST.Text = cirObj.ComakerStreet
            CIRFORM1.CC_BRGY.Text = cirObj.ComakerBrgy
            CIRFORM1.CC_MUN.Text = cirObj.ComakerMunicipality
            CIRFORM1.CC_PRO.Text = cirObj.ComakerProvince
            CIRFORM1.CC_MI.Text = cirObj.ComakerMonthlyIncome
            If cirObj.Neighbors.Count = 1 Then
                CIRFORM1.NF_NAIN1.Text = cirObj.Neighbors(0).FirstName
            ElseIf cirObj.Neighbors.Count = 2 Then
                CIRFORM1.NF_NAIN1.Text = cirObj.Neighbors(0).FirstName
                CIRFORM1.NF_NAIN2.Text = cirObj.Neighbors(1).FirstName
            End If
            If cirObj.HouseAddressRented = True Then
                CIRFORM1.NF_RENT_HOME.Checked = True
                CIRFORM1.NF_ROR.Text = cirObj.HAOwnerRemarks
            Else
                CIRFORM1.NF_OWN_HOME.Checked = True
            End If
            If cirObj.BusinessAddressRented = True Then
                CIRFORM1.NF_RENT_BUSINESS.Checked = True
                CIRFORM1.NF_ROR1.Text = cirObj.BAOwnerRemarks
            Else
                CIRFORM1.NF_OWN_BUSNESS.Checked = True
            End If
            For Each collateral As Collateral In cirObj.Collaterals
                Dim str(5) As String
                str(0) = collateral.Description
                str(1) = collateral.Model
                str(2) = collateral.SerialNo
                str(3) = collateral.PurchaseYear
                str(4) = collateral.Price
                Dim item As ListViewItem = New ListViewItem(str)
                CIRFORM1.ListView2.Items.Add(item)
            Next
            If cirObj.HouseLotType = "commercial" Then
                CIRFORM1.CB_COM.Checked = True
            ElseIf cirObj.HouseLotType = "industrial" Then
                CIRFORM1.CB_INDU.Checked = True
            ElseIf cirObj.HouseLotType = "residential" Then
                CIRFORM1.CB_RESI.Checked = True
            ElseIf cirObj.HouseLotType = "agricultural" Then
                CIRFORM1.CB_AGRI.Checked = True
            End If
            CIRFORM2.txtBLname.Text = cirObj.BorrowerLN
            CIRFORM2.txtBFname.Text = cirObj.BorrowerFN
            CIRFORM2.txtBMname.Text = cirObj.BorrowerMN
            CIRFORM2.txtBSuffix.Text = cirObj.BorrowerSuffix
            CIRFORM2.txtAppGSale.Text = cirObj.BorrowerGrossSale
            CIRFORM2.txtAppCSale.Text = cirObj.BorrowerSalesCost
            CIRFORM2.txtAppNProfit.Text = cirObj.BorrowerNetProfit
            CIRFORM2.txtAppSalary.Text = cirObj.BorrowerSalary
            CIRFORM2.txtSpoGSale.Text = cirObj.SpouseGrossSale
            CIRFORM2.txtSpoCSale.Text = cirObj.SpouseSalesCost
            CIRFORM2.txtSpoNProfit.Text = cirObj.SpouseNetProfit
            CIRFORM2.txtSpoSalary.Text = cirObj.SpouseSalary
            CIRFORM2.txtGIncome.Text = cirObj.TotalGrossMonthlyIncome
            CIRFORM2.txtFood.Text = cirObj.Food
            CIRFORM2.txtAllowance.Text = cirObj.Education
            CIRFORM2.txtRental.Text = cirObj.Rental
            CIRFORM2.txtTranspo.Text = cirObj.Transportation
            CIRFORM2.txtEBill.Text = cirObj.ElectricityBill
            CIRFORM2.txtWBill.Text = cirObj.WaterBill
            CIRFORM2.txtHSalary.Text = cirObj.HelperSalary
            CIRFORM2.txtPersoOther.Text = cirObj.OtherExpenses
            CIRFORM2.txtExpenses.Text = cirObj.TotalMonthlyExpenses
            CIRFORM2.txtNIncome.Text = cirObj.NetMonthlyIncome
            CIRFORM2.txtPLoan.Text = cirObj.PreviousLoan
            CIRFORM2.txtBalance.Text = cirObj.Balance
            CIRFORM2.txtDelinquent.Text = cirObj.DaysDelinquent
            CIRFORM2.txtAccRemarks.Text = cirObj.AccountingStaffName 'wala akong nailagay na remarks sa db kaya ginamit ko na lang to kasi wala naman name sa form signature lang
            CIRFORM2.txtAccSignature.Text = cirObj.AccountingStaffSignature
            CIRFORM2.calDGranted.Value = cirObj.DateGranted
            CIRFORM2.calMDate.Value = cirObj.MaturityDate
            CIRFORM2.calLPayment.Value = cirObj.LastPaymentDate
            CIRFORM2.chbBusiness.Checked = cirObj.RBFBusinessType
            CIRFORM2.chbCharacter.Checked = cirObj.RBFCharacter
            CIRFORM2.chbCollateral.Checked = cirObj.RBFCollateral
            CIRFORM2.chbIncome.Checked = cirObj.RBFIncome
            CIRFORM2.txtPAmount.Text = cirObj.PrincipalAmount
            CIRFORM2.txtRecRemarks.Text = cirObj.Remark
            CIRFORM2.calLPayment.Text = cirObj.LastPaymentDate
            CIRFORM2.txtSubmittedBy.Text = cirObj.CreditInvestigatorName
            CIRFORM2.txtApprovedBy.Text = cirObj.ApprovedByName
            CIRFORM2.calDApproved.Value = cirObj.DateApproved
            CIRFORM2.calDSubmitted.Value = cirObj.DateSubmitted
            CIRFORM2.txtAmountApproved.Text = cirObj.AmountApproved

            CIRFORM1.Show()
            CIRFORM1.BringToFront()
        ElseIf e.ColumnIndex = 7 Then
            MessageBox.Show("delete")
        End If
    End Sub
End Class