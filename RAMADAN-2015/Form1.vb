Public Class main


    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        
        Dim Fade As Double
        For Fade = 1.1 To 0.0 Step -0.1
            Me.Opacity = Fade
            Me.Refresh()
            Threading.Thread.Sleep(100)
        Next
    End Sub


    


    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub main_MouseHover(sender As Object, e As EventArgs) Handles Me.MouseHover
        Label2.Text = "RAMADAN-2015"
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If

        Label2.Text = "RAMADAN-2015"
       
        PictureBox9.BorderStyle = BorderStyle.FixedSingle
        PictureBox10.BorderStyle = BorderStyle.FixedSingle
        PictureBox11.BorderStyle = BorderStyle.FixedSingle
        PictureBox12.BorderStyle = BorderStyle.FixedSingle

    End Sub






    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub


    Private Sub PictureBox2_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub PictureBox2_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub PictureBox2_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseUp
        drag = False
    End Sub



    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click



        Dim Fade As Double
        For Fade = 1.1 To 0.0 Step -0.3
            Me.Opacity = Fade
            Me.Refresh()
            Threading.Thread.Sleep(100)
        Next


        End
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub



    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        drag = False
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        ramjan.Show()
        Me.Hide()


    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        If My.Computer.Network.IsAvailable Then
            Form2.Show()
        Else

            MessageBox.Show("দুঃখিত!!! আপনার ইন্টারনেট সংযোগ না থাকায় আপনি এই ফিচারটি ব্যবহার করতে পারছেন না।", _
        "ইন্টারনেট সংযোগ বার্তা", _
        MessageBoxButtons.OK, _
        MessageBoxIcon.Exclamation, _
        MessageBoxDefaultButton.Button1)

        End If

    End Sub

  

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        online.Show()
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        Me.Hide()
        about.Show()

    End Sub

    Private Sub PictureBox12_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox12.MouseDown
        PictureBox12.BorderStyle = BorderStyle.Fixed3D
    End Sub


    Private Sub PictureBox12_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox12.MouseMove
        Label2.Text = "সফটওয়্যার ও আমাদের সম্পর্কে "
        ' PictureBox12.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub PictureBox11_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox11.MouseDown
        PictureBox11.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub PictureBox11_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox11.MouseMove
        Label2.Text = "ইসলামিক বিষয়ে প্রশ্ন ও তার উত্তর"
        ' PictureBox11.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub PictureBox10_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox10.MouseDown
        PictureBox10.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub PictureBox10_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox10.MouseMove
        Label2.Text = "পবিত্র কোরআন তেলোয়াত"
        'PictureBox10.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub PictureBox9_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox9.MouseDown
        PictureBox9.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub PictureBox9_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox9.MouseMove
        Label2.Text = "পবিত্র মাহে রমজান"
        'PictureBox9.BorderStyle = BorderStyle.FixedSingle
    End Sub

    
    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.BackColor = Color.FromArgb(34, 34, 34)
        Dim fade As Double
        For fade = 0.0 To 1.1 Step 0.1
            Me.Opacity = fade
            Me.Refresh()
            Threading.Thread.Sleep(100)
        Next
        Me.BackgroundImage = bgpic.Image
        Me.BackgroundImageLayout = ImageLayout.Stretch
    End Sub
End Class
