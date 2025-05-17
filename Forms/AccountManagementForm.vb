Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class AccountManagementForm
    Private originalItems As New List(Of ListViewItem)

    Private Sub AccountManagementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub LoadData()
        lvwUsers.Items.Clear()
        lvwUsers.Columns.Clear()
        originalItems.Clear()
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
            originalItems.Add(CType(item.Clone(), ListViewItem))
            ordinal += 1
        Next
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim keyword As String = txtSearch.Text.ToLower()
        lvwUsers.Items.Clear()
        For Each item As ListViewItem In originalItems
            If item.SubItems(2).Text.ToLower().Contains(keyword) Then
                lvwUsers.Items.Add(CType(item.Clone(), ListViewItem))
            End If
        Next
    End Sub
End Class