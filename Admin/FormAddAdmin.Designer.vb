﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddAdmin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAddAdmin))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnDeleteLogin = New System.Windows.Forms.Button()
        Me.cmbUserType = New System.Windows.Forms.ComboBox()
        Me.btnEditLogin = New System.Windows.Forms.Button()
        Me.btnAddLogin = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtboxPassword = New System.Windows.Forms.TextBox()
        Me.txtboxEmployeeID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnDeleteEmp = New System.Windows.Forms.Button()
        Me.btnEditEmp = New System.Windows.Forms.Button()
        Me.txtboxPhoneNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtboxEmail = New System.Windows.Forms.TextBox()
        Me.txtboxLname = New System.Windows.Forms.TextBox()
        Me.txtboxFname = New System.Windows.Forms.TextBox()
        Me.btnAddEmp = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.TblLoginStudBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Eclair_Student_PortalDataSet2 = New Eclair_Student_Portal.Eclair_Student_PortalDataSet2()
        Me.TblLoginStudTableAdapter = New Eclair_Student_Portal.Eclair_Student_PortalDataSet2TableAdapters.tblLoginStudTableAdapter()
        Me.dgvEmpLogin = New System.Windows.Forms.DataGridView()
        Me.EmployeeID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblLoginEmpBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblLoginStudBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvEmployeelist = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblEmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblStudentBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblStudentlist = New System.Windows.Forms.Label()
        Me.TblStudentTableAdapter = New Eclair_Student_Portal.Eclair_Student_PortalDataSet2TableAdapters.tblStudentTableAdapter()
        Me.TblStudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblLoginEmpTableAdapter = New Eclair_Student_Portal.Eclair_Student_PortalDataSet2TableAdapters.tblLoginEmpTableAdapter()
        Me.TblEmployeeTableAdapter = New Eclair_Student_Portal.Eclair_Student_PortalDataSet2TableAdapters.tblEmployeeTableAdapter()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TblLoginStudBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Eclair_Student_PortalDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvEmpLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblLoginEmpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblLoginStudBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvEmployeelist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblEmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblStudentBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblStudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnDeleteLogin)
        Me.GroupBox2.Controls.Add(Me.cmbUserType)
        Me.GroupBox2.Controls.Add(Me.btnEditLogin)
        Me.GroupBox2.Controls.Add(Me.btnAddLogin)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtboxPassword)
        Me.GroupBox2.Controls.Add(Me.txtboxEmployeeID)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(342, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(232, 178)
        Me.GroupBox2.TabIndex = 44
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Modifying Login"
        '
        'btnDeleteLogin
        '
        Me.btnDeleteLogin.Location = New System.Drawing.Point(162, 120)
        Me.btnDeleteLogin.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDeleteLogin.Name = "btnDeleteLogin"
        Me.btnDeleteLogin.Size = New System.Drawing.Size(56, 44)
        Me.btnDeleteLogin.TabIndex = 34
        Me.btnDeleteLogin.Text = "Delete"
        Me.btnDeleteLogin.UseVisualStyleBackColor = True
        '
        'cmbUserType
        '
        Me.cmbUserType.FormattingEnabled = True
        Me.cmbUserType.Items.AddRange(New Object() {"Admin"})
        Me.cmbUserType.Location = New System.Drawing.Point(74, 84)
        Me.cmbUserType.Name = "cmbUserType"
        Me.cmbUserType.Size = New System.Drawing.Size(144, 21)
        Me.cmbUserType.TabIndex = 37
        '
        'btnEditLogin
        '
        Me.btnEditLogin.Location = New System.Drawing.Point(102, 120)
        Me.btnEditLogin.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEditLogin.Name = "btnEditLogin"
        Me.btnEditLogin.Size = New System.Drawing.Size(56, 44)
        Me.btnEditLogin.TabIndex = 33
        Me.btnEditLogin.Text = "Edit"
        Me.btnEditLogin.UseVisualStyleBackColor = True
        '
        'btnAddLogin
        '
        Me.btnAddLogin.Location = New System.Drawing.Point(42, 120)
        Me.btnAddLogin.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddLogin.Name = "btnAddLogin"
        Me.btnAddLogin.Size = New System.Drawing.Size(56, 44)
        Me.btnAddLogin.TabIndex = 32
        Me.btnAddLogin.Text = "Add"
        Me.btnAddLogin.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 92)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "User Type"
        '
        'txtboxPassword
        '
        Me.txtboxPassword.Location = New System.Drawing.Point(74, 50)
        Me.txtboxPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.txtboxPassword.Name = "txtboxPassword"
        Me.txtboxPassword.Size = New System.Drawing.Size(145, 20)
        Me.txtboxPassword.TabIndex = 35
        '
        'txtboxEmployeeID
        '
        Me.txtboxEmployeeID.Location = New System.Drawing.Point(74, 16)
        Me.txtboxEmployeeID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtboxEmployeeID.Name = "txtboxEmployeeID"
        Me.txtboxEmployeeID.ReadOnly = True
        Me.txtboxEmployeeID.Size = New System.Drawing.Size(145, 20)
        Me.txtboxEmployeeID.TabIndex = 34
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 57)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Password"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 23)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Employee ID"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnDeleteEmp)
        Me.GroupBox1.Controls.Add(Me.btnEditEmp)
        Me.GroupBox1.Controls.Add(Me.txtboxPhoneNo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtboxEmail)
        Me.GroupBox1.Controls.Add(Me.txtboxLname)
        Me.GroupBox1.Controls.Add(Me.txtboxFname)
        Me.GroupBox1.Controls.Add(Me.btnAddEmp)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblUsername)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(324, 161)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Modifying Employee"
        '
        'btnDeleteEmp
        '
        Me.btnDeleteEmp.Location = New System.Drawing.Point(253, 104)
        Me.btnDeleteEmp.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDeleteEmp.Name = "btnDeleteEmp"
        Me.btnDeleteEmp.Size = New System.Drawing.Size(56, 44)
        Me.btnDeleteEmp.TabIndex = 31
        Me.btnDeleteEmp.Text = "Delete"
        Me.btnDeleteEmp.UseVisualStyleBackColor = True
        '
        'btnEditEmp
        '
        Me.btnEditEmp.Location = New System.Drawing.Point(253, 56)
        Me.btnEditEmp.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEditEmp.Name = "btnEditEmp"
        Me.btnEditEmp.Size = New System.Drawing.Size(56, 44)
        Me.btnEditEmp.TabIndex = 30
        Me.btnEditEmp.Text = "Edit"
        Me.btnEditEmp.UseVisualStyleBackColor = True
        '
        'txtboxPhoneNo
        '
        Me.txtboxPhoneNo.Location = New System.Drawing.Point(88, 113)
        Me.txtboxPhoneNo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtboxPhoneNo.Name = "txtboxPhoneNo"
        Me.txtboxPhoneNo.Size = New System.Drawing.Size(145, 20)
        Me.txtboxPhoneNo.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 120)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Phone #"
        '
        'txtboxEmail
        '
        Me.txtboxEmail.Location = New System.Drawing.Point(88, 80)
        Me.txtboxEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.txtboxEmail.Name = "txtboxEmail"
        Me.txtboxEmail.Size = New System.Drawing.Size(145, 20)
        Me.txtboxEmail.TabIndex = 23
        '
        'txtboxLname
        '
        Me.txtboxLname.Location = New System.Drawing.Point(88, 46)
        Me.txtboxLname.Margin = New System.Windows.Forms.Padding(2)
        Me.txtboxLname.Name = "txtboxLname"
        Me.txtboxLname.Size = New System.Drawing.Size(145, 20)
        Me.txtboxLname.TabIndex = 22
        '
        'txtboxFname
        '
        Me.txtboxFname.Location = New System.Drawing.Point(88, 15)
        Me.txtboxFname.Margin = New System.Windows.Forms.Padding(2)
        Me.txtboxFname.Name = "txtboxFname"
        Me.txtboxFname.Size = New System.Drawing.Size(145, 20)
        Me.txtboxFname.TabIndex = 21
        '
        'btnAddEmp
        '
        Me.btnAddEmp.Location = New System.Drawing.Point(253, 9)
        Me.btnAddEmp.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddEmp.Name = "btnAddEmp"
        Me.btnAddEmp.Size = New System.Drawing.Size(56, 44)
        Me.btnAddEmp.TabIndex = 18
        Me.btnAddEmp.Text = "Add"
        Me.btnAddEmp.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 87)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Email"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 53)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Last Name"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(15, 22)
        Me.lblUsername.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(57, 13)
        Me.lblUsername.TabIndex = 13
        Me.lblUsername.Text = "First Name"
        '
        'TblLoginStudBindingSource
        '
        Me.TblLoginStudBindingSource.DataMember = "tblLoginStud"
        Me.TblLoginStudBindingSource.DataSource = Me.Eclair_Student_PortalDataSet2
        '
        'Eclair_Student_PortalDataSet2
        '
        Me.Eclair_Student_PortalDataSet2.DataSetName = "Eclair_Student_PortalDataSet2"
        Me.Eclair_Student_PortalDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblLoginStudTableAdapter
        '
        Me.TblLoginStudTableAdapter.ClearBeforeFill = True
        '
        'dgvEmpLogin
        '
        Me.dgvEmpLogin.AutoGenerateColumns = False
        Me.dgvEmpLogin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmpLogin.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmployeeID, Me.PasswordDataGridViewTextBoxColumn, Me.UserTypeDataGridViewTextBoxColumn})
        Me.dgvEmpLogin.DataSource = Me.TblLoginEmpBindingSource
        Me.dgvEmpLogin.Location = New System.Drawing.Point(598, 35)
        Me.dgvEmpLogin.Name = "dgvEmpLogin"
        Me.dgvEmpLogin.Size = New System.Drawing.Size(343, 408)
        Me.dgvEmpLogin.TabIndex = 43
        '
        'EmployeeID
        '
        Me.EmployeeID.DataPropertyName = "EmployeeID"
        Me.EmployeeID.HeaderText = "EmployeeID"
        Me.EmployeeID.Name = "EmployeeID"
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "Password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "Password"
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        '
        'UserTypeDataGridViewTextBoxColumn
        '
        Me.UserTypeDataGridViewTextBoxColumn.DataPropertyName = "UserType"
        Me.UserTypeDataGridViewTextBoxColumn.HeaderText = "UserType"
        Me.UserTypeDataGridViewTextBoxColumn.Name = "UserTypeDataGridViewTextBoxColumn"
        '
        'TblLoginEmpBindingSource
        '
        Me.TblLoginEmpBindingSource.DataMember = "tblLoginEmp"
        Me.TblLoginEmpBindingSource.DataSource = Me.Eclair_Student_PortalDataSet2
        '
        'TblLoginStudBindingSource1
        '
        Me.TblLoginStudBindingSource1.DataMember = "tblLoginStud"
        Me.TblLoginStudBindingSource1.DataSource = Me.Eclair_Student_PortalDataSet2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(594, 12)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(170, 20)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Employee Login List"
        '
        'dgvEmployeelist
        '
        Me.dgvEmployeelist.AutoGenerateColumns = False
        Me.dgvEmployeelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmployeelist.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.dgvEmployeelist.DataSource = Me.TblEmployeeBindingSource
        Me.dgvEmployeelist.Location = New System.Drawing.Point(21, 215)
        Me.dgvEmployeelist.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvEmployeelist.Name = "dgvEmployeelist"
        Me.dgvEmployeelist.RowHeadersWidth = 51
        Me.dgvEmployeelist.RowTemplate.Height = 24
        Me.dgvEmployeelist.Size = New System.Drawing.Size(553, 229)
        Me.dgvEmployeelist.TabIndex = 41
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "EmployeeID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "EmployeeID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Fname"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fname"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Lname"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Lname"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PhoneNo"
        Me.DataGridViewTextBoxColumn5.HeaderText = "PhoneNo"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'TblEmployeeBindingSource
        '
        Me.TblEmployeeBindingSource.DataMember = "tblEmployee"
        Me.TblEmployeeBindingSource.DataSource = Me.Eclair_Student_PortalDataSet2
        '
        'TblStudentBindingSource1
        '
        Me.TblStudentBindingSource1.DataMember = "tblStudent"
        Me.TblStudentBindingSource1.DataSource = Me.Eclair_Student_PortalDataSet2
        '
        'lblStudentlist
        '
        Me.lblStudentlist.AutoSize = True
        Me.lblStudentlist.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentlist.Location = New System.Drawing.Point(17, 188)
        Me.lblStudentlist.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblStudentlist.Name = "lblStudentlist"
        Me.lblStudentlist.Size = New System.Drawing.Size(121, 20)
        Me.lblStudentlist.TabIndex = 40
        Me.lblStudentlist.Text = "Employee List"
        '
        'TblStudentTableAdapter
        '
        Me.TblStudentTableAdapter.ClearBeforeFill = True
        '
        'TblStudentBindingSource
        '
        Me.TblStudentBindingSource.DataMember = "tblStudent"
        '
        'TblLoginEmpTableAdapter
        '
        Me.TblLoginEmpTableAdapter.ClearBeforeFill = True
        '
        'TblEmployeeTableAdapter
        '
        Me.TblEmployeeTableAdapter.ClearBeforeFill = True
        '
        'FormAddAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(953, 457)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvEmpLogin)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dgvEmployeelist)
        Me.Controls.Add(Me.lblStudentlist)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormAddAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Admin"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TblLoginStudBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Eclair_Student_PortalDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvEmpLogin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblLoginEmpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblLoginStudBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvEmployeelist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblEmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblStudentBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblStudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnDeleteLogin As Button
    Friend WithEvents cmbUserType As ComboBox
    Friend WithEvents btnEditLogin As Button
    Friend WithEvents btnAddLogin As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtboxPassword As TextBox
    Friend WithEvents txtboxEmployeeID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnDeleteEmp As Button
    Friend WithEvents btnEditEmp As Button
    Friend WithEvents txtboxPhoneNo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtboxEmail As TextBox
    Friend WithEvents txtboxLname As TextBox
    Friend WithEvents txtboxFname As TextBox
    Friend WithEvents btnAddEmp As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents TblLoginStudBindingSource As BindingSource
    Friend WithEvents Eclair_Student_PortalDataSet2 As Eclair_Student_PortalDataSet2
    Friend WithEvents TblLoginStudTableAdapter As Eclair_Student_PortalDataSet2TableAdapters.tblLoginStudTableAdapter
    Friend WithEvents dgvEmpLogin As DataGridView
    Friend WithEvents TblLoginStudBindingSource1 As BindingSource
    Friend WithEvents Label7 As Label
    Friend WithEvents dgvEmployeelist As DataGridView
    Friend WithEvents TblStudentBindingSource1 As BindingSource
    Friend WithEvents TblStudentBindingSource As BindingSource
    Friend WithEvents lblStudentlist As Label
    Friend WithEvents TblStudentTableAdapter As Eclair_Student_PortalDataSet2TableAdapters.tblStudentTableAdapter
    Friend WithEvents TblLoginEmpBindingSource As BindingSource
    Friend WithEvents TblLoginEmpTableAdapter As Eclair_Student_PortalDataSet2TableAdapters.tblLoginEmpTableAdapter
    Friend WithEvents EmployeeID As DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TblEmployeeBindingSource As BindingSource
    Friend WithEvents TblEmployeeTableAdapter As Eclair_Student_PortalDataSet2TableAdapters.tblEmployeeTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
End Class
