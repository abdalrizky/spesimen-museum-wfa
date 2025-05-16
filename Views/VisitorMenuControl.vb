Public Class VisitorMenuControl
    Private Sub btnToViewSpeciments_Click(sender As Object, e As EventArgs) Handles btnToViewSpeciments.Click
        SpecimentListForm.Show()
    End Sub

    Private Sub btnToFavoriteList_Click(sender As Object, e As EventArgs) Handles btnToFavoriteList.Click
        SpecimentFavoriteForm.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        FindForm.Close()
        WelcomeForm.Show()
    End Sub
End Class
