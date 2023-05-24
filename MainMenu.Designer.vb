<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainMenu))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.BackupButton = New System.Windows.Forms.Button()
        Me.UploadButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monospac821 BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(298, 24)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Welcome to the Main Menu"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button4.Location = New System.Drawing.Point(53, 270)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(246, 35)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Organizations"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button3.Location = New System.Drawing.Point(53, 229)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(246, 35)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Clubs"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button2.Location = New System.Drawing.Point(53, 188)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(246, 35)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Courses"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button1.Location = New System.Drawing.Point(53, 147)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(246, 35)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Students"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'exitButton
        '
        Me.exitButton.BackColor = System.Drawing.Color.IndianRed
        Me.exitButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.exitButton.Location = New System.Drawing.Point(53, 349)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(246, 49)
        Me.exitButton.TabIndex = 10
        Me.exitButton.Text = "Logout"
        Me.exitButton.UseVisualStyleBackColor = False
        '
        'BackupButton
        '
        Me.BackupButton.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackupButton.Location = New System.Drawing.Point(53, 106)
        Me.BackupButton.Name = "BackupButton"
        Me.BackupButton.Size = New System.Drawing.Size(246, 35)
        Me.BackupButton.TabIndex = 11
        Me.BackupButton.Text = "Backup Database"
        Me.BackupButton.UseVisualStyleBackColor = False
        '
        'UploadButton
        '
        Me.UploadButton.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.UploadButton.Location = New System.Drawing.Point(53, 65)
        Me.UploadButton.Name = "UploadButton"
        Me.UploadButton.Size = New System.Drawing.Size(246, 35)
        Me.UploadButton.TabIndex = 12
        Me.UploadButton.Text = "Upload CSV"
        Me.UploadButton.UseVisualStyleBackColor = False
        '
        'mainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 450)
        Me.Controls.Add(Me.UploadButton)
        Me.Controls.Add(Me.BackupButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "mainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents BackupButton As Button
    Friend WithEvents UploadButton As Button
End Class
