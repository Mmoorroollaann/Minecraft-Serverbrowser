<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServerlist
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmServerlist))
        Me.lstServerlistRedstonewire = New System.Windows.Forms.ListBox()
        Me.tabServerlistFavourites = New System.Windows.Forms.TabPage()
        Me.tableServerlistFavourites = New System.Windows.Forms.TableLayoutPanel()
        Me.tableServerlistFavouritesButtons = New System.Windows.Forms.TableLayoutPanel()
        Me.cmdAddNewFavourite = New System.Windows.Forms.Button()
        Me.cmdDeleteFavourite = New System.Windows.Forms.Button()
        Me.cmdEditFavourite = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlMoveFavourites = New System.Windows.Forms.Panel()
        Me.cmdDownDouble = New System.Windows.Forms.Button()
        Me.cmdDownSingle = New System.Windows.Forms.Button()
        Me.cmdUpSingle = New System.Windows.Forms.Button()
        Me.cmdUpDouble = New System.Windows.Forms.Button()
        Me.lstServerlistFavourites = New System.Windows.Forms.ListBox()
        Me.tabServerlistRedstonewire = New System.Windows.Forms.TabPage()
        Me.tableServerlistRedstonewire = New System.Windows.Forms.TableLayoutPanel()
        Me.cmdAddToFavourites = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.tabServerlist = New System.Windows.Forms.TabControl()
        Me.tabServerlistHistory = New System.Windows.Forms.TabPage()
        Me.tableHistoryMain = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlHistoryButtons = New System.Windows.Forms.Panel()
        Me.cmdClearHistory = New System.Windows.Forms.Button()
        Me.lstServerlistHistory = New System.Windows.Forms.ListBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.tabServerlistFavourites.SuspendLayout()
        Me.tableServerlistFavourites.SuspendLayout()
        Me.tableServerlistFavouritesButtons.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.pnlMoveFavourites.SuspendLayout()
        Me.tabServerlistRedstonewire.SuspendLayout()
        Me.tableServerlistRedstonewire.SuspendLayout()
        Me.tabServerlist.SuspendLayout()
        Me.tabServerlistHistory.SuspendLayout()
        Me.tableHistoryMain.SuspendLayout()
        Me.pnlHistoryButtons.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstServerlistRedstonewire
        '
        Me.lstServerlistRedstonewire.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstServerlistRedstonewire.FormattingEnabled = True
        Me.lstServerlistRedstonewire.Location = New System.Drawing.Point(3, 53)
        Me.lstServerlistRedstonewire.Name = "lstServerlistRedstonewire"
        Me.lstServerlistRedstonewire.Size = New System.Drawing.Size(172, 257)
        Me.lstServerlistRedstonewire.TabIndex = 1
        '
        'tabServerlistFavourites
        '
        Me.tabServerlistFavourites.Controls.Add(Me.tableServerlistFavourites)
        Me.tabServerlistFavourites.Location = New System.Drawing.Point(4, 25)
        Me.tabServerlistFavourites.Margin = New System.Windows.Forms.Padding(1, 3, 3, 3)
        Me.tabServerlistFavourites.Name = "tabServerlistFavourites"
        Me.tabServerlistFavourites.Padding = New System.Windows.Forms.Padding(1, 3, 3, 3)
        Me.tabServerlistFavourites.Size = New System.Drawing.Size(184, 319)
        Me.tabServerlistFavourites.TabIndex = 1
        Me.tabServerlistFavourites.Text = "Favourites"
        Me.tabServerlistFavourites.UseVisualStyleBackColor = True
        '
        'tableServerlistFavourites
        '
        Me.tableServerlistFavourites.ColumnCount = 1
        Me.tableServerlistFavourites.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableServerlistFavourites.Controls.Add(Me.tableServerlistFavouritesButtons, 0, 0)
        Me.tableServerlistFavourites.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.tableServerlistFavourites.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableServerlistFavourites.Location = New System.Drawing.Point(1, 3)
        Me.tableServerlistFavourites.Margin = New System.Windows.Forms.Padding(1)
        Me.tableServerlistFavourites.Name = "tableServerlistFavourites"
        Me.tableServerlistFavourites.RowCount = 2
        Me.tableServerlistFavourites.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.tableServerlistFavourites.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableServerlistFavourites.Size = New System.Drawing.Size(180, 313)
        Me.tableServerlistFavourites.TabIndex = 0
        '
        'tableServerlistFavouritesButtons
        '
        Me.tableServerlistFavouritesButtons.ColumnCount = 2
        Me.tableServerlistFavouritesButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableServerlistFavouritesButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableServerlistFavouritesButtons.Controls.Add(Me.cmdAddNewFavourite, 0, 0)
        Me.tableServerlistFavouritesButtons.Controls.Add(Me.cmdDeleteFavourite, 0, 1)
        Me.tableServerlistFavouritesButtons.Controls.Add(Me.cmdEditFavourite, 0, 1)
        Me.tableServerlistFavouritesButtons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableServerlistFavouritesButtons.Location = New System.Drawing.Point(1, 3)
        Me.tableServerlistFavouritesButtons.Margin = New System.Windows.Forms.Padding(1, 3, 3, 3)
        Me.tableServerlistFavouritesButtons.Name = "tableServerlistFavouritesButtons"
        Me.tableServerlistFavouritesButtons.RowCount = 2
        Me.tableServerlistFavouritesButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableServerlistFavouritesButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableServerlistFavouritesButtons.Size = New System.Drawing.Size(176, 53)
        Me.tableServerlistFavouritesButtons.TabIndex = 1
        '
        'cmdAddNewFavourite
        '
        Me.tableServerlistFavouritesButtons.SetColumnSpan(Me.cmdAddNewFavourite, 2)
        Me.cmdAddNewFavourite.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdAddNewFavourite.Location = New System.Drawing.Point(3, 3)
        Me.cmdAddNewFavourite.Name = "cmdAddNewFavourite"
        Me.cmdAddNewFavourite.Size = New System.Drawing.Size(170, 20)
        Me.cmdAddNewFavourite.TabIndex = 0
        Me.cmdAddNewFavourite.Text = "Add new Favourite"
        Me.cmdAddNewFavourite.UseVisualStyleBackColor = True
        '
        'cmdDeleteFavourite
        '
        Me.cmdDeleteFavourite.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdDeleteFavourite.Location = New System.Drawing.Point(91, 29)
        Me.cmdDeleteFavourite.Name = "cmdDeleteFavourite"
        Me.cmdDeleteFavourite.Size = New System.Drawing.Size(82, 21)
        Me.cmdDeleteFavourite.TabIndex = 2
        Me.cmdDeleteFavourite.Text = "Delete"
        Me.cmdDeleteFavourite.UseVisualStyleBackColor = True
        '
        'cmdEditFavourite
        '
        Me.cmdEditFavourite.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdEditFavourite.Location = New System.Drawing.Point(3, 29)
        Me.cmdEditFavourite.Name = "cmdEditFavourite"
        Me.cmdEditFavourite.Size = New System.Drawing.Size(82, 21)
        Me.cmdEditFavourite.TabIndex = 1
        Me.cmdEditFavourite.Text = "Edit"
        Me.cmdEditFavourite.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.pnlMoveFavourites, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lstServerlistFavourites, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 62)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(174, 248)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'pnlMoveFavourites
        '
        Me.pnlMoveFavourites.Controls.Add(Me.cmdDownDouble)
        Me.pnlMoveFavourites.Controls.Add(Me.cmdDownSingle)
        Me.pnlMoveFavourites.Controls.Add(Me.cmdUpSingle)
        Me.pnlMoveFavourites.Controls.Add(Me.cmdUpDouble)
        Me.pnlMoveFavourites.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMoveFavourites.Location = New System.Drawing.Point(0, 1)
        Me.pnlMoveFavourites.Margin = New System.Windows.Forms.Padding(0, 1, 1, 1)
        Me.pnlMoveFavourites.Name = "pnlMoveFavourites"
        Me.pnlMoveFavourites.Size = New System.Drawing.Size(28, 246)
        Me.pnlMoveFavourites.TabIndex = 4
        '
        'cmdDownDouble
        '
        Me.cmdDownDouble.BackgroundImage = Global.Minecraft_Serverbrowser_V2.My.Resources.Resources.arrow_double_down
        Me.cmdDownDouble.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdDownDouble.Location = New System.Drawing.Point(1, 164)
        Me.cmdDownDouble.Margin = New System.Windows.Forms.Padding(1, 3, 3, 3)
        Me.cmdDownDouble.Name = "cmdDownDouble"
        Me.cmdDownDouble.Size = New System.Drawing.Size(25, 35)
        Me.cmdDownDouble.TabIndex = 2
        Me.cmdDownDouble.UseVisualStyleBackColor = True
        '
        'cmdDownSingle
        '
        Me.cmdDownSingle.BackgroundImage = Global.Minecraft_Serverbrowser_V2.My.Resources.Resources.arrow_single_down
        Me.cmdDownSingle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdDownSingle.Location = New System.Drawing.Point(1, 124)
        Me.cmdDownSingle.Margin = New System.Windows.Forms.Padding(1, 3, 3, 3)
        Me.cmdDownSingle.Name = "cmdDownSingle"
        Me.cmdDownSingle.Size = New System.Drawing.Size(25, 35)
        Me.cmdDownSingle.TabIndex = 2
        Me.cmdDownSingle.UseVisualStyleBackColor = True
        '
        'cmdUpSingle
        '
        Me.cmdUpSingle.BackgroundImage = Global.Minecraft_Serverbrowser_V2.My.Resources.Resources.arrow_single_up
        Me.cmdUpSingle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdUpSingle.Location = New System.Drawing.Point(1, 84)
        Me.cmdUpSingle.Margin = New System.Windows.Forms.Padding(1, 3, 3, 3)
        Me.cmdUpSingle.Name = "cmdUpSingle"
        Me.cmdUpSingle.Size = New System.Drawing.Size(25, 35)
        Me.cmdUpSingle.TabIndex = 2
        Me.cmdUpSingle.UseVisualStyleBackColor = True
        '
        'cmdUpDouble
        '
        Me.cmdUpDouble.BackgroundImage = Global.Minecraft_Serverbrowser_V2.My.Resources.Resources.arrow_double_up
        Me.cmdUpDouble.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdUpDouble.Location = New System.Drawing.Point(1, 44)
        Me.cmdUpDouble.Margin = New System.Windows.Forms.Padding(1, 3, 3, 3)
        Me.cmdUpDouble.Name = "cmdUpDouble"
        Me.cmdUpDouble.Size = New System.Drawing.Size(25, 35)
        Me.cmdUpDouble.TabIndex = 2
        Me.cmdUpDouble.UseVisualStyleBackColor = True
        '
        'lstServerlistFavourites
        '
        Me.lstServerlistFavourites.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstServerlistFavourites.FormattingEnabled = True
        Me.lstServerlistFavourites.Location = New System.Drawing.Point(32, 3)
        Me.lstServerlistFavourites.Name = "lstServerlistFavourites"
        Me.lstServerlistFavourites.Size = New System.Drawing.Size(139, 242)
        Me.lstServerlistFavourites.TabIndex = 0
        '
        'tabServerlistRedstonewire
        '
        Me.tabServerlistRedstonewire.Controls.Add(Me.tableServerlistRedstonewire)
        Me.tabServerlistRedstonewire.Location = New System.Drawing.Point(4, 25)
        Me.tabServerlistRedstonewire.Name = "tabServerlistRedstonewire"
        Me.tabServerlistRedstonewire.Padding = New System.Windows.Forms.Padding(3)
        Me.tabServerlistRedstonewire.Size = New System.Drawing.Size(184, 319)
        Me.tabServerlistRedstonewire.TabIndex = 0
        Me.tabServerlistRedstonewire.Text = "Redstonewire"
        Me.tabServerlistRedstonewire.UseVisualStyleBackColor = True
        '
        'tableServerlistRedstonewire
        '
        Me.tableServerlistRedstonewire.ColumnCount = 1
        Me.tableServerlistRedstonewire.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableServerlistRedstonewire.Controls.Add(Me.lstServerlistRedstonewire, 0, 2)
        Me.tableServerlistRedstonewire.Controls.Add(Me.cmdAddToFavourites, 0, 1)
        Me.tableServerlistRedstonewire.Controls.Add(Me.txtSearch, 0, 0)
        Me.tableServerlistRedstonewire.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableServerlistRedstonewire.Location = New System.Drawing.Point(3, 3)
        Me.tableServerlistRedstonewire.Margin = New System.Windows.Forms.Padding(1, 3, 3, 3)
        Me.tableServerlistRedstonewire.Name = "tableServerlistRedstonewire"
        Me.tableServerlistRedstonewire.RowCount = 3
        Me.tableServerlistRedstonewire.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tableServerlistRedstonewire.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.tableServerlistRedstonewire.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableServerlistRedstonewire.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tableServerlistRedstonewire.Size = New System.Drawing.Size(178, 313)
        Me.tableServerlistRedstonewire.TabIndex = 2
        '
        'cmdAddToFavourites
        '
        Me.cmdAddToFavourites.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdAddToFavourites.Location = New System.Drawing.Point(3, 27)
        Me.cmdAddToFavourites.Name = "cmdAddToFavourites"
        Me.cmdAddToFavourites.Size = New System.Drawing.Size(172, 20)
        Me.cmdAddToFavourites.TabIndex = 0
        Me.cmdAddToFavourites.Text = "Add to Favourites"
        Me.cmdAddToFavourites.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSearch.Location = New System.Drawing.Point(3, 3)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(172, 20)
        Me.txtSearch.TabIndex = 2
        Me.txtSearch.Text = "(search)"
        '
        'tabServerlist
        '
        Me.tabServerlist.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.tabServerlist.Controls.Add(Me.tabServerlistRedstonewire)
        Me.tabServerlist.Controls.Add(Me.tabServerlistFavourites)
        Me.tabServerlist.Controls.Add(Me.tabServerlistHistory)
        Me.tabServerlist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabServerlist.Location = New System.Drawing.Point(3, 11)
        Me.tabServerlist.Multiline = True
        Me.tabServerlist.Name = "tabServerlist"
        Me.tabServerlist.SelectedIndex = 0
        Me.tabServerlist.Size = New System.Drawing.Size(192, 348)
        Me.tabServerlist.TabIndex = 0
        '
        'tabServerlistHistory
        '
        Me.tabServerlistHistory.Controls.Add(Me.tableHistoryMain)
        Me.tabServerlistHistory.Location = New System.Drawing.Point(4, 25)
        Me.tabServerlistHistory.Name = "tabServerlistHistory"
        Me.tabServerlistHistory.Padding = New System.Windows.Forms.Padding(3)
        Me.tabServerlistHistory.Size = New System.Drawing.Size(184, 319)
        Me.tabServerlistHistory.TabIndex = 2
        Me.tabServerlistHistory.Text = "History"
        Me.tabServerlistHistory.UseVisualStyleBackColor = True
        '
        'tableHistoryMain
        '
        Me.tableHistoryMain.ColumnCount = 1
        Me.tableHistoryMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableHistoryMain.Controls.Add(Me.pnlHistoryButtons, 0, 0)
        Me.tableHistoryMain.Controls.Add(Me.lstServerlistHistory, 0, 1)
        Me.tableHistoryMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableHistoryMain.Location = New System.Drawing.Point(3, 3)
        Me.tableHistoryMain.Name = "tableHistoryMain"
        Me.tableHistoryMain.RowCount = 2
        Me.tableHistoryMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tableHistoryMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableHistoryMain.Size = New System.Drawing.Size(178, 313)
        Me.tableHistoryMain.TabIndex = 0
        '
        'pnlHistoryButtons
        '
        Me.pnlHistoryButtons.Controls.Add(Me.cmdClearHistory)
        Me.pnlHistoryButtons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlHistoryButtons.Location = New System.Drawing.Point(3, 3)
        Me.pnlHistoryButtons.Name = "pnlHistoryButtons"
        Me.pnlHistoryButtons.Size = New System.Drawing.Size(172, 29)
        Me.pnlHistoryButtons.TabIndex = 0
        '
        'cmdClearHistory
        '
        Me.cmdClearHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdClearHistory.Location = New System.Drawing.Point(0, 0)
        Me.cmdClearHistory.Name = "cmdClearHistory"
        Me.cmdClearHistory.Size = New System.Drawing.Size(172, 29)
        Me.cmdClearHistory.TabIndex = 1
        Me.cmdClearHistory.Text = "Clear history"
        Me.cmdClearHistory.UseVisualStyleBackColor = True
        '
        'lstServerlistHistory
        '
        Me.lstServerlistHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstServerlistHistory.FormattingEnabled = True
        Me.lstServerlistHistory.Location = New System.Drawing.Point(3, 38)
        Me.lstServerlistHistory.Name = "lstServerlistHistory"
        Me.lstServerlistHistory.Size = New System.Drawing.Size(172, 272)
        Me.lstServerlistHistory.TabIndex = 2
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.tabServerlist, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(198, 362)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'frmServerlist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(198, 362)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(214, 180)
        Me.Name = "frmServerlist"
        Me.Text = "Lists"
        Me.tabServerlistFavourites.ResumeLayout(False)
        Me.tableServerlistFavourites.ResumeLayout(False)
        Me.tableServerlistFavouritesButtons.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.pnlMoveFavourites.ResumeLayout(False)
        Me.tabServerlistRedstonewire.ResumeLayout(False)
        Me.tableServerlistRedstonewire.ResumeLayout(False)
        Me.tableServerlistRedstonewire.PerformLayout()
        Me.tabServerlist.ResumeLayout(False)
        Me.tabServerlistHistory.ResumeLayout(False)
        Me.tableHistoryMain.ResumeLayout(False)
        Me.pnlHistoryButtons.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstServerlistRedstonewire As System.Windows.Forms.ListBox
    Friend WithEvents tabServerlistFavourites As System.Windows.Forms.TabPage
    Friend WithEvents lstServerlistFavourites As System.Windows.Forms.ListBox
    Friend WithEvents tabServerlistRedstonewire As System.Windows.Forms.TabPage
    Friend WithEvents tabServerlist As System.Windows.Forms.TabControl
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmdAddToFavourites As System.Windows.Forms.Button
    Friend WithEvents tableServerlistRedstonewire As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tableServerlistFavourites As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tableServerlistFavouritesButtons As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmdAddNewFavourite As System.Windows.Forms.Button
    Friend WithEvents cmdDeleteFavourite As System.Windows.Forms.Button
    Friend WithEvents cmdEditFavourite As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlMoveFavourites As System.Windows.Forms.Panel
    Friend WithEvents cmdDownDouble As System.Windows.Forms.Button
    Friend WithEvents cmdDownSingle As System.Windows.Forms.Button
    Friend WithEvents cmdUpSingle As System.Windows.Forms.Button
    Friend WithEvents cmdUpDouble As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents tabServerlistHistory As System.Windows.Forms.TabPage
    Friend WithEvents tableHistoryMain As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlHistoryButtons As System.Windows.Forms.Panel
    Friend WithEvents cmdClearHistory As System.Windows.Forms.Button
    Friend WithEvents lstServerlistHistory As System.Windows.Forms.ListBox
End Class
