Public Class Form1


    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim mensaje As String = "Falta completar lo siguientes campos:"
        If Me.Tag = "Alter" Then
            If MTb_NOrden.Text = "" Then
                mensaje = mensaje + Convert.ToChar(13) + "  Número de orden"
            End If
            If Cb_Jefe_taller.Text = "" Then
                mensaje = mensaje + Convert.ToChar(13) + "  Jefe de taller"
            End If
            If Not MTb_Dominio.Text = "" Then
                mensaje = mensaje + Convert.ToChar(13) + "  Dominio"
            End If
            If Tb_Propietario.Text = "" Then
                mensaje = mensaje + Convert.ToChar(13) + "  Propietario"
            End If
            If Cb_Conductor.Text = "" Then
                mensaje = mensaje + Convert.ToChar(13) + "  Conductor"
            End If
            If Tb_Trabajo_Sol.Text = "" Then
                mensaje = mensaje + Convert.ToChar(13) + "  Trabajo Solicitado"
            End If
            If Not (Prior_Baja.Checked Or Prior_Media.Checked Or Prior_Alta.Checked) Then
                mensaje = mensaje + Convert.ToChar(13) + "  Prioridad"
            End If
            MessageBox.Show(mensaje, "Error: Pantallazo azul inminente!!!")
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
            e.Cancel = True
            Label4.Text = "*Recuerde Que Todos Los Campos Deben Estar Completos A Excepcion De La Firma"
            Label4.ForeColor = Color.Red
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

End Class
