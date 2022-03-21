Imports System.ComponentModel

Public Class ApplictaionForm1


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
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This is field will accept Letters only")
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

    Private Sub K1_BARANGAY_KeyPress(sender As Object, e As KeyPressEventArgs) Handles K1_DAY.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This is field will accept Letters only")
        End If
    End Sub

    Private Sub K1_MUNICIPALITY_KeyPress(sender As Object, e As KeyPressEventArgs) Handles K1_MONTH.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This is field will accept Letters only")
        End If
    End Sub

    Private Sub K1_PROVINCE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles S.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This is field will accept Letters only")
        End If
    End Sub

    Private Sub E1_AGE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles E1_AGE.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This is field will accept Numbers only")
        End If
    End Sub

    Private Sub C1_CONTACT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles C1_CONTACT.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This is field will accept Numbers only")
        End If
        If C1_CONTACT.Text.Length >= 11 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MessageBox.Show("Philippines local number should not be more than 11")
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



        AppFormB.Show()
        Me.Hide()
    End Sub

    Private Sub ApplictaionForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
