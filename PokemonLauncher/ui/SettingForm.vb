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
        For Each item As ListViewItem In ListView1.Items
            item.SubItems(1).Text = ini.GetVal(item.Group.Header, item.Text)
        Next
    End Sub

    Private Sub ListView1_Click(sender As Object, e As EventArgs) Handles ListView1.Click
        Dim items = ListView1.SelectedItems
        If items.Count = 1 Then
            Dim path = ExplorerDialog.OpenFile
            If path IsNot Nothing Then
                items(0).SubItems(1).Text = path
                ini.SetVal(items(0).Group.Header, items(0).Text, path)
            End If
        End If

    End Sub

    Private Sub SettingForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        MainForm.Enabled = True
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim view = (ListView1.View + 1) Mod 5
        If (view = 2 Or view = 3) Then
            view = 4
        End If
        ListView1.View = view
    End Sub

End Class