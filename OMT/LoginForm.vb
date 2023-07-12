Imports MySql.Data.MySqlClient

Public Class LoginForm

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Please fill in all fields.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Try
                'Dim sql As String = "SELECT Username, Password, Position FROM tbl_account WHERE Username='" & txtUsername.Text & "' AND Password='" & txtPassword.Text & "'"
                Dim sql1 As String = ("Select * From tbl_account where username=@Username and password=@Password")

                cmd = New MySqlCommand(sql1, cn)
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text)

                cmd.Connection = cn
                Dim adapter As New MySqlDataAdapter(cmd)
                cn.Open()
                Dim table As New DataTable()
                adapter.Fill(table)
                'MsgBox(table.Rows(0)(3))

                If StrComp(txtUsername.Text, table.Rows(0)(3), 0) = 0 And StrComp(txtPassword.Text, table.Rows(0)(4), 0) = 0 Then
                    Dim dr As MySqlDataReader = cmd.ExecuteReader

                    Dim position As String = Nothing
                    If dr.Read = True Then
                        position = dr("Position")
                        Select Case position
                            Case "Admin"
                                ' TODO: Handle admin
                                MDIParent1.Show()
                                Me.Close()
                            Case "User"
                                ' TODO: Handle user
                                MDIParent1.InventoryMngmnt2.Enabled = False
                                MDIParent1.InventoryMngmnt2.Visible = False
                                MDIParent1.UserAccountToolStripMenuItem.Enabled = False
                                MDIParent1.UserAccountToolStripMenuItem.Visible = False
                                MDIParent1.Show()
                                Me.Close()
                            Case Else
                                ' TODO: Neither Admin nor User. Now what?

                        End Select
                    Else
                        MessageBox.Show("Incorrect Username or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                    MsgBox("Proceed!")
                Else
                    MessageBox.Show("Incorrect Username or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If

                'Dim dr As MySqlDataReader = cmd.ExecuteReader

                'Dim position As String = Nothing
                'If dr.Read = True Then
                '    position = dr("Position")
                '    Select Case position
                '        Case "Admin"
                '            ' TODO: Handle admin
                '            MDIParent1.Show()
                '            Me.Hide()
                '        Case "User"
                '            ' TODO: Handle user
                '            MDIParent1.InventoryMngmnt2.Enabled = False
                '            MDIParent1.InventoryMngmnt2.Visible = False
                '            MDIParent1.UserAccountToolStripMenuItem.Enabled = False
                '            MDIParent1.UserAccountToolStripMenuItem.Visible = False
                '            MDIParent1.Show()
                '            Me.Hide()
                '        Case Else
                '            ' TODO: Neither Admin nor User. Now what?

                '    End Select
                '    'If StrComp(txtUsername.Text, dr.GetValue(3), 0) = 0 Then

                '    'Else

                '    '    MessageBox.Show("Incorrect Username or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                '    'End If

                'Else
                '        MessageBox.Show("Incorrect Username or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                'End If
            Catch ex As Exception
                'MessageBox.Show("Failed to connect to databse. System Error:" & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            txtUsername.Text = ""
            txtPassword.Text = ""
            If cn.State <> ConnectionState.Closed Then
                cn.Close()
            End If
        End If
        cn.Close()
    End Sub
    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Register.Show()
    End Sub

    Private Sub rboUser_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cboPosition_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Static rand As New Random()
        'Me.BackColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256))
        'PanelOK.BackColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256))
        'PanelCancel.BackColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256))
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class