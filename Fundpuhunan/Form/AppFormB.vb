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

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles H1_HALAGA.TextChanged

    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles PH1_PAGHULOG.TextChanged

    End Sub

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles M1_MODEL.TextChanged

    End Sub

    Private Sub TextBox15_TextChanged(sender As Object, e As EventArgs) Handles HL1_HALAGA.TextChanged

    End Sub

    Private Sub TextBox20_TextChanged(sender As Object, e As EventArgs) Handles T2_HOUSENO.TextChanged

    End Sub

    Private Sub TextBox25_TextChanged(sender As Object, e As EventArgs) Handles H2_HALAGA.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles T1_HOUSENO.TextChanged

    End Sub

    Private Sub TextBox28_TextChanged(sender As Object, e As EventArgs) Handles PP2_PARAAN_PAGBAYAD.TextChanged

    End Sub

    Private Sub TextBox30_TextChanged(sender As Object, e As EventArgs) Handles AL2_LOAN.TextChanged

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




End Class