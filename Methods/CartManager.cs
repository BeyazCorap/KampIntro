using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class CartManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("'" + product.ProductName + "'"+ "Sepete Eklendi ");
        }
        //encapsulation => v
        public void Add2(string name, double price ,string desc ,int stockTotal)
        {
            Console.WriteLine("'" + name + "'" + "Sepete Eklendi ");
        }
    }
}
