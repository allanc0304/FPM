Imports System.ComponentModel
Imports System.Text.RegularExpressions
Public Class AppFormA

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        With Savings

            .TopLevel = False
            .AutoSize = True

            Navigation.Navigationpanel.Controls.Add(Savings)
            .BringToFront()
            .Show()

        End With
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            'Button2.Text = OpenFileDialog1.FileName
            PictureBox2.Image = Image.FromFile(OpenFileDialog1.FileName)
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


        ElseIf Vld(P2_LASTNAME, P2_GIVENNAME, P2_MIDDLENAME, T2_HOUSENO, T2_STREET, T2_BARANGAY, T2_PROVINCE, T2_MUNICIPALITY, E2_AGE, R2_RELIGION, B2_ANAK) = False Then
            MessageBox.Show("Fill up all fields")

        ElseIf Vld(P3_BUSINESS, L3_SALARY, L3_EXPENSES, L3_WEEKLYINCOME, M3_CLEANSALARY) = False Then
            MessageBox.Show("Fill up all fields")


        ElseIf Vld(P4_LASTNAME, P4_GIVENNAME, P4_MIDDLENAME, T4_HOUSENO, T4_STREET, T4_BARANGAY, T4_PROVINCE, T4_MUNICIPALITY, E4_AGE, T4_TYPEOFBUSINESS, B4_BUSINESS) = False Then
            MessageBox.Show("Fill up all fields")


            Exit Sub
        Else

            MsgBox("Proceed to next form")
            AppFormB.Show()
            Me.Close()




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





    Private Sub C1_CONTACT_Validated(sender As Object, e As EventArgs) Handles C1_CONTACT.Validated
        Dim phone As New Regex("09\d{9}$")
        'phone number like 092-3470-9218
        If (Not phone.IsMatch(C1_CONTACT.Text)) Then
            MsgBox("Phone Number is Invalid")
            C1_CONTACT.Text = ""
        End If
    End Sub


End Class
