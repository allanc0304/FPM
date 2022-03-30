<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchApplication
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
        Me.cancelappbttn = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.searchappbttn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cancelappbttn
        '
        Me.cancelappbttn.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cancelappbttn.FlatAppearance.BorderSize = 0
        Me.cancelappbttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancelappbttn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelappbttn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cancelappbttn.Location = New System.Drawing.Point(68, 68)
        Me.cancelappbttn.Name = "cancelappbttn"
        Me.cancelappbttn.Size = New System.Drawing.Size(128, 28)
        Me.cancelappbttn.TabIndex = 7
        Me.cancelappbttn.Text = "Cancel"
        Me.cancelappbttn.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(32, 42)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(350, 20)
        Me.TextBox1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Enter Name of Applicant:"
        '
        'searchappbttn
        '
        Me.searchappbttn.BackColor = System.Drawing.Color.SlateGray
        Me.searchappbttn.FlatAppearance.BorderSize = 0
        Me.searchappbttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.searchappbttn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchappbttn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.searchappbttn.Location = New System.Drawing.Point(202, 68)
        Me.searchappbttn.Name = "searchappbttn"
        Me.searchappbttn.Size = New System.Drawing.Size(128, 28)
        Me.searchappbttn.TabIndex = 4
        Me.searchappbttn.Text = "Search Applicant"
        Me.searchappbttn.UseVisualStyleBackColor = False
        '
        'SearchApplication
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 126)
        Me.Controls.Add(Me.cancelappbttn)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.searchappbttn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "SearchApplication"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search Application Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cancelappbttn As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents searchappbttn As Button
End Class
