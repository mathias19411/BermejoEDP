Imports MySql.Data.MySqlClient
Imports Microsoft.office.interop
Module Module1
    Public myconn As New MySql.Data.MySqlClient.MySqlConnection
    Public myConnectionString As String
    Public strSQL As String
    Public currentDate As DateTime = DateTime.Now
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

    Public Sub importToExcel(ByVal mydg As DataGridView, ByVal templatefilename As String)
        Dim xlsApp As Excel.Application
        Dim xlsWorkBook As Excel.Workbook
        Dim xlsSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim x As Integer
        Dim y As Integer

        xlsApp = New Excel.Application
        xlsWorkBook = xlsApp.Workbooks.Add(misValue)
        xlsSheet = xlsWorkBook.Sheets("sheet1")

        For x = 0 To mydg.RowCount - 2
            For y = 0 To mydg.ColumnCount - 1
                xlsSheet.Cells(x + 1, y + 1) = mydg(y, x).Value.ToString()
            Next
        Next
        xlsSheet.SaveAs("C:\Users\pio\Documents\" & templatefilename & " " & currentDate.ToString("mm-dd-yy hh-mm-ss") & ".xlsx")
        xlsWorkBook.Close()
        xlsApp.Quit()

        releaseObject(xlsApp)
        releaseObject(xlsWorkBook)
        releaseObject(xlsSheet)
        MessageBox.Show("Excel File successfully save to This PC\Documents")
    End Sub
    'Public Function convertToLetters(ByVal number As Integer) As String
    'number -= 1
    'Dim result As String = String.Empty

    'If (26 > number) Then
    'result = Chr(number + 65)
    'Else
    'mn As Integer

    'Do
    'column = number Mod 26
    'number = (number \ 26) - 1
    'result = Chr(column + 65) + result
    'Loop Until (number < 0)
    'End If

    'Return result

    'End Function

    Public Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
End Module
