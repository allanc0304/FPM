Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Header

Public Class CIRFORM1
    Private Sub Label88_Click(sender As Object, e As EventArgs) Handles Label88.Click

    End Sub

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
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles CIR_BACKBTN.Click

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
End Class