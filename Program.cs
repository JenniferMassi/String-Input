namespace Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("What is your name?");
            string what = Console.ReadLine();

            Console.WriteLine("Hello, " + what + " Where do you live?");
            string location = "";
            location = Console.ReadLine();

            Console.WriteLine("Wow! That's GREAT" + location + " sounds like a fun place to live! What car do you drive?");
            string car = "";
            car = Console.ReadLine();

            Console.WriteLine("I love those cars!");

        }
    }
}