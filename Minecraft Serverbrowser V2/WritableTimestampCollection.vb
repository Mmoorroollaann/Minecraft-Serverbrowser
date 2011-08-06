Friend Module WritableTimestampCollection

    Private WithEvents Hans As New WebBrowser()
    Private Const Path As String = "http://www.minecraftforum.net/viewtopic.php?f=25&t=88783"
    Private Done_Loading As Boolean = False
    Friend Ready_To_Serve As Boolean = False
    Friend UpdateAvailable As Boolean = Nothing

    Friend Sub is_Update_Available()

        UpdateAvailable = Nothing
        Ready_To_Serve = False

        Try

            Hans.Navigate(Path)

            Do
                Application.DoEvents()
            Loop Until Done_Loading = True

            Dim BodyText As String = Hans.Document.Body.InnerText

            If BodyText = Nothing Then
                MsgBox("Could not check for updates, please try again later")
                Exit Sub
            End If

            BodyText = BodyText.Remove(BodyText.IndexOf(CChar("]")))
            BodyText = BodyText.Remove(0, BodyText.IndexOf(CChar("[")) + 1)
            BodyText.Trim()

            If BodyText <> My.Application.Info.Version.ToString(3) Then
                UpdateAvailable = True
            Else
                UpdateAvailable = False
            End If

        Catch ex As Exception

            MsgBox("Could not check for updates. Try again later please." & vbCrLf & ex.Message)

        Finally

            Ready_To_Serve = True

        End Try

    End Sub

    Private Sub Hans_DocumentCompleted(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles Hans.DocumentCompleted

        Done_Loading = True

    End Sub

End Module
