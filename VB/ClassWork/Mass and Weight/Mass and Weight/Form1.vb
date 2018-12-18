Public Class Form1

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Dim mass As Double
        Dim weight As Double

        If Double.TryParse(txtMass.Text, mass) Then
            weight = mass * 9.8
            If weight < 10 Then
                lblWeight.Text = "Item is too light"
            ElseIf weight > 1000 Then
                lblWeight.Text = "Item is too heavy"
            Else
                lblWeight.Text = weight.ToString()
            End If
        Else
            MessageBox.Show("Wrong input. Please enter a double value as the mass.")
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' Clear the form
        txtMass.Clear()
        lblWeight.Text = ""

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.

        Me.Close()
    End Sub
End Class
