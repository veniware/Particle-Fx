Imports System.Runtime.InteropServices

Public Class frmAeroDialog

    Public Structure Margins
        Public Left As Integer
        Public Right As Integer
        Public Top As Integer
        Public Bottom As Integer
    End Structure

    Private inset As Margins = New Margins
    Dim isit As Boolean = False
    Dim DialogStyle As Byte

    <DllImport("dwmapi.dll", CharSet:=CharSet.Auto)> Public Shared Sub DwmExtendFrameIntoClientArea(ByVal hWnd As System.IntPtr, ByRef pMargins As Margins)
    End Sub
    <DllImport("dwmapi.dll", CharSet:=CharSet.Auto)> Public Shared Sub DwmIsCompositionEnabled(ByRef IsIt As Boolean)
    End Sub

    Public WithEvents cmdOK As New ctrDynamicButton
    Sub cmdOK_Click() Handles cmdOK.ClickOrEnterOrAnything
        If DialogStyle = 3 Then
            Me.DialogResult = Windows.Forms.DialogResult.Yes
        Else
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub
    Sub cmdOK_Esc() Handles cmdOK.ESC
        If DialogStyle = 3 Then
            Me.DialogResult = Windows.Forms.DialogResult.No
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Public WithEvents cmdCancel As New ctrDynamicButton
    Sub cmdCancel_Click() Handles cmdCancel.ClickOrEnterOrAnything
        If DialogStyle = 3 Then
            Me.DialogResult = Windows.Forms.DialogResult.No
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub
    Sub cmdCancel_Esc() Handles cmdCancel.ESC
        If DialogStyle = 3 Then
            Me.DialogResult = Windows.Forms.DialogResult.No
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    ' 0: none
    ' 1: OkOnly
    ' 2: OKCancel
    ' 3: YesNo
    Public Sub New(Optional ByVal DialogStyle As Byte = 1, Optional ByVal Widht As Integer = 480, Optional ByVal Height As Integer = 200)
        Me.DialogStyle = DialogStyle

        InitializeComponent()
        Me.Size = New Size(Widht, Height)

        cmdOK.Size = New Size(75, 23)
        cmdCancel.Size = New Size(75, 23)

        Select Case DialogStyle

            Case 1
                cmdOK.Label = "OK"
                cmdOK.Location = New Point((Me.ClientSize.Width - cmdOK.Width) \ 2, Me.ClientSize.Height - cmdOK.Height - 8)
                Me.Controls.Add(cmdOK)

            Case 2
                cmdOK.Label = "OK"
                cmdCancel.Label = "Cancel"
                cmdOK.Location = New Point((Me.ClientSize.Width - (cmdOK.Width + cmdCancel.Width + 8)) \ 2, Me.ClientSize.Height - cmdOK.Height - 8)
                cmdCancel.Location = New Point(cmdOK.Left + cmdOK.Width + 8, Me.ClientSize.Height - cmdOK.Height - 8)
                Me.Controls.Add(cmdOK)
                Me.Controls.Add(cmdCancel)

            Case 3
                cmdOK.Label = "Yes"
                cmdCancel.Label = "No"
                cmdOK.Location = New Point((Me.ClientSize.Width - (cmdOK.Width + cmdCancel.Width + 8)) \ 2, Me.ClientSize.Height - cmdOK.Height - 8)
                cmdCancel.Location = New Point(cmdOK.Left + cmdOK.Width + 8, Me.ClientSize.Height - cmdOK.Height - 8)
                Me.Controls.Add(cmdOK)
                Me.Controls.Add(cmdCancel)

        End Select

        inset.Top = Screen.PrimaryScreen.Bounds.Width
        inset.Left = Screen.PrimaryScreen.Bounds.Width
        inset.Right = Screen.PrimaryScreen.Bounds.Width
        inset.Bottom = Screen.PrimaryScreen.Bounds.Height

        DwmIsCompositionEnabled(isit)

        If isit Then
            DwmExtendFrameIntoClientArea(Me.Handle, inset)
        Else
            Me.BackColor = Color.DimGray
        End If
    End Sub

    ' 0: none
    ' 1: Warning
    ' 2: Error
    Public Sub BuilFrame(ByVal Message As String, ByVal Icon As Byte)

        Dim Frame As Image = New Bitmap(Me.ClientSize.Width, Me.ClientSize.Height - 48, Imaging.PixelFormat.Format32bppArgb)
        Using G As Graphics = Graphics.FromImage(Frame)
            G.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
            G.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias

            Dim rec As Rectangle

            Select Case Icon

                Case 0
                    rec = New Rectangle(16, 16, Frame.Width - 32, Frame.Height - 32)

                Case 1
                    G.DrawImage(My.Resources.msgWaring, 16, (Frame.Height - 64) \ 2, 64, 64)
                    rec = New Rectangle(96, 16, Frame.Width - 128, Frame.Height - 32)

                Case 2
                    G.DrawImage(My.Resources.msgError, 16, (Frame.Height - 64) \ 2, 64, 64)
                    rec = New Rectangle(96, 16, Frame.Width - 128, Frame.Height - 32)

            End Select

            G.DrawString(Message, New Font("Arial", 12), New SolidBrush(Color.FromArgb(64, 32, 23, 32)), New Rectangle(rec.X - 1, rec.Y - 1, rec.Width, rec.Height), frmMain.StringFormatCenterAll)
            G.DrawString(Message, New Font("Arial", 12), New SolidBrush(Color.FromArgb(64, 32, 23, 32)), New Rectangle(rec.X, rec.Y - 1, rec.Width, rec.Height), frmMain.StringFormatCenterAll)
            G.DrawString(Message, New Font("Arial", 12), New SolidBrush(Color.FromArgb(64, 32, 23, 32)), New Rectangle(rec.X + 1, rec.Y - 1, rec.Width, rec.Height), frmMain.StringFormatCenterAll)
            G.DrawString(Message, New Font("Arial", 12), New SolidBrush(Color.FromArgb(96, 32, 23, 32)), New Rectangle(rec.X + 1, rec.Y, rec.Width, rec.Height), frmMain.StringFormatCenterAll)
            G.DrawString(Message, New Font("Arial", 12), New SolidBrush(Color.FromArgb(128, 32, 23, 32)), New Rectangle(rec.X + 1, rec.Y + 1, rec.Width, rec.Height), frmMain.StringFormatCenterAll)
            G.DrawString(Message, New Font("Arial", 12), New SolidBrush(Color.FromArgb(96, 32, 23, 32)), New Rectangle(rec.X, rec.Y + 1, rec.Width, rec.Height), frmMain.StringFormatCenterAll)
            G.DrawString(Message, New Font("Arial", 12), New SolidBrush(Color.FromArgb(64, 32, 23, 32)), New Rectangle(rec.X - 1, rec.Y + 1, rec.Width, rec.Height), frmMain.StringFormatCenterAll)
            G.DrawString(Message, New Font("Arial", 12), New SolidBrush(Color.FromArgb(64, 32, 23, 32)), New Rectangle(rec.X - 1, rec.Y, rec.Width, rec.Height), frmMain.StringFormatCenterAll)

            G.DrawString(Message, New Font("Arial", 12), New SolidBrush(Color.FromArgb(32, 32, 23, 32)), New Rectangle(rec.X - 2, rec.Y - 2, rec.Width, rec.Height), frmMain.StringFormatCenterAll)
            G.DrawString(Message, New Font("Arial", 12), New SolidBrush(Color.FromArgb(32, 32, 23, 32)), New Rectangle(rec.X, rec.Y - 2, rec.Width, rec.Height), frmMain.StringFormatCenterAll)
            G.DrawString(Message, New Font("Arial", 12), New SolidBrush(Color.FromArgb(32, 32, 23, 32)), New Rectangle(rec.X + 2, rec.Y - 2, rec.Width, rec.Height), frmMain.StringFormatCenterAll)
            G.DrawString(Message, New Font("Arial", 12), New SolidBrush(Color.FromArgb(32, 32, 23, 32)), New Rectangle(rec.X + 2, rec.Y, rec.Width, rec.Height), frmMain.StringFormatCenterAll)
            G.DrawString(Message, New Font("Arial", 12), New SolidBrush(Color.FromArgb(32, 32, 23, 32)), New Rectangle(rec.X + 2, rec.Y + 2, rec.Width, rec.Height), frmMain.StringFormatCenterAll)
            G.DrawString(Message, New Font("Arial", 12), New SolidBrush(Color.FromArgb(32, 32, 23, 32)), New Rectangle(rec.X, rec.Y + 2, rec.Width, rec.Height), frmMain.StringFormatCenterAll)
            G.DrawString(Message, New Font("Arial", 12), New SolidBrush(Color.FromArgb(32, 32, 23, 32)), New Rectangle(rec.X - 2, rec.Y + 2, rec.Width, rec.Height), frmMain.StringFormatCenterAll)
            G.DrawString(Message, New Font("Arial", 12), New SolidBrush(Color.FromArgb(32, 32, 23, 32)), New Rectangle(rec.X - 2, rec.Y, rec.Width, rec.Height), frmMain.StringFormatCenterAll)

            G.DrawString(Message, New Font("Arial", 12), Brushes.White, rec, frmMain.StringFormatCenterAll)
        End Using

        Me.BackgroundImageLayout = ImageLayout.None
        Me.BackgroundImage = Frame
    End Sub
End Class