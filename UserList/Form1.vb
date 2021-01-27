Imports System.Text

Public Class frmUsers
    Dim db As MyUtilities = New MyUtilities()

    Private Sub frmUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateUsers()
    End Sub

    Public Sub PopulateUsers()
        lstUsers.Items.Clear()

        Try
            Dim strQuery As StringBuilder = New StringBuilder()
            strQuery.Append(" SELECT * FROM tblUsers ORDER BY LName ASC;")
            Dim dt As DataTable = db.SelectQuery(strQuery.ToString())

            If dt.Rows.Count <> 0 Then

                For Each row As DataRow In dt.Rows
                    Dim itm As ListViewItem = New ListViewItem(row("ID").ToString())
                    itm.SubItems.Add(row("LName").ToString())
                    itm.SubItems.Add(row("FName").ToString())
                    itm.SubItems.Add(row("MName").ToString())
                    itm.SubItems.Add(row("Address").ToString())
                    lstUsers.Items.Add(itm)
                Next
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If btnSave.Text = "Save" Then
            InsertUser()
        ElseIf btnSave.Text = "Update" Then
            UpdateUser()
        End If

    End Sub
    Public Sub InsertUser()
        Try

            If IsValidToSave() Then
                Dim strQuery As String = " INSERT INTO tblUsers(LName, FName, Address, MName)" & " VALUES(@LName, @FName, @Addr, @MName)"
                Dim param = New Dictionary(Of String, String) From {
                    {"@LName", txtLName.Text},
                    {"@FName", txtFName.Text},
                    {"@Addr", txtAddr.Text},
                    {"@MName", txtMName.Text}
                }
                Dim result As Integer = db.RunSQLCommand(strQuery.ToString(), param)

                If result > 0 Then
                    MessageBox.Show("Users successfully saved.")
                    txtLName.Text = String.Empty
                    txtFName.Text = String.Empty
                    txtAddr.Text = String.Empty
                    txtMName.Text = String.Empty
                    txtSearch.Text = String.Empty
                    btnSave.Text = "Save"
                    PopulateUsers()
                End If
            End If

        Catch ex As Exception
            Dim message As String = ex.Message
        End Try
    End Sub
    Public Sub UpdateUser()
        Try

            If IsValidToSave() Then
                Dim strQuery As String = " UPDATE tblUsers SET LName=@LName, FName=@FName, Address=@Addr, MName=@MName " & " WHERE ID=@ID"
                Dim param = New Dictionary(Of String, String) From {
                    {"@LName", txtLName.Text},
                    {"@FName", txtFName.Text},
                    {"@Addr", txtAddr.Text},
                    {"@MName", txtMName.Text},
                    {"@ID", lstUsers.SelectedItems(0).SubItems(0).Text}
                }
                Dim result As Integer = db.RunSQLCommand(strQuery.ToString(), param)

                If result > 0 Then
                    PopulateUsers()
                    txtLName.Text = String.Empty
                    txtFName.Text = String.Empty
                    txtAddr.Text = String.Empty
                    txtMName.Text = String.Empty
                    txtSearch.Text = String.Empty
                    btnSave.Text = "Save"
                    MessageBox.Show("Users successfully updated.")
                End If
            End If

        Catch ex As Exception
            Dim message As String = ex.Message
        End Try
    End Sub
    Public Function IsValidToSave() As Boolean
        Dim result As Boolean = True

        If txtLName.Text = String.Empty AndAlso txtAddr.Text = String.Empty AndAlso txtFName.Text = String.Empty Then
            MessageBox.Show("Please fill up the whole form.")
            result = False
        End If

        Return result
    End Function

    Private Sub lstUsers_Click(sender As Object, e As EventArgs) Handles lstUsers.Click
        If IsSelected(lstUsers) Then
            btnSave.Text = "Update"
            Dim item As ListViewItem = lstUsers.SelectedItems(0)
            txtLName.Text = lstUsers.SelectedItems(0).SubItems(1).Text
            txtFName.Text = lstUsers.SelectedItems(0).SubItems(2).Text
            txtMName.Text = lstUsers.SelectedItems(0).SubItems(3).Text
            txtAddr.Text = lstUsers.SelectedItems(0).SubItems(4).Text
        End If
    End Sub
    Public Function IsSelected(lstView As ListView) As Boolean
        Try
            Dim index As Integer = lstView.SelectedIndices(0)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        lstUsers.Items.Clear()

        Try

            If txtSearch.Text <> "" Then
                Dim strQuery As StringBuilder = New StringBuilder()
                strQuery.Append(" SELECT * FROM [dbo].[tblUsers] WHERE LName LIKE '%" & txtSearch.Text & "%' OR FName LIKE '%" & txtSearch.Text & "%' ")
                strQuery.Append(" OR Address LIKE '%" & txtSearch.Text & "%' ")
                Dim dt As DataTable = db.SelectQuery(strQuery.ToString())

                If dt.Rows.Count <> 0 Then

                    For Each row As DataRow In dt.Rows
                        Dim itm As ListViewItem = New ListViewItem(row("ID").ToString())
                        itm.SubItems.Add(row("LName").ToString())
                        itm.SubItems.Add(row("FName").ToString())
                        itm.SubItems.Add(row("MName").ToString())
                        itm.SubItems.Add(row("Address").ToString())
                        lstUsers.Items.Add(itm)
                    Next
                End If
            Else
                PopulateUsers()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub

    Private Sub lstUsers_DoubleClick(sender As Object, e As EventArgs) Handles lstUsers.DoubleClick
        If DialogResult.Yes = MessageBox.Show("Are you sure, you want to delete this user ?. ", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
            Dim strQuery As String = " DELETE FROM tblUsers WHERE ID=@ID"
            Dim result As Integer = db.RunSQLCommand(strQuery, New Dictionary(Of String, String) From {
                {"@ID", lstUsers.SelectedItems(0).SubItems(0).Text}
            })

            If result > 0 Then
                MessageBox.Show("User successfully deleted")
                PopulateUsers()
            End If
        End If
    End Sub
End Class
