Imports MySql.Data.MySqlClient
Module Globaldec
    Public adoRS As ADODB.Recordset


    Public conn As String = ("Server=localhost; User Id=root; Password=''; Database=omt")
    Public cn As New MySqlConnection(conn)
    Public adapter As New MySqlDataAdapter
    Public cmd As New MySqlCommand
    Public ds As DataSet
    Public dt As New DataTable()

    Public totalPrice As Decimal

    Public UserPosition As String = ""

    Public Mcap As Decimal
    Public Lcap As Decimal
    Public TotMProfit As Decimal
    Public TotLProfit As Decimal
    Public SinkName As String
    Public SinkerQ As String
    Public itemstoinsert As Integer
    Public arraycounter As Integer = 5
    Public repeatarray(5) As String
    Public repeatcount As Integer
    Public repeatsubmit As Integer

End Module
