<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdditionalFlavor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdditionalFlavor))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSinker = New System.Windows.Forms.TextBox()
        Me.cboSinkers = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSinkQuantity = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboSyrup = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSyrup = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSweetQuantity = New System.Windows.Forms.TextBox()
        Me.cboPowder = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPowder = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPowderQuantity = New System.Windows.Forms.TextBox()
        Me.cboMilk = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMilk = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtMilkQuantity = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.lblID = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.txtAdditional = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Sinker Price:"
        '
        'txtSinker
        '
        Me.txtSinker.Location = New System.Drawing.Point(79, 68)
        Me.txtSinker.Name = "txtSinker"
        Me.txtSinker.ReadOnly = True
        Me.txtSinker.Size = New System.Drawing.Size(106, 20)
        Me.txtSinker.TabIndex = 4
        '
        'cboSinkers
        '
        Me.cboSinkers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSinkers.FormattingEnabled = True
        Me.cboSinkers.Items.AddRange(New Object() {"Black Pearl", "White Pearl", "Nata", "Egg Pudding", "Coffee Jelly", "Grass Jelly", "Popping Bobba", "1"})
        Me.cboSinkers.Location = New System.Drawing.Point(9, 16)
        Me.cboSinkers.Name = "cboSinkers"
        Me.cboSinkers.Size = New System.Drawing.Size(176, 21)
        Me.cboSinkers.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSinkQuantity)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cboSinkers)
        Me.GroupBox1.Controls.Add(Me.txtSinker)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(192, 92)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sinkers"
        '
        'txtSinkQuantity
        '
        Me.txtSinkQuantity.Location = New System.Drawing.Point(79, 42)
        Me.txtSinkQuantity.Name = "txtSinkQuantity"
        Me.txtSinkQuantity.Size = New System.Drawing.Size(106, 20)
        Me.txtSinkQuantity.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Cup Quantity:"
        '
        'cboSyrup
        '
        Me.cboSyrup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSyrup.FormattingEnabled = True
        Me.cboSyrup.Items.AddRange(New Object() {"Black Sugar", "Golden Sugar", "Simple"})
        Me.cboSyrup.Location = New System.Drawing.Point(6, 16)
        Me.cboSyrup.Name = "cboSyrup"
        Me.cboSyrup.Size = New System.Drawing.Size(179, 21)
        Me.cboSyrup.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Syrup Price:"
        '
        'txtSyrup
        '
        Me.txtSyrup.Location = New System.Drawing.Point(79, 66)
        Me.txtSyrup.Name = "txtSyrup"
        Me.txtSyrup.ReadOnly = True
        Me.txtSyrup.Size = New System.Drawing.Size(106, 20)
        Me.txtSyrup.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtSweetQuantity)
        Me.GroupBox2.Controls.Add(Me.txtSyrup)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cboSyrup)
        Me.GroupBox2.Location = New System.Drawing.Point(210, 78)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(192, 92)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sweet Syrup"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Cup Quantity:"
        '
        'txtSweetQuantity
        '
        Me.txtSweetQuantity.Location = New System.Drawing.Point(80, 43)
        Me.txtSweetQuantity.Name = "txtSweetQuantity"
        Me.txtSweetQuantity.Size = New System.Drawing.Size(106, 20)
        Me.txtSweetQuantity.TabIndex = 8
        '
        'cboPowder
        '
        Me.cboPowder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPowder.FormattingEnabled = True
        Me.cboPowder.Items.AddRange(New Object() {"Brown sugar", "Cinnamon", "Simple", "Flour", "Powder milk", "Salt", "Taro"})
        Me.cboPowder.Location = New System.Drawing.Point(6, 16)
        Me.cboPowder.Name = "cboPowder"
        Me.cboPowder.Size = New System.Drawing.Size(179, 21)
        Me.cboPowder.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Powder Price:"
        '
        'txtPowder
        '
        Me.txtPowder.Location = New System.Drawing.Point(80, 67)
        Me.txtPowder.Name = "txtPowder"
        Me.txtPowder.ReadOnly = True
        Me.txtPowder.Size = New System.Drawing.Size(105, 20)
        Me.txtPowder.TabIndex = 5
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txtPowderQuantity)
        Me.GroupBox3.Controls.Add(Me.txtPowder)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.cboPowder)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 176)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(192, 92)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Powder"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Cup Quantity:"
        '
        'txtPowderQuantity
        '
        Me.txtPowderQuantity.Location = New System.Drawing.Point(80, 44)
        Me.txtPowderQuantity.Name = "txtPowderQuantity"
        Me.txtPowderQuantity.Size = New System.Drawing.Size(106, 20)
        Me.txtPowderQuantity.TabIndex = 8
        '
        'cboMilk
        '
        Me.cboMilk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMilk.FormattingEnabled = True
        Me.cboMilk.Items.AddRange(New Object() {"Fresh milk", "Harvey Fresh", "Special milk", "Taiwan's milk", "Powder milk", "Whip Cream", "Yakult"})
        Me.cboMilk.Location = New System.Drawing.Point(6, 16)
        Me.cboMilk.Name = "cboMilk"
        Me.cboMilk.Size = New System.Drawing.Size(179, 21)
        Me.cboMilk.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Milk Price:"
        '
        'txtMilk
        '
        Me.txtMilk.Location = New System.Drawing.Point(79, 64)
        Me.txtMilk.Name = "txtMilk"
        Me.txtMilk.ReadOnly = True
        Me.txtMilk.Size = New System.Drawing.Size(106, 20)
        Me.txtMilk.TabIndex = 5
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.txtMilk)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.txtMilkQuantity)
        Me.GroupBox4.Controls.Add(Me.cboMilk)
        Me.GroupBox4.Location = New System.Drawing.Point(210, 176)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(192, 92)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Milk"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Cup Quantity:"
        '
        'txtMilkQuantity
        '
        Me.txtMilkQuantity.Location = New System.Drawing.Point(79, 41)
        Me.txtMilkQuantity.Name = "txtMilkQuantity"
        Me.txtMilkQuantity.Size = New System.Drawing.Size(106, 20)
        Me.txtMilkQuantity.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 284)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Total Additional Price:"
        '
        'btnDone
        '
        Me.btnDone.Location = New System.Drawing.Point(306, 274)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(96, 23)
        Me.btnDone.TabIndex = 10
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'lblID
        '
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(6, 20)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(43, 35)
        Me.lblID.TabIndex = 0
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.lblID)
        Me.GroupBox7.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(58, 63)
        Me.GroupBox7.TabIndex = 16
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "No."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(76, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(326, 55)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(210, 274)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(92, 23)
        Me.btnBack.TabIndex = 18
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'txtAdditional
        '
        Me.txtAdditional.Location = New System.Drawing.Point(126, 272)
        Me.txtAdditional.Multiline = True
        Me.txtAdditional.Name = "txtAdditional"
        Me.txtAdditional.ReadOnly = True
        Me.txtAdditional.Size = New System.Drawing.Size(78, 25)
        Me.txtAdditional.TabIndex = 19
        '
        'AdditionalFlavor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 307)
        Me.Controls.Add(Me.txtAdditional)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "AdditionalFlavor"
        Me.Text = "Additional"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents txtSinker As TextBox
    Friend WithEvents cboSinkers As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cboSyrup As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSyrup As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cboPowder As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPowder As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cboMilk As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMilk As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnDone As Button
    Friend WithEvents lblID As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBack As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSweetQuantity As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPowderQuantity As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtMilkQuantity As TextBox
    Friend WithEvents txtAdditional As TextBox
    Friend WithEvents txtSinkQuantity As TextBox
End Class
