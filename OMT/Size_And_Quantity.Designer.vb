<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Size_And_Quantity
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
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtLarge = New System.Windows.Forms.TextBox()
        Me.txtMedium = New System.Windows.Forms.TextBox()
        Me.txtQuantityLarge = New System.Windows.Forms.TextBox()
        Me.txtQuantityMedium = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtSizeLarge = New System.Windows.Forms.TextBox()
        Me.txtSizeMedium = New System.Windows.Forms.TextBox()
        Me.chkMedium = New System.Windows.Forms.CheckBox()
        Me.chkLarge = New System.Windows.Forms.CheckBox()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtLarge)
        Me.GroupBox6.Controls.Add(Me.txtMedium)
        Me.GroupBox6.Controls.Add(Me.txtQuantityLarge)
        Me.GroupBox6.Controls.Add(Me.txtQuantityMedium)
        Me.GroupBox6.Controls.Add(Me.Label7)
        Me.GroupBox6.Controls.Add(Me.Label6)
        Me.GroupBox6.Location = New System.Drawing.Point(210, 12)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(192, 67)
        Me.GroupBox6.TabIndex = 13
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Quantity"
        '
        'txtLarge
        '
        Me.txtLarge.Location = New System.Drawing.Point(140, 12)
        Me.txtLarge.Name = "txtLarge"
        Me.txtLarge.Size = New System.Drawing.Size(46, 20)
        Me.txtLarge.TabIndex = 9
        '
        'txtMedium
        '
        Me.txtMedium.Location = New System.Drawing.Point(51, 12)
        Me.txtMedium.Name = "txtMedium"
        Me.txtMedium.Size = New System.Drawing.Size(46, 20)
        Me.txtMedium.TabIndex = 8
        '
        'txtQuantityLarge
        '
        Me.txtQuantityLarge.Location = New System.Drawing.Point(109, 37)
        Me.txtQuantityLarge.Name = "txtQuantityLarge"
        Me.txtQuantityLarge.ReadOnly = True
        Me.txtQuantityLarge.Size = New System.Drawing.Size(77, 20)
        Me.txtQuantityLarge.TabIndex = 7
        '
        'txtQuantityMedium
        '
        Me.txtQuantityMedium.Location = New System.Drawing.Point(20, 37)
        Me.txtQuantityMedium.Name = "txtQuantityMedium"
        Me.txtQuantityMedium.ReadOnly = True
        Me.txtQuantityMedium.Size = New System.Drawing.Size(77, 20)
        Me.txtQuantityMedium.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(103, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Large:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Medium:"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.lblID)
        Me.GroupBox7.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(55, 67)
        Me.GroupBox7.TabIndex = 15
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "No."
        '
        'lblID
        '
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(6, 19)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(43, 38)
        Me.lblID.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtSizeLarge)
        Me.GroupBox5.Controls.Add(Me.txtSizeMedium)
        Me.GroupBox5.Controls.Add(Me.chkMedium)
        Me.GroupBox5.Controls.Add(Me.chkLarge)
        Me.GroupBox5.Location = New System.Drawing.Point(67, 12)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(137, 67)
        Me.GroupBox5.TabIndex = 14
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Select Size"
        '
        'txtSizeLarge
        '
        Me.txtSizeLarge.Location = New System.Drawing.Point(69, 37)
        Me.txtSizeLarge.Name = "txtSizeLarge"
        Me.txtSizeLarge.ReadOnly = True
        Me.txtSizeLarge.Size = New System.Drawing.Size(55, 20)
        Me.txtSizeLarge.TabIndex = 3
        '
        'txtSizeMedium
        '
        Me.txtSizeMedium.Location = New System.Drawing.Point(6, 37)
        Me.txtSizeMedium.Name = "txtSizeMedium"
        Me.txtSizeMedium.ReadOnly = True
        Me.txtSizeMedium.Size = New System.Drawing.Size(55, 20)
        Me.txtSizeMedium.TabIndex = 2
        '
        'chkMedium
        '
        Me.chkMedium.AutoSize = True
        Me.chkMedium.Location = New System.Drawing.Point(6, 19)
        Me.chkMedium.Name = "chkMedium"
        Me.chkMedium.Size = New System.Drawing.Size(66, 17)
        Me.chkMedium.TabIndex = 0
        Me.chkMedium.Text = "Medium "
        Me.chkMedium.UseVisualStyleBackColor = True
        '
        'chkLarge
        '
        Me.chkLarge.AutoSize = True
        Me.chkLarge.Location = New System.Drawing.Point(70, 17)
        Me.chkLarge.Name = "chkLarge"
        Me.chkLarge.Size = New System.Drawing.Size(56, 17)
        Me.chkLarge.TabIndex = 1
        Me.chkLarge.Text = "Large "
        Me.chkLarge.UseVisualStyleBackColor = True
        '
        'btnDone
        '
        Me.btnDone.Location = New System.Drawing.Point(210, 85)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(97, 23)
        Me.btnDone.TabIndex = 18
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(126, 82)
        Me.txtTotal.Multiline = True
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(78, 25)
        Me.txtTotal.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Total Price:"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(313, 84)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(89, 23)
        Me.btnClear.TabIndex = 19
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Size_And_Quantity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 119)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox6)
        Me.Name = "Size_And_Quantity"
        Me.Text = "Size and Quantity"
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents txtQuantityLarge As TextBox
    Friend WithEvents txtQuantityMedium As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents lblID As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents txtSizeLarge As TextBox
    Friend WithEvents txtSizeMedium As TextBox
    Friend WithEvents chkMedium As CheckBox
    Friend WithEvents chkLarge As CheckBox
    Friend WithEvents btnDone As Button
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents txtLarge As TextBox
    Friend WithEvents txtMedium As TextBox
End Class
