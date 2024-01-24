Imports MySql.Data.MySqlClient

Public Class Home



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Call the function to connect to MySQL
        DatabaseModule.ConnectToMySQL()
    End Sub
    Private Sub Browsebtn_Click(sender As Object, e As EventArgs) Handles Browsebtn.Click
        If OpenFileDialog.ShowDialog() = DialogResult.OK Then
            BrowsePath.Text = OpenFileDialog.FileName
        End If

    End Sub

    Private Sub ShareBtn_Click(sender As Object, e As EventArgs) Handles ShareBtn.Click
        Dialog1.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        LoginForm.Show()

    End Sub
End Class
