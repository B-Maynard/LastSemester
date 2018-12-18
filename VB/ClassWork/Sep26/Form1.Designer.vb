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
        Me.txtLength = New System.Windows.Forms.TextBox()
        Me.txtWidth = New System.Windows.Forms.TextBox()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblPerimeter = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(61, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Length of Room:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(132, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Area is:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(71, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Width of Room:"
        '
        'txtLength
        '
        Me.txtLength.Location = New System.Drawing.Point(247, 45)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(100, 20)
        Me.txtLength.TabIndex = 3
        '
        'txtWidth
        '
        Me.txtWidth.Location = New System.Drawing.Point(247, 103)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(100, 20)
        Me.txtWidth.TabIndex = 4
        '
        'lblArea
        '
        Me.lblArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblArea.Location = New System.Drawing.Point(247, 177)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(100, 23)
        Me.lblArea.TabIndex = 5
        Me.lblArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalc
        '
        Me.btnCalc.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.Location = New System.Drawing.Point(23, 278)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(100, 62)
        Me.btnCalc.TabIndex = 6
        Me.btnCalc.Text = "Calculate Area"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(325, 300)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 40)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(91, 232)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 24)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Perimeter is:"
        '
        'lblPerimeter
        '
        Me.lblPerimeter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPerimeter.Location = New System.Drawing.Point(247, 233)
        Me.lblPerimeter.Name = "lblPerimeter"
        Me.lblPerimeter.Size = New System.Drawing.Size(100, 23)
        Me.lblPerimeter.TabIndex = 9
        Me.lblPerimeter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(178, 278)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 62)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Calculate Perimeter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 352)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblPerimeter)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblArea)
        Me.Controls.Add(Me.txtWidth)
        Me.Controls.Add(Me.txtLength)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Area Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLength As TextBox
    Friend WithEvents txtWidth As TextBox
    Friend WithEvents lblArea As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lblPerimeter As Label
    Friend WithEvents Button1 As Button
End Class
