namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            var stopsign = Console.ReadLine(); 
            Console.WriteLine($"{Environment.NewLine}What's next after {stopsign}");
            var name = Console.ReadLine();
            var currentDate = DateTime.Now;
            Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d}, at {currentDate:t}");
            Console.WriteLine($"{Environment.NewLine}Press any key to exit darling :)");
            



        }
    }
}
