Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop
Public Class Course_Form

    Private Sub loadCoursesButton_Click(sender As Object, e As EventArgs) Handles loadCoursesButton.Click
        Me.DataGridView2.Rows.Clear()
        Me.DataGridView2.Columns.Clear()
        DataGridView2.Columns.Add("Column1", "Course ID")
        DataGridView2.Columns.Add("Column2", "Course Name")
        Dim strSQL As String
        Dim command As New MySqlCommand
        strSQL = "Select * from courses"
        Connect_to_DB()
        With command
            .Connection = myconn
            .CommandType = CommandType.Text
            .CommandText = strSQL
        End With
        Dim myReader As MySqlDataReader
        myReader = command.ExecuteReader
        While myReader.Read()
            Me.DataGridView2.Rows.Add(New Object() {myReader.Item("course_ID"), myReader.Item("course_name")})
        End While
        myReader.Close()
        myReader.Dispose()
        Disconnect_to_DB()
    End Sub

    Private Sub Course_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Add_Course_Button_Click(sender As Object, e As EventArgs) Handles Add_Course_Button.Click
        AddCourseForm1.Show()
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        mainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub Update_Course_Button_Click(sender As Object, e As EventArgs) Handles Update_Course_Button.Click
        UpdateCourseForm.Show()
    End Sub

    Private Sub Delete_Course_Button_Click(sender As Object, e As EventArgs) Handles Delete_Course_Button.Click
        DeleteCourseForm.Show()
    End Sub

    Private Sub ExportExcelButton_Click(sender As Object, e As EventArgs) Handles ExportExcelButton.Click
        Dim saveFileDialog As New SaveFileDialog()

        saveFileDialog.DefaultExt = ".xlsx"
        saveFileDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx"

        Dim result As DialogResult = saveFileDialog.ShowDialog()

        If result = DialogResult.OK Then
            ' Retrieve the selected file path
            Dim filePath As String = saveFileDialog.FileName
            'Call importToExcel(Me.DataGridView2, "Course Report.xlsx")
            Call ExportToExcel(Me.DataGridView2, filePath)
        End If
    End Sub
End Class