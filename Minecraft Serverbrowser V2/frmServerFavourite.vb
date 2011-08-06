Public Class frmServerFavourite

    Dim Hans As Server = Nothing

    Private Sub Apply_Language()

        Me.Text = frmmdiMain.LanguageFile.frmServerFavourites_Text

        lblDescription.Text = frmmdiMain.LanguageFile.frmServerFavourites_lblDescription
        lblIP.Text = frmmdiMain.LanguageFile.frmServerFavourites_lblIP
        lblName.Text = frmmdiMain.LanguageFile.frmServerFavourites_lblName
        lblThread.Text = frmmdiMain.LanguageFile.frmServerFavourites_lblThread
        lblWebsite.Text = frmmdiMain.LanguageFile.frmServerFavourites_lblWebsite

        cmdAccept.Text = frmmdiMain.LanguageFile.frmServerFavourites_cmdAccept
        cmdCancel.Text = frmmdiMain.LanguageFile.frmServerFavourites_cmdCancel

        chkModified.Text = frmmdiMain.LanguageFile.frmServerFavourites_chkModified
        chkPay.Text = frmmdiMain.LanguageFile.frmServerFavourites_chkPayToPlay
        chkRights.Text = frmmdiMain.LanguageFile.frmServerFavourites_chkBuildingRights
        chkWhitelist.Text = frmmdiMain.LanguageFile.frmServerFavourites_chkWhitelist

    End Sub

    Friend Sub New(Optional ByVal ServerToEdit As Server = Nothing)
        InitializeComponent()

        If ServerToEdit IsNot Nothing Then

            Hans = ServerToEdit

            txtName.Text = ServerToEdit.ServerName

            txtIP.Text = ServerToEdit.IP

            If ServerToEdit.Thread = True Then
                txtThread.Enabled = True
                txtThread.Text = ServerToEdit.ThreadURL
            Else
                'txtThread.Enabled = False
            End If

            If ServerToEdit.Website = True Then
                txtWebsite.Enabled = True
                txtWebsite.Text = ServerToEdit.WebsiteURL
            Else
                'txtWebsite.Enabled = False
            End If

            txtDescription.Text = ServerToEdit.Description

            'chkModified.Checked = ServerToEdit.Modified
            'chkPay.Checked = ServerToEdit.Pay
            'chkRights.Checked = ServerToEdit.Rights
            'chkWhitelist.Checked = ServerToEdit.Whitelist

        End If

    End Sub


    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click

        Me.Close()

    End Sub


    Private Sub cmdAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAccept.Click


        Dim hasWebsite As Boolean = False
        Dim hasThread As Boolean = False
        If txtWebsite.Text <> "" Then hasWebsite = True
        If txtThread.Text <> "" Then hasThread = True

        If hasWebsite = True And txtWebsite.Text.StartsWith("http://") = False Then
            txtWebsite.Text = "http://" & txtWebsite.Text
        End If

        If hasThread = True And txtThread.Text.StartsWith("http://") = False Then
            txtThread.Text = "http://" & txtThread.Text
        End If

        If Hans Is Nothing Then

            frmmdiMain.Serverlist_Favourites.Add_Server(New Server( _
                                                        Nothing, _
                                                                   Nothing, _
                                                                   Nothing, _
                                                                   Nothing, _
                                                                   hasThread, _
                                                                   Nothing, _
                                                                   hasWebsite, _
                                                                   txtIP.Text, _
                                                                   txtName.Text, _
                                                                   txtDescription.Text, _
                                                                   txtWebsite.Text, _
                                                                   txtThread.Text, _
                                                                   100 _
                                                                   ))

        Else

            frmmdiMain.Serverlist_Favourites.Change_Server(Hans, New Server( _
                                                        Nothing, _
                                                                   Nothing, _
                                                                   Nothing, _
                                                                   Nothing, _
                                                                   hasThread, _
                                                                   Nothing, _
                                                                   hasWebsite, _
                                                                   txtIP.Text, _
                                                                   txtName.Text, _
                                                                   txtDescription.Text, _
                                                                   txtWebsite.Text, _
                                                                   txtThread.Text, _
                                                                   100 _
                                                                   ))



        End If

        frmmdiMain.Serverlist_Favourites.Read_Database_FromXML()
        frmmdiMain.childServerlist.Get_Data_Favourites()

        Me.Close()

    End Sub


    Private Sub frmServerFavourite_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Apply_Language()

    End Sub


End Class