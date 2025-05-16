<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminMenuControl
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
        btnToCollectionStorageManagement = New Button()
        btnToSpecimentManagement = New Button()
        btnLogout = New Button()
        btnToAccountManagement = New Button()
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnToCollectionStorageManagement
        ' 
        btnToCollectionStorageManagement.BackColor = Color.Azure
        btnToCollectionStorageManagement.Dock = DockStyle.Top
        btnToCollectionStorageManagement.FlatAppearance.BorderColor = Color.LightSkyBlue
        btnToCollectionStorageManagement.FlatAppearance.BorderSize = 2
        btnToCollectionStorageManagement.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue
        btnToCollectionStorageManagement.FlatStyle = FlatStyle.Flat
        btnToCollectionStorageManagement.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnToCollectionStorageManagement.Location = New Point(20, 272)
        btnToCollectionStorageManagement.Margin = New Padding(20, 20, 20, 10)
        btnToCollectionStorageManagement.Name = "btnToCollectionStorageManagement"
        btnToCollectionStorageManagement.Size = New Size(568, 96)
        btnToCollectionStorageManagement.TabIndex = 33
        btnToCollectionStorageManagement.Text = "Manajemen Ruang Penyimpanan"
        btnToCollectionStorageManagement.UseVisualStyleBackColor = False
        ' 
        ' btnToSpecimentManagement
        ' 
        btnToSpecimentManagement.BackColor = Color.Azure
        btnToSpecimentManagement.Dock = DockStyle.Top
        btnToSpecimentManagement.FlatAppearance.BorderColor = Color.LightSkyBlue
        btnToSpecimentManagement.FlatAppearance.BorderSize = 2
        btnToSpecimentManagement.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue
        btnToSpecimentManagement.FlatStyle = FlatStyle.Flat
        btnToSpecimentManagement.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnToSpecimentManagement.Location = New Point(20, 146)
        btnToSpecimentManagement.Margin = New Padding(20, 20, 20, 10)
        btnToSpecimentManagement.Name = "btnToSpecimentManagement"
        btnToSpecimentManagement.Size = New Size(568, 96)
        btnToSpecimentManagement.TabIndex = 32
        btnToSpecimentManagement.Text = "Manajemen Spesimen"
        btnToSpecimentManagement.UseVisualStyleBackColor = False
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.White
        btnLogout.Dock = DockStyle.Top
        btnLogout.FlatAppearance.BorderColor = Color.LightSkyBlue
        btnLogout.FlatAppearance.BorderSize = 2
        btnLogout.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLogout.Location = New Point(20, 398)
        btnLogout.Margin = New Padding(20, 20, 20, 10)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(568, 96)
        btnLogout.TabIndex = 34
        btnLogout.Text = "Keluar dari Akun"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' btnToAccountManagement
        ' 
        btnToAccountManagement.AutoSize = True
        btnToAccountManagement.BackColor = Color.Azure
        btnToAccountManagement.Dock = DockStyle.Top
        btnToAccountManagement.FlatAppearance.BorderColor = Color.LightSkyBlue
        btnToAccountManagement.FlatAppearance.BorderSize = 2
        btnToAccountManagement.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue
        btnToAccountManagement.FlatStyle = FlatStyle.Flat
        btnToAccountManagement.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnToAccountManagement.Location = New Point(20, 20)
        btnToAccountManagement.Margin = New Padding(20, 20, 20, 10)
        btnToAccountManagement.Name = "btnToAccountManagement"
        btnToAccountManagement.Size = New Size(568, 96)
        btnToAccountManagement.TabIndex = 31
        btnToAccountManagement.Text = "Manajemen Akun"
        btnToAccountManagement.UseVisualStyleBackColor = False
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(btnToAccountManagement, 0, 0)
        TableLayoutPanel1.Controls.Add(btnLogout, 0, 3)
        TableLayoutPanel1.Controls.Add(btnToSpecimentManagement, 0, 1)
        TableLayoutPanel1.Controls.Add(btnToCollectionStorageManagement, 0, 2)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 4
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.Size = New Size(608, 520)
        TableLayoutPanel1.TabIndex = 35
        ' 
        ' AdminMenuControl
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(TableLayoutPanel1)
        Name = "AdminMenuControl"
        Size = New Size(608, 520)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnToCollectionStorageManagement As Button
    Friend WithEvents btnToSpecimentManagement As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnToAccountManagement As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel

End Class
