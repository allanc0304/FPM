Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Header

Public Class CIRFORM1

    Private Sub ListView1_Click(sender As Object, e As EventArgs) Handles ListView1.Click
        If ListView1.SelectedItems.Count > 0 Then
            LIA_BL.Text = ListView1.SelectedItems(0).SubItems(0).Text
            LIA_CRED.Text = ListView1.SelectedItems(0).SubItems(1).Text
            LIA_DG.Text = ListView1.SelectedItems(0).SubItems(2).Text
            LIA_DD.Text = ListView1.SelectedItems(0).SubItems(3).Text
            LIA_AL.Text = ListView1.SelectedItems(0).SubItems(4).Text
            LIA_BAL.Text = ListView1.SelectedItems(0).SubItems(5).Text
        End If
    End Sub

    Private Sub Label218_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CIR_NEXTBTN.Click
        If NOB_LN.Text = "" Or NOB_GN.Text = "" Or NOB_MN.Text = "" Or
            CIR_MON.Text = "" Or CIR_DAY.Text = "" Or CIR_YR.Text = "" Or
            CIR_AGE.Text = "" Or CIR_HOUSENO.Text = "" Or CIR_ST.Text = "" Or
            CIR_BRGY.Text = "" Or CIR_MUN.Text = "" Or CIR_PRO.Text = "" Or
            CIR_CONTACT.Text = "" Then
            MessageBox.Show("Please fill up the required fields! ", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf NOR_LN.Text = "" Or NOR_GN.Text = "" Or NOR_MN.Text = "" Or CIR_RELATION.Text = "" Or CIR_HOUSENO1.Text = "" Or CIR_ST1.Text = "" Or CIR_BRGY1.Text = "" Or CIR_MUN1.Text = "" Or CIR_PRO1.Text = "" Or CIR_CONTACT1.Text = "" Then
            MessageBox.Show("Please fill up the required fields! ", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf NOD_NS.Text = "" Or ELEM_PS.Text = "" Or HS_PS.Text = "" Or COLLEGE_PS.Text = "" Or ELEM_GS.Text = "" Or HS_GS.Text = "" Or COLLEGE_GS.Text = "" Or ELEM_TF.Text = "" Or HS_TF.Text = "" Or COLLEGE_TF.Text = "" Then
            MessageBox.Show("Please fill up the required fields! ", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf TOL_AAP.Text = "" Or TOL_PURP.Text = "" Or TOL_TERMS.Text = "" Or TOL_MR.Text = "" Or TOL_MOP.Text = "" Then
            MessageBox.Show("Please fill up the required fields! ", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf BR_NOB.Text = "" Or BR_CONT.Text = "" Or BR_HOUSENO.Text = "" Or BR_ST.Text = "" Or BR_BRGY.Text = "" Or BR_MUN.Text = "" Or BR_PRO.Text = "" Or BR_TOB.Text = "" Or BR_NYB.Text = "" Or BR_BC.Text = "" Then
            MessageBox.Show("Please fill up the required fields! ", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf ER_COMP.Text = "" Or ER_POS.Text = "" Or ER_STATUS.Text = "" Or ER_LOS.Text = "" Or ER_MS.Text = "" Or ER_COMP1.Text = "" Or ER_POS1.Text = "" Or ER_STATUS1.Text = "" Or ER_LOS1.Text = "" Or ER_MS1.Text = "" Then
            MessageBox.Show("Please fill up the required fields! ", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'ElseIf LIA_BL.Text = "" Or LIA_CRED.Text = "" Or LIA_DG.Text = "" Or LIA_DD.Text = "" Or LIA_AL.Text = "" Or LIA_BAL.Text = "" Then
            '    MessageBox.Show("Please fill up the required fields! ", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf N_LN.Text = "" Or N_GN.Text = "" Or N_MN.Text = "" Or CC_RELATION.Text = "" Or CC_OCCU.Text = "" Or CC_HOUSENO.Text = "" Or CC_ST.Text = "" Or CC_BRGY.Text = "" Or CC_MUN.Text = "" Or CC_PRO.Text = "" Or CC_MI.Text = "" Then
            MessageBox.Show("Please fill up the required fields! ", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf NF_NAIN1.Text = "" Or NF_NAIN2.Text = "" Or NF_ROR.Text = "" Or NF_ROR1.Text = "" Then
            MessageBox.Show("Please fill up the required fields! ", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'ElseIf C_KHP.Text = "" Or C_MN.Text = "" Or C_SN.Text = "" Or C_YP.Text = "" Or C_PV.Text = "" Then
            '    MessageBox.Show("Please fill up the required fields! ", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("FORM 1 COMPLETED PROCEEDING TO FORM 2 . . .", "FORM 1 DONE!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CIRFORM2.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles CIR_BACKBTN.Click
        LoanProcessing.Show()
        Me.Hide()
    End Sub

    Private Sub CIRFORM1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles LIA_ADDBTN.Click
        Dim newitem As New ListViewItem(LIA_BL.Text)
        newitem.SubItems.Add(LIA_CRED.Text)
        newitem.SubItems.Add(LIA_DG.Text)
        newitem.SubItems.Add(LIA_DD.Text)
        newitem.SubItems.Add(LIA_AL.Text)
        newitem.SubItems.Add(LIA_BAL.Text)

        ListView1.Items.Add(newitem)

        LIA_BL.Text = ""
        LIA_CRED.Text = ""
        LIA_DG.Text = ""
        LIA_DD.Text = ""
        LIA_AL.Text = ""
        LIA_BAL.Text = ""
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles LIA_UPBTN.Click
        If ListView1.SelectedItems.Count > 0 Then
            ListView1.SelectedItems(0).SubItems(0).Text = LIA_BL.Text
            ListView1.SelectedItems(0).SubItems(1).Text = LIA_CRED.Text
            ListView1.SelectedItems(0).SubItems(2).Text = LIA_DG.Text
            ListView1.SelectedItems(0).SubItems(3).Text = LIA_DD.Text
            ListView1.SelectedItems(0).SubItems(4).Text = LIA_AL.Text
            ListView1.SelectedItems(0).SubItems(5).Text = LIA_BAL.Text

            LIA_BL.Text = ""
            LIA_CRED.Text = ""
            LIA_DG.Text = ""
            LIA_DD.Text = ""
            LIA_AL.Text = ""
            LIA_BAL.Text = ""
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles LIA_REMBTN.Click
        If ListView1.SelectedItems.Count > 0 Then
            ListView1.Items.Remove(ListView1.SelectedItems(0))

            LIA_BL.Text = ""
            LIA_CRED.Text = ""
            LIA_DG.Text = ""
            LIA_DD.Text = ""
            LIA_AL.Text = ""
            LIA_BAL.Text = ""
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles LIA_REMALLBTN.Click
        ListView1.Items.Clear()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles COL_ADDBTN.Click
        Dim newitem As New ListViewItem(C_KHP.Text)
        newitem.SubItems.Add(C_MN.Text)
        newitem.SubItems.Add(C_SN.Text)
        newitem.SubItems.Add(C_YP.Text)
        newitem.SubItems.Add(C_PV.Text)
        ListView2.Items.Add(newitem)

        C_KHP.Text = ""
        C_MN.Text = ""
        C_SN.Text = ""
        C_YP.Text = ""
        C_PV.Text = ""
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles COL_UPBUTTON.Click
        If ListView2.SelectedItems.Count > 0 Then
            ListView2.SelectedItems(0).SubItems(0).Text = C_KHP.Text
            ListView2.SelectedItems(0).SubItems(1).Text = C_MN.Text
            ListView2.SelectedItems(0).SubItems(2).Text = C_SN.Text
            ListView2.SelectedItems(0).SubItems(3).Text = C_YP.Text
            ListView2.SelectedItems(0).SubItems(4).Text = C_PV.Text

            C_KHP.Text = ""
            C_MN.Text = ""
            C_SN.Text = ""
            C_YP.Text = ""
            C_PV.Text = ""
        End If
    End Sub

    Private Sub ListView2_Click(sender As Object, e As EventArgs) Handles ListView2.Click
        If ListView2.SelectedItems.Count > 0 Then
            C_KHP.Text = ListView2.SelectedItems(0).SubItems(0).Text
            C_MN.Text = ListView2.SelectedItems(0).SubItems(1).Text
            C_SN.Text = ListView2.SelectedItems(0).SubItems(2).Text
            C_YP.Text = ListView2.SelectedItems(0).SubItems(3).Text
            C_PV.Text = ListView2.SelectedItems(0).SubItems(4).Text
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles COL_REMBTN.Click
        If ListView2.SelectedItems.Count > 0 Then
            ListView2.Items.Remove(ListView2.SelectedItems(0))

            C_KHP.Text = ""
            C_MN.Text = ""
            C_SN.Text = ""
            C_YP.Text = ""
            C_PV.Text = ""
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles COL_REMALLBTN.Click
        ListView2.Items.Clear()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub NOB_LN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NOB_LN.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")
        End If
    End Sub

    Private Sub NOB_GN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NOB_GN.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")
        End If
    End Sub

    Private Sub NOB_MN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NOB_MN.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")
        End If
    End Sub

    Private Sub NOB_SUFF_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NOB_SUFF.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")
        End If
    End Sub

    Private Sub CIR_MON_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CIR_MON.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")
        End If
    End Sub

    Private Sub CIR_DAY_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CIR_DAY.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only")
        End If
    End Sub

    Private Sub CIR_AGE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CIR_AGE.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only")
        End If
    End Sub

    Private Sub CIR_YR_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CIR_YR.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only")
        End If
    End Sub

    Private Sub CIR_ST_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CIR_ST.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")
        End If
    End Sub

    Private Sub CIR_BRGY_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CIR_BRGY.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")
        End If
    End Sub

    Private Sub CIR_MUN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CIR_MUN.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")
        End If
    End Sub

    Private Sub CIR_PRO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CIR_PRO.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")
        End If
    End Sub

    Private Sub CIR_CONTACT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CIR_CONTACT.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only")
        End If
    End Sub

    Private Sub NOR_LN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NOR_LN.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")
        End If
    End Sub

    Private Sub NOR_GN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NOR_GN.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")
        End If
    End Sub

    Private Sub NOR_MN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NOR_MN.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")
        End If
    End Sub

    Private Sub NOR_SUFF_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NOR_SUFF.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")
        End If
    End Sub

    Private Sub CIR_RELATION_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CIR_RELATION.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")
        End If
    End Sub

    Private Sub CIR_ST1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CIR_ST1.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")
        End If
    End Sub

    Private Sub CIR_BRGY1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CIR_BRGY1.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")
        End If
    End Sub

    Private Sub CIR_MUN1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CIR_MUN1.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")
        End If
    End Sub

    Private Sub CIR_PRO1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CIR_PRO1.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")
        End If
    End Sub

    Private Sub CIR_CONTACT1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CIR_CONTACT1.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only")
        End If
    End Sub

    Private Sub ELEM_PS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ELEM_PS.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only")
        End If
    End Sub

    Private Sub HS_PS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles HS_PS.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only")
        End If
    End Sub

    Private Sub COLLEGE_PS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles COLLEGE_PS.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only")
        End If
    End Sub

    Private Sub ELEM_GS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ELEM_GS.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only")
        End If
    End Sub

    Private Sub HS_GS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles HS_GS.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only")
        End If
    End Sub

    Private Sub COLLEGE_GS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles COLLEGE_GS.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only")
        End If
    End Sub

    Private Sub ELEM_TF_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ELEM_TF.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only")
        End If
    End Sub

    Private Sub HS_TF_KeyPress(sender As Object, e As KeyPressEventArgs) Handles HS_TF.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only")
        End If
    End Sub

    Private Sub COLLEGE_TF_KeyPress(sender As Object, e As KeyPressEventArgs) Handles COLLEGE_TF.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only")
        End If
    End Sub

    Private Sub TOL_AAP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TOL_AAP.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only")
        End If
    End Sub

    Private Sub TOL_PURP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TOL_PURP.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")
        End If
    End Sub

    Private Sub TOL_TERMS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TOL_TERMS.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")
        End If
    End Sub

    Private Sub TOL_MR_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TOL_MR.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only")
        End If
    End Sub

    Private Sub TOL_MOP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TOL_MOP.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")
        End If
    End Sub

    Private Sub BR_NOBKeyPress(sender As Object, e As KeyPressEventArgs) Handles BR_NOB.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")
        End If
    End Sub

    Private Sub BR_CONT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BR_CONT.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only")
        End If
    End Sub

    Private Sub BR_ST_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BR_ST.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")
        End If
    End Sub

    Private Sub BR_BRGY_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BR_BRGY.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")
        End If
    End Sub

    Private Sub BR_MUN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BR_MUN.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")
        End If
    End Sub

    Private Sub BR_PRO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BR_PRO.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")
        End If
    End Sub

    Private Sub BR_TOB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BR_TOB.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")
        End If
    End Sub

    Private Sub BR_BC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BR_BC.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only")
        End If
    End Sub

    Private Sub ER_COMP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ER_COMP.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")
        End If
    End Sub

    Private Sub ER_POS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ER_POS.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")
        End If
    End Sub

    Private Sub ER_STATUS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ER_STATUS.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")
        End If
    End Sub

    Private Sub ER_MS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ER_MS.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only")
        End If
    End Sub

    Private Sub ER_COMP1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ER_COMP1.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")
        End If
    End Sub

    Private Sub ER_POS1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ER_POS1.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")
        End If
    End Sub

    Private Sub ER_STATUS1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ER_STATUS1.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")
        End If
    End Sub

    Private Sub ER_LOS1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ER_LOS1.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")
        End If
    End Sub

    Private Sub ER_MS1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ER_MS1.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only")
        End If
    End Sub

    Private Sub LIA_BL_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LIA_BL.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")
        End If
    End Sub

    Private Sub LIA_CRED_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LIA_CRED.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")
        End If
    End Sub

    Private Sub LIA_AL_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LIA_AL.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only")
        End If
    End Sub

    Private Sub LIA_BAL_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LIA_BAL.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only")
        End If
    End Sub

    Private Sub N_LN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles N_LN.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")
        End If
    End Sub

    Private Sub N_GN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles N_GN.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")
        End If
    End Sub

    Private Sub N_MN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles N_MN.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")
        End If
    End Sub

    Private Sub N_SUFF_KeyPress(sender As Object, e As KeyPressEventArgs) Handles N_SUFF.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")
        End If
    End Sub

    Private Sub CC_RELATION_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CC_RELATION.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")
        End If
    End Sub

    Private Sub CC_OCCU_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CC_OCCU.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")
        End If
    End Sub

    Private Sub CC_ST_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CC_ST.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")
        End If
    End Sub

    Private Sub CC_BRGY_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CC_BRGY.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")
        End If
    End Sub

    Private Sub CC_MUN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CC_MUN.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")
        End If
    End Sub

    Private Sub CC_PRO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CC_PRO.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")
        End If
    End Sub

    Private Sub CC_MI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CC_MI.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only")
        End If
    End Sub

    Private Sub C_KHP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles C_KHP.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only")
        End If
    End Sub

    Private Sub C_MN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles C_MN.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only")
        End If
    End Sub

    Private Sub C_SN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles C_SN.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only")
        End If
    End Sub

    Private Sub C_YP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles C_YP.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only")
        End If
    End Sub

    Private Sub C_PV_KeyPress(sender As Object, e As KeyPressEventArgs) Handles C_PV.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only")
        End If
    End Sub

    Private Sub CIR_CONTACT_Validated(sender As Object, e As EventArgs) Handles CIR_CONTACT.Validated
        Dim phone As New Regex("09\d{9}$")
        'phone number like 092-3470-9218
        If (phone.IsMatch(CIR_CONTACT.Text)) Then
            MsgBox("Phone Number is Valid")
        Else
            MsgBox("Contact Number is should start with 09 or exceeded or less than to 11 digits")
        End If
    End Sub

    Private Sub CIR_CONTACT1_Validated(sender As Object, e As EventArgs) Handles CIR_CONTACT1.Validated
        Dim phone As New Regex("09\d{9}$")
        'phone number like 092-3470-9218
        If (phone.IsMatch(CIR_CONTACT1.Text)) Then
            MsgBox("Phone Number is Valid")
        Else
            MsgBox("Contact Number is should start with 09 or exceeded or less than to 11 digits")
        End If
    End Sub

    Private Sub BR_CONT_Validated(sender As Object, e As EventArgs) Handles BR_CONT.Validated
        Dim phone As New Regex("09\d{9}$")
        'phone number like 092-3470-9218
        If (phone.IsMatch(BR_CONT.Text)) Then
            MsgBox("Phone Number is Valid")
        Else
            MsgBox("Contact Number is should start with 09 or exceeded or less than to 11 digits")
        End If
    End Sub
End Class