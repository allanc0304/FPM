Public Class AppFormB


    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles proceedbttn.Click
        If Vld(P1_LASTNAME, P1_MIDDLENAME, P1_GIVENNAME, T1_HOUSENO, T1_STREET, T1_BARANGAY, T1_MUNICIPALITY, T1_PROVINCE, H2_HALAGA, HH2_HALAGANG_HINIRAM, TP2_TAGAL_NG_PAGBAYAD, PP2_PARAAN_PAGBAYAD, R2_RECOMMENDED, AL2_LOAN, CB2_CHECKEDBY) = False Then
            MessageBox.Show("Fill up all fields")
            Exit Sub
        Else

            MsgBox("Proceed to CIR FORM")

            CIRFORMA.Show()
            Me.Hide()
        End If


    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.P1_LASTNAME.Text = AppFormA.P1_LASTNAME.Text
        Me.P1_GIVENNAME.Text = AppFormA.P1_GIVENNAME.Text
        Me.P1_MIDDLENAME.Text = AppFormA.P1_MIDDLENAME.Text
        Me.P1_SUFFIX.Text = AppFormA.P1_SUFFIX.Text
        Me.T1_BARANGAY.Text = AppFormA.T1_BARANGAY.Text
        Me.T1_HOUSENO.Text = AppFormA.T1_HOUSENO.Text
        Me.T1_MUNICIPALITY.Text = AppFormA.T1_MUNICIPALITY.Text
        Me.T1_STREET.Text = AppFormA.T1_STREET.Text
        Me.T1_PROVINCE.Text = AppFormA.T1_PROVINCE.Text

        Me.P2_LASTNAME.Text = AppFormA.P1_LASTNAME.Text
        Me.P2_GIVENNAME.Text = AppFormA.P1_GIVENNAME.Text
        Me.P2_MIDDLENAME.Text = AppFormA.P1_MIDDLENAME.Text
        Me.P2_SUFFIX.Text = AppFormA.P1_SUFFIX.Text
        Me.T2_BARANGAY.Text = AppFormA.T1_BARANGAY.Text
        Me.T2_HOUSENO.Text = AppFormA.T1_HOUSENO.Text
        Me.T2_MUNICIPALITY.Text = AppFormA.T1_MUNICIPALITY.Text
        Me.T2_STREET.Text = AppFormA.T1_STREET.Text
        Me.T2_PROVINCE.Text = AppFormA.T1_PROVINCE.Text


    End Sub


    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        AppFormA.Show()
        Me.Hide()

    End Sub



    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click





        Dim Item As New ListViewItem(U1_URI_NG_KAGAMITAN.Text)


        Item.SubItems.Add(M1_MODEL.Text)
        Item.SubItems.Add(SN1_SERIES_NUMBER.Text)
        Item.SubItems.Add(HL1_HALAGA.Text)

        ListView1.Items.Add(Item)





    End Sub

    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles SN1_SERIES_NUMBER.TextChanged




    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        ListView1.Items.RemoveAt(ListView1.SelectedIndices(0))
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub ListView1_MouseClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseClick





    End Sub

    Private Sub ListView2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListView2_MouseClick(sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub AppFormB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles T1_PROVINCE.KeyPress, T1_MUNICIPALITY.KeyPress, T1_BARANGAY.KeyPress, P1_SUFFIX.KeyPress, CB2_CHECKEDBY.KeyPress, P1_MIDDLENAME.KeyPress, R2_RECOMMENDED.KeyPress, T2_MUNICIPALITY.KeyPress, T2_PROVINCE.KeyPress, T2_BARANGAY.KeyPress, P1_GIVENNAME.KeyPress, P2_SUFFIX.KeyPress, P2_MIDDLENAME.KeyPress, P2_GIVENNAME.KeyPress, P2_LASTNAME.KeyPress, U1_URI_NG_KAGAMITAN.KeyPress, P1_LASTNAME.KeyPress, MyBase.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This is field will accept Letters only")
        End If
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles T1_HOUSENO.KeyPress, AL2_LOAN.KeyPress, PP2_PARAAN_PAGBAYAD.KeyPress, TP2_TAGAL_NG_PAGBAYAD.KeyPress, HH2_HALAGANG_HINIRAM.KeyPress, H2_HALAGA.KeyPress, T2_HOUSENO.KeyPress, HL1_HALAGA.KeyPress, SN1_SERIES_NUMBER.KeyPress, M1_MODEL.KeyPress, PH1_PAGHULOG.KeyPress, H1_HALAGA.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This is field will accept Numbers only")
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

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        CIRFORMA.Show()
        Me.Hide()

    End Sub
End Class