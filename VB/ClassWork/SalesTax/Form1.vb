'Bailey Maynard
'9/28/18
'
'Takes a cost of items purchased along with a sales tax in decimal format, multiplies
'them together, then adds the cost of items to the product of the two numbers multiplied, and
'outputs.

Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim costOfItems As Double = txtCost.Text
        Dim taxRate As Double = txtTaxRate.Text


        Dim totalCost As Decimal = (costOfItems * taxRate) + costOfItems

        'converts the total cost to currency format
        lblTotal.Text = totalCost.ToString("C2")


    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
