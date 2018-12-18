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
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.btnValue = New System.Windows.Forms.Button()
        Me.btnReference = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstOutput
        '
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.Location = New System.Drawing.Point(85, 12)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(223, 212)
        Me.lstOutput.TabIndex = 0
        '
        'btnValue
        '
        Me.btnValue.Location = New System.Drawing.Point(12, 291)
        Me.btnValue.Name = "btnValue"
        Me.btnValue.Size = New System.Drawing.Size(84, 23)
        Me.btnValue.TabIndex = 1
        Me.btnValue.Text = "Pass by value"
        Me.btnValue.UseVisualStyleBackColor = True
        '
        'btnReference
        '
        Me.btnReference.Location = New System.Drawing.Point(147, 291)
        Me.btnReference.Name = "btnReference"
        Me.btnReference.Size = New System.Drawing.Size(102, 23)
        Me.btnReference.TabIndex = 2
        Me.btnReference.Text = "Pass by reference"
        Me.btnReference.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(303, 291)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 339)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnReference)
        Me.Controls.Add(Me.btnValue)
        Me.Controls.Add(Me.lstOutput)
        Me.Name = "Form1"
        Me.Text = "Passing by Reference and Value"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstOutput As ListBox
    Friend WithEvents btnValue As Button
    Friend WithEvents btnReference As Button
    Friend WithEvents btnClose As Button
End Class
