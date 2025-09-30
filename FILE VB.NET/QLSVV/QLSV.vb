Public Class Form1
    Private _DBAccess As New DataBaseAccess
    Private _isloading As Boolean = False

    Private Sub Loaddataoncombobox()
        Dim sqlQuery As String = "Select MANGANH, TENNGANH From dbo.NGANH"
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Dim allRow As DataRow = dTable.NewRow()
        allRow("MANGANH") = ""
        allRow("TENNGANH") = "Tất cả"
        dTable.Rows.InsertAt(allRow, 0)
        Me.cboNGANH.DataSource = dTable
        Me.cboNGANH.ValueMember = "MANGANH"
        Me.cboNGANH.DisplayMember = "TENNGANH"
        If Me.cboNGANH.Items.Count > 0 Then
            Me.cboNGANH.SelectedIndex = 0
        End If
    End Sub
    Private Sub Loaddataoncomboboxkhoa(MANGANH As String)
        Dim sqlQuery As String
        If String.IsNullOrWhiteSpace(MANGANH) Then
            sqlQuery = "Select DISTINCT KHOAHOC From dbo.LOP"
        Else
            sqlQuery = String.Format("Select DISTINCT KHOAHOC From dbo.LOP where MANGANH = '{0}'", MANGANH)
        End If
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Dim allRow As DataRow = dTable.NewRow()

        allRow("KHOAHOC") = ""
        dTable.Rows.InsertAt(allRow, 0)
        With Me.cboKHOA
            .DataSource = dTable
            .ValueMember = "KHOAHOC"
            .DisplayMember = "KHOAHOC"
            .SelectedIndex = 0

        End With

    End Sub

    Private Sub LoadDataOnGridView(MANGANH As String, KHOAHOC As String)
        Dim sqlQuery As String = "SELECT SV.MASV, SV.HOTEN, L.TENLOP, SV.GT, SV.NGAYSINH, SV.DIACHI, L.MALOP, SV.MANGANH " &
                             "FROM dbo.SINHVIEN AS SV INNER JOIN dbo.LOP AS L ON SV.MALOP = L.MALOP"
        Dim whereClause As String = ""

        If Not String.IsNullOrWhiteSpace(MANGANH) Then
            whereClause &= String.Format("L.MANGANH = '{0}'", MANGANH)
        End If

        If Not String.IsNullOrWhiteSpace(KHOAHOC) Then
            If String.IsNullOrWhiteSpace(whereClause) Then
                whereClause &= String.Format("L.KHOAHOC = '{0}'", KHOAHOC)
            Else
                whereClause &= String.Format(" AND L.KHOAHOC = '{0}'", KHOAHOC)
            End If
        End If

        If Not String.IsNullOrWhiteSpace(whereClause) Then
            sqlQuery &= " WHERE " & whereClause
        End If

        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        With Me.dgSV

            .DataSource = dTable
            .Columns("MALOP").Visible = False
            .Columns("MANGANH").Visible = False
            .Columns(0).HeaderText = "Mã sinh viên"
            .Columns(1).HeaderText = "Họ tên"
            .Columns(2).HeaderText = "Lớp"
            .Columns(3).HeaderText = "Giới tính"
            .Columns(4).HeaderText = "Ngày sinh"
            .Columns(5).HeaderText = "Địa chỉ"
            .Columns(5).Width = 165
        End With
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _isloading = True

        Loaddataoncombobox()
        Loaddataoncomboboxkhoa(Me.cboNGANH.SelectedValue)
        LoadDataOnGridView(Me.cboNGANH.SelectedValue, Me.cboKHOA.SelectedValue)

        Me.cboTIM.Items.Clear()
        Me.cboTIM.Items.Add("Mã sinh viên")
        Me.cboTIM.Items.Add("Tên sinh viên")
        Me.cboTIM.SelectedIndex = 0

        _isloading = False
    End Sub

    Private Sub cboNGANH_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNGANH.SelectedIndexChanged
        If Not _isloading Then
            Dim selectedNGANH As String = Me.cboNGANH.SelectedValue.ToString()
            _isloading = True
            Loaddataoncomboboxkhoa(selectedNGANH)
            _isloading = False

            LoadDataOnGridView(selectedNGANH, Me.cboKHOA.SelectedValue.ToString())
        End If
    End Sub

    Private Sub cboKHOA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboKHOA.SelectedIndexChanged
        If Not _isloading Then
            LoadDataOnGridView(Me.cboNGANH.SelectedValue.ToString(), Me.cboKHOA.SelectedValue.ToString())
        End If
    End Sub
    Private Sub SearchSinhVien(MANGANH As String, KHOAHOC As String, value As String)
        Dim sqlQuery As String = "SELECT SV.MASV, SV.HOTEN, L.TENLOP, SV.GT, SV.NGAYSINH, SV.DIACHI, L.MALOP ,SV.MANGANH " &
                             "FROM dbo.SINHVIEN AS SV INNER JOIN dbo.LOP AS L ON SV.MALOP = L.MALOP"
        If Me.cboTIM.SelectedIndex = 0 Then
            sqlQuery += String.Format(" AND SV.MASV LIKE '{0}%'", value)
        ElseIf Me.cboTIM.SelectedIndex = 1 Then
            sqlQuery += String.Format(" AND SV.HOTEN LIKE '{0}%'", value)

        End If
        Dim whereClause As String = ""

        If Not String.IsNullOrWhiteSpace(MANGANH) Then
            whereClause &= String.Format("L.MANGANH = '{0}'", MANGANH)
        End If

        If Not String.IsNullOrWhiteSpace(KHOAHOC) Then
            If String.IsNullOrWhiteSpace(whereClause) Then
                whereClause &= String.Format("L.KHOAHOC = '{0}'", KHOAHOC)
            Else
                whereClause &= String.Format(" AND L.KHOAHOC = '{0}'", KHOAHOC)
            End If
        End If

        If Not String.IsNullOrWhiteSpace(whereClause) Then
            sqlQuery &= " WHERE " & whereClause
        End If

        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        With Me.dgSV

            .DataSource = dTable
            .Columns("MALOP").Visible = False
            .Columns("MANGANH").Visible = False
            .Columns(0).HeaderText = "Mã sinh viên"
            .Columns(1).HeaderText = "Họ tên"
            .Columns(2).HeaderText = "Lớp"
            .Columns(3).HeaderText = "Giới tính"
            .Columns(4).HeaderText = "Ngày sinh"
            .Columns(5).HeaderText = "Địa chỉ"
            .Columns(5).Width = 165
        End With
    End Sub
    Private Sub txtTIM_TextChanged(sender As Object, e As EventArgs) Handles txtTIM.TextChanged
        SearchSinhVien(Me.cboNGANH.SelectedValue, Me.cboKHOA.SelectedValue, Me.txtTIM.Text)
    End Sub

    Private Sub btthem_Click(sender As Object, e As EventArgs) Handles btthem.Click
        Dim frm As New SV(False)
        frm.txtMANGANH.Text = Me.cboNGANH.SelectedValue
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.OK Then
            LoadDataOnGridView(Me.cboNGANH.SelectedValue, Me.cboKHOA.SelectedValue.ToString())
        End If
    End Sub

    Private Sub btsua_Click(sender As Object, e As EventArgs) Handles btsua.Click
        Dim frm As New SV(True)
        frm.txtMANGANH.Text = cboNGANH.SelectedValue.ToString()
        frm.txtMANGANH.ReadOnly = True
        frm.txtML.ReadOnly = True
        With dgSV
            frm.txtMASV.Text = .Rows(.CurrentCell.RowIndex).Cells("MASV").Value.ToString()
            frm.txtTEN.Text = .Rows(.CurrentCell.RowIndex).Cells("HOTEN").Value.ToString()
            frm.txtMANGANH.Text = .Rows(.CurrentCell.RowIndex).Cells("MANGANH").Value.ToString()
            frm.txtML.Text = .Rows(.CurrentCell.RowIndex).Cells("MALOP").Value.ToString()
            frm.txtNS.Text = Convert.ToDateTime(.Rows(.CurrentCell.RowIndex).Cells("NGAYSINH").Value).ToString("yyyy-MM-dd")
            frm.txtGT.Text = .Rows(.CurrentCell.RowIndex).Cells("GT").Value.ToString()
            frm.txtDC.Text = .Rows(.CurrentCell.RowIndex).Cells("DIACHI").Value.ToString()
        End With

        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.OK Then
            LoadDataOnGridView(Me.cboNGANH.SelectedValue, Me.cboKHOA.SelectedValue.ToString())
        End If

    End Sub

    Private Sub btxoa_Click(sender As Object, e As EventArgs) Handles btxoa.Click
        Dim MASV As String = Me.dgSV.Rows(Me.dgSV.CurrentCell.RowIndex).Cells("MASV").Value
        Dim sqlQuery As String = String.Format("DELETE SINHVIEN WHERE MASV = '{0}'", MASV)

        If _DBAccess.ExecuteNoneQuery(sqlQuery) Then
            MessageBox.Show("DONE!")
            LoadDataOnGridView(Me.cboNGANH.SelectedValue, Me.cboKHOA.SelectedValue.ToString())
        Else
            MessageBox.Show("loi, xoa that bai!")
        End If
    End Sub
End Class
