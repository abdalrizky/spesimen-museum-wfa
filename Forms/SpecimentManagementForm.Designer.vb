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
        btnAdd = New Button()
        txtSearching = New TextBox()
        lvwSpeciments = New ListView()
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
        ' SpecimentManagementForm
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightCyan
        ClientSize = New Size(1359, 824)
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
End Class
