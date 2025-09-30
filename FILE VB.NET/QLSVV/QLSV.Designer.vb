<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.dgSV = New System.Windows.Forms.DataGridView()
        Me.btxoa = New System.Windows.Forms.Button()
        Me.btsua = New System.Windows.Forms.Button()
        Me.btthem = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbthuhep = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboKHOA = New System.Windows.Forms.ComboBox()
        Me.cboNGANH = New System.Windows.Forms.ComboBox()
        Me.gbtim = New System.Windows.Forms.GroupBox()
        Me.txtTIM = New System.Windows.Forms.TextBox()
        Me.cboTIM = New System.Windows.Forms.ComboBox()
        Me.Gbcn = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgSV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbthuhep.SuspendLayout()
        Me.gbtim.SuspendLayout()
        Me.Gbcn.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgSV
        '
        Me.dgSV.AllowUserToAddRows = False
        Me.dgSV.AllowUserToDeleteRows = False
        Me.dgSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSV.Location = New System.Drawing.Point(292, 238)
        Me.dgSV.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgSV.MultiSelect = False
        Me.dgSV.Name = "dgSV"
        Me.dgSV.ReadOnly = True
        Me.dgSV.RowHeadersWidth = 51
        Me.dgSV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgSV.Size = New System.Drawing.Size(818, 302)
        Me.dgSV.TabIndex = 0
        '
        'btxoa
        '
        Me.btxoa.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btxoa.Location = New System.Drawing.Point(9, 101)
        Me.btxoa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btxoa.Name = "btxoa"
        Me.btxoa.Size = New System.Drawing.Size(125, 35)
        Me.btxoa.TabIndex = 3
        Me.btxoa.Text = "Xóa"
        Me.btxoa.UseVisualStyleBackColor = True
        '
        'btsua
        '
        Me.btsua.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btsua.Location = New System.Drawing.Point(9, 61)
        Me.btsua.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btsua.Name = "btsua"
        Me.btsua.Size = New System.Drawing.Size(125, 35)
        Me.btsua.TabIndex = 4
        Me.btsua.Text = "Sửa"
        Me.btsua.UseVisualStyleBackColor = True
        '
        'btthem
        '
        Me.btthem.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btthem.Location = New System.Drawing.Point(9, 21)
        Me.btthem.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btthem.Name = "btthem"
        Me.btthem.Size = New System.Drawing.Size(125, 35)
        Me.btthem.TabIndex = 5
        Me.btthem.Text = "Thêm"
        Me.btthem.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(292, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(278, 28)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Hệ thống quản lý sinh viên"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(292, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(828, 8)
        Me.Label2.TabIndex = 8
        '
        'gbthuhep
        '
        Me.gbthuhep.Controls.Add(Me.Label4)
        Me.gbthuhep.Controls.Add(Me.Label3)
        Me.gbthuhep.Controls.Add(Me.cboKHOA)
        Me.gbthuhep.Controls.Add(Me.cboNGANH)
        Me.gbthuhep.Location = New System.Drawing.Point(654, 64)
        Me.gbthuhep.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbthuhep.Name = "gbthuhep"
        Me.gbthuhep.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbthuhep.Size = New System.Drawing.Size(330, 154)
        Me.gbthuhep.TabIndex = 9
        Me.gbthuhep.TabStop = False
        Me.gbthuhep.Text = "Thu hẹp theo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(21, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Khóa:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label3.Location = New System.Drawing.Point(21, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ngành:"
        '
        'cboKHOA
        '
        Me.cboKHOA.FormattingEnabled = True
        Me.cboKHOA.Location = New System.Drawing.Point(21, 114)
        Me.cboKHOA.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboKHOA.Name = "cboKHOA"
        Me.cboKHOA.Size = New System.Drawing.Size(269, 24)
        Me.cboKHOA.TabIndex = 1
        '
        'cboNGANH
        '
        Me.cboNGANH.FormattingEnabled = True
        Me.cboNGANH.Location = New System.Drawing.Point(21, 53)
        Me.cboNGANH.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboNGANH.Name = "cboNGANH"
        Me.cboNGANH.Size = New System.Drawing.Size(269, 24)
        Me.cboNGANH.TabIndex = 0
        '
        'gbtim
        '
        Me.gbtim.Controls.Add(Me.txtTIM)
        Me.gbtim.Controls.Add(Me.cboTIM)
        Me.gbtim.Location = New System.Drawing.Point(304, 63)
        Me.gbtim.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbtim.Name = "gbtim"
        Me.gbtim.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbtim.Size = New System.Drawing.Size(303, 155)
        Me.gbtim.TabIndex = 10
        Me.gbtim.TabStop = False
        Me.gbtim.Text = "Tìm kiếm"
        '
        'txtTIM
        '
        Me.txtTIM.Location = New System.Drawing.Point(19, 82)
        Me.txtTIM.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTIM.Name = "txtTIM"
        Me.txtTIM.Size = New System.Drawing.Size(226, 22)
        Me.txtTIM.TabIndex = 1
        '
        'cboTIM
        '
        Me.cboTIM.FormattingEnabled = True
        Me.cboTIM.Location = New System.Drawing.Point(19, 45)
        Me.cboTIM.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboTIM.Name = "cboTIM"
        Me.cboTIM.Size = New System.Drawing.Size(151, 24)
        Me.cboTIM.TabIndex = 0
        '
        'Gbcn
        '
        Me.Gbcn.Controls.Add(Me.btthem)
        Me.Gbcn.Controls.Add(Me.btsua)
        Me.Gbcn.Controls.Add(Me.btxoa)
        Me.Gbcn.Location = New System.Drawing.Point(12, 146)
        Me.Gbcn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Gbcn.Name = "Gbcn"
        Me.Gbcn.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Gbcn.Size = New System.Drawing.Size(196, 146)
        Me.Gbcn.TabIndex = 11
        Me.Gbcn.TabStop = False
        Me.Gbcn.Text = "Chức năng"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(274, 134)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1122, 550)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Gbcn)
        Me.Controls.Add(Me.gbtim)
        Me.Controls.Add(Me.gbthuhep)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgSV)
        Me.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Quản lý sinh viên"
        CType(Me.dgSV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbthuhep.ResumeLayout(False)
        Me.gbthuhep.PerformLayout()
        Me.gbtim.ResumeLayout(False)
        Me.gbtim.PerformLayout()
        Me.Gbcn.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgSV As DataGridView
    Friend WithEvents btxoa As Button
    Friend WithEvents btsua As Button
    Friend WithEvents btthem As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents gbthuhep As GroupBox
    Friend WithEvents gbtim As GroupBox
    Friend WithEvents Gbcn As GroupBox
    Friend WithEvents cboKHOA As ComboBox
    Friend WithEvents cboNGANH As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboTIM As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTIM As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
