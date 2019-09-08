''' <summary>
''' Simple PC tool to write TonUINO RFID cards via serial port.
''' Modes, Modifier Baudrate etc. are hardcoded.
''' (c) 2019 pIT-NRW
''' </summary>
Public Class frmMain
    Dim Baudrate = 115200
    Dim ReadBufferSize As Integer = 40
    Dim ReadBuffer As Byte() = New Byte(ReadBufferSize - 1) {}
    Dim rc_state As Integer = 0
    Dim rc_index As Integer = 0
    Dim rc_num As Integer = 0
    Dim Magic = New Byte(7) {0, 0, 0, 0, 0, 0, 0, 0}
    Dim version = New Byte(1) {0, 0}
    Dim folder = New Byte(1) {0, 0}
    Dim mode = New Byte(1) {0, 0}
    Dim track = New Byte(1) {0, 0}
    Dim totrack = New Byte(1) {0, 0}
    Dim WriteString As String
    Dim NewCard As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListPorts()
        If Ports.Items.Count > 0 Then
            lbPort.Text = Ports.Items(0)
            SetComPort()
        Else
            lbPort.Text = ""
        End If
    End Sub

    Private Sub ListPorts()
        ' list all available COM ports
        Ports.Items.Clear()
        For Each sp As String In My.Computer.Ports.SerialPortNames
            Ports.Items.Add(sp)
        Next
    End Sub

    Private Sub btnPorts_Click(sender As Object, e As EventArgs) Handles btnPorts.Click
        ListPorts()
        If Ports.Items.Count > 0 Then
            lbPort.Text = Ports.Items(0)
        Else
            lbPort.Text = ""
        End If
    End Sub

    Private Sub SetComPort()

        Try
            If SerialPort.IsOpen Then SerialPort.Close()
            If lbPort.Text <> "" Then
                SerialPort.PortName = lbPort.Text
                SerialPort.BaudRate = Baudrate
                SerialPort.Open()
                Timer1.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show("Es ist ein Fehler beim Öffnen des Com-Ports aufgetreten. Vermutlich ist dieser bereits in einem anderen Programm geöffnet.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Ports_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Ports.SelectedIndexChanged
        If Ports.Items.Count > 0 Then
            lbPort.Text = Ports.SelectedItem.ToString
        Else
            lbPort.Text = ""
        End If
    End Sub

    Private Sub BytesReceived(c As Byte)
        ' process received bytes
        Select Case rc_state
            Case 0
                ' start of message
                If c = 35 Then
                    rc_state = 1
                    rc_num = 0
                End If
            Case 1
                ' read till card data, here magic bytes 1
                ' reset processing, if message start char received
                If c = 35 Then
                    rc_num = 0
                Else
                    Magic(rc_num) = c
                    rc_num = rc_num + 1
                    If rc_num > 7 Then
                        rc_state = 2
                        rc_num = 0
                    End If
                End If
            Case 2
                ' read version
                ' reset processing, if message start char received
                If c = 35 Then
                    rc_num = 0
                    rc_state = 1
                Else
                    version(rc_num) = c
                    rc_num = rc_num + 1
                    If rc_num > 1 Then
                        rc_state = 3
                        rc_num = 0
                    End If
                End If
            Case 3
                ' read folder number
                ' reset processing, if message start char received
                If c = 35 Then
                    rc_num = 0
                    rc_state = 1
                Else
                    folder(rc_num) = c
                    rc_num = rc_num + 1
                    If rc_num > 1 Then
                        rc_state = 4
                        rc_num = 0
                    End If
                End If
            Case 4
                ' read mode
                ' reset processing, if message start char received
                If c = 35 Then
                    rc_num = 0
                    rc_state = 1
                Else
                    mode(rc_num) = c
                    rc_num = rc_num + 1
                    If rc_num > 1 Then
                        rc_state = 5
                        rc_num = 0
                    End If
                End If
            Case 5
                ' read start position/from track (special)
                ' reset processing, if message start char received
                If c = 35 Then
                    rc_num = 0
                    rc_state = 1
                Else
                    track(rc_num) = c
                    rc_num = rc_num + 1
                    If rc_num > 1 Then
                        rc_state = 6
                        rc_num = 0
                    End If
                End If
            Case 6
                ' read end position/to track (special2)
                ' reset processing, if message start char received
                If c = 35 Then
                    rc_num = 0
                    rc_state = 1
                Else
                    totrack(rc_num) = c
                    rc_num = rc_num + 1
                    If rc_num > 1 Then
                        rc_state = 7
                        rc_num = 0
                    End If
                End If
            Case 7
                ' processing finished
                NewCard = True
                rc_state = 0
        End Select
    End Sub

    Public Sub SerialDataReceived()
        ' record received, next card
        ' show data on form
        lbMagic.Text = System.Text.Encoding.ASCII.GetString(Magic)
        lbFolder.Text = CInt("&H" & System.Text.Encoding.ASCII.GetString(folder)).ToString
        lbVersion.Text = CInt("&H" & System.Text.Encoding.ASCII.GetString(version)).ToString
        lbMode.Text = CInt("&H" & System.Text.Encoding.ASCII.GetString(mode)).ToString
        lbVonTrack.Text = CInt("&H" & System.Text.Encoding.ASCII.GetString(track)).ToString
        lbBisTrack.Text = CInt("&H" & System.Text.Encoding.ASCII.GetString(totrack)).ToString
    End Sub

    Private Function UnicodeBytesToString(
    ByVal bytes() As Byte) As String
        Return System.Text.Encoding.Unicode.GetString(bytes)
    End Function

    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        tbMagic.Text = lbMagic.Text
        tbVersion.Text = lbVersion.Text
        tbFolder.Text = lbFolder.Text
        lbModeNeu.Text = lbMode.Text
        tbVonTrack.Text = lbVonTrack.Text
        tbBisTrack.Text = lbBisTrack.Text
    End Sub

    Private Sub btnWrite_Click(sender As Object, e As EventArgs) Handles btnWrite.Click
        If Not SerialPort.IsOpen Then
            MessageBox.Show("Es besteht keine Verbindung zum TonUINO.", "Keine Verbindung", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If lbModeNeu.Text.Length <= 0 Then
            MessageBox.Show("Es wurde kein Modus für die Karte ausgewählt. Bitte Modus auswählen und erneut versuchen.", "Modusauswahl", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        ' write card data
        While tbMagic.Text.Length > 8
            tbMagic.Text = tbMagic.Text.Remove(0, 1)
        End While
        While tbMagic.Text.Length < 8
            tbMagic.Text = "0" & tbMagic.Text
        End While
        tbMagic.Text = UCase(tbMagic.Text)
        While tbFolder.Text.Length > 2
            tbFolder.Text = tbFolder.Text.Remove(0, 1)
        End While
        If tbFolder.Text.Length = 0 Then
            tbFolder.Text = "0"
        End If
        While tbVersion.Text.Length > 2
            tbVersion.Text = tbVersion.Text.Remove(0, 1)
        End While
        If tbVersion.Text.Length = 0 Then
            tbVersion.Text = "1"
        End If
        While tbVonTrack.Text.Length > 3
            tbVonTrack.Text = tbVonTrack.Text.Remove(0, 1)
        End While
        If tbVonTrack.Text.Length = 0 Then
            tbVonTrack.Text = "0"
        End If
        While tbBisTrack.Text.Length > 3
            tbBisTrack.Text = tbBisTrack.Text.Remove(0, 1)
        End While
        If tbBisTrack.Text.Length = 0 Then
            tbBisTrack.Text = "0"
        End If
        WriteString = "#" & tbMagic.Text & Hex(tbVersion.Text).PadLeft(2, "0") & Hex(tbFolder.Text).PadLeft(2, "0") &
            Hex(lbModeNeu.Text).PadLeft(2, "0") & Hex(tbVonTrack.Text).PadLeft(2, "0") & Hex(tbBisTrack.Text).PadLeft(2, "0")
        SendSerialData(WriteString)
    End Sub

    Sub SendSerialData(ByVal data As String)
        ' send string to serial port
        If SerialPort.IsOpen Then
            SerialPort.WriteLine(data)
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If SerialPort.IsOpen Then SerialPort.Close()
    End Sub

    Private Sub cbModi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbModi.SelectedIndexChanged, cbModifier.SelectedIndexChanged
        Dim index As Integer
        index = CType(sender, ComboBox).SelectedIndex + 1
        lbModeNeu.Text = Format(index, "00")
    End Sub

    Private Sub SerialPort_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort.DataReceived
        Dim n As Integer
        n = SerialPort.BytesToRead
        While n > 0
            BytesReceived(SerialPort.ReadByte())
            n = n - 1
        End While
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If NewCard = True Then
            NewCard = False
            SerialDataReceived()
        End If
        If ((tbFolder.Text).PadLeft(2, "0") = "00") Then
            cbModi.Visible = False
            cbModifier.Visible = True
        Else
            cbModi.Visible = True
            cbModifier.Visible = False
        End If
    End Sub

    Private Sub lbPort_TextChanged(sender As Object, e As EventArgs) Handles lbPort.TextChanged
        SetComPort()
    End Sub

    Private Sub ChkModifier_CheckedChanged(sender As Object, e As EventArgs) Handles chkModifier.CheckedChanged
        If chkModifier.Checked Then
            tbFolder.Text = "00"
        Else
            tbFolder.Text = "1"
        End If
    End Sub

    Private Sub TbFolder_TextChanged(sender As Object, e As EventArgs) Handles tbFolder.TextChanged
        If tbFolder.Text.PadLeft(2, "0") = "00" Then
            chkModifier.Checked = True
        Else
            chkModifier.Checked = False
        End If
    End Sub
End Class

