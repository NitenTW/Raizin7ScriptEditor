Public MustInherit Class Language
    ''' <summary>
    ''' 文字編碼頁
    ''' </summary>
    Public Enum CodePageEnum
        SimplifiedChinese = 936
        Japanese = 932
        TraditionalChinese = 950
    End Enum

    Public FormTitle As String
    Public File As String
    Public NewFile As String
    Public Open As String
    Public Save As String
    Public Quit As String
    Public View As String
    Public Language As String
    Public SimplifiedChinese As String
    Public Japanese As String
    Public TraditionalChinese As String
    Public Font As String
    Public LineNumbers As String
    Public ShowTabs As String
    Public Help As String
    Public About As String
    Public XSHDisNotExists As String
    Public OpenFileTitle As String
    Public SaveFileTitle As String
    Public FileFilter As String
    Public ChangedText As String
    Public CodePage As CodePageEnum
End Class

Public Class SimplifiedChinese
    Inherits Language

    Public Sub New()
        FormTitle = "雷神7脚本编辑器"
        File = "文件(&F)"
        NewFile = "开新文件(&N)"
        Open = "开启文件(&O)..."
        Save = "保存文件(&S)"
        Quit = "退出(&X)"
        View = "查看(&V)"
        Language = "语言(&N)"
        SimplifiedChinese = "简体中文(&S)"
        Japanese = "日文(&J)"
        TraditionalChinese = "繁体中文(&T)"
        Font = "字体(&F)"
        LineNumbers = "行号(&N)"
        ShowTabs = "显示Tab空白(&T)"
        Help = "帮助(&H)"
        About = "关於(&A)..."
        XSHDisNotExists = "RAIZIN7.xshd 文件档不存在，无法显示高亮"
        OpenFileTitle = "开启脚本"
        SaveFileTitle = "储存脚本"
        FileFilter = "雷神7脚本文件|*.txt"
        ChangedText = "脚本已变更，要保存脚本吗？"
        CodePage = CodePageEnum.SimplifiedChinese
    End Sub
End Class

Public Class Japanese
    Inherits Language

    Public Sub New()
        FormTitle = "雷神7スクリプトエディタ"
        File = "ファイル(&F)"
        NewFile = "新規(&N)"
        Open = "開く(&O)..."
        Save = "保存(&S)"
        Quit = "終了(&X)"
        View = "表示(&V)"
        Language = "言語(&N)"
        SimplifiedChinese = "簡体中国語(&S)"
        Japanese = "日本語(&J)"
        TraditionalChinese = "繁体中国語(&T)"
        Font = "フォント(&F)"
        LineNumbers = "行番号が表示する(&N)"
        ShowTabs = "Tabスペースがが表示する(&T)"
        Help = "ヘルプ(&H)"
        About = "バージョン情報(&A)..."
        XSHDisNotExists = "RAIZIN7.xshd が存在しない。ハイライトが表示できない"
        OpenFileTitle = "スクリプトを開く"
        SaveFileTitle = "スクリプトを保存する"
        FileFilter = "雷神7スクリプトファイル|*.txt"
        ChangedText = "スクリプトもう変更しました、保存しますか？"
        CodePage = CodePageEnum.Japanese
    End Sub
End Class

Public Class TraditionalChinese
    Inherits Language

    Public Sub New()
        FormTitle = "雷神7腳本編輯器"
        File = "檔案(&F)"
        NewFile = "開新檔案(&N)"
        Open = "開啟舊檔(&O)..."
        Save = "儲存檔案(&S)"
        Quit = "結束(&X)"
        View = "檢視(&V)"
        Language = "語言(&N)"
        SimplifiedChinese = "簡體中文(&S)"
        Japanese = "日文(&J)"
        TraditionalChinese = "繁體中文(&T)"
        Font = "字型(&F)"
        LineNumbers = "行號(&N)"
        ShowTabs = "顯示Tab空白(&T)"
        Help = "說明(&H)"
        About = "關於(&A)..."
        XSHDisNotExists = "RAIZIN7.xshd 檔案不存在。無法顯示高亮"
        OpenFileTitle = "開啟腳本"
        SaveFileTitle = "儲存腳本"
        FileFilter = "雷神7腳本檔案|*.txt"
        ChangedText = "腳本已變更，要儲存腳本嗎？"
        CodePage = CodePageEnum.TraditionalChinese
    End Sub
End Class