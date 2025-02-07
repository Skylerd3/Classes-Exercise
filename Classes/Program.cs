namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var CarOne = new Car();
            CarOne.make = "Jeep";
            CarOne.model = "Wrangler";
            CarOne.year = 2022;

            Console.WriteLine($"This car is a {CarOne.year} {CarOne.make} {CarOne.model}!");

        }
    }
}
