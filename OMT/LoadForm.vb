Public Class LoadForm
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = My.Application.Info.Title
        Else
            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

        Copyright.Text = My.Application.Info.Copyright
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Static rand As New Random()
        Me.BackColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256))
        Static x As Integer
        x = x + 2
        lblTimer.Text = x
        pbarLoading.Value = x
        If x = 100 Then
            Timer1.Enabled = False
            LoginForm.Show()
            Me.Hide()

        End If

    End Sub
End Class