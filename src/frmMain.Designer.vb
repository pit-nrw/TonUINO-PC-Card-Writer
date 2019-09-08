<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.SerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.lbMagic = New System.Windows.Forms.Label()
        Me.lbFolder = New System.Windows.Forms.Label()
        Me.lbVersion = New System.Windows.Forms.Label()
        Me.lbVonTrack = New System.Windows.Forms.Label()
        Me.lbBisTrack = New System.Windows.Forms.Label()
        Me.lbMode = New System.Windows.Forms.Label()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.btnWrite = New System.Windows.Forms.Button()
        Me.cbModi = New System.Windows.Forms.ComboBox()
        Me.lbModeNeu = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbMagic = New System.Windows.Forms.TextBox()
        Me.tbVersion = New System.Windows.Forms.TextBox()
        Me.tbFolder = New System.Windows.Forms.TextBox()
        Me.tbVonTrack = New System.Windows.Forms.TextBox()
        Me.tbBisTrack = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cbModifier = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.grpComPort = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbPort = New System.Windows.Forms.Label()
        Me.btnPorts = New System.Windows.Forms.Button()
        Me.Ports = New System.Windows.Forms.ListBox()
        Me.grpCardData = New System.Windows.Forms.GroupBox()
        Me.chkModifier = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.grpComPort.SuspendLayout()
        Me.grpCardData.SuspendLayout()
        Me.SuspendLayout()
        '
        'SerialPort
        '
        '
        'lbMagic
        '
        Me.lbMagic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbMagic.Location = New System.Drawing.Point(73, 46)
        Me.lbMagic.Name = "lbMagic"
        Me.lbMagic.Size = New System.Drawing.Size(131, 20)
        Me.lbMagic.TabIndex = 3
        '
        'lbFolder
        '
        Me.lbFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbFolder.Location = New System.Drawing.Point(73, 122)
        Me.lbFolder.Name = "lbFolder"
        Me.lbFolder.Size = New System.Drawing.Size(131, 20)
        Me.lbFolder.TabIndex = 4
        '
        'lbVersion
        '
        Me.lbVersion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbVersion.Location = New System.Drawing.Point(73, 83)
        Me.lbVersion.Name = "lbVersion"
        Me.lbVersion.Size = New System.Drawing.Size(131, 20)
        Me.lbVersion.TabIndex = 5
        '
        'lbVonTrack
        '
        Me.lbVonTrack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbVonTrack.Location = New System.Drawing.Point(73, 199)
        Me.lbVonTrack.Name = "lbVonTrack"
        Me.lbVonTrack.Size = New System.Drawing.Size(131, 20)
        Me.lbVonTrack.TabIndex = 6
        '
        'lbBisTrack
        '
        Me.lbBisTrack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbBisTrack.Location = New System.Drawing.Point(73, 237)
        Me.lbBisTrack.Name = "lbBisTrack"
        Me.lbBisTrack.Size = New System.Drawing.Size(131, 20)
        Me.lbBisTrack.TabIndex = 7
        '
        'lbMode
        '
        Me.lbMode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbMode.Location = New System.Drawing.Point(73, 161)
        Me.lbMode.Name = "lbMode"
        Me.lbMode.Size = New System.Drawing.Size(131, 20)
        Me.lbMode.TabIndex = 8
        '
        'btnCopy
        '
        Me.btnCopy.Location = New System.Drawing.Point(152, 273)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(161, 38)
        Me.btnCopy.TabIndex = 9
        Me.btnCopy.Text = "-> Werte übernehmen ->"
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'btnWrite
        '
        Me.btnWrite.Location = New System.Drawing.Point(512, 273)
        Me.btnWrite.Name = "btnWrite"
        Me.btnWrite.Size = New System.Drawing.Size(145, 38)
        Me.btnWrite.TabIndex = 16
        Me.btnWrite.Text = "Karte schreiben"
        Me.btnWrite.UseVisualStyleBackColor = True
        '
        'cbModi
        '
        Me.cbModi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbModi.FormattingEnabled = True
        Me.cbModi.Items.AddRange(New Object() {"Hörspiel - zufällige Datei aus Ordner", "Album - kompletter Ordner in Reihe", "Party - kompletter Ordner zufällig", "Einzel - eine Datei aus Ordner", "Hörbuch - kompletter Ordner in Reihe mit Speichern", "Admin - Elternmenu aufrufen", "Hörspiel von .. bis", "Album von .. bis", "Party von .. bis"})
        Me.cbModi.Location = New System.Drawing.Point(347, 161)
        Me.cbModi.Name = "cbModi"
        Me.cbModi.Size = New System.Drawing.Size(310, 21)
        Me.cbModi.TabIndex = 17
        '
        'lbModeNeu
        '
        Me.lbModeNeu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbModeNeu.Location = New System.Drawing.Point(294, 161)
        Me.lbModeNeu.Name = "lbModeNeu"
        Me.lbModeNeu.Size = New System.Drawing.Size(42, 20)
        Me.lbModeNeu.TabIndex = 18
        Me.lbModeNeu.Text = "01"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(70, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Kartendaten aktuell"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(291, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Kartendaten neu"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(344, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Auswahl des Modus"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Token"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Version"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 121)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Ordner"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 198)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "von Datei"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 238)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "bis Datei"
        '
        'tbMagic
        '
        Me.tbMagic.Location = New System.Drawing.Point(293, 46)
        Me.tbMagic.Name = "tbMagic"
        Me.tbMagic.Size = New System.Drawing.Size(69, 20)
        Me.tbMagic.TabIndex = 33
        Me.tbMagic.Text = "1337b347"
        '
        'tbVersion
        '
        Me.tbVersion.Location = New System.Drawing.Point(294, 83)
        Me.tbVersion.Name = "tbVersion"
        Me.tbVersion.Size = New System.Drawing.Size(19, 20)
        Me.tbVersion.TabIndex = 34
        Me.tbVersion.Text = "2"
        '
        'tbFolder
        '
        Me.tbFolder.Location = New System.Drawing.Point(294, 120)
        Me.tbFolder.Name = "tbFolder"
        Me.tbFolder.Size = New System.Drawing.Size(38, 20)
        Me.tbFolder.TabIndex = 35
        Me.tbFolder.Text = "1"
        '
        'tbVonTrack
        '
        Me.tbVonTrack.Location = New System.Drawing.Point(293, 197)
        Me.tbVonTrack.Name = "tbVonTrack"
        Me.tbVonTrack.Size = New System.Drawing.Size(41, 20)
        Me.tbVonTrack.TabIndex = 36
        Me.tbVonTrack.Text = "0"
        '
        'tbBisTrack
        '
        Me.tbBisTrack.Location = New System.Drawing.Point(293, 237)
        Me.tbBisTrack.Name = "tbBisTrack"
        Me.tbBisTrack.Size = New System.Drawing.Size(41, 20)
        Me.tbBisTrack.TabIndex = 37
        Me.tbBisTrack.Text = "0"
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'cbModifier
        '
        Me.cbModifier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbModifier.FormattingEnabled = True
        Me.cbModifier.Items.AddRange(New Object() {"Schlummermode - abschalten nach Zeit", "Stoptanz - zufällige Unterbechung", "Sperre - Box sperren", "Krabblermode - Tasten sperren", "Kindergartenmode - nur ganze Titel abspielen", "Einzelmode - einen Titel wiederholen"})
        Me.cbModifier.Location = New System.Drawing.Point(347, 161)
        Me.cbModifier.Name = "cbModifier"
        Me.cbModifier.Size = New System.Drawing.Size(310, 21)
        Me.cbModifier.TabIndex = 38
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(344, 200)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(143, 13)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Minuten bei Schlummermode"
        '
        'grpComPort
        '
        Me.grpComPort.Controls.Add(Me.Label13)
        Me.grpComPort.Controls.Add(Me.Label11)
        Me.grpComPort.Controls.Add(Me.Label4)
        Me.grpComPort.Controls.Add(Me.lbPort)
        Me.grpComPort.Controls.Add(Me.btnPorts)
        Me.grpComPort.Controls.Add(Me.Ports)
        Me.grpComPort.Location = New System.Drawing.Point(13, 13)
        Me.grpComPort.Name = "grpComPort"
        Me.grpComPort.Size = New System.Drawing.Size(322, 131)
        Me.grpComPort.TabIndex = 40
        Me.grpComPort.TabStop = False
        Me.grpComPort.Text = "Serielle Schnittstelle"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(13, 53)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 38)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Port selektieren zum Verbinden."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 38)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Verfügbare Ports:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Aktueller Port:"
        '
        'lbPort
        '
        Me.lbPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbPort.Location = New System.Drawing.Point(101, 15)
        Me.lbPort.Name = "lbPort"
        Me.lbPort.Size = New System.Drawing.Size(131, 20)
        Me.lbPort.TabIndex = 25
        '
        'btnPorts
        '
        Me.btnPorts.Location = New System.Drawing.Point(238, 93)
        Me.btnPorts.Name = "btnPorts"
        Me.btnPorts.Size = New System.Drawing.Size(75, 27)
        Me.btnPorts.TabIndex = 24
        Me.btnPorts.Text = "Aktualisieren"
        Me.btnPorts.UseVisualStyleBackColor = True
        '
        'Ports
        '
        Me.Ports.FormattingEnabled = True
        Me.Ports.Location = New System.Drawing.Point(101, 38)
        Me.Ports.Name = "Ports"
        Me.Ports.Size = New System.Drawing.Size(131, 82)
        Me.Ports.TabIndex = 23
        '
        'grpCardData
        '
        Me.grpCardData.Controls.Add(Me.chkModifier)
        Me.grpCardData.Controls.Add(Me.Label12)
        Me.grpCardData.Controls.Add(Me.Label1)
        Me.grpCardData.Controls.Add(Me.Label10)
        Me.grpCardData.Controls.Add(Me.lbMagic)
        Me.grpCardData.Controls.Add(Me.lbFolder)
        Me.grpCardData.Controls.Add(Me.tbBisTrack)
        Me.grpCardData.Controls.Add(Me.lbVersion)
        Me.grpCardData.Controls.Add(Me.tbVonTrack)
        Me.grpCardData.Controls.Add(Me.lbVonTrack)
        Me.grpCardData.Controls.Add(Me.tbFolder)
        Me.grpCardData.Controls.Add(Me.lbBisTrack)
        Me.grpCardData.Controls.Add(Me.tbVersion)
        Me.grpCardData.Controls.Add(Me.lbMode)
        Me.grpCardData.Controls.Add(Me.tbMagic)
        Me.grpCardData.Controls.Add(Me.btnCopy)
        Me.grpCardData.Controls.Add(Me.Label9)
        Me.grpCardData.Controls.Add(Me.btnWrite)
        Me.grpCardData.Controls.Add(Me.Label8)
        Me.grpCardData.Controls.Add(Me.Label7)
        Me.grpCardData.Controls.Add(Me.lbModeNeu)
        Me.grpCardData.Controls.Add(Me.Label6)
        Me.grpCardData.Controls.Add(Me.Label2)
        Me.grpCardData.Controls.Add(Me.Label5)
        Me.grpCardData.Controls.Add(Me.Label3)
        Me.grpCardData.Controls.Add(Me.cbModifier)
        Me.grpCardData.Controls.Add(Me.cbModi)
        Me.grpCardData.Location = New System.Drawing.Point(13, 150)
        Me.grpCardData.Name = "grpCardData"
        Me.grpCardData.Size = New System.Drawing.Size(667, 322)
        Me.grpCardData.TabIndex = 41
        Me.grpCardData.TabStop = False
        Me.grpCardData.Text = "Kartendaten"
        '
        'chkModifier
        '
        Me.chkModifier.AutoSize = True
        Me.chkModifier.Location = New System.Drawing.Point(347, 122)
        Me.chkModifier.Name = "chkModifier"
        Me.chkModifier.Size = New System.Drawing.Size(94, 17)
        Me.chkModifier.TabIndex = 41
        Me.chkModifier.Text = "Modifizierkarte"
        Me.chkModifier.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(13, 161)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 13)
        Me.Label12.TabIndex = 40
        Me.Label12.Text = "Modus"
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblVersion.Location = New System.Drawing.Point(540, 475)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(140, 13)
        Me.lblVersion.TabIndex = 42
        Me.lblVersion.Text = "v1.0 | 09/2019 by pIT-NRW"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 495)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.grpComPort)
        Me.Controls.Add(Me.grpCardData)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "TonUINO PC Card-Writer"
        Me.grpComPort.ResumeLayout(False)
        Me.grpComPort.PerformLayout()
        Me.grpCardData.ResumeLayout(False)
        Me.grpCardData.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SerialPort As IO.Ports.SerialPort
    Friend WithEvents lbMagic As Label
    Friend WithEvents lbFolder As Label
    Friend WithEvents lbVersion As Label
    Friend WithEvents lbVonTrack As Label
    Friend WithEvents lbBisTrack As Label
    Friend WithEvents lbMode As Label
    Friend WithEvents btnCopy As Button
    Friend WithEvents btnWrite As Button
    Friend WithEvents cbModi As ComboBox
    Friend WithEvents lbModeNeu As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents tbMagic As TextBox
    Friend WithEvents tbVersion As TextBox
    Friend WithEvents tbFolder As TextBox
    Friend WithEvents tbVonTrack As TextBox
    Friend WithEvents tbBisTrack As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents cbModifier As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents grpComPort As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbPort As Label
    Friend WithEvents btnPorts As Button
    Friend WithEvents Ports As ListBox
    Friend WithEvents grpCardData As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents chkModifier As CheckBox
    Friend WithEvents Label13 As Label
    Friend WithEvents lblVersion As Label
End Class
