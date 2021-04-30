
namespace SoftSensConf
{
    partial class SoftSensConfig
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
            System.Windows.Forms.Label configuration_Edit_DateLabel1;
            System.Windows.Forms.Label innput_Output_IdLabel;
            System.Windows.Forms.Label area_IdLabel1;
            System.Windows.Forms.Label frequencyLabel;
            System.Windows.Forms.Label communication_IdLabel1;
            System.Windows.Forms.Label dAU_IdLabel1;
            System.Windows.Forms.Label manufactor_IdLabel1;
            System.Windows.Forms.Label model_IdLabel1;
            System.Windows.Forms.Label category_IdLabel1;
            System.Windows.Forms.Label alarm_highLabel;
            System.Windows.Forms.Label alarm_LowLabel;
            System.Windows.Forms.Label upper_range_valueLabel;
            System.Windows.Forms.Label lower_range_valueLabel;
            System.Windows.Forms.Label descriptionLabel1;
            System.Windows.Forms.Label tagNameLabel;
            System.Windows.Forms.Label configuration_edit_dateLabel;
            System.Windows.Forms.Label bAUDRateLabel;
            System.Windows.Forms.Label cOMPortLabel;
            System.Windows.Forms.Label category_IdLabel;
            System.Windows.Forms.Label manufactor_IdLabel;
            System.Windows.Forms.Label communication_IdLabel;
            System.Windows.Forms.Label model_IdLabel;
            System.Windows.Forms.Label area_IdLabel;
            System.Windows.Forms.Label rDC_IdLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label dAU_IdLabel;
            System.Windows.Forms.Label rDC_IdLabel1;
            System.Windows.Forms.Label descriptionLabel2;
            System.Windows.Forms.Label mCU_IdLabel;
            System.Windows.Forms.Label area_IdLabel2;
            System.Windows.Forms.Label manufactor_IdLabel2;
            System.Windows.Forms.Label model_IdLabel2;
            System.Windows.Forms.Label configuration_Edit_DateLabel2;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timerReceive = new System.Windows.Forms.Timer(this.components);
            this.timerChartRaw = new System.Windows.Forms.Timer(this.components);
            this.timerChartScaled = new System.Windows.Forms.Timer(this.components);
            this.timerStatus = new System.Windows.Forms.Timer(this.components);
            this.sOFTSENSECONF_DATABASE_FINALDataSet = new SoftSensConf.SOFTSENSECONF_DATABASE_FINALDataSet();
            this.iNSTRUMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dAUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manufactorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.communicationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.areaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rDCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dAUTableAdapter = new SoftSensConf.SOFTSENSECONF_DATABASE_FINALDataSetTableAdapters.DAUTableAdapter();
            this.tableAdapterManager = new SoftSensConf.SOFTSENSECONF_DATABASE_FINALDataSetTableAdapters.TableAdapterManager();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dAU_OnlyIdDesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dAU_OnlyIdDesTableAdapter = new SoftSensConf.SOFTSENSECONF_DATABASE_FINALDataSetTableAdapters.DAU_OnlyIdDesTableAdapter();
            this.rDCTableAdapter = new SoftSensConf.SOFTSENSECONF_DATABASE_FINALDataSetTableAdapters.RDCTableAdapter();
            this.areaTableAdapter = new SoftSensConf.SOFTSENSECONF_DATABASE_FINALDataSetTableAdapters.AreaTableAdapter();
            this.modelTableAdapter = new SoftSensConf.SOFTSENSECONF_DATABASE_FINALDataSetTableAdapters.ModelTableAdapter();
            this.communicationTableAdapter = new SoftSensConf.SOFTSENSECONF_DATABASE_FINALDataSetTableAdapters.CommunicationTableAdapter();
            this.manufactorTableAdapter = new SoftSensConf.SOFTSENSECONF_DATABASE_FINALDataSetTableAdapters.ManufactorTableAdapter();
            this.categoryTableAdapter = new SoftSensConf.SOFTSENSECONF_DATABASE_FINALDataSetTableAdapters.CategoryTableAdapter();
            this.iNSTRUMENTTableAdapter = new SoftSensConf.SOFTSENSECONF_DATABASE_FINALDataSetTableAdapters.INSTRUMENTTableAdapter();
            this.instrument_Measure_IdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aI_LOGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageCommand = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tagNameTextBox1 = new System.Windows.Forms.TextBox();
            this.instrument_Log_IdTextBox1 = new System.Windows.Forms.TextBox();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.timeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.instrument_Log_IdTextBox = new System.Windows.Forms.TextBox();
            this.buttonstopgraph = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonGraphstart = new System.Windows.Forms.Button();
            this.chartPoints = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxConnectionP2 = new System.Windows.Forms.TextBox();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.textBoxReceive = new System.Windows.Forms.TextBox();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelInput = new System.Windows.Forms.Label();
            this.buttonReceive = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.tabPageConfiguration = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxFindInstrument = new System.Windows.Forms.ComboBox();
            this.labelMatching = new System.Windows.Forms.Label();
            this.textBoxMatch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDataBaseInstrument = new System.Windows.Forms.Label();
            this.tagNameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox1 = new System.Windows.Forms.TextBox();
            this.lower_range_valueTextBox = new System.Windows.Forms.TextBox();
            this.upper_range_valueTextBox = new System.Windows.Forms.TextBox();
            this.alarm_LowTextBox = new System.Windows.Forms.TextBox();
            this.alarm_highTextBox = new System.Windows.Forms.TextBox();
            this.category_IdTextBox = new System.Windows.Forms.TextBox();
            this.model_IdTextBox = new System.Windows.Forms.TextBox();
            this.manufactor_IdTextBox = new System.Windows.Forms.TextBox();
            this.dAU_IdTextBox1 = new System.Windows.Forms.TextBox();
            this.communication_IdTextBox = new System.Windows.Forms.TextBox();
            this.frequencyTextBox = new System.Windows.Forms.TextBox();
            this.area_IdTextBox = new System.Windows.Forms.TextBox();
            this.innput_Output_IdTextBox = new System.Windows.Forms.TextBox();
            this.textBoxConnectionP1 = new System.Windows.Forms.TextBox();
            this.textBoxAH = new System.Windows.Forms.TextBox();
            this.textBoxAL = new System.Windows.Forms.TextBox();
            this.textBoxURV = new System.Windows.Forms.TextBox();
            this.textBoxLRV = new System.Windows.Forms.TextBox();
            this.textBoxTag = new System.Windows.Forms.TextBox();
            this.configuration_Edit_DateDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonRetrieve = new System.Windows.Forms.Button();
            this.buttonSendValues = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.labelAH = new System.Windows.Forms.Label();
            this.labelAL = new System.Windows.Forms.Label();
            this.labelURV = new System.Windows.Forms.Label();
            this.labelLRV = new System.Windows.Forms.Label();
            this.labelTag = new System.Windows.Forms.Label();
            this.tabPageConnection = new System.Windows.Forms.TabPage();
            this.comboBoxFindingDeviceRDC = new System.Windows.Forms.ComboBox();
            this.RDCFIND = new System.Windows.Forms.Label();
            this.pictureBoxDisconnected = new System.Windows.Forms.PictureBox();
            this.pictureBoxCONNECTED = new System.Windows.Forms.PictureBox();
            this.rDC_IdTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox2 = new System.Windows.Forms.TextBox();
            this.mCU_IdTextBox = new System.Windows.Forms.TextBox();
            this.area_IdTextBox1 = new System.Windows.Forms.TextBox();
            this.manufactor_IdTextBox1 = new System.Windows.Forms.TextBox();
            this.model_IdTextBox1 = new System.Windows.Forms.TextBox();
            this.configuration_Edit_DateDateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.buttonDisconnectInstrument = new System.Windows.Forms.Button();
            this.buttonConnectFromDB = new System.Windows.Forms.Button();
            this.comboBoxCategory_DAU = new System.Windows.Forms.ComboBox();
            this.comboBoxManu_DAU = new System.Windows.Forms.ComboBox();
            this.comboBoxCommunication_DAU = new System.Windows.Forms.ComboBox();
            this.comboBoxModel_DAU = new System.Windows.Forms.ComboBox();
            this.comboBoxAREA_DAU = new System.Windows.Forms.ComboBox();
            this.comboBoxRDC_DAU = new System.Windows.Forms.ComboBox();
            this.dAU_IdTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.cOMPortTextBox = new System.Windows.Forms.TextBox();
            this.bAUDRateTextBox = new System.Windows.Forms.TextBox();
            this.configuration_edit_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBoxFindDevice = new System.Windows.Forms.ComboBox();
            this.labelFindDevice = new System.Windows.Forms.Label();
            this.buttonCancelDAU = new System.Windows.Forms.Button();
            this.buttonNEW = new System.Windows.Forms.Button();
            this.buttonDAU_Save = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.toolStripback = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.labelBitrate = new System.Windows.Forms.Label();
            this.labelCom = new System.Windows.Forms.Label();
            this.radioButtonConnected = new System.Windows.Forms.RadioButton();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.ComboBoxBaud = new System.Windows.Forms.ComboBox();
            this.ComboBoxPorts = new System.Windows.Forms.ComboBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.iNSTRUMENTtoComboBoxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iNSTRUMENTtoComboBoxTableAdapter = new SoftSensConf.SOFTSENSECONF_DATABASE_FINALDataSetTableAdapters.INSTRUMENTtoComboBoxTableAdapter();
            this.aI_LOGTableAdapter = new SoftSensConf.SOFTSENSECONF_DATABASE_FINALDataSetTableAdapters.AI_LOGTableAdapter();
            this.instrument_Measure_IdTableAdapter = new SoftSensConf.SOFTSENSECONF_DATABASE_FINALDataSetTableAdapters.Instrument_Measure_IdTableAdapter();
            this.buttonExit = new System.Windows.Forms.Button();
            this.rDC1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            configuration_Edit_DateLabel1 = new System.Windows.Forms.Label();
            innput_Output_IdLabel = new System.Windows.Forms.Label();
            area_IdLabel1 = new System.Windows.Forms.Label();
            frequencyLabel = new System.Windows.Forms.Label();
            communication_IdLabel1 = new System.Windows.Forms.Label();
            dAU_IdLabel1 = new System.Windows.Forms.Label();
            manufactor_IdLabel1 = new System.Windows.Forms.Label();
            model_IdLabel1 = new System.Windows.Forms.Label();
            category_IdLabel1 = new System.Windows.Forms.Label();
            alarm_highLabel = new System.Windows.Forms.Label();
            alarm_LowLabel = new System.Windows.Forms.Label();
            upper_range_valueLabel = new System.Windows.Forms.Label();
            lower_range_valueLabel = new System.Windows.Forms.Label();
            descriptionLabel1 = new System.Windows.Forms.Label();
            tagNameLabel = new System.Windows.Forms.Label();
            configuration_edit_dateLabel = new System.Windows.Forms.Label();
            bAUDRateLabel = new System.Windows.Forms.Label();
            cOMPortLabel = new System.Windows.Forms.Label();
            category_IdLabel = new System.Windows.Forms.Label();
            manufactor_IdLabel = new System.Windows.Forms.Label();
            communication_IdLabel = new System.Windows.Forms.Label();
            model_IdLabel = new System.Windows.Forms.Label();
            area_IdLabel = new System.Windows.Forms.Label();
            rDC_IdLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            dAU_IdLabel = new System.Windows.Forms.Label();
            rDC_IdLabel1 = new System.Windows.Forms.Label();
            descriptionLabel2 = new System.Windows.Forms.Label();
            mCU_IdLabel = new System.Windows.Forms.Label();
            area_IdLabel2 = new System.Windows.Forms.Label();
            manufactor_IdLabel2 = new System.Windows.Forms.Label();
            model_IdLabel2 = new System.Windows.Forms.Label();
            configuration_Edit_DateLabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sOFTSENSECONF_DATABASE_FINALDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNSTRUMENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufactorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.communicationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAU_OnlyIdDesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrument_Measure_IdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aI_LOGBindingSource)).BeginInit();
            this.tabPageCommand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPoints)).BeginInit();
            this.statusStrip2.SuspendLayout();
            this.tabPageConfiguration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.tabPageConnection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisconnected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCONNECTED)).BeginInit();
            this.toolStripback.SuspendLayout();
            this.tabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iNSTRUMENTtoComboBoxBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDC1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // configuration_Edit_DateLabel1
            // 
            configuration_Edit_DateLabel1.AutoSize = true;
            configuration_Edit_DateLabel1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            configuration_Edit_DateLabel1.Location = new System.Drawing.Point(21, 515);
            configuration_Edit_DateLabel1.Name = "configuration_Edit_DateLabel1";
            configuration_Edit_DateLabel1.Size = new System.Drawing.Size(106, 17);
            configuration_Edit_DateLabel1.TabIndex = 47;
            configuration_Edit_DateLabel1.Text = "Config Edit Date:";
            // 
            // innput_Output_IdLabel
            // 
            innput_Output_IdLabel.AutoSize = true;
            innput_Output_IdLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            innput_Output_IdLabel.Location = new System.Drawing.Point(18, 493);
            innput_Output_IdLabel.Name = "innput_Output_IdLabel";
            innput_Output_IdLabel.Size = new System.Drawing.Size(106, 17);
            innput_Output_IdLabel.TabIndex = 45;
            innput_Output_IdLabel.Text = "Innput Output Id:";
            // 
            // area_IdLabel1
            // 
            area_IdLabel1.AutoSize = true;
            area_IdLabel1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            area_IdLabel1.Location = new System.Drawing.Point(71, 467);
            area_IdLabel1.Name = "area_IdLabel1";
            area_IdLabel1.Size = new System.Drawing.Size(53, 17);
            area_IdLabel1.TabIndex = 43;
            area_IdLabel1.Text = "Area Id:";
            // 
            // frequencyLabel
            // 
            frequencyLabel.AutoSize = true;
            frequencyLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            frequencyLabel.Location = new System.Drawing.Point(52, 441);
            frequencyLabel.Name = "frequencyLabel";
            frequencyLabel.Size = new System.Drawing.Size(70, 17);
            frequencyLabel.TabIndex = 41;
            frequencyLabel.Text = "Frequency:";
            // 
            // communication_IdLabel1
            // 
            communication_IdLabel1.AutoSize = true;
            communication_IdLabel1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            communication_IdLabel1.Location = new System.Drawing.Point(8, 412);
            communication_IdLabel1.Name = "communication_IdLabel1";
            communication_IdLabel1.Size = new System.Drawing.Size(116, 17);
            communication_IdLabel1.TabIndex = 39;
            communication_IdLabel1.Text = "Communication Id:";
            // 
            // dAU_IdLabel1
            // 
            dAU_IdLabel1.AutoSize = true;
            dAU_IdLabel1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dAU_IdLabel1.Location = new System.Drawing.Point(72, 389);
            dAU_IdLabel1.Name = "dAU_IdLabel1";
            dAU_IdLabel1.Size = new System.Drawing.Size(52, 17);
            dAU_IdLabel1.TabIndex = 37;
            dAU_IdLabel1.Text = "DAU Id:";
            // 
            // manufactor_IdLabel1
            // 
            manufactor_IdLabel1.AutoSize = true;
            manufactor_IdLabel1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            manufactor_IdLabel1.Location = new System.Drawing.Point(33, 363);
            manufactor_IdLabel1.Name = "manufactor_IdLabel1";
            manufactor_IdLabel1.Size = new System.Drawing.Size(93, 17);
            manufactor_IdLabel1.TabIndex = 35;
            manufactor_IdLabel1.Text = "Manufactor Id:";
            // 
            // model_IdLabel1
            // 
            model_IdLabel1.AutoSize = true;
            model_IdLabel1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            model_IdLabel1.Location = new System.Drawing.Point(60, 336);
            model_IdLabel1.Name = "model_IdLabel1";
            model_IdLabel1.Size = new System.Drawing.Size(64, 17);
            model_IdLabel1.TabIndex = 33;
            model_IdLabel1.Text = "Model Id:";
            // 
            // category_IdLabel1
            // 
            category_IdLabel1.AutoSize = true;
            category_IdLabel1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            category_IdLabel1.Location = new System.Drawing.Point(47, 308);
            category_IdLabel1.Name = "category_IdLabel1";
            category_IdLabel1.Size = new System.Drawing.Size(80, 17);
            category_IdLabel1.TabIndex = 31;
            category_IdLabel1.Text = "Category Id:";
            // 
            // alarm_highLabel
            // 
            alarm_highLabel.AutoSize = true;
            alarm_highLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            alarm_highLabel.Location = new System.Drawing.Point(53, 280);
            alarm_highLabel.Name = "alarm_highLabel";
            alarm_highLabel.Size = new System.Drawing.Size(74, 17);
            alarm_highLabel.TabIndex = 29;
            alarm_highLabel.Text = "Alarm high:";
            // 
            // alarm_LowLabel
            // 
            alarm_LowLabel.AutoSize = true;
            alarm_LowLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            alarm_LowLabel.Location = new System.Drawing.Point(52, 254);
            alarm_LowLabel.Name = "alarm_LowLabel";
            alarm_LowLabel.Size = new System.Drawing.Size(72, 17);
            alarm_LowLabel.TabIndex = 27;
            alarm_LowLabel.Text = "Alarm Low:";
            // 
            // upper_range_valueLabel
            // 
            upper_range_valueLabel.AutoSize = true;
            upper_range_valueLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            upper_range_valueLabel.Location = new System.Drawing.Point(8, 230);
            upper_range_valueLabel.Name = "upper_range_valueLabel";
            upper_range_valueLabel.Size = new System.Drawing.Size(120, 17);
            upper_range_valueLabel.TabIndex = 25;
            upper_range_valueLabel.Text = "Upper range value:";
            // 
            // lower_range_valueLabel
            // 
            lower_range_valueLabel.AutoSize = true;
            lower_range_valueLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lower_range_valueLabel.Location = new System.Drawing.Point(8, 204);
            lower_range_valueLabel.Name = "lower_range_valueLabel";
            lower_range_valueLabel.Size = new System.Drawing.Size(118, 17);
            lower_range_valueLabel.TabIndex = 23;
            lower_range_valueLabel.Text = "Lower range value:";
            // 
            // descriptionLabel1
            // 
            descriptionLabel1.AutoSize = true;
            descriptionLabel1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descriptionLabel1.Location = new System.Drawing.Point(47, 177);
            descriptionLabel1.Name = "descriptionLabel1";
            descriptionLabel1.Size = new System.Drawing.Size(77, 17);
            descriptionLabel1.TabIndex = 21;
            descriptionLabel1.Text = "Description:";
            // 
            // tagNameLabel
            // 
            tagNameLabel.AutoSize = true;
            tagNameLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tagNameLabel.Location = new System.Drawing.Point(53, 155);
            tagNameLabel.Name = "tagNameLabel";
            tagNameLabel.Size = new System.Drawing.Size(71, 17);
            tagNameLabel.TabIndex = 19;
            tagNameLabel.Text = "Tag Name:";
            // 
            // configuration_edit_dateLabel
            // 
            configuration_edit_dateLabel.AutoSize = true;
            configuration_edit_dateLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            configuration_edit_dateLabel.Location = new System.Drawing.Point(504, 538);
            configuration_edit_dateLabel.Name = "configuration_edit_dateLabel";
            configuration_edit_dateLabel.Size = new System.Drawing.Size(146, 17);
            configuration_edit_dateLabel.TabIndex = 55;
            configuration_edit_dateLabel.Text = "Configuration edit date:";
            // 
            // bAUDRateLabel
            // 
            bAUDRateLabel.AutoSize = true;
            bAUDRateLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bAUDRateLabel.Location = new System.Drawing.Point(557, 509);
            bAUDRateLabel.Name = "bAUDRateLabel";
            bAUDRateLabel.Size = new System.Drawing.Size(70, 17);
            bAUDRateLabel.TabIndex = 53;
            bAUDRateLabel.Text = "BAUDRate:";
            // 
            // cOMPortLabel
            // 
            cOMPortLabel.AutoSize = true;
            cOMPortLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cOMPortLabel.Location = new System.Drawing.Point(567, 483);
            cOMPortLabel.Name = "cOMPortLabel";
            cOMPortLabel.Size = new System.Drawing.Size(65, 17);
            cOMPortLabel.TabIndex = 51;
            cOMPortLabel.Text = "COMPort:";
            // 
            // category_IdLabel
            // 
            category_IdLabel.AutoSize = true;
            category_IdLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            category_IdLabel.Location = new System.Drawing.Point(569, 456);
            category_IdLabel.Name = "category_IdLabel";
            category_IdLabel.Size = new System.Drawing.Size(65, 17);
            category_IdLabel.TabIndex = 49;
            category_IdLabel.Text = "Category:";
            // 
            // manufactor_IdLabel
            // 
            manufactor_IdLabel.AutoSize = true;
            manufactor_IdLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            manufactor_IdLabel.Location = new System.Drawing.Point(557, 430);
            manufactor_IdLabel.Name = "manufactor_IdLabel";
            manufactor_IdLabel.Size = new System.Drawing.Size(79, 17);
            manufactor_IdLabel.TabIndex = 47;
            manufactor_IdLabel.Text = "Manufactor:";
            // 
            // communication_IdLabel
            // 
            communication_IdLabel.AutoSize = true;
            communication_IdLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            communication_IdLabel.Location = new System.Drawing.Point(539, 404);
            communication_IdLabel.Name = "communication_IdLabel";
            communication_IdLabel.Size = new System.Drawing.Size(101, 17);
            communication_IdLabel.TabIndex = 45;
            communication_IdLabel.Text = "Communication:";
            // 
            // model_IdLabel
            // 
            model_IdLabel.AutoSize = true;
            model_IdLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            model_IdLabel.Location = new System.Drawing.Point(582, 378);
            model_IdLabel.Name = "model_IdLabel";
            model_IdLabel.Size = new System.Drawing.Size(49, 17);
            model_IdLabel.TabIndex = 43;
            model_IdLabel.Text = "Model:";
            // 
            // area_IdLabel
            // 
            area_IdLabel.AutoSize = true;
            area_IdLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            area_IdLabel.Location = new System.Drawing.Point(589, 353);
            area_IdLabel.Name = "area_IdLabel";
            area_IdLabel.Size = new System.Drawing.Size(38, 17);
            area_IdLabel.TabIndex = 41;
            area_IdLabel.Text = "Area:";
            // 
            // rDC_IdLabel
            // 
            rDC_IdLabel.AutoSize = true;
            rDC_IdLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rDC_IdLabel.Location = new System.Drawing.Point(507, 326);
            rDC_IdLabel.Name = "rDC_IdLabel";
            rDC_IdLabel.Size = new System.Drawing.Size(140, 17);
            rDC_IdLabel.TabIndex = 39;
            rDC_IdLabel.Text = "Remote Data Collector";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descriptionLabel.Location = new System.Drawing.Point(557, 301);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(77, 17);
            descriptionLabel.TabIndex = 37;
            descriptionLabel.Text = "Description:";
            // 
            // dAU_IdLabel
            // 
            dAU_IdLabel.AutoSize = true;
            dAU_IdLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dAU_IdLabel.Location = new System.Drawing.Point(518, 275);
            dAU_IdLabel.Name = "dAU_IdLabel";
            dAU_IdLabel.Size = new System.Drawing.Size(126, 17);
            dAU_IdLabel.TabIndex = 35;
            dAU_IdLabel.Text = "Data Aquisition Unit:";
            // 
            // rDC_IdLabel1
            // 
            rDC_IdLabel1.AutoSize = true;
            rDC_IdLabel1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rDC_IdLabel1.Location = new System.Drawing.Point(17, 278);
            rDC_IdLabel1.Name = "rDC_IdLabel1";
            rDC_IdLabel1.Size = new System.Drawing.Size(51, 17);
            rDC_IdLabel1.TabIndex = 65;
            rDC_IdLabel1.Text = "RDC Id:";
            // 
            // descriptionLabel2
            // 
            descriptionLabel2.AutoSize = true;
            descriptionLabel2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descriptionLabel2.Location = new System.Drawing.Point(17, 313);
            descriptionLabel2.Name = "descriptionLabel2";
            descriptionLabel2.Size = new System.Drawing.Size(77, 17);
            descriptionLabel2.TabIndex = 67;
            descriptionLabel2.Text = "Description:";
            // 
            // mCU_IdLabel
            // 
            mCU_IdLabel.AutoSize = true;
            mCU_IdLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mCU_IdLabel.Location = new System.Drawing.Point(17, 348);
            mCU_IdLabel.Name = "mCU_IdLabel";
            mCU_IdLabel.Size = new System.Drawing.Size(55, 17);
            mCU_IdLabel.TabIndex = 69;
            mCU_IdLabel.Text = "MCU Id:";
            // 
            // area_IdLabel2
            // 
            area_IdLabel2.AutoSize = true;
            area_IdLabel2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            area_IdLabel2.Location = new System.Drawing.Point(17, 383);
            area_IdLabel2.Name = "area_IdLabel2";
            area_IdLabel2.Size = new System.Drawing.Size(53, 17);
            area_IdLabel2.TabIndex = 71;
            area_IdLabel2.Text = "Area Id:";
            // 
            // manufactor_IdLabel2
            // 
            manufactor_IdLabel2.AutoSize = true;
            manufactor_IdLabel2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            manufactor_IdLabel2.Location = new System.Drawing.Point(17, 418);
            manufactor_IdLabel2.Name = "manufactor_IdLabel2";
            manufactor_IdLabel2.Size = new System.Drawing.Size(93, 17);
            manufactor_IdLabel2.TabIndex = 73;
            manufactor_IdLabel2.Text = "Manufactor Id:";
            // 
            // model_IdLabel2
            // 
            model_IdLabel2.AutoSize = true;
            model_IdLabel2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            model_IdLabel2.Location = new System.Drawing.Point(17, 453);
            model_IdLabel2.Name = "model_IdLabel2";
            model_IdLabel2.Size = new System.Drawing.Size(64, 17);
            model_IdLabel2.TabIndex = 75;
            model_IdLabel2.Text = "Model Id:";
            // 
            // configuration_Edit_DateLabel2
            // 
            configuration_Edit_DateLabel2.AutoSize = true;
            configuration_Edit_DateLabel2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            configuration_Edit_DateLabel2.Location = new System.Drawing.Point(17, 489);
            configuration_Edit_DateLabel2.Name = "configuration_Edit_DateLabel2";
            configuration_Edit_DateLabel2.Size = new System.Drawing.Size(147, 17);
            configuration_Edit_DateLabel2.TabIndex = 77;
            configuration_Edit_DateLabel2.Text = "Configuration Edit Date:";
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
            // sOFTSENSECONF_DATABASE_FINALDataSet
            // 
            this.sOFTSENSECONF_DATABASE_FINALDataSet.DataSetName = "SOFTSENSECONF_DATABASE_FINALDataSet";
            this.sOFTSENSECONF_DATABASE_FINALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iNSTRUMENTBindingSource
            // 
            this.iNSTRUMENTBindingSource.DataMember = "INSTRUMENT";
            this.iNSTRUMENTBindingSource.DataSource = this.sOFTSENSECONF_DATABASE_FINALDataSet;
            // 
            // dAUBindingSource
            // 
            this.dAUBindingSource.DataMember = "DAU";
            this.dAUBindingSource.DataSource = this.sOFTSENSECONF_DATABASE_FINALDataSet;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.sOFTSENSECONF_DATABASE_FINALDataSet;
            // 
            // manufactorBindingSource
            // 
            this.manufactorBindingSource.DataMember = "Manufactor";
            this.manufactorBindingSource.DataSource = this.sOFTSENSECONF_DATABASE_FINALDataSet;
            // 
            // communicationBindingSource
            // 
            this.communicationBindingSource.DataMember = "Communication";
            this.communicationBindingSource.DataSource = this.sOFTSENSECONF_DATABASE_FINALDataSet;
            // 
            // modelBindingSource
            // 
            this.modelBindingSource.DataMember = "Model";
            this.modelBindingSource.DataSource = this.sOFTSENSECONF_DATABASE_FINALDataSet;
            // 
            // areaBindingSource
            // 
            this.areaBindingSource.DataMember = "Area";
            this.areaBindingSource.DataSource = this.sOFTSENSECONF_DATABASE_FINALDataSet;
            // 
            // rDCBindingSource
            // 
            this.rDCBindingSource.DataMember = "RDC";
            this.rDCBindingSource.DataSource = this.sOFTSENSECONF_DATABASE_FINALDataSet;
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
            this.tableAdapterManager.DAU_OnlyIdDesTableAdapter = null;
            this.tableAdapterManager.DAUTableAdapter = this.dAUTableAdapter;
            this.tableAdapterManager.DI_LOGTableAdapter = null;
            this.tableAdapterManager.DO_LOGTableAdapter = null;
            this.tableAdapterManager.Innput_OutputTableAdapter = null;
            this.tableAdapterManager.Instrument_Measure_IdTableAdapter = null;
            this.tableAdapterManager.INSTRUMENTTableAdapter = null;
            this.tableAdapterManager.INSTRUMENTtoComboBoxTableAdapter = null;
            this.tableAdapterManager.ManufactorTableAdapter = null;
            this.tableAdapterManager.MCUTableAdapter = null;
            this.tableAdapterManager.ModelTableAdapter = null;
            this.tableAdapterManager.RDCOnlyIdDesTableAdapter = null;
            this.tableAdapterManager.RDConlyRDCDesTableAdapter = null;
            this.tableAdapterManager.RDCTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SoftSensConf.SOFTSENSECONF_DATABASE_FINALDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bindingSource1
            // 
            this.bindingSource1.AllowNew = true;
            this.bindingSource1.DataSource = this.sOFTSENSECONF_DATABASE_FINALDataSet;
            this.bindingSource1.Position = 0;
            // 
            // dAU_OnlyIdDesBindingSource
            // 
            this.dAU_OnlyIdDesBindingSource.DataMember = "DAU_OnlyIdDes";
            this.dAU_OnlyIdDesBindingSource.DataSource = this.sOFTSENSECONF_DATABASE_FINALDataSet;
            // 
            // dAU_OnlyIdDesTableAdapter
            // 
            this.dAU_OnlyIdDesTableAdapter.ClearBeforeFill = true;
            // 
            // rDCTableAdapter
            // 
            this.rDCTableAdapter.ClearBeforeFill = true;
            // 
            // areaTableAdapter
            // 
            this.areaTableAdapter.ClearBeforeFill = true;
            // 
            // modelTableAdapter
            // 
            this.modelTableAdapter.ClearBeforeFill = true;
            // 
            // communicationTableAdapter
            // 
            this.communicationTableAdapter.ClearBeforeFill = true;
            // 
            // manufactorTableAdapter
            // 
            this.manufactorTableAdapter.ClearBeforeFill = true;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // iNSTRUMENTTableAdapter
            // 
            this.iNSTRUMENTTableAdapter.ClearBeforeFill = true;
            // 
            // instrument_Measure_IdBindingSource
            // 
            this.instrument_Measure_IdBindingSource.DataMember = "Instrument_Measure_Id";
            this.instrument_Measure_IdBindingSource.DataSource = this.sOFTSENSECONF_DATABASE_FINALDataSet;
            // 
            // aI_LOGBindingSource
            // 
            this.aI_LOGBindingSource.DataMember = "AI_LOG";
            this.aI_LOGBindingSource.DataSource = this.sOFTSENSECONF_DATABASE_FINALDataSet;
            // 
            // tabPageCommand
            // 
            this.tabPageCommand.BackColor = System.Drawing.Color.Gray;
            this.tabPageCommand.Controls.Add(this.pictureBox2);
            this.tabPageCommand.Controls.Add(this.tagNameTextBox1);
            this.tabPageCommand.Controls.Add(this.instrument_Log_IdTextBox1);
            this.tabPageCommand.Controls.Add(this.valueTextBox);
            this.tabPageCommand.Controls.Add(this.timeDateTimePicker);
            this.tabPageCommand.Controls.Add(this.instrument_Log_IdTextBox);
            this.tabPageCommand.Controls.Add(this.buttonstopgraph);
            this.tabPageCommand.Controls.Add(this.listBox1);
            this.tabPageCommand.Controls.Add(this.buttonGraphstart);
            this.tabPageCommand.Controls.Add(this.chartPoints);
            this.tabPageCommand.Controls.Add(this.textBoxConnectionP2);
            this.tabPageCommand.Controls.Add(this.textBoxSend);
            this.tabPageCommand.Controls.Add(this.textBoxReceive);
            this.tabPageCommand.Controls.Add(this.statusStrip2);
            this.tabPageCommand.Controls.Add(this.labelInput);
            this.tabPageCommand.Controls.Add(this.buttonReceive);
            this.tabPageCommand.Controls.Add(this.buttonSend);
            this.tabPageCommand.Location = new System.Drawing.Point(4, 34);
            this.tabPageCommand.Name = "tabPageCommand";
            this.tabPageCommand.Size = new System.Drawing.Size(1191, 750);
            this.tabPageCommand.TabIndex = 2;
            this.tabPageCommand.Text = "Command";
            this.tabPageCommand.Enter += new System.EventHandler(this.tabPageCommand_Enter);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SoftSensConf.Properties.Resources.iconfinder_wifi_Symbol_925808;
            this.pictureBox2.Location = new System.Drawing.Point(1065, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 68);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 80;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // tagNameTextBox1
            // 
            this.tagNameTextBox1.BackColor = System.Drawing.Color.Gray;
            this.tagNameTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tagNameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instrument_Measure_IdBindingSource, "TagName", true));
            this.tagNameTextBox1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagNameTextBox1.ForeColor = System.Drawing.Color.Gray;
            this.tagNameTextBox1.Location = new System.Drawing.Point(988, 470);
            this.tagNameTextBox1.Name = "tagNameTextBox1";
            this.tagNameTextBox1.Size = new System.Drawing.Size(100, 18);
            this.tagNameTextBox1.TabIndex = 31;
            // 
            // instrument_Log_IdTextBox1
            // 
            this.instrument_Log_IdTextBox1.BackColor = System.Drawing.Color.Gray;
            this.instrument_Log_IdTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.instrument_Log_IdTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instrument_Measure_IdBindingSource, "Instrument_Log_Id", true));
            this.instrument_Log_IdTextBox1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instrument_Log_IdTextBox1.ForeColor = System.Drawing.Color.Gray;
            this.instrument_Log_IdTextBox1.Location = new System.Drawing.Point(988, 496);
            this.instrument_Log_IdTextBox1.Name = "instrument_Log_IdTextBox1";
            this.instrument_Log_IdTextBox1.Size = new System.Drawing.Size(100, 18);
            this.instrument_Log_IdTextBox1.TabIndex = 33;
            // 
            // valueTextBox
            // 
            this.valueTextBox.BackColor = System.Drawing.Color.Gray;
            this.valueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.valueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aI_LOGBindingSource, "Value", true));
            this.valueTextBox.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueTextBox.ForeColor = System.Drawing.Color.Gray;
            this.valueTextBox.Location = new System.Drawing.Point(988, 547);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(200, 18);
            this.valueTextBox.TabIndex = 25;
            // 
            // timeDateTimePicker
            // 
            this.timeDateTimePicker.CalendarForeColor = System.Drawing.Color.Gray;
            this.timeDateTimePicker.CalendarMonthBackground = System.Drawing.Color.Gray;
            this.timeDateTimePicker.CalendarTitleBackColor = System.Drawing.Color.Gray;
            this.timeDateTimePicker.CalendarTitleForeColor = System.Drawing.Color.Gray;
            this.timeDateTimePicker.CalendarTrailingForeColor = System.Drawing.Color.Gray;
            this.timeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.aI_LOGBindingSource, "Time", true));
            this.timeDateTimePicker.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeDateTimePicker.Location = new System.Drawing.Point(988, 573);
            this.timeDateTimePicker.Name = "timeDateTimePicker";
            this.timeDateTimePicker.Size = new System.Drawing.Size(200, 25);
            this.timeDateTimePicker.TabIndex = 27;
            this.timeDateTimePicker.Visible = false;
            // 
            // instrument_Log_IdTextBox
            // 
            this.instrument_Log_IdTextBox.BackColor = System.Drawing.Color.Gray;
            this.instrument_Log_IdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.instrument_Log_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aI_LOGBindingSource, "Instrument_Log_Id", true));
            this.instrument_Log_IdTextBox.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instrument_Log_IdTextBox.ForeColor = System.Drawing.Color.Gray;
            this.instrument_Log_IdTextBox.Location = new System.Drawing.Point(988, 599);
            this.instrument_Log_IdTextBox.Name = "instrument_Log_IdTextBox";
            this.instrument_Log_IdTextBox.Size = new System.Drawing.Size(200, 18);
            this.instrument_Log_IdTextBox.TabIndex = 30;
            // 
            // buttonstopgraph
            // 
            this.buttonstopgraph.Location = new System.Drawing.Point(194, 245);
            this.buttonstopgraph.Name = "buttonstopgraph";
            this.buttonstopgraph.Size = new System.Drawing.Size(112, 29);
            this.buttonstopgraph.TabIndex = 14;
            this.buttonstopgraph.Text = "Stop";
            this.buttonstopgraph.UseVisualStyleBackColor = true;
            this.buttonstopgraph.Click += new System.EventHandler(this.buttonstopgraph_Click);
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.aI_LOGBindingSource;
            this.listBox1.DisplayMember = "Value";
            this.listBox1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(68, 303);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(125, 157);
            this.listBox1.TabIndex = 13;
            this.listBox1.ValueMember = "Value";
            // 
            // buttonGraphstart
            // 
            this.buttonGraphstart.Location = new System.Drawing.Point(45, 245);
            this.buttonGraphstart.Name = "buttonGraphstart";
            this.buttonGraphstart.Size = new System.Drawing.Size(148, 29);
            this.buttonGraphstart.TabIndex = 8;
            this.buttonGraphstart.Text = "View in graph";
            this.buttonGraphstart.UseVisualStyleBackColor = true;
            this.buttonGraphstart.Click += new System.EventHandler(this.buttonGraphstart_Click);
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
            this.chartPoints.Location = new System.Drawing.Point(324, 3);
            this.chartPoints.Name = "chartPoints";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Va";
            this.chartPoints.Series.Add(series1);
            this.chartPoints.Size = new System.Drawing.Size(747, 300);
            this.chartPoints.TabIndex = 7;
            this.chartPoints.Text = "chart1";
            // 
            // textBoxConnectionP2
            // 
            this.textBoxConnectionP2.BackColor = System.Drawing.Color.Gray;
            this.textBoxConnectionP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.textBoxConnectionP2.Location = new System.Drawing.Point(22, 563);
            this.textBoxConnectionP2.Name = "textBoxConnectionP2";
            this.textBoxConnectionP2.Size = new System.Drawing.Size(109, 24);
            this.textBoxConnectionP2.TabIndex = 6;
            // 
            // textBoxSend
            // 
            this.textBoxSend.Location = new System.Drawing.Point(67, 32);
            this.textBoxSend.Multiline = true;
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.Size = new System.Drawing.Size(251, 23);
            this.textBoxSend.TabIndex = 1;
            this.textBoxSend.Enter += new System.EventHandler(this.textBoxSend_Enter);
            // 
            // textBoxReceive
            // 
            this.textBoxReceive.Location = new System.Drawing.Point(67, 61);
            this.textBoxReceive.Multiline = true;
            this.textBoxReceive.Name = "textBoxReceive";
            this.textBoxReceive.ReadOnly = true;
            this.textBoxReceive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxReceive.Size = new System.Drawing.Size(251, 149);
            this.textBoxReceive.TabIndex = 0;
            // 
            // statusStrip2
            // 
            this.statusStrip2.BackColor = System.Drawing.Color.Lavender;
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2});
            this.statusStrip2.Location = new System.Drawing.Point(0, 728);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(1191, 22);
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
            this.labelInput.Location = new System.Drawing.Point(19, 34);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(42, 16);
            this.labelInput.TabIndex = 4;
            this.labelInput.Text = "Input:";
            this.labelInput.MouseHover += new System.EventHandler(this.labelInput_MouseHover);
            // 
            // buttonReceive
            // 
            this.buttonReceive.Location = new System.Drawing.Point(199, 216);
            this.buttonReceive.Name = "buttonReceive";
            this.buttonReceive.Size = new System.Drawing.Size(117, 23);
            this.buttonReceive.TabIndex = 3;
            this.buttonReceive.Text = "Receive values";
            this.buttonReceive.UseVisualStyleBackColor = true;
            this.buttonReceive.Click += new System.EventHandler(this.buttonReceive_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(67, 216);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(126, 23);
            this.buttonSend.TabIndex = 2;
            this.buttonSend.Text = "Send values";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // tabPageConfiguration
            // 
            this.tabPageConfiguration.AutoScroll = true;
            this.tabPageConfiguration.BackColor = System.Drawing.Color.Gray;
            this.tabPageConfiguration.Controls.Add(this.pictureBox1);
            this.tabPageConfiguration.Controls.Add(this.comboBoxFindInstrument);
            this.tabPageConfiguration.Controls.Add(this.labelMatching);
            this.tabPageConfiguration.Controls.Add(this.textBoxMatch);
            this.tabPageConfiguration.Controls.Add(this.label1);
            this.tabPageConfiguration.Controls.Add(this.labelDataBaseInstrument);
            this.tabPageConfiguration.Controls.Add(tagNameLabel);
            this.tabPageConfiguration.Controls.Add(this.tagNameTextBox);
            this.tabPageConfiguration.Controls.Add(this.descriptionTextBox1);
            this.tabPageConfiguration.Controls.Add(this.lower_range_valueTextBox);
            this.tabPageConfiguration.Controls.Add(this.upper_range_valueTextBox);
            this.tabPageConfiguration.Controls.Add(this.alarm_LowTextBox);
            this.tabPageConfiguration.Controls.Add(this.alarm_highTextBox);
            this.tabPageConfiguration.Controls.Add(this.category_IdTextBox);
            this.tabPageConfiguration.Controls.Add(this.model_IdTextBox);
            this.tabPageConfiguration.Controls.Add(this.manufactor_IdTextBox);
            this.tabPageConfiguration.Controls.Add(this.dAU_IdTextBox1);
            this.tabPageConfiguration.Controls.Add(this.communication_IdTextBox);
            this.tabPageConfiguration.Controls.Add(this.frequencyTextBox);
            this.tabPageConfiguration.Controls.Add(this.area_IdTextBox);
            this.tabPageConfiguration.Controls.Add(this.innput_Output_IdTextBox);
            this.tabPageConfiguration.Controls.Add(this.textBoxConnectionP1);
            this.tabPageConfiguration.Controls.Add(this.textBoxAH);
            this.tabPageConfiguration.Controls.Add(this.textBoxAL);
            this.tabPageConfiguration.Controls.Add(this.textBoxURV);
            this.tabPageConfiguration.Controls.Add(this.textBoxLRV);
            this.tabPageConfiguration.Controls.Add(this.textBoxTag);
            this.tabPageConfiguration.Controls.Add(descriptionLabel1);
            this.tabPageConfiguration.Controls.Add(lower_range_valueLabel);
            this.tabPageConfiguration.Controls.Add(upper_range_valueLabel);
            this.tabPageConfiguration.Controls.Add(alarm_LowLabel);
            this.tabPageConfiguration.Controls.Add(alarm_highLabel);
            this.tabPageConfiguration.Controls.Add(category_IdLabel1);
            this.tabPageConfiguration.Controls.Add(model_IdLabel1);
            this.tabPageConfiguration.Controls.Add(manufactor_IdLabel1);
            this.tabPageConfiguration.Controls.Add(dAU_IdLabel1);
            this.tabPageConfiguration.Controls.Add(communication_IdLabel1);
            this.tabPageConfiguration.Controls.Add(frequencyLabel);
            this.tabPageConfiguration.Controls.Add(area_IdLabel1);
            this.tabPageConfiguration.Controls.Add(innput_Output_IdLabel);
            this.tabPageConfiguration.Controls.Add(configuration_Edit_DateLabel1);
            this.tabPageConfiguration.Controls.Add(this.configuration_Edit_DateDateTimePicker1);
            this.tabPageConfiguration.Controls.Add(this.buttonRetrieve);
            this.tabPageConfiguration.Controls.Add(this.buttonSendValues);
            this.tabPageConfiguration.Controls.Add(this.buttonClear);
            this.tabPageConfiguration.Controls.Add(this.statusStrip1);
            this.tabPageConfiguration.Controls.Add(this.buttonSave);
            this.tabPageConfiguration.Controls.Add(this.buttonUpdate);
            this.tabPageConfiguration.Controls.Add(this.buttonLoad);
            this.tabPageConfiguration.Controls.Add(this.labelAH);
            this.tabPageConfiguration.Controls.Add(this.labelAL);
            this.tabPageConfiguration.Controls.Add(this.labelURV);
            this.tabPageConfiguration.Controls.Add(this.labelLRV);
            this.tabPageConfiguration.Controls.Add(this.labelTag);
            this.tabPageConfiguration.Location = new System.Drawing.Point(4, 34);
            this.tabPageConfiguration.Name = "tabPageConfiguration";
            this.tabPageConfiguration.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConfiguration.Size = new System.Drawing.Size(1191, 750);
            this.tabPageConfiguration.TabIndex = 1;
            this.tabPageConfiguration.Text = "Configuration";
            this.tabPageConfiguration.Click += new System.EventHandler(this.tabPageConfiguration_Click);
            this.tabPageConfiguration.Enter += new System.EventHandler(this.tabPageConfiguration_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SoftSensConf.Properties.Resources.iconfinder_wifi_Symbol_925808;
            this.pictureBox1.Location = new System.Drawing.Point(1065, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 80;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // comboBoxFindInstrument
            // 
            this.comboBoxFindInstrument.FormattingEnabled = true;
            this.comboBoxFindInstrument.Location = new System.Drawing.Point(132, 74);
            this.comboBoxFindInstrument.Name = "comboBoxFindInstrument";
            this.comboBoxFindInstrument.Size = new System.Drawing.Size(201, 29);
            this.comboBoxFindInstrument.TabIndex = 54;
            this.comboBoxFindInstrument.SelectedIndexChanged += new System.EventHandler(this.comboBoxFindInstrument_SelectedIndexChanged);
            // 
            // labelMatching
            // 
            this.labelMatching.AutoSize = true;
            this.labelMatching.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatching.Location = new System.Drawing.Point(380, 279);
            this.labelMatching.Name = "labelMatching";
            this.labelMatching.Size = new System.Drawing.Size(194, 17);
            this.labelMatching.TabIndex = 53;
            this.labelMatching.Text = "Instrument db and config match";
            // 
            // textBoxMatch
            // 
            this.textBoxMatch.Location = new System.Drawing.Point(580, 280);
            this.textBoxMatch.Name = "textBoxMatch";
            this.textBoxMatch.Size = new System.Drawing.Size(156, 29);
            this.textBoxMatch.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(585, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 38);
            this.label1.TabIndex = 50;
            this.label1.Text = "Instrument Data";
            // 
            // labelDataBaseInstrument
            // 
            this.labelDataBaseInstrument.AutoSize = true;
            this.labelDataBaseInstrument.Font = new System.Drawing.Font("Microsoft Uighur", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataBaseInstrument.Location = new System.Drawing.Point(135, 108);
            this.labelDataBaseInstrument.Name = "labelDataBaseInstrument";
            this.labelDataBaseInstrument.Size = new System.Drawing.Size(188, 38);
            this.labelDataBaseInstrument.TabIndex = 49;
            this.labelDataBaseInstrument.Text = "Instrument DataBase";
            // 
            // tagNameTextBox
            // 
            this.tagNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNSTRUMENTBindingSource, "TagName", true));
            this.tagNameTextBox.Location = new System.Drawing.Point(133, 149);
            this.tagNameTextBox.Name = "tagNameTextBox";
            this.tagNameTextBox.Size = new System.Drawing.Size(200, 29);
            this.tagNameTextBox.TabIndex = 20;
            // 
            // descriptionTextBox1
            // 
            this.descriptionTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNSTRUMENTBindingSource, "Description", true));
            this.descriptionTextBox1.Location = new System.Drawing.Point(133, 175);
            this.descriptionTextBox1.Name = "descriptionTextBox1";
            this.descriptionTextBox1.Size = new System.Drawing.Size(200, 29);
            this.descriptionTextBox1.TabIndex = 22;
            // 
            // lower_range_valueTextBox
            // 
            this.lower_range_valueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNSTRUMENTBindingSource, "Lower_range_value", true));
            this.lower_range_valueTextBox.Location = new System.Drawing.Point(133, 201);
            this.lower_range_valueTextBox.Name = "lower_range_valueTextBox";
            this.lower_range_valueTextBox.Size = new System.Drawing.Size(200, 29);
            this.lower_range_valueTextBox.TabIndex = 24;
            // 
            // upper_range_valueTextBox
            // 
            this.upper_range_valueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNSTRUMENTBindingSource, "Upper_range_value", true));
            this.upper_range_valueTextBox.Location = new System.Drawing.Point(133, 227);
            this.upper_range_valueTextBox.Name = "upper_range_valueTextBox";
            this.upper_range_valueTextBox.Size = new System.Drawing.Size(200, 29);
            this.upper_range_valueTextBox.TabIndex = 26;
            // 
            // alarm_LowTextBox
            // 
            this.alarm_LowTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNSTRUMENTBindingSource, "Alarm_Low", true));
            this.alarm_LowTextBox.Location = new System.Drawing.Point(133, 253);
            this.alarm_LowTextBox.Name = "alarm_LowTextBox";
            this.alarm_LowTextBox.Size = new System.Drawing.Size(200, 29);
            this.alarm_LowTextBox.TabIndex = 28;
            // 
            // alarm_highTextBox
            // 
            this.alarm_highTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNSTRUMENTBindingSource, "Alarm_high", true));
            this.alarm_highTextBox.Location = new System.Drawing.Point(133, 279);
            this.alarm_highTextBox.Name = "alarm_highTextBox";
            this.alarm_highTextBox.Size = new System.Drawing.Size(200, 29);
            this.alarm_highTextBox.TabIndex = 30;
            // 
            // category_IdTextBox
            // 
            this.category_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNSTRUMENTBindingSource, "Category_Id", true));
            this.category_IdTextBox.Location = new System.Drawing.Point(133, 305);
            this.category_IdTextBox.Name = "category_IdTextBox";
            this.category_IdTextBox.Size = new System.Drawing.Size(200, 29);
            this.category_IdTextBox.TabIndex = 32;
            // 
            // model_IdTextBox
            // 
            this.model_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNSTRUMENTBindingSource, "Model_Id", true));
            this.model_IdTextBox.Location = new System.Drawing.Point(133, 331);
            this.model_IdTextBox.Name = "model_IdTextBox";
            this.model_IdTextBox.Size = new System.Drawing.Size(200, 29);
            this.model_IdTextBox.TabIndex = 34;
            // 
            // manufactor_IdTextBox
            // 
            this.manufactor_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNSTRUMENTBindingSource, "Manufactor_Id", true));
            this.manufactor_IdTextBox.Location = new System.Drawing.Point(133, 357);
            this.manufactor_IdTextBox.Name = "manufactor_IdTextBox";
            this.manufactor_IdTextBox.Size = new System.Drawing.Size(200, 29);
            this.manufactor_IdTextBox.TabIndex = 36;
            // 
            // dAU_IdTextBox1
            // 
            this.dAU_IdTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNSTRUMENTBindingSource, "DAU_Id", true));
            this.dAU_IdTextBox1.Location = new System.Drawing.Point(133, 383);
            this.dAU_IdTextBox1.Name = "dAU_IdTextBox1";
            this.dAU_IdTextBox1.Size = new System.Drawing.Size(200, 29);
            this.dAU_IdTextBox1.TabIndex = 38;
            // 
            // communication_IdTextBox
            // 
            this.communication_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNSTRUMENTBindingSource, "Communication_Id", true));
            this.communication_IdTextBox.Location = new System.Drawing.Point(133, 409);
            this.communication_IdTextBox.Name = "communication_IdTextBox";
            this.communication_IdTextBox.Size = new System.Drawing.Size(200, 29);
            this.communication_IdTextBox.TabIndex = 40;
            // 
            // frequencyTextBox
            // 
            this.frequencyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNSTRUMENTBindingSource, "Frequency", true));
            this.frequencyTextBox.Location = new System.Drawing.Point(133, 435);
            this.frequencyTextBox.Name = "frequencyTextBox";
            this.frequencyTextBox.Size = new System.Drawing.Size(200, 29);
            this.frequencyTextBox.TabIndex = 42;
            // 
            // area_IdTextBox
            // 
            this.area_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNSTRUMENTBindingSource, "Area_Id", true));
            this.area_IdTextBox.Location = new System.Drawing.Point(133, 461);
            this.area_IdTextBox.Name = "area_IdTextBox";
            this.area_IdTextBox.Size = new System.Drawing.Size(200, 29);
            this.area_IdTextBox.TabIndex = 44;
            // 
            // innput_Output_IdTextBox
            // 
            this.innput_Output_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNSTRUMENTBindingSource, "Innput_Output_Id", true));
            this.innput_Output_IdTextBox.Location = new System.Drawing.Point(133, 487);
            this.innput_Output_IdTextBox.Name = "innput_Output_IdTextBox";
            this.innput_Output_IdTextBox.Size = new System.Drawing.Size(200, 29);
            this.innput_Output_IdTextBox.TabIndex = 46;
            // 
            // textBoxConnectionP1
            // 
            this.textBoxConnectionP1.BackColor = System.Drawing.Color.Gray;
            this.textBoxConnectionP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConnectionP1.ForeColor = System.Drawing.Color.Lime;
            this.textBoxConnectionP1.Location = new System.Drawing.Point(616, 506);
            this.textBoxConnectionP1.Name = "textBoxConnectionP1";
            this.textBoxConnectionP1.Size = new System.Drawing.Size(109, 24);
            this.textBoxConnectionP1.TabIndex = 19;
            // 
            // textBoxAH
            // 
            this.textBoxAH.Location = new System.Drawing.Point(580, 248);
            this.textBoxAH.MaxLength = 4;
            this.textBoxAH.Name = "textBoxAH";
            this.textBoxAH.Size = new System.Drawing.Size(156, 29);
            this.textBoxAH.TabIndex = 5;
            this.textBoxAH.TextChanged += new System.EventHandler(this.textBoxAH_TextChanged);
            this.textBoxAH.Enter += new System.EventHandler(this.textBoxAH_Enter);
            // 
            // textBoxAL
            // 
            this.textBoxAL.Location = new System.Drawing.Point(580, 222);
            this.textBoxAL.MaxLength = 4;
            this.textBoxAL.Name = "textBoxAL";
            this.textBoxAL.Size = new System.Drawing.Size(156, 29);
            this.textBoxAL.TabIndex = 4;
            this.textBoxAL.TextChanged += new System.EventHandler(this.textBoxAL_TextChanged);
            this.textBoxAL.Enter += new System.EventHandler(this.textBoxAL_Enter);
            this.textBoxAL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAL_KeyPress);
            // 
            // textBoxURV
            // 
            this.textBoxURV.Location = new System.Drawing.Point(580, 196);
            this.textBoxURV.MaxLength = 6;
            this.textBoxURV.Name = "textBoxURV";
            this.textBoxURV.Size = new System.Drawing.Size(156, 29);
            this.textBoxURV.TabIndex = 3;
            this.textBoxURV.TextChanged += new System.EventHandler(this.textBoxURV_TextChanged);
            this.textBoxURV.Enter += new System.EventHandler(this.textBoxURV_Enter);
            // 
            // textBoxLRV
            // 
            this.textBoxLRV.Location = new System.Drawing.Point(580, 171);
            this.textBoxLRV.MaxLength = 6;
            this.textBoxLRV.Name = "textBoxLRV";
            this.textBoxLRV.Size = new System.Drawing.Size(156, 29);
            this.textBoxLRV.TabIndex = 2;
            this.textBoxLRV.TextChanged += new System.EventHandler(this.textBoxLRV_TextChanged);
            this.textBoxLRV.Enter += new System.EventHandler(this.textBoxLRV_Enter);
            this.textBoxLRV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLRV_KeyPress);
            // 
            // textBoxTag
            // 
            this.textBoxTag.Location = new System.Drawing.Point(580, 145);
            this.textBoxTag.MaxLength = 10;
            this.textBoxTag.Name = "textBoxTag";
            this.textBoxTag.Size = new System.Drawing.Size(156, 29);
            this.textBoxTag.TabIndex = 0;
            this.textBoxTag.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBoxTag.Enter += new System.EventHandler(this.textBoxTag_Enter);
            // 
            // configuration_Edit_DateDateTimePicker1
            // 
            this.configuration_Edit_DateDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.iNSTRUMENTBindingSource, "Configuration_Edit_Date", true));
            this.configuration_Edit_DateDateTimePicker1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configuration_Edit_DateDateTimePicker1.Location = new System.Drawing.Point(133, 513);
            this.configuration_Edit_DateDateTimePicker1.Name = "configuration_Edit_DateDateTimePicker1";
            this.configuration_Edit_DateDateTimePicker1.Size = new System.Drawing.Size(200, 25);
            this.configuration_Edit_DateDateTimePicker1.TabIndex = 48;
            // 
            // buttonRetrieve
            // 
            this.buttonRetrieve.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRetrieve.Location = new System.Drawing.Point(580, 315);
            this.buttonRetrieve.Name = "buttonRetrieve";
            this.buttonRetrieve.Size = new System.Drawing.Size(202, 23);
            this.buttonRetrieve.TabIndex = 18;
            this.buttonRetrieve.Text = "Retrieve data from instrument";
            this.buttonRetrieve.UseVisualStyleBackColor = true;
            this.buttonRetrieve.Click += new System.EventHandler(this.buttonRetrieve_Click);
            this.buttonRetrieve.MouseHover += new System.EventHandler(this.buttonRetrieve_MouseHover);
            // 
            // buttonSendValues
            // 
            this.buttonSendValues.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSendValues.Location = new System.Drawing.Point(580, 389);
            this.buttonSendValues.Name = "buttonSendValues";
            this.buttonSendValues.Size = new System.Drawing.Size(156, 23);
            this.buttonSendValues.TabIndex = 17;
            this.buttonSendValues.Text = "Send values to device";
            this.buttonSendValues.UseVisualStyleBackColor = true;
            this.buttonSendValues.Click += new System.EventHandler(this.buttonSendValues_Click);
            this.buttonSendValues.MouseHover += new System.EventHandler(this.buttonSendValues_MouseHover);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(367, 506);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 16;
            this.buttonClear.Text = "Clear Values";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Visible = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            this.buttonClear.MouseHover += new System.EventHandler(this.buttonClear_MouseHover);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Lavender;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(3, 725);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1185, 22);
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
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(448, 509);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Visible = false;
            this.buttonSave.Click += new System.EventHandler(this.button2_Click);
            this.buttonSave.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(580, 344);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(156, 23);
            this.buttonUpdate.TabIndex = 13;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.button1_Click);
            this.buttonUpdate.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(367, 480);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 12;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Visible = false;
            this.buttonLoad.Click += new System.EventHandler(this.button3_Click);
            this.buttonLoad.MouseHover += new System.EventHandler(this.buttonLoad_MouseHover);
            // 
            // labelAH
            // 
            this.labelAH.AutoSize = true;
            this.labelAH.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold);
            this.labelAH.Location = new System.Drawing.Point(489, 252);
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
            this.labelAL.Location = new System.Drawing.Point(494, 224);
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
            this.labelURV.Location = new System.Drawing.Point(444, 200);
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
            this.labelLRV.Location = new System.Drawing.Point(444, 175);
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
            this.labelTag.Location = new System.Drawing.Point(499, 149);
            this.labelTag.Name = "labelTag";
            this.labelTag.Size = new System.Drawing.Size(63, 16);
            this.labelTag.TabIndex = 6;
            this.labelTag.Text = "Tagname:";
            this.labelTag.MouseHover += new System.EventHandler(this.labelTag_MouseHover);
            // 
            // tabPageConnection
            // 
            this.tabPageConnection.AutoScroll = true;
            this.tabPageConnection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.tabPageConnection.Controls.Add(this.comboBoxFindingDeviceRDC);
            this.tabPageConnection.Controls.Add(this.RDCFIND);
            this.tabPageConnection.Controls.Add(this.pictureBoxDisconnected);
            this.tabPageConnection.Controls.Add(this.pictureBoxCONNECTED);
            this.tabPageConnection.Controls.Add(rDC_IdLabel1);
            this.tabPageConnection.Controls.Add(this.rDC_IdTextBox);
            this.tabPageConnection.Controls.Add(descriptionLabel2);
            this.tabPageConnection.Controls.Add(this.descriptionTextBox2);
            this.tabPageConnection.Controls.Add(mCU_IdLabel);
            this.tabPageConnection.Controls.Add(this.mCU_IdTextBox);
            this.tabPageConnection.Controls.Add(area_IdLabel2);
            this.tabPageConnection.Controls.Add(this.area_IdTextBox1);
            this.tabPageConnection.Controls.Add(manufactor_IdLabel2);
            this.tabPageConnection.Controls.Add(this.manufactor_IdTextBox1);
            this.tabPageConnection.Controls.Add(model_IdLabel2);
            this.tabPageConnection.Controls.Add(this.model_IdTextBox1);
            this.tabPageConnection.Controls.Add(configuration_Edit_DateLabel2);
            this.tabPageConnection.Controls.Add(this.configuration_Edit_DateDateTimePicker2);
            this.tabPageConnection.Controls.Add(this.buttonDisconnectInstrument);
            this.tabPageConnection.Controls.Add(this.buttonConnectFromDB);
            this.tabPageConnection.Controls.Add(this.comboBoxCategory_DAU);
            this.tabPageConnection.Controls.Add(this.comboBoxManu_DAU);
            this.tabPageConnection.Controls.Add(this.comboBoxCommunication_DAU);
            this.tabPageConnection.Controls.Add(this.comboBoxModel_DAU);
            this.tabPageConnection.Controls.Add(this.comboBoxAREA_DAU);
            this.tabPageConnection.Controls.Add(this.comboBoxRDC_DAU);
            this.tabPageConnection.Controls.Add(dAU_IdLabel);
            this.tabPageConnection.Controls.Add(this.dAU_IdTextBox);
            this.tabPageConnection.Controls.Add(this.descriptionTextBox);
            this.tabPageConnection.Controls.Add(this.cOMPortTextBox);
            this.tabPageConnection.Controls.Add(this.bAUDRateTextBox);
            this.tabPageConnection.Controls.Add(descriptionLabel);
            this.tabPageConnection.Controls.Add(rDC_IdLabel);
            this.tabPageConnection.Controls.Add(area_IdLabel);
            this.tabPageConnection.Controls.Add(model_IdLabel);
            this.tabPageConnection.Controls.Add(communication_IdLabel);
            this.tabPageConnection.Controls.Add(manufactor_IdLabel);
            this.tabPageConnection.Controls.Add(category_IdLabel);
            this.tabPageConnection.Controls.Add(cOMPortLabel);
            this.tabPageConnection.Controls.Add(bAUDRateLabel);
            this.tabPageConnection.Controls.Add(configuration_edit_dateLabel);
            this.tabPageConnection.Controls.Add(this.configuration_edit_dateDateTimePicker);
            this.tabPageConnection.Controls.Add(this.comboBoxFindDevice);
            this.tabPageConnection.Controls.Add(this.labelFindDevice);
            this.tabPageConnection.Controls.Add(this.buttonCancelDAU);
            this.tabPageConnection.Controls.Add(this.buttonNEW);
            this.tabPageConnection.Controls.Add(this.buttonDAU_Save);
            this.tabPageConnection.Controls.Add(this.buttonChange);
            this.tabPageConnection.Controls.Add(this.toolStripback);
            this.tabPageConnection.Controls.Add(this.labelBitrate);
            this.tabPageConnection.Controls.Add(this.labelCom);
            this.tabPageConnection.Controls.Add(this.radioButtonConnected);
            this.tabPageConnection.Controls.Add(this.buttonDisconnect);
            this.tabPageConnection.Controls.Add(this.buttonConnect);
            this.tabPageConnection.Controls.Add(this.ComboBoxBaud);
            this.tabPageConnection.Controls.Add(this.ComboBoxPorts);
            this.tabPageConnection.ForeColor = System.Drawing.Color.Black;
            this.tabPageConnection.Location = new System.Drawing.Point(4, 34);
            this.tabPageConnection.Name = "tabPageConnection";
            this.tabPageConnection.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConnection.Size = new System.Drawing.Size(1191, 750);
            this.tabPageConnection.TabIndex = 0;
            this.tabPageConnection.Text = "Connection";
            this.tabPageConnection.Enter += new System.EventHandler(this.tabPageConnection_Enter);
            // 
            // comboBoxFindingDeviceRDC
            // 
            this.comboBoxFindingDeviceRDC.DataSource = this.rDCBindingSource;
            this.comboBoxFindingDeviceRDC.DisplayMember = "RDC_Id";
            this.comboBoxFindingDeviceRDC.FormattingEnabled = true;
            this.comboBoxFindingDeviceRDC.Location = new System.Drawing.Point(198, 224);
            this.comboBoxFindingDeviceRDC.Name = "comboBoxFindingDeviceRDC";
            this.comboBoxFindingDeviceRDC.Size = new System.Drawing.Size(200, 29);
            this.comboBoxFindingDeviceRDC.TabIndex = 82;
            this.comboBoxFindingDeviceRDC.SelectedIndexChanged += new System.EventHandler(this.comboBoxFindingDeviceRDC_SelectedIndexChanged);
            // 
            // RDCFIND
            // 
            this.RDCFIND.AutoSize = true;
            this.RDCFIND.Location = new System.Drawing.Point(16, 224);
            this.RDCFIND.Name = "RDCFIND";
            this.RDCFIND.Size = new System.Drawing.Size(93, 21);
            this.RDCFIND.TabIndex = 81;
            this.RDCFIND.Text = "Find Device:";
            // 
            // pictureBoxDisconnected
            // 
            this.pictureBoxDisconnected.Image = global::SoftSensConf.Properties.Resources.iconfinder_wifi_off_2561213;
            this.pictureBoxDisconnected.Location = new System.Drawing.Point(1058, 6);
            this.pictureBoxDisconnected.Name = "pictureBoxDisconnected";
            this.pictureBoxDisconnected.Size = new System.Drawing.Size(127, 68);
            this.pictureBoxDisconnected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDisconnected.TabIndex = 80;
            this.pictureBoxDisconnected.TabStop = false;
            // 
            // pictureBoxCONNECTED
            // 
            this.pictureBoxCONNECTED.Image = global::SoftSensConf.Properties.Resources.iconfinder_wifi_Symbol_925808;
            this.pictureBoxCONNECTED.Location = new System.Drawing.Point(1065, 6);
            this.pictureBoxCONNECTED.Name = "pictureBoxCONNECTED";
            this.pictureBoxCONNECTED.Size = new System.Drawing.Size(120, 68);
            this.pictureBoxCONNECTED.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCONNECTED.TabIndex = 79;
            this.pictureBoxCONNECTED.TabStop = false;
            this.pictureBoxCONNECTED.Visible = false;
            // 
            // rDC_IdTextBox
            // 
            this.rDC_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rDCBindingSource, "RDC_Id", true));
            this.rDC_IdTextBox.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rDC_IdTextBox.Location = new System.Drawing.Point(198, 275);
            this.rDC_IdTextBox.Name = "rDC_IdTextBox";
            this.rDC_IdTextBox.Size = new System.Drawing.Size(200, 25);
            this.rDC_IdTextBox.TabIndex = 66;
            // 
            // descriptionTextBox2
            // 
            this.descriptionTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rDCBindingSource, "Description", true));
            this.descriptionTextBox2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox2.Location = new System.Drawing.Point(198, 310);
            this.descriptionTextBox2.Name = "descriptionTextBox2";
            this.descriptionTextBox2.Size = new System.Drawing.Size(200, 25);
            this.descriptionTextBox2.TabIndex = 68;
            // 
            // mCU_IdTextBox
            // 
            this.mCU_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rDCBindingSource, "MCU_Id", true));
            this.mCU_IdTextBox.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mCU_IdTextBox.Location = new System.Drawing.Point(198, 345);
            this.mCU_IdTextBox.Name = "mCU_IdTextBox";
            this.mCU_IdTextBox.Size = new System.Drawing.Size(200, 25);
            this.mCU_IdTextBox.TabIndex = 70;
            // 
            // area_IdTextBox1
            // 
            this.area_IdTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rDCBindingSource, "Area_Id", true));
            this.area_IdTextBox1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.area_IdTextBox1.Location = new System.Drawing.Point(198, 380);
            this.area_IdTextBox1.Name = "area_IdTextBox1";
            this.area_IdTextBox1.Size = new System.Drawing.Size(200, 25);
            this.area_IdTextBox1.TabIndex = 72;
            // 
            // manufactor_IdTextBox1
            // 
            this.manufactor_IdTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rDCBindingSource, "Manufactor_Id", true));
            this.manufactor_IdTextBox1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufactor_IdTextBox1.Location = new System.Drawing.Point(198, 415);
            this.manufactor_IdTextBox1.Name = "manufactor_IdTextBox1";
            this.manufactor_IdTextBox1.Size = new System.Drawing.Size(200, 25);
            this.manufactor_IdTextBox1.TabIndex = 74;
            // 
            // model_IdTextBox1
            // 
            this.model_IdTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rDCBindingSource, "Model_Id", true));
            this.model_IdTextBox1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.model_IdTextBox1.Location = new System.Drawing.Point(198, 450);
            this.model_IdTextBox1.Name = "model_IdTextBox1";
            this.model_IdTextBox1.Size = new System.Drawing.Size(200, 25);
            this.model_IdTextBox1.TabIndex = 76;
            // 
            // configuration_Edit_DateDateTimePicker2
            // 
            this.configuration_Edit_DateDateTimePicker2.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.rDCBindingSource, "Configuration_Edit_Date", true));
            this.configuration_Edit_DateDateTimePicker2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configuration_Edit_DateDateTimePicker2.Location = new System.Drawing.Point(198, 485);
            this.configuration_Edit_DateDateTimePicker2.Name = "configuration_Edit_DateDateTimePicker2";
            this.configuration_Edit_DateDateTimePicker2.Size = new System.Drawing.Size(200, 25);
            this.configuration_Edit_DateDateTimePicker2.TabIndex = 78;
            // 
            // buttonDisconnectInstrument
            // 
            this.buttonDisconnectInstrument.FlatAppearance.BorderSize = 0;
            this.buttonDisconnectInstrument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDisconnectInstrument.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisconnectInstrument.ForeColor = System.Drawing.Color.Red;
            this.buttonDisconnectInstrument.Location = new System.Drawing.Point(618, 566);
            this.buttonDisconnectInstrument.Name = "buttonDisconnectInstrument";
            this.buttonDisconnectInstrument.Size = new System.Drawing.Size(293, 33);
            this.buttonDisconnectInstrument.TabIndex = 65;
            this.buttonDisconnectInstrument.Text = "Disconnect from instrument";
            this.buttonDisconnectInstrument.UseVisualStyleBackColor = true;
            this.buttonDisconnectInstrument.Visible = false;
            this.buttonDisconnectInstrument.Click += new System.EventHandler(this.buttonDisconnectInstrument_Click_1);
            // 
            // buttonConnectFromDB
            // 
            this.buttonConnectFromDB.FlatAppearance.BorderSize = 0;
            this.buttonConnectFromDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConnectFromDB.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnectFromDB.ForeColor = System.Drawing.Color.Lime;
            this.buttonConnectFromDB.Location = new System.Drawing.Point(645, 566);
            this.buttonConnectFromDB.Name = "buttonConnectFromDB";
            this.buttonConnectFromDB.Size = new System.Drawing.Size(230, 33);
            this.buttonConnectFromDB.TabIndex = 63;
            this.buttonConnectFromDB.Text = "Connect to instrument";
            this.buttonConnectFromDB.UseVisualStyleBackColor = true;
            this.buttonConnectFromDB.Click += new System.EventHandler(this.buttonConnectFromDB_Click);
            // 
            // comboBoxCategory_DAU
            // 
            this.comboBoxCategory_DAU.BackColor = System.Drawing.Color.White;
            this.comboBoxCategory_DAU.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dAUBindingSource, "Category_Id", true));
            this.comboBoxCategory_DAU.DataSource = this.categoryBindingSource;
            this.comboBoxCategory_DAU.DisplayMember = "Category";
            this.comboBoxCategory_DAU.Enabled = false;
            this.comboBoxCategory_DAU.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCategory_DAU.FormattingEnabled = true;
            this.comboBoxCategory_DAU.Location = new System.Drawing.Point(659, 456);
            this.comboBoxCategory_DAU.Name = "comboBoxCategory_DAU";
            this.comboBoxCategory_DAU.Size = new System.Drawing.Size(200, 25);
            this.comboBoxCategory_DAU.TabIndex = 62;
            this.comboBoxCategory_DAU.ValueMember = "Category_Id";
            // 
            // comboBoxManu_DAU
            // 
            this.comboBoxManu_DAU.BackColor = System.Drawing.Color.White;
            this.comboBoxManu_DAU.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dAUBindingSource, "Manufactor_Id", true));
            this.comboBoxManu_DAU.DataSource = this.manufactorBindingSource;
            this.comboBoxManu_DAU.DisplayMember = "Manufactor";
            this.comboBoxManu_DAU.Enabled = false;
            this.comboBoxManu_DAU.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxManu_DAU.FormattingEnabled = true;
            this.comboBoxManu_DAU.Location = new System.Drawing.Point(659, 430);
            this.comboBoxManu_DAU.Name = "comboBoxManu_DAU";
            this.comboBoxManu_DAU.Size = new System.Drawing.Size(200, 25);
            this.comboBoxManu_DAU.TabIndex = 61;
            this.comboBoxManu_DAU.ValueMember = "Manufactor_Id";
            // 
            // comboBoxCommunication_DAU
            // 
            this.comboBoxCommunication_DAU.BackColor = System.Drawing.Color.White;
            this.comboBoxCommunication_DAU.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dAUBindingSource, "Communication_Id", true));
            this.comboBoxCommunication_DAU.DataSource = this.communicationBindingSource;
            this.comboBoxCommunication_DAU.DisplayMember = "Communication";
            this.comboBoxCommunication_DAU.Enabled = false;
            this.comboBoxCommunication_DAU.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCommunication_DAU.FormattingEnabled = true;
            this.comboBoxCommunication_DAU.Location = new System.Drawing.Point(659, 404);
            this.comboBoxCommunication_DAU.Name = "comboBoxCommunication_DAU";
            this.comboBoxCommunication_DAU.Size = new System.Drawing.Size(200, 25);
            this.comboBoxCommunication_DAU.TabIndex = 60;
            this.comboBoxCommunication_DAU.ValueMember = "Communication_Id";
            // 
            // comboBoxModel_DAU
            // 
            this.comboBoxModel_DAU.BackColor = System.Drawing.Color.White;
            this.comboBoxModel_DAU.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dAUBindingSource, "Model_Id", true));
            this.comboBoxModel_DAU.DataSource = this.modelBindingSource;
            this.comboBoxModel_DAU.DisplayMember = "Model";
            this.comboBoxModel_DAU.Enabled = false;
            this.comboBoxModel_DAU.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxModel_DAU.FormattingEnabled = true;
            this.comboBoxModel_DAU.Location = new System.Drawing.Point(659, 378);
            this.comboBoxModel_DAU.Name = "comboBoxModel_DAU";
            this.comboBoxModel_DAU.Size = new System.Drawing.Size(200, 25);
            this.comboBoxModel_DAU.TabIndex = 59;
            this.comboBoxModel_DAU.ValueMember = "Model_Id";
            // 
            // comboBoxAREA_DAU
            // 
            this.comboBoxAREA_DAU.BackColor = System.Drawing.Color.White;
            this.comboBoxAREA_DAU.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dAUBindingSource, "Area_Id", true));
            this.comboBoxAREA_DAU.DataSource = this.areaBindingSource;
            this.comboBoxAREA_DAU.DisplayMember = "Area";
            this.comboBoxAREA_DAU.Enabled = false;
            this.comboBoxAREA_DAU.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAREA_DAU.FormattingEnabled = true;
            this.comboBoxAREA_DAU.Location = new System.Drawing.Point(659, 353);
            this.comboBoxAREA_DAU.Name = "comboBoxAREA_DAU";
            this.comboBoxAREA_DAU.Size = new System.Drawing.Size(200, 25);
            this.comboBoxAREA_DAU.TabIndex = 58;
            this.comboBoxAREA_DAU.ValueMember = "Area_Id";
            // 
            // comboBoxRDC_DAU
            // 
            this.comboBoxRDC_DAU.BackColor = System.Drawing.Color.White;
            this.comboBoxRDC_DAU.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dAUBindingSource, "RDC_Id", true));
            this.comboBoxRDC_DAU.DataSource = this.rDCBindingSource;
            this.comboBoxRDC_DAU.DisplayMember = "Description";
            this.comboBoxRDC_DAU.Enabled = false;
            this.comboBoxRDC_DAU.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRDC_DAU.FormattingEnabled = true;
            this.comboBoxRDC_DAU.Location = new System.Drawing.Point(659, 326);
            this.comboBoxRDC_DAU.Name = "comboBoxRDC_DAU";
            this.comboBoxRDC_DAU.Size = new System.Drawing.Size(200, 25);
            this.comboBoxRDC_DAU.TabIndex = 57;
            this.comboBoxRDC_DAU.ValueMember = "RDC_Id";
            // 
            // dAU_IdTextBox
            // 
            this.dAU_IdTextBox.BackColor = System.Drawing.Color.White;
            this.dAU_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dAUBindingSource, "DAU_Id", true));
            this.dAU_IdTextBox.Enabled = false;
            this.dAU_IdTextBox.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dAU_IdTextBox.Location = new System.Drawing.Point(659, 270);
            this.dAU_IdTextBox.Name = "dAU_IdTextBox";
            this.dAU_IdTextBox.Size = new System.Drawing.Size(200, 25);
            this.dAU_IdTextBox.TabIndex = 36;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.Color.White;
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dAUBindingSource, "Description", true));
            this.descriptionTextBox.Enabled = false;
            this.descriptionTextBox.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(659, 298);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(200, 25);
            this.descriptionTextBox.TabIndex = 38;
            // 
            // cOMPortTextBox
            // 
            this.cOMPortTextBox.BackColor = System.Drawing.Color.White;
            this.cOMPortTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dAUBindingSource, "COMPort", true));
            this.cOMPortTextBox.Enabled = false;
            this.cOMPortTextBox.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cOMPortTextBox.Location = new System.Drawing.Point(659, 483);
            this.cOMPortTextBox.Name = "cOMPortTextBox";
            this.cOMPortTextBox.Size = new System.Drawing.Size(200, 25);
            this.cOMPortTextBox.TabIndex = 52;
            // 
            // bAUDRateTextBox
            // 
            this.bAUDRateTextBox.BackColor = System.Drawing.Color.White;
            this.bAUDRateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dAUBindingSource, "BAUDRate", true));
            this.bAUDRateTextBox.Enabled = false;
            this.bAUDRateTextBox.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAUDRateTextBox.Location = new System.Drawing.Point(659, 509);
            this.bAUDRateTextBox.Name = "bAUDRateTextBox";
            this.bAUDRateTextBox.Size = new System.Drawing.Size(200, 25);
            this.bAUDRateTextBox.TabIndex = 54;
            // 
            // configuration_edit_dateDateTimePicker
            // 
            this.configuration_edit_dateDateTimePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.configuration_edit_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dAUBindingSource, "Configuration_edit_date", true));
            this.configuration_edit_dateDateTimePicker.Enabled = false;
            this.configuration_edit_dateDateTimePicker.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configuration_edit_dateDateTimePicker.Location = new System.Drawing.Point(659, 535);
            this.configuration_edit_dateDateTimePicker.Name = "configuration_edit_dateDateTimePicker";
            this.configuration_edit_dateDateTimePicker.Size = new System.Drawing.Size(200, 25);
            this.configuration_edit_dateDateTimePicker.TabIndex = 56;
            // 
            // comboBoxFindDevice
            // 
            this.comboBoxFindDevice.BackColor = System.Drawing.Color.White;
            this.comboBoxFindDevice.DataSource = this.dAU_OnlyIdDesBindingSource;
            this.comboBoxFindDevice.DisplayMember = "DAU_Id";
            this.comboBoxFindDevice.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFindDevice.ForeColor = System.Drawing.Color.Black;
            this.comboBoxFindDevice.FormattingEnabled = true;
            this.comboBoxFindDevice.Location = new System.Drawing.Point(659, 168);
            this.comboBoxFindDevice.Name = "comboBoxFindDevice";
            this.comboBoxFindDevice.Size = new System.Drawing.Size(200, 25);
            this.comboBoxFindDevice.TabIndex = 35;
            this.comboBoxFindDevice.ValueMember = "DAU_Id";
            this.comboBoxFindDevice.SelectedIndexChanged += new System.EventHandler(this.comboBoxFindDevice_SelectedIndexChanged);
            // 
            // labelFindDevice
            // 
            this.labelFindDevice.AutoSize = true;
            this.labelFindDevice.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFindDevice.Location = new System.Drawing.Point(563, 174);
            this.labelFindDevice.Name = "labelFindDevice";
            this.labelFindDevice.Size = new System.Drawing.Size(74, 17);
            this.labelFindDevice.TabIndex = 34;
            this.labelFindDevice.Text = "Find Device";
            // 
            // buttonCancelDAU
            // 
            this.buttonCancelDAU.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelDAU.Location = new System.Drawing.Point(769, 232);
            this.buttonCancelDAU.Name = "buttonCancelDAU";
            this.buttonCancelDAU.Size = new System.Drawing.Size(90, 23);
            this.buttonCancelDAU.TabIndex = 33;
            this.buttonCancelDAU.Text = "Cancel";
            this.buttonCancelDAU.UseVisualStyleBackColor = true;
            this.buttonCancelDAU.Click += new System.EventHandler(this.buttonCancelDAU_Click);
            // 
            // buttonNEW
            // 
            this.buttonNEW.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNEW.Location = new System.Drawing.Point(659, 232);
            this.buttonNEW.Name = "buttonNEW";
            this.buttonNEW.Size = new System.Drawing.Size(89, 23);
            this.buttonNEW.TabIndex = 32;
            this.buttonNEW.Text = "New";
            this.buttonNEW.UseVisualStyleBackColor = true;
            this.buttonNEW.Click += new System.EventHandler(this.buttonNEW_Click);
            // 
            // buttonDAU_Save
            // 
            this.buttonDAU_Save.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDAU_Save.Location = new System.Drawing.Point(769, 203);
            this.buttonDAU_Save.Name = "buttonDAU_Save";
            this.buttonDAU_Save.Size = new System.Drawing.Size(90, 23);
            this.buttonDAU_Save.TabIndex = 31;
            this.buttonDAU_Save.Text = "Save";
            this.buttonDAU_Save.UseVisualStyleBackColor = true;
            this.buttonDAU_Save.Click += new System.EventHandler(this.buttonDAU_Save_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChange.Location = new System.Drawing.Point(659, 203);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(89, 23);
            this.buttonChange.TabIndex = 30;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // toolStripback
            // 
            this.toolStripback.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripback.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStripback.Location = new System.Drawing.Point(3, 722);
            this.toolStripback.Name = "toolStripback";
            this.toolStripback.Size = new System.Drawing.Size(1185, 25);
            this.toolStripback.TabIndex = 7;
            this.toolStripback.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(39, 22);
            this.toolStripLabel1.Text = "Ready";
            // 
            // labelBitrate
            // 
            this.labelBitrate.AutoSize = true;
            this.labelBitrate.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBitrate.Location = new System.Drawing.Point(811, 116);
            this.labelBitrate.Name = "labelBitrate";
            this.labelBitrate.Size = new System.Drawing.Size(48, 17);
            this.labelBitrate.TabIndex = 6;
            this.labelBitrate.Text = "Bitrate:";
            this.labelBitrate.Visible = false;
            this.labelBitrate.MouseHover += new System.EventHandler(this.labelBitrate_MouseHover);
            // 
            // labelCom
            // 
            this.labelCom.AutoSize = true;
            this.labelCom.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCom.Location = new System.Drawing.Point(802, 80);
            this.labelCom.Name = "labelCom";
            this.labelCom.Size = new System.Drawing.Size(62, 17);
            this.labelCom.TabIndex = 5;
            this.labelCom.Text = "ComPort:";
            this.labelCom.Visible = false;
            this.labelCom.MouseHover += new System.EventHandler(this.labelCom_MouseHover);
            // 
            // radioButtonConnected
            // 
            this.radioButtonConnected.AutoSize = true;
            this.radioButtonConnected.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonConnected.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonConnected.ForeColor = System.Drawing.Color.LimeGreen;
            this.radioButtonConnected.Location = new System.Drawing.Point(1004, 152);
            this.radioButtonConnected.Name = "radioButtonConnected";
            this.radioButtonConnected.Size = new System.Drawing.Size(14, 13);
            this.radioButtonConnected.TabIndex = 4;
            this.radioButtonConnected.TabStop = true;
            this.radioButtonConnected.UseVisualStyleBackColor = false;
            this.radioButtonConnected.Visible = false;
            this.radioButtonConnected.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButtonConnected_MouseClick);
            this.radioButtonConnected.MouseHover += new System.EventHandler(this.radioButtonConnected_MouseHover);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisconnect.Location = new System.Drawing.Point(886, 181);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(112, 23);
            this.buttonDisconnect.TabIndex = 3;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Visible = false;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            this.buttonDisconnect.MouseHover += new System.EventHandler(this.buttonDisconnect_MouseHover);
            // 
            // buttonConnect
            // 
            this.buttonConnect.FlatAppearance.BorderSize = 0;
            this.buttonConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConnect.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.buttonConnect.Location = new System.Drawing.Point(886, 147);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(112, 23);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Visible = false;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            this.buttonConnect.MouseHover += new System.EventHandler(this.buttonConnect_MouseHover);
            // 
            // ComboBoxBaud
            // 
            this.ComboBoxBaud.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxBaud.FormattingEnabled = true;
            this.ComboBoxBaud.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "76800",
            "153600"});
            this.ComboBoxBaud.Location = new System.Drawing.Point(870, 116);
            this.ComboBoxBaud.Name = "ComboBoxBaud";
            this.ComboBoxBaud.Size = new System.Drawing.Size(148, 25);
            this.ComboBoxBaud.TabIndex = 1;
            this.ComboBoxBaud.Visible = false;
            this.ComboBoxBaud.Enter += new System.EventHandler(this.ComboBoxBaud_Enter);
            // 
            // ComboBoxPorts
            // 
            this.ComboBoxPorts.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxPorts.FormattingEnabled = true;
            this.ComboBoxPorts.Location = new System.Drawing.Point(870, 78);
            this.ComboBoxPorts.Name = "ComboBoxPorts";
            this.ComboBoxPorts.Size = new System.Drawing.Size(148, 25);
            this.ComboBoxPorts.TabIndex = 0;
            this.ComboBoxPorts.Visible = false;
            this.ComboBoxPorts.Enter += new System.EventHandler(this.comboBoxPorts_Enter);
            this.ComboBoxPorts.MouseHover += new System.EventHandler(this.ComboBoxPorts_MouseHover);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPageConnection);
            this.tabControl.Controls.Add(this.tabPageConfiguration);
            this.tabControl.Controls.Add(this.tabPageCommand);
            this.tabControl.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.ItemSize = new System.Drawing.Size(500, 30);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(151, 5);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1199, 788);
            this.tabControl.TabIndex = 0;
            // 
            // iNSTRUMENTtoComboBoxBindingSource
            // 
            this.iNSTRUMENTtoComboBoxBindingSource.DataMember = "INSTRUMENTtoComboBox";
            this.iNSTRUMENTtoComboBoxBindingSource.DataSource = this.sOFTSENSECONF_DATABASE_FINALDataSet;
            // 
            // iNSTRUMENTtoComboBoxTableAdapter
            // 
            this.iNSTRUMENTtoComboBoxTableAdapter.ClearBeforeFill = true;
            // 
            // aI_LOGTableAdapter
            // 
            this.aI_LOGTableAdapter.ClearBeforeFill = true;
            // 
            // instrument_Measure_IdTableAdapter
            // 
            this.instrument_Measure_IdTableAdapter.ClearBeforeFill = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(901, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(48, 23);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // rDC1BindingSource
            // 
            this.rDC1BindingSource.DataMember = "RDC1";
            this.rDC1BindingSource.DataSource = this.sOFTSENSECONF_DATABASE_FINALDataSet;
            // 
            // SoftSensConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1200, 667);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SoftSensConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoftSensConfig";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sOFTSENSECONF_DATABASE_FINALDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNSTRUMENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufactorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.communicationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAU_OnlyIdDesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrument_Measure_IdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aI_LOGBindingSource)).EndInit();
            this.tabPageCommand.ResumeLayout(false);
            this.tabPageCommand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPoints)).EndInit();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.tabPageConfiguration.ResumeLayout(false);
            this.tabPageConfiguration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabPageConnection.ResumeLayout(false);
            this.tabPageConnection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisconnected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCONNECTED)).EndInit();
            this.toolStripback.ResumeLayout(false);
            this.toolStripback.PerformLayout();
            this.tabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iNSTRUMENTtoComboBoxBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDC1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer timerReceive;
        private System.Windows.Forms.Timer timerChartRaw;
        private System.Windows.Forms.Timer timerChartScaled;
        private System.Windows.Forms.Timer timerStatus;
        private SOFTSENSECONF_DATABASE_FINALDataSet sOFTSENSECONF_DATABASE_FINALDataSet;
        private System.Windows.Forms.BindingSource dAUBindingSource;
        private SOFTSENSECONF_DATABASE_FINALDataSetTableAdapters.DAUTableAdapter dAUTableAdapter;
        private SOFTSENSECONF_DATABASE_FINALDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource dAU_OnlyIdDesBindingSource;
        private SOFTSENSECONF_DATABASE_FINALDataSetTableAdapters.DAU_OnlyIdDesTableAdapter dAU_OnlyIdDesTableAdapter;
        private System.Windows.Forms.BindingSource rDCBindingSource;
        private SOFTSENSECONF_DATABASE_FINALDataSetTableAdapters.RDCTableAdapter rDCTableAdapter;
        private System.Windows.Forms.BindingSource areaBindingSource;
        private SOFTSENSECONF_DATABASE_FINALDataSetTableAdapters.AreaTableAdapter areaTableAdapter;
        private System.Windows.Forms.BindingSource modelBindingSource;
        private SOFTSENSECONF_DATABASE_FINALDataSetTableAdapters.ModelTableAdapter modelTableAdapter;
        private System.Windows.Forms.BindingSource communicationBindingSource;
        private SOFTSENSECONF_DATABASE_FINALDataSetTableAdapters.CommunicationTableAdapter communicationTableAdapter;
        private System.Windows.Forms.BindingSource manufactorBindingSource;
        private SOFTSENSECONF_DATABASE_FINALDataSetTableAdapters.ManufactorTableAdapter manufactorTableAdapter;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private SOFTSENSECONF_DATABASE_FINALDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.BindingSource iNSTRUMENTBindingSource;
        private SOFTSENSECONF_DATABASE_FINALDataSetTableAdapters.INSTRUMENTTableAdapter iNSTRUMENTTableAdapter;
        private System.Windows.Forms.TabPage tabPageCommand;
        private System.Windows.Forms.TextBox textBoxConnectionP2;
        private System.Windows.Forms.TextBox textBoxSend;
        private System.Windows.Forms.TextBox textBoxReceive;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Button buttonReceive;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TabPage tabPageConfiguration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDataBaseInstrument;
        private System.Windows.Forms.TextBox tagNameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox1;
        private System.Windows.Forms.TextBox lower_range_valueTextBox;
        private System.Windows.Forms.TextBox upper_range_valueTextBox;
        private System.Windows.Forms.TextBox alarm_LowTextBox;
        private System.Windows.Forms.TextBox alarm_highTextBox;
        private System.Windows.Forms.TextBox category_IdTextBox;
        private System.Windows.Forms.TextBox model_IdTextBox;
        private System.Windows.Forms.TextBox manufactor_IdTextBox;
        private System.Windows.Forms.TextBox dAU_IdTextBox1;
        private System.Windows.Forms.TextBox communication_IdTextBox;
        private System.Windows.Forms.TextBox frequencyTextBox;
        private System.Windows.Forms.TextBox area_IdTextBox;
        private System.Windows.Forms.TextBox innput_Output_IdTextBox;
        private System.Windows.Forms.TextBox textBoxConnectionP1;
        private System.Windows.Forms.TextBox textBoxAH;
        private System.Windows.Forms.TextBox textBoxAL;
        private System.Windows.Forms.TextBox textBoxURV;
        private System.Windows.Forms.TextBox textBoxLRV;
        private System.Windows.Forms.TextBox textBoxTag;
        private System.Windows.Forms.DateTimePicker configuration_Edit_DateDateTimePicker1;
        private System.Windows.Forms.Button buttonRetrieve;
        private System.Windows.Forms.Button buttonSendValues;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Label labelAH;
        private System.Windows.Forms.Label labelAL;
        private System.Windows.Forms.Label labelURV;
        private System.Windows.Forms.Label labelLRV;
        private System.Windows.Forms.Label labelTag;
        private System.Windows.Forms.TabPage tabPageConnection;
        private System.Windows.Forms.ComboBox comboBoxCategory_DAU;
        private System.Windows.Forms.ComboBox comboBoxManu_DAU;
        private System.Windows.Forms.ComboBox comboBoxCommunication_DAU;
        private System.Windows.Forms.ComboBox comboBoxModel_DAU;
        private System.Windows.Forms.ComboBox comboBoxAREA_DAU;
        private System.Windows.Forms.ComboBox comboBoxRDC_DAU;
        private System.Windows.Forms.TextBox dAU_IdTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox cOMPortTextBox;
        private System.Windows.Forms.TextBox bAUDRateTextBox;
        private System.Windows.Forms.DateTimePicker configuration_edit_dateDateTimePicker;
        private System.Windows.Forms.ComboBox comboBoxFindDevice;
        private System.Windows.Forms.Label labelFindDevice;
        private System.Windows.Forms.Button buttonCancelDAU;
        private System.Windows.Forms.Button buttonNEW;
        private System.Windows.Forms.Button buttonDAU_Save;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.ToolStrip toolStripback;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Label labelBitrate;
        private System.Windows.Forms.Label labelCom;
        private System.Windows.Forms.RadioButton radioButtonConnected;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.ComboBox ComboBoxBaud;
        private System.Windows.Forms.ComboBox ComboBoxPorts;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Label labelMatching;
        private System.Windows.Forms.TextBox textBoxMatch;
        private System.Windows.Forms.BindingSource iNSTRUMENTtoComboBoxBindingSource;
        private SOFTSENSECONF_DATABASE_FINALDataSetTableAdapters.INSTRUMENTtoComboBoxTableAdapter iNSTRUMENTtoComboBoxTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxFindInstrument;
        private System.Windows.Forms.BindingSource aI_LOGBindingSource;
        private SOFTSENSECONF_DATABASE_FINALDataSetTableAdapters.AI_LOGTableAdapter aI_LOGTableAdapter;
        private System.Windows.Forms.BindingSource instrument_Measure_IdBindingSource;
        private SOFTSENSECONF_DATABASE_FINALDataSetTableAdapters.Instrument_Measure_IdTableAdapter instrument_Measure_IdTableAdapter;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonConnectFromDB;
        private System.Windows.Forms.Button buttonDisconnectInstrument;
        private System.Windows.Forms.TextBox rDC_IdTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox2;
        private System.Windows.Forms.TextBox mCU_IdTextBox;
        private System.Windows.Forms.TextBox area_IdTextBox1;
        private System.Windows.Forms.TextBox manufactor_IdTextBox1;
        private System.Windows.Forms.TextBox model_IdTextBox1;
        private System.Windows.Forms.DateTimePicker configuration_Edit_DateDateTimePicker2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPoints;
        private System.Windows.Forms.Button buttonGraphstart;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonstopgraph;
        private System.Windows.Forms.TextBox tagNameTextBox1;
        private System.Windows.Forms.TextBox instrument_Log_IdTextBox1;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.DateTimePicker timeDateTimePicker;
        private System.Windows.Forms.TextBox instrument_Log_IdTextBox;
        private System.Windows.Forms.PictureBox pictureBoxCONNECTED;
        private System.Windows.Forms.PictureBox pictureBoxDisconnected;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxFindingDeviceRDC;
        private System.Windows.Forms.Label RDCFIND;
        private System.Windows.Forms.BindingSource rDC1BindingSource;
    }
}

