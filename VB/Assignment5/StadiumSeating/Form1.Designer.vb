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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtClassA = New System.Windows.Forms.TextBox()
        Me.txtClassB = New System.Windows.Forms.TextBox()
        Me.txtClassC = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblClassA = New System.Windows.Forms.Label()
        Me.lblClassB = New System.Windows.Forms.Label()
        Me.lblClassC = New System.Windows.Forms.Label()
        Me.lblTotalRevenue = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtClassC)
        Me.GroupBox1.Controls.Add(Me.txtClassB)
        Me.GroupBox1.Controls.Add(Me.txtClassA)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(221, 171)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tickets Sold"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Class C:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Class B:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Class A:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter the number of tickets sold for each class of seats"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblTotalRevenue)
        Me.GroupBox2.Controls.Add(Me.lblClassC)
        Me.GroupBox2.Controls.Add(Me.lblClassB)
        Me.GroupBox2.Controls.Add(Me.lblClassA)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(258, 40)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(216, 171)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Revenue Generated"
        '
        'txtClassA
        '
        Me.txtClassA.Location = New System.Drawing.Point(108, 78)
        Me.txtClassA.Name = "txtClassA"
        Me.txtClassA.Size = New System.Drawing.Size(73, 20)
        Me.txtClassA.TabIndex = 4
        '
        'txtClassB
        '
        Me.txtClassB.Location = New System.Drawing.Point(108, 105)
        Me.txtClassB.Name = "txtClassB"
        Me.txtClassB.Size = New System.Drawing.Size(73, 20)
        Me.txtClassB.TabIndex = 5
        '
        'txtClassC
        '
        Me.txtClassC.Location = New System.Drawing.Point(108, 135)
        Me.txtClassC.Name = "txtClassC"
        Me.txtClassC.Size = New System.Drawing.Size(73, 20)
        Me.txtClassC.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(47, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Class A:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(47, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Class B:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(47, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Class C:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 138)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Total Revenue:"
        '
        'lblClassA
        '
        Me.lblClassA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClassA.Location = New System.Drawing.Point(114, 27)
        Me.lblClassA.Name = "lblClassA"
        Me.lblClassA.Size = New System.Drawing.Size(83, 23)
        Me.lblClassA.TabIndex = 9
        Me.lblClassA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblClassB
        '
        Me.lblClassB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClassB.Location = New System.Drawing.Point(114, 54)
        Me.lblClassB.Name = "lblClassB"
        Me.lblClassB.Size = New System.Drawing.Size(83, 23)
        Me.lblClassB.TabIndex = 10
        Me.lblClassB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblClassC
        '
        Me.lblClassC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClassC.Location = New System.Drawing.Point(114, 81)
        Me.lblClassC.Name = "lblClassC"
        Me.lblClassC.Size = New System.Drawing.Size(83, 23)
        Me.lblClassC.TabIndex = 11
        Me.lblClassC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalRevenue
        '
        Me.lblTotalRevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalRevenue.Location = New System.Drawing.Point(114, 133)
        Me.lblTotalRevenue.Name = "lblTotalRevenue"
        Me.lblTotalRevenue.Size = New System.Drawing.Size(83, 23)
        Me.lblTotalRevenue.TabIndex = 12
        Me.lblTotalRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(70, 235)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(123, 23)
        Me.btnCalc.TabIndex = 2
        Me.btnCalc.Text = "Calculate Revenue"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(208, 235)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(77, 23)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(307, 235)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 302)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Stadium Seating"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtClassC As TextBox
    Friend WithEvents txtClassB As TextBox
    Friend WithEvents txtClassA As TextBox
    Friend WithEvents lblTotalRevenue As Label
    Friend WithEvents lblClassC As Label
    Friend WithEvents lblClassB As Label
    Friend WithEvents lblClassA As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
