Public Class MainForm

    Private p2 As Form2
    Private settingForm As SettingForm
    Public Shared ini As IniService = IniService.GetSingletonInstance

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        p2 = New Form2
        settingForm = New SettingForm(Application.StartupPath + "/Pokemon.ini")
        GenerationTab.SelectedIndex = ini.GetVal("Component", "GenerationTabIndex")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim f As New OpenFileDialog()
        If f.ShowDialog() = DialogResult.OK Then
            MsgBox(f.FileName)
        End If

    End Sub

    Private Sub 设置ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 设置ToolStripMenuItem.Click
        settingForm.Visible = True
    End Sub

    Private Sub GenerationTab_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GenerationTab.SelectedIndexChanged
        ini.SetVal("Component", "GenerationTabIndex", GenerationTab.SelectedIndex)
    End Sub

    Private Sub PictureBox34_Click(sender As Object, e As EventArgs) Handles PictureBox34.Click
        Process.Start(ini.GetVal("Emulator", "VBA"), ini.GetVal("ROM", "LeafGreen"))
    End Sub
End Class
