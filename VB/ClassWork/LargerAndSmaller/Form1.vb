'Bailey Maynard
'10/19/18
'Program takes two integers and compares them to see which is larger and/or if they are equal

Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCompare_Click(sender As Object, e As EventArgs) Handles btnCompare.Click
        Dim intA As Integer
        Dim intB As Integer

        'Will check to make sure that the inputs are integers
        If Integer.TryParse(txtIntegerA.Text, intA) And Integer.TryParse(txtIntegerB.Text, intB) Then
            intA = CInt(txtIntegerA.Text)
            intB = CInt(txtIntegerB.Text)

            'Determines whether or not the values are equal, or if one is greater than the other
            If intA > intB Then
                lblAnswer.Text = "Value A is greatest."
            ElseIf intB > intA Then
                lblAnswer.Text = "Value B is greatest."
            Else
                lblAnswer.Text = "Values are equal."
            End If
        Else
            'If the user enters non-integer values, display error message
            MessageBox.Show("Please enter valid integers.")
        End If
    End Sub
End Class
