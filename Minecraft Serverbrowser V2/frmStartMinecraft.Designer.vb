<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStartMinecraft
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
        Me.cmdStartMinecraft = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdStartMinecraft
        '
        Me.cmdStartMinecraft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdStartMinecraft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdStartMinecraft.Location = New System.Drawing.Point(0, 0)
        Me.cmdStartMinecraft.Name = "cmdStartMinecraft"
        Me.cmdStartMinecraft.Size = New System.Drawing.Size(284, 264)
        Me.cmdStartMinecraft.TabIndex = 0
        Me.cmdStartMinecraft.UseVisualStyleBackColor = True
        '
        'frmStartMinecraft
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 264)
        Me.Controls.Add(Me.cmdStartMinecraft)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmStartMinecraft"
        Me.ShowIcon = False
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdStartMinecraft As System.Windows.Forms.Button
End Class
