Imports MySql.Data.MySqlClient
Public Class DeleteClubForm
    Private Sub DeleteClubForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Delete_Club_Button_Click(sender As Object, e As EventArgs) Handles Delete_Club_Button.Click
        Dim strsql As String = "delete from clubs where club_ID = " & Me.ClubIDTextBox.Text & " "
        MsgBox("Are you sure you want to DELETE the club with ID = " & Me.ClubIDTextBox.Text & "?")
        Connect_to_DB()
        Dim mycmmd As New MySqlCommand
        Try
            mycmmd.Connection = myconn
            mycmmd.CommandText = strsql
            mycmmd.ExecuteNonQuery()
            MsgBox("Club Successfully Deleted!", MsgBoxStyle.Information)
            Call Clear_Boxes()
            Me.Hide()
            Club_Form.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Disconnect_to_DB()
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Call Clear_Boxes()
        Club_Form.Show()
        Me.Hide()
    End Sub
    Private Sub Clear_Boxes()
        With Me
            .ClubIDTextBox.Text = ""
        End With
    End Sub
End Class