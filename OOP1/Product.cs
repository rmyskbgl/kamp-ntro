using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //sineppet (özelikler)
    class Product
    {
        public int  Id { get; set; }
        public int CategorId { get; set; }
        public string productName { get; set; }
        public double UniPrice { get; set; }
        public int UnitsInStock { get; set; }

    }
}
