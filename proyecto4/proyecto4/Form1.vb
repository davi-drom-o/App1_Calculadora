Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Numero1.Click

    End Sub

    Private Sub mas_Click(sender As Object, e As EventArgs) Handles mas.Click
        Dim Numero1 As Integer = Integer.Parse(num1.Text)
        Dim Numero2 As Integer = Integer.Parse(num2.Text)

        Dim resultado As Integer = Numero1 + Numero2

        Label4.Text = resultado.ToString()
    End Sub

    Private Sub menos_Click(sender As Object, e As EventArgs) Handles menos.Click
        Dim Numero1 As Integer = Integer.Parse(num1.Text)
        Dim Numero2 As Integer = Integer.Parse(num2.Text)

        Dim resultado As Integer = Numero1 - Numero2

        Label4.Text = resultado.ToString()
    End Sub

    Private Sub entre_Click(sender As Object, e As EventArgs) Handles entre.Click
        Dim Numero1 As Integer = Integer.Parse(num1.Text)
        Dim Numero2 As Integer = Integer.Parse(num2.Text)

        Dim resultado As Integer = Numero1 / Numero2

        Label4.Text = resultado.ToString()
    End Sub

    Private Sub por_Click(sender As Object, e As EventArgs) Handles por.Click
        Dim Numero1 As Integer = Integer.Parse(num1.Text)
        Dim Numero2 As Integer = Integer.Parse(num2.Text)

        Dim resultado As Integer = Numero1 * Numero2

        Label4.Text = resultado.ToString()
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        num1.Text = num1.Text & "0"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        num1.Text = num1.Text & "1"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        num1.Text = num1.Text & "2"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        num1.Text = num1.Text & "3"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        num1.Text = num1.Text & "4"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        num1.Text = num1.Text & "5"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        num1.Text = num1.Text & "6"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        num1.Text = num1.Text & "7"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        num1.Text = num1.Text & "8"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        num1.Text = num1.Text & "9"
    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        num1.Text = ""
    End Sub
End Class