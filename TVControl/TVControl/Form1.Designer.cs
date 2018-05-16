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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progConnect = new System.Windows.Forms.ProgressBar();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.gBoxRJ45 = new System.Windows.Forms.GroupBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIPAddr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gBoxRS232 = new System.Windows.Forms.GroupBox();
            this.txtStopbits = new System.Windows.Forms.TextBox();
            this.txtDatabits = new System.Windows.Forms.TextBox();
            this.txtParity = new System.Windows.Forms.TextBox();
            this.txtBaudRate = new System.Windows.Forms.TextBox();
            this.txtCom = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTVID = new System.Windows.Forms.TextBox();
            this.btnRunApp = new System.Windows.Forms.Button();
            this.txtTVModel = new System.Windows.Forms.TextBox();
            this.txtTVSeries = new System.Windows.Forms.TextBox();
            this.txtCommunicationType = new System.Windows.Forms.TextBox();
            this.gBoxRJ45.SuspendLayout();
            this.gBoxRS232.SuspendLayout();
            this.SuspendLayout();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Series:";
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
            this.txtPort.Enabled = false;
            this.txtPort.Location = new System.Drawing.Point(84, 49);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(123, 20);
            this.txtPort.TabIndex = 3;
            // 
            // txtIPAddr
            // 
            this.txtIPAddr.Enabled = false;
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
            this.gBoxRS232.Controls.Add(this.txtStopbits);
            this.gBoxRS232.Controls.Add(this.txtDatabits);
            this.gBoxRS232.Controls.Add(this.txtParity);
            this.gBoxRS232.Controls.Add(this.txtBaudRate);
            this.gBoxRS232.Controls.Add(this.txtCom);
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
            // txtStopbits
            // 
            this.txtStopbits.Enabled = false;
            this.txtStopbits.Location = new System.Drawing.Point(295, 49);
            this.txtStopbits.Name = "txtStopbits";
            this.txtStopbits.Size = new System.Drawing.Size(58, 20);
            this.txtStopbits.TabIndex = 26;
            // 
            // txtDatabits
            // 
            this.txtDatabits.Enabled = false;
            this.txtDatabits.Location = new System.Drawing.Point(226, 49);
            this.txtDatabits.Name = "txtDatabits";
            this.txtDatabits.Size = new System.Drawing.Size(46, 20);
            this.txtDatabits.TabIndex = 25;
            // 
            // txtParity
            // 
            this.txtParity.Enabled = false;
            this.txtParity.Location = new System.Drawing.Point(156, 49);
            this.txtParity.Name = "txtParity";
            this.txtParity.Size = new System.Drawing.Size(51, 20);
            this.txtParity.TabIndex = 24;
            // 
            // txtBaudRate
            // 
            this.txtBaudRate.Enabled = false;
            this.txtBaudRate.Location = new System.Drawing.Point(80, 49);
            this.txtBaudRate.Name = "txtBaudRate";
            this.txtBaudRate.Size = new System.Drawing.Size(58, 20);
            this.txtBaudRate.TabIndex = 23;
            // 
            // txtCom
            // 
            this.txtCom.Enabled = false;
            this.txtCom.Location = new System.Drawing.Point(17, 49);
            this.txtCom.Name = "txtCom";
            this.txtCom.Size = new System.Drawing.Size(47, 20);
            this.txtCom.TabIndex = 22;
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
            this.label7.Location = new System.Drawing.Point(77, 23);
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
            this.txtTVID.Enabled = false;
            this.txtTVID.Location = new System.Drawing.Point(196, 20);
            this.txtTVID.Name = "txtTVID";
            this.txtTVID.Size = new System.Drawing.Size(49, 20);
            this.txtTVID.TabIndex = 4;
            // 
            // btnRunApp
            // 
            this.btnRunApp.Location = new System.Drawing.Point(13, 197);
            this.btnRunApp.Name = "btnRunApp";
            this.btnRunApp.Size = new System.Drawing.Size(638, 43);
            this.btnRunApp.TabIndex = 19;
            this.btnRunApp.Text = "Run";
            this.btnRunApp.UseVisualStyleBackColor = true;
            this.btnRunApp.Click += new System.EventHandler(this.btnRunApp_Click);
            // 
            // txtTVModel
            // 
            this.txtTVModel.Enabled = false;
            this.txtTVModel.Location = new System.Drawing.Point(45, 20);
            this.txtTVModel.Name = "txtTVModel";
            this.txtTVModel.Size = new System.Drawing.Size(99, 20);
            this.txtTVModel.TabIndex = 20;
            // 
            // txtTVSeries
            // 
            this.txtTVSeries.Enabled = false;
            this.txtTVSeries.Location = new System.Drawing.Point(296, 20);
            this.txtTVSeries.Name = "txtTVSeries";
            this.txtTVSeries.Size = new System.Drawing.Size(121, 20);
            this.txtTVSeries.TabIndex = 21;
            // 
            // txtCommunicationType
            // 
            this.txtCommunicationType.Enabled = false;
            this.txtCommunicationType.Location = new System.Drawing.Point(535, 20);
            this.txtCommunicationType.Name = "txtCommunicationType";
            this.txtCommunicationType.Size = new System.Drawing.Size(115, 20);
            this.txtCommunicationType.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 252);
            this.Controls.Add(this.txtCommunicationType);
            this.Controls.Add(this.txtTVSeries);
            this.Controls.Add(this.txtTVModel);
            this.Controls.Add(this.btnRunApp);
            this.Controls.Add(this.txtTVID);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.gBoxRS232);
            this.Controls.Add(this.gBoxRJ45);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.progConnect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gBoxRJ45.ResumeLayout(false);
            this.gBoxRJ45.PerformLayout();
            this.gBoxRS232.ResumeLayout(false);
            this.gBoxRS232.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progConnect;
        private System.Windows.Forms.Button btnConnect;
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
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTVID;
        private System.Windows.Forms.Button btnRunApp;
        private System.Windows.Forms.TextBox txtTVModel;
        private System.Windows.Forms.TextBox txtTVSeries;
        private System.Windows.Forms.TextBox txtCommunicationType;
        private System.Windows.Forms.TextBox txtStopbits;
        private System.Windows.Forms.TextBox txtDatabits;
        private System.Windows.Forms.TextBox txtParity;
        private System.Windows.Forms.TextBox txtBaudRate;
        private System.Windows.Forms.TextBox txtCom;
    }
}

