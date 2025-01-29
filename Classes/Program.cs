namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var carOne = new Car();
            carOne.make = "Jeep";
            carOne.model = "Wrangler";
            carOne.year = 2022;

            Console.WriteLine($"This car is a {carOne.year} {carOne.make} {carOne.model}!");

        }
    }
}
