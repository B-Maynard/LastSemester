Public Class Form1
    Private Sub btnRunDemo_Click(sender As Object, e As EventArgs) Handles btnRunDemo.Click
        Dim intCount As Integer = 0

        Do While intCount < 10
            lstOutput.Items.Add("Hello")
            intCount += 1
        Loop
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstOutput.Items.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
