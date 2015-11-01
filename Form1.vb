Public Class Form1
    Dim valor1, valor2 As Double
    Dim operacion As Double
    Dim resultado As Double
    Dim punto As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = TextBox1.Text & "1"

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = TextBox1.Text & "2"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = TextBox1.Text & "3"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text = TextBox1.Text & "4"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = TextBox1.Text & "5"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = TextBox1.Text & "6"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox1.Text = TextBox1.Text & "7"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = TextBox1.Text & "8"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = TextBox1.Text & "9"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text = TextBox1.Text & "0"
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        TextBox1.Text = TextBox1.Text & "."
        punto = 1
        If punto = 1 Then
            Button14.Enabled = False
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        operacion = 1
        valor1 = Val(TextBox1.Text)
        TextBox1.Clear()
        Button14.Enabled = True
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        TextBox1.Clear()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Button14.Enabled = True
        valor2 = Val(TextBox1.Text)

        If operacion = 1 Then
            resultado = valor1 + valor2
            TextBox1.Text = resultado

        ElseIf operacion = 2 Then
            resultado = valor1 - valor2
            TextBox1.Text = resultado

        ElseIf operacion = 3 Then
            resultado = valor1 * valor2
            TextBox1.Text = resultado

        ElseIf operacion = 4 Then
            resultado = valor1 / valor2
            TextBox1.Text = resultado

        End If


    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        operacion = 2
        valor1 = Val(TextBox1.Text)
        TextBox1.Clear()
        Button14.Enabled = True
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        operacion = 3
        valor1 = Val(TextBox1.Text)
        TextBox1.Clear()
        Button14.Enabled = True
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        operacion = 4
        valor1 = Val(TextBox1.Text)
        TextBox1.Clear()
        Button14.Enabled = True
    End Sub
End Class
