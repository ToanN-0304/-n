<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fCRE
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btCRE = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMK = New QLSVV.RoundedTextBox()
        Me.txtTK = New QLSVV.RoundedTextBox()
        Me.txtSDT = New QLSVV.RoundedTextBox()
        Me.txtM = New QLSVV.RoundedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTEN = New QLSVV.RoundedTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btCRE)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtMK)
        Me.GroupBox1.Controls.Add(Me.txtTK)
        Me.GroupBox1.Controls.Add(Me.txtSDT)
        Me.GroupBox1.Controls.Add(Me.txtM)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtTEN)
        Me.GroupBox1.Location = New System.Drawing.Point(360, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(557, 649)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btCRE
        '
        Me.btCRE.BackColor = System.Drawing.Color.LimeGreen
        Me.btCRE.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCRE.ForeColor = System.Drawing.Color.White
        Me.btCRE.Location = New System.Drawing.Point(232, 579)
        Me.btCRE.Name = "btCRE"
        Me.btCRE.Size = New System.Drawing.Size(183, 48)
        Me.btCRE.TabIndex = 12
        Me.btCRE.Text = "Tạo"
        Me.btCRE.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(30, 534)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(474, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Ghi chú : do hệ thống đang trong quá trình thử nghiệm nên có thử nhập mã bất kỳ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 269)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(213, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "// Vui lòng nhập đúng mã được cấp"
        '
        'txtMK
        '
        Me.txtMK.BackColor = System.Drawing.Color.White
        Me.txtMK.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMK.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtMK.ForeColor = System.Drawing.Color.Black
        Me.txtMK.Location = New System.Drawing.Point(43, 448)
        Me.txtMK.Name = "txtMK"
        Me.txtMK.PlaceholderText = "Mật khẩu mới"
        Me.txtMK.Size = New System.Drawing.Size(464, 53)
        Me.txtMK.TabIndex = 9
        '
        'txtTK
        '
        Me.txtTK.BackColor = System.Drawing.Color.White
        Me.txtTK.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTK.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtTK.ForeColor = System.Drawing.Color.Black
        Me.txtTK.Location = New System.Drawing.Point(43, 373)
        Me.txtTK.Name = "txtTK"
        Me.txtTK.PlaceholderText = "Tài khoản"
        Me.txtTK.Size = New System.Drawing.Size(464, 53)
        Me.txtTK.TabIndex = 8
        '
        'txtSDT
        '
        Me.txtSDT.BackColor = System.Drawing.Color.White
        Me.txtSDT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSDT.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtSDT.ForeColor = System.Drawing.Color.Black
        Me.txtSDT.Location = New System.Drawing.Point(43, 300)
        Me.txtSDT.Name = "txtSDT"
        Me.txtSDT.PlaceholderText = "Số điện thoại"
        Me.txtSDT.Size = New System.Drawing.Size(464, 53)
        Me.txtSDT.TabIndex = 7
        '
        'txtM
        '
        Me.txtM.BackColor = System.Drawing.Color.White
        Me.txtM.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtM.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtM.ForeColor = System.Drawing.Color.Black
        Me.txtM.Location = New System.Drawing.Point(43, 199)
        Me.txtM.Name = "txtM"
        Me.txtM.PlaceholderText = "Mã quản lý"
        Me.txtM.Size = New System.Drawing.Size(464, 46)
        Me.txtM.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label1.Location = New System.Drawing.Point(159, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 45)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tạo tài khoản "
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Silver
        Me.Label4.Location = New System.Drawing.Point(2, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(552, 1)
        Me.Label4.TabIndex = 2
        '
        'txtTEN
        '
        Me.txtTEN.BackColor = System.Drawing.Color.White
        Me.txtTEN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTEN.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtTEN.ForeColor = System.Drawing.Color.Black
        Me.txtTEN.Location = New System.Drawing.Point(43, 129)
        Me.txtTEN.Name = "txtTEN"
        Me.txtTEN.PlaceholderText = "Họ và tên"
        Me.txtTEN.Size = New System.Drawing.Size(464, 49)
        Me.txtTEN.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gray
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(142, 579)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 48)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Hủy"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'fCRE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1262, 673)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "fCRE"
        Me.Text = "QLSV"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtTEN As RoundedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMK As RoundedTextBox
    Friend WithEvents txtTK As RoundedTextBox
    Friend WithEvents txtSDT As RoundedTextBox
    Friend WithEvents txtM As RoundedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btCRE As Button
    Friend WithEvents Button1 As Button
End Class
