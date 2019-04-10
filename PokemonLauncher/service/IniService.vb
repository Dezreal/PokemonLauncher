Public Class IniService
    Private iniIO As IniIO
    Private Shared ReadOnly ini As IniService = New IniService
    Private Sub New()
        iniIO = New IniIO(Application.StartupPath + "/PokemonLauncher.ini")
    End Sub
    Public Shared Function GetSingletonInstance() As IniService
        Return ini
    End Function
    Public Function GetVal(ByVal section As String, appName As String) As String
        Return iniIO.GetINI(section, appName, "")
    End Function
    Public Sub SetVal(section As String, appName As String, value As String)
        iniIO.WriteINI(section, appName, value)
    End Sub
End Class
