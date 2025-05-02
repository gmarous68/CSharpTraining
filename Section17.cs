using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Wordprocessing;

namespace CSharpTraining
{
    internal class Section17
    {
        public static void App()
        {
            int[] numbers = new int[] { 1, 15, 16, 77, 32, 33, 99, 54, 23, 81, 19 };
            OddNumber(numbers);
        }

        public static void OddNumber(int[] numbers)
        {
            Console.WriteLine("Odd numbers..");

            IEnumerable<int> oddNumbers = from number in numbers                                          
                                          where number % 2 != 0
                                          orderby number descending
                                          select number;
            foreach (int number in oddNumbers)
                Console.Write(number + " ");
            Console.WriteLine();
        }
    }
}
