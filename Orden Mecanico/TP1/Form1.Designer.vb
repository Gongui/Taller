<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Cb_Jefe_taller = New System.Windows.Forms.ComboBox()
        Me.Prior_Baja = New System.Windows.Forms.RadioButton()
        Me.Prior_Media = New System.Windows.Forms.RadioButton()
        Me.Prior_Alta = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Tb_Propietario = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Tb_Trabajo_Sol = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Gb_Prioridad = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Mecanico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Reparacion = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Cargahoraria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Tab_Gen = New System.Windows.Forms.TabPage()
        Me.MTb_NOrden = New System.Windows.Forms.MaskedTextBox()
        Me.MTb_Dominio = New System.Windows.Forms.MaskedTextBox()
        Me.Cb_Conductor = New System.Windows.Forms.ComboBox()
        Me.Tab_Rep = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Tab_Ent = New System.Windows.Forms.TabPage()
        Me.Chb_Copiar_Orden = New System.Windows.Forms.CheckBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Gb_Prioridad.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.Tab_Gen.SuspendLayout()
        Me.Tab_Rep.SuspendLayout()
        Me.Tab_Ent.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nro de orden:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(340, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Jefe de taller receptor:"
        '
        'Cb_Jefe_taller
        '
        Me.Cb_Jefe_taller.FormattingEnabled = True
        Me.Cb_Jefe_taller.Items.AddRange(New Object() {"Juan Perez"})
        Me.Cb_Jefe_taller.Location = New System.Drawing.Point(6, 96)
        Me.Cb_Jefe_taller.Name = "Cb_Jefe_taller"
        Me.Cb_Jefe_taller.Size = New System.Drawing.Size(300, 21)
        Me.Cb_Jefe_taller.TabIndex = 5
        '
        'Prior_Baja
        '
        Me.Prior_Baja.AutoSize = True
        Me.Prior_Baja.Location = New System.Drawing.Point(10, 19)
        Me.Prior_Baja.Name = "Prior_Baja"
        Me.Prior_Baja.Size = New System.Drawing.Size(46, 17)
        Me.Prior_Baja.TabIndex = 7
        Me.Prior_Baja.TabStop = True
        Me.Prior_Baja.Text = "Baja"
        Me.Prior_Baja.UseVisualStyleBackColor = True
        '
        'Prior_Media
        '
        Me.Prior_Media.AutoSize = True
        Me.Prior_Media.Location = New System.Drawing.Point(124, 19)
        Me.Prior_Media.Name = "Prior_Media"
        Me.Prior_Media.Size = New System.Drawing.Size(54, 17)
        Me.Prior_Media.TabIndex = 8
        Me.Prior_Media.TabStop = True
        Me.Prior_Media.Text = "Media"
        Me.Prior_Media.UseVisualStyleBackColor = True
        '
        'Prior_Alta
        '
        Me.Prior_Alta.AutoSize = True
        Me.Prior_Alta.Location = New System.Drawing.Point(251, 19)
        Me.Prior_Alta.Name = "Prior_Alta"
        Me.Prior_Alta.Size = New System.Drawing.Size(43, 17)
        Me.Prior_Alta.TabIndex = 9
        Me.Prior_Alta.TabStop = True
        Me.Prior_Alta.Text = "Alta"
        Me.Prior_Alta.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Dominio:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(366, 173)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Kilometraje:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(340, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Conductor:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(340, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Propietario:"
        '
        'Tb_Propietario
        '
        Me.Tb_Propietario.Location = New System.Drawing.Point(343, 97)
        Me.Tb_Propietario.Name = "Tb_Propietario"
        Me.Tb_Propietario.Size = New System.Drawing.Size(300, 20)
        Me.Tb_Propietario.TabIndex = 15
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(369, 189)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(300, 20)
        Me.TextBox5.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Trabajo solicitado:"
        '
        'Tb_Trabajo_Sol
        '
        Me.Tb_Trabajo_Sol.Location = New System.Drawing.Point(19, 33)
        Me.Tb_Trabajo_Sol.Multiline = True
        Me.Tb_Trabajo_Sol.Name = "Tb_Trabajo_Sol"
        Me.Tb_Trabajo_Sol.Size = New System.Drawing.Size(300, 116)
        Me.Tb_Trabajo_Sol.TabIndex = 19
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(343, 32)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(300, 20)
        Me.DateTimePicker1.TabIndex = 20
        '
        'Gb_Prioridad
        '
        Me.Gb_Prioridad.Controls.Add(Me.Prior_Baja)
        Me.Gb_Prioridad.Controls.Add(Me.Prior_Media)
        Me.Gb_Prioridad.Controls.Add(Me.Prior_Alta)
        Me.Gb_Prioridad.Location = New System.Drawing.Point(343, 59)
        Me.Gb_Prioridad.Name = "Gb_Prioridad"
        Me.Gb_Prioridad.Size = New System.Drawing.Size(300, 51)
        Me.Gb_Prioridad.TabIndex = 28
        Me.Gb_Prioridad.TabStop = False
        Me.Gb_Prioridad.Text = "Prioridad"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Mecanico, Me.Reparacion, Me.Cargahoraria, Me.Fecha})
        Me.DataGridView1.Location = New System.Drawing.Point(3, 170)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(643, 258)
        Me.DataGridView1.TabIndex = 21
        '
        'Mecanico
        '
        Me.Mecanico.HeaderText = "Mecanico"
        Me.Mecanico.Name = "Mecanico"
        '
        'Reparacion
        '
        Me.Reparacion.HeaderText = "Reparación"
        Me.Reparacion.Items.AddRange(New Object() {"ee"})
        Me.Reparacion.Name = "Reparacion"
        Me.Reparacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Cargahoraria
        '
        Me.Cargahoraria.FillWeight = 70.0!
        Me.Cargahoraria.HeaderText = "Horas trabajadas"
        Me.Cargahoraria.Name = "Cargahoraria"
        '
        'Fecha
        '
        Me.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Fecha.HeaderText = "Fecha (dd/mm/aaaa)"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Fecha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Fecha.Width = 162
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.Tab_Gen)
        Me.TabControl1.Controls.Add(Me.Tab_Rep)
        Me.TabControl1.Controls.Add(Me.Tab_Ent)
        Me.TabControl1.Location = New System.Drawing.Point(28, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(667, 462)
        Me.TabControl1.TabIndex = 32
        '
        'Tab_Gen
        '
        Me.Tab_Gen.Controls.Add(Me.MTb_NOrden)
        Me.Tab_Gen.Controls.Add(Me.MTb_Dominio)
        Me.Tab_Gen.Controls.Add(Me.Cb_Conductor)
        Me.Tab_Gen.Controls.Add(Me.DateTimePicker1)
        Me.Tab_Gen.Controls.Add(Me.Label7)
        Me.Tab_Gen.Controls.Add(Me.Label8)
        Me.Tab_Gen.Controls.Add(Me.Tb_Propietario)
        Me.Tab_Gen.Controls.Add(Me.Label5)
        Me.Tab_Gen.Controls.Add(Me.Cb_Jefe_taller)
        Me.Tab_Gen.Controls.Add(Me.Label3)
        Me.Tab_Gen.Controls.Add(Me.Label1)
        Me.Tab_Gen.Controls.Add(Me.Label2)
        Me.Tab_Gen.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Gen.Name = "Tab_Gen"
        Me.Tab_Gen.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Gen.Size = New System.Drawing.Size(659, 436)
        Me.Tab_Gen.TabIndex = 0
        Me.Tab_Gen.Text = "General"
        Me.Tab_Gen.UseVisualStyleBackColor = True
        '
        'MTb_NOrden
        '
        Me.MTb_NOrden.Location = New System.Drawing.Point(7, 35)
        Me.MTb_NOrden.Mask = "999999"
        Me.MTb_NOrden.Name = "MTb_NOrden"
        Me.MTb_NOrden.Size = New System.Drawing.Size(299, 20)
        Me.MTb_NOrden.TabIndex = 36
        '
        'MTb_Dominio
        '
        Me.MTb_Dominio.Location = New System.Drawing.Point(7, 167)
        Me.MTb_Dominio.Mask = "LLL-999"
        Me.MTb_Dominio.Name = "MTb_Dominio"
        Me.MTb_Dominio.Size = New System.Drawing.Size(299, 20)
        Me.MTb_Dominio.TabIndex = 35
        '
        'Cb_Conductor
        '
        Me.Cb_Conductor.FormattingEnabled = True
        Me.Cb_Conductor.Items.AddRange(New Object() {"Grua"})
        Me.Cb_Conductor.Location = New System.Drawing.Point(343, 166)
        Me.Cb_Conductor.Name = "Cb_Conductor"
        Me.Cb_Conductor.Size = New System.Drawing.Size(300, 21)
        Me.Cb_Conductor.TabIndex = 32
        '
        'Tab_Rep
        '
        Me.Tab_Rep.Controls.Add(Me.Label4)
        Me.Tab_Rep.Controls.Add(Me.DataGridView1)
        Me.Tab_Rep.Controls.Add(Me.Tb_Trabajo_Sol)
        Me.Tab_Rep.Controls.Add(Me.Gb_Prioridad)
        Me.Tab_Rep.Controls.Add(Me.Label9)
        Me.Tab_Rep.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Rep.Name = "Tab_Rep"
        Me.Tab_Rep.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Rep.Size = New System.Drawing.Size(659, 436)
        Me.Tab_Rep.TabIndex = 1
        Me.Tab_Rep.Text = "Reparaciones"
        Me.Tab_Rep.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(340, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 29
        '
        'Tab_Ent
        '
        Me.Tab_Ent.Controls.Add(Me.Label10)
        Me.Tab_Ent.Controls.Add(Me.GroupBox1)
        Me.Tab_Ent.Controls.Add(Me.DateTimePicker2)
        Me.Tab_Ent.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Ent.Name = "Tab_Ent"
        Me.Tab_Ent.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Ent.Size = New System.Drawing.Size(659, 436)
        Me.Tab_Ent.TabIndex = 2
        Me.Tab_Ent.Text = "Entrega"
        Me.Tab_Ent.UseVisualStyleBackColor = True
        '
        'Chb_Copiar_Orden
        '
        Me.Chb_Copiar_Orden.Appearance = System.Windows.Forms.Appearance.Button
        Me.Chb_Copiar_Orden.AutoSize = True
        Me.Chb_Copiar_Orden.Location = New System.Drawing.Point(3, 8)
        Me.Chb_Copiar_Orden.Name = "Chb_Copiar_Orden"
        Me.Chb_Copiar_Orden.Size = New System.Drawing.Size(23, 23)
        Me.Chb_Copiar_Orden.TabIndex = 33
        Me.Chb_Copiar_Orden.Text = "<"
        Me.Chb_Copiar_Orden.UseVisualStyleBackColor = True
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(337, 40)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(300, 20)
        Me.DateTimePicker2.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(39, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(164, 53)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Recibi en conformidad:"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(19, 21)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(34, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Si"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(101, 21)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(39, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "No"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(334, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Fecha:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 463)
        Me.Controls.Add(Me.Chb_Copiar_Orden)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label6)
        Me.Name = "Form1"
        Me.Text = "FormOrden"
        Me.Gb_Prioridad.ResumeLayout(False)
        Me.Gb_Prioridad.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.Tab_Gen.ResumeLayout(False)
        Me.Tab_Gen.PerformLayout()
        Me.Tab_Rep.ResumeLayout(False)
        Me.Tab_Rep.PerformLayout()
        Me.Tab_Ent.ResumeLayout(False)
        Me.Tab_Ent.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Cb_Jefe_taller As System.Windows.Forms.ComboBox
    Friend WithEvents Prior_Baja As System.Windows.Forms.RadioButton
    Friend WithEvents Prior_Media As System.Windows.Forms.RadioButton
    Friend WithEvents Prior_Alta As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Tb_Propietario As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Tb_Trabajo_Sol As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Gb_Prioridad As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Tab_Gen As System.Windows.Forms.TabPage
    Friend WithEvents Tab_Rep As System.Windows.Forms.TabPage
    Friend WithEvents Tab_Ent As System.Windows.Forms.TabPage
    Friend WithEvents Cb_Conductor As System.Windows.Forms.ComboBox
    Friend WithEvents Chb_Copiar_Orden As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Mecanico As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Reparacion As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Cargahoraria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents MTb_Dominio As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MTb_NOrden As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker

End Class
