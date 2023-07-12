<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class POS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(POS))
        Me.btnGolden = New System.Windows.Forms.Button()
        Me.btnFruit = New System.Windows.Forms.Button()
        Me.btnThai = New System.Windows.Forms.Button()
        Me.btnSaltedCaramel = New System.Windows.Forms.Button()
        Me.btnSaltedCheese = New System.Windows.Forms.Button()
        Me.btnYakult = New System.Windows.Forms.Button()
        Me.btnSignature = New System.Windows.Forms.Button()
        Me.btnClassic = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tblFlavorlist = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnWhiteRabbitCandy = New System.Windows.Forms.Button()
        Me.txtTotalPrice = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPayment = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tblPayment = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGolden
        '
        Me.btnGolden.Location = New System.Drawing.Point(607, 86)
        Me.btnGolden.Name = "btnGolden"
        Me.btnGolden.Size = New System.Drawing.Size(214, 59)
        Me.btnGolden.TabIndex = 34
        Me.btnGolden.Text = "Golden Sugar"
        Me.btnGolden.UseVisualStyleBackColor = True
        '
        'btnFruit
        '
        Me.btnFruit.Location = New System.Drawing.Point(207, 86)
        Me.btnFruit.Name = "btnFruit"
        Me.btnFruit.Size = New System.Drawing.Size(189, 59)
        Me.btnFruit.TabIndex = 33
        Me.btnFruit.Text = "Fruit Teas"
        Me.btnFruit.UseVisualStyleBackColor = True
        '
        'btnThai
        '
        Me.btnThai.Location = New System.Drawing.Point(15, 86)
        Me.btnThai.Name = "btnThai"
        Me.btnThai.Size = New System.Drawing.Size(186, 59)
        Me.btnThai.TabIndex = 32
        Me.btnThai.Text = "Thai Series"
        Me.btnThai.UseVisualStyleBackColor = True
        '
        'btnSaltedCaramel
        '
        Me.btnSaltedCaramel.Location = New System.Drawing.Point(607, 19)
        Me.btnSaltedCaramel.Name = "btnSaltedCaramel"
        Me.btnSaltedCaramel.Size = New System.Drawing.Size(214, 61)
        Me.btnSaltedCaramel.TabIndex = 31
        Me.btnSaltedCaramel.Text = "Salted Caramel Cream"
        Me.btnSaltedCaramel.UseVisualStyleBackColor = True
        '
        'btnSaltedCheese
        '
        Me.btnSaltedCheese.Location = New System.Drawing.Point(402, 86)
        Me.btnSaltedCheese.Name = "btnSaltedCheese"
        Me.btnSaltedCheese.Size = New System.Drawing.Size(199, 59)
        Me.btnSaltedCheese.TabIndex = 30
        Me.btnSaltedCheese.Text = "Salted Cheese Blend"
        Me.btnSaltedCheese.UseVisualStyleBackColor = True
        '
        'btnYakult
        '
        Me.btnYakult.Location = New System.Drawing.Point(402, 19)
        Me.btnYakult.Name = "btnYakult"
        Me.btnYakult.Size = New System.Drawing.Size(199, 61)
        Me.btnYakult.TabIndex = 29
        Me.btnYakult.Text = "Yakult Fusion"
        Me.btnYakult.UseVisualStyleBackColor = True
        '
        'btnSignature
        '
        Me.btnSignature.Location = New System.Drawing.Point(207, 19)
        Me.btnSignature.Name = "btnSignature"
        Me.btnSignature.Size = New System.Drawing.Size(189, 61)
        Me.btnSignature.TabIndex = 28
        Me.btnSignature.Text = "Signature Milk Tea"
        Me.btnSignature.UseVisualStyleBackColor = True
        '
        'btnClassic
        '
        Me.btnClassic.Location = New System.Drawing.Point(15, 19)
        Me.btnClassic.Name = "btnClassic"
        Me.btnClassic.Size = New System.Drawing.Size(186, 61)
        Me.btnClassic.TabIndex = 27
        Me.btnClassic.Text = "Classic Milk Tea"
        Me.btnClassic.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tblFlavorlist)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 218)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(366, 325)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Flavor List"
        '
        'tblFlavorlist
        '
        Me.tblFlavorlist.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.tblFlavorlist.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader10, Me.ColumnHeader11})
        Me.tblFlavorlist.FullRowSelect = True
        Me.tblFlavorlist.GridLines = True
        Me.tblFlavorlist.HideSelection = False
        Me.tblFlavorlist.Location = New System.Drawing.Point(6, 18)
        Me.tblFlavorlist.Name = "tblFlavorlist"
        Me.tblFlavorlist.Size = New System.Drawing.Size(354, 300)
        Me.tblFlavorlist.TabIndex = 7
        Me.tblFlavorlist.UseCompatibleStateImageBehavior = False
        Me.tblFlavorlist.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "No."
        Me.ColumnHeader4.Width = 44
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Flavors Items"
        Me.ColumnHeader5.Width = 114
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Medium Price"
        Me.ColumnHeader10.Width = 79
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Large Price"
        Me.ColumnHeader11.Width = 67
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.PictureBox1)
        Me.GroupBox3.Controls.Add(Me.btnWhiteRabbitCandy)
        Me.GroupBox3.Controls.Add(Me.btnClassic)
        Me.GroupBox3.Controls.Add(Me.btnGolden)
        Me.GroupBox3.Controls.Add(Me.btnThai)
        Me.GroupBox3.Controls.Add(Me.btnSaltedCaramel)
        Me.GroupBox3.Controls.Add(Me.btnFruit)
        Me.GroupBox3.Controls.Add(Me.btnSaltedCheese)
        Me.GroupBox3.Controls.Add(Me.btnSignature)
        Me.GroupBox3.Controls.Add(Me.btnYakult)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(828, 218)
        Me.GroupBox3.TabIndex = 35
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tea Selection"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(207, 151)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(614, 61)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'btnWhiteRabbitCandy
        '
        Me.btnWhiteRabbitCandy.Location = New System.Drawing.Point(15, 151)
        Me.btnWhiteRabbitCandy.Name = "btnWhiteRabbitCandy"
        Me.btnWhiteRabbitCandy.Size = New System.Drawing.Size(186, 61)
        Me.btnWhiteRabbitCandy.TabIndex = 35
        Me.btnWhiteRabbitCandy.Text = "White Rabbit Candy"
        Me.btnWhiteRabbitCandy.UseVisualStyleBackColor = True
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.BackColor = System.Drawing.SystemColors.Control
        Me.txtTotalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPrice.Location = New System.Drawing.Point(244, 240)
        Me.txtTotalPrice.Multiline = True
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.Size = New System.Drawing.Size(206, 37)
        Me.txtTotalPrice.TabIndex = 24
        Me.txtTotalPrice.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 246)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 31)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Total Price:"
        '
        'btnPayment
        '
        Me.btnPayment.Location = New System.Drawing.Point(5, 280)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Size = New System.Drawing.Size(192, 38)
        Me.btnPayment.TabIndex = 37
        Me.btnPayment.Text = "Payment"
        Me.btnPayment.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(255, 280)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(195, 38)
        Me.btnRemove.TabIndex = 38
        Me.btnRemove.Text = "Remove Item"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tblPayment)
        Me.GroupBox2.Controls.Add(Me.btnRemove)
        Me.GroupBox2.Controls.Add(Me.btnPayment)
        Me.GroupBox2.Controls.Add(Me.txtTotalPrice)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(384, 235)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(456, 325)
        Me.GroupBox2.TabIndex = 39
        Me.GroupBox2.TabStop = False
        '
        'tblPayment
        '
        Me.tblPayment.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.tblPayment.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9})
        Me.tblPayment.FullRowSelect = True
        Me.tblPayment.GridLines = True
        Me.tblPayment.HideSelection = False
        Me.tblPayment.Location = New System.Drawing.Point(9, 19)
        Me.tblPayment.Name = "tblPayment"
        Me.tblPayment.Size = New System.Drawing.Size(440, 215)
        Me.tblPayment.TabIndex = 39
        Me.tblPayment.UseCompatibleStateImageBehavior = False
        Me.tblPayment.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "No."
        Me.ColumnHeader1.Width = 40
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Flavors Items"
        Me.ColumnHeader2.Width = 114
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "FQ(M)"
        Me.ColumnHeader3.Width = 43
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "FQ(L)"
        Me.ColumnHeader7.Width = 39
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Price"
        Me.ColumnHeader8.Width = 50
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "AditionalPrice"
        Me.ColumnHeader9.Width = 97
        '
        'POS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 567)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "POS"
        Me.Text = "POS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnGolden As Button
    Friend WithEvents btnFruit As Button
    Friend WithEvents btnThai As Button
    Friend WithEvents btnSaltedCaramel As Button
    Friend WithEvents btnSaltedCheese As Button
    Friend WithEvents btnYakult As Button
    Friend WithEvents btnSignature As Button
    Friend WithEvents btnClassic As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tblFlavorlist As ListView
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtTotalPrice As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnPayment As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents tblPayment As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents btnWhiteRabbitCandy As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
