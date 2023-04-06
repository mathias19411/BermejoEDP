Imports MySql.Data.MySqlClient
Public Class Club_Form
    Private Sub ClubForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub loadClubsButton_Click(sender As Object, e As EventArgs) Handles loadClubsButton.Click
        Me.DataGridView3.Rows.Clear()
        Me.DataGridView3.Columns.Clear()
        DataGridView3.Columns.Add("Column1", "Club ID")
        DataGridView3.Columns.Add("Column2", "Club Name")
        DataGridView3.Columns.Add("Column3", "Club President")
        DataGridView3.Columns.Add("Column4", "Club Description")
        Dim strSQL As String
        Dim command As New MySqlCommand
        strSQL = "Select * from clubs"
        Connect_to_DB()
        With command
            .Connection = myconn
            .CommandType = CommandType.Text
            .CommandText = strSQL
        End With
        Dim myReader As MySqlDataReader
        myReader = command.ExecuteReader
        While myReader.Read()
            Me.DataGridView3.Rows.Add(New Object() {myReader.Item("club_ID"), myReader.Item("club_name"), myReader.Item("club_president"), myReader.Item("club_description")})
        End While
        myReader.Close()
        myReader.Dispose()
        Disconnect_to_DB()
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        mainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub addClubButton_Click(sender As Object, e As EventArgs) Handles addClubButton.Click
        AddClubForm.Show()
    End Sub
    Private Sub updateClubButton_Click(sender As Object, e As EventArgs) Handles updateClubButton.Click
        UpdateClubForm.Show()
    End Sub

    Private Sub deleteClubButton_Click(sender As Object, e As EventArgs) Handles deleteClubButton.Click
        DeleteClubForm.Show()
    End Sub
End Class