Public Class Processor
    Public Shared Sub Start(ByVal emulator As String, ByVal ROM As String)
        Dim proc As New Process
        proc.StartInfo.FileName = emulator
        proc.StartInfo.Arguments = ROM
        proc.Start()
    End Sub
End Class
