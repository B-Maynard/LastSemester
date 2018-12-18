'Bailey Maynard
'Lab 1
'9/14/18
'Shows a math problem and will show the answer after clicking 'show answer' button. Program closes when user clicks exit button

Public Class Form1
    Private Sub btnShowAnswer_Click(sender As Object, e As EventArgs) Handles btnShowAnswer.Click
        lblAnswer.Text = "82"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
