<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteOrganizationForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeleteOrganizationForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.OrganizationIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.backButton = New System.Windows.Forms.Button()
        Me.Delete_Org_Button = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.OrganizationIDTextBox)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.backButton)
        Me.Panel1.Controls.Add(Me.Delete_Org_Button)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(423, 182)
        Me.Panel1.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 17)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Organization ID"
        '
        'OrganizationIDTextBox
        '
        Me.OrganizationIDTextBox.Location = New System.Drawing.Point(9, 65)
        Me.OrganizationIDTextBox.Name = "OrganizationIDTextBox"
        Me.OrganizationIDTextBox.Size = New System.Drawing.Size(402, 22)
        Me.OrganizationIDTextBox.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(289, 17)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Enter the Organization ID you want to Delete"
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
        'Delete_Org_Button
        '
        Me.Delete_Org_Button.BackColor = System.Drawing.Color.LimeGreen
        Me.Delete_Org_Button.Location = New System.Drawing.Point(12, 107)
        Me.Delete_Org_Button.Name = "Delete_Org_Button"
        Me.Delete_Org_Button.Size = New System.Drawing.Size(198, 57)
        Me.Delete_Org_Button.TabIndex = 22
        Me.Delete_Org_Button.Text = "Delete Organization"
        Me.Delete_Org_Button.UseVisualStyleBackColor = False
        '
        'DeleteOrganizationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 184)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DeleteOrganizationForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delete Organization Form"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents backButton As Button
    Friend WithEvents Delete_Org_Button As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents OrganizationIDTextBox As TextBox
End Class
