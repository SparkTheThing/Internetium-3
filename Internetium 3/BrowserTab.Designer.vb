﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BrowserTab
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TabsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewTabToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseTabToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InternetiumToolbarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoogleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EBayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GmailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OutlookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutThisToolbarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BBCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AOLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EscargotToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(29, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "<<"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(47, 27)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(29, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = ">>"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(82, 27)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(53, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Refresh"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(141, 29)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(836, 20)
        Me.TextBox1.TabIndex = 3
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.Location = New System.Drawing.Point(983, 27)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(29, 23)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Go"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebBrowser1.Location = New System.Drawing.Point(12, 56)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(1000, 700)
        Me.WebBrowser1.TabIndex = 5
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TabsToolStripMenuItem, Me.InternetiumToolbarToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1024, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TabsToolStripMenuItem
        '
        Me.TabsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewTabToolStripMenuItem, Me.CloseTabToolStripMenuItem})
        Me.TabsToolStripMenuItem.Name = "TabsToolStripMenuItem"
        Me.TabsToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.TabsToolStripMenuItem.Text = "Tabs"
        '
        'NewTabToolStripMenuItem
        '
        Me.NewTabToolStripMenuItem.Name = "NewTabToolStripMenuItem"
        Me.NewTabToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.NewTabToolStripMenuItem.Text = "New Tab"
        '
        'CloseTabToolStripMenuItem
        '
        Me.CloseTabToolStripMenuItem.Name = "CloseTabToolStripMenuItem"
        Me.CloseTabToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.CloseTabToolStripMenuItem.Text = "Close Tab"
        '
        'InternetiumToolbarToolStripMenuItem
        '
        Me.InternetiumToolbarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GoogleToolStripMenuItem, Me.EBayToolStripMenuItem, Me.YTToolStripMenuItem, Me.GmailToolStripMenuItem, Me.OutlookToolStripMenuItem, Me.AboutThisToolbarToolStripMenuItem, Me.BBCToolStripMenuItem, Me.AOLToolStripMenuItem, Me.EscargotToolStripMenuItem})
        Me.InternetiumToolbarToolStripMenuItem.Name = "InternetiumToolbarToolStripMenuItem"
        Me.InternetiumToolbarToolStripMenuItem.Size = New System.Drawing.Size(125, 20)
        Me.InternetiumToolbarToolStripMenuItem.Text = "Internetium Toolbar"
        '
        'GoogleToolStripMenuItem
        '
        Me.GoogleToolStripMenuItem.Name = "GoogleToolStripMenuItem"
        Me.GoogleToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.GoogleToolStripMenuItem.Text = "Google"
        '
        'EBayToolStripMenuItem
        '
        Me.EBayToolStripMenuItem.Name = "EBayToolStripMenuItem"
        Me.EBayToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.EBayToolStripMenuItem.Text = "e-Bay"
        '
        'YTToolStripMenuItem
        '
        Me.YTToolStripMenuItem.Name = "YTToolStripMenuItem"
        Me.YTToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.YTToolStripMenuItem.Text = "YT"
        '
        'GmailToolStripMenuItem
        '
        Me.GmailToolStripMenuItem.Name = "GmailToolStripMenuItem"
        Me.GmailToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.GmailToolStripMenuItem.Text = "Gmail"
        '
        'OutlookToolStripMenuItem
        '
        Me.OutlookToolStripMenuItem.Name = "OutlookToolStripMenuItem"
        Me.OutlookToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.OutlookToolStripMenuItem.Text = "Outlook"
        '
        'AboutThisToolbarToolStripMenuItem
        '
        Me.AboutThisToolbarToolStripMenuItem.Name = "AboutThisToolbarToolStripMenuItem"
        Me.AboutThisToolbarToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.AboutThisToolbarToolStripMenuItem.Text = "About this toolbar"
        '
        'BBCToolStripMenuItem
        '
        Me.BBCToolStripMenuItem.Name = "BBCToolStripMenuItem"
        Me.BBCToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.BBCToolStripMenuItem.Text = "BBC"
        '
        'AOLToolStripMenuItem
        '
        Me.AOLToolStripMenuItem.Name = "AOLToolStripMenuItem"
        Me.AOLToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.AOLToolStripMenuItem.Text = "AOL"
        '
        'EscargotToolStripMenuItem
        '
        Me.EscargotToolStripMenuItem.Name = "EscargotToolStripMenuItem"
        Me.EscargotToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.EscargotToolStripMenuItem.Text = "Escargot"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'BrowserTab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "BrowserTab"
        Me.Text = "BrowserTab"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents InternetiumToolbarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GoogleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EBayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GmailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OutlookToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutThisToolbarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BBCToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AOLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EscargotToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewTabToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseTabToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
