<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServerFavourite
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.chkModified = New System.Windows.Forms.CheckBox()
        Me.cmdAccept = New System.Windows.Forms.Button()
        Me.chkRights = New System.Windows.Forms.CheckBox()
        Me.chkPay = New System.Windows.Forms.CheckBox()
        Me.chkWhitelist = New System.Windows.Forms.CheckBox()
        Me.lblIP = New System.Windows.Forms.Label()
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.lblWebsite = New System.Windows.Forms.Label()
        Me.txtWebsite = New System.Windows.Forms.TextBox()
        Me.lblThread = New System.Windows.Forms.Label()
        Me.txtThread = New System.Windows.Forms.TextBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(20, 20)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(75, 15)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(195, 20)
        Me.txtName.TabIndex = 0
        '
        'chkModified
        '
        Me.chkModified.AutoSize = True
        Me.chkModified.Enabled = False
        Me.chkModified.Location = New System.Drawing.Point(295, 15)
        Me.chkModified.Name = "chkModified"
        Me.chkModified.Size = New System.Drawing.Size(66, 17)
        Me.chkModified.TabIndex = 5
        Me.chkModified.Text = "Modified"
        Me.chkModified.UseVisualStyleBackColor = True
        '
        'cmdAccept
        '
        Me.cmdAccept.Location = New System.Drawing.Point(290, 135)
        Me.cmdAccept.Name = "cmdAccept"
        Me.cmdAccept.Size = New System.Drawing.Size(75, 40)
        Me.cmdAccept.TabIndex = 9
        Me.cmdAccept.Text = "Accept"
        Me.cmdAccept.UseVisualStyleBackColor = True
        '
        'chkRights
        '
        Me.chkRights.AutoSize = True
        Me.chkRights.Enabled = False
        Me.chkRights.Location = New System.Drawing.Point(295, 40)
        Me.chkRights.Name = "chkRights"
        Me.chkRights.Size = New System.Drawing.Size(56, 17)
        Me.chkRights.TabIndex = 6
        Me.chkRights.Text = "Rights"
        Me.chkRights.UseVisualStyleBackColor = True
        '
        'chkPay
        '
        Me.chkPay.AutoSize = True
        Me.chkPay.Enabled = False
        Me.chkPay.Location = New System.Drawing.Point(295, 65)
        Me.chkPay.Name = "chkPay"
        Me.chkPay.Size = New System.Drawing.Size(44, 17)
        Me.chkPay.TabIndex = 7
        Me.chkPay.Text = "Pay"
        Me.chkPay.UseVisualStyleBackColor = True
        '
        'chkWhitelist
        '
        Me.chkWhitelist.AutoSize = True
        Me.chkWhitelist.Enabled = False
        Me.chkWhitelist.Location = New System.Drawing.Point(295, 90)
        Me.chkWhitelist.Name = "chkWhitelist"
        Me.chkWhitelist.Size = New System.Drawing.Size(66, 17)
        Me.chkWhitelist.TabIndex = 8
        Me.chkWhitelist.Text = "Whitelist"
        Me.chkWhitelist.UseVisualStyleBackColor = True
        '
        'lblIP
        '
        Me.lblIP.AutoSize = True
        Me.lblIP.Location = New System.Drawing.Point(20, 45)
        Me.lblIP.Name = "lblIP"
        Me.lblIP.Size = New System.Drawing.Size(17, 13)
        Me.lblIP.TabIndex = 0
        Me.lblIP.Text = "IP"
        '
        'txtIP
        '
        Me.txtIP.Location = New System.Drawing.Point(75, 40)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(195, 20)
        Me.txtIP.TabIndex = 1
        '
        'lblWebsite
        '
        Me.lblWebsite.AutoSize = True
        Me.lblWebsite.Location = New System.Drawing.Point(20, 70)
        Me.lblWebsite.Name = "lblWebsite"
        Me.lblWebsite.Size = New System.Drawing.Size(46, 13)
        Me.lblWebsite.TabIndex = 0
        Me.lblWebsite.Text = "Website"
        '
        'txtWebsite
        '
        Me.txtWebsite.Location = New System.Drawing.Point(75, 65)
        Me.txtWebsite.Name = "txtWebsite"
        Me.txtWebsite.Size = New System.Drawing.Size(195, 20)
        Me.txtWebsite.TabIndex = 2
        '
        'lblThread
        '
        Me.lblThread.AutoSize = True
        Me.lblThread.Location = New System.Drawing.Point(20, 95)
        Me.lblThread.Name = "lblThread"
        Me.lblThread.Size = New System.Drawing.Size(41, 13)
        Me.lblThread.TabIndex = 0
        Me.lblThread.Text = "Thread"
        '
        'txtThread
        '
        Me.txtThread.Location = New System.Drawing.Point(75, 90)
        Me.txtThread.Name = "txtThread"
        Me.txtThread.Size = New System.Drawing.Size(195, 20)
        Me.txtThread.TabIndex = 3
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(20, 120)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(63, 13)
        Me.lblDescription.TabIndex = 0
        Me.lblDescription.Text = "Description:"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(20, 135)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescription.Size = New System.Drawing.Size(250, 145)
        Me.txtDescription.TabIndex = 4
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(290, 240)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 40)
        Me.cmdCancel.TabIndex = 10
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'frmServerFavourite
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 298)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdAccept)
        Me.Controls.Add(Me.chkWhitelist)
        Me.Controls.Add(Me.chkPay)
        Me.Controls.Add(Me.chkRights)
        Me.Controls.Add(Me.chkModified)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.txtThread)
        Me.Controls.Add(Me.lblThread)
        Me.Controls.Add(Me.txtWebsite)
        Me.Controls.Add(Me.lblWebsite)
        Me.Controls.Add(Me.txtIP)
        Me.Controls.Add(Me.lblIP)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmServerFavourite"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents chkModified As System.Windows.Forms.CheckBox
    Friend WithEvents cmdAccept As System.Windows.Forms.Button
    Friend WithEvents chkRights As System.Windows.Forms.CheckBox
    Friend WithEvents chkPay As System.Windows.Forms.CheckBox
    Friend WithEvents chkWhitelist As System.Windows.Forms.CheckBox
    Friend WithEvents lblIP As System.Windows.Forms.Label
    Friend WithEvents txtIP As System.Windows.Forms.TextBox
    Friend WithEvents lblWebsite As System.Windows.Forms.Label
    Friend WithEvents txtWebsite As System.Windows.Forms.TextBox
    Friend WithEvents lblThread As System.Windows.Forms.Label
    Friend WithEvents txtThread As System.Windows.Forms.TextBox
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
End Class
