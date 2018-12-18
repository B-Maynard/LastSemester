'Bailey Maynard
'11/30/18
'Prompts the user for a speed in mph and time in hours, then calculates the distance one would travel given those parameters
Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Closes the program
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'Clears any existing items in the list box before new calculations begin
        lstOutput.Items.Clear()
        'Variables needed for calculations
        Dim speed As Integer
        Dim time As Integer
        Dim distance As Integer = 0

        'Input validation for speed. Must be a positive integer
        If Integer.TryParse(InputBox("Enter a speed in mph:", "Speed"), speed) Then
            If speed < 1 Then
                MessageBox.Show("Please enter a positive integer.")
                Return
            End If
            'Input validation for time. Also must be a positive integer
            If Integer.TryParse(InputBox("Enter a time in hours:", "Time"), time) Then
                If time < 1 Then
                    MessageBox.Show("Please enter a positive integer.")
                    Return
                End If

                'Adding items to the list box in specific format
                lstOutput.Items.Add("Vehicle Speed: " & speed.ToString() & " MPH")
                lstOutput.Items.Add("Time Traveled: " & time.ToString() & " hours")
                lstOutput.Items.Add("Hours" & vbTab & "Distance Traveled")
                lstOutput.Items.Add("-----------------------------------------------")

                'Loop to add distances to the list box. Also does the calculation at each step
                For i As Integer = 1 To time
                    distance += speed
                    lstOutput.Items.Add(i.ToString() & vbTab & distance)
                Next i

                'Outputs the total distance at the end of the program
                lstOutput.Items.Add("Total Distance: " & distance)

                'Error messages for incorrect input
            Else
                MessageBox.Show("Please enter a valid integer.")
            End If
        Else
            MessageBox.Show("Please enter a valid integer.")
        End If
    End Sub
End Class
