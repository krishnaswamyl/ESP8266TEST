using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Net;

namespace ESP8266TEST
{
    public partial class Form1 : Form
    {
        static SerialPort SP1 = new SerialPort();
        public char[] split = { '\n', '\r' };
        public String[] arrst = new string[20];
        bool read_timeout_flag = true;
        public String Password = "abc";
        bool receive = false;
        bool receiveJoin = false;
        bool receiveTcpcon = false;
        public String data = "";
        Thread readAPList,tcpConnect;
        static AutoResetEvent waitserial;
        private static readonly Object _Lock = new Object();

        public Form1()
        {
            InitializeComponent();
            SP1 = new SerialPort();
            SP1.DataReceived += new SerialDataReceivedEventHandler(this.SP1_DataReceived);
            waitserial = new AutoResetEvent(false);
        }

        private string WriteAndReadCom(string com)
        {
            lock (_Lock)
            {
                string temp = null;
                
                read_timeout_flag = false;
                if (SP1.IsOpen == false)
                {
                    MessageBox.Show("Please connect to comm");
                    return ("N");
                }
                SP1.DiscardInBuffer();
                SP1.WriteTimeout = 2000;
                SP1.ReadTimeout = 2000;
                SP1.WriteLine(com);
                int bytestoread=0;
                int timeup = 0;
                do
                {
                    Thread.Sleep(100);
                    bytestoread = SP1.BytesToRead;
                    if (bytestoread > 0) break;
                    timeup++;
                    if(timeup > 60)
                    {
                        read_timeout_flag = true;
                        break;
                    }


                } while (true);
                if(read_timeout_flag == true)
                {
                    MessageBox.Show("Target Not Responding.\n Please check connections and cable");
                    return "N";
                }
                char[] buf = new char[bytestoread];
                try
                {
                    SP1.Read(buf, 0, bytestoread);
                    String xt = new string(buf);
                    richTextBoxOut.AppendText(xt);
                    arrst = xt.Split(split);
                    
                }
                catch (TimeoutException)
                {
                    read_timeout_flag = true;
                    MessageBox.Show("Target Not Responding.\n Please check connections and cable");
                    return "N";
                }

                return ("A");

            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (buttonConnect.Text.Equals("Connect"))
            {
                string Comportname;
                try
                {
                    Comportname = comboBox1.SelectedItem.ToString();
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Select A Valid Comm Port");
                    return;
                }
                if(radioButton1.Checked)
                {
                    SP1.BaudRate = 115200;
                }else
                {
                    SP1.BaudRate = 9600;
                }
                SP1.PortName = Comportname;
                
                SP1.ReadBufferSize = 100;
                SP1.ReadTimeout = 3000;
                SP1.NewLine = "\r\n";
                try
                {
                    SP1.Open();
                }
                catch (Exception se)
                {
                    MessageBox.Show(se.Message.ToString());
                   // return;
                }
                string rs = WriteAndReadCom("AT");
                if (rs.Contains("N"))
                {
                    SP1.Dispose();
                    SP1.Close();
                    return;
                }
                if (read_timeout_flag == false)
                {
                    buttonConnect.Text = "Close Port";
                    buttonConnect.BackColor = Color.HotPink;
                    SP1.DataReceived += new SerialDataReceivedEventHandler(this.SP1_DataReceived);
                    getip();
                }


            }
            else
            {
                SP1.DataReceived -= new SerialDataReceivedEventHandler(this.SP1_DataReceived);
                SP1.Dispose();
                SP1.Close();
                buttonConnect.Text = "Connect";
            }
        }

        private void getip()
        {
            toolStripStatusLabel2.Text = "Please Wait ......";
            string rs = WriteAndReadCom("AT+CIFSR");
            char[] mysplit = { '"', '(', ')', ',' };
            String[] temp = new String[40];
            richTextBoxOut.Clear();
            foreach (string s in arrst)
            {
                temp = s.Split(mysplit);  
                if(temp[0].Contains("+CIFSR:STAIP"))
                {
                    labelStation.Text = "IP Add:" + temp[2];
                }
                if (temp[0].Contains("+CIFSR:STAMAC"))
                {
                    labelMac.Text = "MAC Add:" + temp[2];
                }

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int count = 0;
            comboBox1.BeginUpdate();
            comboBox1.Items.Clear();
            foreach (string s in SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(s);
                count++;
            }
            if (count > 0)
                comboBox1.SelectedIndex = 0;
            comboBox1.EndUpdate();
            textBoxIpaddress.Text = Properties.Settings.Default.Ipaddress.ToString();
        }

        private void buttonAT_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "..";
            string rs = WriteAndReadCom("ATE0");           
            if (rs.Equals("N"))
            {
                toolStripStatusLabel2.Text = "AT command Failed";
                return;
            }
            if (read_timeout_flag == true)
            {
                toolStripStatusLabel2.Text = "AT command Failed";
                return;
            }
            toolStripStatusLabel2.Text = "AT command Success!";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "..";
            string rs = WriteAndReadCom("AT+CWMODE_DEF=1");            
            if (rs.Equals("N"))
            {
                toolStripStatusLabel2.Text = "CWMODE_DEF command Failed";
                return;
            }
            if (read_timeout_flag == true)
            {
                toolStripStatusLabel2.Text = "CWMODE_DEF command Failed";
                return;
            }
            toolStripStatusLabel2.Text = "CWMODE_DEF SET TO STATION MODE!";

        }

        private void buttonAccessPoint_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "Please Wait....";
            richTextBoxOut.Clear();
            //string rs = WriteAndReadCom("AT+CWLAP");
            buttonAccessPoint.Enabled = false;
            readAPList = new Thread(getApList);
            readAPList.Start();

            
            
        }

        private void buttonConnectAP_Click(object sender, EventArgs e)
        {
            SSID sd = new SSID(this);
            Button tem = sender as Button;

            if(tem.Text=="Connect")
            {
                String select = comboBoxStation.SelectedItem.ToString();
                if (select.Length < 1)
                {
                    MessageBox.Show("Please select a Valid SSID");
                    return;
                }
                if (!SP1.IsOpen)
                {
                    MessageBox.Show("Please Open comp port..");
                    return;
                }
                sd.ShowDialog();
                select = "AT+CWJAP_DEF=\"" + select + @""",""" + Password + "\"";
                receive = false;
                receiveJoin = true;
                SP1.WriteLine(select);
            }
            else
            {
               
                toolStripStatusLabel2.Text = "..";
                string rs = WriteAndReadCom("AT+CWQAP");
                if (rs.Equals("N"))
                {
                    toolStripStatusLabel2.Text = "QUIT AP command Failed";
                    return;
                }
                if (read_timeout_flag == true)
                {
                    toolStripStatusLabel2.Text = "QUIT AP command Failed";
                    return;
                }
                toolStripStatusLabel2.Text = "QUIT AP SUCESSFULL!";

            }
            
            return;
        }

        private void buttonBaudrate_Click(object sender, EventArgs e)
        {
            string rs = "";
            toolStripStatusLabel2.Text = "..";
            if (radioButton1.Checked)
            {
               rs  = WriteAndReadCom("AT+UART_DEF=115200,8,1,0,0");
            }
            else
            {
               rs = WriteAndReadCom("AT+UART_DEF=9600,8,1,0,0");
            }
                
            if (rs.Equals("N"))
            {
                toolStripStatusLabel2.Text = "SET BAUD COMM FAILED!";
                return;
            }
            if (read_timeout_flag == true)
            {
                toolStripStatusLabel2.Text = "SET BAUD COMM FAILED!";
                return;
            }
            toolStripStatusLabel2.Text = "SET BAUD COMMAND  Success!";

        }

        private void buttonRF_Click(object sender, EventArgs e)
        {
            string rs = "";
            toolStripStatusLabel2.Text = "..";
            rs = WriteAndReadCom("AT+SLEEP=0");
            if (rs.Equals("N"))
            {
                toolStripStatusLabel2.Text = "SET SLEEP COMMAND FAILED!";
                return;
            }
            if (read_timeout_flag == true)
            {
                toolStripStatusLabel2.Text = "SET SLEEP COMMAND FAILED!";
                return;
            }
            toolStripStatusLabel2.Text = "SET SLEEP COMMAND  Success!";
            this.Update();
            Thread.Sleep(500);
            toolStripStatusLabel2.Text = "..";
            rs = WriteAndReadCom("AT+RFPOWER=50");
            if (rs.Equals("N"))
            {
                toolStripStatusLabel2.Text = "SET RF COMMAND FAILED!";
                return;
            }
            if (read_timeout_flag == true)
            {
                toolStripStatusLabel2.Text = "SET RF COMMAND FAILED!";
                return;
            }

            toolStripStatusLabel2.Text = "SET RF COMMAND  Success!";
        }
        
        private void getApList()
        {
            receive = true;
            if(!SP1.IsOpen)
            {
                MessageBox.Show("Please Open comp port..");
                return;
            }
            SP1.WriteLine("AT+CWLAP");
            waitserial.WaitOne(8000);

            Invoke(new Action(() =>
            {
                buttonAccessPoint.Enabled = true;
                int count = 0;
                char[] mysplit = { '"', '(', ')', ',' };
                String[] ssid = new String[100];
                for (int i = 0; i < arrst.Length; i++)
                {
                    comboBoxStation.BeginUpdate();
                    comboBoxStation.Items.Clear();
                    foreach (string s in arrst)
                    {
                        ssid = s.Split(mysplit);
                        if (ssid.Length > 7)
                        {
                            comboBoxStation.Items.Add(ssid[3]);
                            count++;
                        }


                    }
                    if (count > 0)
                        comboBoxStation.SelectedIndex = 0;
                    comboBoxStation.EndUpdate();


                }
                toolStripStatusLabel2.Text = "Listing done!";
            }));

        }

        private void SP1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            String local = "";
            int bytestoread = 0;
            Thread.Sleep(250);
            if (receive)
            {
                bytestoread = SP1.BytesToRead;
                local = SP1.ReadExisting();
                arrst = local.Split(split);
                if (bytestoread>0)
                {
                    Invoke(new Action(() =>
                    {
                        richTextBoxOut.AppendText(local);
                        richTextBoxOut.Invalidate();
                    }));
                   
                }
                waitserial.Set();
            }            
            receive = false;
            if(receiveJoin)
            {
                bytestoread = SP1.BytesToRead;
                local = SP1.ReadExisting();
                if (bytestoread > 0)
                {
                    Invoke(new Action(() =>
                    {
                        richTextBoxOut.AppendText(local);
                        richTextBoxOut.Invalidate();
                    }));

                }
            }
            if(receiveTcpcon)
            {
                bytestoread = SP1.BytesToRead;
                local = SP1.ReadExisting();
                if (bytestoread > 0)
                {
                    arrst = local.Split(split);
                    Invoke(new Action(() =>
                    {
                        richTextBoxOut.AppendText(local);
                        richTextBoxOut.Invalidate();                                               
                    }));

                }
                waitserial.Set();
                
            }


        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Button temp = sender as Button;
            String tex = temp.Text;
            Properties.Settings.Default.Ipaddress = textBoxIpaddress.Text.ToString();
            Properties.Settings.Default.Save();

            if (tex.Contains("Exit"))
            {

                SP1.Dispose();
                SP1.Close();
                this.Close();
                return;
            }
            String nam = temp.Name;
            if (nam.Equals("buttonClearSend"))
            {
                richTextBoxSend.Clear();
            }
            if (nam.Equals("buttonClearout"))
            {
                richTextBoxOut.Clear();
            }
            if (nam.Equals("buttonSendData"))
            {
                if (!SP1.IsOpen)
                {
                    MessageBox.Show("Please open Com Port..");
                    return;
                }
                //AT + CIPSTART = "TCP","192.168.101.110",1000
                String conn = "";
                data = richTextBoxSend.Text;
                string input = textBoxIpaddress.Text;
                if (input.Contains(" "))
                    input = input.Replace(" ", "");
                IPAddress ipAddress;
                if (IPAddress.TryParse(input, out ipAddress))
                {
                    //IP address has been parsed correctly
                    toolStripStatusLabel2.Text = "..";
                    richTextBoxOut.Clear();
                    receiveTcpcon = true;
                    receive = false;
                    receiveJoin = false;
                    arrst = null;
                    waitserial.Reset();
                    conn = "AT+CIPSTART=\"TCP\"," + "\"" + input + "\","+"3000";                    
                    SP1.WriteLine(conn);                    
                    buttonSendData.Enabled = false;
                    tcpConnect = new Thread(SendDatatoServer);
                    tcpConnect.Start();

                }

            }
        }
        private void SendDatatoServer()
        {
            waitserial.Reset();
            waitserial.WaitOne(8000);
            bool nextflag = true;
            if (arrst!=null)
            foreach (string s in arrst)
            {
                if (s.Length > 1)
                {
                    if(s.Equals("ALREADY CONNECTED"))
                    {
                        break;
                    }
                    if (s.Equals("ERROR")|| s.Contains("busy p..."))
                    {
                        nextflag = false;
                    }
                    

                }
            }
            if(nextflag)
            {
                int len = data.Length;
                waitserial.Reset();
                SP1.WriteLine("AT+CIPSEND="+len.ToString());
                waitserial.WaitOne(8000);
                
                SP1.Write(data);                
                waitserial.WaitOne(8000);
                Invoke(new Action(() => {
                    toolStripStatusLabel2.Text = "Data Sent to Server";
                    buttonSendData.Enabled = true;
                }));
                
                return;
                //SP1.WriteLine("AT+CIPCLOSE");AT+CIPCLOSE
            }
            else
            {
               Invoke(new Action(() =>
               {
                   toolStripStatusLabel2.Text = "Connection Failed";
                   buttonSendData.Enabled = true;

               }));
            }


        }

        private void buttonPing_Click(object sender, EventArgs e)
        {
            if(!SP1.IsOpen)
            {
                return;
            }
            else
            {
                string input = textBoxIpaddress.Text;
                String conn = String.Empty;
                if (input.Contains(" "))
                    input = input.Replace(" ", "");
                IPAddress ipAddress;
                if (IPAddress.TryParse(input, out ipAddress))
                {
                    receiveJoin = true;
                    waitserial.Reset();
                    conn = "AT+PING=\""+ input + "\"";
                    SP1.WriteLine(conn);
                    //waitserial.WaitOne();
                }
               
            }
        }

        private void buttonGetip_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "..";
            getip();
            toolStripStatusLabel2.Text = "Got IP!";
        }
    }

    }



