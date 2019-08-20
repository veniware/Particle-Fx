Public Module cmd
    Public WORKPLACE As New Size(10000, 5000)

    Public Const ANGLECONVERT As Double = 57.295779513082323 '180 / Math.PI..

    Public OSVer As Short = Val(Microsoft.VisualBasic.Left(My.Computer.Info.OSVersion, InStr(My.Computer.Info.OSVersion, ".") - 1))

    Public Const MinF As Integer = -65536
    Public Const MaxF As Integer = 65535
    Public Const MinNoice As Integer = 0
    Public Const MaxNoice As Integer = 100
    Public Const MinR As Integer = 1
    Public Const MaxR As Integer = 255
    Public Const MinPPF As Integer = 1
    Public Const MaxPPF As Integer = 1024

    Public Function StringDialog(ByVal Title As String, ByRef Text As String) As DialogResult
        Dim frmString As New Form
        frmString.Text = Title
        frmString.Icon = frmMain.Icon
        frmString.ShowIcon = False
        frmString.ShowInTaskbar = False
        frmString.BackColor = Color.FromArgb(64, 64, 64)
        frmString.ForeColor = Color.FromArgb(224, 224, 224)
        frmString.Font = frmMain.Font
        frmString.StartPosition = FormStartPosition.CenterParent
        frmString.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
        frmString.ClientSize = New Size(360, 88)
        frmString.MinimizeBox = False
        frmString.MaximizeBox = False

        Dim txtTitle As New TextBox
        txtTitle.Text = Text
        txtTitle.BackColor = Drawing.Color.DimGray
        txtTitle.ForeColor = Drawing.Color.White
        txtTitle.Location = New Point(16, 16)
        txtTitle.Width = frmString.ClientSize.Width - 32
        txtTitle.MaxLength = 32

        Dim cmdOK As New Button
        cmdOK.Text = "OK"
        cmdOK.DialogResult = Windows.Forms.DialogResult.OK
        cmdOK.BackColor = Color.FromArgb(224, 244, 244)
        cmdOK.ForeColor = Color.FromArgb(32, 32, 32)

        Dim cmdCancel As New Button
        cmdCancel.Text = "Cancel"
        cmdCancel.DialogResult = Windows.Forms.DialogResult.Cancel
        cmdCancel.BackColor = Color.FromArgb(224, 244, 244)
        cmdCancel.ForeColor = Color.FromArgb(32, 32, 32)

        cmdOK.Location = New Point((frmString.ClientSize.Width - cmdOK.Width - cmdCancel.Width - 8) \ 2, frmString.ClientSize.Height - cmdOK.Height - 8)
        cmdCancel.Location = New Point(cmdOK.Left + cmdOK.Width + 8, frmString.ClientSize.Height - cmdCancel.Height - 8)

        frmString.Controls.Add(txtTitle)
        frmString.Controls.Add(cmdOK)
        frmString.Controls.Add(cmdCancel)

        frmString.AcceptButton = cmdOK
        frmString.CancelButton = cmdCancel

        If frmString.ShowDialog = Windows.Forms.DialogResult.OK Then
            Text = txtTitle.Text
            Return DialogResult.OK
        Else
            Return DialogResult.Cancel
        End If
        frmString.Dispose()
    End Function

    Public Function ValueDialog(ByVal Title As String, ByRef Value As Double, Optional ByVal min As Integer = 0, Optional ByVal max As Integer = 100, Optional ByVal Decimals As Byte = 0) As DialogResult
        Dim frmValue As New Form
        frmValue.Text = Title
        frmValue.Icon = frmMain.Icon
        frmValue.ShowIcon = False
        frmValue.ShowInTaskbar = False
        frmValue.BackColor = Color.FromArgb(64, 64, 64)
        frmValue.ForeColor = Color.FromArgb(224, 224, 224)
        frmValue.Font = frmMain.Font
        frmValue.StartPosition = FormStartPosition.CenterParent
        frmValue.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
        frmValue.ClientSize = New Size(240, 88)
        frmValue.MinimizeBox = False
        frmValue.MaximizeBox = False

        Dim txtValue As New NumericUpDown
        txtValue.BackColor = Drawing.Color.DimGray
        txtValue.ForeColor = Drawing.Color.White
        txtValue.Location = New Point(16, 16)
        txtValue.Width = frmValue.ClientSize.Width - 32
        txtValue.Minimum = min
        txtValue.Maximum = max
        txtValue.Value = Value
        txtValue.DecimalPlaces = Decimals

        Dim cmdOK As New Button
        cmdOK.Text = "OK"
        cmdOK.DialogResult = Windows.Forms.DialogResult.OK
        cmdOK.BackColor = Color.FromArgb(224, 244, 244)
        cmdOK.ForeColor = Color.FromArgb(32, 32, 32)

        Dim cmdCancel As New Button
        cmdCancel.Text = "Cancel"
        cmdCancel.DialogResult = Windows.Forms.DialogResult.Cancel
        cmdCancel.BackColor = Color.FromArgb(224, 244, 244)
        cmdCancel.ForeColor = Color.FromArgb(32, 32, 32)

        cmdOK.Location = New Point((frmValue.ClientSize.Width - cmdOK.Width - cmdCancel.Width - 8) \ 2, frmValue.ClientSize.Height - cmdOK.Height - 8)
        cmdCancel.Location = New Point(cmdOK.Left + cmdOK.Width + 8, frmValue.ClientSize.Height - cmdCancel.Height - 8)

        frmValue.Controls.Add(txtValue)
        frmValue.Controls.Add(cmdOK)
        frmValue.Controls.Add(cmdCancel)

        frmValue.AcceptButton = cmdOK
        frmValue.CancelButton = cmdCancel

        txtValue.Select(0, Value.ToString.Length)

        If frmValue.ShowDialog = Windows.Forms.DialogResult.OK Then
            Value = txtValue.Text
            Return DialogResult.OK
        Else
            Return DialogResult.Cancel
        End If
        frmValue.Dispose()
    End Function

    Public Function MessageBox(ByVal Message As String, ByVal Title As String, Optional ByVal Style As Byte = 1, Optional ByVal Icon As Byte = 0) As DialogResult

        If OSver > 5 Then
            Dim frmMSG As New frmAeroDialog(Style)
            frmMSG.BuilFrame(Message, Icon)
            frmMSG.Text = Title
            Return frmMSG.ShowDialog()
        Else

            Select Case Style
                Case 2 : Return MsgBox(Message, MsgBoxStyle.OkCancel, Title)
                Case 3 : Return MsgBox(Message, MsgBoxStyle.YesNo, Title)
                Case Else : Return MsgBox(Message, MsgBoxStyle.OkOnly, Title)
            End Select

        End If

    End Function

    Function GoogleTranslate(ByVal text As String, ByVal langpair As String) As String
        Dim streamreader As IO.StreamReader = New IO.StreamReader(Net.HttpWebRequest.Create("http://translate.google.com/?hl=en&ie=UTF8&text=" & text & "&langpair=" & langpair & "#").GetResponse.GetResponseStream, System.Text.Encoding.Default)

        Dim Code As String = streamreader.ReadToEnd
        streamreader.Close()

        Dim s1 As String = Microsoft.VisualBasic.Right(Code, Code.Length - InStr(Code, "<span id=result_box class=" & """" & "short_text" & """" & ">"))
        Dim s2 As String = Microsoft.VisualBasic.Right(s1, s1.Length - InStr(s1, ">"))
        Dim s3 As String = Microsoft.VisualBasic.Right(s2, s2.Length - InStr(s2, ">"))
        Dim s4 As String = Microsoft.VisualBasic.Left(s3, InStr(s3, "<") - 1)

        Return s4
    End Function

    Public Function Lang2LangPair(ByVal Lang As String) As String
        Select Case Lang.ToLower
            Case "[Autodetect]".ToLower : Return "auto"

            Case "English".ToLower : Return "en"
            Case "Albanian".ToLower : Return "sq"
            Case "Arabic".ToLower : Return "ar"
            Case "Bulgarian".ToLower : Return "bg"
            Case "Catalan".ToLower : Return "ca"
            Case "Chinese".ToLower : Return "zh-CN"
            Case "Croatian".ToLower : Return "hr"
            Case "Czech".ToLower : Return "cs"
            Case "Danish".ToLower : Return "da"
            Case "Dutch".ToLower : Return "nl"
            Case "Estonian".ToLower : Return "et"
            Case "Filipino".ToLower : Return "tl"
            Case "Finnish".ToLower : Return "fi"
            Case "French".ToLower : Return "fr"
            Case "Galician".ToLower : Return "gl"
            Case "German".ToLower : Return "de"
            Case "Greek".ToLower : Return "el"
            Case "Hebrew".ToLower : Return "iw"
            Case "Hindi".ToLower : Return "hi"
            Case "Hungarian".ToLower : Return "hu"
            Case "Indonesian".ToLower : Return "id"
            Case "Italian".ToLower : Return "it"
            Case "Japanese".ToLower : Return "ja"
            Case "Korean".ToLower : Return "ko"
            Case "Latvian".ToLower : Return "lv"
            Case "Lithuanian".ToLower : Return "lt"
            Case "Maltese".ToLower : Return "mt"
            Case "Norwegian".ToLower : Return "no"
            Case "Persian".ToLower : Return "fa"
            Case "Polish".ToLower : Return "pl"
            Case "Portuguese".ToLower : Return "pt"
            Case "Romanian".ToLower : Return "ro"
            Case "Russian".ToLower : Return "ru"
            Case "Serbian".ToLower : Return "sr"
            Case "Slovak".ToLower : Return "sk"
            Case "Slovenian".ToLower : Return "sl"
            Case "Spanish".ToLower : Return "es"
            Case "Swedish".ToLower : Return "sv"
            Case "Thai".ToLower : Return "th"
            Case "Turkish".ToLower : Return "tr"
            Case "Ukrainian".ToLower : Return "uk"
            Case "Vietnamese".ToLower : Return "vi"
            Case Else : Return "en"
        End Select
    End Function

    Public Function Count2String(ByVal count As Integer) As String
        Select Case count.ToString.Length
            Case 1 : Return "00000" & count
            Case 2 : Return "0000" & count
            Case 3 : Return "000" & count
            Case 4 : Return "00" & count
            Case 5 : Return "0" & count
            Case Else : Return count
        End Select
    End Function
End Module
