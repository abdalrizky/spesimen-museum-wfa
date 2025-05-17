Public Class MainMenuForm

    Public Property User As New User()

    Private Sub MainMenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case User.Role
            Case "admin"
                Dim employeeMenuControl As New AdminMenuControl
                employeeMenuControl.Dock = DockStyle.Fill
                SplitContainer1.Panel2.Controls.Add(employeeMenuControl)
            Case "visitor"
                Dim visitorMenuControl As New VisitorMenuControl
                visitorMenuControl.User = Me.User
                visitorMenuControl.Dock = DockStyle.Fill
                SplitContainer1.Panel2.Controls.Add(visitorMenuControl)
                txtWelcomeMessage.Text = $"Selamat Datang, {User.Username}"
            Case Else
                MessageBox.Show("Login tidak valid.")
                End
        End Select
    End Sub
End Class