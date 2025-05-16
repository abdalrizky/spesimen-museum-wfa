<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SpecimentFavoriteForm
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
        FlowLayoutPanel1 = New FlowLayoutPanel()
        ItemSpecimentControl1 = New ItemSpecimentControl()
        FlowLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(ItemSpecimentControl1)
        FlowLayoutPanel1.Dock = DockStyle.Fill
        FlowLayoutPanel1.Location = New Point(0, 0)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(1799, 804)
        FlowLayoutPanel1.TabIndex = 0
        ' 
        ' ItemSpecimentControl1
        ' 
        ItemSpecimentControl1.BackColor = Color.Azure
        ItemSpecimentControl1.BorderStyle = BorderStyle.FixedSingle
        ItemSpecimentControl1.Location = New Point(10, 10)
        ItemSpecimentControl1.Margin = New Padding(10)
        ItemSpecimentControl1.MaximumSize = New Size(420, 420)
        ItemSpecimentControl1.MinimumSize = New Size(420, 420)
        ItemSpecimentControl1.Name = "ItemSpecimentControl1"
        ItemSpecimentControl1.Size = New Size(420, 420)
        ItemSpecimentControl1.TabIndex = 0
        ' 
        ' SpecimentFavoriteForm
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1799, 804)
        Controls.Add(FlowLayoutPanel1)
        Name = "SpecimentFavoriteForm"
        Text = "SpecimentFavoriteForm"
        FlowLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents ItemSpecimentControl1 As ItemSpecimentControl
End Class
