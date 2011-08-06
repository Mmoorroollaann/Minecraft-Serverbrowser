Imports System.Windows.Forms

Public Class frmmdiMain

#Region "Deklarationen"

#Region "MDI children"

    Friend childFilters As frmFilters
    Friend childDetails As frmDetails
    Friend childServerlist As frmServerlist
    Friend childStartMinecraft As frmStartMinecraft

#End Region

#Region "Filter"

    ' 0=disabled, 1=only, 2=hide
    ' Switched to my.settings instead
    'Friend filterBuildingRights As Integer = 0
    'Friend filterModified As Integer = 0
    'Friend filterPayToPlay As Integer = 0
    'Friend filterWhitelist As Integer = 0

#End Region

#Region "Data"

    Public Serverlist_Redstone As New Serverlist_Redstone(Environment.CurrentDirectory & "\API_Data_XML.xml")
    Friend SelectedIndexRedstone As Integer

    Public Serverlist_Favourites As New Serverlist_Favourites(Environment.CurrentDirectory & "\Favourites.xml")

#End Region

    Friend LanguageFile As Translation

    Friend SettingsFile As MinecraftSettings

#End Region


    Private Sub Apply_Language()

        ' If the language file has been removed it will not apply the (missing) informations, since this would lead to blank buttons and stuff
        If LanguageFile.isLanguageFileAvailable = False Then Exit Sub

        mnuiAbout.Text = LanguageFile.frmmdiMain_mnuiAbout_Text

        mnuiApplication.Text = LanguageFile.frmmdiMain_mnuiApplication_Text
        mnuiApplicationOpenFolder.Text = LanguageFile.frmmdiMain_mnuiApplication_OpenProgramFolder
        mnuiApplicationQuit.Text = LanguageFile.frmmdiMain_mnuiApplication_Quit

        mnuiCheckForUpdates.Text = LanguageFile.frmmdiMain_mnuiCheckForUpdates_Text

        mnuiExtras.Text = LanguageFile.frmmdiMain_mnuiExtras_Text
        mnuiExtrasLockWindows.Text = LanguageFile.frmmdiMain_mnuiExtras_LockWindows
        mnuiExtrasRestoreDefaultWindowsPositionAndLocation.Text = LanguageFile.frmmdiMain_mnuiExtras_RestoreDefault
        mnuiExtrasSettings.Text = LanguageFile.frmmdiMain_mnuiExtras_Settings

        mnuiWindows.Text = LanguageFile.frmmdiMain_mnuiWindows_Text
        mnuiWindowsDetails.Text = LanguageFile.frmmdiMain_mnuiWindows_Details
        mnuiWindowsFilters.Text = LanguageFile.frmmdiMain_mnuiWindows_Filters
        mnuiWindowsServerlistFavourites.Text = LanguageFile.frmmdiMain_mnuiWindows_ServerlistFavourites
        mnuiWindowsStartMinecraft.Text = LanguageFile.frmmdiMain_mnuiWindows_StartMinecraft

    End Sub

    Sub Apply_Settings()

        ' Not used right now.

    End Sub

    Sub Open_Windows()

        If My.Settings.childFiltersActive = True Then
            Open_Windows_Filters()
        End If

        If My.Settings.childDetailsActive = True Then
            Open_Windows_Details()
        End If

        If My.Settings.childServerlistActive = True Then
            Open_Windows_ServerlistFavourites()
        End If

        If My.Settings.childStartMinecraftActive = True Then
            Open_Windows_StartMinecraft()
        End If


    End Sub

    Sub Open_Windows_Filters()

        mnuiWindowsFilters.Checked = True

        childFilters = New frmFilters
        childFilters.MdiParent = Me
        childFilters.Show()
        childFilters.Size = My.Settings.childFiltersSize
        childFilters.Location = My.Settings.childFiltersLocation

        If My.Settings.LockWindows = True Then
            Lock_Windows()
        Else
            Unlock_Windows()
        End If

    End Sub

    Sub Open_Windows_Details()

        mnuiWindowsDetails.Checked = True

        childDetails = New frmDetails
        childDetails.MdiParent = Me
        childDetails.Show()
        childDetails.Size = My.Settings.childDetailsSize
        childDetails.Location = My.Settings.childDetailsLocation

        If My.Settings.LockWindows = True Then
            Lock_Windows()
        Else
            Unlock_Windows()
        End If

    End Sub

    Sub Open_Windows_ServerlistFavourites()

        mnuiWindowsServerlistFavourites.Checked = True

        childServerlist = New frmServerlist
        childServerlist.MdiParent = Me
        childServerlist.Show()
        childServerlist.Size = My.Settings.childServerlistSize
        childServerlist.Location = My.Settings.childServerlistLocation

        If My.Settings.LockWindows = True Then
            Lock_Windows()
        Else
            Unlock_Windows()
        End If

    End Sub

    Sub Open_Windows_StartMinecraft()

        mnuiWindowsStartMinecraft.Checked = True

        childStartMinecraft = New frmStartMinecraft
        childStartMinecraft.MdiParent = Me
        childStartMinecraft.Show()
        childStartMinecraft.Size = My.Settings.childStartMinecraftSize
        childStartMinecraft.Location = My.Settings.childStartMinecraftLocation

        If My.Settings.LockWindows = True Then
            Lock_Windows()
        Else
            Unlock_Windows()
        End If

    End Sub

    Sub Clear_Components()

        toolNumberOfServers.Text = ""

    End Sub

    Friend Sub Show_Servercount()

        If childServerlist IsNot Nothing Then

            If childServerlist.tabServerlist.SelectedTab.Text = "Favourites" Then
                toolNumberOfServers.Text = LanguageFile.frmmdiMain_StatusStrip_toolNumberOfServers_Favourites & " " & Serverlist_Favourites.ListOfServers.Count
            ElseIf childServerlist.tabServerlist.SelectedTab.Text = "Redstonewire" Then
                toolNumberOfServers.Text = LanguageFile.frmmdiMain_StatusStrip_toolNumberOfServers_Redstonewire & " " & Serverlist_Redstone.ListOfServers.Count
            ElseIf childServerlist.tabServerlist.SelectedTab.Text = "History" Then
                toolNumberOfServers.Text = LanguageFile.frmmdiMain_StatusStrip_toolNumberOfServers_History & " "
            End If

        Else

            toolNumberOfServers.Text = ""

        End If

    End Sub

    Private Sub Load_Language()

        If IO.File.Exists("Languages\" & My.Settings.settingsLanguageFile) = True Then
            LanguageFile = New Translation("Languages\" & My.Settings.settingsLanguageFile)
        ElseIf IO.File.Exists(Environment.CurrentDirectory & "\Languages\English.SBLNG") = True Then
            LanguageFile = New Translation(Environment.CurrentDirectory & "\Languages\English.SBLNG")
            My.Settings.settingsLanguageFile = "English.SBLNG"
        Else
            LanguageFile = New Translation("Languages\" & My.Settings.settingsLanguageFile)
            LanguageFile.isLanguageFileAvailable = False
        End If

        'LanguageFile = New Translation(Environment.CurrentDirectory & "\language.xml")
        LanguageFile.Load_LanguageFile()
        'LanguageFile.Save_New_File(Environment.CurrentDirectory & "\utf8.xml")
        'LanguageFile.Generate_XML_Save()

    End Sub

    Sub Show_Donation_Info()

        MsgBox("Thanks for using " & My.Application.Info.ProductName & " " & My.Application.Info.Version.ToString() & vbCrLf & _
               "If you like this application consider donating some money. You can find the donation link in the 'About' window.")

    End Sub


#Region "Data"

    Sub Redstone_Get_Data()

        If My.Settings.settingsOfflineMode = False AndAlso My.Computer.Network.IsAvailable = True Then
            Serverlist_Redstone.Get_Data_From_Web()
            Serverlist_Redstone.Convert_RawXML_To_XML()
        End If

        Serverlist_Redstone.Get_Data_From_XML()

    End Sub

    Sub Favourites_Get_Data()

        Serverlist_Favourites.Read_Database_FromXML()

    End Sub


#End Region


    Private Sub mnuiWindowsFilters_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuiWindowsFilters.Click

        If mnuiWindowsFilters.Checked = False And childFilters IsNot Nothing Then
            childFilters.Close()
        Else
            Open_Windows_Filters()
        End If

    End Sub

    Private Sub mnuiWindowsDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuiWindowsDetails.Click

        If mnuiWindowsDetails.Checked = False And childDetails IsNot Nothing Then
            childDetails.Close()
        Else
            Open_Windows_Details()
        End If

    End Sub

    Private Sub mnuiWindowsServerlistFavourites_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuiWindowsServerlistFavourites.Click

        If mnuiWindowsServerlistFavourites.Checked = False And childServerlist IsNot Nothing Then
            childServerlist.Close()
        Else
            Open_Windows_ServerlistFavourites()
        End If

    End Sub

    Private Sub mnuiWindowsStartMinecraft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuiWindowsStartMinecraft.Click

        If mnuiWindowsStartMinecraft.Checked = False And childStartMinecraft IsNot Nothing Then
            childStartMinecraft.Close()
        Else
            Open_Windows_StartMinecraft()
        End If

    End Sub


    Private Sub mnuiApplicationQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuiApplicationQuit.Click

        Me.Close()

    End Sub

    Private Sub mnuiApplicationOpenFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuiApplicationOpenFolder.Click

        System.Diagnostics.Process.Start(Environment.CurrentDirectory)

    End Sub


    Private Sub mdiMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        SplashScreen.Show()
        SplashScreen.Update()

        SplashScreen.lblStatus.Text = "Initializing main window"
        SplashScreen.lblStatus.Update()

        Me.Location = My.Settings.parentmdiMainLocation
        Me.Size = My.Settings.parentmdiMainSize

        Clear_Components()


        SplashScreen.lblStatus.Text = "Getting data"
        SplashScreen.lblStatus.Update()

        Redstone_Get_Data()
        Favourites_Get_Data()


        SplashScreen.lblStatus.Text = "Opening windows"
        SplashScreen.lblStatus.Update()

        ' Muss vor Open_Windows ausgeführt werden, damit die Sprache in den Load-Events der einzelnen Fenster geladen werden kann.
        Load_Language()

        SplashScreen.lblStatus.Text = "Applying language"
        SplashScreen.lblStatus.Update()
        Apply_Language()

        Open_Windows()

        ' Wird neuerdings von Open_Windows_x ausgeführt.
        'If My.Settings.LockWindows = True Then
        '    Lock_Windows()
        '    mnuiExtrasLockWindows.Checked = True
        'Else
        '    Unlock_Windows()
        '    mnuiExtrasLockWindows.Checked = False
        'End If

        ' Muss Nach Open_Windows() sein, da ansonsten childServerlist auf jeden Fall nothing wäre.
        Show_Servercount()

        Try
            SettingsFile = New MinecraftSettings()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If My.Settings.globalDonatePromptDisplaied = False Then
            Show_Donation_Info()
            My.Settings.globalDonatePromptDisplaied = True
        End If

        SplashScreen.Close()

    End Sub

    Private Sub mdiMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        My.Settings.parentmdiMainLocation = Me.Location
        My.Settings.parentmdiMainSize = Me.Size

        If childDetails IsNot Nothing Then
            My.Settings.childDetailsActive = True
        Else
            My.Settings.childDetailsActive = False
        End If

        If childFilters IsNot Nothing Then
            My.Settings.childFiltersActive = True
        Else
            My.Settings.childFiltersActive = False
        End If

        If childServerlist IsNot Nothing Then
            My.Settings.childServerlistActive = True
        Else
            My.Settings.childServerlistActive = False
        End If

        If childStartMinecraft IsNot Nothing Then
            My.Settings.childStartMinecraftActive = True
        Else
            My.Settings.childStartMinecraftActive = False
        End If

    End Sub


    Private Sub Lock_Windows()

        ' Gets called from Open_Windows_x.

        mnuiExtrasLockWindows.Checked = True

        toollblLocked.Text = "Ï"
        Me.Text = "Minecraft Serverbrowser [locked]"

        If childDetails IsNot Nothing Then
            childDetails.MinimumSize = childDetails.Size
            childDetails.MaximumSize = childDetails.Size
        End If

        If childFilters IsNot Nothing Then
            childFilters.MinimumSize = childFilters.Size
            childFilters.MaximumSize = childFilters.Size
        End If

        If childServerlist IsNot Nothing Then
            childServerlist.MinimumSize = childServerlist.Size
            childServerlist.MaximumSize = childServerlist.Size
        End If

        If childStartMinecraft IsNot Nothing Then
            childStartMinecraft.MinimumSize = childStartMinecraft.Size
            childStartMinecraft.MaximumSize = childStartMinecraft.Size
        End If

    End Sub

    Private Sub Unlock_Windows()

        ' Gets called from Open_Windows_x.
        ' Resets the minimum and maximum size to the hardcoded ones.

        mnuiExtrasLockWindows.Checked = False

        toollblLocked.Text = "Ð"
        Me.Text = "Minecraft Serverbrowser"

        If childDetails IsNot Nothing Then
            childDetails.MinimumSize = New Drawing.Size(303, 320)
            childDetails.MaximumSize = New Drawing.Size(0, 0)
        End If

        If childFilters IsNot Nothing Then
            childFilters.MinimumSize = New Drawing.Size(0, 0)
            childFilters.MaximumSize = New Drawing.Size(0, 0)
        End If

        If childServerlist IsNot Nothing Then
            childServerlist.MinimumSize = New Drawing.Size(214, 180)
            childServerlist.MaximumSize = New Drawing.Size(0, 0)
        End If

        If childStartMinecraft IsNot Nothing Then
            childStartMinecraft.MinimumSize = New Drawing.Size(0, 0)
            childStartMinecraft.MaximumSize = New Drawing.Size(0, 0)
        End If

    End Sub

    Private Sub mnuiExtrasLockWindows_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuiExtrasLockWindows.Click

        My.Settings.LockWindows = mnuiExtrasLockWindows.Checked

        If My.Settings.LockWindows = True Then

            Lock_Windows()

        ElseIf My.Settings.LockWindows = False Then

            Unlock_Windows()

        End If

    End Sub


    Private Sub mnuiExtrasSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuiExtrasSettings.Click

        Dim Settings As New frmSettings

        Settings.ShowDialog()

    End Sub


    Private Sub ToolStripDropDownButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripDropDownButton1.Click

        MsgBox(Me.Location.ToString & "    " & Me.Size.ToString)


    End Sub


    Private Sub RestoreDefaultWindowsPositionAndLocationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuiExtrasRestoreDefaultWindowsPositionAndLocation.Click

        ' Restores the various sizes and positions to the standard, hardcoded ones.

        childDetails.Location = New Drawing.Point(0, 0)
        childDetails.Size = New Drawing.Size(303, 424)

        childFilters.Location = New Drawing.Point(303, 212)
        childFilters.Size = New Drawing.Size(212, 212)

        childServerlist.Location = New Drawing.Point(515, 0)
        childServerlist.Size = New Drawing.Size(230, 424)

        childStartMinecraft.Location = New Drawing.Point(303, 0)
        childStartMinecraft.Size = New Drawing.Size(212, 212)

        'Me.Location = New Drawing.Point(0, 0)
        Me.Size = New Drawing.Size(765, 512)

    End Sub

    Private Sub mnuiAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuiAbout.Click

        frmAbout.Show()

    End Sub


    Private Sub mnuiCheckForUpdates_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuiCheckForUpdates.Click

        'Dim UpdateThread As New Threading.Thread(AddressOf WritableTimestampCollection.is_Update_Available)

        WritableTimestampCollection.is_Update_Available()

        Do Until WritableTimestampCollection.Ready_To_Serve = True
            Application.DoEvents()
        Loop

        If WritableTimestampCollection.UpdateAvailable = False Then
            MsgBox("There is no update available.")
        Else
            If MsgBox("There is an update available. Proceed to http://www.minecraftforum.net/viewtopic.php?f=25&t=88783 ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                System.Diagnostics.Process.Start("http://www.minecraftforum.net/viewtopic.php?f=25&t=88783")
            End If
        End If


    End Sub


End Class

