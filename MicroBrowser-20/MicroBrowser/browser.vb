Public Class frmMicroBrowser
    'Main browser window. Most the code for MicroBrowser in this file
    Private Sub frmMicroBrowser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    'Address bar
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtWebAddress.TextChanged

    End Sub

    'Go button
    Private Sub cmdGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGo.Click
        brwBrowser.Navigate(txtWebAddress.Text)
    End Sub

    'Navigate to previous page
    Private Sub cmdPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrev.Click
        brwBrowser.GoBack()
    End Sub

    'Navigate to next or recently loaded page
    Private Sub cmdNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNext.Click
        brwBrowser.GoForward()
    End Sub

    'Stop button
    Private Sub cmdStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStop.Click
        brwBrowser.Stop()
    End Sub

    'Reload button
    Private Sub cmdReload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReload.Click
        brwBrowser.Refresh()
    End Sub

    Private Sub lblCurrent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmdAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmAbout.Show()
    End Sub

    'Load IXquick search engine page
    Private Sub cmdGoGoogle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIxquick.Click
        brwBrowser.Navigate("https://www.ixquick.com")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub lblAddress_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAddress.Enter

    End Sub

    'View page source option in toolstrip. To be completed
    Private Sub PageSourceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageSourceToolStripMenuItem.Click
        frmSourceView.Show()
    End Sub

    'About option  in toolstrip. Opens help window.
    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.Show()
    End Sub

    'Quit option in toolstrip
    Private Sub QuitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitToolStripMenuItem.Click
        Me.Close()
    End Sub

    'Main browser form element
    Private Sub brwBrowser_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles brwBrowser.DocumentCompleted
        'Change text next to status bar when page loaded
        lblCompleted.Text = "Complete"
    End Sub

    Private Sub MenuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuToolStripMenuItem.Click
        frmUtilities.Show()
    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    'Progress bar. See handler code
    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar.Click

    End Sub

    'Progress bar event handler code
    Private Sub brwBrowser_ProgressChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) Handles brwBrowser.ProgressChanged
        ProgressBar.Maximum = e.MaximumProgress
        ProgressBar.Value = e.CurrentProgress
    End Sub

    'Display date and calendar
    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub FileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileToolStripMenuItem.Click

    End Sub
End Class
