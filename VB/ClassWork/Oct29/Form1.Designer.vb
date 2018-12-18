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
        Me.txtName1 = New System.Windows.Forms.TextBox()
        Me.txtName2 = New System.Windows.Forms.TextBox()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.btnCompare = New System.Windows.Forms.Button()
        Me.btnUpper = New System.Windows.Forms.Button()
        Me.btnLower = New System.Windows.Forms.Button()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(87, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter a name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter another name:"
        '
        'txtName1
        '
        Me.txtName1.Location = New System.Drawing.Point(185, 74)
        Me.txtName1.Name = "txtName1"
        Me.txtName1.Size = New System.Drawing.Size(100, 20)
        Me.txtName1.TabIndex = 2
        '
        'txtName2
        '
        Me.txtName2.Location = New System.Drawing.Point(185, 134)
        Me.txtName2.Name = "txtName2"
        Me.txtName2.Size = New System.Drawing.Size(100, 20)
        Me.txtName2.TabIndex = 3
        '
        'lblResults
        '
        Me.lblResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResults.Location = New System.Drawing.Point(90, 187)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(195, 23)
        Me.lblResults.TabIndex = 4
        '
        'btnCompare
        '
        Me.btnCompare.Location = New System.Drawing.Point(29, 239)
        Me.btnCompare.Name = "btnCompare"
        Me.btnCompare.Size = New System.Drawing.Size(75, 23)
        Me.btnCompare.TabIndex = 5
        Me.btnCompare.Text = "Compare"
        Me.btnCompare.UseVisualStyleBackColor = True
        '
        'btnUpper
        '
        Me.btnUpper.Location = New System.Drawing.Point(148, 239)
        Me.btnUpper.Name = "btnUpper"
        Me.btnUpper.Size = New System.Drawing.Size(75, 23)
        Me.btnUpper.TabIndex = 6
        Me.btnUpper.Text = "Upper"
        Me.btnUpper.UseVisualStyleBackColor = True
        '
        'btnLower
        '
        Me.btnLower.Location = New System.Drawing.Point(271, 239)
        Me.btnLower.Name = "btnLower"
        Me.btnLower.Size = New System.Drawing.Size(75, 23)
        Me.btnLower.TabIndex = 7
        Me.btnLower.Text = "Lower"
        Me.btnLower.UseVisualStyleBackColor = True
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(85, 286)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(75, 23)
        Me.btnCheck.TabIndex = 8
        Me.btnCheck.Text = "Check"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(210, 286)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 321)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.btnLower)
        Me.Controls.Add(Me.btnUpper)
        Me.Controls.Add(Me.btnCompare)
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(Me.txtName2)
        Me.Controls.Add(Me.txtName1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Playing with Strings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtName1 As TextBox
    Friend WithEvents txtName2 As TextBox
    Friend WithEvents lblResults As Label
    Friend WithEvents btnCompare As Button
    Friend WithEvents btnUpper As Button
    Friend WithEvents btnLower As Button
    Friend WithEvents btnCheck As Button
    Friend WithEvents btnClose As Button
End Class
