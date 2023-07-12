Imports MySql.Data.MySqlClient
Public Class EditUser
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        cn.Open()

        Dim sql As String = "update tbl_account set FirstName=@FirstName, LastName=@LastName,
                                                        Username=@Username, Position=@Position, Password=@Password" & " where ID=@ID"
        cmd.ExecuteNonQuery()
        cn.Close()
        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@ID", txtID.Text)
        cmd.Parameters.AddWithValue("@FirstName", txtFirst.Text)
        cmd.Parameters.AddWithValue("@LastName", txtLast.Text)
        cmd.Parameters.AddWithValue("@Username", txtUser.Text)
        cmd.Parameters.AddWithValue("@Position", cboPosition.Text)
        cmd.Parameters.AddWithValue("@Password", txtPass.Text)
        'Open Connection and INSERT
        Try
            cn.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                MsgBox("Product Successfully Update")
                txtID.Text = ""
                txtFirst.Text = ""
                txtLast.Text = ""
                txtUser.Text = ""
                txtPass.Text = ""


            ElseIf txtFirst.Text = "" And txtLast.Text = "" And txtUser.Text = "" And cboPosition.Text = "" And txtPass.Text = "" And txtReEnter.Text = "" Then
                MsgBox("No Input!")
            ElseIf txtFirst.Text = """" And txtLast.Text = "" Then
                MsgBox("Please enter Firstname Items and Lastname!")
            ElseIf txtFirst.Text = "" Then
                MsgBox("Please enter Firstname!")
            ElseIf txtLast.Text = "" Then
                MsgBox("Please enter Lastname!")
            ElseIf txtUser.Text = "" And cboPosition.Text = "" Then
                MsgBox("Please enter Username and Position!")
            ElseIf txtUser.Text = "" Then
                MsgBox("Please enter Username!")
            ElseIf cboPosition.Text = "" Then
                MsgBox("Please enter Position!")
            ElseIf txtPass.Text = "" And txtReEnter.Text = "" Then
                MsgBox("Please enter Password and Re-Enter Password!")
            ElseIf txtPass.Text = "" Then
                MsgBox("Please enter Password!")
            ElseIf txtReEnter.Text = "" Then
                MsgBox("Please enter Re-Enter Password!")
            End If
            cn.Close()
            'Retrieve()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try
        User_Account.Show()
        Me.Close()
    End Sub
End Class