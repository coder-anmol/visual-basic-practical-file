<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.CountLabel = New System.Windows.Forms.Label()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.IncrementButton = New System.Windows.Forms.Button()
        Me.DecrementButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CountLabel
        '
        Me.CountLabel.AutoSize = True
        Me.CountLabel.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CountLabel.Location = New System.Drawing.Point(123, 39)
        Me.CountLabel.Name = "CountLabel"
        Me.CountLabel.Size = New System.Drawing.Size(52, 62)
        Me.CountLabel.TabIndex = 0
        Me.CountLabel.Text = "0"
        Me.CountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ResetButton
        '
        Me.ResetButton.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ResetButton.Location = New System.Drawing.Point(47, 187)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(202, 60)
        Me.ResetButton.TabIndex = 1
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'IncrementButton
        '
        Me.IncrementButton.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.IncrementButton.Location = New System.Drawing.Point(47, 121)
        Me.IncrementButton.Name = "IncrementButton"
        Me.IncrementButton.Size = New System.Drawing.Size(202, 60)
        Me.IncrementButton.TabIndex = 2
        Me.IncrementButton.Text = "Increment"
        Me.IncrementButton.UseVisualStyleBackColor = True
        '
        'DecrementButton
        '
        Me.DecrementButton.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DecrementButton.Location = New System.Drawing.Point(47, 253)
        Me.DecrementButton.Name = "DecrementButton"
        Me.DecrementButton.Size = New System.Drawing.Size(202, 60)
        Me.DecrementButton.TabIndex = 3
        Me.DecrementButton.Text = "Decrement"
        Me.DecrementButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(295, 361)
        Me.Controls.Add(Me.DecrementButton)
        Me.Controls.Add(Me.IncrementButton)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.CountLabel)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CountLabel As Label
    Friend WithEvents ResetButton As Button
    Friend WithEvents IncrementButton As Button
    Friend WithEvents DecrementButton As Button
End Class
