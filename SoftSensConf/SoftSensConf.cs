using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftSensConf
{
    public partial class SoftSensConf : Form
    {
        public SoftSensConf()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
    }
}
