Public Class frmStartMinecraft

    Friend Sub Check_If_MinecraftExe_Available()

        If IO.File.Exists(My.Settings.settingsPathToMinecraftExe) Then

            cmdStartMinecraft.BackgroundImage = My.Resources.Pumpkin_lit

        Else

            cmdStartMinecraft.BackgroundImage = My.Resources.Pumpkin_unlit

        End If

    End Sub

    Private Sub cmdStartMinecraft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStartMinecraft.Click

        If My.Settings.settingsLogInOnMCStart = True And My.Settings.settingsPathToMinecraftExe <> "" Then

            'Clipboard.SetDataObject(frmmdiMain.childDetails.ActiveServer.IP, True)

            Dim Hans As New Diagnostics.ProcessStartInfo()
            Hans.FileName = My.Settings.settingsPathToMinecraftExe
            Hans.Arguments = _
                My.Settings.settingsUserName & " " & _
                My.Settings.settingsUserPassword & " " & _
                frmmdiMain.childDetails.ActiveServer.IP

            Diagnostics.Process.Start(Hans)

            'MsgBox(My.Settings.settingsPathToMinecraftExe & " " & My.Settings.settingsUserName & " " & My.Settings.settingsUserPassword & _
            '       " " & frmmdiMain.childDetails.ActiveServer.IP)

        ElseIf My.Settings.settingsPathToMinecraftExe <> "" Then

            Clipboard.SetDataObject(frmmdiMain.childDetails.ActiveServer.IP, True)

            Try
                ' Da in options.txt der Port mit einem _ und nicht mit einem : an die IP angehängt wird, muss der : zuerst mit einem _ ersetzt werden.

                Dim IP As String = frmmdiMain.childDetails.ActiveServer.IP
                IP = IP.Replace(CChar(":"), CChar("_"))

                frmmdiMain.SettingsFile.Change_Line(13, "lastServer:" & IP)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Process.Start(My.Settings.settingsPathToMinecraftExe)

        Else

                MsgBox("Please specify the path to where your Minecraft.exe can be found in the options menu")

        End If

    End Sub


    Private Sub frmStartMinecraft_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Check_If_MinecraftExe_Available()

    End Sub

    Private Sub frmStartMinecraft_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        frmmdiMain.mnuiWindowsStartMinecraft.Checked = False

        My.Settings.childStartMinecraftLocation = Me.Location
        My.Settings.childStartMinecraftSize = Me.Size

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


End Class