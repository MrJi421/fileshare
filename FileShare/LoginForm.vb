Imports System.Net
Imports System.Net.NetworkInformation
Imports System.Net.Sockets

Public Class LoginForm

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub IPFetchCBox_CheckedChanged(sender As Object, e As EventArgs) Handles IPFetchCBox.CheckedChanged
        If IPFetchCBox.Checked Then
            ' Checkbox is checked, fetch the IP address
            Dim ipAddress As String = GetLocalIPAddress()

            ' Display or use the IP address as needed (for demonstration, showing in a MessageBox)
            If ipAddress Then
                IPFetchCBox.Text = ipAddress
            Else
                MsgBox("Error fetching IP address...")
            End If
        End If
    End Sub



    Private Function GetLocalIPAddress() As String
        Try
            Dim hostName As String = System.Net.Dns.GetHostName()
            Dim ipEntry As IPHostEntry = System.Net.Dns.GetHostEntry(hostName)

            For Each ipAddress As IPAddress In ipEntry.AddressList
                ' Filter out IPv6 addresses and loopback addresses
                If ipAddress.AddressFamily = AddressFamily.InterNetwork AndAlso Not IPAddress.IsLoopback(ipAddress) Then
                    Return ipAddress.ToString()
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("Error fetching IP address: " & ex.Message)
        End Try

        Return ""
    End Function


End Class
