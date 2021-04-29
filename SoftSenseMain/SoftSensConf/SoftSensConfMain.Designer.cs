
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.Label valueLabel;
            System.Windows.Forms.Label timeLabel;
            System.Windows.Forms.Label instrument_Log_IdLabel;
            System.Windows.Forms.Label tagNameLabel1;
            System.Windows.Forms.Label instrument_Log_IdLabel1;
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
            this.Instrument = new System.Windows.Forms.TabPage();
            this.buttonSavetest = new System.Windows.Forms.Button();
            this.Newtest = new System.Windows.Forms.Button();
            this.listBoxValueAI = new System.Windows.Forms.ListBox();
            this.tabPageGraph = new System.Windows.Forms.TabPage();
            this.textBoxConnectionP3 = new System.Windows.Forms.TextBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.statusStrip3 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonSavetofile = new System.Windows.Forms.Button();
            this.buttonClearV = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonScaled = new System.Windows.Forms.Button();
            this.listBoxReading = new System.Windows.Forms.ListBox();
            this.buttonRaw = new System.Windows.Forms.Button();
            this.chartPoints = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPageCommand = new System.Windows.Forms.TabPage();
            this.textBoxConnectionP2 = new System.Windows.Forms.TextBox();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.textBoxReceive = new System.Windows.Forms.TextBox();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelInput = new System.Windows.Forms.Label();
            this.buttonReceive = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.tabPageConfiguration = new System.Windows.Forms.TabPage();
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
            this.aI_LOGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aI_LOGTableAdapter = new SoftSensConf.SOFTSENSECONF_DATABASE_FINALDataSetTableAdapters.AI_LOGTableAdapter();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.instrument_Log_IdTextBox = new System.Windows.Forms.TextBox();
            this.instrument_Measure_IdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instrument_Measure_IdTableAdapter = new SoftSensConf.SOFTSENSECONF_DATABASE_FINALDataSetTableAdapters.Instrument_Measure_IdTableAdapter();
            this.tagNameTextBox1 = new System.Windows.Forms.TextBox();
            this.instrument_Log_IdTextBox1 = new System.Windows.Forms.TextBox();
            this.buttonReadAnalog = new System.Windows.Forms.Button();
            this.timeDateTimePicker = new System.Windows.Forms.DateTimePicker();
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
            valueLabel = new System.Windows.Forms.Label();
            timeLabel = new System.Windows.Forms.Label();
            instrument_Log_IdLabel = new System.Windows.Forms.Label();
            tagNameLabel1 = new System.Windows.Forms.Label();
            instrument_Log_IdLabel1 = new System.Windows.Forms.Label();
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
            this.Instrument.SuspendLayout();
            this.tabPageGraph.SuspendLayout();
            this.statusStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPoints)).BeginInit();
            this.tabPageCommand.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.tabPageConfiguration.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabPageConnection.SuspendLayout();
            this.toolStripback.SuspendLayout();
            this.tabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iNSTRUMENTtoComboBoxBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aI_LOGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrument_Measure_IdBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // configuration_Edit_DateLabel1
            // 
            configuration_Edit_DateLabel1.AutoSize = true;
            configuration_Edit_DateLabel1.Location = new System.Drawing.Point(8, 517);
            configuration_Edit_DateLabel1.Name = "configuration_Edit_DateLabel1";
            configuration_Edit_DateLabel1.Size = new System.Drawing.Size(119, 13);
            configuration_Edit_DateLabel1.TabIndex = 47;
            configuration_Edit_DateLabel1.Text = "Configuration Edit Date:";
            // 
            // innput_Output_IdLabel
            // 
            innput_Output_IdLabel.AutoSize = true;
            innput_Output_IdLabel.Location = new System.Drawing.Point(8, 490);
            innput_Output_IdLabel.Name = "innput_Output_IdLabel";
            innput_Output_IdLabel.Size = new System.Drawing.Size(87, 13);
            innput_Output_IdLabel.TabIndex = 45;
            innput_Output_IdLabel.Text = "Innput Output Id:";
            // 
            // area_IdLabel1
            // 
            area_IdLabel1.AutoSize = true;
            area_IdLabel1.Location = new System.Drawing.Point(8, 464);
            area_IdLabel1.Name = "area_IdLabel1";
            area_IdLabel1.Size = new System.Drawing.Size(44, 13);
            area_IdLabel1.TabIndex = 43;
            area_IdLabel1.Text = "Area Id:";
            // 
            // frequencyLabel
            // 
            frequencyLabel.AutoSize = true;
            frequencyLabel.Location = new System.Drawing.Point(8, 438);
            frequencyLabel.Name = "frequencyLabel";
            frequencyLabel.Size = new System.Drawing.Size(60, 13);
            frequencyLabel.TabIndex = 41;
            frequencyLabel.Text = "Frequency:";
            // 
            // communication_IdLabel1
            // 
            communication_IdLabel1.AutoSize = true;
            communication_IdLabel1.Location = new System.Drawing.Point(8, 412);
            communication_IdLabel1.Name = "communication_IdLabel1";
            communication_IdLabel1.Size = new System.Drawing.Size(94, 13);
            communication_IdLabel1.TabIndex = 39;
            communication_IdLabel1.Text = "Communication Id:";
            // 
            // dAU_IdLabel1
            // 
            dAU_IdLabel1.AutoSize = true;
            dAU_IdLabel1.Location = new System.Drawing.Point(8, 386);
            dAU_IdLabel1.Name = "dAU_IdLabel1";
            dAU_IdLabel1.Size = new System.Drawing.Size(45, 13);
            dAU_IdLabel1.TabIndex = 37;
            dAU_IdLabel1.Text = "DAU Id:";
            // 
            // manufactor_IdLabel1
            // 
            manufactor_IdLabel1.AutoSize = true;
            manufactor_IdLabel1.Location = new System.Drawing.Point(8, 360);
            manufactor_IdLabel1.Name = "manufactor_IdLabel1";
            manufactor_IdLabel1.Size = new System.Drawing.Size(76, 13);
            manufactor_IdLabel1.TabIndex = 35;
            manufactor_IdLabel1.Text = "Manufactor Id:";
            // 
            // model_IdLabel1
            // 
            model_IdLabel1.AutoSize = true;
            model_IdLabel1.Location = new System.Drawing.Point(8, 334);
            model_IdLabel1.Name = "model_IdLabel1";
            model_IdLabel1.Size = new System.Drawing.Size(51, 13);
            model_IdLabel1.TabIndex = 33;
            model_IdLabel1.Text = "Model Id:";
            // 
            // category_IdLabel1
            // 
            category_IdLabel1.AutoSize = true;
            category_IdLabel1.Location = new System.Drawing.Point(8, 308);
            category_IdLabel1.Name = "category_IdLabel1";
            category_IdLabel1.Size = new System.Drawing.Size(64, 13);
            category_IdLabel1.TabIndex = 31;
            category_IdLabel1.Text = "Category Id:";
            // 
            // alarm_highLabel
            // 
            alarm_highLabel.AutoSize = true;
            alarm_highLabel.Location = new System.Drawing.Point(8, 282);
            alarm_highLabel.Name = "alarm_highLabel";
            alarm_highLabel.Size = new System.Drawing.Size(59, 13);
            alarm_highLabel.TabIndex = 29;
            alarm_highLabel.Text = "Alarm high:";
            // 
            // alarm_LowLabel
            // 
            alarm_LowLabel.AutoSize = true;
            alarm_LowLabel.Location = new System.Drawing.Point(8, 256);
            alarm_LowLabel.Name = "alarm_LowLabel";
            alarm_LowLabel.Size = new System.Drawing.Size(59, 13);
            alarm_LowLabel.TabIndex = 27;
            alarm_LowLabel.Text = "Alarm Low:";
            // 
            // upper_range_valueLabel
            // 
            upper_range_valueLabel.AutoSize = true;
            upper_range_valueLabel.Location = new System.Drawing.Point(8, 230);
            upper_range_valueLabel.Name = "upper_range_valueLabel";
            upper_range_valueLabel.Size = new System.Drawing.Size(98, 13);
            upper_range_valueLabel.TabIndex = 25;
            upper_range_valueLabel.Text = "Upper range value:";
            // 
            // lower_range_valueLabel
            // 
            lower_range_valueLabel.AutoSize = true;
            lower_range_valueLabel.Location = new System.Drawing.Point(8, 204);
            lower_range_valueLabel.Name = "lower_range_valueLabel";
            lower_range_valueLabel.Size = new System.Drawing.Size(98, 13);
            lower_range_valueLabel.TabIndex = 23;
            lower_range_valueLabel.Text = "Lower range value:";
            // 
            // descriptionLabel1
            // 
            descriptionLabel1.AutoSize = true;
            descriptionLabel1.Location = new System.Drawing.Point(8, 178);
            descriptionLabel1.Name = "descriptionLabel1";
            descriptionLabel1.Size = new System.Drawing.Size(63, 13);
            descriptionLabel1.TabIndex = 21;
            descriptionLabel1.Text = "Description:";
            // 
            // tagNameLabel
            // 
            tagNameLabel.AutoSize = true;
            tagNameLabel.Location = new System.Drawing.Point(8, 152);
            tagNameLabel.Name = "tagNameLabel";
            tagNameLabel.Size = new System.Drawing.Size(60, 13);
            tagNameLabel.TabIndex = 19;
            tagNameLabel.Text = "Tag Name:";
            // 
            // configuration_edit_dateLabel
            // 
            configuration_edit_dateLabel.AutoSize = true;
            configuration_edit_dateLabel.Location = new System.Drawing.Point(6, 507);
            configuration_edit_dateLabel.Name = "configuration_edit_dateLabel";
            configuration_edit_dateLabel.Size = new System.Drawing.Size(116, 13);
            configuration_edit_dateLabel.TabIndex = 55;
            configuration_edit_dateLabel.Text = "Configuration edit date:";
            // 
            // bAUDRateLabel
            // 
            bAUDRateLabel.AutoSize = true;
            bAUDRateLabel.Location = new System.Drawing.Point(59, 478);
            bAUDRateLabel.Name = "bAUDRateLabel";
            bAUDRateLabel.Size = new System.Drawing.Size(63, 13);
            bAUDRateLabel.TabIndex = 53;
            bAUDRateLabel.Text = "BAUDRate:";
            // 
            // cOMPortLabel
            // 
            cOMPortLabel.AutoSize = true;
            cOMPortLabel.Location = new System.Drawing.Point(69, 452);
            cOMPortLabel.Name = "cOMPortLabel";
            cOMPortLabel.Size = new System.Drawing.Size(53, 13);
            cOMPortLabel.TabIndex = 51;
            cOMPortLabel.Text = "COMPort:";
            // 
            // category_IdLabel
            // 
            category_IdLabel.AutoSize = true;
            category_IdLabel.Location = new System.Drawing.Point(71, 425);
            category_IdLabel.Name = "category_IdLabel";
            category_IdLabel.Size = new System.Drawing.Size(52, 13);
            category_IdLabel.TabIndex = 49;
            category_IdLabel.Text = "Category:";
            // 
            // manufactor_IdLabel
            // 
            manufactor_IdLabel.AutoSize = true;
            manufactor_IdLabel.Location = new System.Drawing.Point(59, 399);
            manufactor_IdLabel.Name = "manufactor_IdLabel";
            manufactor_IdLabel.Size = new System.Drawing.Size(64, 13);
            manufactor_IdLabel.TabIndex = 47;
            manufactor_IdLabel.Text = "Manufactor:";
            // 
            // communication_IdLabel
            // 
            communication_IdLabel.AutoSize = true;
            communication_IdLabel.Location = new System.Drawing.Point(41, 373);
            communication_IdLabel.Name = "communication_IdLabel";
            communication_IdLabel.Size = new System.Drawing.Size(82, 13);
            communication_IdLabel.TabIndex = 45;
            communication_IdLabel.Text = "Communication:";
            // 
            // model_IdLabel
            // 
            model_IdLabel.AutoSize = true;
            model_IdLabel.Location = new System.Drawing.Point(84, 347);
            model_IdLabel.Name = "model_IdLabel";
            model_IdLabel.Size = new System.Drawing.Size(39, 13);
            model_IdLabel.TabIndex = 43;
            model_IdLabel.Text = "Model:";
            // 
            // area_IdLabel
            // 
            area_IdLabel.AutoSize = true;
            area_IdLabel.Location = new System.Drawing.Point(91, 322);
            area_IdLabel.Name = "area_IdLabel";
            area_IdLabel.Size = new System.Drawing.Size(32, 13);
            area_IdLabel.TabIndex = 41;
            area_IdLabel.Text = "Area:";
            // 
            // rDC_IdLabel
            // 
            rDC_IdLabel.AutoSize = true;
            rDC_IdLabel.Location = new System.Drawing.Point(9, 295);
            rDC_IdLabel.Name = "rDC_IdLabel";
            rDC_IdLabel.Size = new System.Drawing.Size(114, 13);
            rDC_IdLabel.TabIndex = 39;
            rDC_IdLabel.Text = "Remote Data Collector";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(59, 270);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 37;
            descriptionLabel.Text = "Description:";
            // 
            // dAU_IdLabel
            // 
            dAU_IdLabel.AutoSize = true;
            dAU_IdLabel.Location = new System.Drawing.Point(20, 244);
            dAU_IdLabel.Name = "dAU_IdLabel";
            dAU_IdLabel.Size = new System.Drawing.Size(103, 13);
            dAU_IdLabel.TabIndex = 35;
            dAU_IdLabel.Text = "Data Aquisition Unit:";
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
            // Instrument
            // 
            this.Instrument.Controls.Add(this.buttonReadAnalog);
            this.Instrument.Controls.Add(tagNameLabel1);
            this.Instrument.Controls.Add(this.tagNameTextBox1);
            this.Instrument.Controls.Add(instrument_Log_IdLabel1);
            this.Instrument.Controls.Add(this.instrument_Log_IdTextBox1);
            this.Instrument.Controls.Add(valueLabel);
            this.Instrument.Controls.Add(this.valueTextBox);
            this.Instrument.Controls.Add(timeLabel);
            this.Instrument.Controls.Add(this.timeDateTimePicker);
            this.Instrument.Controls.Add(instrument_Log_IdLabel);
            this.Instrument.Controls.Add(this.instrument_Log_IdTextBox);
            this.Instrument.Controls.Add(this.buttonSavetest);
            this.Instrument.Controls.Add(this.Newtest);
            this.Instrument.Controls.Add(this.listBoxValueAI);
            this.Instrument.Location = new System.Drawing.Point(4, 22);
            this.Instrument.Name = "Instrument";
            this.Instrument.Size = new System.Drawing.Size(731, 564);
            this.Instrument.TabIndex = 4;
            this.Instrument.Text = "Instrument";
            this.Instrument.UseVisualStyleBackColor = true;
            this.Instrument.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // buttonSavetest
            // 
            this.buttonSavetest.Location = new System.Drawing.Point(141, 27);
            this.buttonSavetest.Name = "buttonSavetest";
            this.buttonSavetest.Size = new System.Drawing.Size(80, 23);
            this.buttonSavetest.TabIndex = 15;
            this.buttonSavetest.Text = "buttonSave";
            this.buttonSavetest.UseVisualStyleBackColor = true;
            this.buttonSavetest.Click += new System.EventHandler(this.buttonSavetest_Click);
            // 
            // Newtest
            // 
            this.Newtest.Location = new System.Drawing.Point(33, 27);
            this.Newtest.Name = "Newtest";
            this.Newtest.Size = new System.Drawing.Size(75, 23);
            this.Newtest.TabIndex = 14;
            this.Newtest.Text = "bttnNew";
            this.Newtest.UseVisualStyleBackColor = true;
            this.Newtest.Click += new System.EventHandler(this.Newtest_Click);
            // 
            // listBoxValueAI
            // 
            this.listBoxValueAI.DataSource = this.aI_LOGBindingSource;
            this.listBoxValueAI.DisplayMember = "Value";
            this.listBoxValueAI.FormattingEnabled = true;
            this.listBoxValueAI.Location = new System.Drawing.Point(416, 99);
            this.listBoxValueAI.Name = "listBoxValueAI";
            this.listBoxValueAI.Size = new System.Drawing.Size(200, 69);
            this.listBoxValueAI.TabIndex = 12;
            this.listBoxValueAI.ValueMember = "Value";
            // 
            // tabPageGraph
            // 
            this.tabPageGraph.BackColor = System.Drawing.Color.Gray;
            this.tabPageGraph.Controls.Add(this.textBoxConnectionP3);
            this.tabPageGraph.Controls.Add(this.textBoxStatus);
            this.tabPageGraph.Controls.Add(this.statusStrip3);
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
            this.tabPageGraph.Size = new System.Drawing.Size(731, 564);
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
            // textBoxStatus
            // 
            this.textBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStatus.Location = new System.Drawing.Point(236, 285);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(84, 24);
            this.textBoxStatus.TabIndex = 12;
            // 
            // statusStrip3
            // 
            this.statusStrip3.BackColor = System.Drawing.Color.Lavender;
            this.statusStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel3});
            this.statusStrip3.Location = new System.Drawing.Point(0, 542);
            this.statusStrip3.Name = "statusStrip3";
            this.statusStrip3.Size = new System.Drawing.Size(731, 22);
            this.statusStrip3.TabIndex = 13;
            this.statusStrip3.Text = "statusStrip3";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel3.Text = "Ready";
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
            this.listBoxReading.SelectedIndexChanged += new System.EventHandler(this.listBoxReading_SelectedIndexChanged);
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
            chartArea4.BackColor = System.Drawing.Color.Gray;
            chartArea4.BackSecondaryColor = System.Drawing.Color.Gray;
            chartArea4.Name = "ChartArea1";
            this.chartPoints.ChartAreas.Add(chartArea4);
            legend4.BackColor = System.Drawing.Color.Gray;
            legend4.Name = "Legend1";
            this.chartPoints.Legends.Add(legend4);
            this.chartPoints.Location = new System.Drawing.Point(296, 3);
            this.chartPoints.Name = "chartPoints";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Red;
            series4.Legend = "Legend1";
            series4.Name = "Va";
            this.chartPoints.Series.Add(series4);
            this.chartPoints.Size = new System.Drawing.Size(300, 300);
            this.chartPoints.TabIndex = 0;
            this.chartPoints.Text = "chart1";
            // 
            // tabPageCommand
            // 
            this.tabPageCommand.BackColor = System.Drawing.Color.Gray;
            this.tabPageCommand.Controls.Add(this.textBoxConnectionP2);
            this.tabPageCommand.Controls.Add(this.textBoxSend);
            this.tabPageCommand.Controls.Add(this.textBoxReceive);
            this.tabPageCommand.Controls.Add(this.statusStrip2);
            this.tabPageCommand.Controls.Add(this.labelInput);
            this.tabPageCommand.Controls.Add(this.buttonReceive);
            this.tabPageCommand.Controls.Add(this.buttonSend);
            this.tabPageCommand.Location = new System.Drawing.Point(4, 22);
            this.tabPageCommand.Name = "tabPageCommand";
            this.tabPageCommand.Size = new System.Drawing.Size(731, 564);
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
            // statusStrip2
            // 
            this.statusStrip2.BackColor = System.Drawing.Color.Lavender;
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2});
            this.statusStrip2.Location = new System.Drawing.Point(0, 542);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(731, 22);
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
            // tabPageConfiguration
            // 
            this.tabPageConfiguration.AutoScroll = true;
            this.tabPageConfiguration.BackColor = System.Drawing.Color.Gray;
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
            this.tabPageConfiguration.Location = new System.Drawing.Point(4, 22);
            this.tabPageConfiguration.Name = "tabPageConfiguration";
            this.tabPageConfiguration.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConfiguration.Size = new System.Drawing.Size(731, 564);
            this.tabPageConfiguration.TabIndex = 1;
            this.tabPageConfiguration.Text = "Configuration";
            this.tabPageConfiguration.Enter += new System.EventHandler(this.tabPageConfiguration_Enter);
            // 
            // comboBoxFindInstrument
            // 
            this.comboBoxFindInstrument.FormattingEnabled = true;
            this.comboBoxFindInstrument.Location = new System.Drawing.Point(132, 74);
            this.comboBoxFindInstrument.Name = "comboBoxFindInstrument";
            this.comboBoxFindInstrument.Size = new System.Drawing.Size(201, 21);
            this.comboBoxFindInstrument.TabIndex = 54;
            this.comboBoxFindInstrument.SelectedIndexChanged += new System.EventHandler(this.comboBoxFindInstrument_SelectedIndexChanged);
            // 
            // labelMatching
            // 
            this.labelMatching.AutoSize = true;
            this.labelMatching.Location = new System.Drawing.Point(350, 291);
            this.labelMatching.Name = "labelMatching";
            this.labelMatching.Size = new System.Drawing.Size(156, 13);
            this.labelMatching.TabIndex = 53;
            this.labelMatching.Text = "Instrument db and config match";
            // 
            // textBoxMatch
            // 
            this.textBoxMatch.Location = new System.Drawing.Point(353, 307);
            this.textBoxMatch.Name = "textBoxMatch";
            this.textBoxMatch.Size = new System.Drawing.Size(100, 20);
            this.textBoxMatch.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(523, 104);
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
            this.tagNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.tagNameTextBox.TabIndex = 20;
            // 
            // descriptionTextBox1
            // 
            this.descriptionTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNSTRUMENTBindingSource, "Description", true));
            this.descriptionTextBox1.Location = new System.Drawing.Point(133, 175);
            this.descriptionTextBox1.Name = "descriptionTextBox1";
            this.descriptionTextBox1.Size = new System.Drawing.Size(200, 20);
            this.descriptionTextBox1.TabIndex = 22;
            // 
            // lower_range_valueTextBox
            // 
            this.lower_range_valueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNSTRUMENTBindingSource, "Lower_range_value", true));
            this.lower_range_valueTextBox.Location = new System.Drawing.Point(133, 201);
            this.lower_range_valueTextBox.Name = "lower_range_valueTextBox";
            this.lower_range_valueTextBox.Size = new System.Drawing.Size(200, 20);
            this.lower_range_valueTextBox.TabIndex = 24;
            // 
            // upper_range_valueTextBox
            // 
            this.upper_range_valueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNSTRUMENTBindingSource, "Upper_range_value", true));
            this.upper_range_valueTextBox.Location = new System.Drawing.Point(133, 227);
            this.upper_range_valueTextBox.Name = "upper_range_valueTextBox";
            this.upper_range_valueTextBox.Size = new System.Drawing.Size(200, 20);
            this.upper_range_valueTextBox.TabIndex = 26;
            // 
            // alarm_LowTextBox
            // 
            this.alarm_LowTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNSTRUMENTBindingSource, "Alarm_Low", true));
            this.alarm_LowTextBox.Location = new System.Drawing.Point(133, 253);
            this.alarm_LowTextBox.Name = "alarm_LowTextBox";
            this.alarm_LowTextBox.Size = new System.Drawing.Size(200, 20);
            this.alarm_LowTextBox.TabIndex = 28;
            // 
            // alarm_highTextBox
            // 
            this.alarm_highTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNSTRUMENTBindingSource, "Alarm_high", true));
            this.alarm_highTextBox.Location = new System.Drawing.Point(133, 279);
            this.alarm_highTextBox.Name = "alarm_highTextBox";
            this.alarm_highTextBox.Size = new System.Drawing.Size(200, 20);
            this.alarm_highTextBox.TabIndex = 30;
            // 
            // category_IdTextBox
            // 
            this.category_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNSTRUMENTBindingSource, "Category_Id", true));
            this.category_IdTextBox.Location = new System.Drawing.Point(133, 305);
            this.category_IdTextBox.Name = "category_IdTextBox";
            this.category_IdTextBox.Size = new System.Drawing.Size(200, 20);
            this.category_IdTextBox.TabIndex = 32;
            // 
            // model_IdTextBox
            // 
            this.model_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNSTRUMENTBindingSource, "Model_Id", true));
            this.model_IdTextBox.Location = new System.Drawing.Point(133, 331);
            this.model_IdTextBox.Name = "model_IdTextBox";
            this.model_IdTextBox.Size = new System.Drawing.Size(200, 20);
            this.model_IdTextBox.TabIndex = 34;
            // 
            // manufactor_IdTextBox
            // 
            this.manufactor_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNSTRUMENTBindingSource, "Manufactor_Id", true));
            this.manufactor_IdTextBox.Location = new System.Drawing.Point(133, 357);
            this.manufactor_IdTextBox.Name = "manufactor_IdTextBox";
            this.manufactor_IdTextBox.Size = new System.Drawing.Size(200, 20);
            this.manufactor_IdTextBox.TabIndex = 36;
            // 
            // dAU_IdTextBox1
            // 
            this.dAU_IdTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNSTRUMENTBindingSource, "DAU_Id", true));
            this.dAU_IdTextBox1.Location = new System.Drawing.Point(133, 383);
            this.dAU_IdTextBox1.Name = "dAU_IdTextBox1";
            this.dAU_IdTextBox1.Size = new System.Drawing.Size(200, 20);
            this.dAU_IdTextBox1.TabIndex = 38;
            // 
            // communication_IdTextBox
            // 
            this.communication_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNSTRUMENTBindingSource, "Communication_Id", true));
            this.communication_IdTextBox.Location = new System.Drawing.Point(133, 409);
            this.communication_IdTextBox.Name = "communication_IdTextBox";
            this.communication_IdTextBox.Size = new System.Drawing.Size(200, 20);
            this.communication_IdTextBox.TabIndex = 40;
            // 
            // frequencyTextBox
            // 
            this.frequencyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNSTRUMENTBindingSource, "Frequency", true));
            this.frequencyTextBox.Location = new System.Drawing.Point(133, 435);
            this.frequencyTextBox.Name = "frequencyTextBox";
            this.frequencyTextBox.Size = new System.Drawing.Size(200, 20);
            this.frequencyTextBox.TabIndex = 42;
            // 
            // area_IdTextBox
            // 
            this.area_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNSTRUMENTBindingSource, "Area_Id", true));
            this.area_IdTextBox.Location = new System.Drawing.Point(133, 461);
            this.area_IdTextBox.Name = "area_IdTextBox";
            this.area_IdTextBox.Size = new System.Drawing.Size(200, 20);
            this.area_IdTextBox.TabIndex = 44;
            // 
            // innput_Output_IdTextBox
            // 
            this.innput_Output_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNSTRUMENTBindingSource, "Innput_Output_Id", true));
            this.innput_Output_IdTextBox.Location = new System.Drawing.Point(133, 487);
            this.innput_Output_IdTextBox.Name = "innput_Output_IdTextBox";
            this.innput_Output_IdTextBox.Size = new System.Drawing.Size(200, 20);
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
            this.textBoxAH.Location = new System.Drawing.Point(518, 248);
            this.textBoxAH.MaxLength = 4;
            this.textBoxAH.Name = "textBoxAH";
            this.textBoxAH.Size = new System.Drawing.Size(156, 20);
            this.textBoxAH.TabIndex = 5;
            this.textBoxAH.TextChanged += new System.EventHandler(this.textBoxAH_TextChanged);
            this.textBoxAH.Enter += new System.EventHandler(this.textBoxAH_Enter);
            // 
            // textBoxAL
            // 
            this.textBoxAL.Location = new System.Drawing.Point(518, 222);
            this.textBoxAL.MaxLength = 4;
            this.textBoxAL.Name = "textBoxAL";
            this.textBoxAL.Size = new System.Drawing.Size(156, 20);
            this.textBoxAL.TabIndex = 4;
            this.textBoxAL.TextChanged += new System.EventHandler(this.textBoxAL_TextChanged);
            this.textBoxAL.Enter += new System.EventHandler(this.textBoxAL_Enter);
            this.textBoxAL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAL_KeyPress);
            // 
            // textBoxURV
            // 
            this.textBoxURV.Location = new System.Drawing.Point(518, 196);
            this.textBoxURV.MaxLength = 6;
            this.textBoxURV.Name = "textBoxURV";
            this.textBoxURV.Size = new System.Drawing.Size(156, 20);
            this.textBoxURV.TabIndex = 3;
            this.textBoxURV.TextChanged += new System.EventHandler(this.textBoxURV_TextChanged);
            this.textBoxURV.Enter += new System.EventHandler(this.textBoxURV_Enter);
            // 
            // textBoxLRV
            // 
            this.textBoxLRV.Location = new System.Drawing.Point(518, 171);
            this.textBoxLRV.MaxLength = 6;
            this.textBoxLRV.Name = "textBoxLRV";
            this.textBoxLRV.Size = new System.Drawing.Size(156, 20);
            this.textBoxLRV.TabIndex = 2;
            this.textBoxLRV.TextChanged += new System.EventHandler(this.textBoxLRV_TextChanged);
            this.textBoxLRV.Enter += new System.EventHandler(this.textBoxLRV_Enter);
            this.textBoxLRV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLRV_KeyPress);
            // 
            // textBoxTag
            // 
            this.textBoxTag.Location = new System.Drawing.Point(518, 145);
            this.textBoxTag.MaxLength = 10;
            this.textBoxTag.Name = "textBoxTag";
            this.textBoxTag.Size = new System.Drawing.Size(156, 20);
            this.textBoxTag.TabIndex = 0;
            this.textBoxTag.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBoxTag.Enter += new System.EventHandler(this.textBoxTag_Enter);
            // 
            // configuration_Edit_DateDateTimePicker1
            // 
            this.configuration_Edit_DateDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.iNSTRUMENTBindingSource, "Configuration_Edit_Date", true));
            this.configuration_Edit_DateDateTimePicker1.Location = new System.Drawing.Point(133, 513);
            this.configuration_Edit_DateDateTimePicker1.Name = "configuration_Edit_DateDateTimePicker1";
            this.configuration_Edit_DateDateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.configuration_Edit_DateDateTimePicker1.TabIndex = 48;
            // 
            // buttonRetrieve
            // 
            this.buttonRetrieve.Location = new System.Drawing.Point(518, 274);
            this.buttonRetrieve.Name = "buttonRetrieve";
            this.buttonRetrieve.Size = new System.Drawing.Size(156, 23);
            this.buttonRetrieve.TabIndex = 18;
            this.buttonRetrieve.Text = "Retrieve data from instrument";
            this.buttonRetrieve.UseVisualStyleBackColor = true;
            this.buttonRetrieve.Click += new System.EventHandler(this.buttonRetrieve_Click);
            this.buttonRetrieve.MouseHover += new System.EventHandler(this.buttonRetrieve_MouseHover);
            // 
            // buttonSendValues
            // 
            this.buttonSendValues.Location = new System.Drawing.Point(518, 336);
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
            this.statusStrip1.Location = new System.Drawing.Point(3, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(725, 22);
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
            this.buttonUpdate.Location = new System.Drawing.Point(518, 305);
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
            this.labelAH.Location = new System.Drawing.Point(438, 252);
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
            this.labelAL.Location = new System.Drawing.Point(443, 224);
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
            this.labelURV.Location = new System.Drawing.Point(393, 200);
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
            this.labelLRV.Location = new System.Drawing.Point(393, 175);
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
            this.labelTag.Location = new System.Drawing.Point(448, 149);
            this.labelTag.Name = "labelTag";
            this.labelTag.Size = new System.Drawing.Size(63, 16);
            this.labelTag.TabIndex = 6;
            this.labelTag.Text = "Tagname:";
            this.labelTag.MouseHover += new System.EventHandler(this.labelTag_MouseHover);
            // 
            // tabPageConnection
            // 
            this.tabPageConnection.AutoScroll = true;
            this.tabPageConnection.BackColor = System.Drawing.Color.Gray;
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
            this.tabPageConnection.ForeColor = System.Drawing.SystemColors.Desktop;
            this.tabPageConnection.Location = new System.Drawing.Point(4, 22);
            this.tabPageConnection.Name = "tabPageConnection";
            this.tabPageConnection.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConnection.Size = new System.Drawing.Size(731, 564);
            this.tabPageConnection.TabIndex = 0;
            this.tabPageConnection.Text = "Connection";
            this.tabPageConnection.Enter += new System.EventHandler(this.tabPageConnection_Enter);
            // 
            // comboBoxCategory_DAU
            // 
            this.comboBoxCategory_DAU.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dAUBindingSource, "Category_Id", true));
            this.comboBoxCategory_DAU.DataSource = this.categoryBindingSource;
            this.comboBoxCategory_DAU.DisplayMember = "Category";
            this.comboBoxCategory_DAU.Enabled = false;
            this.comboBoxCategory_DAU.FormattingEnabled = true;
            this.comboBoxCategory_DAU.Location = new System.Drawing.Point(129, 422);
            this.comboBoxCategory_DAU.Name = "comboBoxCategory_DAU";
            this.comboBoxCategory_DAU.Size = new System.Drawing.Size(200, 21);
            this.comboBoxCategory_DAU.TabIndex = 62;
            this.comboBoxCategory_DAU.ValueMember = "Category_Id";
            // 
            // comboBoxManu_DAU
            // 
            this.comboBoxManu_DAU.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dAUBindingSource, "Manufactor_Id", true));
            this.comboBoxManu_DAU.DataSource = this.manufactorBindingSource;
            this.comboBoxManu_DAU.DisplayMember = "Manufactor";
            this.comboBoxManu_DAU.Enabled = false;
            this.comboBoxManu_DAU.FormattingEnabled = true;
            this.comboBoxManu_DAU.Location = new System.Drawing.Point(129, 396);
            this.comboBoxManu_DAU.Name = "comboBoxManu_DAU";
            this.comboBoxManu_DAU.Size = new System.Drawing.Size(200, 21);
            this.comboBoxManu_DAU.TabIndex = 61;
            this.comboBoxManu_DAU.ValueMember = "Manufactor_Id";
            // 
            // comboBoxCommunication_DAU
            // 
            this.comboBoxCommunication_DAU.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dAUBindingSource, "Communication_Id", true));
            this.comboBoxCommunication_DAU.DataSource = this.communicationBindingSource;
            this.comboBoxCommunication_DAU.DisplayMember = "Communication";
            this.comboBoxCommunication_DAU.Enabled = false;
            this.comboBoxCommunication_DAU.FormattingEnabled = true;
            this.comboBoxCommunication_DAU.Location = new System.Drawing.Point(129, 370);
            this.comboBoxCommunication_DAU.Name = "comboBoxCommunication_DAU";
            this.comboBoxCommunication_DAU.Size = new System.Drawing.Size(200, 21);
            this.comboBoxCommunication_DAU.TabIndex = 60;
            this.comboBoxCommunication_DAU.ValueMember = "Communication_Id";
            // 
            // comboBoxModel_DAU
            // 
            this.comboBoxModel_DAU.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dAUBindingSource, "Model_Id", true));
            this.comboBoxModel_DAU.DataSource = this.modelBindingSource;
            this.comboBoxModel_DAU.DisplayMember = "Model";
            this.comboBoxModel_DAU.Enabled = false;
            this.comboBoxModel_DAU.FormattingEnabled = true;
            this.comboBoxModel_DAU.Location = new System.Drawing.Point(129, 344);
            this.comboBoxModel_DAU.Name = "comboBoxModel_DAU";
            this.comboBoxModel_DAU.Size = new System.Drawing.Size(200, 21);
            this.comboBoxModel_DAU.TabIndex = 59;
            this.comboBoxModel_DAU.ValueMember = "Model_Id";
            // 
            // comboBoxAREA_DAU
            // 
            this.comboBoxAREA_DAU.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dAUBindingSource, "Area_Id", true));
            this.comboBoxAREA_DAU.DataSource = this.areaBindingSource;
            this.comboBoxAREA_DAU.DisplayMember = "Area";
            this.comboBoxAREA_DAU.Enabled = false;
            this.comboBoxAREA_DAU.FormattingEnabled = true;
            this.comboBoxAREA_DAU.Location = new System.Drawing.Point(129, 319);
            this.comboBoxAREA_DAU.Name = "comboBoxAREA_DAU";
            this.comboBoxAREA_DAU.Size = new System.Drawing.Size(200, 21);
            this.comboBoxAREA_DAU.TabIndex = 58;
            this.comboBoxAREA_DAU.ValueMember = "Area_Id";
            // 
            // comboBoxRDC_DAU
            // 
            this.comboBoxRDC_DAU.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dAUBindingSource, "RDC_Id", true));
            this.comboBoxRDC_DAU.DataSource = this.rDCBindingSource;
            this.comboBoxRDC_DAU.DisplayMember = "Description";
            this.comboBoxRDC_DAU.Enabled = false;
            this.comboBoxRDC_DAU.FormattingEnabled = true;
            this.comboBoxRDC_DAU.Location = new System.Drawing.Point(129, 292);
            this.comboBoxRDC_DAU.Name = "comboBoxRDC_DAU";
            this.comboBoxRDC_DAU.Size = new System.Drawing.Size(200, 21);
            this.comboBoxRDC_DAU.TabIndex = 57;
            this.comboBoxRDC_DAU.ValueMember = "RDC_Id";
            // 
            // dAU_IdTextBox
            // 
            this.dAU_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dAUBindingSource, "DAU_Id", true));
            this.dAU_IdTextBox.Enabled = false;
            this.dAU_IdTextBox.Location = new System.Drawing.Point(129, 241);
            this.dAU_IdTextBox.Name = "dAU_IdTextBox";
            this.dAU_IdTextBox.Size = new System.Drawing.Size(200, 20);
            this.dAU_IdTextBox.TabIndex = 36;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dAUBindingSource, "Description", true));
            this.descriptionTextBox.Enabled = false;
            this.descriptionTextBox.Location = new System.Drawing.Point(129, 267);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(200, 20);
            this.descriptionTextBox.TabIndex = 38;
            // 
            // cOMPortTextBox
            // 
            this.cOMPortTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dAUBindingSource, "COMPort", true));
            this.cOMPortTextBox.Enabled = false;
            this.cOMPortTextBox.Location = new System.Drawing.Point(129, 449);
            this.cOMPortTextBox.Name = "cOMPortTextBox";
            this.cOMPortTextBox.Size = new System.Drawing.Size(200, 20);
            this.cOMPortTextBox.TabIndex = 52;
            // 
            // bAUDRateTextBox
            // 
            this.bAUDRateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dAUBindingSource, "BAUDRate", true));
            this.bAUDRateTextBox.Enabled = false;
            this.bAUDRateTextBox.Location = new System.Drawing.Point(129, 475);
            this.bAUDRateTextBox.Name = "bAUDRateTextBox";
            this.bAUDRateTextBox.Size = new System.Drawing.Size(200, 20);
            this.bAUDRateTextBox.TabIndex = 54;
            // 
            // configuration_edit_dateDateTimePicker
            // 
            this.configuration_edit_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dAUBindingSource, "Configuration_edit_date", true));
            this.configuration_edit_dateDateTimePicker.Enabled = false;
            this.configuration_edit_dateDateTimePicker.Location = new System.Drawing.Point(129, 501);
            this.configuration_edit_dateDateTimePicker.Name = "configuration_edit_dateDateTimePicker";
            this.configuration_edit_dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.configuration_edit_dateDateTimePicker.TabIndex = 56;
            // 
            // comboBoxFindDevice
            // 
            this.comboBoxFindDevice.DataSource = this.dAU_OnlyIdDesBindingSource;
            this.comboBoxFindDevice.DisplayMember = "DAU_Id";
            this.comboBoxFindDevice.FormattingEnabled = true;
            this.comboBoxFindDevice.Location = new System.Drawing.Point(129, 136);
            this.comboBoxFindDevice.Name = "comboBoxFindDevice";
            this.comboBoxFindDevice.Size = new System.Drawing.Size(200, 21);
            this.comboBoxFindDevice.TabIndex = 35;
            this.comboBoxFindDevice.ValueMember = "DAU_Id";
            this.comboBoxFindDevice.SelectedIndexChanged += new System.EventHandler(this.comboBoxFindDevice_SelectedIndexChanged);
            // 
            // labelFindDevice
            // 
            this.labelFindDevice.AutoSize = true;
            this.labelFindDevice.Location = new System.Drawing.Point(58, 139);
            this.labelFindDevice.Name = "labelFindDevice";
            this.labelFindDevice.Size = new System.Drawing.Size(64, 13);
            this.labelFindDevice.TabIndex = 34;
            this.labelFindDevice.Text = "Find Device";
            // 
            // buttonCancelDAU
            // 
            this.buttonCancelDAU.Location = new System.Drawing.Point(239, 197);
            this.buttonCancelDAU.Name = "buttonCancelDAU";
            this.buttonCancelDAU.Size = new System.Drawing.Size(90, 23);
            this.buttonCancelDAU.TabIndex = 33;
            this.buttonCancelDAU.Text = "Cancel";
            this.buttonCancelDAU.UseVisualStyleBackColor = true;
            this.buttonCancelDAU.Click += new System.EventHandler(this.buttonCancelDAU_Click);
            // 
            // buttonNEW
            // 
            this.buttonNEW.Location = new System.Drawing.Point(129, 197);
            this.buttonNEW.Name = "buttonNEW";
            this.buttonNEW.Size = new System.Drawing.Size(89, 23);
            this.buttonNEW.TabIndex = 32;
            this.buttonNEW.Text = "New";
            this.buttonNEW.UseVisualStyleBackColor = true;
            this.buttonNEW.Click += new System.EventHandler(this.buttonNEW_Click);
            // 
            // buttonDAU_Save
            // 
            this.buttonDAU_Save.Location = new System.Drawing.Point(239, 168);
            this.buttonDAU_Save.Name = "buttonDAU_Save";
            this.buttonDAU_Save.Size = new System.Drawing.Size(90, 23);
            this.buttonDAU_Save.TabIndex = 31;
            this.buttonDAU_Save.Text = "Save";
            this.buttonDAU_Save.UseVisualStyleBackColor = true;
            this.buttonDAU_Save.Click += new System.EventHandler(this.buttonDAU_Save_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(129, 168);
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
            this.toolStripback.Location = new System.Drawing.Point(3, 536);
            this.toolStripback.Name = "toolStripback";
            this.toolStripback.Size = new System.Drawing.Size(725, 25);
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
            this.labelBitrate.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold);
            this.labelBitrate.Location = new System.Drawing.Point(470, 65);
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
            this.labelCom.Location = new System.Drawing.Point(461, 29);
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
            this.radioButtonConnected.Location = new System.Drawing.Point(647, 97);
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
            this.buttonDisconnect.Location = new System.Drawing.Point(529, 121);
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
            this.buttonConnect.Location = new System.Drawing.Point(529, 92);
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
            this.ComboBoxBaud.Location = new System.Drawing.Point(529, 65);
            this.ComboBoxBaud.Name = "ComboBoxBaud";
            this.ComboBoxBaud.Size = new System.Drawing.Size(148, 21);
            this.ComboBoxBaud.TabIndex = 1;
            this.ComboBoxBaud.Enter += new System.EventHandler(this.ComboBoxBaud_Enter);
            // 
            // ComboBoxPorts
            // 
            this.ComboBoxPorts.FormattingEnabled = true;
            this.ComboBoxPorts.Location = new System.Drawing.Point(529, 27);
            this.ComboBoxPorts.Name = "ComboBoxPorts";
            this.ComboBoxPorts.Size = new System.Drawing.Size(148, 21);
            this.ComboBoxPorts.TabIndex = 0;
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
            this.tabControl.Controls.Add(this.tabPageGraph);
            this.tabControl.Controls.Add(this.Instrument);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(739, 590);
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
            // aI_LOGBindingSource
            // 
            this.aI_LOGBindingSource.DataMember = "AI_LOG";
            this.aI_LOGBindingSource.DataSource = this.sOFTSENSECONF_DATABASE_FINALDataSet;
            // 
            // aI_LOGTableAdapter
            // 
            this.aI_LOGTableAdapter.ClearBeforeFill = true;
            // 
            // valueLabel
            // 
            valueLabel.AutoSize = true;
            valueLabel.Location = new System.Drawing.Point(40, 184);
            valueLabel.Name = "valueLabel";
            valueLabel.Size = new System.Drawing.Size(37, 13);
            valueLabel.TabIndex = 15;
            valueLabel.Text = "Value:";
            // 
            // valueTextBox
            // 
            this.valueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aI_LOGBindingSource, "Value", true));
            this.valueTextBox.Location = new System.Drawing.Point(138, 181);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(200, 20);
            this.valueTextBox.TabIndex = 16;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new System.Drawing.Point(40, 211);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new System.Drawing.Size(33, 13);
            timeLabel.TabIndex = 17;
            timeLabel.Text = "Time:";
            // 
            // instrument_Log_IdLabel
            // 
            instrument_Log_IdLabel.AutoSize = true;
            instrument_Log_IdLabel.Location = new System.Drawing.Point(40, 236);
            instrument_Log_IdLabel.Name = "instrument_Log_IdLabel";
            instrument_Log_IdLabel.Size = new System.Drawing.Size(92, 13);
            instrument_Log_IdLabel.TabIndex = 19;
            instrument_Log_IdLabel.Text = "Instrument Log Id:";
            // 
            // instrument_Log_IdTextBox
            // 
            this.instrument_Log_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aI_LOGBindingSource, "Instrument_Log_Id", true));
            this.instrument_Log_IdTextBox.Location = new System.Drawing.Point(138, 233);
            this.instrument_Log_IdTextBox.Name = "instrument_Log_IdTextBox";
            this.instrument_Log_IdTextBox.Size = new System.Drawing.Size(200, 20);
            this.instrument_Log_IdTextBox.TabIndex = 20;
            // 
            // instrument_Measure_IdBindingSource
            // 
            this.instrument_Measure_IdBindingSource.DataMember = "Instrument_Measure_Id";
            this.instrument_Measure_IdBindingSource.DataSource = this.sOFTSENSECONF_DATABASE_FINALDataSet;
            // 
            // instrument_Measure_IdTableAdapter
            // 
            this.instrument_Measure_IdTableAdapter.ClearBeforeFill = true;
            // 
            // tagNameLabel1
            // 
            tagNameLabel1.AutoSize = true;
            tagNameLabel1.Location = new System.Drawing.Point(40, 114);
            tagNameLabel1.Name = "tagNameLabel1";
            tagNameLabel1.Size = new System.Drawing.Size(60, 13);
            tagNameLabel1.TabIndex = 20;
            tagNameLabel1.Text = "Tag Name:";
            // 
            // tagNameTextBox1
            // 
            this.tagNameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instrument_Measure_IdBindingSource, "TagName", true));
            this.tagNameTextBox1.Location = new System.Drawing.Point(138, 111);
            this.tagNameTextBox1.Name = "tagNameTextBox1";
            this.tagNameTextBox1.Size = new System.Drawing.Size(100, 20);
            this.tagNameTextBox1.TabIndex = 21;
            // 
            // instrument_Log_IdLabel1
            // 
            instrument_Log_IdLabel1.AutoSize = true;
            instrument_Log_IdLabel1.Location = new System.Drawing.Point(40, 140);
            instrument_Log_IdLabel1.Name = "instrument_Log_IdLabel1";
            instrument_Log_IdLabel1.Size = new System.Drawing.Size(92, 13);
            instrument_Log_IdLabel1.TabIndex = 22;
            instrument_Log_IdLabel1.Text = "Instrument Log Id:";
            // 
            // instrument_Log_IdTextBox1
            // 
            this.instrument_Log_IdTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instrument_Measure_IdBindingSource, "Instrument_Log_Id", true));
            this.instrument_Log_IdTextBox1.Location = new System.Drawing.Point(138, 137);
            this.instrument_Log_IdTextBox1.Name = "instrument_Log_IdTextBox1";
            this.instrument_Log_IdTextBox1.Size = new System.Drawing.Size(100, 20);
            this.instrument_Log_IdTextBox1.TabIndex = 23;
            // 
            // buttonReadAnalog
            // 
            this.buttonReadAnalog.Location = new System.Drawing.Point(138, 82);
            this.buttonReadAnalog.Name = "buttonReadAnalog";
            this.buttonReadAnalog.Size = new System.Drawing.Size(100, 23);
            this.buttonReadAnalog.TabIndex = 24;
            this.buttonReadAnalog.Text = "Read Analog";
            this.buttonReadAnalog.UseVisualStyleBackColor = true;
            this.buttonReadAnalog.Click += new System.EventHandler(this.buttonReadAnalog_Click);
            // 
            // timeDateTimePicker
            // 
            this.timeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.aI_LOGBindingSource, "Time", true));
            this.timeDateTimePicker.Location = new System.Drawing.Point(138, 207);
            this.timeDateTimePicker.Name = "timeDateTimePicker";
            this.timeDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.timeDateTimePicker.TabIndex = 18;
            // 
            // SoftSensConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(739, 590);
            this.Controls.Add(this.tabControl);
            this.Name = "SoftSensConfig";
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
            this.Instrument.ResumeLayout(false);
            this.Instrument.PerformLayout();
            this.tabPageGraph.ResumeLayout(false);
            this.tabPageGraph.PerformLayout();
            this.statusStrip3.ResumeLayout(false);
            this.statusStrip3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPoints)).EndInit();
            this.tabPageCommand.ResumeLayout(false);
            this.tabPageCommand.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.tabPageConfiguration.ResumeLayout(false);
            this.tabPageConfiguration.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabPageConnection.ResumeLayout(false);
            this.tabPageConnection.PerformLayout();
            this.toolStripback.ResumeLayout(false);
            this.toolStripback.PerformLayout();
            this.tabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iNSTRUMENTtoComboBoxBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aI_LOGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrument_Measure_IdBindingSource)).EndInit();
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
        private System.Windows.Forms.TabPage Instrument;
        private System.Windows.Forms.TabPage tabPageGraph;
        private System.Windows.Forms.TextBox textBoxConnectionP3;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.StatusStrip statusStrip3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonSavetofile;
        private System.Windows.Forms.Button buttonClearV;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonScaled;
        private System.Windows.Forms.ListBox listBoxReading;
        private System.Windows.Forms.Button buttonRaw;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPoints;
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
        private System.Windows.Forms.ListBox listBoxValueAI;
        private System.Windows.Forms.Button Newtest;
        private System.Windows.Forms.Button buttonSavetest;
        private System.Windows.Forms.BindingSource aI_LOGBindingSource;
        private SOFTSENSECONF_DATABASE_FINALDataSetTableAdapters.AI_LOGTableAdapter aI_LOGTableAdapter;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.TextBox instrument_Log_IdTextBox;
        private System.Windows.Forms.BindingSource instrument_Measure_IdBindingSource;
        private SOFTSENSECONF_DATABASE_FINALDataSetTableAdapters.Instrument_Measure_IdTableAdapter instrument_Measure_IdTableAdapter;
        private System.Windows.Forms.TextBox tagNameTextBox1;
        private System.Windows.Forms.TextBox instrument_Log_IdTextBox1;
        private System.Windows.Forms.Button buttonReadAnalog;
        private System.Windows.Forms.DateTimePicker timeDateTimePicker;
    }
}

