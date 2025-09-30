namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            var name = Console.ReadLine(); 
            Console.WriteLine($"{Environment.NewLine}Ok, your name is {name}");
            var currentDate = DateTime.Now;
            Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d}, at {currentDate:t}");
            Console.WriteLine($"{Environment.NewLine}Press any key to exit darling :)");
        }
    }
}
