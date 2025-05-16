<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateBiologistAccountForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Label1 = New Label()
        txtUsername = New TextBox()
        Label2 = New Label()
        txtPassword = New TextBox()
        btnSave = New Button()
        btnCancel = New Button()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(41, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(121, 32)
        Label1.TabIndex = 0
        Label1.Text = "Username"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(195, 44)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(376, 39)
        txtUsername.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(41, 124)
        Label2.Name = "Label2"
        Label2.Size = New Size(111, 32)
        Label2.TabIndex = 2
        Label2.Text = "Password"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(195, 124)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(376, 39)
        txtPassword.TabIndex = 3
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.Azure
        btnSave.FlatAppearance.BorderColor = Color.LightSkyBlue
        btnSave.FlatAppearance.BorderSize = 2
        btnSave.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Microsoft Sans Serif", 9F)
        btnSave.Location = New Point(213, 239)
        btnSave.Margin = New Padding(5, 6, 5, 6)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(174, 56)
        btnSave.TabIndex = 13
        btnSave.Text = "Simpan"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.White
        btnCancel.FlatAppearance.BorderColor = Color.LightSkyBlue
        btnCancel.FlatAppearance.BorderSize = 2
        btnCancel.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Microsoft Sans Serif", 9F)
        btnCancel.Location = New Point(397, 239)
        btnCancel.Margin = New Padding(5, 6, 5, 6)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(174, 56)
        btnCancel.TabIndex = 12
        btnCancel.Text = "Batal"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = SystemColors.AppWorkspace
        Label3.Location = New Point(195, 173)
        Label3.Name = "Label3"
        Label3.Size = New Size(228, 32)
        Label3.TabIndex = 14
        Label3.Text = "*Minimal 8 karakter."
        ' 
        ' CreateBiologistAccount
        ' 
        AcceptButton = btnSave
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightCyan
        CancelButton = btnCancel
        ClientSize = New Size(630, 328)
        Controls.Add(Label3)
        Controls.Add(btnSave)
        Controls.Add(btnCancel)
        Controls.Add(txtPassword)
        Controls.Add(Label2)
        Controls.Add(txtUsername)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "CreateBiologistAccount"
        Text = "Buat Akun Ahli Biologi"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label3 As Label
End Class
