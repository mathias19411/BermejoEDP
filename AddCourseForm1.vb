﻿Imports MySql.Data.MySqlClient
Public Class AddCourseForm1
    Private Sub AddCourseForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub addCourseButton_Click(sender As Object, e As EventArgs) Handles addCourseButton.Click
        Dim strsql As String = "insert into courses values('" & Me.CourseIDTextBox.Text & "','" & Me.CourseNameTextBox.Text & "')"
        MsgBox("Are you sure to ADD this new course to the records?")
        Connect_to_DB()
        Dim mycmmd As New MySqlCommand
        Try
            mycmmd.Connection = myconn
            mycmmd.CommandText = strsql
            mycmmd.ExecuteNonQuery()
            MsgBox("Course Successfully Added!", MsgBoxStyle.Information)
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
            .CourseNameTextBox.Text = ""
        End With
    End Sub
End Class