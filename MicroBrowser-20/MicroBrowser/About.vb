Public Class frmAbout

    Private Sub cmdOkay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOkay.Click
        frmMicroBrowser.Show()
        Me.Hide()
    End Sub

    Private Sub frmAbout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class