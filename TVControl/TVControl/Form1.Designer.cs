namespace TVControl
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
            this.ddbTV = new System.Windows.Forms.ComboBox();
            this.ddbModel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ddbCommType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progConnect = new System.Windows.Forms.ProgressBar();
            this.btnConnect = new System.Windows.Forms.Button();
            this.gbPower = new System.Windows.Forms.GroupBox();
            this.btnPowerOff = new System.Windows.Forms.Button();
            this.btnPowerOn = new System.Windows.Forms.Button();
            this.gbVolume = new System.Windows.Forms.GroupBox();
            this.txtVolInfo = new System.Windows.Forms.TextBox();
            this.btnVolDown = new System.Windows.Forms.Button();
            this.btnVolUp = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.gBoxRJ45 = new System.Windows.Forms.GroupBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIPAddr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gBoxRS232 = new System.Windows.Forms.GroupBox();
            this.ddbStopbits = new System.Windows.Forms.ComboBox();
            this.ddbDataBits = new System.Windows.Forms.ComboBox();
            this.ddbParity = new System.Windows.Forms.ComboBox();
            this.ddbBaudRate = new System.Windows.Forms.ComboBox();
            this.ddbPorts = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTVID = new System.Windows.Forms.TextBox();
            this.btnSetVolValue = new System.Windows.Forms.Button();
            this.btnVolMute = new System.Windows.Forms.Button();
            this.btnVolNotMute = new System.Windows.Forms.Button();
            this.gbPower.SuspendLayout();
            this.gbVolume.SuspendLayout();
            this.gBoxRJ45.SuspendLayout();
            this.gBoxRS232.SuspendLayout();
            this.SuspendLayout();
            // 
            // ddbTV
            // 
            this.ddbTV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddbTV.FormattingEnabled = true;
            this.ddbTV.Location = new System.Drawing.Point(45, 19);
            this.ddbTV.Name = "ddbTV";
            this.ddbTV.Size = new System.Drawing.Size(101, 21);
            this.ddbTV.TabIndex = 0;
            this.ddbTV.SelectedIndexChanged += new System.EventHandler(this.ddbTV_SelectedIndexChanged);
            // 
            // ddbModel
            // 
            this.ddbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddbModel.FormattingEnabled = true;
            this.ddbModel.Location = new System.Drawing.Point(296, 19);
            this.ddbModel.Name = "ddbModel";
            this.ddbModel.Size = new System.Drawing.Size(121, 21);
            this.ddbModel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "TV:";
            // 
            // ddbCommType
            // 
            this.ddbCommType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddbCommType.FormattingEnabled = true;
            this.ddbCommType.Location = new System.Drawing.Point(537, 20);
            this.ddbCommType.Name = "ddbCommType";
            this.ddbCommType.Size = new System.Drawing.Size(113, 21);
            this.ddbCommType.TabIndex = 4;
            this.ddbCommType.SelectedIndexChanged += new System.EventHandler(this.ddbCommType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Communication Type:";
            // 
            // progConnect
            // 
            this.progConnect.Location = new System.Drawing.Point(12, 159);
            this.progConnect.Name = "progConnect";
            this.progConnect.Size = new System.Drawing.Size(388, 26);
            this.progConnect.TabIndex = 11;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(409, 159);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(113, 26);
            this.btnConnect.TabIndex = 12;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // gbPower
            // 
            this.gbPower.Controls.Add(this.btnPowerOff);
            this.gbPower.Controls.Add(this.btnPowerOn);
            this.gbPower.Enabled = false;
            this.gbPower.Location = new System.Drawing.Point(12, 214);
            this.gbPower.Name = "gbPower";
            this.gbPower.Size = new System.Drawing.Size(211, 69);
            this.gbPower.TabIndex = 13;
            this.gbPower.TabStop = false;
            this.gbPower.Text = "Power";
            // 
            // btnPowerOff
            // 
            this.btnPowerOff.Location = new System.Drawing.Point(106, 25);
            this.btnPowerOff.Name = "btnPowerOff";
            this.btnPowerOff.Size = new System.Drawing.Size(94, 27);
            this.btnPowerOff.TabIndex = 1;
            this.btnPowerOff.Text = "Off";
            this.btnPowerOff.UseVisualStyleBackColor = true;
            this.btnPowerOff.Click += new System.EventHandler(this.btnPowerOff_Click);
            // 
            // btnPowerOn
            // 
            this.btnPowerOn.Location = new System.Drawing.Point(6, 25);
            this.btnPowerOn.Name = "btnPowerOn";
            this.btnPowerOn.Size = new System.Drawing.Size(94, 27);
            this.btnPowerOn.TabIndex = 0;
            this.btnPowerOn.Text = "On";
            this.btnPowerOn.UseVisualStyleBackColor = true;
            this.btnPowerOn.Click += new System.EventHandler(this.btnPowerOn_Click);
            // 
            // gbVolume
            // 
            this.gbVolume.Controls.Add(this.btnVolNotMute);
            this.gbVolume.Controls.Add(this.btnVolMute);
            this.gbVolume.Controls.Add(this.btnSetVolValue);
            this.gbVolume.Controls.Add(this.txtVolInfo);
            this.gbVolume.Controls.Add(this.btnVolDown);
            this.gbVolume.Controls.Add(this.btnVolUp);
            this.gbVolume.Location = new System.Drawing.Point(329, 214);
            this.gbVolume.Name = "gbVolume";
            this.gbVolume.Size = new System.Drawing.Size(322, 96);
            this.gbVolume.TabIndex = 14;
            this.gbVolume.TabStop = false;
            this.gbVolume.Text = "Volume";
            // 
            // txtVolInfo
            // 
            this.txtVolInfo.Enabled = false;
            this.txtVolInfo.Location = new System.Drawing.Point(136, 28);
            this.txtVolInfo.Name = "txtVolInfo";
            this.txtVolInfo.Size = new System.Drawing.Size(86, 20);
            this.txtVolInfo.TabIndex = 2;
            // 
            // btnVolDown
            // 
            this.btnVolDown.Location = new System.Drawing.Point(80, 26);
            this.btnVolDown.Name = "btnVolDown";
            this.btnVolDown.Size = new System.Drawing.Size(47, 26);
            this.btnVolDown.TabIndex = 1;
            this.btnVolDown.Text = "Down";
            this.btnVolDown.UseVisualStyleBackColor = true;
            this.btnVolDown.Click += new System.EventHandler(this.btnVolDown_Click);
            // 
            // btnVolUp
            // 
            this.btnVolUp.Location = new System.Drawing.Point(21, 26);
            this.btnVolUp.Name = "btnVolUp";
            this.btnVolUp.Size = new System.Drawing.Size(50, 26);
            this.btnVolUp.TabIndex = 0;
            this.btnVolUp.Text = "Up";
            this.btnVolUp.UseVisualStyleBackColor = true;
            this.btnVolUp.Click += new System.EventHandler(this.btnVolUp_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(538, 159);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(113, 26);
            this.btnDisconnect.TabIndex = 15;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // gBoxRJ45
            // 
            this.gBoxRJ45.Controls.Add(this.txtPort);
            this.gBoxRJ45.Controls.Add(this.txtIPAddr);
            this.gBoxRJ45.Controls.Add(this.label5);
            this.gBoxRJ45.Controls.Add(this.label4);
            this.gBoxRJ45.Location = new System.Drawing.Point(16, 56);
            this.gBoxRJ45.Name = "gBoxRJ45";
            this.gBoxRJ45.Size = new System.Drawing.Size(227, 85);
            this.gBoxRJ45.TabIndex = 16;
            this.gBoxRJ45.TabStop = false;
            this.gBoxRJ45.Text = "RJ45 Settings";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(84, 49);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(123, 20);
            this.txtPort.TabIndex = 3;
            // 
            // txtIPAddr
            // 
            this.txtIPAddr.Location = new System.Drawing.Point(84, 23);
            this.txtIPAddr.Name = "txtIPAddr";
            this.txtIPAddr.Size = new System.Drawing.Size(123, 20);
            this.txtIPAddr.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Port:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "IP Address:";
            // 
            // gBoxRS232
            // 
            this.gBoxRS232.Controls.Add(this.ddbStopbits);
            this.gBoxRS232.Controls.Add(this.ddbDataBits);
            this.gBoxRS232.Controls.Add(this.ddbParity);
            this.gBoxRS232.Controls.Add(this.ddbBaudRate);
            this.gBoxRS232.Controls.Add(this.ddbPorts);
            this.gBoxRS232.Controls.Add(this.label10);
            this.gBoxRS232.Controls.Add(this.label9);
            this.gBoxRS232.Controls.Add(this.label8);
            this.gBoxRS232.Controls.Add(this.label7);
            this.gBoxRS232.Controls.Add(this.label6);
            this.gBoxRS232.Location = new System.Drawing.Point(279, 56);
            this.gBoxRS232.Name = "gBoxRS232";
            this.gBoxRS232.Size = new System.Drawing.Size(371, 85);
            this.gBoxRS232.TabIndex = 17;
            this.gBoxRS232.TabStop = false;
            this.gBoxRS232.Text = "RS232 Settings";
            // 
            // ddbStopbits
            // 
            this.ddbStopbits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddbStopbits.FormattingEnabled = true;
            this.ddbStopbits.Location = new System.Drawing.Point(296, 48);
            this.ddbStopbits.Name = "ddbStopbits";
            this.ddbStopbits.Size = new System.Drawing.Size(54, 21);
            this.ddbStopbits.TabIndex = 9;
            // 
            // ddbDataBits
            // 
            this.ddbDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddbDataBits.FormattingEnabled = true;
            this.ddbDataBits.Location = new System.Drawing.Point(226, 48);
            this.ddbDataBits.Name = "ddbDataBits";
            this.ddbDataBits.Size = new System.Drawing.Size(54, 21);
            this.ddbDataBits.TabIndex = 8;
            // 
            // ddbParity
            // 
            this.ddbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddbParity.FormattingEnabled = true;
            this.ddbParity.Location = new System.Drawing.Point(156, 48);
            this.ddbParity.Name = "ddbParity";
            this.ddbParity.Size = new System.Drawing.Size(54, 21);
            this.ddbParity.TabIndex = 7;
            // 
            // ddbBaudRate
            // 
            this.ddbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddbBaudRate.FormattingEnabled = true;
            this.ddbBaudRate.Location = new System.Drawing.Point(88, 48);
            this.ddbBaudRate.Name = "ddbBaudRate";
            this.ddbBaudRate.Size = new System.Drawing.Size(54, 21);
            this.ddbBaudRate.TabIndex = 6;
            // 
            // ddbPorts
            // 
            this.ddbPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddbPorts.FormattingEnabled = true;
            this.ddbPorts.Location = new System.Drawing.Point(18, 48);
            this.ddbPorts.Name = "ddbPorts";
            this.ddbPorts.Size = new System.Drawing.Size(54, 21);
            this.ddbPorts.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(293, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Stopbits:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(223, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Databits:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(153, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Parity:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(85, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Baud Rate:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Port:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(152, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "TV ID:";
            // 
            // txtTVID
            // 
            this.txtTVID.Location = new System.Drawing.Point(196, 20);
            this.txtTVID.Name = "txtTVID";
            this.txtTVID.Size = new System.Drawing.Size(49, 20);
            this.txtTVID.TabIndex = 4;
            // 
            // btnSetVolValue
            // 
            this.btnSetVolValue.Location = new System.Drawing.Point(236, 26);
            this.btnSetVolValue.Name = "btnSetVolValue";
            this.btnSetVolValue.Size = new System.Drawing.Size(80, 23);
            this.btnSetVolValue.TabIndex = 3;
            this.btnSetVolValue.Text = "Set";
            this.btnSetVolValue.UseVisualStyleBackColor = true;
            this.btnSetVolValue.Click += new System.EventHandler(this.btnSetVolValue_Click);
            // 
            // btnVolMute
            // 
            this.btnVolMute.Location = new System.Drawing.Point(21, 58);
            this.btnVolMute.Name = "btnVolMute";
            this.btnVolMute.Size = new System.Drawing.Size(75, 23);
            this.btnVolMute.TabIndex = 4;
            this.btnVolMute.Text = "Mute";
            this.btnVolMute.UseVisualStyleBackColor = true;
            this.btnVolMute.Click += new System.EventHandler(this.btnVolMute_Click);
            // 
            // btnVolNotMute
            // 
            this.btnVolNotMute.Location = new System.Drawing.Point(106, 58);
            this.btnVolNotMute.Name = "btnVolNotMute";
            this.btnVolNotMute.Size = new System.Drawing.Size(75, 23);
            this.btnVolNotMute.TabIndex = 5;
            this.btnVolNotMute.Text = "Not mute";
            this.btnVolNotMute.UseVisualStyleBackColor = true;
            this.btnVolNotMute.Click += new System.EventHandler(this.btnVolNotMute_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 332);
            this.Controls.Add(this.txtTVID);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.gBoxRS232);
            this.Controls.Add(this.gBoxRJ45);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.gbVolume);
            this.Controls.Add(this.gbPower);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.progConnect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ddbCommType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ddbModel);
            this.Controls.Add(this.ddbTV);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbPower.ResumeLayout(false);
            this.gbVolume.ResumeLayout(false);
            this.gbVolume.PerformLayout();
            this.gBoxRJ45.ResumeLayout(false);
            this.gBoxRJ45.PerformLayout();
            this.gBoxRS232.ResumeLayout(false);
            this.gBoxRS232.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ddbTV;
        private System.Windows.Forms.ComboBox ddbModel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddbCommType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progConnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox gbPower;
        private System.Windows.Forms.Button btnPowerOff;
        private System.Windows.Forms.Button btnPowerOn;
        private System.Windows.Forms.GroupBox gbVolume;
        private System.Windows.Forms.TextBox txtVolInfo;
        private System.Windows.Forms.Button btnVolDown;
        private System.Windows.Forms.Button btnVolUp;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.GroupBox gBoxRJ45;
        private System.Windows.Forms.GroupBox gBoxRS232;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIPAddr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox ddbStopbits;
        private System.Windows.Forms.ComboBox ddbDataBits;
        private System.Windows.Forms.ComboBox ddbParity;
        private System.Windows.Forms.ComboBox ddbBaudRate;
        private System.Windows.Forms.ComboBox ddbPorts;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTVID;
        private System.Windows.Forms.Button btnVolMute;
        private System.Windows.Forms.Button btnSetVolValue;
        private System.Windows.Forms.Button btnVolNotMute;
    }
}

