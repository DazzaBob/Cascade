<Flags> _
Friend Enum NodeTypes As Integer
    Folder = 1
    Model = 2
    Clone = 3
    BaseFolder = 4
    None = 0
End Enum
<Flags> _
Friend Enum BroadcastTypes As Integer
    None = 0
    Log = 1
    [Error] = 2
End Enum
<Flags> _
Friend Enum Requests As Integer
    None = 0
    Connect = 1
    Disconnect = 2
    DataTransfer = 3
    StringTransfer = 4
    ByteTransfer = 5
    GetStatus = 6
    Connected = 7
    DownloadYesterdaysResultsForce = 8
    ServerUI = 9
    ReportingUI = 10
    RerunModelsAll = 11
    DownloadYesterdaysResults = 12
    RebuildIndexes = 13
    DownloadDay = 14
    DownloadSchedule = 15
    RerunModels = 16
    DownloadResults = 17
    CheckModelResults = 18
    DownloadXml = 19
    DownloadScheduleForceReload = 21
End Enum
