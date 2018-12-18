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
        Me.btnHelloWorld = New System.Windows.Forms.Button()
        Me.btn100to1 = New System.Windows.Forms.Button()
        Me.btnSum = New System.Windows.Forms.Button()
        Me.btnUserTotal = New System.Windows.Forms.Button()
        Me.btnNames = New System.Windows.Forms.Button()
        Me.btnUserSum = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btn1to64 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstOutput
        '
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.ItemHeight = 25
        Me.lstOutput.Location = New System.Drawing.Point(46, 48)
        Me.lstOutput.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(350, 579)
        Me.lstOutput.TabIndex = 0
        '
        'btnHelloWorld
        '
        Me.btnHelloWorld.Location = New System.Drawing.Point(520, 48)
        Me.btnHelloWorld.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnHelloWorld.Name = "btnHelloWorld"
        Me.btnHelloWorld.Size = New System.Drawing.Size(150, 44)
        Me.btnHelloWorld.TabIndex = 1
        Me.btnHelloWorld.Text = "Hello World"
        Me.btnHelloWorld.UseVisualStyleBackColor = True
        '
        'btn100to1
        '
        Me.btn100to1.Location = New System.Drawing.Point(520, 221)
        Me.btn100to1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btn100to1.Name = "btn100to1"
        Me.btn100to1.Size = New System.Drawing.Size(150, 44)
        Me.btn100to1.TabIndex = 2
        Me.btn100to1.Text = "100 to 1"
        Me.btn100to1.UseVisualStyleBackColor = True
        '
        'btnSum
        '
        Me.btnSum.Location = New System.Drawing.Point(520, 312)
        Me.btnSum.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnSum.Name = "btnSum"
        Me.btnSum.Size = New System.Drawing.Size(150, 44)
        Me.btnSum.TabIndex = 3
        Me.btnSum.Text = "Sum"
        Me.btnSum.UseVisualStyleBackColor = True
        '
        'btnUserTotal
        '
        Me.btnUserTotal.Location = New System.Drawing.Point(520, 398)
        Me.btnUserTotal.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnUserTotal.Name = "btnUserTotal"
        Me.btnUserTotal.Size = New System.Drawing.Size(150, 44)
        Me.btnUserTotal.TabIndex = 4
        Me.btnUserTotal.Text = "User Total"
        Me.btnUserTotal.UseVisualStyleBackColor = True
        '
        'btnNames
        '
        Me.btnNames.Location = New System.Drawing.Point(520, 492)
        Me.btnNames.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnNames.Name = "btnNames"
        Me.btnNames.Size = New System.Drawing.Size(150, 44)
        Me.btnNames.TabIndex = 5
        Me.btnNames.Text = "Names"
        Me.btnNames.UseVisualStyleBackColor = True
        '
        'btnUserSum
        '
        Me.btnUserSum.Location = New System.Drawing.Point(520, 587)
        Me.btnUserSum.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnUserSum.Name = "btnUserSum"
        Me.btnUserSum.Size = New System.Drawing.Size(150, 44)
        Me.btnUserSum.TabIndex = 6
        Me.btnUserSum.Text = "User Sum"
        Me.btnUserSum.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(46, 642)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(354, 44)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(602, 698)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(150, 44)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btn1to64
        '
        Me.btn1to64.Location = New System.Drawing.Point(520, 129)
        Me.btn1to64.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btn1to64.Name = "btn1to64"
        Me.btn1to64.Size = New System.Drawing.Size(150, 44)
        Me.btn1to64.TabIndex = 9
        Me.btn1to64.Text = "1 to 64"
        Me.btn1to64.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 765)
        Me.Controls.Add(Me.btn1to64)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnUserSum)
        Me.Controls.Add(Me.btnNames)
        Me.Controls.Add(Me.btnUserTotal)
        Me.Controls.Add(Me.btnSum)
        Me.Controls.Add(Me.btn100to1)
        Me.Controls.Add(Me.btnHelloWorld)
        Me.Controls.Add(Me.lstOutput)
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "Form1"
        Me.Text = "Loops Testing"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstOutput As ListBox
    Friend WithEvents btnHelloWorld As Button
    Friend WithEvents btn100to1 As Button
    Friend WithEvents btnSum As Button
    Friend WithEvents btnUserTotal As Button
    Friend WithEvents btnNames As Button
    Friend WithEvents btnUserSum As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btn1to64 As Button
End Class
