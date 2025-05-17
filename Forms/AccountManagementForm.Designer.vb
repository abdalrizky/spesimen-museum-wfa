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
        txtSearch = New TextBox()
        SuspendLayout()
        ' 
        ' lvwUsers
        ' 
        lvwUsers.BackColor = Color.Azure
        lvwUsers.Dock = DockStyle.Bottom
        lvwUsers.FullRowSelect = True
        lvwUsers.Location = New Point(0, 120)
        lvwUsers.Name = "lvwUsers"
        lvwUsers.Size = New Size(888, 476)
        lvwUsers.TabIndex = 0
        lvwUsers.UseCompatibleStateImageBehavior = False
        lvwUsers.View = View.Details
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(25, 36)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Cari Username...."
        txtSearch.Size = New Size(833, 39)
        txtSearch.TabIndex = 11
        ' 
        ' AccountManagementForm
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightCyan
        ClientSize = New Size(888, 596)
        Controls.Add(txtSearch)
        Controls.Add(lvwUsers)
        Name = "AccountManagementForm"
        Text = "Manajemen Akun"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lvwUsers As ListView
    Friend WithEvents txtSearch As TextBox
End Class
