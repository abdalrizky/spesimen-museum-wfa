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
        lvwSpeciments = New ListView()
        SuspendLayout()
        ' 
        ' lvwSpeciments
        ' 
        lvwSpeciments.BackColor = Color.Azure
        lvwSpeciments.Location = New Point(61, 148)
        lvwSpeciments.Name = "lvwSpeciments"
        lvwSpeciments.Size = New Size(1618, 596)
        lvwSpeciments.TabIndex = 0
        lvwSpeciments.UseCompatibleStateImageBehavior = False
        ' 
        ' SpecimentFavoriteForm
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightCyan
        ClientSize = New Size(1747, 804)
        Controls.Add(lvwSpeciments)
        Name = "SpecimentFavoriteForm"
        Text = "Spesimen Favorit"
        ResumeLayout(False)
    End Sub

    Friend WithEvents lvwSpeciments As ListView
End Class
