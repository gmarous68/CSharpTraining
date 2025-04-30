using CSharpTraining;
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

        public Product(string name, double price) 
        { 
            Name = name;
            Price = price;
        }
    }

    class Section6
    {
        public static void Dict()
        {
            Dictionary<int, string> empl = new Dictionary<int, string>();
            empl.Add(101, "John Doe");
            empl.Add(102, "Bob Smith");
            empl.Add(103, "Willy Jackson");
            empl.Add(104, "Donald Trumph");
            empl.Add(105, "Barack Obama");      

            Console.WriteLine(empl[101]);
            Console.WriteLine("***********************");

            empl[102] = "Jane Smith";
            Console.WriteLine(empl[102]);
            Console.WriteLine("***********************");

            empl.Remove(103);
            foreach (KeyValuePair<int, string> employee in empl)
                Console.WriteLine($"EmployeeID: {employee.Key} is {employee.Value}.");
            Console.WriteLine("***********************");

            // Duplicates
            if (!empl.ContainsKey(103))
                empl.Add(103, "Jesus Christ");
            // Or..
            if (empl.TryAdd(103, "Jesus Christ"))
                Console.WriteLine("Added 103 - Jesus Christ");
            else
                Console.WriteLine("Not added");
            Console.WriteLine("***********************");

            Dictionary<int, Product> products = new Dictionary<int, Product>();
            products.Add(1, new Product("Apple", 0.59));
            products.Add(2, new Product("Toothbrush", 1.59));
            products.Add(3, new Product("Butter", 2.09));
            products.Add(4, new Product("Cheese", 21.51));

            foreach(var product in products)
                Console.WriteLine($"ID:{product.Key}: {product.Value.Name} ${product.Value.Price}");
        }

        public static void App()
        {
            // nullable variable
            int? num = null;
            if(num.HasValue)
                Console.WriteLine(num);
            else
                Console.WriteLine("No Value");
            Console.WriteLine("***********************");
        }

        public static void Product()
        {
            List<Product> products = new List<Product>();

            products.Add(new Product("Bananas", 0.30));
            products.Add(new Product("Berries", 2.99));
            products.Add(new Product("Apples", 1.99));
            products.Add(new Product("Grapes", 0.70));
            products.Add(new Product("Orange", 1.99));
            products.Add(new Product("Blueberry", 0.09));

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
