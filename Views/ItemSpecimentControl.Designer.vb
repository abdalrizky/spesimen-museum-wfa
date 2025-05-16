<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ItemSpecimentControl
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
        lblSpecimentCommonName = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.Location = New Point(0, 327)
        Label2.Name = "Label2"
        Label2.Size = New Size(422, 40)
        Label2.TabIndex = 5
        Label2.Text = "scientific_name"
        Label2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblSpecimentCommonName
        ' 
        lblSpecimentCommonName.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSpecimentCommonName.Location = New Point(0, 272)
        lblSpecimentCommonName.Name = "lblSpecimentCommonName"
        lblSpecimentCommonName.Size = New Size(422, 55)
        lblSpecimentCommonName.TabIndex = 4
        lblSpecimentCommonName.Text = "common_name"
        lblSpecimentCommonName.TextAlign = ContentAlignment.TopCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(112, 55)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(200, 200)
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' ItemSpecimentControl
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Azure
        BorderStyle = BorderStyle.FixedSingle
        Controls.Add(Label2)
        Controls.Add(lblSpecimentCommonName)
        Controls.Add(PictureBox1)
        Margin = New Padding(10)
        MaximumSize = New Size(420, 420)
        MinimumSize = New Size(420, 420)
        Name = "ItemSpecimentControl"
        Size = New Size(418, 418)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents lblSpecimentCommonName As Label
    Friend WithEvents PictureBox1 As PictureBox

End Class
