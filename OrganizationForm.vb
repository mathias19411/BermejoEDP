Imports MySql.Data.MySqlClient
Imports System.Data.Common
Imports Excel = Microsoft.Office.Interop.Excel
Public Class Organization_Form
    Private Sub OrganizationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub loadOrganizationsButton_Click(sender As Object, e As EventArgs) Handles loadOrganizationsButton.Click
        Me.DataGridView4.Rows.Clear()
        Me.DataGridView4.Columns.Clear()
        DataGridView4.Columns.Add("Column1", "Organization ID")
        DataGridView4.Columns.Add("Column2", "Organization Name")

        Dim strSQL As String
        Dim command As New MySqlCommand
        strSQL = "Select * from organizations"
        Connect_to_DB()
        With command
            .Connection = myconn
            .CommandType = CommandType.Text
            .CommandText = strSQL
        End With
        Dim myReader As MySqlDataReader
        myReader = command.ExecuteReader
        While myReader.Read()
            Me.DataGridView4.Rows.Add(New Object() {myReader.Item("org_ID"), myReader.Item("organization_name")})
        End While
        myReader.Close()
        myReader.Dispose()
        Disconnect_to_DB()
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        mainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub addOrganizationButton_Click(sender As Object, e As EventArgs) Handles addOrganizationButton.Click
        AddOrganizationForm.Show()
    End Sub

    Private Sub updateOrganizationButton_Click(sender As Object, e As EventArgs) Handles updateOrganizationButton.Click
        UpdateOrganizationForm.Show()
    End Sub

    Private Sub deleteOrganizationButton_Click(sender As Object, e As EventArgs) Handles deleteOrganizationButton.Click
        DeleteOrganizationForm.Show()
    End Sub

    Private Sub ExportExcelButton3_Click(sender As Object, e As EventArgs) Handles ExportExcelButton3.Click
        Dim saveFileDialog As New SaveFileDialog()

        saveFileDialog.DefaultExt = ".xlsx"
        saveFileDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx"

        Dim result As DialogResult = saveFileDialog.ShowDialog()

        If result = DialogResult.OK Then
            ' Retrieve the selected file path
            Dim filePath As String = saveFileDialog.FileName
            'Call importToExcel(Me.DataGridView2, "Course Report.xlsx")
            Call ExportToExcel(Me.DataGridView4, filePath)
        End If
    End Sub
End Class