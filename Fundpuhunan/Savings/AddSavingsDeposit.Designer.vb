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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SD_CONFIRMBTN = New System.Windows.Forms.Button()
        Me.SD_CANCELBTN = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.SD_COLB = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SD_AD = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SD_RB = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Location = New System.Drawing.Point(71, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 20)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "Saving Deposit"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(-15, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(896, 16)
        Me.Label6.TabIndex = 76
        Me.Label6.Text = "_________________________________________________________________________________" &
    "______________________________________________"
        '
        'SD_CONFIRMBTN
        '
        Me.SD_CONFIRMBTN.BackColor = System.Drawing.Color.SteelBlue
        Me.SD_CONFIRMBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SD_CONFIRMBTN.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.SD_CONFIRMBTN.Location = New System.Drawing.Point(224, 256)
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
        Me.SD_CANCELBTN.Location = New System.Drawing.Point(136, 256)
        Me.SD_CANCELBTN.Name = "SD_CANCELBTN"
        Me.SD_CANCELBTN.Size = New System.Drawing.Size(82, 32)
        Me.SD_CANCELBTN.TabIndex = 81
        Me.SD_CANCELBTN.Text = "Cancel"
        Me.SD_CANCELBTN.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(162, 188)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(59, 9)
        Me.Label18.TabIndex = 90
        Me.Label18.Text = "( FULL NAME )"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(174, 110)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 9)
        Me.Label12.TabIndex = 88
        Me.Label12.Text = "( ex. 10,000)"
        '
        'SD_COLB
        '
        Me.SD_COLB.Location = New System.Drawing.Point(143, 200)
        Me.SD_COLB.Name = "SD_COLB"
        Me.SD_COLB.Size = New System.Drawing.Size(118, 20)
        Me.SD_COLB.TabIndex = 85
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(19, 200)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 15)
        Me.Label8.TabIndex = 84
        Me.Label8.Text = "Collected by :"
        '
        'SD_AD
        '
        Me.SD_AD.Location = New System.Drawing.Point(143, 122)
        Me.SD_AD.Name = "SD_AD"
        Me.SD_AD.Size = New System.Drawing.Size(118, 20)
        Me.SD_AD.TabIndex = 82
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(15, 127)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 15)
        Me.Label7.TabIndex = 79
        Me.Label7.Text = "Amount-Depost :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(19, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 15)
        Me.Label5.TabIndex = 77
        Me.Label5.Text = "Date :"
        '
        'SD_RB
        '
        Me.SD_RB.Location = New System.Drawing.Point(143, 162)
        Me.SD_RB.Name = "SD_RB"
        Me.SD_RB.ReadOnly = True
        Me.SD_RB.Size = New System.Drawing.Size(118, 20)
        Me.SD_RB.TabIndex = 96
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(174, 150)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 9)
        Me.Label9.TabIndex = 92
        Me.Label9.Text = "( ex. 20,000 )"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(15, 162)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(122, 15)
        Me.Label10.TabIndex = 91
        Me.Label10.Text = "Remaining Balance :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(140, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 97
        Me.Label2.Text = "------------------------------"
        '
        'Timer1
        '
        '
        'AddSavingsDeposit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 300)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SD_RB)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.SD_CONFIRMBTN)
        Me.Controls.Add(Me.SD_CANCELBTN)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.SD_COLB)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.SD_AD)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Name = "AddSavingsDeposit"
        Me.Text = "AddSavingsDeposit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents SD_CONFIRMBTN As Button
    Friend WithEvents SD_CANCELBTN As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents SD_COLB As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents SD_AD As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents SD_RB As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
End Class
