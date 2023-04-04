<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddClubForm
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ClubIDTextBox = New System.Windows.Forms.TextBox()
        Me.ClubNameTextBox = New System.Windows.Forms.TextBox()
        Me.addClubButton = New System.Windows.Forms.Button()
        Me.backButton = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Controls.Add(Me.addClubButton)
        Me.Panel1.Controls.Add(Me.backButton)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.ClubIDTextBox)
        Me.Panel1.Controls.Add(Me.ClubNameTextBox)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(423, 393)
        Me.Panel1.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 17)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Club ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 17)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Club Name"
        '
        'ClubIDTextBox
        '
        Me.ClubIDTextBox.Location = New System.Drawing.Point(9, 30)
        Me.ClubIDTextBox.Name = "ClubIDTextBox"
        Me.ClubIDTextBox.Size = New System.Drawing.Size(402, 22)
        Me.ClubIDTextBox.TabIndex = 17
        '
        'ClubNameTextBox
        '
        Me.ClubNameTextBox.Location = New System.Drawing.Point(9, 100)
        Me.ClubNameTextBox.Name = "ClubNameTextBox"
        Me.ClubNameTextBox.Size = New System.Drawing.Size(402, 22)
        Me.ClubNameTextBox.TabIndex = 18
        '
        'addClubButton
        '
        Me.addClubButton.BackColor = System.Drawing.Color.Lime
        Me.addClubButton.Location = New System.Drawing.Point(9, 195)
        Me.addClubButton.Name = "addClubButton"
        Me.addClubButton.Size = New System.Drawing.Size(198, 57)
        Me.addClubButton.TabIndex = 23
        Me.addClubButton.Text = "Add Club"
        Me.addClubButton.UseVisualStyleBackColor = False
        '
        'backButton
        '
        Me.backButton.BackColor = System.Drawing.Color.OrangeRed
        Me.backButton.Location = New System.Drawing.Point(213, 195)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(198, 57)
        Me.backButton.TabIndex = 22
        Me.backButton.Text = "Back"
        Me.backButton.UseVisualStyleBackColor = False
        '
        'AddClubForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 395)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "AddClubForm"
        Me.Text = "AddClubForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ClubIDTextBox As TextBox
    Friend WithEvents ClubNameTextBox As TextBox
    Friend WithEvents addClubButton As Button
    Friend WithEvents backButton As Button
End Class
