
Imports System.Text.RegularExpressions

Public Class BorrowersLoan


    Private Sub linkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)



    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click



    End Sub







    Private Sub phoneno1_Validated_1(sender As Object, e As EventArgs)
        Dim phone As New Regex("09\d{9}$")
        'phone number like 092-3470-9218

    End Sub

    Private Sub maristats1_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This is field will accept Numbers only")
        End If
    End Sub

    Private Sub email1_KeyPress(sender As Object, e As KeyPressEventArgs)

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

    Private Sub phoneno1_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This is field will accept Numbers only")
        End If
    End Sub

    Private Sub textBox1_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This is field will accept Numbers only")
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub label13_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub dataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AppFormA.view = True
        AppFormB.view = True
        AppFormA.Show()
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        AddLoanPayment.Show()
    End Sub

    Private Sub AP_CONFIRMBTN_Click(sender As Object, e As EventArgs) Handles AP_CONFIRMBTN.Click
        BorrowersSavings.Show()

        Me.Hide()

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Date.Now.ToString("dd MMM yyyy       hh:mm:ss tt")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        BorrowersList.Button3.Enabled = True
        Dashboard.Show()
        Me.Close()
    End Sub
End Class
