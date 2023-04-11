<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CSVUploadForm1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.UploadButton = New System.Windows.Forms.Button()
        Me.DataGridViewCSV = New System.Windows.Forms.DataGridView()
        Me.backButton = New System.Windows.Forms.Button()
        CType(Me.DataGridViewCSV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UploadButton
        '
        Me.UploadButton.BackColor = System.Drawing.Color.LimeGreen
        Me.UploadButton.Location = New System.Drawing.Point(12, 472)
        Me.UploadButton.Name = "UploadButton"
        Me.UploadButton.Size = New System.Drawing.Size(163, 57)
        Me.UploadButton.TabIndex = 0
        Me.UploadButton.Text = "Upload CSV"
        Me.UploadButton.UseVisualStyleBackColor = False
        '
        'DataGridViewCSV
        '
        Me.DataGridViewCSV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridViewCSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCSV.Location = New System.Drawing.Point(12, 12)
        Me.DataGridViewCSV.Name = "DataGridViewCSV"
        Me.DataGridViewCSV.RowHeadersWidth = 51
        Me.DataGridViewCSV.RowTemplate.Height = 24
        Me.DataGridViewCSV.Size = New System.Drawing.Size(1257, 454)
        Me.DataGridViewCSV.TabIndex = 1
        '
        'backButton
        '
        Me.backButton.BackColor = System.Drawing.Color.Gray
        Me.backButton.Location = New System.Drawing.Point(1103, 472)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(166, 57)
        Me.backButton.TabIndex = 29
        Me.backButton.Text = "Back"
        Me.backButton.UseVisualStyleBackColor = False
        '
        'CSVUploadForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1281, 541)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.DataGridViewCSV)
        Me.Controls.Add(Me.UploadButton)
        Me.Name = "CSVUploadForm1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CSVUploadForm1"
        CType(Me.DataGridViewCSV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UploadButton As Button
    Friend WithEvents DataGridViewCSV As DataGridView
    Friend WithEvents backButton As Button
End Class
