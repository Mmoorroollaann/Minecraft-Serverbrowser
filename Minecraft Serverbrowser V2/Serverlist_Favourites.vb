Imports System.IO
Imports System.Xml

''' <summary>
''' A class used to store the users favourites.
''' </summary>
''' <remarks></remarks>
Public Class Serverlist_Favourites
    Inherits Serverlist

#Region "Deklarationen"

#Region "Comparer"

    Private Comparer As IComparer
    Private comparison As Comparison(Of Server)

#End Region

#End Region

#Region "New"

    ''' <summary>
    ''' Creates a new instance of the class.
    ''' </summary>
    ''' <param name="Path">The path to where the favourites should be saved to / will be read from.</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Path As String)

        Me.Path = Path
        ' If there is no database yet, there will be created an empty one.
        If File.Exists(Path) = False Then
            Create_Database()
        End If

    End Sub

#End Region

#Region "Manage Database"

    Private Sub Create_Database()

        Dim settings As New XmlWriterSettings

        settings.Indent = True
        settings.NewLineOnAttributes = False

        Using writer As XmlWriter = XmlWriter.Create(Path, settings)

            writer.WriteStartDocument()
            writer.WriteStartElement("Favourites")
            writer.WriteEndElement()
            writer.WriteEndDocument()

        End Using

    End Sub

    ''' <summary>
    ''' Reads the servers from the specified path.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Read_Database_FromXML()

        Dim document As New XmlDocument
        Dim node As XmlNode
        Dim subnode As XmlNode
        Dim attribute As XmlAttribute

        Clear_Private_List()
        Clear_Public_List()

        document.Load(Path)

        For Each node In document.DocumentElement

            Dim NewServer As New Server()

            For Each attribute In node.Attributes
                Select Case attribute.Name
                    Case "ID"
                        NewServer.ID = CInt(attribute.Value)
                End Select
            Next

            For Each subnode In node.ChildNodes

                Select Case subnode.Name
                    Case "Name"
                        NewServer.ServerName = subnode.InnerText
                    Case "IP"
                        NewServer.IP = subnode.InnerText
                    Case "Uptime"
                        NewServer._Uptime = CType(subnode.InnerText, Single)
                    Case "Website"
                        NewServer.Website = CBool(subnode.InnerXml)
                    Case "WebsiteURL"
                        NewServer.WebsiteURL = subnode.InnerText
                    Case "Thread"
                        NewServer.Thread = CBool(subnode.InnerText)
                    Case "ThreadURL"
                        NewServer.ThreadURL = subnode.InnerText
                    Case "Description"
                        NewServer.Description = subnode.InnerText
                    Case "Modified"
                        NewServer.Modified = CBool(subnode.InnerText)
                    Case "Rights"
                        NewServer.Rights = CBool(subnode.InnerText)
                    Case "Whitelist"
                        NewServer.Whitelist = CBool(subnode.InnerText)
                    Case "Pay"
                        NewServer.Pay = CBool(subnode.InnerText)
                    Case Else
                        MsgBox("Something somewhere went terribly wrong")
                End Select

            Next

            _ListOfServers.Add(NewServer)

        Next

        ' Wichtig: Sort_list VOR Compress_ID, ansonsten würde die benutzerdefinierte Reihenfolge zerstört werden.
        Sort_list()
        Sync_Lists()
        Compress_ID()

    End Sub

#End Region

#Region "Manage lists"

    Private Sub Compress_ID()

        ' Falls die DB aktualisiert wurde, wird ReadAgain = true gesetzt, und dann die DB nochmals gelesen.
        Dim ReadAgain As Boolean = False

        For i = 0 To _ListOfServers.Count - 1
            If _ListOfServers(i).ID <> i + 1 Then
                Change_ID(_ListOfServers(i).ID, i + 1)
                ReadAgain = True
            End If
        Next

        If ReadAgain = True Then
            ReadAgain = False
            Read_Database_FromXML()
        End If

    End Sub

    Friend Sub Change_ID(ByVal IDToChangeFrom As Integer, ByVal IDToChangeTo As Integer)

        Dim Document As New XmlDocument
        Dim Node As XmlNode
        Dim Attribut As XmlAttribute

        Document.Load(Path)


        For Each Node In Document.DocumentElement
            For Each Attribut In Node.Attributes
                If Attribut.Name = "ID" And CInt(Attribut.Value) = IDToChangeFrom Then
                    Attribut.Value = IDToChangeTo.ToString
                    Document.Save(Path)
                    Exit Sub
                End If
            Next
        Next

    End Sub

    Friend Sub CrossChange_ID(ByVal ID1 As Integer, ByVal ID2 As Integer)

        Dim Document As New XmlDocument
        Dim Node As XmlNode
        Dim Attribut As XmlAttribute

        Document.Load(Path)


        For Each Node In Document.DocumentElement
            For Each Attribut In Node.Attributes
                If Attribut.Name = "ID" And CInt(Attribut.Value) = ID1 Then
                    Attribut.Value = ID2.ToString
                ElseIf Attribut.Name = "ID" And CInt(Attribut.Value) = ID2 Then
                    Attribut.Value = ID1.ToString
                End If
            Next
        Next


        Document.Save(Path)

    End Sub

    Private Sub Sort_list()

        _ListOfServers.Sort(New Vergleich)

    End Sub

#End Region

#Region "Manage servers"

    ''' <summary>
    ''' Adds a new server to the favourites-database.
    ''' </summary>
    ''' <param name="Server">Server to add to the database.</param>
    ''' <remarks></remarks>
    Public Sub Add_Server(ByVal Server As Server)

        Dim document As New XmlDocument()
        Dim Favourite As XmlNode
        Dim xmlID As XmlAttribute
        Dim xmlIP As XmlNode
        Dim xmlName As XmlNode
        Dim xmlUptime As XmlNode
        Dim xmlWebsite As XmlNode
        Dim xmlWebsiteURL As XmlNode
        Dim xmlThread As XmlNode
        Dim xmlThreadUrl As XmlNode
        Dim xmlDescription As XmlNode
        Dim xmlModifed As XmlNode
        Dim xmlRights As XmlNode
        Dim xmlWhitelist As XmlNode
        Dim xmlPay As XmlNode

        document.Load(Path)

        Favourite = document.CreateElement("Favourite")


        xmlID = document.CreateAttribute("ID")
        xmlID.Value = CStr(Highest_ID() + 1)
        Favourite.Attributes.Append(xmlID)


        xmlIP = document.CreateElement("IP")
        xmlIP.AppendChild(document.CreateTextNode(Server.IP))
        Favourite.AppendChild(xmlIP)

        xmlName = document.CreateElement("Name")
        xmlName.AppendChild(document.CreateTextNode(Server.ServerName))
        Favourite.AppendChild(xmlName)

        xmlUptime = document.CreateElement("Uptime")
        xmlUptime.AppendChild(document.CreateTextNode(CStr(Server.Uptime)))
        Favourite.AppendChild(xmlUptime)


        xmlWebsite = document.CreateElement("Website")
        xmlWebsite.AppendChild(document.CreateTextNode(CStr(Server.Website)))
        Favourite.AppendChild(xmlWebsite)

        xmlWebsiteURL = document.CreateElement("WebsiteURL")
        xmlWebsiteURL.AppendChild(document.CreateTextNode(Server.WebsiteURL))
        Favourite.AppendChild(xmlWebsiteURL)


        xmlThread = document.CreateElement("Thread")
        xmlThread.AppendChild(document.CreateTextNode(CStr(Server.Thread)))
        Favourite.AppendChild(xmlThread)

        xmlThreadUrl = document.CreateElement("ThreadURL")
        xmlThreadUrl.AppendChild(document.CreateTextNode(Server.ThreadURL))
        Favourite.AppendChild(xmlThreadUrl)


        xmlDescription = document.CreateElement("Description")
        xmlDescription.AppendChild(document.CreateTextNode(Server.Description))
        Favourite.AppendChild(xmlDescription)


        xmlModifed = document.CreateElement("Modified")
        xmlModifed.AppendChild(document.CreateTextNode(Server.Modified.ToString))
        Favourite.AppendChild(xmlModifed)

        xmlRights = document.CreateElement("Rights")
        xmlRights.AppendChild(document.CreateTextNode(Server.Rights.ToString))
        Favourite.AppendChild(xmlRights)

        xmlWhitelist = document.CreateElement("Whitelist")
        xmlWhitelist.AppendChild(document.CreateTextNode(Server.Whitelist.ToString))
        Favourite.AppendChild(xmlWhitelist)

        xmlPay = document.CreateElement("Pay")
        xmlPay.AppendChild(document.CreateTextNode(Server.Pay.ToString))
        Favourite.AppendChild(xmlPay)

        document.ChildNodes(1).AppendChild(Favourite)

        document.Save(Path)

    End Sub

    ''' <summary>
    ''' Deletes a server from the favourites database.
    ''' </summary>
    ''' <param name="ID">The ID of the server to delete.</param>
    ''' <remarks></remarks>
    Public Overloads Sub Delete_Server(ByVal ID As Integer)

        Dim Dokument As New XmlDocument
        Dim Node As XmlNode
        Dim Attribut As XmlAttribute

        Dokument.Load(Path)

        For Each Node In Dokument.DocumentElement
            For Each Attribut In Node.Attributes
                If Attribut.Name = "ID" And Attribut.Value = ID.ToString Then
                    Node.RemoveAll()
                    Dokument.DocumentElement.RemoveChild(Node)
                    Dokument.Save(Path)
                    ' Da man ja nur eine Vokabel löschen will, (und die id eindeutig ist), kann man, sobald sie gelöscht wurde, die Sub verlassen.
                    Exit Sub
                End If
            Next
        Next

    End Sub

    ''' <summary>
    ''' Deletes a server from the favourites database.
    ''' </summary>
    ''' <param name="ServerToDelete">The server to delete from the database.</param>
    ''' <remarks></remarks>
    Public Overloads Sub Delete_Server(ByVal ServerToDelete As Server)
        Delete_Server(ServerToDelete.ID)
    End Sub

    ''' <summary>
    ''' Changes the information of a server in the favourites database.
    ''' </summary>
    ''' <param name="OldServer">The server which contains the old informations.</param>
    ''' <param name="NewServer">The server which contains the new informations.</param>
    ''' <remarks></remarks>
    Public Sub Change_Server(ByVal OldServer As Server, ByVal NewServer As Server)

        Dim Dokument As New XmlDocument
        Dim Node As XmlNode
        Dim Attribut As XmlAttribute
        Dim Subnode As XmlNode

        Dokument.Load(Path)


        For Each Node In Dokument.DocumentElement
            For Each Attribut In Node.Attributes
                If Attribut.Name = "ID" And Attribut.Value = CStr(OldServer.ID) Then
                    For Each Subnode In Node.ChildNodes
                        Select Case Subnode.Name
                            Case "IP"
                                Subnode.InnerText = NewServer.IP
                            Case "Name"
                                Subnode.InnerText = NewServer.ServerName
                            Case "Uptime"
                                Subnode.InnerText = CStr(NewServer.Uptime)
                            Case "Website"
                                Subnode.InnerText = NewServer.Website.ToString
                            Case "WebsiteURL"
                                Subnode.InnerText = NewServer.WebsiteURL
                            Case "Thread"
                                Subnode.InnerText = NewServer.Thread.ToString
                            Case "ThreadURL"
                                Subnode.InnerText = NewServer.ThreadURL
                            Case "Description"
                                Subnode.InnerText = NewServer.Description
                            Case "Modified"
                                Subnode.InnerText = NewServer.Modified.ToString
                            Case "Rights"
                                Subnode.InnerText = NewServer.Rights.ToString
                            Case "Whitelist"
                                Subnode.InnerText = NewServer.Whitelist.ToString
                            Case "Pay"
                                Subnode.InnerText = NewServer.Pay.ToString
                        End Select
                    Next


                    Dokument.Save(Path)
                    ' Da man ja nur eine Vokabel ändern will, (und die id eindeutig ist), kann man, sobald sie geändert wurde, die Sub verlassen.
                    Exit Sub
                End If
            Next
        Next

    End Sub

    Private Function Highest_ID() As Integer

        Dim HI As Integer = 0

        For i = 0 To _ListOfServers.Count - 1
            If _ListOfServers(i).ID > HI Then
                HI = _ListOfServers(i).ID
            End If
        Next

        Return HI

    End Function


#End Region

#Region "Comparison"

    Private Class Vergleich : Implements IComparer(Of Server)

        Public Function Compare(ByVal x As Server, ByVal y As Server) As Integer _
        Implements System.Collections.Generic.IComparer(Of Server).Compare

            If x Is Nothing AndAlso y Is Nothing Then Return 0
            If x Is Nothing Then Return -1
            If y Is Nothing Then Return 1
            Return x.ID.CompareTo(y.ID)

        End Function

    End Class

#End Region

End Class
