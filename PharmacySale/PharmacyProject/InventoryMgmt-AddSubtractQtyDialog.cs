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
	//Created by Blake Howe.
	public partial class InventoryMgmt_AddSubtractQtyDialog : Form
	{
		public int _productID = -1;

		//true for subtract, false to add
		public bool subtractQuantity;
		public InventoryMgmt_AddSubtractQtyDialog()
		{
			InitializeComponent();
		}

		private void InventoryMgmt_AddSubtractQtyDialog_Load(object sender, EventArgs e)
		{
            //if valid product ID
			if (_productID > -1)
			{
				this.Text = "Product ID: " + _productID;
				if (!subtractQuantity)
				{
					btnAction.Text = "Add Quantity";
				}
				else {
					btnAction.Text = "Subtract Quantity";
				}
			}
			else {
				this.Text = "Invalid Product ID";
				txtQuantity.Enabled = false;
				btnAction.Enabled = false;
				btnAction.Text = "";
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
		   DatabaseFunctions dbFuncs = new DatabaseFunctions();
			int qty = Convert.ToInt32(txtQuantity.Text);
			if (qty > 0) {
                bool result = false;

                if (subtractQuantity)
                {
                    result = dbFuncs.SubtractQuantityToProduct(_productID, qty);
                }
                else {
                    result = dbFuncs.AddQuantityToProduct(_productID, qty);
                }

                if (!result)
                {
                    MessageBox.Show("Unknown error has occured");
                }
            }
            this.Close();
		}
	}
}
