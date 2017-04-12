Attribute VB_Name = "NewMacros"
Sub GetBattaryState()
    Dim a As New WindowsManagement_Services.PowerManagementService
    c = a.GetBattaryState()
    MsgBox c
End Sub

Sub GetLastSleepTime()
    Dim a As New WindowsManagement_Services.PowerManagementService
    c = a.GetLastSleepTime()
    MsgBox c
End Sub

Sub GetLastWakeTime()
    Dim a As New WindowsManagement_Services.PowerManagementService
    c = a.GetLastWakeTime()
    MsgBox c
End Sub

Sub Sleep()
    Dim a As New WindowsManagement_Services.PowerManagementService
    c = a.Sleep()
End Sub

Sub Hybernate()
    Dim a As New WindowsManagement_Services.PowerManagementService
    c = a.Hybernate()
End Sub

Sub ReserveHibernationFile()
    Dim a As New WindowsManagement_Services.PowerManagementService
    c = a.ReserveHibernationFile()
End Sub

Sub DeleteHibernationFile()
    Dim a As New WindowsManagement_Services.PowerManagementService
    c = a.DeleteHibernationFile()
End Sub

Sub GetSystemIdless()
    Dim a As New WindowsManagement_Services.PowerManagementService
    c = a.GetSystemIdless()
    MsgBox c
End Sub
