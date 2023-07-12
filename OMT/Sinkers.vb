Imports MySql.Data.MySqlClient
Public Class Sinkers
    Dim tblSink As String
    Dim mlkteatype As String
    Public Sub Sink()
        ds = New DataSet

        Dim sql1 As String = ("Select * From " + tblSink)
        cmd = New MySqlCommand(sql1, cn)


        Dim isi As ListViewItem
        tblSinkerslist.Items.Clear()
        cn.Open()

        Dim objreader = cmd.ExecuteReader
        While objreader.Read
            isi = tblSinkerslist.Items.Add(objreader.Item("ID").ToString)
            isi.SubItems.Add(objreader.Item("SinkersItems").ToString)
            isi.SubItems.Add(objreader.Item("SinkersPrice").ToString)

        End While
        cn.Close()
    End Sub
    Private Sub Sinkers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tblSink = "tbl_sinkers"
        Sink()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim sql As String = "INSERT INTO " + tblSink + "(ID,SinkersItems,SinkersPrice)
                                                VALUES(@ID,@SinkersItems,@SinkersPrice)"
        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@ID", txtSinkersNo.Text)
        cmd.Parameters.AddWithValue("@SinkersItems", txtSinkersItems.Text)
        cmd.Parameters.AddWithValue("@SinkersPrice", txtSinkersPrice.Text)
        'Open Connection and INSERT
        Try
            cn.Open()
            If txtSinkersNo.Text <> "" Then
                MsgBox("You must clear the text before adding")
            ElseIf cmd.ExecuteNonQuery() > 0 Then
                MsgBox("Product Successfully Added")
                txtSinkersItems.Text = ""

                txtSinkersPrice.Text = ""
            ElseIf txtSinkersItems.Text = "" And txtSinkersPrice.Text = "" Then
                MsgBox("No Input!")

            ElseIf txtSinkersItems.Text = "" Then
                MsgBox("Please enter Items!")

            End If
            cn.Close()
            'Retrieve()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try
        Sink()

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        cn.Open()
        Dim sql As String = "update " + tblSink + " set SinkersItems=@SinkersItems,
                                                        SinkersPrice=@SinkersPrice " & " where ID=@ID"
        cmd.ExecuteNonQuery()
        cn.Close()
        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@ID", txtSinkersNo.Text)
        cmd.Parameters.AddWithValue("@SinkersItems", txtSinkersItems.Text)

        cmd.Parameters.AddWithValue("@SinkersPrice", txtSinkersPrice.Text)
        'Open Connection and INSERT
        Try
            cn.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                MsgBox("Product Successfully Update")
                txtSinkersNo.Text = ""
                txtSinkersItems.Text = ""

                txtSinkersPrice.Text = ""

            ElseIf txtSinkersItems.Text = "" And txtSinkersPrice.Text = "" Then
                MsgBox("No Input!")

            ElseIf txtSinkersItems.Text = "" Then
                MsgBox("Please enter Items!")

            End If
            cn.Close()
            'Retrieve()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try
        Sink()
    End Sub

    Private Sub tblSinkerslist_Click(sender As Object, e As EventArgs) Handles tblSinkerslist.Click
        If tblSinkerslist.SelectedIndices.Count <= 0 Then
            MsgBox("No selected items", 64, "Invalid")
        Else
            txtSinkersNo.Text = tblSinkerslist.SelectedItems(0).SubItems(0).Text
            txtSinkersItems.Text = tblSinkerslist.SelectedItems(0).SubItems(1).Text

            txtSinkersPrice.Text = tblSinkerslist.SelectedItems(0).SubItems(2).Text

        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        cn.Open()
        Dim sql As String = "delete from " + tblSink + " where ID=@ID"
        cmd.ExecuteNonQuery()
        cn.Close()
        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@ID", txtSinkersNo.Text)

        Try
            cn.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                MsgBox("Product Successfully Delete")
                txtSinkersNo.Text = ""
                txtSinkersItems.Text = ""

                txtSinkersPrice.Text = ""
            End If
            cn.Close()
            'Retrieve()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try
        Sink()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtSinkersNo.Clear()
        txtSinkersItems.Text = ""

        txtSinkersPrice.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub TblSinkerslist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tblSinkerslist.SelectedIndexChanged

    End Sub
End Class