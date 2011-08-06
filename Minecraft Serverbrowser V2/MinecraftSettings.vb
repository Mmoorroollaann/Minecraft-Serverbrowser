Public Class MinecraftSettings

    Private Path As String
    Private Text As New List(Of String)

    Sub New(Optional ByVal Path As String = Nothing)

        If Path Is Nothing Then
            Me.Path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\.minecraft\options.txt"
        Else
            Me.Path = Path
        End If

        If IO.File.Exists(Me.Path) = False Then
            Throw New IO.FileNotFoundException("Could not find options.txt at the following position: " & Me.Path)
        End If

        Load_Lines()

    End Sub

    Private Sub Load_Lines()

        Dim Reader As New IO.StreamReader(Me.Path)

        Do While Reader.EndOfStream = False
            Text.Add(Reader.ReadLine)
        Loop

        Reader.Close()

    End Sub

    Friend Sub Change_Line(ByVal line As Integer, ByVal NewText As String)

        Text(line - 1) = NewText

        Dim Stream As New IO.FileStream(Me.Path, IO.FileMode.Create)
        Dim Writer As New IO.StreamWriter(Stream)

        For i = 0 To Text.Count - 1
            Writer.WriteLine(Text(i))
        Next

        Writer.Flush()
        Writer.Close()

    End Sub

End Class
