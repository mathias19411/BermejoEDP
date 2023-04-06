Imports MySql.Data.MySqlClient
Public Class UpdateOrganizationForm
    Private Sub UpdateOrganizationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub updateOrganizationButton_Click(sender As Object, e As EventArgs) Handles updateOrganizationButton.Click
        Dim strsql As String = "update organizations set organization_name = '" & Me.OrganizationNameTextBox.Text & "' where org_ID = " & Me.OrganizationIDTextBox.Text & " "
        MsgBox("Are you sure you want to UPDATE the organization with ID = " & Me.OrganizationIDTextBox.Text & "?")
        Connect_to_DB()
        Dim mycmmd As New MySqlCommand
        Try
            mycmmd.Connection = myconn
            mycmmd.CommandText = strsql
            mycmmd.ExecuteNonQuery()
            MsgBox("Organization Successfully Updated!", MsgBoxStyle.Information)
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