Public Class Dashboard

    Private Sub AddNewoanbttn_Click(sender As Object, e As EventArgs) Handles AddNewoanbttn.Click
        With Application
            AppFormA = Nothing
            AppFormB = Nothing
            CIRFORMA = Nothing
            CIRFORMB = Nothing

            .TopLevel = False
            .AutoSize = True

            Navigation.Navigationpanel.Controls.Add(Application)
            .BringToFront()
            .Show()

        End With

        AppFormA.Show()
    End Sub

    Private Sub AccounSettingsbttn_Click(sender As Object, e As EventArgs) Handles AccounSettingsbttn.Click
        With MyAccount

            .TopLevel = False
            .AutoSize = True

            Navigation.Navigationpanel.Controls.Add(MyAccount)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub ViewAllLoanbttn_Click(sender As Object, e As EventArgs) Handles ViewAllLoanbttn.Click
        With Application

            .TopLevel = False
            .AutoSize = True

            Navigation.Navigationpanel.Controls.Add(Application)
            .BringToFront()
            .Show()

        End With
    End Sub
End Class