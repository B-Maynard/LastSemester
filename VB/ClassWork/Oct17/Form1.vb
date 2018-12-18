Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Declare variables for scores and average
        Dim score1 As Double
        Dim score2 As Double
        Dim score3 As Double
        Dim average As Double

        Try

            score1 = CDbl(txtScore1.Text)
            score2 = CDbl(txtScore2.Text)
            score3 = CDbl(txtScore3.Text)


            average = (score1 + score2 + score3) / 3

            lblAverage.Text = average.ToString("n2")

            'Select case condition to output the correct letter grade
            Select Case average
                Case >= 90
                    lblGrade.Text = "A"
                Case 80 To 89
                    lblGrade.Text = "B"
                Case 70 To 79
                    lblGrade.Text = "C"
                Case 60 To 69
                    lblGrade.Text = "D"
                Case Else
                    lblGrade.Text = "F"
            End Select

        Catch ex As Exception
            MessageBox.Show("You must enter a numeric value")
        End Try


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtScore1.Clear()
        txtScore2.Clear()
        txtScore3.Clear()

        lblAverage.Text = ""
        lblGrade.Text = ""

    End Sub
End Class
