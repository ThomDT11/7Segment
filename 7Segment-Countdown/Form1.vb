Public Class Form1


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles I.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text += 1
        If Label2.Text = 0 Then
            I.BackColor = Color.RoyalBlue
            II.BackColor = Color.RoyalBlue
            III.BackColor = Color.RoyalBlue
            IV.BackColor = Color.White
            V.BackColor = Color.RoyalBlue
            VI.BackColor = Color.RoyalBlue
            VII.BackColor = Color.RoyalBlue
        ElseIf Label2.Text = 1 Then
            I.BackColor = Color.RoyalBlue
            II.BackColor = Color.RoyalBlue
            III.BackColor = Color.White
            IV.BackColor = Color.White
            V.BackColor = Color.White
            VI.BackColor = Color.White
            VII.BackColor = Color.White
        ElseIf Label2.Text = 2 Then
            I.BackColor = Color.RoyalBlue
            II.BackColor = Color.White
            III.BackColor = Color.RoyalBlue
            IV.BackColor = Color.RoyalBlue
            V.BackColor = Color.RoyalBlue
            VI.BackColor = Color.White
            VII.BackColor = Color.RoyalBlue
        ElseIf Label2.Text = 3 Then
            I.BackColor = Color.RoyalBlue
            II.BackColor = Color.RoyalBlue
            III.BackColor = Color.RoyalBlue
            IV.BackColor = Color.RoyalBlue
            V.BackColor = Color.RoyalBlue
            VI.BackColor = Color.White
            VII.BackColor = Color.White
        ElseIf Label2.Text = 4 Then
            I.BackColor = Color.RoyalBlue
            II.BackColor = Color.RoyalBlue
            III.BackColor = Color.White
            IV.BackColor = Color.RoyalBlue
            V.BackColor = Color.White
            VI.BackColor = Color.RoyalBlue
            VII.BackColor = Color.White
        ElseIf Label2.Text = 5 Then
            I.BackColor = Color.White
            II.BackColor = Color.RoyalBlue
            III.BackColor = Color.RoyalBlue
            IV.BackColor = Color.RoyalBlue
            V.BackColor = Color.RoyalBlue
            VI.BackColor = Color.RoyalBlue
            VII.BackColor = Color.White
        ElseIf Label2.Text = 6 Then
            I.BackColor = Color.White
            II.BackColor = Color.RoyalBlue
            III.BackColor = Color.RoyalBlue
            IV.BackColor = Color.RoyalBlue
            V.BackColor = Color.RoyalBlue
            VI.BackColor = Color.RoyalBlue
            VII.BackColor = Color.RoyalBlue
        ElseIf Label2.Text = 7 Then
            I.BackColor = Color.RoyalBlue
            II.BackColor = Color.RoyalBlue
            III.BackColor = Color.RoyalBlue
            IV.BackColor = Color.White
            V.BackColor = Color.White
            VI.BackColor = Color.White
            VII.BackColor = Color.White
        ElseIf Label2.Text = 8 Then
            I.BackColor = Color.RoyalBlue
            II.BackColor = Color.RoyalBlue
            III.BackColor = Color.RoyalBlue
            IV.BackColor = Color.RoyalBlue
            V.BackColor = Color.RoyalBlue
            VI.BackColor = Color.RoyalBlue
            VII.BackColor = Color.RoyalBlue
        ElseIf Label2.Text = 9 Then
            I.BackColor = Color.RoyalBlue
            II.BackColor = Color.RoyalBlue
            III.BackColor = Color.RoyalBlue
            IV.BackColor = Color.RoyalBlue
            V.BackColor = Color.RoyalBlue
            VI.BackColor = Color.RoyalBlue
            VII.BackColor = Color.White
        Else
            Label2.Text = 0
            I.BackColor = Color.RoyalBlue
            II.BackColor = Color.RoyalBlue
            III.BackColor = Color.RoyalBlue
            IV.BackColor = Color.White
            V.BackColor = Color.RoyalBlue
            VI.BackColor = Color.RoyalBlue
            VII.BackColor = Color.RoyalBlue
        End If
    End Sub
End Class
