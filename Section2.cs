using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CSharpTraining
{
    class Section2
    {
        public static void App()
        {
            int num;

            Console.WriteLine("Type in a number: " );
            string numString = Console.ReadLine();
            bool isNum = int.TryParse(numString, out num);
            if(isNum)
                Console.WriteLine("OK - it's a number");
            else
                Console.WriteLine("NOT OK - it's not a number");
            Console.WriteLine("*********************************");

            Console.ReadKey();
        }
        
    }
}
