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


namespace SoftSensConf
{
    public partial class SoftSensConf : Form
    {
        public SoftSensConf()
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
            // TODO: This line of code loads data into the 'softsenseconfDataSet.DAUonlyID_DES' table. You can move, or remove it, as needed.
            this.dAUonlyID_DESTableAdapter.Fill(this.softsenseconfDataSet.DAUonlyID_DES);
            // TODO: This line of code loads data into the 'softsenseconfDataSet.DAUonlyID_DES' table. You can move, or remove it, as needed.
            this.dAUonlyID_DESTableAdapter.Fill(this.softsenseconfDataSet.DAUonlyID_DES);
            // TODO: This line of code loads data into the 'softsenseconfDataSet.DAU' table. You can move, or remove it, as needed.
            this.dAUTableAdapter.Fill(this.softsenseconfDataSet.DAU);
            InstrumentConfigs = new string[5];
            InstrumentValues = new string[5];
            Flagnumber = new string[1];
            if (serialPort1.IsOpen == false)
            {
                buttonSend.Enabled = false;
                buttonSendValues.Enabled = false;
                buttonRetrieve.Enabled = false;
                buttonReceive.Enabled = false;
                buttonRaw.Enabled = false;
                buttonScaled.Enabled = false;
                buttonDisconnect.Enabled = false;
                textBoxConnectionP1.Text = "Disconnected";
                textBoxConnectionP1.ForeColor = Color.Red;
                textBoxConnectionP2.Text = "Disconnected";
                textBoxConnectionP2.ForeColor = Color.Red;
                textBoxConnectionP3.Text = "Disconnected";
                textBoxConnectionP3.ForeColor = Color.Red;
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
            toolStripStatusLabel.Text = "Comport";
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
                        textBoxConnectionP3.Text = "Connected";
                        textBoxConnectionP3.ForeColor = Color.Green;
                        buttonSend.Enabled = true;
                        buttonSendValues.Enabled = true;
                        buttonRetrieve.Enabled = true;
                        buttonReceive.Enabled = true;
                        buttonRaw.Enabled = true;
                        buttonScaled.Enabled = true;
                        buttonDisconnect.Enabled = true;
                        timerStatus.Enabled = true;


                    }


                }
                else
                {
                    MessageBox.Show("Select the Comport and Bitrate");

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
            textBoxConnectionP3.Text = "Disconnected";
            textBoxConnectionP3.ForeColor = Color.Red;



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonConnect_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Connect";
        }

        private void tabPageConnection_Enter(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Ready";
        }

        private void buttonDisconnect_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Disconnect";
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
                    listBoxReading.Items.Add(analogReadings[0]);
                 
                    chartPoints.Series[0].Points.AddXY((listBoxReading.Items.Count - 1), (listBoxReading.Items[listBoxReading.Items.Count - 1]));
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
            writeString = "writeconf>" + passp + ">" +string.Join(";", InstrumentConfigs);
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
            listBoxReading.Items.Clear();
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


            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                
                {

                    StreamWriter writer = new StreamWriter(saveFileDialog.FileName);

                    for (int i = 0; i < listBoxReading.Items.Count; i++)
                    {
                        writer.WriteLine(i);
                        writer.WriteLine((string)listBoxReading.Items[i]);
                    }
                    writer.Close();
                    
                   
                }
                

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
                        textBoxStatus.Text = "OK";
                    }
                    if (result == 1)
                    {
                        textBoxStatus.Text = "Fail";
                    }
                    if (result == 2)
                    {
                        textBoxStatus.Text = "Alarml";
                    }
                    if (result == 3)
                    {
                        textBoxStatus.Text = "Alarmh";
                    }
                }

                
            }
        }

        private void ComboBoxPorts_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Comport";
        }

        private void ComboBoxBaud_Enter(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Bitrate";
        }

        private void radioButtonConnected_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Connection Status";
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
            toolTip.Show("View the raw data in graph", buttonRaw);
        }

        private void buttonScaled_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("View the scaled data in graph", buttonRaw);
        }

        private void buttonStop_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("stop the live graph", buttonStop);
        }

        private void buttonClearV_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Clear the values", buttonClearV);
        }

        private void buttonSavetofile_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Save the live data to file", buttonSavetofile);
        }


        private void tabInstrument_Enter(object sender, EventArgs e)
        {
            this.dAUTableAdapter.Fill(this.softsenseconfDataSet.DAU);
            comboBoxFindDevice.DisplayMember = "Description";
            comboBoxFindDevice.ValueMember = "DAU_Id";
            comboBoxFindDevice.DataSource = softsenseconfDataSet.DAU;
        }

    }
}
