Public Class Form1



    Private Sub FlowLayoutPanel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        My.Computer.Audio.Play("windows logon sound.wav")
    End Sub


    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        RichTextBox1.Copy()

    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        RichTextBox1.Copy()

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Try
            Dim dlg As OpenFileDialog = New OpenFileDialog
            dlg.Title = "Open"
            dlg.Filter = "Louisoft Document Format (*.ldf)|*.ldf"
            If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                RichTextBox1.LoadFile(dlg.FileName)
            End If
        Catch ex As Exception : End Try
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
Save:
        Try
            Dim dlg As SaveFileDialog = New SaveFileDialog
            dlg.Title = "Save"
            dlg.Filter = "Louisoft Document Format (*.ldf)|*.ldf"
            If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                RichTextBox1.SaveFile(dlg.FileName, RichTextBoxStreamType.RichText)
            End If
        Catch ex As Exception : End Try

    End Sub

    Private Sub UndoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RichTextBox1.Undo()

    End Sub

    Private Sub HelpToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem1.Click
        MsgBox("Please note the help system is not finsihed yet")
        Form2.Show()
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        RichTextBox1.Clear()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click

    End Sub

    Private Sub BlueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BlueToolStripMenuItem.Click
        RichTextBox1.BackColor = Color.Aqua
    End Sub

    Private Sub BlackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BlackToolStripMenuItem.Click
        RichTextBox1.BackColor = Color.Black
    End Sub

    Private Sub DeactivateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Settings.Activate = False
        End
    End Sub

    Private Sub GreenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GreenToolStripMenuItem.Click
        RichTextBox1.BackColor = Color.Green
    End Sub
End Class
