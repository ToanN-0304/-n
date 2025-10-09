Imports System.Data.SqlClient
Imports System.Net

Public Class fLG
    Private _DBAccess As New DataBaseAccess

    Private Sub fLG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.WhiteSmoke
        btLG.FlatStyle = FlatStyle.Flat
        btLG.FlatAppearance.BorderSize = 0
        btLG.BackColor = Color.RoyalBlue
        btLG.ForeColor = Color.White
        btLG.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        txtTK.BorderStyle = BorderStyle.FixedSingle
        txtPASS.BorderStyle = BorderStyle.FixedSingle
        txtPASS.UseSystemPasswordChar = True
    End Sub

    Private Sub fLG_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim path As New Drawing2D.GraphicsPath()
        Dim radius As Integer = 10
        Dim rect As Rectangle = btLG.ClientRectangle

        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
        path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90)
        path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90)
        path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90)
        path.CloseAllFigures()

        btLG.Region = New Region(path)
        btCRE.Region = New Region(path)
    End Sub

    Private Sub GroupBox1_Paint(sender As Object, e As PaintEventArgs) Handles GroupBox1.Paint
        Dim gb As GroupBox = CType(sender, GroupBox)
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        Dim rect As New Rectangle(0, 7, gb.Width - 1, gb.Height - 10)
        Dim radius As Integer = 15
        Dim path As New Drawing2D.GraphicsPath()
        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
        path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90)
        path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90)
        path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90)
        path.CloseAllFigures()

        g.Clear(Me.BackColor)
        g.FillPath(New SolidBrush(gb.BackColor), path)
        g.DrawPath(New Pen(Color.LightGray, 1), path)
        g.DrawString(gb.Text, gb.Font, Brushes.Black, 15, 0)
    End Sub

    Private Sub btLG_MouseEnter(sender As Object, e As EventArgs) Handles btLG.MouseEnter
        btLG.BackColor = Color.MediumBlue
    End Sub

    Private Sub btLG_MouseLeave(sender As Object, e As EventArgs) Handles btLG.MouseLeave
        btLG.BackColor = Color.RoyalBlue
    End Sub

    Private Sub btLG_Click(sender As Object, e As EventArgs) Handles btLG.Click
        Dim tk As String = txtTK.Text.Trim()
        Dim mk As String = txtPASS.Text.Trim()

        If tk = "" Or mk = "" Then
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim sql As String = "SELECT TEN, SDT FROM LG WHERE TK = N'" & tk & "' AND PASS = N'" & mk & "'"
            Dim dTable As DataTable = _DBAccess.GetDataTable(sql)

            If dTable.Rows.Count > 0 Then
                Dim ten As String = dTable.Rows(0)("TEN").ToString()
                Dim sdt As String = dTable.Rows(0)("SDT").ToString()



                Dim f As New fQLSV()
                f.TenQL = ten
                f.SDTQL = sdt
                f.Show()
                Me.Hide()
            Else
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Lỗi khi đăng nhập: " & ex.Message, "Lỗi hệ thống",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub lQP_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lQP.LinkClicked
        Dim qmk As New fQMK()
        qmk.Show()
        Me.Hide()
    End Sub

    Private Sub btCRE_Click(sender As Object, e As EventArgs) Handles btCRE.Click
        Dim cre As New fCRE()
        cre.Show()
        Me.Hide()
    End Sub
End Class
