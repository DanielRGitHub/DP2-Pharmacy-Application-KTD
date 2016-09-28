using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PharmacyProject
{
    public partial class SalesPrediction : Form
    {
        DataTable dbdataset;
        public SalesPrediction()
        {
            InitializeComponent();
            ViewText();
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3306;username=root;password=sample1";
            string Query = " SELECT * FROM pharmacy_db.Sales WHERE month='" + textBox1.Text + "'; "; /* WRITE APPROPRIATE DATABASE VALUES ON THIS LINE */

            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            DataView SID = new DataView(dbdataset);
            SID.RowFilter = string.Format("convert(month, 'System.String') LIKE '%{0}%'", textBox1.Text);
            dataGridView1.DataSource = SID;
        }

        private void calculate_avg_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
            }

            int count_row = dataGridView1.Rows.Count;
            double avg = sum / (count_row - 1);
            MessageBox.Show("For the month of " + textBox1.Text + " the predicted average sales value is: $" + avg.ToString() + ".00");
        }
    }
}
