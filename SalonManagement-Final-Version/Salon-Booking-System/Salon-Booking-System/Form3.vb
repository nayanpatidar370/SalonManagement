Imports System.Data.SqlClient
Public Class Form3
    Dim slot As String
    Dim Barber As String
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim Table_Name As String

    'Clicking on home button, will take the user to the home page, and booking form will be closed.
    Private Sub HomeButton1_Click(sender As Object, e As EventArgs) Handles Home.Click
        Form1.Show()
        Me.Close()
    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Hide()
        Groupbox2.Hide()

        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\OneDrive\Desktop\SalonManagement-Version-UI Final\SalonManagement-Version-UI\Salon-Booking-System\Salon-Booking-System\KNKSalon.mdf;Integrated Security=True"

        Dim cultureInfo As New Globalization.CultureInfo("en-US")
        cultureInfo.DateTimeFormat.ShortDatePattern = "yyyy-MM-dd"
        System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo

        Guna2DateTimePicker1.CustomFormat = "dd-MM-yyyy"

        If con.State = ConnectionState.Open Then
            con.Close()
        Else
            con.Open()
        End If
    End Sub
    Private Sub Guna2DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles Guna2DateTimePicker1.ValueChanged
        Guna2DateTimePicker1.MinDate = DateTime.Today
        Guna2DateTimePicker1.MaxDate = DateTime.Today.AddMonths(2)
        'MsgBox(Guna2DateTimePicker1.Value)
    End Sub

    'Code for Choosing Barber
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GroupBox1.Show()
        Panel1.Hide()
        Groupbox2.Show()
        SelectedBarber.ImageLocation = ("C:\Users\dell\OneDrive\Desktop\SalonManagement-Version-UI Final\SalonManagement-Version-UI\Pictures\mf3.png")
        SelectedBarberLabel.Text = "Mohit"
        Barber = "Mohit"
        Table_Name = "[Mohit]"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        GroupBox1.Show()
        Panel1.Hide()
        Groupbox2.Show()
        SelectedBarber.ImageLocation = ("C:\Users\dell\OneDrive\Desktop\SalonManagement-Version-UI Final\SalonManagement-Version-UI\Pictures\lf3.png")
        SelectedBarberLabel.Text = "Lakshya"
        Table_Name = "[Lakshya]"
        Barber = "Lakshya"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        GroupBox1.Show()
        Panel1.Hide()
        Groupbox2.Show()
        SelectedBarber.ImageLocation = ("C:\Users\dell\OneDrive\Desktop\SalonManagement-Version-UI Final\SalonManagement-Version-UI\Pictures\nf3.png")
        SelectedBarberLabel.Text = "Nimesh"
        Barber = "Nimesh"
        Table_Name = "[Nimesh]"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        GroupBox1.Show()
        Panel1.Hide()
        Groupbox2.Show()
        SelectedBarber.ImageLocation = ("C:\Users\dell\OneDrive\Desktop\SalonManagement-Version-UI Final\SalonManagement-Version-UI\Pictures\jf3.png")
        SelectedBarberLabel.Text = "Jasprit"
        Barber = "Jasprit"
        Table_Name = "[Jasprit]"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        GroupBox1.Show()
        Panel1.Hide()
        Groupbox2.Show()
        SelectedBarber.ImageLocation = ("C:\Users\dell\OneDrive\Desktop\SalonManagement-Version-UI Final\SalonManagement-Version-UI\Pictures\af3.png")
        SelectedBarberLabel.Text = "Ali"
        Barber = "Ali"
        Table_Name = "[Ali]"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Barber = Nothing Or slot = Nothing Or Guna2ComboBox1.SelectedIndex = -1 Then
            MessageBox.Show("Please select all the fields!", "Insufficient details", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text

                If slot = "10:00 - 11:00" Then
                    cmd.CommandText = "insert into " + Table_Name + " values ('" + Guna2GradientButton10.Text + "','" + Guna2DateTimePicker1.Value + "','" + Guna2ComboBox1.Text + "')"

                ElseIf slot = "11:00 - 12:00" Then
                    cmd.CommandText = "insert into " + Table_Name + " values ('" + Guna2GradientButton6.Text + "','" + Guna2DateTimePicker1.Value + "','" + Guna2ComboBox1.Text + "')"

                ElseIf slot = "16:00 - 17:00" Then
                    cmd.CommandText = "insert into " + Table_Name + " values ('" + Guna2GradientButton7.Text + "','" + Guna2DateTimePicker1.Value + "','" + Guna2ComboBox1.Text + "')"

                ElseIf slot = "17:00 - 18:00" Then
                    cmd.CommandText = "insert into " + Table_Name + " values ('" + Guna2GradientButton11.Text + "','" + Guna2DateTimePicker1.Value + "','" + Guna2ComboBox1.Text + "')"

                ElseIf slot = "18:00 - 19:00" Then
                    cmd.CommandText = "insert into " + Table_Name + " values ('" + Guna2GradientButton9.Text + "','" + Guna2DateTimePicker1.Value + "','" + Guna2ComboBox1.Text + "')"

                ElseIf slot = "19:00 - 20:00" Then
                    cmd.CommandText = "insert into " + Table_Name + " values ('" + Guna2GradientButton8.Text + "','" + Guna2DateTimePicker1.Value + "','" + Guna2ComboBox1.Text + "')"
                End If

                cmd.ExecuteNonQuery()

                If slot = "10:00 - 11:00" Then
                    MessageBox.Show("Appointment booked on " + Guna2DateTimePicker1.Text + " from " + Guna2GradientButton10.Text + " hours ", "Booking Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ElseIf slot = "11:00 - 12:00" Then
                    MessageBox.Show("Appointment booked on " + Guna2DateTimePicker1.Text + " from " + Guna2GradientButton6.Text + " hours ", "Booking Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ElseIf slot = "16:00 - 17:00" Then
                    MessageBox.Show("Appointment booked on " + Guna2DateTimePicker1.Text + " from " + Guna2GradientButton7.Text + " hours ", "Booking Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ElseIf slot = "17:00 - 18:00" Then
                    MessageBox.Show("Appointment booked on " + Guna2DateTimePicker1.Text + " from " + Guna2GradientButton11.Text + " hours ", "Booking Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ElseIf slot = "18:00 - 19:00" Then
                    MessageBox.Show("Appointment booked on " + Guna2DateTimePicker1.Text + " from " + Guna2GradientButton9.Text + " hours ", "Booking Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ElseIf slot = "19:00 - 20:00" Then
                    MessageBox.Show("Appointment booked on " + Guna2DateTimePicker1.Text + " from " + Guna2GradientButton8.Text + " hours ", "Booking Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                Me.Close()
                Form1.Show()

            Catch ex As SqlException
                If slot = "10:00 - 11:00" Then
                    MessageBox.Show("Barber already booked for " + Guna2GradientButton10.Text + " hours on " + Guna2DateTimePicker1.Text, "Booking Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf slot = "11:00 - 12:00" Then
                    MessageBox.Show("Barber already booked for " + Guna2GradientButton10.Text + " hours on " + Guna2DateTimePicker1.Text, "Booking Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf slot = "16:00 - 17:00" Then
                    MessageBox.Show("Barber already booked for " + Guna2GradientButton10.Text + " hours on " + Guna2DateTimePicker1.Text, "Booking Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf slot = "17:00 - 18:00" Then
                    MessageBox.Show("Barber already booked for " + Guna2GradientButton10.Text + " hours on " + Guna2DateTimePicker1.Text, "Booking Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf slot = "18:00 - 19:00" Then
                    MessageBox.Show("Barber already booked for " + Guna2GradientButton10.Text + " hours on " + Guna2DateTimePicker1.Text, "Booking Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf slot = "19:00 - 20:00" Then
                    MessageBox.Show("Barber already booked for " + Guna2GradientButton10.Text + " hours on " + Guna2DateTimePicker1.Text, "Booking Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Try
        End If
    End Sub

    Private Sub ReChoose_Click(sender As Object, e As EventArgs) Handles ReChoose.Click
        GroupBox1.Hide()
        Groupbox2.Hide()
        Panel1.Show()
        Guna2ComboBox1.SelectedIndex = -1

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
        Guna2GradientButton11.FillColor = Color.FromArgb(216, 185, 132)
        Guna2GradientButton11.FillColor2 = Color.FromArgb(233, 218, 193)

        Guna2GradientButton6.ForeColor = Color.FromArgb(57, 49, 42)
        Guna2GradientButton7.ForeColor = Color.FromArgb(57, 49, 42)
        Guna2GradientButton8.ForeColor = Color.FromArgb(57, 49, 42)
        Guna2GradientButton9.ForeColor = Color.FromArgb(57, 49, 42)
        Guna2GradientButton10.ForeColor = Color.FromArgb(57, 49, 42)
        Guna2GradientButton11.ForeColor = Color.FromArgb(57, 49, 42)
    End Sub

    'Code for time-slot booking buttons
    Private Sub Guna2GradientButton6_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton6.Click
        slot = "11:00 - 12:00"

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

    Private Sub Guna2GradientButton7_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton7.Click
        slot = "16:00 - 17:00"

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

    Private Sub Guna2GradientButton8_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton8.Click
        slot = "19:00 - 20:00"

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
    Private Sub Guna2GradientButton9_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton9.Click
        slot = "18:00 - 19:00"

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

    Private Sub Guna2GradientButton10_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton10.Click
        slot = "10:00 - 11:00"

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

    Private Sub Guna2GradientButton11_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton11.Click
        slot = "17:00 - 18:00"

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
End Class