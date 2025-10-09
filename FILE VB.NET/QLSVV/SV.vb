Imports System.Data.SqlClient

Public Class SV
    Private _DBAccess As New DataBaseAccess
    Private _isEdit As Boolean = False
    Private _oldMASV As String = ""

    Public Sub New(Optional isEdit As Boolean = False, Optional oldMASV As String = "")
        InitializeComponent()
        _isEdit = isEdit
        _oldMASV = oldMASV
    End Sub


    Private Function CheckExistMASV(masv As String) As Boolean
        Dim sql As String = "SELECT COUNT(*) FROM SINHVIEN WHERE MASV = @MASV"
        Dim count As Integer = Convert.ToInt32(_DBAccess.GetScalarWithParams(sql, {New SqlParameter("@MASV", masv)}))
        Return count > 0
    End Function


    Private Function InsertSV() As Boolean
        Try

            Dim masv As String = txtMASV.Text.Trim()
            If CheckExistMASV(masv) Then
                MessageBox.Show(" Mã sinh viên này đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If


            Dim ngaySinh As DateTime
            If Not DateTime.TryParse(txtNS.Text, ngaySinh) Then
                MessageBox.Show("Ngày sinh không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If


            Dim sql As String = "INSERT INTO SINHVIEN (MANGANH, MALOP, MASV, HOTEN, NGAYSINH, GT, DIACHI) " &
                                "VALUES (@MANGANH, @MALOP, @MASV, @HOTEN, @NGAYSINH, @GT, @DIACHI)"

            Dim params As SqlParameter() = {
                New SqlParameter("@MANGANH", txtMANGANH.Text.Trim()),
                New SqlParameter("@MALOP", txtML.Text.Trim()),
                New SqlParameter("@MASV", masv),
                New SqlParameter("@HOTEN", txtTEN.Text.Trim()),
                New SqlParameter("@NGAYSINH", ngaySinh),
                New SqlParameter("@GT", txtGT.Text.Trim()),
                New SqlParameter("@DIACHI", txtDC.Text.Trim())
            }

            Return _DBAccess.ExecuteQueryWithParams(sql, params)

        Catch ex As Exception
            MessageBox.Show("Lỗi SQL: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function


    Private Function UpdateSV() As Boolean
        Try
            Dim masvMoi As String = txtMASV.Text.Trim()


            If masvMoi <> _oldMASV AndAlso CheckExistMASV(masvMoi) Then
                MessageBox.Show("❌ Mã sinh viên này đã tồn tại, không thể đổi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If


            Dim ngaySinh As DateTime
            If Not DateTime.TryParse(txtNS.Text, ngaySinh) Then
                MessageBox.Show("Ngày sinh không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If


            Dim sql As String = "UPDATE SINHVIEN SET MANGANH=@MANGANH, MALOP=@MALOP, MASV=@MASV, HOTEN=@HOTEN, " &
                                "NGAYSINH=@NGAYSINH, GT=@GT, DIACHI=@DIACHI WHERE MASV=@OLDMASV"

            Dim params As SqlParameter() = {
                New SqlParameter("@MANGANH", txtMANGANH.Text.Trim()),
                New SqlParameter("@MALOP", txtML.Text.Trim()),
                New SqlParameter("@MASV", masvMoi),
                New SqlParameter("@HOTEN", txtTEN.Text.Trim()),
                New SqlParameter("@NGAYSINH", ngaySinh),
                New SqlParameter("@GT", txtGT.Text.Trim()),
                New SqlParameter("@DIACHI", txtDC.Text.Trim()),
                New SqlParameter("@OLDMASV", _oldMASV)
            }

            Return _DBAccess.ExecuteQueryWithParams(sql, params)

        Catch ex As Exception
            MessageBox.Show("Lỗi Update: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function


    Private Function IsEmpty() As Boolean
        Return (String.IsNullOrEmpty(txtMANGANH.Text) OrElse
                String.IsNullOrEmpty(txtML.Text) OrElse
                String.IsNullOrEmpty(txtMASV.Text) OrElse
                String.IsNullOrEmpty(txtTEN.Text) OrElse
                String.IsNullOrEmpty(txtNS.Text) OrElse
                String.IsNullOrEmpty(txtGT.Text) OrElse
                String.IsNullOrEmpty(txtDC.Text))
    End Function


    Private Sub btok_Click(sender As Object, e As EventArgs) Handles btok.Click
        If IsEmpty() Then
            MessageBox.Show(" Hãy nhập đầy đủ dữ liệu!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If _isEdit Then
            If UpdateSV() Then
                MessageBox.Show(" Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                MessageBox.Show(" Cập nhật thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            If InsertSV() Then
                MessageBox.Show(" Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                MessageBox.Show(" Thêm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If


    End Sub

    Private Sub btback_Click(sender As Object, e As EventArgs) Handles btback.Click
        Me.Close()
    End Sub

    Private Sub SV_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
