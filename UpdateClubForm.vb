Imports MySql.Data.MySqlClient
Public Class UpdateClubForm
    Private Sub UpdateClubForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub updateClubButton_Click(sender As Object, e As EventArgs) Handles updateClubButton.Click
        Dim strsql As String = "update clubs set club_name = '" & Me.ClubNameTextBox.Text & "', club_president = " & Me.ClubPresTextBox.Text & ", club_description = '" & Me.ClubDescTextBox.Text & "' where club_ID = " & Me.ClubIDTextBox.Text & " "
        MsgBox("Are you sure you want to UPDATE the club with ID = " & Me.ClubIDTextBox.Text & "?")
        Connect_to_DB()
        Dim mycmmd As New MySqlCommand
        Try
            mycmmd.Connection = myconn
            mycmmd.CommandText = strsql
            mycmmd.ExecuteNonQuery()
            MsgBox("Club Successfully Updated!", MsgBoxStyle.Information)
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
            .ClubNameTextBox.Text = ""
            .ClubPresTextBox.Text = ""
            .ClubDescTextBox.Text = ""
        End With
    End Sub
End Class