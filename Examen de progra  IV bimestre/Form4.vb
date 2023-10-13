Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, resultado As Integer
        a = TextBox1.Text
        b = TextBox2.Text
        resultado = a + b
        TextBox3.Text = resultado
    End Sub
End Class