Public Class MainForm

    Public Shared ini As IniService = IniService.GetSingletonInstance

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            GenerationTab.SelectedIndex = ini.GetVal("Component", "GenerationTabIndex")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Dim f As New OpenFileDialog()
        If f.ShowDialog() = DialogResult.OK Then
            MsgBox(f.FileName)
        End If
    End Sub

    Private Sub GenerationTab_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GenerationTab.SelectedIndexChanged
        ini.SetVal("Component", "GenerationTabIndex", GenerationTab.SelectedIndex)
    End Sub

    Private Sub 退出ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 退出ToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub 游戏路径设置ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 游戏路径设置ToolStripMenuItem.Click
        Dim form = New SettingForm(Application.StartupPath + "/Pokemon.ini") With {.Visible = True}
        Enabled = False
    End Sub

    Private Sub 关于PokemonStarterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 关于PokemonStarterToolStripMenuItem.Click
        Dim form = New About With {.Visible = True}
    End Sub

    Private Sub PictureBox31_Click(sender As Object, e As EventArgs) Handles PictureBox31.Click
        Processor.Start(ini.GetVal("Emulator", "VisualBoyAdvance"), ini.GetVal("ROM", "红宝石"))
    End Sub

    Private Sub PictureBox32_Click(sender As Object, e As EventArgs) Handles PictureBox32.Click
        Processor.Start(ini.GetVal("Emulator", "VisualBoyAdvance"), ini.GetVal("ROM", "蓝宝石"))
    End Sub

    Private Sub PictureBox33_Click(sender As Object, e As EventArgs) Handles PictureBox33.Click
        Processor.Start(ini.GetVal("Emulator", "VisualBoyAdvance"), ini.GetVal("ROM", "火红"))
    End Sub

    Private Sub PictureBox34_Click(sender As Object, e As EventArgs) Handles PictureBox34.Click
        Processor.Start(ini.GetVal("Emulator", "VisualBoyAdvance"), ini.GetVal("ROM", "叶绿"))
    End Sub

    Private Sub PictureBox35_Click(sender As Object, e As EventArgs) Handles PictureBox35.Click
        Processor.Start(ini.GetVal("Emulator", "VisualBoyAdvance"), ini.GetVal("ROM", "绿宝石"))
    End Sub
End Class
