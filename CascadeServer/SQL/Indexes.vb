Namespace SQL
    Friend Module Indexes
        Friend Function IndexFragmentationTable(Connection As CascadeCommon.Utils.Connection) As Data.DataTable
            Dim CommandText As String = "SELECT dbschemas.[name] as 'Schema', dbtables.[name] as 'Table', dbindexes.[name] as 'Index', indexstats.avg_fragmentation_in_percent, indexstats.page_count 
            FROM sys.dm_db_index_physical_stats (DB_ID(), NULL, NULL, NULL, NULL) AS indexstats INNER Join sys.tables dbtables on dbtables.[object_id] = indexstats.[object_id] INNER Join sys.schemas dbschemas on dbtables.[schema_id] = dbschemas.[schema_id] INNER Join sys.indexes AS dbindexes ON dbindexes.[object_id] = indexstats.[object_id] AND indexstats.index_id = dbindexes.index_id 
            WHERE indexstats.database_id = DB_ID() And dbtables.[name] Like '%%' 
            ORDER BY indexstats.avg_fragmentation_in_percent DESC"

            Return Connection.GetDataTable(CommandText)
        End Function
        Friend Sub RebuildIndexes(Connection As CascadeCommon.Utils.Connection, Messages As CascadeCommon.Messages)
            Dim LogThis As String = "Begin Rebuild Indexes for database."
            Messages.LogMessages(LogThis, Utils.General.BroadcastTypes.Log)

            Dim Stopwatch As New Stopwatch
            Stopwatch.Start()

            Dim CommandText As String = "DECLARE @TableName VARCHAR(255)
            DECLARE @sql NVARCHAR(500)
            DECLARE @fillfactor INT
            SET @fillfactor = 80 
            DECLARE TableCursor CURSOR FOR
            SELECT QUOTENAME(OBJECT_SCHEMA_NAME([object_id]))+'.' + QUOTENAME(name) AS TableName
            FROM sys.tables
            OPEN TableCursor
            FETCH NEXT FROM TableCursor INTO @TableName
            WHILE @@FETCH_STATUS = 0
            BEGIN
            SET @sql = 'ALTER INDEX ALL ON ' + @TableName + ' REBUILD WITH (FILLFACTOR = ' + CONVERT(VARCHAR(3),@fillfactor) + ')'
            EXEC (@sql)
            FETCH NEXT FROM TableCursor INTO @TableName
            END
            CLOSE TableCursor
            DEALLOCATE TableCursor"

            Call Connection.Execute(CommandText)
            Stopwatch.Stop()

            LogThis = "*****     Time taken to Rebuild Indexes: " & Utils.ElapsedTime(Stopwatch) & "     *****"
            Call Messages.LogMessages(LogThis, Utils.BroadcastTypes.Log)
        End Sub
    End Module
End Namespace