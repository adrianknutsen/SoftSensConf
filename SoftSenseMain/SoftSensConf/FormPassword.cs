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
    public partial class FormPassword : Form
    {
        public FormPassword()
        {
            InitializeComponent();
        }
        string passp = "superhemmelig";

        private void FormPassword_Load(object sender, EventArgs e)
        {

        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {

            if (textBoxPassword.Text == passp)
            {
                this.Hide();
                
            }
            else
                MessageBox.Show("Enter the correct Password");
                textBoxPassword.Clear();





        }
    }
}
