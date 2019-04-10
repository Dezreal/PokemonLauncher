Public Class Processor
    Public Shared Sub Start(ByVal emulator As String, ByVal ROM As String)
        If ROM = "" Then
            MsgBox("启动失败，请检查ROM路径设置！")
            Return
        End If
        Try
            emulator = """" & emulator & """"
            ROM = """" & ROM & """"
            Process.Start(emulator, ROM)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
