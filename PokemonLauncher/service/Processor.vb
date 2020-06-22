Public Class Processor
    Public Shared Sub Start(ByVal emulator As String, ByVal ROM As String)
        If emulator = "" Then
            MsgBox("请先设置模拟器路径！")
            Return
        End If
        Try
            emulator = """" & emulator & """"
            If ROM = "" Then
                MsgBox("未设置ROM路径，将仅启动模拟器！")
            Else
                ROM = """" & ROM & """"
            End If
            Process.Start(emulator, ROM)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
