Imports System.IO
Imports System.Xml
Imports System.Net
Imports System.Text

Public Class Serverlist_Redstone
    Inherits Serverlist

    Private Const API_Key As String = "c5b0d086d56a0fa6423de7076af7a7f9e94e6951"
    Private ResponseFromServer As String


#Region "New"

    Public Sub New(ByVal Path As String)

        Me.Path = Path

    End Sub

#End Region

#Region "Manage database"

    Private Sub Create_Database()

    End Sub

#End Region

#Region "Data"

    Public Sub Get_Data_From_Web()

        Try

            Dim Request As WebRequest = WebRequest.Create("http://mcserverlist.net/api/server_list")
            Request.Timeout = 20000
            Request.Method = "POST"

            Dim PostData As String = "key=" + API_Key
            Dim ByteArray() As Byte = Encoding.UTF8.GetBytes(PostData)

            Request.ContentLength = ByteArray.Length

            Dim RequestStream As Stream = Request.GetRequestStream
            RequestStream.Write(ByteArray, 0, ByteArray.Length)
            RequestStream.Close()

            Dim Response As WebResponse = Request.GetResponse

            Dim Responsestream As Stream = Response.GetResponseStream
            Dim Reader As New StreamReader(Responsestream)
            Dim ResponseFromServer As String = Reader.ReadToEnd
            Reader.Close()
            Responsestream.Close()

            Response.Close()

            Dim xmlDoc As New XmlDocument()
            xmlDoc.LoadXml(ResponseFromServer)
            xmlDoc.Save(Environment.CurrentDirectory & "\API_Data_XML_Raw.xml")

            Dim Writer As StreamWriter = New StreamWriter(Environment.CurrentDirectory & "\API_Data_Text_Raw.txt")
            Writer.Write(ResponseFromServer)
            Writer.Close()

        Catch ex As Net.WebException

            MsgBox("Make sure that you are connected to the internet." & vbCrLf & ex.Message, , "An error has occurred")

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Public Sub Convert_RawXML_To_XML()

        Try

            Dim xmlDocRawData As New XmlDocument()
            xmlDocRawData.Load(Environment.CurrentDirectory & "\API_Data_XML_Raw.xml")

            Dim NodeListRawData As XmlNodeList = xmlDocRawData.GetElementsByTagName("result")

            Dim xmlDocOutputData As New XmlDocument()

            Dim NodeUber As XmlNode
            Dim NodeServer As XmlNode
            Dim AttributeID As XmlAttribute
            Dim SubnodeName As XmlNode
            Dim SubnodeIP As XmlNode
            ' Erklärung dass String und nicht XmlNode siehe weiter unten, bei der Verwendung.
            Dim SubnodePort As String
            Dim SubnodePercentage As XmlNode
            Dim SubnodeDescription As XmlNode

            Dim ID As Integer = 0

            NodeUber = xmlDocOutputData.CreateElement("Uber")

            For Each node As XmlNode In NodeListRawData

                ' Ist nötig, da das oberste Element ebenfalls "Result" heisst Eventuell existiert ein effizienterer Weg, der nicht erfordert bei jedem Eintrag zu überprüfen,
                ' ob er eventuell zu viele ChildNodes hat.
                If node.ChildNodes.Count > 10 Then
                    Continue For
                End If

                NodeServer = xmlDocOutputData.CreateElement("Server")

                AttributeID = xmlDocOutputData.CreateAttribute("ID")
                AttributeID.Value = CStr(ID)
                ID += 1
                NodeServer.Attributes.Append(AttributeID)

                For Each subnode As XmlNode In node.ChildNodes

                    Select Case subnode.Name

                        Case "name"
                            SubnodeName = xmlDocOutputData.CreateElement("Name")
                            SubnodeName.InnerText = subnode.InnerText
                            NodeServer.AppendChild(SubnodeName)
                        Case "port"
                            ' Da ich kein separates Feld "Port" führe, wird der Port hier lediglich ausgelesen. Späte wird er dann mit einem : an die IP angehängt.
                            SubnodePort = subnode.InnerText
                        Case "percentage"
                            SubnodePercentage = xmlDocOutputData.CreateElement("Uptime")
                            SubnodePercentage.InnerText = subnode.InnerText
                            NodeServer.AppendChild(SubnodePercentage)
                        Case "ip"
                            SubnodeIP = xmlDocOutputData.CreateElement("IP")
                            SubnodeIP.InnerText = subnode.InnerText & ":" & SubnodePort
                            NodeServer.AppendChild(SubnodeIP)
                        Case "description"
                            SubnodeDescription = xmlDocOutputData.CreateElement("Description")
                            SubnodeDescription.InnerText = subnode.InnerText
                            NodeServer.AppendChild(SubnodeDescription)
                            '
                    End Select

                Next

                NodeUber.AppendChild(NodeServer)

            Next

            xmlDocOutputData.AppendChild(NodeUber)

            xmlDocOutputData.Save(Path)

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Public Sub Get_Data_From_XML()

        Dim SourceDocument As New XmlDocument
        Dim Node As XmlNode
        Dim Subnode As XmlNode
        Dim Attribute As XmlAttribute

        Clear_Public_List()
        Clear_Private_List()

        Try

            SourceDocument.Load(Me.Path)

            For Each Node In SourceDocument.DocumentElement

                Dim NewServer As New Server()

                For Each Attribute In Node.Attributes

                    Select Case Attribute.Name

                        Case "ID"
                            NewServer.ID = CInt(Attribute.Value)

                    End Select

                Next

                For Each Subnode In Node.ChildNodes

                    Select Case Subnode.Name

                        Case "Name"
                            NewServer.ServerName = Subnode.InnerText

                        Case "IP"
                            NewServer.IP = Subnode.InnerText

                        Case "Uptime"

                            Try

                                ' Dies ist nötig, da in der MCServerlist ein Bug existiert, durch den einige Server eine "leere" (<> 0 !) Uptime haben. Dies würde bei der
                                ' Kovertierung zu einer Ausnahme führen.
                                If Subnode.InnerText = "" Then
                                    NewServer._Uptime = 0
                                    ' 24.03.2011 Ist nötig, da seit neustem bei einigen servern als uptime "nan" steht. Dies steht wohl für nicht verfügbar oder so.
                                ElseIf Subnode.InnerText = "-nan" Then
                                    NewServer._Uptime = 0
                                    ' Seit dem 02.04.2011 ist der Bug wieder da, diesmal mit "NaN%".
                                ElseIf Subnode.InnerText = "NaN&" Then
                                    NewServer._Uptime = 0
                                    ' Hier versuche ich, für die Zukunft vorzusorgen, falls wieder einmal eine weitere Variation von nan auftaucht...
                                ElseIf Subnode.InnerText.Contains("nan") = True Then
                                    NewServer._Uptime = 0
                                Else
                                    NewServer._Uptime = CType(Subnode.InnerText, Single)
                                End If

                            Catch ex As InvalidCastException

                                ' Hier wird nichts gemacht. Dies ist lediglich dazu da, um das in verschiedenen Variationen auftretende "NaN" zu vermeiden.

                            End Try

                        Case "Description"
                            NewServer.Description = Subnode.InnerText

                    End Select

                Next

                _ListOfServers.Add(NewServer)

            Next

            Sort_Data()
            Sync_Lists()

        Catch FileEx As FileNotFoundException

            MsgBox("Unable to find file" & vbCrLf & FileEx.Message)

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try



    End Sub

    Private Sub Sort_Data()

        _ListOfServers.Sort(New Vergleich)

    End Sub

#End Region

#Region "Manage lists"


#End Region

#Region "Comparison"

    Private Class Vergleich : Implements IComparer(Of Server)

        Public Function Compare(ByVal x As Server, ByVal y As Server) As Integer _
        Implements System.Collections.Generic.IComparer(Of Server).Compare

            If x Is Nothing AndAlso y Is Nothing Then Return 0
            If x Is Nothing Then Return -1
            If y Is Nothing Then Return 1

            ' Standardmässig würden die Server dadurch nach ihrer Uptime AUFSTEIGEND sortiert werden. Um dies zu verhindern wird das Ergebniss hier
            ' einfach "gespiegelt".
            Dim hans As Integer = x.Uptime.CompareTo(y.Uptime)
            Select Case hans
                Case 0
                    Return 0
                Case 1
                    Return -1
                Case -1
                    Return 1
            End Select

        End Function

    End Class

#End Region

End Class
