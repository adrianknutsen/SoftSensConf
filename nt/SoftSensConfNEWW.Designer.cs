
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
            System.Windows.Forms.Label dAU_IdLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label rDC_IdLabel;
            System.Windows.Forms.Label area_IdLabel;
            System.Windows.Forms.Label model_IdLabel;
            System.Windows.Forms.Label communication_IdLabel;
            System.Windows.Forms.Label manufactor_IdLabel;
            System.Windows.Forms.Label category_IdLabel;
            System.Windows.Forms.Label cOMPortLabel;
            System.Windows.Forms.Label bAUDRateLabel;
            System.Windows.Forms.Label configuration_edit_dateLabel;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabPageConfiguration = new System.Windows.Forms.TabPage();
            this.textBoxConnectionP1 = new System.Windows.Forms.TextBox();
            this.buttonRetrieve = new System.Windows.Forms.Button();
            this.buttonSendValues = new System.Windows.Forms.Button();
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
            this.button3 = new System.Windows.Forms.Button();
            this.comboBoxFindDevice = new System.Windows.Forms.ComboBox();
            this.LabelFindDevice = new System.Windows.Forms.Label();
            this.dAU_IdTextBox = new System.Windows.Forms.TextBox();
            this.dAUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.softsenseconfDataSet = new softsenseconfDataSet();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.rDC_IdTextBox = new System.Windows.Forms.TextBox();
            this.area_IdTextBox = new System.Windows.Forms.TextBox();
            this.model_IdTextBox = new System.Windows.Forms.TextBox();
            this.communication_IdTextBox = new System.Windows.Forms.TextBox();
            this.manufactor_IdTextBox = new System.Windows.Forms.TextBox();
            this.category_IdTextBox = new System.Windows.Forms.TextBox();
            this.cOMPortTextBox = new System.Windows.Forms.TextBox();
            this.bAUDRateTextBox = new System.Windows.Forms.TextBox();
            this.configuration_edit_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelBitrate = new System.Windows.Forms.Label();
            this.labelCom = new System.Windows.Forms.Label();
            this.radioButtonConnected = new System.Windows.Forms.RadioButton();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.ComboBoxBaud = new System.Windows.Forms.ComboBox();
            this.ComboBoxPorts = new System.Windows.Forms.ComboBox();
            this.dAUonlyID_DESBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dAUonlyID_DESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabInstrument = new System.Windows.Forms.TabControl();
            this.tabPageCommand = new System.Windows.Forms.TabPage();
            this.textBoxConnectionP2 = new System.Windows.Forms.TextBox();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelInput = new System.Windows.Forms.Label();
            this.buttonReceive = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.textBoxReceive = new System.Windows.Forms.TextBox();
            this.tabPageGraph = new System.Windows.Forms.TabPage();
            this.textBoxConnectionP3 = new System.Windows.Forms.TextBox();
            this.statusStrip3 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonSavetofile = new System.Windows.Forms.Button();
            this.buttonClearV = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonScaled = new System.Windows.Forms.Button();
            this.listBoxReading = new System.Windows.Forms.ListBox();
            this.buttonRaw = new System.Windows.Forms.Button();
            this.chartPoints = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timerReceive = new System.Windows.Forms.Timer(this.components);
            this.timerChartRaw = new System.Windows.Forms.Timer(this.components);
            this.timerChartScaled = new System.Windows.Forms.Timer(this.components);
            this.timerStatus = new System.Windows.Forms.Timer(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dAUTableAdapter = new softsenseconfDataSetTableAdapters.DAUTableAdapter();
            this.tableAdapterManager = new softsenseconfDataSetTableAdapters.TableAdapterManager();
            this.dAUonlyID_DESTableAdapter = new softsenseconfDataSetTableAdapters.DAUonlyID_DESTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            dAU_IdLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            rDC_IdLabel = new System.Windows.Forms.Label();
            area_IdLabel = new System.Windows.Forms.Label();
            model_IdLabel = new System.Windows.Forms.Label();
            communication_IdLabel = new System.Windows.Forms.Label();
            manufactor_IdLabel = new System.Windows.Forms.Label();
            category_IdLabel = new System.Windows.Forms.Label();
            cOMPortLabel = new System.Windows.Forms.Label();
            bAUDRateLabel = new System.Windows.Forms.Label();
            configuration_edit_dateLabel = new System.Windows.Forms.Label();
            this.tabPageConfiguration.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabPageConnection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dAUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.softsenseconfDataSet)).BeginInit();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dAUonlyID_DESBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAUonlyID_DESBindingSource)).BeginInit();
            this.tabInstrument.SuspendLayout();
            this.tabPageCommand.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.tabPageGraph.SuspendLayout();
            this.statusStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dAU_IdLabel
            // 
            dAU_IdLabel.AutoSize = true;
            dAU_IdLabel.Location = new System.Drawing.Point(288, 77);
            dAU_IdLabel.Name = "dAU_IdLabel";
            dAU_IdLabel.Size = new System.Drawing.Size(45, 13);
            dAU_IdLabel.TabIndex = 8;
            dAU_IdLabel.Text = "DAU Id:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(288, 103);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 10;
            descriptionLabel.Text = "Description:";
            // 
            // rDC_IdLabel
            // 
            rDC_IdLabel.AutoSize = true;
            rDC_IdLabel.Location = new System.Drawing.Point(288, 129);
            rDC_IdLabel.Name = "rDC_IdLabel";
            rDC_IdLabel.Size = new System.Drawing.Size(45, 13);
            rDC_IdLabel.TabIndex = 12;
            rDC_IdLabel.Text = "RDC Id:";
            // 
            // area_IdLabel
            // 
            area_IdLabel.AutoSize = true;
            area_IdLabel.Location = new System.Drawing.Point(288, 155);
            area_IdLabel.Name = "area_IdLabel";
            area_IdLabel.Size = new System.Drawing.Size(44, 13);
            area_IdLabel.TabIndex = 14;
            area_IdLabel.Text = "Area Id:";
            // 
            // model_IdLabel
            // 
            model_IdLabel.AutoSize = true;
            model_IdLabel.Location = new System.Drawing.Point(288, 181);
            model_IdLabel.Name = "model_IdLabel";
            model_IdLabel.Size = new System.Drawing.Size(51, 13);
            model_IdLabel.TabIndex = 16;
            model_IdLabel.Text = "Model Id:";
            // 
            // communication_IdLabel
            // 
            communication_IdLabel.AutoSize = true;
            communication_IdLabel.Location = new System.Drawing.Point(288, 207);
            communication_IdLabel.Name = "communication_IdLabel";
            communication_IdLabel.Size = new System.Drawing.Size(94, 13);
            communication_IdLabel.TabIndex = 18;
            communication_IdLabel.Text = "Communication Id:";
            // 
            // manufactor_IdLabel
            // 
            manufactor_IdLabel.AutoSize = true;
            manufactor_IdLabel.Location = new System.Drawing.Point(288, 233);
            manufactor_IdLabel.Name = "manufactor_IdLabel";
            manufactor_IdLabel.Size = new System.Drawing.Size(76, 13);
            manufactor_IdLabel.TabIndex = 20;
            manufactor_IdLabel.Text = "Manufactor Id:";
            // 
            // category_IdLabel
            // 
            category_IdLabel.AutoSize = true;
            category_IdLabel.Location = new System.Drawing.Point(288, 259);
            category_IdLabel.Name = "category_IdLabel";
            category_IdLabel.Size = new System.Drawing.Size(64, 13);
            category_IdLabel.TabIndex = 22;
            category_IdLabel.Text = "Category Id:";
            // 
            // cOMPortLabel
            // 
            cOMPortLabel.AutoSize = true;
            cOMPortLabel.Location = new System.Drawing.Point(288, 285);
            cOMPortLabel.Name = "cOMPortLabel";
            cOMPortLabel.Size = new System.Drawing.Size(53, 13);
            cOMPortLabel.TabIndex = 24;
            cOMPortLabel.Text = "COMPort:";
            // 
            // bAUDRateLabel
            // 
            bAUDRateLabel.AutoSize = true;
            bAUDRateLabel.Location = new System.Drawing.Point(288, 311);
            bAUDRateLabel.Name = "bAUDRateLabel";
            bAUDRateLabel.Size = new System.Drawing.Size(63, 13);
            bAUDRateLabel.TabIndex = 26;
            bAUDRateLabel.Text = "BAUDRate:";
            // 
            // configuration_edit_dateLabel
            // 
            configuration_edit_dateLabel.AutoSize = true;
            configuration_edit_dateLabel.Location = new System.Drawing.Point(288, 338);
            configuration_edit_dateLabel.Name = "configuration_edit_dateLabel";
            configuration_edit_dateLabel.Size = new System.Drawing.Size(116, 13);
            configuration_edit_dateLabel.TabIndex = 28;
            configuration_edit_dateLabel.Text = "Configuration edit date:";
            // 
            // tabPageConfiguration
            // 
            this.tabPageConfiguration.BackColor = System.Drawing.Color.Gray;
            this.tabPageConfiguration.Controls.Add(this.textBoxConnectionP1);
            this.tabPageConfiguration.Controls.Add(this.buttonRetrieve);
            this.tabPageConfiguration.Controls.Add(this.buttonSendValues);
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
            this.tabPageConfiguration.Size = new System.Drawing.Size(679, 389);
            this.tabPageConfiguration.TabIndex = 1;
            this.tabPageConfiguration.Text = "Configuration";
            // 
            // textBoxConnectionP1
            // 
            this.textBoxConnectionP1.BackColor = System.Drawing.Color.Gray;
            this.textBoxConnectionP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConnectionP1.ForeColor = System.Drawing.Color.Lime;
            this.textBoxConnectionP1.Location = new System.Drawing.Point(6, 282);
            this.textBoxConnectionP1.Name = "textBoxConnectionP1";
            this.textBoxConnectionP1.Size = new System.Drawing.Size(109, 24);
            this.textBoxConnectionP1.TabIndex = 19;
            // 
            // buttonRetrieve
            // 
            this.buttonRetrieve.Location = new System.Drawing.Point(125, 204);
            this.buttonRetrieve.Name = "buttonRetrieve";
            this.buttonRetrieve.Size = new System.Drawing.Size(318, 23);
            this.buttonRetrieve.TabIndex = 18;
            this.buttonRetrieve.Text = "Retrieve data from instrument";
            this.buttonRetrieve.UseVisualStyleBackColor = true;
            this.buttonRetrieve.Click += new System.EventHandler(this.buttonRetrieve_Click);
            this.buttonRetrieve.MouseHover += new System.EventHandler(this.buttonRetrieve_MouseHover);
            // 
            // buttonSendValues
            // 
            this.buttonSendValues.Location = new System.Drawing.Point(125, 233);
            this.buttonSendValues.Name = "buttonSendValues";
            this.buttonSendValues.Size = new System.Drawing.Size(318, 23);
            this.buttonSendValues.TabIndex = 17;
            this.buttonSendValues.Text = "Send values to device";
            this.buttonSendValues.UseVisualStyleBackColor = true;
            this.buttonSendValues.Click += new System.EventHandler(this.buttonSendValues_Click);
            this.buttonSendValues.MouseHover += new System.EventHandler(this.buttonSendValues_MouseHover);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(368, 175);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 16;
            this.buttonClear.Text = "Clear Values";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            this.buttonClear.MouseHover += new System.EventHandler(this.buttonClear_MouseHover);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Lavender;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(3, 364);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(673, 22);
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
            this.button2.Location = new System.Drawing.Point(287, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(125, 175);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 12;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.button3_Click);
            this.buttonLoad.MouseHover += new System.EventHandler(this.buttonLoad_MouseHover);
            // 
            // labelAH
            // 
            this.labelAH.AutoSize = true;
            this.labelAH.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold);
            this.labelAH.Location = new System.Drawing.Point(45, 153);
            this.labelAH.Name = "labelAH";
            this.labelAH.Size = new System.Drawing.Size(75, 16);
            this.labelAH.TabIndex = 10;
            this.labelAH.Text = "Alarm high:";
            this.labelAH.MouseHover += new System.EventHandler(this.labelAH_MouseHover);
            // 
            // labelAL
            // 
            this.labelAL.AutoSize = true;
            this.labelAL.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold);
            this.labelAL.Location = new System.Drawing.Point(50, 125);
            this.labelAL.Name = "labelAL";
            this.labelAL.Size = new System.Drawing.Size(70, 16);
            this.labelAL.TabIndex = 9;
            this.labelAL.Text = "Alarm low:";
            this.labelAL.MouseHover += new System.EventHandler(this.labelAL_MouseHover);
            // 
            // labelURV
            // 
            this.labelURV.AutoSize = true;
            this.labelURV.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold);
            this.labelURV.Location = new System.Drawing.Point(0, 101);
            this.labelURV.Name = "labelURV";
            this.labelURV.Size = new System.Drawing.Size(118, 16);
            this.labelURV.TabIndex = 8;
            this.labelURV.Text = "Upper range value:";
            this.labelURV.MouseHover += new System.EventHandler(this.labelURV_MouseHover);
            // 
            // labelLRV
            // 
            this.labelLRV.AutoSize = true;
            this.labelLRV.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLRV.Location = new System.Drawing.Point(0, 76);
            this.labelLRV.Name = "labelLRV";
            this.labelLRV.Size = new System.Drawing.Size(119, 16);
            this.labelLRV.TabIndex = 7;
            this.labelLRV.Text = "Lower range value:";
            this.labelLRV.MouseHover += new System.EventHandler(this.labelLRV_MouseHover);
            // 
            // labelTag
            // 
            this.labelTag.AutoSize = true;
            this.labelTag.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTag.Location = new System.Drawing.Point(55, 50);
            this.labelTag.Name = "labelTag";
            this.labelTag.Size = new System.Drawing.Size(63, 16);
            this.labelTag.TabIndex = 6;
            this.labelTag.Text = "Tagname:";
            this.labelTag.MouseHover += new System.EventHandler(this.labelTag_MouseHover);
            // 
            // textBoxAH
            // 
            this.textBoxAH.Location = new System.Drawing.Point(125, 149);
            this.textBoxAH.MaxLength = 4;
            this.textBoxAH.Name = "textBoxAH";
            this.textBoxAH.Size = new System.Drawing.Size(318, 20);
            this.textBoxAH.TabIndex = 5;
            this.textBoxAH.Enter += new System.EventHandler(this.textBoxAH_Enter);
            // 
            // textBoxAL
            // 
            this.textBoxAL.Location = new System.Drawing.Point(125, 123);
            this.textBoxAL.MaxLength = 4;
            this.textBoxAL.Name = "textBoxAL";
            this.textBoxAL.Size = new System.Drawing.Size(318, 20);
            this.textBoxAL.TabIndex = 4;
            this.textBoxAL.Enter += new System.EventHandler(this.textBoxAL_Enter);
            this.textBoxAL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAL_KeyPress);
            // 
            // textBoxURV
            // 
            this.textBoxURV.Location = new System.Drawing.Point(125, 97);
            this.textBoxURV.MaxLength = 6;
            this.textBoxURV.Name = "textBoxURV";
            this.textBoxURV.Size = new System.Drawing.Size(318, 20);
            this.textBoxURV.TabIndex = 3;
            this.textBoxURV.Enter += new System.EventHandler(this.textBoxURV_Enter);
            // 
            // textBoxLRV
            // 
            this.textBoxLRV.Location = new System.Drawing.Point(125, 72);
            this.textBoxLRV.MaxLength = 6;
            this.textBoxLRV.Name = "textBoxLRV";
            this.textBoxLRV.Size = new System.Drawing.Size(318, 20);
            this.textBoxLRV.TabIndex = 2;
            this.textBoxLRV.Enter += new System.EventHandler(this.textBoxLRV_Enter);
            this.textBoxLRV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLRV_KeyPress);
            // 
            // textBoxTag
            // 
            this.textBoxTag.Location = new System.Drawing.Point(125, 46);
            this.textBoxTag.MaxLength = 10;
            this.textBoxTag.Name = "textBoxTag";
            this.textBoxTag.Size = new System.Drawing.Size(318, 20);
            this.textBoxTag.TabIndex = 0;
            this.textBoxTag.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBoxTag.Enter += new System.EventHandler(this.textBoxTag_Enter);
            // 
            // tabPageConnection
            // 
            this.tabPageConnection.AutoScroll = true;
            this.tabPageConnection.BackColor = System.Drawing.Color.Gray;
            this.tabPageConnection.Controls.Add(this.button4);
            this.tabPageConnection.Controls.Add(this.button3);
            this.tabPageConnection.Controls.Add(this.comboBoxFindDevice);
            this.tabPageConnection.Controls.Add(this.LabelFindDevice);
            this.tabPageConnection.Controls.Add(dAU_IdLabel);
            this.tabPageConnection.Controls.Add(this.dAU_IdTextBox);
            this.tabPageConnection.Controls.Add(descriptionLabel);
            this.tabPageConnection.Controls.Add(this.descriptionTextBox);
            this.tabPageConnection.Controls.Add(rDC_IdLabel);
            this.tabPageConnection.Controls.Add(this.rDC_IdTextBox);
            this.tabPageConnection.Controls.Add(area_IdLabel);
            this.tabPageConnection.Controls.Add(this.area_IdTextBox);
            this.tabPageConnection.Controls.Add(model_IdLabel);
            this.tabPageConnection.Controls.Add(this.model_IdTextBox);
            this.tabPageConnection.Controls.Add(communication_IdLabel);
            this.tabPageConnection.Controls.Add(this.communication_IdTextBox);
            this.tabPageConnection.Controls.Add(manufactor_IdLabel);
            this.tabPageConnection.Controls.Add(this.manufactor_IdTextBox);
            this.tabPageConnection.Controls.Add(category_IdLabel);
            this.tabPageConnection.Controls.Add(this.category_IdTextBox);
            this.tabPageConnection.Controls.Add(cOMPortLabel);
            this.tabPageConnection.Controls.Add(this.cOMPortTextBox);
            this.tabPageConnection.Controls.Add(bAUDRateLabel);
            this.tabPageConnection.Controls.Add(this.bAUDRateTextBox);
            this.tabPageConnection.Controls.Add(configuration_edit_dateLabel);
            this.tabPageConnection.Controls.Add(this.configuration_edit_dateDateTimePicker);
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
            this.tabPageConnection.Size = new System.Drawing.Size(679, 389);
            this.tabPageConnection.TabIndex = 0;
            this.tabPageConnection.Text = "Connection";
            this.tabPageConnection.Enter += new System.EventHandler(this.tabPageConnection_Enter);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(189, 224);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 22);
            this.button3.TabIndex = 33;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // comboBoxFindDevice
            // 
            this.comboBoxFindDevice.FormattingEnabled = true;
            this.comboBoxFindDevice.Location = new System.Drawing.Point(410, 30);
            this.comboBoxFindDevice.Name = "comboBoxFindDevice";
            this.comboBoxFindDevice.Size = new System.Drawing.Size(200, 21);
            this.comboBoxFindDevice.TabIndex = 32;
            this.comboBoxFindDevice.SelectedIndexChanged += new System.EventHandler(this.comboBoxFindDevice_SelectedIndexChanged_1);
            // 
            // LabelFindDevice
            // 
            this.LabelFindDevice.AutoSize = true;
            this.LabelFindDevice.Location = new System.Drawing.Point(287, 33);
            this.LabelFindDevice.Name = "LabelFindDevice";
            this.LabelFindDevice.Size = new System.Drawing.Size(64, 13);
            this.LabelFindDevice.TabIndex = 31;
            this.LabelFindDevice.Text = "Find Device";
            // 
            // dAU_IdTextBox
            // 
            this.dAU_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dAUBindingSource, "DAU_Id", true));
            this.dAU_IdTextBox.Location = new System.Drawing.Point(410, 74);
            this.dAU_IdTextBox.Name = "dAU_IdTextBox";
            this.dAU_IdTextBox.Size = new System.Drawing.Size(200, 20);
            this.dAU_IdTextBox.TabIndex = 9;
            // 
            // dAUBindingSource
            // 
            this.dAUBindingSource.DataMember = "DAU";
            this.dAUBindingSource.DataSource = this.softsenseconfDataSet;
            // 
            // softsenseconfDataSet
            // 
            this.softsenseconfDataSet.DataSetName = "softsenseconfDataSet";
            this.softsenseconfDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dAUBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(410, 100);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(200, 20);
            this.descriptionTextBox.TabIndex = 11;
            // 
            // rDC_IdTextBox
            // 
            this.rDC_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dAUBindingSource, "RDC_Id", true));
            this.rDC_IdTextBox.Location = new System.Drawing.Point(410, 126);
            this.rDC_IdTextBox.Name = "rDC_IdTextBox";
            this.rDC_IdTextBox.Size = new System.Drawing.Size(200, 20);
            this.rDC_IdTextBox.TabIndex = 13;
            // 
            // area_IdTextBox
            // 
            this.area_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dAUBindingSource, "Area_Id", true));
            this.area_IdTextBox.Location = new System.Drawing.Point(410, 152);
            this.area_IdTextBox.Name = "area_IdTextBox";
            this.area_IdTextBox.Size = new System.Drawing.Size(200, 20);
            this.area_IdTextBox.TabIndex = 15;
            // 
            // model_IdTextBox
            // 
            this.model_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dAUBindingSource, "Model_Id", true));
            this.model_IdTextBox.Location = new System.Drawing.Point(410, 178);
            this.model_IdTextBox.Name = "model_IdTextBox";
            this.model_IdTextBox.Size = new System.Drawing.Size(200, 20);
            this.model_IdTextBox.TabIndex = 17;
            // 
            // communication_IdTextBox
            // 
            this.communication_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dAUBindingSource, "Communication_Id", true));
            this.communication_IdTextBox.Location = new System.Drawing.Point(410, 204);
            this.communication_IdTextBox.Name = "communication_IdTextBox";
            this.communication_IdTextBox.Size = new System.Drawing.Size(200, 20);
            this.communication_IdTextBox.TabIndex = 19;
            // 
            // manufactor_IdTextBox
            // 
            this.manufactor_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dAUBindingSource, "Manufactor_Id", true));
            this.manufactor_IdTextBox.Location = new System.Drawing.Point(410, 230);
            this.manufactor_IdTextBox.Name = "manufactor_IdTextBox";
            this.manufactor_IdTextBox.Size = new System.Drawing.Size(200, 20);
            this.manufactor_IdTextBox.TabIndex = 21;
            // 
            // category_IdTextBox
            // 
            this.category_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dAUBindingSource, "Category_Id", true));
            this.category_IdTextBox.Location = new System.Drawing.Point(410, 256);
            this.category_IdTextBox.Name = "category_IdTextBox";
            this.category_IdTextBox.Size = new System.Drawing.Size(200, 20);
            this.category_IdTextBox.TabIndex = 23;
            // 
            // cOMPortTextBox
            // 
            this.cOMPortTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dAUBindingSource, "COMPort", true));
            this.cOMPortTextBox.Location = new System.Drawing.Point(410, 282);
            this.cOMPortTextBox.Name = "cOMPortTextBox";
            this.cOMPortTextBox.Size = new System.Drawing.Size(200, 20);
            this.cOMPortTextBox.TabIndex = 25;
            // 
            // bAUDRateTextBox
            // 
            this.bAUDRateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dAUBindingSource, "BAUDRate", true));
            this.bAUDRateTextBox.Location = new System.Drawing.Point(410, 308);
            this.bAUDRateTextBox.Name = "bAUDRateTextBox";
            this.bAUDRateTextBox.Size = new System.Drawing.Size(200, 20);
            this.bAUDRateTextBox.TabIndex = 27;
            // 
            // configuration_edit_dateDateTimePicker
            // 
            this.configuration_edit_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dAUBindingSource, "Configuration_edit_date", true));
            this.configuration_edit_dateDateTimePicker.Location = new System.Drawing.Point(410, 334);
            this.configuration_edit_dateDateTimePicker.Name = "configuration_edit_dateDateTimePicker";
            this.configuration_edit_dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.configuration_edit_dateDateTimePicker.TabIndex = 29;
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.Lavender;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(3, 364);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(673, 22);
            this.statusStrip.TabIndex = 7;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.BackColor = System.Drawing.Color.Lavender;
            this.toolStripStatusLabel.ForeColor = System.Drawing.Color.Black;
            this.toolStripStatusLabel.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Ready";
            // 
            // labelBitrate
            // 
            this.labelBitrate.AutoSize = true;
            this.labelBitrate.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold);
            this.labelBitrate.Location = new System.Drawing.Point(12, 71);
            this.labelBitrate.Name = "labelBitrate";
            this.labelBitrate.Size = new System.Drawing.Size(53, 16);
            this.labelBitrate.TabIndex = 6;
            this.labelBitrate.Text = "Bitrate:";
            this.labelBitrate.MouseHover += new System.EventHandler(this.labelBitrate_MouseHover);
            // 
            // labelCom
            // 
            this.labelCom.AutoSize = true;
            this.labelCom.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold);
            this.labelCom.Location = new System.Drawing.Point(3, 35);
            this.labelCom.Name = "labelCom";
            this.labelCom.Size = new System.Drawing.Size(62, 16);
            this.labelCom.TabIndex = 5;
            this.labelCom.Text = "ComPort:";
            this.labelCom.MouseHover += new System.EventHandler(this.labelCom_MouseHover);
            // 
            // radioButtonConnected
            // 
            this.radioButtonConnected.AutoSize = true;
            this.radioButtonConnected.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonConnected.ForeColor = System.Drawing.Color.LimeGreen;
            this.radioButtonConnected.Location = new System.Drawing.Point(189, 103);
            this.radioButtonConnected.Name = "radioButtonConnected";
            this.radioButtonConnected.Size = new System.Drawing.Size(14, 13);
            this.radioButtonConnected.TabIndex = 4;
            this.radioButtonConnected.TabStop = true;
            this.radioButtonConnected.UseVisualStyleBackColor = false;
            this.radioButtonConnected.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButtonConnected_MouseClick);
            this.radioButtonConnected.MouseHover += new System.EventHandler(this.radioButtonConnected_MouseHover);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(71, 127);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(112, 23);
            this.buttonDisconnect.TabIndex = 3;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            this.buttonDisconnect.MouseHover += new System.EventHandler(this.buttonDisconnect_MouseHover);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(71, 98);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(112, 23);
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
            this.ComboBoxBaud.Location = new System.Drawing.Point(71, 71);
            this.ComboBoxBaud.Name = "ComboBoxBaud";
            this.ComboBoxBaud.Size = new System.Drawing.Size(148, 21);
            this.ComboBoxBaud.TabIndex = 1;
            this.ComboBoxBaud.Enter += new System.EventHandler(this.ComboBoxBaud_Enter);
            // 
            // ComboBoxPorts
            // 
            this.ComboBoxPorts.FormattingEnabled = true;
            this.ComboBoxPorts.Location = new System.Drawing.Point(71, 33);
            this.ComboBoxPorts.Name = "ComboBoxPorts";
            this.ComboBoxPorts.Size = new System.Drawing.Size(148, 21);
            this.ComboBoxPorts.TabIndex = 0;
            this.ComboBoxPorts.Enter += new System.EventHandler(this.comboBoxPorts_Enter);
            this.ComboBoxPorts.MouseHover += new System.EventHandler(this.ComboBoxPorts_MouseHover);
            // 
            // dAUonlyID_DESBindingSource1
            // 
            this.dAUonlyID_DESBindingSource1.DataMember = "DAUonlyID_DES";
            this.dAUonlyID_DESBindingSource1.DataSource = this.softsenseconfDataSet;
            // 
            // dAUonlyID_DESBindingSource
            // 
            this.dAUonlyID_DESBindingSource.DataSource = this.softsenseconfDataSet;
            this.dAUonlyID_DESBindingSource.Position = 0;
            // 
            // tabInstrument
            // 
            this.tabInstrument.Controls.Add(this.tabPageConnection);
            this.tabInstrument.Controls.Add(this.tabPageConfiguration);
            this.tabInstrument.Controls.Add(this.tabPageCommand);
            this.tabInstrument.Controls.Add(this.tabPageGraph);
            this.tabInstrument.Controls.Add(this.tabPage1);
            this.tabInstrument.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabInstrument.Location = new System.Drawing.Point(0, 0);
            this.tabInstrument.Name = "tabInstrument";
            this.tabInstrument.SelectedIndex = 0;
            this.tabInstrument.Size = new System.Drawing.Size(687, 415);
            this.tabInstrument.TabIndex = 0;
            this.tabInstrument.Enter += new System.EventHandler(this.tabInstrument_Enter);
            // 
            // tabPageCommand
            // 
            this.tabPageCommand.BackColor = System.Drawing.Color.Gray;
            this.tabPageCommand.Controls.Add(this.textBoxConnectionP2);
            this.tabPageCommand.Controls.Add(this.statusStrip2);
            this.tabPageCommand.Controls.Add(this.labelInput);
            this.tabPageCommand.Controls.Add(this.buttonReceive);
            this.tabPageCommand.Controls.Add(this.buttonSend);
            this.tabPageCommand.Controls.Add(this.textBoxSend);
            this.tabPageCommand.Controls.Add(this.textBoxReceive);
            this.tabPageCommand.Location = new System.Drawing.Point(4, 22);
            this.tabPageCommand.Name = "tabPageCommand";
            this.tabPageCommand.Size = new System.Drawing.Size(679, 389);
            this.tabPageCommand.TabIndex = 2;
            this.tabPageCommand.Text = "Command";
            // 
            // textBoxConnectionP2
            // 
            this.textBoxConnectionP2.BackColor = System.Drawing.Color.Gray;
            this.textBoxConnectionP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.textBoxConnectionP2.Location = new System.Drawing.Point(8, 285);
            this.textBoxConnectionP2.Name = "textBoxConnectionP2";
            this.textBoxConnectionP2.Size = new System.Drawing.Size(109, 24);
            this.textBoxConnectionP2.TabIndex = 6;
            // 
            // statusStrip2
            // 
            this.statusStrip2.BackColor = System.Drawing.Color.Lavender;
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2});
            this.statusStrip2.Location = new System.Drawing.Point(0, 367);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(679, 22);
            this.statusStrip2.TabIndex = 5;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel2.Text = "Ready";
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold);
            this.labelInput.Location = new System.Drawing.Point(46, 34);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(42, 16);
            this.labelInput.TabIndex = 4;
            this.labelInput.Text = "Input:";
            this.labelInput.MouseHover += new System.EventHandler(this.labelInput_MouseHover);
            // 
            // buttonReceive
            // 
            this.buttonReceive.Location = new System.Drawing.Point(226, 216);
            this.buttonReceive.Name = "buttonReceive";
            this.buttonReceive.Size = new System.Drawing.Size(117, 23);
            this.buttonReceive.TabIndex = 3;
            this.buttonReceive.Text = "Receive values";
            this.buttonReceive.UseVisualStyleBackColor = true;
            this.buttonReceive.Click += new System.EventHandler(this.buttonReceive_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(94, 216);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(126, 23);
            this.buttonSend.TabIndex = 2;
            this.buttonSend.Text = "Send values";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // textBoxSend
            // 
            this.textBoxSend.Location = new System.Drawing.Point(94, 32);
            this.textBoxSend.Multiline = true;
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.Size = new System.Drawing.Size(251, 23);
            this.textBoxSend.TabIndex = 1;
            this.textBoxSend.Enter += new System.EventHandler(this.textBoxSend_Enter);
            // 
            // textBoxReceive
            // 
            this.textBoxReceive.Location = new System.Drawing.Point(94, 61);
            this.textBoxReceive.Multiline = true;
            this.textBoxReceive.Name = "textBoxReceive";
            this.textBoxReceive.ReadOnly = true;
            this.textBoxReceive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxReceive.Size = new System.Drawing.Size(251, 149);
            this.textBoxReceive.TabIndex = 0;
            // 
            // tabPageGraph
            // 
            this.tabPageGraph.BackColor = System.Drawing.Color.Gray;
            this.tabPageGraph.Controls.Add(this.textBoxConnectionP3);
            this.tabPageGraph.Controls.Add(this.statusStrip3);
            this.tabPageGraph.Controls.Add(this.textBoxStatus);
            this.tabPageGraph.Controls.Add(this.labelStatus);
            this.tabPageGraph.Controls.Add(this.buttonSavetofile);
            this.tabPageGraph.Controls.Add(this.buttonClearV);
            this.tabPageGraph.Controls.Add(this.buttonStop);
            this.tabPageGraph.Controls.Add(this.buttonScaled);
            this.tabPageGraph.Controls.Add(this.listBoxReading);
            this.tabPageGraph.Controls.Add(this.buttonRaw);
            this.tabPageGraph.Controls.Add(this.chartPoints);
            this.tabPageGraph.Location = new System.Drawing.Point(4, 22);
            this.tabPageGraph.Name = "tabPageGraph";
            this.tabPageGraph.Size = new System.Drawing.Size(679, 389);
            this.tabPageGraph.TabIndex = 3;
            this.tabPageGraph.Text = "Gaphical view";
            // 
            // textBoxConnectionP3
            // 
            this.textBoxConnectionP3.BackColor = System.Drawing.Color.Gray;
            this.textBoxConnectionP3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.textBoxConnectionP3.Location = new System.Drawing.Point(8, 285);
            this.textBoxConnectionP3.Name = "textBoxConnectionP3";
            this.textBoxConnectionP3.Size = new System.Drawing.Size(109, 24);
            this.textBoxConnectionP3.TabIndex = 14;
            // 
            // statusStrip3
            // 
            this.statusStrip3.BackColor = System.Drawing.Color.Lavender;
            this.statusStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel3});
            this.statusStrip3.Location = new System.Drawing.Point(0, 367);
            this.statusStrip3.Name = "statusStrip3";
            this.statusStrip3.Size = new System.Drawing.Size(679, 22);
            this.statusStrip3.TabIndex = 13;
            this.statusStrip3.Text = "statusStrip3";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel3.Text = "Ready";
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStatus.Location = new System.Drawing.Point(236, 285);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(84, 24);
            this.textBoxStatus.TabIndex = 12;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold);
            this.labelStatus.Location = new System.Drawing.Point(151, 291);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(79, 16);
            this.labelStatus.TabIndex = 11;
            this.labelStatus.Text = "Status Flag:";
            // 
            // buttonSavetofile
            // 
            this.buttonSavetofile.Location = new System.Drawing.Point(8, 202);
            this.buttonSavetofile.Name = "buttonSavetofile";
            this.buttonSavetofile.Size = new System.Drawing.Size(206, 23);
            this.buttonSavetofile.TabIndex = 10;
            this.buttonSavetofile.Text = "Save to file";
            this.buttonSavetofile.UseVisualStyleBackColor = true;
            this.buttonSavetofile.Click += new System.EventHandler(this.buttonSavetofile_Click);
            this.buttonSavetofile.MouseHover += new System.EventHandler(this.buttonSavetofile_MouseHover);
            // 
            // buttonClearV
            // 
            this.buttonClearV.Location = new System.Drawing.Point(112, 173);
            this.buttonClearV.Name = "buttonClearV";
            this.buttonClearV.Size = new System.Drawing.Size(102, 23);
            this.buttonClearV.TabIndex = 9;
            this.buttonClearV.Text = "Clear";
            this.buttonClearV.UseVisualStyleBackColor = true;
            this.buttonClearV.Click += new System.EventHandler(this.buttonClearV_Click);
            this.buttonClearV.MouseHover += new System.EventHandler(this.buttonClearV_MouseHover);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(8, 173);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(98, 23);
            this.buttonStop.TabIndex = 8;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            this.buttonStop.MouseHover += new System.EventHandler(this.buttonStop_MouseHover);
            // 
            // buttonScaled
            // 
            this.buttonScaled.Location = new System.Drawing.Point(112, 144);
            this.buttonScaled.Name = "buttonScaled";
            this.buttonScaled.Size = new System.Drawing.Size(102, 23);
            this.buttonScaled.TabIndex = 7;
            this.buttonScaled.Text = "Read Scaled Data";
            this.buttonScaled.UseVisualStyleBackColor = true;
            this.buttonScaled.Click += new System.EventHandler(this.buttonScaled_Click);
            this.buttonScaled.MouseHover += new System.EventHandler(this.buttonScaled_MouseHover);
            // 
            // listBoxReading
            // 
            this.listBoxReading.FormattingEnabled = true;
            this.listBoxReading.Location = new System.Drawing.Point(8, 17);
            this.listBoxReading.Name = "listBoxReading";
            this.listBoxReading.Size = new System.Drawing.Size(269, 121);
            this.listBoxReading.TabIndex = 5;
            // 
            // buttonRaw
            // 
            this.buttonRaw.Location = new System.Drawing.Point(8, 144);
            this.buttonRaw.Name = "buttonRaw";
            this.buttonRaw.Size = new System.Drawing.Size(98, 23);
            this.buttonRaw.TabIndex = 2;
            this.buttonRaw.Text = "Read raw data";
            this.buttonRaw.UseVisualStyleBackColor = true;
            this.buttonRaw.Click += new System.EventHandler(this.buttonStart_Click);
            this.buttonRaw.MouseHover += new System.EventHandler(this.buttonRaw_MouseHover);
            // 
            // chartPoints
            // 
            this.chartPoints.BackColor = System.Drawing.Color.Gray;
            this.chartPoints.BorderlineColor = System.Drawing.Color.Gray;
            chartArea1.BackColor = System.Drawing.Color.Gray;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Gray;
            chartArea1.Name = "ChartArea1";
            this.chartPoints.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Gray;
            legend1.Name = "Legend1";
            this.chartPoints.Legends.Add(legend1);
            this.chartPoints.Location = new System.Drawing.Point(296, 3);
            this.chartPoints.Name = "chartPoints";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Va";
            this.chartPoints.Series.Add(series1);
            this.chartPoints.Size = new System.Drawing.Size(300, 300);
            this.chartPoints.TabIndex = 0;
            this.chartPoints.Text = "chart1";
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(679, 389);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Instrument";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // timerReceive
            // 
            this.timerReceive.Tick += new System.EventHandler(this.timerReceive_Tick);
            // 
            // timerChartRaw
            // 
            this.timerChartRaw.Interval = 1000;
            this.timerChartRaw.Tick += new System.EventHandler(this.timerChart_Tick);
            // 
            // timerChartScaled
            // 
            this.timerChartScaled.Interval = 1000;
            this.timerChartScaled.Tick += new System.EventHandler(this.timerChartScaled_Tick);
            // 
            // timerStatus
            // 
            this.timerStatus.Interval = 5000;
            this.timerStatus.Tick += new System.EventHandler(this.timerStatus_Tick);
            // 
            // bindingSource1
            // 
            this.bindingSource1.AllowNew = true;
            this.bindingSource1.DataSource = this.softsenseconfDataSet;
            this.bindingSource1.Position = 0;
            // 
            // dAUTableAdapter
            // 
            this.dAUTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AI_LOGTableAdapter = null;
            this.tableAdapterManager.AO_LOGTableAdapter = null;
            this.tableAdapterManager.AreaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoryTableAdapter = null;
            this.tableAdapterManager.CommunicationTableAdapter = null;
            this.tableAdapterManager.DAUonlyID_DESTableAdapter = null;
            this.tableAdapterManager.DAUTableAdapter = this.dAUTableAdapter;
            this.tableAdapterManager.DI_LOGTableAdapter = null;
            this.tableAdapterManager.DO_LOGTableAdapter = null;
            this.tableAdapterManager.Innput_OutputTableAdapter = null;
            this.tableAdapterManager.Instrument_Measure_IdTableAdapter = null;
            this.tableAdapterManager.INSTRUMENTTableAdapter = null;
            this.tableAdapterManager.ManufactorTableAdapter = null;
            this.tableAdapterManager.MCUTableAdapter = null;
            this.tableAdapterManager.ModelTableAdapter = null;
            this.tableAdapterManager.RDCTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = softsenseconfDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dAUonlyID_DESTableAdapter
            // 
            this.dAUonlyID_DESTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(189, 195);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 34;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // SoftSensConf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(687, 415);
            this.Controls.Add(this.tabInstrument);
            this.Name = "SoftSensConf";
            this.Text = "SoftSensConf";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPageConfiguration.ResumeLayout(false);
            this.tabPageConfiguration.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabPageConnection.ResumeLayout(false);
            this.tabPageConnection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dAUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.softsenseconfDataSet)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dAUonlyID_DESBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAUonlyID_DESBindingSource)).EndInit();
            this.tabInstrument.ResumeLayout(false);
            this.tabPageCommand.ResumeLayout(false);
            this.tabPageCommand.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.tabPageGraph.ResumeLayout(false);
            this.tabPageGraph.PerformLayout();
            this.statusStrip3.ResumeLayout(false);
            this.statusStrip3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageConfiguration;
        private System.Windows.Forms.TabPage tabPageConnection;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.ComboBox ComboBoxBaud;
        private System.Windows.Forms.ComboBox ComboBoxPorts;
        private System.Windows.Forms.TabControl tabInstrument;
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
        private System.Windows.Forms.Timer timerChartRaw;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPoints;
        private System.Windows.Forms.Button buttonRaw;
        private System.Windows.Forms.ListBox listBoxReading;
        private System.Windows.Forms.Button buttonSendValues;
        private System.Windows.Forms.Button buttonScaled;
        private System.Windows.Forms.Timer timerChartScaled;
        private System.Windows.Forms.Button buttonClearV;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonRetrieve;
        private System.Windows.Forms.Button buttonSavetofile;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Timer timerStatus;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.StatusStrip statusStrip3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.TextBox textBoxConnectionP1;
        private System.Windows.Forms.TextBox textBoxConnectionP2;
        private System.Windows.Forms.TextBox textBoxConnectionP3;
        private softsenseconfDataSet softsenseconfDataSet;
        private System.Windows.Forms.BindingSource dAUBindingSource;
        private softsenseconfDataSetTableAdapters.DAUTableAdapter dAUTableAdapter;
        private softsenseconfDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox dAU_IdTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox rDC_IdTextBox;
        private System.Windows.Forms.TextBox area_IdTextBox;
        private System.Windows.Forms.TextBox model_IdTextBox;
        private System.Windows.Forms.TextBox communication_IdTextBox;
        private System.Windows.Forms.TextBox manufactor_IdTextBox;
        private System.Windows.Forms.TextBox category_IdTextBox;
        private System.Windows.Forms.TextBox cOMPortTextBox;
        private System.Windows.Forms.TextBox bAUDRateTextBox;
        private System.Windows.Forms.DateTimePicker configuration_edit_dateDateTimePicker;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label LabelFindDevice;
        private System.Windows.Forms.BindingSource dAUonlyID_DESBindingSource;
        private softsenseconfDataSetTableAdapters.DAUonlyID_DESTableAdapter dAUonlyID_DESTableAdapter;
        private System.Windows.Forms.BindingSource dAUonlyID_DESBindingSource1;
        private System.Windows.Forms.ComboBox comboBoxFindDevice;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

