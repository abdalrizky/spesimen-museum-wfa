<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SpecimentManagementForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SpecimentManagementForm))
        btnAdd = New Button()
        txtSearching = New TextBox()
        lvwSpeciments = New ListView()
        btnPrintSpecimentList = New Button()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        SuspendLayout()
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.Azure
        btnAdd.FlatAppearance.BorderColor = Color.LightSkyBlue
        btnAdd.FlatAppearance.BorderSize = 2
        btnAdd.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAdd.Location = New Point(46, 682)
        btnAdd.Margin = New Padding(5, 6, 5, 6)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(408, 96)
        btnAdd.TabIndex = 14
        btnAdd.Text = "Tambah Spesimen"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' txtSearching
        ' 
        txtSearching.Location = New Point(46, 56)
        txtSearching.Margin = New Padding(5, 6, 5, 6)
        txtSearching.Name = "txtSearching"
        txtSearching.PlaceholderText = "Cari...."
        txtSearching.Size = New Size(1258, 39)
        txtSearching.TabIndex = 13
        ' 
        ' lvwSpeciments
        ' 
        lvwSpeciments.BackColor = Color.Azure
        lvwSpeciments.FullRowSelect = True
        lvwSpeciments.Location = New Point(46, 136)
        lvwSpeciments.Name = "lvwSpeciments"
        lvwSpeciments.Size = New Size(1258, 504)
        lvwSpeciments.TabIndex = 15
        lvwSpeciments.UseCompatibleStateImageBehavior = False
        lvwSpeciments.View = View.Details
        ' 
        ' btnPrintSpecimentList
        ' 
        btnPrintSpecimentList.BackColor = Color.Azure
        btnPrintSpecimentList.FlatAppearance.BorderColor = Color.LightSkyBlue
        btnPrintSpecimentList.FlatAppearance.BorderSize = 2
        btnPrintSpecimentList.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue
        btnPrintSpecimentList.FlatStyle = FlatStyle.Flat
        btnPrintSpecimentList.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnPrintSpecimentList.Location = New Point(475, 682)
        btnPrintSpecimentList.Margin = New Padding(5, 6, 5, 6)
        btnPrintSpecimentList.Name = "btnPrintSpecimentList"
        btnPrintSpecimentList.Size = New Size(408, 96)
        btnPrintSpecimentList.TabIndex = 16
        btnPrintSpecimentList.Text = "Cetak Daftar Spesimen"
        btnPrintSpecimentList.UseVisualStyleBackColor = False
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' SpecimentManagementForm
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightCyan
        ClientSize = New Size(1359, 824)
        Controls.Add(btnPrintSpecimentList)
        Controls.Add(lvwSpeciments)
        Controls.Add(btnAdd)
        Controls.Add(txtSearching)
        Margin = New Padding(5, 6, 5, 6)
        Name = "SpecimentManagementForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Manajemen Spesimen"
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtSearching As TextBox
    Friend WithEvents lvwSpeciments As ListView
    Friend WithEvents btnPrintSpecimentList As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
