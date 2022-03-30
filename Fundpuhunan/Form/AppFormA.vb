Imports System.ComponentModel
Imports System.Text.RegularExpressions
Public Class AppFormA


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        OpenFileDialog1.Filter = "All files|*.*"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Button2.Text = OpenFileDialog1.FileName
        End If
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
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
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

    Private Sub K1_DAY_KeyPress(sender As Object, e As KeyPressEventArgs) Handles K1_DAY.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This is field will accept Numbers only")
        End If

    End Sub

    Private Sub K1_MONTH_KeyPress(sender As Object, e As KeyPressEventArgs) Handles K1_MONTH.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This is field will accept Letters only")
        End If
    End Sub

    Private Sub K1_YEAR_KeyPress(sender As Object, e As KeyPressEventArgs) Handles K1_YEAR.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This is field will accept Numbers only")
        End If
        If K1_YEAR.Text.Length = 4 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MessageBox.Show("Indicate your birth of year")
            End If
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

    Private Sub P2_LASTNAME_KeyPress(sender As Object, e As KeyPressEventArgs) Handles T2_PROVINCE.KeyPress, T2_MUNICIPALITY.KeyPress, T2_BARANGAY.KeyPress, R2_RELIGION.KeyPress, P2_SUFFIX.KeyPress, P2_MIDDLENAME.KeyPress, P2_LASTNAME.KeyPress, P2_GIVENNAME.KeyPress, K2_YEAR.KeyPress, K2_DAY.KeyPress, K2_MONTH.KeyPress
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

    Private Sub P4_LASTNAME_KeyPress(sender As Object, e As KeyPressEventArgs) Handles T4_TYPEOFBUSINESS.KeyPress, T4_PROVINCE.KeyPress, T4_MUNICIPALITY.KeyPress, T4_BARANGAY.KeyPress, P4_SUFFIX.KeyPress, P4_MIDDLENAME.KeyPress, P4_LASTNAME.KeyPress, P4_GIVENNAME.KeyPress, K4_YEAR.KeyPress, K4_DAY.KeyPress, K4_MONTH.KeyPress, B4_BUSINESS.KeyPress
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

        If Vld(P1_LASTNAME, P1_MIDDLENAME, P1_GIVENNAME, C1_CONTACT, T1_HOUSENO, T1_STREET, T1_BARANGAY, T1_MUNICIPALITY, T1_PROVINCE, K1_MONTH, K1_DAY, K1_YEAR, E1_AGE, R1_RELIGION) = False Then
            MessageBox.Show("Fill up all fields")


        ElseIf Vld(P2_LASTNAME, P2_GIVENNAME, P2_MIDDLENAME, T2_HOUSENO, T2_STREET, T2_BARANGAY, T2_PROVINCE, T2_MUNICIPALITY, K2_DAY, K2_MONTH, K2_YEAR, E2_AGE, R2_RELIGION, B2_ANAK) = False Then
            MessageBox.Show("Fill up all fields")

        ElseIf Vld(P3_BUSINESS, L3_SALARY, L3_EXPENSES, L3_WEEKLYINCOME, M3_CLEANSALARY) = False Then
            MessageBox.Show("Fill up all fields")


        ElseIf Vld(P4_LASTNAME, P4_GIVENNAME, P4_MIDDLENAME, T4_HOUSENO, T4_STREET, T4_BARANGAY, T4_PROVINCE, T4_MUNICIPALITY, K4_DAY, K4_MONTH, K4_YEAR, E4_AGE, T4_TYPEOFBUSINESS, B4_BUSINESS) = False Then
            MessageBox.Show("Fill up all fields")


            Exit Sub
        Else

            MsgBox("Proceed to next form")
            AppFormB.Show()
            Me.Hide()




        End If


    End Sub

    Private Sub ApplictaionForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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



    Private Sub P1_LASTNAME_TextChanged(sender As Object, e As EventArgs) Handles P1_LASTNAME.TextChanged
        P2_LASTNAME.Text = P1_LASTNAME.Text
        P4_LASTNAME.Text = P1_LASTNAME.Text
    End Sub

    Private Sub P1_GIVENNAME_TextChanged(sender As Object, e As EventArgs) Handles P1_GIVENNAME.TextChanged
        P2_GIVENNAME.Text = P1_GIVENNAME.Text
        P4_GIVENNAME.Text = P1_GIVENNAME.Text
    End Sub

    Private Sub P1_MIDDLENAME_TextChanged(sender As Object, e As EventArgs) Handles P1_MIDDLENAME.TextChanged
        P2_MIDDLENAME.Text = P1_MIDDLENAME.Text
        P4_MIDDLENAME.Text = P1_MIDDLENAME.Text
    End Sub

    Private Sub P1_SUFFIX_TextChanged(sender As Object, e As EventArgs) Handles P1_SUFFIX.TextChanged
        P2_SUFFIX.Text = P1_SUFFIX.Text
        P4_SUFFIX.Text = P1_SUFFIX.Text
    End Sub

    Private Sub T1_BARANGAY_TextChanged(sender As Object, e As EventArgs) Handles T1_BARANGAY.TextChanged
        T2_BARANGAY.Text = T1_BARANGAY.Text
        T4_BARANGAY.Text = T1_BARANGAY.Text
    End Sub

    Private Sub T1_PROVINCE_TextChanged(sender As Object, e As EventArgs) Handles T1_PROVINCE.TextChanged
        T2_PROVINCE.Text = T1_PROVINCE.Text
        T4_PROVINCE.Text = T1_PROVINCE.Text
    End Sub

    Private Sub T1_MUNICIPALITY_TextChanged(sender As Object, e As EventArgs) Handles T1_MUNICIPALITY.TextChanged
        T2_MUNICIPALITY.Text = T1_MUNICIPALITY.Text
        T4_MUNICIPALITY.Text = T1_MUNICIPALITY.Text
    End Sub

    Private Sub T1_STREET_TextChanged(sender As Object, e As EventArgs) Handles T1_STREET.TextChanged
        T2_STREET.Text = T1_STREET.Text
        T4_STREET.Text = T1_STREET.Text
    End Sub

    Private Sub T1_HOUSENO_TextChanged(sender As Object, e As EventArgs) Handles T1_HOUSENO.TextChanged
        T2_HOUSENO.Text = T1_HOUSENO.Text
        T4_HOUSENO.Text = T1_HOUSENO.Text
    End Sub

    Private Sub K1_DAY_TextChanged(sender As Object, e As EventArgs) Handles K1_DAY.TextChanged
        K2_DAY.Text = K1_DAY.Text
        K4_DAY.Text = K1_DAY.Text
    End Sub

    Private Sub K1_MONTH_TextChanged(sender As Object, e As EventArgs) Handles K1_MONTH.TextChanged
        K2_MONTH.Text = K1_MONTH.Text
        K4_MONTH.Text = K1_MONTH.Text
    End Sub

    Private Sub K1_YEAR_TextChanged(sender As Object, e As EventArgs) Handles K1_YEAR.TextChanged
        K2_YEAR.Text = K1_YEAR.Text
        K4_YEAR.Text = K1_YEAR.Text
    End Sub

    Private Sub E1_AGE_TextChanged(sender As Object, e As EventArgs) Handles E1_AGE.TextChanged
        E2_AGE.Text = E1_AGE.Text
        E4_AGE.Text = E1_AGE.Text
    End Sub

    Private Sub R1_RELIGION_TextChanged(sender As Object, e As EventArgs) Handles R1_RELIGION.TextChanged
        R2_RELIGION.Text = R1_RELIGION.Text

    End Sub

    Private Sub P3_BUSINESS_TextChanged(sender As Object, e As EventArgs) Handles P3_BUSINESS.TextChanged
        B4_BUSINESS.Text = P3_BUSINESS.Text

    End Sub



    Private Sub C1_CONTACT_Validated(sender As Object, e As EventArgs) Handles C1_CONTACT.Validated
        Dim phone As New Regex("09\d{9}$")
        'phone number like 092-3470-9218
        If (phone.IsMatch(C1_CONTACT.Text)) Then
            MsgBox("Phone Number is Valid")
        Else
            MsgBox("Phone Number is Invalid")
            C1_CONTACT.Text = ""
        End If
    End Sub
End Class
