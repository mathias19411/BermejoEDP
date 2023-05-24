Imports MySql.Data.MySqlClient
Imports System.IO
Public Class mainMenu

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Student_Form.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Course_Form.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Club_Form.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Organization_Form.Show()
        Me.Hide()
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Hide()
        LoginForm1.Show()
    End Sub

    Private Sub mainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub UploadButton_Click(sender As Object, e As EventArgs) Handles UploadButton.Click
        CSVUploadForm1.Show()
        Me.Hide()
    End Sub

    Private Sub BackupButton_Click(sender As Object, e As EventArgs) Handles BackupButton.Click
        Backup_DB()
    End Sub
End Class