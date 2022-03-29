Public Class AppFormB
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Vld(P1_LASTNAME, P1_MIDDLENAME, P1_GIVENNAME, T1_HOUSENO, T1_STREET, T1_BARANGAY, T1_MUNICIPALITY, T1_PROVINCE, H2_HALAGA, HH2_HALAGANG_HINIRAM, TP2_TAGAL_NG_PAGBAYAD, PP2_PARAAN_PAGBAYAD, R2_RECOMMENDED, AL2_LOAN, CB2_CHECKEDBY) = False Then
            MessageBox.Show("Fill up all fields")

            Exit Sub
        Else

            MsgBox("your data was inserted Succesfully")
            Application.Show()
            Me.Hide()



        End If




    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox26_TextChanged(sender As Object, e As EventArgs) Handles HH2_HALAGANG_HINIRAM.TextChanged

    End Sub

    Private Sub TextBox27_TextChanged(sender As Object, e As EventArgs) Handles TP2_TAGAL_NG_PAGBAYAD.TextChanged

    End Sub

    Private Sub Label61_Click(sender As Object, e As EventArgs) Handles Label61.Click

    End Sub

    Private Sub TextBox23_TextChanged(sender As Object, e As EventArgs) Handles T2_PROVINCE.TextChanged

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        ApplictaionForm1.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Button2.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If OpenFileDialog2.ShowDialog = DialogResult.OK Then
            Button2.Text = OpenFileDialog2.FileName
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If OpenFileDialog3.ShowDialog = DialogResult.OK Then
            Button2.Text = OpenFileDialog3.FileName
        End If
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

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Dim Item As New ListViewItem(PP2_PARAAN_PAGBAYAD.Text)


        Item.SubItems.Add(HH2_HALAGANG_HINIRAM.Text)
        Item.SubItems.Add(TP2_TAGAL_NG_PAGBAYAD.Text)
        Item.SubItems.Add(PP2_PARAAN_PAGBAYAD.Text)

        ListView2.Items.Add(Item)






    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        ListView1.Items.RemoveAt(ListView1.SelectedIndices(0))
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub ListView1_MouseClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseClick





    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        ListView2.Items.RemoveAt(ListView2.SelectedIndices(0))
    End Sub

    Private Sub ListView2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView2.SelectedIndexChanged

    End Sub

    Private Sub ListView2_MouseClick(sender As Object, e As MouseEventArgs) Handles ListView2.MouseClick

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

    Private Sub P1_LASTNAME_TextChanged(sender As Object, e As EventArgs) Handles P1_LASTNAME.TextChanged
        P2_LASTNAME.Text = P1_LASTNAME.Text
    End Sub

    Private Sub P1_GIVENNAME_TextChanged(sender As Object, e As EventArgs) Handles P1_GIVENNAME.TextChanged
        P2_GIVENNAME.Text = P2_GIVENNAME.Text
    End Sub

    Private Sub P1_MIDDLENAME_TextChanged(sender As Object, e As EventArgs) Handles P1_MIDDLENAME.TextChanged
        P2_MIDDLENAME.Text = P1_MIDDLENAME.Text
    End Sub

    Private Sub P1_SUFFIX_TextChanged(sender As Object, e As EventArgs) Handles P1_SUFFIX.TextChanged
        P2_SUFFIX.Text = P1_SUFFIX.Text
    End Sub

    Private Sub T1_STREET_TextChanged(sender As Object, e As EventArgs) Handles T1_STREET.TextChanged
        T2_STREET.Text = T1_STREET.Text
    End Sub

    Private Sub T1_BARANGAY_TextChanged(sender As Object, e As EventArgs) Handles T1_BARANGAY.TextChanged
        T2_BARANGAY.Text = T1_BARANGAY.Text
    End Sub

    Private Sub T1_MUNICIPALITY_TextChanged(sender As Object, e As EventArgs) Handles T1_MUNICIPALITY.TextChanged
        T2_MUNICIPALITY.Text = T1_MUNICIPALITY.Text
    End Sub

    Private Sub T1_PROVINCE_TextChanged(sender As Object, e As EventArgs) Handles T1_PROVINCE.TextChanged
        T2_PROVINCE.Text = T1_PROVINCE.Text
    End Sub

    Private Sub T1_HOUSENO_TextChanged(sender As Object, e As EventArgs) Handles T1_HOUSENO.TextChanged
        T2_HOUSENO.Text = T1_HOUSENO.Text
    End Sub
End Class