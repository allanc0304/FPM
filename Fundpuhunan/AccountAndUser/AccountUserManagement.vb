Public Class AccountUserManagement
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        AddUserAccount.Show()

    End Sub

    Private Sub FontDialog1_Apply(sender As Object, e As EventArgs) Handles FontDialog1.Apply

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = Date.Now.ToString("dd MMM yyyy       hh:mm:ss tt")


    End Sub

    Private Sub AccountUserManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub
End Class