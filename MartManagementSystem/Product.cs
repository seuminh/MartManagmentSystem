using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MartManagementSystem
{
    class Product
    {
        public string id { get; set; }
        public string name { get; set; }
        public string pic { get; set; }
        public double price { get; set; }
        public double total { get; set; }
        public int qty { get; set; }

        public Product()
        {
            id = "";
            name = "";
            pic = "";
            price = 0.0;
            total = 0.0;
            qty = 0;
        }

        public Product(string id_,string name_,string pic_,double price_)
        {
            id = id_;
            name = name_;
            pic = pic_;
            price = price_;
        }
    }
}
