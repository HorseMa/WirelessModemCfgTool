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

namespace WirelessModemCfgTool
{
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        }

        private void start_Load(object sender, EventArgs e)
        {
            SerialPort com = new SerialPort("COM1");

            string[] portlist = SerialPort.GetPortNames();
            for (int i = 0; i < portlist.Length; i++)
            {
                if (-1 == serialportlist.FindString(portlist[i]))
                {
                    serialportlist.Items.Add(portlist[i]);
                }
                if (i == 0)
                {
                    serialportlist.Text = portlist[i];
                }
            }

            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            serialportlist.Show();

            baudrate.SelectedIndex = 0;
            paritybit.SelectedIndex = 0;
            databit.SelectedIndex = 0;
            stopbit.SelectedIndex = 0;
            comboBoxairrate.SelectedIndex = 0;
            textBoxdestAddr.Text = "FFFF";
            channel.Text = "00";
            comboBoxmode.SelectedIndex = 0;
        }

        private void serialportlist_MouseDown(object sender, MouseEventArgs e)
        {
            SerialPort com = new SerialPort("COM1");

            string[] portlist = SerialPort.GetPortNames();
            for (int i = 0; i < portlist.Length; i++)
            {
                if (-1 == serialportlist.FindString(portlist[i]))
                {
                    serialportlist.Items.Add(portlist[i]);
                }
                if (i == 0)
                {
                    serialportlist.Text = portlist[i];
                }
            }

            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            serialportlist.Show();
        }

        private void opendevice_Click(object sender, EventArgs e)
        {
            if (serialportlist.SelectedItem == null)
                return;
            if (opendevice.Text == "打开端口")
            {
                serialPort.PortName = serialportlist.SelectedItem.ToString();
                serialPort.BaudRate = 9600;
                serialPort.DataBits = 8;
                serialPort.StopBits = StopBits.One;
                serialPort.Parity = Parity.None;
                serialPort.NewLine = "\0";
                try
                {
                    serialPort.Open();
                    if (serialPort.IsOpen)
                    {
                        serialPort.WriteLine("fdsa");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                opendevice.Text = "关闭端口";
            }
            else
            {
                serialPort.Close();
                opendevice.Text = "打开端口";
            }
        }

        private void serialportlist_SelectedValueChanged(object sender, EventArgs e)
        {
            serialPort.Close();
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //string str;
            //str = serialPort.ReadLine();
            byte[] cmd = Encoding.UTF8.GetBytes(serialPort.ReadLine()); ;
            if (cmd.Length >= (12 + 12 + 12))//MJ-MD1U10010
            {
                baudrate.SelectedIndex = cmd[0] - 1;//串口波特率
                paritybit.SelectedIndex = cmd[1] - 1;//串口校验位
                databit.SelectedIndex = cmd[2] - 1;//串口数据位
                stopbit.SelectedIndex = cmd[3] - 1;//串口停止位
                comboBoxairrate.SelectedIndex = cmd[4] - 1;//空中波特率
                byte[] tmp = new byte[10];//信道
                Array.Copy(cmd, 5, tmp, 0, 2);
                channel.Text = System.Text.Encoding.Default.GetString(tmp);
                tmp = new byte[10];//目标地址
                Array.Copy(cmd, 7, tmp, 0, 4);
                textBoxdestAddr.Text = System.Text.Encoding.Default.GetString(tmp); ;
                comboBoxmode.SelectedIndex = cmd[11] - 1;//通信模式
                tmp = new byte[13];//硬件版本
                Array.Copy(cmd, 12, tmp, 0, 12);
                textBoxhardwareversion.Text = System.Text.Encoding.Default.GetString(tmp);
                tmp = new byte[13];//软件版本
                Array.Copy(cmd, 24, tmp, 0, 12);
                textBoxsoftwareversion.Text = System.Text.Encoding.Default.GetString(tmp);
                tmp = new byte[13];//出厂编号
                Array.Copy(cmd, 36, tmp, 0, 12);
                textBoxsn.Text = System.Text.Encoding.Default.GetString(tmp);
            }
        }

        private void readcfg_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen == false)
            {
                MessageBox.Show("请选择端口并打开");
                return;
            }
            serialPort.WriteLine("get");
        }

        private void writecfg_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen == false)
            {
                MessageBox.Show("请选择端口并打开");
                return;
            }
            byte[] cmd = new byte[40];
            cmd[0] = (byte)'c';
            cmd[1] = (byte)'f';
            cmd[2] = (byte)'g';
            cmd[3] = (byte)' ';
            cmd[4] = (byte)'s';
            cmd[5] = (byte)'e';
            cmd[6] = (byte)'t';
            cmd[7] = (byte)(baudrate.SelectedIndex + 1);//串口波特率
            cmd[8] = (byte)(paritybit.SelectedIndex + 1);//串口校验位
            cmd[9] = (byte)(databit.SelectedIndex + 1);//串口数据位
            cmd[10] = (byte)(stopbit.SelectedIndex + 1);//串口停止位
            cmd[11] = (byte)(comboBoxairrate.SelectedIndex + 1);//空中波特率
            byte[] tmp = new byte[10];
            tmp = System.Text.Encoding.ASCII.GetBytes(channel.Text);//信道
            Array.Copy(tmp, 0, cmd, 12, 2);
            tmp = new byte[10];
            tmp = System.Text.Encoding.ASCII.GetBytes(textBoxdestAddr.Text);//目标地址
            Array.Copy(tmp, 0, cmd, 14, 4);
            tmp = new byte[10];
            cmd[18] = (byte)(comboBoxmode.SelectedIndex + 1);//通信模式
            cmd[19] = (byte)'\0';
            string pcack = System.Text.Encoding.UTF8.GetString(cmd);
            serialPort.WriteLine(pcack);
        }

        private void buttonFactoryReset_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen == false)
            {
                MessageBox.Show("请选择端口并打开");
                return;
            }
            serialPort.WriteLine("factory reset");
        }
        public const string PATTERN = @"([^A-Fa-f0-9]|\s+?)+";
        private void channel_MouseLeave(object sender, EventArgs e)
        {
            string hex;

            hex = channel.Text;
            if (true == System.Text.RegularExpressions.Regex.IsMatch(hex, PATTERN))
            {
                MessageBox.Show("请正确输入十六进制数字:00~FF");
                channel.Text = "00";
            }
            int len = channel.TextLength;
            if (len != 2)
            {
                MessageBox.Show("请输入正确的地址:00~FF");
                channel.Text = "00";
            }
        }

        private void textBoxdestAddr_MouseLeave(object sender, EventArgs e)
        {
            string hex;
            
            hex = textBoxdestAddr.Text;
            if (true == System.Text.RegularExpressions.Regex.IsMatch(hex, PATTERN))
            {
                MessageBox.Show("请正确输入十六进制数字:0000~FFFF");
                textBoxdestAddr.Text = "FFFF";
            }

            int len = textBoxdestAddr.TextLength;
            if (len != 4)
            {
                MessageBox.Show("请输入正确的地址:0000~FFFF");
                textBoxdestAddr.Text = "FFFF";
            }
        }

        private void textBoxdestAddr_TextChanged(object sender, EventArgs e)
        {
            string hex;

            hex = textBoxdestAddr.Text;
            if (true == System.Text.RegularExpressions.Regex.IsMatch(hex, PATTERN))
            {
                MessageBox.Show("请正确输入十六进制数字:0000~FFFF");
                textBoxdestAddr.Text = "FFFF";
            }
        }

        private void channel_TextChanged(object sender, EventArgs e)
        {
            string hex;

            hex = channel.Text;
            if (true == System.Text.RegularExpressions.Regex.IsMatch(hex, PATTERN))
            {
                MessageBox.Show("请正确输入十六进制数字:00~FF");
                channel.Text = "00";
            }
        }
    }
}
