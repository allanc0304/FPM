<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountUserManagement
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
        Me.datagridManageUser = New System.Windows.Forms.DataGridView()
        Me.UserID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserSurname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserFirstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserMiddleName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserPosition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserUsername = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserPassword = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserEdit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserDelete = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.btnAddUser = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.datagridManageUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'datagridManageUser
        '
        Me.datagridManageUser.BackgroundColor = System.Drawing.SystemColors.ControlDark
        Me.datagridManageUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridManageUser.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserID, Me.UserSurname, Me.UserFirstName, Me.UserMiddleName, Me.UserPosition, Me.UserUsername, Me.UserPassword, Me.UserEdit, Me.UserDelete})
        Me.datagridManageUser.Location = New System.Drawing.Point(12, 105)
        Me.datagridManageUser.Name = "datagridManageUser"
        Me.datagridManageUser.Size = New System.Drawing.Size(916, 620)
        Me.datagridManageUser.TabIndex = 0
        '
        'UserID
        '
        Me.UserID.HeaderText = "ID"
        Me.UserID.Name = "UserID"
        '
        'UserSurname
        '
        Me.UserSurname.HeaderText = "Surname"
        Me.UserSurname.Name = "UserSurname"
        '
        'UserFirstName
        '
        Me.UserFirstName.HeaderText = "First Name"
        Me.UserFirstName.Name = "UserFirstName"
        '
        'UserMiddleName
        '
        Me.UserMiddleName.HeaderText = "Middle Name"
        Me.UserMiddleName.Name = "UserMiddleName"
        '
        'UserPosition
        '
        Me.UserPosition.HeaderText = "Position"
        Me.UserPosition.Name = "UserPosition"
        '
        'UserUsername
        '
        Me.UserUsername.HeaderText = "Username"
        Me.UserUsername.Name = "UserUsername"
        '
        'UserPassword
        '
        Me.UserPassword.HeaderText = "Password"
        Me.UserPassword.Name = "UserPassword"
        '
        'UserEdit
        '
        Me.UserEdit.HeaderText = "Edit"
        Me.UserEdit.Name = "UserEdit"
        '
        'UserDelete
        '
        Me.UserDelete.HeaderText = "Delete"
        Me.UserDelete.Name = "UserDelete"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Teal
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(-1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(941, 44)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "MANAGE USER"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FontDialog1
        '
        '
        'btnAddUser
        '
        Me.btnAddUser.BackColor = System.Drawing.Color.Teal
        Me.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddUser.ForeColor = System.Drawing.SystemColors.Control
        Me.btnAddUser.Location = New System.Drawing.Point(760, 56)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnAddUser.Size = New System.Drawing.Size(168, 43)
        Me.btnAddUser.TabIndex = 3
        Me.btnAddUser.Text = "Add User Account"
        Me.btnAddUser.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Teal
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(716, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 18)
        Me.Label2.TabIndex = 383
        Me.Label2.Text = "------------------------------------"
        '
        'Timer1
        '
        '
        'AccountUserManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 746)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAddUser)
        Me.Controls.Add(Me.datagridManageUser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AccountUserManagement"
        Me.Text = "Form2"
        CType(Me.datagridManageUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents datagridManageUser As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents btnAddUser As Button
    Friend WithEvents UserID As DataGridViewTextBoxColumn
    Friend WithEvents UserSurname As DataGridViewTextBoxColumn
    Friend WithEvents UserFirstName As DataGridViewTextBoxColumn
    Friend WithEvents UserMiddleName As DataGridViewTextBoxColumn
    Friend WithEvents UserPosition As DataGridViewTextBoxColumn
    Friend WithEvents UserUsername As DataGridViewTextBoxColumn
    Friend WithEvents UserPassword As DataGridViewTextBoxColumn
    Friend WithEvents UserEdit As DataGridViewTextBoxColumn
    Friend WithEvents UserDelete As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
End Class
