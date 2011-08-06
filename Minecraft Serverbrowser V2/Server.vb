''' <summary>
''' Represents a single server from one of the lists.
''' </summary>
''' <remarks></remarks>

Public Class Server



#Region "Deklarationen"

    ''' <summary>
    ''' Gets or sets wheter the server is in survival mode or not.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Survival As Boolean
    ''' <summary>
    '''  Gets or sets wheter the server is using modifications or not.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Modified As Boolean
    ''' <summary>
    '''  Gets or sets wheter the server is using a whitelist or not.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Whitelist As Boolean
    ''' <summary>
    ''' Gets or sets wheter you need to pay to play on this server or not.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Pay As Boolean
    ''' <summary>
    ''' Gets or sets wheter the server has a thread on the minecraftforum or not.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Thread As Boolean
    ''' <summary>
    ''' Gets or sets wheter the server is using building rights or not.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Rights As Boolean
    ''' <summary>
    ''' Gets or sets wheter the server has its own website or not.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Website As Boolean

    ''' <summary>
    ''' Gets or sets the IP of the server.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property IP As String
    ''' <summary>
    ''' Gets or sets the name of the server.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ServerName As String
    ''' <summary>
    ''' Gets or sets the description of the server.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Description As String
    ''' <summary>
    ''' Gets or sets the website URL of the server..
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property WebsiteURL As String
    ''' <summary>
    ''' Gets or sets the URL of the forum thread of the server.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ThreadURL As String
    ''' <summary>
    ''' Returns the uptime of the server.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Uptime As Single
        Get
            Return _Uptime
        End Get
    End Property
    Friend _Uptime As Single

    Friend Property ID As Integer

#End Region
    

    Friend Sub New()

    End Sub

    ''' <summary>
    ''' Creates a new instance of the server class
    ''' </summary>
    ''' <param name="Survival">States wheter the server is a survival server or not.</param>
    ''' <param name="Modified">States wheter the server is using any modifications or not.</param>
    ''' <param name="Whitelist">States wheter the server is using a whitelist or not.</param>
    ''' <param name="Pay">States wheter you need to pay to get on the server or not.</param>
    ''' <param name="Thread">States if the server has a thread on the minecraftforum or not.</param>
    ''' <param name="Rights">States wheter the server is using building rights or not.</param>
    ''' <param name="Website">States wheter the server has an own website or not.</param>
    ''' <param name="IP">Contains the IP of the server.</param>
    ''' <param name="Name">Contains the name of the server.</param>
    ''' <param name="Description">Contains a little description of the server.</param>
    ''' <param name="WebsiteURL">If the server has an own website, then the URL will be stored here.</param>
    ''' <param name="ThreadURL">If the server has a thread on the minecraftforum, then the URL will be stored here.</param>
    ''' <param name="Uptime">Contains the uptime of the server.</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Survival As Boolean, ByVal Modified As Boolean, ByVal Whitelist As Boolean, ByVal Pay As Boolean, _
                   ByVal Thread As Boolean, ByVal Rights As Boolean, ByVal Website As Boolean, ByVal IP As String, ByVal Name As String, _
                   ByVal Description As String, ByVal WebsiteURL As String, ByVal ThreadURL As String, ByVal Uptime As Single)

        Me.Survival = Survival
        Me.Modified = Modified
        Me.Whitelist = Whitelist
        Me.Pay = Pay
        Me.Thread = Thread
        Me.Rights = Rights
        Me.Website = Website
        Me.IP = IP
        Me.ServerName = Name
        Me.Description = Description
        Me.WebsiteURL = WebsiteURL
        Me.ThreadURL = ThreadURL
        Me._Uptime = Uptime

    End Sub

    Public Overrides Function ToString() As String

        Dim x As String = _
                   "Survival: " & Survival & vbCrLf & _
                   "Modified: " & Modified & vbCrLf & _
                   "Whitelist: " & Whitelist & vbCrLf & _
                   "Pay: " & Pay & vbCrLf & _
                   "Thread: " & Thread & vbCrLf & _
                   "Website: " & Website & vbCrLf & _
                   "Rights: " & Rights & vbCrLf & _
                   "IP: " & IP & vbCrLf & _
                   "Server name: " & ServerName & vbCrLf & _
                   "Description: " & Description & vbCrLf & _
                   "Website URL: " & WebsiteURL & vbCrLf & _
                   "Thread URL: " & ThreadURL & vbCrLf & _
                   "Uptime: " & Uptime & vbCrLf

        Return x

    End Function

End Class