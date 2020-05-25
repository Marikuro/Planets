<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Форма переопределяет dispose для очистки списка компонентов.
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

	'Является обязательной для конструктора форм Windows Forms
	Private components As System.ComponentModel.IContainer

	'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
	'Для ее изменения используйте конструктор форм Windows Form.  
	'Не изменяйте ее в редакторе исходного кода.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
		Me.Button6 = New System.Windows.Forms.Button()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.ComboBox1 = New System.Windows.Forms.ComboBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.Button5 = New System.Windows.Forms.Button()
		Me.Button4 = New System.Windows.Forms.Button()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.DGV1 = New System.Windows.Forms.DataGridView()
		Me.ПланетыDataSet = New Planets.ПланетыDataSet()
		Me.ПланетыBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.ПланетыTableAdapter = New Planets.ПланетыDataSetTableAdapters.ПланетыTableAdapter()
		Me.TextBox3 = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.GroupBox1.SuspendLayout()
		CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ПланетыDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ПланетыBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Button6
		'
		Me.Button6.Font = New System.Drawing.Font("MV Boli", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button6.Location = New System.Drawing.Point(570, 358)
		Me.Button6.Name = "Button6"
		Me.Button6.Size = New System.Drawing.Size(120, 54)
		Me.Button6.TabIndex = 16
		Me.Button6.Text = "Обновить"
		Me.Button6.UseVisualStyleBackColor = True
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.TextBox3)
		Me.GroupBox1.Controls.Add(Me.ComboBox1)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Controls.Add(Me.TextBox2)
		Me.GroupBox1.Controls.Add(Me.Button1)
		Me.GroupBox1.Controls.Add(Me.Button2)
		Me.GroupBox1.Controls.Add(Me.TextBox1)
		Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.GroupBox1.Location = New System.Drawing.Point(491, 54)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(283, 282)
		Me.GroupBox1.TabIndex = 15
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Расчет 1 и 2 космических скоростей"
		'
		'ComboBox1
		'
		Me.ComboBox1.DataSource = Me.ПланетыBindingSource
		Me.ComboBox1.DisplayMember = "Название_планеты"
		Me.ComboBox1.FormattingEnabled = True
		Me.ComboBox1.Location = New System.Drawing.Point(20, 226)
		Me.ComboBox1.Name = "ComboBox1"
		Me.ComboBox1.Size = New System.Drawing.Size(230, 24)
		Me.ComboBox1.TabIndex = 11
		Me.ComboBox1.ValueMember = "Код"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(90, 207)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(72, 16)
		Me.Label1.TabIndex = 10
		Me.Label1.Text = "Планета"
		'
		'TextBox2
		'
		Me.TextBox2.Location = New System.Drawing.Point(115, 102)
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.ReadOnly = True
		Me.TextBox2.Size = New System.Drawing.Size(147, 22)
		Me.TextBox2.TabIndex = 8
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(6, 52)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(90, 22)
		Me.Button1.TabIndex = 1
		Me.Button1.Text = "V1"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Button2
		'
		Me.Button2.Location = New System.Drawing.Point(6, 102)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(90, 22)
		Me.Button2.TabIndex = 2
		Me.Button2.Text = "V2"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(115, 52)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.ReadOnly = True
		Me.TextBox1.Size = New System.Drawing.Size(147, 22)
		Me.TextBox1.TabIndex = 6
		'
		'Button5
		'
		Me.Button5.Font = New System.Drawing.Font("MV Boli", 8.25!, System.Drawing.FontStyle.Bold)
		Me.Button5.Location = New System.Drawing.Point(295, 398)
		Me.Button5.Name = "Button5"
		Me.Button5.Size = New System.Drawing.Size(160, 32)
		Me.Button5.TabIndex = 14
		Me.Button5.Text = "Редактировать планету"
		Me.Button5.UseVisualStyleBackColor = True
		'
		'Button4
		'
		Me.Button4.Font = New System.Drawing.Font("MV Boli", 8.25!, System.Drawing.FontStyle.Bold)
		Me.Button4.Location = New System.Drawing.Point(169, 398)
		Me.Button4.Name = "Button4"
		Me.Button4.Size = New System.Drawing.Size(120, 32)
		Me.Button4.TabIndex = 13
		Me.Button4.Text = "Удалить планету"
		Me.Button4.UseVisualStyleBackColor = True
		'
		'Button3
		'
		Me.Button3.Font = New System.Drawing.Font("MV Boli", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button3.Location = New System.Drawing.Point(32, 398)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(129, 32)
		Me.Button3.TabIndex = 12
		Me.Button3.Text = "Добавить планету"
		Me.Button3.UseVisualStyleBackColor = True
		'
		'DGV1
		'
		Me.DGV1.AllowUserToAddRows = False
		Me.DGV1.AllowUserToDeleteRows = False
		Me.DGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.DGV1.BackgroundColor = System.Drawing.SystemColors.Control
		Me.DGV1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DGV1.GridColor = System.Drawing.Color.Black
		Me.DGV1.Location = New System.Drawing.Point(26, 21)
		Me.DGV1.Name = "DGV1"
		Me.DGV1.ReadOnly = True
		Me.DGV1.Size = New System.Drawing.Size(435, 371)
		Me.DGV1.TabIndex = 11
		'
		'ПланетыDataSet
		'
		Me.ПланетыDataSet.DataSetName = "ПланетыDataSet"
		Me.ПланетыDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'ПланетыBindingSource
		'
		Me.ПланетыBindingSource.DataMember = "Планеты"
		Me.ПланетыBindingSource.DataSource = Me.ПланетыDataSet
		'
		'ПланетыTableAdapter
		'
		Me.ПланетыTableAdapter.ClearBeforeFill = True
		'
		'TextBox3
		'
		Me.TextBox3.Location = New System.Drawing.Point(136, 158)
		Me.TextBox3.Name = "TextBox3"
		Me.TextBox3.Size = New System.Drawing.Size(100, 22)
		Me.TextBox3.TabIndex = 12
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(48, 161)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(62, 16)
		Me.Label2.TabIndex = 13
		Me.Label2.Text = "Высота"
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.Button6)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.Button5)
		Me.Controls.Add(Me.Button4)
		Me.Controls.Add(Me.Button3)
		Me.Controls.Add(Me.DGV1)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "Form1"
		Me.Text = "Planets"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ПланетыDataSet, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ПланетыBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Button6 As Button
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents ComboBox1 As ComboBox
	Friend WithEvents Label1 As Label
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents Button1 As Button
	Friend WithEvents Button2 As Button
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents Button5 As Button
	Friend WithEvents Button4 As Button
	Friend WithEvents Button3 As Button
	Friend WithEvents DGV1 As DataGridView
	Friend WithEvents ПланетыDataSet As ПланетыDataSet
	Friend WithEvents ПланетыBindingSource As BindingSource
	Friend WithEvents ПланетыTableAdapter As ПланетыDataSetTableAdapters.ПланетыTableAdapter
	Friend WithEvents Label2 As Label
	Friend WithEvents TextBox3 As TextBox
End Class
