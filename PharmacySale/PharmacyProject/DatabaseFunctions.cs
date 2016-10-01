using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Created by Blake Howe.
namespace PharmacyProject
{
    //Helps Perform Common Database Actions for the Pharmacy Project
    class DatabaseFunctions
    {
        private string _constring = "datasource=localhost;database=pharmacy_db;port=3306;username=root;password=sample1;";
        private MySqlConnection conDatabase;

        public DatabaseFunctions() {
            conDatabase = new MySqlConnection(_constring);
        }

        public MySqlCommand CommandFromSQLStatement(string query) {
            return new MySqlCommand(query, conDatabase);
        }

        public string NameForProduct(int productID)
        {

            if (conDatabase.State != System.Data.ConnectionState.Open)
            {
                conDatabase.Open();
            }

            MySqlCommand command = CommandFromSQLStatement("SELECT brand_name FROM product WHERE product_id=?id;");
            command.Parameters.AddWithValue("id", productID);

            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                string name = this.getDBString("brand_name", reader);
                reader.Close();
                return name;
            }
            reader.Close();
            conDatabase.Close();
            return "";
        }

        public bool SetThresholdStateForProduct(int productID, bool state) {
            if (productID < -1) { return false; }
            if (conDatabase.State != System.Data.ConnectionState.Open)
            {
                conDatabase.Open();
            }
            MySqlCommand command = CommandFromSQLStatement("UPDATE productstock SET use_threshold = "+state.ToString()+" WHERE product_id = " + productID);
            try
            {
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected != 1)
                {
                    //unexpected result?
                    conDatabase.Close();
                    return false;
                }
            }
            catch (Exception e)
            {
                conDatabase.Close();
                MessageBox.Show(e.Message);
                return false;
            }
            conDatabase.Close();
            return true;
        }

        public bool ThresholdStateForProduct(int productID) {
            if (conDatabase.State != System.Data.ConnectionState.Open)
            {
                conDatabase.Open();
            }
            MySqlCommand command = CommandFromSQLStatement("SELECT use_threshold FROM productstock WHERE product_id=?id;");
            command.Parameters.AddWithValue("id", productID);

            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                string state = this.getDBString("use_threshold", reader);
                reader.Close();
                bool result = Convert.ToBoolean(state);
                return result;
            }
            reader.Close();
            conDatabase.Close();
            return false;
        }
        public int ThresholdForProduct(int productID) {
            if (conDatabase.State != System.Data.ConnectionState.Open)
            {
                conDatabase.Open();
            }
            MySqlCommand command = CommandFromSQLStatement("SELECT stock_threshold FROM productstock WHERE product_id=?id;");
            command.Parameters.AddWithValue("id", productID);

            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                string qty = this.getDBString("stock_threshold", reader);
                reader.Close();
                int parsedQty = Convert.ToInt32(qty);
                if (parsedQty > -1)
                {
                    conDatabase.Close();
                    return parsedQty;
                }
                else
                {
                    MessageBox.Show("Database Error: Product has negative threshold");
                }
            }
            reader.Close();
            conDatabase.Close();
            return 0;
        }

        public int StockQuantityForProduct(int productID) {
            if (conDatabase.State != System.Data.ConnectionState.Open) {
                conDatabase.Open();
            }
            
            MySqlCommand command = CommandFromSQLStatement("SELECT stock_available FROM productstock WHERE product_id=?id;");
            command.Parameters.AddWithValue("id", productID);

            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            if (reader.HasRows) {
                string qty = this.getDBString("stock_available", reader);
                
                int parsedQty = Convert.ToInt32(qty);
                if (parsedQty > -1)
                {
                    conDatabase.Close();
                    return parsedQty;
                }
                else {
                    MessageBox.Show("Database Error: Product has negative stock");
                }
            }
            conDatabase.Close();
            return 0;
        }

        public bool SetQuantityToProduct(int productID, int qty)
        {
            int stockToSet = qty;
            if ((stockToSet) < 0)
            {
                //ensures negative cant happen
                return false;
            }
            else
            {
                if (conDatabase.State != System.Data.ConnectionState.Open)
                {
                    conDatabase.Open();
                }
                MySqlCommand command = CommandFromSQLStatement("UPDATE productstock SET stock_available = " + stockToSet + " WHERE product_id = " + productID);
                try
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected != 1)
                    {
                        //unexpected result?
                        conDatabase.Close();
                        return false;
                    }
                }
                catch (Exception e)
                {
                    conDatabase.Close();
                    MessageBox.Show(e.Message);
                    return false;
                }
                conDatabase.Close();
                return true;
            }
        }

        public bool SetQuantityThresholdToProduct(int productID, int qty)
        {
            int stockToSet = qty;
            if ((stockToSet) < 0)
            {
                //ensures negative cant happen
                return false;
            }
            else
            {
                if (conDatabase.State != System.Data.ConnectionState.Open)
                {
                    conDatabase.Open();
                }
                MySqlCommand command = CommandFromSQLStatement("UPDATE productstock SET stock_threshold = " + stockToSet + " WHERE product_id = " + productID);
                try
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected != 1)
                    {
                        //unexpected result?
                        conDatabase.Close();
                        return false;
                    }
                }
                catch (Exception e)
                {
                    conDatabase.Close();
                    MessageBox.Show(e.Message);
                    return false;
                }
                conDatabase.Close();
                return true;
            }
        }

        public bool AddQuantityToProduct(int productID, int qty) {
            if (qty < 1) { return true; }
            if (conDatabase.State != System.Data.ConnectionState.Open)
            {
                conDatabase.Open();
            }
            MySqlCommand command = CommandFromSQLStatement("UPDATE productstock SET stock_available = stock_available + "+qty+" WHERE product_id = " + productID);
            try
            {
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected != 1)
                {
                    //unexpected result?
                    conDatabase.Close();
                    return false;
                }
            }
            catch (Exception e) {
                conDatabase.Close();
                MessageBox.Show(e.Message);
                return false;
            }
            conDatabase.Close();
            return true;
        }

        public bool SubtractQuantityToProduct(int productID, int qty) {
            int currentStock = StockQuantityForProduct(productID);
            int stockToSet = currentStock - qty;
            if ((stockToSet) < 0)
            {
                //ensures negative cant happen
                return false;
            }
            else {
                if (conDatabase.State != System.Data.ConnectionState.Open)
                {
                    conDatabase.Open();
                }
                MySqlCommand command = CommandFromSQLStatement("UPDATE productstock SET stock_available = " + stockToSet + " WHERE product_id = " + productID);
                try
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected != 1)
                    {
                        //unexpected result?
                        conDatabase.Close();
                        return false;
                    }
                }
                catch (Exception e)
                {
                    conDatabase.Close();
                    MessageBox.Show(e.Message);
                    return false;
                }
                conDatabase.Close();
                return true;
            }
        }

        private string getDBString(string SqlFieldName, MySqlDataReader Reader)
        {
            return Reader[SqlFieldName].Equals(DBNull.Value) ? String.Empty : Reader.GetString(SqlFieldName);
        }
    }
}
