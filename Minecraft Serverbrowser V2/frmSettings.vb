Public Class frmSettings

    Private LanguageFolderPath As String = Environment.CurrentDirectory & "\languages"
    Private StartUp As Boolean = False

    Private Sub Apply_Language()

        ' If the language file has been removed it will not apply the (missing) informations, since this would lead to blank buttons and stuff
        If frmmdiMain.LanguageFile.isLanguageFileAvailable = False Then Exit Sub

        Me.Text = frmmdiMain.LanguageFile.frmSettings_Text

        chkConnectToServer.Text = frmmdiMain.LanguageFile.frmSettings_chkConnectToServer
        chkUseOfflineMode.Text = frmmdiMain.LanguageFile.frmSettings_chkUseOfflineMode

        cmdAccept.Text = frmmdiMain.LanguageFile.frmSettings_cmdAccept
        cmdBrowse.Text = frmmdiMain.LanguageFile.frmsettings_cmdBrowse

        grpLoginMinecraft.Text = frmmdiMain.LanguageFile.frmSettings_grpLoginMinecraft
        grpOfflineMode.Text = frmmdiMain.LanguageFile.frmSettings_grpOfflineMode

        lblAuthenticationInfo.Text = frmmdiMain.LanguageFile.frmSettings_lblAuthenticationInfo
        lblChooseLanguage.Text = frmmdiMain.LanguageFile.frmSettings_lblChooseLanguage
        lblLanguageInfo.Text = frmmdiMain.LanguageFile.frmSettings_lblLanguageInfo
        lblOfflineModeInfo.Text = frmmdiMain.LanguageFile.frmSettings_lblOfflineModeInfo
        lblPassword.Text = frmmdiMain.LanguageFile.frmSettings_lblPassword
        lblPathToMinecraftEXE.Text = frmmdiMain.LanguageFile.frmSettings_lblPathToMinecraftExe
        lblUsername.Text = frmmdiMain.LanguageFile.frmSettings_lblUsername

        tabLanguage.Text = frmmdiMain.LanguageFile.frmSettings_tabLanguage
        tabMinecraft.Text = frmmdiMain.LanguageFile.frmSettings_tabMinecraft
        tabOfflineMode.Text = frmmdiMain.LanguageFile.frmSettings_tabOfflineMode

    End Sub


    Private Sub Search_Available_Languages()

        Try

            Dim DirectInfo As New IO.DirectoryInfo(LanguageFolderPath)

            Dim files As IO.FileInfo() = DirectInfo.GetFiles("*.SBLNG")

            For Each file As IO.FileInfo In files
                cmbLanguageSelection.Items.Add(file.Name)
            Next

            If My.Settings.settingsLanguageFile <> "" And IO.File.Exists(Environment.CurrentDirectory & "\Languages\" & My.Settings.settingsLanguageFile) = True Then

                cmbLanguageSelection.SelectedItem = My.Settings.settingsLanguageFile

            Else

                If cmbLanguageSelection.Items.Contains("English.SBLNG") = True Then
                    cmbLanguageSelection.SelectedItem = "English.SBLNG"
                End If

            End If


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub


    Private Sub chkUseOfflineMode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkUseOfflineMode.CheckedChanged

        My.Settings.settingsOfflineMode = chkUseOfflineMode.Checked

    End Sub

    Private Sub chkConnectToServer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkConnectToServer.CheckedChanged

        My.Settings.settingsLogInOnMCStart = chkConnectToServer.Checked

        txtUsername.Enabled = chkConnectToServer.Checked
        txtPassword.Enabled = chkConnectToServer.Checked

    End Sub


    Private Sub cmdBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBrowse.Click

        Dim ofd As New OpenFileDialog
        ofd.Title = "Select your Minecraft.exe"
        ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        ofd.Filter = "Executables (*.exe)|*.exe"

        If ofd.ShowDialog = DialogResult.OK Then
            My.Settings.settingsPathToMinecraftExe = ofd.FileName
            txtPathToMinecraftExe.Text = ofd.FileName
        End If

    End Sub


    Private Sub cmdAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAccept.Click

        My.Settings.settingsUserName = txtUsername.Text
        My.Settings.settingsUserPassword = txtPassword.Text

        Me.Close()

    End Sub

    Private Sub frmSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        StartUp = True

        chkUseOfflineMode.Checked = My.Settings.settingsOfflineMode
        chkConnectToServer.Checked = My.Settings.settingsLogInOnMCStart

        txtPathToMinecraftExe.Text = My.Settings.settingsPathToMinecraftExe

        txtUsername.Text = My.Settings.settingsUserName
        txtPassword.Text = My.Settings.settingsUserPassword

        txtUsername.Enabled = chkConnectToServer.Checked
        txtPassword.Enabled = chkConnectToServer.Checked

        Search_Available_Languages()

        StartUp = False

        Apply_Language()

    End Sub

    Private Sub frmSettings_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        frmmdiMain.childStartMinecraft.Check_If_MinecraftExe_Available()

    End Sub

    Private Sub cmbLanguageSelection_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLanguageSelection.SelectedIndexChanged

        My.Settings.settingsLanguageFile = cmbLanguageSelection.SelectedItem.ToString
        My.Settings.Save()
        'MsgBox(My.Settings.settingsLanguageFile)

        If StartUp = False Then MsgBox("You will need to restart this application for the change to take effect.")

    End Sub

End Class