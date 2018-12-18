Public Class Form1
    Private Sub btnValue_Click(sender As Object, e As EventArgs) Handles btnValue.Click
        lstOutput.Items.Clear()
        Dim number As Integer = 50 'our variable we are looking at

        lstOutput.Items.Add("Inside of the Click Event Pass by value")
        lstOutput.Items.Add(number.ToString())
        'Call the procedure
        ChangeByValue(number)

        'after the call to the procedure

        lstOutput.Items.Add("After the call to ChangeByValue procedure")
        lstOutput.Items.Add(number.ToString())

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnReference_Click(sender As Object, e As EventArgs) Handles btnReference.Click
        lstOutput.Items.Clear()
        Dim number As Integer = 500

        lstOutput.Items.Add("Inside the Click Event Pass by reference")
        lstOutput.Items.Add(number.ToString())

        'call the ChangeByReference procedure
        ChangeByReference(number)

        'after the call

        lstOutput.Items.Add("After the call to the ChangeByReference procedure")
        lstOutput.Items.Add(number.ToString())
    End Sub

    Sub ChangeByValue(ByVal firstNum As Integer)
        'output to the list box so that you know where you are in the code

        lstOutput.Items.Add("Inside of the ChangeByValue procedure")
        lstOutput.Items.Add(firstNum.ToString())

        firstNum = 123

        lstOutput.Items.Add("After the change to firstNum")
        lstOutput.Items.Add(firstNum.ToString())

    End Sub

    Sub ChangeByReference(ByRef firstNum As Integer)
        lstOutput.Items.Add("Inside of the ChangeByReference procedure")
        lstOutput.Items.Add(firstNum.ToString())

        firstNum = 555

        lstOutput.Items.Add("After the change to firstNum")
        lstOutput.Items.Add(firstNum.ToString())
    End Sub
End Class
