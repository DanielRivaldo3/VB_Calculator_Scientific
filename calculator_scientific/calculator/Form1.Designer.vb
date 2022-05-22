<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class scientific_calculator
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
        Me.txt_history_entry = New System.Windows.Forms.TextBox()
        Me.txt_entry = New System.Windows.Forms.TextBox()
        Me.btn_ce = New System.Windows.Forms.Button()
        Me.btn_7 = New System.Windows.Forms.Button()
        Me.btn_4 = New System.Windows.Forms.Button()
        Me.btn_1 = New System.Windows.Forms.Button()
        Me.btn_2 = New System.Windows.Forms.Button()
        Me.btn_5 = New System.Windows.Forms.Button()
        Me.btn_8 = New System.Windows.Forms.Button()
        Me.btn_c = New System.Windows.Forms.Button()
        Me.btn_3 = New System.Windows.Forms.Button()
        Me.btn_6 = New System.Windows.Forms.Button()
        Me.btn_9 = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_plus = New System.Windows.Forms.Button()
        Me.btn_minus = New System.Windows.Forms.Button()
        Me.btn_multiple = New System.Windows.Forms.Button()
        Me.btn_divide = New System.Windows.Forms.Button()
        Me.btn_0 = New System.Windows.Forms.Button()
        Me.btn_equals = New System.Windows.Forms.Button()
        Me.btn_dot = New System.Windows.Forms.Button()
        Me.btn_sin = New System.Windows.Forms.Button()
        Me.btn_cos = New System.Windows.Forms.Button()
        Me.btn_tan = New System.Windows.Forms.Button()
        Me.btn_log = New System.Windows.Forms.Button()
        Me.btn_ln = New System.Windows.Forms.Button()
        Me.btn_kuadrat = New System.Windows.Forms.Button()
        Me.btn_rootsign = New System.Windows.Forms.Button()
        Me.btn_x2 = New System.Windows.Forms.Button()
        Me.btn_factorial = New System.Windows.Forms.Button()
        Me.btn_nCr = New System.Windows.Forms.Button()
        Me.btn_mod = New System.Windows.Forms.Button()
        Me.btn_deg = New System.Windows.Forms.Button()
        Me.btn_phi = New System.Windows.Forms.Button()
        Me.btn_percent = New System.Windows.Forms.Button()
        Me.btn_e = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_history_entry
        '
        Me.txt_history_entry.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.txt_history_entry.Enabled = False
        Me.txt_history_entry.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_history_entry.Location = New System.Drawing.Point(26, 12)
        Me.txt_history_entry.Name = "txt_history_entry"
        Me.txt_history_entry.Size = New System.Drawing.Size(400, 30)
        Me.txt_history_entry.TabIndex = 0
        Me.txt_history_entry.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_entry
        '
        Me.txt_entry.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.txt_entry.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_entry.Location = New System.Drawing.Point(26, 58)
        Me.txt_entry.Name = "txt_entry"
        Me.txt_entry.Size = New System.Drawing.Size(400, 43)
        Me.txt_entry.TabIndex = 1
        Me.txt_entry.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_ce
        '
        Me.btn_ce.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_ce.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ce.Location = New System.Drawing.Point(278, 371)
        Me.btn_ce.Name = "btn_ce"
        Me.btn_ce.Size = New System.Drawing.Size(67, 35)
        Me.btn_ce.TabIndex = 2
        Me.btn_ce.Text = "CE"
        Me.btn_ce.UseVisualStyleBackColor = False
        '
        'btn_7
        '
        Me.btn_7.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_7.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_7.Location = New System.Drawing.Point(18, 250)
        Me.btn_7.Name = "btn_7"
        Me.btn_7.Size = New System.Drawing.Size(67, 35)
        Me.btn_7.TabIndex = 3
        Me.btn_7.Text = "7"
        Me.btn_7.UseVisualStyleBackColor = False
        '
        'btn_4
        '
        Me.btn_4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_4.Location = New System.Drawing.Point(18, 291)
        Me.btn_4.Name = "btn_4"
        Me.btn_4.Size = New System.Drawing.Size(67, 35)
        Me.btn_4.TabIndex = 4
        Me.btn_4.Text = "4"
        Me.btn_4.UseVisualStyleBackColor = False
        '
        'btn_1
        '
        Me.btn_1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_1.Location = New System.Drawing.Point(18, 332)
        Me.btn_1.Name = "btn_1"
        Me.btn_1.Size = New System.Drawing.Size(67, 35)
        Me.btn_1.TabIndex = 5
        Me.btn_1.Text = "1"
        Me.btn_1.UseVisualStyleBackColor = False
        '
        'btn_2
        '
        Me.btn_2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_2.Location = New System.Drawing.Point(105, 332)
        Me.btn_2.Name = "btn_2"
        Me.btn_2.Size = New System.Drawing.Size(67, 35)
        Me.btn_2.TabIndex = 9
        Me.btn_2.Text = "2"
        Me.btn_2.UseVisualStyleBackColor = False
        '
        'btn_5
        '
        Me.btn_5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_5.Location = New System.Drawing.Point(105, 291)
        Me.btn_5.Name = "btn_5"
        Me.btn_5.Size = New System.Drawing.Size(67, 35)
        Me.btn_5.TabIndex = 8
        Me.btn_5.Text = "5"
        Me.btn_5.UseVisualStyleBackColor = False
        '
        'btn_8
        '
        Me.btn_8.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_8.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_8.Location = New System.Drawing.Point(105, 250)
        Me.btn_8.Name = "btn_8"
        Me.btn_8.Size = New System.Drawing.Size(67, 35)
        Me.btn_8.TabIndex = 7
        Me.btn_8.Text = "8"
        Me.btn_8.UseVisualStyleBackColor = False
        '
        'btn_c
        '
        Me.btn_c.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_c.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_c.Location = New System.Drawing.Point(363, 250)
        Me.btn_c.Name = "btn_c"
        Me.btn_c.Size = New System.Drawing.Size(67, 35)
        Me.btn_c.TabIndex = 6
        Me.btn_c.Text = "C"
        Me.btn_c.UseVisualStyleBackColor = False
        '
        'btn_3
        '
        Me.btn_3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_3.Location = New System.Drawing.Point(191, 332)
        Me.btn_3.Name = "btn_3"
        Me.btn_3.Size = New System.Drawing.Size(67, 35)
        Me.btn_3.TabIndex = 13
        Me.btn_3.Text = "3"
        Me.btn_3.UseVisualStyleBackColor = False
        '
        'btn_6
        '
        Me.btn_6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_6.Location = New System.Drawing.Point(191, 291)
        Me.btn_6.Name = "btn_6"
        Me.btn_6.Size = New System.Drawing.Size(67, 35)
        Me.btn_6.TabIndex = 12
        Me.btn_6.Text = "6"
        Me.btn_6.UseVisualStyleBackColor = False
        '
        'btn_9
        '
        Me.btn_9.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_9.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_9.Location = New System.Drawing.Point(191, 250)
        Me.btn_9.Name = "btn_9"
        Me.btn_9.Size = New System.Drawing.Size(67, 35)
        Me.btn_9.TabIndex = 11
        Me.btn_9.Text = "9"
        Me.btn_9.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_delete.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(278, 250)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(67, 35)
        Me.btn_delete.TabIndex = 10
        Me.btn_delete.Text = "Del"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_plus
        '
        Me.btn_plus.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_plus.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_plus.Location = New System.Drawing.Point(278, 332)
        Me.btn_plus.Name = "btn_plus"
        Me.btn_plus.Size = New System.Drawing.Size(67, 35)
        Me.btn_plus.TabIndex = 17
        Me.btn_plus.Text = "+"
        Me.btn_plus.UseVisualStyleBackColor = False
        '
        'btn_minus
        '
        Me.btn_minus.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_minus.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_minus.Location = New System.Drawing.Point(363, 331)
        Me.btn_minus.Name = "btn_minus"
        Me.btn_minus.Size = New System.Drawing.Size(67, 35)
        Me.btn_minus.TabIndex = 16
        Me.btn_minus.Text = "-"
        Me.btn_minus.UseVisualStyleBackColor = False
        '
        'btn_multiple
        '
        Me.btn_multiple.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_multiple.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_multiple.Location = New System.Drawing.Point(278, 290)
        Me.btn_multiple.Name = "btn_multiple"
        Me.btn_multiple.Size = New System.Drawing.Size(67, 35)
        Me.btn_multiple.TabIndex = 15
        Me.btn_multiple.Text = "x"
        Me.btn_multiple.UseVisualStyleBackColor = False
        '
        'btn_divide
        '
        Me.btn_divide.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_divide.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_divide.Location = New System.Drawing.Point(363, 291)
        Me.btn_divide.Name = "btn_divide"
        Me.btn_divide.Size = New System.Drawing.Size(67, 35)
        Me.btn_divide.TabIndex = 14
        Me.btn_divide.Text = "/"
        Me.btn_divide.UseVisualStyleBackColor = False
        '
        'btn_0
        '
        Me.btn_0.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_0.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_0.Location = New System.Drawing.Point(18, 373)
        Me.btn_0.Name = "btn_0"
        Me.btn_0.Size = New System.Drawing.Size(154, 35)
        Me.btn_0.TabIndex = 18
        Me.btn_0.Text = "0"
        Me.btn_0.UseVisualStyleBackColor = False
        '
        'btn_equals
        '
        Me.btn_equals.BackColor = System.Drawing.Color.Lime
        Me.btn_equals.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_equals.Location = New System.Drawing.Point(363, 372)
        Me.btn_equals.Name = "btn_equals"
        Me.btn_equals.Size = New System.Drawing.Size(67, 35)
        Me.btn_equals.TabIndex = 20
        Me.btn_equals.Text = "="
        Me.btn_equals.UseVisualStyleBackColor = False
        '
        'btn_dot
        '
        Me.btn_dot.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_dot.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_dot.Location = New System.Drawing.Point(191, 373)
        Me.btn_dot.Name = "btn_dot"
        Me.btn_dot.Size = New System.Drawing.Size(67, 35)
        Me.btn_dot.TabIndex = 19
        Me.btn_dot.Text = "."
        Me.btn_dot.UseVisualStyleBackColor = False
        '
        'btn_sin
        '
        Me.btn_sin.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sin.Location = New System.Drawing.Point(18, 209)
        Me.btn_sin.Name = "btn_sin"
        Me.btn_sin.Size = New System.Drawing.Size(67, 35)
        Me.btn_sin.TabIndex = 21
        Me.btn_sin.Text = "Sin"
        Me.btn_sin.UseVisualStyleBackColor = True
        '
        'btn_cos
        '
        Me.btn_cos.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cos.Location = New System.Drawing.Point(105, 209)
        Me.btn_cos.Name = "btn_cos"
        Me.btn_cos.Size = New System.Drawing.Size(67, 35)
        Me.btn_cos.TabIndex = 22
        Me.btn_cos.Text = "Cos"
        Me.btn_cos.UseVisualStyleBackColor = True
        '
        'btn_tan
        '
        Me.btn_tan.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_tan.Location = New System.Drawing.Point(191, 209)
        Me.btn_tan.Name = "btn_tan"
        Me.btn_tan.Size = New System.Drawing.Size(67, 35)
        Me.btn_tan.TabIndex = 23
        Me.btn_tan.Text = "Tan"
        Me.btn_tan.UseVisualStyleBackColor = True
        '
        'btn_log
        '
        Me.btn_log.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_log.Location = New System.Drawing.Point(363, 209)
        Me.btn_log.Name = "btn_log"
        Me.btn_log.Size = New System.Drawing.Size(67, 35)
        Me.btn_log.TabIndex = 24
        Me.btn_log.Text = "Log"
        Me.btn_log.UseVisualStyleBackColor = True
        '
        'btn_ln
        '
        Me.btn_ln.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ln.Location = New System.Drawing.Point(278, 209)
        Me.btn_ln.Name = "btn_ln"
        Me.btn_ln.Size = New System.Drawing.Size(67, 35)
        Me.btn_ln.TabIndex = 25
        Me.btn_ln.Text = "ln"
        Me.btn_ln.UseVisualStyleBackColor = True
        '
        'btn_kuadrat
        '
        Me.btn_kuadrat.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_kuadrat.Location = New System.Drawing.Point(363, 127)
        Me.btn_kuadrat.Name = "btn_kuadrat"
        Me.btn_kuadrat.Size = New System.Drawing.Size(67, 35)
        Me.btn_kuadrat.TabIndex = 26
        Me.btn_kuadrat.Text = "^"
        Me.btn_kuadrat.UseVisualStyleBackColor = True
        '
        'btn_rootsign
        '
        Me.btn_rootsign.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_rootsign.Location = New System.Drawing.Point(363, 168)
        Me.btn_rootsign.Name = "btn_rootsign"
        Me.btn_rootsign.Size = New System.Drawing.Size(67, 35)
        Me.btn_rootsign.TabIndex = 27
        Me.btn_rootsign.Text = "√"
        Me.btn_rootsign.UseVisualStyleBackColor = True
        '
        'btn_x2
        '
        Me.btn_x2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_x2.Location = New System.Drawing.Point(105, 127)
        Me.btn_x2.Name = "btn_x2"
        Me.btn_x2.Size = New System.Drawing.Size(67, 35)
        Me.btn_x2.TabIndex = 28
        Me.btn_x2.Text = "x^2"
        Me.btn_x2.UseVisualStyleBackColor = True
        '
        'btn_factorial
        '
        Me.btn_factorial.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_factorial.Location = New System.Drawing.Point(278, 127)
        Me.btn_factorial.Name = "btn_factorial"
        Me.btn_factorial.Size = New System.Drawing.Size(67, 35)
        Me.btn_factorial.TabIndex = 29
        Me.btn_factorial.Text = "x!"
        Me.btn_factorial.UseVisualStyleBackColor = True
        '
        'btn_nCr
        '
        Me.btn_nCr.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nCr.Location = New System.Drawing.Point(191, 127)
        Me.btn_nCr.Name = "btn_nCr"
        Me.btn_nCr.Size = New System.Drawing.Size(67, 35)
        Me.btn_nCr.TabIndex = 30
        Me.btn_nCr.Text = "nCr"
        Me.btn_nCr.UseVisualStyleBackColor = True
        '
        'btn_mod
        '
        Me.btn_mod.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mod.Location = New System.Drawing.Point(18, 127)
        Me.btn_mod.Name = "btn_mod"
        Me.btn_mod.Size = New System.Drawing.Size(67, 35)
        Me.btn_mod.TabIndex = 31
        Me.btn_mod.Text = "Mod"
        Me.btn_mod.UseVisualStyleBackColor = True
        '
        'btn_deg
        '
        Me.btn_deg.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_deg.Location = New System.Drawing.Point(18, 168)
        Me.btn_deg.Name = "btn_deg"
        Me.btn_deg.Size = New System.Drawing.Size(67, 35)
        Me.btn_deg.TabIndex = 32
        Me.btn_deg.Text = "Deg"
        Me.btn_deg.UseVisualStyleBackColor = True
        '
        'btn_phi
        '
        Me.btn_phi.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_phi.Location = New System.Drawing.Point(105, 168)
        Me.btn_phi.Name = "btn_phi"
        Me.btn_phi.Size = New System.Drawing.Size(67, 35)
        Me.btn_phi.TabIndex = 33
        Me.btn_phi.Text = "π"
        Me.btn_phi.UseVisualStyleBackColor = True
        '
        'btn_percent
        '
        Me.btn_percent.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_percent.Location = New System.Drawing.Point(278, 168)
        Me.btn_percent.Name = "btn_percent"
        Me.btn_percent.Size = New System.Drawing.Size(67, 35)
        Me.btn_percent.TabIndex = 34
        Me.btn_percent.Text = "%"
        Me.btn_percent.UseVisualStyleBackColor = True
        '
        'btn_e
        '
        Me.btn_e.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_e.Location = New System.Drawing.Point(191, 168)
        Me.btn_e.Name = "btn_e"
        Me.btn_e.Size = New System.Drawing.Size(67, 35)
        Me.btn_e.TabIndex = 35
        Me.btn_e.Text = "e"
        Me.btn_e.UseVisualStyleBackColor = True
        '
        'scientific_calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(450, 415)
        Me.Controls.Add(Me.btn_e)
        Me.Controls.Add(Me.btn_percent)
        Me.Controls.Add(Me.btn_phi)
        Me.Controls.Add(Me.btn_deg)
        Me.Controls.Add(Me.btn_mod)
        Me.Controls.Add(Me.btn_nCr)
        Me.Controls.Add(Me.btn_factorial)
        Me.Controls.Add(Me.btn_x2)
        Me.Controls.Add(Me.btn_rootsign)
        Me.Controls.Add(Me.btn_kuadrat)
        Me.Controls.Add(Me.btn_ln)
        Me.Controls.Add(Me.btn_log)
        Me.Controls.Add(Me.btn_tan)
        Me.Controls.Add(Me.btn_cos)
        Me.Controls.Add(Me.btn_sin)
        Me.Controls.Add(Me.btn_equals)
        Me.Controls.Add(Me.btn_dot)
        Me.Controls.Add(Me.btn_0)
        Me.Controls.Add(Me.btn_plus)
        Me.Controls.Add(Me.btn_minus)
        Me.Controls.Add(Me.btn_multiple)
        Me.Controls.Add(Me.btn_divide)
        Me.Controls.Add(Me.btn_3)
        Me.Controls.Add(Me.btn_6)
        Me.Controls.Add(Me.btn_9)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_2)
        Me.Controls.Add(Me.btn_5)
        Me.Controls.Add(Me.btn_8)
        Me.Controls.Add(Me.btn_c)
        Me.Controls.Add(Me.btn_1)
        Me.Controls.Add(Me.btn_4)
        Me.Controls.Add(Me.btn_7)
        Me.Controls.Add(Me.btn_ce)
        Me.Controls.Add(Me.txt_entry)
        Me.Controls.Add(Me.txt_history_entry)
        Me.Name = "scientific_calculator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Scientific Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_history_entry As System.Windows.Forms.TextBox
    Friend WithEvents txt_entry As System.Windows.Forms.TextBox
    Friend WithEvents btn_ce As System.Windows.Forms.Button
    Friend WithEvents btn_7 As System.Windows.Forms.Button
    Friend WithEvents btn_4 As System.Windows.Forms.Button
    Friend WithEvents btn_1 As System.Windows.Forms.Button
    Friend WithEvents btn_2 As System.Windows.Forms.Button
    Friend WithEvents btn_5 As System.Windows.Forms.Button
    Friend WithEvents btn_8 As System.Windows.Forms.Button
    Friend WithEvents btn_c As System.Windows.Forms.Button
    Friend WithEvents btn_3 As System.Windows.Forms.Button
    Friend WithEvents btn_6 As System.Windows.Forms.Button
    Friend WithEvents btn_9 As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_plus As System.Windows.Forms.Button
    Friend WithEvents btn_minus As System.Windows.Forms.Button
    Friend WithEvents btn_multiple As System.Windows.Forms.Button
    Friend WithEvents btn_divide As System.Windows.Forms.Button
    Friend WithEvents btn_0 As System.Windows.Forms.Button
    Friend WithEvents btn_equals As System.Windows.Forms.Button
    Friend WithEvents btn_dot As System.Windows.Forms.Button
    Friend WithEvents btn_sin As System.Windows.Forms.Button
    Friend WithEvents btn_cos As System.Windows.Forms.Button
    Friend WithEvents btn_tan As System.Windows.Forms.Button
    Friend WithEvents btn_log As System.Windows.Forms.Button
    Friend WithEvents btn_ln As System.Windows.Forms.Button
    Friend WithEvents btn_kuadrat As System.Windows.Forms.Button
    Friend WithEvents btn_rootsign As System.Windows.Forms.Button
    Friend WithEvents btn_x2 As System.Windows.Forms.Button
    Friend WithEvents btn_factorial As System.Windows.Forms.Button
    Friend WithEvents btn_nCr As System.Windows.Forms.Button
    Friend WithEvents btn_mod As System.Windows.Forms.Button
    Friend WithEvents btn_deg As System.Windows.Forms.Button
    Friend WithEvents btn_phi As System.Windows.Forms.Button
    Friend WithEvents btn_percent As System.Windows.Forms.Button
    Friend WithEvents btn_e As System.Windows.Forms.Button

End Class
