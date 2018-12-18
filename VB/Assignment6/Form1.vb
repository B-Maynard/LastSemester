'Bailey Maynard
'10/23/18
'Takes user input as days and converts it minutes or seconds
Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Closes the form
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clears any labels or text boxes used for calculations
        txtInput.Clear()
        lblUnits.Text = ""
        lblConversion.Text = ""
        txtInput.Select()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'Delarations for variables used in calculations
        Dim calculation As Integer
        Dim days As Integer

        'Will try to see if input is in integer format

        If Integer.TryParse(txtInput.Text, days) Then
            'If days is an integer but is also negative, will throw an error and return
            If days < 0 Then
                MessageBox.Show("Please enter a number higher than 0.")
                Return
            End If

            'Checks if user toggled minutes or seconds and multiplies the days by the number of seconds/minutes in a single day
            If radMinutes.Checked Then
                calculation = days * 1440
                lblUnits.Text = "Minutes"
            Else
                calculation = days * 86400
                lblUnits.Text = "Seconds"
            End If

            'Outputs calculations to the form
            lblConversion.Text = calculation.ToString()

        Else
            'Throw error if the user inputs a non-integer
            MessageBox.Show("Please enter an integer for the days.")
        End If
    End Sub
End Class
