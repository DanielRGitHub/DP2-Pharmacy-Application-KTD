﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PharmacyProject
{
    public partial class AddSale : Form
    {
        public AddSale()
        {
            InitializeComponent();
            FillCombo();
            DisplaySales();
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

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3306;username=root;password=sample1";
            string Query = "INSERT INTO pharmacy_db.Sales (quantity, product_id, total, month, year) VALUES ('" + this.Quantity_num.Text + "', '" + this.PID_txt.Text + "', '" + this.Total_txt.Text + "', '" + this.month_txt.Text + "', '" + this.year_txt.Text + "') ;"; /* WRITE APPROPRIATE DATABASE VALUES ON THIS LINE */

            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("SUCCESSFULLY ADDED");
                while (myReader.Read())

                { }
            }
            catch (Exception error)
            { MessageBox.Show(error.Message); }
        }

        void DisplaySales ()
        {
            string constring = "datasource=localhost;port=3306;username=root;password=sample1";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand("SELECT * FROM pharmacy_db.Sales;", conDatabase);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                DataTable dbdataset = new DataTable();
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

        private void Calc_btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Price_txt.Text) && !string.IsNullOrEmpty(Quantity_num.Text))
                Total_txt.Text = (Convert.ToDouble(Price_txt.Text) * Convert.ToDouble(Quantity_num.Text)).ToString();
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
                    string sProductPrice = myReader.GetInt16("product_price").ToString();
                    string sProductID = myReader.GetInt32("product_id").ToString();
                    Price_txt.Text = sProductPrice;
                    PID_txt.Text = sProductID;
                }
            }
            catch (Exception error)
            { MessageBox.Show(error.Message); }
        }

        private void AddSale_Load(object sender, EventArgs e)
        {

        }
    }
}
