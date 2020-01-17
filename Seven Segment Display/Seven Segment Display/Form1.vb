Public Class Form1
    Private counter As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        counter += 1

        If counter = 1 Then
            Button1.BackColor = Color.Gray
            Button2.BackColor = Color.Gray
            Button3.BackColor = Color.Red
            Button4.BackColor = Color.Gray
            Button5.BackColor = Color.Gray
            Button6.BackColor = Color.Red
            Button7.BackColor = Color.Gray
        End If

        If counter = 2 Then
            Button1.BackColor = Color.Red
            Button2.BackColor = Color.Gray
            Button3.BackColor = Color.Red
            Button4.BackColor = Color.Red
            Button5.BackColor = Color.Red
            Button6.BackColor = Color.Gray
            Button7.BackColor = Color.Red
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = TimeSpan.FromSeconds(1).TotalMilliseconds
        Timer1.Start()
        Button1.BackColor = Color.Red
        Button2.BackColor = Color.Red
        Button3.BackColor = Color.Red
        Button4.BackColor = Color.Gray
        Button5.BackColor = Color.Red
        Button6.BackColor = Color.Red
        Button7.BackColor = Color.Red



    End Sub
End Class
