using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    internal class Section8
    {
        public static void App() 
        { 
            Dog donna = new Dog();
            donna.Eat();
            donna.Bark();
        }
    }

    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating..");
        }
    }

    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Barking..");
        }
    }
}