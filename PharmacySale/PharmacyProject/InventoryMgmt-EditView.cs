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
    public partial class InventoryMgmt_EditView: Form
    {
        public int _productId = -1; 
        public InventoryMgmt_EditView()
        {
            InitializeComponent();
        }

        private void InventoryMgmt_EditView_Load(object sender, EventArgs e)
        {
            if (_productId > -1) {
                //try load the product
                lblProductID.Text = _productId.ToString();

                //try get data from database, would want to reload data since data could of been changed between loading grid data and opening edit?

                
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
