Imports MySql.Data.MySqlClient
Public Class Size_And_Quantity
    Public Sub add_mul()
        If txtMedium.Text <> "" And txtLarge.Text <> "" Then
            txtQuantityMedium.Text = Val(txtSizeMedium.Text)
            txtQuantityLarge.Text = Val(txtSizeLarge.Text)

            txtQuantityMedium.Text = Val(txtSizeMedium.Text) * Val(txtMedium.Text)
            txtQuantityLarge.Text = Val(txtSizeLarge.Text) * Val(txtLarge.Text)
            txtTotal.Text = Val(txtQuantityMedium.Text) + Val(txtQuantityLarge.Text)

        ElseIf txtMedium.Text <> "" Then
            txtQuantityMedium.Text = Val(txtSizeMedium.Text) * Val(txtMedium.Text)
            txtTotal.Text = Val(txtQuantityMedium.Text)

        ElseIf txtLarge.Text <> "" Then
            txtQuantityLarge.Text = Val(txtSizeLarge.Text) * Val(txtLarge.Text)
            txtTotal.Text = Val(txtQuantityLarge.Text)

        Else
            txtTotal.Text = Val(txtSizeMedium.Text) + Val(txtSizeLarge.Text)
        End If
    End Sub
    Dim chkclassic As String
    Dim chksignature As String
    Dim chkyakultfusion As String
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
        cn.Open()
        Dim table As New DataTable()
        adapter.Fill(table)
        If chkMedium.Checked = True And chkLarge.Checked = True Then
            txtMedium.Text = "1"
            txtLarge.Text = "1"
            txtSizeMedium.Text = table.Rows(0)(3).ToString()
            txtSizeLarge.Text = table.Rows(0)(4).ToString()

        ElseIf chkMedium.Checked = True Then
            txtMedium.Text = "1"
            txtSizeMedium.Text = table.Rows(0)(3).ToString()
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
    Private Sub lblID_Click(sender As Object, e As EventArgs)
        lblID.Text = POS.tblFlavorlist.Text
        AdditionalFlavor.lblID.Text = lblID.Text
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

    Private Sub txtAdditional_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged
        add_mul()
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

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        If chkMedium.Checked = False And chkLarge.Checked = False Then
            MsgBox("Please select Size!")
        ElseIf txtMedium.Text = "" And txtLarge.Text = "" Then
            MsgBox("Please input Quantity!")
        ElseIf chkMedium.Checked = True And txtMedium.Text = "" Then
            MsgBox("Please input Medium Quantity!")
        ElseIf chkLarge.Checked = True And txtLarge.Text = "" Then
            MsgBox("Please input Large Quantity!")
        Else
            AdditionalFlavor.Show()
            Me.Close()
        End If
    End Sub


    Private Sub lblID_VisibleChanged(sender As Object, e As EventArgs) Handles lblID.VisibleChanged
        lblID.Text = AdditionalFlavor.lblID.Text 'id ng additional mag didisplay sa id Size_And_Quantity
        lblID.Text = POS.tblPayment.SelectedItems(0).SubItems(0).Text
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtMedium.Text = ""
        txtLarge.Text = ""
        chkMedium.Checked = False
        chkLarge.Checked = False
    End Sub

    Private Sub Size_And_Quantity_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class