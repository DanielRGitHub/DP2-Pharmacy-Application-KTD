using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PharmacyProject
{
    public partial class SearchSale : Form
    {
        DataTable dbdataset;
        public SearchSale()
        {
            InitializeComponent();
            ViewText();
            FillCombo();
        }

        void FillCombo()
        {
            string constring = "datasource=localhost;port=3306;username=root;password=sample1";
            string Query = " SELECT * FROM pharmacy_db.Product "; /* WRITE APPROPRIATE DATABASE VALUES ON THIS LINE */

            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                while (myReader.Read())
                {
                    string sProduct = myReader.GetString("brand_name");
                    Product_combo.Items.Add(sProduct);
                }
            }
            catch (Exception error)
            { MessageBox.Show(error.Message); }
        }

        private void Product_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3306;username=root;password=sample1";
            string Query = " SELECT * FROM pharmacy_db.Product WHERE brand_name='" + Product_combo.Text + "'; "; /* WRITE APPROPRIATE DATABASE VALUES ON THIS LINE */

            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                while (myReader.Read())
                {
                    string sProductID = myReader.GetInt32("product_id").ToString();
                    PID_txt.Text = sProductID;
                }
            }
            catch (Exception error)
            { MessageBox.Show(error.Message); }
        }

        void ViewText()
        {
            string constring = "datasource=localhost;port=3306;username=root;password=sample1";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand("SELECT * FROM pharmacy_db.Sales;", conDatabase);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PID_txt_TextChanged(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3306;username=root;password=sample1";
            string Query = " SELECT * FROM pharmacy_db.Product WHERE product_id='" + PID_txt.Text + "'; "; /* WRITE APPROPRIATE DATABASE VALUES ON THIS LINE */

            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                while (myReader.Read())
                {
                    string sProductBrand = myReader.GetString("brand_name").ToString();
                    Product_combo.Text = sProductBrand;
                }
            }
            catch (Exception error)
            { MessageBox.Show(error.Message); }

            DataView SID = new DataView(dbdataset);
            SID.RowFilter = string.Format("convert(product_id, 'System.String') LIKE '%{0}%'", PID_txt.Text);
            dataGridView1.DataSource = SID;
        }

        private void sales_id_update_TextChanged(object sender, EventArgs e)
        {
            DataView SID = new DataView(dbdataset);
            SID.RowFilter = string.Format("convert(sales_id, 'System.String') LIKE '%{0}%'", sales_id_update.Text);
            dataGridView1.DataSource = SID;
        }
    }
}
