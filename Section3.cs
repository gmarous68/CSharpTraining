using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CSharpTraining
{
    class Section3
    {
        public static void App() {
            //for (int i = 10; i > 0; i--)
            //{
            //    Console.WriteLine("T-minus " + i + " seconds..");
            //    Thread.Sleep(1000);
            //}            

            //int[] intArray = new int[5];
            //for (int i = 1; i <= intArray.Length; i++)
            //    intArray[i-1] = i + 100;

            //foreach (int num in intArray)
            //    Console.Write(num + " ");
            //Console.WriteLine();

            //int[] intArray = { 110, 120, 130, 140, 150 };
            //foreach (var num in intArray)
            //    Console.Write(num + " ");

            int[,] intArray1 = new int[3,5];
            int[][] intArray2 = new int[3][] { new int[3] { 1, 2, 3 }, new int[3] { 4, 5, 6 }, new int[3] { 7, 8, 9 } };            

            for (int i = 0; i < intArray1.GetLength(0); i++)
            {
                for (int k = 0; k < intArray1.GetLength(1); k++)
                    intArray1[i, k] = (i + k);
            }
            for (int i = 0; i < intArray1.GetLength(0); i++)
            {
                for (int k = 0; k < intArray1.GetLength(1); k++)
                    Console.Write(intArray1[i,k] + " ");
                Console.WriteLine();
            }
            Console.WriteLine("*********************");

            foreach (int[] intRow in intArray2)
            {
                foreach (int element in intRow)
                    Console.Write(element + " ");
                Console.WriteLine();
            }
            
            Console.ReadKey();
        }        
    }
}
