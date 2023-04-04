Imports MySql.Data.MySqlClient
Public Class AddClubForm
    Private Sub AddClubForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
Private Sub addClubButton_Click(sender As Object, e As EventArgs) Handles addClubButton.Click
    Dim strsql As String = "insert into clubs values('" & Me.ClubIDTextBox.Text & "','" & Me.ClubNameTextBox.Text & "')"
    Connect_to_DB()
    Dim mycmmd As New MySqlCommand
    Try
        mycmmd.Connection = myconn
        mycmmd.CommandText = strsql
        mycmmd.ExecuteNonQuery()
        MsgBox("Club Successfully Added!", MsgBoxStyle.Information)
        Call Clear_Boxes()
        Me.Hide()
        Course_Form.Show()
    Catch ex As Exception
        MsgBox(ex.Message, MsgBoxStyle.Critical)
    End Try
    Disconnect_to_DB()
End Sub
Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
    Course_Form.Show()
    Me.Hide()
End Sub
Private Sub Clear_Boxes()
    With Me
        .CourseIDTextBox.Text = ""
        .CourseNameTextBox.Text = ""
    End With
End Sub