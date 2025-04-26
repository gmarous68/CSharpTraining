namespace CSharpTraining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Start of program
            Section5 myCar1 = new Section5("BMW", "i7");
            Section5 myCar2 = new Section5("Audi", "A3");

            Console.WriteLine($"Car 1 is a {myCar1.Brand}/{myCar1.Model}.");
            Console.WriteLine($"Car 2 is a {myCar2.Brand}/{myCar2.Model}.");

            Console.ReadKey();
        }
    }
}
