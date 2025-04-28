namespace CSharpTraining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Start of program
            Section5 myCar1 = new Section5("BMW", "i7");
            Section5 myCar2 = new Section5("Audi", "A3");
            Section5 myCar3 = new Section5("Porsche", "Carrera");

            Console.WriteLine($"Car 1 is a {myCar1.Brand}/{myCar1.Model} with id: {myCar1.Id}");
            Console.WriteLine($"Car 2 is a {myCar2.Brand}/{myCar2.Model} with id: {myCar2.Id}");
            Console.WriteLine($"Car 3 is a {myCar3.Brand}/{myCar3.Model} with id: {myCar3.Id}");

            Console.ReadKey();
        }
    }
}
