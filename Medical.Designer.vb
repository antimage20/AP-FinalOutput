<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMedical
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpPatientForm = New System.Windows.Forms.TabPage()
        Me.btnNext2 = New System.Windows.Forms.Button()
        Me.btnNew2 = New System.Windows.Forms.Button()
        Me.btnPrevious2 = New System.Windows.Forms.Button()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtMedicineName = New System.Windows.Forms.TextBox()
        Me.btnClear2 = New System.Windows.Forms.Button()
        Me.btnSave2 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tpPatientInformation = New System.Windows.Forms.TabPage()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Database2DataSet3 = New advanceprog.Database2DataSet3()
        Me.MedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MedTableAdapter = New advanceprog.Database2DataSet3TableAdapters.MedTableAdapter()
        Me.MedicinenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.tpPatientForm.SuspendLayout()
        Me.tpPatientInformation.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database2DataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpPatientForm)
        Me.TabControl1.Controls.Add(Me.tpPatientInformation)
        Me.TabControl1.Location = New System.Drawing.Point(12, 11)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(442, 327)
        Me.TabControl1.TabIndex = 18
        '
        'tpPatientForm
        '
        Me.tpPatientForm.BackColor = System.Drawing.Color.Gray
        Me.tpPatientForm.Controls.Add(Me.btnNext2)
        Me.tpPatientForm.Controls.Add(Me.btnNew2)
        Me.tpPatientForm.Controls.Add(Me.btnPrevious2)
        Me.tpPatientForm.Controls.Add(Me.txtQuantity)
        Me.tpPatientForm.Controls.Add(Me.txtMedicineName)
        Me.tpPatientForm.Controls.Add(Me.btnClear2)
        Me.tpPatientForm.Controls.Add(Me.btnSave2)
        Me.tpPatientForm.Controls.Add(Me.Label9)
        Me.tpPatientForm.Controls.Add(Me.Label7)
        Me.tpPatientForm.Controls.Add(Me.Label4)
        Me.tpPatientForm.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tpPatientForm.Location = New System.Drawing.Point(4, 22)
        Me.tpPatientForm.Name = "tpPatientForm"
        Me.tpPatientForm.Padding = New System.Windows.Forms.Padding(3)
        Me.tpPatientForm.Size = New System.Drawing.Size(434, 301)
        Me.tpPatientForm.TabIndex = 0
        Me.tpPatientForm.Text = "Register"
        '
        'btnNext2
        '
        Me.btnNext2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext2.ForeColor = System.Drawing.Color.Black
        Me.btnNext2.Location = New System.Drawing.Point(346, 257)
        Me.btnNext2.Name = "btnNext2"
        Me.btnNext2.Size = New System.Drawing.Size(75, 26)
        Me.btnNext2.TabIndex = 27
        Me.btnNext2.Text = "Next"
        Me.btnNext2.UseVisualStyleBackColor = True
        '
        'btnNew2
        '
        Me.btnNew2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew2.ForeColor = System.Drawing.Color.Black
        Me.btnNew2.Location = New System.Drawing.Point(256, 257)
        Me.btnNew2.Name = "btnNew2"
        Me.btnNew2.Size = New System.Drawing.Size(75, 26)
        Me.btnNew2.TabIndex = 26
        Me.btnNew2.Text = "New"
        Me.btnNew2.UseVisualStyleBackColor = True
        '
        'btnPrevious2
        '
        Me.btnPrevious2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious2.ForeColor = System.Drawing.Color.Black
        Me.btnPrevious2.Location = New System.Drawing.Point(167, 257)
        Me.btnPrevious2.Name = "btnPrevious2"
        Me.btnPrevious2.Size = New System.Drawing.Size(75, 26)
        Me.btnPrevious2.TabIndex = 25
        Me.btnPrevious2.Text = "Previous"
        Me.btnPrevious2.UseVisualStyleBackColor = True
        '
        'txtQuantity
        '
        Me.txtQuantity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedBindingSource, "Quantity", True))
        Me.txtQuantity.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(156, 135)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(156, 21)
        Me.txtQuantity.TabIndex = 19
        '
        'txtMedicineName
        '
        Me.txtMedicineName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedBindingSource, "Medicine_name", True))
        Me.txtMedicineName.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMedicineName.Location = New System.Drawing.Point(156, 103)
        Me.txtMedicineName.Name = "txtMedicineName"
        Me.txtMedicineName.Size = New System.Drawing.Size(156, 21)
        Me.txtMedicineName.TabIndex = 17
        '
        'btnClear2
        '
        Me.btnClear2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear2.ForeColor = System.Drawing.Color.Black
        Me.btnClear2.Location = New System.Drawing.Point(237, 162)
        Me.btnClear2.Name = "btnClear2"
        Me.btnClear2.Size = New System.Drawing.Size(75, 26)
        Me.btnClear2.TabIndex = 15
        Me.btnClear2.Text = "Clear"
        Me.btnClear2.UseVisualStyleBackColor = True
        '
        'btnSave2
        '
        Me.btnSave2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave2.ForeColor = System.Drawing.Color.Black
        Me.btnSave2.Location = New System.Drawing.Point(156, 162)
        Me.btnSave2.Name = "btnSave2"
        Me.btnSave2.Size = New System.Drawing.Size(75, 26)
        Me.btnSave2.TabIndex = 14
        Me.btnSave2.Text = "Save"
        Me.btnSave2.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(56, 138)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 15)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Quantity:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(56, 106)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 15)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Medicine name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(153, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Medical Inventory"
        '
        'tpPatientInformation
        '
        Me.tpPatientInformation.Controls.Add(Me.btnDelete)
        Me.tpPatientInformation.Controls.Add(Me.btnUpdate)
        Me.tpPatientInformation.Controls.Add(Me.Label16)
        Me.tpPatientInformation.Controls.Add(Me.DataGridView1)
        Me.tpPatientInformation.ForeColor = System.Drawing.Color.Black
        Me.tpPatientInformation.Location = New System.Drawing.Point(4, 22)
        Me.tpPatientInformation.Name = "tpPatientInformation"
        Me.tpPatientInformation.Padding = New System.Windows.Forms.Padding(3)
        Me.tpPatientInformation.Size = New System.Drawing.Size(434, 301)
        Me.tpPatientInformation.TabIndex = 1
        Me.tpPatientInformation.Text = "Information"
        Me.tpPatientInformation.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Black
        Me.btnDelete.Location = New System.Drawing.Point(390, 302)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 26)
        Me.btnDelete.TabIndex = 16
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.Black
        Me.btnUpdate.Location = New System.Drawing.Point(309, 302)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 26)
        Me.btnUpdate.TabIndex = 15
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(6, 17)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(157, 19)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Patient Information "
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MedicinenameDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MedBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(6, 47)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(425, 248)
        Me.DataGridView1.TabIndex = 0
        '
        'Database2DataSet3
        '
        Me.Database2DataSet3.DataSetName = "Database2DataSet3"
        Me.Database2DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MedBindingSource
        '
        Me.MedBindingSource.DataMember = "Med"
        Me.MedBindingSource.DataSource = Me.Database2DataSet3
        '
        'MedTableAdapter
        '
        Me.MedTableAdapter.ClearBeforeFill = True
        '
        'MedicinenameDataGridViewTextBoxColumn
        '
        Me.MedicinenameDataGridViewTextBoxColumn.DataPropertyName = "Medicine_name"
        Me.MedicinenameDataGridViewTextBoxColumn.HeaderText = "Medicine_name"
        Me.MedicinenameDataGridViewTextBoxColumn.Name = "MedicinenameDataGridViewTextBoxColumn"
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        '
        'frmMedical
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(470, 343)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMedical"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Medical"
        Me.TabControl1.ResumeLayout(False)
        Me.tpPatientForm.ResumeLayout(False)
        Me.tpPatientForm.PerformLayout()
        Me.tpPatientInformation.ResumeLayout(False)
        Me.tpPatientInformation.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database2DataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpPatientForm As TabPage
    Friend WithEvents btnNext2 As Button
    Friend WithEvents btnNew2 As Button
    Friend WithEvents btnPrevious2 As Button
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtMedicineName As TextBox
    Friend WithEvents btnClear2 As Button
    Friend WithEvents btnSave2 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tpPatientInformation As TabPage
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Database2DataSet3 As Database2DataSet3
    Friend WithEvents MedBindingSource As BindingSource
    Friend WithEvents MedTableAdapter As Database2DataSet3TableAdapters.MedTableAdapter
    Friend WithEvents MedicinenameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
