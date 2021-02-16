
namespace SoftSensConf
{
    partial class SoftSensConf
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
            this.components = new System.ComponentModel.Container();
            this.tabPageConfiguration = new System.Windows.Forms.TabPage();
            this.tabPageConnection = new System.Windows.Forms.TabPage();
            this.radioButtonConnected = new System.Windows.Forms.RadioButton();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.ComboBoxBaud = new System.Windows.Forms.ComboBox();
            this.ComboBoxPorts = new System.Windows.Forms.ComboBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.labelCom = new System.Windows.Forms.Label();
            this.labelBitrate = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPageConfiguration.SuspendLayout();
            this.tabPageConnection.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageConfiguration
            // 
            this.tabPageConfiguration.Controls.Add(this.button1);
            this.tabPageConfiguration.Controls.Add(this.textBox1);
            this.tabPageConfiguration.Location = new System.Drawing.Point(4, 22);
            this.tabPageConfiguration.Name = "tabPageConfiguration";
            this.tabPageConfiguration.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConfiguration.Size = new System.Drawing.Size(524, 304);
            this.tabPageConfiguration.TabIndex = 1;
            this.tabPageConfiguration.Text = "Configuration";
            this.tabPageConfiguration.UseVisualStyleBackColor = true;
            // 
            // tabPageConnection
            // 
            this.tabPageConnection.Controls.Add(this.labelBitrate);
            this.tabPageConnection.Controls.Add(this.labelCom);
            this.tabPageConnection.Controls.Add(this.radioButtonConnected);
            this.tabPageConnection.Controls.Add(this.buttonDisconnect);
            this.tabPageConnection.Controls.Add(this.buttonConnect);
            this.tabPageConnection.Controls.Add(this.ComboBoxBaud);
            this.tabPageConnection.Controls.Add(this.ComboBoxPorts);
            this.tabPageConnection.Location = new System.Drawing.Point(4, 22);
            this.tabPageConnection.Name = "tabPageConnection";
            this.tabPageConnection.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConnection.Size = new System.Drawing.Size(654, 424);
            this.tabPageConnection.TabIndex = 0;
            this.tabPageConnection.Text = "Connection";
            this.tabPageConnection.UseVisualStyleBackColor = true;
            // 
            // radioButtonConnected
            // 
            this.radioButtonConnected.AutoSize = true;
            this.radioButtonConnected.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonConnected.ForeColor = System.Drawing.Color.LimeGreen;
            this.radioButtonConnected.Location = new System.Drawing.Point(151, 122);
            this.radioButtonConnected.Name = "radioButtonConnected";
            this.radioButtonConnected.Size = new System.Drawing.Size(14, 13);
            this.radioButtonConnected.TabIndex = 4;
            this.radioButtonConnected.TabStop = true;
            this.radioButtonConnected.UseVisualStyleBackColor = false;
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(61, 148);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(84, 23);
            this.buttonDisconnect.TabIndex = 3;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(61, 119);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(84, 23);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // ComboBoxBaud
            // 
            this.ComboBoxBaud.FormattingEnabled = true;
            this.ComboBoxBaud.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "76800",
            "153600"});
            this.ComboBoxBaud.Location = new System.Drawing.Point(61, 90);
            this.ComboBoxBaud.Name = "ComboBoxBaud";
            this.ComboBoxBaud.Size = new System.Drawing.Size(148, 21);
            this.ComboBoxBaud.TabIndex = 1;
            // 
            // ComboBoxPorts
            // 
            this.ComboBoxPorts.FormattingEnabled = true;
            this.ComboBoxPorts.Location = new System.Drawing.Point(61, 49);
            this.ComboBoxPorts.Name = "ComboBoxPorts";
            this.ComboBoxPorts.Size = new System.Drawing.Size(148, 21);
            this.ComboBoxPorts.TabIndex = 0;
            this.ComboBoxPorts.Enter += new System.EventHandler(this.comboBoxPorts_Enter);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageConnection);
            this.tabControl.Controls.Add(this.tabPageConfiguration);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(532, 330);
            this.tabControl.TabIndex = 0;
            // 
            // labelCom
            // 
            this.labelCom.AutoSize = true;
            this.labelCom.Location = new System.Drawing.Point(8, 52);
            this.labelCom.Name = "labelCom";
            this.labelCom.Size = new System.Drawing.Size(50, 13);
            this.labelCom.TabIndex = 5;
            this.labelCom.Text = "ComPort:";
            // 
            // labelBitrate
            // 
            this.labelBitrate.AutoSize = true;
            this.labelBitrate.Location = new System.Drawing.Point(18, 93);
            this.labelBitrate.Name = "labelBitrate";
            this.labelBitrate.Size = new System.Drawing.Size(40, 13);
            this.labelBitrate.TabIndex = 6;
            this.labelBitrate.Text = "Bitrate:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "buttonOpen";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SoftSensConf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 330);
            this.Controls.Add(this.tabControl);
            this.Name = "SoftSensConf";
            this.Text = "SoftSensConf";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPageConfiguration.ResumeLayout(false);
            this.tabPageConfiguration.PerformLayout();
            this.tabPageConnection.ResumeLayout(false);
            this.tabPageConnection.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageConfiguration;
        private System.Windows.Forms.TabPage tabPageConnection;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.ComboBox ComboBoxBaud;
        private System.Windows.Forms.ComboBox ComboBoxPorts;
        private System.Windows.Forms.TabControl tabControl;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.RadioButton radioButtonConnected;
        private System.Windows.Forms.Label labelBitrate;
        private System.Windows.Forms.Label labelCom;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

