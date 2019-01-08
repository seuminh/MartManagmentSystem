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
    public partial class tabSale : UserControl
    {
        public tabSale()
        {
            InitializeComponent();
        }

        private void tabSale_Load(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Add(1, 1.1, 1.2, 1.3);
            this.dataGridView1.Rows.Add(2, 21.1, 1.2, 1.3);
            this.dataGridView1.Rows.Add(3, 31.1, 1.2, 1.3);
            this.dataGridView1.Rows.Add(4, 41.1, 1.2, 1.3);
            this.dataGridView1.Rows.Add(5, 51.1, 1.2, 1.3);
            this.dataGridView1.Rows.Add(6, 61.1, 1.2, 1.3);
            this.dataGridView1.Rows.Add(7, 71.1, 1.2, 1.3);
            this.dataGridView1.Rows.Add(8, 81.1, 1.2, 1.3);
            this.dataGridView1.Rows.Add(9, 91.1, 1.2, 1.3);
            this.dataGridView1.Rows.Add(10, 101.1, 1.2, 1.3);
            this.dataGridView1.Rows.Add(11, 111.1, 1.2, 1.3);
            this.dataGridView1.Rows.Add(8, 81.1, 1.2, 1.3);
            this.dataGridView1.Rows.Add(9, 91.1, 1.2, 1.3);
            this.dataGridView1.Rows.Add(10, 101.1, 1.2, 1.3);
            this.dataGridView1.Rows.Add(11, 111.1, 1.2, 1.3);
            this.dataGridView1.Rows.Add(8, 81.1, 1.2, 1.3);
            this.dataGridView1.Rows.Add(9, 91.1, 1.2, 1.3);
            this.dataGridView1.Rows.Add(10, 101.1, 1.2, 1.3);
            this.dataGridView1.Rows.Add(11, 111.1, 1.2, 1.3);
            dataGridView1.ClearSelection();
        }
    }
}
