Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim num1 As Integer = Val(TextBox1.Text)
        Dim num2 As Integer = Val(TextBox2.Text)
        Dim sum As Integer = num1 + num2
        MessageBox.Show("The Value after addition is " & sum)
    End Sub
End Class
