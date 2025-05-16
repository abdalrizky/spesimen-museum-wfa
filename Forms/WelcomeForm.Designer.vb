<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WelcomeForm
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
        Panel1 = New Panel()
        Label1 = New Label()
        btnExit = New Button()
        btnViewSpeciments = New Button()
        btnMasuk = New Button()
        Label2 = New Label()
        pnlOverlay = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.CornflowerBlue
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(-47, -38)
        Panel1.Margin = New Padding(5, 6, 5, 6)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1396, 322)
        Panel1.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Monotype Corsiva", 30F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.WhiteSmoke
        Label1.Location = New Point(501, 126)
        Label1.Margin = New Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(385, 97)
        Label1.TabIndex = 0
        Label1.Text = "BioMuseum"
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.Azure
        btnExit.FlatAppearance.BorderColor = Color.LightSkyBlue
        btnExit.FlatAppearance.BorderSize = 2
        btnExit.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Microsoft Sans Serif", 9F)
        btnExit.Location = New Point(30, 1034)
        btnExit.Margin = New Padding(5, 6, 5, 6)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(174, 56)
        btnExit.TabIndex = 5
        btnExit.Text = "Keluar"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' btnViewSpeciments
        ' 
        btnViewSpeciments.BackColor = Color.Azure
        btnViewSpeciments.FlatAppearance.BorderColor = Color.LightSkyBlue
        btnViewSpeciments.FlatAppearance.BorderSize = 2
        btnViewSpeciments.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue
        btnViewSpeciments.FlatStyle = FlatStyle.Flat
        btnViewSpeciments.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnViewSpeciments.Location = New Point(314, 582)
        btnViewSpeciments.Margin = New Padding(5, 6, 5, 6)
        btnViewSpeciments.Name = "btnViewSpeciments"
        btnViewSpeciments.Size = New Size(664, 180)
        btnViewSpeciments.TabIndex = 4
        btnViewSpeciments.Text = "Lihat Spesimen"
        btnViewSpeciments.UseVisualStyleBackColor = False
        ' 
        ' btnMasuk
        ' 
        btnMasuk.BackColor = Color.Azure
        btnMasuk.FlatAppearance.BorderColor = Color.LightSkyBlue
        btnMasuk.FlatAppearance.BorderSize = 2
        btnMasuk.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue
        btnMasuk.FlatStyle = FlatStyle.Flat
        btnMasuk.Font = New Font("Microsoft Sans Serif", 9F)
        btnMasuk.Location = New Point(1087, 314)
        btnMasuk.Margin = New Padding(5, 6, 5, 6)
        btnMasuk.Name = "btnMasuk"
        btnMasuk.Size = New Size(174, 56)
        btnMasuk.TabIndex = 7
        btnMasuk.Text = "Masuk Akun"
        btnMasuk.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(131, 515)
        Label2.Name = "Label2"
        Label2.Size = New Size(1051, 45)
        Label2.TabIndex = 8
        Label2.Text = "Bagi pengunjung yang tidak memiliki akun, silakan klik tombol di bawah."
        ' 
        ' pnlOverlay
        ' 
        pnlOverlay.BackColor = Color.FromArgb(CByte(100), CByte(0), CByte(0), CByte(0))
        pnlOverlay.Dock = DockStyle.Fill
        pnlOverlay.Location = New Point(0, 0)
        pnlOverlay.Name = "pnlOverlay"
        pnlOverlay.Size = New Size(1300, 1120)
        pnlOverlay.TabIndex = 9
        pnlOverlay.Visible = False
        ' 
        ' WelcomeForm
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightCyan
        ClientSize = New Size(1300, 1120)
        Controls.Add(Label2)
        Controls.Add(btnMasuk)
        Controls.Add(Panel1)
        Controls.Add(btnExit)
        Controls.Add(btnViewSpeciments)
        Controls.Add(pnlOverlay)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(5, 6, 5, 6)
        MaximizeBox = False
        Name = "WelcomeForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "BioMuseum"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnViewSpeciments As Button
    Friend WithEvents btnMasuk As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents pnlOverlay As Panel
End Class
