Imports MySql.Data.MySqlClient
Imports System.Data
Public Class StockManagement
    Dim QtyOpp As Integer
    Dim IDtouse As Integer
    Public Sub Display_TableHere()
        ds = New DataSet

        Dim sql1 As String = ("Select * From tbl_stocks")
        cmd = New MySqlCommand(sql1, cn)

        Dim isi As ListViewItem
        tblStocks.Items.Clear()
        cn.Open()

        Dim objreader = cmd.ExecuteReader
        While objreader.Read
            isi = tblStocks.Items.Add(objreader.Item("ID").ToString)
            isi.SubItems.Add(objreader.Item("Name").ToString)
            isi.SubItems.Add(objreader.Item("Quantity").ToString)
        End While
        cn.Close()
    End Sub

    Private Sub tblStocks_Click(sender As Object, e As EventArgs) Handles tblStocks.Click
        If tblStocks.SelectedIndices.Count <= 0 Then
            MsgBox("No selected items", 64, "Invalid")
        Else
            IDtouse = tblStocks.SelectedItems(0).SubItems(0).Text
            NameData.Text = tblStocks.SelectedItems(0).SubItems(1).Text
            QtyData.Text = tblStocks.SelectedItems(0).SubItems(2).Text
        End If
    End Sub


    Private Sub StockManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Display_TableHere()
    End Sub

    Private Sub AddItem_Click(sender As Object, e As EventArgs) Handles AddItem.Click
        If ItmName.Text = "" And ItmQty.Text = "" Then

            MsgBox("Please Enter Name and Quantity of the Item!")

        ElseIf ItmName.Text = "" Then

            MsgBox("PLease Enter Name of the Item!")

        ElseIf ItmQty.Text = "" Then

            MsgBox("Please Enter Quantity!")


        Else
            Dim sql As String = "INSERT INTO tbl_stocks (Name,Quantity)
                                                VALUES(@Name,@Quantity)"
            cmd = New MySqlCommand(sql, cn)
            'cmd.Parameters.AddWithValue("@ID", txtNo.Text)
            cmd.Parameters.AddWithValue("@Name", ItmName.Text)
            cmd.Parameters.AddWithValue("@Quantity", ItmQty.Text)

            Try
                cn.Open()
                If ItmName.Text = "" And ItmQty.Text = "" Then
                    MsgBox("Please Enter Name and Quantity of the Item!")

                ElseIf ItmName.Text = "" Then
                    MsgBox("Please Enter Name of the Item!")
                ElseIf ItmQty.Text = "" Then
                    MsgBox("Please Enter Quantity of the Item!")
                ElseIf cmd.ExecuteNonQuery() > 0 Then
                    MsgBox("Item/s Successfully Added")
                    ItmName.Text = ""
                    ItmQty.Text = ""
                End If
                cn.Close()
                'Retrieve()
            Catch ex As Exception
                MsgBox(ex.Message)
                MsgBox("hello")
                cn.Close()
            End Try

            Display_TableHere()
        End If


    End Sub

    Private Sub SrchItem_Click(sender As Object, e As EventArgs) Handles SrchItem.Click
        If NameSrch.Text = "" Then
            MsgBox("Please enter name of the Item!")
        Else
            ds = New DataSet

            Dim sql1 As String = ("Select * From tbl_stocks where Name = @Name")
            cmd = New MySqlCommand(sql1, cn)
            cmd.Parameters.AddWithValue("@Name", NameSrch.Text)

            Dim isi As ListViewItem
            tblStocks.Items.Clear()
            cn.Open()

            Dim objreader = cmd.ExecuteReader
            While objreader.Read
                isi = tblStocks.Items.Add(objreader.Item("ID").ToString)
                isi.SubItems.Add(objreader.Item("Name").ToString)
                isi.SubItems.Add(objreader.Item("Quantity").ToString)
            End While
            cn.Close()
        End If

    End Sub
    Public Sub QtyForOperation()

    End Sub
    Private Sub AddStock_Click(sender As Object, e As EventArgs) Handles AddStock.Click
        If NameData.Text = "" And QtyData.Text = "" Then

            MsgBox("No Item has been selected!")

        ElseIf QtyUse.Text = "" Then

            MsgBox("Please enter how many items will be added/taken!")

        Else
            QtyOpp = QtyUse.Text
            Dim sql1 As String = ("Select * From tbl_stocks where Id = @ID")
            cmd = New MySqlCommand(sql1, cn)
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = IDtouse
            Dim adapter As New MySqlDataAdapter(cmd)
            cn.Open()
            Dim table As New DataTable()
            adapter.Fill(table)
            'MsgBox(table.Rows(0)(2))
            QtyOpp = table.Rows(0)(2) + QtyOpp
            'MsgBox(QtyOpp)
            Dim sql2 As String = ("Update tbl_stocks set Quantity = @Qty")

            cmd.ExecuteNonQuery()
            cn.Close()
            cmd = New MySqlCommand(sql2, cn)
            cmd.Parameters.AddWithValue("@Qty", QtyOpp)
            Try
                cn.Open()
                If cmd.ExecuteNonQuery() > 0 Then
                    MsgBox("Item Successfully Updated")
                    NameData.Text = ""
                    QtyData.Text = ""
                    QtyUse.Text = ""
                Else
                    MsgBox("Error!")
                End If
                cn.Close()
                'Retrieve()
            Catch ex As Exception
                MsgBox(ex.Message)
                cn.Close()
            End Try
            Display_TableHere()
        End If


    End Sub

    Private Sub TakeStock_Click(sender As Object, e As EventArgs) Handles TakeStock.Click
        If NameData.Text = "" And QtyData.Text = "" Then

            MsgBox("No Item has been selected!")

        ElseIf QtyUse.Text = "" Then

            MsgBox("Please enter how many items will be added/taken!")

        Else
            QtyOpp = QtyUse.Text
            Dim sql1 As String = ("Select * From tbl_stocks where Id = @ID")
            cmd = New MySqlCommand(sql1, cn)
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = IDtouse
            Dim adapter As New MySqlDataAdapter(cmd)
            cn.Open()
            Dim table As New DataTable()
            adapter.Fill(table)
            'MsgBox(table.Rows(0)(2))
            QtyOpp = table.Rows(0)(2) - QtyOpp
            'MsgBox(QtyOpp)
            Dim sql2 As String = ("Update tbl_stocks set Quantity = @Qty")

            cmd.ExecuteNonQuery()
            cn.Close()
            cmd = New MySqlCommand(sql2, cn)
            cmd.Parameters.AddWithValue("@Qty", QtyOpp)
            Try
                cn.Open()
                If cmd.ExecuteNonQuery() > 0 Then
                    MsgBox("Item Successfully Updated")
                    NameData.Text = ""
                    QtyData.Text = ""
                    QtyUse.Text = ""
                Else
                    MsgBox("Error!")
                End If
                cn.Close()
                'Retrieve()
            Catch ex As Exception
                MsgBox(ex.Message)
                cn.Close()
            End Try
            Display_TableHere()
        End If
    End Sub

    Private Sub DelItem_Click(sender As Object, e As EventArgs) Handles DelItem.Click
        If tblStocks.SelectedIndices.Count <= 0 Then
            MsgBox("No selected items", 64, "Invalid")
        Else
            cn.Open()
            Dim sql As String = "delete from tbl_stocks where ID=@ID"
            cmd.ExecuteNonQuery()
            cn.Close()
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@ID", IDtouse)

            'Open Connection and INSERT
            Try
                cn.Open()
                If cmd.ExecuteNonQuery() > 0 Then
                    MsgBox("Product Successfully Delete")
                    NameData.Text = ""
                    QtyData.Text = ""

                End If
                cn.Close()
                'Retrieve()
            Catch ex As Exception
                MsgBox(ex.Message)
                cn.Close()
            End Try
            Display_TableHere()

        End If
    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Me.Close()
    End Sub

End Class