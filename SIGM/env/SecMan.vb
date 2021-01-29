﻿Imports System.Net.NetworkInformation
Public Class SecMan 'Security Manager
    ' SEGURIDAD
    'Login functions
    Shared Function ValidateUser(user As String, pass As String) As Integer
        If Len(user) >= 5 And Len(pass) >= 5 Then
            Dim sql(5) As String
            sql(0) = "SELECT id, usuario, pass FROM usuarios WHERE usuario='" & user & "' AND pass ='" & pass & "'"
            Dim dtab As DataTable = DbMan.ReadDB(Nothing, My.Settings.CurrentDB, sql)

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
    Shared Function RegisterLogon(user_id As Integer, lock As Boolean) As Boolean
        Dim fecha_hora As String = Date.Today.ToShortDateString & " " & TimeOfDay.ToShortTimeString
        Dim token As String = getCpuId()
        Dim equipo As String = Environment.MachineName
        Dim sql(5) As String
        sql(0) = "SELECT id, fecha_hora, user_id, token, equipo, sesion 
                    FROM usr_log
                   WHERE user_id=" & user_id & " ORDER BY id DESC"
        'Últimos accesos
        Dim dtab As DataTable = DbMan.ReadDB(Nothing, My.Settings.CurrentDB, sql)


        If lock Then 'Iniciar sesion
            If dtab.Rows.Count > 0 Then
                If dtab(0)("token").ToString = token Then 'Sesion iniciada en este equipo
                    If dtab(0)("sesion") Then
                        'Sin cambios
                    ElseIf dtab(0)("sesion") = False Then 'Agregar registro a historial
                        DbMan.editDB(Nothing, My.Settings.CurrentDB, "INSERT INTO usr_log(user_id, fecha_hora, token, equipo, sesion)
										 VALUES(" & user_id & ", '" & fecha_hora & "' ,
												'" & token & "', '" & equipo & "', " & lock & ")")
                    End If
                ElseIf dtab(0)("token").ToString <> token Then  'Sesión iniciada en otro equipo
                    If MsgBoxResult.Yes = MsgBox("Sesion abierta en " & dtab(0)("equipo") & ". Presione SI para continuar, NO para salir",
                                                  MsgBoxStyle.YesNo, "Sesion iniciada en otro equipo") Then

                        'Iniciar sesion en este equipo, cerrar sesión de accesos anteriores
                        DbMan.editDB(Nothing, My.Settings.CurrentDB, "UPDATE usr_log Set sesion=False WHERE user_id=" & user_id)

                        DbMan.editDB(Nothing, My.Settings.CurrentDB, "INSERT INTO usr_log(user_id, fecha_hora, token, equipo, sesion)
											     VALUES(" & user_id & ", '" & fecha_hora & "' ,
														'" & token & "', '" & equipo & "', " & lock & ")")

                    Else 'No iniciar sesion en este equipo
                        Return False
                    End If
                End If

            ElseIf dtab.Rows.Count = 0 Then 'No hay registros de inicio de sesion
                DbMan.editDB(Nothing, My.Settings.CurrentDB, "INSERT INTO usr_log(user_id, fecha_hora, token, equipo, sesion)" &
                                  " VALUES(" & user_id & ", '" & fecha_hora & "' ," &
                                  " '" & token & "', '" & equipo & "', True)")
            End If
        Else 'Cerrar sesion correctamente
            DbMan.editDB(Nothing, My.Settings.CurrentDB, "UPDATE usr_log SET sesion=" & lock & " WHERE user_id=" & user_id)
        End If

        Return True
    End Function
    Shared Function Privileges(user_id As Integer) As launcher
        Dim inicio As New launcher
        Dim sql(0) As String
        sql(0) = "SELECT * FROM usuarios WHERE id=" & user_id
        'Leer
        Dim dtab As DataTable = DbMan.ReadDB(Nothing, My.Settings.CurrentDB, sql)
        'Cargar
        My.Settings.delete_enabled = dtab(0)("delete_permission")
        CtrlMan.LoadAllControls(dtab(0), inicio)
        Return inicio
    End Function

    'Read MAC or CPU to identify user/computer
    Shared Function GetMacAddress() As String
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
    Shared Function GetCpuId() As String
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
End Class