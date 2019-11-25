Imports System.Windows.Forms

Public Class FrmMainForm
    Private Sub ملفToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ملفToolStripMenuItem.Click

    End Sub

    Private Sub تاسيسشركةفرعToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles تاسيسشركةفرعToolStripMenuItem.Click
        Dim frmcompany As New FrmCompany
        frmcompany.MdiParent = Me
        frmcompany.Show()
    End Sub

    Private Sub السنةالماليةToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles السنةالماليةToolStripMenuItem.Click

    End Sub

    Private Sub ادخالقيديوميةToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ادخالقيديوميةToolStripMenuItem.Click
        Dim frmjournal As New FrmJournalEntry
        frmjournal.MdiParent = Me
        frmjournal.Show()
    End Sub
End Class
