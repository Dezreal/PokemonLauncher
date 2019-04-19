Imports System.IO

Public Class StreamIO

    Public Shared Sub WriteFile(filename As String, text As String)
        Dim sw = New StreamWriter(Application.StartupPath & "/" & filename)
        sw.Write(text)
        sw.Close()
    End Sub

    Public Shared Function ReadFile(filename As String) As String
        Dim sr = New StreamReader(Application.StartupPath & "/" & filename)
        Return sr.ReadToEnd
    End Function

    Public Shared Sub AppendFile(filename As String, text As String)
        Dim sw = New StreamWriter(Application.StartupPath & "/" & filename, True)
        sw.Write(text)
        sw.Close()
    End Sub

End Class
