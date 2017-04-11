Public Class frmUtilities

    Private Sub frmOnlineServices_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdDropBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIxquick.Click
        frmMicroBrowser.brwBrowser.Navigate("https://www.ixquick.com")
        Me.Close()
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub
End Class