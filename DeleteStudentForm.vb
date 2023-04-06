Imports MySql.Data.MySqlClient
Public Class DeleteStudentForm
    Private Sub DeleteStudentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Delete_Stud_Button_Click(sender As Object, e As EventArgs) Handles Delete_Stud_Button.Click
        Dim strsql As String = "delete from students where stud_ID = " & Me.Stud_IDTextBox3.Text & " "
        MsgBox("Are you sure you want to DELETE the course with ID = " & Me.Stud_IDTextBox3.Text & "?")
        Connect_to_DB()
        Dim mycmmd As New MySqlCommand
        Try
            mycmmd.Connection = myconn
            mycmmd.CommandText = strsql
            mycmmd.ExecuteNonQuery()
            MsgBox("Student Successfully Deleted!", MsgBoxStyle.Information)
            Call Clear_Boxes()
            Me.Hide()
            Student_Form.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Disconnect_to_DB()
    End Sub
    Private Sub Clear_Boxes()
        With Me
            .Stud_IDTextBox3.Text = ""
        End With
    End Sub
    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Hide()
        Student_Form.Show()
    End Sub
End Class