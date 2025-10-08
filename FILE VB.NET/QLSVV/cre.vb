Imports MS.Internal

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

    Private Function addTK() As Boolean
        Try

            Dim sqlQuery As String = "INSERT INTO LG (TEN, MAGV, SDT, TK, PASS) " &
                                 "VALUES (N'{0}', N'{1}', N'{2}', N'{3}', N'{4}')"

            sqlQuery = String.Format(sqlQuery,
                                 txtTEN.Text.Trim(),
                                 txtM.Text.Trim(),
                                 txtSDT.Text.Trim(),
                                 txtTK.Text.Trim(),
                                 txtMK.Text.Trim())

            Return _DBAccess.ExecuteNoneQuery(sqlQuery)

        Catch ex As Exception
            MessageBox.Show("Lỗi SQL: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Function IsEmpty() As Boolean
        Return (String.IsNullOrEmpty(txtTEN.Text) OrElse String.IsNullOrEmpty(txtM.Text) OrElse
               String.IsNullOrEmpty(txtSDT.Text) OrElse String.IsNullOrEmpty(txtTK.Text) OrElse
               String.IsNullOrEmpty(txtMK.Text))
    End Function
    Private Sub btCRE_Click(sender As Object, e As EventArgs) Handles btCRE.Click
        If IsEmpty() Then
            MessageBox.Show("Hãy nhập đủ dữ liệu", "Error", MessageBoxButtons.OK)
        Else
            If addTK() Then
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK)
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Dim lg As New fLG()
                lg.Show()
                Me.Close()
            Else
                MessageBox.Show("Thêm thất bại!", "Lỗi", MessageBoxButtons.OK)
                End If
            End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim lg As New fLG()
        lg.Show()
        Me.Close()

    End Sub
End Class
