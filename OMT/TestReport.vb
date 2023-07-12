Imports MySql.Data.MySqlClient

Public Class TestReport

    Private Sub btnReport_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub TestReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim cmd As MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim dt As New DataSet
        Dim sql As String

        sql = "select * from tbl_saltedcaramelcream"
        Try
            cn.Open()
            cmd = New MySqlCommand(sql, cn)
            adp.SelectCommand = cmd
            adp.Fill(dt, "tbl_saltedcaramelcream")
            Dim report As New tryreport
            report.SetDataSource(dt)
            CrystalReportViewer1.ReportSource = report
            CrystalReportViewer1.Refresh()
            cmd.Dispose()
            adp.Dispose()
            dt.Dispose()
            cn.Close()

        Catch ex As Exception
            MsgBox("aoifhg")
            cn.Close()
        End Try
    End Sub



    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim cmd As MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim dt As New DataSet
        Dim sql As String
        'sql = "select * from tbl_payment"
        sql = ("select FlavorItems, FQuantityM, MCapital, FQuantityL, LCapital, Price, AdditionalPrice, TotalMProfit, TotalLProfit, Date from tbl_payment where date(Date) between '" & datetimeFrom.Value.ToString("yyyy-MM-dd") & "' and '" & datetimeTo.Value.ToString("yyyy-MM-dd") & "'")
        ' sql = ("select FlavorItems, FQuantityM, MCapital, FQuantityL, LCapital, Price, TotalMProfit, TotalLProfit, Date from tbl_payment where date(Date) between '" & datetimeFrom.Value.ToString("yyyy-MM-dd") & "' and '" & datetimeTo.Value.ToString("yyyy-MM-dd") & "'")

        Try
            cn.Open()
            cmd = New MySqlCommand(sql, cn)
            adp.SelectCommand = cmd
            adp.Fill(dt, "tbl_payment")
            Dim report As New finalsales
            report.SetDataSource(dt)
            CrystalReportViewer1.ReportSource = report
            CrystalReportViewer1.Refresh()
            cmd.Dispose()
            adp.Dispose()
            dt.Dispose()
            cn.Close()

        Catch ex As Exception
            MsgBox("aoifhg")
            cn.Close()
        End Try
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnSGenerate_Click(sender As Object, e As EventArgs) Handles btnSGenerate.Click
        Dim cmd As MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim dt As New DataSet
        Dim sql As String
        'sql = "select * from tbl_payment"
        sql = ("select SinkerName, SinkerQ, AdditionalPrice, Date from tbl_payment where SinkerQ <> 0 AND date(Date) between '" & datetimeFrom.Value.ToString("yyyy-MM-dd") & "' and '" & datetimeTo.Value.ToString("yyyy-MM-dd") & "'")
        ' sql = ("select FlavorItems, FQuantityM, MCapital, FQuantityL, LCapital, Price, TotalMProfit, TotalLProfit, Date from tbl_payment where date(Date) between '" & datetimeFrom.Value.ToString("yyyy-MM-dd") & "' and '" & datetimeTo.Value.ToString("yyyy-MM-dd") & "'")

        Try
            cn.Open()
            cmd = New MySqlCommand(sql, cn)
            adp.SelectCommand = cmd
            adp.Fill(dt, "tbl_payment")
            Dim report As New sinkersreport
            report.SetDataSource(dt)
            CrystalReportViewer1.ReportSource = report
            CrystalReportViewer1.Refresh()
            cmd.Dispose()
            adp.Dispose()
            dt.Dispose()
            cn.Close()

        Catch ex As Exception
            MsgBox("aoifhg")
            cn.Close()
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim dt As New DataSet
        Dim sql As String
        'sql = "select * from tbl_payment"
        sql = ("select ID, Name, Quantity from tbl_stocks")
        ' sql = ("select FlavorItems, FQuantityM, MCapital, FQuantityL, LCapital, Price, TotalMProfit, TotalLProfit, Date from tbl_payment where date(Date) between '" & datetimeFrom.Value.ToString("yyyy-MM-dd") & "' and '" & datetimeTo.Value.ToString("yyyy-MM-dd") & "'")

        Try
            cn.Open()
            cmd = New MySqlCommand(sql, cn)
            adp.SelectCommand = cmd
            adp.Fill(dt, "tbl_stocks")
            Dim report As New stockreport
            report.SetDataSource(dt)
            CrystalReportViewer1.ReportSource = report
            CrystalReportViewer1.Refresh()
            cmd.Dispose()
            adp.Dispose()
            dt.Dispose()
            cn.Close()

        Catch ex As Exception
            MsgBox("aoifhg")
            cn.Close()
        End Try

    End Sub
End Class