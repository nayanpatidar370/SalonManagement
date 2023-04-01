Imports System.Data.OleDb
Public Class Form3

    Public cr As Integer

    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\nayan\source\repos\SalonManagement\Salon-Booking-System\Salon-Booking-System\obj\Debug\Barber.mdb")
    Dim da As New OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Dim str As String

    Private Sub HomeButton1_Click(sender As Object, e As EventArgs) Handles Home.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Panel1.Hide()

    End Sub

    Private Sub Guna2HtmlLabel4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cr = 0

        con.Open()
        str = "select * from Barber"
        da = New OleDbDataAdapter(str, con)
        da.Fill(ds, "Barber")





    End Sub

    Private Sub showdata(ByVal cr As Integer)
        TextBox1.Text = ds.Tables(0).Rows(cr)("B_ID")
        TextBox2.Text = ds.Tables(0).Rows(cr)("B_Name").ToString




    End Sub

    Private Sub Guna2DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles Guna2DateTimePicker1.ValueChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        str = $"insert into appointment(B_Name) values('{TextBox2.Text}')"

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If cr <> 0 Then
            cr -= 1
            showdata(cr)
        Else
            MsgBox("First Record is reached")
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If cr <> ds.Tables("Barber").Rows.Count - 1 Then
            cr += 1
            showdata(cr)
        Else
            MsgBox("Last Record Reached")

        End If
    End Sub
End Class