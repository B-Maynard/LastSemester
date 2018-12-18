Public Class Form1
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'Calculate area L*W
        Dim roomLength As Double = txtLength.Text
        Dim roomWidth As Double = txtWidth.Text


        Dim area As Double = roomLength * roomWidth

        lblArea.Text = area
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim roomLength As Double = txtLength.Text
        Dim roomWidth As Double = txtWidth.Text
        Dim perimeter As Double

        perimeter = (2 * roomLength) + (2 * roomWidth)

        lblPerimeter.Text = perimeter
    End Sub
End Class
