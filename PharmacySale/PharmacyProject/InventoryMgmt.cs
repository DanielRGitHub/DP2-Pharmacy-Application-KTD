using MySql.Data.MySqlClient;
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
        private DataTable _tableData;
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
            string constring = "datasource=localhost;port=3306;username=root;password=sample1";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand("SELECT pharmacy_db.ProductStock.product_id AS 'Product ID', brand_name AS 'Product Name', stock_available AS 'Stock Available', stock_threshold AS 'Stock Threshold' FROM pharmacy_db.ProductStock JOIN pharmacy_db.Product ON pharmacy_db.ProductStock.product_id=pharmacy_db.Product.product_id;", conDatabase);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                _tableData = new DataTable();
                sda.Fill(_tableData);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = _tableData;
                
                sda.Update(_tableData);

                dataGridView1.DataSource = _tableData;

                // -- EDIT BUTTON --

                DataGridViewButtonColumn dcButton = new DataGridViewButtonColumn();
                //set column header
                dcButton.HeaderText = "Edit";
                dcButton.Text = "Edit";
                //make buttons have header in the button text
                dcButton.UseColumnTextForButtonValue = true;
                //edit tooltip
                dcButton.ToolTipText = "Edit products inventory data";



                //remove row header (first column)
                dataGridView1.RowHeadersVisible = false;

                //remove bottom editing row
                dataGridView1.AllowUserToAddRows = false;

                //add the column
                dataGridView1.Columns.Add(dcButton);

                //autosize columns
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

                //define row size
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                dataGridView1.AllowUserToResizeRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_VisibleChanged(object sender, EventArgs e)
        {
            //set static size
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Height = 25;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                //get row index

                //create the form

                //set form product id variable relative to row index

                //show the form so user can edit that particular products information

                MessageBox.Show("Hello " + e.RowIndex);
            }
        }
    }
}
