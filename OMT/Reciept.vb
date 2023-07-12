Imports MySql.Data.MySqlClient
Public Class Reciept
    Dim QtyOpp As Integer
    Dim IDtouse As Integer
    Public Sub Display_TableHere()
        ds = New DataSet

        Dim sql1 As String = ("Select * From tbl_stocks")
        cmd = New MySqlCommand(sql1, cn)

        Dim isi As ListViewItem
        StockManagement.tblStocks.Items.Clear()
        cn.Open()

        Dim objreader = cmd.ExecuteReader
        While objreader.Read
            isi = StockManagement.tblStocks.Items.Add(objreader.Item("ID").ToString)
            isi.SubItems.Add(objreader.Item("Name").ToString)
            isi.SubItems.Add(objreader.Item("Quantity").ToString)
        End While
        cn.Close()
    End Sub
    Private Sub tbPrint_Click(sender As Object, e As EventArgs) Handles tbPrint.Click

        QtyOpp = POS.tblPayment.Items(0).SubItems(2).Text

        Dim sql1 As String = ("Select * From tbl_stocks where Id = @ID")
        cmd = New MySqlCommand(sql1, cn)
        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = POS.tblPayment.Items(0).SubItems(0).Text
        Dim adapter As New MySqlDataAdapter(cmd)
            cn.Open()
            Dim table As New DataTable()
        adapter.Fill(table)

        'MsgBox(table.Rows(0)(2))
        QtyOpp = table.Rows(0)(2) - QtyOpp
        'QtyOpp = StockManagement.tblStocks .Items(0).SubItems(2).Text - QtyOpp
        'MsgBox(QtyOpp)
        TextBox1.Text = table.Rows(0)(0).ToString()

        Dim sql2 As String = ("Update tbl_stocks set Quantity = @Qty")

        cmd.ExecuteNonQuery()
        cn.Close()
        cmd = New MySqlCommand(sql2, cn)
        cmd.Parameters.AddWithValue("@Qty", QtyOpp)

        Try
                cn.Open()
                If cmd.ExecuteNonQuery() > 0 Then
                    MsgBox("Item Successfully Updated")
                    StockManagement.NameData.Text = ""
                    StockManagement.QtyData.Text = ""
                    StockManagement.QtyUse.Text = ""
                Else
                    MsgBox("Error!")
                End If
                cn.Close()
                'Retrieve()
            Catch ex As Exception
                MsgBox(ex.Message)
            'cn.Close()
        End Try
        Display_TableHere()

        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font1 As New Font("Times New Roman", 20, FontStyle.Regular)
        e.Graphics.DrawString(rtfReciepet.Text, Font, Brushes.Black, 100, 200)
    End Sub
End Class