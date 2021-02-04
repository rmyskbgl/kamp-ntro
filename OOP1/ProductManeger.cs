using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //ürünle ilgili operasyonlar var dır 
    class ProductManeger
    {
        //encapsulation
        public void Add(Product product)
        {
            Console.WriteLine(product.productName+"eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.productName+"güncellendi.");
        }

       
    }
}
