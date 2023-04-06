<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteClubForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.backButton = New System.Windows.Forms.Button()
        Me.Delete_Club_Button = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ClubIDTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.ClubIDTextBox)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.backButton)
        Me.Panel1.Controls.Add(Me.Delete_Club_Button)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(423, 182)
        Me.Panel1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 17)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Enter the Club ID you want to Delete"
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
        'Delete_Club_Button
        '
        Me.Delete_Club_Button.BackColor = System.Drawing.Color.LimeGreen
        Me.Delete_Club_Button.Location = New System.Drawing.Point(12, 107)
        Me.Delete_Club_Button.Name = "Delete_Club_Button"
        Me.Delete_Club_Button.Size = New System.Drawing.Size(198, 57)
        Me.Delete_Club_Button.TabIndex = 22
        Me.Delete_Club_Button.Text = "Delete Club"
        Me.Delete_Club_Button.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 17)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Club ID"
        '
        'ClubIDTextBox
        '
        Me.ClubIDTextBox.Location = New System.Drawing.Point(9, 62)
        Me.ClubIDTextBox.Name = "ClubIDTextBox"
        Me.ClubIDTextBox.Size = New System.Drawing.Size(402, 22)
        Me.ClubIDTextBox.TabIndex = 25
        '
        'DeleteClubForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 184)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "DeleteClubForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delete Club Form"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents backButton As Button
    Friend WithEvents Delete_Club_Button As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ClubIDTextBox As TextBox
End Class
