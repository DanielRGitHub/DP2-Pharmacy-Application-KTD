using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyProject
{
    public partial class InventoryMgmt : Form
    {
        public InventoryMgmt()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //set the enter label relative to the selected combobox item
            var result = searchByCbx.Text;
            if (result != "")
            {
                enterLabel.Text = "Enter " + result + ":";
            }
        }

        private void enterLabel_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                dateFilterFromDP.Enabled = true;
                dateFilterToDP.Enabled = true;
                dateFromLabel.Enabled = true;
                dateToLabel.Enabled = true;
            }
            else
            {
                dateFilterFromDP.Enabled = false;
                dateFilterToDP.Enabled = false;
                dateFromLabel.Enabled = false;
                dateToLabel.Enabled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        

        private void enterInput_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void InventoryMgmt_Load(object sender, EventArgs e)
        {

        }
    }
}
