
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
            this.buttonClear = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.labelAH = new System.Windows.Forms.Label();
            this.labelAL = new System.Windows.Forms.Label();
            this.labelURV = new System.Windows.Forms.Label();
            this.labelLRV = new System.Windows.Forms.Label();
            this.labelTag = new System.Windows.Forms.Label();
            this.textBoxAH = new System.Windows.Forms.TextBox();
            this.textBoxAL = new System.Windows.Forms.TextBox();
            this.textBoxURV = new System.Windows.Forms.TextBox();
            this.textBoxLRV = new System.Windows.Forms.TextBox();
            this.textBoxTag = new System.Windows.Forms.TextBox();
            this.tabPageConnection = new System.Windows.Forms.TabPage();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelBitrate = new System.Windows.Forms.Label();
            this.labelCom = new System.Windows.Forms.Label();
            this.radioButtonConnected = new System.Windows.Forms.RadioButton();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.ComboBoxBaud = new System.Windows.Forms.ComboBox();
            this.ComboBoxPorts = new System.Windows.Forms.ComboBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageCommand = new System.Windows.Forms.TabPage();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.textBoxReceive = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonReceive = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.labelInput = new System.Windows.Forms.Label();
            this.tabPageGraph = new System.Windows.Forms.TabPage();
            this.timerReceive = new System.Windows.Forms.Timer(this.components);
            this.timerChart = new System.Windows.Forms.Timer(this.components);
            this.tabPageConfiguration.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabPageConnection.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageCommand.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageConfiguration
            // 
            this.tabPageConfiguration.BackColor = System.Drawing.Color.SlateGray;
            this.tabPageConfiguration.Controls.Add(this.buttonClear);
            this.tabPageConfiguration.Controls.Add(this.statusStrip1);
            this.tabPageConfiguration.Controls.Add(this.button2);
            this.tabPageConfiguration.Controls.Add(this.button1);
            this.tabPageConfiguration.Controls.Add(this.buttonLoad);
            this.tabPageConfiguration.Controls.Add(this.labelAH);
            this.tabPageConfiguration.Controls.Add(this.labelAL);
            this.tabPageConfiguration.Controls.Add(this.labelURV);
            this.tabPageConfiguration.Controls.Add(this.labelLRV);
            this.tabPageConfiguration.Controls.Add(this.labelTag);
            this.tabPageConfiguration.Controls.Add(this.textBoxAH);
            this.tabPageConfiguration.Controls.Add(this.textBoxAL);
            this.tabPageConfiguration.Controls.Add(this.textBoxURV);
            this.tabPageConfiguration.Controls.Add(this.textBoxLRV);
            this.tabPageConfiguration.Controls.Add(this.textBoxTag);
            this.tabPageConfiguration.Location = new System.Drawing.Point(4, 22);
            this.tabPageConfiguration.Name = "tabPageConfiguration";
            this.tabPageConfiguration.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConfiguration.Size = new System.Drawing.Size(524, 304);
            this.tabPageConfiguration.TabIndex = 1;
            this.tabPageConfiguration.Text = "Configuration";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(353, 190);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 16;
            this.buttonClear.Text = "Clear Values";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(3, 279);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(518, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Lavender;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Ready";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(272, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(110, 190);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 12;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelAH
            // 
            this.labelAH.AutoSize = true;
            this.labelAH.Location = new System.Drawing.Point(45, 164);
            this.labelAH.Name = "labelAH";
            this.labelAH.Size = new System.Drawing.Size(59, 13);
            this.labelAH.TabIndex = 10;
            this.labelAH.Text = "Alarm high:";
            // 
            // labelAL
            // 
            this.labelAL.AutoSize = true;
            this.labelAL.Location = new System.Drawing.Point(49, 138);
            this.labelAL.Name = "labelAL";
            this.labelAL.Size = new System.Drawing.Size(55, 13);
            this.labelAL.TabIndex = 9;
            this.labelAL.Text = "Alarm low:";
            // 
            // labelURV
            // 
            this.labelURV.AutoSize = true;
            this.labelURV.Location = new System.Drawing.Point(11, 112);
            this.labelURV.Name = "labelURV";
            this.labelURV.Size = new System.Drawing.Size(98, 13);
            this.labelURV.TabIndex = 8;
            this.labelURV.Text = "Upper range value:";
            // 
            // labelLRV
            // 
            this.labelLRV.AutoSize = true;
            this.labelLRV.Location = new System.Drawing.Point(11, 86);
            this.labelLRV.Name = "labelLRV";
            this.labelLRV.Size = new System.Drawing.Size(98, 13);
            this.labelLRV.TabIndex = 7;
            this.labelLRV.Text = "Lower range value:";
            this.labelLRV.MouseHover += new System.EventHandler(this.labelLRV_MouseHover);
            // 
            // labelTag
            // 
            this.labelTag.AutoSize = true;
            this.labelTag.Location = new System.Drawing.Point(49, 63);
            this.labelTag.Name = "labelTag";
            this.labelTag.Size = new System.Drawing.Size(55, 13);
            this.labelTag.TabIndex = 6;
            this.labelTag.Text = "Tagname:";
            this.labelTag.MouseHover += new System.EventHandler(this.labelTag_MouseHover);
            // 
            // textBoxAH
            // 
            this.textBoxAH.Location = new System.Drawing.Point(110, 164);
            this.textBoxAH.Name = "textBoxAH";
            this.textBoxAH.Size = new System.Drawing.Size(318, 20);
            this.textBoxAH.TabIndex = 5;
            // 
            // textBoxAL
            // 
            this.textBoxAL.Location = new System.Drawing.Point(110, 138);
            this.textBoxAL.Name = "textBoxAL";
            this.textBoxAL.Size = new System.Drawing.Size(318, 20);
            this.textBoxAL.TabIndex = 4;
            // 
            // textBoxURV
            // 
            this.textBoxURV.Location = new System.Drawing.Point(110, 112);
            this.textBoxURV.Name = "textBoxURV";
            this.textBoxURV.Size = new System.Drawing.Size(318, 20);
            this.textBoxURV.TabIndex = 3;
            // 
            // textBoxLRV
            // 
            this.textBoxLRV.Location = new System.Drawing.Point(110, 86);
            this.textBoxLRV.Name = "textBoxLRV";
            this.textBoxLRV.Size = new System.Drawing.Size(318, 20);
            this.textBoxLRV.TabIndex = 2;
            // 
            // textBoxTag
            // 
            this.textBoxTag.Location = new System.Drawing.Point(110, 60);
            this.textBoxTag.Name = "textBoxTag";
            this.textBoxTag.Size = new System.Drawing.Size(318, 20);
            this.textBoxTag.TabIndex = 0;
            this.textBoxTag.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tabPageConnection
            // 
            this.tabPageConnection.BackColor = System.Drawing.Color.SlateGray;
            this.tabPageConnection.Controls.Add(this.statusStrip);
            this.tabPageConnection.Controls.Add(this.labelBitrate);
            this.tabPageConnection.Controls.Add(this.labelCom);
            this.tabPageConnection.Controls.Add(this.radioButtonConnected);
            this.tabPageConnection.Controls.Add(this.buttonDisconnect);
            this.tabPageConnection.Controls.Add(this.buttonConnect);
            this.tabPageConnection.Controls.Add(this.ComboBoxBaud);
            this.tabPageConnection.Controls.Add(this.ComboBoxPorts);
            this.tabPageConnection.ForeColor = System.Drawing.SystemColors.Desktop;
            this.tabPageConnection.Location = new System.Drawing.Point(4, 22);
            this.tabPageConnection.Name = "tabPageConnection";
            this.tabPageConnection.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConnection.Size = new System.Drawing.Size(524, 304);
            this.tabPageConnection.TabIndex = 0;
            this.tabPageConnection.Text = "Connection";
            this.tabPageConnection.Enter += new System.EventHandler(this.tabPageConnection_Enter);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(3, 279);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(518, 22);
            this.statusStrip.TabIndex = 7;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.BackColor = System.Drawing.Color.SlateGray;
            this.toolStripStatusLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.toolStripStatusLabel.ImageTransparentColor = System.Drawing.Color.Gray;
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Ready";
            // 
            // labelBitrate
            // 
            this.labelBitrate.AutoSize = true;
            this.labelBitrate.Location = new System.Drawing.Point(18, 93);
            this.labelBitrate.Name = "labelBitrate";
            this.labelBitrate.Size = new System.Drawing.Size(40, 13);
            this.labelBitrate.TabIndex = 6;
            this.labelBitrate.Text = "Bitrate:";
            this.labelBitrate.MouseHover += new System.EventHandler(this.labelBitrate_MouseHover);
            // 
            // labelCom
            // 
            this.labelCom.AutoSize = true;
            this.labelCom.Location = new System.Drawing.Point(8, 52);
            this.labelCom.Name = "labelCom";
            this.labelCom.Size = new System.Drawing.Size(50, 13);
            this.labelCom.TabIndex = 5;
            this.labelCom.Text = "ComPort:";
            this.labelCom.MouseHover += new System.EventHandler(this.labelCom_MouseHover);
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
            this.buttonDisconnect.MouseHover += new System.EventHandler(this.buttonDisconnect_MouseHover);
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
            this.buttonConnect.MouseHover += new System.EventHandler(this.buttonConnect_MouseHover);
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
            this.tabControl.Controls.Add(this.tabPageCommand);
            this.tabControl.Controls.Add(this.tabPageGraph);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(532, 330);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageCommand
            // 
            this.tabPageCommand.Controls.Add(this.labelInput);
            this.tabPageCommand.Controls.Add(this.buttonReceive);
            this.tabPageCommand.Controls.Add(this.buttonSend);
            this.tabPageCommand.Controls.Add(this.textBoxSend);
            this.tabPageCommand.Controls.Add(this.textBoxReceive);
            this.tabPageCommand.Location = new System.Drawing.Point(4, 22);
            this.tabPageCommand.Name = "tabPageCommand";
            this.tabPageCommand.Size = new System.Drawing.Size(524, 304);
            this.tabPageCommand.TabIndex = 2;
            this.tabPageCommand.Text = "Command";
            this.tabPageCommand.UseVisualStyleBackColor = true;
            // 
            // textBoxSend
            // 
            this.textBoxSend.Location = new System.Drawing.Point(117, 32);
            this.textBoxSend.Multiline = true;
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.Size = new System.Drawing.Size(198, 23);
            this.textBoxSend.TabIndex = 1;
            // 
            // textBoxReceive
            // 
            this.textBoxReceive.Location = new System.Drawing.Point(117, 63);
            this.textBoxReceive.Multiline = true;
            this.textBoxReceive.Name = "textBoxReceive";
            this.textBoxReceive.ReadOnly = true;
            this.textBoxReceive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxReceive.Size = new System.Drawing.Size(198, 149);
            this.textBoxReceive.TabIndex = 0;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(117, 218);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(101, 23);
            this.buttonSend.TabIndex = 2;
            this.buttonSend.Text = "Send values";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonReceive
            // 
            this.buttonReceive.Location = new System.Drawing.Point(224, 218);
            this.buttonReceive.Name = "buttonReceive";
            this.buttonReceive.Size = new System.Drawing.Size(91, 23);
            this.buttonReceive.TabIndex = 3;
            this.buttonReceive.Text = "Receive values";
            this.buttonReceive.UseVisualStyleBackColor = true;
            this.buttonReceive.Click += new System.EventHandler(this.buttonReceive_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(80, 35);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(34, 13);
            this.labelInput.TabIndex = 4;
            this.labelInput.Text = "Input:";
            // 
            // tabPageGraph
            // 
            this.tabPageGraph.Location = new System.Drawing.Point(4, 22);
            this.tabPageGraph.Name = "tabPageGraph";
            this.tabPageGraph.Size = new System.Drawing.Size(524, 304);
            this.tabPageGraph.TabIndex = 3;
            this.tabPageGraph.Text = "Gaphical view";
            this.tabPageGraph.UseVisualStyleBackColor = true;
            // 
            // timerReceive
            // 
            this.timerReceive.Tick += new System.EventHandler(this.timerReceive_Tick);
            // 
            // timerChart
            // 
            this.timerChart.Tick += new System.EventHandler(this.timerChart_Tick);
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
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabPageConnection.ResumeLayout(false);
            this.tabPageConnection.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageCommand.ResumeLayout(false);
            this.tabPageCommand.PerformLayout();
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
        private System.Windows.Forms.TextBox textBoxTag;
        private System.Windows.Forms.TextBox textBoxAH;
        private System.Windows.Forms.TextBox textBoxAL;
        private System.Windows.Forms.TextBox textBoxURV;
        private System.Windows.Forms.TextBox textBoxLRV;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Label labelAH;
        private System.Windows.Forms.Label labelAL;
        private System.Windows.Forms.Label labelURV;
        private System.Windows.Forms.Label labelLRV;
        private System.Windows.Forms.Label labelTag;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TabPage tabPageCommand;
        private System.Windows.Forms.TextBox textBoxSend;
        private System.Windows.Forms.TextBox textBoxReceive;
        private System.Windows.Forms.Button buttonReceive;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.TabPage tabPageGraph;
        private System.Windows.Forms.Timer timerReceive;
        private System.Windows.Forms.Timer timerChart;
    }
}

