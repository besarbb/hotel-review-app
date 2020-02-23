<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Administration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Administration))
        Me.lblAdministrationPage = New System.Windows.Forms.Label()
        Me.lblCompanyName = New System.Windows.Forms.Label()
        Me.lblCompanyLogo = New System.Windows.Forms.Label()
        Me.lblCompanyMarketingLine = New System.Windows.Forms.Label()
        Me.txtCompanyName = New System.Windows.Forms.TextBox()
        Me.txtCompanyLogoPath = New System.Windows.Forms.TextBox()
        Me.txtCompanyMarketingLine = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.bwsImageLoad = New System.Windows.Forms.OpenFileDialog()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblAdministrationPage
        '
        Me.lblAdministrationPage.AutoSize = True
        Me.lblAdministrationPage.Font = New System.Drawing.Font("Calibri", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdministrationPage.Location = New System.Drawing.Point(27, 32)
        Me.lblAdministrationPage.Name = "lblAdministrationPage"
        Me.lblAdministrationPage.Size = New System.Drawing.Size(393, 42)
        Me.lblAdministrationPage.TabIndex = 0
        Me.lblAdministrationPage.Text = "Pagina di administrazione"
        '
        'lblCompanyName
        '
        Me.lblCompanyName.AutoSize = True
        Me.lblCompanyName.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompanyName.Location = New System.Drawing.Point(31, 134)
        Me.lblCompanyName.Name = "lblCompanyName"
        Me.lblCompanyName.Size = New System.Drawing.Size(147, 26)
        Me.lblCompanyName.TabIndex = 1
        Me.lblCompanyName.Text = "Company name"
        '
        'lblCompanyLogo
        '
        Me.lblCompanyLogo.AutoSize = True
        Me.lblCompanyLogo.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompanyLogo.Location = New System.Drawing.Point(31, 217)
        Me.lblCompanyLogo.Name = "lblCompanyLogo"
        Me.lblCompanyLogo.Size = New System.Drawing.Size(135, 26)
        Me.lblCompanyLogo.TabIndex = 2
        Me.lblCompanyLogo.Text = "Company logo"
        '
        'lblCompanyMarketingLine
        '
        Me.lblCompanyMarketingLine.AutoSize = True
        Me.lblCompanyMarketingLine.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompanyMarketingLine.Location = New System.Drawing.Point(31, 297)
        Me.lblCompanyMarketingLine.Name = "lblCompanyMarketingLine"
        Me.lblCompanyMarketingLine.Size = New System.Drawing.Size(222, 26)
        Me.lblCompanyMarketingLine.TabIndex = 3
        Me.lblCompanyMarketingLine.Text = "Company marketing line"
        '
        'txtCompanyName
        '
        Me.txtCompanyName.Location = New System.Drawing.Point(36, 164)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.Size = New System.Drawing.Size(295, 20)
        Me.txtCompanyName.TabIndex = 4
        '
        'txtCompanyLogoPath
        '
        Me.txtCompanyLogoPath.Location = New System.Drawing.Point(36, 246)
        Me.txtCompanyLogoPath.Name = "txtCompanyLogoPath"
        Me.txtCompanyLogoPath.Size = New System.Drawing.Size(295, 20)
        Me.txtCompanyLogoPath.TabIndex = 5
        '
        'txtCompanyMarketingLine
        '
        Me.txtCompanyMarketingLine.Location = New System.Drawing.Point(36, 326)
        Me.txtCompanyMarketingLine.Name = "txtCompanyMarketingLine"
        Me.txtCompanyMarketingLine.Size = New System.Drawing.Size(295, 20)
        Me.txtCompanyMarketingLine.TabIndex = 6
        '
        'btnBrowse
        '
        Me.btnBrowse.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.Location = New System.Drawing.Point(350, 246)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(107, 19)
        Me.btnBrowse.TabIndex = 7
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'bwsImageLoad
        '
        Me.bwsImageLoad.Filter = """Image files (*.png) | *.png"""
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(36, 379)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(142, 38)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Save changes"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(33, 431)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(67, 15)
        Me.lblInfo.TabIndex = 9
        Me.lblInfo.Text = "lblInfo text"
        Me.lblInfo.Visible = False
        '
        'Administration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 468)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.txtCompanyMarketingLine)
        Me.Controls.Add(Me.txtCompanyLogoPath)
        Me.Controls.Add(Me.txtCompanyName)
        Me.Controls.Add(Me.lblCompanyMarketingLine)
        Me.Controls.Add(Me.lblCompanyLogo)
        Me.Controls.Add(Me.lblCompanyName)
        Me.Controls.Add(Me.lblAdministrationPage)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Administration"
        Me.Text = "Administration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAdministrationPage As Label
    Friend WithEvents lblCompanyName As Label
    Friend WithEvents lblCompanyLogo As Label
    Friend WithEvents lblCompanyMarketingLine As Label
    Friend WithEvents txtCompanyName As TextBox
    Friend WithEvents txtCompanyLogoPath As TextBox
    Friend WithEvents txtCompanyMarketingLine As TextBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents bwsImageLoad As OpenFileDialog
    Friend WithEvents btnSave As Button
    Friend WithEvents lblInfo As Label
End Class
