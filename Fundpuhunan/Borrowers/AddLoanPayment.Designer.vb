<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddLoanPayment
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
        Me.AP_PEN = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.AP_CONFIRMBTN = New System.Windows.Forms.Button()
        Me.AP_CANCELBTN = New System.Windows.Forms.Button()
        Me.AP_COLB = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.AP_EA = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.AP_CB = New System.Windows.Forms.TextBox()
        Me.AP_REM = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'AP_PEN
        '
        Me.AP_PEN.Location = New System.Drawing.Point(148, 152)
        Me.AP_PEN.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.AP_PEN.Name = "AP_PEN"
        Me.AP_PEN.Size = New System.Drawing.Size(208, 23)
        Me.AP_PEN.TabIndex = 64
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(63, 155)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(75, 15)
        Me.Label22.TabIndex = 63
        Me.Label22.Text = "Penalties :"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(72, 123)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(64, 15)
        Me.Label19.TabIndex = 60
        Me.Label19.Text = "Remark :"
        '
        'AP_CONFIRMBTN
        '
        Me.AP_CONFIRMBTN.BackColor = System.Drawing.Color.Green
        Me.AP_CONFIRMBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AP_CONFIRMBTN.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.AP_CONFIRMBTN.Location = New System.Drawing.Point(258, 210)
        Me.AP_CONFIRMBTN.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.AP_CONFIRMBTN.Name = "AP_CONFIRMBTN"
        Me.AP_CONFIRMBTN.Size = New System.Drawing.Size(98, 34)
        Me.AP_CONFIRMBTN.TabIndex = 55
        Me.AP_CONFIRMBTN.Text = "Confirm"
        Me.AP_CONFIRMBTN.UseVisualStyleBackColor = False
        '
        'AP_CANCELBTN
        '
        Me.AP_CANCELBTN.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.AP_CANCELBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AP_CANCELBTN.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.AP_CANCELBTN.Location = New System.Drawing.Point(149, 210)
        Me.AP_CANCELBTN.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.AP_CANCELBTN.Name = "AP_CANCELBTN"
        Me.AP_CANCELBTN.Size = New System.Drawing.Size(101, 34)
        Me.AP_CANCELBTN.TabIndex = 54
        Me.AP_CANCELBTN.Text = "Cancel"
        Me.AP_CANCELBTN.UseVisualStyleBackColor = False
        '
        'AP_COLB
        '
        Me.AP_COLB.Location = New System.Drawing.Point(147, 181)
        Me.AP_COLB.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.AP_COLB.Name = "AP_COLB"
        Me.AP_COLB.Size = New System.Drawing.Size(209, 23)
        Me.AP_COLB.TabIndex = 57
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(41, 184)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 15)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Collected by :"
        '
        'AP_EA
        '
        Me.AP_EA.Location = New System.Drawing.Point(148, 91)
        Me.AP_EA.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.AP_EA.Name = "AP_EA"
        Me.AP_EA.Size = New System.Drawing.Size(209, 23)
        Me.AP_EA.TabIndex = 53
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(42, 94)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 15)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Enter Amount:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(179, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 22)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "Add Payment"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(17, 47)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(124, 15)
        Me.Label17.TabIndex = 69
        Me.Label17.Text = "Current Balance  :"
        '
        'AP_CB
        '
        Me.AP_CB.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.AP_CB.Location = New System.Drawing.Point(149, 44)
        Me.AP_CB.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.AP_CB.Name = "AP_CB"
        Me.AP_CB.ReadOnly = True
        Me.AP_CB.Size = New System.Drawing.Size(208, 23)
        Me.AP_CB.TabIndex = 71
        '
        'AP_REM
        '
        Me.AP_REM.FormattingEnabled = True
        Me.AP_REM.Items.AddRange(New Object() {"Updated", "Overdue"})
        Me.AP_REM.Location = New System.Drawing.Point(147, 120)
        Me.AP_REM.Name = "AP_REM"
        Me.AP_REM.Size = New System.Drawing.Size(209, 23)
        Me.AP_REM.TabIndex = 74
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(365, 47)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 15)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "Php"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(364, 155)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 15)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "Php"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(365, 94)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 15)
        Me.Label4.TabIndex = 77
        Me.Label4.Text = "Php"
        '
        'AddLoanPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(504, 262)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.AP_REM)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AP_CB)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.AP_PEN)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.AP_CONFIRMBTN)
        Me.Controls.Add(Me.AP_CANCELBTN)
        Me.Controls.Add(Me.AP_COLB)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.AP_EA)
        Me.Controls.Add(Me.Label7)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddLoanPayment"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Loan Payment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AP_PEN As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents AP_CONFIRMBTN As Button
    Friend WithEvents AP_CANCELBTN As Button
    Friend WithEvents AP_COLB As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents AP_EA As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents AP_CB As TextBox
    Friend WithEvents AP_REM As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
