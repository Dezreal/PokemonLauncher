Public Class ExplorerDialog

    Public Shared Function OpenFile() As String
        Using ofd = New OpenFileDialog
            If ofd.ShowDialog = DialogResult.OK Then
                Return ofd.FileName
            End If
            Return Nothing
        End Using
    End Function

    Public Shared Function FolderBrower(description As String, Optional ByVal ShowNewFolder As Boolean = False) As String
        Using fb = New FolderBrowserDialog
            fb.Description = description
            fb.ShowNewFolderButton = ShowNewFolder
            If fb.ShowDialog = DialogResult.OK Then
                Return fb.SelectedPath
            End If
            Return Nothing
        End Using
    End Function

End Class
