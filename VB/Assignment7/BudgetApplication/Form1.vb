'Bailey Maynard
'11/29/18
Public Class Form1
    'Global variables for storing expense information for use in calculations 
    Dim numberOfExpenses As Integer
    Dim totalCostExpenses As Double

    Private Sub btnDataEntry_Click(sender As Object, e As EventArgs) Handles btnDataEntry.Click
        'Checking input for number of expenses the user has
        If Integer.TryParse(txtExpenses.Text, numberOfExpenses) Then
            'Cannot enter an integer less than 1
            If numberOfExpenses < 1 Then
                MessageBox.Show("Please enter an integer greater than 0.")
                Return
            End If
            Dim i As Integer = 0
            Dim temp As Double
            totalCostExpenses = 0.00

            'Loop to allow user to enter costs of expenses
            While i < numberOfExpenses
                'Input validation for cost of expenses
                If Double.TryParse(InputBox("Please enter the cost of expense:", "Expenses"), temp) Then
                    'User cannot enter a negative value
                    If temp < 0 Then
                        MessageBox.Show("Please enter a valid value above 0.")
                        Return
                    End If

                    'Will add up the total cost of expenses
                    totalCostExpenses += temp
                    i = i + 1
                Else
                    MessageBox.Show("Please enter a valid input above 0.")
                    Return
                End If
            End While
            'Outputs when data is ready, and puts it into the expense label
            MessageBox.Show("Data is ready!")
            lblExpenses.Text = totalCostExpenses.ToString("c")
        Else
            MessageBox.Show("Please enter a valid integer that's 1 or greater.")
        End If
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim monthlyIncome As Double
        Dim totalRevenue As Double
        Dim expenseRatio As Double

        'Input validation for monthly income
        If Double.TryParse(txtIncome.Text, monthlyIncome) Then
            'Monthly income cannot be negative
            If monthlyIncome < 0 Then
                MessageBox.Show("Please enter an input greater than 0.")
                Return
            End If
            'If expenses are more than monthly income, output warning
            If totalCostExpenses > monthlyIncome Then
                MessageBox.Show("You are going to go into debt quickly!")
            End If

            'Calculations for determining output
            totalRevenue = monthlyIncome - totalCostExpenses
            expenseRatio = (totalCostExpenses / monthlyIncome) * 100
            expenseRatio = Decimal.Round(expenseRatio, 2, MidpointRounding.AwayFromZero)

            lblIncome.Text = monthlyIncome.ToString("c")
            lblRevenue.Text = totalRevenue.ToString("c")
            lblRatio.Text = expenseRatio.ToString & "%"
        Else
            MessageBox.Show("Please enter a valid number above 0.")
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear all labels and text boxes
        lblExpenses.Text = "$0.00"
        lblIncome.Text = "$0.00"
        lblRatio.Text = "0%"
        lblRevenue.Text = "$0.00"

        txtExpenses.Clear()
        txtIncome.Clear()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Close the program
        Me.Close()
    End Sub
End Class
