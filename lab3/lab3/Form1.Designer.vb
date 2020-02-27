<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.lblDayCount = New System.Windows.Forms.Label()
        Me.lblUnitP = New System.Windows.Forms.Label()
        Me.txtUnitBox = New System.Windows.Forms.TextBox()
        Me.txtEmp1 = New System.Windows.Forms.TextBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtEmp2 = New System.Windows.Forms.TextBox()
        Me.txtEmp3 = New System.Windows.Forms.TextBox()
        Me.lblEmp1Total = New System.Windows.Forms.Label()
        Me.lblEmp2Total = New System.Windows.Forms.Label()
        Me.lblEmp3Total = New System.Windows.Forms.Label()
        Me.lblTotalUnits = New System.Windows.Forms.Label()
        Me.lblEmp1 = New System.Windows.Forms.Label()
        Me.lblEmp2 = New System.Windows.Forms.Label()
        Me.lblEmp3 = New System.Windows.Forms.Label()
        Me.ttEnter = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttReset = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttExit = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttUnits = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblDayCount
        '
        Me.lblDayCount.AutoSize = True
        Me.lblDayCount.Location = New System.Drawing.Point(23, 21)
        Me.lblDayCount.Name = "lblDayCount"
        Me.lblDayCount.Size = New System.Drawing.Size(45, 17)
        Me.lblDayCount.TabIndex = 0
        Me.lblDayCount.Text = "Day 1"
        '
        'lblUnitP
        '
        Me.lblUnitP.AutoSize = True
        Me.lblUnitP.Location = New System.Drawing.Point(23, 58)
        Me.lblUnitP.Name = "lblUnitP"
        Me.lblUnitP.Size = New System.Drawing.Size(44, 17)
        Me.lblUnitP.TabIndex = 1
        Me.lblUnitP.Text = "Units:"
        '
        'txtUnitBox
        '
        Me.txtUnitBox.Location = New System.Drawing.Point(80, 55)
        Me.txtUnitBox.Name = "txtUnitBox"
        Me.txtUnitBox.Size = New System.Drawing.Size(100, 22)
        Me.txtUnitBox.TabIndex = 0
        '
        'txtEmp1
        '
        Me.txtEmp1.BackColor = System.Drawing.SystemColors.Control
        Me.txtEmp1.ForeColor = System.Drawing.SystemColors.MenuText
        Me.txtEmp1.Location = New System.Drawing.Point(25, 107)
        Me.txtEmp1.Multiline = True
        Me.txtEmp1.Name = "txtEmp1"
        Me.txtEmp1.ReadOnly = True
        Me.txtEmp1.Size = New System.Drawing.Size(134, 127)
        Me.txtEmp1.TabIndex = 3
        Me.txtEmp1.TabStop = False
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(26, 296)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(134, 36)
        Me.btnEnter.TabIndex = 1
        Me.btnEnter.Text = "Enter"
        Me.ttEnter.SetToolTip(Me.btnEnter, "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(166, 296)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(134, 36)
        Me.btnReset.TabIndex = 2
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(306, 296)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(134, 36)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtEmp2
        '
        Me.txtEmp2.Location = New System.Drawing.Point(165, 107)
        Me.txtEmp2.Multiline = True
        Me.txtEmp2.Name = "txtEmp2"
        Me.txtEmp2.ReadOnly = True
        Me.txtEmp2.Size = New System.Drawing.Size(134, 127)
        Me.txtEmp2.TabIndex = 7
        Me.txtEmp2.TabStop = False
        '
        'txtEmp3
        '
        Me.txtEmp3.Location = New System.Drawing.Point(306, 107)
        Me.txtEmp3.Multiline = True
        Me.txtEmp3.Name = "txtEmp3"
        Me.txtEmp3.ReadOnly = True
        Me.txtEmp3.Size = New System.Drawing.Size(134, 127)
        Me.txtEmp3.TabIndex = 8
        Me.txtEmp3.TabStop = False
        '
        'lblEmp1Total
        '
        Me.lblEmp1Total.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmp1Total.Location = New System.Drawing.Point(25, 237)
        Me.lblEmp1Total.Name = "lblEmp1Total"
        Me.lblEmp1Total.Size = New System.Drawing.Size(134, 23)
        Me.lblEmp1Total.TabIndex = 9
        Me.lblEmp1Total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmp2Total
        '
        Me.lblEmp2Total.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmp2Total.Location = New System.Drawing.Point(165, 237)
        Me.lblEmp2Total.Name = "lblEmp2Total"
        Me.lblEmp2Total.Size = New System.Drawing.Size(134, 23)
        Me.lblEmp2Total.TabIndex = 10
        Me.lblEmp2Total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmp3Total
        '
        Me.lblEmp3Total.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmp3Total.Location = New System.Drawing.Point(306, 237)
        Me.lblEmp3Total.Name = "lblEmp3Total"
        Me.lblEmp3Total.Size = New System.Drawing.Size(134, 23)
        Me.lblEmp3Total.TabIndex = 11
        Me.lblEmp3Total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalUnits
        '
        Me.lblTotalUnits.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalUnits.Location = New System.Drawing.Point(25, 270)
        Me.lblTotalUnits.Name = "lblTotalUnits"
        Me.lblTotalUnits.Size = New System.Drawing.Size(415, 23)
        Me.lblTotalUnits.TabIndex = 12
        Me.lblTotalUnits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmp1
        '
        Me.lblEmp1.AutoSize = True
        Me.lblEmp1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmp1.Location = New System.Drawing.Point(54, 87)
        Me.lblEmp1.Name = "lblEmp1"
        Me.lblEmp1.Size = New System.Drawing.Size(92, 17)
        Me.lblEmp1.TabIndex = 13
        Me.lblEmp1.Text = "Employee 1"
        '
        'lblEmp2
        '
        Me.lblEmp2.AutoSize = True
        Me.lblEmp2.Location = New System.Drawing.Point(192, 87)
        Me.lblEmp2.Name = "lblEmp2"
        Me.lblEmp2.Size = New System.Drawing.Size(82, 17)
        Me.lblEmp2.TabIndex = 14
        Me.lblEmp2.Text = "Employee 2"
        '
        'lblEmp3
        '
        Me.lblEmp3.AutoSize = True
        Me.lblEmp3.Location = New System.Drawing.Point(329, 87)
        Me.lblEmp3.Name = "lblEmp3"
        Me.lblEmp3.Size = New System.Drawing.Size(82, 17)
        Me.lblEmp3.TabIndex = 15
        Me.lblEmp3.Text = "Employee 3"
        '
        'ttEnter
        '
        Me.ttEnter.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ttEnter.ToolTipTitle = "Enter Button"
        '
        'ttReset
        '
        Me.ttReset.ToolTipTitle = "Reset Button"
        '
        'ttExit
        '
        Me.ttExit.ToolTipTitle = "Exit Button"
        '
        'ttUnits
        '
        Me.ttUnits.ToolTipTitle = "Unit Entry Box"
        '
        'Form1
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(481, 353)
        Me.Controls.Add(Me.lblEmp3)
        Me.Controls.Add(Me.lblEmp2)
        Me.Controls.Add(Me.lblEmp1)
        Me.Controls.Add(Me.lblTotalUnits)
        Me.Controls.Add(Me.lblEmp3Total)
        Me.Controls.Add(Me.lblEmp2Total)
        Me.Controls.Add(Me.lblEmp1Total)
        Me.Controls.Add(Me.txtEmp3)
        Me.Controls.Add(Me.txtEmp2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.txtEmp1)
        Me.Controls.Add(Me.txtUnitBox)
        Me.Controls.Add(Me.lblUnitP)
        Me.Controls.Add(Me.lblDayCount)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDayCount As Label
    Friend WithEvents lblUnitP As Label
    Friend WithEvents txtUnitBox As TextBox
    Friend WithEvents txtEmp1 As TextBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtEmp2 As TextBox
    Friend WithEvents txtEmp3 As TextBox
    Friend WithEvents lblEmp1Total As Label
    Friend WithEvents lblEmp2Total As Label
    Friend WithEvents lblEmp3Total As Label
    Friend WithEvents lblTotalUnits As Label
    Friend WithEvents lblEmp1 As Label
    Friend WithEvents lblEmp2 As Label
    Friend WithEvents lblEmp3 As Label
    Friend WithEvents ttEnter As ToolTip
    Friend WithEvents ttReset As ToolTip
    Friend WithEvents ttExit As ToolTip
    Friend WithEvents ttUnits As ToolTip
End Class
