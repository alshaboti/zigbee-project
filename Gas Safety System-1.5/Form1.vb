Imports System.IO.Ports


Public Class frm_Control_panel
    Dim data_rx As String           'this variable copies data to from serial port
    Dim parsed_data(4) As String    'this variable processes data and remove aggrigation

    Dim logitude As String          'Content required by the map
    Dim latitude As String
    Dim id As String
    Dim gas As String



    Private Sub frm_Control_panel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '--------------the serial ports are populated in the combo box------------------
        Dim allports_avail As String() = SerialPort.GetPortNames()

        Dim counts As Integer = allports_avail.Count
        Dim pointer As Integer = 0

        For pointer = 0 To counts - 1 Step 1
            Cmb_Ports.Items.Add(allports_avail(pointer))
        Next
        '-----------------------Populating serial port over------------------------------


        WB_display.Url = New Uri(Application.StartupPath + "\site_map.html")


    End Sub

    Private Sub Cmb_Ports_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_Ports.SelectedIndexChanged
        Dim PortsName As String

        If Cmb_Ports.Text <> "" And Not Com_arduino.IsOpen Then
            PortsName = Cmb_Ports.Text

            With Com_arduino
                .PortName = PortsName
                .BaudRate = 9600
                .DataBits = 8
                .Parity = Parity.None
                .StopBits = StopBits.One
                .Handshake = Handshake.None
            End With

            Try
                Com_arduino.Open()

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try

        End If
    End Sub



    Private Sub Com_arduino_DataReceived(ByVal sender As System.Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles Com_arduino.DataReceived
        ' read then update then clean then read again 
        If data_rx = "" Then
            data_rx = Com_arduino.ReadLine                'Get data from arduino

        End If

    End Sub
    Dim t1, t2, t2a, t2b, td As Double
    Private Sub updatMap()
        Try


            parsed_data = data_rx.Split(",")                    'Parse data

            parsed_data(0) = parsed_data(0).Trim().Substring(0, 6)
            parsed_data(1) = parsed_data(1).Trim().Substring(0, 6)
            parsed_data(2).Trim()
            parsed_data(3).Trim()

            If parsed_data(2) = "1" Then
                t2a = Val(DateTime.Now.ToString("ss.ffffff"))
                td = (t2a - t1)
                t1 = t2a
            ElseIf parsed_data(2) = "2" Then
                t2b = Val(DateTime.Now.ToString("ss.ffffff"))
                td = (t2b - t2)
                t2 = t2b
            End If
            '' for measureing the delay
            If td < 0 Then
                td += 60
            End If
            TextBoxGPS.Text &= td & vbNewLine

            TextBoxGPS.Text += data_rx & vbNewLine




            parsed_data(0) = CStr(Val(parsed_data(0)) / 10000)
            parsed_data(1) = CStr(Val(parsed_data(1)) / 10000)


            Dim args() As String = {parsed_data(0), parsed_data(1), parsed_data(2), parsed_data(3)}
            WB_display.Document.InvokeScript("getVars", args)


        Catch ex As Exception
            'MsgBox(ex.ToString)
        End Try
        data_rx = ""
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If data_rx <> "" Then
            '    TextBoxGPS.Text += data_rx + vbNewLine
            'data_rx = ""
            If (data_rx.IndexOf("=") > 0) Then
                ModbusReading()
            ElseIf (data_rx.IndexOf(",") > 0) Then
                updatMap()
                TextBoxGPS.Text += data_rx + vbNewLine
            End If
            'clean it
            data_rx = ""
        End If



    End Sub
    Dim H2S, H2Sbatt, CO, COBatt, CO2, CO2Batt As Single

    Private Sub ModbusReading()
        '10=0,12=38,14=0,16=38,18=0,20=128

        Dim frag() As String = data_rx.Split(",")

        Dim tempArr() As String = frag(0).Split("=")
        H2S = Val(tempArr(1)) / 10
        tempArr = frag(1).Split("=")
        H2Sbatt = Val(tempArr(1)) / 10


        tempArr = frag(2).Split("=")
        CO = Val(tempArr(1)) / 10
        tempArr = frag(3).Split("=")
        COBatt = Val(tempArr(1)) / 10



        tempArr = frag(4).Split("=")
        CO2 = Val(tempArr(1)) / 10
        tempArr = frag(5).Split("=")
        CO2Batt = Val(tempArr(1)) / 10

        TextBoxCO.Text = CO
        TextBoxCoBatt.Text = COBatt

        TextBoxCO2.Text = CO2
        TextBoxCO2Batt.Text = CO2Batt

        TextBoxH2S.Text = H2S
        TextBoxH2SBatt.Text = H2Sbatt

        If (H2S >= Val(TextBoxRefH2S.Text)) Or (CO >= Val(TextBoxRefCO.Text)) Or (CO2 >= Val(TextBoxRefCO2.Text)) Then
            Com_arduino.Write("H#")
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        ' Com_arduino.WriteLine(TextBox1.Text)

        If Com_arduino.IsOpen Then

            Com_arduino.Write(TextBox1.Text)
            t1 = Val(DateTime.Now.ToString("ss.ffffff"))
            t2 = t1
        Else
            MsgBox("Select port first...")

        End If


    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub frm_Control_panel_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        Try
            Com_arduino.Close()

        Catch ex As Exception

        End Try

    End Sub
End Class