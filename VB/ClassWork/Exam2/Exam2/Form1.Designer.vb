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
        Me.txtCaloriesInFood = New System.Windows.Forms.TextBox()
        Me.txtGramsOfFat = New System.Windows.Forms.TextBox()
        Me.lblCaloriesFromFat = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter the number of calories in the food:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(247, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter the number of fat grams in the food:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(253, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Percentage of calories that come from fat:"
        '
        'txtCaloriesInFood
        '
        Me.txtCaloriesInFood.Location = New System.Drawing.Point(314, 38)
        Me.txtCaloriesInFood.Name = "txtCaloriesInFood"
        Me.txtCaloriesInFood.Size = New System.Drawing.Size(88, 20)
        Me.txtCaloriesInFood.TabIndex = 3
        '
        'txtGramsOfFat
        '
        Me.txtGramsOfFat.Location = New System.Drawing.Point(314, 91)
        Me.txtGramsOfFat.Name = "txtGramsOfFat"
        Me.txtGramsOfFat.Size = New System.Drawing.Size(88, 20)
        Me.txtGramsOfFat.TabIndex = 4
        '
        'lblCaloriesFromFat
        '
        Me.lblCaloriesFromFat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCaloriesFromFat.Location = New System.Drawing.Point(311, 182)
        Me.lblCaloriesFromFat.Name = "lblCaloriesFromFat"
        Me.lblCaloriesFromFat.Size = New System.Drawing.Size(105, 42)
        Me.lblCaloriesFromFat.TabIndex = 5
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(38, 274)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(90, 34)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(173, 274)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(90, 34)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(311, 274)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(90, 34)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 332)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblCaloriesFromFat)
        Me.Controls.Add(Me.txtGramsOfFat)
        Me.Controls.Add(Me.txtCaloriesInFood)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Fat Percentage Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCaloriesInFood As TextBox
    Friend WithEvents txtGramsOfFat As TextBox
    Friend WithEvents lblCaloriesFromFat As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
