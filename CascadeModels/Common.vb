Friend Module Common
    Private This_Connection As CascadeCommon.Utils.Connection = Nothing
    Private This_Messages As CascadeCommon.Messages = Nothing
    Private This_IsTesting As Boolean = True
    Private This_MeetingOADate As String = Nothing
    Private This_StartOADate As String = Nothing
    Private This_FinishOADate As String = Nothing
    Private This_Total_Meetings As Integer
    Private This_Total_Races As Integer
    Private This_Total_Entries As Integer
    Friend Property Connection As CascadeCommon.Utils.Connection
        Get
            Return This_Connection
        End Get
        Set(value As CascadeCommon.Utils.Connection)
            This_Connection = value
        End Set
    End Property
    Friend Property Messages As CascadeCommon.Messages
        Get
            Return This_Messages
        End Get
        Set(value As CascadeCommon.Messages)
            This_Messages = value
        End Set
    End Property
    Friend Property IsTesting As Boolean
        Get
            Return This_IsTesting
        End Get
        Set(value As Boolean)
            This_IsTesting = value
        End Set
    End Property
    Friend Property MeetingOADate As String
        Get
            Return This_MeetingOADate
        End Get
        Set(value As String)
            This_MeetingOADate = value
        End Set
    End Property
    Friend Property StartOADate As String
        Get
            Return This_StartOADate
        End Get
        Set(value As String)
            This_StartOADate = value
        End Set
    End Property
    Friend Property FinishOADate As String
        Get
            Return This_FinishOADate
        End Get
        Set(value As String)
            This_FinishOADate = value
        End Set
    End Property
    Friend Property TotalMeetings As Integer
        Get
            Return This_Total_Meetings
        End Get
        Set(value As Integer)
            This_Total_Meetings = value
        End Set
    End Property
    Friend Property TotalRaces As Integer
        Get
            Return This_Total_Races
        End Get
        Set(value As Integer)
            This_Total_Races = value
        End Set
    End Property
    Friend Property TotalEntries As Integer
        Get
            Return This_Total_Entries
        End Get
        Set(value As Integer)
            This_Total_Entries = value
        End Set
    End Property
End Module
