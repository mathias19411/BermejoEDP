Imports MySql.Data.MySqlClient
Public Class DeleteCourseForm
    Private Sub DeleteCourseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Delete_Stud_Button_Click(sender As Object, e As EventArgs) Handles Delete_Stud_Button.Click
        Dim strsql As String = "delete from courses where course_ID = " & Me.CourseIDTextBox.Text & " "
        MsgBox("Are you sure you want to DELETE the student with ID = " & Me.CourseIDTextBox.Text & "?")
        Connect_to_DB()
        Dim mycmmd As New MySqlCommand
        Try
            mycmmd.Connection = myconn
            mycmmd.CommandText = strsql
            mycmmd.ExecuteNonQuery()
            MsgBox("Student Successfully Deleted!", MsgBoxStyle.Information)
            Call Clear_Boxes()
            Me.Hide()
            Course_Form.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Disconnect_to_DB()
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Call Clear_Boxes()
        Course_Form.Show()
        Me.Hide()
    End Sub
    Private Sub Clear_Boxes()
        With Me
            .CourseIDTextBox.Text = ""
        End With
    End Sub
End Class