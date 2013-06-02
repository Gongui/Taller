Imports System.Windows.Forms

Public Class Opciones
    Dim ColumnaReparaciones As DataGridViewComboBoxColumn

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Agregar_Mec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_Agre_mec.Click
        If Not Tb_nuevo_mec.Text = "" And Not Lb_Mecanicos.Items.Contains(Tb_nuevo_mec.Text) Then
            Lb_Mecanicos.Items.Add(Tb_nuevo_mec.Text)
        End If
    End Sub

    Private Sub Bt_Elim_mec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_Elim_mec.Click
        Lb_Mecanicos.Items.Remove(Lb_Mecanicos.SelectedItem)
    End Sub

    Private Sub Opciones_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Lb_Mecanicos.Items.Clear()
        For Each Mecanico In My.Settings.Mecanicos
            Lb_Mecanicos.Items.Add(Mecanico)
        Next
        Lb_jefesdetaller.Items.Clear()
        For Each Jefe In My.Settings.Jefes
            Lb_jefesdetaller.Items.Add(Jefe)
        Next
        DG_reparaciones.Rows.Clear()
        Dim i As Integer = 0
        For Each Rep In My.Settings.Reparaciones
            If Rep <> "" Then
                DG_reparaciones.Rows.Add()
            End If
            DG_reparaciones.Rows(i).Cells(0).Value = Rep
            i += 1
        Next
        i = 0
        For Each Price In My.Settings.Precios
            DG_reparaciones.Rows(i).Cells(1).Value = Price
            i += 1
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Not Tb_nuevo_jefe.Text = "" And Not Lb_jefesdetaller.Items.Contains(Tb_nuevo_jefe.Text) Then
            Lb_jefesdetaller.Items.Add(Tb_nuevo_jefe.Text)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Lb_jefesdetaller.Items.Remove(Lb_jefesdetaller.SelectedItem)
    End Sub
End Class
