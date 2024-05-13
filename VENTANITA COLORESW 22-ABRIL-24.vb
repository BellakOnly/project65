Public Class Form1



    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Text = ComboBox1.Text
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim f As Integer
        For f = 0 To 255
            ComboBox2.Items.Add(f)
            ComboBox3.Items.Add(f)
            ComboBox4.Items.Add(f)
        Next
        ComboBox2.SelectedIndex = 0
        ComboBox3.SelectedIndex = 0
        ComboBox4.SelectedIndex = 0

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rojo As Integer = ComboBox2.Text
        Dim verde As Integer = ComboBox2.Text
        Dim azul As Integer = ComboBox3.Text
        BackColor = Color.FromArgb(rojo, verde, azul)
    End Sub

    Private Sub ARCHIVOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ARCHIVOToolStripMenuItem.Click
        MsgBox("ABRIR HDSTPM")

    End Sub
End Class
