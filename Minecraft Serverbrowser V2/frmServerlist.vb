Public Class frmServerlist

    Private Sub Apply_Language()

        ' If the language file has been removed it will not apply the (missing) informations, since this would lead to blank buttons and stuff
        If frmmdiMain.LanguageFile.isLanguageFileAvailable = False Then Exit Sub

        Me.Text = frmmdiMain.LanguageFile.frmServerlist_Text

        cmdAddNewFavourite.Text = frmmdiMain.LanguageFile.frmServerlist_cmdAddNewFavourite
        cmdAddToFavourites.Text = frmmdiMain.LanguageFile.frmServerlist_cmdAddToFavourites
        cmdDeleteFavourite.Text = frmmdiMain.LanguageFile.frmServerlist_cmdDeleteFavourite
        cmdEditFavourite.Text = frmmdiMain.LanguageFile.frmServerlist_cmdEditFavourite
        cmdClearHistory.Text = frmmdiMain.LanguageFile.frmServerlist_cmdClearHistory

        txtSearch.Text = frmmdiMain.LanguageFile.frmServerlist_txtSearch

        tabServerlistFavourites.Text = frmmdiMain.LanguageFile.frmServerlist_tabServerlistFavourites
        tabServerlistRedstonewire.Text = frmmdiMain.LanguageFile.frmServerlist_tabServerlistRedstone
        tabServerlistHistory.Text = frmmdiMain.LanguageFile.frmServerlist_tabServerlistHistory

    End Sub

    Private Sub Get_Data()

        Get_Data_Redstone()
        Get_Data_Favourites()

    End Sub

    Private Sub Get_Data_Redstone()

        lstServerlistRedstonewire.Items.Clear()

        For Each Server In frmmdiMain.Serverlist_Redstone.ListOfServers

            lstServerlistRedstonewire.Items.Add(Server.ServerName)

        Next


        Select_Index_Redstone()

    End Sub

    Private Sub Select_Index_Redstone(Optional ByVal Index As Integer = 0)

        Dim oldIndex As Integer = lstServerlistRedstonewire.SelectedIndex


        ' Falls zuerst select_index_favourites und damit über lstfavourites.selectedindexchanged frmdetails.updatedata(serverlist_favourites)
        ' aufgerufen wird, und danach select_index_redstone aufgerufen wird, da der alte und der neue Index übereinstimmen,
        ' lstredstone.selectedindexchanged und damit frmdetails.updatedata(serverlist_redstone) NIE aufgerufen. Dadurch zeigt
        ' frmdetails immernoch den "falschen" server an. Siehe Situation AddServerToFavourites.
        ' Wäre eleganter mit RaisEvent, weiss allerdings zurzeit nicht wie das geht.
        If oldIndex = Index Then
            lstServerlistRedstonewire.SelectedIndex = -1
            lstServerlistRedstonewire.SelectedIndex = oldIndex
            Return
        End If

        If Index > lstServerlistRedstonewire.Items.Count - 1 Then
            If lstServerlistRedstonewire.Items.Count > 0 Then
                lstServerlistRedstonewire.SelectedIndex = 0
            Else

            End If
        Else
            lstServerlistRedstonewire.SelectedIndex = Index
        End If

    End Sub

    Friend Sub Get_Data_Favourites()

        lstServerlistFavourites.Items.Clear()

        For Each Server In frmmdiMain.Serverlist_Favourites.ListOfServers

            lstServerlistFavourites.Items.Add(Server.ServerName)

        Next

        Select_Index_Favourites()

    End Sub

    Private Sub Select_Index_Favourites(Optional ByVal Index As Integer = 0)

        If Index > lstServerlistFavourites.Items.Count - 1 Then
            If lstServerlistFavourites.Items.Count > 0 Then
                lstServerlistFavourites.SelectedIndex = 0
            Else

            End If
        Else
            lstServerlistFavourites.SelectedIndex = Index
        End If

    End Sub


    Private Sub cmdAddToFavourites_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddToFavourites.Click

        If lstServerlistRedstonewire.SelectedIndex = -1 Then
            Return
        End If

        frmmdiMain.Serverlist_Favourites.Add_Server(frmmdiMain.Serverlist_Redstone.ListOfServers(lstServerlistRedstonewire.SelectedIndex))

        Dim i As Integer = lstServerlistRedstonewire.SelectedIndex

        frmmdiMain.Serverlist_Favourites.Read_Database_FromXML()
        Get_Data_Favourites()
        Select_Index_Redstone(i)

    End Sub


    Private Sub cmdAddNewFavourite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddNewFavourite.Click

        Dim AddFavourite As New frmServerFavourite()
        AddFavourite.ShowDialog()

    End Sub

    Private Sub cmdEditFavourite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditFavourite.Click

        Dim AddFavourite As New frmServerFavourite(frmmdiMain.Serverlist_Favourites.ListOfServers(lstServerlistFavourites.SelectedIndex))
        AddFavourite.ShowDialog()

    End Sub

    Private Sub cmdDeleteFavourite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDeleteFavourite.Click

        frmmdiMain.Serverlist_Favourites.Delete_Server(frmmdiMain.Serverlist_Favourites.ListOfServers(lstServerlistFavourites.SelectedIndex))
        frmmdiMain.Serverlist_Favourites.Read_Database_FromXML()

        Get_Data_Favourites()
        Select_Index_Favourites()

    End Sub


    Private Sub cmdUpDouble_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpDouble.Click

        If lstServerlistFavourites.SelectedIndex <> 0 And lstServerlistFavourites.Items.Count > 1 Then

            frmmdiMain.Serverlist_Favourites.CrossChange_ID(frmmdiMain.Serverlist_Favourites.ListOfServers(lstServerlistFavourites.SelectedIndex).ID, _
                                                            frmmdiMain.Serverlist_Favourites.ListOfServers(0).ID)

            frmmdiMain.Serverlist_Favourites.Read_Database_FromXML()
            Get_Data_Favourites()

            Select_Index_Favourites(0)

        End If

    End Sub

    Private Sub cmdUpSingle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpSingle.Click

        Dim hans As Integer = lstServerlistFavourites.SelectedIndex

        If hans <> 0 And lstServerlistFavourites.Items.Count > 1 Then

            frmmdiMain.Serverlist_Favourites.CrossChange_ID(frmmdiMain.Serverlist_Favourites.ListOfServers(hans).ID, _
                                                            frmmdiMain.Serverlist_Favourites.ListOfServers(hans - 1).ID)

            frmmdiMain.Serverlist_Favourites.Read_Database_FromXML()
            Get_Data_Favourites()

            Select_Index_Favourites(hans - 1)

        End If

    End Sub

    Private Sub cmdDownSingle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDownSingle.Click

        Dim hans As Integer = lstServerlistFavourites.SelectedIndex

        If hans <> 0 And lstServerlistFavourites.Items.Count > 1 Then

            frmmdiMain.Serverlist_Favourites.CrossChange_ID(frmmdiMain.Serverlist_Favourites.ListOfServers(hans).ID, _
                                                            frmmdiMain.Serverlist_Favourites.ListOfServers(hans + 1).ID)

            frmmdiMain.Serverlist_Favourites.Read_Database_FromXML()
            Get_Data_Favourites()

            Select_Index_Favourites(hans + 1)

        End If

    End Sub

    Private Sub cmdDownDouble_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDownDouble.Click

        If lstServerlistFavourites.SelectedIndex <> lstServerlistFavourites.Items.Count - 1 And lstServerlistFavourites.Items.Count > 1 Then

            frmmdiMain.Serverlist_Favourites.CrossChange_ID(frmmdiMain.Serverlist_Favourites.ListOfServers(lstServerlistFavourites.SelectedIndex).ID, _
                                                            frmmdiMain.Serverlist_Favourites.ListOfServers(lstServerlistFavourites.Items.Count - 1).ID)

            frmmdiMain.Serverlist_Favourites.Read_Database_FromXML()
            Get_Data_Favourites()

            Select_Index_Favourites(lstServerlistFavourites.Items.Count - 1)

        End If

    End Sub


    Private Sub tabServerlist_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabServerlist.SelectedIndexChanged

        ' Calls the Update-sub of frmDetails, with the appropriate information.
        If tabServerlist.SelectedTab.Text = frmmdiMain.LanguageFile.frmServerlist_tabServerlistRedstone Then
            cmdAddToFavourites.Enabled = True
            frmmdiMain.childDetails.Update_Data(frmmdiMain.Serverlist_Redstone, lstServerlistRedstonewire.SelectedIndex)
        ElseIf tabServerlist.SelectedTab.Text = frmmdiMain.LanguageFile.frmServerlist_tabServerlistFavourites Then
            cmdAddToFavourites.Enabled = False
            frmmdiMain.childDetails.Update_Data(frmmdiMain.Serverlist_Favourites, lstServerlistFavourites.SelectedIndex)
        ElseIf tabServerlist.SelectedTab.Text = frmmdiMain.LanguageFile.frmServerlist_tabServerlistHistory Then
            ' Need to add code here as soon as history is coded.
        Else
            MsgBox("Actually you should never ever see this error. If you do see it please report it to me." & vbCrLf & _
                   "Invalid tabname passed to frmServerlist.tabServerlist_SelectedIndexChanged: " & tabServerlist.SelectedTab.Text)
        End If

        frmmdiMain.Show_Servercount()

    End Sub

    Private Sub lstServerlistRedstonewire_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstServerlistRedstonewire.SelectedIndexChanged

        frmmdiMain.SelectedIndexRedstone = lstServerlistRedstonewire.SelectedIndex
        frmmdiMain.childDetails.Update_Data(frmmdiMain.Serverlist_Redstone, lstServerlistRedstonewire.SelectedIndex)

    End Sub

    Private Sub lstServerlistFavourites_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstServerlistFavourites.SelectedIndexChanged

        frmmdiMain.childDetails.Update_Data(frmmdiMain.Serverlist_Favourites, lstServerlistFavourites.SelectedIndex)

    End Sub


    Private Sub frmServerlist_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Get_Data()

        frmmdiMain.childDetails.Update_Data(frmmdiMain.Serverlist_Redstone, lstServerlistRedstonewire.SelectedIndex)

        Apply_Language()

    End Sub

    Private Sub frmServerlist_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        frmmdiMain.mnuiWindowsServerlistFavourites.Checked = False
        My.Settings.childServerlistLocation = Me.Location
        My.Settings.childServerlistSize = Me.Size

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



    Friend Sub Apply_Search()

        frmmdiMain.Serverlist_Redstone.Sync_Lists()

        Dim i As Integer = 0
        'Dim count As Integer
        'Dim countinit As Integer = frmmdiMain.Serverlist_Redstone.ListOfServers.Count - 1
        'Dim ip As String
        'Dim server As Server

        Do While i < frmmdiMain.Serverlist_Redstone.ListOfServers.Count
            'ip = frmmdiMain.Serverlist_Redstone.ListOfServers(i).IP
            'server = frmmdiMain.Serverlist_Redstone.ListOfServers(i)
            ' Wichtig: Bedingungen müssen mit "and" verküft sein, da ansonsten der Server rausgeschmissen wird, falls EINE der beiden
            ' Bedingungen nicht erfüllt ist!
            If frmmdiMain.Serverlist_Redstone.ListOfServers(i).ServerName.ToLower.Contains(txtSearch.Text.ToLower) = False _
                And frmmdiMain.Serverlist_Redstone.ListOfServers(i).IP.Contains(txtSearch.Text.ToLower) = False Then
                frmmdiMain.Serverlist_Redstone.ListOfServers.RemoveAt(i)
            Else
                i += 1
            End If

            'count = frmmdiMain.Serverlist_Redstone.ListOfServers.Count

        Loop


        Get_Data_Redstone()

    End Sub


    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown

        If e.KeyCode = Keys.Enter Then
            If txtSearch.Text = "" Then
                frmmdiMain.Serverlist_Redstone.Sync_Lists()
                Get_Data()
            Else
                Apply_Search()
            End If
        End If

    End Sub


End Class