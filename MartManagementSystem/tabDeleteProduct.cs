using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MartManagementSystem
{
    public partial class tabDeleteProduct : UserControl
    {

        List<Product> products = new List<Product>();


        public tabDeleteProduct()
        {
            InitializeComponent();
        }

        // Form Load
        private void tabDeleteProduct_Load(object sender, EventArgs e)
        {
            Clear();
            txtId.Focus();
            ReadProduct();
        }

        // Button Search
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                SearchProduct(txtId.Text.Trim());
            }
            else
                MessageBox.Show("Input Barcode ID to Search");
        }


        // Button Clear
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }


        // Button Delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                DialogResult result = MessageBox.Show("Do you want to Delete this Product?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteProduct();
                    tabDeleteProduct_Load(sender, e);
                }
            }
            else
                MessageBox.Show("Enter Barcode ID to Delete");
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


        // Read Data from tbProductDemo and store in List Products
        void ReadProduct()
        {
            products.Clear();
            string connectionString;
            SqlConnection cnn;
            connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Desktop\MartManagementSystem\MartManagementSystem\Database.mdf;Integrated Security = True";
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


        //Delete Product
        void DeleteProduct()
        {
            string connectionString;
            SqlConnection cnn;
            connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Desktop\MartManagementSystem\MartManagementSystem\Database.mdf;Integrated Security = True";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "";
            sql = "Delete From tbProductDemo Where CAST( ProId AS bigint) =" + txtId.Text.Trim() + "";
            command = new SqlCommand(sql, cnn);
            adapter.DeleteCommand = new SqlCommand(sql, cnn);
            adapter.DeleteCommand.ExecuteNonQuery();
            MessageBox.Show("Product Has Been Delete");
            command.Dispose();
            cnn.Close();
        }




        // Clear Button Method
        void Clear()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
            picProduct.Image = null;
            txtId.Enabled = true;
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
                    txtId.Enabled = false;
                    txtPrice.Text = temp.price.ToString();
                    txtName.Text = temp.name;
                    picProduct.ImageLocation = temp.pic;
                    break;
                }
            }
            if (found == false)
            {
                MessageBox.Show("Product Not Found");
                Clear();
            }
        }


        #endregion
    }
}
