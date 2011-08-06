Imports System.Xml

Friend Class Translation

    Dim PropertiesInfos As System.Reflection.PropertyInfo()

    Friend isLanguageFileAvailable As Boolean = True

    Private _Path As String

#Region "frmmdiMain"

    Private lstfrmmdimain As New List(Of String)

    Friend Property frmmdiMain_Text As String

#Region "Menu bar"

    Friend Property frmmdiMain_mnuiApplication_Text As String
    Friend Property frmmdiMain_mnuiApplication_OpenProgramFolder As String
    Friend Property frmmdiMain_mnuiApplication_Quit As String

    Friend Property frmmdiMain_mnuiWindows_Text As String
    Friend Property frmmdiMain_mnuiWindows_Filters As String
    Friend Property frmmdiMain_mnuiWindows_Details As String
    Friend Property frmmdiMain_mnuiWindows_ServerlistFavourites As String
    Friend Property frmmdiMain_mnuiWindows_StartMinecraft As String

    Friend Property frmmdiMain_mnuiExtras_Text As String
    Friend Property frmmdiMain_mnuiExtras_LockWindows As String
    Friend Property frmmdiMain_mnuiExtras_RestoreDefault As String
    Friend Property frmmdiMain_mnuiExtras_Settings As String

    Friend Property frmmdiMain_mnuiAbout_Text As String

    Friend Property frmmdiMain_mnuiCheckForUpdates_Text As String

#End Region

#Region "Status bar"

    Friend Property frmmdiMain_StatusStrip_toolNumberOfServers_Redstonewire As String
    Friend Property frmmdiMain_StatusStrip_toolNumberOfServers_Favourites As String
    Friend Property frmmdiMain_StatusStrip_toolNumberOfServers_History As String

#End Region

#End Region

#Region "frmAbout"

    Private lstfrmAbout As New List(Of String)

    Friend Property frmabout_Text As String

    Friend Property frmabout_rtbDescription As String

#End Region

#Region "frmDetails"

    Private lstfrmDetails As New List(Of String)

    Friend Property frmDetails_Text As String

#Region "Labels"

    Friend Property frmDetails_lblName As String
    Friend Property frmDetails_lblIP As String
    Friend Property frmDetails_lblUptime As String
    Friend Property frmDetails_lblWebsite As String
    Friend Property frmDetails_lblForumThread As String

#End Region

#End Region

#Region "frmFilters"

    Private lstfrmFilters As New List(Of String)

    Friend Property frmFilters_Text As String

#Region "Buttons"

    Friend Property frmFilters_cmdBuildingRights As String
    Friend Property frmFilters_cmdModified As String
    Friend Property frmFilters_cmdPayToPlay As String
    Friend Property frmFilters_cmdWhitelist As String

#End Region

#End Region

#Region "frmServerFavourites"

    Private lstfrmServerFavourites As New List(Of String)

    Friend Property frmServerFavourites_Text As String

#Region "Labels"

    Friend Property frmServerFavourites_lblName As String
    Friend Property frmServerFavourites_lblIP As String
    Friend Property frmServerFavourites_lblWebsite As String
    Friend Property frmServerFavourites_lblThread As String
    Friend Property frmServerFavourites_lblDescription As String

#End Region

#Region "Checkboxes"

    Friend Property frmServerFavourites_chkModified As String
    Friend Property frmServerFavourites_chkBuildingRights As String
    Friend Property frmServerFavourites_chkPayToPlay As String
    Friend Property frmServerFavourites_chkWhitelist As String

#End Region

#Region "Buttons"

    Friend Property frmServerFavourites_cmdAccept As String
    Friend Property frmServerFavourites_cmdCancel As String

#End Region

#End Region

#Region "frmServerlist"

    Private lstfrmServerlist As New List(Of String)

    Friend Property frmServerlist_Text As String

#Region "Textboxes"

    Friend Property frmServerlist_txtSearch As String

#End Region

#Region "Tabpages"

    Friend Property frmServerlist_tabServerlistRedstone As String
    Friend Property frmServerlist_tabServerlistFavourites As String
    Friend Property frmServerlist_tabServerlistHistory As String

#End Region

#Region "Buttons"

    Friend Property frmServerlist_cmdAddToFavourites As String
    Friend Property frmServerlist_cmdAddNewFavourite As String
    Friend Property frmServerlist_cmdEditFavourite As String
    Friend Property frmServerlist_cmdDeleteFavourite As String
    Friend Property frmServerlist_cmdClearHistory As String

#End Region

#End Region

#Region "frmSettings"

    Private lstfrmSettings As New List(Of String)

    Friend Property frmSettings_Text As String

#Region "Tab pages"

    Friend Property frmSettings_tabMinecraft As String
    Friend Property frmSettings_tabOfflineMode As String
    Friend Property frmSettings_tabLanguage As String

#End Region

#Region "Group boxes"

    Friend Property frmSettings_grpLoginMinecraft As String
    Friend Property frmSettings_grpOfflineMode As String

#End Region

#Region "Checkboxes"

    Friend Property frmSettings_chkConnectToServer As String
    Friend Property frmSettings_chkUseOfflineMode As String

#End Region

#Region "Labels"

    Friend Property frmSettings_lblAuthenticationInfo As String
    Friend Property frmSettings_lblUsername As String
    Friend Property frmSettings_lblPassword As String
    Friend Property frmSettings_lblPathToMinecraftExe As String
    Friend Property frmSettings_lblOfflineModeInfo As String
    Friend Property frmSettings_lblChooseLanguage As String
    Friend Property frmSettings_lblLanguageInfo As String

#End Region

#Region "Buttons"

    Friend Property frmSettings_cmdAccept As String
    Friend Property frmsettings_cmdBrowse As String
   
#End Region


#End Region

    Friend Sub New(ByVal Path As String)

        _Path = Path

    End Sub

    Friend Sub Save_New_File(ByVal Path As String)

        Get_Properties()

        Dim xmlWriter As New Xml.XmlTextWriter(Path, New System.Text.UTF8Encoding)

        xmlWriter.Formatting = Formatting.Indented

        xmlWriter.WriteStartDocument()

        xmlWriter.WriteStartElement("Language")


        For i = 0 To PropertiesInfos.Count - 1

            xmlWriter.WriteStartElement(PropertiesInfos(i).Name)
            If PropertiesInfos(i).GetValue(Me, Nothing) IsNot Nothing Then
                xmlWriter.WriteValue(PropertiesInfos(i).GetValue(Me, Nothing))
            Else
                xmlWriter.WriteValue("Test")
            End If
            xmlWriter.WriteEndElement()

        Next

        xmlWriter.WriteEndElement()

        xmlWriter.WriteEndDocument()

        xmlWriter.Close()

    End Sub

    Friend Sub SelectCase()

        Get_Properties()

        Dim hans As String

        For i = 0 To PropertiesInfos.Length - 1
            hans &= "case " & """" & PropertiesInfos(i).Name & """" & vbCrLf
            hans &= PropertiesInfos(i).Name & "=" & "node.innertext" & vbCrLf
        Next

        Clipboard.SetDataObject(hans, True)

    End Sub

    Friend Sub Generate_XML_Save()

        Get_Properties()

        Dim hans As String

        For i = 0 To PropertiesInfos.Length - 1
            hans &= "xmlWriter.WriteStartElement(""" & PropertiesInfos(i).Name & """)" & vbCrLf
            hans &= "xmlWriter.WriteValue(" & "txt" & PropertiesInfos(i).Name & ".text)" & vbCrLf
            hans &= "xmlWriter.WriteEndElement" & vbCrLf
        Next

        Clipboard.SetDataObject(hans, True)

    End Sub

    Friend Sub Load_LanguageFile()

        'Dim debugName As String
        'Dim debugInnerText As String


        Dim xmlDocument As New XmlDocument

        Try

            xmlDocument.Load(_Path)

            For Each node As XmlNode In xmlDocument.DocumentElement

                Select Case node.Name

                    Case "frmmdiMain_Text"
                        frmmdiMain_Text = node.InnerText
                    Case "frmmdiMain_mnuiApplication_Text"
                        frmmdiMain_mnuiApplication_Text = node.InnerText
                    Case "frmmdiMain_mnuiApplication_OpenProgramFolder"
                        frmmdiMain_mnuiApplication_OpenProgramFolder = node.InnerText
                    Case "frmmdiMain_mnuiApplication_Quit"
                        frmmdiMain_mnuiApplication_Quit = node.InnerText
                    Case "frmmdiMain_mnuiWindows_Text"
                        frmmdiMain_mnuiWindows_Text = node.InnerText
                    Case "frmmdiMain_mnuiWindows_Filters"
                        frmmdiMain_mnuiWindows_Filters = node.InnerText
                    Case "frmmdiMain_mnuiWindows_Details"
                        frmmdiMain_mnuiWindows_Details = node.InnerText
                    Case "frmmdiMain_mnuiWindows_ServerlistFavourites"
                        frmmdiMain_mnuiWindows_ServerlistFavourites = node.InnerText
                    Case "frmmdiMain_mnuiWindows_StartMinecraft"
                        frmmdiMain_mnuiWindows_StartMinecraft = node.InnerText
                    Case "frmmdiMain_mnuiExtras_Text"
                        frmmdiMain_mnuiExtras_Text = node.InnerText
                    Case "frmmdiMain_mnuiExtras_LockWindows"
                        frmmdiMain_mnuiExtras_LockWindows = node.InnerText
                    Case "frmmdiMain_mnuiExtras_RestoreDefault"
                        frmmdiMain_mnuiExtras_RestoreDefault = node.InnerText
                    Case "frmmdiMain_mnuiExtras_Settings"
                        frmmdiMain_mnuiExtras_Settings = node.InnerText
                    Case "frmmdiMain_mnuiAbout_Text"
                        frmmdiMain_mnuiAbout_Text = node.InnerText
                    Case "frmmdiMain_mnuiCheckForUpdates_Text"
                        frmmdiMain_mnuiCheckForUpdates_Text = node.InnerText
                    Case "frmmdiMain_StatusStrip_toolNumberOfServers_Redstonewire"
                        frmmdiMain_StatusStrip_toolNumberOfServers_Redstonewire = node.InnerText
                    Case "frmmdiMain_StatusStrip_toolNumberOfServers_Favourites"
                        frmmdiMain_StatusStrip_toolNumberOfServers_Favourites = node.InnerText
                    Case "frmmdiMain_StatusStrip_toolNumberOfServers_History"
                        frmmdiMain_StatusStrip_toolNumberOfServers_History = node.InnerText
                    Case "frmabout_Text"
                        frmabout_Text = node.InnerText
                    Case "frmabout_rtbDescription"
                        frmabout_rtbDescription = node.InnerText
                    Case "frmDetails_Text"
                        frmDetails_Text = node.InnerText
                    Case "frmDetails_lblName"
                        frmDetails_lblName = node.InnerText
                    Case "frmDetails_lblIP"
                        frmDetails_lblIP = node.InnerText
                    Case "frmDetails_lblUptime"
                        frmDetails_lblUptime = node.InnerText
                    Case "frmDetails_lblWebsite"
                        frmDetails_lblWebsite = node.InnerText
                    Case "frmDetails_lblForumThread"
                        frmDetails_lblForumThread = node.InnerText
                    Case "frmFilters_Text"
                        frmFilters_Text = node.InnerText
                    Case "frmFilters_cmdBuildingRights"
                        frmFilters_cmdBuildingRights = node.InnerText
                    Case "frmFilters_cmdModified"
                        frmFilters_cmdModified = node.InnerText
                    Case "frmFilters_cmdPayToPlay"
                        frmFilters_cmdPayToPlay = node.InnerText
                    Case "frmFilters_cmdWhitelist"
                        frmFilters_cmdWhitelist = node.InnerText
                    Case "frmServerFavourites_Text"
                        frmServerFavourites_Text = node.InnerText
                    Case "frmServerFavourites_lblName"
                        frmServerFavourites_lblName = node.InnerText
                    Case "frmServerFavourites_lblIP"
                        frmServerFavourites_lblIP = node.InnerText
                    Case "frmServerFavourites_lblWebsite"
                        frmServerFavourites_lblWebsite = node.InnerText
                    Case "frmServerFavourites_lblThread"
                        frmServerFavourites_lblThread = node.InnerText
                    Case "frmServerFavourites_lblDescription"
                        frmServerFavourites_lblDescription = node.InnerText
                    Case "frmServerFavourites_chkModified"
                        frmServerFavourites_chkModified = node.InnerText
                    Case "frmServerFavourites_chkBuildingRights"
                        frmServerFavourites_chkBuildingRights = node.InnerText
                    Case "frmServerFavourites_chkPayToPlay"
                        frmServerFavourites_chkPayToPlay = node.InnerText
                    Case "frmServerFavourites_chkWhitelist"
                        frmServerFavourites_chkWhitelist = node.InnerText
                    Case "frmServerFavourites_cmdAccept"
                        frmServerFavourites_cmdAccept = node.InnerText
                    Case "frmServerFavourites_cmdCancel"
                        frmServerFavourites_cmdCancel = node.InnerText
                    Case "frmServerlist_Text"
                        frmServerlist_Text = node.InnerText
                    Case "frmServerlist_txtSearch"
                        frmServerlist_txtSearch = node.InnerText
                    Case "frmServerlist_tabServerlistRedstone"
                        frmServerlist_tabServerlistRedstone = node.InnerText
                    Case "frmServerlist_tabServerlistFavourites"
                        frmServerlist_tabServerlistFavourites = node.InnerText
                    Case "frmServerlist_tabServerlistHistory"
                        frmServerlist_tabServerlistHistory = node.InnerText
                    Case "frmServerlist_cmdAddToFavourites"
                        frmServerlist_cmdAddToFavourites = node.InnerText
                    Case "frmServerlist_cmdAddNewFavourite"
                        frmServerlist_cmdAddNewFavourite = node.InnerText
                    Case "frmServerlist_cmdEditFavourite"
                        frmServerlist_cmdEditFavourite = node.InnerText
                    Case "frmServerlist_cmdDeleteFavourite"
                        frmServerlist_cmdDeleteFavourite = node.InnerText
                    Case "frmServerlist_cmdClearHistory"
                        frmServerlist_cmdClearHistory = node.InnerText
                    Case "frmSettings_Text"
                        frmSettings_Text = node.InnerText
                    Case "frmSettings_tabMinecraft"
                        frmSettings_tabMinecraft = node.InnerText
                    Case "frmSettings_tabOfflineMode"
                        frmSettings_tabOfflineMode = node.InnerText
                    Case "frmSettings_tabLanguage"
                        frmSettings_tabLanguage = node.InnerText
                    Case "frmSettings_grpLoginMinecraft"
                        frmSettings_grpLoginMinecraft = node.InnerText
                    Case "frmSettings_grpOfflineMode"
                        frmSettings_grpOfflineMode = node.InnerText
                    Case "frmSettings_chkConnectToServer"
                        frmSettings_chkConnectToServer = node.InnerText
                    Case "frmSettings_chkUseOfflineMode"
                        frmSettings_chkUseOfflineMode = node.InnerText
                    Case "frmSettings_lblAuthenticationInfo"
                        frmSettings_lblAuthenticationInfo = node.InnerText
                    Case "frmSettings_lblUsername"
                        frmSettings_lblUsername = node.InnerText
                    Case "frmSettings_lblPassword"
                        frmSettings_lblPassword = node.InnerText
                    Case "frmSettings_lblPathToMinecraftExe"
                        frmSettings_lblPathToMinecraftExe = node.InnerText
                    Case "frmSettings_lblOfflineModeInfo"
                        frmSettings_lblOfflineModeInfo = node.InnerText
                    Case "frmSettings_lblChooseLanguage"
                        frmSettings_lblChooseLanguage = node.InnerText
                    Case "frmSettings_lblLanguageInfo"
                        frmSettings_lblLanguageInfo = node.InnerText
                    Case "frmSettings_cmdAccept"
                        frmSettings_cmdAccept = node.InnerText
                    Case "frmSettings_cmdBrowse"
                        frmsettings_cmdBrowse = node.InnerText

                End Select

                'debugName = node.Name
                'debugInnerText = node.InnerText

            Next

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Create_Lists()


        With lstfrmAbout

            .Clear()

            .Add(frmabout_Text)

            .Add(frmabout_rtbDescription)

        End With


        With lstfrmDetails

            .Clear()

            .Add(frmDetails_Text)

            .Add(frmDetails_lblForumThread)
            .Add(frmDetails_lblIP)
            .Add(frmDetails_lblName)
            .Add(frmDetails_lblUptime)
            .Add(frmDetails_lblWebsite)
            .Add(frmDetails_lblWebsite)

        End With


        With lstfrmFilters

            .Clear()

            .Add(frmFilters_Text)

            .Add(frmFilters_cmdBuildingRights)
            .Add(frmFilters_cmdModified)
            .Add(frmFilters_cmdPayToPlay)
            .Add(frmFilters_cmdWhitelist)

        End With


        With lstfrmmdimain

            .Clear()

            .Add(frmmdiMain_Text)

            .Add(frmmdiMain_mnuiAbout_Text)

            .Add(frmmdiMain_mnuiApplication_OpenProgramFolder)
            .Add(frmmdiMain_mnuiApplication_Quit)
            .Add(frmmdiMain_mnuiApplication_Text)

            .Add(frmmdiMain_mnuiCheckForUpdates_Text)

            .Add(frmmdiMain_mnuiExtras_LockWindows)
            .Add(frmmdiMain_mnuiExtras_RestoreDefault)
            .Add(frmmdiMain_mnuiExtras_Settings)
            .Add(frmmdiMain_mnuiExtras_Text)

            .Add(frmmdiMain_mnuiWindows_Details)
            .Add(frmmdiMain_mnuiWindows_Filters)
            .Add(frmmdiMain_mnuiWindows_ServerlistFavourites)
            .Add(frmmdiMain_mnuiWindows_StartMinecraft)
            .Add(frmmdiMain_mnuiWindows_Text)

        End With


        With lstfrmServerFavourites

            .Clear()

            .Add(frmServerFavourites_Text)

            .Add(frmServerFavourites_chkBuildingRights)
            .Add(frmServerFavourites_chkModified)
            .Add(frmServerFavourites_chkPayToPlay)
            .Add(frmServerFavourites_chkWhitelist)

            .Add(frmServerFavourites_cmdAccept)
            .Add(frmServerFavourites_cmdCancel)

            .Add(frmServerFavourites_lblDescription)
            .Add(frmServerFavourites_lblIP)
            .Add(frmServerFavourites_lblName)
            .Add(frmServerFavourites_lblThread)
            .Add(frmServerFavourites_lblWebsite)

        End With


        With lstfrmServerlist

            .Clear()

            .Add(frmServerlist_Text)

            .Add(frmServerlist_cmdAddNewFavourite)
            .Add(frmServerlist_cmdAddToFavourites)
            .Add(frmServerlist_cmdDeleteFavourite)
            .Add(frmServerlist_cmdEditFavourite)

            .Add(frmServerlist_tabServerlistFavourites)
            .Add(frmServerlist_tabServerlistRedstone)

            .Add(frmServerlist_txtSearch)

        End With


        With lstfrmSettings

            .Clear()

            .Add(frmSettings_Text)

            .Add(frmSettings_chkConnectToServer)
            .Add(frmSettings_chkUseOfflineMode)

            .Add(frmSettings_grpLoginMinecraft)
            .Add(frmSettings_grpOfflineMode)

            .Add(frmSettings_lblAuthenticationInfo)
            .Add(frmSettings_lblPassword)
            .Add(frmSettings_lblPathToMinecraftExe)
            .Add(frmSettings_lblUsername)
            .Add(frmSettings_lblChooseLanguage)
            .Add(frmSettings_lblLanguageInfo)

            .Add(frmSettings_tabMinecraft)
            .Add(frmSettings_tabOfflineMode)
            .Add(frmSettings_tabLanguage)

        End With


    End Sub

    Private Sub Get_Properties()

        PropertiesInfos = GetType(Translation).GetProperties(Reflection.BindingFlags.Public Or Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance)

    End Sub

End Class
