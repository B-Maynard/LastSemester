Public Class Form1
    'Global variables
    Dim decRetail As Decimal
    Dim decPercentage As Decimal

    'declare the function to validate input
    Private Function validateInput() As Boolean
        'if condition for retal price text box
        If Not Decimal.TryParse(txtRetailPrice.Text, decRetail) Then
            lblMessage.Text = "Retail price must be numeric"
            Return False
        End If
        If Not Decimal.TryParse(txtDiscountPercent.Text, decPercentage) Then
            lblMessage.Text = "Discount percentage must be numeric"
            Return False
        End If

        Return True
    End Function

    'function for calculating sales price
    Function calculateSalesPrice(ByVal decRetail As Decimal, ByVal decPercentage As Decimal) As Decimal
        'Calculate and return the sale price
        Dim decSalePrice As Decimal

        decSalePrice = decRetail - (decRetail * decPercentage)
        Return decSalePrice
    End Function

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decSaleprice As Decimal

        'Clear any previous message
        lblMessage.Text = String.Empty

        'If the input is valid, display the sale price
        If validateInput() Then
            decSaleprice = calculateSalesPrice(decRetail, decPercentage)
            lblSalePrice.Text = decSaleprice.ToString("c")
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
