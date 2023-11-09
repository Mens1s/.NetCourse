
namespace console_programming // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();


            Console.Write("Enter your surname: ");
            string surname = Console.ReadLine();

            Console.WriteLine("Hello " + name + " " + surname + "!");
        }
    }
}