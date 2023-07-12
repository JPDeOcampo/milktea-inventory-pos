Imports MySql.Data.MySqlClient
Public Class POS
    'Dim totalPrice As Decimal
    Dim tbluser As String
    Dim mlkteatype As String
    Public Sub pos_user()
        ds = New DataSet

        Dim sql1 As String = ("Select * From " + tbluser)
        cmd = New MySqlCommand(sql1, cn)

        Dim isi As ListViewItem
        tblFlavorlist.Items.Clear()
        cn.Open()

        Dim objreader = cmd.ExecuteReader
        While objreader.Read
            isi = tblFlavorlist.Items.Add(objreader.Item("ID").ToString)
            isi.SubItems.Add(objreader.Item("FlavorItems").ToString)
            isi.SubItems.Add(objreader.Item("MediumPrice").ToString)
            isi.SubItems.Add(objreader.Item("LargePrice").ToString)

        End While
        cn.Close()
    End Sub


    Private Sub tblFlavorlistUser_Click(sender As Object, e As EventArgs) Handles tblFlavorlist.Click
        'Size_And_Quantity.Show() 'pangalan ng form kung saan ililipat
        'Size_And_Quantity.lblID.Text = tblFlavorlist.SelectedItems(0).SubItems(0).Text
        'Size_And_Quantity pangalan ng form, tas yung lbl.text kung saan mo ilalagay tas, yung tblflavorlistuser jan galing yung iliipat mo

        SizeQuantityAddition.Show() 'pangalan ng form kung saan ililipat
        SizeQuantityAddition.lblID.Text = tblFlavorlist.SelectedItems(0).SubItems(0).Text
    End Sub

    Private Sub btnClassic_Click(sender As Object, e As EventArgs) Handles btnClassic.Click
        tbluser = "tbl_classicmilktea"
        mlkteatype = "Classic Milk Tea"
        pos_user()
    End Sub

    Private Sub btnSignature_Click(sender As Object, e As EventArgs) Handles btnSignature.Click
        tbluser = "tbl_signaturemilktea"
        mlkteatype = "Signature Milk Tea"
        pos_user()
    End Sub

    Private Sub btnYakult_Click(sender As Object, e As EventArgs) Handles btnYakult.Click
        tbluser = "tbl_yakultfusion"
        mlkteatype = "Yakult Fusion"
        pos_user()
    End Sub

    Private Sub btnSaltedCaramel_Click(sender As Object, e As EventArgs) Handles btnSaltedCaramel.Click
        tbluser = "tbl_saltedcaramelcream"
        mlkteatype = "Salted Caramel Cream"
        pos_user()
    End Sub

    Private Sub btnThai_Click(sender As Object, e As EventArgs) Handles btnThai.Click
        tbluser = "tbl_thaiseries"
        mlkteatype = "Thai Series"
        pos_user()
    End Sub

    Private Sub btnFruit_Click(sender As Object, e As EventArgs) Handles btnFruit.Click
        tbluser = "tbl_fruitteas"
        mlkteatype = "Fruit Teas"
        pos_user()
    End Sub

    Private Sub btnSaltedCheese_Click(sender As Object, e As EventArgs) Handles btnSaltedCheese.Click
        tbluser = "tbl_saltedcheeseblend"
        mlkteatype = "Salted Cheese Blend"
        pos_user()
    End Sub

    Private Sub btnGolden_Click(sender As Object, e As EventArgs) Handles btnGolden.Click
        tbluser = "tbl_goldensugar"
        mlkteatype = "Golden Sugar"
        pos_user()
    End Sub


    Private Sub tblPayment_Click(sender As Object, e As EventArgs) Handles tblPayment.Click

        'If tblFlavorlist.SelectedIndices.Count <= 0 Then
        'MsgBox("No selected items", 64, "Invalid")
        'Else

        'Size_And_Quantity.Show()
        'End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If tblPayment.SelectedIndices.Count <= 0 Then
            MsgBox("No selected items", 64, "Invalid")
        Else
            totalPrice = totalPrice - Convert.ToDecimal(tblPayment.SelectedItems(0).SubItems(4).Text)
            txtTotalPrice.Text = totalPrice
            'If tblPayment.Items(i).Selected Then 'fail attempt
            '    MsgBox("deleted 1st item")
            'x = 0
            'ElseIf tblPayment.Items(1).Selected Then
            '    MsgBox("deleted 2nd item")
            '    'x = 6
            'ElseIf tblPayment.Items(2).Selected Then
            '    MsgBox("deleted 3rd item")
            '    'x = 12
            'ElseIf tblPayment.Items(3).Selected Then
            '    MsgBox("deleted 4th item")
            '    'x = 18
            'ElseIf tblPayment.Items(4).Selected Then
            '    MsgBox("deleted 5th item")
            '    'x = 24
            Dim delitem As Integer
            Dim delrotation As Integer = 0
            delitem = tblPayment.FocusedItem.Index
            delitem = delitem * 6
            While delrotation < 6
                delitem = tblPayment.FocusedItem.Index * 6
                For cycle As Integer = delitem To repeatarray.Length - 2
                    'MsgBox("Laki ng array mo: " + repeatarray.Length.ToString)
                    'Dim y As Integer = 0
                    'While y < repeatarray.Length
                    '    MsgBox(repeatarray(y))
                    '    y = y + 1
                    'End While
                    'MsgBox(repeatarray(delitem))
                    repeatarray(delitem) = repeatarray(delitem + 1)
                    'MsgBox(repeatarray(delitem))
                    'MsgBox("Ilang loop pa: " + delitem.ToString)
                    delitem = delitem + 1

                Next
                delrotation = delrotation + 1
            End While
            'MsgBox(tblPayment.FocusedItem.Index)

            tblPayment.SelectedItems(0).Remove()
            itemstoinsert = itemstoinsert - 1

            arraycounter = arraycounter - 6


        End If
    End Sub

    Private Sub ToolStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub BtnWhiteRabbitCandy_Click(sender As Object, e As EventArgs) Handles btnWhiteRabbitCandy.Click
        tbluser = "tbl_whiterabbitcandy"
        mlkteatype = "White Rabbit Candy"
        pos_user()
    End Sub

    Private Sub TblFlavorlist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tblFlavorlist.SelectedIndexChanged

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        Dim i As Integer = 0
        'Dim TotMProf As Integer
        'Dim TotLProf As Integer
        Reciept.rtfReciepet.AppendText("OMT Reciept" + vbTab + Date.Now.ToString("dd-MM-yyyy") + vbNewLine)
        While i < itemstoinsert
            Dim salesdate As New Date
            salesdate = Date.Now.ToString("dd-MM-yyyy")
            Dim sql As String = "INSERT INTO tbl_payment (ID,FlavorItems,FQuantityM,MCapital,FQuantityL,LCapital,Price,SinkerName,SinkerQ,TotalMProfit,TotalLProfit,AdditionalPrice,Date)
                                                VALUES(@ID,@FlavorItems,@FQuantityM,@MCapital,@FQuantityL,@LCapital,@Price,@SinkerName,@SinkerQ,@TotalMProfit,@TotalLProfit,@AdditionalPrice,@Date)"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@ID", tblPayment.Items(i).SubItems(0).Text)
            cmd.Parameters.AddWithValue("@FlavorItems", tblPayment.Items(i).SubItems(1).Text)
            cmd.Parameters.AddWithValue("@FQuantityM", tblPayment.Items(i).SubItems(2).Text)
            cmd.Parameters.AddWithValue("@MCapital", repeatarray(0 + repeatsubmit))
            cmd.Parameters.AddWithValue("@FQuantityL", tblPayment.Items(i).SubItems(3).Text)
            cmd.Parameters.AddWithValue("@LCapital", repeatarray(1 + repeatsubmit))
            cmd.Parameters.AddWithValue("@Price", tblPayment.Items(i).SubItems(4).Text)
            cmd.Parameters.AddWithValue("@SinkerName", repeatarray(4 + repeatsubmit))
            cmd.Parameters.AddWithValue("@SinkerQ", repeatarray(5 + repeatsubmit))
            cmd.Parameters.AddWithValue("@TotalMProfit", repeatarray(2 + repeatsubmit))
            cmd.Parameters.AddWithValue("@TotalLProfit", repeatarray(3 + repeatsubmit))
            cmd.Parameters.AddWithValue("@AdditionalPrice", tblPayment.Items(i).SubItems(5).Text)
            cmd.Parameters.AddWithValue("@Date", salesdate)
            Try
                cn.Open()
                If cmd.ExecuteNonQuery() > 0 Then
                    MsgBox("ADDED")
                Else
                    MsgBox("FAILED")
                End If
                cn.Close()
            Catch ex As Exception


                MsgBox(ex.Message)
                cn.Close()
            End Try
            Reciept.rtfReciepet.AppendText("-------------------------------------------------------------------------------------------" + vbNewLine)
            Reciept.rtfReciepet.AppendText("Flavor Items" + vbTab + vbTab + tblPayment.Items(i).SubItems(1).Text + vbNewLine)
            Reciept.rtfReciepet.AppendText("Flavor Quantity (Medium)" + vbTab + tblPayment.Items(i).SubItems(2).Text + vbNewLine)
            Reciept.rtfReciepet.AppendText("Flavor Quantity (Large)" + vbTab + tblPayment.Items(i).SubItems(3).Text + vbNewLine)
            Reciept.rtfReciepet.AppendText("Additional" + vbTab + vbTab + vbTab + tblPayment.Items(i).SubItems(5).Text + vbNewLine)
            Reciept.rtfReciepet.AppendText("Price" + vbTab + vbTab + vbTab + tblPayment.Items(i).SubItems(4).Text + vbNewLine)

            Reciept.Show()
            i = i + 1
            repeatsubmit = repeatsubmit + 6
        End While
        Reciept.rtfReciepet.AppendText("-------------------------------------------------------------------------------------------" + vbNewLine)
        Reciept.rtfReciepet.AppendText("TotalPrice" + vbTab + vbTab + txtTotalPrice.Text + vbNewLine)
        Reciept.rtfReciepet.AppendText("-------------------------------------------------------------------------------------------" + vbNewLine)
        Reciept.rtfReciepet.AppendText("Thank You!" + vbNewLine)

    End Sub

    Private Sub txtTotalPrice_TextChanged(sender As Object, e As EventArgs) Handles txtTotalPrice.TextChanged
        txtTotalPrice.Text = Format(CSng(txtTotalPrice.Text), "#,##0.00")
    End Sub

    Private Sub tblPayment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tblPayment.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) 
        TestReport.Show()
    End Sub

    Private Sub POS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class