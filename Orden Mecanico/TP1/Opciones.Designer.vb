<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Opciones
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Lb_Mecanicos = New System.Windows.Forms.ListBox()
        Me.Bt_Elim_mec = New System.Windows.Forms.Button()
        Me.Bt_Agre_mec = New System.Windows.Forms.Button()
        Me.Tb_nuevo_mec = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Lb_jefesdetaller = New System.Windows.Forms.ListBox()
        Me.Tb_nuevo_jefe = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DG_reparaciones = New System.Windows.Forms.DataGridView()
        Me.Reparacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MyApplicationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DG_reparaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyApplicationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(453, 310)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(1, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(612, 302)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Lb_Mecanicos)
        Me.TabPage1.Controls.Add(Me.Bt_Elim_mec)
        Me.TabPage1.Controls.Add(Me.Bt_Agre_mec)
        Me.TabPage1.Controls.Add(Me.Tb_nuevo_mec)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(604, 276)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Mecanicos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Lb_Mecanicos
        '
        Me.Lb_Mecanicos.FormattingEnabled = True
        Me.Lb_Mecanicos.Location = New System.Drawing.Point(8, 33)
        Me.Lb_Mecanicos.Name = "Lb_Mecanicos"
        Me.Lb_Mecanicos.Size = New System.Drawing.Size(498, 238)
        Me.Lb_Mecanicos.TabIndex = 4
        '
        'Bt_Elim_mec
        '
        Me.Bt_Elim_mec.Location = New System.Drawing.Point(513, 129)
        Me.Bt_Elim_mec.Name = "Bt_Elim_mec"
        Me.Bt_Elim_mec.Size = New System.Drawing.Size(85, 23)
        Me.Bt_Elim_mec.TabIndex = 3
        Me.Bt_Elim_mec.Text = "Quitar"
        Me.Bt_Elim_mec.UseVisualStyleBackColor = True
        '
        'Bt_Agre_mec
        '
        Me.Bt_Agre_mec.Location = New System.Drawing.Point(513, 4)
        Me.Bt_Agre_mec.Name = "Bt_Agre_mec"
        Me.Bt_Agre_mec.Size = New System.Drawing.Size(85, 23)
        Me.Bt_Agre_mec.TabIndex = 1
        Me.Bt_Agre_mec.Text = "Agregar"
        Me.Bt_Agre_mec.UseVisualStyleBackColor = True
        '
        'Tb_nuevo_mec
        '
        Me.Tb_nuevo_mec.Location = New System.Drawing.Point(7, 6)
        Me.Tb_nuevo_mec.Name = "Tb_nuevo_mec"
        Me.Tb_nuevo_mec.Size = New System.Drawing.Size(499, 20)
        Me.Tb_nuevo_mec.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Lb_jefesdetaller)
        Me.TabPage3.Controls.Add(Me.Tb_nuevo_jefe)
        Me.TabPage3.Controls.Add(Me.Button2)
        Me.TabPage3.Controls.Add(Me.Button1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(604, 276)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Jefes de Taller"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Lb_jefesdetaller
        '
        Me.Lb_jefesdetaller.FormattingEnabled = True
        Me.Lb_jefesdetaller.Location = New System.Drawing.Point(8, 33)
        Me.Lb_jefesdetaller.Name = "Lb_jefesdetaller"
        Me.Lb_jefesdetaller.Size = New System.Drawing.Size(489, 238)
        Me.Lb_jefesdetaller.TabIndex = 3
        '
        'Tb_nuevo_jefe
        '
        Me.Tb_nuevo_jefe.Location = New System.Drawing.Point(8, 6)
        Me.Tb_nuevo_jefe.Name = "Tb_nuevo_jefe"
        Me.Tb_nuevo_jefe.Size = New System.Drawing.Size(489, 20)
        Me.Tb_nuevo_jefe.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(503, 149)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(91, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Quitar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(503, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DG_reparaciones)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(604, 276)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Reparaciones"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DG_reparaciones
        '
        Me.DG_reparaciones.AllowUserToOrderColumns = True
        Me.DG_reparaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_reparaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Reparacion, Me.Precio})
        Me.DG_reparaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_reparaciones.Location = New System.Drawing.Point(3, 3)
        Me.DG_reparaciones.Name = "DG_reparaciones"
        Me.DG_reparaciones.Size = New System.Drawing.Size(598, 270)
        Me.DG_reparaciones.TabIndex = 0
        '
        'Reparacion
        '
        Me.Reparacion.HeaderText = "Reparación"
        Me.Reparacion.Name = "Reparacion"
        Me.Reparacion.Width = 455
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        '
        'MyApplicationBindingSource
        '
        Me.MyApplicationBindingSource.DataSource = GetType(WindowsApplication1.My.MyApplication)
        '
        'Opciones
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(611, 351)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Opciones"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Opciones"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DG_reparaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyApplicationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Bt_Agre_mec As System.Windows.Forms.Button
    Friend WithEvents Tb_nuevo_mec As System.Windows.Forms.TextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Bt_Elim_mec As System.Windows.Forms.Button
    Friend WithEvents DG_reparaciones As System.Windows.Forms.DataGridView
    Friend WithEvents MyApplicationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Reparacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Lb_Mecanicos As System.Windows.Forms.ListBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Lb_jefesdetaller As System.Windows.Forms.ListBox
    Friend WithEvents Tb_nuevo_jefe As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
