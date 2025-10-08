<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fLG
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.gc = New System.Windows.Forms.Label()
        Me.btCRE = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPASS = New QLSVV.RoundedTextBox()
        Me.txtTK = New QLSVV.RoundedTextBox()
        Me.lQP = New System.Windows.Forms.LinkLabel()
        Me.btLG = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Controls.Add(Me.gc)
        Me.GroupBox1.Controls.Add(Me.btCRE)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtPASS)
        Me.GroupBox1.Controls.Add(Me.txtTK)
        Me.GroupBox1.Controls.Add(Me.lQP)
        Me.GroupBox1.Controls.Add(Me.btLG)
        Me.GroupBox1.Location = New System.Drawing.Point(698, 110)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(437, 353)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'gc
        '
        Me.gc.AutoSize = True
        Me.gc.BackColor = System.Drawing.SystemColors.ControlDark
        Me.gc.ForeColor = System.Drawing.Color.White
        Me.gc.Location = New System.Drawing.Point(407, 10)
        Me.gc.Name = "gc"
        Me.gc.Size = New System.Drawing.Size(14, 16)
        Me.gc.TabIndex = 9
        Me.gc.Text = "?"
        Me.ToolTip1.SetToolTip(Me.gc, "TK thử :           " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     Test01 p: 123456" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     T2 p: 123" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     T3 p: 123" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'btCRE
        '
        Me.btCRE.BackColor = System.Drawing.Color.LimeGreen
        Me.btCRE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCRE.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCRE.ForeColor = System.Drawing.Color.White
        Me.btCRE.Location = New System.Drawing.Point(117, 282)
        Me.btCRE.Name = "btCRE"
        Me.btCRE.Size = New System.Drawing.Size(201, 47)
        Me.btCRE.TabIndex = 8
        Me.btCRE.Text = "Tạo tài khoản"
        Me.btCRE.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.DarkGray
        Me.Label4.Location = New System.Drawing.Point(19, 263)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(398, 1)
        Me.Label4.TabIndex = 7
        '
        'txtPASS
        '
        Me.txtPASS.BackColor = System.Drawing.Color.White
        Me.txtPASS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPASS.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtPASS.ForeColor = System.Drawing.Color.Black
        Me.txtPASS.Location = New System.Drawing.Point(16, 104)
        Me.txtPASS.Name = "txtPASS"
        Me.txtPASS.PlaceholderText = "Mật khẩu"
        Me.txtPASS.Size = New System.Drawing.Size(406, 48)
        Me.txtPASS.TabIndex = 6
        Me.txtPASS.UseSystemPasswordChar = True
        '
        'txtTK
        '
        Me.txtTK.BackColor = System.Drawing.Color.White
        Me.txtTK.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTK.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtTK.ForeColor = System.Drawing.Color.Black
        Me.txtTK.Location = New System.Drawing.Point(16, 32)
        Me.txtTK.Name = "txtTK"
        Me.txtTK.PlaceholderText = "Tài khoản"
        Me.txtTK.Size = New System.Drawing.Size(406, 45)
        Me.txtTK.TabIndex = 5
        '
        'lQP
        '
        Me.lQP.AutoSize = True
        Me.lQP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lQP.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lQP.Location = New System.Drawing.Point(160, 232)
        Me.lQP.Name = "lQP"
        Me.lQP.Size = New System.Drawing.Size(120, 20)
        Me.lQP.TabIndex = 4
        Me.lQP.TabStop = True
        Me.lQP.Text = "Quên mật khẩu ?"
        '
        'btLG
        '
        Me.btLG.BackColor = System.Drawing.Color.DodgerBlue
        Me.btLG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btLG.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btLG.FlatAppearance.BorderSize = 0
        Me.btLG.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btLG.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btLG.ForeColor = System.Drawing.Color.White
        Me.btLG.Location = New System.Drawing.Point(16, 174)
        Me.btLG.Name = "btLG"
        Me.btLG.Size = New System.Drawing.Size(406, 48)
        Me.btLG.TabIndex = 3
        Me.btLG.Text = "Đăng nhập"
        Me.btLG.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label1.Location = New System.Drawing.Point(252, 164)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 62)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "QLSV"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(260, 246)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Quản lý dễ dàng hơn"
        '
        'fLG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1262, 673)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "fLG"
        Me.Text = "QLSV"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btLG As Button
    Friend WithEvents lQP As LinkLabel
    Friend WithEvents txtPASS As RoundedTextBox
    Friend WithEvents txtTK As RoundedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btCRE As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents gc As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
