Imports System.Data.SqlClient

Public Enum QueryType
    QUERY_TEXT
    STORED_PROC
    STORED_FUNC
End Enum
Public Class MyUtilities
    Private Shared transaction As SqlTransaction
    Public pass As Boolean = False
    Public ifedit As Integer = 0
    Private connection As SqlConnection
    Private adapter As SqlDataAdapter
    Private table As DataTable

    Dim connString As String = "data source=LAPTOP-SF9JMU5V;" +
                              "initial catalog=SampleDB;" +
                              "user id=sa;" +
                              "pwd=AimShot123;"

    Public Function OpenConnection() As SqlConnection
        connection = New SqlConnection()

        Try
            connection.ConnectionString = connString
            connection.Open()
            Return connection
        Catch e As Exception
            Return Nothing
        End Try
    End Function
    Public Sub CloseConnection()
        If connection IsNot Nothing Then
            If connection.State = ConnectionState.Open Then connection.Close()
        End If
    End Sub
    Public Function SelectQuery(ByVal query As String) As DataTable
        Try
            adapter = New SqlDataAdapter(query, OpenConnection())
            table = New DataTable()
            adapter.Fill(table)
            adapter.Dispose()
            Return table
        Catch e As Exception
            Return Nothing
        End Try
    End Function

    Public Function RunSQLCommand(ByVal query As String, ByVal param As Dictionary(Of String, String)) As Integer
        Dim connection As SqlConnection = New SqlConnection(connString)

        Try
            Dim recordAffected As Integer

            Using cmd As SqlCommand = New SqlCommand()
                connection.Open()
                cmd.Connection = connection
                cmd.CommandText = query
                cmd.Parameters.AddRange(GetParams(param))
                recordAffected = cmd.ExecuteNonQuery()
            End Using

            Return recordAffected
        Catch ex As Exception
            Dim msg As String = ex.Message
            Return -1
        Finally

            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Function
    Private Function GetParams(ByVal param As Dictionary(Of String, String)) As Array
        Dim parameters = New List(Of SqlParameter)()

        For Each entry As KeyValuePair(Of String, String) In param
            parameters.Add(New SqlParameter(entry.Key, entry.Value))
        Next

        Return parameters.ToArray()
    End Function
    Public Function RunSqlTransaction(ByVal query As String, ByRef param As Dictionary(Of String, String), ByVal transactionName As String, ByRef conn As SqlConnection, ByRef transaction As SqlTransaction, ByVal queryType As QueryType) As Boolean
        Try

            Using command As SqlCommand = New SqlCommand()
                command.CommandText = query
                command.Connection = conn

                If queryType = QueryType.QUERY_TEXT Then
                    command.CommandType = CommandType.Text
                ElseIf queryType = QueryType.STORED_PROC Then
                    command.CommandType = CommandType.StoredProcedure
                End If

                command.Transaction = transaction
                command.Parameters.Clear()
                command.Parameters.AddRange(GetParams(param))
                command.ExecuteNonQuery()
            End Using

            Return True
        Catch ex As Exception
            Dim msg As String = ex.Message
            Return False
        End Try
    End Function

    Public Shared Sub CommitTransaction()
        Try
            transaction.Commit()
            transaction = Nothing
        Catch ex As Exception
            Dim msg As String = ex.Message
            transaction.Rollback()
        End Try
    End Sub
    Public Shared Sub RollbackTransaction()
        Try
            transaction.Rollback()
            transaction = Nothing
        Catch ex As Exception
            Dim msg As String = ex.Message
        End Try
    End Sub
End Class
