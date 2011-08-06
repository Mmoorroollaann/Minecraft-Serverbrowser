<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmdiMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmmdiMain))
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.toolNumberOfServers = New System.Windows.Forms.ToolStripStatusLabel()
        Me.toollblLocked = New System.Windows.Forms.ToolStripStatusLabel()
        Me.toollblHans = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.mnuiApplication = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuiApplicationOpenFolder = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuiApplicationQuit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuiWindows = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuiWindowsFilters = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuiWindowsDetails = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuiWindowsServerlistFavourites = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuiWindowsStartMinecraft = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuiExtras = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuiExtrasLockWindows = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuiExtrasRestoreDefaultWindowsPositionAndLocation = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuiExtrasSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuiAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuiCheckForUpdates = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip.SuspendLayout()
        Me.mnuMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolNumberOfServers, Me.toollblLocked, Me.toollblHans, Me.ToolStripDropDownButton1})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 455)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(632, 24)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'toolNumberOfServers
        '
        Me.toolNumberOfServers.Name = "toolNumberOfServers"
        Me.toolNumberOfServers.Size = New System.Drawing.Size(32, 19)
        Me.toolNumberOfServers.Text = "(init)"
        '
        'toollblLocked
        '
        Me.toollblLocked.Font = New System.Drawing.Font("Webdings", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.toollblLocked.Name = "toollblLocked"
        Me.toollblLocked.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.toollblLocked.Size = New System.Drawing.Size(21, 19)
        Me.toollblLocked.Text = "Ð"
        '
        'toollblHans
        '
        Me.toollblHans.Name = "toollblHans"
        Me.toollblHans.Size = New System.Drawing.Size(32, 19)
        Me.toollblHans.Text = "hans"
        Me.toollblHans.Visible = False
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(29, 22)
        Me.ToolStripDropDownButton1.Text = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Visible = False
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuiApplication, Me.mnuiWindows, Me.mnuiExtras, Me.mnuiAbout, Me.mnuiCheckForUpdates})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(632, 24)
        Me.mnuMain.TabIndex = 0
        Me.mnuMain.Text = "MenuStrip1"
        '
        'mnuiApplication
        '
        Me.mnuiApplication.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuiApplicationOpenFolder, Me.mnuiApplicationQuit})
        Me.mnuiApplication.Name = "mnuiApplication"
        Me.mnuiApplication.Size = New System.Drawing.Size(80, 20)
        Me.mnuiApplication.Text = "Application"
        '
        'mnuiApplicationOpenFolder
        '
        Me.mnuiApplicationOpenFolder.Name = "mnuiApplicationOpenFolder"
        Me.mnuiApplicationOpenFolder.Size = New System.Drawing.Size(186, 22)
        Me.mnuiApplicationOpenFolder.Text = "Open program folder"
        '
        'mnuiApplicationQuit
        '
        Me.mnuiApplicationQuit.Name = "mnuiApplicationQuit"
        Me.mnuiApplicationQuit.Size = New System.Drawing.Size(186, 22)
        Me.mnuiApplicationQuit.Text = "Quit"
        '
        'mnuiWindows
        '
        Me.mnuiWindows.CheckOnClick = True
        Me.mnuiWindows.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuiWindowsFilters, Me.mnuiWindowsDetails, Me.mnuiWindowsServerlistFavourites, Me.mnuiWindowsStartMinecraft})
        Me.mnuiWindows.Name = "mnuiWindows"
        Me.mnuiWindows.Size = New System.Drawing.Size(68, 20)
        Me.mnuiWindows.Text = "Windows"
        '
        'mnuiWindowsFilters
        '
        Me.mnuiWindowsFilters.CheckOnClick = True
        Me.mnuiWindowsFilters.Name = "mnuiWindowsFilters"
        Me.mnuiWindowsFilters.Size = New System.Drawing.Size(191, 22)
        Me.mnuiWindowsFilters.Text = "Filters"
        '
        'mnuiWindowsDetails
        '
        Me.mnuiWindowsDetails.CheckOnClick = True
        Me.mnuiWindowsDetails.Name = "mnuiWindowsDetails"
        Me.mnuiWindowsDetails.Size = New System.Drawing.Size(191, 22)
        Me.mnuiWindowsDetails.Text = "Details"
        '
        'mnuiWindowsServerlistFavourites
        '
        Me.mnuiWindowsServerlistFavourites.CheckOnClick = True
        Me.mnuiWindowsServerlistFavourites.Name = "mnuiWindowsServerlistFavourites"
        Me.mnuiWindowsServerlistFavourites.Size = New System.Drawing.Size(191, 22)
        Me.mnuiWindowsServerlistFavourites.Text = "Serverlist && Favourites"
        '
        'mnuiWindowsStartMinecraft
        '
        Me.mnuiWindowsStartMinecraft.CheckOnClick = True
        Me.mnuiWindowsStartMinecraft.Name = "mnuiWindowsStartMinecraft"
        Me.mnuiWindowsStartMinecraft.Size = New System.Drawing.Size(191, 22)
        Me.mnuiWindowsStartMinecraft.Text = "Start Minecraft"
        '
        'mnuiExtras
        '
        Me.mnuiExtras.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuiExtrasLockWindows, Me.mnuiExtrasRestoreDefaultWindowsPositionAndLocation, Me.mnuiExtrasSettings})
        Me.mnuiExtras.Name = "mnuiExtras"
        Me.mnuiExtras.Size = New System.Drawing.Size(49, 20)
        Me.mnuiExtras.Text = "Extras"
        '
        'mnuiExtrasLockWindows
        '
        Me.mnuiExtrasLockWindows.CheckOnClick = True
        Me.mnuiExtrasLockWindows.Name = "mnuiExtrasLockWindows"
        Me.mnuiExtrasLockWindows.ShortcutKeyDisplayString = ""
        Me.mnuiExtrasLockWindows.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.mnuiExtrasLockWindows.Size = New System.Drawing.Size(318, 22)
        Me.mnuiExtrasLockWindows.Text = "Lock Windows"
        '
        'mnuiExtrasRestoreDefaultWindowsPositionAndLocation
        '
        Me.mnuiExtrasRestoreDefaultWindowsPositionAndLocation.Name = "mnuiExtrasRestoreDefaultWindowsPositionAndLocation"
        Me.mnuiExtrasRestoreDefaultWindowsPositionAndLocation.Size = New System.Drawing.Size(318, 22)
        Me.mnuiExtrasRestoreDefaultWindowsPositionAndLocation.Text = "Restore default windows position and location"
        '
        'mnuiExtrasSettings
        '
        Me.mnuiExtrasSettings.Name = "mnuiExtrasSettings"
        Me.mnuiExtrasSettings.Size = New System.Drawing.Size(318, 22)
        Me.mnuiExtrasSettings.Text = "Settings"
        '
        'mnuiAbout
        '
        Me.mnuiAbout.Name = "mnuiAbout"
        Me.mnuiAbout.Size = New System.Drawing.Size(52, 20)
        Me.mnuiAbout.Text = "About"
        '
        'mnuiCheckForUpdates
        '
        Me.mnuiCheckForUpdates.Name = "mnuiCheckForUpdates"
        Me.mnuiCheckForUpdates.Size = New System.Drawing.Size(115, 20)
        Me.mnuiCheckForUpdates.Text = "Check for updates"
        '
        'frmmdiMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 479)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.mnuMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "frmmdiMain"
        Me.Text = "Minecraft Serverbrowser"
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents mnuMain As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuiApplication As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuiApplicationOpenFolder As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuiApplicationQuit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuiWindows As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuiWindowsFilters As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuiWindowsDetails As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuiWindowsServerlistFavourites As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuiWindowsStartMinecraft As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuiExtras As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuiExtrasLockWindows As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuiExtrasSettings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolNumberOfServers As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents toollblLocked As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents toollblHans As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents mnuiExtrasRestoreDefaultWindowsPositionAndLocation As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuiAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuiCheckForUpdates As System.Windows.Forms.ToolStripMenuItem

End Class
