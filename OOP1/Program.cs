using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategorId=2;
            product1.productName = "masa";
            product1.UniPrice = 500;
            product1.UnitsInStock =3;

            Product product = new Product { Id = 2, CategorId = 5, UnitsInStock = 5, productName = "kalem", UniPrice = 35 };
            //PascalCase   //camelCase  //case sensitive
            ProductManeger productManeger=new ProductManeger();
            productManeger.Add(product1);

           
        }
    }
}
