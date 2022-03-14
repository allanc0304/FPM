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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.UserID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserSurname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserFirstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserMiddleName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserPosition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserUsername = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserPassword = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserEdit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserDelete = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserID, Me.UserSurname, Me.UserFirstName, Me.UserMiddleName, Me.UserPosition, Me.UserUsername, Me.UserPassword, Me.UserEdit, Me.UserDelete})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 119)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(916, 606)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
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
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(853, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "[ CLOSE ]"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(790, 61)
        Me.Button2.Name = "Button2"
        Me.Button2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button2.Size = New System.Drawing.Size(138, 43)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Add User Account"
        Me.Button2.UseVisualStyleBackColor = True
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
        'AccountUserManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 746)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AccountUserManagement"
        Me.Text = "Form2"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents UserID As DataGridViewTextBoxColumn
    Friend WithEvents UserSurname As DataGridViewTextBoxColumn
    Friend WithEvents UserFirstName As DataGridViewTextBoxColumn
    Friend WithEvents UserMiddleName As DataGridViewTextBoxColumn
    Friend WithEvents UserPosition As DataGridViewTextBoxColumn
    Friend WithEvents UserUsername As DataGridViewTextBoxColumn
    Friend WithEvents UserPassword As DataGridViewTextBoxColumn
    Friend WithEvents UserEdit As DataGridViewTextBoxColumn
    Friend WithEvents UserDelete As DataGridViewTextBoxColumn
End Class
