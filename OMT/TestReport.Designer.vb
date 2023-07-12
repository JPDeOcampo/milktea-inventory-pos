<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TestReport
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.datetimeFrom = New System.Windows.Forms.DateTimePicker()
        Me.datetimeTo = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.salesreport1 = New OMT.salesreport()
        Me.salesreport2 = New OMT.salesreport()
        Me.salesreport3 = New OMT.salesreport()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSGenerate = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(12, 53)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1370, 610)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'btnGenerate
        '
        Me.btnGenerate.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerate.Location = New System.Drawing.Point(621, 24)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(190, 23)
        Me.btnGenerate.TabIndex = 1
        Me.btnGenerate.Text = "FLAVOR SALES REPORT"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'datetimeFrom
        '
        Me.datetimeFrom.Location = New System.Drawing.Point(91, 27)
        Me.datetimeFrom.Name = "datetimeFrom"
        Me.datetimeFrom.Size = New System.Drawing.Size(200, 20)
        Me.datetimeFrom.TabIndex = 2
        '
        'datetimeTo
        '
        Me.datetimeTo.Location = New System.Drawing.Point(379, 27)
        Me.datetimeTo.Name = "datetimeTo"
        Me.datetimeTo.Size = New System.Drawing.Size(200, 20)
        Me.datetimeTo.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "From:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(317, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 24)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "To:"
        '
        'btnSGenerate
        '
        Me.btnSGenerate.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSGenerate.Location = New System.Drawing.Point(817, 24)
        Me.btnSGenerate.Name = "btnSGenerate"
        Me.btnSGenerate.Size = New System.Drawing.Size(203, 23)
        Me.btnSGenerate.TabIndex = 6
        Me.btnSGenerate.Text = "FLAVOR SALES REPORT"
        Me.btnSGenerate.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1026, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(164, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "STOCKS REPORT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TestReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1195, 749)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnSGenerate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.datetimeTo)
        Me.Controls.Add(Me.datetimeFrom)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "TestReport"
        Me.Text = "TestReport"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents salesreport1 As salesreport
    Friend WithEvents salesreport2 As salesreport
    Friend WithEvents salesreport3 As salesreport
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnGenerate As Button
    Friend WithEvents datetimeFrom As DateTimePicker
    Friend WithEvents datetimeTo As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSGenerate As Button
    Friend WithEvents Button1 As Button
End Class
