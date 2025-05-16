Public Class AuthForm
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenConnection()
        ShowContent(New LoginControl(Me))
    End Sub

    Public Sub ShowContent(control As UserControl)
        pnlContent.Controls.Clear()
        pnlContent.Controls.Add(control)
    End Sub

    'Private Sub txtPwBaru_TextChanged(sender As Object, e As EventArgs)
    '    If txtPwBaru.Text.Length < 8 Then
    '        lbPwBaru.Visible = True
    '        lbPwBaru.Text = "Password minimal 8 karakter"
    '        txtKonfirmPw.Enabled = False
    '    Else
    '        lbPwBaru.Visible = False
    '        txtKonfirmPw.Enabled = True
    '        IsKosong()
    '    End If
    'End Sub

    'Private Sub btnLogin_Click(sender As Object, e As EventArgs)
    '    If UserRepository.Login(txtUsrLogin.Text, txtPw.Text) Then
    '        SpecimentManagementForm.Show()
    '    Else
    '        MsgBox("Username atau Password Salah")
    '        txtUsrLogin.Clear
    '        txtPw.Clear
    '        txtUsrLogin.Focus
    '    End If
    'End Sub



    'Private Sub txtUsrLogin_TextChanged(sender As Object, e As EventArgs)
    '    If txtUsrLogin.Text = "" Or txtPw.Text = "" Then
    '        btnLogin.Enabled = False
    '    Else
    '        btnLogin.Enabled = True
    '    End If
    'End Sub

    'Private Sub txtUsrBaru_TextChanged(sender As Object, e As EventArgs)
    '    IsKosong()
    'End Sub

    'Private Sub IsKosong()
    '    If txtUsrBaru.Text = "" Or txtPwBaru.Text = "" Or txtKonfirmPw.Text = "" Then
    '        btnRegis.Enabled = False
    '    Else
    '        If txtPwBaru.Text <> txtKonfirmPw.Text Then
    '            lbPwBaru.Text = "Password tidak sama"
    '            lbPwBaru.Visible = True
    '            btnRegis.Enabled = False
    '        Else
    '            lbPwBaru.Visible = False
    '            btnRegis.Enabled = True
    '        End If
    '    End If
    'End Sub

    'Private Sub kosong()
    '    txtKonfirmPw.Clear()
    '    txtPwBaru.Clear()
    '    txtUsrBaru.Clear()
    '    txtUsrLogin.Clear()
    '    txtPw.Clear()
    'End Sub

    'Private Sub txtUsrBaru_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsrBaru.KeyPress, txtUsrLogin.KeyPress, txtPw.KeyPress, txtPwBaru.KeyPress, txtKonfirmPw.KeyPress
    '    txtUsrBaru.MaxLength = 50

    '    txtPwBaru.MaxLength = 50
    '    txtKonfirmPw.MaxLength = 50

    '    If pnlLogin.Visible = True Then
    '        txtUsrLogin.MaxLength = 50
    '        txtPw.MaxLength = 50
    '        If e.KeyChar = Chr(13) Then
    '            If txtUsrLogin.Text = "" Then
    '                MsgBox("Username Harus Diisi")
    '                txtUsrLogin.Focus()
    '            Else
    '                txtPw.Focus()
    '            End If

    '            If txtPw.Focus And txtPw.Text <> "" Then
    '                SLogin()
    '            End If
    '        End If

    '    ElseIf pnlRegis.Visible = True Then
    '        txtUsrBaru.MaxLength = 50
    '        txtPwBaru.MaxLength = 50
    '        txtKonfirmPw.MaxLength = 50

    '        If e.KeyChar = Chr(13) Then
    '            If txtUsrBaru.Text <> "" And txtUsrBaru.Focus Then
    '                txtPwBaru.Focus()
    '            ElseIf txtPwBaru.Text <> "" And txtPwBaru.Focus Then
    '                txtKonfirmPw.Focus()
    '            End If

    '            If txtKonfirmPw.Focus And txtKonfirmPw.Text <> "" Then
    '                crud.regis(txtUsrBaru.Text, txtPwBaru.Text, "default.jpg")
    '                kosong()
    '                pnlRegis.Visible = False
    '                pnlLogin.Visible = True
    '            End If
    '        End If
    '    End If
    'End Sub

End Class