Public Class Dashboard

    Private Sub AddNewoanbttn_Click(sender As Object, e As EventArgs) Handles AddNewoanbttn.Click
        With BorrowersList
            AppFormA = Nothing
            AppFormB = Nothing
            CIRFORMA = Nothing
            CIRFORMB = Nothing

            .TopLevel = False
            .AutoSize = True

            Navigation.Navigationpanel.Controls.Add(BorrowersList)
            .BringToFront()
            .Show()

        End With


    End Sub

    Private Sub AccounSettingsbttn_Click(sender As Object, e As EventArgs) Handles AccounSettingsbttn.Click
        With Savings

            .TopLevel = False
            .AutoSize = True

            Navigation.Navigationpanel.Controls.Add(Savings)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub ViewAllLoanbttn_Click(sender As Object, e As EventArgs) Handles ViewAllLoanbttn.Click
        With MyAccount

            .TopLevel = False
            .AutoSize = True

            Navigation.Navigationpanel.Controls.Add(MyAccount)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub collectpaymentbttn_Click(sender As Object, e As EventArgs) Handles collectpaymentbttn.Click
        With Collections

            .TopLevel = False
            .AutoSize = True

            Navigation.Navigationpanel.Controls.Add(Collections)
            .BringToFront()
            .Show()

        End With
    End Sub
End Class