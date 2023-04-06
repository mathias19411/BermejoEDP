<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Club_Form
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
        Me.loadClubsButton = New System.Windows.Forms.Button()
        Me.backButton = New System.Windows.Forms.Button()
        Me.addClubButton = New System.Windows.Forms.Button()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.updateClubButton = New System.Windows.Forms.Button()
        Me.deleteClubButton = New System.Windows.Forms.Button()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'loadClubsButton
        '
        Me.loadClubsButton.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.loadClubsButton.Location = New System.Drawing.Point(12, 12)
        Me.loadClubsButton.Name = "loadClubsButton"
        Me.loadClubsButton.Size = New System.Drawing.Size(1257, 42)
        Me.loadClubsButton.TabIndex = 28
        Me.loadClubsButton.Text = "Load Clubs"
        Me.loadClubsButton.UseVisualStyleBackColor = False
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
        'addClubButton
        '
        Me.addClubButton.BackColor = System.Drawing.Color.LimeGreen
        Me.addClubButton.Location = New System.Drawing.Point(12, 472)
        Me.addClubButton.Name = "addClubButton"
        Me.addClubButton.Size = New System.Drawing.Size(163, 57)
        Me.addClubButton.TabIndex = 21
        Me.addClubButton.Text = "Add Club"
        Me.addClubButton.UseVisualStyleBackColor = False
        '
        'DataGridView3
        '
        Me.DataGridView3.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(12, 60)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowHeadersWidth = 51
        Me.DataGridView3.RowTemplate.Height = 24
        Me.DataGridView3.Size = New System.Drawing.Size(1257, 397)
        Me.DataGridView3.TabIndex = 29
        '
        'updateClubButton
        '
        Me.updateClubButton.BackColor = System.Drawing.SystemColors.Highlight
        Me.updateClubButton.Location = New System.Drawing.Point(181, 472)
        Me.updateClubButton.Name = "updateClubButton"
        Me.updateClubButton.Size = New System.Drawing.Size(163, 57)
        Me.updateClubButton.TabIndex = 30
        Me.updateClubButton.Text = "Update Club"
        Me.updateClubButton.UseVisualStyleBackColor = False
        '
        'deleteClubButton
        '
        Me.deleteClubButton.BackColor = System.Drawing.Color.Crimson
        Me.deleteClubButton.Location = New System.Drawing.Point(350, 472)
        Me.deleteClubButton.Name = "deleteClubButton"
        Me.deleteClubButton.Size = New System.Drawing.Size(163, 57)
        Me.deleteClubButton.TabIndex = 31
        Me.deleteClubButton.Text = "Delete Club"
        Me.deleteClubButton.UseVisualStyleBackColor = False
        '
        'Club_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1281, 541)
        Me.Controls.Add(Me.deleteClubButton)
        Me.Controls.Add(Me.updateClubButton)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.addClubButton)
        Me.Controls.Add(Me.loadClubsButton)
        Me.Controls.Add(Me.DataGridView3)
        Me.Name = "Club_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Club Form"
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents loadClubsButton As Button
    Friend WithEvents backButton As Button
    Friend WithEvents addClubButton As Button
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents updateClubButton As Button
    Friend WithEvents deleteClubButton As Button
End Class
