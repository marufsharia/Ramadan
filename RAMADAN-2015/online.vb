Public Class online

    

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ForwardstepToolStripMenuItem.Click
        WebBrowser1.GoBack()
    End Sub

    

    

    Private Sub ForwardToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ForwardToolStripMenuItem1.Click
        WebBrowser1.GoForward()
    End Sub

    
    
    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        WebBrowser1.ShowPrintPreviewDialog()
    End Sub

    Private Sub ReloadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReloadToolStripMenuItem.Click
        WebBrowser1.Refresh()
    End Sub

   

    Private Sub CloseToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem2.Click
        main.Show()
        Me.Close()
    End Sub

    Private Sub WebBrowser1_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs) Handles WebBrowser1.Navigating
        ToolStripProgressBar1.Visible = True

        With ToolStripProgressBar1

            .Minimum = 0

            .Maximum = 50

            .Step = 5

        End With

        For index As Integer = 0 To 50 Step 5

            ToolStripProgressBar1.Value = index

            System.Threading.Thread.Sleep(35)

        Next

    End Sub

    

    

    
    
    

    
    

    

   
    Private Sub WebBrowser1_StatusTextChanged(sender As Object, e As EventArgs) Handles WebBrowser1.StatusTextChanged
        ToolStripStatusLabel1.Text = WebBrowser1.StatusText & " - (RAMADAN-2015)"

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        ToolStripProgressBar1.Visible = False
    End Sub

    Private Sub PropertiesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PropertiesToolStripMenuItem1.Click
        WebBrowser1.ShowPropertiesDialog() 'Show Page Properties Window
    End Sub


    

    Private Sub reloadpageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles reloadpageToolStripMenuItem.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub HomeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem1.Click
        WebBrowser1.Navigate("http://www.ifatwaa.com/")
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        WebBrowser1.ShowSaveAsDialog()
    End Sub

    Private Sub BackToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        WebBrowser1.Navigate("http://www.quraanshareef.org/")
    End Sub

    Private Sub StatusStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub homepageToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles homepageToolStripMenuItem1.Click


        WebBrowser1.Navigate("http://www.ifatwaa.com/")
    End Sub

    Private Sub GoToQuraanShareeforgToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoToQuraanShareeforgToolStripMenuItem.Click
        WebBrowser1.Navigate("http://www.quraanshareef.org/")
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Label1.Text = WebBrowser1.Url.ToString()

        Process.Start(Label1.Text)
    End Sub

    Private Sub openwithToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles openwithToolStripMenuItem.Click
        Label1.Text = WebBrowser1.Url.ToString()

        Process.Start(Label1.Text)
    End Sub

    Private Sub ClosethisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClosethisToolStripMenuItem.Click
        main.Show()
        Me.Close()
    End Sub

    Private Sub BackstepToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackstepToolStripMenuItem.Click
        WebBrowser1.GoBack()
    End Sub
End Class