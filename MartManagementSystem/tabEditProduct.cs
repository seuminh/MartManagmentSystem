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
    public partial class tabEditProduct : UserControl
    {
        public tabEditProduct()
        {
            InitializeComponent();
        }

        private void tabEditProduct_Load(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            txtName.Enabled = false;
            txtPrice.Enabled = false;
        }
    }
}
