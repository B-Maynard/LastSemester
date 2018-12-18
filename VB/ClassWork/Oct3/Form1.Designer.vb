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
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSubtract = New System.Windows.Forms.Button()
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.btnMultiply = New System.Windows.Forms.Button()
        Me.btnMod = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnDemo = New System.Windows.Forms.Button()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtNum1
        '
        Me.txtNum1.Location = New System.Drawing.Point(556, 73)
        Me.txtNum1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(196, 31)
        Me.txtNum1.TabIndex = 0
        '
        'txtNum2
        '
        Me.txtNum2.Location = New System.Drawing.Point(556, 167)
        Me.txtNum2.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(196, 31)
        Me.txtNum2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(148, 79)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Please enter a number:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(148, 173)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(235, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Please enter a number:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(220, 262)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "The results are:"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(230, 331)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(150, 44)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSubtract
        '
        Me.btnSubtract.Location = New System.Drawing.Point(230, 408)
        Me.btnSubtract.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnSubtract.Name = "btnSubtract"
        Me.btnSubtract.Size = New System.Drawing.Size(150, 44)
        Me.btnSubtract.TabIndex = 6
        Me.btnSubtract.Text = "Subtract"
        Me.btnSubtract.UseVisualStyleBackColor = True
        '
        'btnDivide
        '
        Me.btnDivide.Location = New System.Drawing.Point(230, 481)
        Me.btnDivide.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(150, 44)
        Me.btnDivide.TabIndex = 7
        Me.btnDivide.Text = "Divide"
        Me.btnDivide.UseVisualStyleBackColor = True
        '
        'btnMultiply
        '
        Me.btnMultiply.Location = New System.Drawing.Point(556, 331)
        Me.btnMultiply.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnMultiply.Name = "btnMultiply"
        Me.btnMultiply.Size = New System.Drawing.Size(150, 44)
        Me.btnMultiply.TabIndex = 8
        Me.btnMultiply.Text = "Multiply"
        Me.btnMultiply.UseVisualStyleBackColor = True
        '
        'btnMod
        '
        Me.btnMod.Location = New System.Drawing.Point(556, 408)
        Me.btnMod.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(150, 44)
        Me.btnMod.TabIndex = 9
        Me.btnMod.Text = "Modulus"
        Me.btnMod.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(392, 579)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(150, 44)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnDemo
        '
        Me.btnDemo.Location = New System.Drawing.Point(556, 481)
        Me.btnDemo.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnDemo.Name = "btnDemo"
        Me.btnDemo.Size = New System.Drawing.Size(150, 44)
        Me.btnDemo.TabIndex = 11
        Me.btnDemo.Text = "Demo"
        Me.btnDemo.UseVisualStyleBackColor = True
        '
        'lblResults
        '
        Me.lblResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResults.Location = New System.Drawing.Point(556, 254)
        Me.lblResults.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(200, 40)
        Me.lblResults.TabIndex = 12
        Me.lblResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(910, 646)
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(Me.btnDemo)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnMod)
        Me.Controls.Add(Me.btnMultiply)
        Me.Controls.Add(Me.btnDivide)
        Me.Controls.Add(Me.btnSubtract)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNum2)
        Me.Controls.Add(Me.txtNum1)
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNum1 As TextBox
    Friend WithEvents txtNum2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSubtract As Button
    Friend WithEvents btnDivide As Button
    Friend WithEvents btnMultiply As Button
    Friend WithEvents btnMod As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnDemo As Button
    Friend WithEvents lblResults As Label
End Class
