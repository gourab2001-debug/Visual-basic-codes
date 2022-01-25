Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim val1 As Integer = Val(TextBox1.Text)
        If val1 Mod 2 = 0 Then
            MessageBox.Show(val1, "Even")
        Else
            MessageBox.Show(val1, "Odd")
        End If

        TextBox1.Clear()

    End Sub
End Class
