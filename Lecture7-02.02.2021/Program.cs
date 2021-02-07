using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lecture7_02._02._2021
{
    [Table("Product")]
    class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }

        public Product(string productname,int price)
        {
            ProductName = productname;
            Price = price;
        }

        public Product(string productname)
        {
            ProductName = productname;
        }

        public Product()
        {

        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            var product = new Product
            {
                ProductID = 1,
                ProductName = "Молоко",
                Price = 25
            };

            var product1 = new Product
            {
                ProductID = 2,
                ProductName = "Апельсиновый сок",
                Price = 30
            };

            Console.WriteLine($"ID: {product.ProductID}\n" + $"Название продуктв: {product.ProductName}\n" + $"Цена: {product.Price}");
            Console.WriteLine($"ID: {product1.ProductID}\n" + $"Название продукта: {product1.ProductName}\n" + $"Цена: {product1.Price}");
            Console.ReadKey();
        }
    }
}
