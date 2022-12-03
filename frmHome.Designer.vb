<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHome))
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CellphoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvinceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PostalCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateofBirthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SingleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarriedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InformationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database2DataSet1 = New advanceprog.Database2DataSet1()
        Me.tpPatientInformation = New System.Windows.Forms.TabPage()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtPostalcode = New System.Windows.Forms.TextBox()
        Me.txtProvince = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtCellphone = New System.Windows.Forms.TextBox()
        Me.txtLastname = New System.Windows.Forms.TextBox()
        Me.tpPatientForm = New System.Windows.Forms.TabPage()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.rbMarried = New System.Windows.Forms.RadioButton()
        Me.rbSingle = New System.Windows.Forms.RadioButton()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dtpDateofBirth = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnMedicalinventory = New System.Windows.Forms.Button()
        Me.btnPatientrecord = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.gbxHome = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.InformationTableAdapter = New advanceprog.Database2DataSet1TableAdapters.InformationTableAdapter()
        Me.Database2DataSet2 = New advanceprog.Database2DataSet2()
        Me.MedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MedTableAdapter = New advanceprog.Database2DataSet2TableAdapters.MedTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InformationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database2DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpPatientInformation.SuspendLayout()
        Me.tpPatientForm.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gbxHome.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        CType(Me.Database2DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FirstnameDataGridViewTextBoxColumn, Me.LastnameDataGridViewTextBoxColumn, Me.CellphoneDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.CityDataGridViewTextBoxColumn, Me.ProvinceDataGridViewTextBoxColumn, Me.PostalCodeDataGridViewTextBoxColumn, Me.DateofBirthDataGridViewTextBoxColumn, Me.SingleDataGridViewTextBoxColumn, Me.MarriedDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.InformationBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(6, 47)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(459, 249)
        Me.DataGridView1.TabIndex = 0
        '
        'FirstnameDataGridViewTextBoxColumn
        '
        Me.FirstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname"
        Me.FirstnameDataGridViewTextBoxColumn.HeaderText = "Firstname"
        Me.FirstnameDataGridViewTextBoxColumn.Name = "FirstnameDataGridViewTextBoxColumn"
        '
        'LastnameDataGridViewTextBoxColumn
        '
        Me.LastnameDataGridViewTextBoxColumn.DataPropertyName = "Lastname"
        Me.LastnameDataGridViewTextBoxColumn.HeaderText = "Lastname"
        Me.LastnameDataGridViewTextBoxColumn.Name = "LastnameDataGridViewTextBoxColumn"
        '
        'CellphoneDataGridViewTextBoxColumn
        '
        Me.CellphoneDataGridViewTextBoxColumn.DataPropertyName = "Cellphone"
        Me.CellphoneDataGridViewTextBoxColumn.HeaderText = "Cellphone"
        Me.CellphoneDataGridViewTextBoxColumn.Name = "CellphoneDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'CityDataGridViewTextBoxColumn
        '
        Me.CityDataGridViewTextBoxColumn.DataPropertyName = "City"
        Me.CityDataGridViewTextBoxColumn.HeaderText = "City"
        Me.CityDataGridViewTextBoxColumn.Name = "CityDataGridViewTextBoxColumn"
        '
        'ProvinceDataGridViewTextBoxColumn
        '
        Me.ProvinceDataGridViewTextBoxColumn.DataPropertyName = "Province"
        Me.ProvinceDataGridViewTextBoxColumn.HeaderText = "Province"
        Me.ProvinceDataGridViewTextBoxColumn.Name = "ProvinceDataGridViewTextBoxColumn"
        '
        'PostalCodeDataGridViewTextBoxColumn
        '
        Me.PostalCodeDataGridViewTextBoxColumn.DataPropertyName = "Postal_Code"
        Me.PostalCodeDataGridViewTextBoxColumn.HeaderText = "Postal_Code"
        Me.PostalCodeDataGridViewTextBoxColumn.Name = "PostalCodeDataGridViewTextBoxColumn"
        '
        'DateofBirthDataGridViewTextBoxColumn
        '
        Me.DateofBirthDataGridViewTextBoxColumn.DataPropertyName = "Date_of_Birth"
        Me.DateofBirthDataGridViewTextBoxColumn.HeaderText = "Date_of_Birth"
        Me.DateofBirthDataGridViewTextBoxColumn.Name = "DateofBirthDataGridViewTextBoxColumn"
        '
        'SingleDataGridViewTextBoxColumn
        '
        Me.SingleDataGridViewTextBoxColumn.DataPropertyName = "Single"
        Me.SingleDataGridViewTextBoxColumn.HeaderText = "Single"
        Me.SingleDataGridViewTextBoxColumn.Name = "SingleDataGridViewTextBoxColumn"
        '
        'MarriedDataGridViewTextBoxColumn
        '
        Me.MarriedDataGridViewTextBoxColumn.DataPropertyName = "Married"
        Me.MarriedDataGridViewTextBoxColumn.HeaderText = "Married"
        Me.MarriedDataGridViewTextBoxColumn.Name = "MarriedDataGridViewTextBoxColumn"
        '
        'InformationBindingSource
        '
        Me.InformationBindingSource.DataMember = "Information"
        Me.InformationBindingSource.DataSource = Me.Database2DataSet1
        '
        'Database2DataSet1
        '
        Me.Database2DataSet1.DataSetName = "Database2DataSet1"
        Me.Database2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.tpPatientInformation.Size = New System.Drawing.Size(471, 358)
        Me.tpPatientInformation.TabIndex = 1
        Me.tpPatientInformation.Text = "Information"
        Me.tpPatientInformation.UseVisualStyleBackColor = True
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
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Transparent
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogout.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.Black
        Me.btnLogout.Location = New System.Drawing.Point(626, 10)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(25, 25)
        Me.btnLogout.TabIndex = 14
        Me.btnLogout.Text = "X"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(20, 252)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(75, 15)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "Date of Birth:"
        '
        'txtPostalcode
        '
        Me.txtPostalcode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InformationBindingSource, "Postal_Code", True))
        Me.txtPostalcode.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPostalcode.Location = New System.Drawing.Point(296, 220)
        Me.txtPostalcode.Name = "txtPostalcode"
        Me.txtPostalcode.Size = New System.Drawing.Size(133, 21)
        Me.txtPostalcode.TabIndex = 23
        '
        'txtProvince
        '
        Me.txtProvince.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InformationBindingSource, "Province", True))
        Me.txtProvince.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProvince.Location = New System.Drawing.Point(296, 194)
        Me.txtProvince.Name = "txtProvince"
        Me.txtProvince.Size = New System.Drawing.Size(133, 21)
        Me.txtProvince.TabIndex = 22
        '
        'txtCity
        '
        Me.txtCity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InformationBindingSource, "City", True))
        Me.txtCity.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCity.Location = New System.Drawing.Point(92, 194)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(133, 21)
        Me.txtCity.TabIndex = 21
        '
        'txtAddress
        '
        Me.txtAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InformationBindingSource, "Address", True))
        Me.txtAddress.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(92, 148)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(337, 40)
        Me.txtAddress.TabIndex = 20
        '
        'txtCellphone
        '
        Me.txtCellphone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InformationBindingSource, "Cellphone", True))
        Me.txtCellphone.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCellphone.Location = New System.Drawing.Point(92, 121)
        Me.txtCellphone.Name = "txtCellphone"
        Me.txtCellphone.Size = New System.Drawing.Size(133, 21)
        Me.txtCellphone.TabIndex = 19
        '
        'txtLastname
        '
        Me.txtLastname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InformationBindingSource, "Lastname", True))
        Me.txtLastname.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastname.Location = New System.Drawing.Point(296, 89)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(133, 21)
        Me.txtLastname.TabIndex = 18
        '
        'tpPatientForm
        '
        Me.tpPatientForm.BackColor = System.Drawing.Color.Gray
        Me.tpPatientForm.Controls.Add(Me.btnNext)
        Me.tpPatientForm.Controls.Add(Me.btnNew)
        Me.tpPatientForm.Controls.Add(Me.btnPrevious)
        Me.tpPatientForm.Controls.Add(Me.Label15)
        Me.tpPatientForm.Controls.Add(Me.txtPostalcode)
        Me.tpPatientForm.Controls.Add(Me.txtProvince)
        Me.tpPatientForm.Controls.Add(Me.txtCity)
        Me.tpPatientForm.Controls.Add(Me.txtAddress)
        Me.tpPatientForm.Controls.Add(Me.txtCellphone)
        Me.tpPatientForm.Controls.Add(Me.txtLastname)
        Me.tpPatientForm.Controls.Add(Me.txtFirstname)
        Me.tpPatientForm.Controls.Add(Me.btnClear)
        Me.tpPatientForm.Controls.Add(Me.btnSave)
        Me.tpPatientForm.Controls.Add(Me.rbMarried)
        Me.tpPatientForm.Controls.Add(Me.rbSingle)
        Me.tpPatientForm.Controls.Add(Me.Label14)
        Me.tpPatientForm.Controls.Add(Me.dtpDateofBirth)
        Me.tpPatientForm.Controls.Add(Me.Label13)
        Me.tpPatientForm.Controls.Add(Me.Label12)
        Me.tpPatientForm.Controls.Add(Me.Label11)
        Me.tpPatientForm.Controls.Add(Me.Label10)
        Me.tpPatientForm.Controls.Add(Me.Label9)
        Me.tpPatientForm.Controls.Add(Me.Label8)
        Me.tpPatientForm.Controls.Add(Me.Label7)
        Me.tpPatientForm.Controls.Add(Me.Label6)
        Me.tpPatientForm.Controls.Add(Me.Label5)
        Me.tpPatientForm.Controls.Add(Me.Label4)
        Me.tpPatientForm.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tpPatientForm.Location = New System.Drawing.Point(4, 22)
        Me.tpPatientForm.Name = "tpPatientForm"
        Me.tpPatientForm.Padding = New System.Windows.Forms.Padding(3)
        Me.tpPatientForm.Size = New System.Drawing.Size(471, 358)
        Me.tpPatientForm.TabIndex = 0
        Me.tpPatientForm.Text = "Register"
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.Black
        Me.btnNext.Location = New System.Drawing.Point(202, 311)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 26)
        Me.btnNext.TabIndex = 27
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.ForeColor = System.Drawing.Color.Black
        Me.btnNew.Location = New System.Drawing.Point(112, 311)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 26)
        Me.btnNew.TabIndex = 26
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.ForeColor = System.Drawing.Color.Black
        Me.btnPrevious.Location = New System.Drawing.Point(23, 311)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 26)
        Me.btnPrevious.TabIndex = 25
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'txtFirstname
        '
        Me.txtFirstname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InformationBindingSource, "Firstname", True))
        Me.txtFirstname.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstname.Location = New System.Drawing.Point(92, 89)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(133, 21)
        Me.txtFirstname.TabIndex = 17
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Location = New System.Drawing.Point(390, 311)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 26)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(296, 311)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 26)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'rbMarried
        '
        Me.rbMarried.AutoSize = True
        Me.rbMarried.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.InformationBindingSource, "Married", True))
        Me.rbMarried.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbMarried.ForeColor = System.Drawing.Color.Black
        Me.rbMarried.Location = New System.Drawing.Point(191, 283)
        Me.rbMarried.Name = "rbMarried"
        Me.rbMarried.Size = New System.Drawing.Size(67, 19)
        Me.rbMarried.TabIndex = 13
        Me.rbMarried.TabStop = True
        Me.rbMarried.Text = "Married"
        Me.rbMarried.UseVisualStyleBackColor = True
        '
        'rbSingle
        '
        Me.rbSingle.AutoSize = True
        Me.rbSingle.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.InformationBindingSource, "Single", True))
        Me.rbSingle.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSingle.ForeColor = System.Drawing.Color.Black
        Me.rbSingle.Location = New System.Drawing.Point(119, 283)
        Me.rbSingle.Name = "rbSingle"
        Me.rbSingle.Size = New System.Drawing.Size(58, 19)
        Me.rbSingle.TabIndex = 12
        Me.rbSingle.TabStop = True
        Me.rbSingle.Text = "Single"
        Me.rbSingle.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(22, 284)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 15)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "Marital status:"
        '
        'dtpDateofBirth
        '
        Me.dtpDateofBirth.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.InformationBindingSource, "Date_of_Birth", True))
        Me.dtpDateofBirth.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateofBirth.Location = New System.Drawing.Point(102, 250)
        Me.dtpDateofBirth.Name = "dtpDateofBirth"
        Me.dtpDateofBirth.Size = New System.Drawing.Size(200, 21)
        Me.dtpDateofBirth.TabIndex = 10
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(219, 222)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(73, 15)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "Postal code:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(234, 196)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 15)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Province:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(22, 196)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 15)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "City:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(22, 150)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 15)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Address:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(20, 123)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 15)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Cellphone:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(231, 91)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 15)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Last name:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(22, 91)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 15)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "First name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(198, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 15)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Personal Details"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(22, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(162, 16)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Fill in with your information"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(159, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(165, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Patient Information Form"
        '
        'btnExit
        '
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(0, 155)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(127, 34)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(190, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(395, 19)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Medical Inventory and Patients Information System"
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(25, 30)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(125, 74)
        Me.Button6.TabIndex = 15
        Me.Button6.Text = "VB LOVES"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Black
        Me.GroupBox2.Controls.Add(Me.btnExit)
        Me.GroupBox2.Controls.Add(Me.btnMedicalinventory)
        Me.GroupBox2.Controls.Add(Me.btnPatientrecord)
        Me.GroupBox2.Controls.Add(Me.btnHome)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 114)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(127, 312)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'btnMedicalinventory
        '
        Me.btnMedicalinventory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnMedicalinventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMedicalinventory.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMedicalinventory.Location = New System.Drawing.Point(0, 113)
        Me.btnMedicalinventory.Name = "btnMedicalinventory"
        Me.btnMedicalinventory.Size = New System.Drawing.Size(127, 42)
        Me.btnMedicalinventory.TabIndex = 2
        Me.btnMedicalinventory.Text = "Medical Inventory"
        Me.btnMedicalinventory.UseVisualStyleBackColor = True
        '
        'btnPatientrecord
        '
        Me.btnPatientrecord.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPatientrecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPatientrecord.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPatientrecord.Location = New System.Drawing.Point(0, 79)
        Me.btnPatientrecord.Name = "btnPatientrecord"
        Me.btnPatientrecord.Size = New System.Drawing.Size(127, 34)
        Me.btnPatientrecord.TabIndex = 1
        Me.btnPatientrecord.Text = "Patients Record"
        Me.btnPatientrecord.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.Location = New System.Drawing.Point(0, 45)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(127, 34)
        Me.btnHome.TabIndex = 0
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'gbxHome
        '
        Me.gbxHome.BackColor = System.Drawing.Color.Gray
        Me.gbxHome.Controls.Add(Me.TextBox2)
        Me.gbxHome.Controls.Add(Me.TextBox1)
        Me.gbxHome.Controls.Add(Me.Label3)
        Me.gbxHome.Controls.Add(Me.Label2)
        Me.gbxHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbxHome.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxHome.Location = New System.Drawing.Point(156, 62)
        Me.gbxHome.Name = "gbxHome"
        Me.gbxHome.Size = New System.Drawing.Size(479, 380)
        Me.gbxHome.TabIndex = 12
        Me.gbxHome.TabStop = False
        Me.gbxHome.Text = "Home"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Gray
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.Cyan
        Me.TextBox2.Location = New System.Drawing.Point(267, 91)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(166, 186)
        Me.TextBox2.TabIndex = 7
        Me.TextBox2.Text = resources.GetString("TextBox2.Text")
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Gray
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Cyan
        Me.TextBox1.Location = New System.Drawing.Point(54, 91)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(166, 186)
        Me.TextBox1.TabIndex = 6
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(282, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Medical Inventory"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(66, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Patient Information"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpPatientForm)
        Me.TabControl1.Controls.Add(Me.tpPatientInformation)
        Me.TabControl1.Location = New System.Drawing.Point(156, 62)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(479, 384)
        Me.TabControl1.TabIndex = 17
        '
        'InformationTableAdapter
        '
        Me.InformationTableAdapter.ClearBeforeFill = True
        '
        'Database2DataSet2
        '
        Me.Database2DataSet2.DataSetName = "Database2DataSet2"
        Me.Database2DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MedBindingSource
        '
        Me.MedBindingSource.DataMember = "Med"
        Me.MedBindingSource.DataSource = Me.Database2DataSet2
        '
        'MedTableAdapter
        '
        Me.MedTableAdapter.ClearBeforeFill = True
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aqua
        Me.ClientSize = New System.Drawing.Size(668, 459)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gbxHome)
        Me.Controls.Add(Me.TabControl1)
        Me.ForeColor = System.Drawing.Color.Aqua
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmHome"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InformationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database2DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpPatientInformation.ResumeLayout(False)
        Me.tpPatientInformation.PerformLayout()
        Me.tpPatientForm.ResumeLayout(False)
        Me.tpPatientForm.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.gbxHome.ResumeLayout(False)
        Me.gbxHome.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        CType(Me.Database2DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents tpPatientInformation As TabPage
    Friend WithEvents Label16 As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents txtPostalcode As TextBox
    Friend WithEvents txtProvince As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtCellphone As TextBox
    Friend WithEvents txtLastname As TextBox
    Friend WithEvents tpPatientForm As TabPage
    Friend WithEvents txtFirstname As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents dtpDateofBirth As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnMedicalinventory As Button
    Friend WithEvents btnPatientrecord As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents gbxHome As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents btnNext As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents rbMarried As RadioButton
    Friend WithEvents rbSingle As RadioButton
    Friend WithEvents Database2DataSet1 As Database2DataSet1
    Friend WithEvents InformationBindingSource As BindingSource
    Friend WithEvents InformationTableAdapter As Database2DataSet1TableAdapters.InformationTableAdapter
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CellphoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProvinceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PostalCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateofBirthDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SingleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MarriedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Database2DataSet2 As Database2DataSet2
    Friend WithEvents MedBindingSource As BindingSource
    Friend WithEvents MedTableAdapter As Database2DataSet2TableAdapters.MedTableAdapter
End Class
