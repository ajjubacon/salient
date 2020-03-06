<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.button_a = New System.Windows.Forms.Button()
        Me.button_d = New System.Windows.Forms.Button()
        Me.button_f = New System.Windows.Forms.Button()
        Me.button_e = New System.Windows.Forms.Button()
        Me.button_c = New System.Windows.Forms.Button()
        Me.button_g = New System.Windows.Forms.Button()
        Me.button_b = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'button_a
        '
        Me.button_a.Location = New System.Drawing.Point(180, 85)
        Me.button_a.Name = "button_a"
        Me.button_a.Size = New System.Drawing.Size(101, 23)
        Me.button_a.TabIndex = 0
        Me.button_a.UseVisualStyleBackColor = True
        '
        'button_d
        '
        Me.button_d.Location = New System.Drawing.Point(180, 324)
        Me.button_d.Name = "button_d"
        Me.button_d.Size = New System.Drawing.Size(101, 23)
        Me.button_d.TabIndex = 1
        Me.button_d.UseVisualStyleBackColor = True
        '
        'button_f
        '
        Me.button_f.Location = New System.Drawing.Point(152, 111)
        Me.button_f.Name = "button_f"
        Me.button_f.Size = New System.Drawing.Size(22, 90)
        Me.button_f.TabIndex = 2
        Me.button_f.UseVisualStyleBackColor = True
        '
        'button_e
        '
        Me.button_e.Location = New System.Drawing.Point(152, 231)
        Me.button_e.Name = "button_e"
        Me.button_e.Size = New System.Drawing.Size(22, 90)
        Me.button_e.TabIndex = 3
        Me.button_e.UseVisualStyleBackColor = True
        '
        'button_c
        '
        Me.button_c.Location = New System.Drawing.Point(286, 236)
        Me.button_c.Name = "button_c"
        Me.button_c.Size = New System.Drawing.Size(22, 90)
        Me.button_c.TabIndex = 4
        Me.button_c.UseVisualStyleBackColor = True
        '
        'button_g
        '
        Me.button_g.Location = New System.Drawing.Point(180, 207)
        Me.button_g.Name = "button_g"
        Me.button_g.Size = New System.Drawing.Size(101, 23)
        Me.button_g.TabIndex = 5
        Me.button_g.UseVisualStyleBackColor = True
        '
        'button_b
        '
        Me.button_b.Location = New System.Drawing.Point(286, 114)
        Me.button_b.Name = "button_b"
        Me.button_b.Size = New System.Drawing.Size(22, 90)
        Me.button_b.TabIndex = 6
        Me.button_b.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GrayText
        Me.ClientSize = New System.Drawing.Size(468, 450)
        Me.Controls.Add(Me.button_b)
        Me.Controls.Add(Me.button_g)
        Me.Controls.Add(Me.button_c)
        Me.Controls.Add(Me.button_e)
        Me.Controls.Add(Me.button_f)
        Me.Controls.Add(Me.button_d)
        Me.Controls.Add(Me.button_a)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents button_a As Button
    Friend WithEvents button_d As Button
    Friend WithEvents button_f As Button
    Friend WithEvents button_e As Button
    Friend WithEvents button_c As Button
    Friend WithEvents button_g As Button
    Friend WithEvents button_b As Button
End Class
