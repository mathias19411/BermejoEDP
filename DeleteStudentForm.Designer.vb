<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DeleteStudentForm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.backButton = New System.Windows.Forms.Button()
        Me.Delete_Stud_Button = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Stud_IDTextBox3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.backButton)
        Me.Panel1.Controls.Add(Me.Delete_Stud_Button)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Stud_IDTextBox3)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(423, 182)
        Me.Panel1.TabIndex = 3
        '
        'backButton
        '
        Me.backButton.BackColor = System.Drawing.Color.OrangeRed
        Me.backButton.Location = New System.Drawing.Point(216, 107)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(195, 57)
        Me.backButton.TabIndex = 23
        Me.backButton.Text = "Back"
        Me.backButton.UseVisualStyleBackColor = False
        '
        'Delete_Stud_Button
        '
        Me.Delete_Stud_Button.BackColor = System.Drawing.Color.LimeGreen
        Me.Delete_Stud_Button.Location = New System.Drawing.Point(12, 107)
        Me.Delete_Stud_Button.Name = "Delete_Stud_Button"
        Me.Delete_Stud_Button.Size = New System.Drawing.Size(198, 57)
        Me.Delete_Stud_Button.TabIndex = 22
        Me.Delete_Stud_Button.Text = "Delete Student"
        Me.Delete_Stud_Button.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Student ID"
        '
        'Stud_IDTextBox3
        '
        Me.Stud_IDTextBox3.Location = New System.Drawing.Point(12, 58)
        Me.Stud_IDTextBox3.Name = "Stud_IDTextBox3"
        Me.Stud_IDTextBox3.Size = New System.Drawing.Size(398, 22)
        Me.Stud_IDTextBox3.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 17)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Enter the Student ID you want to Delete"
        '
        'DeleteStudentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 184)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "DeleteStudentForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delete Student Form"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents backButton As Button
    Friend WithEvents Delete_Stud_Button As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Stud_IDTextBox3 As TextBox
End Class
