Public Class rojavongo

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.Image = PictureBox2.Image
        Label2.Text = "রোজা ভঙ্গের কারণ সমুহ"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PictureBox1.Image = PictureBox3.Image
        Label2.Text = "রোজা মাকরুহের  কারণ সমুহ"
    End Sub

    Private Sub rojavongo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = "রোজা ভঙ্গের কারণ সমুহ"
    End Sub
End Class