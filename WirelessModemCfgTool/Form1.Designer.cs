namespace WirelessModemCfgTool
{
    partial class start
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelhardwareversion = new System.Windows.Forms.Label();
            this.textBoxhardwareversion = new System.Windows.Forms.TextBox();
            this.labelsoftwareversion = new System.Windows.Forms.Label();
            this.textBoxsoftwareversion = new System.Windows.Forms.TextBox();
            this.labelsn = new System.Windows.Forms.Label();
            this.textBoxsn = new System.Windows.Forms.TextBox();
            this.groupBoxinfo = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxmode = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonFactoryReset = new System.Windows.Forms.Button();
            this.textBoxdestAddr = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.readcfg = new System.Windows.Forms.Button();
            this.writecfg = new System.Windows.Forms.Button();
            this.channel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.airbaudrate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.stopbit = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.databit = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.paritybit = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.baudrate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.serialportlist = new System.Windows.Forms.ComboBox();
            this.opendevice = new System.Windows.Forms.Button();
            this.groupBoxinfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelhardwareversion
            // 
            this.labelhardwareversion.AutoSize = true;
            this.labelhardwareversion.Location = new System.Drawing.Point(6, 29);
            this.labelhardwareversion.Name = "labelhardwareversion";
            this.labelhardwareversion.Size = new System.Drawing.Size(53, 12);
            this.labelhardwareversion.TabIndex = 2;
            this.labelhardwareversion.Text = "硬件版本";
            // 
            // textBoxhardwareversion
            // 
            this.textBoxhardwareversion.Enabled = false;
            this.textBoxhardwareversion.Location = new System.Drawing.Point(78, 26);
            this.textBoxhardwareversion.Name = "textBoxhardwareversion";
            this.textBoxhardwareversion.Size = new System.Drawing.Size(79, 21);
            this.textBoxhardwareversion.TabIndex = 3;
            this.textBoxhardwareversion.Text = "10";
            this.textBoxhardwareversion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelsoftwareversion
            // 
            this.labelsoftwareversion.AutoSize = true;
            this.labelsoftwareversion.Location = new System.Drawing.Point(6, 60);
            this.labelsoftwareversion.Name = "labelsoftwareversion";
            this.labelsoftwareversion.Size = new System.Drawing.Size(53, 12);
            this.labelsoftwareversion.TabIndex = 4;
            this.labelsoftwareversion.Text = "软件版本";
            // 
            // textBoxsoftwareversion
            // 
            this.textBoxsoftwareversion.Enabled = false;
            this.textBoxsoftwareversion.Location = new System.Drawing.Point(78, 57);
            this.textBoxsoftwareversion.Name = "textBoxsoftwareversion";
            this.textBoxsoftwareversion.Size = new System.Drawing.Size(79, 21);
            this.textBoxsoftwareversion.TabIndex = 5;
            this.textBoxsoftwareversion.Text = "10";
            this.textBoxsoftwareversion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelsn
            // 
            this.labelsn.AutoSize = true;
            this.labelsn.Location = new System.Drawing.Point(6, 91);
            this.labelsn.Name = "labelsn";
            this.labelsn.Size = new System.Drawing.Size(53, 12);
            this.labelsn.TabIndex = 6;
            this.labelsn.Text = "出厂编号";
            // 
            // textBoxsn
            // 
            this.textBoxsn.Enabled = false;
            this.textBoxsn.Location = new System.Drawing.Point(78, 88);
            this.textBoxsn.Name = "textBoxsn";
            this.textBoxsn.Size = new System.Drawing.Size(79, 21);
            this.textBoxsn.TabIndex = 7;
            this.textBoxsn.Text = "201602160000";
            // 
            // groupBoxinfo
            // 
            this.groupBoxinfo.Controls.Add(this.textBoxsn);
            this.groupBoxinfo.Controls.Add(this.textBoxhardwareversion);
            this.groupBoxinfo.Controls.Add(this.labelsn);
            this.groupBoxinfo.Controls.Add(this.labelhardwareversion);
            this.groupBoxinfo.Controls.Add(this.textBoxsoftwareversion);
            this.groupBoxinfo.Controls.Add(this.labelsoftwareversion);
            this.groupBoxinfo.Location = new System.Drawing.Point(12, 55);
            this.groupBoxinfo.Name = "groupBoxinfo";
            this.groupBoxinfo.Size = new System.Drawing.Size(169, 121);
            this.groupBoxinfo.TabIndex = 8;
            this.groupBoxinfo.TabStop = false;
            this.groupBoxinfo.Text = "模块信息";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxmode);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.buttonFactoryReset);
            this.groupBox1.Controls.Add(this.textBoxdestAddr);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.readcfg);
            this.groupBox1.Controls.Add(this.writecfg);
            this.groupBox1.Controls.Add(this.channel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.airbaudrate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.stopbit);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.databit);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.paritybit);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.baudrate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 182);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 310);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "配置";
            // 
            // comboBoxmode
            // 
            this.comboBoxmode.FormattingEnabled = true;
            this.comboBoxmode.Items.AddRange(new object[] {
            "透明传输",
            "API传输"});
            this.comboBoxmode.Location = new System.Drawing.Point(78, 225);
            this.comboBoxmode.Name = "comboBoxmode";
            this.comboBoxmode.Size = new System.Drawing.Size(79, 20);
            this.comboBoxmode.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 24;
            this.label8.Text = "通信模式";
            // 
            // buttonFactoryReset
            // 
            this.buttonFactoryReset.Location = new System.Drawing.Point(8, 281);
            this.buttonFactoryReset.Name = "buttonFactoryReset";
            this.buttonFactoryReset.Size = new System.Drawing.Size(149, 23);
            this.buttonFactoryReset.TabIndex = 23;
            this.buttonFactoryReset.Text = "恢复出厂设置";
            this.buttonFactoryReset.UseVisualStyleBackColor = true;
            this.buttonFactoryReset.Click += new System.EventHandler(this.buttonFactoryReset_Click);
            // 
            // textBoxdestAddr
            // 
            this.textBoxdestAddr.Location = new System.Drawing.Point(78, 199);
            this.textBoxdestAddr.Name = "textBoxdestAddr";
            this.textBoxdestAddr.Size = new System.Drawing.Size(79, 21);
            this.textBoxdestAddr.TabIndex = 22;
            this.textBoxdestAddr.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 21;
            this.label7.Text = "目标地址";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // readcfg
            // 
            this.readcfg.Location = new System.Drawing.Point(84, 252);
            this.readcfg.Name = "readcfg";
            this.readcfg.Size = new System.Drawing.Size(73, 23);
            this.readcfg.TabIndex = 20;
            this.readcfg.Text = "读配置";
            this.readcfg.UseVisualStyleBackColor = true;
            this.readcfg.Click += new System.EventHandler(this.readcfg_Click);
            // 
            // writecfg
            // 
            this.writecfg.Location = new System.Drawing.Point(8, 252);
            this.writecfg.Name = "writecfg";
            this.writecfg.Size = new System.Drawing.Size(75, 23);
            this.writecfg.TabIndex = 19;
            this.writecfg.Text = "写配置";
            this.writecfg.UseVisualStyleBackColor = true;
            this.writecfg.Click += new System.EventHandler(this.writecfg_Click);
            // 
            // channel
            // 
            this.channel.Location = new System.Drawing.Point(78, 168);
            this.channel.Name = "channel";
            this.channel.Size = new System.Drawing.Size(79, 21);
            this.channel.TabIndex = 18;
            this.channel.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 17;
            this.label6.Text = "无线信道";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // airbaudrate
            // 
            this.airbaudrate.Location = new System.Drawing.Point(78, 139);
            this.airbaudrate.Name = "airbaudrate";
            this.airbaudrate.Size = new System.Drawing.Size(79, 21);
            this.airbaudrate.TabIndex = 16;
            this.airbaudrate.Text = "10000";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "无线速率";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stopbit
            // 
            this.stopbit.FormattingEnabled = true;
            this.stopbit.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.stopbit.Location = new System.Drawing.Point(78, 110);
            this.stopbit.Name = "stopbit";
            this.stopbit.Size = new System.Drawing.Size(79, 20);
            this.stopbit.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "串口停止位";
            // 
            // databit
            // 
            this.databit.FormattingEnabled = true;
            this.databit.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.databit.Location = new System.Drawing.Point(78, 83);
            this.databit.Name = "databit";
            this.databit.Size = new System.Drawing.Size(79, 20);
            this.databit.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "串口数据位";
            // 
            // paritybit
            // 
            this.paritybit.FormattingEnabled = true;
            this.paritybit.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.paritybit.Location = new System.Drawing.Point(78, 55);
            this.paritybit.Name = "paritybit";
            this.paritybit.Size = new System.Drawing.Size(79, 20);
            this.paritybit.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "串口校验位";
            // 
            // baudrate
            // 
            this.baudrate.FormattingEnabled = true;
            this.baudrate.Items.AddRange(new object[] {
            "100",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200",
            "128000",
            "256000"});
            this.baudrate.Location = new System.Drawing.Point(78, 28);
            this.baudrate.Name = "baudrate";
            this.baudrate.Size = new System.Drawing.Size(79, 20);
            this.baudrate.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "串口波特率";
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // serialportlist
            // 
            this.serialportlist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serialportlist.FormattingEnabled = true;
            this.serialportlist.Location = new System.Drawing.Point(20, 14);
            this.serialportlist.Name = "serialportlist";
            this.serialportlist.Size = new System.Drawing.Size(73, 20);
            this.serialportlist.TabIndex = 10;
            this.serialportlist.SelectedValueChanged += new System.EventHandler(this.serialportlist_SelectedValueChanged);
            this.serialportlist.MouseDown += new System.Windows.Forms.MouseEventHandler(this.serialportlist_MouseDown);
            // 
            // opendevice
            // 
            this.opendevice.Location = new System.Drawing.Point(96, 10);
            this.opendevice.Name = "opendevice";
            this.opendevice.Size = new System.Drawing.Size(73, 26);
            this.opendevice.TabIndex = 11;
            this.opendevice.Text = "打开端口";
            this.opendevice.UseVisualStyleBackColor = true;
            this.opendevice.Click += new System.EventHandler(this.opendevice_Click);
            // 
            // start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 504);
            this.Controls.Add(this.opendevice);
            this.Controls.Add(this.serialportlist);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxinfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "start";
            this.Text = "上海鸣驹智能科技有限公司";
            this.Load += new System.EventHandler(this.start_Load);
            this.groupBoxinfo.ResumeLayout(false);
            this.groupBoxinfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelhardwareversion;
        private System.Windows.Forms.TextBox textBoxhardwareversion;
        private System.Windows.Forms.Label labelsoftwareversion;
        private System.Windows.Forms.TextBox textBoxsoftwareversion;
        private System.Windows.Forms.Label labelsn;
        private System.Windows.Forms.TextBox textBoxsn;
        private System.Windows.Forms.GroupBox groupBoxinfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxdestAddr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button readcfg;
        private System.Windows.Forms.Button writecfg;
        private System.Windows.Forms.TextBox channel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox airbaudrate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox stopbit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox databit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox paritybit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox baudrate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxmode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonFactoryReset;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Button opendevice;
        private System.Windows.Forms.ComboBox serialportlist;
    }
}

