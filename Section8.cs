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
            //Dog donna = new Dog();
            //donna.Eat();
            //donna.Bark();
            Employee emp = new Employee(78, "Marlon Brando");
            emp.DisplayPersonInfo();
        }

        public class Person
        {
            public string Name { get; private set; }
            public int Age { get; private set; }

            public Person(int age, string name)
            {
                Name = name;
                Age = age;
                Console.WriteLine("Person Constructor.");
            }

            public void DisplayPersonInfo()
            {
                Console.WriteLine($"Name: {Name}, Age: {Age}");
            }
        }

        public class Employee : Person
        {
            public Employee(int age, string name) : base(age, name)
            {
                Console.WriteLine("Employee Constructor.");
            }
        }

        class Animal
        {
            public virtual void Eat()
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
            public override void Eat()
            {
                Console.WriteLine("Dog is eating..");
            }
        }
    }
}