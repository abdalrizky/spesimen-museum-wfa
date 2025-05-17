<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SpecimentListForm
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
        components = New ComponentModel.Container()
        timerNowTime = New Timer(components)
        lblNowTime = New Label()
        lvwSpeciments = New ListView()
        SuspendLayout()
        ' 
        ' timerNowTime
        ' 
        timerNowTime.Enabled = True
        timerNowTime.Interval = 1000
        ' 
        ' lblNowTime
        ' 
        lblNowTime.Dock = DockStyle.Top
        lblNowTime.Font = New Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNowTime.Location = New Point(0, 0)
        lblNowTime.Name = "lblNowTime"
        lblNowTime.Padding = New Padding(0, 0, 20, 0)
        lblNowTime.Size = New Size(1611, 90)
        lblNowTime.TabIndex = 1
        lblNowTime.Text = "now_time"
        lblNowTime.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lvwSpeciments
        ' 
        lvwSpeciments.BackColor = Color.Azure
        lvwSpeciments.FullRowSelect = True
        lvwSpeciments.Location = New Point(63, 152)
        lvwSpeciments.Name = "lvwSpeciments"
        lvwSpeciments.Size = New Size(1474, 736)
        lvwSpeciments.TabIndex = 2
        lvwSpeciments.UseCompatibleStateImageBehavior = False
        lvwSpeciments.View = View.Details
        ' 
        ' SpecimentListForm
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightCyan
        ClientSize = New Size(1611, 961)
        Controls.Add(lvwSpeciments)
        Controls.Add(lblNowTime)
        Name = "SpecimentListForm"
        Text = "Spesimen"
        ResumeLayout(False)
    End Sub
    Friend WithEvents timerNowTime As Timer
    Friend WithEvents lblNowTime As Label
    Friend WithEvents lvwSpeciments As ListView
End Class
