Imports MySql.Data.MySqlClient
Public Class SizeQuantityAddition
    Public Sub add_mul()

        If txtSinkQuantity.Text <> "" OrElse txtMedium.Text <> "" OrElse txtLarge.Text <> "" Then 'CODE TO DETERMINE PRICE WITH SINKERS + MEDIUM + LARGE

            txtSinkPrice.Text = Val(txtSinker.Text) * Val(txtSinkQuantity.Text)


            txtQuantityMedium.Text = Val(txtSizeMedium.Text)
            txtQuantityLarge.Text = Val(txtSizeLarge.Text)

            txtQuantityMedium.Text = Val(txtSizeMedium.Text) * Val(txtMedium.Text)
            txtQuantityLarge.Text = Val(txtSizeLarge.Text) * Val(txtLarge.Text)

            txtTotal.Text = Val(txtSinkPrice.Text) + Val(txtQuantityMedium.Text) + Val(txtQuantityLarge.Text)

        ElseIf txtSinkQuantity.Text <> "" And txtMedium.Text <> "" And txtLarge.Text <> "" Then 'CODE TO DETERMINE PRICE WITH SINKERS + MEDIUM + LARGE

            txtSinkPrice.Text = Val(txtSinker.Text) * Val(txtSinkQuantity.Text)
            txtTotal.Text = Val(txtSinkPrice.Text) + Val(txtQuantityMedium.Text) + Val(txtQuantityLarge.Text)

        ElseIf txtSinkQuantity.Text <> "" And txtMedium.Text <> "" Then 'CODE TO DETERMINE PRICE WITH SINKERS + MEDIUM
            txtSinkPrice.Text = Val(txtSinker.Text) * Val(txtSinkQuantity.Text)
            txtTotal.Text = Val(txtSinkPrice.Text) + Val(txtQuantityMedium.Text)

        ElseIf txtSinkQuantity.Text <> "" And txtLarge.Text <> "" Then 'CODE TO DETERMINE PRICE WITH SINKERS + LARGE
            txtSinkPrice.Text = Val(txtSinker.Text) * Val(txtSinkQuantity.Text)
            txtTotal.Text = Val(txtSinkPrice.Text) + Val(txtQuantityLarge.Text)

        ElseIf txtMedium.Text <> "" And txtLarge.Text <> "" Then 'CODE TO DETERMINE PRICE WITH MEDIUM + LARGE
            txtQuantityMedium.Text = Val(txtSizeMedium.Text)
            txtQuantityLarge.Text = Val(txtSizeLarge.Text)


            txtQuantityMedium.Text = Val(txtSizeMedium.Text) * Val(txtMedium.Text)
            txtQuantityLarge.Text = Val(txtSizeLarge.Text) * Val(txtLarge.Text)
            txtTotal.Text = Val(txtQuantityMedium.Text) + Val(txtQuantityLarge.Text)

        ElseIf txtMedium.Text <> "" Then 'CODE TO DETERMINE PRICE WITH MEDIUM 
            txtQuantityMedium.Text = Val(txtSizeMedium.Text) * Val(txtMedium.Text)
            txtTotal.Text = Val(txtQuantityMedium.Text) + Val(txtSinkPrice.Text)

        ElseIf txtLarge.Text <> "" Then 'CODE TO DETERMINE PRICE WITH LARGE
            txtQuantityLarge.Text = Val(txtSizeLarge.Text) * Val(txtLarge.Text)
            txtTotal.Text = Val(txtQuantityLarge.Text) + Val(txtSinkPrice.Text)



        ElseIf txtSinkQuantity.Text <> "" Then 'CODE TO DETERMINE PRICE WITH SINKERS
            txtSinkPrice.Text = Val(txtSinker.Text) * Val(txtSinkQuantity.Text)
            txtTotal.Text = Val(txtSinkPrice.Text)
        Else
            txtTotal.Text = Val(txtSizeMedium.Text) + Val(txtSizeLarge.Text) + Val(txtSinkPrice.Text)
        End If
    End Sub


    Public Sub Chk()
        Dim sql1 As String = ("Select * From tbl_classicmilktea where ID = @ID UNION ALL Select * From tbl_signaturemilktea where ID = @ID
                               UNION ALL Select * From tbl_yakultfusion where ID = @ID 
                               UNION ALL Select * From tbl_saltedcaramelcream where ID = @ID 
                               UNION ALL Select * From tbl_thaiseries where ID = @ID
                               UNION ALL Select * From tbl_fruitteas where ID = @ID 
                               UNION ALL Select * From tbl_saltedcheeseblend where ID = @ID
                               UNION ALL Select * From tbl_goldensugar where ID = @ID
                               UNION ALL Select * From tbl_whiterabbitcandy where ID = @ID")
        cmd = New MySqlCommand(sql1, cn)
        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = lblID.Text
        Dim adapter As New MySqlDataAdapter(cmd)
        'cn.Open()
        Dim table As New DataTable()
        adapter.Fill(table)

        If chkMedium.Checked = True And chkLarge.Checked = True Then
            txtMedium.Text = "1"
            txtLarge.Text = "1"
            txtSizeMedium.Text = table.Rows(0)(2).ToString()
            txtSizeLarge.Text = table.Rows(0)(4).ToString()


        ElseIf chkMedium.Checked = True Then
            txtMedium.Text = "1"
            txtSizeMedium.Text = table.Rows(0)(2).ToString()
            txtTotal.Text = txtSizeMedium.Text


        ElseIf chkLarge.Checked = True Then
            txtLarge.Text = "1"
            txtSizeLarge.Text = table.Rows(0)(4).ToString()
            txtTotal.Text = txtSizeLarge.Text


        Else
            txtSizeMedium.Text = ""
            txtMedium.Text = ""
            txtQuantityMedium.Text = ""
            '--------------------------'
            txtSizeLarge.Text = ""
            txtLarge.Text = ""
            txtQuantityLarge.Text = ""

            txtTotal.Text = ""
        End If
        add_mul()
        cn.Close()
    End Sub


    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Dim sql2 As String = ("Select * From tbl_classicmilktea where ID = @ID UNION ALL Select * From tbl_signaturemilktea where ID = @ID
                               UNION ALL Select * From tbl_yakultfusion where ID = @ID 
                               UNION ALL Select * From tbl_saltedcaramelcream where ID = @ID 
                               UNION ALL Select * From tbl_thaiseries where ID = @ID
                               UNION ALL Select * From tbl_fruitteas where ID = @ID 
                               UNION ALL Select * From tbl_saltedcheeseblend where ID = @ID
                               UNION ALL Select * From tbl_goldensugar where ID = @ID
                               UNION ALL Select * From tbl_whiterabbitcandy where ID = @ID")
        cmd = New MySqlCommand(sql2, cn)
        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = lblID.Text
        Dim adapter As New MySqlDataAdapter(cmd)
        cn.Open()
        Dim table As New DataTable()
        adapter.Fill(table)
        If chkMedium.Checked = False And chkLarge.Checked = False Then
            MsgBox("Please select Size!")
        ElseIf txtMedium.Text = "" And txtLarge.Text = "" Then
            MsgBox("Please input Quantity!")
        ElseIf chkMedium.Checked = True And txtMedium.Text = "" Then
            MsgBox("Please input Medium Quantity!")
        ElseIf chkLarge.Checked = True And txtLarge.Text = "" Then
            MsgBox("Please input Large Quantity!")

        Else
            Dim arr(6) As String
            Dim itm As ListViewItem
            arr(0) = POS.tblFlavorlist.SelectedItems(0).SubItems(0).Text
            arr(1) = POS.tblFlavorlist.SelectedItems(0).SubItems(1).Text
            arr(2) = txtMedium.Text
            arr(3) = txtLarge.Text
            arr(4) = txtTotal.Text
            arr(5) = txtSinkPrice.Text

            If chkMedium.Checked = True And chkLarge.Checked = True Then

                Mcap = table.Rows(0)(3) * Convert.ToInt32(txtMedium.Text)
                Lcap = table.Rows(0)(5) * Convert.ToInt32(txtLarge.Text)

                TotMProfit = Val(txtQuantityMedium.Text) - Mcap
                TotLProfit = Val(txtQuantityLarge.Text) - Lcap
                SinkName = cboSinkers.Text
                SinkerQ = txtSinkQuantity.Text
                'MsgBox(Mcap)
                'MsgBox(Lcap)
                'MsgBox(TotMProfit)
                'MsgBox(TotLProfit)
                'MsgBox(repeatcount)
                'MsgBox(repeatarray.Length)

                repeatarray(0 + repeatcount) = Mcap 'ARRAY TO STORE 2 OR MORE ORDER OF MILK TEA
                repeatarray(1 + repeatcount) = Lcap
                repeatarray(2 + repeatcount) = TotMProfit
                repeatarray(3 + repeatcount) = TotLProfit
                repeatarray(4 + repeatcount) = SinkName
                repeatarray(5 + repeatcount) = SinkerQ
                'MsgBox(SinkName)
                'MsgBox(SinkerQ)
                repeatcount = repeatcount + 6
                itemstoinsert = itemstoinsert + 1
                arraycounter = arraycounter + 6 'CODE FOR SIZE OF ARRAY (TO DO UNLI ADD)
                ReDim Preserve repeatarray(arraycounter)
                Mcap = 0
                Lcap = 0
                TotMProfit = 0
                TotLProfit = 0
                SinkName = ""
                SinkerQ = ""

                'MsgBox(repeatarray.Length)

            ElseIf chkMedium.Checked = True Then
                Mcap = table.Rows(0)(3) * Convert.ToInt32(txtMedium.Text)
                TotMProfit = Val(txtQuantityMedium.Text) - Mcap
                SinkName = cboSinkers.Text
                SinkerQ = txtSinkQuantity.Text
                'MsgBox(Mcap)
                'MsgBox(TotMProfit)
                'MsgBox(repeatcount)
                'MsgBox(repeatarray.Length)

                repeatarray(0 + repeatcount) = Mcap
                repeatarray(1 + repeatcount) = Lcap
                repeatarray(2 + repeatcount) = TotMProfit
                repeatarray(3 + repeatcount) = TotLProfit
                repeatarray(4 + repeatcount) = SinkName
                repeatarray(5 + repeatcount) = SinkerQ
                'MsgBox(SinkName)
                'MsgBox(SinkerQ)
                'MsgBox(repeatarray(5))
                repeatcount = repeatcount + 6
                itemstoinsert = itemstoinsert + 1
                arraycounter = arraycounter + 6
                ReDim Preserve repeatarray(arraycounter)
                'MsgBox(repeatarray.Length)
                Mcap = 0
                Lcap = 0
                TotMProfit = 0
                TotLProfit = 0
                SinkName = ""
                SinkerQ = ""

            ElseIf chkLarge.Checked = True Then
                Lcap = table.Rows(0)(5) * Convert.ToInt32(txtLarge.Text)
                TotLProfit = Val(txtQuantityLarge.Text) - Lcap
                SinkName = cboSinkers.Text
                SinkerQ = txtSinkQuantity.Text
                'MsgBox(Lcap)
                'MsgBox(TotLProfit)
                'MsgBox(repeatcount)
                'MsgBox(repeatarray.Length)

                repeatarray(0 + repeatcount) = Mcap
                repeatarray(1 + repeatcount) = Lcap
                repeatarray(2 + repeatcount) = TotMProfit
                repeatarray(3 + repeatcount) = TotLProfit
                repeatarray(4 + repeatcount) = SinkName
                repeatarray(5 + repeatcount) = SinkerQ
                'MsgBox(SinkName)
                'MsgBox(SinkerQ)
                repeatcount = repeatcount + 6
                itemstoinsert = itemstoinsert + 1
                arraycounter = arraycounter + 6
                ReDim Preserve repeatarray(arraycounter)
                'MsgBox(repeatarray.Length)
                Mcap = 0
                Lcap = 0
                TotMProfit = 0
                TotLProfit = 0
                SinkName = ""
                SinkerQ = ""

            End If

            itm = New ListViewItem(arr)
            POS.tblPayment.Items.Add(itm)

            totalPrice = totalPrice + Convert.ToDecimal(txtTotal.Text)
            POS.txtTotalPrice.Text = totalPrice

            txtSizeMedium.Text = ""
            txtMedium.Text = ""
            txtQuantityMedium.Text = ""
            '--------------------------'
            txtSizeLarge.Text = ""
            txtLarge.Text = ""
            txtQuantityLarge.Text = ""
            chkMedium.Checked = False
            chkLarge.Checked = False
            txtTotal.Text = ""

            Me.Close()
        End If
        cn.Close()
    End Sub

    Private Sub lblID_Click(sender As Object, e As EventArgs) Handles lblID.Click
        lblID.Text = Size_And_Quantity.lblID.Text
    End Sub

    Private Sub cboSinkers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSinkers.SelectedIndexChanged
        Dim sql1 As String = ("Select * From tbl_sinkers where SinkersItems = @SinkersItems")
        cmd = New MySqlCommand(sql1, cn)
        cmd.Parameters.Add("@SinkersItems", MySqlDbType.VarChar).Value = cboSinkers.Text
        Dim adapter As New MySqlDataAdapter(cmd)
        cn.Open()
        Dim table As New DataTable()
        Try
            adapter.Fill(table)
            If table.Rows.Count() > 0 Then
                'Return only 1 row
                txtSinkQuantity.Text = "1"
                txtSinker.Text = table.Rows(0)(2).ToString()
                txtTotal.Text = txtSinker.Text
            End If
        Catch Ex As Exception
            MessageBox.Show("NO Data Found")
        End Try
        cn.Close()
    End Sub

    Private Sub chkMedium_CheckedChanged(sender As Object, e As EventArgs) Handles chkMedium.CheckedChanged
        If chkMedium.Checked = False Then
            txtSizeMedium.Text = ""
            txtMedium.Text = ""
            txtQuantityMedium.Text = ""

        End If
        Chk()
    End Sub

    Private Sub chkLarge_CheckedChanged(sender As Object, e As EventArgs) Handles chkLarge.CheckedChanged
        If chkLarge.Checked = False Then
            txtSizeLarge.Text = ""
            txtLarge.Text = ""
            txtQuantityLarge.Text = ""

        End If
        Chk()
    End Sub

    Private Sub txtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged
        add_mul()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cboSinkers.Text = ""
        txtMedium.Text = ""
        txtLarge.Text = ""
        txtSinkQuantity.Text = ""
        txtSinker.Text = ""
        chkMedium.Checked = False
        chkLarge.Checked = False
    End Sub

    Private Sub txtSinkQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtSinkQuantity.TextChanged
        If txtSinkQuantity.Text = "" Then
            txtSinkPrice.Text = ""
            txtTotal.Text = ""
        Else
            add_mul()
        End If
    End Sub

    Private Sub txtMedium_TextChanged(sender As Object, e As EventArgs) Handles txtMedium.TextChanged
        If txtMedium.Text = "" Then
            txtMedium.Text = ""
            txtQuantityMedium.Clear()
            txtTotal.Text = ""
        Else
            add_mul()
        End If
    End Sub

    Private Sub txtLarge_TextChanged(sender As Object, e As EventArgs) Handles txtLarge.TextChanged
        If txtLarge.Text = "" Then
            txtLarge.Text = ""
            txtQuantityLarge.Clear()
            txtTotal.Text = ""
        Else
            add_mul()
        End If
    End Sub

    Private Sub txtSinker_TextChanged(sender As Object, e As EventArgs) Handles txtSinker.TextChanged

        add_mul()
    End Sub

    Private Sub txtSinkPrice_TextChanged(sender As Object, e As EventArgs) Handles txtSinkPrice.TextChanged
        add_mul()
    End Sub

    Private Sub btnClearSink_Click(sender As Object, e As EventArgs) Handles btnClearSink.Click
        cboSinkers.Text = "-----"
        txtSinkQuantity.Text = ""
        txtSinker.Text = ""
        txtTotal.Text = ""
    End Sub

    Private Sub SizeQuantityAddition_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class