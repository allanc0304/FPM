<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddSavingsDeposit
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SD_CONFIRMBTN = New System.Windows.Forms.Button()
        Me.SD_CANCELBTN = New System.Windows.Forms.Button()
        Me.SD_COLB = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SD_AD = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SD_RB = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Location = New System.Drawing.Point(233, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 20)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "Saving Deposit"
        '
        'SD_CONFIRMBTN
        '
        Me.SD_CONFIRMBTN.BackColor = System.Drawing.Color.SteelBlue
        Me.SD_CONFIRMBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SD_CONFIRMBTN.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.SD_CONFIRMBTN.Location = New System.Drawing.Point(237, 177)
        Me.SD_CONFIRMBTN.Name = "SD_CONFIRMBTN"
        Me.SD_CONFIRMBTN.Size = New System.Drawing.Size(82, 32)
        Me.SD_CONFIRMBTN.TabIndex = 83
        Me.SD_CONFIRMBTN.Text = "Confirm"
        Me.SD_CONFIRMBTN.UseVisualStyleBackColor = False
        '
        'SD_CANCELBTN
        '
        Me.SD_CANCELBTN.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.SD_CANCELBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SD_CANCELBTN.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.SD_CANCELBTN.Location = New System.Drawing.Point(149, 177)
        Me.SD_CANCELBTN.Name = "SD_CANCELBTN"
        Me.SD_CANCELBTN.Size = New System.Drawing.Size(82, 32)
        Me.SD_CANCELBTN.TabIndex = 81
        Me.SD_CANCELBTN.Text = "Cancel"
        Me.SD_CANCELBTN.UseVisualStyleBackColor = False
        '
        'SD_COLB
        '
        Me.SD_COLB.Location = New System.Drawing.Point(201, 151)
        Me.SD_COLB.Name = "SD_COLB"
        Me.SD_COLB.Size = New System.Drawing.Size(172, 20)
        Me.SD_COLB.TabIndex = 85
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(77, 151)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 15)
        Me.Label8.TabIndex = 84
        Me.Label8.Text = "Collected by :"
        '
        'SD_AD
        '
        Me.SD_AD.Location = New System.Drawing.Point(201, 73)
        Me.SD_AD.Name = "SD_AD"
        Me.SD_AD.Size = New System.Drawing.Size(172, 20)
        Me.SD_AD.TabIndex = 82
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(73, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 15)
        Me.Label7.TabIndex = 79
        Me.Label7.Text = "Amount-Depost :"
        '
        'SD_RB
        '
        Me.SD_RB.Location = New System.Drawing.Point(201, 113)
        Me.SD_RB.Name = "SD_RB"
        Me.SD_RB.ReadOnly = True
        Me.SD_RB.Size = New System.Drawing.Size(172, 20)
        Me.SD_RB.TabIndex = 96
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(73, 113)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(122, 15)
        Me.Label10.TabIndex = 91
        Me.Label10.Text = "Remaining Balance :"
        '
        'Timer1
        '
        '
        'AddSavingsDeposit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 262)
        Me.Controls.Add(Me.SD_RB)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.SD_CONFIRMBTN)
        Me.Controls.Add(Me.SD_CANCELBTN)
        Me.Controls.Add(Me.SD_COLB)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.SD_AD)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AddSavingsDeposit"
        Me.Text = "AddSavingsDeposit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents SD_CONFIRMBTN As Button
    Friend WithEvents SD_CANCELBTN As Button
    Friend WithEvents SD_COLB As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents SD_AD As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents SD_RB As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Timer1 As Timer
End Class
