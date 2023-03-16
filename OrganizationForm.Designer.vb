<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Organization_Form
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
        Me.loadOrganizationsButton = New System.Windows.Forms.Button()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.addOrganizationButton = New System.Windows.Forms.Button()
        Me.backButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.firstNameTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'loadOrganizationsButton
        '
        Me.loadOrganizationsButton.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.loadOrganizationsButton.Location = New System.Drawing.Point(392, 9)
        Me.loadOrganizationsButton.Name = "loadOrganizationsButton"
        Me.loadOrganizationsButton.Size = New System.Drawing.Size(403, 42)
        Me.loadOrganizationsButton.TabIndex = 28
        Me.loadOrganizationsButton.Text = "Load Organizations"
        Me.loadOrganizationsButton.UseVisualStyleBackColor = False
        '
        'DataGridView4
        '
        Me.DataGridView4.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Location = New System.Drawing.Point(392, 59)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.RowHeadersWidth = 51
        Me.DataGridView4.RowTemplate.Height = 24
        Me.DataGridView4.Size = New System.Drawing.Size(403, 377)
        Me.DataGridView4.TabIndex = 29
        '
        'addOrganizationButton
        '
        Me.addOrganizationButton.BackColor = System.Drawing.SystemColors.Highlight
        Me.addOrganizationButton.Location = New System.Drawing.Point(204, 182)
        Me.addOrganizationButton.Name = "addOrganizationButton"
        Me.addOrganizationButton.Size = New System.Drawing.Size(163, 57)
        Me.addOrganizationButton.TabIndex = 21
        Me.addOrganizationButton.Text = "Add Organization"
        Me.addOrganizationButton.UseVisualStyleBackColor = False
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
        Me.Label3.Size = New System.Drawing.Size(130, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Organization Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Organization ID"
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
        Me.Panel1.Controls.Add(Me.addOrganizationButton)
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
        'Organization_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.loadOrganizationsButton)
        Me.Controls.Add(Me.DataGridView4)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Organization_Form"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Organization Form"
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents loadOrganizationsButton As Button
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents addOrganizationButton As Button
    Friend WithEvents backButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents firstNameTextBox As TextBox
    Friend WithEvents Panel1 As Panel
End Class
