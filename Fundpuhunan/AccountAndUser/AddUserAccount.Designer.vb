<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddUserAccount
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
        Me.components = New System.ComponentModel.Container()
        Me.cmbboxPosition = New System.Windows.Forms.ComboBox()
        Me.btnAddUserApply = New System.Windows.Forms.Button()
        Me.btnAddUserCancel = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.chbSPassword = New System.Windows.Forms.CheckBox()
        Me.btnCFile = New System.Windows.Forms.Button()
        Me.pictureboxAddUser = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMname = New System.Windows.Forms.TextBox()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.txtLname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider3 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider4 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider5 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider6 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.pictureboxAddUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbboxPosition
        '
        Me.cmbboxPosition.FormattingEnabled = True
        Me.cmbboxPosition.Items.AddRange(New Object() {"Manager", "Collector", "CIR"})
        Me.cmbboxPosition.Location = New System.Drawing.Point(138, 166)
        Me.cmbboxPosition.Name = "cmbboxPosition"
        Me.cmbboxPosition.Size = New System.Drawing.Size(435, 21)
        Me.cmbboxPosition.TabIndex = 29
        '
        'btnAddUserApply
        '
        Me.btnAddUserApply.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAddUserApply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAddUserApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddUserApply.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddUserApply.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAddUserApply.Location = New System.Drawing.Point(646, 277)
        Me.btnAddUserApply.Name = "btnAddUserApply"
        Me.btnAddUserApply.Size = New System.Drawing.Size(112, 34)
        Me.btnAddUserApply.TabIndex = 33
        Me.btnAddUserApply.Text = "Apply"
        Me.btnAddUserApply.UseVisualStyleBackColor = False
        '
        'btnAddUserCancel
        '
        Me.btnAddUserCancel.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnAddUserCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAddUserCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddUserCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddUserCancel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAddUserCancel.Location = New System.Drawing.Point(528, 277)
        Me.btnAddUserCancel.Name = "btnAddUserCancel"
        Me.btnAddUserCancel.Size = New System.Drawing.Size(112, 34)
        Me.btnAddUserCancel.TabIndex = 42
        Me.btnAddUserCancel.Text = "Cancel"
        Me.btnAddUserCancel.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(643, 115)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 16)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "ID #"
        '
        'chbSPassword
        '
        Me.chbSPassword.AutoSize = True
        Me.chbSPassword.Location = New System.Drawing.Point(138, 262)
        Me.chbSPassword.Name = "chbSPassword"
        Me.chbSPassword.Size = New System.Drawing.Size(102, 17)
        Me.chbSPassword.TabIndex = 40
        Me.chbSPassword.Text = "Show Password"
        Me.chbSPassword.UseVisualStyleBackColor = True
        '
        'btnCFile
        '
        Me.btnCFile.Location = New System.Drawing.Point(646, 233)
        Me.btnCFile.Name = "btnCFile"
        Me.btnCFile.Size = New System.Drawing.Size(112, 23)
        Me.btnCFile.TabIndex = 32
        Me.btnCFile.Text = "Choose File"
        Me.btnCFile.UseVisualStyleBackColor = True
        '
        'pictureboxAddUser
        '
        Me.pictureboxAddUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pictureboxAddUser.Location = New System.Drawing.Point(646, 133)
        Me.pictureboxAddUser.Name = "pictureboxAddUser"
        Me.pictureboxAddUser.Size = New System.Drawing.Size(112, 94)
        Me.pictureboxAddUser.TabIndex = 38
        Me.pictureboxAddUser.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(61, 237)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 16)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Password:"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(138, 236)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(435, 20)
        Me.txtPassword.TabIndex = 31
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(138, 201)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(435, 20)
        Me.txtUsername.TabIndex = 30
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(61, 202)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 16)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Username:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(61, 167)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 16)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Position:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(430, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 9)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "(Middle Name)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(283, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 9)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "(Given Name)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(136, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 9)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "(Surname)"
        '
        'txtMname
        '
        Me.txtMname.Location = New System.Drawing.Point(432, 133)
        Me.txtMname.Name = "txtMname"
        Me.txtMname.Size = New System.Drawing.Size(141, 20)
        Me.txtMname.TabIndex = 28
        '
        'txtFname
        '
        Me.txtFname.Location = New System.Drawing.Point(285, 133)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(141, 20)
        Me.txtFname.TabIndex = 27
        '
        'txtLname
        '
        Me.txtLname.Location = New System.Drawing.Point(138, 133)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(141, 20)
        Me.txtLname.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(61, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 16)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Full Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Location = New System.Drawing.Point(60, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 20)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Add User Account"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(-26, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(896, 16)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "_________________________________________________________________________________" &
    "______________________________________________"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        '
        'ErrorProvider3
        '
        Me.ErrorProvider3.ContainerControl = Me
        '
        'ErrorProvider4
        '
        Me.ErrorProvider4.ContainerControl = Me
        '
        'ErrorProvider5
        '
        Me.ErrorProvider5.ContainerControl = Me
        '
        'ErrorProvider6
        '
        Me.ErrorProvider6.ContainerControl = Me
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(683, 117)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 13)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "--------"
        '
        'AddUserAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(838, 346)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cmbboxPosition)
        Me.Controls.Add(Me.btnAddUserApply)
        Me.Controls.Add(Me.btnAddUserCancel)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.chbSPassword)
        Me.Controls.Add(Me.btnCFile)
        Me.Controls.Add(Me.pictureboxAddUser)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMname)
        Me.Controls.Add(Me.txtFname)
        Me.Controls.Add(Me.txtLname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "AddUserAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add User Account"
        CType(Me.pictureboxAddUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbboxPosition As ComboBox
    Friend WithEvents btnAddUserApply As Button
    Friend WithEvents btnAddUserCancel As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents chbSPassword As CheckBox
    Friend WithEvents btnCFile As Button
    Friend WithEvents pictureboxAddUser As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMname As TextBox
    Friend WithEvents txtFname As TextBox
    Friend WithEvents txtLname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
    Friend WithEvents ErrorProvider3 As ErrorProvider
    Friend WithEvents ErrorProvider4 As ErrorProvider
    Friend WithEvents ErrorProvider5 As ErrorProvider
    Friend WithEvents ErrorProvider6 As ErrorProvider
    Friend WithEvents Label11 As Label
End Class
