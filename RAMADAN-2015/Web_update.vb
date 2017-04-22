Imports System.IO
Imports System.Net
Imports System.Text
Class Web_update
    Dim version As String
    Public Shared Downuri As String
    Public Shared Sub Main()
        Dim URI As String
        '
        'REPLACE Program WITH YOUR APPLICATIONS NAME.
        '
        'REMEMBER TO EDIT FILEVERSION IN ASSEMBLY INFORMATION
        '
        '
        'Edit URI to your version.html-file. 
        URI = "http://marufsharia.com/mstecsoftapp/Ramadan-2015/version.txt"
        'Edit URI to your programs zip-file
        Downuri = "http://marufsharia.com/mstecsoftapp/Ramadan-2015/setup.exe"

        Dim wr As HttpWebRequest = CType(WebRequest.Create(URI.ToString), HttpWebRequest)
        Dim ws As HttpWebResponse = CType(wr.GetResponse(), HttpWebResponse)
        Dim str As Stream = ws.GetResponseStream()
        Dim inBuf(100000) As Byte
        Dim bytesToRead As Integer = CInt(inBuf.Length)
        Dim bytesRead As Integer = 0
        While bytesToRead > 0
            Dim n As Integer = str.Read(inBuf, bytesRead, bytesToRead)
            If n = 0 Then
                Exit While
            End If
            bytesRead += n
            bytesToRead -= n
        End While
        Dim fstr As New FileStream("version.txt", FileMode.OpenOrCreate, FileAccess.Write)
        fstr.Write(inBuf, 0, bytesRead)
        str.Close()
        fstr.Close()
        Dim sr As StreamReader = New System.IO.StreamReader("version.txt")
        Dim version As Integer = CInt(sr.ReadToEnd.Replace(".", "").Substring(0, 4))
        sr.Close()
        If version > CInt(Application.ProductVersion.Replace(".", "")) Then
            ' MessageBox.Show("T000000000000.", "Update", MessageBoxButtons.YesNo)
            If MsgBox("There is no new updates." + vbCrLf + "Are you sure to Update?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Update") = MsgBoxResult.Yes Then
                Process.Start(Downuri)
            Else
                Web_update.Refresh()
            End If
        Else
            MessageBox.Show("There is no new updates.", "Update", MessageBoxButtons.OK)
        End If
    End Sub 'Main

    

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Main()
    End Sub
End Class 'Web_update
