Imports MySql.Data.MySqlClient
Public Class Course_Form

    Private Sub loadStudentsButton_Click(sender As Object, e As EventArgs) Handles loadCoursesButton.Click
        Me.DataGridView2.Rows.Clear()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles backButton.Click
        mainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles addCourseButton.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub
End Class