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
        FlowLayoutPanel1 = New FlowLayoutPanel()
        ItemSpecimentControl1 = New ItemSpecimentControl()
        ItemSpecimentControl2 = New ItemSpecimentControl()
        ItemSpecimentControl3 = New ItemSpecimentControl()
        ItemSpecimentControl4 = New ItemSpecimentControl()
        ItemSpecimentControl5 = New ItemSpecimentControl()
        ItemSpecimentControl6 = New ItemSpecimentControl()
        ItemSpecimentControl7 = New ItemSpecimentControl()
        ItemSpecimentControl8 = New ItemSpecimentControl()
        timerNowTime = New Timer(components)
        lblNowTime = New Label()
        FlowLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.AutoScroll = True
        FlowLayoutPanel1.Controls.Add(ItemSpecimentControl1)
        FlowLayoutPanel1.Controls.Add(ItemSpecimentControl2)
        FlowLayoutPanel1.Controls.Add(ItemSpecimentControl3)
        FlowLayoutPanel1.Controls.Add(ItemSpecimentControl4)
        FlowLayoutPanel1.Controls.Add(ItemSpecimentControl5)
        FlowLayoutPanel1.Controls.Add(ItemSpecimentControl6)
        FlowLayoutPanel1.Controls.Add(ItemSpecimentControl7)
        FlowLayoutPanel1.Controls.Add(ItemSpecimentControl8)
        FlowLayoutPanel1.Dock = DockStyle.Bottom
        FlowLayoutPanel1.Location = New Point(0, 236)
        FlowLayoutPanel1.Margin = New Padding(0)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(1799, 938)
        FlowLayoutPanel1.TabIndex = 0
        ' 
        ' ItemSpecimentControl1
        ' 
        ItemSpecimentControl1.BorderStyle = BorderStyle.FixedSingle
        ItemSpecimentControl1.Location = New Point(10, 10)
        ItemSpecimentControl1.Margin = New Padding(10)
        ItemSpecimentControl1.MaximumSize = New Size(420, 420)
        ItemSpecimentControl1.MinimumSize = New Size(420, 420)
        ItemSpecimentControl1.Name = "ItemSpecimentControl1"
        ItemSpecimentControl1.Size = New Size(420, 420)
        ItemSpecimentControl1.TabIndex = 0
        ' 
        ' ItemSpecimentControl2
        ' 
        ItemSpecimentControl2.BorderStyle = BorderStyle.FixedSingle
        ItemSpecimentControl2.Location = New Point(450, 10)
        ItemSpecimentControl2.Margin = New Padding(10)
        ItemSpecimentControl2.MaximumSize = New Size(420, 420)
        ItemSpecimentControl2.MinimumSize = New Size(420, 420)
        ItemSpecimentControl2.Name = "ItemSpecimentControl2"
        ItemSpecimentControl2.Size = New Size(420, 420)
        ItemSpecimentControl2.TabIndex = 1
        ' 
        ' ItemSpecimentControl3
        ' 
        ItemSpecimentControl3.BorderStyle = BorderStyle.FixedSingle
        ItemSpecimentControl3.Location = New Point(890, 10)
        ItemSpecimentControl3.Margin = New Padding(10)
        ItemSpecimentControl3.MaximumSize = New Size(420, 420)
        ItemSpecimentControl3.MinimumSize = New Size(420, 420)
        ItemSpecimentControl3.Name = "ItemSpecimentControl3"
        ItemSpecimentControl3.Size = New Size(420, 420)
        ItemSpecimentControl3.TabIndex = 2
        ' 
        ' ItemSpecimentControl4
        ' 
        ItemSpecimentControl4.BorderStyle = BorderStyle.FixedSingle
        ItemSpecimentControl4.Location = New Point(1330, 10)
        ItemSpecimentControl4.Margin = New Padding(10)
        ItemSpecimentControl4.MaximumSize = New Size(420, 420)
        ItemSpecimentControl4.MinimumSize = New Size(420, 420)
        ItemSpecimentControl4.Name = "ItemSpecimentControl4"
        ItemSpecimentControl4.Size = New Size(420, 420)
        ItemSpecimentControl4.TabIndex = 3
        ' 
        ' ItemSpecimentControl5
        ' 
        ItemSpecimentControl5.BorderStyle = BorderStyle.FixedSingle
        ItemSpecimentControl5.Location = New Point(10, 450)
        ItemSpecimentControl5.Margin = New Padding(10)
        ItemSpecimentControl5.MaximumSize = New Size(420, 420)
        ItemSpecimentControl5.MinimumSize = New Size(420, 420)
        ItemSpecimentControl5.Name = "ItemSpecimentControl5"
        ItemSpecimentControl5.Size = New Size(420, 420)
        ItemSpecimentControl5.TabIndex = 4
        ' 
        ' ItemSpecimentControl6
        ' 
        ItemSpecimentControl6.BorderStyle = BorderStyle.FixedSingle
        ItemSpecimentControl6.Location = New Point(450, 450)
        ItemSpecimentControl6.Margin = New Padding(10)
        ItemSpecimentControl6.MaximumSize = New Size(420, 420)
        ItemSpecimentControl6.MinimumSize = New Size(420, 420)
        ItemSpecimentControl6.Name = "ItemSpecimentControl6"
        ItemSpecimentControl6.Size = New Size(420, 420)
        ItemSpecimentControl6.TabIndex = 5
        ' 
        ' ItemSpecimentControl7
        ' 
        ItemSpecimentControl7.BorderStyle = BorderStyle.FixedSingle
        ItemSpecimentControl7.Location = New Point(890, 450)
        ItemSpecimentControl7.Margin = New Padding(10)
        ItemSpecimentControl7.MaximumSize = New Size(420, 420)
        ItemSpecimentControl7.MinimumSize = New Size(420, 420)
        ItemSpecimentControl7.Name = "ItemSpecimentControl7"
        ItemSpecimentControl7.Size = New Size(420, 420)
        ItemSpecimentControl7.TabIndex = 6
        ' 
        ' ItemSpecimentControl8
        ' 
        ItemSpecimentControl8.BorderStyle = BorderStyle.FixedSingle
        ItemSpecimentControl8.Location = New Point(1330, 450)
        ItemSpecimentControl8.Margin = New Padding(10)
        ItemSpecimentControl8.MaximumSize = New Size(420, 420)
        ItemSpecimentControl8.MinimumSize = New Size(420, 420)
        ItemSpecimentControl8.Name = "ItemSpecimentControl8"
        ItemSpecimentControl8.Size = New Size(420, 420)
        ItemSpecimentControl8.TabIndex = 7
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
        lblNowTime.Size = New Size(1799, 90)
        lblNowTime.TabIndex = 1
        lblNowTime.Text = "now_time"
        lblNowTime.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' SpecimentListForm
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightCyan
        ClientSize = New Size(1799, 1174)
        Controls.Add(lblNowTime)
        Controls.Add(FlowLayoutPanel1)
        Name = "SpecimentListForm"
        Text = "Spesimen (Tamu)"
        FlowLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents timerNowTime As Timer
    Friend WithEvents lblNowTime As Label
    Friend WithEvents ItemSpecimentControl1 As ItemSpecimentControl
    Friend WithEvents ItemSpecimentControl2 As ItemSpecimentControl
    Friend WithEvents ItemSpecimentControl3 As ItemSpecimentControl
    Friend WithEvents ItemSpecimentControl4 As ItemSpecimentControl
    Friend WithEvents ItemSpecimentControl5 As ItemSpecimentControl
    Friend WithEvents ItemSpecimentControl6 As ItemSpecimentControl
    Friend WithEvents ItemSpecimentControl7 As ItemSpecimentControl
    Friend WithEvents ItemSpecimentControl8 As ItemSpecimentControl
End Class
