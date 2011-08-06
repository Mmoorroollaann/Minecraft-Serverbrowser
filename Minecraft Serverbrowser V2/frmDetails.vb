Public Class frmDetails

    Friend ActiveServer As Server

    Private Sub Apply_Language()

        ' If the language file has been removed it will not apply the (missing) informations, since this would lead to blank buttons and stuff
        If frmmdiMain.LanguageFile.isLanguageFileAvailable = False Then Exit Sub

        Me.Text = frmmdiMain.LanguageFile.frmDetails_Text

        lblForumThread.Text = frmmdiMain.LanguageFile.frmDetails_lblForumThread
        lblIP.Text = frmmdiMain.LanguageFile.frmDetails_lblIP
        lblName.Text = frmmdiMain.LanguageFile.frmDetails_lblName
        lblUptime.Text = frmmdiMain.LanguageFile.frmDetails_lblUptime
        lblWebsite.Text = frmmdiMain.LanguageFile.frmDetails_lblWebsite

    End Sub

    Friend Sub Update_Data(ByVal Serverlist As Serverlist, ByVal SelectedIndex As Integer)

        ' Updates the various textboxes according to the server at the given index of the given serverlist.

        If SelectedIndex < 0 Or SelectedIndex > Serverlist.ListOfServers.Count - 1 Then
            Exit Sub
        End If

        txtName.Text = Serverlist.ListOfServers(SelectedIndex).ServerName
        txtIP.Text = Serverlist.ListOfServers(SelectedIndex).IP
        txtUptime.Text = CStr(Serverlist.ListOfServers(SelectedIndex).Uptime)

        ' txtWebsite should actually be called txtWebsiteURL, so there won't be any confusion. Same goes for txtForumThread
        If Serverlist.ListOfServers(SelectedIndex).Website = True Then
            txtWebsite.Text = Serverlist.ListOfServers(SelectedIndex).WebsiteURL
            txtWebsite.Enabled = True
        Else
            txtWebsite.Text = ""
            txtWebsite.Enabled = False
        End If

        If Serverlist.ListOfServers(SelectedIndex).Thread = True Then
            txtForumThread.Text = Serverlist.ListOfServers(SelectedIndex).ThreadURL
            txtForumThread.Enabled = True
        Else
            txtForumThread.Text = ""
            txtForumThread.Enabled = False
        End If

        txtDescription.Text = Serverlist.ListOfServers(SelectedIndex).Description

        ActiveServer = Serverlist.ListOfServers(SelectedIndex)

    End Sub

    Private Sub frmDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Apply_Language()

    End Sub

    Private Sub frmDetails_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        frmmdiMain.mnuiWindowsDetails.Checked = False
        My.Settings.childDetailsLocation = Me.Location
        My.Settings.childDetailsSize = Me.Size

    End Sub

    Private Sub frmDetails_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        Me.Width = 303

    End Sub

    Protected Overrides Sub WndProc(ByRef m As Message)

        If My.Settings.LockWindows = True Then

            Const WM_NCLBUTTONDOWN As Integer = 161
            Const WM_SYSCOMMAND As Integer = 274
            Const HTCAPTION As Integer = 2
            Const SC_MOVE As Integer = 61456

            If (m.Msg = WM_SYSCOMMAND) AndAlso (m.WParam.ToInt32() = SC_MOVE) Then
                Return
            End If
            If (m.Msg = WM_NCLBUTTONDOWN) AndAlso (m.WParam.ToInt32() = HTCAPTION) Then
                Return
            End If

            MyBase.WndProc(m)

        Else

            MyBase.WndProc(m)

        End If

    End Sub

    Private Sub txtIP_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIP.DoubleClick

        Clipboard.SetDataObject(frmmdiMain.childDetails.ActiveServer.IP, True)

    End Sub


    Private Sub txtForumThread_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtForumThread.DoubleClick

        If txtForumThread.Text <> "" Then
            Diagnostics.Process.Start(txtForumThread.Text)
        End If

    End Sub

    Private Sub txtWebsite_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtWebsite.DoubleClick

        If txtWebsite.Text <> "" Then
            Diagnostics.Process.Start(txtWebsite.Text)
        End If

    End Sub

End Class