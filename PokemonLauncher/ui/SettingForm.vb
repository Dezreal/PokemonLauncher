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
            item.SubItems(2).Text = ini.GetVal(item.Group.Header, item.SubItems(1).Text)
        Next
    End Sub

    Private Sub ListView1_Click(sender As Object, e As EventArgs) Handles ListView1.Click
        Dim items = ListView1.SelectedItems
        If items.Count = 1 Then
            Dim path = ExplorerDialog.OpenFile
            If path IsNot Nothing Then
                items(0).SubItems(2).Text = path
                ini.SetVal(items(0).Group.Header, items(0).SubItems(1).Text, path)
            End If
        End If

    End Sub

    Private Sub SettingForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        MainForm.Enabled = True
    End Sub

    'Private Sub ListView1_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles ListView1.ColumnClick
    '    MsgBox("ColumnClick")
    'End Sub

    'Private Sub ListView1_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles ListView1.ItemSelectionChanged
    '    MsgBox("ItemSelectionChanged")
    'End Sub
End Class