using System;
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
    public partial class displaysales : Form
    {
        public displaysales()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            edit eform = new edit();
            eform.ShowDialog();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            search eform = new search();
            eform.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            MainForm eform = new MainForm();
            eform.ShowDialog();
        }

        private void Display_chart_txt_Click(object sender, EventArgs e)
        {
            /*this.chart1.Series["Month"].Points.AddXY("January", 120);
            this.chart1.Series["Month"].Points.AddXY("February", 60);
            this.chart1.Series["Month"].Points.AddXY("March", 30);
            this.chart1.Series["Month"].Points.AddXY("April", 80);*/
            string constring = "datasource=localhost;port=3306;username=root;password=sample1";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("SELECT * FROM pharmacy_db.sales", conDataBase);
            MySqlDataReader myReader;
            chart1.Series[0].Points.Clear();
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    this.chart1.Series["Month"].Points.AddXY(myReader.GetString("month"), myReader.GetInt32("total"));
                }
            }

            catch (Exception error)
            { MessageBox.Show(error.Message); }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        { }
    }
}

