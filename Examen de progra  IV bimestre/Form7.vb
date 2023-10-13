Public Class Form7
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i, h, resultado As Double
        i = TextBox1.Text
        h = TextBox2.Text
        resultado = i / h
        TextBox3.Text = resultado
        If TextBox1.Text = 0 Then
            TextBox3.Text = "Sytaxis Error"
        ElseIf TextBox2.Text = 0 Then
            TextBox3.Text = "Sytaxis Error"
        End If
        If TextBox1.Text = 0 Then
            TextBox3.Text = ""
            MsgBox("Syntax error")
        ElseIf TextBox2.Text = "" Then
            MsgBox("Syntax error")
        End If
    End Sub
End Class