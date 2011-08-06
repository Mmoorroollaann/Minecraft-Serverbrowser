Public Class frmFilters

    Private Sub Initialize()

        Dim x As Windows.Forms.Button

        x = cmdFilterBuildingRights
        Select Case My.Settings.filterBuildingRights
            Case 0
                x.BackColor = Color.WhiteSmoke
            Case 1
                x.BackColor = Color.Green
            Case 2
                x.BackColor = Color.Red
        End Select

        x = cmdFilterModified
        Select Case My.Settings.filterModified
            Case 0
                x.BackColor = Color.WhiteSmoke
            Case 1
                x.BackColor = Color.Green
            Case 2
                x.BackColor = Color.Red
        End Select

        x = cmdFilterPayToPlay
        Select Case My.Settings.filterPayToPlay
            Case 0
                x.BackColor = Color.WhiteSmoke
            Case 1
                x.BackColor = Color.Green
            Case 2
                x.BackColor = Color.Red
        End Select

        x = cmdFilterWhitelist
        Select Case My.Settings.filterWhitelist
            Case 0
                x.BackColor = Color.WhiteSmoke
            Case 1
                x.BackColor = Color.Green
            Case 2
                x.BackColor = Color.Red
        End Select

    End Sub

    Private Sub Apply_Language()

        ' If the language file has been removed it will not apply the (missing) informations, since this would lead to blank buttons and stuff
        If frmmdiMain.LanguageFile.isLanguageFileAvailable = False Then Exit Sub

        Me.Text = frmmdiMain.LanguageFile.frmFilters_Text
        cmdFilterBuildingRights.Text = frmmdiMain.LanguageFile.frmFilters_cmdBuildingRights
        cmdFilterModified.Text = frmmdiMain.LanguageFile.frmFilters_cmdModified
        cmdFilterPayToPlay.Text = frmmdiMain.LanguageFile.frmFilters_cmdPayToPlay
        cmdFilterWhitelist.Text = frmmdiMain.LanguageFile.frmFilters_cmdWhitelist

    End Sub


    Private Sub cmdFilterWhitelist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFilterWhitelist.Click

        Dim x As Windows.Forms.Button = cmdFilterWhitelist

        Select Case x.BackColor
            Case Color.WhiteSmoke
                x.BackColor = Color.Green
                My.Settings.filterWhitelist = 1
            Case Color.Green
                x.BackColor = Color.Red
                My.Settings.filterWhitelist = 2
            Case Color.Red
                x.BackColor = Color.WhiteSmoke
                My.Settings.filterWhitelist = 0
        End Select

    End Sub

    Private Sub cmdFilterBuildingRights_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFilterBuildingRights.Click

        Dim x As Windows.Forms.Button = cmdFilterBuildingRights

        Select Case x.BackColor
            Case Color.WhiteSmoke
                x.BackColor = Color.Green
                My.Settings.filterBuildingRights = 1
            Case Color.Green
                x.BackColor = Color.Red
                My.Settings.filterBuildingRights = 2
            Case Color.Red
                x.BackColor = Color.WhiteSmoke
                My.Settings.filterBuildingRights = 0
        End Select

    End Sub

    Private Sub cmdFilterPayToPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFilterPayToPlay.Click

        Dim x As Windows.Forms.Button = cmdFilterPayToPlay

        Select Case x.BackColor
            Case Color.WhiteSmoke
                x.BackColor = Color.Green
                My.Settings.filterPayToPlay = 1
            Case Color.Green
                x.BackColor = Color.Red
                My.Settings.filterPayToPlay = 2
            Case Color.Red
                x.BackColor = Color.WhiteSmoke
                My.Settings.filterPayToPlay = 0
        End Select

    End Sub

    Private Sub cmdFilterModified_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFilterModified.Click

        Dim x As Windows.Forms.Button = cmdFilterModified

        Select Case x.BackColor
            Case Color.WhiteSmoke
                x.BackColor = Color.Green
                My.Settings.filterModified = 1
            Case Color.Green
                x.BackColor = Color.Red
                My.Settings.filterModified = 2
            Case Color.Red
                x.BackColor = Color.WhiteSmoke
                My.Settings.filterModified = 0
        End Select

    End Sub


    Private Sub frmFilters_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Initialize()
        Apply_Language()

    End Sub

    Private Sub frmFilters_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        frmmdiMain.mnuiWindowsFilters.Checked = False
        My.Settings.childFiltersLocation = Me.Location
        My.Settings.childFiltersSize = Me.Size

    End Sub

    'Private Sub frmFilters_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Move
    '    frmmdiMain.Label1.Text = Me.Location.ToString
    'End Sub

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

End Class