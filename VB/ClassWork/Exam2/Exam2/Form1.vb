'Bailey Maynard
'11/2/18
'Takes calories and grams of fat of a food and calculates the percentage of calories from the fat
Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Variables needed to do calculations
        Dim totalCalories As Double
        Dim caloriesFromFat As Double
        Dim gramsOfFat As Double
        Dim percentage As Double
        Dim lessThan30Check As Double

        'Will attempt to convert strings given by user into doubles
        Try
            totalCalories = CDbl(txtCaloriesInFood.Text)
            gramsOfFat = CDbl(txtGramsOfFat.Text)

            'Checks to make sure numbers entered are above zero
            If gramsOfFat <= 0 Then
                MessageBox.Show("Grams of fat must be greater than zero.")
                Return
            ElseIf totalCalories <= 0 Then
                MessageBox.Show("Calories must be greater than zero.")
                Return
            End If

            'Calculates 30% of the total calories to check the percentage of calories from fat later on
            lessThan30Check = totalCalories * 0.3

            'Calculations to determine calories from fat and the percentage of calories from fat in the total calories
            caloriesFromFat = gramsOfFat * 9
            percentage = caloriesFromFat / totalCalories

            'Checks to see if the food is low-fat
            If percentage < lessThan30Check Then
                MessageBox.Show("This food is a low-fat food.")
            End If

            'Outputs the poercentage
            lblCaloriesFromFat.Text = percentage

            'If it cannot convert the string, output an error message
        Catch ex As Exception
            MessageBox.Show("Please enter valid numbers greater than zero.")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clears the labels and text boxes
        lblCaloriesFromFat.Text = ""
        txtCaloriesInFood.Clear()
        txtGramsOfFat.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Closes the program
        Me.Close()
    End Sub
End Class
