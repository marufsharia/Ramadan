Public Class contactus

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        WebBrowser1.Visible = True
    End Sub

    Private Sub contactus_Load(sender As Object, e As EventArgs) Handles Me.Load
        WebBrowser1.Visible = False
    End Sub
End Class