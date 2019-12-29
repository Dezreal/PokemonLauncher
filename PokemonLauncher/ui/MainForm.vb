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

    Private Sub 版本说明ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 版本说明ToolStripMenuItem.Click
        Dim form = New VersionAbout With {.Visible = True}
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox22.Click
        Processor.Start(ini.GetVal("Emulator", "VisualBoyAdvance"), ini.GetVal("ROM", "银"))
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Processor.Start(ini.GetVal("Emulator", "VisualBoyAdvance"), ini.GetVal("ROM", "红"))
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        Processor.Start(ini.GetVal("Emulator", "VisualBoyAdvance"), ini.GetVal("ROM", "绿"))
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        Processor.Start(ini.GetVal("Emulator", "VisualBoyAdvance"), ini.GetVal("ROM", "蓝"))
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        Processor.Start(ini.GetVal("Emulator", "VisualBoyAdvance"), ini.GetVal("ROM", "皮卡丘"))
    End Sub

    Private Sub PictureBox21_Click(sender As Object, e As EventArgs) Handles PictureBox21.Click
        Processor.Start(ini.GetVal("Emulator", "VisualBoyAdvance"), ini.GetVal("ROM", "金"))
    End Sub

    Private Sub PictureBox23_Click(sender As Object, e As EventArgs) Handles PictureBox23.Click
        Processor.Start(ini.GetVal("Emulator", "VisualBoyAdvance"), ini.GetVal("ROM", "水晶"))
    End Sub

    Private Sub PictureBox41_Click(sender As Object, e As EventArgs) Handles PictureBox41.Click
        Processor.Start(ini.GetVal("Emulator", "DeSmuME"), ini.GetVal("ROM", "钻石"))
    End Sub

    Private Sub PictureBox42_Click(sender As Object, e As EventArgs) Handles PictureBox42.Click
        Processor.Start(ini.GetVal("Emulator", "DeSmuME"), ini.GetVal("ROM", "珍珠"))
    End Sub

    Private Sub PictureBox43_Click(sender As Object, e As EventArgs) Handles PictureBox43.Click
        Processor.Start(ini.GetVal("Emulator", "DeSmuME"), ini.GetVal("ROM", "白金"))
    End Sub

    Private Sub PictureBox44_Click(sender As Object, e As EventArgs) Handles PictureBox44.Click
        Processor.Start(ini.GetVal("Emulator", "DeSmuME"), ini.GetVal("ROM", "心金"))
    End Sub

    Private Sub PictureBox45_Click(sender As Object, e As EventArgs) Handles PictureBox45.Click
        Processor.Start(ini.GetVal("Emulator", "DeSmuME"), ini.GetVal("ROM", "魂银"))
    End Sub

    Private Sub PictureBox51_Click(sender As Object, e As EventArgs) Handles PictureBox51.Click
        Processor.Start(ini.GetVal("Emulator", "DeSmuME"), ini.GetVal("ROM", "黑"))
    End Sub

    Private Sub PictureBox52_Click(sender As Object, e As EventArgs) Handles PictureBox52.Click
        Processor.Start(ini.GetVal("Emulator", "DeSmuME"), ini.GetVal("ROM", "白"))
    End Sub

    Private Sub PictureBox53_Click(sender As Object, e As EventArgs) Handles PictureBox53.Click
        Processor.Start(ini.GetVal("Emulator", "DeSmuME"), ini.GetVal("ROM", "黑2"))
    End Sub

    Private Sub PictureBox54_Click(sender As Object, e As EventArgs) Handles PictureBox54.Click
        Processor.Start(ini.GetVal("Emulator", "DeSmuME"), ini.GetVal("ROM", "白2"))
    End Sub

    Private Sub PictureBox61_Click(sender As Object, e As EventArgs) Handles PictureBox61.Click
        Processor.Start(ini.GetVal("Emulator", "3ds"), ini.GetVal("ROM", "X"))
    End Sub

    Private Sub PictureBox62_Click(sender As Object, e As EventArgs) Handles PictureBox62.Click
        Processor.Start(ini.GetVal("Emulator", "3ds"), ini.GetVal("ROM", "Y"))
    End Sub

    Private Sub PictureBox63_Click(sender As Object, e As EventArgs) Handles PictureBox63.Click
        Processor.Start(ini.GetVal("Emulator", "3ds"), ini.GetVal("ROM", "欧米伽红宝石"))
    End Sub

    Private Sub PictureBox64_Click(sender As Object, e As EventArgs) Handles PictureBox64.Click
        Processor.Start(ini.GetVal("Emulator", "3ds"), ini.GetVal("ROM", "阿尔法蓝宝石"))
    End Sub

    Private Sub PictureBox71_Click(sender As Object, e As EventArgs) Handles PictureBox71.Click
        Processor.Start(ini.GetVal("Emulator", "3ds"), ini.GetVal("ROM", "太阳"))
    End Sub

    Private Sub PictureBox72_Click(sender As Object, e As EventArgs) Handles PictureBox72.Click
        Processor.Start(ini.GetVal("Emulator", "3ds"), ini.GetVal("ROM", "月亮"))
    End Sub

    Private Sub PictureBox73_Click(sender As Object, e As EventArgs) Handles PictureBox73.Click
        Processor.Start(ini.GetVal("Emulator", "3ds"), ini.GetVal("ROM", "究极之日"))
    End Sub

    Private Sub PictureBox74_Click(sender As Object, e As EventArgs) Handles PictureBox74.Click
        Processor.Start(ini.GetVal("Emulator", "3ds"), ini.GetVal("ROM", "究极之月"))
    End Sub

    Private Sub PictureBox81_Click(sender As Object, e As EventArgs) Handles PictureBox81.Click
        Processor.Start(ini.GetVal("Emulator", "switch"), ini.GetVal("ROM", "剑"))
    End Sub

    Private Sub PictureBox82_Click(sender As Object, e As EventArgs) Handles PictureBox82.Click
        Processor.Start(ini.GetVal("Emulator", "switch"), ini.GetVal("ROM", "盾"))
    End Sub

End Class
