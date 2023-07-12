Imports MySql.Data.MySqlClient
Public Class User_Account
    Sub search(field As String)
        If field = "" Then
            MsgBox("Please choose a field To search", 16, "Error")
            tblUser.Items.Clear()
        ElseIf field = "ID" Or field = "Username" Or field = "FirstName" Or field = "LastName" Or field = "Position" Then
            If txtSearch.Text = "" Then
                MsgBox("Please enter a value To search", 16, "Error")
                tblUser.Items.Clear()
            Else
                Dim sql As String = ("Select * From tbl_account where " & field & " Like '" & txtSearch.Text & "%'")
                cmd = New MySqlCommand(sql, cn)
            End If
        End If
        Dim isi As ListViewItem
        tblUser.Items.Clear()
        cn.Open()
        Try
            Dim objreader = cmd.ExecuteReader
            While objreader.Read
                isi = tblUser.Items.Add(objreader.Item("ID").ToString)
                isi.SubItems.Add(objreader.Item("Username").ToString)
                isi.SubItems.Add(objreader.Item("FirstName").ToString)
                isi.SubItems.Add(objreader.Item("Lastname").ToString)
                isi.SubItems.Add(objreader.Item("Position").ToString)
                isi.SubItems.Add(objreader.Item("Password").ToString)
            End While
        Catch Ex As Exception
            MessageBox.Show("NO Data Found")
        End Try
        cn.Close()

    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        search(cboField.Text)
    End Sub
    Public Sub Display_TableHere()
        Dim sql1 As String = ("Select * From tbl_account where ID")
        cmd = New MySqlCommand(sql1, cn)
        Dim isi As ListViewItem
        cn.Open()
        Try
            Dim objreader = cmd.ExecuteReader
            While objreader.Read
                isi = tblUser.Items.Add(objreader.Item("ID").ToString)
                isi.SubItems.Add(objreader.Item("Username").ToString)
                isi.SubItems.Add(objreader.Item("FirstName").ToString)
                isi.SubItems.Add(objreader.Item("Lastname").ToString)
                isi.SubItems.Add(objreader.Item("Position").ToString)
                isi.SubItems.Add(objreader.Item("Password").ToString)

            End While
        Catch Ex As Exception
            MessageBox.Show("NO Data Found")
        End Try
        cn.Close()
    End Sub
    Private Sub User_Account_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Display_TableHere()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Register.Show()
        Me.Hide()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        EditUser.Show()
        Me.Close()
    End Sub

    Private Sub tblUser_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tblUser.SelectedIndexChanged

    End Sub

    Private Sub tblUser_Click(sender As Object, e As EventArgs) Handles tblUser.Click
        If tblUser.SelectedIndices.Count <= 0 Then
            MsgBox("No selected items", 64, "Invalid")
        Else
            EditUser.txtID.Text = tblUser.SelectedItems(0).SubItems(0).Text
            EditUser.txtFirst.Text = tblUser.SelectedItems(0).SubItems(1).Text
            EditUser.txtLast.Text = tblUser.SelectedItems(0).SubItems(2).Text
            EditUser.txtUser.Text = tblUser.SelectedItems(0).SubItems(3).Text
            EditUser.cboPosition.Text = tblUser.SelectedItems(0).SubItems(4).Text
            EditUser.txtPass.Text = tblUser.SelectedItems(0).SubItems(5).Text

        End If
    End Sub
End Class