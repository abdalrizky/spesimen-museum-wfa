Public Class WelcomeForm
    Public IsLogin As Boolean = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenConnection()
        btnViewSpeciments.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnMasuk_Click(sender As Object, e As EventArgs) Handles btnMasuk.Click
        If IsLogin = True Then
            Hide()
            SpecimentManagementForm.Show()
            Exit Sub
        Else
            pnlOverlay.BringToFront()
            pnlOverlay.Visible = True
            Dim authForm As New AuthForm
            authForm.ShowDialog()
            pnlOverlay.Visible = False
        End If
    End Sub

    Private Sub ShowOverlay()
        Dim overlay As New Panel
        overlay.BackColor = Color.FromArgb(100, 0, 0, 0)
        overlay.Dock = DockStyle.Fill
        overlay.Location = New Point(0, 0)

    End Sub

    Private Sub btnViewSpeciments_Click(sender As Object, e As EventArgs) Handles btnViewSpeciments.Click
        Dim specimentListForm As New SpecimentListForm()
        specimentListForm.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs)
        IsLogin = False
        btnViewSpeciments.Location = New Point(309, 265)
        btnExit.Location = New Point(309, 380)
    End Sub
End Class
