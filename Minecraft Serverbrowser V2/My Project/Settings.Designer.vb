﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Dieser Code wurde von einem Tool generiert.
'     Laufzeitversion:4.0.30319.1
'
'     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
'     der Code erneut generiert wird.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "Funktion zum automatischen Speichern von My.Settings"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(ByVal sender As Global.System.Object, ByVal e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property filterBuildingRights() As Integer
            Get
                Return CType(Me("filterBuildingRights"),Integer)
            End Get
            Set
                Me("filterBuildingRights") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property filterModified() As Integer
            Get
                Return CType(Me("filterModified"),Integer)
            End Get
            Set
                Me("filterModified") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property filterPayToPlay() As Integer
            Get
                Return CType(Me("filterPayToPlay"),Integer)
            End Get
            Set
                Me("filterPayToPlay") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property filterWhitelist() As Integer
            Get
                Return CType(Me("filterWhitelist"),Integer)
            End Get
            Set
                Me("filterWhitelist") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("303, 212")>  _
        Public Property childFiltersLocation() As Global.System.Drawing.Point
            Get
                Return CType(Me("childFiltersLocation"),Global.System.Drawing.Point)
            End Get
            Set
                Me("childFiltersLocation") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0, 0")>  _
        Public Property childDetailsLocation() As Global.System.Drawing.Point
            Get
                Return CType(Me("childDetailsLocation"),Global.System.Drawing.Point)
            End Get
            Set
                Me("childDetailsLocation") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("515, 0")>  _
        Public Property childServerlistLocation() As Global.System.Drawing.Point
            Get
                Return CType(Me("childServerlistLocation"),Global.System.Drawing.Point)
            End Get
            Set
                Me("childServerlistLocation") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("202, 424")>  _
        Public Property childServerlistSize() As Global.System.Drawing.Size
            Get
                Return CType(Me("childServerlistSize"),Global.System.Drawing.Size)
            End Get
            Set
                Me("childServerlistSize") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0, 0")>  _
        Public Property parentmdiMainLocation() As Global.System.Drawing.Point
            Get
                Return CType(Me("parentmdiMainLocation"),Global.System.Drawing.Point)
            End Get
            Set
                Me("parentmdiMainLocation") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("737, 512")>  _
        Public Property parentmdiMainSize() As Global.System.Drawing.Size
            Get
                Return CType(Me("parentmdiMainSize"),Global.System.Drawing.Size)
            End Get
            Set
                Me("parentmdiMainSize") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("303, 0")>  _
        Public Property childStartMinecraftLocation() As Global.System.Drawing.Point
            Get
                Return CType(Me("childStartMinecraftLocation"),Global.System.Drawing.Point)
            End Get
            Set
                Me("childStartMinecraftLocation") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("212, 212")>  _
        Public Property childStartMinecraftSize() As Global.System.Drawing.Size
            Get
                Return CType(Me("childStartMinecraftSize"),Global.System.Drawing.Size)
            End Get
            Set
                Me("childStartMinecraftSize") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("212, 212")>  _
        Public Property childFiltersSize() As Global.System.Drawing.Size
            Get
                Return CType(Me("childFiltersSize"),Global.System.Drawing.Size)
            End Get
            Set
                Me("childFiltersSize") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("303, 424")>  _
        Public Property childDetailsSize() As Global.System.Drawing.Size
            Get
                Return CType(Me("childDetailsSize"),Global.System.Drawing.Size)
            End Get
            Set
                Me("childDetailsSize") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property LockWindows() As Boolean
            Get
                Return CType(Me("LockWindows"),Boolean)
            End Get
            Set
                Me("LockWindows") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property childFiltersActive() As Boolean
            Get
                Return CType(Me("childFiltersActive"),Boolean)
            End Get
            Set
                Me("childFiltersActive") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property childDetailsActive() As Boolean
            Get
                Return CType(Me("childDetailsActive"),Boolean)
            End Get
            Set
                Me("childDetailsActive") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property childServerlistActive() As Boolean
            Get
                Return CType(Me("childServerlistActive"),Boolean)
            End Get
            Set
                Me("childServerlistActive") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property childStartMinecraftActive() As Boolean
            Get
                Return CType(Me("childStartMinecraftActive"),Boolean)
            End Get
            Set
                Me("childStartMinecraftActive") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property settingsOfflineMode() As Boolean
            Get
                Return CType(Me("settingsOfflineMode"),Boolean)
            End Get
            Set
                Me("settingsOfflineMode") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property settingsPathToMinecraftExe() As String
            Get
                Return CType(Me("settingsPathToMinecraftExe"),String)
            End Get
            Set
                Me("settingsPathToMinecraftExe") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property settingsLogInOnMCStart() As Boolean
            Get
                Return CType(Me("settingsLogInOnMCStart"),Boolean)
            End Get
            Set
                Me("settingsLogInOnMCStart") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property settingsUserName() As String
            Get
                Return CType(Me("settingsUserName"),String)
            End Get
            Set
                Me("settingsUserName") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property settingsUserPassword() As String
            Get
                Return CType(Me("settingsUserPassword"),String)
            End Get
            Set
                Me("settingsUserPassword") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property settingsLanguageFile() As String
            Get
                Return CType(Me("settingsLanguageFile"),String)
            End Get
            Set
                Me("settingsLanguageFile") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property globalDonatePromptDisplaied() As Boolean
            Get
                Return CType(Me("globalDonatePromptDisplaied"),Boolean)
            End Get
            Set
                Me("globalDonatePromptDisplaied") = value
            End Set
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.Minecraft_Serverbrowser_V2.My.MySettings
            Get
                Return Global.Minecraft_Serverbrowser_V2.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
