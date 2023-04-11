Imports MySql.Data.MySqlClient
Module Module1
    Public myconn As New MySql.Data.MySqlClient.MySqlConnection
    Public myConnectionString As String
    Public strSQL As String

    Public Sub Connect_to_DB()
        myConnectionString = "server=127.0.0.1;" _
                    & "uid=root;" _
                    & "pwd=root;" _
                    & "database=bermejoact2"
        Try
            myconn.ConnectionString = myConnectionString
            myconn.Open()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            Select Case ex.Number
                Case 0
                    MsgBox("Cannot Connect to Server")
                Case 1045
                    MsgBox("Invalid Username or password")
            End Select

        End Try
    End Sub

    Public Sub Disconnect_to_DB()
        myconn.Close()
        myconn.Dispose()
    End Sub

    Public Sub Backup_DB()
        Dim DBBackup As New SaveFileDialog
        DBBackup.InitialDirectory = "C:\"
        DBBackup.Title = "Database Backup"
        DBBackup.CheckFileExists = False
        DBBackup.CheckPathExists = False
        DBBackup.DefaultExt = "sql"
        DBBackup.Filter = "sql files (*.sql)|*.sql|All files (*.*)|*.*"
        DBBackup.RestoreDirectory = True

        If DBBackup.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim conn As MySqlConnection = New MySqlConnection("server=127.0.0.1;" _
                    & "uid=root;" _
                    & "pwd=root;" _
                    & "database=bermejoact2")
            Dim mycmmd As MySqlCommand = New MySqlCommand
            mycmmd.Connection = conn
            conn.Open()
            Dim db_backup As MySqlBackup = New MySqlBackup(mycmmd)
            db_backup.ExportToFile(DBBackup.FileName)
            conn.Close()
            MessageBox.Show("Database Backup Successful!", "BACKUP", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf DBBackup.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            Return
        End If

    End Sub
End Module
