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






            int filterRDC = Convert.ToInt32(comboBoxFindingDeviceRDC.SelectedValue.ToString());
            this.dAU_OnlyIdDesTableAdapter.FillbyDAU_ID(this.sOFTSENSECONF_DATABASE_FINALDataSet.DAU_OnlyIdDes, filterRDC);
            comboBoxFindDevice.DisplayMember = "Description";
            comboBoxFindDevice.ValueMember = "DAU_Id";
            comboBoxFindDevice.DataSource = sOFTSENSECONF_DATABASE_FINALDataSet.DAU_OnlyIdDes;





            //comboBoxFindingDeviceRDC.DisplayMember = "Description";
            //comboBoxFindingDeviceRDC.ValueMember = "DAU_Id";
            // comboBoxFindingDeviceRDC.DataSource = 



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
            this.dAU_OnlyIdDesTableAdapter.FillbyDAU_ID(this.sOFTSENSECONF_DATABASE_FINALDataSet.DAU_OnlyIdDes, filterRDC);
            // TODO: This line of code loads data into the 'sOFTSENSECONF_DATABASE_FINALDataSet.INSTRUMENT' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'sOFTSENSECONF_DATABASE_FINALDataSet.DAU' table. You can move, or remove it, as needed.
            this.dAUTableAdapter.Fill(this.sOFTSENSECONF_DATABASE_FINALDataSet.DAU);
            InstrumentConfigs = new string[5];
            InstrumentValues = new string[5];
            Flagnumber = new string[1];
            if (serialPort1.IsOpen == false)
            {
                buttonSend.Enabled = false;
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
                        buttonSend.Enabled = true;
                        buttonSendValues.Enabled = true;
                        buttonRetrieve.Enabled = true;
                        buttonReceive.Enabled = true;
                        buttonDisconnect.Enabled = true;
                        timerStatus.Enabled = true;


                    }


                }
                //else
                {
                    // MessageBox.Show("Select the Comport and Bitrate");

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
            //openFileDialog.Filter = "ssc files (*.ssc)|*.ssc|all files (*.*|*.*";
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
                            if (textBoxTag.Text == "")
                            {
                                MessageBox.Show("Tagname is required!");
                                textBoxTag.Focus();
                            }
                            break;
                        case 1:
                            if (textBoxLRV.Text == "")
                            {
                                MessageBox.Show("Lower range value is required!");
                                textBoxLRV.Focus();
                            }

                            break;
                        case 2:
                            if (textBoxURV.Text == "")
                            {
                                MessageBox.Show("Upper range value is required!");
                                textBoxURV.Focus();
                            }

                            break;
                        case 3:
                            if (textBoxAL.Text == "")
                            {
                                MessageBox.Show("Alarm low value is required!");
                                textBoxAL.Focus();
                            }
                            break;
                        case 4:
                            if (textBoxAH.Text == "")
                            {
                                MessageBox.Show("Alarm high value is required!");
                                textBoxAH.Focus();
                            }

                            break;


                        default:
                            InstrumentConfigs[i] = textBoxTag.Text;
                            InstrumentConfigs[i] = textBoxLRV.Text;
                            InstrumentConfigs[i] = textBoxURV.Text;
                            InstrumentConfigs[i] = textBoxAL.Text;
                            InstrumentConfigs[i] = textBoxAH.Text;


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
                    instrument_Log_IdTextBox.Text = instrument_Log_IdTextBox1.Text;
                    string datetime = DateTime.Now.ToString();
                    //textBox1.Text = datetime;
                    timeDateTimePicker.Text = datetime;
                    aI_LOGBindingSource.EndEdit();
                    this.aI_LOGTableAdapter.Update(this.sOFTSENSECONF_DATABASE_FINALDataSet.AI_LOG);



                    //valueTextBox.Text = analogReadings[0];

                    chartPoints.Series[0].Points.AddXY(DateTime.Now, valuetodb);
                    //chartPoints.Series[0].Points.AddXY((listBoxValueAI.Items.Count - 1), (listBoxValueAI.Items[listBoxReading.Items.Count - 1]));
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
                textBoxTag.Text = InstrumentValues[0];
                textBoxLRV.Text = InstrumentValues[1];
                textBoxURV.Text = InstrumentValues[2];
                textBoxAL.Text = InstrumentValues[3];
                textBoxAH.Text = InstrumentValues[4];
            }
        }

        private void buttonSavetofile_Click(object sender, EventArgs e)
        {





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

        private void labelInput_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Enter the input you want to send to the instrument", labelInput);
        }

        private void radioButtonConnected_MouseClick(object sender, MouseEventArgs e)
        {
            radioButtonConnected.Checked = false;
        }

        private void buttonRaw_MouseHover(object sender, EventArgs e)
        {
        }

        private void buttonScaled_MouseHover(object sender, EventArgs e)
        {
        }

        private void buttonStop_MouseHover(object sender, EventArgs e)
        {
        }

        private void buttonClearV_MouseHover(object sender, EventArgs e)
        {
        }

        private void buttonSavetofile_MouseHover(object sender, EventArgs e)
        {
        }

        private void listBoxReading_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dAUBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();



        }

        private void dAUBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {


        }

        private void dAUBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {


        }

        private void dAUBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {

        }

        private void dAUBindingNavigatorSaveItem_Click_4(object sender, EventArgs e)
        {

        }

        private void dAUBindingNavigatorSaveItem_Click_5(object sender, EventArgs e)
        {

        }

        private void iNSTRUMENTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void dAUBindingNavigatorSaveItem_Click_6(object sender, EventArgs e)
        {

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
                textBoxMatch.Text = "Not matching!";
        }

        private void textBoxURV_TextChanged(object sender, EventArgs e)
        {
            if (upper_range_valueTextBox.Text == textBoxURV.Text)
            {
                textBoxMatch.Text = "OK";
            }
            else
                textBoxMatch.Text = "Not matching!";

        }

        private void textBoxAL_TextChanged(object sender, EventArgs e)
        {
            if (alarm_LowTextBox.Text == textBoxAL.Text)
            {
                textBoxMatch.Text = "OK";
            }
            else
                textBoxMatch.Text = "Not matching!";

        }

        private void textBoxAH_TextChanged(object sender, EventArgs e)
        {
            if (alarm_highTextBox.Text == textBoxAH.Text)
            {
                textBoxMatch.Text = "OK";
            }
            else
                textBoxMatch.Text = "Not matching!";
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

            comboBoxFindDevice.Text = "";
            comboBoxFindDevice.Enabled = true;
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
                    //string TagNamefilterAI = comboBoxFindInstrument.SelectedValue.ToString();
                    // textBoxTAGNAME.Text = TagNamefilterAI;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("ERROR!" + ex);
                }


            }
        }

        private void valueTextBox_TextChanged(object sender, EventArgs e)
        {


        }

        private void Newtest_Click(object sender, EventArgs e)
        {

        }

        private void buttonSavetest_Click(object sender, EventArgs e)
        {
        }

        private void buttonReadAnalog_Click(object sender, EventArgs e)
        {
            //string tagname = tagNameTextBox1.Text;
            //instrument_Measure_IdBindingSource.AddNew();
            //instrument_Measure_IdBindingSource.MoveLast();
            //tagNameTextBox1.Text = tagname;
            //instrument_Measure_IdBindingSource.EndEdit();
            //this.instrument_Measure_IdTableAdapter.Update(this.sOFTSENSECONF_DATABASE_FINALDataSet.Instrument_Measure_Id);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tabControl.Visible = true;
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
                buttonConnectFromDB.Visible = false;
                buttonDisconnectInstrument.Visible = true;
                pictureBox2.Visible = true;
                pictureBox1.Visible = true;
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

            }
        }

        private void tabPageConfiguration_Click(object sender, EventArgs e)
        {

        }

        private void buttonGraphstart_Click(object sender, EventArgs e)
        {
            timerChartRaw.Enabled = true;
            timerStatus.Enabled = false;
        }

        private void buttonstopgraph_Click(object sender, EventArgs e)
        {
            timerChartScaled.Enabled = false;
            timerChartRaw.Enabled = false;
            timerStatus.Enabled = true;
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

        private void comboBoxFindingDeviceRDC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFindingDeviceRDC.SelectedIndex > -1)
            {
                try
                {
                    int RDC_IdFilter = Convert.ToInt32(comboBoxFindingDeviceRDC.SelectedValue.ToString());
                    rDCTableAdapter.FillByRDCID(this.sOFTSENSECONF_DATABASE_FINALDataSet.RDC, RDC_IdFilter);
                    

                }
                catch (Exception ex)
                {

                    MessageBox.Show("ERROR!" + ex);
                }


            }
        }
    }
}
