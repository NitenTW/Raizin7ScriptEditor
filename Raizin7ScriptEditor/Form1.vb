Imports System.ComponentModel

Public Class Form1

    Private lang As Language
    Private changed As Boolean = True
    Private initilizeText As String = "//" & vbNewLine & "eve_start" & vbNewLine & "eve_end"
    Private suffix As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextEditorControl1.Encoding = System.Text.Encoding.UTF8
        TextEditorControl1.Font = New Font("consolas", 12)
        changed = False
        TraditionalChineseToolStripMenuItem.Checked = True
        SetXSHD()
    End Sub

    Private Sub SetXSHD()
        Dim path As String = AppDomain.CurrentDomain.BaseDirectory & "\RAIZIN7.xshd"
        If System.IO.File.Exists(path) Then
            Dim fsmp As New ICSharpCode.TextEditor.Document.FileSyntaxModeProvider(AppDomain.CurrentDomain.BaseDirectory)
            ICSharpCode.TextEditor.Document.HighlightingManager.Manager.AddSyntaxModeFileProvider(fsmp)
            TextEditorControl1.SetHighlighting("RAIZIN7")
        Else
            MsgBox(lang.XSHDisNotExists)
        End If
    End Sub

    Private Sub LineNumbersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LineNumbersToolStripMenuItem.Click
        LineNumbersToolStripMenuItem.Checked = Not LineNumbersToolStripMenuItem.Checked
    End Sub

    Private Sub LineNumbersToolStripMenuItem_CheckedChanged(sender As Object, e As EventArgs) Handles LineNumbersToolStripMenuItem.CheckedChanged
        Select Case LineNumbersToolStripMenuItem.Checked
            Case True
                TextEditorControl1.ShowLineNumbers = True
            Case False
                TextEditorControl1.ShowLineNumbers = False
        End Select
    End Sub

    Private Sub ShowTabsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowTabsToolStripMenuItem.Click
        ShowTabsToolStripMenuItem.Checked = Not ShowTabsToolStripMenuItem.Checked
    End Sub

    Private Sub ShowTabsToolStripMenuItem_CheckedChanged(sender As Object, e As EventArgs) Handles ShowTabsToolStripMenuItem.CheckedChanged
        Select Case ShowTabsToolStripMenuItem.Checked
            Case True
                TextEditorControl1.ShowTabs = True
            Case False
                TextEditorControl1.ShowTabs = False
        End Select
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        If FontDialog1.ShowDialog = DialogResult.OK Then
            TextEditorControl1.Font = FontDialog1.Font
        End If
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        FileChanged()
        changed = False
        Me.Text = lang.FormTitle
        suffix = String.Empty
        initilizeText = "//" & vbNewLine & "eve_start" & vbNewLine & "eve_end"
        TextEditorControl1.Text = initilizeText
        TextEditorControl1.Refresh()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        OpenScriptFile(lang.CodePage)
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        SaveScriptFile(lang.CodePage)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' 開啟腳本
    ''' </summary>
    Private Sub OpenScriptFile(ByVal codepage As Language.CodePageEnum)
        FileChanged()

        Dim textBytes As Byte()
        Using openFile As New OpenFileDialog
            openFile.Title = lang.OpenFileTitle
            openFile.Filter = lang.FileFilter
            If openFile.ShowDialog = DialogResult.OK Then
                textBytes = System.IO.File.ReadAllBytes(openFile.FileName)
                initilizeText = System.Text.Encoding.GetEncoding(codepage).GetString(textBytes)
                TextEditorControl1.Text = initilizeText
                suffix = " - [" & openFile.FileName & "]"
                Me.Text = lang.FormTitle & suffix
                changed = False
            End If
        End Using
    End Sub

    ''' <summary>
    ''' 儲存腳本
    ''' </summary>
    Private Sub SaveScriptFile(ByVal codepage As Language.CodePageEnum)
        Using saveFile As New SaveFileDialog
            saveFile.Title = lang.SaveFileTitle
            saveFile.Filter = lang.FileFilter
            If saveFile.ShowDialog = DialogResult.OK Then
                System.IO.File.WriteAllText(saveFile.FileName, TextEditorControl1.Text, System.Text.Encoding.GetEncoding(codepage))
                initilizeText = TextEditorControl1.Text
                suffix = " - [" & saveFile.FileName & "]"
                Me.Text = lang.FormTitle & suffix
                changed = False
            End If
        End Using
    End Sub

    Private Sub JapaneseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JapaneseToolStripMenuItem.Click
        CheckoutAllLanguage()
        JapaneseToolStripMenuItem.Checked = True
    End Sub

    Private Sub JapaneseToolStripMenuItem_CheckedChanged(sender As Object, e As EventArgs) Handles JapaneseToolStripMenuItem.CheckedChanged
        If JapaneseToolStripMenuItem.Checked = True Then
            lang = New Japanese
            ChangeLanguageFactory()
        End If
    End Sub

    Private Sub TraditionalChineseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TraditionalChineseToolStripMenuItem.Click
        CheckoutAllLanguage()
        TraditionalChineseToolStripMenuItem.Checked = True
    End Sub

    Private Sub TraditionalChineseToolStripMenuItem_CheckedChanged(sender As Object, e As EventArgs) Handles TraditionalChineseToolStripMenuItem.CheckedChanged
        If TraditionalChineseToolStripMenuItem.Checked = True Then
            lang = New TraditionalChinese
            ChangeLanguageFactory()
        End If
    End Sub

    Private Sub SimplifiedChineseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimplifiedChineseToolStripMenuItem.Click
        CheckoutAllLanguage()
        SimplifiedChineseToolStripMenuItem.Checked = True
    End Sub

    Private Sub SimplifiedChineseToolStripMenuItem_CheckedChanged(sender As Object, e As EventArgs) Handles SimplifiedChineseToolStripMenuItem.CheckedChanged
        If SimplifiedChineseToolStripMenuItem.Checked = True Then
            lang = New SimplifiedChinese
            ChangeLanguageFactory()
        End If
    End Sub

    Private Sub CheckoutAllLanguage()
        SimplifiedChineseToolStripMenuItem.Checked = False
        JapaneseToolStripMenuItem.Checked = False
        TraditionalChineseToolStripMenuItem.Checked = False
    End Sub

    Private Sub ChangeLanguageFactory()
        Me.Text = lang.FormTitle & GetChangedSuffix()
        FileToolStripMenuItem.Text = lang.File
        NewToolStripMenuItem.Text = lang.NewFile
        OpenToolStripMenuItem.Text = lang.Open
        SaveToolStripMenuItem.Text = lang.Save
        ExitToolStripMenuItem.Text = lang.Quit
        ViewToolStripMenuItem.Text = lang.View
        LanguageToolStripMenuItem.Text = lang.Language
        SimplifiedChineseToolStripMenuItem.Text = lang.SimplifiedChinese
        JapaneseToolStripMenuItem.Text = lang.Japanese
        TraditionalChineseToolStripMenuItem.Text = lang.TraditionalChinese
        FontToolStripMenuItem.Text = lang.Font
        LineNumbersToolStripMenuItem.Text = lang.LineNumbers
        ShowTabsToolStripMenuItem.Text = lang.ShowTabs
        HelpToolStripMenuItem.Text = lang.Help
        AboutToolStripMenuItem.Text = lang.About
    End Sub

    Private Function GetChangedSuffix() As String
        If changed Then
            Return suffix & " *"
        End If

        Return suffix
    End Function

    Private Sub TextEditorControl1_TextChanged(sender As Object, e As EventArgs) Handles TextEditorControl1.TextChanged
        If Not changed AndAlso Not TextEditorControl1.Text = initilizeText Then
            changed = True
            initilizeText = String.Empty
            Me.Text &= " *"
        End If
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        FileChanged()
    End Sub

    ''' <summary>
    ''' 檔案已變更，詢問是否儲存
    ''' </summary>
    Private Sub FileChanged()
        If changed Then
            If MessageBox.Show(lang.ChangedText, Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                SaveScriptFile(lang.CodePage)
            End If
        End If
    End Sub
End Class