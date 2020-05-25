<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.TextBox3 = New System.Windows.Forms.TextBox()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
		Me.GroupBox1.Controls.Add(Me.TextBox3)
		Me.GroupBox1.Controls.Add(Me.TextBox2)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Controls.Add(Me.TextBox1)
		Me.GroupBox1.Controls.Add(Me.Button2)
		Me.GroupBox1.Controls.Add(Me.Label3)
		Me.GroupBox1.Controls.Add(Me.Button1)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Bold)
		Me.GroupBox1.ForeColor = System.Drawing.Color.White
		Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(375, 305)
		Me.GroupBox1.TabIndex = 7
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Параметры"
		'
		'TextBox3
		'
		Me.TextBox3.ForeColor = System.Drawing.Color.Black
		Me.TextBox3.Location = New System.Drawing.Point(207, 153)
		Me.TextBox3.Name = "TextBox3"
		Me.TextBox3.Size = New System.Drawing.Size(125, 28)
		Me.TextBox3.TabIndex = 7
		'
		'TextBox2
		'
		Me.TextBox2.ForeColor = System.Drawing.Color.Black
		Me.TextBox2.Location = New System.Drawing.Point(207, 100)
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.Size = New System.Drawing.Size(125, 28)
		Me.TextBox2.TabIndex = 6
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.ForeColor = System.Drawing.Color.Black
		Me.Label1.Location = New System.Drawing.Point(26, 50)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(152, 17)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "Название планеты"
		'
		'TextBox1
		'
		Me.TextBox1.ForeColor = System.Drawing.Color.Black
		Me.TextBox1.Location = New System.Drawing.Point(207, 39)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(125, 28)
		Me.TextBox1.TabIndex = 0
		'
		'Button2
		'
		Me.Button2.ForeColor = System.Drawing.Color.Black
		Me.Button2.Location = New System.Drawing.Point(217, 223)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(95, 39)
		Me.Button2.TabIndex = 3
		Me.Button2.Text = "Отмена"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.ForeColor = System.Drawing.Color.Black
		Me.Label3.Location = New System.Drawing.Point(26, 164)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(132, 17)
		Me.Label3.TabIndex = 5
		Me.Label3.Text = "Радиус планеты"
		'
		'Button1
		'
		Me.Button1.ForeColor = System.Drawing.Color.Black
		Me.Button1.Location = New System.Drawing.Point(55, 223)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(95, 39)
		Me.Button1.TabIndex = 2
		Me.Button1.Text = "Добавить"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.ForeColor = System.Drawing.Color.Black
		Me.Label2.Location = New System.Drawing.Point(26, 111)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(124, 17)
		Me.Label2.TabIndex = 4
		Me.Label2.Text = "Масса планеты"
		'
		'Form2
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
		Me.ClientSize = New System.Drawing.Size(397, 332)
		Me.Controls.Add(Me.GroupBox1)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "Form2"
		Me.Text = "Planets"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents TextBox3 As TextBox
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents Button2 As Button
	Friend WithEvents Label3 As Label
	Friend WithEvents Button1 As Button
	Friend WithEvents Label2 As Label
End Class
