Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class RoundedTextBox
    Inherits TextBox

    Private _placeholderText As String = "Nhập thông tin..."
    Private _isFocused As Boolean = False

    '--- Thuộc tính Placeholder ---
    Public Property PlaceholderText As String
        Get
            Return _placeholderText
        End Get
        Set(value As String)
            _placeholderText = value
            Invalidate() ' Vẽ lại khi thay đổi
        End Set
    End Property

    Public Sub New()
        MyBase.New()
        Me.BorderStyle = BorderStyle.None
        Me.Font = New Font("Segoe UI", 10)
        Me.BackColor = Color.White
        Me.ForeColor = Color.Black
        Me.Padding = New Padding(5)
        Me.SetStyle(ControlStyles.UserPaint, True)
    End Sub

    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        Me.AutoSize = False

    End Sub

    Protected Overrides Sub OnEnter(e As EventArgs)
        MyBase.OnEnter(e)
        _isFocused = True
        Invalidate()
    End Sub

    Protected Overrides Sub OnLeave(e As EventArgs)
        MyBase.OnLeave(e)
        _isFocused = False
        Invalidate()
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias

        ' Viền bo góc
        Dim rect As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim path As New GraphicsPath()
        Dim radius As Integer = 10

        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
        path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90)
        path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90)
        path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90)
        path.CloseFigure()

        ' Nền
        Using brush As New SolidBrush(Me.BackColor)
            g.FillPath(brush, path)
        End Using

        ' Viền
        Dim borderColor As Color = If(_isFocused, Color.DodgerBlue, Color.Silver)
        Using pen As New Pen(borderColor, 2)
            g.DrawPath(pen, path)
        End Using

        ' Text hoặc Placeholder
        Dim textRect As RectangleF = New RectangleF(8, 8, Me.Width - 16, Me.Height - 16)
        If Me.Text.Length > 0 Then
            Using brush As New SolidBrush(Me.ForeColor)
                g.DrawString(Me.Text, Me.Font, brush, textRect)
            End Using
        ElseIf Not _isFocused Then
            Using brush As New SolidBrush(Color.Gray)
                g.DrawString(_placeholderText, Me.Font, brush, textRect)
            End Using
        End If
    End Sub

    Protected Overrides Sub OnTextChanged(e As EventArgs)
        MyBase.OnTextChanged(e)
        Invalidate()
    End Sub
End Class
