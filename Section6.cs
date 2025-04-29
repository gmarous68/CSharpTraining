using DocumentFormat.OpenXml.Drawing;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }

    class Section6
    {
        public static void Product()
        {
            List<Product> products = new List<Product>();

            products.Add(new Product { Name = "Bananas", Price = 0.30 });
            products.Add(new Product { Name = "Berries", Price = 2.99 });
            products.Add(new Product { Name = "Apples", Price = 1.99 });
            products.Add(new Product { Name = "Grapes", Price = 0.70 });
            products.Add(new Product { Name = "Orange", Price = 1.99 });
            products.Add(new Product { Name = "Blueberry", Price = 0.09 });

            List<Product> cheapProd = products.Where(p => p.Price <= 1.0).ToList();

            foreach (Product prod in products)
                Console.WriteLine($"Product: {prod.Name}, with price: {prod.Price}");
            Console.WriteLine("***********************");

            foreach (Product prod in cheapProd)
                Console.WriteLine($"Product: {prod.Name}, with price: {prod.Price}");
            Console.WriteLine("***********************");
        }

        public static void MyList()
        {
            List<int> numbers = new List<int>() { 10, 5, 15, 3, 9,25,18 };

            numbers.Sort();

            foreach (int number in numbers)
                Console.Write(number + " ");
            Console.WriteLine();
            Console.WriteLine("***********************");
        }

        public static void MyLambda()
        {
            List<int> numbers = new List<int>() { 10, 5, 15, 3, 9, 25, 18 };
            Predicate<int> equalTenOrHigher = x => x >= 10;

            foreach(int number in numbers.FindAll(equalTenOrHigher))
                Console.Write(number + " ");
            Console.WriteLine();
            Console.WriteLine("***********************");
                        
            Predicate<int> lessThanTen = LessThanTen;

            foreach (int number in numbers.FindAll(lessThanTen))
                Console.Write(number + " ");
            Console.WriteLine();
            Console.WriteLine("***********************");

            bool hasLargeNumber = numbers.Any(x => x > 20);
            if(hasLargeNumber)
                Console.WriteLine("There are large numbers in the list!");
            else
                Console.WriteLine("There are not large numbers in the list!");
            Console.WriteLine("***********************");
        }

        public static bool LessThanTen(int x)
        {
            return x < 10;
        }
    }
}
