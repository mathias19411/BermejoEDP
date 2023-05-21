<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateOrganizationForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateOrganizationForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.updateOrganizationButton = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.OrganizationNameTextBox = New System.Windows.Forms.TextBox()
        Me.backButton = New System.Windows.Forms.Button()
        Me.OrganizationIDTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.updateOrganizationButton)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.OrganizationNameTextBox)
        Me.Panel1.Controls.Add(Me.backButton)
        Me.Panel1.Controls.Add(Me.OrganizationIDTextBox)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(423, 393)
        Me.Panel1.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 17)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Organization Name"
        '
        'updateOrganizationButton
        '
        Me.updateOrganizationButton.BackColor = System.Drawing.Color.Lime
        Me.updateOrganizationButton.Location = New System.Drawing.Point(9, 325)
        Me.updateOrganizationButton.Name = "updateOrganizationButton"
        Me.updateOrganizationButton.Size = New System.Drawing.Size(198, 57)
        Me.updateOrganizationButton.TabIndex = 23
        Me.updateOrganizationButton.Text = "Update Organization"
        Me.updateOrganizationButton.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 17)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Organization ID"
        '
        'OrganizationNameTextBox
        '
        Me.OrganizationNameTextBox.Location = New System.Drawing.Point(9, 100)
        Me.OrganizationNameTextBox.Name = "OrganizationNameTextBox"
        Me.OrganizationNameTextBox.Size = New System.Drawing.Size(402, 22)
        Me.OrganizationNameTextBox.TabIndex = 20
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
        'OrganizationIDTextBox
        '
        Me.OrganizationIDTextBox.Location = New System.Drawing.Point(9, 30)
        Me.OrganizationIDTextBox.Name = "OrganizationIDTextBox"
        Me.OrganizationIDTextBox.Size = New System.Drawing.Size(402, 22)
        Me.OrganizationIDTextBox.TabIndex = 19
        '
        'UpdateOrganizationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 395)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UpdateOrganizationForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Organization Form"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents updateOrganizationButton As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents OrganizationNameTextBox As TextBox
    Friend WithEvents backButton As Button
    Friend WithEvents OrganizationIDTextBox As TextBox
End Class
