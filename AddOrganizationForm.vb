Imports MySql.Data.MySqlClient
Public Class AddOrganizationForm
    Private Sub AddOrganizationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub addOrganizationButton_Click(sender As Object, e As EventArgs) Handles addOrganizationButton.Click
        Dim strsql As String = "insert into organizations values('" & Me.OrganizationIDTextBox.Text & "','" & Me.OrganizationNameTextBox.Text & "')"
        MsgBox("Are you sure to ADD this new organization to the records?")
        Connect_to_DB()
        Dim mycmmd As New MySqlCommand
        Try
            mycmmd.Connection = myconn
            mycmmd.CommandText = strsql
            mycmmd.ExecuteNonQuery()
            MsgBox("Organization Successfully Added!", MsgBoxStyle.Information)
            Call Clear_Boxes()
            Me.Hide()
            Organization_Form.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Disconnect_to_DB()
    End Sub
    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Call Clear_Boxes()
        Organization_Form.Show()
        Me.Hide()
    End Sub
    Private Sub Clear_Boxes()
        With Me
            .OrganizationIDTextBox.Text = ""
            .OrganizationNameTextBox.Text = ""
        End With
    End Sub
End Class