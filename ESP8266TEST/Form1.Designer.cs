namespace ESP8266TEST
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonConnect = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.buttonGetip = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.labelMac = new System.Windows.Forms.Label();
            this.labelStation = new System.Windows.Forms.Label();
            this.buttonAT = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolstripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonStation = new System.Windows.Forms.Button();
            this.buttonAccessPoint = new System.Windows.Forms.Button();
            this.comboBoxStation = new System.Windows.Forms.ComboBox();
            this.buttonConnectAP = new System.Windows.Forms.Button();
            this.buttonBaudrate = new System.Windows.Forms.Button();
            this.buttonRF = new System.Windows.Forms.Button();
            this.richTextBoxOut = new System.Windows.Forms.RichTextBox();
            this.buttonClearout = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.richTextBoxSend = new System.Windows.Forms.RichTextBox();
            this.buttonClearSend = new System.Windows.Forms.Button();
            this.buttonSendData = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIpaddress = new System.Windows.Forms.TextBox();
            this.buttonPing = new System.Windows.Forms.Button();
            this.groupBox8.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonConnect.FlatAppearance.BorderSize = 2;
            this.buttonConnect.Location = new System.Drawing.Point(44, 27);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(104, 30);
            this.buttonConnect.TabIndex = 1;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = false;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(281, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(95, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox8.Controls.Add(this.buttonGetip);
            this.groupBox8.Controls.Add(this.radioButton2);
            this.groupBox8.Controls.Add(this.radioButton1);
            this.groupBox8.Controls.Add(this.labelMac);
            this.groupBox8.Controls.Add(this.labelStation);
            this.groupBox8.Controls.Add(this.buttonConnect);
            this.groupBox8.Controls.Add(this.comboBox1);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(516, 35);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(436, 166);
            this.groupBox8.TabIndex = 1;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Com Port";
            // 
            // buttonGetip
            // 
            this.buttonGetip.Location = new System.Drawing.Point(44, 63);
            this.buttonGetip.Name = "buttonGetip";
            this.buttonGetip.Size = new System.Drawing.Size(104, 25);
            this.buttonGetip.TabIndex = 8;
            this.buttonGetip.Text = "Get IP:";
            this.buttonGetip.UseVisualStyleBackColor = true;
            this.buttonGetip.Click += new System.EventHandler(this.buttonGetip_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(163, 52);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(63, 24);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.Text = "9600";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(163, 23);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(81, 24);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "115200";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // labelMac
            // 
            this.labelMac.AutoSize = true;
            this.labelMac.Location = new System.Drawing.Point(6, 143);
            this.labelMac.Name = "labelMac";
            this.labelMac.Size = new System.Drawing.Size(79, 20);
            this.labelMac.TabIndex = 6;
            this.labelMac.Text = "MAC add:";
            // 
            // labelStation
            // 
            this.labelStation.AutoSize = true;
            this.labelStation.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelStation.Location = new System.Drawing.Point(6, 111);
            this.labelStation.Name = "labelStation";
            this.labelStation.Size = new System.Drawing.Size(59, 20);
            this.labelStation.TabIndex = 6;
            this.labelStation.Text = "IP add:";
            // 
            // buttonAT
            // 
            this.buttonAT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonAT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAT.Location = new System.Drawing.Point(12, 35);
            this.buttonAT.Name = "buttonAT";
            this.buttonAT.Size = new System.Drawing.Size(110, 23);
            this.buttonAT.TabIndex = 2;
            this.buttonAT.Text = "AT CHECK";
            this.buttonAT.UseVisualStyleBackColor = false;
            this.buttonAT.Click += new System.EventHandler(this.buttonAT_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolstripStatus,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 688);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(974, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel1.Text = "Status:";
            // 
            // toolstripStatus
            // 
            this.toolstripStatus.Name = "toolstripStatus";
            this.toolstripStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel2.Text = ":";
            // 
            // buttonStation
            // 
            this.buttonStation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonStation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStation.Location = new System.Drawing.Point(128, 35);
            this.buttonStation.Name = "buttonStation";
            this.buttonStation.Size = new System.Drawing.Size(110, 23);
            this.buttonStation.TabIndex = 4;
            this.buttonStation.Text = "SET Station Mode";
            this.buttonStation.UseVisualStyleBackColor = false;
            this.buttonStation.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAccessPoint
            // 
            this.buttonAccessPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonAccessPoint.FlatAppearance.BorderSize = 2;
            this.buttonAccessPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAccessPoint.Location = new System.Drawing.Point(12, 81);
            this.buttonAccessPoint.Name = "buttonAccessPoint";
            this.buttonAccessPoint.Size = new System.Drawing.Size(142, 23);
            this.buttonAccessPoint.TabIndex = 4;
            this.buttonAccessPoint.Text = "LIST ACCESS POINTS";
            this.buttonAccessPoint.UseVisualStyleBackColor = false;
            this.buttonAccessPoint.Click += new System.EventHandler(this.buttonAccessPoint_Click);
            // 
            // comboBoxStation
            // 
            this.comboBoxStation.FormattingEnabled = true;
            this.comboBoxStation.Location = new System.Drawing.Point(167, 81);
            this.comboBoxStation.Name = "comboBoxStation";
            this.comboBoxStation.Size = new System.Drawing.Size(143, 21);
            this.comboBoxStation.TabIndex = 0;
            // 
            // buttonConnectAP
            // 
            this.buttonConnectAP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonConnectAP.Location = new System.Drawing.Point(316, 81);
            this.buttonConnectAP.Name = "buttonConnectAP";
            this.buttonConnectAP.Size = new System.Drawing.Size(81, 23);
            this.buttonConnectAP.TabIndex = 5;
            this.buttonConnectAP.Text = "Connect";
            this.buttonConnectAP.UseVisualStyleBackColor = false;
            this.buttonConnectAP.Click += new System.EventHandler(this.buttonConnectAP_Click);
            // 
            // buttonBaudrate
            // 
            this.buttonBaudrate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonBaudrate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBaudrate.Location = new System.Drawing.Point(366, 35);
            this.buttonBaudrate.Name = "buttonBaudrate";
            this.buttonBaudrate.Size = new System.Drawing.Size(110, 23);
            this.buttonBaudrate.TabIndex = 4;
            this.buttonBaudrate.Text = "Set Baud Rate";
            this.buttonBaudrate.UseVisualStyleBackColor = false;
            this.buttonBaudrate.Click += new System.EventHandler(this.buttonBaudrate_Click);
            // 
            // buttonRF
            // 
            this.buttonRF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonRF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRF.Location = new System.Drawing.Point(244, 35);
            this.buttonRF.Name = "buttonRF";
            this.buttonRF.Size = new System.Drawing.Size(110, 23);
            this.buttonRF.TabIndex = 4;
            this.buttonRF.Text = "SET RF Power";
            this.buttonRF.UseVisualStyleBackColor = false;
            this.buttonRF.Click += new System.EventHandler(this.buttonRF_Click);
            // 
            // richTextBoxOut
            // 
            this.richTextBoxOut.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxOut.Location = new System.Drawing.Point(516, 207);
            this.richTextBoxOut.Name = "richTextBoxOut";
            this.richTextBoxOut.Size = new System.Drawing.Size(436, 417);
            this.richTextBoxOut.TabIndex = 6;
            this.richTextBoxOut.Text = "";
            // 
            // buttonClearout
            // 
            this.buttonClearout.Location = new System.Drawing.Point(658, 639);
            this.buttonClearout.Name = "buttonClearout";
            this.buttonClearout.Size = new System.Drawing.Size(75, 23);
            this.buttonClearout.TabIndex = 7;
            this.buttonClearout.Text = "Clear";
            this.buttonClearout.UseVisualStyleBackColor = true;
            this.buttonClearout.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(770, 639);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDisconnect.Location = new System.Drawing.Point(403, 81);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(83, 23);
            this.buttonDisconnect.TabIndex = 5;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = false;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonConnectAP_Click);
            // 
            // richTextBoxSend
            // 
            this.richTextBoxSend.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxSend.Location = new System.Drawing.Point(15, 207);
            this.richTextBoxSend.Name = "richTextBoxSend";
            this.richTextBoxSend.Size = new System.Drawing.Size(382, 417);
            this.richTextBoxSend.TabIndex = 6;
            this.richTextBoxSend.Text = resources.GetString("richTextBoxSend.Text");
            // 
            // buttonClearSend
            // 
            this.buttonClearSend.Location = new System.Drawing.Point(50, 639);
            this.buttonClearSend.Name = "buttonClearSend";
            this.buttonClearSend.Size = new System.Drawing.Size(75, 23);
            this.buttonClearSend.TabIndex = 7;
            this.buttonClearSend.Text = "Clear";
            this.buttonClearSend.UseVisualStyleBackColor = true;
            this.buttonClearSend.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSendData
            // 
            this.buttonSendData.Location = new System.Drawing.Point(190, 639);
            this.buttonSendData.Name = "buttonSendData";
            this.buttonSendData.Size = new System.Drawing.Size(75, 23);
            this.buttonSendData.TabIndex = 7;
            this.buttonSendData.Text = "SEND";
            this.buttonSendData.UseVisualStyleBackColor = true;
            this.buttonSendData.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enter Server IP Address:";
            // 
            // textBoxIpaddress
            // 
            this.textBoxIpaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIpaddress.Location = new System.Drawing.Point(187, 136);
            this.textBoxIpaddress.Name = "textBoxIpaddress";
            this.textBoxIpaddress.Size = new System.Drawing.Size(145, 22);
            this.textBoxIpaddress.TabIndex = 10;
            this.textBoxIpaddress.Text = "192.168.1.24";
            // 
            // buttonPing
            // 
            this.buttonPing.Location = new System.Drawing.Point(338, 135);
            this.buttonPing.Name = "buttonPing";
            this.buttonPing.Size = new System.Drawing.Size(75, 23);
            this.buttonPing.TabIndex = 11;
            this.buttonPing.Text = "Ping";
            this.buttonPing.UseVisualStyleBackColor = true;
            this.buttonPing.Click += new System.EventHandler(this.buttonPing_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 710);
            this.Controls.Add(this.buttonPing);
            this.Controls.Add(this.textBoxIpaddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSendData);
            this.Controls.Add(this.buttonClearSend);
            this.Controls.Add(this.buttonClearout);
            this.Controls.Add(this.richTextBoxSend);
            this.Controls.Add(this.richTextBoxOut);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.buttonConnectAP);
            this.Controls.Add(this.buttonAccessPoint);
            this.Controls.Add(this.comboBoxStation);
            this.Controls.Add(this.buttonBaudrate);
            this.Controls.Add(this.buttonRF);
            this.Controls.Add(this.buttonStation);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonAT);
            this.Controls.Add(this.groupBox8);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button buttonAT;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolstripStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Button buttonStation;
        private System.Windows.Forms.Button buttonAccessPoint;
        private System.Windows.Forms.ComboBox comboBoxStation;
        private System.Windows.Forms.Button buttonConnectAP;
        private System.Windows.Forms.Label labelMac;
        private System.Windows.Forms.Label labelStation;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button buttonBaudrate;
        private System.Windows.Forms.Button buttonRF;
        private System.Windows.Forms.RichTextBox richTextBoxOut;
        private System.Windows.Forms.Button buttonClearout;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Button buttonGetip;
        private System.Windows.Forms.RichTextBox richTextBoxSend;
        private System.Windows.Forms.Button buttonClearSend;
        private System.Windows.Forms.Button buttonSendData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIpaddress;
        private System.Windows.Forms.Button buttonPing;
    }
}

