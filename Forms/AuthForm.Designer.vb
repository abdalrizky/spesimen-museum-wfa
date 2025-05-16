<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AuthForm
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
        pnlContent = New Panel()
        SuspendLayout()
        ' 
        ' pnlContent
        ' 
        pnlContent.BackColor = Color.White
        pnlContent.Location = New Point(54, 63)
        pnlContent.Margin = New Padding(4, 6, 4, 6)
        pnlContent.Name = "pnlContent"
        pnlContent.Size = New Size(757, 835)
        pnlContent.TabIndex = 1
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.CornflowerBlue
        ClientSize = New Size(865, 960)
        Controls.Add(pnlContent)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 6, 4, 6)
        Name = "LoginForm"
        Opacity = 0.95R
        StartPosition = FormStartPosition.CenterScreen
        Text = "login"
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlContent As Panel
End Class
