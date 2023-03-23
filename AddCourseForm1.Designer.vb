<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCourseForm1
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.addCourseButton = New System.Windows.Forms.Button()
        Me.backButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CourseNameTextBox = New System.Windows.Forms.TextBox()
        Me.CourseIDTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Controls.Add(Me.addCourseButton)
        Me.Panel1.Controls.Add(Me.backButton)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.CourseNameTextBox)
        Me.Panel1.Controls.Add(Me.CourseIDTextBox)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(423, 393)
        Me.Panel1.TabIndex = 25
        '
        'addCourseButton
        '
        Me.addCourseButton.BackColor = System.Drawing.Color.Lime
        Me.addCourseButton.Location = New System.Drawing.Point(9, 195)
        Me.addCourseButton.Name = "addCourseButton"
        Me.addCourseButton.Size = New System.Drawing.Size(198, 57)
        Me.addCourseButton.TabIndex = 21
        Me.addCourseButton.Text = "Add Course"
        Me.addCourseButton.UseVisualStyleBackColor = False
        '
        'backButton
        '
        Me.backButton.BackColor = System.Drawing.Color.OrangeRed
        Me.backButton.Location = New System.Drawing.Point(213, 195)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(198, 57)
        Me.backButton.TabIndex = 20
        Me.backButton.Text = "Back"
        Me.backButton.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Course Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Course ID"
        '
        'CourseNameTextBox
        '
        Me.CourseNameTextBox.Location = New System.Drawing.Point(9, 100)
        Me.CourseNameTextBox.Name = "CourseNameTextBox"
        Me.CourseNameTextBox.Size = New System.Drawing.Size(402, 22)
        Me.CourseNameTextBox.TabIndex = 2
        '
        'CourseIDTextBox
        '
        Me.CourseIDTextBox.Location = New System.Drawing.Point(9, 30)
        Me.CourseIDTextBox.Name = "CourseIDTextBox"
        Me.CourseIDTextBox.Size = New System.Drawing.Size(402, 22)
        Me.CourseIDTextBox.TabIndex = 0
        '
        'AddCourseForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 395)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "AddCourseForm1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Course Form"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents addCourseButton As Button
    Friend WithEvents backButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CourseNameTextBox As TextBox
    Friend WithEvents CourseIDTextBox As TextBox
End Class
