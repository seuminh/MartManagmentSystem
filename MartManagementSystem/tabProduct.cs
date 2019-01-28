using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MartManagementSystem
{
    public partial class tabProduct : UserControl
    {
        tabAddProduct addProduct;
        tabEditProduct editProduct;
        tabDeleteProduct deleteProduct;
        tabSearchProduct searchProduct;

        public tabProduct()
        {
            InitializeComponent();
        }

        private void tabProduct_Load(object sender, EventArgs e)
        {
            btnAddProduct_Click(sender, e);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            panelShow.Controls.Clear();
            addProduct = new tabAddProduct();
            panelShow.Controls.Add(addProduct);
            addProduct.BringToFront();
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            panelShow.Controls.Clear();
            editProduct = new tabEditProduct();
            panelShow.Controls.Add(editProduct);
            editProduct.BringToFront();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            panelShow.Controls.Clear();
            deleteProduct = new tabDeleteProduct();
            panelShow.Controls.Add(deleteProduct);
            deleteProduct.BringToFront();
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            panelShow.Controls.Clear();
            searchProduct = new tabSearchProduct();
            panelShow.Controls.Add(searchProduct);
            searchProduct.BringToFront();
        }

      
    }
}
