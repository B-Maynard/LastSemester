'Bailey Maynard
'9/19/18 - Exam 1


Public Class Form1
    Private Sub btnPennsylvania_Click(sender As Object, e As EventArgs) Handles btnPennsylvania.Click
        lblPennsylvania.Text = "PA"
    End Sub

    Private Sub btnNewYork_Click(sender As Object, e As EventArgs) Handles btnNewYork.Click
        lblNewYork.Text = "NY"
    End Sub

    Private Sub btnOhio_Click(sender As Object, e As EventArgs) Handles btnOhio.Click
        lblOhio.Text = "OH"
    End Sub

    Private Sub btnVirginia_Click(sender As Object, e As EventArgs) Handles btnVirginia.Click
        lblVirginia.Text = "VA"
    End Sub

    Private Sub btnMaryland_Click(sender As Object, e As EventArgs) Handles btnMaryland.Click
        lblMaryland.Text = "MD"
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
