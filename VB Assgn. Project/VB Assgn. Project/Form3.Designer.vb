<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillByToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.BarberBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BarberDataSet1 = New VB_Assgn.Project.BarberDataSet1()
        Me.BarberTableAdapter = New VB_Assgn.Project.BarberDataSet1TableAdapters.BarberTableAdapter()
        Me.TableAdapterManager = New VB_Assgn.Project.BarberDataSet1TableAdapters.TableAdapterManager()
        Me.BarberTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BarberDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BarberAvailabilityDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.BarberNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.FillByToolStrip.SuspendLayout()
        CType(Me.BarberBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarberDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(99, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Barber_ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(99, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Barber_Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(99, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Barber_Availability"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(99, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Barber_Date"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(238, 104)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(173, 22)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(238, 143)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(173, 22)
        Me.TextBox2.TabIndex = 5
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(238, 174)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(173, 22)
        Me.TextBox3.TabIndex = 6
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(238, 205)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(173, 22)
        Me.TextBox4.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(190, 292)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 31)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "ADD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(99, 233)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Barber_Time"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(238, 233)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(173, 22)
        Me.TextBox5.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(662, 84)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(461, 310)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(321, 292)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 31)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "ADD"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillByToolStripButton})
        Me.FillByToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(1902, 27)
        Me.FillByToolStrip.TabIndex = 13
        Me.FillByToolStrip.Text = "FillByToolStrip"
        '
        'FillByToolStripButton
        '
        Me.FillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton.Name = "FillByToolStripButton"
        Me.FillByToolStripButton.Size = New System.Drawing.Size(48, 24)
        Me.FillByToolStripButton.Text = "FillBy"
        '
        'BarberBindingSource
        '
        Me.BarberBindingSource.DataMember = "Barber"
        Me.BarberBindingSource.DataSource = Me.BarberDataSet1
        '
        'BarberDataSet1
        '
        Me.BarberDataSet1.DataSetName = "BarberDataSet1"
        Me.BarberDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BarberTableAdapter
        '
        Me.BarberTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BarberTableAdapter = Me.BarberTableAdapter
        Me.TableAdapterManager.UpdateOrder = VB_Assgn.Project.BarberDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BarberTimeDataGridViewTextBoxColumn
        '
        Me.BarberTimeDataGridViewTextBoxColumn.DataPropertyName = "Barber_Time"
        Me.BarberTimeDataGridViewTextBoxColumn.HeaderText = "Barber_Time"
        Me.BarberTimeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BarberTimeDataGridViewTextBoxColumn.Name = "BarberTimeDataGridViewTextBoxColumn"
        Me.BarberTimeDataGridViewTextBoxColumn.Width = 125
        '
        'BarberDateDataGridViewTextBoxColumn
        '
        Me.BarberDateDataGridViewTextBoxColumn.DataPropertyName = "Barber_Date"
        Me.BarberDateDataGridViewTextBoxColumn.HeaderText = "Barber_Date"
        Me.BarberDateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BarberDateDataGridViewTextBoxColumn.Name = "BarberDateDataGridViewTextBoxColumn"
        Me.BarberDateDataGridViewTextBoxColumn.Width = 125
        '
        'BarberAvailabilityDataGridViewCheckBoxColumn
        '
        Me.BarberAvailabilityDataGridViewCheckBoxColumn.DataPropertyName = "Barber_Availability"
        Me.BarberAvailabilityDataGridViewCheckBoxColumn.HeaderText = "Barber_Availability"
        Me.BarberAvailabilityDataGridViewCheckBoxColumn.MinimumWidth = 6
        Me.BarberAvailabilityDataGridViewCheckBoxColumn.Name = "BarberAvailabilityDataGridViewCheckBoxColumn"
        Me.BarberAvailabilityDataGridViewCheckBoxColumn.Width = 125
        '
        'BarberNameDataGridViewTextBoxColumn
        '
        Me.BarberNameDataGridViewTextBoxColumn.DataPropertyName = "Barber_Name"
        Me.BarberNameDataGridViewTextBoxColumn.HeaderText = "Barber_Name"
        Me.BarberNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BarberNameDataGridViewTextBoxColumn.Name = "BarberNameDataGridViewTextBoxColumn"
        Me.BarberNameDataGridViewTextBoxColumn.Width = 125
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Width = 125
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.BarberNameDataGridViewTextBoxColumn, Me.BarberAvailabilityDataGridViewCheckBoxColumn, Me.BarberDateDataGridViewTextBoxColumn, Me.BarberTimeDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BarberBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(6, 20)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(435, 269)
        Me.DataGridView1.TabIndex = 0
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1902, 762)
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.FillByToolStrip.ResumeLayout(False)
        Me.FillByToolStrip.PerformLayout()
        CType(Me.BarberBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarberDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents BarberDataSet1 As BarberDataSet1
    Friend WithEvents BarberBindingSource As BindingSource
    Friend WithEvents BarberTableAdapter As BarberDataSet1TableAdapters.BarberTableAdapter
    Friend WithEvents TableAdapterManager As BarberDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents FillByToolStrip As ToolStrip
    Friend WithEvents FillByToolStripButton As ToolStripButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BarberNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BarberAvailabilityDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents BarberDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BarberTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
