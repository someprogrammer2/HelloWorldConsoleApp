namespace HelloWorldConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            SayHello("Oleg");
        }

        static void SayHello(string name)
        {
            Console.WriteLine($"Hello, {name}");
        }

    }
}