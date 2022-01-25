Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a As Integer = Val(TextBox1.Text)
        Dim b As Integer = Val(TextBox2.Text)
        Dim c As Integer = Val(TextBox3.Text)

        If a > b And a > c Then
            MessageBox.Show(a, "Largest")
        ElseIf b > c And b > a Then
            MessageBox.Show(b, "Largest")
        Else
            MessageBox.Show(c, "Largest")
        End If
    End Sub
End Class
