Public Class Form1
    Dim num1 As Integer
    Dim num2 As Integer
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        num1 = txtNum1.Text
        num2 = txtNum2.Text

        lblResults.Text = num1 + num2
    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        num1 = txtNum1.Text
        num2 = txtNum2.Text

        lblResults.Text = num1 - num2
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        num1 = txtNum1.Text
        num2 = txtNum2.Text

        lblResults.Text = num1 * num2
    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        num1 = txtNum1.Text
        num2 = txtNum2.Text

        lblResults.Text = num1 Mod num2
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        Dim num1 As Double = txtNum1.Text
        Dim num2 As Double = txtNum2.Text

        lblResults.Text = num1 / num2
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnDemo_Click(sender As Object, e As EventArgs) Handles btnDemo.Click
        Dim answer As Integer

        answer = CInt(23.5)
        lblResults.Text = answer
    End Sub
End Class
