Public Class AdminMenuControl
    Private Sub btnToAccountManagement_Click(sender As Object, e As EventArgs) Handles btnToAccountManagement.Click
        AccountManagementForm.Show()
    End Sub

    Private Sub btnToSpecimentManagement_Click(sender As Object, e As EventArgs) Handles btnToSpecimentManagement.Click
        SpecimentManagementForm.Show()
    End Sub

    Private Sub btnToCollectionStorageManagement_Click(sender As Object, e As EventArgs) Handles btnToCollectionStorageManagement.Click
        CollectionStorageManagementForm.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        FindForm.Close()
        WelcomeForm.Show()
    End Sub
End Class
