using System;
using System.Collections.Generic;

namespace Store
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- Interface/Product Example");
            List<Product> productslist = new List<Product>();
            productslist.Add(new Product("Teltta", 124.99, 450));
            productslist.Add(new Product("Sytytin", 14.99, 250));
            productslist.Add(new Product("Kuksa", 124.99, 450));
            productslist.Add(new Product("Puukko", 124.99, 450));

            foreach (Product currentProduct in productslist)
            {
                if (currentProduct.GetProduct("Teltta") != null)
                {
                    Console.WriteLine("--------  ");
                    Console.WriteLine("Teltta löytyi");
                    Console.WriteLine($"Varaston arvo: {currentProduct.CalculateTotal()}");
                    Console.WriteLine("--------  ");
                }
                //Console.WriteLine(currentProduct.ToString());
            }

            Console.WriteLine("-------STORE-------");

            StoreClass myStore = new StoreClass("Eetun kauppa");
            myStore.AddProduct(new Product("RK-62", 699.99, 25));
            myStore.AddProduct(new Product("Clock-18", 249.99, 42));
            myStore.AddProduct(new Product("HRE", 34.99, 275));
            myStore.PrintProducts();
        }
    }
}
