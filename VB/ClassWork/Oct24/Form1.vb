Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim number As Integer

        If Integer.TryParse(txtNumber.Text, number) Then
            Select Case number
                Case 1
                    lblResults.Text = "I"
                Case 2
                    lblResults.Text = "II"
                Case 3
                    lblResults.Text = "III"
                Case 4
                    lblResults.Text = "IV"
                Case 5
                    lblResults.Text = "V"
                Case 6
                    lblResults.Text = "VI"
                Case 7
                    lblResults.Text = "VII"
                Case 8
                    lblResults.Text = "VIII"
                Case 9
                    lblResults.Text = "IX"
                Case 10
                    lblResults.Text = "X"
            End Select
        Else
            lblResults.Text = "Your number is not in the rage of 1 - 10."
        End If
    End Sub
End Class
