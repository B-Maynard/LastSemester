Public Class Form1
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnGuess_Click(sender As Object, e As EventArgs) Handles btnGuess.Click
        'declare variables
        Dim rand As New Random
        Dim randNumber As New Integer
        Dim userGuess As New Integer

        'Generate random number
        randNumber = 1 + rand.Next(99) '99 controls your upper limit

        'repeat the loop until user guesses the correct number
        While userGuess <> randNumber

            'ask the user to enter a number
            userGuess = InputBox("Guess", "Enter your guess from 1-100:")

            If userGuess < randNumber Then
                MessageBox.Show("Too low!")
            ElseIf userGuess > randNumber Then
                MessageBox.Show("Too high!")
            Else
                MessageBox.Show("You got it right!")
            End If
        End While 'exits the loop when the number and guess are equal



    End Sub
End Class
