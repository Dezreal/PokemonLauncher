Public Class IniIO
    Private iniPath As String

    Public Sub New(ByVal path As String)
        Me.iniPath = path
    End Sub


    Public Function GetINI(ByVal Section As String, ByVal AppName As String, ByVal lpDefault As String) As String
        Dim Str As String = LSet(Str, 256)
        GetPrivateProfileString(Section, AppName, lpDefault, Str, Len(Str), iniPath)
        Return Left(Str, InStr(Str, Chr(0)) - 1)
    End Function
    Public Function WriteINI(ByVal Section As String, ByVal AppName As String, ByVal lpDefault As String) As Long
        WriteINI = WritePrivateProfileString(Section, AppName, lpDefault, iniPath)
    End Function
    Private Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Int32, ByVal lpFileName As String) As Int32
    Private Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Int32

End Class
