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
    public partial class InventoryLowStock : Form
    {
        private DatabaseFunctions _dbFuncs;
        private DataTable _tableData;
        public InventoryLowStock()
        {
            InitializeComponent();
        }

        private void loadGridData()
        {
            string query = "SELECT pharmacy_db.ProductStock.product_id AS 'Identifier', brand_name AS 'Name', stock_available AS 'Stock Available', stock_threshold AS 'Stock Threshold' FROM pharmacy_db.ProductStock JOIN pharmacy_db.Product ON pharmacy_db.ProductStock.product_id=pharmacy_db.Product.product_id WHERE use_threshold=true && stock_available < stock_threshold;";

            MySqlCommand cmdDatabase = _dbFuncs.CommandFromSQLStatement(query);

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

        private void InventoryLowStock_Load(object sender, EventArgs e)
        {
            //Initialise class to help access the database
            _dbFuncs = new DatabaseFunctions();

            loadGridData();
        }
    }
}
