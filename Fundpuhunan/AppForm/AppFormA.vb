Imports System.ComponentModel
Imports System.Text.RegularExpressions
Public Class AppFormA
    Public Shared view As Boolean = False
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        BorrowersList.Button3.Enabled = True
        With Savings

            .TopLevel = False
            .AutoSize = True

            Navigation.Navigationpanel.Controls.Add(Savings)
            .BringToFront()
            .Show()

        End With
        Me.Close()
    End Sub
    Private Sub P1_LASTNAME_KeyPress(sender As Object, e As KeyPressEventArgs) Handles P1_LASTNAME.KeyPress
        If Not Char.IsLetterOrDigit(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This is field will accept Letters and number only")


        End If

    End Sub

    Private Sub P1_GIVENNAME_KeyPress(sender As Object, e As KeyPressEventArgs) Handles P1_GIVENNAME.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This is field will accept Letters only")
        End If
    End Sub

    Private Sub P1_MIDDLENAME_KeyPress(sender As Object, e As KeyPressEventArgs) Handles P1_MIDDLENAME.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This is field will accept Letters only")
        End If
    End Sub

    Private Sub P1_SUFFIX_KeyPress(sender As Object, e As KeyPressEventArgs) Handles P1_SUFFIX.KeyPress
        If Not Char.IsLetterOrDigit(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This is field will accept Letters only")
        End If
    End Sub

    Private Sub T1_HOUSENO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles T1_HOUSENO.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This is field will accept Numbers only")
        End If
    End Sub

    Private Sub T1_BARANGAY_KeyPress(sender As Object, e As KeyPressEventArgs) Handles T1_BARANGAY.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This is field will accept Letters only")
        End If
    End Sub

    Private Sub T1_MUNICIPALITY_KeyPress(sender As Object, e As KeyPressEventArgs) Handles T1_MUNICIPALITY.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This is field will accept Letters only")
        End If
    End Sub

    Private Sub T1_PROVINCE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles T1_PROVINCE.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This is field will accept Letters only")
        End If
    End Sub

    Private Sub K1_DAY_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This is field will accept Numbers only")
        End If

    End Sub

    Private Sub K1_MONTH_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This is field will accept Letters only")
        End If
    End Sub

    Private Sub K1_YEAR_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This is field will accept Numbers only")
        End If


    End Sub

    Private Sub E1_AGE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles E1_AGE.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This is field will accept Numbers only")
        End If
        If E1_AGE.Text.Length >= 2 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MessageBox.Show("Error")
            End If
        End If
    End Sub



    Private Sub R1_RELIGION_KeyPress(sender As Object, e As KeyPressEventArgs) Handles R1_RELIGION.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This is field will accept Letters only")
        End If
    End Sub

    Private Sub P2_LASTNAME_KeyPress(sender As Object, e As KeyPressEventArgs) Handles T2_PROVINCE.KeyPress, T2_MUNICIPALITY.KeyPress, T2_BARANGAY.KeyPress, R2_RELIGION.KeyPress, P2_SUFFIX.KeyPress, P2_MIDDLENAME.KeyPress, P2_LASTNAME.KeyPress, P2_GIVENNAME.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This is field will accept Letters only")
        End If
    End Sub

    Private Sub T2_HOUSENO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles T2_HOUSENO.KeyPress, E2_AGE.KeyPress, B2_ANAK.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This is field will accept Numbers only")
        End If
    End Sub

    Private Sub ApplictaionForm1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress, M3_CLEANSALARY.KeyPress, L3_WEEKLYINCOME.KeyPress, L3_SALARY.KeyPress, L3_EXPENSES.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This is field will accept Numbers only")
        End If
    End Sub

    Private Sub P3_BUSINESS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles P3_BUSINESS.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This is field will accept Letters only")
        End If
    End Sub

    Private Sub P4_LASTNAME_KeyPress(sender As Object, e As KeyPressEventArgs) Handles T4_TYPEOFBUSINESS.KeyPress, T4_PROVINCE.KeyPress, T4_MUNICIPALITY.KeyPress, T4_BARANGAY.KeyPress, P4_SUFFIX.KeyPress, P4_MIDDLENAME.KeyPress, P4_LASTNAME.KeyPress, P4_GIVENNAME.KeyPress, B4_BUSINESS.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This is field will accept Letters only")
        End If
    End Sub

    Private Sub T4_HOUSENO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles T4_HOUSENO.KeyPress, E4_AGE.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This is field will accept Numbers only")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Vld(P1_LASTNAME, P1_MIDDLENAME, P1_GIVENNAME, C1_CONTACT, T1_HOUSENO, T1_STREET, T1_BARANGAY, T1_MUNICIPALITY, T1_PROVINCE, E1_AGE, R1_RELIGION) = False Then
            MessageBox.Show("Fill up all fields")


            ' ElseIf Vld(P2_LASTNAME, P2_GIVENNAME, P2_MIDDLENAME, T2_HOUSENO, T2_STREET, T2_BARANGAY, T2_PROVINCE, T2_MUNICIPALITY, E2_AGE, R2_RELIGION, B2_ANAK) = False Then
            '  MessageBox.Show("Fill up all fields")

        ElseIf Vld(P3_BUSINESS, L3_SALARY, L3_EXPENSES, L3_WEEKLYINCOME, M3_CLEANSALARY) = False Then
            MessageBox.Show("Fill up all fields")


        ElseIf Vld(P4_LASTNAME, P4_GIVENNAME, P4_MIDDLENAME, T4_HOUSENO, T4_STREET, T4_BARANGAY, T4_PROVINCE, T4_MUNICIPALITY, E4_AGE, T4_TYPEOFBUSINESS, B4_BUSINESS) = False Then
            MessageBox.Show("Fill up all fields")


            Exit Sub
        Else

            MsgBox("Proceed to next form")
            AppFormB.Show()
            Me.Hide()




        End If


    End Sub

    Private Sub ApplictaionForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button2.Visible = False

        Timer1.Enabled = True
        If view = True Then
            For Each control As Control In Me.Controls
                If (Not TypeOf (control) Is Label) Then
                    control.Enabled = False
                End If
            Next
            Button1.Visible = False
            Button1.Enabled = True
            Button2.Visible = True
            Button3.Enabled = True
            Button2.Enabled = True
            Label31.Text = "VIEW ONLY"
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





    Private Sub C1_CONTACT_Validated(sender As Object, e As EventArgs) Handles C1_CONTACT.Validated
        Dim phone As New Regex("09\d{9}$")
        'phone number like 092-3470-9218
        If (Not phone.IsMatch(C1_CONTACT.Text)) Then
            MsgBox("Phone Number is Invalid")
            C1_CONTACT.Text = ""
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            'Button2.Text = OpenFileDialog1.FileName
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label49.Text = Date.Now.ToString("dd MMM yyyy       hh:mm:ss tt")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AppFormB.Show()

        Me.Hide()
    End Sub

    Private Sub Label88_Click(sender As Object, e As EventArgs) Handles Label88.Click

    End Sub

    Private Sub Label87_Click(sender As Object, e As EventArgs) Handles Label87.Click

    End Sub

    Private Sub Label83_Click(sender As Object, e As EventArgs) Handles Label83.Click

    End Sub

    Private Sub Label82_Click(sender As Object, e As EventArgs) Handles Label82.Click

    End Sub

    Private Sub Label81_Click(sender As Object, e As EventArgs) Handles Label81.Click

    End Sub

    Private Sub Label80_Click(sender As Object, e As EventArgs) Handles Label80.Click

    End Sub

    Private Sub Label79_Click(sender As Object, e As EventArgs) Handles Label79.Click

    End Sub

    Private Sub Label78_Click(sender As Object, e As EventArgs) Handles Label78.Click

    End Sub

    Private Sub Label77_Click(sender As Object, e As EventArgs) Handles Label77.Click

    End Sub

    Private Sub Label76_Click(sender As Object, e As EventArgs) Handles Label76.Click

    End Sub

    Private Sub Label75_Click(sender As Object, e As EventArgs) Handles Label75.Click

    End Sub

    Private Sub Label74_Click(sender As Object, e As EventArgs) Handles Label74.Click

    End Sub

    Private Sub Label73_Click(sender As Object, e As EventArgs) Handles Label73.Click

    End Sub

    Private Sub Label72_Click(sender As Object, e As EventArgs) Handles Label72.Click

    End Sub

    Private Sub Label71_Click(sender As Object, e As EventArgs) Handles Label71.Click

    End Sub

    Private Sub Label68_Click(sender As Object, e As EventArgs) Handles Label68.Click

    End Sub

    Private Sub Label70_Click(sender As Object, e As EventArgs) Handles Label70.Click

    End Sub

    Private Sub Label69_Click(sender As Object, e As EventArgs) Handles Label69.Click

    End Sub

    Private Sub Label67_Click(sender As Object, e As EventArgs) Handles Label67.Click

    End Sub

    Private Sub Label63_Click(sender As Object, e As EventArgs) Handles Label63.Click

    End Sub

    Private Sub Label62_Click(sender As Object, e As EventArgs) Handles Label62.Click

    End Sub

    Private Sub Label61_Click(sender As Object, e As EventArgs) Handles Label61.Click

    End Sub

    Private Sub Label60_Click(sender As Object, e As EventArgs) Handles Label60.Click

    End Sub

    Private Sub Label59_Click(sender As Object, e As EventArgs) Handles Label59.Click

    End Sub

    Private Sub Label58_Click(sender As Object, e As EventArgs) Handles Label58.Click

    End Sub

    Private Sub Label57_Click(sender As Object, e As EventArgs) Handles Label57.Click

    End Sub

    Private Sub Label56_Click(sender As Object, e As EventArgs) Handles Label56.Click

    End Sub

    Private Sub Label55_Click(sender As Object, e As EventArgs) Handles Label55.Click

    End Sub

    Private Sub Label54_Click(sender As Object, e As EventArgs) Handles Label54.Click

    End Sub

    Private Sub Label53_Click(sender As Object, e As EventArgs) Handles Label53.Click

    End Sub

    Private Sub Label52_Click(sender As Object, e As EventArgs) Handles Label52.Click

    End Sub

    Private Sub Label47_Click(sender As Object, e As EventArgs) Handles Label47.Click

    End Sub

    Private Sub Label46_Click(sender As Object, e As EventArgs) Handles Label46.Click

    End Sub

    Private Sub Label45_Click(sender As Object, e As EventArgs) Handles Label45.Click

    End Sub

    Private Sub Label44_Click(sender As Object, e As EventArgs) Handles Label44.Click

    End Sub

    Private Sub Label43_Click(sender As Object, e As EventArgs) Handles Label43.Click

    End Sub

    Private Sub Label42_Click(sender As Object, e As EventArgs) Handles Label42.Click

    End Sub

    Private Sub Label41_Click(sender As Object, e As EventArgs) Handles Label41.Click

    End Sub

    Private Sub Label39_Click(sender As Object, e As EventArgs) Handles Label39.Click

    End Sub

    Private Sub Label48_Click(sender As Object, e As EventArgs) Handles Label48.Click

    End Sub

    Private Sub Label38_Click(sender As Object, e As EventArgs) Handles Label38.Click

    End Sub

    Private Sub Label37_Click(sender As Object, e As EventArgs) Handles Label37.Click

    End Sub

    Private Sub Label36_Click(sender As Object, e As EventArgs) Handles Label36.Click

    End Sub

    Private Sub Label35_Click(sender As Object, e As EventArgs) Handles Label35.Click

    End Sub

    Private Sub Label34_Click(sender As Object, e As EventArgs) Handles Label34.Click

    End Sub

    Private Sub Label33_Click(sender As Object, e As EventArgs) Handles Label33.Click

    End Sub

    Private Sub Label32_Click(sender As Object, e As EventArgs) Handles Label32.Click

    End Sub

    Private Sub Label40_Click(sender As Object, e As EventArgs) Handles Label40.Click

    End Sub

    Private Sub P4_SUFFIX_TextChanged(sender As Object, e As EventArgs) Handles P4_SUFFIX.TextChanged

    End Sub

    Private Sub P2_SUFFIX_TextChanged(sender As Object, e As EventArgs) Handles P2_SUFFIX.TextChanged

    End Sub

    Private Sub P1_SUFFIX_TextChanged(sender As Object, e As EventArgs) Handles P1_SUFFIX.TextChanged

    End Sub

    Private Sub P4_GIVENNAME_TextChanged(sender As Object, e As EventArgs) Handles P4_GIVENNAME.TextChanged

    End Sub

    Private Sub P2_GIVENNAME_TextChanged(sender As Object, e As EventArgs) Handles P2_GIVENNAME.TextChanged

    End Sub

    Private Sub P1_GIVENNAME_TextChanged(sender As Object, e As EventArgs) Handles P1_GIVENNAME.TextChanged

    End Sub

    Private Sub T4_TYPEOFBUSINESS_TextChanged(sender As Object, e As EventArgs) Handles T4_TYPEOFBUSINESS.TextChanged

    End Sub

    Private Sub B4_BUSINESS_TextChanged(sender As Object, e As EventArgs) Handles B4_BUSINESS.TextChanged

    End Sub

    Private Sub E4_AGE_TextChanged(sender As Object, e As EventArgs) Handles E4_AGE.TextChanged

    End Sub

    Private Sub T4_PROVINCE_TextChanged(sender As Object, e As EventArgs) Handles T4_PROVINCE.TextChanged

    End Sub

    Private Sub T4_MUNICIPALITY_TextChanged(sender As Object, e As EventArgs) Handles T4_MUNICIPALITY.TextChanged

    End Sub

    Private Sub T4_BARANGAY_TextChanged(sender As Object, e As EventArgs) Handles T4_BARANGAY.TextChanged

    End Sub

    Private Sub T4_STREET_TextChanged(sender As Object, e As EventArgs) Handles T4_STREET.TextChanged

    End Sub

    Private Sub T4_HOUSENO_TextChanged(sender As Object, e As EventArgs) Handles T4_HOUSENO.TextChanged

    End Sub

    Private Sub P4_MIDDLENAME_TextChanged(sender As Object, e As EventArgs) Handles P4_MIDDLENAME.TextChanged

    End Sub

    Private Sub P4_LASTNAME_TextChanged(sender As Object, e As EventArgs) Handles P4_LASTNAME.TextChanged

    End Sub

    Private Sub M3_CLEANSALARY_TextChanged(sender As Object, e As EventArgs) Handles M3_CLEANSALARY.TextChanged

    End Sub

    Private Sub L3_WEEKLYINCOME_TextChanged(sender As Object, e As EventArgs) Handles L3_WEEKLYINCOME.TextChanged

    End Sub

    Private Sub L3_EXPENSES_TextChanged(sender As Object, e As EventArgs) Handles L3_EXPENSES.TextChanged

    End Sub

    Private Sub L3_SALARY_TextChanged(sender As Object, e As EventArgs) Handles L3_SALARY.TextChanged

    End Sub

    Private Sub P3_BUSINESS_TextChanged(sender As Object, e As EventArgs) Handles P3_BUSINESS.TextChanged

    End Sub

    Private Sub R2_RELIGION_TextChanged(sender As Object, e As EventArgs) Handles R2_RELIGION.TextChanged

    End Sub

    Private Sub B2_ANAK_TextChanged(sender As Object, e As EventArgs) Handles B2_ANAK.TextChanged

    End Sub

    Private Sub E2_AGE_TextChanged(sender As Object, e As EventArgs) Handles E2_AGE.TextChanged

    End Sub

    Private Sub T2_PROVINCE_TextChanged(sender As Object, e As EventArgs) Handles T2_PROVINCE.TextChanged

    End Sub

    Private Sub T2_MUNICIPALITY_TextChanged(sender As Object, e As EventArgs) Handles T2_MUNICIPALITY.TextChanged

    End Sub

    Private Sub T2_BARANGAY_TextChanged(sender As Object, e As EventArgs) Handles T2_BARANGAY.TextChanged

    End Sub

    Private Sub T2_STREET_TextChanged(sender As Object, e As EventArgs) Handles T2_STREET.TextChanged

    End Sub

    Private Sub T2_HOUSENO_TextChanged(sender As Object, e As EventArgs) Handles T2_HOUSENO.TextChanged

    End Sub

    Private Sub P2_MIDDLENAME_TextChanged(sender As Object, e As EventArgs) Handles P2_MIDDLENAME.TextChanged

    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged

    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click

    End Sub

    Private Sub Label25_Click(sender As Object, e As EventArgs) Handles Label25.Click

    End Sub

    Private Sub Label26_Click(sender As Object, e As EventArgs) Handles Label26.Click

    End Sub

    Private Sub Label27_Click(sender As Object, e As EventArgs) Handles Label27.Click

    End Sub

    Private Sub Label28_Click(sender As Object, e As EventArgs) Handles Label28.Click

    End Sub

    Private Sub Label29_Click(sender As Object, e As EventArgs) Handles Label29.Click

    End Sub

    Private Sub Label30_Click(sender As Object, e As EventArgs) Handles Label30.Click

    End Sub

    Private Sub P2_LASTNAME_TextChanged(sender As Object, e As EventArgs) Handles P2_LASTNAME.TextChanged

    End Sub

    Private Sub C1_CONTACT_TextChanged(sender As Object, e As EventArgs) Handles C1_CONTACT.TextChanged

    End Sub

    Private Sub R1_RELIGION_TextChanged(sender As Object, e As EventArgs) Handles R1_RELIGION.TextChanged

    End Sub

    Private Sub E1_AGE_TextChanged(sender As Object, e As EventArgs) Handles E1_AGE.TextChanged

    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click

    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click

    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click

    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click

    End Sub

    Private Sub Label23_Click(sender As Object, e As EventArgs) Handles Label23.Click

    End Sub

    Private Sub Label24_Click(sender As Object, e As EventArgs) Handles Label24.Click

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub

    Private Sub T1_BARANGAY_TextChanged(sender As Object, e As EventArgs) Handles T1_BARANGAY.TextChanged

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub T1_PROVINCE_TextChanged(sender As Object, e As EventArgs) Handles T1_PROVINCE.TextChanged

    End Sub

    Private Sub T1_MUNICIPALITY_TextChanged(sender As Object, e As EventArgs) Handles T1_MUNICIPALITY.TextChanged

    End Sub

    Private Sub T1_STREET_TextChanged(sender As Object, e As EventArgs) Handles T1_STREET.TextChanged

    End Sub

    Private Sub T1_HOUSENO_TextChanged(sender As Object, e As EventArgs) Handles T1_HOUSENO.TextChanged

    End Sub

    Private Sub P1_MIDDLENAME_TextChanged(sender As Object, e As EventArgs) Handles P1_MIDDLENAME.TextChanged

    End Sub

    Private Sub P1_LASTNAME_TextChanged(sender As Object, e As EventArgs) Handles P1_LASTNAME.TextChanged

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged

    End Sub

    Private Sub DateTimePicker3_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker3.ValueChanged

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label49_Click(sender As Object, e As EventArgs) Handles Label49.Click

    End Sub

    Private Sub Label31_Click(sender As Object, e As EventArgs) Handles Label31.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub Label89_Click(sender As Object, e As EventArgs) Handles Label89.Click

    End Sub
End Class
