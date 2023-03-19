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
    public partial class FormMainWindow : Form
    {
        bool nextform = false;
        public FormMainWindow()
        {
            InitializeComponent();
        }
        private void labelFavArtist_Click(object sender, EventArgs e)
        {

        }
        private void buttonNextForm_Click(object sender, EventArgs e)
        {
            Second_Windows_Form secondForm = new Second_Windows_Form();
            secondForm.Show();
            nextform = true;
            if (checkBoxTrue.Checked == true && nextform == true)
            {
                buttonSubmit.Enabled = true;
            }
        }
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            Second_Windows_Form formdua = new Second_Windows_Form();
            string nama = Convert.ToString(textBoxName.Text);
            string favorit = Convert.ToString(textBoxFavArtist.Text);
            if (nama == "" || favorit == "")
            {
                MessageBox.Show("Please enter the correct input", "WARNING", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                buttonSubmit.Enabled = false;
            }
            if (checkBoxTrue.Checked == true && nextform == true)
            {
                buttonSubmit.Enabled = true;
                formdua.Show();
                formdua.Self(nama, favorit);
            }    
        }
        private void checkBoxTrue_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTrue.Checked == true && nextform == true)
            {
                buttonSubmit.Enabled = true;
            }
            else
            {
                buttonSubmit.Enabled = false;
            }
        }
    }
}
