Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim num1 As Integer = Val(TextBox1.Text)
        Dim num2 As Integer = Val(TextBox2.Text)
        Dim sum As Integer = num1 + num2
        Dim sumString As String = num1 & " + " & num2 & " = " & sum
        operationTextBox.Text = sumString
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim num1 As Integer = Val(TextBox1.Text)
        Dim num2 As Integer = Val(TextBox2.Text)
        Dim min As Integer = num1 - num2
        Dim subString As String = num1 & " - " & num2 & " = " & min
        operationTextBox.Text = subString
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim num1 As Integer = Val(TextBox1.Text)
        Dim num2 As Integer = Val(TextBox2.Text)
        Dim mul As Integer = num1 * num2
        Dim mulString As String = num1 & " * " & num2 & " = " & mul
        operationTextBox.Text = mulString
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim num1 As Integer = Val(TextBox1.Text)
        Dim num2 As Integer = Val(TextBox2.Text)
        Dim div As Double = num1 / num2
        Dim divString As String = num1 & " / " & num2 & " = " & div
        operationTextBox.Text = divString
    End Sub
End Class
