using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH_Winform_W3
{
    public partial class Second_Windows_Form : Form
    {
        public Second_Windows_Form()
        {
            InitializeComponent();
        }
        private void Second_Windows_Form_Load(object sender, EventArgs e)
        {
            radioButtonRed.Checked = false;
            radioButtonGreen.Checked = false;
            radioButtonBlue.Checked = false;
            radioButtonYellow.Checked = false;
            radioButtonPurple.Checked = false;
            radioButtonmerah.Checked = false;
            radioButtonhijau.Checked = false;
            radioButtonbiru.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMainWindow formsatu = new FormMainWindow();
            if (radioButtonRed.Checked == true)
            {
                formsatu.BackColor = Color.OrangeRed;
            }
            else if (radioButtonGreen.Checked == true)
            {
                formsatu.BackColor = Color.LightGreen;
            }
            else if (radioButtonBlue.Checked == true)
            {
                formsatu.BackColor = Color.LightBlue;
            }
            else if (radioButtonYellow.Checked == true)
            {
                formsatu.BackColor = Color.LightYellow;
            }
            else if (radioButtonPurple.Checked == true)
            {
                formsatu.BackColor = Color.Violet;
            }
            else
            {
                MessageBox.Show("Choose the radio buttons", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (radioButtonmerah.Checked == true)
            {
                formsatu.ForeColor = Color.OrangeRed;
            }
            else if (radioButtonbiru.Checked == true)
            {
                formsatu.ForeColor = Color.SkyBlue;
            }
            else if (radioButtonhijau.Checked == true)
            {
                formsatu.ForeColor = Color.LightGreen;
            }
            else
            {
                MessageBox.Show("Choose the radio buttons", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (checkBoxPick.Checked == true && checkBoxTerms.Checked == true)
            {
                button1.Enabled = true;
                formsatu.Show();
            }
            else
            {
                button1.Enabled = false;
            }
        }
        public void Self(string name, string artist)
        {
            labelSelf.Text = "Hi, my name is " + name + " my favorite artist is " + artist;
        }
        private void labelSelf_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBoxTerms_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPick.Checked == true && checkBoxTerms.Checked == true)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void checkBoxPick_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPick.Checked == true && checkBoxTerms.Checked == true)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }
    }
}
