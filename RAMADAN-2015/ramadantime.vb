Public Class ramadantime

    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.Image = PictureBox2.Image
        Label2.Text = "রহমতের ১০দিনের সময়সূর্চি (ঢাকা ও পাশ্ববর্তী জেলাসমূহ)"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PictureBox1.Image = PictureBox3.Image
        Label2.Text = " মাগফিরাতের ১০দিনের সময়সূর্চি (ঢাকা ও পাশ্ববর্তী জেলাসমূহ)"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PictureBox1.Image = PictureBox4.Image
        Label2.Text = " রহমতের ১০দিনের সময়সূর্চি (ঢাকা ও পাশ্ববর্তী জেলাসমূহ)"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PictureBox1.Image = PictureBox5.Image
        Label2.Text = "অন্যান্য জেলাসমূহের সময়সূর্চি "
    End Sub

    Private Sub ramadantime_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = "রহমতের ১০দিনের সময়সূর্চি (ঢাকা ও পাশ্ববর্তী জেলাসমূহ)"
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    
End Class