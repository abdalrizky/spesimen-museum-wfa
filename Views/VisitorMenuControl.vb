Public Class VisitorMenuControl
    Public Property User As New User()
    Private Sub btnToViewSpeciments_Click(sender As Object, e As EventArgs) Handles btnToViewSpeciments.Click
        Dim specimentListForm As New SpecimentListForm()
        specimentListForm.User = Me.User
        specimentListForm.Show()
    End Sub

    Private Sub btnToFavoriteList_Click(sender As Object, e As EventArgs) Handles btnToFavoriteList.Click
        Dim specimentFavoriteForm As New SpecimentFavoriteForm()
        specimentFavoriteForm.User = Me.User
        specimentFavoriteForm.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        FindForm.Close()
        WelcomeForm.Show()
    End Sub
End Class
