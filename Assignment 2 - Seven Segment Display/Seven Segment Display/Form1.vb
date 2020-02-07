Public Class Form1
    Private counter As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If counter = 0 Then
            Button1.BackColor = Color.Red
            Button2.BackColor = Color.Red
            Button3.BackColor = Color.Red
            Button4.BackColor = Color.Black
            Button5.BackColor = Color.Red
            Button6.BackColor = Color.Red
            Button7.BackColor = Color.Red
        End If

        If counter = 1 Then
            Button1.BackColor = Color.Black
            Button2.BackColor = Color.Black
            Button3.BackColor = Color.Red
            Button4.BackColor = Color.Black
            Button5.BackColor = Color.Black
            Button6.BackColor = Color.Red
            Button7.BackColor = Color.Black
        End If

        If counter = 2 Then
            Button1.BackColor = Color.Red
            Button2.BackColor = Color.Black
            Button3.BackColor = Color.Red
            Button4.BackColor = Color.Red
            Button5.BackColor = Color.Red
            Button6.BackColor = Color.Black
            Button7.BackColor = Color.Red
        End If

        If counter = 3 Then
            Button1.BackColor = Color.Red
            Button2.BackColor = Color.Black
            Button3.BackColor = Color.Red
            Button4.BackColor = Color.Red
            Button5.BackColor = Color.Red
            Button6.BackColor = Color.Red
            Button7.BackColor = Color.Black
        End If

        If counter = 4 Then
            Button1.BackColor = Color.Black
            Button2.BackColor = Color.Red
            Button3.BackColor = Color.Red
            Button4.BackColor = Color.Red
            Button5.BackColor = Color.Black
            Button6.BackColor = Color.Red
            Button7.BackColor = Color.Black
        End If

        If counter = 5 Then
            Button1.BackColor = Color.Red
            Button2.BackColor = Color.Red
            Button3.BackColor = Color.Black
            Button4.BackColor = Color.Red
            Button5.BackColor = Color.Red
            Button6.BackColor = Color.Red
            Button7.BackColor = Color.Black
        End If

        If counter = 6 Then
            Button1.BackColor = Color.Red
            Button2.BackColor = Color.Red
            Button3.BackColor = Color.Black
            Button4.BackColor = Color.Red
            Button5.BackColor = Color.Red
            Button6.BackColor = Color.Red
            Button7.BackColor = Color.Red
        End If

        If counter = 7 Then
            Button1.BackColor = Color.Red
            Button2.BackColor = Color.Black
            Button3.BackColor = Color.Red
            Button4.BackColor = Color.Black
            Button5.BackColor = Color.Black
            Button6.BackColor = Color.Red
            Button7.BackColor = Color.Black
        End If

        If counter = 8 Then
            Button1.BackColor = Color.Red
            Button2.BackColor = Color.Red
            Button3.BackColor = Color.Red
            Button4.BackColor = Color.Red
            Button5.BackColor = Color.Red
            Button6.BackColor = Color.Red
            Button7.BackColor = Color.Red
        End If

        If counter = 9 Then
            Button1.BackColor = Color.Red
            Button2.BackColor = Color.Red
            Button3.BackColor = Color.Red
            Button4.BackColor = Color.Red
            Button5.BackColor = Color.Red
            Button6.BackColor = Color.Red
            Button7.BackColor = Color.Black
            counter = 0
        Else
            counter += 1
        End If

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = TimeSpan.FromSeconds(1).TotalMilliseconds
        Timer1.Start()



    End Sub
End Class
