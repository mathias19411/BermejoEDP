<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Student_Form))
        Me.Add_Stud_Button = New System.Windows.Forms.Button()
        Me.backButton = New System.Windows.Forms.Button()
        Me.loadStudentsButton = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Update_Stud_Button = New System.Windows.Forms.Button()
        Me.Delete_Stud_Button = New System.Windows.Forms.Button()
        Me.ExportExcelButton2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Add_Stud_Button
        '
        Me.Add_Stud_Button.BackColor = System.Drawing.Color.LimeGreen
        Me.Add_Stud_Button.Location = New System.Drawing.Point(12, 472)
        Me.Add_Stud_Button.Name = "Add_Stud_Button"
        Me.Add_Stud_Button.Size = New System.Drawing.Size(163, 57)
        Me.Add_Stud_Button.TabIndex = 21
        Me.Add_Stud_Button.Text = "Add Student"
        Me.Add_Stud_Button.UseVisualStyleBackColor = False
        '
        'backButton
        '
        Me.backButton.BackColor = System.Drawing.Color.Gray
        Me.backButton.Location = New System.Drawing.Point(1103, 472)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(166, 57)
        Me.backButton.TabIndex = 20
        Me.backButton.Text = "Back"
        Me.backButton.UseVisualStyleBackColor = False
        '
        'loadStudentsButton
        '
        Me.loadStudentsButton.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.loadStudentsButton.Location = New System.Drawing.Point(12, 12)
        Me.loadStudentsButton.Name = "loadStudentsButton"
        Me.loadStudentsButton.Size = New System.Drawing.Size(1257, 42)
        Me.loadStudentsButton.TabIndex = 22
        Me.loadStudentsButton.Text = "Load Students"
        Me.loadStudentsButton.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 61)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1257, 397)
        Me.DataGridView1.TabIndex = 23
        '
        'Update_Stud_Button
        '
        Me.Update_Stud_Button.BackColor = System.Drawing.SystemColors.Highlight
        Me.Update_Stud_Button.Location = New System.Drawing.Point(181, 472)
        Me.Update_Stud_Button.Name = "Update_Stud_Button"
        Me.Update_Stud_Button.Size = New System.Drawing.Size(163, 57)
        Me.Update_Stud_Button.TabIndex = 24
        Me.Update_Stud_Button.Text = "Update Student"
        Me.Update_Stud_Button.UseVisualStyleBackColor = False
        '
        'Delete_Stud_Button
        '
        Me.Delete_Stud_Button.BackColor = System.Drawing.Color.Crimson
        Me.Delete_Stud_Button.Location = New System.Drawing.Point(350, 472)
        Me.Delete_Stud_Button.Name = "Delete_Stud_Button"
        Me.Delete_Stud_Button.Size = New System.Drawing.Size(163, 57)
        Me.Delete_Stud_Button.TabIndex = 25
        Me.Delete_Stud_Button.Text = "Delete Student"
        Me.Delete_Stud_Button.UseVisualStyleBackColor = False
        '
        'ExportExcelButton2
        '
        Me.ExportExcelButton2.BackColor = System.Drawing.Color.LightCoral
        Me.ExportExcelButton2.Location = New System.Drawing.Point(931, 472)
        Me.ExportExcelButton2.Name = "ExportExcelButton2"
        Me.ExportExcelButton2.Size = New System.Drawing.Size(166, 57)
        Me.ExportExcelButton2.TabIndex = 35
        Me.ExportExcelButton2.Text = "Export Data to Excel"
        Me.ExportExcelButton2.UseVisualStyleBackColor = False
        '
        'Student_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1281, 541)
        Me.Controls.Add(Me.ExportExcelButton2)
        Me.Controls.Add(Me.Delete_Stud_Button)
        Me.Controls.Add(Me.Update_Stud_Button)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.Add_Stud_Button)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.loadStudentsButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Student_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Form"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Add_Stud_Button As Button
    Friend WithEvents backButton As Button
    Friend WithEvents loadStudentsButton As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Update_Stud_Button As Button
    Friend WithEvents Delete_Stud_Button As Button
    Friend WithEvents ExportExcelButton2 As Button
End Class
