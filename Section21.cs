using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    internal class Section21
    {
        public static void App()
        {
            Box<int> intBox = new Box<int>();
            intBox.Content = 1;
            Console.WriteLine(intBox.Log());
            Console.WriteLine("***********************");

            Box<string> strBox = new Box<string>();
            strBox.Content = "Hello World!";
            Console.WriteLine(strBox.Log());
            Console.WriteLine("***********************");
        }
    }

    internal class Box<T>
    {
        public T Content { get; set; }

        public string Log()
        {
            return $"Box contains {Content}";
        }
    }
}
