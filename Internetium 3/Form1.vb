Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim t As New TabPage
        Dim newtab As New BrowserTab
        newtab.Show()
        newtab.TopLevel = False
        newtab.Dock = DockStyle.Fill
        t.Controls.Add(newtab)
        TabControl1.TabPages.Add(t)
    End Sub
End Class