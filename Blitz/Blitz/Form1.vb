Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tab2 As New TabPage
        Dim newtab As New tab2
        newtab.Show()
        newtab.Dock = DockStyle.Fill
        newtab.TopLevel = False
        tab2.Controls.Add(newtab)
        TabControl1.TabPages.Add(tab2)
    End Sub
End Class
