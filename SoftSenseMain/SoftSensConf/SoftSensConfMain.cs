using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace SoftSensConf
{
    public partial class SoftSensConfig : Form
    {
        public SoftSensConfig()
        {
            InitializeComponent();

        }
        string[] InstrumentConfigs;
        string[] InstrumentValues;
        string[] Flagnumber;
        string passp = "superhemmelig";
        string Sendingdata = "";
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sOFTSENSECONF_DATABASE_FINALDataSet.Innput_Output' table. You can move, or remove it, as needed.
            this.innput_OutputTableAdapter.Fill(this.sOFTSENSECONF_DATABASE_FINALDataSet.Innput_Output);
            // TODO: This line of code loads data into the 'sOFTSENSECONF_DATABASE_FINALDataSet.RDCOnlyIdDes' table. You can move, or remove it, as needed.
            this.rDCOnlyIdDesTableAdapter.FillRDCOnlyIDdES(this.sOFTSENSECONF_DATABASE_FINALDataSet.RDCOnlyIdDes);
            // TODO: This line of code loads data into the 'sOFTSENSECONF_DATABASE_FINALDataSet.RDC1' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'sOFTSENSECONF_DATABASE_FINALDataSet.Instrument_Measure_Id' table. You can move, or remove it, as needed.
            this.instrument_Measure_IdTableAdapter.Fill(this.sOFTSENSECONF_DATABASE_FINALDataSet.Instrument_Measure_Id);
            // TODO: This line of code loads data into the 'sOFTSENSECONF_DATABASE_FINALDataSet.AI_LOG' table. You can move, or remove it, as needed.
            this.aI_LOGTableAdapter.Fill(this.sOFTSENSECONF_DATABASE_FINALDataSet.AI_LOG);
            // TODO: This line of code loads data into the 'sOFTSENSECONF_DATABASE_FINALDataSet.AI_LOG' table. You can move, or remove it, as needed.
            this.aI_LOGTableAdapter.Fill(this.sOFTSENSECONF_DATABASE_FINALDataSet.AI_LOG);
            // TODO: This line of code loads data into the 'sOFTSENSECONF_DATABASE_FINALDataSet.AI_LOG' table. You can move, or remove it, as needed.
            this.aI_LOGTableAdapter.Fill(this.sOFTSENSECONF_DATABASE_FINALDataSet.AI_LOG);
            // TODO: This line of code loads data into the 'sOFTSENSECONF_DATABASE_FINALDataSet.AI_LOG' table. You can move, or remove it, as needed.
            this.aI_LOGTableAdapter.Fill(this.sOFTSENSECONF_DATABASE_FINALDataSet.AI_LOG);
            // TODO: This line of code loads data into the 'sOFTSENSECONF_DATABASE_FINALDataSet.Instrument_Measure_Id' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'sOFTSENSECONF_DATABASE_FINALDataSet.AI_LOG' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'sOFTSENSECONF_DATABASE_FINALDataSet.AI_LOG' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'sOFTSENSECONF_DATABASE_FINALDataSet.AI_LOG' table. You can move, or remove it, as needed.


            //rdc
            this.rDCOnlyIdDesTableAdapter.FillRDCOnlyIDdES(this.sOFTSENSECONF_DATABASE_FINALDataSet.RDCOnlyIdDes);
            comboBoxFindingDeviceRDC.DisplayMember = "Description";
            comboBoxFindingDeviceRDC.ValueMember = "RDC_Id";
            comboBoxFindingDeviceRDC.DataSource = sOFTSENSECONF_DATABASE_FINALDataSet.RDCOnlyIdDes;

            ///dau
    






            // TODO: This line of code loads data into the 'sOFTSENSECONF_DATABASE_FINALDataSet.INSTRUMENT' table. You can move, or remove it, as needed.
            this.iNSTRUMENTTableAdapter.Fill(this.sOFTSENSECONF_DATABASE_FINALDataSet.INSTRUMENT);
            // TODO: This line of code loads data into the 'sOFTSENSECONF_DATABASE_FINALDataSet.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.sOFTSENSECONF_DATABASE_FINALDataSet.Category);
            // TODO: This line of code loads data into the 'sOFTSENSECONF_DATABASE_FINALDataSet.Manufactor' table. You can move, or remove it, as needed.
            this.manufactorTableAdapter.Fill(this.sOFTSENSECONF_DATABASE_FINALDataSet.Manufactor);
            // TODO: This line of code loads data into the 'sOFTSENSECONF_DATABASE_FINALDataSet.Communication' table. You can move, or remove it, as needed.
            this.communicationTableAdapter.Fill(this.sOFTSENSECONF_DATABASE_FINALDataSet.Communication);
            // TODO: This line of code loads data into the 'sOFTSENSECONF_DATABASE_FINALDataSet.Model' table. You can move, or remove it, as needed.
            this.modelTableAdapter.Fill(this.sOFTSENSECONF_DATABASE_FINALDataSet.Model);
            // TODO: This line of code loads data into the 'sOFTSENSECONF_DATABASE_FINALDataSet.Area' table. You can move, or remove it, as needed.
            this.areaTableAdapter.Fill(this.sOFTSENSECONF_DATABASE_FINALDataSet.Area);
            // TODO: This line of code loads data into the 'sOFTSENSECONF_DATABASE_FINALDataSet.RDC' table. You can move, or remove it, as needed.
            this.rDCTableAdapter.Fill(this.sOFTSENSECONF_DATABASE_FINALDataSet.RDC);
            // TODO: This line of code loads data into the 'sOFTSENSECONF_DATABASE_FINALDataSet.DAU_OnlyIdDes' table. You can move, or remove it, as needed.
            this.dAU_OnlyIdDesTableAdapter.Fill(this.sOFTSENSECONF_DATABASE_FINALDataSet.DAU_OnlyIdDes);
            // TODO: This line of code loads data into the 'sOFTSENSECONF_DATABASE_FINALDataSet.INSTRUMENT' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'sOFTSENSECONF_DATABASE_FINALDataSet.DAU' table. You can move, or remove it, as needed.
            this.dAUTableAdapter.Fill(this.sOFTSENSECONF_DATABASE_FINALDataSet.DAU);
            InstrumentConfigs = new string[5];
            InstrumentValues = new string[5];
            Flagnumber = new string[1];
            if (serialPort1.IsOpen == false)
            {
                buttonSendValuesToInstrument.Enabled = false;
                buttonSendValues.Enabled = false;
                buttonRetrieve.Enabled = false;
                buttonReceive.Enabled = false;
                buttonDisconnect.Enabled = false;
                textBoxConnectionP1.Text = "Disconnected";
                textBoxConnectionP1.ForeColor = Color.Red;
                textBoxConnectionP2.Text = "Disconnected";
                textBoxConnectionP2.ForeColor = Color.Red;
            }

        }

        private void comboBoxPorts_Enter(object sender, EventArgs e)
        {
            ComboBoxPorts.Items.Clear();
            string[] comPorts = System.IO.Ports.SerialPort.GetPortNames();
            foreach (string ports in comPorts)
            {
                ComboBoxPorts.Items.Add(ports);
            }
            toolStripLabel1.Text = "Comport";
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            {
                if (ComboBoxPorts.SelectedIndex > -1)
                {
                    serialPort1.PortName = ComboBoxPorts.Items[ComboBoxPorts.SelectedIndex].ToString();


                    if (ComboBoxBaud.SelectedIndex > -1)
                    {
                        serialPort1.BaudRate = Convert.ToInt32(ComboBoxBaud.Items[ComboBoxBaud.SelectedIndex]);
                        serialPort1.Open();
                        radioButtonConnected.Checked = true;
                        radioButtonConnected.Text = "Connected";
                        buttonDisconnect.Enabled = true;
                        buttonConnect.Enabled = false;
                        textBoxConnectionP1.Text = "Connected";
                        textBoxConnectionP1.ForeColor = Color.Green;
                        textBoxConnectionP2.Text = "Connected";
                        textBoxConnectionP2.ForeColor = Color.Green;
                        buttonSendValuesToInstrument.Enabled = true;
                        buttonSendValues.Enabled = true;
                        buttonRetrieve.Enabled = true;
                        buttonReceive.Enabled = true;
                        buttonDisconnect.Enabled = true;
                        timerStatus.Enabled = true;


                    }


                }
                
                {
                    

                }
            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            serialPort1.BaudRate = Convert.ToInt32(ComboBoxBaud.Items[ComboBoxBaud.SelectedIndex]);
            serialPort1.Close();
            ComboBoxPorts.Text = "";
            ComboBoxBaud.Text = "";
            MessageBox.Show("Disconnected");
            radioButtonConnected.Checked = false;
            radioButtonConnected.Text = "Disconnected";
            radioButtonConnected.ForeColor = Color.Red;
            buttonConnect.Enabled = true;
            textBoxConnectionP1.Text = "Disconnected";
            textBoxConnectionP1.ForeColor = Color.Red;
            textBoxConnectionP2.Text = "Disconnected";
            textBoxConnectionP2.ForeColor = Color.Red;



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (tagNameTextBox.Text == textBoxTag.Text)
            {
                textBoxMatch.Text = "OK";
            }
        }

        private void buttonConnect_MouseHover(object sender, EventArgs e)
        {
            toolStripback.Text = "Connect";
        }

        private void tabPageConnection_Enter(object sender, EventArgs e)
        {
            toolStripback.Text = "Ready";



        }

        private void buttonDisconnect_MouseHover(object sender, EventArgs e)
        {
            toolStripback.Text = "Disconnect";
        }

        private void labelCom_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Select the comport", labelCom);
        }

        private void labelBitrate_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Select the Bitrate/Baudrate", labelBitrate);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var filecontent = string.Empty;
            string Name = "";
            openFileDialog.InitialDirectory = ":c\\";
            openFileDialog.Filter = "ssc files (*.ssc)|*.ssc|all files (*.*|*.*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FileName = "";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Name = openFileDialog.FileName;
                MessageBox.Show("Sucsessfully opened the file" + "\r\n", Name);
                filecontent = File.ReadAllText(Name);

            }

            InstrumentConfigs = filecontent.Split(';');
            textBoxTag.Text = InstrumentConfigs[0];
            textBoxLRV.Text = InstrumentConfigs[1];
            textBoxURV.Text = InstrumentConfigs[2];
            textBoxAL.Text = InstrumentConfigs[3];
            textBoxAH.Text = InstrumentConfigs[4];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < InstrumentConfigs.Length; i++)
            {
                {
                    switch (i)
                    {
                        case 0:
                            if (tagNameTextBox.Text == "")
                            {
                                MessageBox.Show("Tagname is required!");
                                textBoxTag.Focus();
                            }
                            break;
                        case 1:
                            if (lower_range_valueTextBox.Text == "")
                            {
                                MessageBox.Show("Lower range value is required!");
                                textBoxLRV.Focus();
                            }

                            break;
                        case 2:
                            if (upper_range_valueTextBox.Text == "")
                            {
                                MessageBox.Show("Upper range value is required!");
                                textBoxURV.Focus();
                            }

                            break;
                        case 3:
                            if (alarm_LowTextBox.Text == "")
                            {
                                MessageBox.Show("Alarm low value is required!");
                                textBoxAL.Focus();
                            }
                            break;
                        case 4:
                            if (alarm_highTextBox.Text == "")
                            {
                                MessageBox.Show("Alarm high value is required!");
                                textBoxAH.Focus();
                            }

                            break;


                        default:
                            InstrumentConfigs[i] = tagNameTextBox.Text;
                            InstrumentConfigs[i] = lower_range_valueTextBox.Text;
                            InstrumentConfigs[i] = upper_range_valueTextBox.Text;
                            InstrumentConfigs[i] = alarm_LowTextBox.Text;
                            InstrumentConfigs[i] = alarm_highTextBox.Text;


                            break;
                    }



                }
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            {

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {

                    File.WriteAllText(saveFileDialog.FileName, string.Join(";", InstrumentConfigs));

                }
            }

        }

        private void labelTag_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("The name of the device", labelTag);
        }

        private void labelLRV_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("The lower value range of the device", labelLRV);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxTag.Text = "";
            textBoxLRV.Text = "";
            textBoxURV.Text = "";
            textBoxAH.Text = "";
            textBoxAL.Text = "";
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine(textBoxSend.Text);
                textBoxSend.Clear();
            }



        }

        private void buttonReceive_Click(object sender, EventArgs e)
        {

            textBoxReceive.Text = serialPort1.ReadLine();
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            timerChartRaw.Enabled = true;
            timerStatus.Enabled = false;

        }

        private void timerReceive_Tick(object sender, EventArgs e)
        {
            if (serialPort1.BytesToRead > 0)
            {
                string availableData = "";
                availableData += serialPort1.ReadExisting().ToString();


                string[] analogReadings = availableData.Split(';');



                if (analogReadings.Length == 1)
                {
                    string valuetodb = analogReadings[0];
                    aI_LOGBindingSource.AddNew();
                    aI_LOGBindingSource.MoveLast();
                    valueTextBox.Text = valuetodb;
                    instrument_Log_IdTextBox.Text = instrument_Log_IdTextBox2.Text;
                    

                    string datetime = DateTime.Now.ToString();

                    timeDateTimePickerAILOG.Text = datetime;
                    aI_LOGBindingSource.EndEdit();
                    this.aI_LOGTableAdapter.Update(this.sOFTSENSECONF_DATABASE_FINALDataSet.AI_LOG);

                    if (buttonstopgraph.Visible == true)
                    {
                        chartPoints.Series[0].Points.AddXY(DateTime.Now, valuetodb);
                    }
                    

                }
            }
            timerReceive.Enabled = false;
            if (Sendingdata == "Raw")
            {
                timerChartRaw.Enabled = true;
            }
            else
                timerChartScaled.Enabled = true;

        }

        private void timerChart_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("readraw");
                timerReceive.Enabled = true;
                timerChartRaw.Enabled = false;
                Sendingdata = "Raw";
            }
        }

        private void buttonSendValues_Click(object sender, EventArgs e)
        {
            FormPassword f2 = new FormPassword();
            f2.Show();
            string writeString;
            writeString = "writeconf>" + passp + ">" + string.Join(";", InstrumentConfigs);
            serialPort1.WriteLine(writeString);




        }

        private void buttonScaled_Click(object sender, EventArgs e)
        {
            timerChartScaled.Enabled = true;
            timerStatus.Enabled = false;
        }

        private void timerChartScaled_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("readscaled");
                timerReceive.Enabled = true;
                timerChartScaled.Enabled = false;
                Sendingdata = "Scaled";
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timerChartScaled.Enabled = false;
            timerChartRaw.Enabled = false;
            timerStatus.Enabled = true;
        }

        private void buttonClearV_Click(object sender, EventArgs e)
        {
            chartPoints.Series[0].Points.Clear();
        }

        private void buttonRetrieve_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("readconf");
                var Instrumentdata = string.Empty;
                Instrumentdata = serialPort1.ReadLine();
                InstrumentValues = Instrumentdata.Split(';');
                tagNameTextBox.Text = InstrumentValues[0];
                lower_range_valueTextBox.Text = InstrumentValues[1];
                upper_range_valueTextBox.Text = InstrumentValues[2];
                alarm_LowTextBox.Text = InstrumentValues[3];
                alarm_highTextBox.Text = InstrumentValues[4];
            }
        }



        private void timerStatus_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("readstatus");
                var Flagnumber = string.Empty;
                Flagnumber = serialPort1.ReadLine();
                if (Flagnumber.Length == 2)
                {
                    int result = Int32.Parse(Flagnumber);
                    if (result == 0)
                    {
                        textBoxConnectionP2.Text = "OK";
                    }
                    if (result == 1)
                    {
                        textBoxConnectionP2.Text = "Fail";
                    }
                    if (result == 2)
                    {
                        textBoxConnectionP2.Text = "Alarml";
                    }
                    if (result == 3)
                    {
                        textBoxConnectionP2.Text = "Alarmh";
                    }
                }


            }
        }

        private void ComboBoxPorts_MouseHover(object sender, EventArgs e)
        {
            toolStripLabel1.Text = "Comport";
        }

        private void ComboBoxBaud_Enter(object sender, EventArgs e)
        {
            toolStripLabel1.Text = "Bitrate";
        }

        private void radioButtonConnected_MouseHover(object sender, EventArgs e)
        {
            toolStripLabel1.Text = "Connection Status";
        }

        private void labelURV_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("The upper range value", labelURV);
        }

        private void labelAL_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("the lower alarm value", labelAL);
        }

        private void labelAH_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("The upper alarm value", labelAH);
        }

        private void buttonLoad_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Load";
        }

        private void textBoxLRV_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && textBoxLRV.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;

            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)

            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid number");
            }
        }

        private void textBoxAL_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && textBoxLRV.Text.IndexOf('.') != -2)
            {
                e.Handled = true;
                return;

            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)

            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid number");
            }

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Update";
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Save file";
        }

        private void buttonClear_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Clear values";
        }

        private void buttonRetrieve_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Retrieve data from the instrument";
        }

        private void buttonSendValues_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Send values to the instrument";
        }

        private void textBoxTag_Enter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Tagname";
        }

        private void textBoxLRV_Enter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "The lower range value";
        }

        private void textBoxAL_Enter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "The lower alarm value";
        }

        private void textBoxAH_Enter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "The upper alarm value";
        }

        private void textBoxURV_Enter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "The upper range value";
        }

        private void textBoxSend_Enter(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "Input";
        }



        private void radioButtonConnected_MouseClick(object sender, MouseEventArgs e)
        {
            radioButtonConnected.Checked = false;
        }



        private void dAUBindingNavigatorSaveItem_Click_7(object sender, EventArgs e)
        {
            this.Validate();
            this.dAUBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sOFTSENSECONF_DATABASE_FINALDataSet);

        }

        private void comboBoxFindDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFindDevice.SelectedIndex > -1)
            {
                try
                {
                    int DAU_IdFilter = Convert.ToInt32(comboBoxFindDevice.SelectedValue.ToString());
                    dAUTableAdapter.FillByDAU_Id(this.sOFTSENSECONF_DATABASE_FINALDataSet.DAU, DAU_IdFilter);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("ERROR!" + ex);
                }


            }
        }

        private void textBoxLRV_TextChanged(object sender, EventArgs e)
        {
            if (lower_range_valueTextBox.Text == textBoxLRV.Text)
            {
                textBoxMatch.Text = "OK";
            }
            else
                textBoxMatch.Text = "Not1 matching!";
        }

        private void textBoxURV_TextChanged(object sender, EventArgs e)
        {
            if (upper_range_valueTextBox.Text == textBoxURV.Text)
            {
                textBoxMatch.Text = "OK";
            }
            else
                textBoxMatch.Text = "Not2 matching!";

        }

        private void textBoxAL_TextChanged(object sender, EventArgs e)
        {
            if (alarm_LowTextBox.Text == textBoxAL.Text)
            {
                textBoxMatch.Text = "OK";
            }
            else
                textBoxMatch.Text = "Not3 matching!";

        }

        private void textBoxAH_TextChanged(object sender, EventArgs e)
        {
            string ah = textBoxAH.Text.ToString();
            textBoxAH.Text = ah.Replace('\r', ' ');
            if (alarm_highTextBox == textBoxAH)
            {
                textBoxMatch.Text = "OK";
            }
            else
                textBoxMatch.Text = "Not4 matching!";
        }

        private void tabPageConfiguration_Enter(object sender, EventArgs e)
        {
            int filterDAU = Convert.ToInt32(comboBoxFindDevice.SelectedValue.ToString());
            this.iNSTRUMENTtoComboBoxTableAdapter.FillDAU_ID(this.sOFTSENSECONF_DATABASE_FINALDataSet.INSTRUMENTtoComboBox, filterDAU);
            comboBoxFindInstrument.DisplayMember = "TagName";
            comboBoxFindInstrument.ValueMember = "TagName";
            comboBoxFindInstrument.DataSource = sOFTSENSECONF_DATABASE_FINALDataSet.INSTRUMENTtoComboBox;
            comboBoxFindInstrument.Text = tagNameTextBox.Text;
            
        }

        private void comboBoxFindInstrument_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFindInstrument.SelectedIndex > -1)
            {
                try
                {
                    string TagNameFilter = comboBoxFindInstrument.SelectedValue.ToString();
                    iNSTRUMENTTableAdapter.FillByInstrument(this.sOFTSENSECONF_DATABASE_FINALDataSet.INSTRUMENT, TagNameFilter);

                }
                catch (Exception ex)
                {

                    MessageBox.Show("ERROR!" + ex);
                }


            }
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            dAU_IdTextBox.Enabled = true;
            descriptionTextBox.Enabled = true;
            comboBoxAREA_DAU.Enabled = true;
            comboBoxCategory_DAU.Enabled = true;
            comboBoxCommunication_DAU.Enabled = true;
            comboBoxModel_DAU.Enabled = true;
            comboBoxManu_DAU.Enabled = true;
            cOMPortTextBox.Enabled = true;
            bAUDRateTextBox.Enabled = true;
            comboBoxRDC_DAU.Enabled = true;
            configuration_edit_dateDateTimePicker.Enabled = true;
            comboBoxFindDevice.Text = "";
            comboBoxFindDevice.Enabled = false;
            buttonNEW.Enabled = false;
            buttonChange.Enabled = false;
        }

        private void buttonDAU_Save_Click(object sender, EventArgs e)
        {
            buttonNEW.Enabled = true;
            buttonChange.Enabled = true;
            dAU_IdTextBox.Enabled = false;
            descriptionTextBox.Enabled = false;
            comboBoxAREA_DAU.Enabled = false;
            comboBoxCategory_DAU.Enabled = false;
            comboBoxCommunication_DAU.Enabled = false;
            comboBoxModel_DAU.Enabled = false;
            comboBoxManu_DAU.Enabled = false;
            cOMPortTextBox.Enabled = false;
            bAUDRateTextBox.Enabled = false;
            comboBoxRDC_DAU.Enabled = false;
            configuration_edit_dateDateTimePicker.Enabled = false;
            dAUBindingSource.EndEdit();
            this.dAUTableAdapter.Update(this.sOFTSENSECONF_DATABASE_FINALDataSet.DAU);

            
            comboBoxFindDevice.Enabled = true;
            comboBoxFindDevice.Text = descriptionTextBox.Text;
        }

        private void buttonNEW_Click(object sender, EventArgs e)
        {
            buttonNEW.Enabled = false;
            buttonChange.Enabled = false;
            dAU_IdTextBox.Enabled = true;
            descriptionTextBox.Enabled = true;
            comboBoxAREA_DAU.Enabled = true;
            comboBoxCategory_DAU.Enabled = true;
            comboBoxCommunication_DAU.Enabled = true;
            comboBoxModel_DAU.Enabled = true;
            comboBoxManu_DAU.Enabled = true;
            cOMPortTextBox.Enabled = true;
            bAUDRateTextBox.Enabled = true;
            comboBoxRDC_DAU.Enabled = true;
            configuration_edit_dateDateTimePicker.Enabled = true;

            dAUBindingSource.AddNew();
            dAUBindingSource.MoveLast();
        }

        private void buttonCancelDAU_Click(object sender, EventArgs e)
        {
            buttonNEW.Enabled = true;
            buttonChange.Enabled = true;
            dAU_IdTextBox.Enabled = false;
            descriptionTextBox.Enabled = false;
            comboBoxAREA_DAU.Enabled = false;
            comboBoxCategory_DAU.Enabled = false;
            comboBoxCommunication_DAU.Enabled = false;
            comboBoxModel_DAU.Enabled = false;
            comboBoxManu_DAU.Enabled = false;
            cOMPortTextBox.Enabled = false;
            bAUDRateTextBox.Enabled = false;
            comboBoxRDC_DAU.Enabled = false;

            dAU_OnlyIdDesBindingSource.CancelEdit();
            comboBoxFindDevice.Enabled = true;
            comboBoxFindDevice.Text = descriptionTextBox.Text;

        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            if (comboBoxFindInstrument.SelectedIndex > -1)
            {
                try
                {
                    tagNameTextBox1.Text = tagNameTextBox.Text;
                    
                }
                catch (Exception ex)
                {

                    MessageBox.Show("ERROR!" + ex);
                }


            }
        }



        private void buttonConnectFromDB_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = "COM" + cOMPortTextBox.Text;
            serialPort1.BaudRate = Convert.ToInt32(bAUDRateTextBox.Text);
            serialPort1.Open();
            if (serialPort1.IsOpen == true)
            {
                MessageBox.Show("Successfully Connected To the Instrument");
                pictureBoxCONNECTED.Visible = true;
                pictureBoxDisconnected.Visible = false;
                buttonRetrieve.Enabled = true;
                buttonUpdate.Enabled = true;
                buttonConnectFromDB.Visible = false;
                buttonDisconnectInstrument.Visible = true;
                
                pictureBox1.Visible = true;
                pictureBoxDisconnected2.Visible = false;
                pictureBoxDisconnected3.Visible = false;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                buttonSendValuesToInstrument.Enabled = true;
                buttonReceive.Enabled = true;
                buttonSendValues.Enabled = true;
            }
        }



        private void buttonDisconnectInstrument_Click_1(object sender, EventArgs e)
        {
            serialPort1.Close();
            if (serialPort1.IsOpen == false)
            {
                pictureBoxDisconnected.Visible = true;
                pictureBoxCONNECTED.Visible = false;
                buttonConnectFromDB.Visible = true;
                buttonDisconnectInstrument.Visible = false;
                MessageBox.Show("Disconnected!");
                pictureBoxDisconnected2.Visible = true;
                pictureBoxDisconnected3.Visible = true;
                pictureBoxCONNECTED.Visible = false;

            }
        }



        private void buttonGraphstart_Click(object sender, EventArgs e)
        {
            timerChartRaw.Enabled = true;
            timerStatus.Enabled = false;
            chartPoints.Visible = true;
            buttonstopgraph.Visible = true;

        }

        private void buttonstopgraph_Click(object sender, EventArgs e)
        {
            buttonstopgraph.Visible = false;
            
        }

        private void tabPageCommand_Enter(object sender, EventArgs e)
        {
            

            if (comboBoxFindInstrument.SelectedIndex > -1)
            {
                try
                {
                    tagNameTextBox1.Text = tagNameTextBox.Text;
                    


                }
                catch (Exception ex)
                {

                    MessageBox.Show("ERROR!" + ex);
                }
            }
        }


        private void comboBoxFindingDeviceRDC_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBoxFindingDeviceRDC.SelectedIndex > -1)
            {
                try
                {
                    int RDC_idFilter = Convert.ToInt32(comboBoxFindingDeviceRDC.SelectedValue.ToString());
                    rDCTableAdapter.FillByRDCID(this.sOFTSENSECONF_DATABASE_FINALDataSet.RDC, RDC_idFilter);

                    
                }
                catch (Exception ex)
                {

                    MessageBox.Show("ERROR!" + ex);
                }
                int filterRDC = Convert.ToInt32(comboBoxFindingDeviceRDC.SelectedValue.ToString());
                this.dAU_OnlyIdDesTableAdapter.FillByrdc(this.sOFTSENSECONF_DATABASE_FINALDataSet.DAU_OnlyIdDes, filterRDC);
                comboBoxFindDevice.DisplayMember = "Description";
                comboBoxFindDevice.ValueMember = "DAU_Id";
                comboBoxFindDevice.DataSource = sOFTSENSECONF_DATABASE_FINALDataSet.DAU_OnlyIdDes;
                comboBoxFindDevice.Text = descriptionTextBox.Text;


            }
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            listBoxDBreadings.Visible = true;
        }

        private void buttonSending_Click(object sender, EventArgs e)
        {
            textBoxSend.Visible = true;
            textBoxReceive.Visible = true;
            buttonSendValuesToInstrument.Visible = true;
            buttonReceive.Visible = true;
            
        }

        private void buttonSendValuestodb_Click(object sender, EventArgs e)
        {
            instrument_Measure_IdBindingSource.AddNew();
            instrument_Measure_IdBindingSource.MoveLast();
            tagNameTextBox2.Text = tagNameTextBox.Text;
            instrument_Measure_IdBindingSource.EndEdit();
            this.instrument_Measure_IdTableAdapter.Update(this.sOFTSENSECONF_DATABASE_FINALDataSet.Instrument_Measure_Id);
            buttonAnalogInn.Visible = true;
            buttonAnalogout.Visible = true;
            buttonDigitalInn.Visible = true;
            buttonDigitalout.Visible = true;

        



        }

        private void buttonNEWRDC_Click(object sender, EventArgs e)
        {
            buttonNEWRDC.Enabled = false;
            buttonChangeRDC.Enabled = false;


            descriptionTextBoxRDC.Enabled = true;
            comboBoxAReaRDC.Enabled = true;
            comboBoxMOdelRDC.Enabled = true;
            comboBoxManuRDC.Enabled = true;
            configuration_Edit_DateDateTimePickerRDC.Enabled = true;

            rDCBindingSource.AddNew();
            rDCBindingSource.MoveLast();
        }

        private void buttonChangeRDC_Click(object sender, EventArgs e)
        {
            buttonChangeRDC.Enabled = false;
            buttonNEWRDC.Enabled = false;
            descriptionTextBoxRDC.Enabled = true;
            comboBoxAReaRDC.Enabled = true;
            comboBoxMOdelRDC.Enabled = true;
            comboBoxManuRDC.Enabled = true;
            configuration_Edit_DateDateTimePickerRDC.Enabled = true;
            comboBoxFindingDeviceRDC.Text = "";
        }

        private void buttonSaveRDC_Click(object sender, EventArgs e)
        {
            buttonChangeRDC.Enabled = true;
            buttonNEWRDC.Enabled = true;
            descriptionTextBoxRDC.Enabled = false;
            comboBoxAReaRDC.Enabled = false;
            comboBoxMOdelRDC.Enabled = false;
            comboBoxManuRDC.Enabled = false;
            configuration_Edit_DateDateTimePickerRDC.Enabled = false;



            rDCBindingSource.EndEdit();
            this.rDCTableAdapter.Update(this.sOFTSENSECONF_DATABASE_FINALDataSet.RDC);

            comboBoxFindingDeviceRDC.Text = descriptionTextBoxRDC.Text;
            comboBoxFindingDeviceRDC.Enabled = true;





        }

        private void buttonCancelRDC_Click(object sender, EventArgs e)
        {
            buttonNEWRDC.Enabled = true;
            buttonChangeRDC.Enabled = true;
            buttonSaveRDC.Enabled = true;


            descriptionTextBoxRDC.Enabled = false;
            comboBoxAReaRDC.Enabled = false;
            comboBoxMOdelRDC.Enabled = false;
            comboBoxManuRDC.Enabled = false;
            configuration_Edit_DateDateTimePickerRDC.Enabled = false;
            rDCBindingSource.CancelEdit();


            comboBoxFindingDeviceRDC.Enabled = true;
            comboBoxFindingDeviceRDC.Text = descriptionTextBoxRDC.Text;
        }

        private void frequencyTextBox_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (frequencyTextBox.Text.Length > 0)
                {
                    int frequency = Convert.ToInt32(frequencyTextBox.Text);
                    timerChartRaw.Interval = frequency;
                }
                else
                    timerChartRaw.Enabled = false;
                    

            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR!" + ex);
            }
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

            comboBoxAreaInstrument.Enabled = false;
            comboBoxCOMMInstrument.Enabled = false;
            comboBoxDAUinstrument.Enabled = false;
            comboBoxInnputOutputInstrument.Enabled = false;
            comboBoxModelinstrument.Enabled = false;
            comboBoxManu_DAU.Enabled = false;
            comboBoxManuInstrument.Enabled = false;
            frequencyTextBox.Enabled = false;
            configuration_Edit_DateDateTimePickerInstrument.Enabled = false;
            descriptionTextBoxInstrument.Enabled = false;
            comboBoxCategoryInstrument.Enabled = false;
            tagNameTextBox.Enabled = false;
            upper_range_valueTextBox.Enabled = false;
            lower_range_valueTextBox.Enabled = false;
            alarm_highTextBox.Enabled = false;
            alarm_LowTextBox.Enabled = false;
            buttonChangeInstrument.Enabled = true;
            buttonCancelInstrument.Enabled = true;
            buttonNEWInstrument.Enabled = true;

            iNSTRUMENTBindingSource.EndEdit();
            this.iNSTRUMENTTableAdapter.Update(sOFTSENSECONF_DATABASE_FINALDataSet.INSTRUMENT);
            comboBoxFindInstrument.Text = tagNameTextBox.Text;

            comboBoxFindInstrument.Text = tagNameTextBox.Text;
            comboBoxFindInstrument.Enabled = true;

        }

        private void buttonNEWInstrument_Click(object sender, EventArgs e)
        {
            comboBoxAreaInstrument.Enabled = true;
            comboBoxCOMMInstrument.Enabled = true;
            comboBoxDAUinstrument.Enabled = true;
            comboBoxInnputOutputInstrument.Enabled = true;
            comboBoxModelinstrument.Enabled = true;
            comboBoxManu_DAU.Enabled = true;
            frequencyTextBox.Enabled = true;
            configuration_Edit_DateDateTimePickerInstrument.Enabled = true;
            descriptionTextBoxInstrument.Enabled = true;
            comboBoxCategoryInstrument.Enabled = true;
            comboBoxManuInstrument.Enabled = true;
            tagNameTextBox.Enabled = true;
            upper_range_valueTextBox.Enabled = true;
            lower_range_valueTextBox.Enabled = true;
            alarm_highTextBox.Enabled = true;
            alarm_LowTextBox.Enabled = true;
            buttonChangeInstrument.Enabled = false;





            iNSTRUMENTBindingSource.AddNew();
            iNSTRUMENTBindingSource.MoveLast();

            comboBoxFindInstrument.Enabled = false;
            comboBoxFindInstrument.Text = "";
        }

        private void buttonCancelInstrument_Click(object sender, EventArgs e)
        {
            comboBoxAreaInstrument.Enabled = false;
            comboBoxCOMMInstrument.Enabled = false;
            comboBoxDAUinstrument.Enabled = false;
            comboBoxInnputOutputInstrument.Enabled = false;
            comboBoxModelinstrument.Enabled = false;
            comboBoxManu_DAU.Enabled = false;
            frequencyTextBox.Enabled = false;
            configuration_Edit_DateDateTimePickerInstrument.Enabled = false;
            descriptionTextBoxInstrument.Enabled = false;
            comboBoxCategoryInstrument.Enabled = false;
            tagNameTextBox.Enabled = false;
            upper_range_valueTextBox.Enabled = false;
            lower_range_valueTextBox.Enabled = false;
            alarm_highTextBox.Enabled = false;
            alarm_LowTextBox.Enabled = false;
            buttonChangeInstrument.Enabled = true;
            buttonCancelInstrument.Enabled = true;
            buttonNEWInstrument.Enabled = true;



            iNSTRUMENTBindingSource.CancelEdit();
            comboBoxFindInstrument.Enabled = true;
            comboBoxFindInstrument.Text = tagNameTextBox.Text;

        }

        private void buttonChangeInstrument_Click(object sender, EventArgs e)
        {
            comboBoxAreaInstrument.Enabled = true;
            comboBoxCOMMInstrument.Enabled = true;
            comboBoxDAUinstrument.Enabled = true;
            comboBoxInnputOutputInstrument.Enabled = true;
            comboBoxModelinstrument.Enabled = true;
            comboBoxManu_DAU.Enabled = true;
            frequencyTextBox.Enabled = true;
            configuration_Edit_DateDateTimePickerInstrument.Enabled = true;
            descriptionTextBoxInstrument.Enabled = true;
            comboBoxCategoryInstrument.Enabled = true;
            comboBoxManuInstrument.Enabled = true;
            tagNameTextBox.Enabled = true;
            comboBoxManuInstrument.Enabled = true;
            upper_range_valueTextBox.Enabled = true;
            lower_range_valueTextBox.Enabled = true;
            alarm_highTextBox.Enabled = true;
            alarm_LowTextBox.Enabled = true;
            buttonChangeInstrument.Enabled = false;
            buttonNEWInstrument.Enabled = false;
            comboBoxFindInstrument.Enabled = false;
            comboBoxFindInstrument.Text = "";
        }

        private void buttonSTopsendingdata_Click(object sender, EventArgs e)
        {
            timerChartRaw.Enabled = false;
            buttonSTopsendingdata.Enabled = false;
            buttonSTopsendingdata.Visible = false;
            buttonSendValuestodb.Enabled = true;
            buttonSendValuestodb.Visible = true;
        }

        private void buttonAnalog_Click(object sender, EventArgs e)
        {
            timerChartRaw.Enabled = true;
            buttonAnalogInn.Visible = false;
            buttonAnalogout.Visible = false;
            buttonDigitalInn.Visible = false;
            buttonDigitalout.Visible = false;
            buttonSTopsendingdata.Enabled = true;
            buttonSTopsendingdata.Visible = true;
            buttonSendValuestodb.Visible = false;
        }


        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
