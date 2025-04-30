using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    internal class Section7
    {
        public static void divideByZero()
        {
            int num1 = 0;
            int num2 = 5;
            try
            {
                Console.WriteLine($"Sum {num2} / {num1} = {num2 / num1}");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Thanks for trying!");
            }
        }
    }
}
