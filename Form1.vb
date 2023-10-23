Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ListBox1.Items.Clear()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i, TextBox1A, TextBox2A, TextBox3A As Integer
        TextBox1A = TextBox1.Text
        TextBox2A = TextBox2.Text
        TextBox3A = TextBox3.Text
        For i = TextBox1A To TextBox2A Step +TextBox3A
            ListBox1.Items.Add(i)
        Next

        For i = TextBox1A To TextBox2A Step -TextBox3A
            ListBox1.Items.Add(i)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim i, TextBox2A, TextBox3A As Integer
        i = TextBox1.Text
        TextBox2A = TextBox2.Text
        TextBox3A = TextBox3.Text
        Do While i <= TextBox2A
            ListBox1.Items.Add(i)
            i = i + TextBox3A
        Loop
        Do While i >= TextBox2A
            ListBox1.Items.Add(i)
            i = i - TextBox3A
        Loop
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim i, TextBox2A, TextBox3A As Integer
        i = TextBox1.Text
        TextBox2A = TextBox2.Text
        TextBox3A = TextBox3.Text
        Do Until i > TextBox2A
            ListBox1.Items.Add(i)
            i = i + TextBox3A
        Loop
        Do Until i < TextBox2A
            ListBox1.Items.Add(i)
            i = i - TextBox3A
        Loop
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim i, TextBox1A, TextBox2A, TextBox3A As Integer
        TextBox1A = TextBox1.Text
        TextBox2A = TextBox2.Text
        TextBox3A = TextBox3.Text
        i = TextBox1A
        While i <= TextBox2A
            ListBox1.Items.Add(i)
            i += TextBox3A
        End While
        While i >= TextBox2A
            ListBox1.Items.Add(i)
            i -= TextBox3A
        End While
    End Sub
End Class
