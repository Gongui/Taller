﻿Public Class Form1


    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim mensaje As String = "Falta completar lo siguientes campos:"
        Dim t As String = ""
        If Me.Tag = "Alter" Then
            If Cb_Jefe_taller.Text = "" Then
                t = t + Convert.ToChar(13) + "  Jefe de taller"
            End If
            If MTb_Dominio.Text = "" Then
                t = t + Convert.ToChar(13) + "  Dominio"
            End If
            If Tb_Propietario.Text = "" Then
                t = t + Convert.ToChar(13) + "  Propietario"
            End If
            If Cb_Conductor.Text = "" Then
                t = t + Convert.ToChar(13) + "  Conductor"
            End If
            If Tb_Trabajo_Sol.Text = "" Then
                t = t + Convert.ToChar(13) + "  Trabajo Solicitado"
            End If
            If Not (Prior_Baja.Checked Or Prior_Media.Checked Or Prior_Alta.Checked) Then
                t = t + Convert.ToChar(13) + "  Prioridad"
            End If
            If Not t = "" Then
                mensaje += t
                MessageBox.Show(mensaje, "Advertencia!")
            End If
            Select Case MessageBox.Show("Desea guardar el archivo?", "Falta información!", MessageBoxButtons.YesNoCancel)
                Case Windows.Forms.DialogResult.Yes
                Case Windows.Forms.DialogResult.No
                Case Windows.Forms.DialogResult.Cancel
                    e.Cancel = True
            End Select
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tag = ""
        Tb_Norden.Text = My.Settings.nro_orden.ToString.PadLeft(6, "0")
        Dim ColumnaMecanicos As DataGridViewComboBoxColumn = DataGridView1.Columns(0)
        ColumnaMecanicos.Items.Clear()
        For Each Mec In My.Settings.Mecanicos
            ColumnaMecanicos.Items.Add(Mec)
        Next
        Cb_Jefe_taller.Items.Clear()
        For Each Jefe In My.Settings.Jefes
            Cb_Jefe_taller.Items.Add(Jefe)
        Next
        Dim ColumnaReparaciones As DataGridViewComboBoxColumn = DataGridView1.Columns(1)
        ColumnaReparaciones.Items.Clear()
        For Each Rep In My.Settings.Reparaciones
            ColumnaReparaciones.Items.Add(Rep)
        Next

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chb_Copiar_Orden.CheckedChanged
        If Chb_Copiar_Orden.Checked Then
            Chb_Copiar_Orden.Tag = "Sel"
        Else
            Chb_Copiar_Orden.Tag = ""
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If DataGridView1.CurrentCell.ColumnIndex = 3 Then
            If Dialogo_Fecha.ShowDialog = vbOK Then
                DataGridView1.CurrentRow.Cells(3).Value = Dialogo_Fecha.Tag
            End If
        End If
    End Sub

    Private Sub DataGridView1_RowValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.RowValidated
        DataGridView1.CurrentRow.ErrorText = ""
    End Sub

    Private Sub DataGridView1_RowValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles DataGridView1.RowValidating
        DataGridView1.ShowRowErrors = True
        If DataGridView1.CurrentRow.Cells(0).Value = "" Or DataGridView1.CurrentRow.Cells(1).Value = "" Or DataGridView1.CurrentRow.Cells(2).Value = "" Then
            DataGridView1.CurrentRow.ErrorText = "El dato es obligatorio:"
            'e.Cancel = True
            'Label4.Text = "*Recuerde Que Todos Los Campos Deben Estar Completos"
            'Label4.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Tb_NOrden_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Tag = "Alter"
    End Sub

    Private Sub Tb_Dominio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Tag = "Alter"
    End Sub

    Private Sub Tb_Propietario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tb_Propietario.TextChanged
        Me.Tag = "Alter"
    End Sub

    Private Sub Cb_Jefe_taller_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_Jefe_taller.SelectedIndexChanged
        Me.Tag = "Alter"
    End Sub

    Private Sub Cb_Conductor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_Conductor.SelectedIndexChanged
        Me.Tag = "Alter"
    End Sub

    Private Sub Tb_Trabajo_Sol_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tb_Trabajo_Sol.TextChanged
        Me.Tag = "Alter"
    End Sub

    Private Sub Prior_Baja_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Prior_Baja.CheckedChanged
        Me.Tag = "Alter"
    End Sub

    Private Sub Prior_Media_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Prior_Media.CheckedChanged
        Me.Tag = "Alter"
    End Sub

    Private Sub Prior_Alta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Prior_Alta.CheckedChanged
        Me.Tag = "Alter"
    End Sub

    Private Sub Bt_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_Imprimir.Click
        SendKeys.Send("^p")
    End Sub

    Private Sub MTb_NOrden_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs)
        Me.Tag = "Alter"
    End Sub

    Private Sub MTb_Dominio_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles MTb_Dominio.MaskInputRejected
        Me.Tag = "Alter"
    End Sub
End Class
