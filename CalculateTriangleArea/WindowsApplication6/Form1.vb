Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Getting the values of sides from textboxes'
        Dim a As Double = Val(tba.Text)
        Dim b As Double = Val(tbb.Text)
        Dim c As Double = Val(tbc.Text)
        'Calculating the semi perimter of the triangle'
        Dim s As Double = (a + b + c) / 2
        'Applying Heron's formula to calculate area'
        Dim area As Double = Math.Sqrt(s * (s - a) * (s - b) * (s - c))

        Dim str As String = "The area of the Triangle = " & area.ToString("0.000")
        MessageBox.Show(str, "Area")
    End Sub
End Class
