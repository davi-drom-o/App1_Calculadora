Public Class Form1
    Dim activo
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Numero1.Click

    End Sub

    Private Sub mas_Click(sender As Object, e As EventArgs) Handles mas.Click
        Dim Numero1 As Double = Double.Parse(num1.Text)
        Dim Numero2 As Double = Double.Parse(num2.Text)

        Dim resultado As Double = Numero1 + Numero2

        Label4.Text = resultado.ToString()
    End Sub

    Private Sub menos_Click(sender As Object, e As EventArgs) Handles menos.Click
        Dim Numero1 As Double = Double.Parse(num1.Text)
        Dim Numero2 As Double = Double.Parse(num2.Text)

        Dim resultado As Double = Numero1 - Numero2

        Label4.Text = resultado.ToString()
    End Sub

    Private Sub entre_Click(sender As Object, e As EventArgs) Handles entre.Click

        Dim resultado

        Dim Numero1 As Double = Double.Parse(Me.num1.Text)
        Dim Numero2 As Double = Double.Parse(Me.num2.Text)

        If Numero2 > 0 Then
            resultado = Numero1 / Numero2
        Else
            resultado = "nah twin"
        End If

        Label4.Text = resultado.ToString()
    End Sub

    Private Sub por_Click(sender As Object, e As EventArgs) Handles por.Click
        Dim Numero1 As Double = Double.Parse(num1.Text)
        Dim Numero2 As Double = Double.Parse(num2.Text)

        Dim resultado As Double = Numero1 * Numero2

        Label4.Text = resultado.ToString()
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        activo.Text = activo.Text & "0"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        activo.Text = activo.Text & "1"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        activo.Text = activo.Text & "2"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        activo.Text = activo.Text & "3"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        activo.Text = activo.Text & "4"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        activo.Text = activo.Text & "5"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        activo.Text = activo.Text & "6"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        activo.Text = activo.Text & "7"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        activo.Text = activo.Text & "8"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        activo.Text = activo.Text & "9"
    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        activo.Text = ""
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        activo = num1
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        activo = num2
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        activo.Text = activo.Text & "."
    End Sub
End Class