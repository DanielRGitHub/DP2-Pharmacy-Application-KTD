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
//Created by Blake Howe.
namespace PharmacyProject
{
    
    public partial class InventoryMgmt : Form
    {
        private DataTable _tableData;
        private DatabaseFunctions _dbFuncs;
        public InventoryMgmt()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void enterLabel_Click(object sender, EventArgs e)
        {

        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        

        private void enterInput_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (searchByCbx.Text == "ID") {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else if (searchByCbx.Text == "Name") {
                e.Handled = false;
            }
            else {
                e.Handled = true;
            }
            
        }

        private void loadGridData() {
            string defaultQuery = "SELECT pharmacy_db.ProductStock.product_id AS 'Identifier', brand_name AS 'Name', stock_available AS 'Stock Available', stock_threshold AS 'Stock Threshold' FROM pharmacy_db.ProductStock JOIN pharmacy_db.Product ON pharmacy_db.ProductStock.product_id=pharmacy_db.Product.product_id";
            string queryToUse = "";
            if (txtEnterInput.Text != "")
            {
                if (searchByCbx.Text == "ID")
                {
                    queryToUse = defaultQuery + " WHERE pharmacy_db.ProductStock.product_id LIKE " + Convert.ToInt32(txtEnterInput.Text);
                }
                else if (searchByCbx.Text == "Name")
                {
                    queryToUse = defaultQuery + " WHERE brand_name LIKE '%" + txtEnterInput.Text+"%'";
                }
            }
            else {
                queryToUse = defaultQuery;
            }

            queryToUse += ";";

            MySqlCommand cmdDatabase = _dbFuncs.CommandFromSQLStatement(queryToUse);

            try
            {
                
                dataGridView1.Refresh();
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                _tableData = new DataTable();
                sda.Fill(_tableData);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = _tableData;

                sda.Update(_tableData);

                dataGridView1.DataSource = _tableData;

                



                //remove row header (first column)
                dataGridView1.RowHeadersVisible = false;

                //remove bottom editing row
                dataGridView1.AllowUserToAddRows = false;

                //add the column if it doesnt exist already in table
                if (!dataGridView1.Columns.Contains("Edit"))
                {
                    
                }

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

        private void addEditBtnToGrid() {
            // -- EDIT BUTTON --

            DataGridViewButtonColumn dcButton = new DataGridViewButtonColumn();
            //set column header
            dcButton.HeaderText = "Edit";
            dcButton.Text = "Edit";
            //make buttons have header in the button text
            dcButton.UseColumnTextForButtonValue = true;
            //edit tooltip
            dcButton.ToolTipText = "Edit products inventory data";
            dataGridView1.Columns.Add(dcButton);
        }

        private void InventoryMgmt_Load(object sender, EventArgs e)
        {
            //Initialise class to help access the database
            _dbFuncs = new DatabaseFunctions();

            //load up the grid view
            loadGridData();

            //add edit column that can invoke editing the product inventory data
            addEditBtnToGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                
                //create the form
                InventoryMgmt_EditView editView = new InventoryMgmt_EditView();

                //set form product id variable relative to row index
                editView._productId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Identifier"].Value);

                //show the form so user can edit that particular products information
                editView.ShowDialog();
            }
        }

        private void txtEnterInput_TextChanged(object sender, EventArgs e)
        {
            loadGridData();
        }

        private void searchByCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            //set the enter label relative to the selected combobox item
            var result = searchByCbx.Text;
            if (result != "")
            {
                enterLabel.Text = "Enter " + result + ":";
            }
        }
    }
}
