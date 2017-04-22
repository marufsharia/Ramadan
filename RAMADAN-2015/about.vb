Public Class about

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub about_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label1.BackColor = Color.FromArgb(34, 34, 34)

    End Sub

    Private Sub about_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub about_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
        Label2.Text = "পবিত্র মাহে রমজান"
        PictureBox4.BorderStyle = BorderStyle.FixedSingle
        PictureBox7.BorderStyle = BorderStyle.FixedSingle
        PictureBox8.BorderStyle = BorderStyle.FixedSingle
        PictureBox9.BorderStyle = BorderStyle.FixedSingle
        PictureBox10.BorderStyle = BorderStyle.FixedSingle
        PictureBox11.BorderStyle = BorderStyle.FixedSingle

    End Sub

    Private Sub about_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
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

        main.Show()
        Me.Close()

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

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        If My.Computer.Network.IsAvailable Then
            contactus.Show()
        Else

            MessageBox.Show("দুঃখিত!!! আপনার ইন্টারনেট সংযোগ না থাকায় আপনি এই ফিচারটি ব্যবহার করতে পারছেন না।",
        "ইন্টারনেট সংযোগ বার্তা",
        MessageBoxButtons.OK,
        MessageBoxIcon.Exclamation,
        MessageBoxDefaultButton.Button1)

        End If

    End Sub
    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        If My.Computer.Network.IsAvailable Then
            Web_update.Show()
        Else

            MessageBox.Show("দুঃখিত!!! আপনার ইন্টারনেট সংযোগ না থাকায় আপনি এই ফিচারটি ব্যবহার করতে পারছেন না।",
        "ইন্টারনেট সংযোগ বার্তা",
        MessageBoxButtons.OK,
        MessageBoxIcon.Exclamation,
        MessageBoxDefaultButton.Button1)

        End If

    End Sub
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        AboutBox1.Show()

    End Sub
    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Process.Start("https://www.facebook.com/mstecsoft")
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Process.Start("http://marufsharia.com/mstecsoftapp/Ramadan-2015/")
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Process.Start("http://marufsharia.com/software/")
    End Sub

    Private Sub PictureBox4_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox4.MouseDown
        PictureBox4.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub PictureBox4_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox4.MouseMove
        Label2.Text = "সফটওয়্যার সম্পর্কে"
    End Sub

    Private Sub PictureBox7_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox7.MouseDown
        PictureBox7.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub PictureBox7_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox7.MouseMove
        Label2.Text = "সফটওয়্যার আপডেট চেক "
    End Sub

    Private Sub PictureBox8_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox8.MouseDown
        PictureBox8.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub PictureBox8_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox8.MouseMove
        Label2.Text = "আমাদের সাথে যোগাযোগ করুন"
    End Sub

    Private Sub PictureBox9_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox9.MouseDown
        PictureBox9.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub PictureBox9_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox9.MouseMove
        Label2.Text = "ফেসবুক পেজে ভিজিট করুন"
    End Sub

    Private Sub PictureBox10_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox10.MouseDown
        PictureBox10.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub PictureBox10_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox10.MouseMove
        Label2.Text = "আমাদের ওয়েবসাইটে ভিজিট করুন"
    End Sub

    Private Sub PictureBox11_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox11.MouseDown
        PictureBox11.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub PictureBox11_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox11.MouseMove
        Label2.Text = "নতুন প্রোডাক্ট সম্পর্কে জানতে "
    End Sub
End Class