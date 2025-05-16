Public Class CreateBiologistAccountForm
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        If UserRepository.CheckUsernameExists($"bio:{username}") Then
            MessageBox.Show("Username sudah terdaftar.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If UserRepository.RegisterBiologist(username, password) Then
            MessageBox.Show("Akun ahli biologi berhasil dibuat.", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Terjadi kesalahan. Silakan dicoba lain waktu.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class