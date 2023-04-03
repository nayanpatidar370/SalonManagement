Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Hide()
        Groupbox2.Hide()
    End Sub

    'Clicking on home button, will take the user to the home page, and booking form will be closed.
    Private Sub HomeButton1_Click(sender As Object, e As EventArgs) Handles Home.Click
        Form1.Show()
        Me.Close()
    End Sub

    'Code for Choosing Barber
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GroupBox1.Show()
        Panel1.Hide()
        Groupbox2.Show()
        SelectedBarber.ImageLocation = ("D:\BCA Sem 4\Salon-Booking-Sytem\Pictures\mf3.png")
        SelectedBarberLabel.Text = "Mohit"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        GroupBox1.Show()
        Panel1.Hide()
        Groupbox2.Show()
        SelectedBarber.ImageLocation = ("D:\BCA Sem 4\Salon-Booking-Sytem\Pictures\lf3.png")
        SelectedBarberLabel.Text = "Lakshya"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        GroupBox1.Show()
        Panel1.Hide()
        Groupbox2.Show()
        SelectedBarber.ImageLocation = ("D:\BCA Sem 4\Salon-Booking-Sytem\Pictures\nf3.png")
        SelectedBarberLabel.Text = "Nimesh"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        GroupBox1.Show()
        Panel1.Hide()
        Groupbox2.Show()
        SelectedBarber.ImageLocation = ("D:\BCA Sem 4\Salon-Booking-Sytem\Pictures\jf3.png")
        SelectedBarberLabel.Text = "Jasprit"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        GroupBox1.Show()
        Panel1.Hide()
        Groupbox2.Show()
        SelectedBarber.ImageLocation = ("D:\BCA Sem 4\Salon-Booking-Sytem\Pictures\af3.png")
        SelectedBarberLabel.Text = "Ali"
    End Sub

    Private Sub ReChoose_Click(sender As Object, e As EventArgs) Handles ReChoose.Click
        GroupBox1.Hide()
        Panel1.Show()
        Groupbox2.Hide()
    End Sub

    'Code for time-slot booking buttons
    Private Sub Guna2GradientButton7_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton7.Click
        Guna2GradientButton7.FillColor = Color.FromArgb(57, 49, 42)
        Guna2GradientButton7.FillColor2 = Color.FromArgb(57, 49, 42)
        Guna2GradientButton7.ForeColor = Color.FromArgb(233, 218, 193)

        Guna2GradientButton10.FillColor = Color.FromArgb(216, 185, 132)
        Guna2GradientButton10.FillColor2 = Color.FromArgb(233, 218, 193)
        Guna2GradientButton11.FillColor = Color.FromArgb(216, 185, 132)
        Guna2GradientButton11.FillColor2 = Color.FromArgb(233, 218, 193)
        Guna2GradientButton6.FillColor = Color.FromArgb(216, 185, 132)
        Guna2GradientButton6.FillColor2 = Color.FromArgb(233, 218, 193)
        Guna2GradientButton9.FillColor = Color.FromArgb(216, 185, 132)
        Guna2GradientButton9.FillColor2 = Color.FromArgb(233, 218, 193)
        Guna2GradientButton8.FillColor = Color.FromArgb(216, 185, 132)
        Guna2GradientButton8.FillColor2 = Color.FromArgb(233, 218, 193)

        Guna2GradientButton8.ForeColor = Color.FromArgb(57, 49, 42)
        Guna2GradientButton9.ForeColor = Color.FromArgb(57, 49, 42)
        Guna2GradientButton10.ForeColor = Color.FromArgb(57, 49, 42)
        Guna2GradientButton11.ForeColor = Color.FromArgb(57, 49, 42)
        Guna2GradientButton6.ForeColor = Color.FromArgb(57, 49, 42)
    End Sub

    Private Sub Guna2GradientButton10_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton10.Click
        Guna2GradientButton10.FillColor = Color.FromArgb(57, 49, 42)
        Guna2GradientButton10.FillColor2 = Color.FromArgb(57, 49, 42)
        Guna2GradientButton10.ForeColor = Color.FromArgb(233, 218, 193)

        Guna2GradientButton11.FillColor = Color.FromArgb(216, 185, 132)
        Guna2GradientButton11.FillColor2 = Color.FromArgb(233, 218, 193)
        Guna2GradientButton6.FillColor = Color.FromArgb(216, 185, 132)
        Guna2GradientButton6.FillColor2 = Color.FromArgb(233, 218, 193)
        Guna2GradientButton9.FillColor = Color.FromArgb(216, 185, 132)
        Guna2GradientButton9.FillColor2 = Color.FromArgb(233, 218, 193)
        Guna2GradientButton8.FillColor = Color.FromArgb(216, 185, 132)
        Guna2GradientButton8.FillColor2 = Color.FromArgb(233, 218, 193)
        Guna2GradientButton7.FillColor = Color.FromArgb(216, 185, 132)
        Guna2GradientButton7.FillColor2 = Color.FromArgb(233, 218, 193)

        Guna2GradientButton6.ForeColor = Color.FromArgb(57, 49, 42)
        Guna2GradientButton7.ForeColor = Color.FromArgb(57, 49, 42)
        Guna2GradientButton8.ForeColor = Color.FromArgb(57, 49, 42)
        Guna2GradientButton9.ForeColor = Color.FromArgb(57, 49, 42)
        Guna2GradientButton11.ForeColor = Color.FromArgb(57, 49, 42)
    End Sub

    Private Sub Guna2GradientButton6_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton6.Click
        Guna2GradientButton6.FillColor = Color.FromArgb(57, 49, 42)
        Guna2GradientButton6.FillColor2 = Color.FromArgb(57, 49, 42)
        Guna2GradientButton6.ForeColor = Color.FromArgb(233, 218, 193)

        Guna2GradientButton7.FillColor = Color.FromArgb(216, 185, 132)
        Guna2GradientButton7.FillColor2 = Color.FromArgb(233, 218, 193)
        Guna2GradientButton9.FillColor = Color.FromArgb(216, 185, 132)
        Guna2GradientButton9.FillColor2 = Color.FromArgb(233, 218, 193)
        Guna2GradientButton8.FillColor = Color.FromArgb(216, 185, 132)
        Guna2GradientButton8.FillColor2 = Color.FromArgb(233, 218, 193)
        Guna2GradientButton10.FillColor = Color.FromArgb(216, 185, 132)
        Guna2GradientButton10.FillColor2 = Color.FromArgb(233, 218, 193)
        Guna2GradientButton11.FillColor = Color.FromArgb(216, 185, 132)
        Guna2GradientButton11.FillColor2 = Color.FromArgb(233, 218, 193)

        Guna2GradientButton10.ForeColor = Color.FromArgb(57, 49, 42)
        Guna2GradientButton7.ForeColor = Color.FromArgb(57, 49, 42)
        Guna2GradientButton8.ForeColor = Color.FromArgb(57, 49, 42)
        Guna2GradientButton9.ForeColor = Color.FromArgb(57, 49, 42)
        Guna2GradientButton11.ForeColor = Color.FromArgb(57, 49, 42)
    End Sub

    Private Sub Guna2GradientButton11_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton11.Click
        Guna2GradientButton11.FillColor = Color.FromArgb(57, 49, 42)
        Guna2GradientButton11.FillColor2 = Color.FromArgb(57, 49, 42)
        Guna2GradientButton11.ForeColor = Color.FromArgb(233, 218, 193)

        Guna2GradientButton6.FillColor = Color.FromArgb(216, 185, 132)
        Guna2GradientButton6.FillColor2 = Color.FromArgb(233, 218, 193)
        Guna2GradientButton7.FillColor = Color.FromArgb(216, 185, 132)
        Guna2GradientButton7.FillColor2 = Color.FromArgb(233, 218, 193)
        Guna2GradientButton9.FillColor = Color.FromArgb(216, 185, 132)
        Guna2GradientButton9.FillColor2 = Color.FromArgb(233, 218, 193)
        Guna2GradientButton8.FillColor = Color.FromArgb(216, 185, 132)
        Guna2GradientButton8.FillColor2 = Color.FromArgb(233, 218, 193)
        Guna2GradientButton10.FillColor = Color.FromArgb(216, 185, 132)
        Guna2GradientButton10.FillColor2 = Color.FromArgb(233, 218, 193)

        Guna2GradientButton6.ForeColor = Color.FromArgb(57, 49, 42)
        Guna2GradientButton7.ForeColor = Color.FromArgb(57, 49, 42)
        Guna2GradientButton8.ForeColor = Color.FromArgb(57, 49, 42)
        Guna2GradientButton9.ForeColor = Color.FromArgb(57, 49, 42)
        Guna2GradientButton10.ForeColor = Color.FromArgb(57, 49, 42)
    End Sub

    Private Sub Guna2GradientButton9_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton9.Click
        Guna2GradientButton9.FillColor = Color.FromArgb(57, 49, 42)
        Guna2GradientButton9.FillColor2 = Color.FromArgb(57, 49, 42)
        Guna2GradientButton9.ForeColor = Color.FromArgb(233, 218, 193)

        Guna2GradientButton8.FillColor = Color.FromArgb(216, 185, 132)
        Guna2GradientButton8.FillColor2 = Color.FromArgb(233, 218, 193)
        Guna2GradientButton10.FillColor = Color.FromArgb(216, 185, 132)
        Guna2GradientButton10.FillColor2 = Color.FromArgb(233, 218, 193)
        Guna2GradientButton11.FillColor = Color.FromArgb(216, 185, 132)
        Guna2GradientButton11.FillColor2 = Color.FromArgb(233, 218, 193)
        Guna2GradientButton6.FillColor = Color.FromArgb(216, 185, 132)
        Guna2GradientButton6.FillColor2 = Color.FromArgb(233, 218, 193)
        Guna2GradientButton7.FillColor = Color.FromArgb(216, 185, 132)
        Guna2GradientButton7.FillColor2 = Color.FromArgb(233, 218, 193)

        Guna2GradientButton6.ForeColor = Color.FromArgb(57, 49, 42)
        Guna2GradientButton7.ForeColor = Color.FromArgb(57, 49, 42)
        Guna2GradientButton8.ForeColor = Color.FromArgb(57, 49, 42)
        Guna2GradientButton10.ForeColor = Color.FromArgb(57, 49, 42)
        Guna2GradientButton11.ForeColor = Color.FromArgb(57, 49, 42)
    End Sub

    Private Sub Guna2GradientButton8_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton8.Click
        Guna2GradientButton8.FillColor = Color.FromArgb(57, 49, 42)
        Guna2GradientButton8.FillColor2 = Color.FromArgb(57, 49, 42)
        Guna2GradientButton8.ForeColor = Color.FromArgb(233, 218, 193)

        Guna2GradientButton9.FillColor = Color.FromArgb(216, 185, 132)
        Guna2GradientButton9.FillColor2 = Color.FromArgb(233, 218, 193)
        Guna2GradientButton10.FillColor = Color.FromArgb(216, 185, 132)
        Guna2GradientButton10.FillColor2 = Color.FromArgb(233, 218, 193)
        Guna2GradientButton11.FillColor = Color.FromArgb(216, 185, 132)
        Guna2GradientButton11.FillColor2 = Color.FromArgb(233, 218, 193)
        Guna2GradientButton6.FillColor = Color.FromArgb(216, 185, 132)
        Guna2GradientButton6.FillColor2 = Color.FromArgb(233, 218, 193)
        Guna2GradientButton7.FillColor = Color.FromArgb(216, 185, 132)
        Guna2GradientButton7.FillColor2 = Color.FromArgb(233, 218, 193)

        Guna2GradientButton6.ForeColor = Color.FromArgb(57, 49, 42)
        Guna2GradientButton7.ForeColor = Color.FromArgb(57, 49, 42)
        Guna2GradientButton10.ForeColor = Color.FromArgb(57, 49, 42)
        Guna2GradientButton9.ForeColor = Color.FromArgb(57, 49, 42)
        Guna2GradientButton11.ForeColor = Color.FromArgb(57, 49, 42)
    End Sub

End Class