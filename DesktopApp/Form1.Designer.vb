<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblAreaDiServizio = New System.Windows.Forms.Label()
        Me.lblCompany = New System.Windows.Forms.Label()
        Me.lblGioveClear = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lnkLogIn = New System.Windows.Forms.LinkLabel()
        Me.tmrTime = New System.Windows.Forms.Timer(Me.components)
        Me.lblCustomerQuestion = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.imgAngry = New System.Windows.Forms.PictureBox()
        Me.imgConfused = New System.Windows.Forms.PictureBox()
        Me.imgSmiley = New System.Windows.Forms.PictureBox()
        Me.imgCompanyLogoCenter = New System.Windows.Forms.PictureBox()
        Me.imgHeader = New System.Windows.Forms.PictureBox()
        CType(Me.imgAngry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgConfused, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgSmiley, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgCompanyLogoCenter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAreaDiServizio
        '
        Me.lblAreaDiServizio.AutoSize = True
        Me.lblAreaDiServizio.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAreaDiServizio.ForeColor = System.Drawing.SystemColors.Window
        Me.lblAreaDiServizio.Location = New System.Drawing.Point(12, 15)
        Me.lblAreaDiServizio.Name = "lblAreaDiServizio"
        Me.lblAreaDiServizio.Size = New System.Drawing.Size(180, 33)
        Me.lblAreaDiServizio.TabIndex = 1
        Me.lblAreaDiServizio.Text = "Area di servizio"
        '
        'lblCompany
        '
        Me.lblCompany.AutoSize = True
        Me.lblCompany.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompany.ForeColor = System.Drawing.SystemColors.Window
        Me.lblCompany.Location = New System.Drawing.Point(11, 48)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(252, 39)
        Me.lblCompany.TabIndex = 2
        Me.lblCompany.Text = "CAMPIOLO OVEST"
        '
        'lblGioveClear
        '
        Me.lblGioveClear.AutoSize = True
        Me.lblGioveClear.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGioveClear.ForeColor = System.Drawing.SystemColors.Window
        Me.lblGioveClear.Location = New System.Drawing.Point(715, 38)
        Me.lblGioveClear.Name = "lblGioveClear"
        Me.lblGioveClear.Size = New System.Drawing.Size(174, 36)
        Me.lblGioveClear.TabIndex = 4
        Me.lblGioveClear.Text = "GIOVE CLEAR"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(1081, 15)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(0, 33)
        Me.lblTime.TabIndex = 5
        '
        'lnkLogIn
        '
        Me.lnkLogIn.AutoSize = True
        Me.lnkLogIn.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkLogIn.LinkColor = System.Drawing.Color.White
        Me.lnkLogIn.Location = New System.Drawing.Point(1087, 60)
        Me.lnkLogIn.Name = "lnkLogIn"
        Me.lnkLogIn.Size = New System.Drawing.Size(119, 15)
        Me.lnkLogIn.TabIndex = 6
        Me.lnkLogIn.TabStop = True
        Me.lnkLogIn.Text = "Accedi are operatori"
        '
        'tmrTime
        '
        Me.tmrTime.Enabled = True
        '
        'lblCustomerQuestion
        '
        Me.lblCustomerQuestion.AutoSize = True
        Me.lblCustomerQuestion.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerQuestion.Location = New System.Drawing.Point(17, 113)
        Me.lblCustomerQuestion.Name = "lblCustomerQuestion"
        Me.lblCustomerQuestion.Size = New System.Drawing.Size(441, 39)
        Me.lblCustomerQuestion.TabIndex = 7
        Me.lblCustomerQuestion.Text = "Sei sodisfato dei servizzi igienici?"
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'imgAngry
        '
        Me.imgAngry.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgAngry.Image = Global.DesktopApp.My.Resources.Resource1.imgSad
        Me.imgAngry.Location = New System.Drawing.Point(887, 232)
        Me.imgAngry.Name = "imgAngry"
        Me.imgAngry.Size = New System.Drawing.Size(267, 242)
        Me.imgAngry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgAngry.TabIndex = 10
        Me.imgAngry.TabStop = False
        '
        'imgConfused
        '
        Me.imgConfused.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgConfused.Image = Global.DesktopApp.My.Resources.Resource1.imgConfused
        Me.imgConfused.Location = New System.Drawing.Point(507, 232)
        Me.imgConfused.Name = "imgConfused"
        Me.imgConfused.Size = New System.Drawing.Size(267, 242)
        Me.imgConfused.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgConfused.TabIndex = 9
        Me.imgConfused.TabStop = False
        '
        'imgSmiley
        '
        Me.imgSmiley.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgSmiley.Image = Global.DesktopApp.My.Resources.Resource1.imgHappy
        Me.imgSmiley.Location = New System.Drawing.Point(123, 232)
        Me.imgSmiley.Name = "imgSmiley"
        Me.imgSmiley.Size = New System.Drawing.Size(267, 242)
        Me.imgSmiley.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgSmiley.TabIndex = 8
        Me.imgSmiley.TabStop = False
        '
        'imgCompanyLogoCenter
        '
        Me.imgCompanyLogoCenter.Location = New System.Drawing.Point(608, 12)
        Me.imgCompanyLogoCenter.Name = "imgCompanyLogoCenter"
        Me.imgCompanyLogoCenter.Size = New System.Drawing.Size(116, 75)
        Me.imgCompanyLogoCenter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgCompanyLogoCenter.TabIndex = 3
        Me.imgCompanyLogoCenter.TabStop = False
        '
        'imgHeader
        '
        Me.imgHeader.Location = New System.Drawing.Point(-1, -2)
        Me.imgHeader.Name = "imgHeader"
        Me.imgHeader.Size = New System.Drawing.Size(1280, 92)
        Me.imgHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.imgHeader.TabIndex = 0
        Me.imgHeader.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.imgAngry)
        Me.Controls.Add(Me.imgConfused)
        Me.Controls.Add(Me.imgSmiley)
        Me.Controls.Add(Me.lblCustomerQuestion)
        Me.Controls.Add(Me.lnkLogIn)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblGioveClear)
        Me.Controls.Add(Me.imgCompanyLogoCenter)
        Me.Controls.Add(Me.lblCompany)
        Me.Controls.Add(Me.lblAreaDiServizio)
        Me.Controls.Add(Me.imgHeader)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "VB.NET Desktop Application"
        CType(Me.imgAngry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgConfused, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgSmiley, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgCompanyLogoCenter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents imgHeader As PictureBox
    Friend WithEvents lblAreaDiServizio As Label
    Friend WithEvents lblCompany As Label
    Friend WithEvents imgCompanyLogoCenter As PictureBox
    Friend WithEvents lblGioveClear As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents lnkLogIn As LinkLabel
    Friend WithEvents tmrTime As Timer
    Friend WithEvents lblCustomerQuestion As Label
    Friend WithEvents imgSmiley As PictureBox
    Friend WithEvents imgConfused As PictureBox
    Friend WithEvents imgAngry As PictureBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
