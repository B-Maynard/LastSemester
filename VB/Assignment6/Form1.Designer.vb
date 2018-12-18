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
        Me.radSeconds = New System.Windows.Forms.RadioButton()
        Me.radMinutes = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblConversion = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'radSeconds
        '
        Me.radSeconds.AutoSize = True
        Me.radSeconds.Location = New System.Drawing.Point(58, 146)
        Me.radSeconds.Name = "radSeconds"
        Me.radSeconds.Size = New System.Drawing.Size(67, 17)
        Me.radSeconds.TabIndex = 0
        Me.radSeconds.TabStop = True
        Me.radSeconds.Text = "Seconds"
        Me.radSeconds.UseVisualStyleBackColor = True
        '
        'radMinutes
        '
        Me.radMinutes.AutoSize = True
        Me.radMinutes.Location = New System.Drawing.Point(192, 146)
        Me.radMinutes.Name = "radMinutes"
        Me.radMinutes.Size = New System.Drawing.Size(62, 17)
        Me.radMinutes.TabIndex = 1
        Me.radMinutes.TabStop = True
        Me.radMinutes.Text = "Minutes"
        Me.radMinutes.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtInput)
        Me.GroupBox1.Controls.Add(Me.radSeconds)
        Me.GroupBox1.Controls.Add(Me.radMinutes)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(54, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(314, 187)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enter a number of days to convert to either seconds or minutes:"
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(92, 68)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(100, 20)
        Me.txtInput.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 301)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Conversion:"
        '
        'lblConversion
        '
        Me.lblConversion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblConversion.Location = New System.Drawing.Point(146, 297)
        Me.lblConversion.Name = "lblConversion"
        Me.lblConversion.Size = New System.Drawing.Size(103, 20)
        Me.lblConversion.TabIndex = 4
        Me.lblConversion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(54, 368)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 5
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(171, 368)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(293, 368)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblUnits
        '
        Me.lblUnits.AutoSize = True
        Me.lblUnits.Location = New System.Drawing.Point(268, 301)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(0, 13)
        Me.lblUnits.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 413)
        Me.Controls.Add(Me.lblUnits)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblConversion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Day Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents radSeconds As RadioButton
    Friend WithEvents radMinutes As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtInput As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblConversion As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblUnits As Label
End Class
