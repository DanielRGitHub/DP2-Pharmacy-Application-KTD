﻿using System;
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


        private void LoadInvMgmt() {
            InventoryMgmt obj = new InventoryMgmt();

            obj.MdiParent = this;
            obj.Show();
        }

        private void LoadSalesPrediction()
        {
            SalesPrediction obj = new SalesPrediction();

            obj.MdiParent = this;
            obj.Show();
        }

        private void LoadLowStock() {
            InventoryLowStock obj = new InventoryLowStock();

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
            LoadAddSale();
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


        private void InvMgmtLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadInvMgmt();
        }

        private void SalesPredictionLink_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadSalesPrediction();
        }

        private void InvLowStockLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadLowStock();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadInvMgmt();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadLowStock();
        }
    }
}
