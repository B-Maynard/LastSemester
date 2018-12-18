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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIncome = New System.Windows.Forms.TextBox()
        Me.txtExpenses = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnDataEntry = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblIncome = New System.Windows.Forms.Label()
        Me.lblExpenses = New System.Windows.Forms.Label()
        Me.lblRevenue = New System.Windows.Forms.Label()
        Me.lblRatio = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnDataEntry)
        Me.GroupBox1.Controls.Add(Me.txtExpenses)
        Me.GroupBox1.Controls.Add(Me.txtIncome)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(273, 183)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enter monthly income and number of expenses:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblRatio)
        Me.GroupBox2.Controls.Add(Me.lblRevenue)
        Me.GroupBox2.Controls.Add(Me.lblExpenses)
        Me.GroupBox2.Controls.Add(Me.lblIncome)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(335, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(293, 183)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Results:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Monthly income:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Number of expenses:"
        '
        'txtIncome
        '
        Me.txtIncome.Location = New System.Drawing.Point(167, 36)
        Me.txtIncome.Name = "txtIncome"
        Me.txtIncome.Size = New System.Drawing.Size(100, 20)
        Me.txtIncome.TabIndex = 2
        '
        'txtExpenses
        '
        Me.txtExpenses.Location = New System.Drawing.Point(167, 97)
        Me.txtExpenses.Name = "txtExpenses"
        Me.txtExpenses.Size = New System.Drawing.Size(100, 20)
        Me.txtExpenses.TabIndex = 3
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(12, 261)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(269, 261)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 3
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(553, 261)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnDataEntry
        '
        Me.btnDataEntry.Location = New System.Drawing.Point(79, 137)
        Me.btnDataEntry.Name = "btnDataEntry"
        Me.btnDataEntry.Size = New System.Drawing.Size(108, 23)
        Me.btnDataEntry.TabIndex = 5
        Me.btnDataEntry.Text = "Enter Expenses"
        Me.btnDataEntry.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Monthly income:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Total cost of expenses:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Total revenue:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Expense ratio:"
        '
        'lblIncome
        '
        Me.lblIncome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIncome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncome.Location = New System.Drawing.Point(162, 35)
        Me.lblIncome.Name = "lblIncome"
        Me.lblIncome.Size = New System.Drawing.Size(125, 20)
        Me.lblIncome.TabIndex = 4
        Me.lblIncome.Text = "$0.00"
        Me.lblIncome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblExpenses
        '
        Me.lblExpenses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblExpenses.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpenses.Location = New System.Drawing.Point(162, 71)
        Me.lblExpenses.Name = "lblExpenses"
        Me.lblExpenses.Size = New System.Drawing.Size(125, 20)
        Me.lblExpenses.TabIndex = 5
        Me.lblExpenses.Text = "$0.00"
        Me.lblExpenses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRevenue
        '
        Me.lblRevenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRevenue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRevenue.Location = New System.Drawing.Point(162, 109)
        Me.lblRevenue.Name = "lblRevenue"
        Me.lblRevenue.Size = New System.Drawing.Size(125, 20)
        Me.lblRevenue.TabIndex = 6
        Me.lblRevenue.Text = "$0.00"
        Me.lblRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRatio
        '
        Me.lblRatio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRatio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRatio.Location = New System.Drawing.Point(162, 143)
        Me.lblRatio.Name = "lblRatio"
        Me.lblRatio.Size = New System.Drawing.Size(125, 20)
        Me.lblRatio.TabIndex = 7
        Me.lblRatio.Text = "0%"
        Me.lblRatio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 304)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Budget Application"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtExpenses As TextBox
    Friend WithEvents txtIncome As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnDataEntry As Button
    Friend WithEvents lblIncome As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblRatio As Label
    Friend WithEvents lblRevenue As Label
    Friend WithEvents lblExpenses As Label
End Class
