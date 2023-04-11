Imports System.IO
Imports Microsoft.VisualBasic.FileIO

Public Class CSVUploadForm1
    Private Sub CSVUploadForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub UploadButton_Click(sender As Object, e As EventArgs) Handles UploadButton.Click
        ' Opens a file dialog to select CSV file
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "CSV files (*.csv)|*.csv"
        openFileDialog.Multiselect = False
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' Loading the CSV file into data grid view
            LoadCSV(openFileDialog.FileName, DataGridViewCSV)
        End If
    End Sub
    Private Sub LoadCSV(ByVal filePath As String, ByVal dataGridView As DataGridView)
        dataGridView.DataSource = Nothing
        dataGridView.Rows.Clear()
        dataGridView.Columns.Clear()

        Try
            ' Reading the CSV file
            Using parser As New TextFieldParser(filePath)
                parser.TextFieldType = FieldType.Delimited
                parser.SetDelimiters(",")
                ' Reading the header rows to create data grid columns
                Dim headers As String() = parser.ReadFields()
                For Each header In headers
                    dataGridView.Columns.Add(header, header)
                Next
                ' Read data rows to populate data grid rows
                While Not parser.EndOfData
                    Dim fields As String() = parser.ReadFields()
                    dataGridView.Rows.Add(fields)
                End While
            End Using
            MessageBox.Show("CSV uploaded successfully!")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        mainMenu.Show()
        Me.Hide()
    End Sub
End Class