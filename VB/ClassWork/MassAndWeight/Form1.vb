'Bailey Maynard
'10/26/18
'Asks user to input a mass of an item and then calculates the weight of the item in newtons

Public Class Form1
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Closes the application
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clears the appropriate text fields
        lblOutput.Text = ""
        txtInput.Clear()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim itemMass As Double
        Dim weight As Double

        'Attempts to parse the input as a double
        If Double.TryParse(txtInput.Text, itemMass) Then
            'If it succeeds, then do the calculation to newtons
            weight = itemMass * 9.8

            'If weight is greater than 1000, output that it is too heavy
            If weight > 1000 Then
                lblOutput.Text = "Item is too heavy"
                'If weight is less than 10, output that it is too light
            ElseIf weight < 10 Then
                lblOutput.Text = "Item is too light"
            Else
                'Otherwise, output the weight
                lblOutput.Text = weight.ToString()
            End If
        Else
            'If the input cannot be parsed as a double, output an error
            MessageBox.Show("Wrong input. Please enter input as a double.")
        End If
    End Sub
End Class
