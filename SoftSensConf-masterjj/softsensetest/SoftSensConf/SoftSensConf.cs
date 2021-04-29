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
        string passp = "password123";
        private void Form1_Load(object sender, EventArgs e)
        {
            InstrumentConfigs = new string[5];
        }

        private void comboBoxPorts_Enter(object sender, EventArgs e)
        {
            ComboBoxPorts.Items.Clear();
            string[] comPorts = System.IO.Ports.SerialPort.GetPortNames();
            foreach (string ports in comPorts)
            {
                ComboBoxPorts.Items.Add(ports);
            }
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
            radioButtonConnected.ForeColor = Color.FromArgb(170, 205, 210);

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
            openFileDialog.Filter = "txt files (*.txt)|*.txt|all files (*.*|*.*";
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
            
           
            serialPort1.WriteLine(textBoxSend.Text);
            
            
 
 






        }

        private void buttonReceive_Click(object sender, EventArgs e)
        {

            textBoxReceive.Text = serialPort1.ReadLine();
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            timerChart.Enabled = true;
        }

        private void timerReceive_Tick(object sender, EventArgs e)
        {
            if (serialPort1.BytesToRead > 0)
            {
                string availableData = "";
                availableData += serialPort1.ReadExisting().ToString();
                availableData.Replace(";\r\n", "");
                string[] analogReadings = availableData.Split(';');
                textBox1.AppendText(availableData);
                
                if (analogReadings.Length == 4)
                {
                    
                    //listBoxVa.Items.Add(analogReadings[0]);
                    //chartPoints.Series[0].Points.AddXY(Convert.ToDouble(listBoxVa.Items.Count - 1), Convert.ToDouble(listBoxVa.Items[listBoxVa.Items.Count - 1]));
                    //listBoxVb.Items.Add(analogReadings[1]);
                    //chartPoints.Series[1].Points.AddXY(Convert.ToDouble(listBoxVb.Items.Count - 1), Convert.ToDouble(listBoxVb.Items[listBoxVb.Items.Count - 1]));
                    listBoxVab.Items.Add(analogReadings[2]);
                    chartPoints.Series[2].Points.AddXY(Convert.ToDouble(listBoxVab.Items.Count - 1), Convert.ToDouble(listBoxVab.Items[listBoxVab.Items.Count - 1]));

                }
            }
            timerReceive.Enabled = false;
            timerChart.Enabled = true;
        }

        private void timerChart_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("readanalog");
                timerReceive.Enabled = true;
                timerChart.Enabled = false;
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
    }
}
