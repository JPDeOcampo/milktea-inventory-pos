Imports MySql.Data.MySqlClient
Imports System.Data
Public Class InventoryManagement
    Public conn As New MySqlConnection
    Public cmd As New MySqlCommand
    Public reader As MySqlDataReader
    Public dt As DataTable
    Dim tblview As String
    Dim tbltouse As String
    Dim mlkteatype As String
    Public Sub Display_TableHere()
        ds = New DataSet

        Dim sql1 As String = ("Select * From " + tbltouse)
        cmd = New MySqlCommand(sql1, cn)

        Dim isi As ListViewItem
        tblFlavorlist.Items.Clear()
        cn.Open()

        Dim objreader = cmd.ExecuteReader
        While objreader.Read
            isi = tblFlavorlist.Items.Add(objreader.Item("ID").ToString)
            isi.SubItems.Add(objreader.Item("FlavorItems").ToString)
            isi.SubItems.Add(objreader.Item("MediumPrice").ToString)
            isi.SubItems.Add(objreader.Item("MediumCapital").ToString)
            isi.SubItems.Add(objreader.Item("LargePrice").ToString)
            isi.SubItems.Add(objreader.Item("LargeCapital").ToString)
        End While
        cn.Close()
    End Sub
    Private Sub POS_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClassic_Click(sender As Object, e As EventArgs) Handles btnClassic.Click
        tbltouse = "tbl_classicmilktea"
        mlkteatype = "Classic Milk Tea"
        cboChoices.Text = mlkteatype
        Display_TableHere()

    End Sub



    'adors2.MoveNext()


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click


        Dim sql As String = "INSERT INTO " + tbltouse + "(ID,FlavorItems,MediumPrice,MediumCapital,LargePrice,LargeCapital)
                                                VALUES(@ID,@FlavorItems,@MediumPrice,@MediumCapital,@LargePrice,@LargeCapital)"
        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@ID", txtNo.Text)
        cmd.Parameters.AddWithValue("@FlavorItems", txtFlavorItems.Text)
        cmd.Parameters.AddWithValue("@MediumPrice", txtMedium.Text)
        cmd.Parameters.AddWithValue("@MediumCapital", txtMcapital.Text)
        cmd.Parameters.AddWithValue("@LargePrice", txtLarge.Text)
        cmd.Parameters.AddWithValue("@LargeCapital", TxtLcapital.Text)
        'Open Connection and INSERT
        Try
            cn.Open()
            If txtNo.Text <> "" Then
                MsgBox("You must clear the text before adding")
            ElseIf txtFlavorItems.Text = "" And TxtLcapital.Text = "" And txtMcapital.Text = "" And txtMedium.Text = "" And txtLarge.Text = "" Then
                MsgBox("No Input!")
            ElseIf txtFlavorItems.Text = "" And txtMcapital.Text = "" And TxtLcapital.Text = "" Then
                MsgBox("Please enter Flavor Items and their Capitals!")
            ElseIf txtFlavorItems.Text = "" Then
                MsgBox("Please enter Flavor Items!")
            ElseIf txtMcapital.Text = "" And TxtLcapital.Text = "" Then
                MsgBox("Please enter Medium Capital and Large Capital!")
            ElseIf txtMcapital.Text = "" Then
                MsgBox("Please enter Medium Capital!")
            ElseIf TxtLcapital.Text = "" Then
                MsgBox("Please enter Large Capital!")
            ElseIf txtMedium.Text = "" And txtLarge.Text = "" Then
                MsgBox("Please enter Medium Price and Large Price!")
            ElseIf txtMedium.Text = "" Then
                MsgBox("Please enter Medium Price!")
            ElseIf txtLarge.Text = "" Then
                MsgBox("Please enter Large Price!")
            ElseIf cmd.ExecuteNonQuery() > 0 Then
                MsgBox("Product Successfully Added")
                txtNo.Text = ""
                txtFlavorItems.Text = ""
                txtMcapital.Text = ""
                TxtLcapital.Text = ""
                txtMedium.Text = ""
                txtLarge.Text = ""
            Else
                MsgBox("Please select flavor table!")

            End If
            cn.Close()
            'Retrieve()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("hello")
            cn.Close()
        End Try

        Display_TableHere()

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        cn.Open()
        Dim sql As String = "update " + tbltouse + " set FlavorItems=@FlavorItems,
                                                        MediumPrice=@MediumPrice,MediumCapital=@MediumCapital,LargePrice=@LargePrice, LargeCapital=@LargeCapital" & " where ID=@ID"
        cmd.ExecuteNonQuery()
        cn.Close()
        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@ID", txtNo.Text)
        cmd.Parameters.AddWithValue("@FlavorItems", txtFlavorItems.Text)
        cmd.Parameters.AddWithValue("@MediumPrice", txtMedium.Text)
        cmd.Parameters.AddWithValue("@MediumCapital", txtMcapital.Text)
        cmd.Parameters.AddWithValue("@LargePrice", txtLarge.Text)
        cmd.Parameters.AddWithValue("@LargeCapital", TxtLcapital.Text)
        'Open Connection and INSERT
        Try
            cn.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                MsgBox("Product Successfully Update")
                txtNo.Text = ""
                txtFlavorItems.Text = ""
                txtMcapital.Text = ""
                TxtLcapital.Text = ""
                txtMedium.Text = ""
                txtLarge.Text = ""


            ElseIf txtFlavorItems.Text = "" And TxtLcapital.Text = "" And TxtMcapital.Text = "" And txtMedium.Text = "" And txtLarge.Text = "" Then
                MsgBox("No Input!")
            ElseIf txtFlavorItems.Text = "" And txtMcapital.Text = "" And TxtLcapital.Text = "" Then
                MsgBox("Please enter Flavor Items and their Capitals!")
            ElseIf txtFlavorItems.Text = "" Then
                MsgBox("Please enter Flavor Items!")
            ElseIf txtMcapital.Text = "" And txtLcapital.text = "" Then
                MsgBox("Please enter Medium Capital and Large Capital!")
            ElseIf txtMcapital.Text = "" Then
                MsgBox("Please enter Medium Capital!")
            ElseIf txtLcapital.Text = "" Then
                MsgBox("Please enter Large Capital!")
            ElseIf txtMedium.Text = "" And txtLarge.Text = "" Then
                MsgBox("Please enter Medium Price and Large Price!")
            ElseIf txtMedium.Text = "" Then
                MsgBox("Please enter Medium Price!")
            ElseIf txtLarge.Text = "" Then
                MsgBox("Please enter Large Price!")
            Else
                MsgBox("Please select flavor table!")

            End If
            cn.Close()
            'Retrieve()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try
        Display_TableHere()
    End Sub

    Private Sub tblFlavorlist_Click(sender As Object, e As EventArgs) Handles tblFlavorlist.Click
        If tblFlavorlist.SelectedIndices.Count <= 0 Then
            MsgBox("No selected items", 64, "Invalid")
        Else
            txtNo.Text = tblFlavorlist.SelectedItems(0).SubItems(0).Text
            txtFlavorItems.Text = tblFlavorlist.SelectedItems(0).SubItems(1).Text
            txtMedium.Text = tblFlavorlist.SelectedItems(0).SubItems(2).Text
            txtMcapital.Text = tblFlavorlist.SelectedItems(0).SubItems(3).Text
            txtLarge.Text = tblFlavorlist.SelectedItems(0).SubItems(4).Text
            TxtLcapital.Text = tblFlavorlist.SelectedItems(0).SubItems(5).Text

            cboChoices.Text = mlkteatype
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        cn.Open()
        Dim sql As String = "delete from " + tbltouse + " where ID=@ID"
        cmd.ExecuteNonQuery()
        cn.Close()
        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@ID", txtNo.Text)

        'Open Connection and INSERT
        Try
            cn.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                MsgBox("Product Successfully Delete")
                txtNo.Text = ""
                txtFlavorItems.Text = ""
                txtMcapital.Text = ""
                TxtLcapital.Text = ""
                txtMedium.Text = ""
                txtLarge.Text = ""
            End If
            cn.Close()
            'Retrieve()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try
        Display_TableHere()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNo.Text = ""
        txtFlavorItems.Text = ""
        txtMcapital.Text = ""
        TxtLcapital.Text = ""
        txtMedium.Text = ""
        txtLarge.Text = ""
    End Sub


    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim sql1 As String = ("Select * From tbl_classicmilktea where FlavorItems = @FlavorItems UNION ALL Select * From tbl_signaturemilktea where FlavorItems = @FlavorItems
                                    UNION ALL Select * From tbl_signaturemilktea where FlavorItems = @FlavorItems 
                                    UNION ALL Select * From tbl_yakultfusion where FlavorItems = @FlavorItems
                                    UNION ALL Select * From tbl_saltedcheeseblend where FlavorItems = @FlavorItems 
                                    UNION ALL Select * From tbl_saltedcaramelcream where FlavorItems = @FlavorItems
                                    UNION ALL Select * From tbl_thaiseries where FlavorItems = @FlavorItems
                                    UNION ALL Select * From tbl_fruitteas where FlavorItems = @FlavorItems
                                    UNION ALL Select * From tbl_goldensugar where FlavorItems = @FlavorItems
                                    UNION ALL Select * From tbl_whiterabbitcandy where FlavorItems = @FlavorItems")


        cmd = New MySqlCommand(sql1, cn)
        cmd.Parameters.Add("@FlavorItems", MySqlDbType.VarChar).Value = txtSearch.Text
        Dim adapter As New MySqlDataAdapter(cmd)
        cn.Open()
        Dim table As New DataTable()
        Try
            adapter.Fill(table)
            If table.Rows.Count() > 0 Then
                'Return only 1 row
                txtNo.Text = table.Rows(0)(0).ToString()
                txtFlavorItems.Text = table.Rows(0)(1).ToString()
                txtMedium.Text = table.Rows(0)(2).ToString()
                txtMcapital.Text = table.Rows(0)(3).ToString()
                txtLarge.Text = table.Rows(0)(4).ToString()
                TxtLcapital.Text = table.Rows(0)(5).ToString()
            End If
        Catch Ex As Exception
            MessageBox.Show("NO Data Found")
        End Try
        cn.Close()
    End Sub


    Private Sub BtnSignature_Click(sender As Object, e As EventArgs) Handles btnSignature.Click
        tbltouse = "tbl_signaturemilktea"
        mlkteatype = "Signature Milk Tea"
        cboChoices.Text = mlkteatype
        Display_TableHere()

    End Sub

    Private Sub CboChoices_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboChoices.SelectedIndexChanged
        If cboChoices.Text = "Classic Milk Tea" Then
            tbltouse = "tbl_classicmilktea"

        ElseIf cboChoices.Text = "Signature Milk Tea" Then
            tbltouse = "tbl_signaturemilktea"

        ElseIf cboChoices.Text = "Yakult Fusion" Then
            tbltouse = "tbl_yakultfusion"

        ElseIf cboChoices.Text = "Salted Cheese Blend" Then
            tbltouse = "tbl_saltedcheeseblend"

        ElseIf cboChoices.Text = "Salted Caramel Cream" Then
            tbltouse = "tbl_saltedcaramelcream"

        ElseIf cboChoices.Text = "Thai Series" Then
            tbltouse = "tbl_thaiseries"

        ElseIf cboChoices.Text = "Fruit Teas" Then
            tbltouse = "tbl_fruitteas"

        ElseIf cboChoices.Text = "Golden Sugar" Then
            tbltouse = "tbl_goldensugar"

        ElseIf cboChoices.Text = "White Rabbit Candy" Then
            tbltouse = "tbl_whiterabbitcandy"

        End If
    End Sub
    Private Sub BtnYakult_Click(sender As Object, e As EventArgs) Handles btnYakult.Click
        tbltouse = "tbl_yakultfusion"
        mlkteatype = "Yakult Fusion"
        cboChoices.Text = mlkteatype
        Display_TableHere()
    End Sub

    Private Sub BtnSaltedCheese_Click(sender As Object, e As EventArgs) Handles btnSaltedCheese.Click
        tbltouse = "tbl_saltedcheeseblend"
        mlkteatype = "Salted Cheese Blend"
        cboChoices.Text = mlkteatype
        Display_TableHere()
    End Sub

    Private Sub BtnSaltedCaramel_Click(sender As Object, e As EventArgs) Handles btnSaltedCaramel.Click
        tbltouse = "tbl_saltedcaramelcream"
        mlkteatype = "Salted Caramel Cream"
        cboChoices.Text = mlkteatype
        Display_TableHere()
    End Sub

    Private Sub BtnThai_Click(sender As Object, e As EventArgs) Handles btnThai.Click
        tbltouse = "tbl_thaiseries"
        mlkteatype = "Thai Series"
        cboChoices.Text = mlkteatype
        Display_TableHere()
    End Sub

    Private Sub BtnFruit_Click(sender As Object, e As EventArgs) Handles btnFruit.Click
        tbltouse = "tbl_fruitteas"
        mlkteatype = "Fruit Teas"
        cboChoices.Text = mlkteatype
        Display_TableHere()
    End Sub

    Private Sub BtnGolden_Click(sender As Object, e As EventArgs) Handles btnGolden.Click
        tbltouse = "tbl_goldensugar"
        mlkteatype = "Golden Sugar"
        cboChoices.Text = mlkteatype
        Display_TableHere()
    End Sub

    Private Sub btnSinkers_Click(sender As Object, e As EventArgs) Handles btnSinkers.Click
        Sinkers.Show()
    End Sub

    Private Sub btnSweet_Click(sender As Object, e As EventArgs) 
        Sweet_Syrup.Show()
    End Sub

    Private Sub TblFlavorlist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tblFlavorlist.SelectedIndexChanged

    End Sub

    Private Sub BtnWhite_Click(sender As Object, e As EventArgs) Handles BtnWhite.Click
        tbltouse = "tbl_whiterabbitcandy"
        mlkteatype = "White Rabbit Candy"
        cboChoices.Text = mlkteatype
        Display_TableHere()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        StockManagement.Show()
    End Sub
End Class
