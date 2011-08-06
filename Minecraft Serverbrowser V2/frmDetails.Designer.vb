<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetails))
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblIP = New System.Windows.Forms.Label()
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.lblUptime = New System.Windows.Forms.Label()
        Me.txtUptime = New System.Windows.Forms.TextBox()
        Me.lblWebsite = New System.Windows.Forms.Label()
        Me.txtWebsite = New System.Windows.Forms.TextBox()
        Me.lblForumThread = New System.Windows.Forms.Label()
        Me.txtForumThread = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pctPayToPlay = New System.Windows.Forms.PictureBox()
        Me.pctWhitelist = New System.Windows.Forms.Label()
        Me.pctModified = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.pctBuildingRights = New System.Windows.Forms.Label()
        Me.pctSappling = New System.Windows.Forms.PictureBox()
        Me.grpFiltersImages = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.pctPayToPlay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctModified, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctSappling, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltersImages.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(5, 10)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(75, 5)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(185, 20)
        Me.txtName.TabIndex = 0
        '
        'lblIP
        '
        Me.lblIP.AutoSize = True
        Me.lblIP.Location = New System.Drawing.Point(5, 35)
        Me.lblIP.Name = "lblIP"
        Me.lblIP.Size = New System.Drawing.Size(17, 13)
        Me.lblIP.TabIndex = 0
        Me.lblIP.Text = "IP"
        '
        'txtIP
        '
        Me.txtIP.Location = New System.Drawing.Point(75, 30)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.ReadOnly = True
        Me.txtIP.Size = New System.Drawing.Size(185, 20)
        Me.txtIP.TabIndex = 1
        '
        'lblUptime
        '
        Me.lblUptime.AutoSize = True
        Me.lblUptime.Location = New System.Drawing.Point(5, 60)
        Me.lblUptime.Name = "lblUptime"
        Me.lblUptime.Size = New System.Drawing.Size(40, 13)
        Me.lblUptime.TabIndex = 0
        Me.lblUptime.Text = "Uptime"
        '
        'txtUptime
        '
        Me.txtUptime.Location = New System.Drawing.Point(75, 55)
        Me.txtUptime.Name = "txtUptime"
        Me.txtUptime.ReadOnly = True
        Me.txtUptime.Size = New System.Drawing.Size(185, 20)
        Me.txtUptime.TabIndex = 2
        '
        'lblWebsite
        '
        Me.lblWebsite.AutoSize = True
        Me.lblWebsite.Location = New System.Drawing.Point(5, 85)
        Me.lblWebsite.Name = "lblWebsite"
        Me.lblWebsite.Size = New System.Drawing.Size(46, 13)
        Me.lblWebsite.TabIndex = 0
        Me.lblWebsite.Text = "Website"
        '
        'txtWebsite
        '
        Me.txtWebsite.Location = New System.Drawing.Point(75, 80)
        Me.txtWebsite.Name = "txtWebsite"
        Me.txtWebsite.ReadOnly = True
        Me.txtWebsite.Size = New System.Drawing.Size(185, 20)
        Me.txtWebsite.TabIndex = 3
        '
        'lblForumThread
        '
        Me.lblForumThread.AutoSize = True
        Me.lblForumThread.Location = New System.Drawing.Point(5, 110)
        Me.lblForumThread.Name = "lblForumThread"
        Me.lblForumThread.Size = New System.Drawing.Size(66, 13)
        Me.lblForumThread.TabIndex = 0
        Me.lblForumThread.Text = "Forumthread"
        '
        'txtForumThread
        '
        Me.txtForumThread.Location = New System.Drawing.Point(75, 105)
        Me.txtForumThread.Name = "txtForumThread"
        Me.txtForumThread.ReadOnly = True
        Me.txtForumThread.Size = New System.Drawing.Size(185, 20)
        Me.txtForumThread.TabIndex = 4
        '
        'txtDescription
        '
        Me.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDescription.Location = New System.Drawing.Point(3, 138)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        Me.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescription.Size = New System.Drawing.Size(281, 139)
        Me.txtDescription.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.pctPayToPlay, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.pctWhitelist, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.pctModified, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox4, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox3, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.pctBuildingRights, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.pctSappling, 2, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(10, 15)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(245, 75)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Modified"
        '
        'pctPayToPlay
        '
        Me.pctPayToPlay.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.pctPayToPlay.Image = CType(resources.GetObject("pctPayToPlay.Image"), System.Drawing.Image)
        Me.pctPayToPlay.Location = New System.Drawing.Point(58, 46)
        Me.pctPayToPlay.Name = "pctPayToPlay"
        Me.pctPayToPlay.Size = New System.Drawing.Size(20, 20)
        Me.pctPayToPlay.TabIndex = 0
        Me.pctPayToPlay.TabStop = False
        '
        'pctWhitelist
        '
        Me.pctWhitelist.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.pctWhitelist.AutoSize = True
        Me.pctWhitelist.Location = New System.Drawing.Point(195, 49)
        Me.pctWhitelist.Name = "pctWhitelist"
        Me.pctWhitelist.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pctWhitelist.Size = New System.Drawing.Size(47, 13)
        Me.pctWhitelist.TabIndex = 0
        Me.pctWhitelist.Text = "Whitelist"
        '
        'pctModified
        '
        Me.pctModified.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.pctModified.Image = CType(resources.GetObject("pctModified.Image"), System.Drawing.Image)
        Me.pctModified.Location = New System.Drawing.Point(58, 8)
        Me.pctModified.Name = "pctModified"
        Me.pctModified.Size = New System.Drawing.Size(20, 20)
        Me.pctModified.TabIndex = 0
        Me.pctModified.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(167, 46)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox4.TabIndex = 0
        Me.PictureBox4.TabStop = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Pay"
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(167, 8)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'pctBuildingRights
        '
        Me.pctBuildingRights.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.pctBuildingRights.AutoSize = True
        Me.pctBuildingRights.Location = New System.Drawing.Point(205, 12)
        Me.pctBuildingRights.Name = "pctBuildingRights"
        Me.pctBuildingRights.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pctBuildingRights.Size = New System.Drawing.Size(37, 13)
        Me.pctBuildingRights.TabIndex = 0
        Me.pctBuildingRights.Text = "Rights"
        '
        'pctSappling
        '
        Me.pctSappling.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pctSappling.Image = Global.Minecraft_Serverbrowser_V2.My.Resources.Resources.Sappling
        Me.pctSappling.Location = New System.Drawing.Point(90, 5)
        Me.pctSappling.Name = "pctSappling"
        Me.TableLayoutPanel1.SetRowSpan(Me.pctSappling, 2)
        Me.pctSappling.Size = New System.Drawing.Size(65, 65)
        Me.pctSappling.TabIndex = 0
        Me.pctSappling.TabStop = False
        '
        'grpFiltersImages
        '
        Me.grpFiltersImages.Controls.Add(Me.TableLayoutPanel1)
        Me.grpFiltersImages.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpFiltersImages.Location = New System.Drawing.Point(3, 283)
        Me.grpFiltersImages.Name = "grpFiltersImages"
        Me.grpFiltersImages.Size = New System.Drawing.Size(281, 95)
        Me.grpFiltersImages.TabIndex = 2
        Me.grpFiltersImages.TabStop = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.grpFiltersImages, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.txtDescription, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 135.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 101.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(287, 381)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.lblName)
        Me.Panel1.Controls.Add(Me.lblIP)
        Me.Panel1.Controls.Add(Me.txtIP)
        Me.Panel1.Controls.Add(Me.txtForumThread)
        Me.Panel1.Controls.Add(Me.lblUptime)
        Me.Panel1.Controls.Add(Me.lblForumThread)
        Me.Panel1.Controls.Add(Me.txtUptime)
        Me.Panel1.Controls.Add(Me.txtWebsite)
        Me.Panel1.Controls.Add(Me.lblWebsite)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(281, 129)
        Me.Panel1.TabIndex = 0
        '
        'frmDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(287, 381)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(303, 320)
        Me.Name = "frmDetails"
        Me.Text = "Details"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.pctPayToPlay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctModified, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctSappling, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltersImages.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblIP As System.Windows.Forms.Label
    Friend WithEvents txtIP As System.Windows.Forms.TextBox
    Friend WithEvents lblUptime As System.Windows.Forms.Label
    Friend WithEvents txtUptime As System.Windows.Forms.TextBox
    Friend WithEvents lblWebsite As System.Windows.Forms.Label
    Friend WithEvents txtWebsite As System.Windows.Forms.TextBox
    Friend WithEvents lblForumThread As System.Windows.Forms.Label
    Friend WithEvents txtForumThread As System.Windows.Forms.TextBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pctPayToPlay As System.Windows.Forms.PictureBox
    Friend WithEvents pctWhitelist As System.Windows.Forms.Label
    Friend WithEvents pctModified As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents pctBuildingRights As System.Windows.Forms.Label
    Friend WithEvents pctSappling As System.Windows.Forms.PictureBox
    Friend WithEvents grpFiltersImages As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
