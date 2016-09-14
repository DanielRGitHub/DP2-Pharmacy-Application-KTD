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
    public partial class SalesInfo : Form
    {
        public SalesInfo()
        {
            InitializeComponent();
            chartDisplay();
        }

        private void chartDisplay()
        {
            string constring = "datasource=localhost;port=3306;username=root;password=sample1";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select month, sum(total) as total from pharmacy_db.sales group by month order by month", conDataBase);
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
    }
}
