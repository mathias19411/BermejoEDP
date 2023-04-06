Imports MySql.Data.MySqlClient
Public Class UpdateCourseForm
    Private Sub UpdateCourseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub updateCourseButton_Click(sender As Object, e As EventArgs) Handles updateCourseButton.Click
        Dim strsql As String = "update courses set course_name = '" & Me.CourseNameTextBox.Text & "' where course_ID = " & Me.CourseIDTextBox.Text & " "
        MsgBox("Are you sure you want to UPDATE the course with ID = " & Me.CourseIDTextBox.Text & "?")
        Connect_to_DB()
        Dim mycmmd As New MySqlCommand
        Try
            mycmmd.Connection = myconn
            mycmmd.CommandText = strsql
            mycmmd.ExecuteNonQuery()
            MsgBox("Course Successfully Updated!", MsgBoxStyle.Information)
            Call Clear_Boxes()
            Me.Hide()
            Course_Form.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Disconnect_to_DB()
    End Sub
    Private Sub Clear_Boxes()
        With Me
            .CourseIDTextBox.Text = ""
            .CourseNameTextBox.Text = ""
        End With
    End Sub
    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Call Clear_Boxes()
        Me.Hide()
        Course_Form.Show()
    End Sub
End Class