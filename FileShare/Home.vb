Imports System.Net.Sockets
Imports MySql.Data.MySqlClient
Imports System.Net
Imports System.IO
Imports System.Threading


Public Class Home
    Dim connectionString As String = "Server=localhost;Database=fileshare;User Id=root;Password=;"
    Dim connection As New MySqlConnection(connectionString)

    Private listener As TcpListener = Nothing
    Private listenerThread As Thread = Nothing
    Private isListening As Boolean = True
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Start the TCP listener on a separate thread
        Dim listenerThread As New Thread(AddressOf StartListener)
        listenerThread.Start()
    End Sub

    Private Sub StartListener()
        Dim listener As TcpListener = Nothing
        Try
            ' Initialize the TCP listener on port 12345 (you can change the port number if needed)
            listener = New TcpListener(IPAddress.Any, 12421)
            listener.Start()

            ' Continuously listen for incoming connections
            While True
                ' Accept incoming connections asynchronously
                Dim clientTask As Task(Of TcpClient) = listener.AcceptTcpClientAsync()
                clientTask.Wait()

                ' Handle the accepted client in a separate thread
                Dim clientThread As New Thread(AddressOf HandleClient)
                clientThread.Start(clientTask.Result)
            End While
        Catch ex As Exception
            ' Handle errors
            MessageBox.Show("Error starting listener: " & ex.Message)
        Finally
            ' Stop the listener when finished
            If listener IsNot Nothing Then
                listener.Stop()
            End If
        End Try
    End Sub

    Private Sub HandleClient(ByVal client As TcpClient)
        Try
            ' Get the network stream of the client
            Using networkStream As NetworkStream = client.GetStream()
                ' Receive the file name from the client
                Dim fileNameBytes(4096) As Byte
                Dim fileNameLength As Integer = networkStream.Read(fileNameBytes, 0, fileNameBytes.Length)
                Dim fileName As String = System.Text.Encoding.ASCII.GetString(fileNameBytes, 0, fileNameLength)

                ' Create a file stream to save the received file
                Dim filePath As String = Path.Combine("D:\ReceivedFiles", fileName)
                Using fileStream As FileStream = File.Create(filePath)
                    ' Receive and write the file content to the file stream
                    Dim buffer(4096) As Byte
                    Dim bytesRead As Integer
                    Do
                        bytesRead = networkStream.Read(buffer, 0, buffer.Length)
                        If bytesRead > 0 Then
                            fileStream.Write(buffer, 0, bytesRead)
                        End If
                    Loop While bytesRead > 0
                End Using

                ' Send acknowledgment back to the sender
                Dim acknowledgment As Byte() = System.Text.Encoding.ASCII.GetBytes("File received successfully.")
                networkStream.Write(acknowledgment, 0, acknowledgment.Length)
            End Using
        Catch ex As Exception
            ' Handle errors
            MessageBox.Show("Error handling client: " & ex.Message)
        Finally
            ' Close the client connection
            client.Close()
        End Try
    End Sub

    Private Sub Browsebtn_Click(sender As Object, e As EventArgs) Handles Browsebtn.Click
        If OpenFileDialog.ShowDialog() = DialogResult.OK Then
            BrowsePath.Text = OpenFileDialog.FileName
        End If

    End Sub


    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        LoginForm.Show()

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Try
            ' Assuming userID is the unique identifier for the user
            Dim userID As String = DatabaseModule.GetLoggedInUserID()

            If userID <> Nothing Then ' Assuming -1 indicates an error in fetching the userID
                ' Update islogged to 0 for the logged-in user
                Dim updateQuery As String = "UPDATE didtable SET islogged = 0 WHERE userID = @userID;"

                Using connection As New MySqlConnection(connectionString)
                    connection.Open()

                    Using command As New MySqlCommand(updateQuery, connection)
                        command.Parameters.AddWithValue("@userID", userID)
                        command.ExecuteNonQuery()
                    End Using
                End Using

                ' Perform any other logout operations here

                MsgBox("Logout successful.")
            Else
                MsgBox("Error fetching user information.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error during logout: " & ex.Message)
        End Try
    End Sub

    Public Function GetLoggedInUserID() As Integer


        Return -1 ' Replace this with the actual userID or handle the retrieval logic
    End Function



    Private Sub Home_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing, ExitToolStripMenuItem.Click
        ' Stop the TCP server listener when the form is closing
        isListening = False
        If listener IsNot Nothing Then
            listener.Stop()
        End If
        Me.Close()
    End Sub

    Private Sub SendFile(ByVal filePath As String, ByVal receiverIP As String)
        Try
            ' Create a TCP/IP socket
            Using client As New TcpClient(receiverIP, 12421) ' Assuming port 12421 for file transfer

                ' Open the file to send
                Using fileStream As FileStream = File.OpenRead(filePath)

                    ' Get the network stream
                    Dim networkStream As NetworkStream = client.GetStream()

                    ' Send the file name
                    Dim fileName As Byte() = System.Text.Encoding.ASCII.GetBytes(Path.GetFileName(filePath))
                    networkStream.Write(fileName, 0, fileName.Length)

                    ' Send the file content
                    Dim buffer(4096) As Byte
                    Dim bytesRead As Integer
                    Do
                        bytesRead = fileStream.Read(buffer, 0, buffer.Length)
                        If bytesRead > 0 Then
                            networkStream.Write(buffer, 0, bytesRead)
                        End If
                    Loop While bytesRead > 0

                    ' Close the file and network stream
                    fileStream.Close()
                    networkStream.Close()

                    ' Display success message
                    MsgBox("File sent successfully.")
                End Using
            End Using
        Catch ex As Exception
            ' Handle errors
            MsgBox("Error sending file: " & ex.Message)
        End Try
    End Sub

    Private Sub ShareBtn_Click(sender As Object, e As EventArgs) Handles ShareBtn.Click
        Dim filePath As String = BrowsePath.Text
        Dim receiverIP As String = Iptext.Text

        ' Call the send function
        SendFile(filePath, receiverIP)

    End Sub



    Private Sub Newbtn_Click(sender As Object, e As EventArgs) Handles Newbtn.Click
        NewDevice.Show()

    End Sub
End Class
