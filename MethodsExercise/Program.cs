namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string? name = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            string? color = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            string? animal = Console.ReadLine();

            Console.WriteLine("What is your favorite band?");
            string? band = Console.ReadLine();

            Console.WriteLine($"Hello, my name is {name} and my favorite color is {color} I like listening to {band} with my {animal}.");

        }
    }
}
