Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports System.Data.SqlClient
Imports Guna.UI2.WinForms
Public Class Form3
    Dim slot As String
    Dim Barber As String
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim Table_Name As String
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Hide()
        Groupbox2.Hide()
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hemah\Desktop\SalonManagement-Version-UI Final\SalonManagement-Version-UI\Salon-Booking-System\Salon-Booking-System\KNKSalon.mdf;Integrated Security=True"
        Guna2DateTimePicker1.CustomFormat = "dd-MM-yyyy"
        If con.State = ConnectionState.Open Then
            con.Close()

        End If

        con.Open()
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
        SelectedBarber.ImageLocation = ("C:\Users\hemah\Desktop\SalonManagement-Version-UI Final\SalonManagement-Version-UI\Pictures\mf3.png")
        SelectedBarberLabel.Text = "Mohit"
        Barber = "Mohit"
        Table_Name = "[Mohit]"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        GroupBox1.Show()
        Panel1.Hide()
        Groupbox2.Show()
        SelectedBarber.ImageLocation = ("C:\Users\hemah\Desktop\SalonManagement-Version-UI Final\SalonManagement-Version-UI\Pictures\lf3.png")
        SelectedBarberLabel.Text = "Lakshya"
        Table_Name = "[Lakshya]"
        Barber = "Lakshya"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        GroupBox1.Show()
        Panel1.Hide()
        Groupbox2.Show()
        SelectedBarber.ImageLocation = ("C:\Users\hemah\Desktop\SalonManagement-Version-UI Final\SalonManagement-Version-UI\Pictures\nf3.png")
        SelectedBarberLabel.Text = "Nimesh"
        Barber = "Nimesh"
        Table_Name = "[Nimesh]"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        GroupBox1.Show()
        Panel1.Hide()
        Groupbox2.Show()
        SelectedBarber.ImageLocation = ("C:\Users\hemah\Desktop\SalonManagement-Version-UI Final\SalonManagement-Version-UI\Pictures\jf3.png")
        SelectedBarberLabel.Text = "Jasprit"
        Barber = "Jasprit"
        Table_Name = "[Jasprit]"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        GroupBox1.Show()
        Panel1.Hide()
        Groupbox2.Show()
        SelectedBarber.ImageLocation = ("C:\Users\hemah\Desktop\SalonManagement-Version-UI Final\SalonManagement-Version-UI\Pictures\af3.png")
        SelectedBarberLabel.Text = "Ali"
        Barber = "Ali"
        Table_Name = "[Ali]"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text

            If slot = "10:00 - 11:00" Then
                cmd.CommandText = "insert into " + Table_Name + " values ('" + Guna2GradientButton10.Text + "','" + Guna2DateTimePicker1.Text + "','" + Guna2ComboBox1.Text + "')"

            ElseIf slot = "11:00 - 12:00" Then
                cmd.CommandText = "insert into " + Table_Name + " values ('" + Guna2GradientButton10.Text + "','" + Guna2DateTimePicker1.Text + "','" + Guna2ComboBox1.Text + "')"

            ElseIf slot = "16:00 - 17:00" Then
                cmd.CommandText = "insert into " + Table_Name + " values ('" + Guna2GradientButton10.Text + "','" + Guna2DateTimePicker1.Text + "','" + Guna2ComboBox1.Text + "')"

            ElseIf slot = "17:00 - 18:00" Then
                cmd.CommandText = "insert into " + Table_Name + " values ('" + Guna2GradientButton10.Text + "','" + Guna2DateTimePicker1.Text + "','" + Guna2ComboBox1.Text + "')"

            ElseIf slot = "18:00 - 19:00" Then
                cmd.CommandText = "insert into " + Table_Name + " values ('" + Guna2GradientButton10.Text + "','" + Guna2DateTimePicker1.Text + "','" + Guna2ComboBox1.Text + "')"

            ElseIf slot = "19:00 - 20:00" Then
                cmd.CommandText = "insert into " + Table_Name + " values ('" + Guna2GradientButton10.Text + "','" + Guna2DateTimePicker1.Text + "','" + Guna2ComboBox1.Text + "')"
            End If
            cmd.ExecuteNonQuery()

            If slot = "10:00 - 11:00" Then
                MessageBox.Show("Appointment Booked On " + Guna2DateTimePicker1.Text + " At " + Guna2GradientButton10.Text)
            ElseIf slot = "11:00 - 12:00" Then
                MessageBox.Show("Appointment Booked On " + Guna2DateTimePicker1.Text + " At " + Guna2GradientButton6.Text)
            ElseIf slot = "16:00 - 17:00" Then
                MessageBox.Show("Appointment Booked On " + Guna2DateTimePicker1.Text + " At " + Guna2GradientButton7.Text)
            ElseIf slot = "17:00 - 18:00" Then
                MessageBox.Show("Appointment Booked On " + Guna2DateTimePicker1.Text + " At " + Guna2GradientButton11.Text)
            ElseIf slot = "18:00 - 19:00" Then
                MessageBox.Show("Appointment Booked On " + Guna2DateTimePicker1.Text + " At " + Guna2GradientButton9.Text)
            ElseIf slot = "19:00 - 20:00" Then
                MessageBox.Show("Appointment Booked On " + Guna2DateTimePicker1.Text + " At " + Guna2GradientButton8.Text)
            End If

        Catch ex As Exception
            If slot = "10:00 - 11:00" Then
                MessageBox.Show("Barber Already Booked for " + Guna2GradientButton10.Text)
            ElseIf slot = "11:00 - 12:00" Then
                MessageBox.Show("Barber Already Booked for " + Guna2GradientButton6.Text)
            ElseIf slot = "16:00 - 17:00" Then
                MessageBox.Show("Barber Already Booked for " + Guna2GradientButton7.Text)
            ElseIf slot = "17:00 - 18:00" Then
                MessageBox.Show("Barber Already Booked for " + Guna2GradientButton11.Text)
            ElseIf slot = "18:00 - 19:00" Then
                MessageBox.Show("Barber Already Booked for " + Guna2GradientButton9.Text)
            ElseIf slot = "19:00 - 20:00" Then
                MessageBox.Show("Barber Already Booked for " + Guna2GradientButton8.Text)
            End If

        End Try
    End Sub

    Private Sub ReChoose_Click(sender As Object, e As EventArgs) Handles ReChoose.Click
        GroupBox1.Hide()
        Panel1.Show()
        Groupbox2.Hide()
    End Sub

    'Code for time-slot booking buttons
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
        slot = "11:00 - 12:00"
    End Sub

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
        slot = "16:00 - 17:00"
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
        slot = "19:00 - 20:00"
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
        slot = "18:00 - 19:00"
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
        slot = "10:00 - 11:00"
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
        slot = "17:00 - 18:00"
    End Sub

    Private Sub Guna2DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles Guna2DateTimePicker1.ValueChanged
        Guna2DateTimePicker1.MinDate = DateTime.Today
        Guna2DateTimePicker1.MaxDate = DateTime.Today.AddMonths(6)
    End Sub


End Class