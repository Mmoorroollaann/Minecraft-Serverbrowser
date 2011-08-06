''' <summary>
''' A basic class, containing some unspecific methods and objects. Mustinherit!
''' </summary>
''' <remarks></remarks>
Public MustInherit Class Serverlist


#Region "Deklarationen"

    Protected Path As String
    ''' <summary>
    ''' A list of servers the list contains - D'OH
    ''' </summary>
    ''' <remarks></remarks>
    Public ListOfServers As New List(Of Server)
    Protected _ListOfServers As New List(Of Server)



#End Region

#Region "New"



#End Region

#Region "Manage Database"

#End Region

#Region "Manage Data"

#End Region

#Region "Manage lists"

    ''' <summary>
    ''' Clears the public list.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Clear_Public_List()
        ListOfServers.Clear()
    End Sub

    Protected Sub Clear_Private_List()
        _ListOfServers.Clear()
    End Sub

    ''' <summary>
    ''' Adds the contents of the private list to the public list.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Sync_Lists()

        ListOfServers.Clear()

        For i = 0 To _ListOfServers.Count - 1
            ListOfServers.Add(_ListOfServers(i))
        Next

    End Sub

#End Region


End Class
