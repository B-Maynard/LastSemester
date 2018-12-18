Public Class Form1
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnCompare_Click(sender As Object, e As EventArgs) Handles btnCompare.Click
        Dim name1 As String
        Dim name2 As String

        name1 = txtName1.Text
        name2 = txtName2.Text

        If name1 > name2 Then
            lblResults.Text = name1 & " is larger than " & name2
        ElseIf name2 > name1 Then
            lblResults.Text = name2 & " is larger than " & name1
        Else
            lblResults.Text = name1 & " and " & name2 & " are equal"
        End If
    End Sub

    Private Sub btnUpper_Click(sender As Object, e As EventArgs) Handles btnUpper.Click
        Dim name1 As String
        Dim name2 As String

        name1 = txtName1.Text
        name2 = txtName2.Text

        lblResults.Text = name1.ToUpper() & " " & name2.ToUpper()


    End Sub

    Private Sub btnLower_Click(sender As Object, e As EventArgs) Handles btnLower.Click
        Dim name1 As String
        Dim name2 As String

        name1 = txtName1.Text
        name2 = txtName2.Text

        lblResults.Text = name1.ToLower() & " " & name2.ToLower()
    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim name1 As String

        name1 = txtName1.Text

        If name1 = "Apple" Then
            lblResults.Text = "Password is correct"
        Else
            lblResults.Text = "Password is incorrect"
        End If
    End Sub
End Class
