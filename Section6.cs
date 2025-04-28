using DocumentFormat.OpenXml.Drawing;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    class Section6
    {
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
        }

        public static bool LessThanTen(int x)
        {
            return x < 10;
        }
    }
}
