<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSmartHome
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
        Me.picSmartHome = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.cboMonth = New System.Windows.Forms.ComboBox()
        Me.lblSavingsMonth = New System.Windows.Forms.Label()
        Me.btnDisplayStats = New System.Windows.Forms.Button()
        Me.lblSavingsAvg = New System.Windows.Forms.Label()
        Me.lblSavingsMax = New System.Windows.Forms.Label()
        CType(Me.picSmartHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picSmartHome
        '
        Me.picSmartHome.Image = Global.WindowsApp1.My.Resources.Resources.smarthome
        Me.picSmartHome.Location = New System.Drawing.Point(1, 0)
        Me.picSmartHome.Name = "picSmartHome"
        Me.picSmartHome.Size = New System.Drawing.Size(349, 345)
        Me.picSmartHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSmartHome.TabIndex = 0
        Me.picSmartHome.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(416, 51)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(312, 90)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Smart Home" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Electric Savings"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cboMonth
        '
        Me.cboMonth.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMonth.FormattingEnabled = True
        Me.cboMonth.Location = New System.Drawing.Point(473, 185)
        Me.cboMonth.Name = "cboMonth"
        Me.cboMonth.Size = New System.Drawing.Size(207, 33)
        Me.cboMonth.TabIndex = 2
        '
        'lblSavingsMonth
        '
        Me.lblSavingsMonth.AutoSize = True
        Me.lblSavingsMonth.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSavingsMonth.Location = New System.Drawing.Point(213, 373)
        Me.lblSavingsMonth.Name = "lblSavingsMonth"
        Me.lblSavingsMonth.Size = New System.Drawing.Size(81, 25)
        Me.lblSavingsMonth.TabIndex = 3
        Me.lblSavingsMonth.Text = "Label2"
        Me.lblSavingsMonth.Visible = False
        '
        'btnDisplayStats
        '
        Me.btnDisplayStats.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnDisplayStats.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayStats.ForeColor = System.Drawing.Color.White
        Me.btnDisplayStats.Location = New System.Drawing.Point(269, 416)
        Me.btnDisplayStats.Name = "btnDisplayStats"
        Me.btnDisplayStats.Size = New System.Drawing.Size(262, 43)
        Me.btnDisplayStats.TabIndex = 4
        Me.btnDisplayStats.Text = "Display Statistics"
        Me.btnDisplayStats.UseVisualStyleBackColor = False
        Me.btnDisplayStats.Visible = False
        '
        'lblSavingsAvg
        '
        Me.lblSavingsAvg.AutoSize = True
        Me.lblSavingsAvg.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSavingsAvg.Location = New System.Drawing.Point(213, 482)
        Me.lblSavingsAvg.Name = "lblSavingsAvg"
        Me.lblSavingsAvg.Size = New System.Drawing.Size(81, 25)
        Me.lblSavingsAvg.TabIndex = 5
        Me.lblSavingsAvg.Text = "Label2"
        Me.lblSavingsAvg.Visible = False
        '
        'lblSavingsMax
        '
        Me.lblSavingsMax.AutoSize = True
        Me.lblSavingsMax.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSavingsMax.Location = New System.Drawing.Point(130, 532)
        Me.lblSavingsMax.Name = "lblSavingsMax"
        Me.lblSavingsMax.Size = New System.Drawing.Size(81, 25)
        Me.lblSavingsMax.TabIndex = 6
        Me.lblSavingsMax.Text = "Label3"
        Me.lblSavingsMax.Visible = False
        '
        'frmSmartHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Bisque
        Me.ClientSize = New System.Drawing.Size(800, 601)
        Me.Controls.Add(Me.lblSavingsMax)
        Me.Controls.Add(Me.lblSavingsAvg)
        Me.Controls.Add(Me.btnDisplayStats)
        Me.Controls.Add(Me.lblSavingsMonth)
        Me.Controls.Add(Me.cboMonth)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picSmartHome)
        Me.Name = "frmSmartHome"
        Me.Text = "Smart Home Application"
        CType(Me.picSmartHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picSmartHome As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents cboMonth As ComboBox
    Friend WithEvents lblSavingsMonth As Label
    Friend WithEvents btnDisplayStats As Button
    Friend WithEvents lblSavingsAvg As Label
    Friend WithEvents lblSavingsMax As Label
End Class
