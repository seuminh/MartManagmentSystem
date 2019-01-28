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
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace MartManagementSystem
{
    public partial class tabSale : UserControl
    {
        List<Product> sales = new List<Product>();
        double total = 0;

        public tabSale()
        {
            InitializeComponent();
        }

        // Form Load
        private void tabSale_Load(object sender, EventArgs e)
        {
            ReadProduct();
            RefreshDataGrid();
            dataGridView1.ClearSelection();
            lblDate.Text = "Date :" + DateTime.Now.ToShortDateString();
            txtTotal.Text = total.ToString();
        }

        // Button Save
        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure that you want to save these data to excel?","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (result == DialogResult.Yes&&sales.Count>0)
            {
                Save();
            }
        }





        #region /* Methods */
        //Read Data from tbProductDemo and store in List Products
        void ReadProduct()
        {
            string connectionString;
            SqlConnection cnn;
            connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Desktop\MartManagementSystem\MartManagementSystem\Database.mdf;Integrated Security = True";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            string sql;
            sql = "Select * from tbSaleDemo";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                Product temp = new Product();
                temp.name = dataReader.GetValue(1).ToString();
                temp.price = Convert.ToDouble(dataReader.GetValue(2).ToString());
                temp.qty = Convert.ToInt32(dataReader.GetValue(3).ToString());
                temp.total = temp.price * temp.qty;
                total += temp.total;
                sales.Add(temp);
            }
            dataReader.Close();
            command.Dispose();
            cnn.Close();
        }

        // Add Prodcut to DataGridView
        void RefreshDataGrid()
        {
            foreach (Product temp in sales)
            {
                dataGridView1.Rows.Add(temp.name, temp.price, temp.qty, temp.total);
            }
        }

        // Copy data to Excel and Clear data in tbSale
        void Save()
        {
            string today = "Sale " + DateTime.Now.ToString("yyyy'-'MM'-'dd");
            Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            if (xlApp == null)
            {
                MessageBox.Show("Excel is not installed");
                return;
            }
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            xlWorkSheet.Cells[2, 2] = "Name";
            xlWorkSheet.Cells[2, 3] = "Price";
            xlWorkSheet.Cells[2, 4] = "Qty";
            xlWorkSheet.Cells[2, 5] = "Total";
            int row = 3, col = 2;
            int len = sales.Count();
            for(int i = 0; i < len; i++)
            {
                xlWorkSheet.Cells[row, col - 1] = (i+1).ToString();
                xlWorkSheet.Cells[row, col] = sales[i].name;
                xlWorkSheet.Cells[row, col + 1] = sales[i].price.ToString();
                xlWorkSheet.Cells[row, col + 2] = sales[i].qty.ToString();
                xlWorkSheet.Cells[row, col + 3] = sales[i].total.ToString();
                row++;
            }
            xlWorkSheet.Cells[row+1, 4] = "Total";
            xlWorkSheet.Cells[row+1, 5] = total.ToString();
            xlWorkBook.SaveAs(@"C:\Users\Admin\Desktop\" + today, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();
            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);
            

            // Delete Data after saving to Excel
            string connectionString;
            SqlConnection cnn;
            connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Desktop\MartManagementSystem\MartManagementSystem\Database.mdf;Integrated Security = True";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql;
            sql = "Delete From tbSaleDemo";
            command = new SqlCommand(sql, cnn);
            adapter.DeleteCommand = new SqlCommand(sql, cnn);
            adapter.DeleteCommand.ExecuteNonQuery();
            command.Dispose();
            cnn.Close();
            MessageBox.Show("Excel File has been created in Desktop","Information");
        }
        #endregion
        
    }
}
