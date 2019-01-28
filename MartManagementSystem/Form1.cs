using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MartManagementSystem
{
    public partial class MainForm : Form
    {
        tabProduct product;
        tabAddStock addStock;
        tabSale sale;

        public MainForm()
        {
            InitializeComponent();
            //MartManagementSystem.Properties.Settings.Default.ProNoBarcode = 1;
            //MartManagementSystem.Properties.Settings.Default.Save();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            btnAddStock_Click(sender, e);
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            panelShow.Controls.Clear();
            addStock = new tabAddStock();
            panelShow.Controls.Add(addStock);
            addStock.BringToFront();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            panelShow.Controls.Clear();
            product = new tabProduct();
            panelShow.Controls.Add(product);
            product.BringToFront();
        }
        
        private void btnSale_Click(object sender, EventArgs e)
        {
            panelShow.Controls.Clear();
            sale = new tabSale();
            panelShow.Controls.Add(sale);
            sale.BringToFront();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
