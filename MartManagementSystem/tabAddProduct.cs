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
    public partial class tabAddProduct : UserControl
    {
        string proImg = "";
        int proNoBarcode;


        public tabAddProduct()
        {
            InitializeComponent();
        }


        // Form Load
        private void tabAddProduct_Load(object sender, EventArgs e)
        {
            proNoBarcode = MartManagementSystem.Properties.Settings.Default.ProNoBarcode;
            rdbNoBarcode.Checked = true;
        }

        // Add Button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "" && txtName.Text != "" && txtPrice.Text != "")
            {
                if (picProduct.Image != null)
                    Add();
                else
                    MessageBox.Show("Please Insert Image");
            }
            else
                MessageBox.Show("Input All Fill");
        }


        // Clear Button
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        // Browse Button
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            Browse();
        }

        // RadioBox HaveBarcode
        private void rdbHaveBarcode_CheckedChanged(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            txtId.Focus();
            Clear();
        }
        
        // RadioBox NoBarcode
        private void rdbNoBarcode_CheckedChanged(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            Clear();
            txtId.Text = proNoBarcode.ToString();
        }

        // txtId accept only Number
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
                txtName.Focus();
        }





        #region         /* Methods */

        // Clear Button Method
        void Clear()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
            picProduct.Image = null;
            if (rdbNoBarcode.Checked == true) txtId.Text = proNoBarcode.ToString();
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

        // Add Button Method
        void Add()
        {
            string connectionString;
            SqlConnection cnn;
            connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Desktop\MartManagementSystem\MartManagementSystem\Database.mdf;Integrated Security = True";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql;
            sql = "Insert into tbProductDemo(ProId,ProName,ProImage,ProPrice) VALUES('" + txtId.Text.Trim() + "',N'" + txtName.Text.Trim() + "','" + proImg + "'," + Convert.ToDouble(txtPrice.Text) + ")";
            command = new SqlCommand(sql, cnn);
            adapter.InsertCommand = new SqlCommand(sql, cnn);
            try
            {
                adapter.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("New Product Added");
                if (rdbNoBarcode.Checked == true)
                {
                    proNoBarcode += 1;
                    MartManagementSystem.Properties.Settings.Default.ProNoBarcode = proNoBarcode;
                    MartManagementSystem.Properties.Settings.Default.Save();
                }
                rdbNoBarcode.Checked = true;
                Clear();
                txtId.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Duplicate ID","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            command.Dispose();
            cnn.Close();
        }
        #endregion

       
    }
}
