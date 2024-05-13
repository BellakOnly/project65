Public Class Form1
    Dim x As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = 0
        Timer1.Enabled = True
        Timer1.Interval = 1000
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        x = x + 2
        Label1.Text = x
        If x = 10 Then
            Timer1.Enabled = False
            MsgBox("conteo finalizado", MsgBoxStyle.Information, "AVISO")
            Me.Hide()
            form2.Show()
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
