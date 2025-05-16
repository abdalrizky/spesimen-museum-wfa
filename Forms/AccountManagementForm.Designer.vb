<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountManagementForm
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
        lvwUsers = New ListView()
        btnCreateBiologistAccount = New Button()
        TextBox1 = New TextBox()
        SuspendLayout()
        ' 
        ' lvwUsers
        ' 
        lvwUsers.BackColor = Color.Azure
        lvwUsers.Dock = DockStyle.Bottom
        lvwUsers.FullRowSelect = True
        lvwUsers.Location = New Point(0, 184)
        lvwUsers.Name = "lvwUsers"
        lvwUsers.Size = New Size(888, 412)
        lvwUsers.TabIndex = 0
        lvwUsers.UseCompatibleStateImageBehavior = False
        lvwUsers.View = View.Details
        ' 
        ' btnCreateBiologistAccount
        ' 
        btnCreateBiologistAccount.BackColor = Color.Azure
        btnCreateBiologistAccount.FlatAppearance.BorderColor = Color.LightSkyBlue
        btnCreateBiologistAccount.FlatAppearance.BorderSize = 2
        btnCreateBiologistAccount.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue
        btnCreateBiologistAccount.FlatStyle = FlatStyle.Flat
        btnCreateBiologistAccount.Font = New Font("Microsoft Sans Serif", 9F)
        btnCreateBiologistAccount.Location = New Point(25, 33)
        btnCreateBiologistAccount.Margin = New Padding(5, 6, 5, 6)
        btnCreateBiologistAccount.Name = "btnCreateBiologistAccount"
        btnCreateBiologistAccount.Size = New Size(833, 56)
        btnCreateBiologistAccount.TabIndex = 10
        btnCreateBiologistAccount.Text = "Buat Akun Ahli Biologi"
        btnCreateBiologistAccount.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(25, 128)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Cari Username...."
        TextBox1.Size = New Size(833, 39)
        TextBox1.TabIndex = 11
        ' 
        ' AccountManagementForm
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightCyan
        ClientSize = New Size(888, 596)
        Controls.Add(TextBox1)
        Controls.Add(btnCreateBiologistAccount)
        Controls.Add(lvwUsers)
        Name = "AccountManagementForm"
        Text = "Manajemen Akun"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lvwUsers As ListView
    Friend WithEvents btnCreateBiologistAccount As Button
    Friend WithEvents TextBox1 As TextBox
End Class
