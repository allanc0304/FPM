<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Collections
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
        Me.collectpaymentbttn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'collectpaymentbttn
        '
        Me.collectpaymentbttn.BackColor = System.Drawing.Color.DarkOrange
        Me.collectpaymentbttn.FlatAppearance.BorderSize = 0
        Me.collectpaymentbttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.collectpaymentbttn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.collectpaymentbttn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.collectpaymentbttn.Location = New System.Drawing.Point(706, 29)
        Me.collectpaymentbttn.Name = "collectpaymentbttn"
        Me.collectpaymentbttn.Size = New System.Drawing.Size(177, 44)
        Me.collectpaymentbttn.TabIndex = 51
        Me.collectpaymentbttn.Text = "Create Collection List"
        Me.collectpaymentbttn.UseVisualStyleBackColor = False
        '
        'Collections
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 761)
        Me.Controls.Add(Me.collectpaymentbttn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Collections"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Collections"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents collectpaymentbttn As Button
End Class
