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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIntegerA = New System.Windows.Forms.TextBox()
        Me.txtIntegerB = New System.Windows.Forms.TextBox()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.btnCompare = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(116, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Two Integers"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(76, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "A:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(194, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "B:"
        '
        'txtIntegerA
        '
        Me.txtIntegerA.Location = New System.Drawing.Point(104, 85)
        Me.txtIntegerA.Name = "txtIntegerA"
        Me.txtIntegerA.Size = New System.Drawing.Size(77, 20)
        Me.txtIntegerA.TabIndex = 3
        '
        'txtIntegerB
        '
        Me.txtIntegerB.Location = New System.Drawing.Point(222, 85)
        Me.txtIntegerB.Name = "txtIntegerB"
        Me.txtIntegerB.Size = New System.Drawing.Size(77, 20)
        Me.txtIntegerB.TabIndex = 4
        '
        'lblAnswer
        '
        Me.lblAnswer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAnswer.Location = New System.Drawing.Point(35, 143)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(310, 23)
        Me.lblAnswer.TabIndex = 5
        Me.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCompare
        '
        Me.btnCompare.Location = New System.Drawing.Point(104, 194)
        Me.btnCompare.Name = "btnCompare"
        Me.btnCompare.Size = New System.Drawing.Size(75, 23)
        Me.btnCompare.TabIndex = 6
        Me.btnCompare.Text = "Compare"
        Me.btnCompare.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(224, 194)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 236)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCompare)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.txtIntegerB)
        Me.Controls.Add(Me.txtIntegerA)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Larger and Smaller"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtIntegerA As TextBox
    Friend WithEvents txtIntegerB As TextBox
    Friend WithEvents lblAnswer As Label
    Friend WithEvents btnCompare As Button
    Friend WithEvents btnExit As Button
End Class
