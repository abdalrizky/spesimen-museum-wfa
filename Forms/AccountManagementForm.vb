Public Class AccountManagementForm
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwUsers.SelectedIndexChanged

    End Sub

    Private Sub AccountManagementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub LoadData()
        lvwUsers.Items.Clear()
        lvwUsers.Columns.Clear()
        lvwUsers.Columns.Add("No.")
        lvwUsers.Columns.Add("Role", 200)
        lvwUsers.Columns.Add("Username", 200)

        Dim users As List(Of User) = UserRepository.GetUsers()

        Dim ordinal As Integer = 1
        For Each user In users
            Dim item As New ListViewItem(ordinal.ToString())
            item.SubItems.Add(user.Role)
            item.SubItems.Add(user.Username)
            lvwUsers.Items.Add(item)
            ordinal += 1
        Next
    End Sub

    Private Sub btnCreateBiologistAccount_Click(sender As Object, e As EventArgs) Handles btnCreateBiologistAccount.Click
        Dim createBiologistAccountForm As New CreateBiologistAccountForm()
        createBiologistAccountForm.ShowDialog()
        LoadData()
    End Sub
End Class