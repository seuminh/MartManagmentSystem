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
    public partial class tabAddStock : UserControl
    {

        List<Product> products = new List<Product>();
        List<Product> addStocks = new List<Product>();

        public tabAddStock()
        {
            InitializeComponent();
        }

        // Form Load
        private void tabAddStock_Load(object sender, EventArgs e)
        {
            ReadProduct();
            txtId.Focus();
            txtName.Enabled = false;
            txtQty.Enabled = false;
        }

        // Form Leave
        private void tabAddStock_Leave(object sender, EventArgs e)
        {
            if (addStocks.Count > 0)
            {
                DialogResult result = MessageBox.Show("You Haven't Save yet..\n\nDo you want to save now?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes || result==DialogResult.No)
                {
                    Save();
                }
            }
           
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

        // Button Add
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "" && txtName.Text != "" && txtQty.Text != "")
            {
                Add();
                New();
            }
            else
                MessageBox.Show("Input All Fill");
        }

        // Button New
        private void btnNew_Click(object sender, EventArgs e)
        {
            New();
        }

        // Button Delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (picProduct.Image != null)
            {
                Delete();
                picProduct.Image = null;
            }
            else
                MessageBox.Show("Select item to delete");
        }

        // Button Save
        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Save","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Save();
                addStocks.Clear();
                dataGridView1.Rows.Clear();
                RefreshDataGrid();
            }
        }

        // Event when user click on any rows in DataGridView
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                picProduct.ImageLocation = FindProPic(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString().Trim());
            }
        }
        
        // txtQty accept only Number
        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 18 && ch != 8)
            {
                e.Handled = true;
            }
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

        // Search Button Method
        void SearchProduct(string proID)
        {
            bool found = false;
            foreach (Product temp in products)
            {
                if (temp.id.ToString() == proID)
                {
                    found = true;
                    txtQty.Enabled = true;
                    txtName.Text = temp.name;
                    picProduct.ImageLocation = temp.pic;
                    txtId.Enabled = false;
                    break;
                }
            }
            if (found == false)
            {
                MessageBox.Show("Product Not Found");
                New();
            }
        }

        // New Button Method
        void New()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtQty.Text = "";
            picProduct.Image = null;
            txtQty.Enabled = false;
            dataGridView1.ClearSelection();
            txtId.Focus();
            txtId.Enabled = true;
            txtId.Focus();
        }

        // Add Button Method
        void Add()
        {
            bool found = false;
            int len = addStocks.Count;
            for(int i = 0; i < len; i++)
            {
                if (addStocks[i].id == txtId.Text.Trim())
                {
                    addStocks[i].qty+= Convert.ToInt32(txtQty.Text.Trim());
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Product temp = new Product();
                temp.id = txtId.Text.Trim();
                temp.name = txtName.Text.Trim();
                temp.price = Convert.ToDouble(FindPrice(txtId.Text.Trim()));
                temp.qty = Convert.ToInt32(txtQty.Text.Trim());
                temp.pic = picProduct.ImageLocation;
                addStocks.Add(temp);
            }
            dataGridView1.Rows.Clear();
            RefreshDataGrid();
            dataGridView1.ClearSelection();
        }

        // Save Button Method
        void Save()
        {
            int len = addStocks.Count;
            for(int i = 0; i < len; i++)
            {
                try
                {
                    string connectionString;
                    SqlConnection cnn;
                    connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Desktop\MartManagementSystem\MartManagementSystem\Database.mdf;Integrated Security = True";
                    cnn = new SqlConnection(connectionString);
                    cnn.Open();
                    SqlCommand command;
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    string sql;
                    sql = "Insert into tbSaleDemo(ProId,ProName,ProPrice,ProQty) VALUES('" + addStocks[i].id + "',N'" + addStocks[i].name + "'," + addStocks[i].price + "," + addStocks[i].qty + ")";
                    command = new SqlCommand(sql, cnn);
                    adapter.InsertCommand = new SqlCommand(sql, cnn);
                    adapter.InsertCommand.ExecuteNonQuery();
                    command.Dispose();
                    cnn.Close();
                }
                catch (SqlException)
                {
                    string connectionString1;
                    SqlConnection cnn1;
                    connectionString1 = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Desktop\MartManagementSystem\MartManagementSystem\Database.mdf;Integrated Security = True";
                    cnn1 = new SqlConnection(connectionString1);
                    cnn1.Open();
                    SqlCommand command1;
                    SqlDataAdapter adapter1 = new SqlDataAdapter();
                    string sql = "";
                    sql = "Update tbSaleDemo Set ProQty +=" + addStocks[i].qty + ",ProPrice =" + addStocks[i].price + ",ProName='" + addStocks[i].name + "' Where ProId = " + addStocks[i].id + "";
                    command1 = new SqlCommand(sql, cnn1);
                    adapter1.InsertCommand = new SqlCommand(sql, cnn1);
                    adapter1.InsertCommand.ExecuteNonQuery();
                    command1.Dispose();
                    cnn1.Close();
                }
            }
        }

        // Delete Button Method
        void Delete()
        {
            int len = addStocks.Count;
            for(int i = 0; i < len; i++)
            {
                if (addStocks[i].pic == picProduct.ImageLocation)
                {
                    addStocks.Remove(addStocks[i]);
                    break;
                }
            }
            dataGridView1.Rows.Clear();
            RefreshDataGrid();
            dataGridView1.ClearSelection();
        }



        // Add Item to DataGrid
        void RefreshDataGrid()
        {
            foreach(Product temp in addStocks)
            {
                dataGridView1.Rows.Add(temp.id, temp.name, temp.price.ToString(), temp.qty);
            }
        }
        // Find Price Method
        string FindPrice(string proId)
        {
            foreach(Product temp in products)
            {
                if (temp.id == proId)
                    return temp.price.ToString();
            }
            return "";
        }

        // Find Product Image Method
        string FindProPic(string proId)
        {
            foreach(Product temp in products)
            {
                if (temp.id == proId)
                    return temp.pic;
            }
            return "";
        }

        // Find item is already added or not

        #endregion
        
    }
}
