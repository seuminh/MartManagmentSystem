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
    public partial class tabDeleteProduct : UserControl
    {
        public tabDeleteProduct()
        {
            InitializeComponent();
        }

        private void tabDeleteProduct_Load(object sender, EventArgs e)
        {
            txtId.Enabled = false;
        }
    }
}
