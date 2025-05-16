<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginControl
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
        Label2 = New Label()
        Username = New Label()
        btnLogin = New Button()
        Label1 = New Label()
        btnToRegis = New Button()
        txtPw = New TextBox()
        txtUsrLogin = New TextBox()
        btnBkLandingPg = New Button()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(94, 349)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(134, 31)
        Label2.TabIndex = 31
        Label2.Text = "Password"
        ' 
        ' Username
        ' 
        Username.AutoSize = True
        Username.BackColor = Color.Transparent
        Username.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Username.Location = New Point(94, 243)
        Username.Margin = New Padding(4, 0, 4, 0)
        Username.Name = "Username"
        Username.Size = New Size(139, 31)
        Username.TabIndex = 30
        Username.Text = "Username"
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.Azure
        btnLogin.FlatAppearance.BorderColor = Color.LightSkyBlue
        btnLogin.FlatAppearance.BorderSize = 2
        btnLogin.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLogin.Location = New Point(94, 480)
        btnLogin.Margin = New Padding(4, 6, 4, 6)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(569, 96)
        btnLogin.TabIndex = 29
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Kristen ITC", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.CornflowerBlue
        Label1.Location = New Point(260, 93)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(260, 83)
        Label1.TabIndex = 27
        Label1.Text = "LOGIN"
        ' 
        ' btnToRegis
        ' 
        btnToRegis.BackColor = Color.WhiteSmoke
        btnToRegis.FlatAppearance.BorderColor = Color.LightSkyBlue
        btnToRegis.FlatAppearance.BorderSize = 2
        btnToRegis.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue
        btnToRegis.FlatStyle = FlatStyle.Flat
        btnToRegis.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnToRegis.Location = New Point(93, 675)
        btnToRegis.Margin = New Padding(4, 6, 4, 6)
        btnToRegis.Name = "btnToRegis"
        btnToRegis.Size = New Size(569, 96)
        btnToRegis.TabIndex = 25
        btnToRegis.Text = "Registrasi"
        btnToRegis.UseVisualStyleBackColor = False
        ' 
        ' txtPw
        ' 
        txtPw.BorderStyle = BorderStyle.FixedSingle
        txtPw.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPw.Location = New Point(94, 397)
        txtPw.Margin = New Padding(4, 6, 4, 6)
        txtPw.Name = "txtPw"
        txtPw.Size = New Size(568, 38)
        txtPw.TabIndex = 24
        txtPw.UseSystemPasswordChar = True
        ' 
        ' txtUsrLogin
        ' 
        txtUsrLogin.BorderStyle = BorderStyle.FixedSingle
        txtUsrLogin.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsrLogin.Location = New Point(94, 289)
        txtUsrLogin.Margin = New Padding(4, 6, 4, 6)
        txtUsrLogin.Name = "txtUsrLogin"
        txtUsrLogin.Size = New Size(568, 38)
        txtUsrLogin.TabIndex = 23
        ' 
        ' btnBkLandingPg
        ' 
        btnBkLandingPg.BackColor = Color.Azure
        btnBkLandingPg.FlatAppearance.BorderColor = Color.LightSkyBlue
        btnBkLandingPg.FlatAppearance.BorderSize = 2
        btnBkLandingPg.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue
        btnBkLandingPg.FlatStyle = FlatStyle.Flat
        btnBkLandingPg.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBkLandingPg.Location = New Point(30, 27)
        btnBkLandingPg.Margin = New Padding(4, 6, 4, 6)
        btnBkLandingPg.Name = "btnBkLandingPg"
        btnBkLandingPg.Size = New Size(180, 80)
        btnBkLandingPg.TabIndex = 26
        btnBkLandingPg.Text = "Kembali"
        btnBkLandingPg.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(260, 629)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(252, 31)
        Label3.TabIndex = 32
        Label3.Text = "Belum punya akun?"
        ' 
        ' LoginControl
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Username)
        Controls.Add(btnLogin)
        Controls.Add(Label1)
        Controls.Add(btnBkLandingPg)
        Controls.Add(btnToRegis)
        Controls.Add(txtPw)
        Controls.Add(txtUsrLogin)
        Name = "LoginControl"
        Size = New Size(757, 853)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Username As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnToRegis As Button
    Friend WithEvents txtPw As TextBox
    Friend WithEvents txtUsrLogin As TextBox
    Friend WithEvents btnBkLandingPg As Button
    Friend WithEvents Label3 As Label

End Class
