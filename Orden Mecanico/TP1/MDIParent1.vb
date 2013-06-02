Imports System.Windows.Forms

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
        SendKeys.Send("^x")
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CopyToolStripMenuItem.Click
        If ActiveMdiChild.Controls("Chb_Copiar_Orden").Tag = "Sel" Then
            Dim Texto As String = ""
            Dim TempForm As Form1 = ActiveMdiChild
            Texto = "Ficha " & m_ChildFormNumber & vbCrLf _
                    & "Nro de orden: " & TempForm.MTb_NOrden.Text & vbCrLf _
                    & "Fecha: " & TempForm.DateTimePicker2.Text & vbCrLf _
                    & "Dominio: " & TempForm.MTb_Dominio.Text & vbCrLf _
                    & "Propietario: " & TempForm.Tb_Propietario.Text & vbCrLf _
                    & "Conductor: " & TempForm.Cb_Conductor.Text & vbCrLf _
                    & "Jefe de Taller: " & TempForm.Cb_Jefe_taller.Text & vbCrLf _
                    & "Trabajo Solicitado: " & TempForm.Tb_Trabajo_Sol.Text & vbCrLf
            For Each CBox In TempForm.Gb_Prioridad.Controls
                If CBox.Checked Then
                    Texto = Texto & "Prioridad: " & CBox.Text & vbCrLf
                End If
            Next
            Texto = Texto & "Trabajos realizados:" & vbCrLf
            For Each Row As DataGridViewRow In TempForm.DataGridView1.Rows
                If Not Row.Cells(1).Value = "" Then
                    Texto = Texto & " ".PadLeft(4) & Row.Cells(1).Value & vbCrLf
                End If
            Next
            My.Computer.Clipboard.SetText(Texto)

        Else
            SendKeys.Send("^c")
        End If
        'My.Computer.Clipboard.SetText(Me.ActiveMdiChild.ActiveControl.Text)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PasteToolStripMenuItem.Click
        SendKeys.Send("^v")
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
        SendKeys.Send("^p")
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
        Texto = Texto & "Nro de orden: " & TempForm.MTb_NOrden.Text & vbNewLine _
                & "Fecha: " & TempForm.DateTimePicker2.Value.Date & vbNewLine _
                & "Dominio: " & TempForm.MTb_Dominio.Text & vbCrLf _
                & "Propietario: " & TempForm.Tb_Propietario.Text & vbCrLf _
                & "Conductor: " & TempForm.Cb_Conductor.Text & vbCrLf _
                & "Jefe de Taller: " & TempForm.Cb_Jefe_taller.Text & vbCrLf _
                & "Trabajo Solicitado: " & TempForm.Tb_Trabajo_Sol.Text & vbCrLf
        For Each CBox In TempForm.Gb_Prioridad.Controls
            If CBox.Checked Then
                Texto = Texto & "Prioridad: " & CBox.Text & vbCrLf
            End If
        Next
        Texto = Texto & "Trabajos realizados".PadRight(50) & "Precio".PadLeft(8) & vbCrLf
        Dim i As Integer = 0
        Dim suma As Integer = 0
        For Each Row As DataGridViewRow In TempForm.DataGridView1.Rows
            If Not Row.Cells(1).Value = "" Then
                Texto = Texto & "  " & Row.Cells.Item(1).Value.PadRight(50) _
                & "  $" & My.Settings.Precios(i).PadLeft(6) & vbCrLf
                suma += My.Settings.Precios(i)
                i += 1
            End If
        Next
        Text = Texto & "Total: $" & suma & vbCrLf
        For Each respuesta In TempForm.GroupBox1.Controls
            If respuesta.Checked Then
                Texto = Texto & "Recibi en conformidad: " & respuesta.Text
            End If
        Next
        For Each formhijo As Form1 In Me.MdiChildren
            If Me.ActiveMdiChild.Text = formhijo.Text Then
                e.Graphics.DrawString(Texto, New Font("Courier new", 14, FontStyle.Regular), Brushes.Black, 10, 10)
                e.Graphics.DrawString("Recibi en conformidad: ", New Font("Courier new", 14, FontStyle.Regular), Brushes.Black, 10, 400)
            End If
        Next

    End Sub

    Private Sub PrintPreviewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewToolStripMenuItem.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintPreviewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewToolStripButton.Click
        PrintPreviewToolStripMenuItem.PerformClick()
    End Sub
End Class
