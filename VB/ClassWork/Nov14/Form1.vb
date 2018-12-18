Public Class Form1
    Private Sub btnHelloWorld_Click(sender As Object, e As EventArgs) Handles btnHelloWorld.Click
        Dim i As Integer = 0

        While i < 100
            lstOutput.Items.Add("Hello World")
            i = i + 1
        End While
    End Sub

    Private Sub btn1to64_Click(sender As Object, e As EventArgs) Handles btn1to64.Click
        Dim count As Integer = 1

        While count < 65
            lstOutput.Items.Add(count)
            count = count + 1
        End While
    End Sub

    Private Sub btn100to1_Click(sender As Object, e As EventArgs) Handles btn100to1.Click
        Dim i As Integer = 100

        While i > 0
            lstOutput.Items.Add(i)
            i = i - 1
        End While
    End Sub

    Private Sub btnSum_Click(sender As Object, e As EventArgs) Handles btnSum.Click
        Dim sum As Integer = 0
        Dim i As Integer = 1

        While i <= 100
            sum = sum + i
            i = i + 1
        End While

        lstOutput.Items.Add(sum)
    End Sub

    Private Sub btnUserTotal_Click(sender As Object, e As EventArgs) Handles btnUserTotal.Click
        Dim userInput As String
        Dim userInt As Integer
        Dim i As Integer = 1
        Dim sum As Integer = 0

        userInput = InputBox("Please enter a positive number:")

        If Integer.TryParse(userInput, userInt) Then
            While i <= userInt
                sum = sum + i
                i = i + 1
            End While
            lstOutput.Items.Add(sum)
        Else
            MessageBox.Show("Please enter a positive integer")
        End If



    End Sub

    Private Sub btnNames_Click(sender As Object, e As EventArgs) Handles btnNames.Click
        Dim userInput As String = InputBox("Please enter a name:")

        While userInput.ToUpper() <> "QUIT"
            lstOutput.Items.Add("Hello, " & userInput)
            userInput = InputBox("Please enter a name:")
        End While
    End Sub

    Private Sub btnUserSum_Click(sender As Object, e As EventArgs) Handles btnUserSum.Click
        Dim userString As String
        Dim sum As Integer = 0
        Dim userInt As Integer

        Do
            'Check the other string to int above
        Loop While userInt <> 0


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstOutput.Items.Clear()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
