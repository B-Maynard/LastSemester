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
        Me.lblMathProblem = New System.Windows.Forms.Label()
        Me.btnShowAnswer = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblMathProblem
        '
        Me.lblMathProblem.AutoSize = True
        Me.lblMathProblem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMathProblem.Location = New System.Drawing.Point(111, 31)
        Me.lblMathProblem.Name = "lblMathProblem"
        Me.lblMathProblem.Size = New System.Drawing.Size(68, 16)
        Me.lblMathProblem.TabIndex = 0
        Me.lblMathProblem.Text = "18 + 64 ="
        '
        'btnShowAnswer
        '
        Me.btnShowAnswer.Location = New System.Drawing.Point(48, 81)
        Me.btnShowAnswer.Name = "btnShowAnswer"
        Me.btnShowAnswer.Size = New System.Drawing.Size(93, 23)
        Me.btnShowAnswer.TabIndex = 1
        Me.btnShowAnswer.Text = "Show Answer"
        Me.btnShowAnswer.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(189, 83)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswer.Location = New System.Drawing.Point(176, 31)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(16, 16)
        Me.lblAnswer.TabIndex = 3
        Me.lblAnswer.Text = "?"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 118)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnShowAnswer)
        Me.Controls.Add(Me.lblMathProblem)
        Me.Name = "Form1"
        Me.Text = "Math Tutor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMathProblem As Label
    Friend WithEvents btnShowAnswer As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblAnswer As Label
End Class
