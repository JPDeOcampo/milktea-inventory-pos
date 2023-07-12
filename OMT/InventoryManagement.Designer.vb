<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InventoryManagement
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InventoryManagement))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnWhite = New System.Windows.Forms.Button()
        Me.tblFlavorlist = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnClassic = New System.Windows.Forms.Button()
        Me.btnGolden = New System.Windows.Forms.Button()
        Me.btnSignature = New System.Windows.Forms.Button()
        Me.btnFruit = New System.Windows.Forms.Button()
        Me.btnYakult = New System.Windows.Forms.Button()
        Me.btnThai = New System.Windows.Forms.Button()
        Me.btnSaltedCheese = New System.Windows.Forms.Button()
        Me.btnSaltedCaramel = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TxtLcapital = New System.Windows.Forms.TextBox()
        Me.txtMcapital = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboChoices = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLarge = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMedium = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFlavorItems = New System.Windows.Forms.TextBox()
        Me.txtNo = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSinkers = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnWhite)
        Me.GroupBox1.Controls.Add(Me.tblFlavorlist)
        Me.GroupBox1.Controls.Add(Me.btnClassic)
        Me.GroupBox1.Controls.Add(Me.btnGolden)
        Me.GroupBox1.Controls.Add(Me.btnSignature)
        Me.GroupBox1.Controls.Add(Me.btnFruit)
        Me.GroupBox1.Controls.Add(Me.btnYakult)
        Me.GroupBox1.Controls.Add(Me.btnThai)
        Me.GroupBox1.Controls.Add(Me.btnSaltedCheese)
        Me.GroupBox1.Controls.Add(Me.btnSaltedCaramel)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 199)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(884, 334)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tea Selection and Flavor List"
        '
        'BtnWhite
        '
        Me.BtnWhite.Location = New System.Drawing.Point(11, 293)
        Me.BtnWhite.Name = "BtnWhite"
        Me.BtnWhite.Size = New System.Drawing.Size(129, 27)
        Me.BtnWhite.TabIndex = 31
        Me.BtnWhite.Text = "White Rabbit Candy"
        Me.BtnWhite.UseVisualStyleBackColor = True
        '
        'tblFlavorlist
        '
        Me.tblFlavorlist.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader1})
        Me.tblFlavorlist.FullRowSelect = True
        Me.tblFlavorlist.GridLines = True
        Me.tblFlavorlist.HideSelection = False
        Me.tblFlavorlist.Location = New System.Drawing.Point(185, 19)
        Me.tblFlavorlist.Name = "tblFlavorlist"
        Me.tblFlavorlist.Size = New System.Drawing.Size(638, 300)
        Me.tblFlavorlist.TabIndex = 6
        Me.tblFlavorlist.UseCompatibleStateImageBehavior = False
        Me.tblFlavorlist.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "No."
        Me.ColumnHeader4.Width = 57
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Flavors Items"
        Me.ColumnHeader5.Width = 167
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Medium Price"
        Me.ColumnHeader6.Width = 94
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Medium Capital"
        Me.ColumnHeader10.Width = 107
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Large Price"
        Me.ColumnHeader11.Width = 92
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Large Capital"
        Me.ColumnHeader1.Width = 113
        '
        'btnClassic
        '
        Me.btnClassic.Location = New System.Drawing.Point(9, 19)
        Me.btnClassic.Name = "btnClassic"
        Me.btnClassic.Size = New System.Drawing.Size(130, 29)
        Me.btnClassic.TabIndex = 23
        Me.btnClassic.Text = "Classic Milk Tea"
        Me.btnClassic.UseVisualStyleBackColor = True
        '
        'btnGolden
        '
        Me.btnGolden.Location = New System.Drawing.Point(10, 260)
        Me.btnGolden.Name = "btnGolden"
        Me.btnGolden.Size = New System.Drawing.Size(129, 27)
        Me.btnGolden.TabIndex = 30
        Me.btnGolden.Text = "Golden Sugar"
        Me.btnGolden.UseVisualStyleBackColor = True
        '
        'btnSignature
        '
        Me.btnSignature.Location = New System.Drawing.Point(10, 54)
        Me.btnSignature.Name = "btnSignature"
        Me.btnSignature.Size = New System.Drawing.Size(129, 29)
        Me.btnSignature.TabIndex = 24
        Me.btnSignature.Text = "Signature Milk Tea"
        Me.btnSignature.UseVisualStyleBackColor = True
        '
        'btnFruit
        '
        Me.btnFruit.Location = New System.Drawing.Point(11, 227)
        Me.btnFruit.Name = "btnFruit"
        Me.btnFruit.Size = New System.Drawing.Size(128, 27)
        Me.btnFruit.TabIndex = 29
        Me.btnFruit.Text = "Fruit Teas"
        Me.btnFruit.UseVisualStyleBackColor = True
        '
        'btnYakult
        '
        Me.btnYakult.Location = New System.Drawing.Point(10, 89)
        Me.btnYakult.Name = "btnYakult"
        Me.btnYakult.Size = New System.Drawing.Size(129, 29)
        Me.btnYakult.TabIndex = 25
        Me.btnYakult.Text = "Yakult Fusion"
        Me.btnYakult.UseVisualStyleBackColor = True
        '
        'btnThai
        '
        Me.btnThai.Location = New System.Drawing.Point(10, 194)
        Me.btnThai.Name = "btnThai"
        Me.btnThai.Size = New System.Drawing.Size(129, 27)
        Me.btnThai.TabIndex = 28
        Me.btnThai.Text = "Thai Series"
        Me.btnThai.UseVisualStyleBackColor = True
        '
        'btnSaltedCheese
        '
        Me.btnSaltedCheese.Location = New System.Drawing.Point(10, 124)
        Me.btnSaltedCheese.Name = "btnSaltedCheese"
        Me.btnSaltedCheese.Size = New System.Drawing.Size(129, 29)
        Me.btnSaltedCheese.TabIndex = 26
        Me.btnSaltedCheese.Text = "Salted Cheese Blend"
        Me.btnSaltedCheese.UseVisualStyleBackColor = True
        '
        'btnSaltedCaramel
        '
        Me.btnSaltedCaramel.Location = New System.Drawing.Point(9, 159)
        Me.btnSaltedCaramel.Name = "btnSaltedCaramel"
        Me.btnSaltedCaramel.Size = New System.Drawing.Size(130, 29)
        Me.btnSaltedCaramel.TabIndex = 27
        Me.btnSaltedCaramel.Text = "Salted Caramel Cream"
        Me.btnSaltedCaramel.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TxtLcapital)
        Me.GroupBox3.Controls.Add(Me.txtMcapital)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.btnClear)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.cboChoices)
        Me.GroupBox3.Controls.Add(Me.PictureBox1)
        Me.GroupBox3.Controls.Add(Me.btnSearch)
        Me.GroupBox3.Controls.Add(Me.txtSearch)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txtLarge)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txtMedium)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.btnUpdate)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtFlavorItems)
        Me.GroupBox3.Controls.Add(Me.txtNo)
        Me.GroupBox3.Controls.Add(Me.btnAdd)
        Me.GroupBox3.Controls.Add(Me.btnDelete)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(930, 130)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        '
        'TxtLcapital
        '
        Me.TxtLcapital.Location = New System.Drawing.Point(731, 50)
        Me.TxtLcapital.Name = "TxtLcapital"
        Me.TxtLcapital.Size = New System.Drawing.Size(153, 20)
        Me.TxtLcapital.TabIndex = 29
        '
        'txtMcapital
        '
        Me.txtMcapital.Location = New System.Drawing.Point(731, 21)
        Me.txtMcapital.Name = "txtMcapital"
        Me.txtMcapital.Size = New System.Drawing.Size(153, 20)
        Me.txtMcapital.TabIndex = 28
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(643, 57)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 13)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Large Capital:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(643, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Medium Capital:"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(551, 98)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(68, 25)
        Me.btnClear.TabIndex = 24
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(358, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Select Flavor Table:"
        '
        'cboChoices
        '
        Me.cboChoices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboChoices.FormattingEnabled = True
        Me.cboChoices.Items.AddRange(New Object() {"Classic Milk Tea", "Signature Milk Tea", "Yakult Fusion", "Salted Cheese Blend", "Salted Caramel Cream", "Thai Series", "Fruit Teas", "Golden Sugar", "White Rabbit Candy"})
        Me.cboChoices.Location = New System.Drawing.Point(466, 72)
        Me.cboChoices.Name = "cboChoices"
        Me.cboChoices.Size = New System.Drawing.Size(153, 21)
        Me.cboChoices.TabIndex = 22
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(104, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(316, 19)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(38, 23)
        Me.btnSearch.TabIndex = 12
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(198, 22)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(115, 20)
        Me.txtSearch.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(116, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Search Flavor:"
        '
        'txtLarge
        '
        Me.txtLarge.Location = New System.Drawing.Point(466, 50)
        Me.txtLarge.Name = "txtLarge"
        Me.txtLarge.Size = New System.Drawing.Size(153, 20)
        Me.txtLarge.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(358, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Large Price:"
        '
        'txtMedium
        '
        Me.txtMedium.Location = New System.Drawing.Point(466, 20)
        Me.txtMedium.Name = "txtMedium"
        Me.txtMedium.Size = New System.Drawing.Size(153, 20)
        Me.txtMedium.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(358, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Medium Price:"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(392, 100)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(76, 24)
        Me.btnUpdate.TabIndex = 13
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(116, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Flavor Items:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(116, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "No."
        '
        'txtFlavorItems
        '
        Me.txtFlavorItems.Location = New System.Drawing.Point(198, 75)
        Me.txtFlavorItems.Name = "txtFlavorItems"
        Me.txtFlavorItems.Size = New System.Drawing.Size(156, 20)
        Me.txtFlavorItems.TabIndex = 8
        '
        'txtNo
        '
        Me.txtNo.Location = New System.Drawing.Point(198, 49)
        Me.txtNo.Name = "txtNo"
        Me.txtNo.ReadOnly = True
        Me.txtNo.Size = New System.Drawing.Size(156, 20)
        Me.txtNo.TabIndex = 7
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(311, 101)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 24)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(474, 98)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(71, 25)
        Me.btnDelete.TabIndex = 5
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.btnSinkers)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 135)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(312, 58)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Additional Flavor"
        '
        'btnSinkers
        '
        Me.btnSinkers.Location = New System.Drawing.Point(10, 14)
        Me.btnSinkers.Name = "btnSinkers"
        Me.btnSinkers.Size = New System.Drawing.Size(143, 38)
        Me.btnSinkers.TabIndex = 0
        Me.btnSinkers.Text = "Sinkers"
        Me.btnSinkers.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(159, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(143, 38)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Stocks/Storage"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'InventoryManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 545)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "InventoryManagement"
        Me.Text = "FlavorManagement"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents tblFlavorlist As ListView
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents btnGolden As Button
    Friend WithEvents btnFruit As Button
    Friend WithEvents btnThai As Button
    Friend WithEvents btnSaltedCaramel As Button
    Friend WithEvents btnSaltedCheese As Button
    Friend WithEvents btnYakult As Button
    Friend WithEvents btnSignature As Button
    Friend WithEvents btnClassic As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents cboChoices As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLarge As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtMedium As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFlavorItems As TextBox
    Friend WithEvents txtNo As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSinkers As Button
    Friend WithEvents BtnWhite As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtLcapital As TextBox
    Friend WithEvents txtMcapital As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Button1 As Button
End Class
