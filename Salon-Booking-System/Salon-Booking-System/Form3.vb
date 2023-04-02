Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Form3
    Private Sub HomeButton1_Click(sender As Object, e As EventArgs) Handles Home.Click
        Form1.Show()
        Me.Hide()
        GroupBox1.Hide()
        Panel1.Show()
        Groupbox2.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GroupBox1.Show()
        Panel1.Hide()
        Groupbox2.Show()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Hide()
        Groupbox2.Hide()
    End Sub

    Private Sub Guna2HtmlLabel6_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel6.Click

    End Sub

    Private Sub Guna2DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles Guna2DateTimePicker1.ValueChanged

    End Sub

    Private Sub ReChoose_Click(sender As Object, e As EventArgs) Handles ReChoose.Click
        GroupBox1.Hide()
        Panel1.Show()
        Groupbox2.Hide()
    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton3.Click

    End Sub

    Private Sub Guna2GradientButton7_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton7.Click

    End Sub
End Class