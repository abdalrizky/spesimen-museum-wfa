Public Class LoginControl
    Private authForm As AuthForm
    Public Sub New(ByRef parent As AuthForm)
        InitializeComponent()
        authForm = parent
    End Sub
    Private Sub btnToRegis_Click(sender As Object, e As EventArgs) Handles btnToRegis.Click
        authForm.ShowContent(New RegisterControl(authForm))
    End Sub

    Private Sub btnBkLandingPg_Click(sender As Object, e As EventArgs) Handles btnBkLandingPg.Click
        authForm.Hide()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username = txtUsrLogin.Text
        Dim password = txtPw.Text

        If username <> "" AndAlso password <> "" Then
            Dim loginResult = UserRepository.Login(username, password)
            If loginResult.IsLoggedIn Then
                authForm.Hide()
                WelcomeForm.Hide()

                Dim mainMenuForm As New MainMenuForm()
                mainMenuForm.User.Id = loginResult.Id
                mainMenuForm.User.Username = loginResult.Username
                mainMenuForm.User.Role = loginResult.Role
                mainMenuForm.Show()
            Else
                MessageBox.Show("Username atau password salah.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Username dan password tidak boleh kosong.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
End Class
