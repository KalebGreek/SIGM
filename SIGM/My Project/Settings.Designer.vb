﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.6.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Public NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(sender As Global.System.Object, e As Global.System.EventArgs)
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
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Provider=PostgreSQL.1;Data Source=\\MALINGUNVILA;Location=sigmDB;User ID=admin;Pa"& _ 
            "ssword=hf32n64;")>  _
        Public ReadOnly Property DefaultPgsql_disabled() As String
            Get
                Return CType(Me("DefaultPgsql_disabled"),String)
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Provider=Microsoft.ACE.OLEDB.16.0;Data Source=vrosas.accdb;OLE DB Services=-1")>  _
        Public Property AdbConnection() As String
            Get
                Return CType(Me("AdbConnection"),String)
            End Get
            Set
                Me("AdbConnection") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Provider=PostgreSQL.1;Data Source=\\malingunvila;Location=vrosas;User ID=sigm_adm"& _ 
            "in;password=sigm2019.;")>  _
        Public Property pgsqlCon_disabled() As String
            Get
                Return CType(Me("pgsqlCon_disabled"),String)
            End Get
            Set
                Me("pgsqlCon_disabled") = value
            End Set
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Provider=vfpoledb.1;Data Source=Z:\DATOS;OLE DB Services=-1")>  _
        Public ReadOnly Property foxConnection() As String
            Get
                Return CType(Me("foxConnection"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Provider=PostgreSQL OLE DB Provider;Data Source=\\malingunvila;Location=vrosas;Us"& _ 
            "er ID=sigm;password=sigm2013;")>  _
        Public ReadOnly Property DefaultPgsql_disabled2() As String
            Get
                Return CType(Me("DefaultPgsql_disabled2"),String)
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property CurrentDB() As String
            Get
                Return CType(Me("CurrentDB"),String)
            End Get
            Set
                Me("CurrentDB") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("\HACIENDA\")>  _
        Public Property DocFolderHacienda() As String
            Get
                Return CType(Me("DocFolderHacienda"),String)
            End Get
            Set
                Me("DocFolderHacienda") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("\CATASTRO\")>  _
        Public Property DocFolderCatastro() As String
            Get
                Return CType(Me("DocFolderCatastro"),String)
            End Get
            Set
                Me("DocFolderCatastro") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("\COMERCIO\")>  _
        Public Property DocFolderComercio() As String
            Get
                Return CType(Me("DocFolderComercio"),String)
            End Get
            Set
                Me("DocFolderComercio") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("\OPRIVADAS\")>  _
        Public Property DocFolderOprivadas() As String
            Get
                Return CType(Me("DocFolderOprivadas"),String)
            End Get
            Set
                Me("DocFolderOprivadas") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("\GOBIERNO\")>  _
        Public Property DocFolderGobierno() As String
            Get
                Return CType(Me("DocFolderGobierno"),String)
            End Get
            Set
                Me("DocFolderGobierno") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("\ORDENANZAS\")>  _
        Public Property DocFolderOrdenanza() As String
            Get
                Return CType(Me("DocFolderOrdenanza"),String)
            End Get
            Set
                Me("DocFolderOrdenanza") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("\PERSONA\")>  _
        Public Property DocFolderPersona() As String
            Get
                Return CType(Me("DocFolderPersona"),String)
            End Get
            Set
                Me("DocFolderPersona") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property UserId() As Integer
            Get
                Return CType(Me("UserId"),Integer)
            End Get
            Set
                Me("UserId") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Color.DimGray")>  _
        Public Property CurrentMenuColor() As String
            Get
                Return CType(Me("CurrentMenuColor"),String)
            End Get
            Set
                Me("CurrentMenuColor") = value
            End Set
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Dsn=PostgreSQL35W;uid=sigm_admin;pwd=sigm2019.")>  _
        Public ReadOnly Property pgsqlODBC2_disabled() As String
            Get
                Return CType(Me("pgsqlODBC2_disabled"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Provider=VFPOLEDB.1;Data Source=z:\datos; OLE DB Services=-1")>  _
        Public ReadOnly Property VFP_OleDB_Munici() As String
            Get
                Return CType(Me("VFP_OleDB_Munici"),String)
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property delete_enabled() As Boolean
            Get
                Return CType(Me("delete_enabled"),Boolean)
            End Get
            Set
                Me("delete_enabled") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Color.MistyRose")>  _
        Public Property ErrorColorValue() As String
            Get
                Return CType(Me("ErrorColorValue"),String)
            End Get
            Set
                Me("ErrorColorValue") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("SystemColors.Window")>  _
        Public Property DefaultColorValue() As String
            Get
                Return CType(Me("DefaultColorValue"),String)
            End Get
            Set
                Me("DefaultColorValue") = value
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
        Friend ReadOnly Property Settings() As Global.Sigm.My.MySettings
            Get
                Return Global.Sigm.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
