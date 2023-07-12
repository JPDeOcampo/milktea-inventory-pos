Imports MySql.Data.MySqlClient
Public Class Register

    Public conn As New MySqlConnection("Server=localhost; User Id=root; Password=''; Database=omt")
    Public adapter As New MySqlDataAdapter
    Public command As New MySqlCommand
    Dim ds As DataSet

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If txtPass.Text = txtReEnter.Text Then
            ds = New DataSet
            adapter = New MySqlDataAdapter("INSERT INTO tbl_account (Firstname, Lastname, Username, Position, Password) VALUES " &
                                           "('" & txtFirst.Text & "','" & txtLast.Text & "','" & txtUser.Text & "','" & cboPostion.Text & "','" & txtPass.Text & "')", conn)
            adapter.Fill(ds, "tbl_account")
            txtFirst.Clear()
            txtLast.Clear()
            txtUser.Clear()
            txtPass.Clear()
            txtReEnter.Clear()
            'ComboBox1.Text = ""
            MsgBox("User Registered!")
            User_Account.Show()
        Else
            MsgBox("Passwords does not match")
        End If
    End Sub
End Class