Imports MySql.Data.MySqlClient

Module DatabaseModule
    ' Use localhost and the default XAMPP credentials
    Dim connectionString As String = "Server=localhost;Database=fileshare;User Id=root;Password=;"
    Dim connection As New MySqlConnection(connectionString)
    Dim userDid As String = LoginForm.DIDTextBox.Text

    Public Function GetLoggedInUserID() As String
        If userDid <> Nothing Then
            Return userDid
        End If
        Return Nothing
        ' Replace this with the actual userID or handle the retrieval logic

    End Function

End Module