Public Class VersionAbout
    Private Sub VersionAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Label1.Text = StreamIO.ReadFile("features.txt")
        Catch ex As Exception
            StreamIO.AppendFile("log.txt", Format(Now, "yyyy-MM-dd hh:mm:ss " + ex.Message + vbCrLf))
        End Try
    End Sub
End Class