<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MDIParent1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIParent1))
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerAccountManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.POSPressF2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventoryMngmnt2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportPressF4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripUserAccount = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripPOS = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripInventory = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.DailyReportToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RangeReportToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerTransactionReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.StatusStrip.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(632, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintSetupToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(37, 20)
        Me.FileMenu.Text = "&File"
        '
        'PrintSetupToolStripMenuItem
        '
        Me.PrintSetupToolStripMenuItem.Image = CType(resources.GetObject("PrintSetupToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintSetupToolStripMenuItem.Name = "PrintSetupToolStripMenuItem"
        Me.PrintSetupToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.PrintSetupToolStripMenuItem.Text = "&Log Off"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = CType(resources.GetObject("ExitToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ManagementToolStripMenuItem
        '
        Me.ManagementToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserAccountToolStripMenuItem, Me.CustomerAccountManagementToolStripMenuItem})
        Me.ManagementToolStripMenuItem.Name = "ManagementToolStripMenuItem"
        Me.ManagementToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.ManagementToolStripMenuItem.Text = "&Management"
        '
        'UserAccountToolStripMenuItem
        '
        Me.UserAccountToolStripMenuItem.Name = "UserAccountToolStripMenuItem"
        Me.UserAccountToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7
        Me.UserAccountToolStripMenuItem.Size = New System.Drawing.Size(258, 22)
        Me.UserAccountToolStripMenuItem.Text = "&User Account Management"
        '
        'CustomerAccountManagementToolStripMenuItem
        '
        Me.CustomerAccountManagementToolStripMenuItem.Image = CType(resources.GetObject("CustomerAccountManagementToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CustomerAccountManagementToolStripMenuItem.Name = "CustomerAccountManagementToolStripMenuItem"
        Me.CustomerAccountManagementToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8
        Me.CustomerAccountManagementToolStripMenuItem.Size = New System.Drawing.Size(258, 22)
        Me.CustomerAccountManagementToolStripMenuItem.Text = "Supplier Account Management"
        '
        'POSPressF2
        '
        Me.POSPressF2.Name = "POSPressF2"
        Me.POSPressF2.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.POSPressF2.Size = New System.Drawing.Size(41, 20)
        Me.POSPressF2.Text = "&POS"
        '
        'InventoryMngmnt2
        '
        Me.InventoryMngmnt2.Name = "InventoryMngmnt2"
        Me.InventoryMngmnt2.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.InventoryMngmnt2.Size = New System.Drawing.Size(143, 20)
        Me.InventoryMngmnt2.Text = "&Inventory Management"
        '
        'ReportPressF4
        '
        Me.ReportPressF4.Name = "ReportPressF4"
        Me.ReportPressF4.Size = New System.Drawing.Size(54, 20)
        Me.ReportPressF4.Text = "Report"
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.ManagementToolStripMenuItem, Me.POSPressF2, Me.InventoryMngmnt2, Me.ReportPressF4})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip.TabIndex = 9
        Me.MenuStrip.Text = "MenuStrip"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'ToolStripUserAccount
        '
        Me.ToolStripUserAccount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripUserAccount.Image = CType(resources.GetObject("ToolStripUserAccount.Image"), System.Drawing.Image)
        Me.ToolStripUserAccount.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripUserAccount.Name = "ToolStripUserAccount"
        Me.ToolStripUserAccount.Size = New System.Drawing.Size(28, 28)
        Me.ToolStripUserAccount.Text = "User Account Management"
        '
        'ToolStripPOS
        '
        Me.ToolStripPOS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripPOS.Image = CType(resources.GetObject("ToolStripPOS.Image"), System.Drawing.Image)
        Me.ToolStripPOS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripPOS.Name = "ToolStripPOS"
        Me.ToolStripPOS.Size = New System.Drawing.Size(28, 28)
        Me.ToolStripPOS.Text = "POS"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'ToolStripInventory
        '
        Me.ToolStripInventory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripInventory.Image = CType(resources.GetObject("ToolStripInventory.Image"), System.Drawing.Image)
        Me.ToolStripInventory.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripInventory.Name = "ToolStripInventory"
        Me.ToolStripInventory.Size = New System.Drawing.Size(28, 28)
        Me.ToolStripInventory.Text = "Inventory Management"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DailyReportToolStripMenuItem1, Me.RangeReportToolStripMenuItem1, Me.CustomerTransactionReportToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(37, 28)
        Me.ToolStripDropDownButton1.Text = "ToolStripDropDownButton1"
        '
        'DailyReportToolStripMenuItem1
        '
        Me.DailyReportToolStripMenuItem1.Name = "DailyReportToolStripMenuItem1"
        Me.DailyReportToolStripMenuItem1.Size = New System.Drawing.Size(228, 22)
        Me.DailyReportToolStripMenuItem1.Text = "Daily Report"
        '
        'RangeReportToolStripMenuItem1
        '
        Me.RangeReportToolStripMenuItem1.Name = "RangeReportToolStripMenuItem1"
        Me.RangeReportToolStripMenuItem1.Size = New System.Drawing.Size(228, 22)
        Me.RangeReportToolStripMenuItem1.Text = "Range Report"
        '
        'CustomerTransactionReportToolStripMenuItem
        '
        Me.CustomerTransactionReportToolStripMenuItem.Name = "CustomerTransactionReportToolStripMenuItem"
        Me.CustomerTransactionReportToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.CustomerTransactionReportToolStripMenuItem.Text = "Customer Transaction Report"
        '
        'ToolStrip
        '
        Me.ToolStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.ToolStripUserAccount, Me.ToolStripPOS, Me.ToolStripSeparator2, Me.ToolStripInventory, Me.ToolStripDropDownButton1})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(632, 31)
        Me.ToolStrip.TabIndex = 10
        Me.ToolStrip.Text = "ToolStrip"
        '
        'MDIParent1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.Name = "MDIParent1"
        Me.Text = "OMT Sales Inventory"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents FileMenu As ToolStripMenuItem
    Friend WithEvents PrintSetupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserAccountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerAccountManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents POSPressF2 As ToolStripMenuItem
    Friend WithEvents InventoryMngmnt2 As ToolStripMenuItem
    Friend WithEvents ReportPressF4 As ToolStripMenuItem
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripUserAccount As ToolStripButton
    Friend WithEvents ToolStripPOS As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripInventory As ToolStripButton
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents DailyReportToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RangeReportToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CustomerTransactionReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip As ToolStrip
End Class
