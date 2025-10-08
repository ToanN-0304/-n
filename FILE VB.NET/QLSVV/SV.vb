Public Class SV
    Private _DBAccess As New DataBaseAccess
    Private _isEdit As Boolean = False

    Public Sub New(Optional isEdit As Boolean = False)
        InitializeComponent()
        _isEdit = isEdit
    End Sub

    Private Function InsertSV() As Boolean
        Try
            Dim ngaySinh As DateTime
            If Not DateTime.TryParse(txtNS.Text, ngaySinh) Then
                MessageBox.Show("Ngày sinh không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
            Dim sqlQuery As String = "INSERT INTO SINHVIEN (MANGANH, MALOP, MASV, HOTEN, NGAYSINH, GT, DIACHI) " &
                                 "VALUES (N'{0}', '{1}', '{2}', N'{3}', '{4}', N'{5}', N'{6}')"

            sqlQuery = String.Format(sqlQuery,
                                 txtMANGANH.Text.Trim(),
                                 txtML.Text.Trim(),
                                 txtMASV.Text.Trim(),
                                 txtTEN.Text.Trim(),
                                 ngaySinh.ToString("yyyy-MM-dd"),
                                 txtGT.Text.Trim(),
                                 txtDC.Text.Trim())

            Return _DBAccess.ExecuteNoneQuery(sqlQuery)

        Catch ex As Exception
            MessageBox.Show("Lỗi SQL: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Private Function UpdateSV() As Boolean
        Try
            Dim ngaySinh As DateTime
            If Not DateTime.TryParse(txtNS.Text, ngaySinh) Then
                MessageBox.Show("Ngày sinh không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

            Dim sqlQuery As String = String.Format("UPDATE SINHVIEN " &
                                               "SET HOTEN = N'{0}', NGAYSINH = '{1}', GT = N'{2}', DIACHI = N'{3}' " &
                                               "WHERE MASV = '{4}'",
                                               txtTEN.Text.Trim(),
                                               ngaySinh.ToString("yyyy-MM-dd"),
                                               txtGT.Text.Trim(),
                                               txtDC.Text.Trim(),
                                               txtMASV.Text.Trim())

            Return _DBAccess.ExecuteNoneQuery(sqlQuery)
        Catch ex As Exception
            MessageBox.Show("Lỗi Update: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Function IsEmpty() As Boolean
        Return (String.IsNullOrEmpty(txtMANGANH.Text) OrElse String.IsNullOrEmpty(txtML.Text) OrElse
               String.IsNullOrEmpty(txtMASV.Text) OrElse String.IsNullOrEmpty(txtTEN.Text) OrElse
               String.IsNullOrEmpty(txtNS.Text) OrElse String.IsNullOrEmpty(txtGT.Text) OrElse
               String.IsNullOrEmpty(txtDC.Text))
    End Function
    Private Sub btok_Click(sender As Object, e As EventArgs) Handles btok.Click
        If IsEmpty() Then
            MessageBox.Show("Hãy nhập đủ dữ liệu", "Error", MessageBoxButtons.OK)
        Else
            If _isEdit Then
                If UpdateSV() Then
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("Cập nhật thất bại!", "Lỗi", MessageBoxButtons.OK)
                End If
            Else
                If InsertSV() Then
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("Thêm thất bại!", "Lỗi", MessageBoxButtons.OK)
                End If
            End If
            Me.Close()
        End If
    End Sub


    Private Sub btback_Click(sender As Object, e As EventArgs) Handles btback.Click
        Me.Close()
    End Sub

    Private Sub SV_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class