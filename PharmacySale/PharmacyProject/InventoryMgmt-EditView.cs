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
	public partial class InventoryMgmt_EditView: Form
	{
		public int _productId = -1; 
        private DatabaseFunctions _dbfuncs;
		public InventoryMgmt_EditView()
		{
			InitializeComponent();
		}

		private void setFormState(int state) {
			//1 = data loaded
			//2 = data loading
			//3 = error getting data
			if (state == 1)
			{
				loadingInfo.Text = "";
				gbxManual.Enabled = true;
				gbxQuick.Enabled = true;
			}
			else if (state == 2)
			{
				loadingInfo.Text = "Loading Product Data....";
				loadingInfo.ForeColor = Color.DarkOrange;
				gbxManual.Enabled = false;
				gbxQuick.Enabled = false;
			}
			else if (state == 3) {
				loadingInfo.Text = "Error loading product data from database";
				loadingInfo.ForeColor = Color.DarkRed;
				gbxManual.Enabled = false;
				gbxQuick.Enabled = false;
			}
		}

		private void loadProductData() {
			//set form state to loading data...
			setFormState(2);
			if (_productId > -1)
			{
				//try load the product
				lblProductID.Text = _productId.ToString();

                //set name
                lblProductName.Text = _dbfuncs.NameForProduct(_productId);

                //try get data from database, would want to reload data since data could of been changed between loading grid data and opening edit?\

                //set stock textfield
                txtManualQty.Text = _dbfuncs.StockQuantityForProduct(_productId).ToString();

                //set threshold textfield
                txtThreshold.Text = _dbfuncs.ThresholdForProduct(_productId).ToString();

                //set threshold buttons relative to state
                setThresholdButtons(_dbfuncs.ThresholdStateForProduct(_productId));

                setFormState(1);
			}
		}

        private void setThresholdButtons(bool state) {
            if (state)
            {
                btnDisableThreshold.Enabled = true;
                btnEnableThreshold.Enabled = false;
            }
            else {
                btnDisableThreshold.Enabled = false;
                btnEnableThreshold.Enabled = true;
            }
        }

		private void InventoryMgmt_EditView_Load(object sender, EventArgs e)
		{
            _dbfuncs = new DatabaseFunctions();
            //try to load the product data for the form
            loadProductData();
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
            subQty(1);
		}

        private void loadAddSubtractDialog(int productID, bool subtractQuantity) {
            InventoryMgmt_AddSubtractQtyDialog obj = new InventoryMgmt_AddSubtractQtyDialog();

            obj._productID = productID;
            obj.subtractQuantity = subtractQuantity;
            obj.ShowDialog();

            //reload data
            loadProductData();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            loadAddSubtractDialog(_productId, false);
        }

        private void btnSubNum_Click(object sender, EventArgs e)
        {
            loadAddSubtractDialog(_productId, true);
        }

        private void btnEnableThreshold_Click(object sender, EventArgs e)
        {
            bool result = _dbfuncs.SetThresholdStateForProduct(_productId, true);
            if (!result)
            {
                MessageBox.Show("An unknown error occured");
            }
            else {
                //success
                setThresholdButtons(true);
            }
        }

        private void btnDisableThreshold_Click(object sender, EventArgs e)
        {
            bool result = _dbfuncs.SetThresholdStateForProduct(_productId, false);
            if (!result)
            {
                MessageBox.Show("An unknown error occured");
            }
            else {
                //success
                setThresholdButtons(false);
            }
        }

        private void subQty(int qty) {
            bool result = _dbfuncs.SubtractQuantityToProduct(_productId, qty);
            if (!result)
            {
                MessageBox.Show("An unknown error has occured");
            }
            else {
                loadProductData();
            }
        }

        private void addQty(int qty) {
            bool result = _dbfuncs.AddQuantityToProduct(_productId, qty);
            if (!result)
            {
                MessageBox.Show("An unknown error has occured");
            }
            else {
                loadProductData();
            }
        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            addQty(1);
        }

        private void btnAdd5_Click(object sender, EventArgs e)
        {
            addQty(5);
        }

        private void btnSub5_Click(object sender, EventArgs e)
        {
            subQty(5);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClrStock_Click(object sender, EventArgs e)
        {
            DialogResult msgboxResult = MessageBox.Show("Are you sure you want to clear this products quantity?", "Confirm Manual Stock Update - Product ID:" + _productId, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (msgboxResult == DialogResult.Yes)
            {
                bool result = _dbfuncs.SetQuantityToProduct(_productId, 0);
                if (!result)
                {
                    MessageBox.Show("An unknown error has occured");
                }
                else {
                    loadProductData();
                }
            }
        }

        private void btnStockManual_Click(object sender, EventArgs e)
        {
            DialogResult msgboxResult = MessageBox.Show("Are you sure you want to set this products quantity to "+Convert.ToInt32(txtManualQty.Text)+"?", "Confirm Manual Stock Update - Product ID:"+_productId, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msgboxResult == DialogResult.Yes) {
                bool result = _dbfuncs.SetQuantityToProduct(_productId, Convert.ToInt32(txtManualQty.Text));
                if (!result)
                {
                    MessageBox.Show("An unknown error has occured");
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DialogResult msgboxResult = MessageBox.Show("Are you sure you want to set this products quantity threshold to " + Convert.ToInt32(txtThreshold.Text) + "?", "Confirm Manual Stock Update - Product ID:" + _productId, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msgboxResult == DialogResult.Yes)
            {
                bool result = _dbfuncs.SetQuantityThresholdToProduct(_productId, Convert.ToInt32(txtThreshold.Text));
                if (!result)
                {
                    MessageBox.Show("An unknown error has occured");
                }
            }
            
        }
    }
}
