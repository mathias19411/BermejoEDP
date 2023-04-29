<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Course_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.loadCoursesButton = New System.Windows.Forms.Button()
        Me.Delete_Course_Button = New System.Windows.Forms.Button()
        Me.Update_Course_Button = New System.Windows.Forms.Button()
        Me.backButton = New System.Windows.Forms.Button()
        Me.Add_Course_Button = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ExportExcelButton = New System.Windows.Forms.Button()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView2
        '
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(12, 60)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(1257, 397)
        Me.DataGridView2.TabIndex = 26
        '
        'loadCoursesButton
        '
        Me.loadCoursesButton.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.loadCoursesButton.Location = New System.Drawing.Point(12, 12)
        Me.loadCoursesButton.Name = "loadCoursesButton"
        Me.loadCoursesButton.Size = New System.Drawing.Size(1257, 42)
        Me.loadCoursesButton.TabIndex = 27
        Me.loadCoursesButton.Text = "Load Courses"
        Me.loadCoursesButton.UseVisualStyleBackColor = False
        '
        'Delete_Course_Button
        '
        Me.Delete_Course_Button.BackColor = System.Drawing.Color.Crimson
        Me.Delete_Course_Button.Location = New System.Drawing.Point(350, 472)
        Me.Delete_Course_Button.Name = "Delete_Course_Button"
        Me.Delete_Course_Button.Size = New System.Drawing.Size(163, 57)
        Me.Delete_Course_Button.TabIndex = 31
        Me.Delete_Course_Button.Text = "Delete Course"
        Me.Delete_Course_Button.UseVisualStyleBackColor = False
        '
        'Update_Course_Button
        '
        Me.Update_Course_Button.BackColor = System.Drawing.SystemColors.Highlight
        Me.Update_Course_Button.Location = New System.Drawing.Point(181, 472)
        Me.Update_Course_Button.Name = "Update_Course_Button"
        Me.Update_Course_Button.Size = New System.Drawing.Size(163, 57)
        Me.Update_Course_Button.TabIndex = 30
        Me.Update_Course_Button.Text = "Update Course"
        Me.Update_Course_Button.UseVisualStyleBackColor = False
        '
        'backButton
        '
        Me.backButton.BackColor = System.Drawing.Color.Gray
        Me.backButton.Location = New System.Drawing.Point(1103, 472)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(166, 57)
        Me.backButton.TabIndex = 28
        Me.backButton.Text = "Back"
        Me.backButton.UseVisualStyleBackColor = False
        '
        'Add_Course_Button
        '
        Me.Add_Course_Button.BackColor = System.Drawing.Color.LimeGreen
        Me.Add_Course_Button.Location = New System.Drawing.Point(12, 472)
        Me.Add_Course_Button.Name = "Add_Course_Button"
        Me.Add_Course_Button.Size = New System.Drawing.Size(163, 57)
        Me.Add_Course_Button.TabIndex = 29
        Me.Add_Course_Button.Text = "Add Course"
        Me.Add_Course_Button.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(931, 472)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(0, 0)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ExportExcelButton
        '
        Me.ExportExcelButton.BackColor = System.Drawing.Color.LightCoral
        Me.ExportExcelButton.Location = New System.Drawing.Point(931, 472)
        Me.ExportExcelButton.Name = "ExportExcelButton"
        Me.ExportExcelButton.Size = New System.Drawing.Size(166, 57)
        Me.ExportExcelButton.TabIndex = 33
        Me.ExportExcelButton.Text = "Export Data to Excel"
        Me.ExportExcelButton.UseVisualStyleBackColor = False
        '
        'Course_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1281, 541)
        Me.Controls.Add(Me.ExportExcelButton)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Delete_Course_Button)
        Me.Controls.Add(Me.Update_Course_Button)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.Add_Course_Button)
        Me.Controls.Add(Me.loadCoursesButton)
        Me.Controls.Add(Me.DataGridView2)
        Me.Name = "Course_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Course Form"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents loadCoursesButton As Button
    Friend WithEvents Delete_Course_Button As Button
    Friend WithEvents Update_Course_Button As Button
    Friend WithEvents backButton As Button
    Friend WithEvents Add_Course_Button As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ExportExcelButton As Button
End Class
