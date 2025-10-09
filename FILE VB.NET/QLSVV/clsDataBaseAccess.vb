Imports System
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient

Public Class DataBaseAccess
    '-----------------------------------------
    'Khai báo các đối tượng chính
    '-----------------------------------------
    Protected SqlCon As SqlConnection
    Protected SqlCom As SqlCommand
    Protected Sqldreader As SqlDataReader
    Protected SqlDa As SqlDataAdapter
    Protected SqlComb As SqlCommandBuilder

    '💡 Sửa chuỗi kết nối theo máy bạn
    Private ConnectionString As String = "Data Source=MSI\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True"

    '-----------------------------------------
    'Khởi tạo kết nối
    '-----------------------------------------
    Public Sub New()
        SqlCon = New SqlConnection
        SqlCon.ConnectionString = ConnectionString
    End Sub

    '-----------------------------------------
    'Mở kết nối
    '-----------------------------------------
    Public Function OpenConnection() As Boolean
        Try
            If SqlCon.State <> ConnectionState.Open Then
                SqlCon.Open()
                Return True
            End If
        Catch ex As SqlException
            MessageBox.Show("Không thể kết nối tới cơ sở dữ liệu!", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
        Return True
    End Function

    '-----------------------------------------
    'Đóng kết nối
    '-----------------------------------------
    Protected Function CloseConnection() As Boolean
        Try
            If SqlCon.State <> ConnectionState.Closed Then
                SqlCon.Close()
                Return True
            End If
        Catch ex As SqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Đóng kết nối thất bại")
            Return False
        End Try
        Return True
    End Function

    '-----------------------------------------
    'Thực thi câu lệnh SQL KHÔNG có tham số (Insert/Update/Delete)
    '-----------------------------------------
    Public Function ExecuteNoneQuery(ByVal v_sSqlString As String, Optional ByVal ShowErrorMessage As Boolean = False) As Boolean
        If OpenConnection() Then
            Try
                SqlCom = New SqlCommand(v_sSqlString, SqlCon)
                SqlCom.ExecuteNonQuery()
                Return True
            Catch ex As SqlException
                If ShowErrorMessage Then
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "ExecuteNonQuery")
                End If
                Return False
            Finally
                CloseConnection()
                SqlCom.Dispose()
            End Try
        End If
        Return False
    End Function

    '-----------------------------------------
    'Thực thi câu lệnh SQL CÓ tham số
    '-----------------------------------------
    Public Function ExecuteQueryWithParams(sqlQuery As String, Optional parameters As SqlParameter() = Nothing) As Boolean
        Using conn As New SqlConnection(ConnectionString)
            Using cmd As New SqlCommand(sqlQuery, conn)
                If parameters IsNot Nothing Then
                    cmd.Parameters.AddRange(parameters)
                End If
                conn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    '-----------------------------------------
    'Đọc dữ liệu dạng SqlDataReader
    '-----------------------------------------
    Public Function GetDataReader(ByVal v_sSqlString As String) As SqlDataReader
        Try
            If OpenConnection() Then
                SqlCom = New SqlCommand(v_sSqlString, SqlCon)
                Sqldreader = SqlCom.ExecuteReader
            End If
            Return Sqldreader
        Catch ex As SqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Get DataReader")
            Return Nothing
        Finally
            CloseConnection()
            SqlCom.Dispose()
        End Try
    End Function

    '-----------------------------------------
    'Lấy 1 giá trị (ô đầu tiên hàng đầu tiên)
    '-----------------------------------------
    Public Function GetScalar(ByVal v_sSqlString As String) As Object
        Dim Result As Object = Nothing
        Try
            If OpenConnection() Then
                SqlCom = New SqlCommand(v_sSqlString, SqlCon)
                Result = SqlCom.ExecuteScalar
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Get Scalar")
        Finally
            CloseConnection()
            SqlCom.Dispose()
        End Try
        Return Result
    End Function

    '-----------------------------------------
    'Lấy 1 giá trị có tham số (phiên bản an toàn)
    '-----------------------------------------
    Public Function GetScalarWithParams(sqlQuery As String, Optional parameters As SqlParameter() = Nothing) As Object
        Using conn As New SqlConnection(ConnectionString)
            Using cmd As New SqlCommand(sqlQuery, conn)
                If parameters IsNot Nothing Then
                    cmd.Parameters.AddRange(parameters)
                End If
                conn.Open()
                Return cmd.ExecuteScalar()
            End Using
        End Using
    End Function

    '-----------------------------------------
    'Trả về bảng dữ liệu (DataTable)
    '-----------------------------------------
    Public Function GetDataTable(ByVal v_sSqlString As String) As DataTable
        Dim dtable As New DataTable()
        SqlDa = New SqlDataAdapter(v_sSqlString, SqlCon)
        If OpenConnection() Then
            Try
                SqlDa.Fill(dtable)
            Catch ex As SqlException
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Get DataTable")
            Finally
                CloseConnection()
                SqlDa.Dispose()
            End Try
        End If
        Return dtable
    End Function

    '-----------------------------------------
    'Trả về bảng dữ liệu theo điều kiện
    '-----------------------------------------
    Public Function GetDataTable(ByVal TableName As String, ByVal Condition As String) As DataTable
        Dim dtable As New DataTable(TableName)
        SqlDa = New SqlDataAdapter("SELECT * FROM " & TableName & " WHERE " & Condition, SqlCon)
        If OpenConnection() Then
            Try
                SqlDa.Fill(dtable)
            Catch ex As SqlException
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Get DataTable Condition")
            Finally
                CloseConnection()
                SqlDa.Dispose()
            End Try
        End If
        Return dtable
    End Function

    '-----------------------------------------
    'Cập nhật bảng dữ liệu (Insert/Update/Delete)
    '-----------------------------------------
    Public Function UpdateDataTable(ByVal v_sSqlString As String, ByVal v_dtable As DataTable, Optional ByVal ShowErrorMessage As Boolean = False) As Boolean
        SqlDa = New SqlDataAdapter
        SqlDa.SelectCommand = New SqlCommand(v_sSqlString, SqlCon)
        SqlComb = New SqlCommandBuilder(SqlDa)
        Try
            If OpenConnection() Then
                SqlDa.Update(v_dtable)
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            If ShowErrorMessage Then
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Update DataTable")
            End If
            Return False
        Finally
            CloseConnection()
            SqlDa.Dispose()
            SqlComb.Dispose()
        End Try
    End Function

    '-----------------------------------------
    'Giải phóng tài nguyên
    '-----------------------------------------
    Protected Overloads Sub Dispose()
        CloseConnection()
        GC.SuppressFinalize(Me)
    End Sub
End Class
