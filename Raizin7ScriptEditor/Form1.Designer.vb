<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TextEditorControl1 = New ICSharpCode.TextEditor.TextEditorControl()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LineNumbersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowTabsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LanguageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SimplifiedChineseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JapaneseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TraditionalChineseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextEditorControl1
        '
        Me.TextEditorControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextEditorControl1.IsReadOnly = False
        Me.TextEditorControl1.Location = New System.Drawing.Point(0, 24)
        Me.TextEditorControl1.Name = "TextEditorControl1"
        Me.TextEditorControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextEditorControl1.ShowMatchingBracket = False
        Me.TextEditorControl1.ShowVRuler = False
        Me.TextEditorControl1.Size = New System.Drawing.Size(800, 426)
        Me.TextEditorControl1.TabIndex = 0
        Me.TextEditorControl1.Text = "//" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "eve_start" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "eve_end"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ViewToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.FileToolStripMenuItem.Text = "檔案(&F)"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.NewToolStripMenuItem.Text = "開新檔案(&N)"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.OpenToolStripMenuItem.Text = "開啟舊檔(&O)..."
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.SaveToolStripMenuItem.Text = "儲存檔案(&S)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(148, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.ExitToolStripMenuItem.Text = "結束(&X)"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FontToolStripMenuItem, Me.LineNumbersToolStripMenuItem, Me.ShowTabsToolStripMenuItem, Me.LanguageToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ViewToolStripMenuItem.Text = "檢視(&V)"
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.FontToolStripMenuItem.Text = "字型(&F)..."
        '
        'LineNumbersToolStripMenuItem
        '
        Me.LineNumbersToolStripMenuItem.Checked = True
        Me.LineNumbersToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.LineNumbersToolStripMenuItem.Name = "LineNumbersToolStripMenuItem"
        Me.LineNumbersToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.LineNumbersToolStripMenuItem.Text = "行號(&N)"
        '
        'ShowTabsToolStripMenuItem
        '
        Me.ShowTabsToolStripMenuItem.Name = "ShowTabsToolStripMenuItem"
        Me.ShowTabsToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.ShowTabsToolStripMenuItem.Text = "顯示Tab空白(&T)"
        '
        'LanguageToolStripMenuItem
        '
        Me.LanguageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SimplifiedChineseToolStripMenuItem, Me.JapaneseToolStripMenuItem, Me.TraditionalChineseToolStripMenuItem})
        Me.LanguageToolStripMenuItem.Name = "LanguageToolStripMenuItem"
        Me.LanguageToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.LanguageToolStripMenuItem.Text = "語言(&L)"
        '
        'SimplifiedChineseToolStripMenuItem
        '
        Me.SimplifiedChineseToolStripMenuItem.Name = "SimplifiedChineseToolStripMenuItem"
        Me.SimplifiedChineseToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.SimplifiedChineseToolStripMenuItem.Text = "簡體中文(&S)"
        '
        'JapaneseToolStripMenuItem
        '
        Me.JapaneseToolStripMenuItem.Name = "JapaneseToolStripMenuItem"
        Me.JapaneseToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.JapaneseToolStripMenuItem.Text = "日本語(&J)"
        '
        'TraditionalChineseToolStripMenuItem
        '
        Me.TraditionalChineseToolStripMenuItem.Name = "TraditionalChineseToolStripMenuItem"
        Me.TraditionalChineseToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.TraditionalChineseToolStripMenuItem.Text = "繁體中文(&T)"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.HelpToolStripMenuItem.Text = "說明(&H)"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.AboutToolStripMenuItem.Text = "關於(&A)..."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextEditorControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "雷神7腳本編輯器"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextEditorControl1 As ICSharpCode.TextEditor.TextEditorControl
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LineNumbersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents LanguageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimplifiedChineseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JapaneseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TraditionalChineseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowTabsToolStripMenuItem As ToolStripMenuItem
End Class
