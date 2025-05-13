using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    public interface IAnimal
    {
        public void MakeSound();
        public void Eat(string food);  
    }

    internal class Section9 : IAnimal
    {
        public void Eat(string food)
        {
            Console.WriteLine($"Dog is eating {food}!");
        }

        public void MakeSound()
        {
            Console.WriteLine("Dog is barking!");
        }
    }
}
