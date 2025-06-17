Imports System.ComponentModel
Namespace UserControls.TabPage
    Partial Class UC_PROPERTIES
        Friend Class FillPropertyGrid
            Private This_Compiled As Boolean

            ' Meeting Information
            Private This_Country As String = Nothing
            Private This_Type As String = Nothing
            '
            ' Race Information
            Private This_Length As String = Nothing
            Private This_Weather As String = Nothing
            Private This_Track As String = Nothing
            Private This_Venue As String = Nothing
            Private This_RunnersInRaceGreaterThanEqualTo As String = Nothing
            Private This_RunnersInRaceLessThanEqualTo As String = Nothing
            '
            ' List converters
            Private This_ExplorerID As String
            Private This_ParentExplorerID As Long
            Private This_TreePath As String
            Private This_Name As String
            '
            Private This_Backing As String
            Private This_VBCode As String
            Private This_Version As Decimal
            Private This_Status As Boolean
            '
            Friend MY_LIST_OF_COUNTRIES As New Collection
            Friend MY_LIST_OF_TYPES As New Collection
            Friend MY_LIST_OF_WEATHER As New Collection
            Friend MY_LIST_OF_TRACK As New Collection
            Friend MY_LIST_OF_VENUE As New Collection
            Friend MY_LIST_OF_BACKINGS As New Collection
            Friend MY_LIST_OF_LENGTH As New Collection
            Friend Sub New()
                MY_LIST_OF_TYPES.Add("")
                MY_LIST_OF_TYPES.Add("GR")
                MY_LIST_OF_TYPES.Add("G")
                MY_LIST_OF_TYPES.Add("H")

                Call Converters.TypeListTypeConverter.SetList(MY_LIST_OF_TYPES)
                Call Converters.BackingListTypeConverter.SetList(MY_LIST_OF_BACKINGS)

                Call Fill_COUNTRY_Property()
                Call Fill_WEATHER_Property("")
                Call Fill_TRACK_Property("")
            End Sub

#Region "               FILL PROPERTIES "
            Friend Sub Fill_LENGTHProperty(ByVal Type As String, ByVal Country As String, Optional ByVal Venue As String = Nothing)
                MY_LIST_OF_LENGTH.Clear()
                If Type Is Nothing OrElse Type = "" Then Return
                '
                Dim CMDTEXT As String = "SELECT DISTINCT RACE_INFO.LENGTH "
                CMDTEXT += "FROM MEETING_INFO INNER JOIN RACE_INFO ON MEETING_INFO.OADATE = RACE_INFO.MEETING_INFO_OADATE AND MEETING_INFO.NUMBER = RACE_INFO.MEETING_INFO_NUMBER "
                CMDTEXT += "WHERE (MEETING_INFO.TYPE = N'" & Type & "') AND (MEETING_INFO.COUNTRY=N'" & Country & "')"
                If (Not Venue Is Nothing) AndAlso Venue <> "" Then CMDTEXT += " AND (RACE_INFO.VENUE=N'" & Venue & "')"
                CMDTEXT += " ORDER BY RACE_INFO.LENGTH"
                '
                MY_LIST_OF_LENGTH.Add("")
                'For Each ROW As Data.DataRow In FORM_MODELDEVELOPMENT.Connection.GetDataTable(CMDTEXT).Select("")
                'MY_LIST_OF_LENGTH.Add(CInt(ROW.Item("LENGTH")))
                'Next ROW
ExitSub:
                Call Converters.LengthListTypeConverter.SetList(MY_LIST_OF_LENGTH)
            End Sub
            Friend Sub Fill_COUNTRY_Property()
                MY_LIST_OF_COUNTRIES.Clear()
                MY_LIST_OF_COUNTRIES.Add("")
                MY_LIST_OF_COUNTRIES.Add("NZL")
                '
                Call Converters.CountryListTypeConverter.SetList(MY_LIST_OF_COUNTRIES)
            End Sub
            Friend Sub Fill_WEATHER_Property(ByVal TYPE As String)
                MY_LIST_OF_WEATHER.Clear()
                If TYPE Is Nothing OrElse TYPE = "" Then Return
                '
                Dim CMDTEXT As String = "SELECT DISTINCT TOP (100) PERCENT WEATHER FROM RACE_INFO ORDER BY WEATHER ASC"
                MY_LIST_OF_WEATHER.Add("")
                '
                'For Each ROW As Data.DataRow In FORM_MODELDEVELOPMENT.Connection.GetDataTable(CMDTEXT).Select("")
                '    MY_LIST_OF_WEATHER.Add(CStr(ROW.Item("WEATHER")))
                'Next
ExitSub:
                Call Converters.WeatherListTypeConverter.SetList(MY_LIST_OF_WEATHER)
            End Sub
            Friend Sub Fill_TRACK_Property(ByVal TYPE As String)
                MY_LIST_OF_TRACK.Clear()
                If TYPE Is Nothing OrElse TYPE = "" Then Return
                '
                Dim CMDTEXT As String = "SELECT DISTINCT TOP (100) PERCENT TRACK FROM RACE_INFO ORDER BY TRACK ASC"
                MY_LIST_OF_TRACK.Add("")
                '
                'For Each ROW As Data.DataRow In FORM_MODELDEVELOPMENT.Connection.GetDataTable(CMDTEXT).Select("")
                '    MY_LIST_OF_TRACK.Add(CStr(ROW.Item("TRACK")))
                'Next
ExitSub:
                Call Converters.TrackListTypeConverter.SetList(MY_LIST_OF_TRACK)
            End Sub
            Friend Sub Fill_VENUEProperty(ByVal Type As String, Optional ByVal Country As String = Nothing)
                MY_LIST_OF_VENUE.Clear()
                If Type Is Nothing OrElse Type = "" Then Return
                '
                Dim CMDTEXT As String = "SELECT DISTINCT RACE_INFO.VENUE "
                CMDTEXT += "FROM MEETING_INFO INNER JOIN RACE_INFO ON MEETING_INFO.OADATE = RACE_INFO.MEETING_INFO_OADATE AND MEETING_INFO.NUMBER = RACE_INFO.MEETING_INFO_NUMBER "
                If Not Type Is Nothing OrElse Not Country Is Nothing Then
                    CMDTEXT += "WHERE"
                    CMDTEXT += " (MEETING_INFO.TYPE = N'" & Type & "') AND"
                    If Not Country Is Nothing AndAlso Country <> "" Then CMDTEXT += " (MEETING_INFO.COUNTRY = N'" & Country & "') AND"
                    If Strings.Right(CMDTEXT, 5) = "WHERE" Then CMDTEXT = Strings.Left(CMDTEXT, CMDTEXT.Length - 5)
                    If Strings.Right(CMDTEXT, 4) = " AND" Then CMDTEXT = Strings.Left(CMDTEXT, CMDTEXT.Length - 4)
                End If
                CMDTEXT += " ORDER BY RACE_INFO.VENUE ASC"
                '
                MY_LIST_OF_VENUE.Add("")
                'For Each ROW As Data.DataRow In FORM_MODELDEVELOPMENT.Connection.GetDataTable(CMDTEXT).Select("")
                'MY_LIST_OF_VENUE.Add(CStr(ROW.Item("VENUE")))
                'Next ROW
ExitSub:
                Call Converters.VenueListTypeConverter.SetList(MY_LIST_OF_VENUE)
            End Sub
#End Region
#Region "               PROPERTIES "
            <CategoryAttribute("Status Information"), DefaultValueAttribute(False), ReadOnlyAttribute(True), DescriptionAttribute("Indicates whether the model requires compiling.")>
            Public Property Compiled() As Boolean
                Get
                    Return This_Compiled
                End Get
                Set(value As Boolean)
                    Me.This_Compiled = value
                End Set
            End Property
            <CategoryAttribute("Status Information"), ReadOnlyAttribute(True), DescriptionAttribute("The ID of this model.")>
            Public Property Id() As String
                Get
                    Return This_ExplorerID
                End Get
                Set(ByVal Value As String)
                    This_ExplorerID = Value
                End Set
            End Property
            <CategoryAttribute("Status Information"), ReadOnlyAttribute(True), DescriptionAttribute("Indicates the Parent ID for the model.")>
            Public Property ParentID As Long
                Get
                    Return This_ParentExplorerID
                End Get
                Set(value As Long)
                    This_ParentExplorerID = value
                End Set
            End Property
            <CategoryAttribute("Status Information"), ReadOnlyAttribute(True), DescriptionAttribute("The current path of this model.")>
            Public Property TreePath() As String
                Get
                    Return This_TreePath
                End Get
                Set(ByVal Value As String)
                    This_TreePath = Value
                End Set
            End Property
            <CategoryAttribute("MODEL INFORMATION"), DefaultValueAttribute("New Model"), DescriptionAttribute("The name of this model.")>
            Public Shadows Property Name() As String
                Get
                    Return This_Name
                End Get
                Set(ByVal Value As String)
                    This_Name = Value
                End Set
            End Property
            <TypeConverter(GetType(Converters.TypeListTypeConverter)), CategoryAttribute("MODEL INFORMATION"), DescriptionAttribute("The TYPE of Meeting this model will react to.")>
            Public Property [Type] As String
                Get
                    Return This_Type
                End Get
                Set(value As String)
                    This_Type = value
                End Set
            End Property
            <TypeConverter(GetType(Converters.CountryListTypeConverter)), DefaultValueAttribute(""), RefreshProperties(RefreshProperties.All), CategoryAttribute("MODEL INFORMATION"), DescriptionAttribute("The Meeting COUNTRY this model will react to.")>
            Public Property Country As String
                Get
                    Return This_Country
                End Get
                Set(value As String)
                    This_Country = value
                End Set
            End Property
#Region "   Race Information "
            <TypeConverter(GetType(Converters.LengthListTypeConverter)), DefaultValueAttribute(""), RefreshProperties(RefreshProperties.All), CategoryAttribute("MODEL INFORMATION"), DescriptionAttribute("The LENGTH of Race this model will react to.")>
            Public Property LENGTH As String
                Get
                    Return This_Length
                End Get
                Set(value As String)
                    This_Length = value
                End Set
            End Property
            <TypeConverter(GetType(Converters.WeatherListTypeConverter)), DefaultValueAttribute(""), RefreshProperties(RefreshProperties.All), CategoryAttribute("MODEL INFORMATION"), DescriptionAttribute("The WEATHER of Race this model will react to.")>
            Public Property WEATHER As String
                Get
                    Return This_Weather
                End Get
                Set(value As String)
                    This_Weather = value
                End Set
            End Property
            <TypeConverter(GetType(Converters.TrackListTypeConverter)), DefaultValueAttribute(""), RefreshProperties(RefreshProperties.All), CategoryAttribute("MODEL INFORMATION"), DescriptionAttribute("The TRACK conditions of Race this model will react to.")>
            Public Property TRACK As String
                Get
                    Return This_Track
                End Get
                Set(value As String)
                    This_Track = value
                End Set
            End Property
            <TypeConverter(GetType(Converters.VenueListTypeConverter)), DefaultValueAttribute(""), RefreshProperties(RefreshProperties.All), CategoryAttribute("MODEL INFORMATION"), DescriptionAttribute("The VENUE of Race this model will react to.")>
            Public Property VENUE As String
                Get
                    Return This_Venue
                End Get
                Set(value As String)
                    This_Venue = value
                End Set
            End Property
            <CategoryAttribute("MODEL INFORMATION"), DefaultValueAttribute(8), DescriptionAttribute("The race must have 'Runners In Race' greater than or equal to the value supplied." & ControlChars.CrLf & "The default value is 8.  If the value is omitted or cleared, it is assumed the handling of 'Runners In Race' will be handled by the script code.")>
            Public Property RunnersInRaceGTE() As String
                Get
                    Return This_RunnersInRaceGreaterThanEqualTo
                End Get
                Set(ByVal Value As String)
                    This_RunnersInRaceGreaterThanEqualTo = Value
                End Set
            End Property
            <CategoryAttribute("MODEL INFORMATION"), DescriptionAttribute("The race must have 'Runners In Race' less than or equal to the value supplied." & ControlChars.NewLine & "The default value is NULL.  If a value is not given, it is assumed the handling of 'Runners In Race' will be handled by the script code or there is no limit on number of runners.")>
            Public Property RunnersInRaceLTE() As String
                Get
                    Return This_RunnersInRaceLessThanEqualTo
                End Get
                Set(ByVal Value As String)
                    This_RunnersInRaceLessThanEqualTo = Value
                End Set
            End Property
#End Region
            <TypeConverter(GetType(Converters.BackingListTypeConverter)), DefaultValueAttribute("PLC"), CategoryAttribute("MODEL INFORMATION"), DescriptionAttribute("The backing type of this model to display when passed.")>
            Public Property BACKING As String
                Get
                    Return This_Backing
                End Get
                Set(value As String)
                    This_Backing = value
                End Set
            End Property
            Friend Property VBCODE() As String
                Get
                    Return This_VBCode
                End Get
                Set(ByVal Value As String)
                    This_VBCode = Value
                End Set
            End Property
            <CategoryAttribute("MODEL INFORMATION"), ReadOnlyAttribute(True), DefaultValueAttribute(0D), DescriptionAttribute("The version of this model. (When was it last saved)")>
            Public Property Version() As Decimal
                Get
                    Return This_Version
                End Get
                Set(ByVal Value As Decimal)
                    This_Version = Value
                End Set
            End Property
            <CategoryAttribute("MODEL INFORMATION"), DefaultValueAttribute(False), DescriptionAttribute("Determines whether the model is active or not.")>
            Public Property Status() As Boolean
                Get
                    Return This_Status
                End Get
                Set(ByVal Value As Boolean)
                    This_Status = Value
                End Set
            End Property
#End Region
        End Class
    End Class
End Namespace