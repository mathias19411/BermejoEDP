<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateClubForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateClubForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ClubDescTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ClubPresTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.updateClubButton = New System.Windows.Forms.Button()
        Me.backButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ClubIDTextBox = New System.Windows.Forms.TextBox()
        Me.ClubNameTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Controls.Add(Me.ClubDescTextBox)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.ClubPresTextBox)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.updateClubButton)
        Me.Panel1.Controls.Add(Me.backButton)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.ClubIDTextBox)
        Me.Panel1.Controls.Add(Me.ClubNameTextBox)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(423, 393)
        Me.Panel1.TabIndex = 18
        '
        'ClubDescTextBox
        '
        Me.ClubDescTextBox.Location = New System.Drawing.Point(9, 240)
        Me.ClubDescTextBox.Name = "ClubDescTextBox"
        Me.ClubDescTextBox.Size = New System.Drawing.Size(402, 22)
        Me.ClubDescTextBox.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 17)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Club Description"
        '
        'ClubPresTextBox
        '
        Me.ClubPresTextBox.Location = New System.Drawing.Point(9, 170)
        Me.ClubPresTextBox.Name = "ClubPresTextBox"
        Me.ClubPresTextBox.Size = New System.Drawing.Size(402, 22)
        Me.ClubPresTextBox.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 17)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Club President"
        '
        'updateClubButton
        '
        Me.updateClubButton.BackColor = System.Drawing.Color.Lime
        Me.updateClubButton.Location = New System.Drawing.Point(9, 325)
        Me.updateClubButton.Name = "updateClubButton"
        Me.updateClubButton.Size = New System.Drawing.Size(198, 57)
        Me.updateClubButton.TabIndex = 23
        Me.updateClubButton.Text = "Update Club"
        Me.updateClubButton.UseVisualStyleBackColor = False
        '
        'backButton
        '
        Me.backButton.BackColor = System.Drawing.Color.OrangeRed
        Me.backButton.Location = New System.Drawing.Point(213, 325)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(198, 57)
        Me.backButton.TabIndex = 22
        Me.backButton.Text = "Back"
        Me.backButton.UseVisualStyleBackColor = False
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
        'UpdateClubForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 395)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UpdateClubForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Club Form"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ClubDescTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ClubPresTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents updateClubButton As Button
    Friend WithEvents backButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ClubIDTextBox As TextBox
    Friend WithEvents ClubNameTextBox As TextBox
End Class
