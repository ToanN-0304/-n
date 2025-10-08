Imports System.Data.SqlClient
Imports System.Net
Public Class fQMK
    Private _DBAccess As New DataBaseAccess

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim lg As New fLG()
        lg.Show()
        Me.Close()

    End Sub

    Private Sub btOK_Click(sender As Object, e As EventArgs) Handles btOK.Click
        Dim magv As String = txtM.Text.Trim()

        If String.IsNullOrEmpty(magv) Then
            MessageBox.Show("Vui lòng nhập mã quản lý!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If


        Dim sqlQuery As String = String.Format("SELECT TK, PASS FROM dbo.LG WHERE MAGV = '{0}'", magv)

        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)

        If dTable.Rows.Count > 0 Then
            Dim taikhoan As String = dTable.Rows(0)("TK").ToString()
            Dim matkhau As String = dTable.Rows(0)("PASS").ToString()

            MessageBox.Show(String.Format("Tài khoản: {0}" & vbCrLf & "Mật khẩu: {1}", taikhoan, matkhau),
                            "Thông tin tài khoản",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        Else
            MessageBox.Show("Không tìm thấy tài khoản cho mã quản lý này!",
                            "Lỗi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End If
    End Sub
End Class