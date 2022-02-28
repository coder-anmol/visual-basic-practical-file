Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CountLabel.Text = "0"
    End Sub

    Private Sub IncrementButton_Click(sender As Object, e As EventArgs) Handles IncrementButton.Click
        CountLabel.Text = CStr(CInt(CountLabel.Text) + 1)
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        CountLabel.Text = CStr(0)
    End Sub

    Private Sub DecrementButton_Click(sender As Object, e As EventArgs) Handles DecrementButton.Click
        CountLabel.Text = CStr(CInt(CountLabel.Text) - 1)
    End Sub
End Class
