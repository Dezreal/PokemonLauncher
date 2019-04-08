Public Class SettingForm

    Private ini As IniService

    Public Sub New(path)
        InitializeComponent()
        ini = IniService.GetSingletonInstance

    End Sub

    Private Sub SettingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateComp()
    End Sub

    Private Sub UpdateComp()
        TextBox1.Text = ini.GetVal("GameRoot", "Path")
        TextBox2.Text = ini.GetVal("Emulator", "VBA")
        TextBox3.Text = ini.GetVal("ROM", "LeafGreen")
    End Sub

    Private Function SelectFolder(ByVal Describe As String, Optional ByVal ShowNewFolder As Boolean = True) As String
        Using nOpen As New System.Windows.Forms.FolderBrowserDialog()
            nOpen.Description = Describe
            nOpen.ShowNewFolderButton = ShowNewFolder
            nOpen.ShowDialog()
            Return nOpen.SelectedPath
        End Using
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim path As String = SelectFolder("选择Pokemon的根目录", False)
        If path.Length > 0 Then
            ini.SetVal("GameRoot", "Path", path)
            UpdateComp()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Using f As New OpenFileDialog()
            If f.ShowDialog() = DialogResult.OK Then
                ini.SetVal("Emulator", "VBA", f.FileName)
                UpdateComp()
            End If
        End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Using f As New OpenFileDialog()
            If f.ShowDialog() = DialogResult.OK Then
                ini.SetVal("ROM", "LeafGreen", f.FileName)
                UpdateComp()
            End If
        End Using
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs)

    End Sub
End Class