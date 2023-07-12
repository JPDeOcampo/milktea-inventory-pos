<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockManagement
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StockManagement))
        Me.tblStocks = New System.Windows.Forms.ListView()
        Me.NoCol = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ItemCol = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.StockCol = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.AddStock = New System.Windows.Forms.Button()
        Me.NameData = New System.Windows.Forms.TextBox()
        Me.QtyUse = New System.Windows.Forms.TextBox()
        Me.TakeStock = New System.Windows.Forms.Button()
        Me.SrchItem = New System.Windows.Forms.Button()
        Me.NameSrch = New System.Windows.Forms.TextBox()
        Me.AddItem = New System.Windows.Forms.Button()
        Me.DelItem = New System.Windows.Forms.Button()
        Me.ItmName = New System.Windows.Forms.TextBox()
        Me.ItmQty = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.QtyData = New System.Windows.Forms.TextBox()
        Me.BackBtn = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tblStocks
        '
        Me.tblStocks.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.NoCol, Me.ItemCol, Me.StockCol})
        Me.tblStocks.FullRowSelect = True
        Me.tblStocks.GridLines = True
        Me.tblStocks.HideSelection = False
        Me.tblStocks.Location = New System.Drawing.Point(12, 12)
        Me.tblStocks.Name = "tblStocks"
        Me.tblStocks.Size = New System.Drawing.Size(288, 300)
        Me.tblStocks.TabIndex = 7
        Me.tblStocks.UseCompatibleStateImageBehavior = False
        Me.tblStocks.View = System.Windows.Forms.View.Details
        '
        'NoCol
        '
        Me.NoCol.Text = "No."
        Me.NoCol.Width = 57
        '
        'ItemCol
        '
        Me.ItemCol.Text = "Item"
        Me.ItemCol.Width = 167
        '
        'StockCol
        '
        Me.StockCol.Text = "Stock"
        '
        'AddStock
        '
        Me.AddStock.Location = New System.Drawing.Point(73, 370)
        Me.AddStock.Name = "AddStock"
        Me.AddStock.Size = New System.Drawing.Size(72, 23)
        Me.AddStock.TabIndex = 8
        Me.AddStock.Text = "Add/Stock"
        Me.AddStock.UseVisualStyleBackColor = True
        '
        'NameData
        '
        Me.NameData.Location = New System.Drawing.Point(73, 318)
        Me.NameData.Name = "NameData"
        Me.NameData.ReadOnly = True
        Me.NameData.Size = New System.Drawing.Size(150, 20)
        Me.NameData.TabIndex = 9
        '
        'QtyUse
        '
        Me.QtyUse.Location = New System.Drawing.Point(73, 344)
        Me.QtyUse.Name = "QtyUse"
        Me.QtyUse.Size = New System.Drawing.Size(46, 20)
        Me.QtyUse.TabIndex = 10
        '
        'TakeStock
        '
        Me.TakeStock.Location = New System.Drawing.Point(161, 370)
        Me.TakeStock.Name = "TakeStock"
        Me.TakeStock.Size = New System.Drawing.Size(72, 23)
        Me.TakeStock.TabIndex = 11
        Me.TakeStock.Text = "Take out"
        Me.TakeStock.UseVisualStyleBackColor = True
        '
        'SrchItem
        '
        Me.SrchItem.Location = New System.Drawing.Point(327, 199)
        Me.SrchItem.Name = "SrchItem"
        Me.SrchItem.Size = New System.Drawing.Size(97, 20)
        Me.SrchItem.TabIndex = 13
        Me.SrchItem.Text = "Search by name"
        Me.SrchItem.UseVisualStyleBackColor = True
        '
        'NameSrch
        '
        Me.NameSrch.Location = New System.Drawing.Point(329, 173)
        Me.NameSrch.Name = "NameSrch"
        Me.NameSrch.Size = New System.Drawing.Size(95, 20)
        Me.NameSrch.TabIndex = 14
        '
        'AddItem
        '
        Me.AddItem.Location = New System.Drawing.Point(323, 117)
        Me.AddItem.Name = "AddItem"
        Me.AddItem.Size = New System.Drawing.Size(109, 31)
        Me.AddItem.TabIndex = 15
        Me.AddItem.Text = "Add new Item"
        Me.AddItem.UseVisualStyleBackColor = True
        '
        'DelItem
        '
        Me.DelItem.Location = New System.Drawing.Point(323, 253)
        Me.DelItem.Name = "DelItem"
        Me.DelItem.Size = New System.Drawing.Size(109, 45)
        Me.DelItem.TabIndex = 16
        Me.DelItem.Text = "Delete selected item"
        Me.DelItem.UseVisualStyleBackColor = True
        '
        'ItmName
        '
        Me.ItmName.Location = New System.Drawing.Point(323, 45)
        Me.ItmName.Name = "ItmName"
        Me.ItmName.Size = New System.Drawing.Size(95, 20)
        Me.ItmName.TabIndex = 17
        '
        'ItmQty
        '
        Me.ItmQty.Location = New System.Drawing.Point(323, 91)
        Me.ItmQty.Name = "ItmQty"
        Me.ItmQty.Size = New System.Drawing.Size(46, 20)
        Me.ItmQty.TabIndex = 18
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(329, 312)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(89, 81)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(323, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(320, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Quantity:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(320, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "(Enter Name of the item)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 321)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 347)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Quantity:"
        '
        'QtyData
        '
        Me.QtyData.Location = New System.Drawing.Point(229, 318)
        Me.QtyData.Name = "QtyData"
        Me.QtyData.ReadOnly = True
        Me.QtyData.Size = New System.Drawing.Size(50, 20)
        Me.QtyData.TabIndex = 29
        '
        'BackBtn
        '
        Me.BackBtn.Location = New System.Drawing.Point(360, 3)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(72, 23)
        Me.BackBtn.TabIndex = 30
        Me.BackBtn.Text = "Back"
        Me.BackBtn.UseVisualStyleBackColor = True
        '
        'StockManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 399)
        Me.Controls.Add(Me.BackBtn)
        Me.Controls.Add(Me.QtyData)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ItmQty)
        Me.Controls.Add(Me.ItmName)
        Me.Controls.Add(Me.DelItem)
        Me.Controls.Add(Me.AddItem)
        Me.Controls.Add(Me.NameSrch)
        Me.Controls.Add(Me.SrchItem)
        Me.Controls.Add(Me.TakeStock)
        Me.Controls.Add(Me.QtyUse)
        Me.Controls.Add(Me.NameData)
        Me.Controls.Add(Me.AddStock)
        Me.Controls.Add(Me.tblStocks)
        Me.Name = "StockManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StockManagement"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tblStocks As ListView
    Friend WithEvents NoCol As ColumnHeader
    Friend WithEvents ItemCol As ColumnHeader
    Private WithEvents StockCol As ColumnHeader
    Friend WithEvents AddStock As Button
    Friend WithEvents NameData As TextBox
    Friend WithEvents QtyUse As TextBox
    Friend WithEvents TakeStock As Button
    Friend WithEvents SrchItem As Button
    Friend WithEvents NameSrch As TextBox
    Friend WithEvents AddItem As Button
    Friend WithEvents DelItem As Button
    Friend WithEvents ItmName As TextBox
    Friend WithEvents ItmQty As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents QtyData As TextBox
    Friend WithEvents BackBtn As Button
End Class
