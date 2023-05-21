<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Organization_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Organization_Form))
        Me.loadOrganizationsButton = New System.Windows.Forms.Button()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.addOrganizationButton = New System.Windows.Forms.Button()
        Me.backButton = New System.Windows.Forms.Button()
        Me.updateOrganizationButton = New System.Windows.Forms.Button()
        Me.deleteOrganizationButton = New System.Windows.Forms.Button()
        Me.ExportExcelButton3 = New System.Windows.Forms.Button()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'loadOrganizationsButton
        '
        Me.loadOrganizationsButton.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.loadOrganizationsButton.Location = New System.Drawing.Point(12, 12)
        Me.loadOrganizationsButton.Name = "loadOrganizationsButton"
        Me.loadOrganizationsButton.Size = New System.Drawing.Size(1257, 42)
        Me.loadOrganizationsButton.TabIndex = 28
        Me.loadOrganizationsButton.Text = "Load Organizations"
        Me.loadOrganizationsButton.UseVisualStyleBackColor = False
        '
        'DataGridView4
        '
        Me.DataGridView4.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Location = New System.Drawing.Point(12, 60)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.RowHeadersWidth = 51
        Me.DataGridView4.RowTemplate.Height = 24
        Me.DataGridView4.Size = New System.Drawing.Size(1257, 397)
        Me.DataGridView4.TabIndex = 29
        '
        'addOrganizationButton
        '
        Me.addOrganizationButton.BackColor = System.Drawing.Color.LimeGreen
        Me.addOrganizationButton.Location = New System.Drawing.Point(12, 472)
        Me.addOrganizationButton.Name = "addOrganizationButton"
        Me.addOrganizationButton.Size = New System.Drawing.Size(163, 57)
        Me.addOrganizationButton.TabIndex = 21
        Me.addOrganizationButton.Text = "Add Organization"
        Me.addOrganizationButton.UseVisualStyleBackColor = False
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
        'updateOrganizationButton
        '
        Me.updateOrganizationButton.BackColor = System.Drawing.SystemColors.Highlight
        Me.updateOrganizationButton.Location = New System.Drawing.Point(181, 472)
        Me.updateOrganizationButton.Name = "updateOrganizationButton"
        Me.updateOrganizationButton.Size = New System.Drawing.Size(163, 57)
        Me.updateOrganizationButton.TabIndex = 30
        Me.updateOrganizationButton.Text = "Update Organization"
        Me.updateOrganizationButton.UseVisualStyleBackColor = False
        '
        'deleteOrganizationButton
        '
        Me.deleteOrganizationButton.BackColor = System.Drawing.Color.Crimson
        Me.deleteOrganizationButton.Location = New System.Drawing.Point(350, 472)
        Me.deleteOrganizationButton.Name = "deleteOrganizationButton"
        Me.deleteOrganizationButton.Size = New System.Drawing.Size(163, 57)
        Me.deleteOrganizationButton.TabIndex = 31
        Me.deleteOrganizationButton.Text = "Delete Organization"
        Me.deleteOrganizationButton.UseVisualStyleBackColor = False
        '
        'ExportExcelButton3
        '
        Me.ExportExcelButton3.BackColor = System.Drawing.Color.LightCoral
        Me.ExportExcelButton3.Location = New System.Drawing.Point(931, 472)
        Me.ExportExcelButton3.Name = "ExportExcelButton3"
        Me.ExportExcelButton3.Size = New System.Drawing.Size(166, 57)
        Me.ExportExcelButton3.TabIndex = 36
        Me.ExportExcelButton3.Text = "Export Data to Excel"
        Me.ExportExcelButton3.UseVisualStyleBackColor = False
        '
        'Organization_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1281, 541)
        Me.Controls.Add(Me.ExportExcelButton3)
        Me.Controls.Add(Me.deleteOrganizationButton)
        Me.Controls.Add(Me.updateOrganizationButton)
        Me.Controls.Add(Me.addOrganizationButton)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.loadOrganizationsButton)
        Me.Controls.Add(Me.DataGridView4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Organization_Form"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Organization Form"
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents loadOrganizationsButton As Button
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents addOrganizationButton As Button
    Friend WithEvents backButton As Button
    Friend WithEvents updateOrganizationButton As Button
    Friend WithEvents deleteOrganizationButton As Button
    Friend WithEvents ExportExcelButton3 As Button
End Class
