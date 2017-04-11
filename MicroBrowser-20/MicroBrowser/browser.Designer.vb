<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMicroBrowser
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
        Me.cmdGo = New System.Windows.Forms.Button
        Me.txtWebAddress = New System.Windows.Forms.TextBox
        Me.brwBrowser = New System.Windows.Forms.WebBrowser
        Me.lblAddress = New System.Windows.Forms.GroupBox
        Me.cmdPrev = New System.Windows.Forms.Button
        Me.cmdStop = New System.Windows.Forms.Button
        Me.cmdNext = New System.Windows.Forms.Button
        Me.lblAuthor = New System.Windows.Forms.Label
        Me.grpNavBox = New System.Windows.Forms.GroupBox
        Me.cmdReload = New System.Windows.Forms.Button
        Me.cmdIxquick = New System.Windows.Forms.Button
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PageSourceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UtilitiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProgressBar = New System.Windows.Forms.ProgressBar
        Me.lblCompleted = New System.Windows.Forms.Label
        Me.lblAddress.SuspendLayout()
        Me.grpNavBox.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdGo
        '
        Me.cmdGo.BackColor = System.Drawing.Color.LimeGreen
        Me.cmdGo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdGo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGo.ForeColor = System.Drawing.Color.Black
        Me.cmdGo.Location = New System.Drawing.Point(420, 14)
        Me.cmdGo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdGo.Name = "cmdGo"
        Me.cmdGo.Size = New System.Drawing.Size(63, 20)
        Me.cmdGo.TabIndex = 0
        Me.cmdGo.Text = "Go..."
        Me.cmdGo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdGo.UseVisualStyleBackColor = False
        '
        'txtWebAddress
        '
        Me.txtWebAddress.BackColor = System.Drawing.Color.DarkGreen
        Me.txtWebAddress.ForeColor = System.Drawing.Color.Lime
        Me.txtWebAddress.Location = New System.Drawing.Point(8, 14)
        Me.txtWebAddress.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtWebAddress.Name = "txtWebAddress"
        Me.txtWebAddress.Size = New System.Drawing.Size(404, 20)
        Me.txtWebAddress.TabIndex = 3
        '
        'brwBrowser
        '
        Me.brwBrowser.Location = New System.Drawing.Point(35, 84)
        Me.brwBrowser.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.brwBrowser.MinimumSize = New System.Drawing.Size(27, 18)
        Me.brwBrowser.Name = "brwBrowser"
        Me.brwBrowser.Size = New System.Drawing.Size(1080, 581)
        Me.brwBrowser.TabIndex = 4
        '
        'lblAddress
        '
        Me.lblAddress.BackColor = System.Drawing.Color.Silver
        Me.lblAddress.Controls.Add(Me.cmdGo)
        Me.lblAddress.Controls.Add(Me.txtWebAddress)
        Me.lblAddress.Font = New System.Drawing.Font("BankGothic Md BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(7, 30)
        Me.lblAddress.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lblAddress.Size = New System.Drawing.Size(491, 42)
        Me.lblAddress.TabIndex = 6
        Me.lblAddress.TabStop = False
        Me.lblAddress.Text = "Address"
        '
        'cmdPrev
        '
        Me.cmdPrev.BackColor = System.Drawing.Color.LimeGreen
        Me.cmdPrev.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdPrev.Font = New System.Drawing.Font("BankGothic Lt BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrev.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdPrev.Location = New System.Drawing.Point(7, 84)
        Me.cmdPrev.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdPrev.Name = "cmdPrev"
        Me.cmdPrev.Size = New System.Drawing.Size(30, 581)
        Me.cmdPrev.TabIndex = 11
        Me.cmdPrev.Text = "<"
        Me.cmdPrev.UseVisualStyleBackColor = False
        '
        'cmdStop
        '
        Me.cmdStop.BackColor = System.Drawing.Color.LimeGreen
        Me.cmdStop.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdStop.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdStop.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdStop.Location = New System.Drawing.Point(7, 14)
        Me.cmdStop.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdStop.Name = "cmdStop"
        Me.cmdStop.Size = New System.Drawing.Size(53, 25)
        Me.cmdStop.TabIndex = 12
        Me.cmdStop.Text = "Stop"
        Me.cmdStop.UseVisualStyleBackColor = False
        '
        'cmdNext
        '
        Me.cmdNext.BackColor = System.Drawing.Color.LimeGreen
        Me.cmdNext.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdNext.Font = New System.Drawing.Font("BankGothic Lt BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNext.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdNext.Location = New System.Drawing.Point(1115, 84)
        Me.cmdNext.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(30, 581)
        Me.cmdNext.TabIndex = 14
        Me.cmdNext.Text = ">"
        Me.cmdNext.UseVisualStyleBackColor = False
        '
        'lblAuthor
        '
        Me.lblAuthor.AutoSize = True
        Me.lblAuthor.Location = New System.Drawing.Point(1048, 671)
        Me.lblAuthor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(93, 12)
        Me.lblAuthor.TabIndex = 15
        Me.lblAuthor.Text = "Michael 2012"
        '
        'grpNavBox
        '
        Me.grpNavBox.BackColor = System.Drawing.Color.Silver
        Me.grpNavBox.Controls.Add(Me.cmdReload)
        Me.grpNavBox.Controls.Add(Me.cmdStop)
        Me.grpNavBox.Location = New System.Drawing.Point(505, 30)
        Me.grpNavBox.Name = "grpNavBox"
        Me.grpNavBox.Size = New System.Drawing.Size(198, 45)
        Me.grpNavBox.TabIndex = 21
        Me.grpNavBox.TabStop = False
        Me.grpNavBox.Text = "Navigation"
        '
        'cmdReload
        '
        Me.cmdReload.BackColor = System.Drawing.Color.LimeGreen
        Me.cmdReload.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdReload.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReload.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdReload.Location = New System.Drawing.Point(68, 14)
        Me.cmdReload.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdReload.Name = "cmdReload"
        Me.cmdReload.Size = New System.Drawing.Size(123, 25)
        Me.cmdReload.TabIndex = 13
        Me.cmdReload.Text = "Reload"
        Me.cmdReload.UseVisualStyleBackColor = False
        '
        'cmdIxquick
        '
        Me.cmdIxquick.BackColor = System.Drawing.Color.LimeGreen
        Me.cmdIxquick.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdIxquick.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdIxquick.Location = New System.Drawing.Point(709, 44)
        Me.cmdIxquick.Name = "cmdIxquick"
        Me.cmdIxquick.Size = New System.Drawing.Size(128, 28)
        Me.cmdIxquick.TabIndex = 23
        Me.cmdIxquick.Text = "ixquick Search"
        Me.cmdIxquick.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(947, 1)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(194, 19)
        Me.DateTimePicker1.TabIndex = 25
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.LightGray
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ViewToolStripMenuItem, Me.UtilitiesToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1146, 24)
        Me.MenuStrip1.TabIndex = 29
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.BackColor = System.Drawing.Color.Silver
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(97, 22)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PageSourceToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'PageSourceToolStripMenuItem
        '
        Me.PageSourceToolStripMenuItem.BackColor = System.Drawing.Color.Silver
        Me.PageSourceToolStripMenuItem.Name = "PageSourceToolStripMenuItem"
        Me.PageSourceToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.PageSourceToolStripMenuItem.Text = "Page Source"
        '
        'UtilitiesToolStripMenuItem
        '
        Me.UtilitiesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.UtilitiesToolStripMenuItem.Name = "UtilitiesToolStripMenuItem"
        Me.UtilitiesToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.UtilitiesToolStripMenuItem.Text = "Utilities"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.BackColor = System.Drawing.Color.Silver
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.MenuToolStripMenuItem.Text = "Menu"
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
        Me.AboutToolStripMenuItem.BackColor = System.Drawing.Color.Silver
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(7, 671)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(316, 19)
        Me.ProgressBar.TabIndex = 30
        '
        'lblCompleted
        '
        Me.lblCompleted.AutoSize = True
        Me.lblCompleted.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompleted.Location = New System.Drawing.Point(329, 671)
        Me.lblCompleted.Name = "lblCompleted"
        Me.lblCompleted.Size = New System.Drawing.Size(71, 17)
        Me.lblCompleted.TabIndex = 31
        Me.lblCompleted.Text = "Loading..."
        '
        'frmMicroBrowser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1146, 692)
        Me.Controls.Add(Me.lblCompleted)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.cmdNext)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.cmdPrev)
        Me.Controls.Add(Me.cmdIxquick)
        Me.Controls.Add(Me.grpNavBox)
        Me.Controls.Add(Me.lblAuthor)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.brwBrowser)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("BankGothic Md BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.Name = "frmMicroBrowser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MicroBrowser 2.0"
        Me.lblAddress.ResumeLayout(False)
        Me.lblAddress.PerformLayout()
        Me.grpNavBox.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdGo As System.Windows.Forms.Button
    Friend WithEvents txtWebAddress As System.Windows.Forms.TextBox
    Friend WithEvents brwBrowser As System.Windows.Forms.WebBrowser
    Friend WithEvents lblAddress As System.Windows.Forms.GroupBox
    Friend WithEvents cmdPrev As System.Windows.Forms.Button
    Friend WithEvents cmdStop As System.Windows.Forms.Button
    Friend WithEvents cmdNext As System.Windows.Forms.Button
    Friend WithEvents lblAuthor As System.Windows.Forms.Label
    Friend WithEvents grpNavBox As System.Windows.Forms.GroupBox
    Friend WithEvents cmdIxquick As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PageSourceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdReload As System.Windows.Forms.Button
    Friend WithEvents UtilitiesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents lblCompleted As System.Windows.Forms.Label

End Class
