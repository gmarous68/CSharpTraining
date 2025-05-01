using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    internal class Section7
    {
        public static void divideByZero()
        {
            int num1, num2;
            try
            {
                Console.WriteLine("Enter a number: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter another number: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Sum {num1} / {num2} = {num1 / num2}");
                
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                Debug.WriteLine(e.StackTrace);
            }
            catch(Exception e)
            {
                Console.WriteLine("Different error..");
                Debug.WriteLine(e.StackTrace);
            }
            finally
            {
                Console.WriteLine("Thanks for trying!");                
            }
        }
    }
}
