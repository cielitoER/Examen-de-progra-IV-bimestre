Public Class Form8
    Private txt_usuario As Object
    Private txt_contraseña As Object

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim usuario As String
        Dim contraseña As Integer
        usuario = txt_usuario.Text
        contraseña = txt_contraseña.Text
        If (usuario = "Soy el mejor") And (contraseña = "12345") Then

            Form1.Show()
            Hide()
        Else
            MsgBox("Verifique que su usuario y contraseña esten escritos correctamente")
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class