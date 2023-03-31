Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BarberDataSet1.Barber' table. You can move, or remove it, as needed.
        Me.BarberTableAdapter.Fill(Me.BarberDataSet1.Barber)
        'TODO: This line of code loads data into the 'BarberDataSet.Barber' table. You can move, or remove it, as needed.



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        BarberBindingSource.AddNew()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BarberBindingSource.EndEdit()
        BarberTableAdapter.Update(BarberDataSet1)
    End Sub

    Private Sub BarberBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.BarberBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BarberDataSet1)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.BarberTableAdapter.FillBy(Me.BarberDataSet1.Barber)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillBy1ToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.BarberTableAdapter.FillBy(Me.BarberDataSet1.Barber)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByToolStripButton_Click_1(sender As Object, e As EventArgs) Handles FillByToolStripButton.Click
        Try
            Me.BarberTableAdapter.FillBy(Me.BarberDataSet1.Barber)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class