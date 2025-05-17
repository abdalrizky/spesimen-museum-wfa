<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VisitorMenuControl
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
        btnToViewSpeciments = New Button()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(btnLogout, 0, 2)
        TableLayoutPanel1.Controls.Add(btnToViewSpeciments, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.Size = New Size(656, 390)
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
        btnLogout.Location = New Point(20, 146)
        btnLogout.Margin = New Padding(20, 20, 20, 10)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(616, 96)
        btnLogout.TabIndex = 35
        btnLogout.Text = "Keluar dari Akun"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' btnToViewSpeciments
        ' 
        btnToViewSpeciments.AutoSize = True
        btnToViewSpeciments.BackColor = Color.Azure
        btnToViewSpeciments.Dock = DockStyle.Top
        btnToViewSpeciments.FlatAppearance.BorderColor = Color.LightSkyBlue
        btnToViewSpeciments.FlatAppearance.BorderSize = 2
        btnToViewSpeciments.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue
        btnToViewSpeciments.FlatStyle = FlatStyle.Flat
        btnToViewSpeciments.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnToViewSpeciments.Location = New Point(20, 20)
        btnToViewSpeciments.Margin = New Padding(20, 20, 20, 10)
        btnToViewSpeciments.Name = "btnToViewSpeciments"
        btnToViewSpeciments.Size = New Size(616, 96)
        btnToViewSpeciments.TabIndex = 32
        btnToViewSpeciments.Text = "Lihat Spesimen"
        btnToViewSpeciments.UseVisualStyleBackColor = False
        ' 
        ' VisitorMenuControl
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(TableLayoutPanel1)
        Name = "VisitorMenuControl"
        Size = New Size(656, 390)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnToViewSpeciments As Button
    Friend WithEvents btnLogout As Button

End Class
