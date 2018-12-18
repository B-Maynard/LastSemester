'Bailey Maynard
'9/12/18
'Assignment 2:
'Upon clicking one of the languages, the program will respond with the phrase 'Good morning' in that language


Public Class Form1
    Private Sub btnItalian_Click(sender As Object, e As EventArgs) Handles btnItalian.Click
        lblTranslation.Text = "Buongiorno"
    End Sub

    Private Sub btnSpanish_Click(sender As Object, e As EventArgs) Handles btnSpanish.Click
        lblTranslation.Text = "Buenos Dias"
    End Sub

    Private Sub btnGerman_Click(sender As Object, e As EventArgs) Handles btnGerman.Click
        lblTranslation.Text = "Guten Morgen"
    End Sub
End Class
