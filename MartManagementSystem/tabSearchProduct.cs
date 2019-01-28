using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;

namespace MartManagementSystem
{
    public partial class tabSearchProduct : UserControl
    {
        
        List<Product> products = new List<Product>();

        public tabSearchProduct()
        {
            InitializeComponent();
          
        }

        // Form Load
        private void tabSearchProduct_Load(object sender, EventArgs e)
        {
            ReadProduct();
            txtId.Focus();
            RefreshDataGrid();
            dataGridView1.ClearSelection();
        }


        // Search Button
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                SearchProduct(txtId.Text.Trim());
            }
            else
                MessageBox.Show("Input Barcode ID to Search");
        }

        // Refresh Button
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            RefreshDataGrid();
            dataGridView1.ClearSelection();
            txtId.Text = "";
            txtId.Focus();
        }

        // Event when user click on any rows in DataGridView
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                picProduct.ImageLocation = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }
        
        // txtID accept only number
        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 18 && ch != 8)
            {
                e.Handled = true;
            }
        }

        // click search when hit enter in txtId
        private void txtId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearch_Click(sender, e);
        }








        #region /* Methods */

        //Read Data from tbProductDemo and store in List Products
        void ReadProduct()
        {
            products.Clear();
            string connectionString;
            SqlConnection cnn;
            connectionString= @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Desktop\MartManagementSystem\MartManagementSystem\Database.mdf;Integrated Security = True";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            string sql;
            sql = "Select * from tbProductDemo";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                Product temp = new Product(dataReader.GetValue(0).ToString(), dataReader.GetValue(1).ToString(), dataReader.GetValue(2).ToString(), Convert.ToDouble(dataReader.GetValue(3)));
                products.Add(temp);
            }
            dataReader.Close();
            command.Dispose();
            cnn.Close();
        }

        // Add Prodcut to DataGridView
        void RefreshDataGrid()
        {
            foreach(Product temp in products)
            {
               dataGridView1.Rows.Add(temp.id, temp.name, temp.price, temp.pic);
            }
        }


        // Search Button Method
        void SearchProduct(string proID)
        {
            bool found = false;
            foreach (Product temp in products)
            {
                if (temp.id.ToString() == proID)
                {
                    found = true;
                    dataGridView1.Rows.Clear();
                    dataGridView1.Rows.Add(temp.id, temp.name, temp.price, temp.pic);
                    dataGridView1.ClearSelection();
                    break;
                }
            }
            if (found == false)
            {
                MessageBox.Show("Product Not Found");
                txtId.Text = "";
                txtId.Focus();
            }
        }
        #endregion
        
    }
}
