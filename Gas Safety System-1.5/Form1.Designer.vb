<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Control_panel
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
        Me.WB_display = New System.Windows.Forms.WebBrowser()
        Me.Cmb_Ports = New System.Windows.Forms.ComboBox()
        Me.Com_arduino = New System.IO.Ports.SerialPort(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TextBoxGPS = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBoxRefCO2 = New System.Windows.Forms.TextBox()
        Me.TextBoxRefCO = New System.Windows.Forms.TextBox()
        Me.TextBoxRefH2S = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxCO2Batt = New System.Windows.Forms.TextBox()
        Me.TextBoxCoBatt = New System.Windows.Forms.TextBox()
        Me.TextBoxH2SBatt = New System.Windows.Forms.TextBox()
        Me.TextBoxCO2 = New System.Windows.Forms.TextBox()
        Me.TextBoxCO = New System.Windows.Forms.TextBox()
        Me.TextBoxH2S = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'WB_display
        '
        Me.WB_display.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WB_display.Location = New System.Drawing.Point(0, 0)
        Me.WB_display.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WB_display.Name = "WB_display"
        Me.WB_display.Size = New System.Drawing.Size(680, 386)
        Me.WB_display.TabIndex = 0
        Me.WB_display.Url = New System.Uri("", System.UriKind.Relative)
        '
        'Cmb_Ports
        '
        Me.Cmb_Ports.FormattingEnabled = True
        Me.Cmb_Ports.Location = New System.Drawing.Point(72, 12)
        Me.Cmb_Ports.Name = "Cmb_Ports"
        Me.Cmb_Ports.Size = New System.Drawing.Size(108, 21)
        Me.Cmb_Ports.TabIndex = 0
        '
        'Com_arduino
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Select Port"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(72, 51)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(109, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(186, 48)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(53, 25)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "send"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Command:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel1MinSize = 20
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.WB_display)
        Me.SplitContainer1.Size = New System.Drawing.Size(981, 386)
        Me.SplitContainer1.SplitterDistance = 297
        Me.SplitContainer1.TabIndex = 10
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 99)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(297, 287)
        Me.Panel2.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.TextBoxGPS)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 114)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(297, 173)
        Me.Panel4.TabIndex = 14
        '
        'TextBoxGPS
        '
        Me.TextBoxGPS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxGPS.Location = New System.Drawing.Point(0, 0)
        Me.TextBoxGPS.Multiline = True
        Me.TextBoxGPS.Name = "TextBoxGPS"
        Me.TextBoxGPS.ReadOnly = True
        Me.TextBoxGPS.Size = New System.Drawing.Size(297, 173)
        Me.TextBoxGPS.TabIndex = 12
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.TextBoxRefCO2)
        Me.Panel3.Controls.Add(Me.TextBoxRefCO)
        Me.Panel3.Controls.Add(Me.TextBoxRefH2S)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.TextBoxCO2Batt)
        Me.Panel3.Controls.Add(Me.TextBoxCoBatt)
        Me.Panel3.Controls.Add(Me.TextBoxH2SBatt)
        Me.Panel3.Controls.Add(Me.TextBoxCO2)
        Me.Panel3.Controls.Add(Me.TextBoxCO)
        Me.Panel3.Controls.Add(Me.TextBoxH2S)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(297, 114)
        Me.Panel3.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(215, 3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Refence"
        '
        'TextBoxRefCO2
        '
        Me.TextBoxRefCO2.Location = New System.Drawing.Point(212, 74)
        Me.TextBoxRefCO2.Name = "TextBoxRefCO2"
        Me.TextBoxRefCO2.Size = New System.Drawing.Size(55, 20)
        Me.TextBoxRefCO2.TabIndex = 13
        Me.TextBoxRefCO2.Text = "2"
        Me.TextBoxRefCO2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxRefCO
        '
        Me.TextBoxRefCO.Location = New System.Drawing.Point(212, 48)
        Me.TextBoxRefCO.Name = "TextBoxRefCO"
        Me.TextBoxRefCO.Size = New System.Drawing.Size(55, 20)
        Me.TextBoxRefCO.TabIndex = 12
        Me.TextBoxRefCO.Text = "2"
        Me.TextBoxRefCO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxRefH2S
        '
        Me.TextBoxRefH2S.Location = New System.Drawing.Point(212, 22)
        Me.TextBoxRefH2S.Name = "TextBoxRefH2S"
        Me.TextBoxRefH2S.Size = New System.Drawing.Size(55, 20)
        Me.TextBoxRefH2S.TabIndex = 11
        Me.TextBoxRefH2S.Text = "5"
        Me.TextBoxRefH2S.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(127, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Battary Level"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(55, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Gas Reading"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "CO2:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "CO:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "H2S:"
        '
        'TextBoxCO2Batt
        '
        Me.TextBoxCO2Batt.Location = New System.Drawing.Point(132, 75)
        Me.TextBoxCO2Batt.Name = "TextBoxCO2Batt"
        Me.TextBoxCO2Batt.ReadOnly = True
        Me.TextBoxCO2Batt.Size = New System.Drawing.Size(55, 20)
        Me.TextBoxCO2Batt.TabIndex = 55
        '
        'TextBoxCoBatt
        '
        Me.TextBoxCoBatt.Location = New System.Drawing.Point(132, 49)
        Me.TextBoxCoBatt.Name = "TextBoxCoBatt"
        Me.TextBoxCoBatt.ReadOnly = True
        Me.TextBoxCoBatt.Size = New System.Drawing.Size(55, 20)
        Me.TextBoxCoBatt.TabIndex = 44
        '
        'TextBoxH2SBatt
        '
        Me.TextBoxH2SBatt.Location = New System.Drawing.Point(132, 23)
        Me.TextBoxH2SBatt.Name = "TextBoxH2SBatt"
        Me.TextBoxH2SBatt.ReadOnly = True
        Me.TextBoxH2SBatt.Size = New System.Drawing.Size(55, 20)
        Me.TextBoxH2SBatt.TabIndex = 33
        '
        'TextBoxCO2
        '
        Me.TextBoxCO2.Location = New System.Drawing.Point(57, 75)
        Me.TextBoxCO2.Name = "TextBoxCO2"
        Me.TextBoxCO2.ReadOnly = True
        Me.TextBoxCO2.Size = New System.Drawing.Size(63, 20)
        Me.TextBoxCO2.TabIndex = 23
        '
        'TextBoxCO
        '
        Me.TextBoxCO.Location = New System.Drawing.Point(57, 49)
        Me.TextBoxCO.Name = "TextBoxCO"
        Me.TextBoxCO.ReadOnly = True
        Me.TextBoxCO.Size = New System.Drawing.Size(63, 20)
        Me.TextBoxCO.TabIndex = 11
        '
        'TextBoxH2S
        '
        Me.TextBoxH2S.Location = New System.Drawing.Point(57, 23)
        Me.TextBoxH2S.Name = "TextBoxH2S"
        Me.TextBoxH2S.ReadOnly = True
        Me.TextBoxH2S.Size = New System.Drawing.Size(63, 20)
        Me.TextBoxH2S.TabIndex = 110
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Cmb_Ports)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(297, 99)
        Me.Panel1.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "GPS data"
        '
        'frm_Control_panel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(981, 386)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frm_Control_panel"
        Me.Text = "Safty System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents WB_display As System.Windows.Forms.WebBrowser
    Friend WithEvents Cmb_Ports As System.Windows.Forms.ComboBox
    Friend WithEvents Com_arduino As System.IO.Ports.SerialPort
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TextBoxGPS As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents TextBoxCO2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCO As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxH2S As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxCO2Batt As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCoBatt As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxH2SBatt As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBoxRefCO2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxRefCO As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxRefH2S As System.Windows.Forms.TextBox

End Class
