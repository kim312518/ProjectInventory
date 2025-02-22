﻿using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectInventory
{
    public partial class Home : MaterialForm
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange200, TextShade.WHITE);

        }
        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(Color.Orange), materialCard1.ClientRectangle);
        }
        private void materialCard2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(Color.CadetBlue), materialCard1.ClientRectangle);
        }
        private void materialCard3_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(Color.LightGray), materialCard1.ClientRectangle);

        }

        private void materialCard4_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(Color.DarkSlateGray), materialCard1.ClientRectangle);
        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            var cat = new Category();
            cat.ShowDialog();
        }

        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            var productForm = new Product_List();
            productForm.ShowDialog();
        }

        private void btnAddCostumer_Click(object sender, EventArgs e)
        {
            var addcotumerForm = new Costumers();
            addcotumerForm.ShowDialog();
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            var addSupplier = new Suppliers();
            addSupplier.ShowDialog();
        }

        private void btnAddOngoingProducts_Click(object sender, EventArgs e)
        {
            var addOngoing = new Ongoing_Products();
            addOngoing.ShowDialog();
        }

        private void btnAddPuchaseProducts_Click(object sender, EventArgs e)
        {
            var addPurchaseProducts = new Purchased_Products();
            addPurchaseProducts.ShowDialog();
        }
    }
}
