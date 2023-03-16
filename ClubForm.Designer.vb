<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Club_Form
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
        Me.loadClubsButton = New System.Windows.Forms.Button()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.addClubButton = New System.Windows.Forms.Button()
        Me.backButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.firstNameTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'loadClubsButton
        '
        Me.loadClubsButton.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.loadClubsButton.Location = New System.Drawing.Point(392, 9)
        Me.loadClubsButton.Name = "loadClubsButton"
        Me.loadClubsButton.Size = New System.Drawing.Size(403, 42)
        Me.loadClubsButton.TabIndex = 28
        Me.loadClubsButton.Text = "Load Clubs"
        Me.loadClubsButton.UseVisualStyleBackColor = False
        '
        'DataGridView3
        '
        Me.DataGridView3.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(392, 59)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowHeadersWidth = 51
        Me.DataGridView3.RowTemplate.Height = 24
        Me.DataGridView3.Size = New System.Drawing.Size(403, 377)
        Me.DataGridView3.TabIndex = 29
        '
        'addClubButton
        '
        Me.addClubButton.BackColor = System.Drawing.SystemColors.Highlight
        Me.addClubButton.Location = New System.Drawing.Point(204, 182)
        Me.addClubButton.Name = "addClubButton"
        Me.addClubButton.Size = New System.Drawing.Size(163, 57)
        Me.addClubButton.TabIndex = 21
        Me.addClubButton.Text = "Add Club"
        Me.addClubButton.UseVisualStyleBackColor = False
        '
        'backButton
        '
        Me.backButton.BackColor = System.Drawing.SystemColors.Info
        Me.backButton.Location = New System.Drawing.Point(9, 182)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(166, 57)
        Me.backButton.TabIndex = 20
        Me.backButton.Text = "Back"
        Me.backButton.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Club Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Club ID"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(9, 100)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(358, 22)
        Me.TextBox3.TabIndex = 2
        '
        'firstNameTextBox
        '
        Me.firstNameTextBox.Location = New System.Drawing.Point(9, 30)
        Me.firstNameTextBox.Name = "firstNameTextBox"
        Me.firstNameTextBox.Size = New System.Drawing.Size(184, 22)
        Me.firstNameTextBox.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Controls.Add(Me.addClubButton)
        Me.Panel1.Controls.Add(Me.backButton)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.firstNameTextBox)
        Me.Panel1.Location = New System.Drawing.Point(5, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(381, 453)
        Me.Panel1.TabIndex = 27
        '
        'Club_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.loadClubsButton)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Club_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Club Form"
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents loadClubsButton As Button
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents addClubButton As Button
    Friend WithEvents backButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents firstNameTextBox As TextBox
    Friend WithEvents Panel1 As Panel
End Class
