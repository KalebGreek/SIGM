﻿Imports System.Net.NetworkInformation
Module SystemAccess
    'Funciones de inicio de sesion
    Public Function validar_inicio(user As String, pass As String) As Integer
        If Len(user) >= 5 And Len(pass) >= 5 Then
            Dim dtab As DataTable = bd.read(defcon,
                                            "SELECT id, usuario, pass FROM usuarios" &
                                            " WHERE usuario='" & user & "'" &
                                            " AND pass ='" & pass & "'")
            If dtab Is Nothing Then
                Return -1
            Else
                If dtab.Rows.Count > 0 Then 'Contraseña válida
                    Return dtab(0)("id")
                ElseIf dtab.Rows.Count = 0 Then
                    Return -1
                End If
            End If
        Else
            Return -1
        End If
    End Function
    Public Function registrar_user(user_id As Integer, lock As Boolean) As Boolean
        Dim fecha_hora As String = Date.Today.ToShortDateString & " " & TimeOfDay.ToShortTimeString
        Dim token As String = getCpuId()
        Dim equipo As String = Environment.MachineName
        'Últimos accesos
        Dim dtab As DataTable = bd.read(defcon, "SELECT id, fecha_hora, user_id, token, equipo, sesion FROM usr_log" &
                                " WHERE user_id=" & user_id & " ORDER BY id DESC")

        If dtab.Rows.Count > 0 Then
            If dtab(0)("sesion") Then
                If dtab(0)("token").ToString = token Then
                    If lock Then 'Actualizar a último accceso 
                        mod_sql = "UPDATE usr_log SET fecha_hora='" & fecha_hora & "', sesion=True" &
                                  " WHERE id=" & dtab(0)("id")
                    Else
                        mod_sql = "UPDATE usr_log SET sesion=False WHERE user_id=" & user_id
                    End If
                    bd.edit(defcon, mod_sql)
                ElseIf dtab(0)("token").ToString <> token Then
                    'Sesión iniciada en otro equipo
                    If MsgBoxResult.Yes = MsgBox("Sesion abierta en " & dtab(0)("equipo") & ". Presione SI para continuar, NO para salir") Then
                        'Sesión iniciada en este equipo, cerrar sesión de accesos anteriores
                        mod_sql = "UPDATE usr_log SET sesion=False WHERE user_id=" & user_id
                        bd.edit(defcon, mod_sql)
                    Else
                        Return False
                    End If
                End If
            ElseIf dtab(0)("sesion") = False Then 'Agregar registro a historial
                mod_sql = "INSERT INTO usr_log(user_id, fecha_hora, token, equipo, sesion)" &
                                   " VALUES(" & user_id & ", '" & fecha_hora & "' ," &
                                   " '" & token & "', '" & equipo & "', True)"
                bd.edit(defcon, mod_sql)
            End If
        ElseIf dtab.Rows.Count = 0 Then
            mod_sql = "INSERT INTO usr_log(user_id, fecha_hora, token, equipo, sesion)" &
                                  " VALUES(" & user_id & ", '" & fecha_hora & "' ," &
                                  " '" & token & "', '" & equipo & "', True)"
            bd.edit(defcon, mod_sql)
        End If
        Return True
    End Function
    Public Function permisos(user_id As Integer)
        Dim inicio As New launcher
        Dim dtab As DataTable = bd.read(defcon, "SELECT * FROM usuarios WHERE id=" & user_id)
        With inicio
            'Permisos
            .cat.Visible = dtab(0)("cat")
            .com.Visible = dtab(0)("com")
            .frm.Visible = dtab(0)("frm")
            .gob.Visible = dtab(0)("gob")
            .hac.Visible = dtab(0)("hac")
            .opcion.Visible = dtab(0)("opc")
            .opr.Visible = dtab(0)("opr")
            .opu.Visible = dtab(0)("opu")
            .per.Visible = dtab(0)("per")
            .user_id.Text = user_id
        End With
        Return inicio
    End Function

    'Leer MAC o CPU para identificar pc
    Function getMacAddress() As String
        Try
            Dim adapters As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces()
            Dim adapter As NetworkInterface
            Dim myMac As String = String.Empty

            For Each adapter In adapters
                Select Case adapter.NetworkInterfaceType
                    'Exclude Tunnels, Loopbacks and PPP
                    Case NetworkInterfaceType.Tunnel, NetworkInterfaceType.Loopback, NetworkInterfaceType.Ppp
                    Case Else
                        If Not adapter.GetPhysicalAddress.ToString = String.Empty And
                            Not adapter.GetPhysicalAddress.ToString = "00000000000000E0" And
                            adapter.OperationalStatus = OperationalStatus.Up Then 'MAC correcta y conectado
                            myMac = adapter.GetPhysicalAddress.ToString
                            Exit For ' Got a mac so exit for
                        End If

                End Select
            Next adapter

            Return myMac
        Catch ex As Exception
            Return String.Empty
        End Try
    End Function
    Function getCpuId() As String
        Dim computer As String = "."
        Dim wmi As Object = GetObject("winmgmts:" &
            "{impersonationLevel=impersonate}!\\" &
            computer & "\root\cimv2")
        Dim processors As Object = wmi.ExecQuery("Select * from " &
            "Win32_Processor")

        Dim cpu_ids As String = ""
        For Each cpu As Object In processors
            cpu_ids = cpu_ids & ", " & cpu.ProcessorId
        Next cpu
        If cpu_ids.Length > 0 Then cpu_ids =
            cpu_ids.Substring(2)

        Return cpu_ids
    End Function
End Module
