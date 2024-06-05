Public Class BrowserTab

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        WebBrowser1.Navigate(TextBox1.Text)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub GoogleToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GoogleToolStripMenuItem.Click
        WebBrowser1.Navigate("http://www.google.com")
    End Sub

    Private Sub NewTabToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NewTabToolStripMenuItem.Click
        Dim t As New TabPage
        Dim newtab As New BrowserTab
        newtab.Show()
        newtab.TopLevel = False
        newtab.Dock = DockStyle.Fill
        t.Controls.Add(newtab)
        Form1.TabControl1.TabPages.Add(t)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As System.Object, e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        Parent.Text = WebBrowser1.DocumentTitle
        TextBox1.Text = WebBrowser1.Url.ToString
    End Sub

    Private Sub BrowserTab_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate("https://www.google.com")
    End Sub
End Class