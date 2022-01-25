Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim yr As Integer
        yr = Val(TextBox1.Text)

        Dim msg As String
        msg = yr & " leap year"

        Dim msg2 As String
        msg2 = yr & " Not a leap year"

        If yr Mod 400 = 0 Then
            TextBox2.Text = msg
        ElseIf yr Mod 100 = 0 Then
            TextBox2.Text = msg2
        ElseIf yr Mod 4 = 0 Then
            TextBox2.Text = msg
        Else
            TextBox2.Text = msg2
        End If

    End Sub
End Class
