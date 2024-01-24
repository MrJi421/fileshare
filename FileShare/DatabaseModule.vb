Imports MySql.Data.MySqlClient

Module DatabaseModule
    Dim connectionString As String = "Server=localhost;Database=fileshare;User Id=root;Password=mysql;"

    Dim connection As New MySqlConnection
    Public Sub ConnectToMySQL()

        Try
            ' Open the connection
            connection.Open()
            MsgBox("sss")
            ' Perform SELECT query with a parameter
            Dim query As String = "SELECT * FROM DIDTable WHERE DID = @did;"
            Dim command As MySqlCommand = New MySqlCommand(query, connection)

            ' Add parameter
            'command.Parameters.AddWithValue("@did", DIDValue) ' Replace with the actual value for DID

            Dim reader As MySqlDataReader = command.ExecuteReader()

            ' Process the result set (for demonstration, just displaying in a MsgBox)
            If reader.Read() Then
                MsgBox("Record found...")
            Else
                MsgBox("Record not found...")
            End If

            ' Close the reader
            reader.Close()

        Catch ex As Exception
            ' Handle exceptions here
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Close the connection when done
            connection.Close()
        End Try
    End Sub
End Module
