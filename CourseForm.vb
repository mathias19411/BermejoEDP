﻿Imports MySql.Data.MySqlClient
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

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub Course_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Add_Course_Button_Click(sender As Object, e As EventArgs) Handles Add_Course_Button.Click
        Me.Hide()
        AddCourseForm1.Show()
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        mainMenu.Show()
        Me.Hide()
    End Sub

End Class