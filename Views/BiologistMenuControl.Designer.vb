<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BiologistMenuControl
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
        TableLayoutPanel1 = New TableLayoutPanel()
        btnLogout = New Button()
        btnToSpecimentCheckHistory = New Button()
        btnToSpecimentCheckRequest = New Button()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(btnLogout, 0, 2)
        TableLayoutPanel1.Controls.Add(btnToSpecimentCheckHistory, 0, 1)
        TableLayoutPanel1.Controls.Add(btnToSpecimentCheckRequest, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.Size = New Size(698, 392)
        TableLayoutPanel1.TabIndex = 0
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
        btnLogout.Location = New Point(20, 272)
        btnLogout.Margin = New Padding(20, 20, 20, 10)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(658, 96)
        btnLogout.TabIndex = 35
        btnLogout.Text = "Keluar dari Akun"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' btnToSpecimentCheckHistory
        ' 
        btnToSpecimentCheckHistory.AutoSize = True
        btnToSpecimentCheckHistory.BackColor = Color.Azure
        btnToSpecimentCheckHistory.Dock = DockStyle.Top
        btnToSpecimentCheckHistory.FlatAppearance.BorderColor = Color.LightSkyBlue
        btnToSpecimentCheckHistory.FlatAppearance.BorderSize = 2
        btnToSpecimentCheckHistory.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue
        btnToSpecimentCheckHistory.FlatStyle = FlatStyle.Flat
        btnToSpecimentCheckHistory.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnToSpecimentCheckHistory.Location = New Point(20, 146)
        btnToSpecimentCheckHistory.Margin = New Padding(20, 20, 20, 10)
        btnToSpecimentCheckHistory.Name = "btnToSpecimentCheckHistory"
        btnToSpecimentCheckHistory.Size = New Size(658, 96)
        btnToSpecimentCheckHistory.TabIndex = 34
        btnToSpecimentCheckHistory.Text = "Riwayat Pemeriksaan Spesimen"
        btnToSpecimentCheckHistory.UseVisualStyleBackColor = False
        ' 
        ' btnToSpecimentCheckRequest
        ' 
        btnToSpecimentCheckRequest.AutoSize = True
        btnToSpecimentCheckRequest.BackColor = Color.Azure
        btnToSpecimentCheckRequest.Dock = DockStyle.Top
        btnToSpecimentCheckRequest.FlatAppearance.BorderColor = Color.LightSkyBlue
        btnToSpecimentCheckRequest.FlatAppearance.BorderSize = 2
        btnToSpecimentCheckRequest.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue
        btnToSpecimentCheckRequest.FlatStyle = FlatStyle.Flat
        btnToSpecimentCheckRequest.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnToSpecimentCheckRequest.Location = New Point(20, 20)
        btnToSpecimentCheckRequest.Margin = New Padding(20, 20, 20, 10)
        btnToSpecimentCheckRequest.Name = "btnToSpecimentCheckRequest"
        btnToSpecimentCheckRequest.Size = New Size(658, 96)
        btnToSpecimentCheckRequest.TabIndex = 33
        btnToSpecimentCheckRequest.Text = "Permintaan Pemeriksaan Spesimen"
        btnToSpecimentCheckRequest.UseVisualStyleBackColor = False
        ' 
        ' BiologistMenuControl
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(TableLayoutPanel1)
        Name = "BiologistMenuControl"
        Size = New Size(698, 392)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnToSpecimentCheckHistory As Button
    Friend WithEvents btnToSpecimentCheckRequest As Button
    Friend WithEvents btnLogout As Button

End Class
