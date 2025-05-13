using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    internal class App
    {
        public static void FizzB() { 
            int n = 20;            

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0)
                    Console.WriteLine("Fizz");                
                else if (i % 5 == 0)
                    Console.WriteLine("Buzz");                
                else
                    Console.WriteLine(i);    
            }
        }

        public static void Reverse()
        {
            Console.WriteLine("**********************");
            Console.WriteLine("Type in a string: ");
            string text = Console.ReadLine();

            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            foreach(char c in charArray) { 
                Console.Write(c); 
            }
        }
    }
}
