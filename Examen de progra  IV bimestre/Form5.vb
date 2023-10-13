Public Class Form5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim c, d, respuesta As Integer
        c = TextBox1.Text
        d = TextBox2.Text
        respuesta = c - d
        TextBox3.Text = respuesta
    End Sub
End Class