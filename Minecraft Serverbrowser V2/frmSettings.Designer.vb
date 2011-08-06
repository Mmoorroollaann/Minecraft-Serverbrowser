<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettings))
        Me.tabSettings = New System.Windows.Forms.TabControl()
        Me.tabMinecraft = New System.Windows.Forms.TabPage()
        Me.lblPathToMinecraftEXE = New System.Windows.Forms.Label()
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.txtPathToMinecraftExe = New System.Windows.Forms.TextBox()
        Me.grpLoginMinecraft = New System.Windows.Forms.GroupBox()
        Me.chkConnectToServer = New System.Windows.Forms.CheckBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblAuthenticationInfo = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.tabOfflineMode = New System.Windows.Forms.TabPage()
        Me.grpOfflineMode = New System.Windows.Forms.GroupBox()
        Me.chkUseOfflineMode = New System.Windows.Forms.CheckBox()
        Me.lblOfflineModeInfo = New System.Windows.Forms.Label()
        Me.tabLanguage = New System.Windows.Forms.TabPage()
        Me.cmbLanguageSelection = New System.Windows.Forms.ComboBox()
        Me.lblLanguageInfo = New System.Windows.Forms.Label()
        Me.lblChooseLanguage = New System.Windows.Forms.Label()
        Me.cmdAccept = New System.Windows.Forms.Button()
        Me.tabSettings.SuspendLayout()
        Me.tabMinecraft.SuspendLayout()
        Me.grpLoginMinecraft.SuspendLayout()
        Me.tabOfflineMode.SuspendLayout()
        Me.grpOfflineMode.SuspendLayout()
        Me.tabLanguage.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabSettings
        '
        Me.tabSettings.Controls.Add(Me.tabMinecraft)
        Me.tabSettings.Controls.Add(Me.tabOfflineMode)
        Me.tabSettings.Controls.Add(Me.tabLanguage)
        Me.tabSettings.Location = New System.Drawing.Point(0, 0)
        Me.tabSettings.Name = "tabSettings"
        Me.tabSettings.SelectedIndex = 0
        Me.tabSettings.Size = New System.Drawing.Size(305, 340)
        Me.tabSettings.TabIndex = 0
        '
        'tabMinecraft
        '
        Me.tabMinecraft.Controls.Add(Me.lblPathToMinecraftEXE)
        Me.tabMinecraft.Controls.Add(Me.cmdBrowse)
        Me.tabMinecraft.Controls.Add(Me.txtPathToMinecraftExe)
        Me.tabMinecraft.Controls.Add(Me.grpLoginMinecraft)
        Me.tabMinecraft.Location = New System.Drawing.Point(4, 22)
        Me.tabMinecraft.Name = "tabMinecraft"
        Me.tabMinecraft.Padding = New System.Windows.Forms.Padding(3)
        Me.tabMinecraft.Size = New System.Drawing.Size(297, 314)
        Me.tabMinecraft.TabIndex = 0
        Me.tabMinecraft.Text = "Minecraft"
        Me.tabMinecraft.UseVisualStyleBackColor = True
        '
        'lblPathToMinecraftEXE
        '
        Me.lblPathToMinecraftEXE.AutoSize = True
        Me.lblPathToMinecraftEXE.Location = New System.Drawing.Point(10, 240)
        Me.lblPathToMinecraftEXE.Name = "lblPathToMinecraftEXE"
        Me.lblPathToMinecraftEXE.Size = New System.Drawing.Size(115, 13)
        Me.lblPathToMinecraftEXE.TabIndex = 4
        Me.lblPathToMinecraftEXE.Text = "Path to Minecraft EXE:"
        '
        'cmdBrowse
        '
        Me.cmdBrowse.Location = New System.Drawing.Point(5, 285)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(75, 23)
        Me.cmdBrowse.TabIndex = 2
        Me.cmdBrowse.Text = "Browse"
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'txtPathToMinecraftExe
        '
        Me.txtPathToMinecraftExe.Location = New System.Drawing.Point(10, 260)
        Me.txtPathToMinecraftExe.Name = "txtPathToMinecraftExe"
        Me.txtPathToMinecraftExe.ReadOnly = True
        Me.txtPathToMinecraftExe.Size = New System.Drawing.Size(280, 20)
        Me.txtPathToMinecraftExe.TabIndex = 1
        '
        'grpLoginMinecraft
        '
        Me.grpLoginMinecraft.Controls.Add(Me.chkConnectToServer)
        Me.grpLoginMinecraft.Controls.Add(Me.txtPassword)
        Me.grpLoginMinecraft.Controls.Add(Me.txtUsername)
        Me.grpLoginMinecraft.Controls.Add(Me.lblAuthenticationInfo)
        Me.grpLoginMinecraft.Controls.Add(Me.lblPassword)
        Me.grpLoginMinecraft.Controls.Add(Me.lblUsername)
        Me.grpLoginMinecraft.Location = New System.Drawing.Point(5, 5)
        Me.grpLoginMinecraft.Name = "grpLoginMinecraft"
        Me.grpLoginMinecraft.Size = New System.Drawing.Size(285, 225)
        Me.grpLoginMinecraft.TabIndex = 0
        Me.grpLoginMinecraft.TabStop = False
        Me.grpLoginMinecraft.Text = "Authentication"
        '
        'chkConnectToServer
        '
        Me.chkConnectToServer.AutoSize = True
        Me.chkConnectToServer.Location = New System.Drawing.Point(10, 140)
        Me.chkConnectToServer.Name = "chkConnectToServer"
        Me.chkConnectToServer.Size = New System.Drawing.Size(174, 17)
        Me.chkConnectToServer.TabIndex = 0
        Me.chkConnectToServer.Text = "Connect to server automatically"
        Me.chkConnectToServer.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Enabled = False
        Me.txtPassword.Location = New System.Drawing.Point(80, 200)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(130, 20)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtUsername
        '
        Me.txtUsername.Enabled = False
        Me.txtUsername.Location = New System.Drawing.Point(80, 170)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(130, 20)
        Me.txtUsername.TabIndex = 1
        '
        'lblAuthenticationInfo
        '
        Me.lblAuthenticationInfo.Location = New System.Drawing.Point(10, 15)
        Me.lblAuthenticationInfo.Name = "lblAuthenticationInfo"
        Me.lblAuthenticationInfo.Size = New System.Drawing.Size(265, 120)
        Me.lblAuthenticationInfo.TabIndex = 0
        Me.lblAuthenticationInfo.Text = resources.GetString("lblAuthenticationInfo.Text")
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(20, 205)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(53, 13)
        Me.lblPassword.TabIndex = 1
        Me.lblPassword.Text = "Password"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(20, 175)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(55, 13)
        Me.lblUsername.TabIndex = 1
        Me.lblUsername.Text = "Username"
        '
        'tabOfflineMode
        '
        Me.tabOfflineMode.Controls.Add(Me.grpOfflineMode)
        Me.tabOfflineMode.Location = New System.Drawing.Point(4, 22)
        Me.tabOfflineMode.Name = "tabOfflineMode"
        Me.tabOfflineMode.Padding = New System.Windows.Forms.Padding(3)
        Me.tabOfflineMode.Size = New System.Drawing.Size(297, 314)
        Me.tabOfflineMode.TabIndex = 1
        Me.tabOfflineMode.Text = "Offline mode"
        Me.tabOfflineMode.UseVisualStyleBackColor = True
        '
        'grpOfflineMode
        '
        Me.grpOfflineMode.AutoSize = True
        Me.grpOfflineMode.Controls.Add(Me.chkUseOfflineMode)
        Me.grpOfflineMode.Controls.Add(Me.lblOfflineModeInfo)
        Me.grpOfflineMode.Location = New System.Drawing.Point(5, 5)
        Me.grpOfflineMode.Name = "grpOfflineMode"
        Me.grpOfflineMode.Size = New System.Drawing.Size(285, 126)
        Me.grpOfflineMode.TabIndex = 5
        Me.grpOfflineMode.TabStop = False
        Me.grpOfflineMode.Text = "Offline mode"
        '
        'chkUseOfflineMode
        '
        Me.chkUseOfflineMode.AutoSize = True
        Me.chkUseOfflineMode.Location = New System.Drawing.Point(10, 90)
        Me.chkUseOfflineMode.Name = "chkUseOfflineMode"
        Me.chkUseOfflineMode.Size = New System.Drawing.Size(105, 17)
        Me.chkUseOfflineMode.TabIndex = 0
        Me.chkUseOfflineMode.Text = "Use offline mode"
        Me.chkUseOfflineMode.UseVisualStyleBackColor = True
        '
        'lblOfflineModeInfo
        '
        Me.lblOfflineModeInfo.Location = New System.Drawing.Point(10, 15)
        Me.lblOfflineModeInfo.Name = "lblOfflineModeInfo"
        Me.lblOfflineModeInfo.Size = New System.Drawing.Size(265, 78)
        Me.lblOfflineModeInfo.TabIndex = 1
        Me.lblOfflineModeInfo.Text = resources.GetString("lblOfflineModeInfo.Text")
        '
        'tabLanguage
        '
        Me.tabLanguage.Controls.Add(Me.cmbLanguageSelection)
        Me.tabLanguage.Controls.Add(Me.lblLanguageInfo)
        Me.tabLanguage.Controls.Add(Me.lblChooseLanguage)
        Me.tabLanguage.Location = New System.Drawing.Point(4, 22)
        Me.tabLanguage.Name = "tabLanguage"
        Me.tabLanguage.Padding = New System.Windows.Forms.Padding(3)
        Me.tabLanguage.Size = New System.Drawing.Size(297, 314)
        Me.tabLanguage.TabIndex = 2
        Me.tabLanguage.Text = "Language"
        Me.tabLanguage.UseVisualStyleBackColor = True
        '
        'cmbLanguageSelection
        '
        Me.cmbLanguageSelection.FormattingEnabled = True
        Me.cmbLanguageSelection.Location = New System.Drawing.Point(10, 30)
        Me.cmbLanguageSelection.Name = "cmbLanguageSelection"
        Me.cmbLanguageSelection.Size = New System.Drawing.Size(121, 21)
        Me.cmbLanguageSelection.TabIndex = 1
        '
        'lblLanguageInfo
        '
        Me.lblLanguageInfo.Location = New System.Drawing.Point(5, 85)
        Me.lblLanguageInfo.Name = "lblLanguageInfo"
        Me.lblLanguageInfo.Size = New System.Drawing.Size(265, 105)
        Me.lblLanguageInfo.TabIndex = 0
        Me.lblLanguageInfo.Text = "To install a language you need to place the .SBLNG file you've downloaded in the " & _
            "language folder of the Minecraft Serverbrowser folder"
        '
        'lblChooseLanguage
        '
        Me.lblChooseLanguage.AutoSize = True
        Me.lblChooseLanguage.Location = New System.Drawing.Point(5, 10)
        Me.lblChooseLanguage.Name = "lblChooseLanguage"
        Me.lblChooseLanguage.Size = New System.Drawing.Size(202, 13)
        Me.lblChooseLanguage.TabIndex = 0
        Me.lblChooseLanguage.Text = "Choose which language you want to use:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cmdAccept
        '
        Me.cmdAccept.Location = New System.Drawing.Point(220, 345)
        Me.cmdAccept.Name = "cmdAccept"
        Me.cmdAccept.Size = New System.Drawing.Size(75, 23)
        Me.cmdAccept.TabIndex = 1
        Me.cmdAccept.Text = "Accept"
        Me.cmdAccept.UseVisualStyleBackColor = True
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 375)
        Me.Controls.Add(Me.tabSettings)
        Me.Controls.Add(Me.cmdAccept)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmSettings"
        Me.Text = "Settings"
        Me.tabSettings.ResumeLayout(False)
        Me.tabMinecraft.ResumeLayout(False)
        Me.tabMinecraft.PerformLayout()
        Me.grpLoginMinecraft.ResumeLayout(False)
        Me.grpLoginMinecraft.PerformLayout()
        Me.tabOfflineMode.ResumeLayout(False)
        Me.tabOfflineMode.PerformLayout()
        Me.grpOfflineMode.ResumeLayout(False)
        Me.grpOfflineMode.PerformLayout()
        Me.tabLanguage.ResumeLayout(False)
        Me.tabLanguage.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabSettings As System.Windows.Forms.TabControl
    Friend WithEvents tabMinecraft As System.Windows.Forms.TabPage
    Friend WithEvents tabOfflineMode As System.Windows.Forms.TabPage
    Friend WithEvents cmdAccept As System.Windows.Forms.Button
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents grpLoginMinecraft As System.Windows.Forms.GroupBox
    Friend WithEvents chkConnectToServer As System.Windows.Forms.CheckBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblAuthenticationInfo As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents grpOfflineMode As System.Windows.Forms.GroupBox
    Friend WithEvents chkUseOfflineMode As System.Windows.Forms.CheckBox
    Friend WithEvents lblOfflineModeInfo As System.Windows.Forms.Label
    Friend WithEvents lblPathToMinecraftEXE As System.Windows.Forms.Label
    Friend WithEvents cmdBrowse As System.Windows.Forms.Button
    Friend WithEvents txtPathToMinecraftExe As System.Windows.Forms.TextBox
    Friend WithEvents tabLanguage As System.Windows.Forms.TabPage
    Friend WithEvents lblLanguageInfo As System.Windows.Forms.Label
    Friend WithEvents lblChooseLanguage As System.Windows.Forms.Label
    Friend WithEvents cmbLanguageSelection As System.Windows.Forms.ComboBox
End Class
