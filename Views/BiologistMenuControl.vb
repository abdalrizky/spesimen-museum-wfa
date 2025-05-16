Public Class BiologistMenuControl
    Private Sub btnToSpecimentCheckRequest_Click(sender As Object, e As EventArgs) Handles btnToSpecimentCheckRequest.Click
        SpecimentRequestForm.Show()
    End Sub

    Private Sub btnToSpecimentCheckHistory_Click(sender As Object, e As EventArgs) Handles btnToSpecimentCheckHistory.Click
        SpecimentRequestHistoryForm.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        FindForm.Close()
        WelcomeForm.Show()
    End Sub
End Class
