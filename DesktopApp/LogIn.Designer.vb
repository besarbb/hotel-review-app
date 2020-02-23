<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogIn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LogIn))
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLogIn = New System.Windows.Forms.Button()
        Me.lblWarning = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(25, 67)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(131, 33)
        Me.lblUsername.TabIndex = 0
        Me.lblUsername.Text = "Username"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(25, 148)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(122, 33)
        Me.lblPassword.TabIndex = 1
        Me.lblPassword.Text = "Password"
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(31, 103)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(232, 40)
        Me.txtUsername.TabIndex = 2
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(31, 184)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(232, 40)
        Me.txtPassword.TabIndex = 3
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'btnLogIn
        '
        Me.btnLogIn.Font = New System.Drawing.Font("Calibri", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogIn.Location = New System.Drawing.Point(31, 281)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(232, 78)
        Me.btnLogIn.TabIndex = 4
        Me.btnLogIn.Text = "Log In"
        Me.btnLogIn.UseVisualStyleBackColor = True
        '
        'lblWarning
        '
        Me.lblWarning.AutoSize = True
        Me.lblWarning.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWarning.ForeColor = System.Drawing.Color.Red
        Me.lblWarning.Location = New System.Drawing.Point(31, 387)
        Me.lblWarning.Name = "lblWarning"
        Me.lblWarning.Size = New System.Drawing.Size(236, 19)
        Me.lblWarning.TabIndex = 5
        Me.lblWarning.Text = "Username or password is incorrect!"
        Me.lblWarning.Visible = False
        '
        'LogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(302, 450)
        Me.Controls.Add(Me.lblWarning)
        Me.Controls.Add(Me.btnLogIn)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LogIn"
        Me.Text = "LogIn"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogIn As Button
    Friend WithEvents lblWarning As Label
End Class
