﻿Imports System.Windows.Forms

Public Class MDIParent1

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click, NewToolStripButton.Click, NewWindowToolStripMenuItem.Click
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New Form1
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me
        m_ChildFormNumber += 1
        ChildForm.Text = "Orden Objeto Nro " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click, OpenToolStripButton.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: agregue código aquí para abrir el archivo.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*" 

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CutToolStripMenuItem.Click
        'My.Computer.Clipboard.SetText(Me.ActiveMdiChild.ActiveControl.Text)
        'Me.ActiveMdiChild.ActiveControl.Text = ""
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
        SendKeys.Send("^X")
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CopyToolStripMenuItem.Click
        If ActiveMdiChild.Controls("Chb_Copiar_Orden").Tag = "SEL" Then
            Dim Texto As String = ""
            Dim TempForm As Form1 = ActiveMdiChild
            Texto = "Ficha " & m_ChildFormNumber & Convert.ToChar(13) _
                    & "Nro de orden: " & TempForm.MTb_NOrden.Text & Convert.ToChar(13) _
                    & "Dominio: " & TempForm.MTb_Dominio.Text & Convert.ToChar(13) _
                    & "Propietario: " & TempForm.Tb_Propietario.Text & Convert.ToChar(13) _
                    & "Conductor: " & TempForm.Cb_Conductor.Text & Convert.ToChar(13) _
                    & "Fecha: " & TempForm.DateTimePicker2.Text & Convert.ToChar(13) _
                    & "Jefe de Taller: " & TempForm.Cb_Jefe_taller.Text & Convert.ToChar(13) _
                    & "Trabajo Solicitado: " & TempForm.Tb_Trabajo_Sol.Text
            For Each CBox In TempForm.Gb_Prioridad.Controls
                If CBox.Checked Then
                    Texto = Texto & "Prioridad: " & CBox.Text
                End If
            Next
            My.Computer.Clipboard.SetText(Texto)

        Else
            SendKeys.Send("^C")
        End If
        'My.Computer.Clipboard.SetText(Me.ActiveMdiChild.ActiveControl.Text)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PasteToolStripMenuItem.Click
        SendKeys.Send("^V")
        'Me.ActiveMdiChild.ActiveControl.Text = My.Computer.Clipboard.GetText()
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.MdiParent = Me
        AboutBox1.Show()
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionsToolStripMenuItem.Click
        If Opciones.ShowDialog = vbOK Then
            My.Settings.Mecanicos.Clear()
            For Each mecanico In Opciones.Lb_Mecanicos.Items
                My.Settings.Mecanicos.Add(mecanico)
            Next
            My.Settings.Reparaciones.Clear()
            My.Settings.Precios.Clear()
            For Each Row In Opciones.DG_reparaciones.Rows
                My.Settings.Reparaciones.Add(Row.Cells(0).Value)
                My.Settings.Precios.Add(Row.Cells(1).Value)
            Next
        End If
    End Sub

    Private Sub PrintToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripButton.Click

    End Sub

    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            PrintDocument1.Print()
        End If
    End Sub


    Private Sub PrintSetupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintSetupToolStripMenuItem.Click
        PageSetupDialog1.Document = PrintDocument1
        If PageSetupDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PrintDocument1.DefaultPageSettings = PageSetupDialog1.PageSettings
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim Texto As String = ""
        Dim TempForm As Form1 = ActiveMdiChild
        Texto = "Ficha " & m_ChildFormNumber & Convert.ToChar(13) _
                & "Nro de orden: " & TempForm.MTb_NOrden.Text & Convert.ToChar(13) _
                & "Dominio: " & TempForm.MTb_Dominio.Text & Convert.ToChar(13) _
                & "Propietario: " & TempForm.Tb_Propietario.Text & Convert.ToChar(13) _
                & "Conductor: " & TempForm.Cb_Conductor.Text & Convert.ToChar(13) _
                & "Fecha: " & TempForm.DateTimePicker2.Text & Convert.ToChar(13) _
                & "Jefe de Taller: " & TempForm.Cb_Jefe_taller.Text & Convert.ToChar(13) _
                & "Trabajo Solicitado: " & TempForm.Tb_Trabajo_Sol.Text & Convert.ToChar(13)
        Texto = Texto + "Trabajo realizado: " & Convert.ToChar(13)
        For Each Row In TempForm.DataGridView1.Rows
            Texto = Texto & "Reparacion: " & Row.Cells.Item(0).Value & Convert.ToChar(13) _
             & "Mecanico: " & Row.Cells.Item(1).Value & Convert.ToChar(13) _
             & "Horas empleadas: " & Row.Cells.Item(2).Value & Convert.ToChar(13)
        Next
        MsgBox(Texto)
        For Each formhijo As Form1 In Me.MdiChildren
            If Me.ActiveMdiChild.Text = formhijo.Text Then
                e.Graphics.DrawString(Texto, New Font("Courier new", 24, FontStyle.Regular), Brushes.Black, 10, 10)
            End If
        Next
    End Sub

    Private Sub PrintPreviewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewToolStripMenuItem.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub
End Class
