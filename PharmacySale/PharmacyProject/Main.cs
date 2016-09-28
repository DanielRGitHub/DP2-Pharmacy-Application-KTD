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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void LoadSalesInfo()
        {
            SalesInfo obj = new SalesInfo();
            obj.MdiParent = this;
            obj.Show();
        }

        private void LoadAddSale()
        {
            AddSale obj = new AddSale();
            obj.MdiParent = this;
            obj.Show();
        }

        private void LoadEditSale()
        {
            EditSale obj = new EditSale();
            obj.MdiParent = this;
            obj.Show();
        }

        private void LoadSearchSale()
        {
            SearchSale obj = new SearchSale();
            obj.MdiParent = this;
            obj.Show();
        }

<<<<<<< HEAD
        private void LoadInvMgmt() {
            InventoryMgmt obj = new InventoryMgmt();
=======
        private void LoadSalesPrediction()
        {
            SalesPrediction obj = new SalesPrediction();
>>>>>>> refs/remotes/origin/master
            obj.MdiParent = this;
            obj.Show();
        }

        private void CloseSalesInfo()
        {
            Form obj = Application.OpenForms["SalesInfo"];
            obj.Close();
            /*if (fc.Count > 1)
            {
                for (int i = (fc.Count); i > 1; i--)
                {
                    Form selectedForm = Application.OpenForms[i - 1];
                    selectedForm.Close();
                }
            }*/
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoadSalesInfo();
        }

        private void SaleInfoLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadSalesInfo();
        }

        private void AddSaleLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadAddSale();
        }

        private void EditSaleLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadEditSale();
        }

        private void SearchSaleLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadSearchSale();
        }

<<<<<<< HEAD
        private void InvMgmtLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadInvMgmt();
=======
        private void SalesPredictionLink_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadSalesPrediction();
>>>>>>> refs/remotes/origin/master
        }
    }
}
