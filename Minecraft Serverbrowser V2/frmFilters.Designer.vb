<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFilters
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
        Me.cmdFilterModified = New System.Windows.Forms.Button()
        Me.cmdFilterPayToPlay = New System.Windows.Forms.Button()
        Me.cmdFilterWhitelist = New System.Windows.Forms.Button()
        Me.cmdFilterBuildingRights = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdFilterModified
        '
        Me.cmdFilterModified.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmdFilterModified.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdFilterModified.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdFilterModified.Location = New System.Drawing.Point(3, 95)
        Me.cmdFilterModified.Name = "cmdFilterModified"
        Me.cmdFilterModified.Size = New System.Drawing.Size(88, 87)
        Me.cmdFilterModified.TabIndex = 2
        Me.cmdFilterModified.Text = "Modified"
        Me.cmdFilterModified.UseVisualStyleBackColor = False
        '
        'cmdFilterPayToPlay
        '
        Me.cmdFilterPayToPlay.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmdFilterPayToPlay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdFilterPayToPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdFilterPayToPlay.Location = New System.Drawing.Point(97, 3)
        Me.cmdFilterPayToPlay.Name = "cmdFilterPayToPlay"
        Me.cmdFilterPayToPlay.Size = New System.Drawing.Size(88, 86)
        Me.cmdFilterPayToPlay.TabIndex = 1
        Me.cmdFilterPayToPlay.Text = "Pay to Play"
        Me.cmdFilterPayToPlay.UseVisualStyleBackColor = False
        '
        'cmdFilterWhitelist
        '
        Me.cmdFilterWhitelist.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmdFilterWhitelist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdFilterWhitelist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdFilterWhitelist.Location = New System.Drawing.Point(97, 95)
        Me.cmdFilterWhitelist.Name = "cmdFilterWhitelist"
        Me.cmdFilterWhitelist.Size = New System.Drawing.Size(88, 87)
        Me.cmdFilterWhitelist.TabIndex = 3
        Me.cmdFilterWhitelist.Text = "Whitelist"
        Me.cmdFilterWhitelist.UseVisualStyleBackColor = False
        '
        'cmdFilterBuildingRights
        '
        Me.cmdFilterBuildingRights.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmdFilterBuildingRights.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdFilterBuildingRights.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdFilterBuildingRights.Location = New System.Drawing.Point(3, 3)
        Me.cmdFilterBuildingRights.Name = "cmdFilterBuildingRights"
        Me.cmdFilterBuildingRights.Size = New System.Drawing.Size(88, 86)
        Me.cmdFilterBuildingRights.TabIndex = 0
        Me.cmdFilterBuildingRights.Text = "Building Rights"
        Me.cmdFilterBuildingRights.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.cmdFilterPayToPlay, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdFilterWhitelist, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdFilterBuildingRights, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdFilterModified, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(188, 185)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'frmFilters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(188, 185)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Enabled = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmFilters"
        Me.ShowIcon = False
        Me.Text = "Filters"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdFilterModified As System.Windows.Forms.Button
    Friend WithEvents cmdFilterPayToPlay As System.Windows.Forms.Button
    Friend WithEvents cmdFilterWhitelist As System.Windows.Forms.Button
    Friend WithEvents cmdFilterBuildingRights As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
End Class
