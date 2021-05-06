
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
            this.buttonDigitalout = new System.Windows.Forms.Button();
            this.buttonDigitalInn = new System.Windows.Forms.Button();
            this.buttonAnalogout = new System.Windows.Forms.Button();
            this.buttonAnalogInn = new System.Windows.Forms.Button();
            this.buttonSending = new System.Windows.Forms.Button();
            this.buttonView = new System.Windows.Forms.Button();
            this.tagNameTextBox1 = new System.Windows.Forms.TextBox();
            this.instrument_Log_IdTextBox1 = new System.Windows.Forms.TextBox();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.timeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.instrument_Log_IdTextBox = new System.Windows.Forms.TextBox();
            this.buttonstopgraph = new System.Windows.Forms.Button();
            this.listBoxDBreadings = new System.Windows.Forms.ListBox();
            this.buttonGraphstart = new System.Windows.Forms.Button();
            this.chartPoints = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxConnectionP2 = new System.Windows.Forms.TextBox();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonReceive = new System.Windows.Forms.Button();
            this.buttonSendValuesToInstrument = new System.Windows.Forms.Button();
            this.pictureBoxDisconnected3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.textBoxReceive = new System.Windows.Forms.TextBox();
            this.timeDateTimePickerAILOG = new System.Windows.Forms.DateTimePicker();
            this.instrument_Log_IdTextBox2 = new System.Windows.Forms.TextBox();
            this.tagNameTextBox2 = new System.Windows.Forms.TextBox();
            this.buttonSendValuestodb = new System.Windows.Forms.Button();
            this.buttonSTopsendingdata = new System.Windows.Forms.Button();
            this.tabPageConfiguration = new System.Windows.Forms.TabPage();
            this.buttonChangeInstrument = new System.Windows.Forms.Button();
            this.buttonCancelInstrument = new System.Windows.Forms.Button();
            this.buttonNEWInstrument = new System.Windows.Forms.Button();
            this.buttonUpdateInstrument = new System.Windows.Forms.Button();
            this.comboBoxInnputOutputInstrument = new System.Windows.Forms.ComboBox();
            this.innput_OutputBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxAreaInstrument = new System.Windows.Forms.ComboBox();
            this.areaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxCOMMInstrument = new System.Windows.Forms.ComboBox();
            this.communicationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxDAUinstrument = new System.Windows.Forms.ComboBox();
            this.dAUBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxManuInstrument = new System.Windows.Forms.ComboBox();
            this.manufactorBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxModelinstrument = new System.Windows.Forms.ComboBox();
            this.modelBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxCategoryInstrument = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.labelfinding = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxFindInstrument = new System.Windows.Forms.ComboBox();
            this.labelMatching = new System.Windows.Forms.Label();
            this.textBoxMatch = new System.Windows.Forms.TextBox();
            this.tagNameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBoxInstrument = new System.Windows.Forms.TextBox();
            this.lower_range_valueTextBox = new System.Windows.Forms.TextBox();
            this.upper_range_valueTextBox = new System.Windows.Forms.TextBox();
            this.alarm_LowTextBox = new System.Windows.Forms.TextBox();
            this.alarm_highTextBox = new System.Windows.Forms.TextBox();
            this.frequencyTextBox = new System.Windows.Forms.TextBox();
            this.textBoxConnectionP1 = new System.Windows.Forms.TextBox();
            this.textBoxAH = new System.Windows.Forms.TextBox();
            this.textBoxAL = new System.Windows.Forms.TextBox();
            this.textBoxURV = new System.Windows.Forms.TextBox();
            this.textBoxLRV = new System.Windows.Forms.TextBox();
            this.textBoxTag = new System.Windows.Forms.TextBox();
            this.configuration_Edit_DateDateTimePickerInstrument = new System.Windows.Forms.DateTimePicker();
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
            this.pictureBoxDisconnected2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tabPageConnection = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSaveRDC = new System.Windows.Forms.Button();
            this.rDC_IdTextBox = new System.Windows.Forms.TextBox();
            this.buttonCancelRDC = new System.Windows.Forms.Button();
            this.buttonNEWRDC = new System.Windows.Forms.Button();
            this.mCU_IdTextBox = new System.Windows.Forms.TextBox();
            this.buttonChangeRDC = new System.Windows.Forms.Button();
            this.dAU_IdTextBox = new System.Windows.Forms.TextBox();
            this.comboBoxAReaRDC = new System.Windows.Forms.ComboBox();
            this.areaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.labelFIND = new System.Windows.Forms.Label();
            this.comboBoxMOdelRDC = new System.Windows.Forms.ComboBox();
            this.modelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxManuRDC = new System.Windows.Forms.ComboBox();
            this.manufactorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxFindingDeviceRDC = new System.Windows.Forms.ComboBox();
            this.descriptionTextBoxRDC = new System.Windows.Forms.TextBox();
            this.configuration_Edit_DateDateTimePickerRDC = new System.Windows.Forms.DateTimePicker();
            this.buttonConnectFromDB = new System.Windows.Forms.Button();
            this.comboBoxCategory_DAU = new System.Windows.Forms.ComboBox();
            this.comboBoxManu_DAU = new System.Windows.Forms.ComboBox();
            this.comboBoxCommunication_DAU = new System.Windows.Forms.ComboBox();
            this.comboBoxModel_DAU = new System.Windows.Forms.ComboBox();
            this.comboBoxAREA_DAU = new System.Windows.Forms.ComboBox();
            this.comboBoxRDC_DAU = new System.Windows.Forms.ComboBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.cOMPortTextBox = new System.Windows.Forms.TextBox();
            this.bAUDRateTextBox = new System.Windows.Forms.TextBox();
            this.configuration_edit_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBoxFindDevice = new System.Windows.Forms.ComboBox();
            this.buttonNEW = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.toolStripback = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonDisconnectInstrument = new System.Windows.Forms.Button();
            this.labelFindDevice = new System.Windows.Forms.Label();
            this.buttonDAU_Save = new System.Windows.Forms.Button();
            this.buttonCancelDAU = new System.Windows.Forms.Button();
            this.pictureBoxDisconnected = new System.Windows.Forms.PictureBox();
            this.pictureBoxCONNECTED = new System.Windows.Forms.PictureBox();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.radioButtonConnected = new System.Windows.Forms.RadioButton();
            this.ComboBoxBaud = new System.Windows.Forms.ComboBox();
            this.ComboBoxPorts = new System.Windows.Forms.ComboBox();
            this.labelBitrate = new System.Windows.Forms.Label();
            this.labelCom = new System.Windows.Forms.Label();
            this.rDCOnlyIdDesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl = new System.Windows.Forms.TabControl();
            this.iNSTRUMENTtoComboBoxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iNSTRUMENTtoComboBoxTableAdapter = new SoftSensConf.SOFTSENSECONF_DATABASE_FINALDataSetTableAdapters.INSTRUMENTtoComboBoxTableAdapter();
            this.aI_LOGTableAdapter = new SoftSensConf.SOFTSENSECONF_DATABASE_FINALDataSetTableAdapters.AI_LOGTableAdapter();
            this.instrument_Measure_IdTableAdapter = new SoftSensConf.SOFTSENSECONF_DATABASE_FINALDataSetTableAdapters.Instrument_Measure_IdTableAdapter();
            this.buttonExit = new System.Windows.Forms.Button();
            this.rDCOnlyIdDesTableAdapter = new SoftSensConf.SOFTSENSECONF_DATABASE_FINALDataSetTableAdapters.RDCOnlyIdDesTableAdapter();
            this.innput_OutputTableAdapter = new SoftSensConf.SOFTSENSECONF_DATABASE_FINALDataSetTableAdapters.Innput_OutputTableAdapter();
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
            ((System.ComponentModel.ISupportInitialize)(this.chartPoints)).BeginInit();
            this.statusStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisconnected3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.tabPageConfiguration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.innput_OutputBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.communicationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAUBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufactorBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisconnected2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.tabPageConnection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufactorBindingSource1)).BeginInit();
            this.toolStripback.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisconnected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCONNECTED)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDCOnlyIdDesBindingSource)).BeginInit();
            this.tabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iNSTRUMENTtoComboBoxBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // configuration_Edit_DateLabel1
            // 
            configuration_Edit_DateLabel1.AutoSize = true;
            configuration_Edit_DateLabel1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            configuration_Edit_DateLabel1.Location = new System.Drawing.Point(111, 478);
            configuration_Edit_DateLabel1.Name = "configuration_Edit_DateLabel1";
            configuration_Edit_DateLabel1.Size = new System.Drawing.Size(106, 17);
            configuration_Edit_DateLabel1.TabIndex = 47;
            configuration_Edit_DateLabel1.Text = "Config Edit Date:";
            // 
            // innput_Output_IdLabel
            // 
            innput_Output_IdLabel.AutoSize = true;
            innput_Output_IdLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            innput_Output_IdLabel.Location = new System.Drawing.Point(120, 444);
            innput_Output_IdLabel.Name = "innput_Output_IdLabel";
            innput_Output_IdLabel.Size = new System.Drawing.Size(92, 17);
            innput_Output_IdLabel.TabIndex = 45;
            innput_Output_IdLabel.Text = "Innput/Output:";
            // 
            // area_IdLabel1
            // 
            area_IdLabel1.AutoSize = true;
            area_IdLabel1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            area_IdLabel1.Location = new System.Drawing.Point(174, 413);
            area_IdLabel1.Name = "area_IdLabel1";
            area_IdLabel1.Size = new System.Drawing.Size(38, 17);
            area_IdLabel1.TabIndex = 43;
            area_IdLabel1.Text = "Area:";
            // 
            // frequencyLabel
            // 
            frequencyLabel.AutoSize = true;
            frequencyLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            frequencyLabel.Location = new System.Drawing.Point(142, 382);
            frequencyLabel.Name = "frequencyLabel";
            frequencyLabel.Size = new System.Drawing.Size(70, 17);
            frequencyLabel.TabIndex = 41;
            frequencyLabel.Text = "Frequency:";
            // 
            // communication_IdLabel1
            // 
            communication_IdLabel1.AutoSize = true;
            communication_IdLabel1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            communication_IdLabel1.Location = new System.Drawing.Point(111, 351);
            communication_IdLabel1.Name = "communication_IdLabel1";
            communication_IdLabel1.Size = new System.Drawing.Size(101, 17);
            communication_IdLabel1.TabIndex = 39;
            communication_IdLabel1.Text = "Communication:";
            // 
            // dAU_IdLabel1
            // 
            dAU_IdLabel1.AutoSize = true;
            dAU_IdLabel1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dAU_IdLabel1.Location = new System.Drawing.Point(89, 320);
            dAU_IdLabel1.Name = "dAU_IdLabel1";
            dAU_IdLabel1.Size = new System.Drawing.Size(123, 17);
            dAU_IdLabel1.TabIndex = 37;
            dAU_IdLabel1.Text = "Data Aqusition Unit:";
            // 
            // manufactor_IdLabel1
            // 
            manufactor_IdLabel1.AutoSize = true;
            manufactor_IdLabel1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            manufactor_IdLabel1.Location = new System.Drawing.Point(133, 289);
            manufactor_IdLabel1.Name = "manufactor_IdLabel1";
            manufactor_IdLabel1.Size = new System.Drawing.Size(79, 17);
            manufactor_IdLabel1.TabIndex = 35;
            manufactor_IdLabel1.Text = "Manufactor:";
            // 
            // model_IdLabel1
            // 
            model_IdLabel1.AutoSize = true;
            model_IdLabel1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            model_IdLabel1.Location = new System.Drawing.Point(163, 258);
            model_IdLabel1.Name = "model_IdLabel1";
            model_IdLabel1.Size = new System.Drawing.Size(49, 17);
            model_IdLabel1.TabIndex = 33;
            model_IdLabel1.Text = "Model:";
            // 
            // category_IdLabel1
            // 
            category_IdLabel1.AutoSize = true;
            category_IdLabel1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            category_IdLabel1.Location = new System.Drawing.Point(147, 227);
            category_IdLabel1.Name = "category_IdLabel1";
            category_IdLabel1.Size = new System.Drawing.Size(65, 17);
            category_IdLabel1.TabIndex = 31;
            category_IdLabel1.Text = "Category:";
            // 
            // alarm_highLabel
            // 
            alarm_highLabel.AutoSize = true;
            alarm_highLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            alarm_highLabel.Location = new System.Drawing.Point(529, 284);
            alarm_highLabel.Name = "alarm_highLabel";
            alarm_highLabel.Size = new System.Drawing.Size(74, 17);
            alarm_highLabel.TabIndex = 29;
            alarm_highLabel.Text = "Alarm high:";
            // 
            // alarm_LowLabel
            // 
            alarm_LowLabel.AutoSize = true;
            alarm_LowLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            alarm_LowLabel.Location = new System.Drawing.Point(531, 315);
            alarm_LowLabel.Name = "alarm_LowLabel";
            alarm_LowLabel.Size = new System.Drawing.Size(72, 17);
            alarm_LowLabel.TabIndex = 27;
            alarm_LowLabel.Text = "Alarm Low:";
            // 
            // upper_range_valueLabel
            // 
            upper_range_valueLabel.AutoSize = true;
            upper_range_valueLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            upper_range_valueLabel.Location = new System.Drawing.Point(483, 222);
            upper_range_valueLabel.Name = "upper_range_valueLabel";
            upper_range_valueLabel.Size = new System.Drawing.Size(120, 17);
            upper_range_valueLabel.TabIndex = 25;
            upper_range_valueLabel.Text = "Upper range value:";
            // 
            // lower_range_valueLabel
            // 
            lower_range_valueLabel.AutoSize = true;
            lower_range_valueLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lower_range_valueLabel.Location = new System.Drawing.Point(485, 253);
            lower_range_valueLabel.Name = "lower_range_valueLabel";
            lower_range_valueLabel.Size = new System.Drawing.Size(118, 17);
            lower_range_valueLabel.TabIndex = 23;
            lower_range_valueLabel.Text = "Lower range value:";
            // 
            // descriptionLabel1
            // 
            descriptionLabel1.AutoSize = true;
            descriptionLabel1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descriptionLabel1.Location = new System.Drawing.Point(135, 196);
            descriptionLabel1.Name = "descriptionLabel1";
            descriptionLabel1.Size = new System.Drawing.Size(77, 17);
            descriptionLabel1.TabIndex = 21;
            descriptionLabel1.Text = "Description:";
            // 
            // tagNameLabel
            // 
            tagNameLabel.AutoSize = true;
            tagNameLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tagNameLabel.Location = new System.Drawing.Point(532, 191);
            tagNameLabel.Name = "tagNameLabel";
            tagNameLabel.Size = new System.Drawing.Size(71, 17);
            tagNameLabel.TabIndex = 19;
            tagNameLabel.Text = "Tag Name:";
            // 
            // configuration_edit_dateLabel
            // 
            configuration_edit_dateLabel.AutoSize = true;
            configuration_edit_dateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            configuration_edit_dateLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            configuration_edit_dateLabel.Location = new System.Drawing.Point(534, 531);
            configuration_edit_dateLabel.Name = "configuration_edit_dateLabel";
            configuration_edit_dateLabel.Size = new System.Drawing.Size(146, 17);
            configuration_edit_dateLabel.TabIndex = 55;
            configuration_edit_dateLabel.Text = "Configuration edit date:";
            // 
            // bAUDRateLabel
            // 
            bAUDRateLabel.AutoSize = true;
            bAUDRateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            bAUDRateLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bAUDRateLabel.Location = new System.Drawing.Point(610, 497);
            bAUDRateLabel.Name = "bAUDRateLabel";
            bAUDRateLabel.Size = new System.Drawing.Size(70, 17);
            bAUDRateLabel.TabIndex = 53;
            bAUDRateLabel.Text = "BAUDRate:";
            // 
            // cOMPortLabel
            // 
            cOMPortLabel.AutoSize = true;
            cOMPortLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            cOMPortLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cOMPortLabel.Location = new System.Drawing.Point(615, 466);
            cOMPortLabel.Name = "cOMPortLabel";
            cOMPortLabel.Size = new System.Drawing.Size(65, 17);
            cOMPortLabel.TabIndex = 51;
            cOMPortLabel.Text = "COMPort:";
            // 
            // category_IdLabel
            // 
            category_IdLabel.AutoSize = true;
            category_IdLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            category_IdLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            category_IdLabel.Location = new System.Drawing.Point(615, 437);
            category_IdLabel.Name = "category_IdLabel";
            category_IdLabel.Size = new System.Drawing.Size(65, 17);
            category_IdLabel.TabIndex = 49;
            category_IdLabel.Text = "Category:";
            // 
            // manufactor_IdLabel
            // 
            manufactor_IdLabel.AutoSize = true;
            manufactor_IdLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            manufactor_IdLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            manufactor_IdLabel.Location = new System.Drawing.Point(601, 408);
            manufactor_IdLabel.Name = "manufactor_IdLabel";
            manufactor_IdLabel.Size = new System.Drawing.Size(79, 17);
            manufactor_IdLabel.TabIndex = 47;
            manufactor_IdLabel.Text = "Manufactor:";
            // 
            // communication_IdLabel
            // 
            communication_IdLabel.AutoSize = true;
            communication_IdLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            communication_IdLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            communication_IdLabel.Location = new System.Drawing.Point(579, 377);
            communication_IdLabel.Name = "communication_IdLabel";
            communication_IdLabel.Size = new System.Drawing.Size(101, 17);
            communication_IdLabel.TabIndex = 45;
            communication_IdLabel.Text = "Communication:";
            // 
            // model_IdLabel
            // 
            model_IdLabel.AutoSize = true;
            model_IdLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            model_IdLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            model_IdLabel.Location = new System.Drawing.Point(631, 346);
            model_IdLabel.Name = "model_IdLabel";
            model_IdLabel.Size = new System.Drawing.Size(49, 17);
            model_IdLabel.TabIndex = 43;
            model_IdLabel.Text = "Model:";
            // 
            // area_IdLabel
            // 
            area_IdLabel.AutoSize = true;
            area_IdLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            area_IdLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            area_IdLabel.Location = new System.Drawing.Point(642, 315);
            area_IdLabel.Name = "area_IdLabel";
            area_IdLabel.Size = new System.Drawing.Size(38, 17);
            area_IdLabel.TabIndex = 41;
            area_IdLabel.Text = "Area:";
            // 
            // rDC_IdLabel
            // 
            rDC_IdLabel.AutoSize = true;
            rDC_IdLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            rDC_IdLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rDC_IdLabel.Location = new System.Drawing.Point(540, 284);
            rDC_IdLabel.Name = "rDC_IdLabel";
            rDC_IdLabel.Size = new System.Drawing.Size(140, 17);
            rDC_IdLabel.TabIndex = 39;
            rDC_IdLabel.Text = "Remote Data Collector";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            descriptionLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descriptionLabel.Location = new System.Drawing.Point(603, 253);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(77, 17);
            descriptionLabel.TabIndex = 37;
            descriptionLabel.Text = "Description:";
            // 
            // dAU_IdLabel
            // 
            dAU_IdLabel.AutoSize = true;
            dAU_IdLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(60)))));
            dAU_IdLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dAU_IdLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(60)))));
            dAU_IdLabel.Location = new System.Drawing.Point(7, 509);
            dAU_IdLabel.Name = "dAU_IdLabel";
            dAU_IdLabel.Size = new System.Drawing.Size(126, 17);
            dAU_IdLabel.TabIndex = 35;
            dAU_IdLabel.Text = "Data Aquisition Unit:";
            // 
            // rDC_IdLabel1
            // 
            rDC_IdLabel1.AutoSize = true;
            rDC_IdLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(60)))));
            rDC_IdLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(60)))));
            rDC_IdLabel1.Location = new System.Drawing.Point(11, 500);
            rDC_IdLabel1.Name = "rDC_IdLabel1";
            rDC_IdLabel1.Size = new System.Drawing.Size(61, 21);
            rDC_IdLabel1.TabIndex = 80;
            rDC_IdLabel1.Text = "RDC Id:";
            // 
            // descriptionLabel2
            // 
            descriptionLabel2.AutoSize = true;
            descriptionLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            descriptionLabel2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descriptionLabel2.Location = new System.Drawing.Point(118, 173);
            descriptionLabel2.Name = "descriptionLabel2";
            descriptionLabel2.Size = new System.Drawing.Size(77, 17);
            descriptionLabel2.TabIndex = 82;
            descriptionLabel2.Text = "Description:";
            // 
            // mCU_IdLabel
            // 
            mCU_IdLabel.AutoSize = true;
            mCU_IdLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(60)))));
            mCU_IdLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(60)))));
            mCU_IdLabel.Location = new System.Drawing.Point(7, 504);
            mCU_IdLabel.Name = "mCU_IdLabel";
            mCU_IdLabel.Size = new System.Drawing.Size(65, 21);
            mCU_IdLabel.TabIndex = 84;
            mCU_IdLabel.Text = "MCU Id:";
            // 
            // area_IdLabel2
            // 
            area_IdLabel2.AutoSize = true;
            area_IdLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            area_IdLabel2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            area_IdLabel2.Location = new System.Drawing.Point(157, 204);
            area_IdLabel2.Name = "area_IdLabel2";
            area_IdLabel2.Size = new System.Drawing.Size(38, 17);
            area_IdLabel2.TabIndex = 86;
            area_IdLabel2.Text = "Area:";
            // 
            // manufactor_IdLabel2
            // 
            manufactor_IdLabel2.AutoSize = true;
            manufactor_IdLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            manufactor_IdLabel2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            manufactor_IdLabel2.Location = new System.Drawing.Point(116, 235);
            manufactor_IdLabel2.Name = "manufactor_IdLabel2";
            manufactor_IdLabel2.Size = new System.Drawing.Size(79, 17);
            manufactor_IdLabel2.TabIndex = 88;
            manufactor_IdLabel2.Text = "Manufactor:";
            // 
            // model_IdLabel2
            // 
            model_IdLabel2.AutoSize = true;
            model_IdLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            model_IdLabel2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            model_IdLabel2.Location = new System.Drawing.Point(146, 266);
            model_IdLabel2.Name = "model_IdLabel2";
            model_IdLabel2.Size = new System.Drawing.Size(49, 17);
            model_IdLabel2.TabIndex = 90;
            model_IdLabel2.Text = "Model:";
            // 
            // configuration_Edit_DateLabel2
            // 
            configuration_Edit_DateLabel2.AutoSize = true;
            configuration_Edit_DateLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            configuration_Edit_DateLabel2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            configuration_Edit_DateLabel2.Location = new System.Drawing.Point(48, 297);
            configuration_Edit_DateLabel2.Name = "configuration_Edit_DateLabel2";
            configuration_Edit_DateLabel2.Size = new System.Drawing.Size(147, 17);
            configuration_Edit_DateLabel2.TabIndex = 92;
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
            this.tabPageCommand.AutoScroll = true;
            this.tabPageCommand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.tabPageCommand.Controls.Add(this.buttonDigitalout);
            this.tabPageCommand.Controls.Add(this.buttonDigitalInn);
            this.tabPageCommand.Controls.Add(this.buttonAnalogout);
            this.tabPageCommand.Controls.Add(this.buttonAnalogInn);
            this.tabPageCommand.Controls.Add(this.buttonSending);
            this.tabPageCommand.Controls.Add(this.buttonView);
            this.tabPageCommand.Controls.Add(this.tagNameTextBox1);
            this.tabPageCommand.Controls.Add(this.instrument_Log_IdTextBox1);
            this.tabPageCommand.Controls.Add(this.valueTextBox);
            this.tabPageCommand.Controls.Add(this.timeDateTimePicker);
            this.tabPageCommand.Controls.Add(this.instrument_Log_IdTextBox);
            this.tabPageCommand.Controls.Add(this.buttonstopgraph);
            this.tabPageCommand.Controls.Add(this.listBoxDBreadings);
            this.tabPageCommand.Controls.Add(this.buttonGraphstart);
            this.tabPageCommand.Controls.Add(this.chartPoints);
            this.tabPageCommand.Controls.Add(this.textBoxConnectionP2);
            this.tabPageCommand.Controls.Add(this.textBoxSend);
            this.tabPageCommand.Controls.Add(this.statusStrip2);
            this.tabPageCommand.Controls.Add(this.buttonReceive);
            this.tabPageCommand.Controls.Add(this.buttonSendValuesToInstrument);
            this.tabPageCommand.Controls.Add(this.pictureBoxDisconnected3);
            this.tabPageCommand.Controls.Add(this.pictureBox5);
            this.tabPageCommand.Controls.Add(this.textBoxReceive);
            this.tabPageCommand.Controls.Add(this.timeDateTimePickerAILOG);
            this.tabPageCommand.Controls.Add(this.instrument_Log_IdTextBox2);
            this.tabPageCommand.Controls.Add(this.tagNameTextBox2);
            this.tabPageCommand.Controls.Add(this.buttonSendValuestodb);
            this.tabPageCommand.Controls.Add(this.buttonSTopsendingdata);
            this.tabPageCommand.Location = new System.Drawing.Point(4, 34);
            this.tabPageCommand.Name = "tabPageCommand";
            this.tabPageCommand.Size = new System.Drawing.Size(991, 750);
            this.tabPageCommand.TabIndex = 2;
            this.tabPageCommand.Text = "Online";
            this.tabPageCommand.Enter += new System.EventHandler(this.tabPageCommand_Enter);
            // 
            // buttonDigitalout
            // 
            this.buttonDigitalout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDigitalout.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDigitalout.Location = new System.Drawing.Point(453, 67);
            this.buttonDigitalout.Name = "buttonDigitalout";
            this.buttonDigitalout.Size = new System.Drawing.Size(82, 26);
            this.buttonDigitalout.TabIndex = 105;
            this.buttonDigitalout.Text = "Digital Out";
            this.buttonDigitalout.UseVisualStyleBackColor = true;
            this.buttonDigitalout.Visible = false;
            // 
            // buttonDigitalInn
            // 
            this.buttonDigitalInn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDigitalInn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDigitalInn.Location = new System.Drawing.Point(365, 67);
            this.buttonDigitalInn.Name = "buttonDigitalInn";
            this.buttonDigitalInn.Size = new System.Drawing.Size(82, 26);
            this.buttonDigitalInn.TabIndex = 104;
            this.buttonDigitalInn.Text = "Digital Inn";
            this.buttonDigitalInn.UseVisualStyleBackColor = true;
            this.buttonDigitalInn.Visible = false;
            // 
            // buttonAnalogout
            // 
            this.buttonAnalogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnalogout.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnalogout.Location = new System.Drawing.Point(272, 67);
            this.buttonAnalogout.Name = "buttonAnalogout";
            this.buttonAnalogout.Size = new System.Drawing.Size(87, 26);
            this.buttonAnalogout.TabIndex = 103;
            this.buttonAnalogout.Text = "Analog Out";
            this.buttonAnalogout.UseVisualStyleBackColor = true;
            this.buttonAnalogout.Visible = false;
            // 
            // buttonAnalogInn
            // 
            this.buttonAnalogInn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnalogInn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnalogInn.Location = new System.Drawing.Point(184, 67);
            this.buttonAnalogInn.Name = "buttonAnalogInn";
            this.buttonAnalogInn.Size = new System.Drawing.Size(82, 26);
            this.buttonAnalogInn.TabIndex = 99;
            this.buttonAnalogInn.Text = "Analog Inn";
            this.buttonAnalogInn.UseVisualStyleBackColor = true;
            this.buttonAnalogInn.Visible = false;
            this.buttonAnalogInn.Click += new System.EventHandler(this.buttonAnalog_Click);
            // 
            // buttonSending
            // 
            this.buttonSending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSending.Location = new System.Drawing.Point(630, 26);
            this.buttonSending.Name = "buttonSending";
            this.buttonSending.Size = new System.Drawing.Size(230, 33);
            this.buttonSending.TabIndex = 82;
            this.buttonSending.Text = "Send Command to Instrument";
            this.buttonSending.UseVisualStyleBackColor = true;
            this.buttonSending.Click += new System.EventHandler(this.buttonSending_Click);
            // 
            // buttonView
            // 
            this.buttonView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonView.Location = new System.Drawing.Point(421, 26);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(203, 33);
            this.buttonView.TabIndex = 81;
            this.buttonView.Text = "View Data from Database";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
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
            this.buttonstopgraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonstopgraph.Location = new System.Drawing.Point(78, 590);
            this.buttonstopgraph.Margin = new System.Windows.Forms.Padding(0);
            this.buttonstopgraph.Name = "buttonstopgraph";
            this.buttonstopgraph.Size = new System.Drawing.Size(150, 32);
            this.buttonstopgraph.TabIndex = 14;
            this.buttonstopgraph.Text = "Stop";
            this.buttonstopgraph.UseVisualStyleBackColor = true;
            this.buttonstopgraph.Visible = false;
            this.buttonstopgraph.Click += new System.EventHandler(this.buttonstopgraph_Click);
            // 
            // listBoxDBreadings
            // 
            this.listBoxDBreadings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.listBoxDBreadings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxDBreadings.DataSource = this.aI_LOGBindingSource;
            this.listBoxDBreadings.DisplayMember = "Value";
            this.listBoxDBreadings.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxDBreadings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.listBoxDBreadings.FormattingEnabled = true;
            this.listBoxDBreadings.ItemHeight = 17;
            this.listBoxDBreadings.Location = new System.Drawing.Point(78, 140);
            this.listBoxDBreadings.Name = "listBoxDBreadings";
            this.listBoxDBreadings.Size = new System.Drawing.Size(364, 102);
            this.listBoxDBreadings.TabIndex = 13;
            this.listBoxDBreadings.ValueMember = "Value";
            this.listBoxDBreadings.Visible = false;
            // 
            // buttonGraphstart
            // 
            this.buttonGraphstart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGraphstart.Location = new System.Drawing.Point(3, 26);
            this.buttonGraphstart.Name = "buttonGraphstart";
            this.buttonGraphstart.Size = new System.Drawing.Size(203, 33);
            this.buttonGraphstart.TabIndex = 8;
            this.buttonGraphstart.Text = "View Data in Graph";
            this.buttonGraphstart.UseVisualStyleBackColor = true;
            this.buttonGraphstart.Click += new System.EventHandler(this.buttonGraphstart_Click);
            // 
            // chartPoints
            // 
            this.chartPoints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.chartPoints.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.chartPoints.BorderSkin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            chartArea1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            chartArea1.Name = "ChartArea1";
            this.chartPoints.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            legend1.Name = "Legend1";
            legend1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.chartPoints.Legends.Add(legend1);
            this.chartPoints.Location = new System.Drawing.Point(0, 292);
            this.chartPoints.Name = "chartPoints";
            this.chartPoints.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Va";
            this.chartPoints.Series.Add(series1);
            this.chartPoints.Size = new System.Drawing.Size(982, 306);
            this.chartPoints.TabIndex = 7;
            this.chartPoints.Text = "chart1";
            this.chartPoints.Visible = false;
            // 
            // textBoxConnectionP2
            // 
            this.textBoxConnectionP2.BackColor = System.Drawing.Color.Gray;
            this.textBoxConnectionP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.textBoxConnectionP2.Location = new System.Drawing.Point(720, 3);
            this.textBoxConnectionP2.Name = "textBoxConnectionP2";
            this.textBoxConnectionP2.Size = new System.Drawing.Size(109, 24);
            this.textBoxConnectionP2.TabIndex = 6;
            this.textBoxConnectionP2.Visible = false;
            // 
            // textBoxSend
            // 
            this.textBoxSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.textBoxSend.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSend.Location = new System.Drawing.Point(495, 107);
            this.textBoxSend.Multiline = true;
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.Size = new System.Drawing.Size(358, 23);
            this.textBoxSend.TabIndex = 1;
            this.textBoxSend.Visible = false;
            this.textBoxSend.Enter += new System.EventHandler(this.textBoxSend_Enter);
            // 
            // statusStrip2
            // 
            this.statusStrip2.BackColor = System.Drawing.Color.Lavender;
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2});
            this.statusStrip2.Location = new System.Drawing.Point(0, 711);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(1188, 22);
            this.statusStrip2.TabIndex = 5;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel2.Text = "Ready";
            // 
            // buttonReceive
            // 
            this.buttonReceive.BackgroundImage = global::SoftSensConf.Properties.Resources.iconfinder_16_Input_2123951;
            this.buttonReceive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonReceive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReceive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.buttonReceive.Location = new System.Drawing.Point(548, 248);
            this.buttonReceive.Name = "buttonReceive";
            this.buttonReceive.Size = new System.Drawing.Size(64, 38);
            this.buttonReceive.TabIndex = 3;
            this.buttonReceive.UseVisualStyleBackColor = true;
            this.buttonReceive.Visible = false;
            this.buttonReceive.Click += new System.EventHandler(this.buttonReceive_Click);
            // 
            // buttonSendValuesToInstrument
            // 
            this.buttonSendValuesToInstrument.BackgroundImage = global::SoftSensConf.Properties.Resources.iconfinder_11_Upload_2123924;
            this.buttonSendValuesToInstrument.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSendValuesToInstrument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSendValuesToInstrument.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.buttonSendValuesToInstrument.Location = new System.Drawing.Point(495, 248);
            this.buttonSendValuesToInstrument.Name = "buttonSendValuesToInstrument";
            this.buttonSendValuesToInstrument.Size = new System.Drawing.Size(47, 38);
            this.buttonSendValuesToInstrument.TabIndex = 2;
            this.buttonSendValuesToInstrument.UseVisualStyleBackColor = true;
            this.buttonSendValuesToInstrument.Visible = false;
            this.buttonSendValuesToInstrument.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // pictureBoxDisconnected3
            // 
            this.pictureBoxDisconnected3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.pictureBoxDisconnected3.Image = global::SoftSensConf.Properties.Resources.iconfinder_wifi_off_2561213;
            this.pictureBoxDisconnected3.Location = new System.Drawing.Point(841, 16);
            this.pictureBoxDisconnected3.Name = "pictureBoxDisconnected3";
            this.pictureBoxDisconnected3.Size = new System.Drawing.Size(131, 77);
            this.pictureBoxDisconnected3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDisconnected3.TabIndex = 96;
            this.pictureBoxDisconnected3.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.pictureBox5.Image = global::SoftSensConf.Properties.Resources.iconfinder_wifi_Symbol_925808;
            this.pictureBox5.Location = new System.Drawing.Point(841, 16);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(131, 77);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 95;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Visible = false;
            // 
            // textBoxReceive
            // 
            this.textBoxReceive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.textBoxReceive.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxReceive.Location = new System.Drawing.Point(495, 140);
            this.textBoxReceive.Multiline = true;
            this.textBoxReceive.Name = "textBoxReceive";
            this.textBoxReceive.ReadOnly = true;
            this.textBoxReceive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxReceive.Size = new System.Drawing.Size(360, 102);
            this.textBoxReceive.TabIndex = 0;
            this.textBoxReceive.Visible = false;
            // 
            // timeDateTimePickerAILOG
            // 
            this.timeDateTimePickerAILOG.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.aI_LOGBindingSource, "Time", true));
            this.timeDateTimePickerAILOG.Location = new System.Drawing.Point(802, 30);
            this.timeDateTimePickerAILOG.Name = "timeDateTimePickerAILOG";
            this.timeDateTimePickerAILOG.Size = new System.Drawing.Size(10, 29);
            this.timeDateTimePickerAILOG.TabIndex = 109;
            // 
            // instrument_Log_IdTextBox2
            // 
            this.instrument_Log_IdTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.instrument_Log_IdTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.instrument_Log_IdTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instrument_Measure_IdBindingSource, "Instrument_Log_Id", true));
            this.instrument_Log_IdTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.instrument_Log_IdTextBox2.Location = new System.Drawing.Point(735, 32);
            this.instrument_Log_IdTextBox2.Name = "instrument_Log_IdTextBox2";
            this.instrument_Log_IdTextBox2.Size = new System.Drawing.Size(100, 22);
            this.instrument_Log_IdTextBox2.TabIndex = 108;
            // 
            // tagNameTextBox2
            // 
            this.tagNameTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.tagNameTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tagNameTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instrument_Measure_IdBindingSource, "TagName", true));
            this.tagNameTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.tagNameTextBox2.Location = new System.Drawing.Point(653, 33);
            this.tagNameTextBox2.Name = "tagNameTextBox2";
            this.tagNameTextBox2.Size = new System.Drawing.Size(100, 22);
            this.tagNameTextBox2.TabIndex = 106;
            // 
            // buttonSendValuestodb
            // 
            this.buttonSendValuestodb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSendValuestodb.Location = new System.Drawing.Point(212, 26);
            this.buttonSendValuestodb.Name = "buttonSendValuestodb";
            this.buttonSendValuestodb.Size = new System.Drawing.Size(203, 33);
            this.buttonSendValuestodb.TabIndex = 83;
            this.buttonSendValuestodb.Text = "Send data to database";
            this.buttonSendValuestodb.UseVisualStyleBackColor = true;
            this.buttonSendValuestodb.Click += new System.EventHandler(this.buttonSendValuestodb_Click);
            // 
            // buttonSTopsendingdata
            // 
            this.buttonSTopsendingdata.Enabled = false;
            this.buttonSTopsendingdata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSTopsendingdata.Location = new System.Drawing.Point(212, 26);
            this.buttonSTopsendingdata.Name = "buttonSTopsendingdata";
            this.buttonSTopsendingdata.Size = new System.Drawing.Size(203, 33);
            this.buttonSTopsendingdata.TabIndex = 84;
            this.buttonSTopsendingdata.Text = "Stop Dataflow to Database";
            this.buttonSTopsendingdata.UseVisualStyleBackColor = true;
            this.buttonSTopsendingdata.Visible = false;
            this.buttonSTopsendingdata.Click += new System.EventHandler(this.buttonSTopsendingdata_Click);
            // 
            // tabPageConfiguration
            // 
            this.tabPageConfiguration.AutoScroll = true;
            this.tabPageConfiguration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.tabPageConfiguration.Controls.Add(this.buttonChangeInstrument);
            this.tabPageConfiguration.Controls.Add(this.buttonCancelInstrument);
            this.tabPageConfiguration.Controls.Add(this.buttonNEWInstrument);
            this.tabPageConfiguration.Controls.Add(this.buttonUpdateInstrument);
            this.tabPageConfiguration.Controls.Add(this.comboBoxInnputOutputInstrument);
            this.tabPageConfiguration.Controls.Add(this.comboBoxAreaInstrument);
            this.tabPageConfiguration.Controls.Add(this.comboBoxCOMMInstrument);
            this.tabPageConfiguration.Controls.Add(this.comboBoxDAUinstrument);
            this.tabPageConfiguration.Controls.Add(this.comboBoxManuInstrument);
            this.tabPageConfiguration.Controls.Add(this.comboBoxModelinstrument);
            this.tabPageConfiguration.Controls.Add(this.comboBoxCategoryInstrument);
            this.tabPageConfiguration.Controls.Add(this.labelfinding);
            this.tabPageConfiguration.Controls.Add(this.pictureBox1);
            this.tabPageConfiguration.Controls.Add(this.comboBoxFindInstrument);
            this.tabPageConfiguration.Controls.Add(this.labelMatching);
            this.tabPageConfiguration.Controls.Add(this.textBoxMatch);
            this.tabPageConfiguration.Controls.Add(tagNameLabel);
            this.tabPageConfiguration.Controls.Add(this.tagNameTextBox);
            this.tabPageConfiguration.Controls.Add(this.descriptionTextBoxInstrument);
            this.tabPageConfiguration.Controls.Add(this.lower_range_valueTextBox);
            this.tabPageConfiguration.Controls.Add(this.upper_range_valueTextBox);
            this.tabPageConfiguration.Controls.Add(this.alarm_LowTextBox);
            this.tabPageConfiguration.Controls.Add(this.alarm_highTextBox);
            this.tabPageConfiguration.Controls.Add(this.frequencyTextBox);
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
            this.tabPageConfiguration.Controls.Add(this.configuration_Edit_DateDateTimePickerInstrument);
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
            this.tabPageConfiguration.Controls.Add(this.pictureBoxDisconnected2);
            this.tabPageConfiguration.Controls.Add(this.pictureBox4);
            this.tabPageConfiguration.Location = new System.Drawing.Point(4, 34);
            this.tabPageConfiguration.Name = "tabPageConfiguration";
            this.tabPageConfiguration.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConfiguration.Size = new System.Drawing.Size(991, 750);
            this.tabPageConfiguration.TabIndex = 1;
            this.tabPageConfiguration.Text = "Configuration";
            this.tabPageConfiguration.Enter += new System.EventHandler(this.tabPageConfiguration_Enter);
            // 
            // buttonChangeInstrument
            // 
            this.buttonChangeInstrument.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangeInstrument.Location = new System.Drawing.Point(336, 103);
            this.buttonChangeInstrument.Name = "buttonChangeInstrument";
            this.buttonChangeInstrument.Size = new System.Drawing.Size(90, 24);
            this.buttonChangeInstrument.TabIndex = 92;
            this.buttonChangeInstrument.Text = "Change";
            this.buttonChangeInstrument.UseVisualStyleBackColor = true;
            this.buttonChangeInstrument.Click += new System.EventHandler(this.buttonChangeInstrument_Click);
            // 
            // buttonCancelInstrument
            // 
            this.buttonCancelInstrument.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelInstrument.Location = new System.Drawing.Point(336, 133);
            this.buttonCancelInstrument.Name = "buttonCancelInstrument";
            this.buttonCancelInstrument.Size = new System.Drawing.Size(90, 24);
            this.buttonCancelInstrument.TabIndex = 91;
            this.buttonCancelInstrument.Text = "Cancel";
            this.buttonCancelInstrument.UseVisualStyleBackColor = true;
            this.buttonCancelInstrument.Click += new System.EventHandler(this.buttonCancelInstrument_Click);
            // 
            // buttonNEWInstrument
            // 
            this.buttonNEWInstrument.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNEWInstrument.Location = new System.Drawing.Point(223, 104);
            this.buttonNEWInstrument.Name = "buttonNEWInstrument";
            this.buttonNEWInstrument.Size = new System.Drawing.Size(90, 24);
            this.buttonNEWInstrument.TabIndex = 90;
            this.buttonNEWInstrument.Text = "New";
            this.buttonNEWInstrument.UseVisualStyleBackColor = true;
            this.buttonNEWInstrument.Click += new System.EventHandler(this.buttonNEWInstrument_Click);
            // 
            // buttonUpdateInstrument
            // 
            this.buttonUpdateInstrument.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateInstrument.Location = new System.Drawing.Point(223, 133);
            this.buttonUpdateInstrument.Name = "buttonUpdateInstrument";
            this.buttonUpdateInstrument.Size = new System.Drawing.Size(90, 24);
            this.buttonUpdateInstrument.TabIndex = 89;
            this.buttonUpdateInstrument.Text = "Update";
            this.buttonUpdateInstrument.UseVisualStyleBackColor = true;
            this.buttonUpdateInstrument.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // comboBoxInnputOutputInstrument
            // 
            this.comboBoxInnputOutputInstrument.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBoxInnputOutputInstrument.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.iNSTRUMENTBindingSource, "Innput_Output_Id", true));
            this.comboBoxInnputOutputInstrument.DataSource = this.innput_OutputBindingSource;
            this.comboBoxInnputOutputInstrument.DisplayMember = "Innput_Output_Digital_Analog";
            this.comboBoxInnputOutputInstrument.Enabled = false;
            this.comboBoxInnputOutputInstrument.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxInnputOutputInstrument.FormattingEnabled = true;
            this.comboBoxInnputOutputInstrument.Location = new System.Drawing.Point(227, 441);
            this.comboBoxInnputOutputInstrument.Name = "comboBoxInnputOutputInstrument";
            this.comboBoxInnputOutputInstrument.Size = new System.Drawing.Size(199, 25);
            this.comboBoxInnputOutputInstrument.TabIndex = 88;
            this.comboBoxInnputOutputInstrument.ValueMember = "Innput_Output_Id";
            // 
            // innput_OutputBindingSource
            // 
            this.innput_OutputBindingSource.DataMember = "Innput_Output";
            this.innput_OutputBindingSource.DataSource = this.sOFTSENSECONF_DATABASE_FINALDataSet;
            // 
            // comboBoxAreaInstrument
            // 
            this.comboBoxAreaInstrument.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBoxAreaInstrument.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.iNSTRUMENTBindingSource, "Area_Id", true));
            this.comboBoxAreaInstrument.DataSource = this.areaBindingSource2;
            this.comboBoxAreaInstrument.DisplayMember = "Area";
            this.comboBoxAreaInstrument.Enabled = false;
            this.comboBoxAreaInstrument.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAreaInstrument.FormattingEnabled = true;
            this.comboBoxAreaInstrument.Location = new System.Drawing.Point(227, 410);
            this.comboBoxAreaInstrument.Name = "comboBoxAreaInstrument";
            this.comboBoxAreaInstrument.Size = new System.Drawing.Size(199, 25);
            this.comboBoxAreaInstrument.TabIndex = 87;
            this.comboBoxAreaInstrument.ValueMember = "Area_Id";
            // 
            // areaBindingSource2
            // 
            this.areaBindingSource2.DataMember = "Area";
            this.areaBindingSource2.DataSource = this.sOFTSENSECONF_DATABASE_FINALDataSet;
            // 
            // comboBoxCOMMInstrument
            // 
            this.comboBoxCOMMInstrument.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBoxCOMMInstrument.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.iNSTRUMENTBindingSource, "Communication_Id", true));
            this.comboBoxCOMMInstrument.DataSource = this.communicationBindingSource1;
            this.comboBoxCOMMInstrument.DisplayMember = "Communication";
            this.comboBoxCOMMInstrument.Enabled = false;
            this.comboBoxCOMMInstrument.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCOMMInstrument.FormattingEnabled = true;
            this.comboBoxCOMMInstrument.Location = new System.Drawing.Point(226, 348);
            this.comboBoxCOMMInstrument.Name = "comboBoxCOMMInstrument";
            this.comboBoxCOMMInstrument.Size = new System.Drawing.Size(200, 25);
            this.comboBoxCOMMInstrument.TabIndex = 86;
            this.comboBoxCOMMInstrument.ValueMember = "Communication_Id";
            // 
            // communicationBindingSource1
            // 
            this.communicationBindingSource1.DataMember = "Communication";
            this.communicationBindingSource1.DataSource = this.sOFTSENSECONF_DATABASE_FINALDataSet;
            // 
            // comboBoxDAUinstrument
            // 
            this.comboBoxDAUinstrument.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBoxDAUinstrument.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.iNSTRUMENTBindingSource, "DAU_Id", true));
            this.comboBoxDAUinstrument.DataSource = this.dAUBindingSource1;
            this.comboBoxDAUinstrument.DisplayMember = "Description";
            this.comboBoxDAUinstrument.Enabled = false;
            this.comboBoxDAUinstrument.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDAUinstrument.FormattingEnabled = true;
            this.comboBoxDAUinstrument.Location = new System.Drawing.Point(227, 317);
            this.comboBoxDAUinstrument.Name = "comboBoxDAUinstrument";
            this.comboBoxDAUinstrument.Size = new System.Drawing.Size(199, 25);
            this.comboBoxDAUinstrument.TabIndex = 85;
            this.comboBoxDAUinstrument.ValueMember = "DAU_Id";
            // 
            // dAUBindingSource1
            // 
            this.dAUBindingSource1.DataMember = "DAU";
            this.dAUBindingSource1.DataSource = this.sOFTSENSECONF_DATABASE_FINALDataSet;
            // 
            // comboBoxManuInstrument
            // 
            this.comboBoxManuInstrument.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBoxManuInstrument.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.iNSTRUMENTBindingSource, "Manufactor_Id", true));
            this.comboBoxManuInstrument.DataSource = this.manufactorBindingSource2;
            this.comboBoxManuInstrument.DisplayMember = "Manufactor";
            this.comboBoxManuInstrument.Enabled = false;
            this.comboBoxManuInstrument.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxManuInstrument.FormattingEnabled = true;
            this.comboBoxManuInstrument.Location = new System.Drawing.Point(227, 286);
            this.comboBoxManuInstrument.Name = "comboBoxManuInstrument";
            this.comboBoxManuInstrument.Size = new System.Drawing.Size(199, 25);
            this.comboBoxManuInstrument.TabIndex = 84;
            this.comboBoxManuInstrument.ValueMember = "Manufactor_Id";
            // 
            // manufactorBindingSource2
            // 
            this.manufactorBindingSource2.DataMember = "Manufactor";
            this.manufactorBindingSource2.DataSource = this.sOFTSENSECONF_DATABASE_FINALDataSet;
            // 
            // comboBoxModelinstrument
            // 
            this.comboBoxModelinstrument.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBoxModelinstrument.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.iNSTRUMENTBindingSource, "Model_Id", true));
            this.comboBoxModelinstrument.DataSource = this.modelBindingSource2;
            this.comboBoxModelinstrument.DisplayMember = "Model";
            this.comboBoxModelinstrument.Enabled = false;
            this.comboBoxModelinstrument.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxModelinstrument.FormattingEnabled = true;
            this.comboBoxModelinstrument.Location = new System.Drawing.Point(227, 255);
            this.comboBoxModelinstrument.Name = "comboBoxModelinstrument";
            this.comboBoxModelinstrument.Size = new System.Drawing.Size(199, 25);
            this.comboBoxModelinstrument.TabIndex = 83;
            this.comboBoxModelinstrument.ValueMember = "Model_Id";
            // 
            // modelBindingSource2
            // 
            this.modelBindingSource2.DataMember = "Model";
            this.modelBindingSource2.DataSource = this.sOFTSENSECONF_DATABASE_FINALDataSet;
            // 
            // comboBoxCategoryInstrument
            // 
            this.comboBoxCategoryInstrument.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBoxCategoryInstrument.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.iNSTRUMENTBindingSource, "Category_Id", true));
            this.comboBoxCategoryInstrument.DataSource = this.categoryBindingSource1;
            this.comboBoxCategoryInstrument.DisplayMember = "Category";
            this.comboBoxCategoryInstrument.Enabled = false;
            this.comboBoxCategoryInstrument.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCategoryInstrument.FormattingEnabled = true;
            this.comboBoxCategoryInstrument.Location = new System.Drawing.Point(226, 224);
            this.comboBoxCategoryInstrument.Name = "comboBoxCategoryInstrument";
            this.comboBoxCategoryInstrument.Size = new System.Drawing.Size(200, 25);
            this.comboBoxCategoryInstrument.TabIndex = 82;
            this.comboBoxCategoryInstrument.ValueMember = "Category_Id";
            // 
            // categoryBindingSource1
            // 
            this.categoryBindingSource1.DataMember = "Category";
            this.categoryBindingSource1.DataSource = this.sOFTSENSECONF_DATABASE_FINALDataSet;
            // 
            // labelfinding
            // 
            this.labelfinding.AutoSize = true;
            this.labelfinding.Location = new System.Drawing.Point(89, 64);
            this.labelfinding.Name = "labelfinding";
            this.labelfinding.Size = new System.Drawing.Size(123, 21);
            this.labelfinding.TabIndex = 81;
            this.labelfinding.Text = "Find Instrument:";
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
            this.comboBoxFindInstrument.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBoxFindInstrument.FormattingEnabled = true;
            this.comboBoxFindInstrument.Location = new System.Drawing.Point(226, 64);
            this.comboBoxFindInstrument.Name = "comboBoxFindInstrument";
            this.comboBoxFindInstrument.Size = new System.Drawing.Size(200, 29);
            this.comboBoxFindInstrument.TabIndex = 54;
            this.comboBoxFindInstrument.SelectedIndexChanged += new System.EventHandler(this.comboBoxFindInstrument_SelectedIndexChanged);
            // 
            // labelMatching
            // 
            this.labelMatching.AutoSize = true;
            this.labelMatching.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatching.Location = new System.Drawing.Point(682, 598);
            this.labelMatching.Name = "labelMatching";
            this.labelMatching.Size = new System.Drawing.Size(129, 17);
            this.labelMatching.TabIndex = 53;
            this.labelMatching.Text = "db and config match";
            this.labelMatching.Visible = false;
            // 
            // textBoxMatch
            // 
            this.textBoxMatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxMatch.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMatch.Location = new System.Drawing.Point(828, 595);
            this.textBoxMatch.Name = "textBoxMatch";
            this.textBoxMatch.Size = new System.Drawing.Size(154, 25);
            this.textBoxMatch.TabIndex = 52;
            this.textBoxMatch.Visible = false;
            // 
            // tagNameTextBox
            // 
            this.tagNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tagNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNSTRUMENTBindingSource, "TagName", true));
            this.tagNameTextBox.Enabled = false;
            this.tagNameTextBox.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagNameTextBox.Location = new System.Drawing.Point(618, 188);
            this.tagNameTextBox.Name = "tagNameTextBox";
            this.tagNameTextBox.Size = new System.Drawing.Size(200, 25);
            this.tagNameTextBox.TabIndex = 20;
            // 
            // descriptionTextBoxInstrument
            // 
            this.descriptionTextBoxInstrument.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.descriptionTextBoxInstrument.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNSTRUMENTBindingSource, "Description", true));
            this.descriptionTextBoxInstrument.Enabled = false;
            this.descriptionTextBoxInstrument.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBoxInstrument.Location = new System.Drawing.Point(226, 193);
            this.descriptionTextBoxInstrument.Name = "descriptionTextBoxInstrument";
            this.descriptionTextBoxInstrument.Size = new System.Drawing.Size(200, 25);
            this.descriptionTextBoxInstrument.TabIndex = 22;
            // 
            // lower_range_valueTextBox
            // 
            this.lower_range_valueTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lower_range_valueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNSTRUMENTBindingSource, "Lower_range_value", true));
            this.lower_range_valueTextBox.Enabled = false;
            this.lower_range_valueTextBox.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lower_range_valueTextBox.Location = new System.Drawing.Point(618, 250);
            this.lower_range_valueTextBox.Name = "lower_range_valueTextBox";
            this.lower_range_valueTextBox.Size = new System.Drawing.Size(200, 25);
            this.lower_range_valueTextBox.TabIndex = 24;
            // 
            // upper_range_valueTextBox
            // 
            this.upper_range_valueTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.upper_range_valueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNSTRUMENTBindingSource, "Upper_range_value", true));
            this.upper_range_valueTextBox.Enabled = false;
            this.upper_range_valueTextBox.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upper_range_valueTextBox.Location = new System.Drawing.Point(618, 219);
            this.upper_range_valueTextBox.Name = "upper_range_valueTextBox";
            this.upper_range_valueTextBox.Size = new System.Drawing.Size(200, 25);
            this.upper_range_valueTextBox.TabIndex = 26;
            // 
            // alarm_LowTextBox
            // 
            this.alarm_LowTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.alarm_LowTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNSTRUMENTBindingSource, "Alarm_Low", true));
            this.alarm_LowTextBox.Enabled = false;
            this.alarm_LowTextBox.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarm_LowTextBox.Location = new System.Drawing.Point(618, 312);
            this.alarm_LowTextBox.Name = "alarm_LowTextBox";
            this.alarm_LowTextBox.Size = new System.Drawing.Size(200, 25);
            this.alarm_LowTextBox.TabIndex = 28;
            // 
            // alarm_highTextBox
            // 
            this.alarm_highTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.alarm_highTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNSTRUMENTBindingSource, "Alarm_high", true));
            this.alarm_highTextBox.Enabled = false;
            this.alarm_highTextBox.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarm_highTextBox.Location = new System.Drawing.Point(618, 281);
            this.alarm_highTextBox.Name = "alarm_highTextBox";
            this.alarm_highTextBox.Size = new System.Drawing.Size(200, 25);
            this.alarm_highTextBox.TabIndex = 30;
            // 
            // frequencyTextBox
            // 
            this.frequencyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.frequencyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNSTRUMENTBindingSource, "Frequency", true));
            this.frequencyTextBox.Enabled = false;
            this.frequencyTextBox.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frequencyTextBox.Location = new System.Drawing.Point(226, 379);
            this.frequencyTextBox.Name = "frequencyTextBox";
            this.frequencyTextBox.Size = new System.Drawing.Size(200, 25);
            this.frequencyTextBox.TabIndex = 42;
            this.frequencyTextBox.TextChanged += new System.EventHandler(this.frequencyTextBox_TextChanged);
            // 
            // textBoxConnectionP1
            // 
            this.textBoxConnectionP1.BackColor = System.Drawing.Color.Gray;
            this.textBoxConnectionP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConnectionP1.ForeColor = System.Drawing.Color.Lime;
            this.textBoxConnectionP1.Location = new System.Drawing.Point(723, 499);
            this.textBoxConnectionP1.Name = "textBoxConnectionP1";
            this.textBoxConnectionP1.Size = new System.Drawing.Size(109, 24);
            this.textBoxConnectionP1.TabIndex = 19;
            this.textBoxConnectionP1.Visible = false;
            // 
            // textBoxAH
            // 
            this.textBoxAH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxAH.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAH.Location = new System.Drawing.Point(828, 533);
            this.textBoxAH.MaxLength = 4;
            this.textBoxAH.Name = "textBoxAH";
            this.textBoxAH.Size = new System.Drawing.Size(154, 25);
            this.textBoxAH.TabIndex = 5;
            this.textBoxAH.Visible = false;
            this.textBoxAH.TextChanged += new System.EventHandler(this.textBoxAH_TextChanged);
            this.textBoxAH.Enter += new System.EventHandler(this.textBoxAH_Enter);
            // 
            // textBoxAL
            // 
            this.textBoxAL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxAL.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAL.Location = new System.Drawing.Point(828, 564);
            this.textBoxAL.MaxLength = 4;
            this.textBoxAL.Name = "textBoxAL";
            this.textBoxAL.Size = new System.Drawing.Size(154, 25);
            this.textBoxAL.TabIndex = 4;
            this.textBoxAL.Visible = false;
            this.textBoxAL.TextChanged += new System.EventHandler(this.textBoxAL_TextChanged);
            this.textBoxAL.Enter += new System.EventHandler(this.textBoxAL_Enter);
            this.textBoxAL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAL_KeyPress);
            // 
            // textBoxURV
            // 
            this.textBoxURV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxURV.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxURV.Location = new System.Drawing.Point(828, 471);
            this.textBoxURV.MaxLength = 6;
            this.textBoxURV.Name = "textBoxURV";
            this.textBoxURV.Size = new System.Drawing.Size(154, 25);
            this.textBoxURV.TabIndex = 3;
            this.textBoxURV.Visible = false;
            this.textBoxURV.TextChanged += new System.EventHandler(this.textBoxURV_TextChanged);
            this.textBoxURV.Enter += new System.EventHandler(this.textBoxURV_Enter);
            // 
            // textBoxLRV
            // 
            this.textBoxLRV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxLRV.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLRV.Location = new System.Drawing.Point(828, 502);
            this.textBoxLRV.MaxLength = 6;
            this.textBoxLRV.Name = "textBoxLRV";
            this.textBoxLRV.Size = new System.Drawing.Size(154, 25);
            this.textBoxLRV.TabIndex = 2;
            this.textBoxLRV.Visible = false;
            this.textBoxLRV.TextChanged += new System.EventHandler(this.textBoxLRV_TextChanged);
            this.textBoxLRV.Enter += new System.EventHandler(this.textBoxLRV_Enter);
            this.textBoxLRV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLRV_KeyPress);
            // 
            // textBoxTag
            // 
            this.textBoxTag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxTag.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTag.Location = new System.Drawing.Point(828, 440);
            this.textBoxTag.MaxLength = 10;
            this.textBoxTag.Name = "textBoxTag";
            this.textBoxTag.Size = new System.Drawing.Size(154, 25);
            this.textBoxTag.TabIndex = 0;
            this.textBoxTag.Visible = false;
            this.textBoxTag.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBoxTag.Enter += new System.EventHandler(this.textBoxTag_Enter);
            // 
            // configuration_Edit_DateDateTimePickerInstrument
            // 
            this.configuration_Edit_DateDateTimePickerInstrument.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.iNSTRUMENTBindingSource, "Configuration_Edit_Date", true));
            this.configuration_Edit_DateDateTimePickerInstrument.Enabled = false;
            this.configuration_Edit_DateDateTimePickerInstrument.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configuration_Edit_DateDateTimePickerInstrument.Location = new System.Drawing.Point(227, 472);
            this.configuration_Edit_DateDateTimePickerInstrument.Name = "configuration_Edit_DateDateTimePickerInstrument";
            this.configuration_Edit_DateDateTimePickerInstrument.Size = new System.Drawing.Size(199, 25);
            this.configuration_Edit_DateDateTimePickerInstrument.TabIndex = 48;
            // 
            // buttonRetrieve
            // 
            this.buttonRetrieve.Enabled = false;
            this.buttonRetrieve.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRetrieve.Location = new System.Drawing.Point(618, 346);
            this.buttonRetrieve.Name = "buttonRetrieve";
            this.buttonRetrieve.Size = new System.Drawing.Size(200, 27);
            this.buttonRetrieve.TabIndex = 18;
            this.buttonRetrieve.Text = "Retrieve data from instrument";
            this.buttonRetrieve.UseVisualStyleBackColor = true;
            this.buttonRetrieve.Click += new System.EventHandler(this.buttonRetrieve_Click);
            this.buttonRetrieve.MouseHover += new System.EventHandler(this.buttonRetrieve_MouseHover);
            // 
            // buttonSendValues
            // 
            this.buttonSendValues.Enabled = false;
            this.buttonSendValues.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSendValues.Location = new System.Drawing.Point(618, 408);
            this.buttonSendValues.Name = "buttonSendValues";
            this.buttonSendValues.Size = new System.Drawing.Size(200, 27);
            this.buttonSendValues.TabIndex = 17;
            this.buttonSendValues.Text = "Send selected setup to device";
            this.buttonSendValues.UseVisualStyleBackColor = true;
            this.buttonSendValues.Click += new System.EventHandler(this.buttonSendValues_Click);
            this.buttonSendValues.MouseHover += new System.EventHandler(this.buttonSendValues_MouseHover);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(630, 559);
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
            this.statusStrip1.Location = new System.Drawing.Point(3, 708);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1179, 22);
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
            this.buttonSave.Location = new System.Drawing.Point(711, 562);
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
            this.buttonUpdate.Enabled = false;
            this.buttonUpdate.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(618, 377);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(200, 27);
            this.buttonUpdate.TabIndex = 13;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.button1_Click);
            this.buttonUpdate.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(680, 547);
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
            this.labelAH.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAH.Location = new System.Drawing.Point(785, 527);
            this.labelAH.Name = "labelAH";
            this.labelAH.Size = new System.Drawing.Size(74, 17);
            this.labelAH.TabIndex = 10;
            this.labelAH.Text = "Alarm high:";
            this.labelAH.Visible = false;
            this.labelAH.MouseHover += new System.EventHandler(this.labelAH_MouseHover);
            // 
            // labelAL
            // 
            this.labelAL.AutoSize = true;
            this.labelAL.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAL.Location = new System.Drawing.Point(792, 570);
            this.labelAL.Name = "labelAL";
            this.labelAL.Size = new System.Drawing.Size(69, 17);
            this.labelAL.TabIndex = 9;
            this.labelAL.Text = "Alarm low:";
            this.labelAL.Visible = false;
            this.labelAL.MouseHover += new System.EventHandler(this.labelAL_MouseHover);
            // 
            // labelURV
            // 
            this.labelURV.AutoSize = true;
            this.labelURV.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelURV.Location = new System.Drawing.Point(741, 469);
            this.labelURV.Name = "labelURV";
            this.labelURV.Size = new System.Drawing.Size(120, 17);
            this.labelURV.TabIndex = 8;
            this.labelURV.Text = "Upper range value:";
            this.labelURV.Visible = false;
            this.labelURV.MouseHover += new System.EventHandler(this.labelURV_MouseHover);
            // 
            // labelLRV
            // 
            this.labelLRV.AutoSize = true;
            this.labelLRV.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLRV.Location = new System.Drawing.Point(744, 496);
            this.labelLRV.Name = "labelLRV";
            this.labelLRV.Size = new System.Drawing.Size(118, 17);
            this.labelLRV.TabIndex = 7;
            this.labelLRV.Text = "Lower range value:";
            this.labelLRV.Visible = false;
            this.labelLRV.MouseHover += new System.EventHandler(this.labelLRV_MouseHover);
            // 
            // labelTag
            // 
            this.labelTag.AutoSize = true;
            this.labelTag.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTag.Location = new System.Drawing.Point(797, 434);
            this.labelTag.Name = "labelTag";
            this.labelTag.Size = new System.Drawing.Size(64, 17);
            this.labelTag.TabIndex = 6;
            this.labelTag.Text = "Tagname:";
            this.labelTag.Visible = false;
            this.labelTag.MouseHover += new System.EventHandler(this.labelTag_MouseHover);
            // 
            // pictureBoxDisconnected2
            // 
            this.pictureBoxDisconnected2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.pictureBoxDisconnected2.Image = global::SoftSensConf.Properties.Resources.iconfinder_wifi_off_2561213;
            this.pictureBoxDisconnected2.Location = new System.Drawing.Point(841, 16);
            this.pictureBoxDisconnected2.Name = "pictureBoxDisconnected2";
            this.pictureBoxDisconnected2.Size = new System.Drawing.Size(131, 77);
            this.pictureBoxDisconnected2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDisconnected2.TabIndex = 94;
            this.pictureBoxDisconnected2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.pictureBox4.Image = global::SoftSensConf.Properties.Resources.iconfinder_wifi_Symbol_925808;
            this.pictureBox4.Location = new System.Drawing.Point(841, 16);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(131, 77);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 93;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // tabPageConnection
            // 
            this.tabPageConnection.AutoScroll = true;
            this.tabPageConnection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.tabPageConnection.Controls.Add(this.panel3);
            this.tabPageConnection.Controls.Add(this.pictureBox2);
            this.tabPageConnection.Controls.Add(this.panel1);
            this.tabPageConnection.Controls.Add(this.buttonConnectFromDB);
            this.tabPageConnection.Controls.Add(this.comboBoxCategory_DAU);
            this.tabPageConnection.Controls.Add(this.comboBoxManu_DAU);
            this.tabPageConnection.Controls.Add(this.comboBoxCommunication_DAU);
            this.tabPageConnection.Controls.Add(this.comboBoxModel_DAU);
            this.tabPageConnection.Controls.Add(this.comboBoxAREA_DAU);
            this.tabPageConnection.Controls.Add(this.comboBoxRDC_DAU);
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
            this.tabPageConnection.Controls.Add(this.buttonNEW);
            this.tabPageConnection.Controls.Add(this.buttonChange);
            this.tabPageConnection.Controls.Add(this.toolStripback);
            this.tabPageConnection.Controls.Add(this.panel2);
            this.tabPageConnection.ForeColor = System.Drawing.Color.Black;
            this.tabPageConnection.Location = new System.Drawing.Point(4, 34);
            this.tabPageConnection.Name = "tabPageConnection";
            this.tabPageConnection.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConnection.Size = new System.Drawing.Size(991, 750);
            this.tabPageConnection.TabIndex = 0;
            this.tabPageConnection.Text = "Connection";
            this.tabPageConnection.Enter += new System.EventHandler(this.tabPageConnection_Enter);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(484, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 628);
            this.panel3.TabIndex = 108;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SoftSensConf.Properties.Resources._8c066b5377aa447cb1219435ed984ace;
            this.pictureBox2.Location = new System.Drawing.Point(-89, -24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(417, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 107;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.buttonSaveRDC);
            this.panel1.Controls.Add(this.rDC_IdTextBox);
            this.panel1.Controls.Add(rDC_IdLabel1);
            this.panel1.Controls.Add(this.buttonCancelRDC);
            this.panel1.Controls.Add(this.buttonNEWRDC);
            this.panel1.Controls.Add(mCU_IdLabel);
            this.panel1.Controls.Add(this.mCU_IdTextBox);
            this.panel1.Controls.Add(configuration_Edit_DateLabel2);
            this.panel1.Controls.Add(model_IdLabel2);
            this.panel1.Controls.Add(manufactor_IdLabel2);
            this.panel1.Controls.Add(area_IdLabel2);
            this.panel1.Controls.Add(dAU_IdLabel);
            this.panel1.Controls.Add(this.buttonChangeRDC);
            this.panel1.Controls.Add(this.dAU_IdTextBox);
            this.panel1.Controls.Add(this.comboBoxAReaRDC);
            this.panel1.Controls.Add(this.labelFIND);
            this.panel1.Controls.Add(this.comboBoxMOdelRDC);
            this.panel1.Controls.Add(this.comboBoxManuRDC);
            this.panel1.Controls.Add(descriptionLabel2);
            this.panel1.Controls.Add(this.comboBoxFindingDeviceRDC);
            this.panel1.Controls.Add(this.descriptionTextBoxRDC);
            this.panel1.Controls.Add(this.configuration_Edit_DateDateTimePickerRDC);
            this.panel1.Location = new System.Drawing.Point(-4, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 529);
            this.panel1.TabIndex = 105;
            // 
            // buttonSaveRDC
            // 
            this.buttonSaveRDC.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveRDC.Location = new System.Drawing.Point(218, 104);
            this.buttonSaveRDC.Name = "buttonSaveRDC";
            this.buttonSaveRDC.Size = new System.Drawing.Size(90, 24);
            this.buttonSaveRDC.TabIndex = 103;
            this.buttonSaveRDC.Text = "Update";
            this.buttonSaveRDC.UseVisualStyleBackColor = true;
            this.buttonSaveRDC.Click += new System.EventHandler(this.buttonSaveRDC_Click);
            // 
            // rDC_IdTextBox
            // 
            this.rDC_IdTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.rDC_IdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rDC_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rDCBindingSource, "RDC_Id", true));
            this.rDC_IdTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(60)))));
            this.rDC_IdTextBox.Location = new System.Drawing.Point(4, 504);
            this.rDC_IdTextBox.Name = "rDC_IdTextBox";
            this.rDC_IdTextBox.Size = new System.Drawing.Size(200, 22);
            this.rDC_IdTextBox.TabIndex = 81;
            // 
            // buttonCancelRDC
            // 
            this.buttonCancelRDC.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelRDC.Location = new System.Drawing.Point(328, 103);
            this.buttonCancelRDC.Name = "buttonCancelRDC";
            this.buttonCancelRDC.Size = new System.Drawing.Size(90, 24);
            this.buttonCancelRDC.TabIndex = 104;
            this.buttonCancelRDC.Text = "Cancel";
            this.buttonCancelRDC.UseVisualStyleBackColor = true;
            this.buttonCancelRDC.Click += new System.EventHandler(this.buttonCancelRDC_Click);
            // 
            // buttonNEWRDC
            // 
            this.buttonNEWRDC.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNEWRDC.Location = new System.Drawing.Point(218, 75);
            this.buttonNEWRDC.Name = "buttonNEWRDC";
            this.buttonNEWRDC.Size = new System.Drawing.Size(90, 24);
            this.buttonNEWRDC.TabIndex = 101;
            this.buttonNEWRDC.Text = "New";
            this.buttonNEWRDC.UseVisualStyleBackColor = true;
            this.buttonNEWRDC.Click += new System.EventHandler(this.buttonNEWRDC_Click);
            // 
            // mCU_IdTextBox
            // 
            this.mCU_IdTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.mCU_IdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mCU_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rDCBindingSource, "MCU_Id", true));
            this.mCU_IdTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(60)))));
            this.mCU_IdTextBox.Location = new System.Drawing.Point(4, 494);
            this.mCU_IdTextBox.Name = "mCU_IdTextBox";
            this.mCU_IdTextBox.Size = new System.Drawing.Size(200, 22);
            this.mCU_IdTextBox.TabIndex = 85;
            // 
            // buttonChangeRDC
            // 
            this.buttonChangeRDC.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangeRDC.Location = new System.Drawing.Point(328, 75);
            this.buttonChangeRDC.Name = "buttonChangeRDC";
            this.buttonChangeRDC.Size = new System.Drawing.Size(90, 24);
            this.buttonChangeRDC.TabIndex = 102;
            this.buttonChangeRDC.Text = "Change";
            this.buttonChangeRDC.UseVisualStyleBackColor = true;
            this.buttonChangeRDC.Click += new System.EventHandler(this.buttonChangeRDC_Click);
            // 
            // dAU_IdTextBox
            // 
            this.dAU_IdTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dAU_IdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dAU_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dAUBindingSource, "DAU_Id", true));
            this.dAU_IdTextBox.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dAU_IdTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(60)))));
            this.dAU_IdTextBox.Location = new System.Drawing.Point(3, 507);
            this.dAU_IdTextBox.Name = "dAU_IdTextBox";
            this.dAU_IdTextBox.Size = new System.Drawing.Size(200, 18);
            this.dAU_IdTextBox.TabIndex = 36;
            // 
            // comboBoxAReaRDC
            // 
            this.comboBoxAReaRDC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxAReaRDC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBoxAReaRDC.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.rDCBindingSource, "Area_Id", true));
            this.comboBoxAReaRDC.DataSource = this.areaBindingSource1;
            this.comboBoxAReaRDC.DisplayMember = "Area";
            this.comboBoxAReaRDC.Enabled = false;
            this.comboBoxAReaRDC.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAReaRDC.ForeColor = System.Drawing.Color.Black;
            this.comboBoxAReaRDC.FormattingEnabled = true;
            this.comboBoxAReaRDC.Location = new System.Drawing.Point(218, 201);
            this.comboBoxAReaRDC.Name = "comboBoxAReaRDC";
            this.comboBoxAReaRDC.Size = new System.Drawing.Size(200, 25);
            this.comboBoxAReaRDC.TabIndex = 96;
            this.comboBoxAReaRDC.ValueMember = "Area_Id";
            // 
            // areaBindingSource1
            // 
            this.areaBindingSource1.DataMember = "Area";
            this.areaBindingSource1.DataSource = this.sOFTSENSECONF_DATABASE_FINALDataSet;
            // 
            // labelFIND
            // 
            this.labelFIND.AutoSize = true;
            this.labelFIND.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.labelFIND.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFIND.Location = new System.Drawing.Point(23, 43);
            this.labelFIND.Name = "labelFIND";
            this.labelFIND.Size = new System.Drawing.Size(172, 17);
            this.labelFIND.TabIndex = 100;
            this.labelFIND.Text = "Find Remote Data Collector:";
            // 
            // comboBoxMOdelRDC
            // 
            this.comboBoxMOdelRDC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBoxMOdelRDC.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.rDCBindingSource, "Model_Id", true));
            this.comboBoxMOdelRDC.DataSource = this.modelBindingSource1;
            this.comboBoxMOdelRDC.DisplayMember = "Model";
            this.comboBoxMOdelRDC.Enabled = false;
            this.comboBoxMOdelRDC.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMOdelRDC.ForeColor = System.Drawing.Color.Black;
            this.comboBoxMOdelRDC.FormattingEnabled = true;
            this.comboBoxMOdelRDC.Location = new System.Drawing.Point(218, 263);
            this.comboBoxMOdelRDC.Name = "comboBoxMOdelRDC";
            this.comboBoxMOdelRDC.Size = new System.Drawing.Size(200, 25);
            this.comboBoxMOdelRDC.TabIndex = 97;
            this.comboBoxMOdelRDC.ValueMember = "Model_Id";
            // 
            // modelBindingSource1
            // 
            this.modelBindingSource1.DataMember = "Model";
            this.modelBindingSource1.DataSource = this.sOFTSENSECONF_DATABASE_FINALDataSet;
            // 
            // comboBoxManuRDC
            // 
            this.comboBoxManuRDC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBoxManuRDC.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.rDCBindingSource, "Manufactor_Id", true));
            this.comboBoxManuRDC.DataSource = this.manufactorBindingSource1;
            this.comboBoxManuRDC.DisplayMember = "Manufactor";
            this.comboBoxManuRDC.Enabled = false;
            this.comboBoxManuRDC.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxManuRDC.ForeColor = System.Drawing.Color.Black;
            this.comboBoxManuRDC.FormattingEnabled = true;
            this.comboBoxManuRDC.Location = new System.Drawing.Point(218, 232);
            this.comboBoxManuRDC.Name = "comboBoxManuRDC";
            this.comboBoxManuRDC.Size = new System.Drawing.Size(200, 25);
            this.comboBoxManuRDC.TabIndex = 98;
            this.comboBoxManuRDC.ValueMember = "Manufactor_Id";
            // 
            // manufactorBindingSource1
            // 
            this.manufactorBindingSource1.DataMember = "Manufactor";
            this.manufactorBindingSource1.DataSource = this.sOFTSENSECONF_DATABASE_FINALDataSet;
            // 
            // comboBoxFindingDeviceRDC
            // 
            this.comboBoxFindingDeviceRDC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBoxFindingDeviceRDC.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFindingDeviceRDC.ForeColor = System.Drawing.Color.Black;
            this.comboBoxFindingDeviceRDC.FormattingEnabled = true;
            this.comboBoxFindingDeviceRDC.Location = new System.Drawing.Point(218, 40);
            this.comboBoxFindingDeviceRDC.Name = "comboBoxFindingDeviceRDC";
            this.comboBoxFindingDeviceRDC.Size = new System.Drawing.Size(200, 25);
            this.comboBoxFindingDeviceRDC.TabIndex = 95;
            this.comboBoxFindingDeviceRDC.SelectedIndexChanged += new System.EventHandler(this.comboBoxFindingDeviceRDC_SelectedIndexChanged_1);
            // 
            // descriptionTextBoxRDC
            // 
            this.descriptionTextBoxRDC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.descriptionTextBoxRDC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rDCBindingSource, "Description", true));
            this.descriptionTextBoxRDC.Enabled = false;
            this.descriptionTextBoxRDC.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBoxRDC.ForeColor = System.Drawing.Color.Black;
            this.descriptionTextBoxRDC.Location = new System.Drawing.Point(218, 170);
            this.descriptionTextBoxRDC.Multiline = true;
            this.descriptionTextBoxRDC.Name = "descriptionTextBoxRDC";
            this.descriptionTextBoxRDC.Size = new System.Drawing.Size(200, 25);
            this.descriptionTextBoxRDC.TabIndex = 83;
            // 
            // configuration_Edit_DateDateTimePickerRDC
            // 
            this.configuration_Edit_DateDateTimePickerRDC.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.configuration_Edit_DateDateTimePickerRDC.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.configuration_Edit_DateDateTimePickerRDC.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.configuration_Edit_DateDateTimePickerRDC.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.configuration_Edit_DateDateTimePickerRDC.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.configuration_Edit_DateDateTimePickerRDC.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.rDCBindingSource, "Configuration_Edit_Date", true));
            this.configuration_Edit_DateDateTimePickerRDC.Enabled = false;
            this.configuration_Edit_DateDateTimePickerRDC.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configuration_Edit_DateDateTimePickerRDC.Location = new System.Drawing.Point(218, 295);
            this.configuration_Edit_DateDateTimePickerRDC.Name = "configuration_Edit_DateDateTimePickerRDC";
            this.configuration_Edit_DateDateTimePickerRDC.Size = new System.Drawing.Size(200, 25);
            this.configuration_Edit_DateDateTimePickerRDC.TabIndex = 93;
            // 
            // buttonConnectFromDB
            // 
            this.buttonConnectFromDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.buttonConnectFromDB.FlatAppearance.BorderSize = 0;
            this.buttonConnectFromDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConnectFromDB.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnectFromDB.ForeColor = System.Drawing.Color.Lime;
            this.buttonConnectFromDB.Location = new System.Drawing.Point(688, 558);
            this.buttonConnectFromDB.Name = "buttonConnectFromDB";
            this.buttonConnectFromDB.Size = new System.Drawing.Size(230, 33);
            this.buttonConnectFromDB.TabIndex = 63;
            this.buttonConnectFromDB.Text = "Connect to instrument";
            this.buttonConnectFromDB.UseVisualStyleBackColor = false;
            this.buttonConnectFromDB.Click += new System.EventHandler(this.buttonConnectFromDB_Click);
            // 
            // comboBoxCategory_DAU
            // 
            this.comboBoxCategory_DAU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBoxCategory_DAU.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dAUBindingSource, "Category_Id", true));
            this.comboBoxCategory_DAU.DataSource = this.categoryBindingSource;
            this.comboBoxCategory_DAU.DisplayMember = "Category";
            this.comboBoxCategory_DAU.Enabled = false;
            this.comboBoxCategory_DAU.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCategory_DAU.FormattingEnabled = true;
            this.comboBoxCategory_DAU.Location = new System.Drawing.Point(702, 434);
            this.comboBoxCategory_DAU.Name = "comboBoxCategory_DAU";
            this.comboBoxCategory_DAU.Size = new System.Drawing.Size(200, 25);
            this.comboBoxCategory_DAU.TabIndex = 62;
            this.comboBoxCategory_DAU.ValueMember = "Category_Id";
            // 
            // comboBoxManu_DAU
            // 
            this.comboBoxManu_DAU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBoxManu_DAU.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dAUBindingSource, "Manufactor_Id", true));
            this.comboBoxManu_DAU.DataSource = this.manufactorBindingSource;
            this.comboBoxManu_DAU.DisplayMember = "Manufactor";
            this.comboBoxManu_DAU.Enabled = false;
            this.comboBoxManu_DAU.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxManu_DAU.FormattingEnabled = true;
            this.comboBoxManu_DAU.Location = new System.Drawing.Point(702, 405);
            this.comboBoxManu_DAU.Name = "comboBoxManu_DAU";
            this.comboBoxManu_DAU.Size = new System.Drawing.Size(200, 25);
            this.comboBoxManu_DAU.TabIndex = 61;
            this.comboBoxManu_DAU.ValueMember = "Manufactor_Id";
            // 
            // comboBoxCommunication_DAU
            // 
            this.comboBoxCommunication_DAU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBoxCommunication_DAU.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dAUBindingSource, "Communication_Id", true));
            this.comboBoxCommunication_DAU.DataSource = this.communicationBindingSource;
            this.comboBoxCommunication_DAU.DisplayMember = "Communication";
            this.comboBoxCommunication_DAU.Enabled = false;
            this.comboBoxCommunication_DAU.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCommunication_DAU.FormattingEnabled = true;
            this.comboBoxCommunication_DAU.Location = new System.Drawing.Point(702, 374);
            this.comboBoxCommunication_DAU.Name = "comboBoxCommunication_DAU";
            this.comboBoxCommunication_DAU.Size = new System.Drawing.Size(200, 25);
            this.comboBoxCommunication_DAU.TabIndex = 60;
            this.comboBoxCommunication_DAU.ValueMember = "Communication_Id";
            // 
            // comboBoxModel_DAU
            // 
            this.comboBoxModel_DAU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBoxModel_DAU.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dAUBindingSource, "Model_Id", true));
            this.comboBoxModel_DAU.DataSource = this.modelBindingSource;
            this.comboBoxModel_DAU.DisplayMember = "Model";
            this.comboBoxModel_DAU.Enabled = false;
            this.comboBoxModel_DAU.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxModel_DAU.FormattingEnabled = true;
            this.comboBoxModel_DAU.Location = new System.Drawing.Point(702, 343);
            this.comboBoxModel_DAU.Name = "comboBoxModel_DAU";
            this.comboBoxModel_DAU.Size = new System.Drawing.Size(200, 25);
            this.comboBoxModel_DAU.TabIndex = 59;
            this.comboBoxModel_DAU.ValueMember = "Model_Id";
            // 
            // comboBoxAREA_DAU
            // 
            this.comboBoxAREA_DAU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBoxAREA_DAU.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dAUBindingSource, "Area_Id", true));
            this.comboBoxAREA_DAU.DataSource = this.areaBindingSource;
            this.comboBoxAREA_DAU.DisplayMember = "Area";
            this.comboBoxAREA_DAU.Enabled = false;
            this.comboBoxAREA_DAU.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAREA_DAU.FormattingEnabled = true;
            this.comboBoxAREA_DAU.Location = new System.Drawing.Point(702, 312);
            this.comboBoxAREA_DAU.Name = "comboBoxAREA_DAU";
            this.comboBoxAREA_DAU.Size = new System.Drawing.Size(200, 25);
            this.comboBoxAREA_DAU.TabIndex = 58;
            this.comboBoxAREA_DAU.ValueMember = "Area_Id";
            // 
            // comboBoxRDC_DAU
            // 
            this.comboBoxRDC_DAU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBoxRDC_DAU.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dAUBindingSource, "RDC_Id", true));
            this.comboBoxRDC_DAU.DataSource = this.rDCBindingSource;
            this.comboBoxRDC_DAU.DisplayMember = "Description";
            this.comboBoxRDC_DAU.Enabled = false;
            this.comboBoxRDC_DAU.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRDC_DAU.FormattingEnabled = true;
            this.comboBoxRDC_DAU.Location = new System.Drawing.Point(702, 281);
            this.comboBoxRDC_DAU.Name = "comboBoxRDC_DAU";
            this.comboBoxRDC_DAU.Size = new System.Drawing.Size(200, 25);
            this.comboBoxRDC_DAU.TabIndex = 57;
            this.comboBoxRDC_DAU.ValueMember = "RDC_Id";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dAUBindingSource, "Description", true));
            this.descriptionTextBox.Enabled = false;
            this.descriptionTextBox.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(702, 250);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(200, 25);
            this.descriptionTextBox.TabIndex = 38;
            // 
            // cOMPortTextBox
            // 
            this.cOMPortTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cOMPortTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dAUBindingSource, "COMPort", true));
            this.cOMPortTextBox.Enabled = false;
            this.cOMPortTextBox.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cOMPortTextBox.Location = new System.Drawing.Point(702, 463);
            this.cOMPortTextBox.Name = "cOMPortTextBox";
            this.cOMPortTextBox.Size = new System.Drawing.Size(200, 25);
            this.cOMPortTextBox.TabIndex = 52;
            // 
            // bAUDRateTextBox
            // 
            this.bAUDRateTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bAUDRateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dAUBindingSource, "BAUDRate", true));
            this.bAUDRateTextBox.Enabled = false;
            this.bAUDRateTextBox.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAUDRateTextBox.Location = new System.Drawing.Point(702, 494);
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
            this.configuration_edit_dateDateTimePicker.Location = new System.Drawing.Point(702, 525);
            this.configuration_edit_dateDateTimePicker.Name = "configuration_edit_dateDateTimePicker";
            this.configuration_edit_dateDateTimePicker.Size = new System.Drawing.Size(200, 25);
            this.configuration_edit_dateDateTimePicker.TabIndex = 56;
            // 
            // comboBoxFindDevice
            // 
            this.comboBoxFindDevice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBoxFindDevice.DataSource = this.dAU_OnlyIdDesBindingSource;
            this.comboBoxFindDevice.DisplayMember = "DAU_Id";
            this.comboBoxFindDevice.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFindDevice.ForeColor = System.Drawing.Color.Black;
            this.comboBoxFindDevice.FormattingEnabled = true;
            this.comboBoxFindDevice.Location = new System.Drawing.Point(702, 120);
            this.comboBoxFindDevice.Name = "comboBoxFindDevice";
            this.comboBoxFindDevice.Size = new System.Drawing.Size(200, 25);
            this.comboBoxFindDevice.TabIndex = 35;
            this.comboBoxFindDevice.ValueMember = "DAU_Id";
            this.comboBoxFindDevice.SelectedIndexChanged += new System.EventHandler(this.comboBoxFindDevice_SelectedIndexChanged);
            // 
            // buttonNEW
            // 
            this.buttonNEW.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNEW.Location = new System.Drawing.Point(702, 155);
            this.buttonNEW.Name = "buttonNEW";
            this.buttonNEW.Size = new System.Drawing.Size(90, 24);
            this.buttonNEW.TabIndex = 32;
            this.buttonNEW.Text = "New";
            this.buttonNEW.UseVisualStyleBackColor = true;
            this.buttonNEW.Click += new System.EventHandler(this.buttonNEW_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChange.Location = new System.Drawing.Point(811, 155);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(90, 24);
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
            this.toolStripback.Location = new System.Drawing.Point(3, 705);
            this.toolStripback.Name = "toolStripback";
            this.toolStripback.Size = new System.Drawing.Size(989, 25);
            this.toolStripback.TabIndex = 7;
            this.toolStripback.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(39, 22);
            this.toolStripLabel1.Text = "Ready";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel2.Controls.Add(this.buttonDisconnectInstrument);
            this.panel2.Controls.Add(this.labelFindDevice);
            this.panel2.Controls.Add(this.buttonDAU_Save);
            this.panel2.Controls.Add(this.buttonCancelDAU);
            this.panel2.Controls.Add(this.pictureBoxDisconnected);
            this.panel2.Controls.Add(this.pictureBoxCONNECTED);
            this.panel2.Controls.Add(this.buttonDisconnect);
            this.panel2.Controls.Add(this.buttonConnect);
            this.panel2.Controls.Add(this.radioButtonConnected);
            this.panel2.Controls.Add(this.ComboBoxBaud);
            this.panel2.Controls.Add(this.ComboBoxPorts);
            this.panel2.Controls.Add(this.labelBitrate);
            this.panel2.Controls.Add(this.labelCom);
            this.panel2.Location = new System.Drawing.Point(490, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(505, 630);
            this.panel2.TabIndex = 106;
            // 
            // buttonDisconnectInstrument
            // 
            this.buttonDisconnectInstrument.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.buttonDisconnectInstrument.FlatAppearance.BorderSize = 0;
            this.buttonDisconnectInstrument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDisconnectInstrument.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisconnectInstrument.ForeColor = System.Drawing.Color.Red;
            this.buttonDisconnectInstrument.Location = new System.Drawing.Point(177, 553);
            this.buttonDisconnectInstrument.Name = "buttonDisconnectInstrument";
            this.buttonDisconnectInstrument.Size = new System.Drawing.Size(293, 33);
            this.buttonDisconnectInstrument.TabIndex = 65;
            this.buttonDisconnectInstrument.Text = "Disconnect from instrument";
            this.buttonDisconnectInstrument.UseVisualStyleBackColor = false;
            this.buttonDisconnectInstrument.Visible = false;
            this.buttonDisconnectInstrument.Click += new System.EventHandler(this.buttonDisconnectInstrument_Click_1);
            // 
            // labelFindDevice
            // 
            this.labelFindDevice.AutoSize = true;
            this.labelFindDevice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.labelFindDevice.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFindDevice.Location = new System.Drawing.Point(50, 120);
            this.labelFindDevice.Name = "labelFindDevice";
            this.labelFindDevice.Size = new System.Drawing.Size(148, 17);
            this.labelFindDevice.TabIndex = 34;
            this.labelFindDevice.Text = "Find Data Aqusition Unit";
            // 
            // buttonDAU_Save
            // 
            this.buttonDAU_Save.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDAU_Save.Location = new System.Drawing.Point(212, 183);
            this.buttonDAU_Save.Name = "buttonDAU_Save";
            this.buttonDAU_Save.Size = new System.Drawing.Size(90, 24);
            this.buttonDAU_Save.TabIndex = 31;
            this.buttonDAU_Save.Text = "Update";
            this.buttonDAU_Save.UseVisualStyleBackColor = true;
            this.buttonDAU_Save.Click += new System.EventHandler(this.buttonDAU_Save_Click);
            // 
            // buttonCancelDAU
            // 
            this.buttonCancelDAU.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelDAU.Location = new System.Drawing.Point(321, 184);
            this.buttonCancelDAU.Name = "buttonCancelDAU";
            this.buttonCancelDAU.Size = new System.Drawing.Size(90, 24);
            this.buttonCancelDAU.TabIndex = 33;
            this.buttonCancelDAU.Text = "Cancel";
            this.buttonCancelDAU.UseVisualStyleBackColor = true;
            this.buttonCancelDAU.Click += new System.EventHandler(this.buttonCancelDAU_Click);
            // 
            // pictureBoxDisconnected
            // 
            this.pictureBoxDisconnected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.pictureBoxDisconnected.Image = global::SoftSensConf.Properties.Resources.iconfinder_wifi_off_2561213;
            this.pictureBoxDisconnected.Location = new System.Drawing.Point(358, 17);
            this.pictureBoxDisconnected.Name = "pictureBoxDisconnected";
            this.pictureBoxDisconnected.Size = new System.Drawing.Size(131, 76);
            this.pictureBoxDisconnected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDisconnected.TabIndex = 80;
            this.pictureBoxDisconnected.TabStop = false;
            // 
            // pictureBoxCONNECTED
            // 
            this.pictureBoxCONNECTED.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.pictureBoxCONNECTED.Image = global::SoftSensConf.Properties.Resources.iconfinder_wifi_Symbol_925808;
            this.pictureBoxCONNECTED.Location = new System.Drawing.Point(358, 17);
            this.pictureBoxCONNECTED.Name = "pictureBoxCONNECTED";
            this.pictureBoxCONNECTED.Size = new System.Drawing.Size(131, 77);
            this.pictureBoxCONNECTED.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCONNECTED.TabIndex = 79;
            this.pictureBoxCONNECTED.TabStop = false;
            this.pictureBoxCONNECTED.Visible = false;
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisconnect.Location = new System.Drawing.Point(0, 208);
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
            this.buttonConnect.Location = new System.Drawing.Point(3, 184);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(112, 23);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Visible = false;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            this.buttonConnect.MouseHover += new System.EventHandler(this.buttonConnect_MouseHover);
            // 
            // radioButtonConnected
            // 
            this.radioButtonConnected.AutoSize = true;
            this.radioButtonConnected.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonConnected.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonConnected.ForeColor = System.Drawing.Color.LimeGreen;
            this.radioButtonConnected.Location = new System.Drawing.Point(25, 218);
            this.radioButtonConnected.Name = "radioButtonConnected";
            this.radioButtonConnected.Size = new System.Drawing.Size(14, 13);
            this.radioButtonConnected.TabIndex = 4;
            this.radioButtonConnected.TabStop = true;
            this.radioButtonConnected.UseVisualStyleBackColor = false;
            this.radioButtonConnected.Visible = false;
            this.radioButtonConnected.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButtonConnected_MouseClick);
            this.radioButtonConnected.MouseHover += new System.EventHandler(this.radioButtonConnected_MouseHover);
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
            this.ComboBoxBaud.Location = new System.Drawing.Point(3, 156);
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
            this.ComboBoxPorts.Location = new System.Drawing.Point(3, 187);
            this.ComboBoxPorts.Name = "ComboBoxPorts";
            this.ComboBoxPorts.Size = new System.Drawing.Size(148, 25);
            this.ComboBoxPorts.TabIndex = 0;
            this.ComboBoxPorts.Visible = false;
            this.ComboBoxPorts.Enter += new System.EventHandler(this.comboBoxPorts_Enter);
            this.ComboBoxPorts.MouseHover += new System.EventHandler(this.ComboBoxPorts_MouseHover);
            // 
            // labelBitrate
            // 
            this.labelBitrate.AutoSize = true;
            this.labelBitrate.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBitrate.Location = new System.Drawing.Point(-9, 162);
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
            this.labelCom.Location = new System.Drawing.Point(33, 191);
            this.labelCom.Name = "labelCom";
            this.labelCom.Size = new System.Drawing.Size(62, 17);
            this.labelCom.TabIndex = 5;
            this.labelCom.Text = "ComPort:";
            this.labelCom.Visible = false;
            this.labelCom.MouseHover += new System.EventHandler(this.labelCom_MouseHover);
            // 
            // rDCOnlyIdDesBindingSource
            // 
            this.rDCOnlyIdDesBindingSource.DataMember = "RDCOnlyIdDes";
            this.rDCOnlyIdDesBindingSource.DataSource = this.sOFTSENSECONF_DATABASE_FINALDataSet;
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
            this.tabControl.Location = new System.Drawing.Point(5, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(115, 5);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(999, 788);
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
            this.buttonExit.BackgroundImage = global::SoftSensConf.Properties.Resources.iconfinder_39_Exit_Arrow_Door_Signout_Out_Close_2142693;
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonExit.Location = new System.Drawing.Point(955, 2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(49, 36);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // rDCOnlyIdDesTableAdapter
            // 
            this.rDCOnlyIdDesTableAdapter.ClearBeforeFill = true;
            // 
            // innput_OutputTableAdapter
            // 
            this.innput_OutputTableAdapter.ClearBeforeFill = true;
            // 
            // SoftSensConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1000, 667);
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
            ((System.ComponentModel.ISupportInitialize)(this.chartPoints)).EndInit();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisconnected3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.tabPageConfiguration.ResumeLayout(false);
            this.tabPageConfiguration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.innput_OutputBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.communicationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAUBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufactorBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisconnected2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.tabPageConnection.ResumeLayout(false);
            this.tabPageConnection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufactorBindingSource1)).EndInit();
            this.toolStripback.ResumeLayout(false);
            this.toolStripback.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisconnected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCONNECTED)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDCOnlyIdDesBindingSource)).EndInit();
            this.tabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iNSTRUMENTtoComboBoxBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox textBoxSend;
        private System.Windows.Forms.TextBox textBoxReceive;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Button buttonReceive;
        private System.Windows.Forms.Button buttonSendValuesToInstrument;
        private System.Windows.Forms.TabPage tabPageConfiguration;
        private System.Windows.Forms.TextBox tagNameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBoxInstrument;
        private System.Windows.Forms.TextBox lower_range_valueTextBox;
        private System.Windows.Forms.TextBox upper_range_valueTextBox;
        private System.Windows.Forms.TextBox alarm_LowTextBox;
        private System.Windows.Forms.TextBox alarm_highTextBox;
        private System.Windows.Forms.TextBox frequencyTextBox;
        private System.Windows.Forms.TextBox textBoxConnectionP1;
        private System.Windows.Forms.DateTimePicker configuration_Edit_DateDateTimePickerInstrument;
        private System.Windows.Forms.Button buttonRetrieve;
        private System.Windows.Forms.Button buttonSendValues;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonLoad;
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
        private System.Windows.Forms.RadioButton radioButtonConnected;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.ComboBox ComboBoxBaud;
        private System.Windows.Forms.ComboBox ComboBoxPorts;
        private System.Windows.Forms.TabControl tabControl;
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPoints;
        private System.Windows.Forms.Button buttonGraphstart;
        private System.Windows.Forms.ListBox listBoxDBreadings;
        private System.Windows.Forms.Button buttonstopgraph;
        private System.Windows.Forms.TextBox tagNameTextBox1;
        private System.Windows.Forms.TextBox instrument_Log_IdTextBox1;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.DateTimePicker timeDateTimePicker;
        private System.Windows.Forms.TextBox instrument_Log_IdTextBox;
        private System.Windows.Forms.PictureBox pictureBoxCONNECTED;
        private System.Windows.Forms.PictureBox pictureBoxDisconnected;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox rDC_IdTextBox;
        private System.Windows.Forms.TextBox descriptionTextBoxRDC;
        private System.Windows.Forms.TextBox mCU_IdTextBox;
        private System.Windows.Forms.DateTimePicker configuration_Edit_DateDateTimePickerRDC;
        private System.Windows.Forms.ComboBox comboBoxFindingDeviceRDC;
        private System.Windows.Forms.BindingSource rDCOnlyIdDesBindingSource;
        private SOFTSENSECONF_DATABASE_FINALDataSetTableAdapters.RDCOnlyIdDesTableAdapter rDCOnlyIdDesTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxManuRDC;
        private System.Windows.Forms.BindingSource manufactorBindingSource1;
        private System.Windows.Forms.ComboBox comboBoxMOdelRDC;
        private System.Windows.Forms.BindingSource modelBindingSource1;
        private System.Windows.Forms.ComboBox comboBoxAReaRDC;
        private System.Windows.Forms.BindingSource areaBindingSource1;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Button buttonSending;
        private System.Windows.Forms.TextBox textBoxConnectionP2;
        private System.Windows.Forms.Label labelFIND;
        private System.Windows.Forms.Label labelfinding;
        private System.Windows.Forms.ComboBox comboBoxCOMMInstrument;
        private System.Windows.Forms.BindingSource communicationBindingSource1;
        private System.Windows.Forms.ComboBox comboBoxDAUinstrument;
        private System.Windows.Forms.BindingSource dAUBindingSource1;
        private System.Windows.Forms.ComboBox comboBoxManuInstrument;
        private System.Windows.Forms.BindingSource manufactorBindingSource2;
        private System.Windows.Forms.ComboBox comboBoxModelinstrument;
        private System.Windows.Forms.ComboBox comboBoxCategoryInstrument;
        private System.Windows.Forms.BindingSource categoryBindingSource1;
        private System.Windows.Forms.ComboBox comboBoxInnputOutputInstrument;
        private System.Windows.Forms.ComboBox comboBoxAreaInstrument;
        private System.Windows.Forms.BindingSource areaBindingSource2;
        private System.Windows.Forms.BindingSource innput_OutputBindingSource;
        private SOFTSENSECONF_DATABASE_FINALDataSetTableAdapters.Innput_OutputTableAdapter innput_OutputTableAdapter;
        private System.Windows.Forms.BindingSource modelBindingSource2;
        private System.Windows.Forms.Button buttonSendValuestodb;
        private System.Windows.Forms.Button buttonCancelRDC;
        private System.Windows.Forms.Button buttonSaveRDC;
        private System.Windows.Forms.Button buttonChangeRDC;
        private System.Windows.Forms.Button buttonNEWRDC;
        private System.Windows.Forms.Button buttonUpdateInstrument;
        private System.Windows.Forms.TextBox textBoxMatch;
        private System.Windows.Forms.TextBox textBoxAH;
        private System.Windows.Forms.TextBox textBoxAL;
        private System.Windows.Forms.TextBox textBoxURV;
        private System.Windows.Forms.TextBox textBoxLRV;
        private System.Windows.Forms.TextBox textBoxTag;
        private System.Windows.Forms.Button buttonChangeInstrument;
        private System.Windows.Forms.Button buttonCancelInstrument;
        private System.Windows.Forms.Button buttonNEWInstrument;
        private System.Windows.Forms.Label labelMatching;
        private System.Windows.Forms.Label labelAH;
        private System.Windows.Forms.Label labelAL;
        private System.Windows.Forms.Label labelURV;
        private System.Windows.Forms.Label labelLRV;
        private System.Windows.Forms.Label labelTag;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonSTopsendingdata;
        private System.Windows.Forms.PictureBox pictureBoxDisconnected3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBoxDisconnected2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button buttonAnalogInn;
        private System.Windows.Forms.Button buttonDigitalout;
        private System.Windows.Forms.Button buttonDigitalInn;
        private System.Windows.Forms.Button buttonAnalogout;
        private System.Windows.Forms.TextBox tagNameTextBox2;
        private System.Windows.Forms.TextBox instrument_Log_IdTextBox2;
        private System.Windows.Forms.DateTimePicker timeDateTimePickerAILOG;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelCom;
        private System.Windows.Forms.Panel panel3;
    }
}

