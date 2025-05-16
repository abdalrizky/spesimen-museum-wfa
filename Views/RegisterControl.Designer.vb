<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lbPwBaru = New Label()
        Label6 = New Label()
        txtKonfirmPw = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        btnBkLogin = New Button()
        btnRegis = New Button()
        txtPwBaru = New TextBox()
        txtUsrBaru = New TextBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' lbPwBaru
        ' 
        lbPwBaru.AutoSize = True
        lbPwBaru.BackColor = Color.Transparent
        lbPwBaru.ForeColor = Color.Red
        lbPwBaru.Location = New Point(94, 594)
        lbPwBaru.Margin = New Padding(4, 0, 4, 0)
        lbPwBaru.Name = "lbPwBaru"
        lbPwBaru.Size = New Size(358, 32)
        lbPwBaru.TabIndex = 45
        lbPwBaru.Text = "Konfirmasi password tidak sama."
        lbPwBaru.Visible = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(94, 504)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(269, 31)
        Label6.TabIndex = 44
        Label6.Text = "Konfirmasi Password"
        ' 
        ' txtKonfirmPw
        ' 
        txtKonfirmPw.BorderStyle = BorderStyle.FixedSingle
        txtKonfirmPw.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtKonfirmPw.Location = New Point(94, 550)
        txtKonfirmPw.Margin = New Padding(4, 6, 4, 6)
        txtKonfirmPw.Name = "txtKonfirmPw"
        txtKonfirmPw.Size = New Size(568, 38)
        txtKonfirmPw.TabIndex = 43
        txtKonfirmPw.UseSystemPasswordChar = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(94, 343)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(205, 31)
        Label3.TabIndex = 42
        Label3.Text = " Password Baru"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(94, 223)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(203, 31)
        Label4.TabIndex = 41
        Label4.Text = "Username Baru"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Kristen ITC", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.CornflowerBlue
        Label5.Location = New Point(159, 73)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(436, 83)
        Label5.TabIndex = 40
        Label5.Text = "REGISTRASI"
        ' 
        ' btnBkLogin
        ' 
        btnBkLogin.BackColor = Color.Azure
        btnBkLogin.FlatAppearance.BorderColor = Color.LightSkyBlue
        btnBkLogin.FlatAppearance.BorderSize = 2
        btnBkLogin.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue
        btnBkLogin.FlatStyle = FlatStyle.Flat
        btnBkLogin.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBkLogin.Location = New Point(94, 684)
        btnBkLogin.Margin = New Padding(4, 6, 4, 6)
        btnBkLogin.Name = "btnBkLogin"
        btnBkLogin.Size = New Size(182, 96)
        btnBkLogin.TabIndex = 39
        btnBkLogin.Text = "Kembali"
        btnBkLogin.UseVisualStyleBackColor = False
        ' 
        ' btnRegis
        ' 
        btnRegis.BackColor = Color.Azure
        btnRegis.FlatAppearance.BorderColor = Color.LightSkyBlue
        btnRegis.FlatAppearance.BorderSize = 2
        btnRegis.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue
        btnRegis.FlatStyle = FlatStyle.Flat
        btnRegis.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRegis.Location = New Point(455, 683)
        btnRegis.Margin = New Padding(4, 6, 4, 6)
        btnRegis.Name = "btnRegis"
        btnRegis.Size = New Size(208, 96)
        btnRegis.TabIndex = 38
        btnRegis.Text = "Registrasi"
        btnRegis.UseVisualStyleBackColor = False
        ' 
        ' txtPwBaru
        ' 
        txtPwBaru.BorderStyle = BorderStyle.FixedSingle
        txtPwBaru.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPwBaru.Location = New Point(94, 389)
        txtPwBaru.Margin = New Padding(4, 6, 4, 6)
        txtPwBaru.Name = "txtPwBaru"
        txtPwBaru.Size = New Size(568, 38)
        txtPwBaru.TabIndex = 37
        txtPwBaru.UseSystemPasswordChar = True
        ' 
        ' txtUsrBaru
        ' 
        txtUsrBaru.BorderStyle = BorderStyle.FixedSingle
        txtUsrBaru.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsrBaru.Location = New Point(94, 269)
        txtUsrBaru.Margin = New Padding(4, 6, 4, 6)
        txtUsrBaru.Name = "txtUsrBaru"
        txtUsrBaru.Size = New Size(568, 38)
        txtUsrBaru.TabIndex = 36
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(94, 433)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(331, 32)
        Label1.TabIndex = 46
        Label1.Text = "*Password minimal 8 karakter."
        ' 
        ' RegisterControl
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Label1)
        Controls.Add(lbPwBaru)
        Controls.Add(Label6)
        Controls.Add(txtKonfirmPw)
        Controls.Add(Label3)
        Controls.Add(Label4)
        Controls.Add(Label5)
        Controls.Add(btnBkLogin)
        Controls.Add(btnRegis)
        Controls.Add(txtPwBaru)
        Controls.Add(txtUsrBaru)
        Name = "RegisterControl"
        Size = New Size(757, 853)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbPwBaru As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtKonfirmPw As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnBkLogin As Button
    Friend WithEvents btnRegis As Button
    Friend WithEvents txtPwBaru As TextBox
    Friend WithEvents txtUsrBaru As TextBox
    Friend WithEvents Label1 As Label

End Class
