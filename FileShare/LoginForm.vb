Imports System.Net
Imports System.Net.NetworkInformation
Imports System.Net.Sockets
Imports MySql.Data.MySqlClient

Public Class LoginForm

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.
    Dim connectionString As String = "Server=localhost;Database=fileshare;User Id=root;Password=;"
    Dim connection As New MySqlConnection(connectionString)
    Friend isloggedindevice As New Boolean

    Public Sub ConnectToMySQL()
        Try

            ' Open the connection
            Connection.Open()
            'MsgBox("s1")
            ' Perform SELECT query with a parameter
            Dim query As String = "SELECT * FROM DIDTable WHERE DID = @did;"
            Dim command As New MySqlCommand(query, Connection)

            ' Add parameter (replace with the actual value for DID)
            command.Parameters.AddWithValue("@did", DIDTextBox.Text)

            Dim reader As MySqlDataReader = command.ExecuteReader()
            'MsgBox("s2")

            ' Process the result set (for demonstration, just displaying in a MsgBox)
            If reader.Read() Then
                Console.Write("Record found...")
                isloggedindevice = True

            Else
                Console.Write("Record not found...")
                isloggedindevice = False
            End If
            'MsgBox("s3")


            ' Close the reader
            reader.Close()
        Catch ex As MySqlException
            ' Handle MySQL-specific exceptions here
            MessageBox.Show("MySQL Error: " & ex.Message)
        Catch ex As Exception
            ' Handle general exceptions here
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Close the connection when done
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        ConnectToMySQL()
        If isloggedindevice Then
            Home.LoginToolStripMenuItem.Enabled = False
            Home.LogoutToolStripMenuItem.Enabled = True

        End If
        Me.Hide()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub IPFetchCBox_CheckedChanged(sender As Object, e As EventArgs) Handles IPFetchCBox.CheckedChanged
        If IPFetchCBox.Checked Then
            ' Checkbox is checked, fetch the IP address
            Dim ipAddress As String = GetLocalIPAddress()

            ' Display or use the IP address as needed (for demonstration, showing in a MessageBox)
            If Not String.IsNullOrEmpty(ipAddress) Then
                IPTextBox.Text = ipAddress
            Else
                MsgBox("Error fetching IP address...")
            End If
        End If
    End Sub

    Private Function GetLocalIPAddress() As String
        Try
            ' Get all network interfaces
            Dim networkInterfaces() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces()

            ' Find the first operational and non-loopback IPv4 address
            For Each networkInterface As NetworkInterface In networkInterfaces
                If networkInterface.OperationalStatus = OperationalStatus.Up AndAlso
                   networkInterface.NetworkInterfaceType <> NetworkInterfaceType.Loopback Then

                    Dim properties As IPInterfaceProperties = networkInterface.GetIPProperties()
                    Dim unicastAddresses As UnicastIPAddressInformationCollection = properties.UnicastAddresses

                    For Each address As UnicastIPAddressInformation In unicastAddresses
                        If address.Address.AddressFamily = AddressFamily.InterNetwork Then
                            Return address.Address.ToString()
                        End If
                    Next
                End If
            Next

        Catch ex As Exception
            MessageBox.Show("Error fetching IP address: " & ex.Message)
        End Try

        Return ""
    End Function




End Class
