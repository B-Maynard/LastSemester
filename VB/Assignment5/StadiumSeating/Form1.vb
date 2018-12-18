'Bailey Maynard
'10/3/18
'User inputs different values for stadium seats, the program then calculates how much each seat generated
' in revenue, adds up the total, and outputs it.

Public Class Form1
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        Dim classATotalSold As Integer
        Dim classBTotalSold As Integer
        Dim classCTotalSold As Integer

        Dim classATotalCost As Integer
        Dim classBTotalCost As Integer
        Dim classCTotalCost As Integer

        'If else statements to catch if the user tries to calculate without input/without a number
        If txtClassA.Text = "" OrElse Not Integer.TryParse(txtClassA.Text, classATotalSold) Then
            MessageBox.Show("Please enter a number for Class A", "No entry", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        ElseIf txtClassB.Text = "" OrElse Not Integer.TryParse(txtClassB.Text, classBTotalSold) Then
            MessageBox.Show("Please enter a number for Class B", "No entry", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        ElseIf txtClassC.Text = "" OrElse Not Integer.TryParse(txtClassC.Text, classCTotalSold) Then
            MessageBox.Show("Please enter a number for Class C", "No entry", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'Setting up necessary variables
        classATotalSold = txtClassA.Text
        classBTotalSold = txtClassB.Text
        classCTotalSold = txtClassC.Text

        'Total cost of tickets determined by multiplying the total sold by the ticket cost
        classATotalCost = classATotalSold * 15
        classBTotalCost = classBTotalSold * 12
        classCTotalCost = classCTotalSold * 9

        'Add up all the sales
        Dim totalRevenue As Integer = classATotalCost + classBTotalCost + classCTotalCost

        'Output in money format
        lblClassA.Text = classATotalCost.ToString("C2")
        lblClassB.Text = classBTotalCost.ToString("C2")
        lblClassC.Text = classCTotalCost.ToString("C2")

        lblTotalRevenue.Text = totalRevenue.ToString("C2")


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear all the text boxes and labels
        txtClassA.Text = ""
        txtClassB.Text = ""
        txtClassC.Text = ""

        lblClassA.Text = ""
        lblClassB.Text = ""
        lblClassC.Text = ""
        lblTotalRevenue.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
