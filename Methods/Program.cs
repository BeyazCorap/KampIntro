using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductName = "Elma";
            product1.Price = 15;
            product1.Description = "Amasya Elmasi";

            Product product2 = new Product();
            product2.ProductName = "Karpuz";
            product2.Price = 80;
            product2.Description = "Diyarbakir Karpuzu";

            Product[] Products = new Product[] {product1,product2 };

            foreach (Product product in Products)
            {
                Console.WriteLine(product.ProductName);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Description);
            }
            Console.WriteLine("=======================Methods=======================");
            //instance - ornek
            CartManager sepetManager = new CartManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);

            sepetManager.Add2("Armut", 15, "Yesil Armut", 60);

        }
    }
}
//tekrar kullanilabilir kod bloklaridir
//do not repeat yourself - DRY - clean code