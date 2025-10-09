Imports System.Data.SqlClient

Public Class fCRE
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


    Private Function IsEmpty() As Boolean
        Return (String.IsNullOrEmpty(txtTEN.Text) OrElse
                String.IsNullOrEmpty(txtM.Text) OrElse
                String.IsNullOrEmpty(txtSDT.Text) OrElse
                String.IsNullOrEmpty(txtTK.Text) OrElse
                String.IsNullOrEmpty(txtMK.Text))
    End Function


    Private Sub btCRE_Click(sender As Object, e As EventArgs) Handles btCRE.Click
        If IsEmpty() Then
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim tk As String = txtTK.Text.Trim()
        Dim mk As String = txtMK.Text.Trim()
        Dim ten As String = txtTEN.Text.Trim()
        Dim sdt As String = txtSDT.Text.Trim()
        Dim magv As String = txtM.Text.Trim()

        Try

            Dim sqlCheckQL As String = "SELECT COUNT(*) FROM QL WHERE MAGV = @MAGV"
            Dim countQL As Integer = Convert.ToInt32(_DBAccess.GetScalarWithParams(sqlCheckQL, {New SqlParameter("@MAGV", magv)}))
            If countQL = 0 Then
                MessageBox.Show("Mã giáo viên không tồn tại trong hệ thống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If


            Dim sqlCheckMAGV As String = "SELECT COUNT(*) FROM LG WHERE MAGV = @MAGV"
            Dim countMAGV As Integer = Convert.ToInt32(_DBAccess.GetScalarWithParams(sqlCheckMAGV, {New SqlParameter("@MAGV", magv)}))
            If countMAGV > 0 Then
                MessageBox.Show("Mã giáo viên này đã được dùng để tạo tài khoản!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim sqlCheckTK As String = "SELECT COUNT(*) FROM LG WHERE TK = @TK"
            Dim countTK As Integer = Convert.ToInt32(_DBAccess.GetScalarWithParams(sqlCheckTK, {New SqlParameter("@TK", tk)}))
            If countTK > 0 Then
                MessageBox.Show("Tên tài khoản đã tồn tại, vui lòng chọn tên khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If


            Dim sqlInsert As String = "INSERT INTO LG (TK, PASS, TEN, SDT, MAGV) VALUES (@TK, @PASS, @TEN, @SDT, @MAGV)"
            Dim parameters As SqlParameter() = {
                New SqlParameter("@TK", tk),
                New SqlParameter("@PASS", mk),
                New SqlParameter("@TEN", ten),
                New SqlParameter("@SDT", sdt),
                New SqlParameter("@MAGV", magv)
            }

            If _DBAccess.ExecuteQueryWithParams(sqlInsert, parameters) Then
                MessageBox.Show("Tạo tài khoản thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim lg As New fLG()
                lg.Show()
                Me.Close()
            Else
                MessageBox.Show("Không thể tạo tài khoản!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Lỗi hệ thống: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim lg As New fLG()
        lg.Show()
        Me.Close()
    End Sub
End Class
