Imports MySql.Data.MySqlClient

Public Class AdditionalFlavor




    Public Sub Calculate()
        If txtSinkQuantity.Text <> "" Then
            txtAdditional.Text = Val(txtSinker.Text) * Val(txtSinkQuantity.Text) + Val(txtSyrup.Text) + Val(txtPowder.Text) + Val(txtMilk.Text)
        ElseIf txtSweetQuantity.Text <> "" Then
            txtAdditional.Text = Val(txtSyrup.Text) * Val(txtSweetQuantity.Text) + Val(txtSinker.Text) + Val(txtPowder.Text) + Val(txtMilk.Text)
        ElseIf txtPowderQuantity.Text <> "" Then
            txtAdditional.Text = Val(txtPowder.Text) * Val(txtPowderQuantity.Text) + Val(txtSinker.Text) + Val(txtSyrup.Text) + Val(txtMilk.Text)
        ElseIf txtMilkQuantity.Text <> "" Then
            txtAdditional.Text = Val(txtMilk.Text) * Val(txtMilkQuantity.Text) + Val(txtSinker.Text) + Val(txtSyrup.Text) + Val(txtPowder.Text)
        ElseIf txtSinkQuantity.Text <> "" And txtSweetQuantity.Text <> "" And txtPowderQuantity.Text <> "" And txtMilkQuantity.Text <> "" Then
            txtAdditional.Text = Val(txtSinker.Text) + Val(txtSyrup.Text) + Val(txtPowder.Text) + Val(txtMilk.Text)
        Else
            txtAdditional.Text = Val(txtSinker.Text) + Val(txtSyrup.Text) + Val(txtPowder.Text) + Val(txtMilk.Text)
        End If
    End Sub

    Private Sub Additional_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click

        Dim arr(6) As String
            Dim itm As ListViewItem

            arr(0) = POS.tblFlavorlist.SelectedItems(0).SubItems(0).Text
            arr(1) = POS.tblFlavorlist.SelectedItems(0).SubItems(1).Text
            arr(2) = Size_And_Quantity.txtMedium.Text
            arr(3) = Size_And_Quantity.txtLarge.Text
            arr(4) = Size_And_Quantity.txtTotal.Text
            arr(5) = txtAdditional.Text

            itm = New ListViewItem(arr)
            POS.tblPayment.Items.Add(itm)

            totalPrice = totalPrice + Convert.ToDecimal(Size_And_Quantity.txtTotal.Text) + Convert.ToDecimal(txtAdditional.Text)
        POS.txtTotalPrice.Text = totalPrice
    End Sub

    Private Sub lblID_VisibleChanged(sender As Object, e As EventArgs) Handles lblID.VisibleChanged
        lblID.Text = Size_And_Quantity.lblID.Text
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Size_And_Quantity.Show()
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
                txtSinker.Text = table.Rows(0)(3).ToString()
                txtAdditional.Text = txtSinker.Text
            End If
        Catch Ex As Exception
            MessageBox.Show("NO Data Found")
        End Try
        cn.Close()
    End Sub

    Private Sub txtAdditional_TextChanged(sender As Object, e As EventArgs) Handles txtAdditional.TextChanged
        Calculate()
    End Sub

    Private Sub txtSinkQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtSinkQuantity.TextChanged
        Calculate()
    End Sub


    Private Sub cboSyrup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSyrup.SelectedIndexChanged
        Dim sql1 As String = ("Select * From tbl_sweetsyrup where SweetSyrupItems = @SweetSyrupItems")

        cmd = New MySqlCommand(sql1, cn)
        cmd.Parameters.Add("@SweetSyrupItems", MySqlDbType.VarChar).Value = cboSyrup.Text
        Dim adapter As New MySqlDataAdapter(cmd)
        cn.Open()
        Dim table As New DataTable()
        Try
            adapter.Fill(table)
            If table.Rows.Count() > 0 Then
                'Return only 1 row
                txtSyrup.Text = table.Rows(0)(3).ToString()
                txtAdditional.Text = txtSyrup.Text
            End If
        Catch Ex As Exception
            MessageBox.Show("NO Data Found")
        End Try
        cn.Close()
    End Sub

    Private Sub txtSweetQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtSweetQuantity.TextChanged
        Calculate()
    End Sub

    Private Sub txtPowderQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtPowderQuantity.TextChanged
        Calculate()
    End Sub

    Private Sub txtMilkQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtMilkQuantity.TextChanged
        Calculate()
    End Sub

    Private Sub cboPowder_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPowder.SelectedIndexChanged
        Dim sql1 As String = ("Select * From tbl_powder where PowderItems = @PowderItems")

        cmd = New MySqlCommand(sql1, cn)
        cmd.Parameters.Add("@PowderItems", MySqlDbType.VarChar).Value = cboPowder.Text
        Dim adapter As New MySqlDataAdapter(cmd)
        cn.Open()
        Dim table As New DataTable()
        Try
            adapter.Fill(table)
            If table.Rows.Count() > 0 Then
                'Return only 1 row
                txtPowder.Text = table.Rows(0)(3).ToString()
                txtAdditional.Text = txtPowder.Text
            End If
        Catch Ex As Exception
            MessageBox.Show("NO Data Found")
        End Try
        cn.Close()
    End Sub

    Private Sub cboMilk_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMilk.SelectedIndexChanged
        Dim sql1 As String = ("Select * From tbl_milk where MilkItems = @MilkItems")

        cmd = New MySqlCommand(sql1, cn)
        cmd.Parameters.Add("@MilkItems", MySqlDbType.VarChar).Value = cboMilk.Text
        Dim adapter As New MySqlDataAdapter(cmd)
        cn.Open()
        Dim table As New DataTable()
        Try
            adapter.Fill(table)
            If table.Rows.Count() > 0 Then
                'Return only 1 row
                txtMilk.Text = table.Rows(0)(3).ToString()
                txtAdditional.Text = txtMilk.Text
            End If
        Catch Ex As Exception
            MessageBox.Show("NO Data Found")
        End Try
        cn.Close()
    End Sub
End Class
