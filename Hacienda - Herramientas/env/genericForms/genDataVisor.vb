﻿Public Class genDataVisor
    Public Sub LoadDtab(source As DataTable)
        CtrlMan.DataGridViewTools.Load(dgview, bs, "", source)
    End Sub
End Class