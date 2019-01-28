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
    public partial class tabEditProduct : UserControl
    {

        List<Product> products = new List<Product>();
        string proImg = "";

        public tabEditProduct()
        {
            InitializeComponent();
        }

        // Form Load
        private void tabEditProduct_Load(object sender, EventArgs e)
        {
            Clear();
            ReadProduct();
            txtId.Focus();
            txtName.Enabled = false;
            txtPrice.Enabled = false;
        }


        // Button Edit
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtId.Text != ""&&txtName.Text!=""&&txtPrice.Text!="")
            {
                EditProduct();
                tabEditProduct_Load(sender, e);
            }
            else
                MessageBox.Show("Input All Fill");
        }
        
        // Button Clear
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
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

        // Button Browse
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            Browse();
        }


        // txtID accept only Number
        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 18 && ch != 8)
            {
                e.Handled = true;
            }
        }

        // txtPrice accept only Number
        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
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






        #region /*  Methods */

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

        // Edit Product
        void EditProduct()
        {
            string connectionString;
            SqlConnection cnn;
            connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Desktop\MartManagementSystem\MartManagementSystem\Database.mdf;Integrated Security = True";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "";
            sql = "Update tbProductDemo Set ProName =N'" + txtName.Text.Trim() + "',ProImage ='" + proImg + "',ProPrice =" + Convert.ToDouble(txtPrice.Text) + " Where CAST( ProId AS bigint) =" + txtId.Text.Trim() + "";
            command = new SqlCommand(sql, cnn);
            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();
            MessageBox.Show("Product Has Been Editted");
            command.Dispose();
            cnn.Close();
        }

        // CLear Button Method
        void Clear()
        {
            txtId.Enabled = true;
            txtPrice.Enabled = false;
            txtName.Enabled = false;
            txtId.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
            picProduct.Image = null;
        }

        // Browse Button Method
        void Browse()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG File|*.jpg|PNG File|*.png|All File|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picProduct.ImageLocation = ofd.FileName;
                proImg = ofd.FileName;
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
                    txtId.Enabled = false;
                    txtName.Enabled = true;
                    txtPrice.Enabled = true;
                    txtPrice.Text = temp.price.ToString();
                    txtName.Text = temp.name;
                    picProduct.ImageLocation = temp.pic;
                    proImg = temp.pic;
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
