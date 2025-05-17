Public Class RegisterControl

    Private authForm As AuthForm
    Public Sub New(ByRef parent As AuthForm)
        InitializeComponent()
        authForm = parent
    End Sub

    Private Sub btnBkLogin_Click(sender As Object, e As EventArgs) Handles btnBkLogin.Click
        authForm.ShowContent(New LoginControl(authForm))
    End Sub

    Private Sub btnRegis_Click(sender As Object, e As EventArgs) Handles btnRegis.Click

        Dim username = txtUsrBaru.Text
        Dim password = txtPwBaru.Text
        Dim passwordConfirm = txtKonfirmPw.Text

        If username = "" Or password = "" Or passwordConfirm = "" Then
            MessageBox.Show("Harus diisi semua", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If password.Length < 8 Then
            MessageBox.Show("Password harus 8 karakter atau lebih", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If passwordConfirm <> password Then
            MessageBox.Show("Konfirmasi password tidak sama.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If UserRepository.CheckUsernameExists(txtUsrBaru.Text) Then
            MessageBox.Show("Username sudah terdaftar.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If UserRepository.Register(txtUsrBaru.Text, txtPwBaru.Text) Then
            MessageBox.Show("Registrasi Berhasil. Silakan login dengan username dan password yang telah didaftarkan.", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
            authForm.ShowContent(New LoginControl(authForm))
        Else
            MessageBox.Show("Registrasi Gagal. Ada gangguan pada sistem kami.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub txtKonfirmPw_TextChanged(sender As Object, e As EventArgs) Handles txtKonfirmPw.TextChanged
        If txtPwBaru.Text <> txtKonfirmPw.Text Then
            lbPwBaru.Visible = True
            btnRegis.Enabled = False
        Else
            lbPwBaru.Visible = False
            btnRegis.Enabled = True
        End If
    End Sub

End Class
