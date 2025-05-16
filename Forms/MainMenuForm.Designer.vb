<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenuForm
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
        SplitContainer1 = New SplitContainer()
        Label1 = New Label()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.SuspendLayout()
        SuspendLayout()
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.Location = New Point(0, 0)
        SplitContainer1.Name = "SplitContainer1"
        SplitContainer1.Orientation = Orientation.Horizontal
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(Label1)
        SplitContainer1.Size = New Size(698, 854)
        SplitContainer1.SplitterDistance = 290
        SplitContainer1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(698, 290)
        Label1.TabIndex = 0
        Label1.Text = "Selamat datang, Admin"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' MainMenuForm
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightCyan
        ClientSize = New Size(698, 854)
        Controls.Add(SplitContainer1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "MainMenuForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Menu Utama"
        SplitContainer1.Panel1.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Label1 As Label
End Class
