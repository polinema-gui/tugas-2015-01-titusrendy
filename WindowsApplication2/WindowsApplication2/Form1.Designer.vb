<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormWarna
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
        Me.Change = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Change
        '
        Me.Change.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Change.Location = New System.Drawing.Point(168, 213)
        Me.Change.Name = "Change"
        Me.Change.Size = New System.Drawing.Size(94, 28)
        Me.Change.TabIndex = 0
        Me.Change.Text = "Change"
        Me.Change.UseVisualStyleBackColor = True
        '
        'FormWarna
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Change)
        Me.Name = "FormWarna"
        Me.Text = "FormWarna"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Change As System.Windows.Forms.Button

End Class
